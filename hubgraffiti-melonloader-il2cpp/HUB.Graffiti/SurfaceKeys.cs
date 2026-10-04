using System;
using System.Collections.Generic;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppScheduleOne.Graffiti;
using Il2CppScheduleOne.Vehicles;
using UnityEngine;
using Object = UnityEngine.Object;

namespace HUB.Graffiti
{
	/// <summary>
	/// Stable identifiers for spray surfaces, valid across reloads and the same on every player's machine.
	/// World spots use their WorldSpraySurface GUID. Vehicle panels (e.g. the sides of a van) have no GUID of
	/// their own, so they're keyed by the vehicle's GUID plus the panel's index in LandVehicle._spraySurfaces,
	/// which is the order the game itself saves them in OwnedVehicles.json: "vehicle:&lt;guid&gt;:&lt;index&gt;".
	/// </summary>
	internal static class SurfaceKeys
	{
		private const string VehiclePrefix = "vehicle:";

		internal static bool IsVehicleKey(string key)
		{
			return key != null && key.StartsWith(VehiclePrefix, StringComparison.OrdinalIgnoreCase);
		}

		/// <summary>The surface's key, or "" if it is neither a world spot nor part of a vehicle.</summary>
		internal static string GetKey(SpraySurface surface)
		{
			if (surface == null)
			{
				return "";
			}
			WorldSpraySurface world = surface.TryCast<WorldSpraySurface>();
			if (world != null)
			{
				return GetGuid(world);
			}
			return FindVehicleSlot(surface, out LandVehicle vehicle, out int index) ? VehicleKey(vehicle, index) : "";
		}

		/// <summary>Short location text for the menu, e.g. "Northtown" or "Veeper (left side)".</summary>
		internal static string Describe(SpraySurface surface)
		{
			try
			{
				WorldSpraySurface world = surface.TryCast<WorldSpraySurface>();
				if (world != null)
				{
					return world.Region.ToString();
				}
				if (FindVehicleSlot(surface, out LandVehicle vehicle, out _))
				{
					string name = vehicle.VehicleName;
					if (string.IsNullOrEmpty(name))
					{
						name = vehicle.VehicleCode;
					}
					float side = vehicle.transform.InverseTransformPoint(surface.transform.position).x;
					return name + (side < 0f ? " (left side)" : " (right side)");
				}
			}
			catch
			{
			}
			return "";
		}

		/// <summary>Every keyed surface currently in the scene: world spots and all vehicle panels.</summary>
		internal static Dictionary<string, SpraySurface> FindAll()
		{
			Dictionary<string, SpraySurface> result = new Dictionary<string, SpraySurface>(StringComparer.OrdinalIgnoreCase);
			try
			{
				Il2CppArrayBase<WorldSpraySurface> worlds = Object.FindObjectsOfType<WorldSpraySurface>();
				if (worlds != null)
				{
					for (int i = 0; i < worlds.Count; i++)
					{
						WorldSpraySurface world = worlds[i];
						string guid = world != null ? GetGuid(world) : "";
						if (!string.IsNullOrEmpty(guid))
						{
							result[guid] = world;
						}
					}
				}
			}
			catch (Exception ex)
			{
				DebugLog.Log("Surfaces", "World surface scan failed: " + ex.Message);
			}

			try
			{
				Il2CppArrayBase<LandVehicle> vehicles = Object.FindObjectsOfType<LandVehicle>();
				if (vehicles != null)
				{
					for (int v = 0; v < vehicles.Count; v++)
					{
						LandVehicle vehicle = vehicles[v];
						Il2CppReferenceArray<SpraySurface> panels = GetPanels(vehicle);
						if (panels == null)
						{
							continue;
						}
						for (int i = 0; i < panels.Count; i++)
						{
							if (panels[i] != null)
							{
								result[VehicleKey(vehicle, i)] = panels[i];
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				DebugLog.Log("Surfaces", "Vehicle surface scan failed: " + ex.Message);
			}
			return result;
		}

		private static bool FindVehicleSlot(SpraySurface surface, out LandVehicle vehicle, out int index)
		{
			index = -1;
			vehicle = null;
			try
			{
				// Panels are normally children of their vehicle; fall back to scanning every vehicle.
				vehicle = surface.GetComponentInParent<LandVehicle>();
				if (vehicle != null && (index = IndexOf(GetPanels(vehicle), surface)) >= 0)
				{
					return true;
				}
				Il2CppArrayBase<LandVehicle> vehicles = Object.FindObjectsOfType<LandVehicle>();
				for (int v = 0; vehicles != null && v < vehicles.Count; v++)
				{
					vehicle = vehicles[v];
					if (vehicle != null && (index = IndexOf(GetPanels(vehicle), surface)) >= 0)
					{
						return true;
					}
				}
			}
			catch (Exception ex)
			{
				DebugLog.Log("Surfaces", "Vehicle lookup failed: " + ex.Message);
			}
			vehicle = null;
			index = -1;
			return false;
		}

		private static int IndexOf(Il2CppReferenceArray<SpraySurface> panels, SpraySurface surface)
		{
			if (panels == null)
			{
				return -1;
			}
			for (int i = 0; i < panels.Count; i++)
			{
				if (panels[i] != null && panels[i].Pointer == surface.Pointer)
				{
					return i;
				}
			}
			return -1;
		}

		private static Il2CppReferenceArray<SpraySurface> GetPanels(LandVehicle vehicle)
		{
			try
			{
				return vehicle != null ? vehicle._spraySurfaces : null;
			}
			catch
			{
				return null;
			}
		}

		private static string VehicleKey(LandVehicle vehicle, int index)
		{
			return VehiclePrefix + vehicle.GUID.ToString() + ":" + index;
		}

		private static string GetGuid(WorldSpraySurface surface)
		{
			try
			{
				return surface.GUID.ToString() ?? "";
			}
			catch
			{
				return "";
			}
		}
	}
}
