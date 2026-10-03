using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.UI.MainMenu;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne
{
	// Token: 0x020000C6 RID: 198
	public class CommandListScreen : MenuScreen
	{
		// Token: 0x06001218 RID: 4632 RVA: 0x000B7C14 File Offset: 0x000B5E14
		// Note: this type is marked as 'beforefieldinit'.
		static CommandListScreen()
		{
			Il2CppClassPointerStore<CommandListScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "CommandListScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandListScreen>.NativeClassPtr);
			CommandListScreen.NativeFieldInfoPtr_CommandEntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandListScreen>.NativeClassPtr, "CommandEntryContainer");
			CommandListScreen.NativeFieldInfoPtr_CommandEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandListScreen>.NativeClassPtr, "CommandEntryPrefab");
			CommandListScreen.NativeFieldInfoPtr_commandEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandListScreen>.NativeClassPtr, "commandEntries");
			CommandListScreen.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandListScreen>.NativeClassPtr, 100665947);
			CommandListScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandListScreen>.NativeClassPtr, 100665948);
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x000B7CA8 File Offset: 0x000B5EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90905, XrefRangeEnd = 90955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandListScreen.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x000B7CDC File Offset: 0x000B5EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90955, XrefRangeEnd = 90963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CommandListScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommandListScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandListScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600121B RID: 4635 RVA: 0x0000A28A File Offset: 0x0000848A
		public CommandListScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x0600121C RID: 4636 RVA: 0x000B7D18 File Offset: 0x000B5F18
		// (set) Token: 0x0600121D RID: 4637 RVA: 0x0000A293 File Offset: 0x00008493
		public unsafe RectTransform CommandEntryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandListScreen.NativeFieldInfoPtr_CommandEntryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandListScreen.NativeFieldInfoPtr_CommandEntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x0600121E RID: 4638 RVA: 0x000B7D48 File Offset: 0x000B5F48
		// (set) Token: 0x0600121F RID: 4639 RVA: 0x0000A2B2 File Offset: 0x000084B2
		public unsafe RectTransform CommandEntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandListScreen.NativeFieldInfoPtr_CommandEntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandListScreen.NativeFieldInfoPtr_CommandEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06001220 RID: 4640 RVA: 0x000B7D78 File Offset: 0x000B5F78
		// (set) Token: 0x06001221 RID: 4641 RVA: 0x0000A2D1 File Offset: 0x000084D1
		public unsafe List<RectTransform> commandEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandListScreen.NativeFieldInfoPtr_commandEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandListScreen.NativeFieldInfoPtr_commandEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CAD RID: 3245
		private static readonly IntPtr NativeFieldInfoPtr_CommandEntryContainer;

		// Token: 0x04000CAE RID: 3246
		private static readonly IntPtr NativeFieldInfoPtr_CommandEntryPrefab;

		// Token: 0x04000CAF RID: 3247
		private static readonly IntPtr NativeFieldInfoPtr_commandEntries;

		// Token: 0x04000CB0 RID: 3248
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000CB1 RID: 3249
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
