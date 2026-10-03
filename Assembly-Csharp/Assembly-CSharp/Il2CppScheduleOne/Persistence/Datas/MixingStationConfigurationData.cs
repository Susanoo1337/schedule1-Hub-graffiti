using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000226 RID: 550
	[Serializable]
	public class MixingStationConfigurationData : RenamableConfigurationData
	{
		// Token: 0x06002EB9 RID: 11961 RVA: 0x001169D0 File Offset: 0x00114BD0
		// Note: this type is marked as 'beforefieldinit'.
		static MixingStationConfigurationData()
		{
			Il2CppClassPointerStore<MixingStationConfigurationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "MixingStationConfigurationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixingStationConfigurationData>.NativeClassPtr);
			MixingStationConfigurationData.NativeFieldInfoPtr_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationConfigurationData>.NativeClassPtr, "Destination");
			MixingStationConfigurationData.NativeFieldInfoPtr_Threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationConfigurationData>.NativeClassPtr, "Threshold");
			MixingStationConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_StringFieldData_ObjectFieldData_NumberFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationConfigurationData>.NativeClassPtr, 100669387);
		}

		// Token: 0x06002EBA RID: 11962 RVA: 0x00116A3C File Offset: 0x00114C3C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 134792, RefRangeEnd = 134797, XrefRangeStart = 134792, XrefRangeEnd = 134797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixingStationConfigurationData(StringFieldData name, ObjectFieldData destination, NumberFieldData threshold) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixingStationConfigurationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(threshold);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_StringFieldData_ObjectFieldData_NumberFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EBB RID: 11963 RVA: 0x00017BDE File Offset: 0x00015DDE
		public MixingStationConfigurationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EEA RID: 3818
		// (get) Token: 0x06002EBC RID: 11964 RVA: 0x00116AAC File Offset: 0x00114CAC
		// (set) Token: 0x06002EBD RID: 11965 RVA: 0x00017BE7 File Offset: 0x00015DE7
		public unsafe ObjectFieldData Destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationConfigurationData.NativeFieldInfoPtr_Destination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationConfigurationData.NativeFieldInfoPtr_Destination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EEB RID: 3819
		// (get) Token: 0x06002EBE RID: 11966 RVA: 0x00116ADC File Offset: 0x00114CDC
		// (set) Token: 0x06002EBF RID: 11967 RVA: 0x00017C06 File Offset: 0x00015E06
		public unsafe NumberFieldData Threshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationConfigurationData.NativeFieldInfoPtr_Threshold);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NumberFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationConfigurationData.NativeFieldInfoPtr_Threshold), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FC6 RID: 8134
		private static readonly IntPtr NativeFieldInfoPtr_Destination;

		// Token: 0x04001FC7 RID: 8135
		private static readonly IntPtr NativeFieldInfoPtr_Threshold;

		// Token: 0x04001FC8 RID: 8136
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StringFieldData_ObjectFieldData_NumberFieldData_0;
	}
}
