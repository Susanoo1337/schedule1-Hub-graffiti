using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x02000462 RID: 1122
	public class BuildUpdate_Base : MonoBehaviour
	{
		// Token: 0x0600655E RID: 25950 RVA: 0x001DAB1C File Offset: 0x001D8D1C
		// Note: this type is marked as 'beforefieldinit'.
		static BuildUpdate_Base()
		{
			Il2CppClassPointerStore<BuildUpdate_Base>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildUpdate_Base");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildUpdate_Base>.NativeClassPtr);
			BuildUpdate_Base.NativeMethodInfoPtr_Stop_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Base>.NativeClassPtr, 100676609);
			BuildUpdate_Base.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Base>.NativeClassPtr, 100676610);
		}

		// Token: 0x0600655F RID: 25951 RVA: 0x001DAB74 File Offset: 0x001D8D74
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Base.NativeMethodInfoPtr_Stop_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006560 RID: 25952 RVA: 0x001DABB0 File Offset: 0x001D8DB0
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildUpdate_Base() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildUpdate_Base>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Base.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006561 RID: 25953 RVA: 0x0002FB7D File Offset: 0x0002DD7D
		public BuildUpdate_Base(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040045DB RID: 17883
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Virtual_New_Void_0;

		// Token: 0x040045DC RID: 17884
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
