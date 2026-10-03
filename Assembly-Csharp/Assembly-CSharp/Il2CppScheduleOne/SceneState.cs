using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.State;
using Il2CppSystem;

namespace Il2CppScheduleOne
{
	// Token: 0x020000C1 RID: 193
	public class SceneState : MonoStateMachine
	{
		// Token: 0x060011E2 RID: 4578 RVA: 0x000B6FA4 File Offset: 0x000B51A4
		// Note: this type is marked as 'beforefieldinit'.
		static SceneState()
		{
			Il2CppClassPointerStore<SceneState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "SceneState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneState>.NativeClassPtr);
			SceneState.NativeFieldInfoPtr__Current_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneState>.NativeClassPtr, "<Current>k__BackingField");
			SceneState.NativeFieldInfoPtr__LastFrameActiveState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneState>.NativeClassPtr, "<LastFrameActiveState>k__BackingField");
			SceneState.NativeFieldInfoPtr__inGameState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneState>.NativeClassPtr, "_inGameState");
			SceneState.NativeFieldInfoPtr_OnActiveStateChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneState>.NativeClassPtr, "OnActiveStateChanged");
			SceneState.NativeMethodInfoPtr_get_Current_Public_Static_get_SceneState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneState>.NativeClassPtr, 100665913);
			SceneState.NativeMethodInfoPtr_set_Current_Private_Static_set_Void_SceneState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneState>.NativeClassPtr, 100665914);
			SceneState.NativeMethodInfoPtr_get_ActiveState_Public_Static_get_IState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneState>.NativeClassPtr, 100665915);
			SceneState.NativeMethodInfoPtr_get_LastFrameActiveState_Public_Static_get_IState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneState>.NativeClassPtr, 100665916);
			SceneState.NativeMethodInfoPtr_set_LastFrameActiveState_Private_Static_set_Void_IState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneState>.NativeClassPtr, 100665917);
			SceneState.NativeMethodInfoPtr_get_InGame_Public_get_InGameStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneState>.NativeClassPtr, 100665918);
			SceneState.NativeMethodInfoPtr_add_OnActiveStateChanged_Public_add_Void_Action_1_IState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneState>.NativeClassPtr, 100665919);
			SceneState.NativeMethodInfoPtr_remove_OnActiveStateChanged_Public_rem_Void_Action_1_IState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneState>.NativeClassPtr, 100665920);
			SceneState.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneState>.NativeClassPtr, 100665921);
			SceneState.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneState>.NativeClassPtr, 100665922);
			SceneState.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneState>.NativeClassPtr, 100665923);
			SceneState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneState>.NativeClassPtr, 100665924);
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x060011E3 RID: 4579 RVA: 0x000B7114 File Offset: 0x000B5314
		// (set) Token: 0x060011E4 RID: 4580 RVA: 0x000B7148 File Offset: 0x000B5348
		public unsafe static SceneState Current
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90605, XrefRangeEnd = 90607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneState.NativeMethodInfoPtr_get_Current_Public_Static_get_SceneState_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SceneState>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90607, XrefRangeEnd = 90611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneState.NativeMethodInfoPtr_set_Current_Private_Static_set_Void_SceneState_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x060011E5 RID: 4581 RVA: 0x000B7180 File Offset: 0x000B5380
		public unsafe static IState ActiveState
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 90615, RefRangeEnd = 90634, XrefRangeStart = 90611, XrefRangeEnd = 90615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneState.NativeMethodInfoPtr_get_ActiveState_Public_Static_get_IState_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IState>(intPtr3) : null;
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x060011E6 RID: 4582 RVA: 0x000B71B4 File Offset: 0x000B53B4
		// (set) Token: 0x060011E7 RID: 4583 RVA: 0x000B71E8 File Offset: 0x000B53E8
		public unsafe static IState LastFrameActiveState
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90634, XrefRangeEnd = 90636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneState.NativeMethodInfoPtr_get_LastFrameActiveState_Public_Static_get_IState_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IState>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90636, XrefRangeEnd = 90640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneState.NativeMethodInfoPtr_set_LastFrameActiveState_Private_Static_set_Void_IState_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x060011E8 RID: 4584 RVA: 0x000B7220 File Offset: 0x000B5420
		public unsafe InGameStateMachine InGame
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneState.NativeMethodInfoPtr_get_InGame_Public_get_InGameStateMachine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InGameStateMachine>(intPtr3) : null;
			}
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x000B7260 File Offset: 0x000B5460
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90645, RefRangeEnd = 90646, XrefRangeStart = 90640, XrefRangeEnd = 90645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnActiveStateChanged(Action<IState> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneState.NativeMethodInfoPtr_add_OnActiveStateChanged_Public_add_Void_Action_1_IState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x000B72A4 File Offset: 0x000B54A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90651, RefRangeEnd = 90652, XrefRangeStart = 90646, XrefRangeEnd = 90651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnActiveStateChanged(Action<IState> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneState.NativeMethodInfoPtr_remove_OnActiveStateChanged_Public_rem_Void_Action_1_IState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x000B72E8 File Offset: 0x000B54E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90652, XrefRangeEnd = 90684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SceneState.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x000B7324 File Offset: 0x000B5524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90684, XrefRangeEnd = 90699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneState.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x000B7358 File Offset: 0x000B5558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90699, XrefRangeEnd = 90709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneState.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x000B738C File Offset: 0x000B558C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90709, XrefRangeEnd = 90710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SceneState() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneState>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x0000A1C0 File Offset: 0x000083C0
		public SceneState(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x060011F0 RID: 4592 RVA: 0x000B73C8 File Offset: 0x000B55C8
		// (set) Token: 0x060011F1 RID: 4593 RVA: 0x0000A1C9 File Offset: 0x000083C9
		public unsafe static SceneState _Current_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneState.NativeFieldInfoPtr__Current_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneState>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneState.NativeFieldInfoPtr__Current_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x060011F2 RID: 4594 RVA: 0x000B73F0 File Offset: 0x000B55F0
		// (set) Token: 0x060011F3 RID: 4595 RVA: 0x0000A1DB File Offset: 0x000083DB
		public unsafe static IState _LastFrameActiveState_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneState.NativeFieldInfoPtr__LastFrameActiveState_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IState>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneState.NativeFieldInfoPtr__LastFrameActiveState_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x060011F4 RID: 4596 RVA: 0x000B7418 File Offset: 0x000B5618
		// (set) Token: 0x060011F5 RID: 4597 RVA: 0x0000A1ED File Offset: 0x000083ED
		public unsafe InGameStateMachine _inGameState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneState.NativeFieldInfoPtr__inGameState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InGameStateMachine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneState.NativeFieldInfoPtr__inGameState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x060011F6 RID: 4598 RVA: 0x000B7448 File Offset: 0x000B5648
		// (set) Token: 0x060011F7 RID: 4599 RVA: 0x0000A20C File Offset: 0x0000840C
		public unsafe Action<IState> OnActiveStateChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneState.NativeFieldInfoPtr_OnActiveStateChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IState>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneState.NativeFieldInfoPtr_OnActiveStateChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C82 RID: 3202
		private static readonly IntPtr NativeFieldInfoPtr__Current_k__BackingField;

		// Token: 0x04000C83 RID: 3203
		private static readonly IntPtr NativeFieldInfoPtr__LastFrameActiveState_k__BackingField;

		// Token: 0x04000C84 RID: 3204
		private static readonly IntPtr NativeFieldInfoPtr__inGameState;

		// Token: 0x04000C85 RID: 3205
		private static readonly IntPtr NativeFieldInfoPtr_OnActiveStateChanged;

		// Token: 0x04000C86 RID: 3206
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Static_get_SceneState_0;

		// Token: 0x04000C87 RID: 3207
		private static readonly IntPtr NativeMethodInfoPtr_set_Current_Private_Static_set_Void_SceneState_0;

		// Token: 0x04000C88 RID: 3208
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveState_Public_Static_get_IState_0;

		// Token: 0x04000C89 RID: 3209
		private static readonly IntPtr NativeMethodInfoPtr_get_LastFrameActiveState_Public_Static_get_IState_0;

		// Token: 0x04000C8A RID: 3210
		private static readonly IntPtr NativeMethodInfoPtr_set_LastFrameActiveState_Private_Static_set_Void_IState_0;

		// Token: 0x04000C8B RID: 3211
		private static readonly IntPtr NativeMethodInfoPtr_get_InGame_Public_get_InGameStateMachine_0;

		// Token: 0x04000C8C RID: 3212
		private static readonly IntPtr NativeMethodInfoPtr_add_OnActiveStateChanged_Public_add_Void_Action_1_IState_0;

		// Token: 0x04000C8D RID: 3213
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnActiveStateChanged_Public_rem_Void_Action_1_IState_0;

		// Token: 0x04000C8E RID: 3214
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04000C8F RID: 3215
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000C90 RID: 3216
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000C91 RID: 3217
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
