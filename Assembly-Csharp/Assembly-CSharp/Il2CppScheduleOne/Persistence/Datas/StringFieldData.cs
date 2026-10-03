using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000234 RID: 564
	[Serializable]
	public class StringFieldData : Object
	{
		// Token: 0x06002F15 RID: 12053 RVA: 0x0011794C File Offset: 0x00115B4C
		// Note: this type is marked as 'beforefieldinit'.
		static StringFieldData()
		{
			Il2CppClassPointerStore<StringFieldData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "StringFieldData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringFieldData>.NativeClassPtr);
			StringFieldData.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringFieldData>.NativeClassPtr, "Value");
			StringFieldData.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringFieldData>.NativeClassPtr, 100669401);
		}

		// Token: 0x06002F16 RID: 12054 RVA: 0x001179A4 File Offset: 0x00115BA4
		[CallerCount(203)]
		[CachedScanResults(RefRangeStart = 19776, RefRangeEnd = 19979, XrefRangeStart = 19776, XrefRangeEnd = 19979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringFieldData(string value) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringFieldData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringFieldData.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F17 RID: 12055 RVA: 0x00017F5B File Offset: 0x0001615B
		public StringFieldData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F03 RID: 3843
		// (get) Token: 0x06002F18 RID: 12056 RVA: 0x001179F0 File Offset: 0x00115BF0
		// (set) Token: 0x06002F19 RID: 12057 RVA: 0x00017F64 File Offset: 0x00016164
		public unsafe string Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringFieldData.NativeFieldInfoPtr_Value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringFieldData.NativeFieldInfoPtr_Value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001FED RID: 8173
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001FEE RID: 8174
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
