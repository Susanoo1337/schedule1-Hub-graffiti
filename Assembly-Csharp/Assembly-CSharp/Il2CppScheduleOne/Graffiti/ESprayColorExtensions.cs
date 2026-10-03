using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Graffiti
{
	// Token: 0x02000367 RID: 871
	public static class ESprayColorExtensions : Il2CppSystem.Object
	{
		// Token: 0x0600499B RID: 18843 RVA: 0x00023B5C File Offset: 0x00021D5C
		// Note: this type is marked as 'beforefieldinit'.
		static ESprayColorExtensions()
		{
			Il2CppClassPointerStore<ESprayColorExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Graffiti", "ESprayColorExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ESprayColorExtensions>.NativeClassPtr);
			ESprayColorExtensions.NativeMethodInfoPtr_GetColor_Public_Static_Color_ESprayColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ESprayColorExtensions>.NativeClassPtr, 100672733);
		}

		// Token: 0x0600499C RID: 18844 RVA: 0x00175A7C File Offset: 0x00173C7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169164, RefRangeEnd = 169165, XrefRangeStart = 169164, XrefRangeEnd = 169164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color GetColor(this ESprayColor color)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ESprayColorExtensions.NativeMethodInfoPtr_GetColor_Public_Static_Color_ESprayColor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600499D RID: 18845 RVA: 0x00023B95 File Offset: 0x00021D95
		public ESprayColorExtensions(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003213 RID: 12819
		private static readonly IntPtr NativeMethodInfoPtr_GetColor_Public_Static_Color_ESprayColor_0;
	}
}
