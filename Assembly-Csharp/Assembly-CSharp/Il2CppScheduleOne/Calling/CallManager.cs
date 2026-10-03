using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ScriptableObjects;
using Il2CppSystem;

namespace Il2CppScheduleOne.Calling
{
	// Token: 0x02000453 RID: 1107
	public class CallManager : Singleton<CallManager>
	{
		// Token: 0x0600649F RID: 25759 RVA: 0x001D8248 File Offset: 0x001D6448
		// Note: this type is marked as 'beforefieldinit'.
		static CallManager()
		{
			Il2CppClassPointerStore<CallManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Calling", "CallManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallManager>.NativeClassPtr);
			CallManager.NativeFieldInfoPtr__QueuedCallData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallManager>.NativeClassPtr, "<QueuedCallData>k__BackingField");
			CallManager.NativeFieldInfoPtr_OnCallQueued = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallManager>.NativeClassPtr, "OnCallQueued");
			CallManager.NativeFieldInfoPtr_testData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallManager>.NativeClassPtr, "testData");
			CallManager.NativeMethodInfoPtr_get_QueuedCallData_Private_get_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallManager>.NativeClassPtr, 100676516);
			CallManager.NativeMethodInfoPtr_set_QueuedCallData_Private_set_Void_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallManager>.NativeClassPtr, 100676517);
			CallManager.NativeMethodInfoPtr_add_OnCallQueued_Public_add_Void_Action_1_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallManager>.NativeClassPtr, 100676518);
			CallManager.NativeMethodInfoPtr_remove_OnCallQueued_Public_rem_Void_Action_1_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallManager>.NativeClassPtr, 100676519);
			CallManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallManager>.NativeClassPtr, 100676520);
			CallManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallManager>.NativeClassPtr, 100676521);
			CallManager.NativeMethodInfoPtr_QueueCall_Public_Void_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallManager>.NativeClassPtr, 100676522);
			CallManager.NativeMethodInfoPtr_ClearQueuedCall_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallManager>.NativeClassPtr, 100676523);
			CallManager.NativeMethodInfoPtr_CallCompleted_Private_Void_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallManager>.NativeClassPtr, 100676524);
			CallManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallManager>.NativeClassPtr, 100676525);
		}

		// Token: 0x17001EDC RID: 7900
		// (get) Token: 0x060064A0 RID: 25760 RVA: 0x001D837C File Offset: 0x001D657C
		// (set) Token: 0x060064A1 RID: 25761 RVA: 0x001D83BC File Offset: 0x001D65BC
		public unsafe PhoneCallData QueuedCallData
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallManager.NativeMethodInfoPtr_get_QueuedCallData_Private_get_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PhoneCallData>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallManager.NativeMethodInfoPtr_set_QueuedCallData_Private_set_Void_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060064A2 RID: 25762 RVA: 0x001D8400 File Offset: 0x001D6600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211186, XrefRangeEnd = 211191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnCallQueued(Action<PhoneCallData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallManager.NativeMethodInfoPtr_add_OnCallQueued_Public_add_Void_Action_1_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064A3 RID: 25763 RVA: 0x001D8444 File Offset: 0x001D6644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211191, XrefRangeEnd = 211196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnCallQueued(Action<PhoneCallData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallManager.NativeMethodInfoPtr_remove_OnCallQueued_Public_rem_Void_Action_1_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064A4 RID: 25764 RVA: 0x001D8488 File Offset: 0x001D6688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211196, XrefRangeEnd = 211224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064A5 RID: 25765 RVA: 0x001D84C4 File Offset: 0x001D66C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211224, XrefRangeEnd = 211245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064A6 RID: 25766 RVA: 0x001D8500 File Offset: 0x001D6700
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 211247, RefRangeEnd = 211250, XrefRangeStart = 211245, XrefRangeEnd = 211247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueueCall(PhoneCallData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallManager.NativeMethodInfoPtr_QueueCall_Public_Void_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064A7 RID: 25767 RVA: 0x001D8544 File Offset: 0x001D6744
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 211252, RefRangeEnd = 211253, XrefRangeStart = 211250, XrefRangeEnd = 211252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearQueuedCall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallManager.NativeMethodInfoPtr_ClearQueuedCall_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064A8 RID: 25768 RVA: 0x001D8578 File Offset: 0x001D6778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211253, XrefRangeEnd = 211258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CallCompleted(PhoneCallData call)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(call);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallManager.NativeMethodInfoPtr_CallCompleted_Private_Void_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064A9 RID: 25769 RVA: 0x001D85BC File Offset: 0x001D67BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211258, XrefRangeEnd = 211261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064AA RID: 25770 RVA: 0x0002F63D File Offset: 0x0002D83D
		public CallManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001ED9 RID: 7897
		// (get) Token: 0x060064AB RID: 25771 RVA: 0x001D85F8 File Offset: 0x001D67F8
		// (set) Token: 0x060064AC RID: 25772 RVA: 0x0002F646 File Offset: 0x0002D846
		public unsafe PhoneCallData _QueuedCallData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallManager.NativeFieldInfoPtr__QueuedCallData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneCallData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallManager.NativeFieldInfoPtr__QueuedCallData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EDA RID: 7898
		// (get) Token: 0x060064AD RID: 25773 RVA: 0x001D8628 File Offset: 0x001D6828
		// (set) Token: 0x060064AE RID: 25774 RVA: 0x0002F665 File Offset: 0x0002D865
		public unsafe Action<PhoneCallData> OnCallQueued
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallManager.NativeFieldInfoPtr_OnCallQueued);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<PhoneCallData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallManager.NativeFieldInfoPtr_OnCallQueued), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EDB RID: 7899
		// (get) Token: 0x060064AF RID: 25775 RVA: 0x001D8658 File Offset: 0x001D6858
		// (set) Token: 0x060064B0 RID: 25776 RVA: 0x0002F684 File Offset: 0x0002D884
		public unsafe PhoneCallData testData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallManager.NativeFieldInfoPtr_testData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneCallData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallManager.NativeFieldInfoPtr_testData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004562 RID: 17762
		private static readonly IntPtr NativeFieldInfoPtr__QueuedCallData_k__BackingField;

		// Token: 0x04004563 RID: 17763
		private static readonly IntPtr NativeFieldInfoPtr_OnCallQueued;

		// Token: 0x04004564 RID: 17764
		private static readonly IntPtr NativeFieldInfoPtr_testData;

		// Token: 0x04004565 RID: 17765
		private static readonly IntPtr NativeMethodInfoPtr_get_QueuedCallData_Private_get_PhoneCallData_0;

		// Token: 0x04004566 RID: 17766
		private static readonly IntPtr NativeMethodInfoPtr_set_QueuedCallData_Private_set_Void_PhoneCallData_0;

		// Token: 0x04004567 RID: 17767
		private static readonly IntPtr NativeMethodInfoPtr_add_OnCallQueued_Public_add_Void_Action_1_PhoneCallData_0;

		// Token: 0x04004568 RID: 17768
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnCallQueued_Public_rem_Void_Action_1_PhoneCallData_0;

		// Token: 0x04004569 RID: 17769
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400456A RID: 17770
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x0400456B RID: 17771
		private static readonly IntPtr NativeMethodInfoPtr_QueueCall_Public_Void_PhoneCallData_0;

		// Token: 0x0400456C RID: 17772
		private static readonly IntPtr NativeMethodInfoPtr_ClearQueuedCall_Public_Void_0;

		// Token: 0x0400456D RID: 17773
		private static readonly IntPtr NativeMethodInfoPtr_CallCompleted_Private_Void_PhoneCallData_0;

		// Token: 0x0400456E RID: 17774
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
