using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004D4 RID: 1236
	public class CameraOverrider : MonoBehaviour
	{
		// Token: 0x06007127 RID: 28967 RVA: 0x001FF690 File Offset: 0x001FD890
		// Note: this type is marked as 'beforefieldinit'.
		static CameraOverrider()
		{
			Il2CppClassPointerStore<CameraOverrider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "CameraOverrider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraOverrider>.NativeClassPtr);
			CameraOverrider.NativeFieldInfoPtr_FOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOverrider>.NativeClassPtr, "FOV");
			CameraOverrider.NativeMethodInfoPtr_LateUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOverrider>.NativeClassPtr, 100677916);
			CameraOverrider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOverrider>.NativeClassPtr, 100677917);
		}

		// Token: 0x06007128 RID: 28968 RVA: 0x001FF6FC File Offset: 0x001FD8FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225170, XrefRangeEnd = 225184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraOverrider.NativeMethodInfoPtr_LateUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007129 RID: 28969 RVA: 0x001FF730 File Offset: 0x001FD930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225184, XrefRangeEnd = 225185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraOverrider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraOverrider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraOverrider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600712A RID: 28970 RVA: 0x00035D5D File Offset: 0x00033F5D
		public CameraOverrider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170022FB RID: 8955
		// (get) Token: 0x0600712B RID: 28971 RVA: 0x001FF76C File Offset: 0x001FD96C
		// (set) Token: 0x0600712C RID: 28972 RVA: 0x00035D66 File Offset: 0x00033F66
		public unsafe float FOV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOverrider.NativeFieldInfoPtr_FOV);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOverrider.NativeFieldInfoPtr_FOV)) = value;
			}
		}

		// Token: 0x04004D60 RID: 19808
		private static readonly IntPtr NativeFieldInfoPtr_FOV;

		// Token: 0x04004D61 RID: 19809
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Public_Void_0;

		// Token: 0x04004D62 RID: 19810
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
