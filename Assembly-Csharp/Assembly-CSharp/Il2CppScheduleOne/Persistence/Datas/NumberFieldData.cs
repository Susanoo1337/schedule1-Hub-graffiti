using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000229 RID: 553
	[Serializable]
	public class NumberFieldData : Object
	{
		// Token: 0x06002ED2 RID: 11986 RVA: 0x00116E18 File Offset: 0x00115018
		// Note: this type is marked as 'beforefieldinit'.
		static NumberFieldData()
		{
			Il2CppClassPointerStore<NumberFieldData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "NumberFieldData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumberFieldData>.NativeClassPtr);
			NumberFieldData.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFieldData>.NativeClassPtr, "Value");
			NumberFieldData.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFieldData>.NativeClassPtr, 100669390);
		}

		// Token: 0x06002ED3 RID: 11987 RVA: 0x00116E70 File Offset: 0x00115070
		[CallerCount(149)]
		[CachedScanResults(RefRangeStart = 134822, RefRangeEnd = 134971, XrefRangeStart = 134821, XrefRangeEnd = 134822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NumberFieldData(float value) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NumberFieldData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFieldData.NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002ED4 RID: 11988 RVA: 0x00017CF1 File Offset: 0x00015EF1
		public NumberFieldData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EF2 RID: 3826
		// (get) Token: 0x06002ED5 RID: 11989 RVA: 0x00116EB8 File Offset: 0x001150B8
		// (set) Token: 0x06002ED6 RID: 11990 RVA: 0x00017CFA File Offset: 0x00015EFA
		public unsafe float Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldData.NativeFieldInfoPtr_Value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldData.NativeFieldInfoPtr_Value)) = value;
			}
		}

		// Token: 0x04001FD1 RID: 8145
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001FD2 RID: 8146
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;
	}
}
