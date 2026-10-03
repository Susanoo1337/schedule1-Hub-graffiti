using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.Doors;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.NPCs.CharacterClasses;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020002B2 RID: 690
	public class DarkMarketMainDoor : MonoBehaviour
	{
		// Token: 0x0600357A RID: 13690 RVA: 0x0012D680 File Offset: 0x0012B880
		// Note: this type is marked as 'beforefieldinit'.
		static DarkMarketMainDoor()
		{
			Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "DarkMarketMainDoor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr);
			DarkMarketMainDoor.NativeFieldInfoPtr__KnockingEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, "<KnockingEnabled>k__BackingField");
			DarkMarketMainDoor.NativeFieldInfoPtr_KnockSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, "KnockSound");
			DarkMarketMainDoor.NativeFieldInfoPtr_InteractableObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, "InteractableObject");
			DarkMarketMainDoor.NativeFieldInfoPtr_Peephole = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, "Peephole");
			DarkMarketMainDoor.NativeFieldInfoPtr_Igor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, "Igor");
			DarkMarketMainDoor.NativeFieldInfoPtr_FailDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, "FailDialogue");
			DarkMarketMainDoor.NativeFieldInfoPtr_SuccessDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, "SuccessDialogue");
			DarkMarketMainDoor.NativeFieldInfoPtr_SuccessDialogueNotOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, "SuccessDialogueNotOpen");
			DarkMarketMainDoor.NativeFieldInfoPtr_knockRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, "knockRoutine");
			DarkMarketMainDoor.NativeMethodInfoPtr_get_KnockingEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, 100670085);
			DarkMarketMainDoor.NativeMethodInfoPtr_set_KnockingEnabled_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, 100670086);
			DarkMarketMainDoor.NativeMethodInfoPtr_SetKnockingEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, 100670087);
			DarkMarketMainDoor.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, 100670088);
			DarkMarketMainDoor.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, 100670089);
			DarkMarketMainDoor.NativeMethodInfoPtr_Knocked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, 100670090);
			DarkMarketMainDoor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, 100670091);
			DarkMarketMainDoor.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, 100670092);
			DarkMarketMainDoor.NativeMethodInfoPtr__Knocked_b__15_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, 100670093);
		}

		// Token: 0x170010EB RID: 4331
		// (get) Token: 0x0600357B RID: 13691 RVA: 0x0012D818 File Offset: 0x0012BA18
		// (set) Token: 0x0600357C RID: 13692 RVA: 0x0012D854 File Offset: 0x0012BA54
		public unsafe bool KnockingEnabled
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.NativeMethodInfoPtr_get_KnockingEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.NativeMethodInfoPtr_set_KnockingEnabled_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600357D RID: 13693 RVA: 0x0012D894 File Offset: 0x0012BA94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141581, XrefRangeEnd = 141583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetKnockingEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.NativeMethodInfoPtr_SetKnockingEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600357E RID: 13694 RVA: 0x0012D8D4 File Offset: 0x0012BAD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141583, XrefRangeEnd = 141591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600357F RID: 13695 RVA: 0x0012D908 File Offset: 0x0012BB08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141591, XrefRangeEnd = 141598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003580 RID: 13696 RVA: 0x0012D93C File Offset: 0x0012BB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Knocked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.NativeMethodInfoPtr_Knocked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003581 RID: 13697 RVA: 0x0012D970 File Offset: 0x0012BB70
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 141599, RefRangeEnd = 141615, XrefRangeStart = 141598, XrefRangeEnd = 141599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DarkMarketMainDoor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003582 RID: 13698 RVA: 0x0012D9AC File Offset: 0x0012BBAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141615, XrefRangeEnd = 141620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003583 RID: 13699 RVA: 0x0012D9EC File Offset: 0x0012BBEC
		[CallerCount(0)]
		public unsafe bool _Knocked_b__15_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.NativeMethodInfoPtr__Knocked_b__15_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003584 RID: 13700 RVA: 0x0001B25A File Offset: 0x0001945A
		public DarkMarketMainDoor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170010E2 RID: 4322
		// (get) Token: 0x06003585 RID: 13701 RVA: 0x0012DA28 File Offset: 0x0012BC28
		// (set) Token: 0x06003586 RID: 13702 RVA: 0x0001B263 File Offset: 0x00019463
		public unsafe bool _KnockingEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr__KnockingEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr__KnockingEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x170010E3 RID: 4323
		// (get) Token: 0x06003587 RID: 13703 RVA: 0x0012DA50 File Offset: 0x0012BC50
		// (set) Token: 0x06003588 RID: 13704 RVA: 0x0001B27E File Offset: 0x0001947E
		public unsafe AudioSource KnockSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_KnockSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_KnockSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010E4 RID: 4324
		// (get) Token: 0x06003589 RID: 13705 RVA: 0x0012DA80 File Offset: 0x0012BC80
		// (set) Token: 0x0600358A RID: 13706 RVA: 0x0001B29D File Offset: 0x0001949D
		public unsafe InteractableObject InteractableObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_InteractableObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_InteractableObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010E5 RID: 4325
		// (get) Token: 0x0600358B RID: 13707 RVA: 0x0012DAB0 File Offset: 0x0012BCB0
		// (set) Token: 0x0600358C RID: 13708 RVA: 0x0001B2BC File Offset: 0x000194BC
		public unsafe Peephole Peephole
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_Peephole);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Peephole>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_Peephole), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010E6 RID: 4326
		// (get) Token: 0x0600358D RID: 13709 RVA: 0x0012DAE0 File Offset: 0x0012BCE0
		// (set) Token: 0x0600358E RID: 13710 RVA: 0x0001B2DB File Offset: 0x000194DB
		public unsafe Igor Igor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_Igor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Igor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_Igor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010E7 RID: 4327
		// (get) Token: 0x0600358F RID: 13711 RVA: 0x0012DB10 File Offset: 0x0012BD10
		// (set) Token: 0x06003590 RID: 13712 RVA: 0x0001B2FA File Offset: 0x000194FA
		public unsafe DialogueContainer FailDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_FailDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_FailDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010E8 RID: 4328
		// (get) Token: 0x06003591 RID: 13713 RVA: 0x0012DB40 File Offset: 0x0012BD40
		// (set) Token: 0x06003592 RID: 13714 RVA: 0x0001B319 File Offset: 0x00019519
		public unsafe DialogueContainer SuccessDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_SuccessDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_SuccessDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010E9 RID: 4329
		// (get) Token: 0x06003593 RID: 13715 RVA: 0x0012DB70 File Offset: 0x0012BD70
		// (set) Token: 0x06003594 RID: 13716 RVA: 0x0001B338 File Offset: 0x00019538
		public unsafe DialogueContainer SuccessDialogueNotOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_SuccessDialogueNotOpen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_SuccessDialogueNotOpen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010EA RID: 4330
		// (get) Token: 0x06003595 RID: 13717 RVA: 0x0012DBA0 File Offset: 0x0012BDA0
		// (set) Token: 0x06003596 RID: 13718 RVA: 0x0001B357 File Offset: 0x00019557
		public unsafe Coroutine knockRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_knockRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_knockRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040023D3 RID: 9171
		private static readonly IntPtr NativeFieldInfoPtr__KnockingEnabled_k__BackingField;

		// Token: 0x040023D4 RID: 9172
		private static readonly IntPtr NativeFieldInfoPtr_KnockSound;

		// Token: 0x040023D5 RID: 9173
		private static readonly IntPtr NativeFieldInfoPtr_InteractableObject;

		// Token: 0x040023D6 RID: 9174
		private static readonly IntPtr NativeFieldInfoPtr_Peephole;

		// Token: 0x040023D7 RID: 9175
		private static readonly IntPtr NativeFieldInfoPtr_Igor;

		// Token: 0x040023D8 RID: 9176
		private static readonly IntPtr NativeFieldInfoPtr_FailDialogue;

		// Token: 0x040023D9 RID: 9177
		private static readonly IntPtr NativeFieldInfoPtr_SuccessDialogue;

		// Token: 0x040023DA RID: 9178
		private static readonly IntPtr NativeFieldInfoPtr_SuccessDialogueNotOpen;

		// Token: 0x040023DB RID: 9179
		private static readonly IntPtr NativeFieldInfoPtr_knockRoutine;

		// Token: 0x040023DC RID: 9180
		private static readonly IntPtr NativeMethodInfoPtr_get_KnockingEnabled_Public_get_Boolean_0;

		// Token: 0x040023DD RID: 9181
		private static readonly IntPtr NativeMethodInfoPtr_set_KnockingEnabled_Private_set_Void_Boolean_0;

		// Token: 0x040023DE RID: 9182
		private static readonly IntPtr NativeMethodInfoPtr_SetKnockingEnabled_Public_Void_Boolean_0;

		// Token: 0x040023DF RID: 9183
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x040023E0 RID: 9184
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x040023E1 RID: 9185
		private static readonly IntPtr NativeMethodInfoPtr_Knocked_Private_Void_0;

		// Token: 0x040023E2 RID: 9186
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040023E3 RID: 9187
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x040023E4 RID: 9188
		private static readonly IntPtr NativeMethodInfoPtr__Knocked_b__15_1_Private_Boolean_0;

		// Token: 0x02000A0F RID: 2575
		[ObfuscatedName("ScheduleOne.Map.DarkMarketMainDoor+<<Knocked>g__Knock|15_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600DE05 RID: 56837 RVA: 0x0036C5D4 File Offset: 0x0036A7D4
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique()
			{
				Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, "<<Knocked>g__Knock|15_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr);
				DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr, "<>1__state");
				DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr, "<>2__current");
				DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr, "<>4__this");
				DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr__shouldUnlock_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr, "<shouldUnlock>5__2");
				DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr, 100670094);
				DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr, 100670095);
				DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr, 100670096);
				DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr, 100670097);
				DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr, 100670098);
				DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr, 100670099);
			}

			// Token: 0x0600DE06 RID: 56838 RVA: 0x0036C6C8 File Offset: 0x0036A8C8
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE07 RID: 56839 RVA: 0x0036C710 File Offset: 0x0036A910
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE08 RID: 56840 RVA: 0x0036C744 File Offset: 0x0036A944
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141484, XrefRangeEnd = 141576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700439F RID: 17311
			// (get) Token: 0x0600DE09 RID: 56841 RVA: 0x0036C780 File Offset: 0x0036A980
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DE0A RID: 56842 RVA: 0x0036C7C0 File Offset: 0x0036A9C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141576, XrefRangeEnd = 141581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170043A0 RID: 17312
			// (get) Token: 0x0600DE0B RID: 56843 RVA: 0x0036C7F4 File Offset: 0x0036A9F4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DE0C RID: 56844 RVA: 0x00068872 File Offset: 0x00066A72
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700439B RID: 17307
			// (get) Token: 0x0600DE0D RID: 56845 RVA: 0x0036C834 File Offset: 0x0036AA34
			// (set) Token: 0x0600DE0E RID: 56846 RVA: 0x0006887B File Offset: 0x00066A7B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700439C RID: 17308
			// (get) Token: 0x0600DE0F RID: 56847 RVA: 0x0036C85C File Offset: 0x0036AA5C
			// (set) Token: 0x0600DE10 RID: 56848 RVA: 0x00068896 File Offset: 0x00066A96
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700439D RID: 17309
			// (get) Token: 0x0600DE11 RID: 56849 RVA: 0x0036C88C File Offset: 0x0036AA8C
			// (set) Token: 0x0600DE12 RID: 56850 RVA: 0x000688B5 File Offset: 0x00066AB5
			public unsafe DarkMarketMainDoor __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DarkMarketMainDoor>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700439E RID: 17310
			// (get) Token: 0x0600DE13 RID: 56851 RVA: 0x0036C8BC File Offset: 0x0036AABC
			// (set) Token: 0x0600DE14 RID: 56852 RVA: 0x000688D4 File Offset: 0x00066AD4
			public unsafe bool _shouldUnlock_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr__shouldUnlock_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr__shouldUnlock_5__2)) = value;
				}
			}

			// Token: 0x04009749 RID: 38729
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400974A RID: 38730
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400974B RID: 38731
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400974C RID: 38732
			private static readonly IntPtr NativeFieldInfoPtr__shouldUnlock_5__2;

			// Token: 0x0400974D RID: 38733
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400974E RID: 38734
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400974F RID: 38735
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009750 RID: 38736
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009751 RID: 38737
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009752 RID: 38738
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
