using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200002D RID: 45
	public class LookAtCamera : MonoBehaviour
	{
		// Token: 0x06000219 RID: 537 RVA: 0x0008208C File Offset: 0x0008028C
		// Note: this type is marked as 'beforefieldinit'.
		static LookAtCamera()
		{
			Il2CppClassPointerStore<LookAtCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "LookAtCamera");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LookAtCamera>.NativeClassPtr);
			LookAtCamera.NativeFieldInfoPtr_lookAtCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookAtCamera>.NativeClassPtr, "lookAtCamera");
			LookAtCamera.NativeFieldInfoPtr_lookOnlyOnAwake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookAtCamera>.NativeClassPtr, "lookOnlyOnAwake");
			LookAtCamera.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAtCamera>.NativeClassPtr, 100663560);
			LookAtCamera.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAtCamera>.NativeClassPtr, 100663561);
			LookAtCamera.NativeMethodInfoPtr_LookCam_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAtCamera>.NativeClassPtr, 100663562);
			LookAtCamera.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAtCamera>.NativeClassPtr, 100663563);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00082134 File Offset: 0x00080334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67442, XrefRangeEnd = 67451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookAtCamera.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00082168 File Offset: 0x00080368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67451, XrefRangeEnd = 67454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookAtCamera.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0008219C File Offset: 0x0008039C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67454, XrefRangeEnd = 67458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LookCam()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookAtCamera.NativeMethodInfoPtr_LookCam_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x000821D0 File Offset: 0x000803D0
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LookAtCamera() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LookAtCamera>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookAtCamera.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x000030C5 File Offset: 0x000012C5
		public LookAtCamera(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600021F RID: 543 RVA: 0x0008220C File Offset: 0x0008040C
		// (set) Token: 0x06000220 RID: 544 RVA: 0x000030CE File Offset: 0x000012CE
		public unsafe Camera lookAtCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookAtCamera.NativeFieldInfoPtr_lookAtCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookAtCamera.NativeFieldInfoPtr_lookAtCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000221 RID: 545 RVA: 0x0008223C File Offset: 0x0008043C
		// (set) Token: 0x06000222 RID: 546 RVA: 0x000030ED File Offset: 0x000012ED
		public unsafe bool lookOnlyOnAwake
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookAtCamera.NativeFieldInfoPtr_lookOnlyOnAwake);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookAtCamera.NativeFieldInfoPtr_lookOnlyOnAwake)) = value;
			}
		}

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeFieldInfoPtr_lookAtCamera;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeFieldInfoPtr_lookOnlyOnAwake;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeMethodInfoPtr_LookCam_Public_Void_0;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
