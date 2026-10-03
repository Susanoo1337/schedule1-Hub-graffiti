using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x020003F2 RID: 1010
	public static class LayerUtility : Il2CppSystem.Object
	{
		// Token: 0x060059E9 RID: 23017 RVA: 0x0002AA34 File Offset: 0x00028C34
		// Note: this type is marked as 'beforefieldinit'.
		static LayerUtility()
		{
			Il2CppClassPointerStore<LayerUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "LayerUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LayerUtility>.NativeClassPtr);
			LayerUtility.NativeMethodInfoPtr_SetLayerRecursively_Public_Static_Void_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerUtility>.NativeClassPtr, 100675061);
		}

		// Token: 0x060059EA RID: 23018 RVA: 0x001B1964 File Offset: 0x001AFB64
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 194578, RefRangeEnd = 194609, XrefRangeStart = 194572, XrefRangeEnd = 194578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetLayerRecursively(GameObject go, int layerNumber)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayerUtility.NativeMethodInfoPtr_SetLayerRecursively_Public_Static_Void_GameObject_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060059EB RID: 23019 RVA: 0x0002AA6D File Offset: 0x00028C6D
		public LayerUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003DB5 RID: 15797
		private static readonly IntPtr NativeMethodInfoPtr_SetLayerRecursively_Public_Static_Void_GameObject_Int32_0;
	}
}
