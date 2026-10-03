using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200021B RID: 539
	public class LawData : SaveData
	{
		// Token: 0x06002E6D RID: 11885 RVA: 0x00115CD0 File Offset: 0x00113ED0
		// Note: this type is marked as 'beforefieldinit'.
		static LawData()
		{
			Il2CppClassPointerStore<LawData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "LawData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LawData>.NativeClassPtr);
			LawData.NativeFieldInfoPtr_InternalLawIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawData>.NativeClassPtr, "InternalLawIntensity");
			LawData.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawData>.NativeClassPtr, 100669375);
		}

		// Token: 0x06002E6E RID: 11886 RVA: 0x00115D28 File Offset: 0x00113F28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 134782, RefRangeEnd = 134783, XrefRangeStart = 134781, XrefRangeEnd = 134782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LawData(float internalLawIntensity) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LawData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref internalLawIntensity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawData.NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E6F RID: 11887 RVA: 0x000178F8 File Offset: 0x00015AF8
		public LawData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000ED5 RID: 3797
		// (get) Token: 0x06002E70 RID: 11888 RVA: 0x00115D70 File Offset: 0x00113F70
		// (set) Token: 0x06002E71 RID: 11889 RVA: 0x00017901 File Offset: 0x00015B01
		public unsafe float InternalLawIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawData.NativeFieldInfoPtr_InternalLawIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawData.NativeFieldInfoPtr_InternalLawIntensity)) = value;
			}
		}

		// Token: 0x04001FA5 RID: 8101
		private static readonly IntPtr NativeFieldInfoPtr_InternalLawIntensity;

		// Token: 0x04001FA6 RID: 8102
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;
	}
}
