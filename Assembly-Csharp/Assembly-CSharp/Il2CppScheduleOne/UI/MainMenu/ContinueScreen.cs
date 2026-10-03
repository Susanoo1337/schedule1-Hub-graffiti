using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x020007F4 RID: 2036
	public class ContinueScreen : MenuScreen
	{
		// Token: 0x0600C654 RID: 50772 RVA: 0x003241F0 File Offset: 0x003223F0
		// Note: this type is marked as 'beforefieldinit'.
		static ContinueScreen()
		{
			Il2CppClassPointerStore<ContinueScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "ContinueScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContinueScreen>.NativeClassPtr);
			ContinueScreen.NativeFieldInfoPtr_NotHostWarning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueScreen>.NativeClassPtr, "NotHostWarning");
			ContinueScreen.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueScreen>.NativeClassPtr, 100688993);
			ContinueScreen.NativeMethodInfoPtr_LoadGame_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueScreen>.NativeClassPtr, 100688994);
			ContinueScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueScreen>.NativeClassPtr, 100688995);
		}

		// Token: 0x0600C655 RID: 50773 RVA: 0x00324270 File Offset: 0x00322470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327640, XrefRangeEnd = 327647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueScreen.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C656 RID: 50774 RVA: 0x003242A4 File Offset: 0x003224A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327647, XrefRangeEnd = 327663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadGame(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueScreen.NativeMethodInfoPtr_LoadGame_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C657 RID: 50775 RVA: 0x003242E4 File Offset: 0x003224E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327636, RefRangeEnd = 327637, XrefRangeStart = 327636, XrefRangeEnd = 327637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContinueScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContinueScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C658 RID: 50776 RVA: 0x0005D9CD File Offset: 0x0005BBCD
		public ContinueScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003C31 RID: 15409
		// (get) Token: 0x0600C659 RID: 50777 RVA: 0x00324320 File Offset: 0x00322520
		// (set) Token: 0x0600C65A RID: 50778 RVA: 0x0005D9D6 File Offset: 0x0005BBD6
		public unsafe RectTransform NotHostWarning
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueScreen.NativeFieldInfoPtr_NotHostWarning);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueScreen.NativeFieldInfoPtr_NotHostWarning), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400874C RID: 34636
		private static readonly IntPtr NativeFieldInfoPtr_NotHostWarning;

		// Token: 0x0400874D RID: 34637
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400874E RID: 34638
		private static readonly IntPtr NativeMethodInfoPtr_LoadGame_Public_Void_Int32_0;

		// Token: 0x0400874F RID: 34639
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
