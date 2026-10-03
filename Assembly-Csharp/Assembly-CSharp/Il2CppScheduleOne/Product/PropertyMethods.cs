using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x02000551 RID: 1361
	public static class PropertyMethods : Il2CppSystem.Object
	{
		// Token: 0x06007BEC RID: 31724 RVA: 0x00223710 File Offset: 0x00221910
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyMethods()
		{
			Il2CppClassPointerStore<PropertyMethods>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "PropertyMethods");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyMethods>.NativeClassPtr);
			PropertyMethods.NativeMethodInfoPtr_GetName_Public_Static_String_EProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyMethods>.NativeClassPtr, 100679212);
			PropertyMethods.NativeMethodInfoPtr_GetDescription_Public_Static_String_EProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyMethods>.NativeClassPtr, 100679213);
			PropertyMethods.NativeMethodInfoPtr_GetColor_Public_Static_Color_EProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyMethods>.NativeClassPtr, 100679214);
		}

		// Token: 0x06007BED RID: 31725 RVA: 0x0022377C File Offset: 0x0022197C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236137, XrefRangeEnd = 236138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetName(this EProperty property)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref property;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyMethods.NativeMethodInfoPtr_GetName_Public_Static_String_EProperty_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06007BEE RID: 31726 RVA: 0x002237B4 File Offset: 0x002219B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236138, XrefRangeEnd = 236139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetDescription(this EProperty property)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref property;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyMethods.NativeMethodInfoPtr_GetDescription_Public_Static_String_EProperty_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06007BEF RID: 31727 RVA: 0x002237EC File Offset: 0x002219EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236139, XrefRangeEnd = 236140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color GetColor(this EProperty property)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref property;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyMethods.NativeMethodInfoPtr_GetColor_Public_Static_Color_EProperty_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007BF0 RID: 31728 RVA: 0x0003B04F File Offset: 0x0003924F
		public PropertyMethods(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005485 RID: 21637
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Static_String_EProperty_0;

		// Token: 0x04005486 RID: 21638
		private static readonly IntPtr NativeMethodInfoPtr_GetDescription_Public_Static_String_EProperty_0;

		// Token: 0x04005487 RID: 21639
		private static readonly IntPtr NativeMethodInfoPtr_GetColor_Public_Static_Color_EProperty_0;
	}
}
