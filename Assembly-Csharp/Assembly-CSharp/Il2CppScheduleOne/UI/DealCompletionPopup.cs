using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.Quests;
using Il2CppScheduleOne.UI.Relations;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200072A RID: 1834
	public class DealCompletionPopup : Singleton<DealCompletionPopup>
	{
		// Token: 0x0600B0D7 RID: 45271 RVA: 0x002E34D4 File Offset: 0x002E16D4
		// Note: this type is marked as 'beforefieldinit'.
		static DealCompletionPopup()
		{
			Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "DealCompletionPopup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr);
			DealCompletionPopup.NativeFieldInfoPtr__IsPlaying_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "<IsPlaying>k__BackingField");
			DealCompletionPopup.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "Canvas");
			DealCompletionPopup.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "Container");
			DealCompletionPopup.NativeFieldInfoPtr_Group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "Group");
			DealCompletionPopup.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "Anim");
			DealCompletionPopup.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "Title");
			DealCompletionPopup.NativeFieldInfoPtr_PaymentLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "PaymentLabel");
			DealCompletionPopup.NativeFieldInfoPtr_SatisfactionValueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "SatisfactionValueLabel");
			DealCompletionPopup.NativeFieldInfoPtr_RelationCircle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "RelationCircle");
			DealCompletionPopup.NativeFieldInfoPtr_RelationshipLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "RelationshipLabel");
			DealCompletionPopup.NativeFieldInfoPtr_SatisfactionGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "SatisfactionGradient");
			DealCompletionPopup.NativeFieldInfoPtr_SoundEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "SoundEffect");
			DealCompletionPopup.NativeFieldInfoPtr_BonusLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "BonusLabels");
			DealCompletionPopup.NativeFieldInfoPtr__animation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "_animation");
			DealCompletionPopup.NativeFieldInfoPtr_routine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "routine");
			DealCompletionPopup.NativeFieldInfoPtr__animationState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "_animationState");
			DealCompletionPopup.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, 100686551);
			DealCompletionPopup.NativeMethodInfoPtr_set_IsPlaying_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, 100686552);
			DealCompletionPopup.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, 100686553);
			DealCompletionPopup.NativeMethodInfoPtr_PlayPopup_Public_Void_Customer_Single_Single_Single_List_1_BonusPayment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, 100686554);
			DealCompletionPopup.NativeMethodInfoPtr_PlayPopupRoutine_Private_IEnumerator_Customer_Single_Single_Single_List_1_BonusPayment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, 100686555);
			DealCompletionPopup.NativeMethodInfoPtr_SetRelationshipLabel_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, 100686556);
			DealCompletionPopup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, 100686557);
			DealCompletionPopup.NativeMethodInfoPtr__PlayPopupRoutine_b__21_0_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, 100686558);
		}

		// Token: 0x1700352D RID: 13613
		// (get) Token: 0x0600B0D8 RID: 45272 RVA: 0x002E36E4 File Offset: 0x002E18E4
		// (set) Token: 0x0600B0D9 RID: 45273 RVA: 0x002E3720 File Offset: 0x002E1920
		public unsafe bool IsPlaying
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.NativeMethodInfoPtr_set_IsPlaying_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B0DA RID: 45274 RVA: 0x002E3760 File Offset: 0x002E1960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300446, XrefRangeEnd = 300457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DealCompletionPopup.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B0DB RID: 45275 RVA: 0x002E379C File Offset: 0x002E199C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 300481, RefRangeEnd = 300482, XrefRangeStart = 300457, XrefRangeEnd = 300481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayPopup(Customer customer, float satisfaction, float originalRelationshipDelta, float basePayment, List<Contract.BonusPayment> bonuses)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref satisfaction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originalRelationshipDelta;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref basePayment;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bonuses);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.NativeMethodInfoPtr_PlayPopup_Public_Void_Customer_Single_Single_Single_List_1_BonusPayment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B0DC RID: 45276 RVA: 0x002E381C File Offset: 0x002E1A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300482, XrefRangeEnd = 300489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator PlayPopupRoutine(Customer customer, float satisfaction, float originalRelationshipDelta, float basePayment, List<Contract.BonusPayment> bonuses)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref satisfaction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originalRelationshipDelta;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref basePayment;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bonuses);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.NativeMethodInfoPtr_PlayPopupRoutine_Private_IEnumerator_Customer_Single_Single_Single_List_1_BonusPayment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600B0DD RID: 45277 RVA: 0x002E38AC File Offset: 0x002E1AAC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 300497, RefRangeEnd = 300500, XrefRangeStart = 300489, XrefRangeEnd = 300497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRelationshipLabel(float delta)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref delta;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.NativeMethodInfoPtr_SetRelationshipLabel_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B0DE RID: 45278 RVA: 0x002E38EC File Offset: 0x002E1AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300500, XrefRangeEnd = 300503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DealCompletionPopup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B0DF RID: 45279 RVA: 0x002E3928 File Offset: 0x002E1B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300503, XrefRangeEnd = 300504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _PlayPopupRoutine_b__21_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.NativeMethodInfoPtr__PlayPopupRoutine_b__21_0_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B0E0 RID: 45280 RVA: 0x0005137D File Offset: 0x0004F57D
		public DealCompletionPopup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700351D RID: 13597
		// (get) Token: 0x0600B0E1 RID: 45281 RVA: 0x002E3964 File Offset: 0x002E1B64
		// (set) Token: 0x0600B0E2 RID: 45282 RVA: 0x00051386 File Offset: 0x0004F586
		public unsafe bool _IsPlaying_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr__IsPlaying_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr__IsPlaying_k__BackingField)) = value;
			}
		}

		// Token: 0x1700351E RID: 13598
		// (get) Token: 0x0600B0E3 RID: 45283 RVA: 0x002E398C File Offset: 0x002E1B8C
		// (set) Token: 0x0600B0E4 RID: 45284 RVA: 0x000513A1 File Offset: 0x0004F5A1
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700351F RID: 13599
		// (get) Token: 0x0600B0E5 RID: 45285 RVA: 0x002E39BC File Offset: 0x002E1BBC
		// (set) Token: 0x0600B0E6 RID: 45286 RVA: 0x000513C0 File Offset: 0x0004F5C0
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003520 RID: 13600
		// (get) Token: 0x0600B0E7 RID: 45287 RVA: 0x002E39EC File Offset: 0x002E1BEC
		// (set) Token: 0x0600B0E8 RID: 45288 RVA: 0x000513DF File Offset: 0x0004F5DF
		public unsafe CanvasGroup Group
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_Group);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_Group), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003521 RID: 13601
		// (get) Token: 0x0600B0E9 RID: 45289 RVA: 0x002E3A1C File Offset: 0x002E1C1C
		// (set) Token: 0x0600B0EA RID: 45290 RVA: 0x000513FE File Offset: 0x0004F5FE
		public unsafe Animation Anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_Anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003522 RID: 13602
		// (get) Token: 0x0600B0EB RID: 45291 RVA: 0x002E3A4C File Offset: 0x002E1C4C
		// (set) Token: 0x0600B0EC RID: 45292 RVA: 0x0005141D File Offset: 0x0004F61D
		public unsafe TextMeshProUGUI Title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_Title);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_Title), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003523 RID: 13603
		// (get) Token: 0x0600B0ED RID: 45293 RVA: 0x002E3A7C File Offset: 0x002E1C7C
		// (set) Token: 0x0600B0EE RID: 45294 RVA: 0x0005143C File Offset: 0x0004F63C
		public unsafe TextMeshProUGUI PaymentLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_PaymentLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_PaymentLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003524 RID: 13604
		// (get) Token: 0x0600B0EF RID: 45295 RVA: 0x002E3AAC File Offset: 0x002E1CAC
		// (set) Token: 0x0600B0F0 RID: 45296 RVA: 0x0005145B File Offset: 0x0004F65B
		public unsafe TextMeshProUGUI SatisfactionValueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_SatisfactionValueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_SatisfactionValueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003525 RID: 13605
		// (get) Token: 0x0600B0F1 RID: 45297 RVA: 0x002E3ADC File Offset: 0x002E1CDC
		// (set) Token: 0x0600B0F2 RID: 45298 RVA: 0x0005147A File Offset: 0x0004F67A
		public unsafe RelationCircle RelationCircle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_RelationCircle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RelationCircle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_RelationCircle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003526 RID: 13606
		// (get) Token: 0x0600B0F3 RID: 45299 RVA: 0x002E3B0C File Offset: 0x002E1D0C
		// (set) Token: 0x0600B0F4 RID: 45300 RVA: 0x00051499 File Offset: 0x0004F699
		public unsafe TextMeshProUGUI RelationshipLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_RelationshipLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_RelationshipLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003527 RID: 13607
		// (get) Token: 0x0600B0F5 RID: 45301 RVA: 0x002E3B3C File Offset: 0x002E1D3C
		// (set) Token: 0x0600B0F6 RID: 45302 RVA: 0x000514B8 File Offset: 0x0004F6B8
		public unsafe Gradient SatisfactionGradient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_SatisfactionGradient);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_SatisfactionGradient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003528 RID: 13608
		// (get) Token: 0x0600B0F7 RID: 45303 RVA: 0x002E3B6C File Offset: 0x002E1D6C
		// (set) Token: 0x0600B0F8 RID: 45304 RVA: 0x000514D7 File Offset: 0x0004F6D7
		public unsafe AudioSourceController SoundEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_SoundEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_SoundEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003529 RID: 13609
		// (get) Token: 0x0600B0F9 RID: 45305 RVA: 0x002E3B9C File Offset: 0x002E1D9C
		// (set) Token: 0x0600B0FA RID: 45306 RVA: 0x000514F6 File Offset: 0x0004F6F6
		public unsafe Il2CppReferenceArray<TextMeshProUGUI> BonusLabels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_BonusLabels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextMeshProUGUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_BonusLabels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700352A RID: 13610
		// (get) Token: 0x0600B0FB RID: 45307 RVA: 0x002E3BCC File Offset: 0x002E1DCC
		// (set) Token: 0x0600B0FC RID: 45308 RVA: 0x00051515 File Offset: 0x0004F715
		public unsafe Animation _animation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr__animation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr__animation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700352B RID: 13611
		// (get) Token: 0x0600B0FD RID: 45309 RVA: 0x002E3BFC File Offset: 0x002E1DFC
		// (set) Token: 0x0600B0FE RID: 45310 RVA: 0x00051534 File Offset: 0x0004F734
		public unsafe Coroutine routine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_routine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_routine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700352C RID: 13612
		// (get) Token: 0x0600B0FF RID: 45311 RVA: 0x002E3C2C File Offset: 0x002E1E2C
		// (set) Token: 0x0600B100 RID: 45312 RVA: 0x00051553 File Offset: 0x0004F753
		public unsafe AnimationState _animationState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr__animationState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr__animationState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040079E1 RID: 31201
		private static readonly IntPtr NativeFieldInfoPtr__IsPlaying_k__BackingField;

		// Token: 0x040079E2 RID: 31202
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x040079E3 RID: 31203
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040079E4 RID: 31204
		private static readonly IntPtr NativeFieldInfoPtr_Group;

		// Token: 0x040079E5 RID: 31205
		private static readonly IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x040079E6 RID: 31206
		private static readonly IntPtr NativeFieldInfoPtr_Title;

		// Token: 0x040079E7 RID: 31207
		private static readonly IntPtr NativeFieldInfoPtr_PaymentLabel;

		// Token: 0x040079E8 RID: 31208
		private static readonly IntPtr NativeFieldInfoPtr_SatisfactionValueLabel;

		// Token: 0x040079E9 RID: 31209
		private static readonly IntPtr NativeFieldInfoPtr_RelationCircle;

		// Token: 0x040079EA RID: 31210
		private static readonly IntPtr NativeFieldInfoPtr_RelationshipLabel;

		// Token: 0x040079EB RID: 31211
		private static readonly IntPtr NativeFieldInfoPtr_SatisfactionGradient;

		// Token: 0x040079EC RID: 31212
		private static readonly IntPtr NativeFieldInfoPtr_SoundEffect;

		// Token: 0x040079ED RID: 31213
		private static readonly IntPtr NativeFieldInfoPtr_BonusLabels;

		// Token: 0x040079EE RID: 31214
		private static readonly IntPtr NativeFieldInfoPtr__animation;

		// Token: 0x040079EF RID: 31215
		private static readonly IntPtr NativeFieldInfoPtr_routine;

		// Token: 0x040079F0 RID: 31216
		private static readonly IntPtr NativeFieldInfoPtr__animationState;

		// Token: 0x040079F1 RID: 31217
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0;

		// Token: 0x040079F2 RID: 31218
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPlaying_Protected_set_Void_Boolean_0;

		// Token: 0x040079F3 RID: 31219
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040079F4 RID: 31220
		private static readonly IntPtr NativeMethodInfoPtr_PlayPopup_Public_Void_Customer_Single_Single_Single_List_1_BonusPayment_0;

		// Token: 0x040079F5 RID: 31221
		private static readonly IntPtr NativeMethodInfoPtr_PlayPopupRoutine_Private_IEnumerator_Customer_Single_Single_Single_List_1_BonusPayment_0;

		// Token: 0x040079F6 RID: 31222
		private static readonly IntPtr NativeMethodInfoPtr_SetRelationshipLabel_Private_Void_Single_0;

		// Token: 0x040079F7 RID: 31223
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040079F8 RID: 31224
		private static readonly IntPtr NativeMethodInfoPtr__PlayPopupRoutine_b__21_0_Private_Boolean_0;

		// Token: 0x02000CBF RID: 3263
		[ObfuscatedName("ScheduleOne.UI.DealCompletionPopup+<PlayPopupRoutine>d__21")]
		public sealed class _PlayPopupRoutine_d__21 : Il2CppSystem.Object
		{
			// Token: 0x0600F43B RID: 62523 RVA: 0x003ABD3C File Offset: 0x003A9F3C
			// Note: this type is marked as 'beforefieldinit'.
			static _PlayPopupRoutine_d__21()
			{
				Il2CppClassPointerStore<DealCompletionPopup._PlayPopupRoutine_d__21>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "<PlayPopupRoutine>d__21");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealCompletionPopup._PlayPopupRoutine_d__21>.NativeClassPtr);
				DealCompletionPopup._PlayPopupRoutine_d__21.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup._PlayPopupRoutine_d__21>.NativeClassPtr, "<>1__state");
				DealCompletionPopup._PlayPopupRoutine_d__21.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup._PlayPopupRoutine_d__21>.NativeClassPtr, "<>2__current");
				DealCompletionPopup._PlayPopupRoutine_d__21.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup._PlayPopupRoutine_d__21>.NativeClassPtr, "<>4__this");
				DealCompletionPopup._PlayPopupRoutine_d__21.NativeFieldInfoPtr_customer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup._PlayPopupRoutine_d__21>.NativeClassPtr, "customer");
				DealCompletionPopup._PlayPopupRoutine_d__21.NativeFieldInfoPtr_bonuses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup._PlayPopupRoutine_d__21>.NativeClassPtr, "bonuses");
				DealCompletionPopup._PlayPopupRoutine_d__21.NativeFieldInfoPtr_originalRelationshipDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup._PlayPopupRoutine_d__21>.NativeClassPtr, "originalRelationshipDelta");
				DealCompletionPopup._PlayPopupRoutine_d__21.NativeFieldInfoPtr_basePayment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup._PlayPopupRoutine_d__21>.NativeClassPtr, "basePayment");
				DealCompletionPopup._PlayPopupRoutine_d__21.NativeFieldInfoPtr_satisfaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup._PlayPopupRoutine_d__21>.NativeClassPtr, "satisfaction");
				DealCompletionPopup._PlayPopupRoutine_d__21.NativeFieldInfoPtr__paymentLerpTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup._PlayPopupRoutine_d__21>.NativeClassPtr, "<paymentLerpTime>5__2");
				DealCompletionPopup._PlayPopupRoutine_d__21.NativeFieldInfoPtr__satisfactionLerpTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup._PlayPopupRoutine_d__21>.NativeClassPtr, "<satisfactionLerpTime>5__3");
				DealCompletionPopup._PlayPopupRoutine_d__21.NativeFieldInfoPtr__endDelta_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup._PlayPopupRoutine_d__21>.NativeClassPtr, "<endDelta>5__4");
				DealCompletionPopup._PlayPopupRoutine_d__21.NativeFieldInfoPtr__lerpTime_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup._PlayPopupRoutine_d__21>.NativeClassPtr, "<lerpTime>5__5");
				DealCompletionPopup._PlayPopupRoutine_d__21.NativeFieldInfoPtr__i_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup._PlayPopupRoutine_d__21>.NativeClassPtr, "<i>5__6");
				DealCompletionPopup._PlayPopupRoutine_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup._PlayPopupRoutine_d__21>.NativeClassPtr, 100686559);
				DealCompletionPopup._PlayPopupRoutine_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup._PlayPopupRoutine_d__21>.NativeClassPtr, 100686560);
				DealCompletionPopup._PlayPopupRoutine_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup._PlayPopupRoutine_d__21>.NativeClassPtr, 100686561);
				DealCompletionPopup._PlayPopupRoutine_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup._PlayPopupRoutine_d__21>.NativeClassPtr, 100686562);
				DealCompletionPopup._PlayPopupRoutine_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup._PlayPopupRoutine_d__21>.NativeClassPtr, 100686563);
				DealCompletionPopup._PlayPopupRoutine_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup._PlayPopupRoutine_d__21>.NativeClassPtr, 100686564);
			}

			// Token: 0x0600F43C RID: 62524 RVA: 0x003ABEE4 File Offset: 0x003AA0E4
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PlayPopupRoutine_d__21(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealCompletionPopup._PlayPopupRoutine_d__21>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup._PlayPopupRoutine_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F43D RID: 62525 RVA: 0x003ABF2C File Offset: 0x003AA12C
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup._PlayPopupRoutine_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F43E RID: 62526 RVA: 0x003ABF60 File Offset: 0x003AA160
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300316, XrefRangeEnd = 300441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup._PlayPopupRoutine_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004A2F RID: 18991
			// (get) Token: 0x0600F43F RID: 62527 RVA: 0x003ABF9C File Offset: 0x003AA19C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup._PlayPopupRoutine_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F440 RID: 62528 RVA: 0x003ABFDC File Offset: 0x003AA1DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300441, XrefRangeEnd = 300446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup._PlayPopupRoutine_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004A30 RID: 18992
			// (get) Token: 0x0600F441 RID: 62529 RVA: 0x003AC010 File Offset: 0x003AA210
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup._PlayPopupRoutine_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F442 RID: 62530 RVA: 0x0007355D File Offset: 0x0007175D
			public _PlayPopupRoutine_d__21(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A22 RID: 18978
			// (get) Token: 0x0600F443 RID: 62531 RVA: 0x003AC050 File Offset: 0x003AA250
			// (set) Token: 0x0600F444 RID: 62532 RVA: 0x00073566 File Offset: 0x00071766
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup._PlayPopupRoutine_d__21.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup._PlayPopupRoutine_d__21.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004A23 RID: 18979
			// (get) Token: 0x0600F445 RID: 62533 RVA: 0x003AC078 File Offset: 0x003AA278
			// (set) Token: 0x0600F446 RID: 62534 RVA: 0x00073581 File Offset: 0x00071781
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup._PlayPopupRoutine_d__21.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup._PlayPopupRoutine_d__21.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A24 RID: 18980
			// (get) Token: 0x0600F447 RID: 62535 RVA: 0x003AC0A8 File Offset: 0x003AA2A8
			// (set) Token: 0x0600F448 RID: 62536 RVA: 0x000735A0 File Offset: 0x000717A0
			public unsafe DealCompletionPopup __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup._PlayPopupRoutine_d__21.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DealCompletionPopup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup._PlayPopupRoutine_d__21.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A25 RID: 18981
			// (get) Token: 0x0600F449 RID: 62537 RVA: 0x003AC0D8 File Offset: 0x003AA2D8
			// (set) Token: 0x0600F44A RID: 62538 RVA: 0x000735BF File Offset: 0x000717BF
			public unsafe Customer customer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup._PlayPopupRoutine_d__21.NativeFieldInfoPtr_customer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup._PlayPopupRoutine_d__21.NativeFieldInfoPtr_customer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A26 RID: 18982
			// (get) Token: 0x0600F44B RID: 62539 RVA: 0x003AC108 File Offset: 0x003AA308
			// (set) Token: 0x0600F44C RID: 62540 RVA: 0x000735DE File Offset: 0x000717DE
			public unsafe List<Contract.BonusPayment> bonuses
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup._PlayPopupRoutine_d__21.NativeFieldInfoPtr_bonuses);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Contract.BonusPayment>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup._PlayPopupRoutine_d__21.NativeFieldInfoPtr_bonuses), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A27 RID: 18983
			// (get) Token: 0x0600F44D RID: 62541 RVA: 0x003AC138 File Offset: 0x003AA338
			// (set) Token: 0x0600F44E RID: 62542 RVA: 0x000735FD File Offset: 0x000717FD
			public unsafe float originalRelationshipDelta
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup._PlayPopupRoutine_d__21.NativeFieldInfoPtr_originalRelationshipDelta);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup._PlayPopupRoutine_d__21.NativeFieldInfoPtr_originalRelationshipDelta)) = value;
				}
			}

			// Token: 0x17004A28 RID: 18984
			// (get) Token: 0x0600F44F RID: 62543 RVA: 0x003AC160 File Offset: 0x003AA360
			// (set) Token: 0x0600F450 RID: 62544 RVA: 0x00073618 File Offset: 0x00071818
			public unsafe float basePayment
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup._PlayPopupRoutine_d__21.NativeFieldInfoPtr_basePayment);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup._PlayPopupRoutine_d__21.NativeFieldInfoPtr_basePayment)) = value;
				}
			}

			// Token: 0x17004A29 RID: 18985
			// (get) Token: 0x0600F451 RID: 62545 RVA: 0x003AC188 File Offset: 0x003AA388
			// (set) Token: 0x0600F452 RID: 62546 RVA: 0x00073633 File Offset: 0x00071833
			public unsafe float satisfaction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup._PlayPopupRoutine_d__21.NativeFieldInfoPtr_satisfaction);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup._PlayPopupRoutine_d__21.NativeFieldInfoPtr_satisfaction)) = value;
				}
			}

			// Token: 0x17004A2A RID: 18986
			// (get) Token: 0x0600F453 RID: 62547 RVA: 0x003AC1B0 File Offset: 0x003AA3B0
			// (set) Token: 0x0600F454 RID: 62548 RVA: 0x0007364E File Offset: 0x0007184E
			public unsafe float _paymentLerpTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup._PlayPopupRoutine_d__21.NativeFieldInfoPtr__paymentLerpTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup._PlayPopupRoutine_d__21.NativeFieldInfoPtr__paymentLerpTime_5__2)) = value;
				}
			}

			// Token: 0x17004A2B RID: 18987
			// (get) Token: 0x0600F455 RID: 62549 RVA: 0x003AC1D8 File Offset: 0x003AA3D8
			// (set) Token: 0x0600F456 RID: 62550 RVA: 0x00073669 File Offset: 0x00071869
			public unsafe float _satisfactionLerpTime_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup._PlayPopupRoutine_d__21.NativeFieldInfoPtr__satisfactionLerpTime_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup._PlayPopupRoutine_d__21.NativeFieldInfoPtr__satisfactionLerpTime_5__3)) = value;
				}
			}

			// Token: 0x17004A2C RID: 18988
			// (get) Token: 0x0600F457 RID: 62551 RVA: 0x003AC200 File Offset: 0x003AA400
			// (set) Token: 0x0600F458 RID: 62552 RVA: 0x00073684 File Offset: 0x00071884
			public unsafe float _endDelta_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup._PlayPopupRoutine_d__21.NativeFieldInfoPtr__endDelta_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup._PlayPopupRoutine_d__21.NativeFieldInfoPtr__endDelta_5__4)) = value;
				}
			}

			// Token: 0x17004A2D RID: 18989
			// (get) Token: 0x0600F459 RID: 62553 RVA: 0x003AC228 File Offset: 0x003AA428
			// (set) Token: 0x0600F45A RID: 62554 RVA: 0x0007369F File Offset: 0x0007189F
			public unsafe float _lerpTime_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup._PlayPopupRoutine_d__21.NativeFieldInfoPtr__lerpTime_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup._PlayPopupRoutine_d__21.NativeFieldInfoPtr__lerpTime_5__5)) = value;
				}
			}

			// Token: 0x17004A2E RID: 18990
			// (get) Token: 0x0600F45B RID: 62555 RVA: 0x003AC250 File Offset: 0x003AA450
			// (set) Token: 0x0600F45C RID: 62556 RVA: 0x000736BA File Offset: 0x000718BA
			public unsafe float _i_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup._PlayPopupRoutine_d__21.NativeFieldInfoPtr__i_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup._PlayPopupRoutine_d__21.NativeFieldInfoPtr__i_5__6)) = value;
				}
			}

			// Token: 0x0400A55C RID: 42332
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A55D RID: 42333
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A55E RID: 42334
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A55F RID: 42335
			private static readonly IntPtr NativeFieldInfoPtr_customer;

			// Token: 0x0400A560 RID: 42336
			private static readonly IntPtr NativeFieldInfoPtr_bonuses;

			// Token: 0x0400A561 RID: 42337
			private static readonly IntPtr NativeFieldInfoPtr_originalRelationshipDelta;

			// Token: 0x0400A562 RID: 42338
			private static readonly IntPtr NativeFieldInfoPtr_basePayment;

			// Token: 0x0400A563 RID: 42339
			private static readonly IntPtr NativeFieldInfoPtr_satisfaction;

			// Token: 0x0400A564 RID: 42340
			private static readonly IntPtr NativeFieldInfoPtr__paymentLerpTime_5__2;

			// Token: 0x0400A565 RID: 42341
			private static readonly IntPtr NativeFieldInfoPtr__satisfactionLerpTime_5__3;

			// Token: 0x0400A566 RID: 42342
			private static readonly IntPtr NativeFieldInfoPtr__endDelta_5__4;

			// Token: 0x0400A567 RID: 42343
			private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__5;

			// Token: 0x0400A568 RID: 42344
			private static readonly IntPtr NativeFieldInfoPtr__i_5__6;

			// Token: 0x0400A569 RID: 42345
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A56A RID: 42346
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A56B RID: 42347
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A56C RID: 42348
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A56D RID: 42349
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A56E RID: 42350
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
