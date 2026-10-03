using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x020007F3 RID: 2035
	public class ConfirmOverwriteScreen : MenuScreen
	{
		// Token: 0x0600C64B RID: 50763 RVA: 0x00324054 File Offset: 0x00322254
		// Note: this type is marked as 'beforefieldinit'.
		static ConfirmOverwriteScreen()
		{
			Il2CppClassPointerStore<ConfirmOverwriteScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "ConfirmOverwriteScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfirmOverwriteScreen>.NativeClassPtr);
			ConfirmOverwriteScreen.NativeFieldInfoPtr_SetupScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmOverwriteScreen>.NativeClassPtr, "SetupScreen");
			ConfirmOverwriteScreen.NativeFieldInfoPtr_slotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmOverwriteScreen>.NativeClassPtr, "slotIndex");
			ConfirmOverwriteScreen.NativeMethodInfoPtr_Initialize_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmOverwriteScreen>.NativeClassPtr, 100688990);
			ConfirmOverwriteScreen.NativeMethodInfoPtr_Confirm_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmOverwriteScreen>.NativeClassPtr, 100688991);
			ConfirmOverwriteScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmOverwriteScreen>.NativeClassPtr, 100688992);
		}

		// Token: 0x0600C64C RID: 50764 RVA: 0x003240E8 File Offset: 0x003222E8
		[CallerCount(0)]
		public unsafe void Initialize(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmOverwriteScreen.NativeMethodInfoPtr_Initialize_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C64D RID: 50765 RVA: 0x00324128 File Offset: 0x00322328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327637, XrefRangeEnd = 327640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Confirm()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmOverwriteScreen.NativeMethodInfoPtr_Confirm_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C64E RID: 50766 RVA: 0x0032415C File Offset: 0x0032235C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327636, RefRangeEnd = 327637, XrefRangeStart = 327636, XrefRangeEnd = 327637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfirmOverwriteScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfirmOverwriteScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmOverwriteScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C64F RID: 50767 RVA: 0x0005D98A File Offset: 0x0005BB8A
		public ConfirmOverwriteScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003C2F RID: 15407
		// (get) Token: 0x0600C650 RID: 50768 RVA: 0x00324198 File Offset: 0x00322398
		// (set) Token: 0x0600C651 RID: 50769 RVA: 0x0005D993 File Offset: 0x0005BB93
		public unsafe SetupScreen SetupScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOverwriteScreen.NativeFieldInfoPtr_SetupScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetupScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOverwriteScreen.NativeFieldInfoPtr_SetupScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C30 RID: 15408
		// (get) Token: 0x0600C652 RID: 50770 RVA: 0x003241C8 File Offset: 0x003223C8
		// (set) Token: 0x0600C653 RID: 50771 RVA: 0x0005D9B2 File Offset: 0x0005BBB2
		public unsafe int slotIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOverwriteScreen.NativeFieldInfoPtr_slotIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOverwriteScreen.NativeFieldInfoPtr_slotIndex)) = value;
			}
		}

		// Token: 0x04008747 RID: 34631
		private static readonly IntPtr NativeFieldInfoPtr_SetupScreen;

		// Token: 0x04008748 RID: 34632
		private static readonly IntPtr NativeFieldInfoPtr_slotIndex;

		// Token: 0x04008749 RID: 34633
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Int32_0;

		// Token: 0x0400874A RID: 34634
		private static readonly IntPtr NativeMethodInfoPtr_Confirm_Public_Void_0;

		// Token: 0x0400874B RID: 34635
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
