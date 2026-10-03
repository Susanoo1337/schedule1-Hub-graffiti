using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x02000460 RID: 1120
	public class BuildStop_Base : MonoBehaviour
	{
		// Token: 0x06006549 RID: 25929 RVA: 0x001DA61C File Offset: 0x001D881C
		// Note: this type is marked as 'beforefieldinit'.
		static BuildStop_Base()
		{
			Il2CppClassPointerStore<BuildStop_Base>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildStop_Base");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildStop_Base>.NativeClassPtr);
			BuildStop_Base.NativeMethodInfoPtr_Stop_Building_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStop_Base>.NativeClassPtr, 100676598);
			BuildStop_Base.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStop_Base>.NativeClassPtr, 100676599);
		}

		// Token: 0x0600654A RID: 25930 RVA: 0x001DA674 File Offset: 0x001D8874
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212091, RefRangeEnd = 212092, XrefRangeStart = 212061, XrefRangeEnd = 212091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Stop_Building()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildStop_Base.NativeMethodInfoPtr_Stop_Building_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600654B RID: 25931 RVA: 0x001DA6B0 File Offset: 0x001D88B0
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildStop_Base() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildStop_Base>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildStop_Base.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600654C RID: 25932 RVA: 0x0002FB12 File Offset: 0x0002DD12
		public BuildStop_Base(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040045CD RID: 17869
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Building_Public_Virtual_New_Void_0;

		// Token: 0x040045CE RID: 17870
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
