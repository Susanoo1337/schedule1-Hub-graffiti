using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000218 RID: 536
	[Serializable]
	public class WateringCanData : ItemData
	{
		// Token: 0x06002E5E RID: 11870 RVA: 0x00115A54 File Offset: 0x00113C54
		// Note: this type is marked as 'beforefieldinit'.
		static WateringCanData()
		{
			Il2CppClassPointerStore<WateringCanData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "WateringCanData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WateringCanData>.NativeClassPtr);
			WateringCanData.NativeFieldInfoPtr_CurrentFillAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WateringCanData>.NativeClassPtr, "CurrentFillAmount");
			WateringCanData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WateringCanData>.NativeClassPtr, 100669372);
		}

		// Token: 0x06002E5F RID: 11871 RVA: 0x00115AAC File Offset: 0x00113CAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 134753, RefRangeEnd = 134755, XrefRangeStart = 134753, XrefRangeEnd = 134755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WateringCanData(string iD, int quantity, float currentFillLevel) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WateringCanData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iD);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentFillLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WateringCanData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E60 RID: 11872 RVA: 0x00017853 File Offset: 0x00015A53
		public WateringCanData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000ED2 RID: 3794
		// (get) Token: 0x06002E61 RID: 11873 RVA: 0x00115B14 File Offset: 0x00113D14
		// (set) Token: 0x06002E62 RID: 11874 RVA: 0x0001785C File Offset: 0x00015A5C
		public unsafe float CurrentFillAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanData.NativeFieldInfoPtr_CurrentFillAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanData.NativeFieldInfoPtr_CurrentFillAmount)) = value;
			}
		}

		// Token: 0x04001F9F RID: 8095
		private static readonly IntPtr NativeFieldInfoPtr_CurrentFillAmount;

		// Token: 0x04001FA0 RID: 8096
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Single_0;
	}
}
