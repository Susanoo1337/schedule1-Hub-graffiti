using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Vision
{
	// Token: 0x0200019A RID: 410
	[Serializable]
	public class UniqueVisibilityAttribute : VisibilityAttribute
	{
		// Token: 0x0600295A RID: 10586 RVA: 0x00103C40 File Offset: 0x00101E40
		// Note: this type is marked as 'beforefieldinit'.
		static UniqueVisibilityAttribute()
		{
			Il2CppClassPointerStore<UniqueVisibilityAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vision", "UniqueVisibilityAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniqueVisibilityAttribute>.NativeClassPtr);
			UniqueVisibilityAttribute.NativeFieldInfoPtr_uniquenessCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniqueVisibilityAttribute>.NativeClassPtr, "uniquenessCode");
			UniqueVisibilityAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Single_String_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniqueVisibilityAttribute>.NativeClassPtr, 100668594);
		}

		// Token: 0x0600295B RID: 10587 RVA: 0x00103C98 File Offset: 0x00101E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122766, XrefRangeEnd = 122768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniqueVisibilityAttribute(string _name, float _pointsChange, string _uniquenessCode, float _multiplier = 1f, int attributeIndex = -1) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniqueVisibilityAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _pointsChange;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_uniquenessCode);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _multiplier;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref attributeIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniqueVisibilityAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Single_String_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600295C RID: 10588 RVA: 0x00015A7B File Offset: 0x00013C7B
		public UniqueVisibilityAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D92 RID: 3474
		// (get) Token: 0x0600295D RID: 10589 RVA: 0x00103D20 File Offset: 0x00101F20
		// (set) Token: 0x0600295E RID: 10590 RVA: 0x00015A84 File Offset: 0x00013C84
		public unsafe string uniquenessCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniqueVisibilityAttribute.NativeFieldInfoPtr_uniquenessCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniqueVisibilityAttribute.NativeFieldInfoPtr_uniquenessCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001C7A RID: 7290
		private static readonly IntPtr NativeFieldInfoPtr_uniquenessCode;

		// Token: 0x04001C7B RID: 7291
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_String_Single_Int32_0;
	}
}
