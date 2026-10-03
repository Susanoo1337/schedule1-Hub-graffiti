using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x02000458 RID: 1112
	public class ActivateDuringBuild : MonoBehaviour
	{
		// Token: 0x060064ED RID: 25837 RVA: 0x0002F8BE File Offset: 0x0002DABE
		// Note: this type is marked as 'beforefieldinit'.
		static ActivateDuringBuild()
		{
			Il2CppClassPointerStore<ActivateDuringBuild>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "ActivateDuringBuild");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivateDuringBuild>.NativeClassPtr);
			ActivateDuringBuild.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivateDuringBuild>.NativeClassPtr, 100676551);
		}

		// Token: 0x060064EE RID: 25838 RVA: 0x001D90B8 File Offset: 0x001D72B8
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActivateDuringBuild() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivateDuringBuild>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivateDuringBuild.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064EF RID: 25839 RVA: 0x0002F8F7 File Offset: 0x0002DAF7
		public ActivateDuringBuild(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004591 RID: 17809
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
