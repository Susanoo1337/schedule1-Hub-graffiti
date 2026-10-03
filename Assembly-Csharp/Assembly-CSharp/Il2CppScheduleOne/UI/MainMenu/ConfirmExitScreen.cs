using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x020007F2 RID: 2034
	public class ConfirmExitScreen : MenuScreen
	{
		// Token: 0x0600C644 RID: 50756 RVA: 0x00323F00 File Offset: 0x00322100
		// Note: this type is marked as 'beforefieldinit'.
		static ConfirmExitScreen()
		{
			Il2CppClassPointerStore<ConfirmExitScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "ConfirmExitScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfirmExitScreen>.NativeClassPtr);
			ConfirmExitScreen.NativeFieldInfoPtr_TimeSinceSaveLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmExitScreen>.NativeClassPtr, "TimeSinceSaveLabel");
			ConfirmExitScreen.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmExitScreen>.NativeClassPtr, 100688987);
			ConfirmExitScreen.NativeMethodInfoPtr_ConfirmExit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmExitScreen>.NativeClassPtr, 100688988);
			ConfirmExitScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmExitScreen>.NativeClassPtr, 100688989);
		}

		// Token: 0x0600C645 RID: 50757 RVA: 0x00323F80 File Offset: 0x00322180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327615, XrefRangeEnd = 327628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmExitScreen.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C646 RID: 50758 RVA: 0x00323FB4 File Offset: 0x003221B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327628, XrefRangeEnd = 327635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfirmExit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmExitScreen.NativeMethodInfoPtr_ConfirmExit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C647 RID: 50759 RVA: 0x00323FE8 File Offset: 0x003221E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327636, RefRangeEnd = 327637, XrefRangeStart = 327635, XrefRangeEnd = 327636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfirmExitScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfirmExitScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmExitScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C648 RID: 50760 RVA: 0x0005D962 File Offset: 0x0005BB62
		public ConfirmExitScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003C2E RID: 15406
		// (get) Token: 0x0600C649 RID: 50761 RVA: 0x00324024 File Offset: 0x00322224
		// (set) Token: 0x0600C64A RID: 50762 RVA: 0x0005D96B File Offset: 0x0005BB6B
		public unsafe TextMeshProUGUI TimeSinceSaveLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmExitScreen.NativeFieldInfoPtr_TimeSinceSaveLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmExitScreen.NativeFieldInfoPtr_TimeSinceSaveLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008743 RID: 34627
		private static readonly IntPtr NativeFieldInfoPtr_TimeSinceSaveLabel;

		// Token: 0x04008744 RID: 34628
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04008745 RID: 34629
		private static readonly IntPtr NativeMethodInfoPtr_ConfirmExit_Public_Void_0;

		// Token: 0x04008746 RID: 34630
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
