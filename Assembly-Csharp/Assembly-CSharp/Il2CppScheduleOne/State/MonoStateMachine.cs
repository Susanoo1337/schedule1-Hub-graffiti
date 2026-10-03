using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.State
{
	// Token: 0x02000127 RID: 295
	public class MonoStateMachine : MonoState
	{
		// Token: 0x06001C55 RID: 7253 RVA: 0x000D8EB8 File Offset: 0x000D70B8
		// Note: this type is marked as 'beforefieldinit'.
		static MonoStateMachine()
		{
			Il2CppClassPointerStore<MonoStateMachine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.State", "MonoStateMachine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoStateMachine>.NativeClassPtr);
			MonoStateMachine.NativeFieldInfoPtr__Stack_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoStateMachine>.NativeClassPtr, "<Stack>k__BackingField");
			MonoStateMachine.NativeMethodInfoPtr_get_Stack_Public_Virtual_Final_New_get_List_1_IState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoStateMachine>.NativeClassPtr, 100667056);
			MonoStateMachine.NativeMethodInfoPtr_set_Stack_Private_set_Void_List_1_IState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoStateMachine>.NativeClassPtr, 100667057);
			MonoStateMachine.NativeMethodInfoPtr_OnActivate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoStateMachine>.NativeClassPtr, 100667058);
			MonoStateMachine.NativeMethodInfoPtr_Push_Public_Virtual_Final_New_Void_IState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoStateMachine>.NativeClassPtr, 100667059);
			MonoStateMachine.NativeMethodInfoPtr_Pop_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoStateMachine>.NativeClassPtr, 100667060);
			MonoStateMachine.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Void_IState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoStateMachine>.NativeClassPtr, 100667061);
			MonoStateMachine.NativeMethodInfoPtr_Peek_Public_Virtual_Final_New_IState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoStateMachine>.NativeClassPtr, 100667062);
			MonoStateMachine.NativeMethodInfoPtr_PeekRecursive_Public_Virtual_Final_New_IState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoStateMachine>.NativeClassPtr, 100667063);
			MonoStateMachine.NativeMethodInfoPtr_IsAnyChildStateAcceptingInput_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoStateMachine>.NativeClassPtr, 100667064);
			MonoStateMachine.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoStateMachine>.NativeClassPtr, 100667065);
			MonoStateMachine.NativeMethodInfoPtr_ScheduleOne_State_IState_get_name_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoStateMachine>.NativeClassPtr, 100667066);
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x06001C56 RID: 7254 RVA: 0x000D8FD8 File Offset: 0x000D71D8
		// (set) Token: 0x06001C57 RID: 7255 RVA: 0x000D9018 File Offset: 0x000D7218
		public unsafe virtual List<IState> Stack
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoStateMachine.NativeMethodInfoPtr_get_Stack_Public_Virtual_Final_New_get_List_1_IState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<IState>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoStateMachine.NativeMethodInfoPtr_set_Stack_Private_set_Void_List_1_IState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C58 RID: 7256 RVA: 0x000D905C File Offset: 0x000D725C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103173, XrefRangeEnd = 103174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnActivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoStateMachine.NativeMethodInfoPtr_OnActivate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C59 RID: 7257 RVA: 0x000D9098 File Offset: 0x000D7298
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 103203, RefRangeEnd = 103208, XrefRangeStart = 103174, XrefRangeEnd = 103203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Push(IState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoStateMachine.NativeMethodInfoPtr_Push_Public_Virtual_Final_New_Void_IState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C5A RID: 7258 RVA: 0x000D90DC File Offset: 0x000D72DC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 103233, RefRangeEnd = 103237, XrefRangeStart = 103208, XrefRangeEnd = 103233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoStateMachine.NativeMethodInfoPtr_Pop_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C5B RID: 7259 RVA: 0x000D9110 File Offset: 0x000D7310
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 103260, RefRangeEnd = 103263, XrefRangeStart = 103237, XrefRangeEnd = 103260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Remove(IState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoStateMachine.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Void_IState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C5C RID: 7260 RVA: 0x000D9154 File Offset: 0x000D7354
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 103265, RefRangeEnd = 103273, XrefRangeStart = 103263, XrefRangeEnd = 103265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IState Peek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoStateMachine.NativeMethodInfoPtr_Peek_Public_Virtual_Final_New_IState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IState>(intPtr3) : null;
		}

		// Token: 0x06001C5D RID: 7261 RVA: 0x000D9194 File Offset: 0x000D7394
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 103276, RefRangeEnd = 103286, XrefRangeStart = 103273, XrefRangeEnd = 103276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IState PeekRecursive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoStateMachine.NativeMethodInfoPtr_PeekRecursive_Public_Virtual_Final_New_IState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IState>(intPtr3) : null;
		}

		// Token: 0x06001C5E RID: 7262 RVA: 0x000D91D4 File Offset: 0x000D73D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 103294, RefRangeEnd = 103297, XrefRangeStart = 103286, XrefRangeEnd = 103294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAnyChildStateAcceptingInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoStateMachine.NativeMethodInfoPtr_IsAnyChildStateAcceptingInput_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C5F RID: 7263 RVA: 0x000D9210 File Offset: 0x000D7410
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102528, RefRangeEnd = 102529, XrefRangeStart = 102528, XrefRangeEnd = 102529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoStateMachine() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoStateMachine>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoStateMachine.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x06001C60 RID: 7264 RVA: 0x000D924C File Offset: 0x000D744C
		public new unsafe virtual string name
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 48135, RefRangeEnd = 48145, XrefRangeStart = 48135, XrefRangeEnd = 48145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoStateMachine.NativeMethodInfoPtr_ScheduleOne_State_IState_get_name_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001C61 RID: 7265 RVA: 0x0000F454 File Offset: 0x0000D654
		public MonoStateMachine(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x06001C62 RID: 7266 RVA: 0x000D9284 File Offset: 0x000D7484
		// (set) Token: 0x06001C63 RID: 7267 RVA: 0x0000F45D File Offset: 0x0000D65D
		public unsafe List<IState> _Stack_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoStateMachine.NativeFieldInfoPtr__Stack_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IState>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoStateMachine.NativeFieldInfoPtr__Stack_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040013AF RID: 5039
		private static readonly IntPtr NativeFieldInfoPtr__Stack_k__BackingField;

		// Token: 0x040013B0 RID: 5040
		private static readonly IntPtr NativeMethodInfoPtr_get_Stack_Public_Virtual_Final_New_get_List_1_IState_0;

		// Token: 0x040013B1 RID: 5041
		private static readonly IntPtr NativeMethodInfoPtr_set_Stack_Private_set_Void_List_1_IState_0;

		// Token: 0x040013B2 RID: 5042
		private static readonly IntPtr NativeMethodInfoPtr_OnActivate_Public_Virtual_Void_0;

		// Token: 0x040013B3 RID: 5043
		private static readonly IntPtr NativeMethodInfoPtr_Push_Public_Virtual_Final_New_Void_IState_0;

		// Token: 0x040013B4 RID: 5044
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Public_Virtual_Final_New_Void_0;

		// Token: 0x040013B5 RID: 5045
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Void_IState_0;

		// Token: 0x040013B6 RID: 5046
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Public_Virtual_Final_New_IState_0;

		// Token: 0x040013B7 RID: 5047
		private static readonly IntPtr NativeMethodInfoPtr_PeekRecursive_Public_Virtual_Final_New_IState_0;

		// Token: 0x040013B8 RID: 5048
		private static readonly IntPtr NativeMethodInfoPtr_IsAnyChildStateAcceptingInput_Public_Boolean_0;

		// Token: 0x040013B9 RID: 5049
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040013BA RID: 5050
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleOne_State_IState_get_name_Private_Virtual_Final_New_get_String_0;
	}
}
