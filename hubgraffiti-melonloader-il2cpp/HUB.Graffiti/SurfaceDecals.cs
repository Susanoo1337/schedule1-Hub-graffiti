using System;
using System.Collections.Generic;
using System.Linq;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppScheduleOne.Graffiti;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using Object = UnityEngine.Object;

namespace HUB.Graffiti
{
	/// <summary>
	/// Puts sticker images on spray surfaces' decal projectors, and remembers everything it changed
	/// (material, drawing texture, hidden outline objects) so a sticker can be taken off again.
	/// </summary>
	internal static class SurfaceDecals
	{
		/// <summary>Share of the sprayable area the sticker may cover (the rest is margin).</summary>
		private const float StickerFill = 0.8f;
		private const int HardMaxTextureSize = 8192;
		private const int FallbackDrawingSize = 512;
		private const string ProjectorObjectName = "Projector";

		private sealed class Applied
		{
			public string Key = "";
			public string StickerName = "";
			public string RegionName = "";
			public SpraySurface Surface;
			public Material Material;
			public Texture2D DecalTexture;
			public Texture2D DrawingTexture;
			public bool CapturedOriginals;
			public Material OriginalMaterial;
			public Texture2D OriginalOutputTexture;
			public readonly List<GameObject> HiddenObjects = new List<GameObject>();
			public readonly List<Renderer> HiddenRenderers = new List<Renderer>();
			public readonly List<Canvas> HiddenCanvases = new List<Canvas>();
		}

		/// <summary>Where the sprayable area sits inside the projector, in the projector's UV space.</summary>
		private struct Layout
		{
			public float CenterU;
			public float CenterV;
			public float AreaU;
			public float AreaV;
			public float SizeX;
			public float SizeY;
		}

		private static readonly Dictionary<string, Applied> _applied = new Dictionary<string, Applied>(StringComparer.OrdinalIgnoreCase);

		internal static IEnumerable<string> AppliedKeys => _applied.Keys.ToList();

		internal static bool IsApplied(string key)
		{
			return !string.IsNullOrEmpty(key) && _applied.ContainsKey(key);
		}

		internal static string GetRegionName(string key)
		{
			return !string.IsNullOrEmpty(key) && _applied.TryGetValue(key, out Applied entry) ? entry.RegionName : "";
		}

		/// <summary>
		/// Shows <paramref name="sticker"/> on <paramref name="surface"/>. Calling it again with the same
		/// sticker only re-asserts the material and hidden outline, so it's cheap to repeat after the game
		/// has had a chance to touch the projector. <paramref name="rebuild"/> forces new textures, e.g.
		/// after the resolution setting changed.
		/// </summary>
		internal static bool Apply(SpraySurface surface, string key, StickerData sticker, bool rebuild = false)
		{
			if (surface == null || string.IsNullOrEmpty(key) || sticker == null || sticker.Texture == null)
			{
				return false;
			}

			if (_applied.TryGetValue(key, out Applied entry) && (entry.Surface == null || entry.Surface.Pointer != surface.Pointer))
			{
				// Same GUID on a different object means the old one is gone (scene reload); start over.
				ForgetAssets(entry);
				_applied.Remove(key);
				entry = null;
			}
			if (entry == null)
			{
				entry = new Applied { Key = key, Surface = surface };
				try
				{
					WorldSpraySurface world = surface.TryCast<WorldSpraySurface>();
					entry.RegionName = world != null ? world.Region.ToString() : "";
				}
				catch
				{
				}
				_applied[key] = entry;
			}

			if (rebuild || entry.DecalTexture == null || !string.Equals(entry.StickerName, sticker.Name, StringComparison.OrdinalIgnoreCase))
			{
				Texture2D oldDecal = entry.DecalTexture;
				Texture2D oldDrawing = entry.DrawingTexture;
				try
				{
					BuildTextures(entry, surface, sticker);
				}
				catch (Exception ex)
				{
					DebugLog.Log("Decals", "Texture build failed for " + key + ": " + ex.Message + "\n" + ex.StackTrace);
					return false;
				}
				entry.StickerName = sticker.Name;
				AssignToGame(entry, true);
				// Only now nothing references the previous textures any more.
				SafeDestroy(oldDecal);
				SafeDestroy(oldDrawing);
			}
			else
			{
				AssignToGame(entry, false);
			}
			HideOutline(entry);
			return true;
		}

		/// <summary>Re-applies every sticker's material in case the game swapped it back.</summary>
		internal static void ReassertAll()
		{
			foreach (Applied entry in _applied.Values.ToList())
			{
				if (entry.Surface == null)
				{
					ForgetAssets(entry);
					_applied.Remove(entry.Key);
					continue;
				}
				AssignToGame(entry, false);
				HideOutline(entry);
			}
		}

		/// <summary>
		/// Takes the sticker off: restores the original material and drawing texture, shows the surface's
		/// outline again and (optionally) asks the game to clear the drawing and make the surface editable.
		/// </summary>
		internal static bool Remove(string key, bool resetGameSurface)
		{
			if (string.IsNullOrEmpty(key) || !_applied.TryGetValue(key, out Applied entry))
			{
				return false;
			}
			_applied.Remove(key);
			SpraySurface surface = entry.Surface;
			bool surfaceAlive = surface != null;
			bool drawingStillOurs = false;

			if (surfaceAlive)
			{
				foreach (GameObject go in entry.HiddenObjects)
				{
					try
					{
						if (go != null)
						{
							go.SetActive(true);
						}
					}
					catch
					{
					}
				}
				foreach (Renderer renderer in entry.HiddenRenderers)
				{
					try
					{
						if (renderer != null)
						{
							renderer.enabled = true;
						}
					}
					catch
					{
					}
				}
				foreach (Canvas canvas in entry.HiddenCanvases)
				{
					try
					{
						if (canvas != null)
						{
							canvas.enabled = true;
						}
					}
					catch
					{
					}
				}

				try
				{
					DecalProjector projector = surface.Projector;
					if (projector != null && entry.OriginalMaterial != null && projector.material == entry.Material)
					{
						projector.material = entry.OriginalMaterial;
						Refresh(projector);
					}
				}
				catch (Exception ex)
				{
					DebugLog.Log("Decals", "Material restore failed: " + ex.Message);
				}

				try
				{
					Drawing drawing = surface.drawing;
					if (drawing != null && entry.DrawingTexture != null && drawing.OutputTexture == entry.DrawingTexture)
					{
						if (entry.OriginalOutputTexture != null)
						{
							SetOutputTexture(drawing, entry.OriginalOutputTexture);
						}
						else
						{
							drawingStillOurs = true;
						}
					}
				}
				catch (Exception ex)
				{
					DebugLog.Log("Decals", "Drawing restore failed: " + ex.Message);
				}

				if (resetGameSurface)
				{
					ResetGameSurface(surface);
					try
					{
						if (drawingStillOurs && surface.drawing != null && surface.drawing.OutputTexture != entry.DrawingTexture)
						{
							drawingStillOurs = false;
						}
					}
					catch
					{
					}
				}
			}

			SafeDestroy(entry.Material);
			SafeDestroy(entry.DecalTexture);
			// If the game's drawing still points at our texture, leave it alive rather than hand the game a dead one.
			if (!drawingStillOurs)
			{
				SafeDestroy(entry.DrawingTexture);
			}
			DebugLog.Log("Decals", "Removed sticker from " + key + (surfaceAlive ? "" : " (surface no longer exists)"));
			return true;
		}

		/// <summary>Drops all tracking on scene change. Scene objects are going away; our own assets are destroyed.</summary>
		internal static void ResetAll()
		{
			foreach (Applied entry in _applied.Values)
			{
				ForgetAssets(entry);
			}
			_applied.Clear();
		}

		// ---- Texture baking ----

		private static void BuildTextures(Applied entry, SpraySurface surface, StickerData sticker)
		{
			Texture2D source = sticker.Texture;
			int srcW = source.width;
			int srcH = source.height;
			Color32[] srcPixels = source.GetPixels32();

			Layout layout = ComputeLayout(surface);
			Rect uv = StickerUvRect(layout, srcW, srcH);

			// High-resolution texture for the projector: sized so the sticker gets up to the configured
			// number of pixels along its long side (never more than the PNG itself has).
			int target = Math.Min(Math.Max(srcW, srcH), GraffitiMod.MaxStickerResolution);
			int maxSize = Math.Min(HardMaxTextureSize, Math.Max(1024, SystemInfo.maxTextureSize));
			ComputeDecalSize(layout, uv, target, maxSize, out int decalW, out int decalH);
			entry.DecalTexture = Render(srcPixels, srcW, srcH, decalW, decalH, uv, true, "HUB_StickerDecal_" + sticker.Name);

			// Drawing-sized copy handed to the game's Drawing, matching what the game itself would hold.
			int drawW = FallbackDrawingSize;
			int drawH = FallbackDrawingSize;
			try
			{
				surface.EnsureDrawingExists();
				Drawing drawing = surface.drawing;
				if (drawing != null)
				{
					if (drawing.TextureWidth > 0)
					{
						drawW = drawing.TextureWidth;
					}
					if (drawing.TextureHeight > 0)
					{
						drawH = drawing.TextureHeight;
					}
				}
			}
			catch (Exception ex)
			{
				DebugLog.Log("Decals", "Drawing size error: " + ex.Message);
			}
			entry.DrawingTexture = Render(srcPixels, srcW, srcH, drawW, drawH, uv, false, "HUB_StickerDrawing_" + sticker.Name);

			DebugLog.Log("Decals", "Baked '" + sticker.Name + "' (" + srcW + "x" + srcH + ") -> decal " + decalW + "x" + decalH
				+ ", drawing " + drawW + "x" + drawH + ", uv=(" + uv.x.ToString("F3") + "," + uv.y.ToString("F3") + " "
				+ uv.width.ToString("F3") + "x" + uv.height.ToString("F3") + ")");
		}

		private static Texture2D Render(Color32[] src, int srcW, int srcH, int width, int height, Rect uv, bool forProjector, string name)
		{
			Color32[] pixels = new Color32[width * height];
			StickerRaster.DrawScaled(src, srcW, srcH, pixels, width, height, uv.x * width, uv.y * height, uv.width * width, uv.height * height);
			if (forProjector)
			{
				StickerRaster.FillTransparentWithAverage(pixels);
			}

			Texture2D texture = new Texture2D(width, height, TextureFormat.RGBA32, forProjector);
			texture.name = name;
			texture.wrapMode = TextureWrapMode.Clamp;
			texture.filterMode = forProjector ? FilterMode.Trilinear : FilterMode.Bilinear;
			if (forProjector)
			{
				texture.anisoLevel = 4;
			}
			texture.SetPixels32(pixels);
			// The projector copy is GPU-only; dropping the CPU copy halves its memory. The drawing copy stays
			// readable because the game may read its own drawing texture back.
			texture.Apply(forProjector, forProjector);
			return texture;
		}

		private static Layout ComputeLayout(SpraySurface surface)
		{
			Layout layout = new Layout
			{
				CenterU = 0.5f,
				CenterV = 0.5f,
				AreaU = 0.5f,
				AreaV = 0.5f,
				SizeX = 1f,
				SizeY = 1f
			};
			try
			{
				DecalProjector projector = surface.Projector;
				Transform bottomLeft = surface.BottomLeftPoint;
				if (projector == null || bottomLeft == null)
				{
					DebugLog.Log("Decals", "Projector or BottomLeftPoint missing, using centred fallback layout");
					return layout;
				}
				Vector3 size = projector.size;
				if (size.x <= 0f || size.y <= 0f)
				{
					return layout;
				}
				Vector3 pivot = projector.pivot;
				float pixelSize = SpraySurface.PIXEL_SIZE;
				float surfaceW = surface.Width * pixelSize;
				float surfaceH = surface.Height * pixelSize;
				Vector3 local = projector.transform.InverseTransformPoint(bottomLeft.position);
				float u0 = (local.x - pivot.x) / size.x + 0.5f;
				float v0 = (local.y - pivot.y) / size.y + 0.5f;
				layout.SizeX = size.x;
				layout.SizeY = size.y;
				layout.AreaU = surfaceW / size.x;
				layout.AreaV = surfaceH / size.y;
				layout.CenterU = u0 + layout.AreaU * 0.5f;
				layout.CenterV = v0 + layout.AreaV * 0.5f;
			}
			catch (Exception ex)
			{
				DebugLog.Log("Decals", "Geometry calc error: " + ex.Message);
			}
			return layout;
		}

		// The sticker's rectangle in projector UV, fitted into the sprayable area with its aspect ratio
		// preserved in world space (so it isn't stretched when the projector isn't square).
		private static Rect StickerUvRect(Layout layout, int srcW, int srcH)
		{
			float areaWorldW = Math.Abs(layout.AreaU) * layout.SizeX * StickerFill;
			float areaWorldH = Math.Abs(layout.AreaV) * layout.SizeY * StickerFill;
			float scale = Math.Min(areaWorldW / srcW, areaWorldH / srcH);
			float w = srcW * scale / layout.SizeX;
			float h = srcH * scale / layout.SizeY;
			return new Rect(layout.CenterU - w * 0.5f, layout.CenterV - h * 0.5f, w, h);
		}

		private static void ComputeDecalSize(Layout layout, Rect uv, int target, int maxSize, out int width, out int height)
		{
			float stickerWorldW = uv.width * layout.SizeX;
			float stickerWorldH = uv.height * layout.SizeY;
			float texel = Math.Max(stickerWorldW, stickerWorldH) / Math.Max(1, target);
			float w = layout.SizeX / texel;
			float h = layout.SizeY / texel;
			float longest = Math.Max(w, h);
			if (longest > maxSize)
			{
				w *= maxSize / longest;
				h *= maxSize / longest;
			}
			width = Mathf.Clamp(Mathf.CeilToInt(w), 4, maxSize);
			height = Mathf.Clamp(Mathf.CeilToInt(h), 4, maxSize);
		}

		// ---- Applying to the game objects ----

		private static void AssignToGame(Applied entry, bool texturesChanged)
		{
			SpraySurface surface = entry.Surface;
			try
			{
				surface.EnsureDrawingExists();
				Drawing drawing = surface.drawing;
				if (drawing != null)
				{
					if (!entry.CapturedOriginals)
					{
						Texture2D current = drawing.OutputTexture;
						entry.OriginalOutputTexture = current != null && !(current.name ?? "").StartsWith("HUB_") ? current : null;
					}
					if (drawing.OutputTexture != entry.DrawingTexture)
					{
						SetOutputTexture(drawing, entry.DrawingTexture);
					}
				}
			}
			catch (Exception ex)
			{
				DebugLog.Log("Decals", "Drawing assign error: " + ex.Message);
			}

			DecalProjector projector;
			try
			{
				projector = surface.Projector;
			}
			catch
			{
				projector = null;
			}
			if (projector == null)
			{
				DebugLog.Log("Decals", "Projector is null for " + entry.Key);
				entry.CapturedOriginals = true;
				return;
			}

			try
			{
				if (!entry.CapturedOriginals)
				{
					Material current = projector.material;
					entry.OriginalMaterial = current != null && !(current.name ?? "").StartsWith("HUB_") ? current : null;
				}
				entry.CapturedOriginals = true;

				if (entry.Material == null)
				{
					Material template = entry.OriginalMaterial ?? projector.material;
					if (template == null)
					{
						DebugLog.Log("Decals", "Projector has no material to copy for " + entry.Key);
						return;
					}
					entry.Material = new Material(template);
					entry.Material.name = "HUB_StickerDecal";
					texturesChanged = true;
				}
				if (texturesChanged)
				{
					SetMaterialTextures(entry.Material, entry.DecalTexture);
				}

				bool changed = texturesChanged || projector.material != entry.Material;
				if (projector.material != entry.Material)
				{
					projector.material = entry.Material;
				}
				projector.fadeFactor = 1f;
				if (changed)
				{
					Refresh(projector);
					try
					{
						surface.CacheDrawing();
					}
					catch
					{
					}
				}
				else if (!projector.enabled)
				{
					projector.enabled = true;
				}
			}
			catch (Exception ex)
			{
				DebugLog.Log("Decals", "Projector assign error: " + ex.Message);
			}
		}

		// The decal shader's texture slots aren't named consistently across game versions, so fill every
		// texture slot except normal maps and Unity's built-ins.
		private static void SetMaterialTextures(Material material, Texture2D texture)
		{
			try
			{
				material.SetTexture("_Base_Map", texture);
			}
			catch
			{
			}
			try
			{
				material.mainTexture = texture;
			}
			catch
			{
			}
			Shader shader = material.shader;
			if (shader == null)
			{
				return;
			}
			try
			{
				int count = shader.GetPropertyCount();
				for (int i = 0; i < count; i++)
				{
					try
					{
						if (shader.GetPropertyType(i) != ShaderPropertyType.Texture)
						{
							continue;
						}
						string name = shader.GetPropertyName(i);
						if (name.StartsWith("unity_") || name.IndexOf("Normal", StringComparison.OrdinalIgnoreCase) >= 0)
						{
							continue;
						}
						material.SetTexture(name, texture);
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
		}

		private static void SetOutputTexture(Drawing drawing, Texture2D texture)
		{
			try
			{
				drawing.OutputTexture = texture;
			}
			catch
			{
			}
			try
			{
				drawing._OutputTexture_k__BackingField = texture;
			}
			catch
			{
			}
		}

		private static void Refresh(DecalProjector projector)
		{
			projector.enabled = false;
			projector.enabled = true;
		}

		/// <summary>
		/// Hides the surface's spray-area outline/prompt like the game does for finished graffiti.
		/// Records what it hides so <see cref="Remove"/> can bring it back. Safe to call repeatedly.
		/// </summary>
		private static void HideOutline(Applied entry)
		{
			try
			{
				GameObject root = entry.Surface.gameObject;
				if (root == null)
				{
					return;
				}
				DecalProjector projector = null;
				try
				{
					projector = entry.Surface.Projector;
				}
				catch
				{
				}
				Transform projectorTransform = projector != null ? projector.transform : null;

				Transform rootTransform = root.transform;
				for (int i = 0; i < rootTransform.childCount; i++)
				{
					try
					{
						Transform child = rootTransform.GetChild(i);
						if (child == null || child.name == ProjectorObjectName)
						{
							continue;
						}
						// Never deactivate a branch the projector lives in, or the sticker disappears with it.
						if (projectorTransform != null && projectorTransform.IsChildOf(child))
						{
							continue;
						}
						GameObject go = child.gameObject;
						if (go.activeSelf)
						{
							go.SetActive(false);
							entry.HiddenObjects.Add(go);
						}
					}
					catch
					{
					}
				}

				Il2CppArrayBase<Renderer> renderers = root.GetComponentsInChildren<Renderer>(true);
				if (renderers != null)
				{
					for (int i = 0; i < renderers.Count; i++)
					{
						try
						{
							Renderer renderer = renderers[i];
							if (renderer != null && renderer.enabled && renderer.gameObject.name != ProjectorObjectName)
							{
								renderer.enabled = false;
								entry.HiddenRenderers.Add(renderer);
							}
						}
						catch
						{
						}
					}
				}

				Il2CppArrayBase<Canvas> canvases = root.GetComponentsInChildren<Canvas>(true);
				if (canvases != null)
				{
					for (int i = 0; i < canvases.Count; i++)
					{
						try
						{
							Canvas canvas = canvases[i];
							if (canvas != null && canvas.enabled)
							{
								canvas.enabled = false;
								entry.HiddenCanvases.Add(canvas);
							}
						}
						catch
						{
						}
					}
				}

				if (projector != null)
				{
					projector.enabled = true;
					projector.fadeFactor = 1f;
				}
			}
			catch (Exception ex)
			{
				DebugLog.Log("Decals", "HideOutline error: " + ex.Message);
			}
		}

		/// <summary>
		/// Best effort at putting the game's own state for the surface back to "never painted" so it can be
		/// sprayed again. The game has no documented API for this, so try the likely method names and log
		/// what exists if none match.
		/// </summary>
		internal static void ResetGameSurface(SpraySurface surface)
		{
			if (surface == null)
			{
				return;
			}
			object target = (object)surface.TryCast<WorldSpraySurface>() ?? surface;
			string used = GameReflection.TryInvokeFirst(target, "ClearDrawing", "ResetDrawing", "ClearSurface", "ResetSurface", "Clear", "Clean", "Erase", "Wipe");
			if (used == null)
			{
				Drawing drawing = null;
				try
				{
					drawing = surface.drawing;
				}
				catch
				{
				}
				used = GameReflection.TryInvokeFirst(drawing, "Clear", "ClearStrokes", "Reset");
				if (used != null)
				{
					used = "Drawing." + used;
				}
			}
			if (used == null)
			{
				GameReflection.LogMethodsOnce(target, "Clear", "Reset", "Clean", "Erase", "Wipe", "Remove", "Restart");
				GameReflection.LogMethodsOnce(surface.drawing, "Clear", "Reset", "Clean", "Erase", "Remove", "Stroke");
				DebugLog.Log("Decals", "No drawing-clear method found; only the sticker visual was removed");
			}
			else
			{
				DebugLog.Log("Decals", "Cleared game drawing via " + used + "()");
			}

			try
			{
				surface.Editable = true;
			}
			catch
			{
			}
		}

		private static void ForgetAssets(Applied entry)
		{
			SafeDestroy(entry.Material);
			SafeDestroy(entry.DecalTexture);
			SafeDestroy(entry.DrawingTexture);
			entry.Material = null;
			entry.DecalTexture = null;
			entry.DrawingTexture = null;
		}

		private static void SafeDestroy(Object obj)
		{
			try
			{
				if (obj != null)
				{
					Object.Destroy(obj);
				}
			}
			catch
			{
			}
		}
	}
}
