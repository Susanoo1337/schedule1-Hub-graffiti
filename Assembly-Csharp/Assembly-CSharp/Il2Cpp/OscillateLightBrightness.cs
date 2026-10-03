using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000038 RID: 56
	public class OscillateLightBrightness : MonoBehaviour
	{
		// Token: 0x060003B0 RID: 944 RVA: 0x00085EE8 File Offset: 0x000840E8
		// Note: this type is marked as 'beforefieldinit'.
		static OscillateLightBrightness()
		{
			Il2CppClassPointerStore<OscillateLightBrightness>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "OscillateLightBrightness");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OscillateLightBrightness>.NativeClassPtr);
			OscillateLightBrightness.NativeFieldInfoPtr_lightComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OscillateLightBrightness>.NativeClassPtr, "lightComponent");
			OscillateLightBrightness.NativeFieldInfoPtr_lower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OscillateLightBrightness>.NativeClassPtr, "lower");
			OscillateLightBrightness.NativeFieldInfoPtr_upper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OscillateLightBrightness>.NativeClassPtr, "upper");
			OscillateLightBrightness.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OscillateLightBrightness>.NativeClassPtr, 100663657);
			OscillateLightBrightness.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OscillateLightBrightness>.NativeClassPtr, 100663658);
			OscillateLightBrightness.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OscillateLightBrightness>.NativeClassPtr, 100663659);
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00085F90 File Offset: 0x00084190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68528, XrefRangeEnd = 68532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OscillateLightBrightness.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00085FC4 File Offset: 0x000841C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68532, XrefRangeEnd = 68535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OscillateLightBrightness.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00085FF8 File Offset: 0x000841F8
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OscillateLightBrightness() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OscillateLightBrightness>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OscillateLightBrightness.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x000041C6 File Offset: 0x000023C6
		public OscillateLightBrightness(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x00086034 File Offset: 0x00084234
		// (set) Token: 0x060003B6 RID: 950 RVA: 0x000041CF File Offset: 0x000023CF
		public unsafe Light lightComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OscillateLightBrightness.NativeFieldInfoPtr_lightComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OscillateLightBrightness.NativeFieldInfoPtr_lightComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x00086064 File Offset: 0x00084264
		// (set) Token: 0x060003B8 RID: 952 RVA: 0x000041EE File Offset: 0x000023EE
		public unsafe float lower
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OscillateLightBrightness.NativeFieldInfoPtr_lower);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OscillateLightBrightness.NativeFieldInfoPtr_lower)) = value;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x0008608C File Offset: 0x0008428C
		// (set) Token: 0x060003BA RID: 954 RVA: 0x00004209 File Offset: 0x00002409
		public unsafe float upper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OscillateLightBrightness.NativeFieldInfoPtr_upper);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OscillateLightBrightness.NativeFieldInfoPtr_upper)) = value;
			}
		}

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeFieldInfoPtr_lightComponent;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeFieldInfoPtr_lower;

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeFieldInfoPtr_upper;

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
