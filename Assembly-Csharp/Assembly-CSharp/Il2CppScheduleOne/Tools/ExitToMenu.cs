using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004DF RID: 1247
	public class ExitToMenu : MonoBehaviour
	{
		// Token: 0x060071A6 RID: 29094 RVA: 0x00200D80 File Offset: 0x001FEF80
		// Note: this type is marked as 'beforefieldinit'.
		static ExitToMenu()
		{
			Il2CppClassPointerStore<ExitToMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "ExitToMenu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExitToMenu>.NativeClassPtr);
			ExitToMenu.NativeMethodInfoPtr_Exit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitToMenu>.NativeClassPtr, 100677980);
			ExitToMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitToMenu>.NativeClassPtr, 100677981);
		}

		// Token: 0x060071A7 RID: 29095 RVA: 0x00200DD8 File Offset: 0x001FEFD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225567, XrefRangeEnd = 225572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitToMenu.NativeMethodInfoPtr_Exit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071A8 RID: 29096 RVA: 0x00200E0C File Offset: 0x001FF00C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExitToMenu() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExitToMenu>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitToMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071A9 RID: 29097 RVA: 0x0003612C File Offset: 0x0003432C
		public ExitToMenu(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004DAA RID: 19882
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Void_0;

		// Token: 0x04004DAB RID: 19883
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
