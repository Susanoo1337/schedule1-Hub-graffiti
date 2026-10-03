using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x020003E5 RID: 997
	public static class AssetPathUtility : Il2CppSystem.Object
	{
		// Token: 0x060058ED RID: 22765 RVA: 0x0002A126 File Offset: 0x00028326
		// Note: this type is marked as 'beforefieldinit'.
		static AssetPathUtility()
		{
			Il2CppClassPointerStore<AssetPathUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "AssetPathUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetPathUtility>.NativeClassPtr);
			AssetPathUtility.NativeMethodInfoPtr_GetResourcesPath_Public_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetPathUtility>.NativeClassPtr, 100674961);
		}

		// Token: 0x060058EE RID: 22766 RVA: 0x001AEA60 File Offset: 0x001ACC60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193667, XrefRangeEnd = 193669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetResourcesPath(UnityEngine.Object selectedObject)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectedObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetPathUtility.NativeMethodInfoPtr_GetResourcesPath_Public_Static_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060058EF RID: 22767 RVA: 0x0002A15F File Offset: 0x0002835F
		public AssetPathUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003D1B RID: 15643
		private static readonly IntPtr NativeMethodInfoPtr_GetResourcesPath_Public_Static_String_Object_0;
	}
}
