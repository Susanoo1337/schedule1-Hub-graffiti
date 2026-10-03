using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200021E RID: 542
	[Serializable]
	public class BrickPressConfigurationData : RenamableConfigurationData
	{
		// Token: 0x06002E87 RID: 11911 RVA: 0x00116124 File Offset: 0x00114324
		// Note: this type is marked as 'beforefieldinit'.
		static BrickPressConfigurationData()
		{
			Il2CppClassPointerStore<BrickPressConfigurationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "BrickPressConfigurationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BrickPressConfigurationData>.NativeClassPtr);
			BrickPressConfigurationData.NativeFieldInfoPtr_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressConfigurationData>.NativeClassPtr, "Destination");
			BrickPressConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_StringFieldData_ObjectFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressConfigurationData>.NativeClassPtr, 100669379);
		}

		// Token: 0x06002E88 RID: 11912 RVA: 0x0011617C File Offset: 0x0011437C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 134800, RefRangeEnd = 134812, XrefRangeStart = 134797, XrefRangeEnd = 134800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BrickPressConfigurationData(StringFieldData name, ObjectFieldData destination) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BrickPressConfigurationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_StringFieldData_ObjectFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E89 RID: 11913 RVA: 0x00017A03 File Offset: 0x00015C03
		public BrickPressConfigurationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EDD RID: 3805
		// (get) Token: 0x06002E8A RID: 11914 RVA: 0x001161DC File Offset: 0x001143DC
		// (set) Token: 0x06002E8B RID: 11915 RVA: 0x00017A0C File Offset: 0x00015C0C
		public unsafe ObjectFieldData Destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressConfigurationData.NativeFieldInfoPtr_Destination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressConfigurationData.NativeFieldInfoPtr_Destination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FB1 RID: 8113
		private static readonly IntPtr NativeFieldInfoPtr_Destination;

		// Token: 0x04001FB2 RID: 8114
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StringFieldData_ObjectFieldData_0;
	}
}
