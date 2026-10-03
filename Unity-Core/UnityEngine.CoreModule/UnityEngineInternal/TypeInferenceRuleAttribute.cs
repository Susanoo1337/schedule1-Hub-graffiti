using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngineInternal
{
	// Token: 0x02000008 RID: 8
	[Serializable]
	public class TypeInferenceRuleAttribute : Attribute
	{
		// Token: 0x06000012 RID: 18 RVA: 0x00018A94 File Offset: 0x00016C94
		// Note: this type is marked as 'beforefieldinit'.
		static TypeInferenceRuleAttribute()
		{
			Il2CppClassPointerStore<TypeInferenceRuleAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngineInternal", "TypeInferenceRuleAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeInferenceRuleAttribute>.NativeClassPtr);
			TypeInferenceRuleAttribute.NativeFieldInfoPtr__rule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeInferenceRuleAttribute>.NativeClassPtr, "_rule");
			TypeInferenceRuleAttribute.NativeMethodInfoPtr__ctor_Public_Void_TypeInferenceRules_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInferenceRuleAttribute>.NativeClassPtr, 100663301);
			TypeInferenceRuleAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInferenceRuleAttribute>.NativeClassPtr, 100663302);
			TypeInferenceRuleAttribute.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInferenceRuleAttribute>.NativeClassPtr, 100663303);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00018B14 File Offset: 0x00016D14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224714, XrefRangeEnd = 1224719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeInferenceRuleAttribute(TypeInferenceRules rule) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeInferenceRuleAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rule;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeInferenceRuleAttribute.NativeMethodInfoPtr__ctor_Public_Void_TypeInferenceRules_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00018B5C File Offset: 0x00016D5C
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 31934, RefRangeEnd = 31959, XrefRangeStart = 31934, XrefRangeEnd = 31959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeInferenceRuleAttribute(string rule) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeInferenceRuleAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(rule);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeInferenceRuleAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00018BA8 File Offset: 0x00016DA8
		[CallerCount(179)]
		[CachedScanResults(RefRangeStart = 666825, RefRangeEnd = 667004, XrefRangeStart = 666825, XrefRangeEnd = 667004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeInferenceRuleAttribute.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002152 File Offset: 0x00000352
		public TypeInferenceRuleAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00018BEC File Offset: 0x00016DEC
		// (set) Token: 0x06000018 RID: 24 RVA: 0x0000215B File Offset: 0x0000035B
		public unsafe string _rule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInferenceRuleAttribute.NativeFieldInfoPtr__rule);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInferenceRuleAttribute.NativeFieldInfoPtr__rule), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeFieldInfoPtr__rule;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TypeInferenceRules_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
