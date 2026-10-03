using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200025C RID: 604
	[Serializable]
	public class OrganisationData : SaveData
	{
		// Token: 0x0600306B RID: 12395 RVA: 0x0011BB5C File Offset: 0x00119D5C
		// Note: this type is marked as 'beforefieldinit'.
		static OrganisationData()
		{
			Il2CppClassPointerStore<OrganisationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "OrganisationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrganisationData>.NativeClassPtr);
			OrganisationData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrganisationData>.NativeClassPtr, "Name");
			OrganisationData.NativeFieldInfoPtr_NetWorth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrganisationData>.NativeClassPtr, "NetWorth");
			OrganisationData.NativeMethodInfoPtr__ctor_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrganisationData>.NativeClassPtr, 100669443);
		}

		// Token: 0x0600306C RID: 12396 RVA: 0x0011BBC8 File Offset: 0x00119DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135211, XrefRangeEnd = 135213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OrganisationData(string name, float netWorth) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrganisationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref netWorth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrganisationData.NativeMethodInfoPtr__ctor_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600306D RID: 12397 RVA: 0x00018D49 File Offset: 0x00016F49
		public OrganisationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F71 RID: 3953
		// (get) Token: 0x0600306E RID: 12398 RVA: 0x0011BC24 File Offset: 0x00119E24
		// (set) Token: 0x0600306F RID: 12399 RVA: 0x00018D52 File Offset: 0x00016F52
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrganisationData.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrganisationData.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F72 RID: 3954
		// (get) Token: 0x06003070 RID: 12400 RVA: 0x0011BC4C File Offset: 0x00119E4C
		// (set) Token: 0x06003071 RID: 12401 RVA: 0x00018D71 File Offset: 0x00016F71
		public unsafe float NetWorth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrganisationData.NativeFieldInfoPtr_NetWorth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrganisationData.NativeFieldInfoPtr_NetWorth)) = value;
			}
		}

		// Token: 0x04002085 RID: 8325
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04002086 RID: 8326
		private static readonly IntPtr NativeFieldInfoPtr_NetWorth;

		// Token: 0x04002087 RID: 8327
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_0;
	}
}
