using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Experimental
{
	// Token: 0x020006F5 RID: 1781
	[Serializable]
	public class WheelFrictionSettings : Object
	{
		// Token: 0x0600AB9E RID: 43934 RVA: 0x002D351C File Offset: 0x002D171C
		// Note: this type is marked as 'beforefieldinit'.
		static WheelFrictionSettings()
		{
			Il2CppClassPointerStore<WheelFrictionSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Experimental", "WheelFrictionSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WheelFrictionSettings>.NativeClassPtr);
			WheelFrictionSettings.NativeFieldInfoPtr_ExtremumSlip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelFrictionSettings>.NativeClassPtr, "ExtremumSlip");
			WheelFrictionSettings.NativeFieldInfoPtr_ExtremumValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelFrictionSettings>.NativeClassPtr, "ExtremumValue");
			WheelFrictionSettings.NativeFieldInfoPtr_AsymptoteSlip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelFrictionSettings>.NativeClassPtr, "AsymptoteSlip");
			WheelFrictionSettings.NativeFieldInfoPtr_AsymptoteValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelFrictionSettings>.NativeClassPtr, "AsymptoteValue");
			WheelFrictionSettings.NativeFieldInfoPtr_Stiffness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelFrictionSettings>.NativeClassPtr, "Stiffness");
			WheelFrictionSettings.NativeMethodInfoPtr_Blend_Public_WheelFrictionSettings_WheelFrictionSettings_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelFrictionSettings>.NativeClassPtr, 100685970);
			WheelFrictionSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelFrictionSettings>.NativeClassPtr, 100685971);
		}

		// Token: 0x0600AB9F RID: 43935 RVA: 0x002D35D8 File Offset: 0x002D17D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 295034, RefRangeEnd = 295036, XrefRangeStart = 295021, XrefRangeEnd = 295034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WheelFrictionSettings Blend(WheelFrictionSettings other, float t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WheelFrictionSettings.NativeMethodInfoPtr_Blend_Public_WheelFrictionSettings_WheelFrictionSettings_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WheelFrictionSettings>(intPtr3) : null;
		}

		// Token: 0x0600ABA0 RID: 43936 RVA: 0x002D3638 File Offset: 0x002D1838
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WheelFrictionSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WheelFrictionSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WheelFrictionSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ABA1 RID: 43937 RVA: 0x0004E664 File Offset: 0x0004C864
		public WheelFrictionSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003367 RID: 13159
		// (get) Token: 0x0600ABA2 RID: 43938 RVA: 0x002D3674 File Offset: 0x002D1874
		// (set) Token: 0x0600ABA3 RID: 43939 RVA: 0x0004E66D File Offset: 0x0004C86D
		public unsafe float ExtremumSlip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelFrictionSettings.NativeFieldInfoPtr_ExtremumSlip);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelFrictionSettings.NativeFieldInfoPtr_ExtremumSlip)) = value;
			}
		}

		// Token: 0x17003368 RID: 13160
		// (get) Token: 0x0600ABA4 RID: 43940 RVA: 0x002D369C File Offset: 0x002D189C
		// (set) Token: 0x0600ABA5 RID: 43941 RVA: 0x0004E688 File Offset: 0x0004C888
		public unsafe float ExtremumValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelFrictionSettings.NativeFieldInfoPtr_ExtremumValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelFrictionSettings.NativeFieldInfoPtr_ExtremumValue)) = value;
			}
		}

		// Token: 0x17003369 RID: 13161
		// (get) Token: 0x0600ABA6 RID: 43942 RVA: 0x002D36C4 File Offset: 0x002D18C4
		// (set) Token: 0x0600ABA7 RID: 43943 RVA: 0x0004E6A3 File Offset: 0x0004C8A3
		public unsafe float AsymptoteSlip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelFrictionSettings.NativeFieldInfoPtr_AsymptoteSlip);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelFrictionSettings.NativeFieldInfoPtr_AsymptoteSlip)) = value;
			}
		}

		// Token: 0x1700336A RID: 13162
		// (get) Token: 0x0600ABA8 RID: 43944 RVA: 0x002D36EC File Offset: 0x002D18EC
		// (set) Token: 0x0600ABA9 RID: 43945 RVA: 0x0004E6BE File Offset: 0x0004C8BE
		public unsafe float AsymptoteValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelFrictionSettings.NativeFieldInfoPtr_AsymptoteValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelFrictionSettings.NativeFieldInfoPtr_AsymptoteValue)) = value;
			}
		}

		// Token: 0x1700336B RID: 13163
		// (get) Token: 0x0600ABAA RID: 43946 RVA: 0x002D3714 File Offset: 0x002D1914
		// (set) Token: 0x0600ABAB RID: 43947 RVA: 0x0004E6D9 File Offset: 0x0004C8D9
		public unsafe float Stiffness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelFrictionSettings.NativeFieldInfoPtr_Stiffness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelFrictionSettings.NativeFieldInfoPtr_Stiffness)) = value;
			}
		}

		// Token: 0x0400767D RID: 30333
		private static readonly IntPtr NativeFieldInfoPtr_ExtremumSlip;

		// Token: 0x0400767E RID: 30334
		private static readonly IntPtr NativeFieldInfoPtr_ExtremumValue;

		// Token: 0x0400767F RID: 30335
		private static readonly IntPtr NativeFieldInfoPtr_AsymptoteSlip;

		// Token: 0x04007680 RID: 30336
		private static readonly IntPtr NativeFieldInfoPtr_AsymptoteValue;

		// Token: 0x04007681 RID: 30337
		private static readonly IntPtr NativeFieldInfoPtr_Stiffness;

		// Token: 0x04007682 RID: 30338
		private static readonly IntPtr NativeMethodInfoPtr_Blend_Public_WheelFrictionSettings_WheelFrictionSettings_Single_0;

		// Token: 0x04007683 RID: 30339
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
