using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Law;
using Il2CppScheduleOne.Product.Packaging;
using Il2CppScheduleOne.State;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200074B RID: 1867
	public class ArrestNoticeScreen : Singleton<ArrestNoticeScreen>
	{
		// Token: 0x0600B600 RID: 46592 RVA: 0x002F2988 File Offset: 0x002F0B88
		// Note: this type is marked as 'beforefieldinit'.
		static ArrestNoticeScreen()
		{
			Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "ArrestNoticeScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr);
			ArrestNoticeScreen.NativeFieldInfoPtr_VEHICLE_POSSESSION_TIMEOUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, "VEHICLE_POSSESSION_TIMEOUT");
			ArrestNoticeScreen.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, "<isOpen>k__BackingField");
			ArrestNoticeScreen.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, "Canvas");
			ArrestNoticeScreen.NativeFieldInfoPtr_CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, "CanvasGroup");
			ArrestNoticeScreen.NativeFieldInfoPtr_CrimeEntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, "CrimeEntryContainer");
			ArrestNoticeScreen.NativeFieldInfoPtr_PenaltyEntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, "PenaltyEntryContainer");
			ArrestNoticeScreen.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, "State");
			ArrestNoticeScreen.NativeFieldInfoPtr_CrimeEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, "CrimeEntryPrefab");
			ArrestNoticeScreen.NativeFieldInfoPtr_PenaltyEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, "PenaltyEntryPrefab");
			ArrestNoticeScreen.NativeFieldInfoPtr_recordedCrimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, "recordedCrimes");
			ArrestNoticeScreen.NativeFieldInfoPtr_vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, "vehicle");
			ArrestNoticeScreen.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, 100687100);
			ArrestNoticeScreen.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, 100687101);
			ArrestNoticeScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, 100687102);
			ArrestNoticeScreen.NativeMethodInfoPtr_PlayerSpawned_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, 100687103);
			ArrestNoticeScreen.NativeMethodInfoPtr_Exit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, 100687104);
			ArrestNoticeScreen.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, 100687105);
			ArrestNoticeScreen.NativeMethodInfoPtr_OnClose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, 100687106);
			ArrestNoticeScreen.NativeMethodInfoPtr_RecordCrimes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, 100687107);
			ArrestNoticeScreen.NativeMethodInfoPtr_RecordPossession_Private_Void_EStealthLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, 100687108);
			ArrestNoticeScreen.NativeMethodInfoPtr_ConfiscateItems_Private_Void_EStealthLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, 100687109);
			ArrestNoticeScreen.NativeMethodInfoPtr_ClearEntries_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, 100687110);
			ArrestNoticeScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, 100687111);
			ArrestNoticeScreen.NativeMethodInfoPtr__Awake_b__14_0_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, 100687112);
			ArrestNoticeScreen.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, 100687113);
		}

		// Token: 0x170036F4 RID: 14068
		// (get) Token: 0x0600B601 RID: 46593 RVA: 0x002F2BAC File Offset: 0x002F0DAC
		// (set) Token: 0x0600B602 RID: 46594 RVA: 0x002F2BE8 File Offset: 0x002F0DE8
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 33070, RefRangeEnd = 33090, XrefRangeStart = 33070, XrefRangeEnd = 33090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B603 RID: 46595 RVA: 0x002F2C28 File Offset: 0x002F0E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305954, XrefRangeEnd = 306001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrestNoticeScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B604 RID: 46596 RVA: 0x002F2C64 File Offset: 0x002F0E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306001, XrefRangeEnd = 306013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerSpawned()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.NativeMethodInfoPtr_PlayerSpawned_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B605 RID: 46597 RVA: 0x002F2C98 File Offset: 0x002F0E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306013, XrefRangeEnd = 306015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.NativeMethodInfoPtr_Exit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B606 RID: 46598 RVA: 0x002F2CCC File Offset: 0x002F0ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306015, XrefRangeEnd = 306079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B607 RID: 46599 RVA: 0x002F2D00 File Offset: 0x002F0F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306079, XrefRangeEnd = 306087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.NativeMethodInfoPtr_OnClose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B608 RID: 46600 RVA: 0x002F2D34 File Offset: 0x002F0F34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 306158, RefRangeEnd = 306159, XrefRangeStart = 306087, XrefRangeEnd = 306158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordCrimes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.NativeMethodInfoPtr_RecordCrimes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B609 RID: 46601 RVA: 0x002F2D68 File Offset: 0x002F0F68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 306242, RefRangeEnd = 306243, XrefRangeStart = 306159, XrefRangeEnd = 306242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordPossession(EStealthLevel maxStealthLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref maxStealthLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.NativeMethodInfoPtr_RecordPossession_Private_Void_EStealthLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B60A RID: 46602 RVA: 0x002F2DA8 File Offset: 0x002F0FA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 306294, RefRangeEnd = 306295, XrefRangeStart = 306243, XrefRangeEnd = 306294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfiscateItems(EStealthLevel maxStealthLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref maxStealthLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.NativeMethodInfoPtr_ConfiscateItems_Private_Void_EStealthLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B60B RID: 46603 RVA: 0x002F2DE8 File Offset: 0x002F0FE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 306308, RefRangeEnd = 306309, XrefRangeStart = 306295, XrefRangeEnd = 306308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearEntries()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.NativeMethodInfoPtr_ClearEntries_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B60C RID: 46604 RVA: 0x002F2E1C File Offset: 0x002F101C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306309, XrefRangeEnd = 306319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrestNoticeScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B60D RID: 46605 RVA: 0x002F2E58 File Offset: 0x002F1058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306319, XrefRangeEnd = 306321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Awake_b__14_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.NativeMethodInfoPtr__Awake_b__14_0_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B60E RID: 46606 RVA: 0x002F2E94 File Offset: 0x002F1094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306321, XrefRangeEnd = 306326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600B60F RID: 46607 RVA: 0x0005457B File Offset: 0x0005277B
		public ArrestNoticeScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170036E9 RID: 14057
		// (get) Token: 0x0600B610 RID: 46608 RVA: 0x002F2ED4 File Offset: 0x002F10D4
		// (set) Token: 0x0600B611 RID: 46609 RVA: 0x00054584 File Offset: 0x00052784
		public unsafe static float VEHICLE_POSSESSION_TIMEOUT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ArrestNoticeScreen.NativeFieldInfoPtr_VEHICLE_POSSESSION_TIMEOUT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ArrestNoticeScreen.NativeFieldInfoPtr_VEHICLE_POSSESSION_TIMEOUT, (void*)(&value));
			}
		}

		// Token: 0x170036EA RID: 14058
		// (get) Token: 0x0600B612 RID: 46610 RVA: 0x002F2EF0 File Offset: 0x002F10F0
		// (set) Token: 0x0600B613 RID: 46611 RVA: 0x00054592 File Offset: 0x00052792
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x170036EB RID: 14059
		// (get) Token: 0x0600B614 RID: 46612 RVA: 0x002F2F18 File Offset: 0x002F1118
		// (set) Token: 0x0600B615 RID: 46613 RVA: 0x000545AD File Offset: 0x000527AD
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036EC RID: 14060
		// (get) Token: 0x0600B616 RID: 46614 RVA: 0x002F2F48 File Offset: 0x002F1148
		// (set) Token: 0x0600B617 RID: 46615 RVA: 0x000545CC File Offset: 0x000527CC
		public unsafe CanvasGroup CanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_CanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036ED RID: 14061
		// (get) Token: 0x0600B618 RID: 46616 RVA: 0x002F2F78 File Offset: 0x002F1178
		// (set) Token: 0x0600B619 RID: 46617 RVA: 0x000545EB File Offset: 0x000527EB
		public unsafe RectTransform CrimeEntryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_CrimeEntryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_CrimeEntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036EE RID: 14062
		// (get) Token: 0x0600B61A RID: 46618 RVA: 0x002F2FA8 File Offset: 0x002F11A8
		// (set) Token: 0x0600B61B RID: 46619 RVA: 0x0005460A File Offset: 0x0005280A
		public unsafe RectTransform PenaltyEntryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_PenaltyEntryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_PenaltyEntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036EF RID: 14063
		// (get) Token: 0x0600B61C RID: 46620 RVA: 0x002F2FD8 File Offset: 0x002F11D8
		// (set) Token: 0x0600B61D RID: 46621 RVA: 0x00054629 File Offset: 0x00052829
		public unsafe MonoState State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_State);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_State), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036F0 RID: 14064
		// (get) Token: 0x0600B61E RID: 46622 RVA: 0x002F3008 File Offset: 0x002F1208
		// (set) Token: 0x0600B61F RID: 46623 RVA: 0x00054648 File Offset: 0x00052848
		public unsafe RectTransform CrimeEntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_CrimeEntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_CrimeEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036F1 RID: 14065
		// (get) Token: 0x0600B620 RID: 46624 RVA: 0x002F3038 File Offset: 0x002F1238
		// (set) Token: 0x0600B621 RID: 46625 RVA: 0x00054667 File Offset: 0x00052867
		public unsafe RectTransform PenaltyEntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_PenaltyEntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_PenaltyEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036F2 RID: 14066
		// (get) Token: 0x0600B622 RID: 46626 RVA: 0x002F3068 File Offset: 0x002F1268
		// (set) Token: 0x0600B623 RID: 46627 RVA: 0x00054686 File Offset: 0x00052886
		public unsafe Dictionary<Crime, int> recordedCrimes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_recordedCrimes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Crime, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_recordedCrimes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036F3 RID: 14067
		// (get) Token: 0x0600B624 RID: 46628 RVA: 0x002F3098 File Offset: 0x002F1298
		// (set) Token: 0x0600B625 RID: 46629 RVA: 0x000546A5 File Offset: 0x000528A5
		public unsafe LandVehicle vehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_vehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_vehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007D1F RID: 32031
		private static readonly IntPtr NativeFieldInfoPtr_VEHICLE_POSSESSION_TIMEOUT;

		// Token: 0x04007D20 RID: 32032
		private static readonly IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x04007D21 RID: 32033
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04007D22 RID: 32034
		private static readonly IntPtr NativeFieldInfoPtr_CanvasGroup;

		// Token: 0x04007D23 RID: 32035
		private static readonly IntPtr NativeFieldInfoPtr_CrimeEntryContainer;

		// Token: 0x04007D24 RID: 32036
		private static readonly IntPtr NativeFieldInfoPtr_PenaltyEntryContainer;

		// Token: 0x04007D25 RID: 32037
		private static readonly IntPtr NativeFieldInfoPtr_State;

		// Token: 0x04007D26 RID: 32038
		private static readonly IntPtr NativeFieldInfoPtr_CrimeEntryPrefab;

		// Token: 0x04007D27 RID: 32039
		private static readonly IntPtr NativeFieldInfoPtr_PenaltyEntryPrefab;

		// Token: 0x04007D28 RID: 32040
		private static readonly IntPtr NativeFieldInfoPtr_recordedCrimes;

		// Token: 0x04007D29 RID: 32041
		private static readonly IntPtr NativeFieldInfoPtr_vehicle;

		// Token: 0x04007D2A RID: 32042
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x04007D2B RID: 32043
		private static readonly IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04007D2C RID: 32044
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04007D2D RID: 32045
		private static readonly IntPtr NativeMethodInfoPtr_PlayerSpawned_Private_Void_0;

		// Token: 0x04007D2E RID: 32046
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Void_0;

		// Token: 0x04007D2F RID: 32047
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04007D30 RID: 32048
		private static readonly IntPtr NativeMethodInfoPtr_OnClose_Private_Void_0;

		// Token: 0x04007D31 RID: 32049
		private static readonly IntPtr NativeMethodInfoPtr_RecordCrimes_Public_Void_0;

		// Token: 0x04007D32 RID: 32050
		private static readonly IntPtr NativeMethodInfoPtr_RecordPossession_Private_Void_EStealthLevel_0;

		// Token: 0x04007D33 RID: 32051
		private static readonly IntPtr NativeMethodInfoPtr_ConfiscateItems_Private_Void_EStealthLevel_0;

		// Token: 0x04007D34 RID: 32052
		private static readonly IntPtr NativeMethodInfoPtr_ClearEntries_Private_Void_0;

		// Token: 0x04007D35 RID: 32053
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007D36 RID: 32054
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__14_0_Private_Boolean_0;

		// Token: 0x04007D37 RID: 32055
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000CE1 RID: 3297
		[ObfuscatedName("ScheduleOne.UI.ArrestNoticeScreen+<<OnClose>g__CloseRoutine|18_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600F5BE RID: 62910 RVA: 0x003AFF10 File Offset: 0x003AE110
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique()
			{
				Il2CppClassPointerStore<ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, "<<OnClose>g__CloseRoutine|18_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique>.NativeClassPtr);
				ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique>.NativeClassPtr, "<>1__state");
				ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique>.NativeClassPtr, "<>2__current");
				ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique>.NativeClassPtr, "<>4__this");
				ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique>.NativeClassPtr, "<lerpTime>5__2");
				ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique>.NativeClassPtr, "<i>5__3");
				ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique>.NativeClassPtr, 100687114);
				ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique>.NativeClassPtr, 100687115);
				ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique>.NativeClassPtr, 100687116);
				ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique>.NativeClassPtr, 100687117);
				ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique>.NativeClassPtr, 100687118);
				ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique>.NativeClassPtr, 100687119);
			}

			// Token: 0x0600F5BF RID: 62911 RVA: 0x003B0018 File Offset: 0x003AE218
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F5C0 RID: 62912 RVA: 0x003B0060 File Offset: 0x003AE260
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F5C1 RID: 62913 RVA: 0x003B0094 File Offset: 0x003AE294
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305933, XrefRangeEnd = 305949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004AB1 RID: 19121
			// (get) Token: 0x0600F5C2 RID: 62914 RVA: 0x003B00D0 File Offset: 0x003AE2D0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F5C3 RID: 62915 RVA: 0x003B0110 File Offset: 0x003AE310
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305949, XrefRangeEnd = 305954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004AB2 RID: 19122
			// (get) Token: 0x0600F5C4 RID: 62916 RVA: 0x003B0144 File Offset: 0x003AE344
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F5C5 RID: 62917 RVA: 0x000742DB File Offset: 0x000724DB
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004AAC RID: 19116
			// (get) Token: 0x0600F5C6 RID: 62918 RVA: 0x003B0184 File Offset: 0x003AE384
			// (set) Token: 0x0600F5C7 RID: 62919 RVA: 0x000742E4 File Offset: 0x000724E4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004AAD RID: 19117
			// (get) Token: 0x0600F5C8 RID: 62920 RVA: 0x003B01AC File Offset: 0x003AE3AC
			// (set) Token: 0x0600F5C9 RID: 62921 RVA: 0x000742FF File Offset: 0x000724FF
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AAE RID: 19118
			// (get) Token: 0x0600F5CA RID: 62922 RVA: 0x003B01DC File Offset: 0x003AE3DC
			// (set) Token: 0x0600F5CB RID: 62923 RVA: 0x0007431E File Offset: 0x0007251E
			public unsafe ArrestNoticeScreen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrestNoticeScreen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AAF RID: 19119
			// (get) Token: 0x0600F5CC RID: 62924 RVA: 0x003B020C File Offset: 0x003AE40C
			// (set) Token: 0x0600F5CD RID: 62925 RVA: 0x0007433D File Offset: 0x0007253D
			public unsafe float _lerpTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__2)) = value;
				}
			}

			// Token: 0x17004AB0 RID: 19120
			// (get) Token: 0x0600F5CE RID: 62926 RVA: 0x003B0234 File Offset: 0x003AE434
			// (set) Token: 0x0600F5CF RID: 62927 RVA: 0x00074358 File Offset: 0x00072558
			public unsafe float _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x0400A64B RID: 42571
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A64C RID: 42572
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A64D RID: 42573
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A64E RID: 42574
			private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__2;

			// Token: 0x0400A64F RID: 42575
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x0400A650 RID: 42576
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A651 RID: 42577
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A652 RID: 42578
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A653 RID: 42579
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A654 RID: 42580
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A655 RID: 42581
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
