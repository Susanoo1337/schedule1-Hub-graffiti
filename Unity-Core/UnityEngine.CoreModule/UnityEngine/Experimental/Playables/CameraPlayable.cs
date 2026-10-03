using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Experimental.Playables
{
	// Token: 0x02000273 RID: 627
	[StructLayout(2)]
	public struct CameraPlayable
	{
		// Token: 0x06002B03 RID: 11011 RVA: 0x000A7E40 File Offset: 0x000A6040
		// Note: this type is marked as 'beforefieldinit'.
		static CameraPlayable()
		{
			Il2CppClassPointerStore<CameraPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Playables", "CameraPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraPlayable>.NativeClassPtr);
			CameraPlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPlayable>.NativeClassPtr, "m_Handle");
			CameraPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPlayable>.NativeClassPtr, 100667942);
			CameraPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CameraPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPlayable>.NativeClassPtr, 100667943);
			CameraPlayable.GetCameraInternalDelegateField = IL2CPP.ResolveICall<CameraPlayable.GetCameraInternalDelegate>("UnityEngine.Experimental.Playables.CameraPlayable::GetCameraInternal");
			CameraPlayable.SetCameraInternalDelegateField = IL2CPP.ResolveICall<CameraPlayable.SetCameraInternalDelegate>("UnityEngine.Experimental.Playables.CameraPlayable::SetCameraInternal");
			CameraPlayable.InternalCreateCameraPlayableDelegateField = IL2CPP.ResolveICall<CameraPlayable.InternalCreateCameraPlayableDelegate>("UnityEngine.Experimental.Playables.CameraPlayable::InternalCreateCameraPlayable");
			CameraPlayable.ValidateTypeDelegateField = IL2CPP.ResolveICall<CameraPlayable.ValidateTypeDelegate>("UnityEngine.Experimental.Playables.CameraPlayable::ValidateType");
		}

		// Token: 0x06002B04 RID: 11012 RVA: 0x000A7EE8 File Offset: 0x000A60E8
		[CallerCount(47)]
		[CachedScanResults(RefRangeStart = 1223500, RefRangeEnd = 1223547, XrefRangeStart = 1223500, XrefRangeEnd = 1223547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEngine.Playables.PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B05 RID: 11013 RVA: 0x000A7F18 File Offset: 0x000A6118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294330, XrefRangeEnd = 1294338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(CameraPlayable other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CameraPlayable_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B06 RID: 11014 RVA: 0x00012ED4 File Offset: 0x000110D4
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraPlayable>.NativeClassPtr, ref this));
		}

		// Token: 0x06002B07 RID: 11015 RVA: 0x000A7F58 File Offset: 0x000A6158
		public static CameraPlayable Create(UnityEngine.Playables.PlayableGraph graph, Camera camera)
		{
			UnityEngine.Playables.PlayableHandle playableHandle = CameraPlayable.CreateHandle(graph, camera);
			return new CameraPlayable(playableHandle);
		}

		// Token: 0x06002B08 RID: 11016 RVA: 0x000A7F78 File Offset: 0x000A6178
		public static UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, Camera camera)
		{
			UnityEngine.Playables.PlayableHandle @null = UnityEngine.Playables.PlayableHandle.Null;
			bool flag = !CameraPlayable.InternalCreateCameraPlayable(ref graph, camera, ref @null);
			UnityEngine.Playables.PlayableHandle result;
			if (flag)
			{
				result = UnityEngine.Playables.PlayableHandle.Null;
			}
			else
			{
				result = @null;
			}
			return result;
		}

		// Token: 0x06002B09 RID: 11017 RVA: 0x000A7FAC File Offset: 0x000A61AC
		public static implicit operator UnityEngine.Playables.Playable(CameraPlayable playable)
		{
			return new UnityEngine.Playables.Playable(playable.GetHandle());
		}

		// Token: 0x06002B0A RID: 11018 RVA: 0x000A7FCC File Offset: 0x000A61CC
		public static explicit operator CameraPlayable(UnityEngine.Playables.Playable playable)
		{
			return new CameraPlayable(playable.GetHandle());
		}

		// Token: 0x06002B0B RID: 11019 RVA: 0x000A7FEC File Offset: 0x000A61EC
		public Camera GetCamera()
		{
			return CameraPlayable.GetCameraInternal(ref this.m_Handle);
		}

		// Token: 0x06002B0C RID: 11020 RVA: 0x00012EE6 File Offset: 0x000110E6
		public void SetCamera(Camera value)
		{
			CameraPlayable.SetCameraInternal(ref this.m_Handle, value);
		}

		// Token: 0x06002B0D RID: 11021 RVA: 0x000A800C File Offset: 0x000A620C
		public static Camera GetCameraInternal(ref UnityEngine.Playables.PlayableHandle hdl)
		{
			IntPtr intPtr = CameraPlayable.GetCameraInternalDelegateField(ref hdl);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
		}

		// Token: 0x06002B0E RID: 11022 RVA: 0x00012EF6 File Offset: 0x000110F6
		public static void SetCameraInternal(ref UnityEngine.Playables.PlayableHandle hdl, Camera camera)
		{
			CameraPlayable.SetCameraInternalDelegateField(ref hdl, IL2CPP.Il2CppObjectBaseToPtr(camera));
		}

		// Token: 0x06002B0F RID: 11023 RVA: 0x00012F09 File Offset: 0x00011109
		public static bool InternalCreateCameraPlayable(ref UnityEngine.Playables.PlayableGraph graph, Camera camera, ref UnityEngine.Playables.PlayableHandle handle)
		{
			return CameraPlayable.InternalCreateCameraPlayableDelegateField(ref graph, IL2CPP.Il2CppObjectBaseToPtr(camera), ref handle);
		}

		// Token: 0x06002B10 RID: 11024 RVA: 0x00012F1D File Offset: 0x0001111D
		public static bool ValidateType(ref UnityEngine.Playables.PlayableHandle hdl)
		{
			return CameraPlayable.ValidateTypeDelegateField(ref hdl);
		}

		// Token: 0x04002512 RID: 9490
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x04002513 RID: 9491
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x04002514 RID: 9492
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CameraPlayable_0;

		// Token: 0x04002515 RID: 9493
		[FieldOffset(0)]
		public UnityEngine.Playables.PlayableHandle m_Handle;

		// Token: 0x04002516 RID: 9494
		private static readonly CameraPlayable.GetCameraInternalDelegate GetCameraInternalDelegateField;

		// Token: 0x04002517 RID: 9495
		private static readonly CameraPlayable.SetCameraInternalDelegate SetCameraInternalDelegateField;

		// Token: 0x04002518 RID: 9496
		private static readonly CameraPlayable.InternalCreateCameraPlayableDelegate InternalCreateCameraPlayableDelegateField;

		// Token: 0x04002519 RID: 9497
		private static readonly CameraPlayable.ValidateTypeDelegate ValidateTypeDelegateField;

		// Token: 0x02000BEB RID: 3051
		// (Invoke) Token: 0x060040A2 RID: 16546
		private delegate IntPtr GetCameraInternalDelegate(IntPtr hdl);

		// Token: 0x02000BEC RID: 3052
		// (Invoke) Token: 0x060040A4 RID: 16548
		private delegate void SetCameraInternalDelegate(IntPtr hdl, IntPtr camera);

		// Token: 0x02000BED RID: 3053
		// (Invoke) Token: 0x060040A6 RID: 16550
		private delegate bool InternalCreateCameraPlayableDelegate(IntPtr graph, IntPtr camera, IntPtr handle);

		// Token: 0x02000BEE RID: 3054
		// (Invoke) Token: 0x060040A8 RID: 16552
		private delegate bool ValidateTypeDelegate(IntPtr hdl);
	}
}
