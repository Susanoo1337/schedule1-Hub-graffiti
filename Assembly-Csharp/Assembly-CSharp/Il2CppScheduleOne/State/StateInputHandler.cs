using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.UI.Input;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.State
{
	// Token: 0x02000129 RID: 297
	public class StateInputHandler : Object
	{
		// Token: 0x06001CAF RID: 7343 RVA: 0x000DA3E8 File Offset: 0x000D85E8
		// Note: this type is marked as 'beforefieldinit'.
		static StateInputHandler()
		{
			Il2CppClassPointerStore<StateInputHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.State", "StateInputHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StateInputHandler>.NativeClassPtr);
			StateInputHandler.NativeFieldInfoPtr__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateInputHandler>.NativeClassPtr, "_state");
			StateInputHandler.NativeFieldInfoPtr__activeModules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateInputHandler>.NativeClassPtr, "_activeModules");
			StateInputHandler.NativeFieldInfoPtr__isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateInputHandler>.NativeClassPtr, "_isActive");
			StateInputHandler.NativeMethodInfoPtr__ctor_Public_Void_IState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateInputHandler>.NativeClassPtr, 100667104);
			StateInputHandler.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateInputHandler>.NativeClassPtr, 100667105);
			StateInputHandler.NativeMethodInfoPtr_AddModule_Public_Void_InputPromptReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateInputHandler>.NativeClassPtr, 100667106);
			StateInputHandler.NativeMethodInfoPtr_RemoveModule_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateInputHandler>.NativeClassPtr, 100667107);
			StateInputHandler.NativeMethodInfoPtr_LoadModules_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateInputHandler>.NativeClassPtr, 100667108);
			StateInputHandler.NativeMethodInfoPtr_LoadModule_Private_Void_InputPromptReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateInputHandler>.NativeClassPtr, 100667109);
			StateInputHandler.NativeMethodInfoPtr_UnloadModules_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateInputHandler>.NativeClassPtr, 100667110);
			StateInputHandler.NativeMethodInfoPtr_UnloadModule_Private_Void_InputPromptReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateInputHandler>.NativeClassPtr, 100667111);
			StateInputHandler.NativeMethodInfoPtr_OnInputModuleLoaded_Public_Void_InputPromptReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateInputHandler>.NativeClassPtr, 100667112);
			StateInputHandler.NativeMethodInfoPtr_OnInputModuleUnloaded_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateInputHandler>.NativeClassPtr, 100667113);
			StateInputHandler.NativeMethodInfoPtr_HasModuleRef_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateInputHandler>.NativeClassPtr, 100667114);
			StateInputHandler.NativeMethodInfoPtr_CleanUp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateInputHandler>.NativeClassPtr, 100667115);
		}

		// Token: 0x06001CB0 RID: 7344 RVA: 0x000DA544 File Offset: 0x000D8744
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 103614, RefRangeEnd = 103616, XrefRangeStart = 103605, XrefRangeEnd = 103614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StateInputHandler(IState state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateInputHandler>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateInputHandler.NativeMethodInfoPtr__ctor_Public_Void_IState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CB1 RID: 7345 RVA: 0x000DA590 File Offset: 0x000D8790
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 30482, RefRangeEnd = 30484, XrefRangeStart = 30482, XrefRangeEnd = 30484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActive(bool isActive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isActive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateInputHandler.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CB2 RID: 7346 RVA: 0x000DA5D0 File Offset: 0x000D87D0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 103637, RefRangeEnd = 103644, XrefRangeStart = 103616, XrefRangeEnd = 103637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddModule(InputPromptReference moduleRef)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(moduleRef);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateInputHandler.NativeMethodInfoPtr_AddModule_Public_Void_InputPromptReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x000DA614 File Offset: 0x000D8814
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 103673, RefRangeEnd = 103678, XrefRangeStart = 103644, XrefRangeEnd = 103673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveModule(string moduleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(moduleId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateInputHandler.NativeMethodInfoPtr_RemoveModule_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CB4 RID: 7348 RVA: 0x000DA658 File Offset: 0x000D8858
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 103693, RefRangeEnd = 103695, XrefRangeStart = 103678, XrefRangeEnd = 103693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadModules()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateInputHandler.NativeMethodInfoPtr_LoadModules_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x000DA68C File Offset: 0x000D888C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 103700, RefRangeEnd = 103702, XrefRangeStart = 103695, XrefRangeEnd = 103700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadModule(InputPromptReference moduleRef)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(moduleRef);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateInputHandler.NativeMethodInfoPtr_LoadModule_Private_Void_InputPromptReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CB6 RID: 7350 RVA: 0x000DA6D0 File Offset: 0x000D88D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 103721, RefRangeEnd = 103723, XrefRangeStart = 103702, XrefRangeEnd = 103721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnloadModules()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateInputHandler.NativeMethodInfoPtr_UnloadModules_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x000DA704 File Offset: 0x000D8904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103723, XrefRangeEnd = 103729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnloadModule(InputPromptReference moduleRef)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(moduleRef);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateInputHandler.NativeMethodInfoPtr_UnloadModule_Private_Void_InputPromptReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CB8 RID: 7352 RVA: 0x000DA748 File Offset: 0x000D8948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103729, XrefRangeEnd = 103733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInputModuleLoaded(InputPromptReference moduleRef)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(moduleRef);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateInputHandler.NativeMethodInfoPtr_OnInputModuleLoaded_Public_Void_InputPromptReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CB9 RID: 7353 RVA: 0x000DA78C File Offset: 0x000D898C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103733, XrefRangeEnd = 103737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInputModuleUnloaded(string moduleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(moduleId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateInputHandler.NativeMethodInfoPtr_OnInputModuleUnloaded_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CBA RID: 7354 RVA: 0x000DA7D0 File Offset: 0x000D89D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103737, XrefRangeEnd = 103752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasModuleRef(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateInputHandler.NativeMethodInfoPtr_HasModuleRef_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CBB RID: 7355 RVA: 0x000DA820 File Offset: 0x000D8A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103752, XrefRangeEnd = 103774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateInputHandler.NativeMethodInfoPtr_CleanUp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CBC RID: 7356 RVA: 0x0000F69B File Offset: 0x0000D89B
		public StateInputHandler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x06001CBD RID: 7357 RVA: 0x000DA854 File Offset: 0x000D8A54
		// (set) Token: 0x06001CBE RID: 7358 RVA: 0x0000F6A4 File Offset: 0x0000D8A4
		public unsafe IState _state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateInputHandler.NativeFieldInfoPtr__state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateInputHandler.NativeFieldInfoPtr__state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x06001CBF RID: 7359 RVA: 0x000DA884 File Offset: 0x000D8A84
		// (set) Token: 0x06001CC0 RID: 7360 RVA: 0x0000F6C3 File Offset: 0x0000D8C3
		public unsafe List<InputPromptReference> _activeModules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateInputHandler.NativeFieldInfoPtr__activeModules);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<InputPromptReference>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateInputHandler.NativeFieldInfoPtr__activeModules), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x06001CC1 RID: 7361 RVA: 0x000DA8B4 File Offset: 0x000D8AB4
		// (set) Token: 0x06001CC2 RID: 7362 RVA: 0x0000F6E2 File Offset: 0x0000D8E2
		public unsafe bool _isActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateInputHandler.NativeFieldInfoPtr__isActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateInputHandler.NativeFieldInfoPtr__isActive)) = value;
			}
		}

		// Token: 0x040013F2 RID: 5106
		private static readonly IntPtr NativeFieldInfoPtr__state;

		// Token: 0x040013F3 RID: 5107
		private static readonly IntPtr NativeFieldInfoPtr__activeModules;

		// Token: 0x040013F4 RID: 5108
		private static readonly IntPtr NativeFieldInfoPtr__isActive;

		// Token: 0x040013F5 RID: 5109
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IState_0;

		// Token: 0x040013F6 RID: 5110
		private static readonly IntPtr NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0;

		// Token: 0x040013F7 RID: 5111
		private static readonly IntPtr NativeMethodInfoPtr_AddModule_Public_Void_InputPromptReference_0;

		// Token: 0x040013F8 RID: 5112
		private static readonly IntPtr NativeMethodInfoPtr_RemoveModule_Public_Void_String_0;

		// Token: 0x040013F9 RID: 5113
		private static readonly IntPtr NativeMethodInfoPtr_LoadModules_Public_Void_0;

		// Token: 0x040013FA RID: 5114
		private static readonly IntPtr NativeMethodInfoPtr_LoadModule_Private_Void_InputPromptReference_0;

		// Token: 0x040013FB RID: 5115
		private static readonly IntPtr NativeMethodInfoPtr_UnloadModules_Public_Void_0;

		// Token: 0x040013FC RID: 5116
		private static readonly IntPtr NativeMethodInfoPtr_UnloadModule_Private_Void_InputPromptReference_0;

		// Token: 0x040013FD RID: 5117
		private static readonly IntPtr NativeMethodInfoPtr_OnInputModuleLoaded_Public_Void_InputPromptReference_0;

		// Token: 0x040013FE RID: 5118
		private static readonly IntPtr NativeMethodInfoPtr_OnInputModuleUnloaded_Public_Void_String_0;

		// Token: 0x040013FF RID: 5119
		private static readonly IntPtr NativeMethodInfoPtr_HasModuleRef_Private_Boolean_String_0;

		// Token: 0x04001400 RID: 5120
		private static readonly IntPtr NativeMethodInfoPtr_CleanUp_Public_Void_0;

		// Token: 0x0200094D RID: 2381
		[ObfuscatedName("ScheduleOne.State.StateInputHandler+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Object
		{
			// Token: 0x0600D895 RID: 55445 RVA: 0x0035CEBC File Offset: 0x0035B0BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<StateInputHandler.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StateInputHandler>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StateInputHandler.__c__DisplayClass13_0>.NativeClassPtr);
				StateInputHandler.__c__DisplayClass13_0.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateInputHandler.__c__DisplayClass13_0>.NativeClassPtr, "id");
				StateInputHandler.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateInputHandler.__c__DisplayClass13_0>.NativeClassPtr, 100667116);
				StateInputHandler.__c__DisplayClass13_0.NativeMethodInfoPtr__HasModuleRef_b__0_Internal_Boolean_InputPromptReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateInputHandler.__c__DisplayClass13_0>.NativeClassPtr, 100667117);
			}

			// Token: 0x0600D896 RID: 55446 RVA: 0x0035CF24 File Offset: 0x0035B124
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateInputHandler.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateInputHandler.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D897 RID: 55447 RVA: 0x0035CF60 File Offset: 0x0035B160
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HasModuleRef_b__0(InputPromptReference m)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateInputHandler.__c__DisplayClass13_0.NativeMethodInfoPtr__HasModuleRef_b__0_Internal_Boolean_InputPromptReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D898 RID: 55448 RVA: 0x00065D7D File Offset: 0x00063F7D
			public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004225 RID: 16933
			// (get) Token: 0x0600D899 RID: 55449 RVA: 0x0035CFB0 File Offset: 0x0035B1B0
			// (set) Token: 0x0600D89A RID: 55450 RVA: 0x00065D86 File Offset: 0x00063F86
			public unsafe string id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateInputHandler.__c__DisplayClass13_0.NativeFieldInfoPtr_id);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateInputHandler.__c__DisplayClass13_0.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040093BA RID: 37818
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x040093BB RID: 37819
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040093BC RID: 37820
			private static readonly IntPtr NativeMethodInfoPtr__HasModuleRef_b__0_Internal_Boolean_InputPromptReference_0;
		}

		// Token: 0x0200094E RID: 2382
		[ObfuscatedName("ScheduleOne.State.StateInputHandler+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x0600D89B RID: 55451 RVA: 0x0035CFD8 File Offset: 0x0035B1D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<StateInputHandler.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StateInputHandler>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StateInputHandler.__c__DisplayClass6_0>.NativeClassPtr);
				StateInputHandler.__c__DisplayClass6_0.NativeFieldInfoPtr_moduleId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateInputHandler.__c__DisplayClass6_0>.NativeClassPtr, "moduleId");
				StateInputHandler.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateInputHandler.__c__DisplayClass6_0>.NativeClassPtr, 100667118);
				StateInputHandler.__c__DisplayClass6_0.NativeMethodInfoPtr__RemoveModule_b__0_Internal_Boolean_InputPromptReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateInputHandler.__c__DisplayClass6_0>.NativeClassPtr, 100667119);
			}

			// Token: 0x0600D89C RID: 55452 RVA: 0x0035D040 File Offset: 0x0035B240
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateInputHandler.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateInputHandler.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D89D RID: 55453 RVA: 0x0035D07C File Offset: 0x0035B27C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103601, XrefRangeEnd = 103605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveModule_b__0(InputPromptReference m)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateInputHandler.__c__DisplayClass6_0.NativeMethodInfoPtr__RemoveModule_b__0_Internal_Boolean_InputPromptReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D89E RID: 55454 RVA: 0x00065DA5 File Offset: 0x00063FA5
			public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004226 RID: 16934
			// (get) Token: 0x0600D89F RID: 55455 RVA: 0x0035D0CC File Offset: 0x0035B2CC
			// (set) Token: 0x0600D8A0 RID: 55456 RVA: 0x00065DAE File Offset: 0x00063FAE
			public unsafe string moduleId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateInputHandler.__c__DisplayClass6_0.NativeFieldInfoPtr_moduleId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateInputHandler.__c__DisplayClass6_0.NativeFieldInfoPtr_moduleId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040093BD RID: 37821
			private static readonly IntPtr NativeFieldInfoPtr_moduleId;

			// Token: 0x040093BE RID: 37822
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040093BF RID: 37823
			private static readonly IntPtr NativeMethodInfoPtr__RemoveModule_b__0_Internal_Boolean_InputPromptReference_0;
		}
	}
}
