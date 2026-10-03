using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine.U2D
{
	// Token: 0x0200031C RID: 796
	public static class SpriteRendererDataAccessExtensions
	{
		// Token: 0x06002D90 RID: 11664 RVA: 0x000ACB84 File Offset: 0x000AAD84
		public static void SetDeformableBuffer(SpriteRenderer spriteRenderer, Unity.Collections.NativeArray<byte> src)
		{
			bool flag = spriteRenderer.sprite == null;
			if (flag)
			{
				throw new ArgumentException(String.Format("spriteRenderer does not have a valid sprite set.", Array.Empty<Object>()));
			}
			bool flag2 = src.Length != SpriteDataAccessExtensions.GetPrimaryVertexStreamSize(spriteRenderer.sprite);
			if (flag2)
			{
				throw new InvalidOperationException(String.Format("custom sprite vertex data size must match sprite asset's vertex data size {0} {1}", src.Length, SpriteDataAccessExtensions.GetPrimaryVertexStreamSize(spriteRenderer.sprite)));
			}
			SpriteRendererDataAccessExtensions.SetDeformableBuffer(spriteRenderer, src.GetUnsafeReadOnlyPtr<byte>(), src.Length);
		}

		// Token: 0x06002D91 RID: 11665 RVA: 0x000ACC14 File Offset: 0x000AAE14
		public static void SetDeformableBuffer(SpriteRenderer spriteRenderer, Unity.Collections.NativeArray<Vector3> src)
		{
			bool flag = spriteRenderer.sprite == null;
			if (flag)
			{
				throw new InvalidOperationException("spriteRenderer does not have a valid sprite set.");
			}
			bool flag2 = src.Length != SpriteDataAccessExtensions.GetVertexCount(spriteRenderer.sprite);
			if (flag2)
			{
				throw new InvalidOperationException(String.Format("The src length {0} must match the vertex count of source Sprite {1}.", src.Length, SpriteDataAccessExtensions.GetVertexCount(spriteRenderer.sprite)));
			}
			SpriteRendererDataAccessExtensions.SetDeformableBuffer(spriteRenderer, src.GetUnsafeReadOnlyPtr<Vector3>(), src.Length);
		}

		// Token: 0x06002D92 RID: 11666 RVA: 0x000ACC98 File Offset: 0x000AAE98
		public static void SetBatchDeformableBufferAndLocalAABBArray(Il2CppReferenceArray<SpriteRenderer> spriteRenderers, Unity.Collections.NativeArray<IntPtr> buffers, Unity.Collections.NativeArray<int> bufferSizes, Unity.Collections.NativeArray<Bounds> bounds)
		{
			int num = spriteRenderers.Length;
			bool flag = num != buffers.Length || num != bufferSizes.Length || num != bounds.Length;
			if (flag)
			{
				throw new ArgumentException("Input array sizes are not the same.");
			}
			SpriteRendererDataAccessExtensions.SetBatchDeformableBufferAndLocalAABBArray(spriteRenderers, buffers.GetUnsafeReadOnlyPtr<IntPtr>(), bufferSizes.GetUnsafeReadOnlyPtr<int>(), bounds.GetUnsafeReadOnlyPtr<Bounds>(), num);
		}

		// Token: 0x06002D93 RID: 11667 RVA: 0x000ACCFC File Offset: 0x000AAEFC
		public unsafe static bool IsUsingDeformableBuffer(SpriteRenderer spriteRenderer, IntPtr buffer)
		{
			return SpriteRendererDataAccessExtensions.IsUsingDeformableBuffer(spriteRenderer, (void*)buffer);
		}

		// Token: 0x06002D94 RID: 11668 RVA: 0x000142E7 File Offset: 0x000124E7
		public static void DeactivateDeformableBuffer(SpriteRenderer renderer)
		{
			SpriteRendererDataAccessExtensions.DeactivateDeformableBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtr(renderer));
		}

		// Token: 0x06002D95 RID: 11669 RVA: 0x000142F9 File Offset: 0x000124F9
		public static void SetLocalAABB(SpriteRenderer renderer, Bounds aabb)
		{
			SpriteRendererDataAccessExtensions.SetLocalAABB_Injected(renderer, ref aabb);
		}

		// Token: 0x06002D96 RID: 11670 RVA: 0x00014303 File Offset: 0x00012503
		public unsafe static void SetDeformableBuffer(SpriteRenderer spriteRenderer, void* src, int count)
		{
			SpriteRendererDataAccessExtensions.SetDeformableBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtr(spriteRenderer), src, count);
		}

		// Token: 0x06002D97 RID: 11671 RVA: 0x00014317 File Offset: 0x00012517
		public unsafe static void SetBatchDeformableBufferAndLocalAABBArray(Il2CppReferenceArray<SpriteRenderer> spriteRenderers, void* buffers, void* bufferSizes, void* bounds, int count)
		{
			SpriteRendererDataAccessExtensions.SetBatchDeformableBufferAndLocalAABBArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtr(spriteRenderers), buffers, bufferSizes, bounds, count);
		}

		// Token: 0x06002D98 RID: 11672 RVA: 0x0001432E File Offset: 0x0001252E
		public unsafe static bool IsUsingDeformableBuffer(SpriteRenderer spriteRenderer, void* buffer)
		{
			return SpriteRendererDataAccessExtensions.IsUsingDeformableBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtr(spriteRenderer), buffer);
		}

		// Token: 0x06002D99 RID: 11673 RVA: 0x00014341 File Offset: 0x00012541
		public static void SetLocalAABB_Injected(SpriteRenderer renderer, ref Bounds aabb)
		{
			SpriteRendererDataAccessExtensions.SetLocalAABB_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(renderer), ref aabb);
		}

		// Token: 0x0400285D RID: 10333
		private static readonly SpriteRendererDataAccessExtensions.DeactivateDeformableBufferDelegate DeactivateDeformableBufferDelegateField = IL2CPP.ResolveICall<SpriteRendererDataAccessExtensions.DeactivateDeformableBufferDelegate>("UnityEngine.U2D.SpriteRendererDataAccessExtensions::DeactivateDeformableBuffer");

		// Token: 0x0400285E RID: 10334
		private static readonly SpriteRendererDataAccessExtensions.SetDeformableBufferDelegate SetDeformableBufferDelegateField = IL2CPP.ResolveICall<SpriteRendererDataAccessExtensions.SetDeformableBufferDelegate>("UnityEngine.U2D.SpriteRendererDataAccessExtensions::SetDeformableBuffer");

		// Token: 0x0400285F RID: 10335
		private static readonly SpriteRendererDataAccessExtensions.SetBatchDeformableBufferAndLocalAABBArrayDelegate SetBatchDeformableBufferAndLocalAABBArrayDelegateField = IL2CPP.ResolveICall<SpriteRendererDataAccessExtensions.SetBatchDeformableBufferAndLocalAABBArrayDelegate>("UnityEngine.U2D.SpriteRendererDataAccessExtensions::SetBatchDeformableBufferAndLocalAABBArray");

		// Token: 0x04002860 RID: 10336
		private static readonly SpriteRendererDataAccessExtensions.IsUsingDeformableBufferDelegate IsUsingDeformableBufferDelegateField = IL2CPP.ResolveICall<SpriteRendererDataAccessExtensions.IsUsingDeformableBufferDelegate>("UnityEngine.U2D.SpriteRendererDataAccessExtensions::IsUsingDeformableBuffer");

		// Token: 0x04002861 RID: 10337
		private static readonly SpriteRendererDataAccessExtensions.SetLocalAABB_InjectedDelegate SetLocalAABB_InjectedDelegateField = IL2CPP.ResolveICall<SpriteRendererDataAccessExtensions.SetLocalAABB_InjectedDelegate>("UnityEngine.U2D.SpriteRendererDataAccessExtensions::SetLocalAABB_Injected");

		// Token: 0x02000CDA RID: 3290
		// (Invoke) Token: 0x06004251 RID: 16977
		private delegate void DeactivateDeformableBufferDelegate(IntPtr renderer);

		// Token: 0x02000CDB RID: 3291
		// (Invoke) Token: 0x06004253 RID: 16979
		private delegate void SetDeformableBufferDelegate(IntPtr spriteRenderer, IntPtr src, int count);

		// Token: 0x02000CDC RID: 3292
		// (Invoke) Token: 0x06004255 RID: 16981
		private delegate void SetBatchDeformableBufferAndLocalAABBArrayDelegate(IntPtr spriteRenderers, IntPtr buffers, IntPtr bufferSizes, IntPtr bounds, int count);

		// Token: 0x02000CDD RID: 3293
		// (Invoke) Token: 0x06004257 RID: 16983
		private delegate bool IsUsingDeformableBufferDelegate(IntPtr spriteRenderer, IntPtr buffer);

		// Token: 0x02000CDE RID: 3294
		// (Invoke) Token: 0x06004259 RID: 16985
		private delegate void SetLocalAABB_InjectedDelegate(IntPtr renderer, IntPtr aabb);
	}
}
