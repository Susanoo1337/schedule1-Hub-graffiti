using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.State
{
	// Token: 0x02000125 RID: 293
	public class IStateMachine : Il2CppObjectBase
	{
		// Token: 0x06001BFE RID: 7166 RVA: 0x000D7A0C File Offset: 0x000D5C0C
		// Note: this type is marked as 'beforefieldinit'.
		static IStateMachine()
		{
			Il2CppClassPointerStore<IStateMachine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.State", "IStateMachine");
			IStateMachine.NativeMethodInfoPtr_get_Stack_Public_Abstract_Virtual_New_get_List_1_IState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStateMachine>.NativeClassPtr, 100667007);
			IStateMachine.NativeMethodInfoPtr_Push_Public_Abstract_Virtual_New_Void_IState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStateMachine>.NativeClassPtr, 100667008);
			IStateMachine.NativeMethodInfoPtr_Pop_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStateMachine>.NativeClassPtr, 100667009);
			IStateMachine.NativeMethodInfoPtr_Remove_Public_Abstract_Virtual_New_Void_IState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStateMachine>.NativeClassPtr, 100667010);
			IStateMachine.NativeMethodInfoPtr_Peek_Public_Abstract_Virtual_New_IState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStateMachine>.NativeClassPtr, 100667011);
			IStateMachine.NativeMethodInfoPtr_PeekRecursive_Public_Abstract_Virtual_New_IState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStateMachine>.NativeClassPtr, 100667012);
			IStateMachine.NativeMethodInfoPtr_StackToString_Public_Virtual_New_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStateMachine>.NativeClassPtr, 100667013);
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x06001BFF RID: 7167 RVA: 0x000D7AC0 File Offset: 0x000D5CC0
		public unsafe virtual List<IState> Stack
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStateMachine.NativeMethodInfoPtr_get_Stack_Public_Abstract_Virtual_New_get_List_1_IState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<IState>>(intPtr3) : null;
			}
		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x000D7B0C File Offset: 0x000D5D0C
		[CallerCount(0)]
		public unsafe virtual void Push(IState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStateMachine.NativeMethodInfoPtr_Push_Public_Abstract_Virtual_New_Void_IState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x000D7B5C File Offset: 0x000D5D5C
		[CallerCount(0)]
		public unsafe virtual void Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStateMachine.NativeMethodInfoPtr_Pop_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C02 RID: 7170 RVA: 0x000D7B98 File Offset: 0x000D5D98
		[CallerCount(0)]
		public unsafe virtual void Remove(IState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStateMachine.NativeMethodInfoPtr_Remove_Public_Abstract_Virtual_New_Void_IState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C03 RID: 7171 RVA: 0x000D7BE8 File Offset: 0x000D5DE8
		[CallerCount(0)]
		public unsafe virtual IState Peek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStateMachine.NativeMethodInfoPtr_Peek_Public_Abstract_Virtual_New_IState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IState>(intPtr3) : null;
		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x000D7C34 File Offset: 0x000D5E34
		[CallerCount(0)]
		public unsafe virtual IState PeekRecursive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStateMachine.NativeMethodInfoPtr_PeekRecursive_Public_Abstract_Virtual_New_IState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IState>(intPtr3) : null;
		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x000D7C80 File Offset: 0x000D5E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102534, XrefRangeEnd = 102571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string StackToString(int indentation = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref indentation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStateMachine.NativeMethodInfoPtr_StackToString_Public_Virtual_New_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001C06 RID: 7174 RVA: 0x0000F230 File Offset: 0x0000D430
		public IStateMachine(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400136E RID: 4974
		private static readonly IntPtr NativeMethodInfoPtr_get_Stack_Public_Abstract_Virtual_New_get_List_1_IState_0;

		// Token: 0x0400136F RID: 4975
		private static readonly IntPtr NativeMethodInfoPtr_Push_Public_Abstract_Virtual_New_Void_IState_0;

		// Token: 0x04001370 RID: 4976
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04001371 RID: 4977
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Abstract_Virtual_New_Void_IState_0;

		// Token: 0x04001372 RID: 4978
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Public_Abstract_Virtual_New_IState_0;

		// Token: 0x04001373 RID: 4979
		private static readonly IntPtr NativeMethodInfoPtr_PeekRecursive_Public_Abstract_Virtual_New_IState_0;

		// Token: 0x04001374 RID: 4980
		private static readonly IntPtr NativeMethodInfoPtr_StackToString_Public_Virtual_New_String_Int32_0;
	}
}
