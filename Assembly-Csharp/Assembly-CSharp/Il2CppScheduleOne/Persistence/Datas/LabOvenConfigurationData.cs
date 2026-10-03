using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000225 RID: 549
	[Serializable]
	public class LabOvenConfigurationData : RenamableConfigurationData
	{
		// Token: 0x06002EB4 RID: 11956 RVA: 0x001168E8 File Offset: 0x00114AE8
		// Note: this type is marked as 'beforefieldinit'.
		static LabOvenConfigurationData()
		{
			Il2CppClassPointerStore<LabOvenConfigurationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "LabOvenConfigurationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabOvenConfigurationData>.NativeClassPtr);
			LabOvenConfigurationData.NativeFieldInfoPtr_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenConfigurationData>.NativeClassPtr, "Destination");
			LabOvenConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_StringFieldData_ObjectFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenConfigurationData>.NativeClassPtr, 100669386);
		}

		// Token: 0x06002EB5 RID: 11957 RVA: 0x00116940 File Offset: 0x00114B40
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 134800, RefRangeEnd = 134812, XrefRangeStart = 134800, XrefRangeEnd = 134812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabOvenConfigurationData(StringFieldData name, ObjectFieldData destination) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabOvenConfigurationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_StringFieldData_ObjectFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EB6 RID: 11958 RVA: 0x00017BB6 File Offset: 0x00015DB6
		public LabOvenConfigurationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EE9 RID: 3817
		// (get) Token: 0x06002EB7 RID: 11959 RVA: 0x001169A0 File Offset: 0x00114BA0
		// (set) Token: 0x06002EB8 RID: 11960 RVA: 0x00017BBF File Offset: 0x00015DBF
		public unsafe ObjectFieldData Destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenConfigurationData.NativeFieldInfoPtr_Destination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenConfigurationData.NativeFieldInfoPtr_Destination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FC4 RID: 8132
		private static readonly IntPtr NativeFieldInfoPtr_Destination;

		// Token: 0x04001FC5 RID: 8133
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StringFieldData_ObjectFieldData_0;
	}
}
