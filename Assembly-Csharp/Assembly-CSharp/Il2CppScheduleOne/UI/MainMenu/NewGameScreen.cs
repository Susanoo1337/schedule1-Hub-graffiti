using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x020007FC RID: 2044
	public class NewGameScreen : MenuScreen
	{
		// Token: 0x0600C6D3 RID: 50899 RVA: 0x003258B0 File Offset: 0x00323AB0
		// Note: this type is marked as 'beforefieldinit'.
		static NewGameScreen()
		{
			Il2CppClassPointerStore<NewGameScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "NewGameScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewGameScreen>.NativeClassPtr);
			NewGameScreen.NativeFieldInfoPtr_ConfirmOverwriteScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameScreen>.NativeClassPtr, "ConfirmOverwriteScreen");
			NewGameScreen.NativeFieldInfoPtr_SetupScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameScreen>.NativeClassPtr, "SetupScreen");
			NewGameScreen.NativeMethodInfoPtr_SlotSelected_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameScreen>.NativeClassPtr, 100689047);
			NewGameScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameScreen>.NativeClassPtr, 100689048);
		}

		// Token: 0x0600C6D4 RID: 50900 RVA: 0x00325930 File Offset: 0x00323B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328117, XrefRangeEnd = 328126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SlotSelected(int slotIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref slotIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewGameScreen.NativeMethodInfoPtr_SlotSelected_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C6D5 RID: 50901 RVA: 0x00325970 File Offset: 0x00323B70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327636, RefRangeEnd = 327637, XrefRangeStart = 327636, XrefRangeEnd = 327637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NewGameScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewGameScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewGameScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C6D6 RID: 50902 RVA: 0x0005DE19 File Offset: 0x0005C019
		public NewGameScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003C57 RID: 15447
		// (get) Token: 0x0600C6D7 RID: 50903 RVA: 0x003259AC File Offset: 0x00323BAC
		// (set) Token: 0x0600C6D8 RID: 50904 RVA: 0x0005DE22 File Offset: 0x0005C022
		public unsafe ConfirmOverwriteScreen ConfirmOverwriteScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewGameScreen.NativeFieldInfoPtr_ConfirmOverwriteScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfirmOverwriteScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewGameScreen.NativeFieldInfoPtr_ConfirmOverwriteScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C58 RID: 15448
		// (get) Token: 0x0600C6D9 RID: 50905 RVA: 0x003259DC File Offset: 0x00323BDC
		// (set) Token: 0x0600C6DA RID: 50906 RVA: 0x0005DE41 File Offset: 0x0005C041
		public unsafe SetupScreen SetupScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewGameScreen.NativeFieldInfoPtr_SetupScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetupScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewGameScreen.NativeFieldInfoPtr_SetupScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008797 RID: 34711
		private static readonly IntPtr NativeFieldInfoPtr_ConfirmOverwriteScreen;

		// Token: 0x04008798 RID: 34712
		private static readonly IntPtr NativeFieldInfoPtr_SetupScreen;

		// Token: 0x04008799 RID: 34713
		private static readonly IntPtr NativeMethodInfoPtr_SlotSelected_Public_Void_Int32_0;

		// Token: 0x0400879A RID: 34714
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
