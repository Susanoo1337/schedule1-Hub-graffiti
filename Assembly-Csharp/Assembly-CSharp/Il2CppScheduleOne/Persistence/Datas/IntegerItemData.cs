using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200020F RID: 527
	[Serializable]
	public class IntegerItemData : ItemData
	{
		// Token: 0x06002E31 RID: 11825 RVA: 0x001152DC File Offset: 0x001134DC
		// Note: this type is marked as 'beforefieldinit'.
		static IntegerItemData()
		{
			Il2CppClassPointerStore<IntegerItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "IntegerItemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntegerItemData>.NativeClassPtr);
			IntegerItemData.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegerItemData>.NativeClassPtr, "Value");
			IntegerItemData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemData>.NativeClassPtr, 100669363);
		}

		// Token: 0x06002E32 RID: 11826 RVA: 0x00115334 File Offset: 0x00113534
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 134757, RefRangeEnd = 134759, XrefRangeStart = 134757, XrefRangeEnd = 134759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntegerItemData(string iD, int quantity, int value) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntegerItemData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iD);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntegerItemData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E33 RID: 11827 RVA: 0x00017654 File Offset: 0x00015854
		public IntegerItemData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EC9 RID: 3785
		// (get) Token: 0x06002E34 RID: 11828 RVA: 0x0011539C File Offset: 0x0011359C
		// (set) Token: 0x06002E35 RID: 11829 RVA: 0x0001765D File Offset: 0x0001585D
		public unsafe int Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegerItemData.NativeFieldInfoPtr_Value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegerItemData.NativeFieldInfoPtr_Value)) = value;
			}
		}

		// Token: 0x04001F8D RID: 8077
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001F8E RID: 8078
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0;
	}
}
