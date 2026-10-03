using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000407 RID: 1031
	[Serializable]
	public class StringIntPair : Object
	{
		// Token: 0x06005B22 RID: 23330 RVA: 0x001B5A64 File Offset: 0x001B3C64
		// Note: this type is marked as 'beforefieldinit'.
		static StringIntPair()
		{
			Il2CppClassPointerStore<StringIntPair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "StringIntPair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringIntPair>.NativeClassPtr);
			StringIntPair.NativeFieldInfoPtr_String = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringIntPair>.NativeClassPtr, "String");
			StringIntPair.NativeFieldInfoPtr_Int = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringIntPair>.NativeClassPtr, "Int");
			StringIntPair.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringIntPair>.NativeClassPtr, 100675201);
			StringIntPair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringIntPair>.NativeClassPtr, 100675202);
		}

		// Token: 0x06005B23 RID: 23331 RVA: 0x001B5AE4 File Offset: 0x001B3CE4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 123667, RefRangeEnd = 123677, XrefRangeStart = 123667, XrefRangeEnd = 123677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringIntPair(string str, int i) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringIntPair>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringIntPair.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005B24 RID: 23332 RVA: 0x001B5B40 File Offset: 0x001B3D40
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringIntPair() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringIntPair>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringIntPair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005B25 RID: 23333 RVA: 0x0002B26A File Offset: 0x0002946A
		public StringIntPair(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C1A RID: 7194
		// (get) Token: 0x06005B26 RID: 23334 RVA: 0x001B5B7C File Offset: 0x001B3D7C
		// (set) Token: 0x06005B27 RID: 23335 RVA: 0x0002B273 File Offset: 0x00029473
		public unsafe string String
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringIntPair.NativeFieldInfoPtr_String);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringIntPair.NativeFieldInfoPtr_String), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001C1B RID: 7195
		// (get) Token: 0x06005B28 RID: 23336 RVA: 0x001B5BA4 File Offset: 0x001B3DA4
		// (set) Token: 0x06005B29 RID: 23337 RVA: 0x0002B292 File Offset: 0x00029492
		public unsafe int Int
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringIntPair.NativeFieldInfoPtr_Int);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringIntPair.NativeFieldInfoPtr_Int)) = value;
			}
		}

		// Token: 0x04003E7C RID: 15996
		private static readonly IntPtr NativeFieldInfoPtr_String;

		// Token: 0x04003E7D RID: 15997
		private static readonly IntPtr NativeFieldInfoPtr_Int;

		// Token: 0x04003E7E RID: 15998
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;

		// Token: 0x04003E7F RID: 15999
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
