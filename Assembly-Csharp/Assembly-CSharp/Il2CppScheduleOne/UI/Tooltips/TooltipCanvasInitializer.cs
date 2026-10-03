using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Tooltips
{
	// Token: 0x02000778 RID: 1912
	public class TooltipCanvasInitializer : MonoBehaviour
	{
		// Token: 0x0600BA0F RID: 47631 RVA: 0x002FE628 File Offset: 0x002FC828
		// Note: this type is marked as 'beforefieldinit'.
		static TooltipCanvasInitializer()
		{
			Il2CppClassPointerStore<TooltipCanvasInitializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Tooltips", "TooltipCanvasInitializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TooltipCanvasInitializer>.NativeClassPtr);
			TooltipCanvasInitializer.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipCanvasInitializer>.NativeClassPtr, 100687593);
			TooltipCanvasInitializer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipCanvasInitializer>.NativeClassPtr, 100687594);
		}

		// Token: 0x0600BA10 RID: 47632 RVA: 0x002FE680 File Offset: 0x002FC880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310602, XrefRangeEnd = 310611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipCanvasInitializer.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BA11 RID: 47633 RVA: 0x002FE6B4 File Offset: 0x002FC8B4
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TooltipCanvasInitializer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TooltipCanvasInitializer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipCanvasInitializer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BA12 RID: 47634 RVA: 0x00056B1C File Offset: 0x00054D1C
		public TooltipCanvasInitializer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04007F95 RID: 32661
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04007F96 RID: 32662
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
