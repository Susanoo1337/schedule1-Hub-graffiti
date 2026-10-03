using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.Lighting;
using Il2CppScheduleOne.ScriptableObjects;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Calling
{
	// Token: 0x02000454 RID: 1108
	public class PayPhone : MonoBehaviour
	{
		// Token: 0x060064B1 RID: 25777 RVA: 0x001D8688 File Offset: 0x001D6888
		// Note: this type is marked as 'beforefieldinit'.
		static PayPhone()
		{
			Il2CppClassPointerStore<PayPhone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Calling", "PayPhone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PayPhone>.NativeClassPtr);
			PayPhone.NativeFieldInfoPtr_RING_INTERVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, "RING_INTERVAL");
			PayPhone.NativeFieldInfoPtr_RING_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, "RING_RANGE");
			PayPhone.NativeFieldInfoPtr_ringRangeSquared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, "ringRangeSquared");
			PayPhone.NativeFieldInfoPtr_QueuedCall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, "QueuedCall");
			PayPhone.NativeFieldInfoPtr_ActiveCall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, "ActiveCall");
			PayPhone.NativeFieldInfoPtr_Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, "Light");
			PayPhone.NativeFieldInfoPtr_RingSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, "RingSound");
			PayPhone.NativeFieldInfoPtr_AnswerSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, "AnswerSound");
			PayPhone.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, "IntObj");
			PayPhone.NativeFieldInfoPtr_CameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, "CameraPosition");
			PayPhone.NativeFieldInfoPtr_lastRingTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, "lastRingTime");
			PayPhone.NativeFieldInfoPtr_periodicRingHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, "periodicRingHandle");
			PayPhone.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, 100676526);
			PayPhone.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, 100676527);
			PayPhone.NativeMethodInfoPtr_OnCallStarted_Private_Void_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, 100676528);
			PayPhone.NativeMethodInfoPtr_OnCallCompleted_Private_Void_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, 100676529);
			PayPhone.NativeMethodInfoPtr_OnCallEnded_Private_Void_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, 100676530);
			PayPhone.NativeMethodInfoPtr_OnCallQueued_Private_Void_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, 100676531);
			PayPhone.NativeMethodInfoPtr_UpdateCallState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, 100676532);
			PayPhone.NativeMethodInfoPtr_PeriodicRing_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, 100676533);
			PayPhone.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, 100676534);
			PayPhone.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, 100676535);
			PayPhone.NativeMethodInfoPtr_CanInteract_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, 100676536);
			PayPhone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, 100676537);
		}

		// Token: 0x060064B2 RID: 25778 RVA: 0x001D8898 File Offset: 0x001D6A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211282, XrefRangeEnd = 211326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PayPhone.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064B3 RID: 25779 RVA: 0x001D88CC File Offset: 0x001D6ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211326, XrefRangeEnd = 211366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PayPhone.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064B4 RID: 25780 RVA: 0x001D8900 File Offset: 0x001D6B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211366, XrefRangeEnd = 211368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCallStarted(PhoneCallData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PayPhone.NativeMethodInfoPtr_OnCallStarted_Private_Void_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064B5 RID: 25781 RVA: 0x001D8944 File Offset: 0x001D6B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211368, XrefRangeEnd = 211370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCallCompleted(PhoneCallData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PayPhone.NativeMethodInfoPtr_OnCallCompleted_Private_Void_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064B6 RID: 25782 RVA: 0x001D8988 File Offset: 0x001D6B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCallEnded(PhoneCallData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PayPhone.NativeMethodInfoPtr_OnCallEnded_Private_Void_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064B7 RID: 25783 RVA: 0x001D89CC File Offset: 0x001D6BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211370, XrefRangeEnd = 211372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCallQueued(PhoneCallData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PayPhone.NativeMethodInfoPtr_OnCallQueued_Private_Void_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064B8 RID: 25784 RVA: 0x001D8A10 File Offset: 0x001D6C10
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 211382, RefRangeEnd = 211386, XrefRangeStart = 211372, XrefRangeEnd = 211382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCallState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PayPhone.NativeMethodInfoPtr_UpdateCallState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064B9 RID: 25785 RVA: 0x001D8A44 File Offset: 0x001D6C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211386, XrefRangeEnd = 211391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator PeriodicRing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PayPhone.NativeMethodInfoPtr_PeriodicRing_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060064BA RID: 25786 RVA: 0x001D8A84 File Offset: 0x001D6C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211391, XrefRangeEnd = 211393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PayPhone.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064BB RID: 25787 RVA: 0x001D8AB8 File Offset: 0x001D6CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211393, XrefRangeEnd = 211411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PayPhone.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064BC RID: 25788 RVA: 0x001D8AEC File Offset: 0x001D6CEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 211421, RefRangeEnd = 211423, XrefRangeStart = 211411, XrefRangeEnd = 211421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PayPhone.NativeMethodInfoPtr_CanInteract_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060064BD RID: 25789 RVA: 0x001D8B28 File Offset: 0x001D6D28
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PayPhone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PayPhone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PayPhone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064BE RID: 25790 RVA: 0x0002F6A3 File Offset: 0x0002D8A3
		public PayPhone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EDD RID: 7901
		// (get) Token: 0x060064BF RID: 25791 RVA: 0x001D8B64 File Offset: 0x001D6D64
		// (set) Token: 0x060064C0 RID: 25792 RVA: 0x0002F6AC File Offset: 0x0002D8AC
		public unsafe static float RING_INTERVAL
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PayPhone.NativeFieldInfoPtr_RING_INTERVAL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PayPhone.NativeFieldInfoPtr_RING_INTERVAL, (void*)(&value));
			}
		}

		// Token: 0x17001EDE RID: 7902
		// (get) Token: 0x060064C1 RID: 25793 RVA: 0x001D8B80 File Offset: 0x001D6D80
		// (set) Token: 0x060064C2 RID: 25794 RVA: 0x0002F6BA File Offset: 0x0002D8BA
		public unsafe static float RING_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PayPhone.NativeFieldInfoPtr_RING_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PayPhone.NativeFieldInfoPtr_RING_RANGE, (void*)(&value));
			}
		}

		// Token: 0x17001EDF RID: 7903
		// (get) Token: 0x060064C3 RID: 25795 RVA: 0x001D8B9C File Offset: 0x001D6D9C
		// (set) Token: 0x060064C4 RID: 25796 RVA: 0x0002F6C8 File Offset: 0x0002D8C8
		public unsafe static float ringRangeSquared
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PayPhone.NativeFieldInfoPtr_ringRangeSquared, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PayPhone.NativeFieldInfoPtr_ringRangeSquared, (void*)(&value));
			}
		}

		// Token: 0x17001EE0 RID: 7904
		// (get) Token: 0x060064C5 RID: 25797 RVA: 0x001D8BB8 File Offset: 0x001D6DB8
		// (set) Token: 0x060064C6 RID: 25798 RVA: 0x0002F6D6 File Offset: 0x0002D8D6
		public unsafe PhoneCallData QueuedCall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_QueuedCall);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneCallData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_QueuedCall), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EE1 RID: 7905
		// (get) Token: 0x060064C7 RID: 25799 RVA: 0x001D8BE8 File Offset: 0x001D6DE8
		// (set) Token: 0x060064C8 RID: 25800 RVA: 0x0002F6F5 File Offset: 0x0002D8F5
		public unsafe PhoneCallData ActiveCall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_ActiveCall);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneCallData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_ActiveCall), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EE2 RID: 7906
		// (get) Token: 0x060064C9 RID: 25801 RVA: 0x001D8C18 File Offset: 0x001D6E18
		// (set) Token: 0x060064CA RID: 25802 RVA: 0x0002F714 File Offset: 0x0002D914
		public unsafe BlinkingLight Light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_Light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlinkingLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_Light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EE3 RID: 7907
		// (get) Token: 0x060064CB RID: 25803 RVA: 0x001D8C48 File Offset: 0x001D6E48
		// (set) Token: 0x060064CC RID: 25804 RVA: 0x0002F733 File Offset: 0x0002D933
		public unsafe AudioSourceController RingSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_RingSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_RingSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EE4 RID: 7908
		// (get) Token: 0x060064CD RID: 25805 RVA: 0x001D8C78 File Offset: 0x001D6E78
		// (set) Token: 0x060064CE RID: 25806 RVA: 0x0002F752 File Offset: 0x0002D952
		public unsafe AudioSourceController AnswerSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_AnswerSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_AnswerSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EE5 RID: 7909
		// (get) Token: 0x060064CF RID: 25807 RVA: 0x001D8CA8 File Offset: 0x001D6EA8
		// (set) Token: 0x060064D0 RID: 25808 RVA: 0x0002F771 File Offset: 0x0002D971
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EE6 RID: 7910
		// (get) Token: 0x060064D1 RID: 25809 RVA: 0x001D8CD8 File Offset: 0x001D6ED8
		// (set) Token: 0x060064D2 RID: 25810 RVA: 0x0002F790 File Offset: 0x0002D990
		public unsafe Transform CameraPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_CameraPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_CameraPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EE7 RID: 7911
		// (get) Token: 0x060064D3 RID: 25811 RVA: 0x001D8D08 File Offset: 0x001D6F08
		// (set) Token: 0x060064D4 RID: 25812 RVA: 0x0002F7AF File Offset: 0x0002D9AF
		public unsafe float lastRingTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_lastRingTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_lastRingTime)) = value;
			}
		}

		// Token: 0x17001EE8 RID: 7912
		// (get) Token: 0x060064D5 RID: 25813 RVA: 0x001D8D30 File Offset: 0x001D6F30
		// (set) Token: 0x060064D6 RID: 25814 RVA: 0x0002F7CA File Offset: 0x0002D9CA
		public unsafe Coroutine periodicRingHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_periodicRingHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_periodicRingHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400456F RID: 17775
		private static readonly IntPtr NativeFieldInfoPtr_RING_INTERVAL;

		// Token: 0x04004570 RID: 17776
		private static readonly IntPtr NativeFieldInfoPtr_RING_RANGE;

		// Token: 0x04004571 RID: 17777
		private static readonly IntPtr NativeFieldInfoPtr_ringRangeSquared;

		// Token: 0x04004572 RID: 17778
		private static readonly IntPtr NativeFieldInfoPtr_QueuedCall;

		// Token: 0x04004573 RID: 17779
		private static readonly IntPtr NativeFieldInfoPtr_ActiveCall;

		// Token: 0x04004574 RID: 17780
		private static readonly IntPtr NativeFieldInfoPtr_Light;

		// Token: 0x04004575 RID: 17781
		private static readonly IntPtr NativeFieldInfoPtr_RingSound;

		// Token: 0x04004576 RID: 17782
		private static readonly IntPtr NativeFieldInfoPtr_AnswerSound;

		// Token: 0x04004577 RID: 17783
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x04004578 RID: 17784
		private static readonly IntPtr NativeFieldInfoPtr_CameraPosition;

		// Token: 0x04004579 RID: 17785
		private static readonly IntPtr NativeFieldInfoPtr_lastRingTime;

		// Token: 0x0400457A RID: 17786
		private static readonly IntPtr NativeFieldInfoPtr_periodicRingHandle;

		// Token: 0x0400457B RID: 17787
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400457C RID: 17788
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400457D RID: 17789
		private static readonly IntPtr NativeMethodInfoPtr_OnCallStarted_Private_Void_PhoneCallData_0;

		// Token: 0x0400457E RID: 17790
		private static readonly IntPtr NativeMethodInfoPtr_OnCallCompleted_Private_Void_PhoneCallData_0;

		// Token: 0x0400457F RID: 17791
		private static readonly IntPtr NativeMethodInfoPtr_OnCallEnded_Private_Void_PhoneCallData_0;

		// Token: 0x04004580 RID: 17792
		private static readonly IntPtr NativeMethodInfoPtr_OnCallQueued_Private_Void_PhoneCallData_0;

		// Token: 0x04004581 RID: 17793
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCallState_Private_Void_0;

		// Token: 0x04004582 RID: 17794
		private static readonly IntPtr NativeMethodInfoPtr_PeriodicRing_Private_IEnumerator_0;

		// Token: 0x04004583 RID: 17795
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x04004584 RID: 17796
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x04004585 RID: 17797
		private static readonly IntPtr NativeMethodInfoPtr_CanInteract_Private_Boolean_0;

		// Token: 0x04004586 RID: 17798
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B3F RID: 2879
		[ObfuscatedName("ScheduleOne.Calling.PayPhone+<PeriodicRing>d__19")]
		public sealed class _PeriodicRing_d__19 : Il2CppSystem.Object
		{
			// Token: 0x0600E6F1 RID: 59121 RVA: 0x003852F0 File Offset: 0x003834F0
			// Note: this type is marked as 'beforefieldinit'.
			static _PeriodicRing_d__19()
			{
				Il2CppClassPointerStore<PayPhone._PeriodicRing_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, "<PeriodicRing>d__19");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PayPhone._PeriodicRing_d__19>.NativeClassPtr);
				PayPhone._PeriodicRing_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PayPhone._PeriodicRing_d__19>.NativeClassPtr, "<>1__state");
				PayPhone._PeriodicRing_d__19.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PayPhone._PeriodicRing_d__19>.NativeClassPtr, "<>2__current");
				PayPhone._PeriodicRing_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PayPhone._PeriodicRing_d__19>.NativeClassPtr, "<>4__this");
				PayPhone._PeriodicRing_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PayPhone._PeriodicRing_d__19>.NativeClassPtr, 100676538);
				PayPhone._PeriodicRing_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PayPhone._PeriodicRing_d__19>.NativeClassPtr, 100676539);
				PayPhone._PeriodicRing_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PayPhone._PeriodicRing_d__19>.NativeClassPtr, 100676540);
				PayPhone._PeriodicRing_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PayPhone._PeriodicRing_d__19>.NativeClassPtr, 100676541);
				PayPhone._PeriodicRing_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PayPhone._PeriodicRing_d__19>.NativeClassPtr, 100676542);
				PayPhone._PeriodicRing_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PayPhone._PeriodicRing_d__19>.NativeClassPtr, 100676543);
			}

			// Token: 0x0600E6F2 RID: 59122 RVA: 0x003853D0 File Offset: 0x003835D0
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PeriodicRing_d__19(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PayPhone._PeriodicRing_d__19>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PayPhone._PeriodicRing_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E6F3 RID: 59123 RVA: 0x00385418 File Offset: 0x00383618
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PayPhone._PeriodicRing_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E6F4 RID: 59124 RVA: 0x0038544C File Offset: 0x0038364C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211261, XrefRangeEnd = 211277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PayPhone._PeriodicRing_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004619 RID: 17945
			// (get) Token: 0x0600E6F5 RID: 59125 RVA: 0x00385488 File Offset: 0x00383688
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PayPhone._PeriodicRing_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E6F6 RID: 59126 RVA: 0x003854C8 File Offset: 0x003836C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211277, XrefRangeEnd = 211282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PayPhone._PeriodicRing_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700461A RID: 17946
			// (get) Token: 0x0600E6F7 RID: 59127 RVA: 0x003854FC File Offset: 0x003836FC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PayPhone._PeriodicRing_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E6F8 RID: 59128 RVA: 0x0006CED2 File Offset: 0x0006B0D2
			public _PeriodicRing_d__19(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004616 RID: 17942
			// (get) Token: 0x0600E6F9 RID: 59129 RVA: 0x0038553C File Offset: 0x0038373C
			// (set) Token: 0x0600E6FA RID: 59130 RVA: 0x0006CEDB File Offset: 0x0006B0DB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone._PeriodicRing_d__19.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone._PeriodicRing_d__19.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004617 RID: 17943
			// (get) Token: 0x0600E6FB RID: 59131 RVA: 0x00385564 File Offset: 0x00383764
			// (set) Token: 0x0600E6FC RID: 59132 RVA: 0x0006CEF6 File Offset: 0x0006B0F6
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone._PeriodicRing_d__19.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone._PeriodicRing_d__19.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004618 RID: 17944
			// (get) Token: 0x0600E6FD RID: 59133 RVA: 0x00385594 File Offset: 0x00383794
			// (set) Token: 0x0600E6FE RID: 59134 RVA: 0x0006CF15 File Offset: 0x0006B115
			public unsafe PayPhone __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone._PeriodicRing_d__19.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PayPhone>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone._PeriodicRing_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009CC2 RID: 40130
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009CC3 RID: 40131
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009CC4 RID: 40132
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009CC5 RID: 40133
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009CC6 RID: 40134
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009CC7 RID: 40135
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009CC8 RID: 40136
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009CC9 RID: 40137
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009CCA RID: 40138
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
