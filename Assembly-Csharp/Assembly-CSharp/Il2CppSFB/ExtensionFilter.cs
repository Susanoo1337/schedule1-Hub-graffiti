using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSFB
{
	// Token: 0x0200007C RID: 124
	public sealed class ExtensionFilter : ValueType
	{
		// Token: 0x06000940 RID: 2368 RVA: 0x00099534 File Offset: 0x00097734
		// Note: this type is marked as 'beforefieldinit'.
		static ExtensionFilter()
		{
			Il2CppClassPointerStore<ExtensionFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SFB", "ExtensionFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExtensionFilter>.NativeClassPtr);
			ExtensionFilter.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtensionFilter>.NativeClassPtr, "Name");
			ExtensionFilter.NativeFieldInfoPtr_Extensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtensionFilter>.NativeClassPtr, "Extensions");
			ExtensionFilter.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtensionFilter>.NativeClassPtr, 100664482);
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x000995A0 File Offset: 0x000977A0
		[CallerCount(80)]
		[CachedScanResults(RefRangeStart = 62123, RefRangeEnd = 62203, XrefRangeStart = 62123, XrefRangeEnd = 62203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExtensionFilter(string filterName, [Optional] Il2CppStringArray filterExtensions)
		{
			if (filterExtensions == null)
			{
				filterExtensions = new Il2CppStringArray(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExtensionFilter>.NativeClassPtr));
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(filterName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filterExtensions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtensionFilter.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStringArray_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x0000645B File Offset: 0x0000465B
		public ExtensionFilter(string filterName, params string[] filterExtensions) : this(filterName, new Il2CppStringArray(filterExtensions))
		{
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x0000646A File Offset: 0x0000466A
		public ExtensionFilter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x00006473 File Offset: 0x00004673
		public ExtensionFilter() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExtensionFilter>.NativeClassPtr))
		{
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000945 RID: 2373 RVA: 0x00099610 File Offset: 0x00097810
		// (set) Token: 0x06000946 RID: 2374 RVA: 0x00006485 File Offset: 0x00004685
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtensionFilter.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtensionFilter.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000947 RID: 2375 RVA: 0x00099638 File Offset: 0x00097838
		// (set) Token: 0x06000948 RID: 2376 RVA: 0x000064A4 File Offset: 0x000046A4
		public unsafe Il2CppStringArray Extensions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtensionFilter.NativeFieldInfoPtr_Extensions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtensionFilter.NativeFieldInfoPtr_Extensions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000681 RID: 1665
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04000682 RID: 1666
		private static readonly IntPtr NativeFieldInfoPtr_Extensions;

		// Token: 0x04000683 RID: 1667
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStringArray_0;
	}
}
