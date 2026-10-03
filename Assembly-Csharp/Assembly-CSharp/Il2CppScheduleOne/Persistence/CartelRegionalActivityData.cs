using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Map;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence
{
	// Token: 0x020001B2 RID: 434
	[Serializable]
	public class CartelRegionalActivityData : Object
	{
		// Token: 0x06002B57 RID: 11095 RVA: 0x0010A8C8 File Offset: 0x00108AC8
		// Note: this type is marked as 'beforefieldinit'.
		static CartelRegionalActivityData()
		{
			Il2CppClassPointerStore<CartelRegionalActivityData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence", "CartelRegionalActivityData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CartelRegionalActivityData>.NativeClassPtr);
			CartelRegionalActivityData.NativeFieldInfoPtr_Region = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelRegionalActivityData>.NativeClassPtr, "Region");
			CartelRegionalActivityData.NativeFieldInfoPtr_CurrentActivityIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelRegionalActivityData>.NativeClassPtr, "CurrentActivityIndex");
			CartelRegionalActivityData.NativeFieldInfoPtr_HoursUntilNextActivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelRegionalActivityData>.NativeClassPtr, "HoursUntilNextActivity");
			CartelRegionalActivityData.NativeMethodInfoPtr__ctor_Public_Void_EMapRegion_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelRegionalActivityData>.NativeClassPtr, 100668910);
		}

		// Token: 0x06002B58 RID: 11096 RVA: 0x0010A948 File Offset: 0x00108B48
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 127277, RefRangeEnd = 127283, XrefRangeStart = 127276, XrefRangeEnd = 127277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CartelRegionalActivityData(EMapRegion region, int currentActivityIndex, int hoursUntilNextActivity) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CartelRegionalActivityData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref region;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentActivityIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hoursUntilNextActivity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelRegionalActivityData.NativeMethodInfoPtr__ctor_Public_Void_EMapRegion_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B59 RID: 11097 RVA: 0x000167BB File Offset: 0x000149BB
		public CartelRegionalActivityData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E30 RID: 3632
		// (get) Token: 0x06002B5A RID: 11098 RVA: 0x0010A9AC File Offset: 0x00108BAC
		// (set) Token: 0x06002B5B RID: 11099 RVA: 0x000167C4 File Offset: 0x000149C4
		public unsafe EMapRegion Region
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelRegionalActivityData.NativeFieldInfoPtr_Region);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelRegionalActivityData.NativeFieldInfoPtr_Region)) = value;
			}
		}

		// Token: 0x17000E31 RID: 3633
		// (get) Token: 0x06002B5C RID: 11100 RVA: 0x0010A9D4 File Offset: 0x00108BD4
		// (set) Token: 0x06002B5D RID: 11101 RVA: 0x000167DF File Offset: 0x000149DF
		public unsafe int CurrentActivityIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelRegionalActivityData.NativeFieldInfoPtr_CurrentActivityIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelRegionalActivityData.NativeFieldInfoPtr_CurrentActivityIndex)) = value;
			}
		}

		// Token: 0x17000E32 RID: 3634
		// (get) Token: 0x06002B5E RID: 11102 RVA: 0x0010A9FC File Offset: 0x00108BFC
		// (set) Token: 0x06002B5F RID: 11103 RVA: 0x000167FA File Offset: 0x000149FA
		public unsafe int HoursUntilNextActivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelRegionalActivityData.NativeFieldInfoPtr_HoursUntilNextActivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelRegionalActivityData.NativeFieldInfoPtr_HoursUntilNextActivity)) = value;
			}
		}

		// Token: 0x04001DD3 RID: 7635
		private static readonly IntPtr NativeFieldInfoPtr_Region;

		// Token: 0x04001DD4 RID: 7636
		private static readonly IntPtr NativeFieldInfoPtr_CurrentActivityIndex;

		// Token: 0x04001DD5 RID: 7637
		private static readonly IntPtr NativeFieldInfoPtr_HoursUntilNextActivity;

		// Token: 0x04001DD6 RID: 7638
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EMapRegion_Int32_Int32_0;
	}
}
