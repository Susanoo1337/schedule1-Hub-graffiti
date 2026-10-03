using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x02000469 RID: 1129
	public class OverrideGhostMaterial : MonoBehaviour
	{
		// Token: 0x060065F8 RID: 26104 RVA: 0x00030033 File Offset: 0x0002E233
		// Note: this type is marked as 'beforefieldinit'.
		static OverrideGhostMaterial()
		{
			Il2CppClassPointerStore<OverrideGhostMaterial>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "OverrideGhostMaterial");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OverrideGhostMaterial>.NativeClassPtr);
			OverrideGhostMaterial.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverrideGhostMaterial>.NativeClassPtr, 100676671);
		}

		// Token: 0x060065F9 RID: 26105 RVA: 0x001DCB04 File Offset: 0x001DAD04
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OverrideGhostMaterial() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverrideGhostMaterial>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverrideGhostMaterial.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065FA RID: 26106 RVA: 0x0003006C File Offset: 0x0002E26C
		public OverrideGhostMaterial(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400463F RID: 17983
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
