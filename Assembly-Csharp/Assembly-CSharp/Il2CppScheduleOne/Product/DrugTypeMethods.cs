using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x0200054E RID: 1358
	public static class DrugTypeMethods : Il2CppSystem.Object
	{
		// Token: 0x06007BE3 RID: 31715 RVA: 0x00223584 File Offset: 0x00221784
		// Note: this type is marked as 'beforefieldinit'.
		static DrugTypeMethods()
		{
			Il2CppClassPointerStore<DrugTypeMethods>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "DrugTypeMethods");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrugTypeMethods>.NativeClassPtr);
			DrugTypeMethods.NativeMethodInfoPtr_GetName_Public_Static_String_EDrugType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrugTypeMethods>.NativeClassPtr, 100679209);
			DrugTypeMethods.NativeMethodInfoPtr_GetColor_Public_Static_Color_EDrugType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrugTypeMethods>.NativeClassPtr, 100679210);
		}

		// Token: 0x06007BE4 RID: 31716 RVA: 0x002235DC File Offset: 0x002217DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236133, RefRangeEnd = 236134, XrefRangeStart = 236132, XrefRangeEnd = 236133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetName(this EDrugType property)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref property;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrugTypeMethods.NativeMethodInfoPtr_GetName_Public_Static_String_EDrugType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06007BE5 RID: 31717 RVA: 0x00223614 File Offset: 0x00221814
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 236135, RefRangeEnd = 236137, XrefRangeStart = 236134, XrefRangeEnd = 236135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color GetColor(this EDrugType property)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref property;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrugTypeMethods.NativeMethodInfoPtr_GetColor_Public_Static_Color_EDrugType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007BE6 RID: 31718 RVA: 0x0003B022 File Offset: 0x00039222
		public DrugTypeMethods(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400546F RID: 21615
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Static_String_EDrugType_0;

		// Token: 0x04005470 RID: 21616
		private static readonly IntPtr NativeMethodInfoPtr_GetColor_Public_Static_Color_EDrugType_0;
	}
}
