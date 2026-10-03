using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.UI.Handover;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000738 RID: 1848
	public class HandoverStackSplitTutorialOpener : MonoBehaviour
	{
		// Token: 0x0600B267 RID: 45671 RVA: 0x002E80C0 File Offset: 0x002E62C0
		// Note: this type is marked as 'beforefieldinit'.
		static HandoverStackSplitTutorialOpener()
		{
			Il2CppClassPointerStore<HandoverStackSplitTutorialOpener>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "HandoverStackSplitTutorialOpener");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandoverStackSplitTutorialOpener>.NativeClassPtr);
			HandoverStackSplitTutorialOpener.NativeFieldInfoPtr__tutorialOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverStackSplitTutorialOpener>.NativeClassPtr, "_tutorialOpened");
			HandoverStackSplitTutorialOpener.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverStackSplitTutorialOpener>.NativeClassPtr, 100686737);
			HandoverStackSplitTutorialOpener.NativeMethodInfoPtr_ScreenOpened_Private_Void_EMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverStackSplitTutorialOpener>.NativeClassPtr, 100686738);
			HandoverStackSplitTutorialOpener.NativeMethodInfoPtr_ScreenClose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverStackSplitTutorialOpener>.NativeClassPtr, 100686739);
			HandoverStackSplitTutorialOpener.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverStackSplitTutorialOpener>.NativeClassPtr, 100686740);
		}

		// Token: 0x0600B268 RID: 45672 RVA: 0x002E8154 File Offset: 0x002E6354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302003, XrefRangeEnd = 302023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverStackSplitTutorialOpener.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B269 RID: 45673 RVA: 0x002E8188 File Offset: 0x002E6388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302023, XrefRangeEnd = 302055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScreenOpened(HandoverScreen.EMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverStackSplitTutorialOpener.NativeMethodInfoPtr_ScreenOpened_Private_Void_EMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B26A RID: 45674 RVA: 0x002E81C8 File Offset: 0x002E63C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302055, XrefRangeEnd = 302061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScreenClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverStackSplitTutorialOpener.NativeMethodInfoPtr_ScreenClose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B26B RID: 45675 RVA: 0x002E81FC File Offset: 0x002E63FC
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HandoverStackSplitTutorialOpener() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandoverStackSplitTutorialOpener>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverStackSplitTutorialOpener.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B26C RID: 45676 RVA: 0x000521C8 File Offset: 0x000503C8
		public HandoverStackSplitTutorialOpener(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170035A6 RID: 13734
		// (get) Token: 0x0600B26D RID: 45677 RVA: 0x002E8238 File Offset: 0x002E6438
		// (set) Token: 0x0600B26E RID: 45678 RVA: 0x000521D1 File Offset: 0x000503D1
		public unsafe bool _tutorialOpened
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverStackSplitTutorialOpener.NativeFieldInfoPtr__tutorialOpened);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverStackSplitTutorialOpener.NativeFieldInfoPtr__tutorialOpened)) = value;
			}
		}

		// Token: 0x04007ADD RID: 31453
		private static readonly IntPtr NativeFieldInfoPtr__tutorialOpened;

		// Token: 0x04007ADE RID: 31454
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04007ADF RID: 31455
		private static readonly IntPtr NativeMethodInfoPtr_ScreenOpened_Private_Void_EMode_0;

		// Token: 0x04007AE0 RID: 31456
		private static readonly IntPtr NativeMethodInfoPtr_ScreenClose_Private_Void_0;

		// Token: 0x04007AE1 RID: 31457
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000CCB RID: 3275
		[ObfuscatedName("ScheduleOne.UI.HandoverStackSplitTutorialOpener+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600F4E5 RID: 62693 RVA: 0x003AD958 File Offset: 0x003ABB58
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<HandoverStackSplitTutorialOpener.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandoverStackSplitTutorialOpener>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandoverStackSplitTutorialOpener.__c>.NativeClassPtr);
				HandoverStackSplitTutorialOpener.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverStackSplitTutorialOpener.__c>.NativeClassPtr, "<>9");
				HandoverStackSplitTutorialOpener.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverStackSplitTutorialOpener.__c>.NativeClassPtr, "<>9__2_0");
				HandoverStackSplitTutorialOpener.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverStackSplitTutorialOpener.__c>.NativeClassPtr, 100686742);
				HandoverStackSplitTutorialOpener.__c.NativeMethodInfoPtr__ScreenOpened_b__2_0_Internal_Boolean_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverStackSplitTutorialOpener.__c>.NativeClassPtr, 100686743);
			}

			// Token: 0x0600F4E6 RID: 62694 RVA: 0x003AD9D4 File Offset: 0x003ABBD4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandoverStackSplitTutorialOpener.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverStackSplitTutorialOpener.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F4E7 RID: 62695 RVA: 0x003ADA10 File Offset: 0x003ABC10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301996, XrefRangeEnd = 302003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ScreenOpened_b__2_0(ItemSlotUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverStackSplitTutorialOpener.__c.NativeMethodInfoPtr__ScreenOpened_b__2_0_Internal_Boolean_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F4E8 RID: 62696 RVA: 0x00073BB3 File Offset: 0x00071DB3
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A61 RID: 19041
			// (get) Token: 0x0600F4E9 RID: 62697 RVA: 0x003ADA60 File Offset: 0x003ABC60
			// (set) Token: 0x0600F4EA RID: 62698 RVA: 0x00073BBC File Offset: 0x00071DBC
			public unsafe static HandoverStackSplitTutorialOpener.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HandoverStackSplitTutorialOpener.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HandoverStackSplitTutorialOpener.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HandoverStackSplitTutorialOpener.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A62 RID: 19042
			// (get) Token: 0x0600F4EB RID: 62699 RVA: 0x003ADA88 File Offset: 0x003ABC88
			// (set) Token: 0x0600F4EC RID: 62700 RVA: 0x00073BCE File Offset: 0x00071DCE
			public unsafe static Func<ItemSlotUI, bool> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HandoverStackSplitTutorialOpener.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ItemSlotUI, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HandoverStackSplitTutorialOpener.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A5BE RID: 42430
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A5BF RID: 42431
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x0400A5C0 RID: 42432
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A5C1 RID: 42433
			private static readonly IntPtr NativeMethodInfoPtr__ScreenOpened_b__2_0_Internal_Boolean_ItemSlotUI_0;
		}
	}
}
