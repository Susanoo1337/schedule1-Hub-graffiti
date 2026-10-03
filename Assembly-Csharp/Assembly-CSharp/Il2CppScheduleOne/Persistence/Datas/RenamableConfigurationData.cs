using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000230 RID: 560
	[Serializable]
	public class RenamableConfigurationData : SaveData
	{
		// Token: 0x06002F01 RID: 12033 RVA: 0x001175F0 File Offset: 0x001157F0
		// Note: this type is marked as 'beforefieldinit'.
		static RenamableConfigurationData()
		{
			Il2CppClassPointerStore<RenamableConfigurationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "RenamableConfigurationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenamableConfigurationData>.NativeClassPtr);
			RenamableConfigurationData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenamableConfigurationData>.NativeClassPtr, "Name");
			RenamableConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_StringFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenamableConfigurationData>.NativeClassPtr, 100669397);
		}

		// Token: 0x06002F02 RID: 12034 RVA: 0x00117648 File Offset: 0x00115848
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 134314, RefRangeEnd = 134323, XrefRangeStart = 134314, XrefRangeEnd = 134323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenamableConfigurationData(StringFieldData name) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenamableConfigurationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenamableConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_StringFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F03 RID: 12035 RVA: 0x00017EBB File Offset: 0x000160BB
		public RenamableConfigurationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EFF RID: 3839
		// (get) Token: 0x06002F04 RID: 12036 RVA: 0x00117694 File Offset: 0x00115894
		// (set) Token: 0x06002F05 RID: 12037 RVA: 0x00017EC4 File Offset: 0x000160C4
		public unsafe StringFieldData Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenamableConfigurationData.NativeFieldInfoPtr_Name);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenamableConfigurationData.NativeFieldInfoPtr_Name), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FE5 RID: 8165
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04001FE6 RID: 8166
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StringFieldData_0;
	}
}
