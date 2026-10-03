using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000115 RID: 277
	public class PropertyNameUtils : Object
	{
		// Token: 0x060016C2 RID: 5826 RVA: 0x00063228 File Offset: 0x00061428
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyNameUtils()
		{
			Il2CppClassPointerStore<PropertyNameUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "PropertyNameUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyNameUtils>.NativeClassPtr);
			PropertyNameUtils.NativeMethodInfoPtr_PropertyNameFromString_Public_Static_PropertyName_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyNameUtils>.NativeClassPtr, 100665682);
			PropertyNameUtils.NativeMethodInfoPtr_PropertyNameFromString_Injected_Private_Static_Void_String_byref_PropertyName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyNameUtils>.NativeClassPtr, 100665683);
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x00063280 File Offset: 0x00061480
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 1246068, RefRangeEnd = 1246088, XrefRangeStart = 1246066, XrefRangeEnd = 1246068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertyName PropertyNameFromString(string name)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyNameUtils.NativeMethodInfoPtr_PropertyNameFromString_Public_Static_PropertyName_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x000632C4 File Offset: 0x000614C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246088, XrefRangeEnd = 1246090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PropertyNameFromString_Injected(string name, out PropertyName ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyNameUtils.NativeMethodInfoPtr_PropertyNameFromString_Injected_Private_Static_Void_String_byref_PropertyName_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x0000B6F7 File Offset: 0x000098F7
		public PropertyNameUtils(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001374 RID: 4980
		private static readonly IntPtr NativeMethodInfoPtr_PropertyNameFromString_Public_Static_PropertyName_String_0;

		// Token: 0x04001375 RID: 4981
		private static readonly IntPtr NativeMethodInfoPtr_PropertyNameFromString_Injected_Private_Static_Void_String_byref_PropertyName_0;
	}
}
