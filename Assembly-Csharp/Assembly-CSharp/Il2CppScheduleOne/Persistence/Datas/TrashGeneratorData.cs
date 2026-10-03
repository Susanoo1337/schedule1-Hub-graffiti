using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000277 RID: 631
	[Serializable]
	public class TrashGeneratorData : SaveData
	{
		// Token: 0x06003179 RID: 12665 RVA: 0x0011E930 File Offset: 0x0011CB30
		// Note: this type is marked as 'beforefieldinit'.
		static TrashGeneratorData()
		{
			Il2CppClassPointerStore<TrashGeneratorData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "TrashGeneratorData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashGeneratorData>.NativeClassPtr);
			TrashGeneratorData.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGeneratorData>.NativeClassPtr, "GUID");
			TrashGeneratorData.NativeFieldInfoPtr_GeneratedItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGeneratorData>.NativeClassPtr, "GeneratedItems");
			TrashGeneratorData.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGeneratorData>.NativeClassPtr, 100669477);
		}

		// Token: 0x0600317A RID: 12666 RVA: 0x0011E99C File Offset: 0x0011CB9C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 134800, RefRangeEnd = 134812, XrefRangeStart = 134800, XrefRangeEnd = 134812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashGeneratorData(string guid, Il2CppStringArray generatedItems) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashGeneratorData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(generatedItems);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGeneratorData.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600317B RID: 12667 RVA: 0x000198DC File Offset: 0x00017ADC
		public TrashGeneratorData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FCD RID: 4045
		// (get) Token: 0x0600317C RID: 12668 RVA: 0x0011E9FC File Offset: 0x0011CBFC
		// (set) Token: 0x0600317D RID: 12669 RVA: 0x000198E5 File Offset: 0x00017AE5
		public unsafe string GUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGeneratorData.NativeFieldInfoPtr_GUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGeneratorData.NativeFieldInfoPtr_GUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FCE RID: 4046
		// (get) Token: 0x0600317E RID: 12670 RVA: 0x0011EA24 File Offset: 0x0011CC24
		// (set) Token: 0x0600317F RID: 12671 RVA: 0x00019904 File Offset: 0x00017B04
		public unsafe Il2CppStringArray GeneratedItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGeneratorData.NativeFieldInfoPtr_GeneratedItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGeneratorData.NativeFieldInfoPtr_GeneratedItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002102 RID: 8450
		private static readonly IntPtr NativeFieldInfoPtr_GUID;

		// Token: 0x04002103 RID: 8451
		private static readonly IntPtr NativeFieldInfoPtr_GeneratedItems;

		// Token: 0x04002104 RID: 8452
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStringArray_0;
	}
}
