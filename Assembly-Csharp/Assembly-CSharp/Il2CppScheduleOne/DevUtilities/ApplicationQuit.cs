using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x020003E4 RID: 996
	public class ApplicationQuit : MonoBehaviour
	{
		// Token: 0x060058E9 RID: 22761 RVA: 0x001AE998 File Offset: 0x001ACB98
		// Note: this type is marked as 'beforefieldinit'.
		static ApplicationQuit()
		{
			Il2CppClassPointerStore<ApplicationQuit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "ApplicationQuit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ApplicationQuit>.NativeClassPtr);
			ApplicationQuit.NativeMethodInfoPtr_Quit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationQuit>.NativeClassPtr, 100674959);
			ApplicationQuit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationQuit>.NativeClassPtr, 100674960);
		}

		// Token: 0x060058EA RID: 22762 RVA: 0x001AE9F0 File Offset: 0x001ACBF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193663, XrefRangeEnd = 193667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Quit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationQuit.NativeMethodInfoPtr_Quit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058EB RID: 22763 RVA: 0x001AEA24 File Offset: 0x001ACC24
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ApplicationQuit() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ApplicationQuit>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationQuit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058EC RID: 22764 RVA: 0x0002A11D File Offset: 0x0002831D
		public ApplicationQuit(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003D19 RID: 15641
		private static readonly IntPtr NativeMethodInfoPtr_Quit_Public_Void_0;

		// Token: 0x04003D1A RID: 15642
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
