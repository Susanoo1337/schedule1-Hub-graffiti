using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004F6 RID: 1270
	public class PreallocatedAction : Object
	{
		// Token: 0x060072F7 RID: 29431 RVA: 0x00205114 File Offset: 0x00203314
		// Note: this type is marked as 'beforefieldinit'.
		static PreallocatedAction()
		{
			Il2CppClassPointerStore<PreallocatedAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "PreallocatedAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreallocatedAction>.NativeClassPtr);
			PreallocatedAction.NativeFieldInfoPtr__listeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreallocatedAction>.NativeClassPtr, "_listeners");
			PreallocatedAction.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreallocatedAction>.NativeClassPtr, 100678163);
			PreallocatedAction.NativeMethodInfoPtr_op_Addition_Public_Static_PreallocatedAction_PreallocatedAction_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreallocatedAction>.NativeClassPtr, 100678164);
			PreallocatedAction.NativeMethodInfoPtr_op_Subtraction_Public_Static_PreallocatedAction_PreallocatedAction_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreallocatedAction>.NativeClassPtr, 100678165);
			PreallocatedAction.NativeMethodInfoPtr_Add_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreallocatedAction>.NativeClassPtr, 100678166);
			PreallocatedAction.NativeMethodInfoPtr_Remove_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreallocatedAction>.NativeClassPtr, 100678167);
			PreallocatedAction.NativeMethodInfoPtr_Invoke_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreallocatedAction>.NativeClassPtr, 100678168);
			PreallocatedAction.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreallocatedAction>.NativeClassPtr, 100678169);
		}

		// Token: 0x060072F8 RID: 29432 RVA: 0x002051E4 File Offset: 0x002033E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 227056, RefRangeEnd = 227059, XrefRangeStart = 227048, XrefRangeEnd = 227056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PreallocatedAction(int capacity = 16) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PreallocatedAction>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref capacity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreallocatedAction.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072F9 RID: 29433 RVA: 0x0020522C File Offset: 0x0020342C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 227062, RefRangeEnd = 227065, XrefRangeStart = 227059, XrefRangeEnd = 227062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PreallocatedAction operator +(PreallocatedAction evt, Action listener)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listener);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreallocatedAction.NativeMethodInfoPtr_op_Addition_Public_Static_PreallocatedAction_PreallocatedAction_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PreallocatedAction>(intPtr3) : null;
		}

		// Token: 0x060072FA RID: 29434 RVA: 0x00205284 File Offset: 0x00203484
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 227078, RefRangeEnd = 227081, XrefRangeStart = 227065, XrefRangeEnd = 227078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PreallocatedAction operator -(PreallocatedAction evt, Action listener)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listener);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreallocatedAction.NativeMethodInfoPtr_op_Subtraction_Public_Static_PreallocatedAction_PreallocatedAction_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PreallocatedAction>(intPtr3) : null;
		}

		// Token: 0x060072FB RID: 29435 RVA: 0x002052DC File Offset: 0x002034DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227081, XrefRangeEnd = 227084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(Action listener)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreallocatedAction.NativeMethodInfoPtr_Add_Public_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072FC RID: 29436 RVA: 0x00205320 File Offset: 0x00203520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227084, XrefRangeEnd = 227097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(Action listener)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreallocatedAction.NativeMethodInfoPtr_Remove_Public_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072FD RID: 29437 RVA: 0x00205364 File Offset: 0x00203564
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 227102, RefRangeEnd = 227104, XrefRangeStart = 227097, XrefRangeEnd = 227102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreallocatedAction.NativeMethodInfoPtr_Invoke_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17002374 RID: 9076
		// (get) Token: 0x060072FE RID: 29438 RVA: 0x00205398 File Offset: 0x00203598
		public unsafe int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227104, XrefRangeEnd = 227105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreallocatedAction.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060072FF RID: 29439 RVA: 0x00036A8B File Offset: 0x00034C8B
		public PreallocatedAction(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002373 RID: 9075
		// (get) Token: 0x06007300 RID: 29440 RVA: 0x002053D4 File Offset: 0x002035D4
		// (set) Token: 0x06007301 RID: 29441 RVA: 0x00036A94 File Offset: 0x00034C94
		public unsafe List<Action> _listeners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreallocatedAction.NativeFieldInfoPtr__listeners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Action>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreallocatedAction.NativeFieldInfoPtr__listeners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004E7F RID: 20095
		private static readonly IntPtr NativeFieldInfoPtr__listeners;

		// Token: 0x04004E80 RID: 20096
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04004E81 RID: 20097
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_PreallocatedAction_PreallocatedAction_Action_0;

		// Token: 0x04004E82 RID: 20098
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_PreallocatedAction_PreallocatedAction_Action_0;

		// Token: 0x04004E83 RID: 20099
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_Action_0;

		// Token: 0x04004E84 RID: 20100
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_Action_0;

		// Token: 0x04004E85 RID: 20101
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_0;

		// Token: 0x04004E86 RID: 20102
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;
	}
}
