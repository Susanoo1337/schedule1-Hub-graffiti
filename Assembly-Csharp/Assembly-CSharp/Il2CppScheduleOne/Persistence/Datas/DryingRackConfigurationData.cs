using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000223 RID: 547
	[Serializable]
	public class DryingRackConfigurationData : RenamableConfigurationData
	{
		// Token: 0x06002EA6 RID: 11942 RVA: 0x00116688 File Offset: 0x00114888
		// Note: this type is marked as 'beforefieldinit'.
		static DryingRackConfigurationData()
		{
			Il2CppClassPointerStore<DryingRackConfigurationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "DryingRackConfigurationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DryingRackConfigurationData>.NativeClassPtr);
			DryingRackConfigurationData.NativeFieldInfoPtr_TargetQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackConfigurationData>.NativeClassPtr, "TargetQuality");
			DryingRackConfigurationData.NativeFieldInfoPtr_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackConfigurationData>.NativeClassPtr, "Destination");
			DryingRackConfigurationData.NativeFieldInfoPtr_StartThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackConfigurationData>.NativeClassPtr, "StartThreshold");
			DryingRackConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_StringFieldData_QualityFieldData_ObjectFieldData_NumberFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackConfigurationData>.NativeClassPtr, 100669384);
		}

		// Token: 0x06002EA7 RID: 11943 RVA: 0x00116708 File Offset: 0x00114908
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 134371, RefRangeEnd = 134373, XrefRangeStart = 134371, XrefRangeEnd = 134373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DryingRackConfigurationData(StringFieldData name, QualityFieldData targetquality, ObjectFieldData destination, NumberFieldData startThreshold) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DryingRackConfigurationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetquality);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(startThreshold);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_StringFieldData_QualityFieldData_ObjectFieldData_NumberFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EA8 RID: 11944 RVA: 0x00017B28 File Offset: 0x00015D28
		public DryingRackConfigurationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EE5 RID: 3813
		// (get) Token: 0x06002EA9 RID: 11945 RVA: 0x0011678C File Offset: 0x0011498C
		// (set) Token: 0x06002EAA RID: 11946 RVA: 0x00017B31 File Offset: 0x00015D31
		public unsafe QualityFieldData TargetQuality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfigurationData.NativeFieldInfoPtr_TargetQuality);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QualityFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfigurationData.NativeFieldInfoPtr_TargetQuality), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EE6 RID: 3814
		// (get) Token: 0x06002EAB RID: 11947 RVA: 0x001167BC File Offset: 0x001149BC
		// (set) Token: 0x06002EAC RID: 11948 RVA: 0x00017B50 File Offset: 0x00015D50
		public unsafe ObjectFieldData Destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfigurationData.NativeFieldInfoPtr_Destination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfigurationData.NativeFieldInfoPtr_Destination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EE7 RID: 3815
		// (get) Token: 0x06002EAD RID: 11949 RVA: 0x001167EC File Offset: 0x001149EC
		// (set) Token: 0x06002EAE RID: 11950 RVA: 0x00017B6F File Offset: 0x00015D6F
		public unsafe NumberFieldData StartThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfigurationData.NativeFieldInfoPtr_StartThreshold);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NumberFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfigurationData.NativeFieldInfoPtr_StartThreshold), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FBE RID: 8126
		private static readonly IntPtr NativeFieldInfoPtr_TargetQuality;

		// Token: 0x04001FBF RID: 8127
		private static readonly IntPtr NativeFieldInfoPtr_Destination;

		// Token: 0x04001FC0 RID: 8128
		private static readonly IntPtr NativeFieldInfoPtr_StartThreshold;

		// Token: 0x04001FC1 RID: 8129
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StringFieldData_QualityFieldData_ObjectFieldData_NumberFieldData_0;
	}
}
