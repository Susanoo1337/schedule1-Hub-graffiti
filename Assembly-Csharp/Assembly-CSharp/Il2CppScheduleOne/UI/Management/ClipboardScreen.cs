using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020007C2 RID: 1986
	public class ClipboardScreen : MonoBehaviour
	{
		// Token: 0x0600C2E2 RID: 49890 RVA: 0x00319434 File Offset: 0x00317634
		// Note: this type is marked as 'beforefieldinit'.
		static ClipboardScreen()
		{
			Il2CppClassPointerStore<ClipboardScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "ClipboardScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClipboardScreen>.NativeClassPtr);
			ClipboardScreen.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipboardScreen>.NativeClassPtr, "<IsOpen>k__BackingField");
			ClipboardScreen.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipboardScreen>.NativeClassPtr, "Container");
			ClipboardScreen.NativeFieldInfoPtr_ClosedOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipboardScreen>.NativeClassPtr, "ClosedOffset");
			ClipboardScreen.NativeFieldInfoPtr_OpenOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipboardScreen>.NativeClassPtr, "OpenOnStart");
			ClipboardScreen.NativeFieldInfoPtr_UseExitListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipboardScreen>.NativeClassPtr, "UseExitListener");
			ClipboardScreen.NativeFieldInfoPtr_ExitActionPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipboardScreen>.NativeClassPtr, "ExitActionPriority");
			ClipboardScreen.NativeFieldInfoPtr_lerpRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipboardScreen>.NativeClassPtr, "lerpRoutine");
			ClipboardScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardScreen>.NativeClassPtr, 100688614);
			ClipboardScreen.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardScreen>.NativeClassPtr, 100688615);
			ClipboardScreen.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardScreen>.NativeClassPtr, 100688616);
			ClipboardScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardScreen>.NativeClassPtr, 100688617);
			ClipboardScreen.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardScreen>.NativeClassPtr, 100688618);
			ClipboardScreen.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardScreen>.NativeClassPtr, 100688619);
			ClipboardScreen.NativeMethodInfoPtr_Lerp_Private_Void_Boolean_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardScreen>.NativeClassPtr, 100688620);
			ClipboardScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardScreen>.NativeClassPtr, 100688621);
			ClipboardScreen.NativeMethodInfoPtr__Close_b__13_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardScreen>.NativeClassPtr, 100688622);
		}

		// Token: 0x17003B2D RID: 15149
		// (get) Token: 0x0600C2E3 RID: 49891 RVA: 0x003195A4 File Offset: 0x003177A4
		// (set) Token: 0x0600C2E4 RID: 49892 RVA: 0x003195E0 File Offset: 0x003177E0
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 30482, RefRangeEnd = 30484, XrefRangeStart = 30482, XrefRangeEnd = 30484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardScreen.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600C2E5 RID: 49893 RVA: 0x00319620 File Offset: 0x00317820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322733, XrefRangeEnd = 322750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClipboardScreen.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C2E6 RID: 49894 RVA: 0x0031965C File Offset: 0x0031785C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322750, XrefRangeEnd = 322751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction exitAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exitAction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C2E7 RID: 49895 RVA: 0x003196A0 File Offset: 0x003178A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 322755, RefRangeEnd = 322758, XrefRangeStart = 322751, XrefRangeEnd = 322755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClipboardScreen.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C2E8 RID: 49896 RVA: 0x003196DC File Offset: 0x003178DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 322765, RefRangeEnd = 322768, XrefRangeStart = 322758, XrefRangeEnd = 322765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClipboardScreen.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C2E9 RID: 49897 RVA: 0x00319718 File Offset: 0x00317918
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 322790, RefRangeEnd = 322792, XrefRangeStart = 322768, XrefRangeEnd = 322790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Lerp(bool open, Action callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardScreen.NativeMethodInfoPtr_Lerp_Private_Void_Boolean_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C2EA RID: 49898 RVA: 0x00319768 File Offset: 0x00317968
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 322793, RefRangeEnd = 322796, XrefRangeStart = 322792, XrefRangeEnd = 322793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClipboardScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClipboardScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C2EB RID: 49899 RVA: 0x003197A4 File Offset: 0x003179A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322796, XrefRangeEnd = 322799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Close_b__13_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardScreen.NativeMethodInfoPtr__Close_b__13_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C2EC RID: 49900 RVA: 0x0005BC5F File Offset: 0x00059E5F
		public ClipboardScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003B26 RID: 15142
		// (get) Token: 0x0600C2ED RID: 49901 RVA: 0x003197D8 File Offset: 0x003179D8
		// (set) Token: 0x0600C2EE RID: 49902 RVA: 0x0005BC68 File Offset: 0x00059E68
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003B27 RID: 15143
		// (get) Token: 0x0600C2EF RID: 49903 RVA: 0x00319800 File Offset: 0x00317A00
		// (set) Token: 0x0600C2F0 RID: 49904 RVA: 0x0005BC83 File Offset: 0x00059E83
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B28 RID: 15144
		// (get) Token: 0x0600C2F1 RID: 49905 RVA: 0x00319830 File Offset: 0x00317A30
		// (set) Token: 0x0600C2F2 RID: 49906 RVA: 0x0005BCA2 File Offset: 0x00059EA2
		public unsafe float ClosedOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.NativeFieldInfoPtr_ClosedOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.NativeFieldInfoPtr_ClosedOffset)) = value;
			}
		}

		// Token: 0x17003B29 RID: 15145
		// (get) Token: 0x0600C2F3 RID: 49907 RVA: 0x00319858 File Offset: 0x00317A58
		// (set) Token: 0x0600C2F4 RID: 49908 RVA: 0x0005BCBD File Offset: 0x00059EBD
		public unsafe bool OpenOnStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.NativeFieldInfoPtr_OpenOnStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.NativeFieldInfoPtr_OpenOnStart)) = value;
			}
		}

		// Token: 0x17003B2A RID: 15146
		// (get) Token: 0x0600C2F5 RID: 49909 RVA: 0x00319880 File Offset: 0x00317A80
		// (set) Token: 0x0600C2F6 RID: 49910 RVA: 0x0005BCD8 File Offset: 0x00059ED8
		public unsafe bool UseExitListener
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.NativeFieldInfoPtr_UseExitListener);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.NativeFieldInfoPtr_UseExitListener)) = value;
			}
		}

		// Token: 0x17003B2B RID: 15147
		// (get) Token: 0x0600C2F7 RID: 49911 RVA: 0x003198A8 File Offset: 0x00317AA8
		// (set) Token: 0x0600C2F8 RID: 49912 RVA: 0x0005BCF3 File Offset: 0x00059EF3
		public unsafe int ExitActionPriority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.NativeFieldInfoPtr_ExitActionPriority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.NativeFieldInfoPtr_ExitActionPriority)) = value;
			}
		}

		// Token: 0x17003B2C RID: 15148
		// (get) Token: 0x0600C2F9 RID: 49913 RVA: 0x003198D0 File Offset: 0x00317AD0
		// (set) Token: 0x0600C2FA RID: 49914 RVA: 0x0005BD0E File Offset: 0x00059F0E
		public unsafe Coroutine lerpRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.NativeFieldInfoPtr_lerpRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.NativeFieldInfoPtr_lerpRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008529 RID: 34089
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x0400852A RID: 34090
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x0400852B RID: 34091
		private static readonly IntPtr NativeFieldInfoPtr_ClosedOffset;

		// Token: 0x0400852C RID: 34092
		private static readonly IntPtr NativeFieldInfoPtr_OpenOnStart;

		// Token: 0x0400852D RID: 34093
		private static readonly IntPtr NativeFieldInfoPtr_UseExitListener;

		// Token: 0x0400852E RID: 34094
		private static readonly IntPtr NativeFieldInfoPtr_ExitActionPriority;

		// Token: 0x0400852F RID: 34095
		private static readonly IntPtr NativeFieldInfoPtr_lerpRoutine;

		// Token: 0x04008530 RID: 34096
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04008531 RID: 34097
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04008532 RID: 34098
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04008533 RID: 34099
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04008534 RID: 34100
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_New_Void_0;

		// Token: 0x04008535 RID: 34101
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0;

		// Token: 0x04008536 RID: 34102
		private static readonly IntPtr NativeMethodInfoPtr_Lerp_Private_Void_Boolean_Action_0;

		// Token: 0x04008537 RID: 34103
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04008538 RID: 34104
		private static readonly IntPtr NativeMethodInfoPtr__Close_b__13_0_Private_Void_0;

		// Token: 0x02000D55 RID: 3413
		[ObfuscatedName("ScheduleOne.UI.Management.ClipboardScreen+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Il2CppSystem.Object
		{
			// Token: 0x0600FA67 RID: 64103 RVA: 0x003BD6F0 File Offset: 0x003BB8F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClipboardScreen>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0>.NativeClassPtr);
				ClipboardScreen.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0>.NativeClassPtr, "<>4__this");
				ClipboardScreen.__c__DisplayClass14_0.NativeFieldInfoPtr_open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0>.NativeClassPtr, "open");
				ClipboardScreen.__c__DisplayClass14_0.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0>.NativeClassPtr, "callback");
				ClipboardScreen.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0>.NativeClassPtr, 100688623);
				ClipboardScreen.__c__DisplayClass14_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0>.NativeClassPtr, 100688624);
			}

			// Token: 0x0600FA68 RID: 64104 RVA: 0x003BD780 File Offset: 0x003BB980
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardScreen.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FA69 RID: 64105 RVA: 0x003BD7BC File Offset: 0x003BB9BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322728, XrefRangeEnd = 322733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardScreen.__c__DisplayClass14_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600FA6A RID: 64106 RVA: 0x0007679B File Offset: 0x0007499B
			public __c__DisplayClass14_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C1E RID: 19486
			// (get) Token: 0x0600FA6B RID: 64107 RVA: 0x003BD7FC File Offset: 0x003BB9FC
			// (set) Token: 0x0600FA6C RID: 64108 RVA: 0x000767A4 File Offset: 0x000749A4
			public unsafe ClipboardScreen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClipboardScreen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C1F RID: 19487
			// (get) Token: 0x0600FA6D RID: 64109 RVA: 0x003BD82C File Offset: 0x003BBA2C
			// (set) Token: 0x0600FA6E RID: 64110 RVA: 0x000767C3 File Offset: 0x000749C3
			public unsafe bool open
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.__c__DisplayClass14_0.NativeFieldInfoPtr_open);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.__c__DisplayClass14_0.NativeFieldInfoPtr_open)) = value;
				}
			}

			// Token: 0x17004C20 RID: 19488
			// (get) Token: 0x0600FA6F RID: 64111 RVA: 0x003BD854 File Offset: 0x003BBA54
			// (set) Token: 0x0600FA70 RID: 64112 RVA: 0x000767DE File Offset: 0x000749DE
			public unsafe Action callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.__c__DisplayClass14_0.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.__c__DisplayClass14_0.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A909 RID: 43273
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A90A RID: 43274
			private static readonly IntPtr NativeFieldInfoPtr_open;

			// Token: 0x0400A90B RID: 43275
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x0400A90C RID: 43276
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A90D RID: 43277
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000E18 RID: 3608
			[ObfuscatedName("ScheduleOne.UI.Management.ClipboardScreen+<>c__DisplayClass14_0+<<Lerp>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique : Il2CppSystem.Object
			{
				// Token: 0x06010409 RID: 66569 RVA: 0x003D9978 File Offset: 0x003D7B78
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique()
				{
					Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0>.NativeClassPtr, "<<Lerp>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr);
					ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<>1__state");
					ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<>2__current");
					ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<>4__this");
					ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__startX_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<startX>5__2");
					ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__endX_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<endX>5__3");
					ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<i>5__4");
					ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100688625);
					ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100688626);
					ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100688627);
					ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100688628);
					ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100688629);
					ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100688630);
				}

				// Token: 0x0601040A RID: 66570 RVA: 0x003D9A94 File Offset: 0x003D7C94
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601040B RID: 66571 RVA: 0x003D9ADC File Offset: 0x003D7CDC
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601040C RID: 66572 RVA: 0x003D9B10 File Offset: 0x003D7D10
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322707, XrefRangeEnd = 322723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004F89 RID: 20361
				// (get) Token: 0x0601040D RID: 66573 RVA: 0x003D9B4C File Offset: 0x003D7D4C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601040E RID: 66574 RVA: 0x003D9B8C File Offset: 0x003D7D8C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322723, XrefRangeEnd = 322728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004F8A RID: 20362
				// (get) Token: 0x0601040F RID: 66575 RVA: 0x003D9BC0 File Offset: 0x003D7DC0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06010410 RID: 66576 RVA: 0x0007B62C File Offset: 0x0007982C
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004F83 RID: 20355
				// (get) Token: 0x06010411 RID: 66577 RVA: 0x003D9C00 File Offset: 0x003D7E00
				// (set) Token: 0x06010412 RID: 66578 RVA: 0x0007B635 File Offset: 0x00079835
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004F84 RID: 20356
				// (get) Token: 0x06010413 RID: 66579 RVA: 0x003D9C28 File Offset: 0x003D7E28
				// (set) Token: 0x06010414 RID: 66580 RVA: 0x0007B650 File Offset: 0x00079850
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004F85 RID: 20357
				// (get) Token: 0x06010415 RID: 66581 RVA: 0x003D9C58 File Offset: 0x003D7E58
				// (set) Token: 0x06010416 RID: 66582 RVA: 0x0007B66F File Offset: 0x0007986F
				public unsafe ClipboardScreen.__c__DisplayClass14_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClipboardScreen.__c__DisplayClass14_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004F86 RID: 20358
				// (get) Token: 0x06010417 RID: 66583 RVA: 0x003D9C88 File Offset: 0x003D7E88
				// (set) Token: 0x06010418 RID: 66584 RVA: 0x0007B68E File Offset: 0x0007988E
				public unsafe float _startX_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__startX_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__startX_5__2)) = value;
					}
				}

				// Token: 0x17004F87 RID: 20359
				// (get) Token: 0x06010419 RID: 66585 RVA: 0x003D9CB0 File Offset: 0x003D7EB0
				// (set) Token: 0x0601041A RID: 66586 RVA: 0x0007B6A9 File Offset: 0x000798A9
				public unsafe float _endX_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__endX_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__endX_5__3)) = value;
					}
				}

				// Token: 0x17004F88 RID: 20360
				// (get) Token: 0x0601041B RID: 66587 RVA: 0x003D9CD8 File Offset: 0x003D7ED8
				// (set) Token: 0x0601041C RID: 66588 RVA: 0x0007B6C4 File Offset: 0x000798C4
				public unsafe float _i_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__i_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__i_5__4)) = value;
					}
				}

				// Token: 0x0400AEF2 RID: 44786
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AEF3 RID: 44787
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AEF4 RID: 44788
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AEF5 RID: 44789
				private static readonly IntPtr NativeFieldInfoPtr__startX_5__2;

				// Token: 0x0400AEF6 RID: 44790
				private static readonly IntPtr NativeFieldInfoPtr__endX_5__3;

				// Token: 0x0400AEF7 RID: 44791
				private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

				// Token: 0x0400AEF8 RID: 44792
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AEF9 RID: 44793
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AEFA RID: 44794
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AEFB RID: 44795
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AEFC RID: 44796
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AEFD RID: 44797
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
