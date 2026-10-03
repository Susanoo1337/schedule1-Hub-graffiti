using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.NPCs;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.ContactsApp
{
	// Token: 0x020007BF RID: 1983
	public class ContactsDetailPanel : MonoBehaviour
	{
		// Token: 0x0600C27A RID: 49786 RVA: 0x003182CC File Offset: 0x003164CC
		// Note: this type is marked as 'beforefieldinit'.
		static ContactsDetailPanel()
		{
			Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.ContactsApp", "ContactsDetailPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr);
			ContactsDetailPanel.NativeFieldInfoPtr__SelectedNPC_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "<SelectedNPC>k__BackingField");
			ContactsDetailPanel.NativeFieldInfoPtr_DependenceColor_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "DependenceColor_Min");
			ContactsDetailPanel.NativeFieldInfoPtr_DependenceColor_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "DependenceColor_Max");
			ContactsDetailPanel.NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "NameLabel");
			ContactsDetailPanel.NativeFieldInfoPtr_TypeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "TypeLabel");
			ContactsDetailPanel.NativeFieldInfoPtr_UnlockHintLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "UnlockHintLabel");
			ContactsDetailPanel.NativeFieldInfoPtr_RelationshipContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "RelationshipContainer");
			ContactsDetailPanel.NativeFieldInfoPtr_RelationshipScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "RelationshipScrollbar");
			ContactsDetailPanel.NativeFieldInfoPtr_RelationshipLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "RelationshipLabel");
			ContactsDetailPanel.NativeFieldInfoPtr_AddictionContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "AddictionContainer");
			ContactsDetailPanel.NativeFieldInfoPtr_AddictionScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "AddictionScrollbar");
			ContactsDetailPanel.NativeFieldInfoPtr_AddictionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "AddictionLabel");
			ContactsDetailPanel.NativeFieldInfoPtr_DebtContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "DebtContainer");
			ContactsDetailPanel.NativeFieldInfoPtr_DebtLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "DebtLabel");
			ContactsDetailPanel.NativeFieldInfoPtr_PropertiesContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "PropertiesContainer");
			ContactsDetailPanel.NativeFieldInfoPtr_PropertiesLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "PropertiesLabel");
			ContactsDetailPanel.NativeFieldInfoPtr_MostPurchasedProductsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "MostPurchasedProductsContainer");
			ContactsDetailPanel.NativeFieldInfoPtr_MostPurchasedProductsLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "MostPurchasedProductsLabel");
			ContactsDetailPanel.NativeFieldInfoPtr_TotalSpentContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "TotalSpentContainer");
			ContactsDetailPanel.NativeFieldInfoPtr_TotalSpentLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "TotalSpentLabel");
			ContactsDetailPanel.NativeFieldInfoPtr_ShowOnMapButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "ShowOnMapButton");
			ContactsDetailPanel.NativeFieldInfoPtr_StandardsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "StandardsContainer");
			ContactsDetailPanel.NativeFieldInfoPtr_StandardsStar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "StandardsStar");
			ContactsDetailPanel.NativeFieldInfoPtr_StandardsLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "StandardsLabel");
			ContactsDetailPanel.NativeFieldInfoPtr__generalColorFont = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "_generalColorFont");
			ContactsDetailPanel.NativeFieldInfoPtr__proudctColorFont = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "_proudctColorFont");
			ContactsDetailPanel.NativeFieldInfoPtr_poi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "poi");
			ContactsDetailPanel.NativeFieldInfoPtr_MAX_PURCHASED_PRODUCTS_DISPLAYED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "MAX_PURCHASED_PRODUCTS_DISPLAYED");
			ContactsDetailPanel.NativeMethodInfoPtr_get_SelectedNPC_Public_get_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, 100688592);
			ContactsDetailPanel.NativeMethodInfoPtr_set_SelectedNPC_Protected_set_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, 100688593);
			ContactsDetailPanel.NativeMethodInfoPtr_Open_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, 100688594);
			ContactsDetailPanel.NativeMethodInfoPtr_ShowOnMap_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, 100688595);
			ContactsDetailPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, 100688596);
		}

		// Token: 0x17003B1A RID: 15130
		// (get) Token: 0x0600C27B RID: 49787 RVA: 0x00318590 File Offset: 0x00316790
		// (set) Token: 0x0600C27C RID: 49788 RVA: 0x003185D0 File Offset: 0x003167D0
		public unsafe NPC SelectedNPC
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsDetailPanel.NativeMethodInfoPtr_get_SelectedNPC_Public_get_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsDetailPanel.NativeMethodInfoPtr_set_SelectedNPC_Protected_set_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600C27D RID: 49789 RVA: 0x00318614 File Offset: 0x00316814
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 322435, RefRangeEnd = 322437, XrefRangeStart = 322320, XrefRangeEnd = 322435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsDetailPanel.NativeMethodInfoPtr_Open_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C27E RID: 49790 RVA: 0x00318658 File Offset: 0x00316858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322437, XrefRangeEnd = 322470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowOnMap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsDetailPanel.NativeMethodInfoPtr_ShowOnMap_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C27F RID: 49791 RVA: 0x0031868C File Offset: 0x0031688C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContactsDetailPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsDetailPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C280 RID: 49792 RVA: 0x0005B7C3 File Offset: 0x000599C3
		public ContactsDetailPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003AFE RID: 15102
		// (get) Token: 0x0600C281 RID: 49793 RVA: 0x003186C8 File Offset: 0x003168C8
		// (set) Token: 0x0600C282 RID: 49794 RVA: 0x0005B7CC File Offset: 0x000599CC
		public unsafe NPC _SelectedNPC_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr__SelectedNPC_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr__SelectedNPC_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AFF RID: 15103
		// (get) Token: 0x0600C283 RID: 49795 RVA: 0x003186F8 File Offset: 0x003168F8
		// (set) Token: 0x0600C284 RID: 49796 RVA: 0x0005B7EB File Offset: 0x000599EB
		public unsafe Color DependenceColor_Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_DependenceColor_Min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_DependenceColor_Min)) = value;
			}
		}

		// Token: 0x17003B00 RID: 15104
		// (get) Token: 0x0600C285 RID: 49797 RVA: 0x00318720 File Offset: 0x00316920
		// (set) Token: 0x0600C286 RID: 49798 RVA: 0x0005B806 File Offset: 0x00059A06
		public unsafe Color DependenceColor_Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_DependenceColor_Max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_DependenceColor_Max)) = value;
			}
		}

		// Token: 0x17003B01 RID: 15105
		// (get) Token: 0x0600C287 RID: 49799 RVA: 0x00318748 File Offset: 0x00316948
		// (set) Token: 0x0600C288 RID: 49800 RVA: 0x0005B821 File Offset: 0x00059A21
		public unsafe Text NameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_NameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B02 RID: 15106
		// (get) Token: 0x0600C289 RID: 49801 RVA: 0x00318778 File Offset: 0x00316978
		// (set) Token: 0x0600C28A RID: 49802 RVA: 0x0005B840 File Offset: 0x00059A40
		public unsafe Text TypeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_TypeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_TypeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B03 RID: 15107
		// (get) Token: 0x0600C28B RID: 49803 RVA: 0x003187A8 File Offset: 0x003169A8
		// (set) Token: 0x0600C28C RID: 49804 RVA: 0x0005B85F File Offset: 0x00059A5F
		public unsafe Text UnlockHintLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_UnlockHintLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_UnlockHintLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B04 RID: 15108
		// (get) Token: 0x0600C28D RID: 49805 RVA: 0x003187D8 File Offset: 0x003169D8
		// (set) Token: 0x0600C28E RID: 49806 RVA: 0x0005B87E File Offset: 0x00059A7E
		public unsafe RectTransform RelationshipContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_RelationshipContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_RelationshipContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B05 RID: 15109
		// (get) Token: 0x0600C28F RID: 49807 RVA: 0x00318808 File Offset: 0x00316A08
		// (set) Token: 0x0600C290 RID: 49808 RVA: 0x0005B89D File Offset: 0x00059A9D
		public unsafe Scrollbar RelationshipScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_RelationshipScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_RelationshipScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B06 RID: 15110
		// (get) Token: 0x0600C291 RID: 49809 RVA: 0x00318838 File Offset: 0x00316A38
		// (set) Token: 0x0600C292 RID: 49810 RVA: 0x0005B8BC File Offset: 0x00059ABC
		public unsafe Text RelationshipLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_RelationshipLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_RelationshipLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B07 RID: 15111
		// (get) Token: 0x0600C293 RID: 49811 RVA: 0x00318868 File Offset: 0x00316A68
		// (set) Token: 0x0600C294 RID: 49812 RVA: 0x0005B8DB File Offset: 0x00059ADB
		public unsafe RectTransform AddictionContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_AddictionContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_AddictionContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B08 RID: 15112
		// (get) Token: 0x0600C295 RID: 49813 RVA: 0x00318898 File Offset: 0x00316A98
		// (set) Token: 0x0600C296 RID: 49814 RVA: 0x0005B8FA File Offset: 0x00059AFA
		public unsafe Scrollbar AddictionScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_AddictionScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_AddictionScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B09 RID: 15113
		// (get) Token: 0x0600C297 RID: 49815 RVA: 0x003188C8 File Offset: 0x00316AC8
		// (set) Token: 0x0600C298 RID: 49816 RVA: 0x0005B919 File Offset: 0x00059B19
		public unsafe Text AddictionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_AddictionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_AddictionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B0A RID: 15114
		// (get) Token: 0x0600C299 RID: 49817 RVA: 0x003188F8 File Offset: 0x00316AF8
		// (set) Token: 0x0600C29A RID: 49818 RVA: 0x0005B938 File Offset: 0x00059B38
		public unsafe RectTransform DebtContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_DebtContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_DebtContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B0B RID: 15115
		// (get) Token: 0x0600C29B RID: 49819 RVA: 0x00318928 File Offset: 0x00316B28
		// (set) Token: 0x0600C29C RID: 49820 RVA: 0x0005B957 File Offset: 0x00059B57
		public unsafe Text DebtLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_DebtLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_DebtLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B0C RID: 15116
		// (get) Token: 0x0600C29D RID: 49821 RVA: 0x00318958 File Offset: 0x00316B58
		// (set) Token: 0x0600C29E RID: 49822 RVA: 0x0005B976 File Offset: 0x00059B76
		public unsafe RectTransform PropertiesContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_PropertiesContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_PropertiesContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B0D RID: 15117
		// (get) Token: 0x0600C29F RID: 49823 RVA: 0x00318988 File Offset: 0x00316B88
		// (set) Token: 0x0600C2A0 RID: 49824 RVA: 0x0005B995 File Offset: 0x00059B95
		public unsafe Text PropertiesLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_PropertiesLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_PropertiesLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B0E RID: 15118
		// (get) Token: 0x0600C2A1 RID: 49825 RVA: 0x003189B8 File Offset: 0x00316BB8
		// (set) Token: 0x0600C2A2 RID: 49826 RVA: 0x0005B9B4 File Offset: 0x00059BB4
		public unsafe RectTransform MostPurchasedProductsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_MostPurchasedProductsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_MostPurchasedProductsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B0F RID: 15119
		// (get) Token: 0x0600C2A3 RID: 49827 RVA: 0x003189E8 File Offset: 0x00316BE8
		// (set) Token: 0x0600C2A4 RID: 49828 RVA: 0x0005B9D3 File Offset: 0x00059BD3
		public unsafe Text MostPurchasedProductsLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_MostPurchasedProductsLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_MostPurchasedProductsLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B10 RID: 15120
		// (get) Token: 0x0600C2A5 RID: 49829 RVA: 0x00318A18 File Offset: 0x00316C18
		// (set) Token: 0x0600C2A6 RID: 49830 RVA: 0x0005B9F2 File Offset: 0x00059BF2
		public unsafe RectTransform TotalSpentContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_TotalSpentContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_TotalSpentContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B11 RID: 15121
		// (get) Token: 0x0600C2A7 RID: 49831 RVA: 0x00318A48 File Offset: 0x00316C48
		// (set) Token: 0x0600C2A8 RID: 49832 RVA: 0x0005BA11 File Offset: 0x00059C11
		public unsafe Text TotalSpentLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_TotalSpentLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_TotalSpentLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B12 RID: 15122
		// (get) Token: 0x0600C2A9 RID: 49833 RVA: 0x00318A78 File Offset: 0x00316C78
		// (set) Token: 0x0600C2AA RID: 49834 RVA: 0x0005BA30 File Offset: 0x00059C30
		public unsafe Button ShowOnMapButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_ShowOnMapButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_ShowOnMapButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B13 RID: 15123
		// (get) Token: 0x0600C2AB RID: 49835 RVA: 0x00318AA8 File Offset: 0x00316CA8
		// (set) Token: 0x0600C2AC RID: 49836 RVA: 0x0005BA4F File Offset: 0x00059C4F
		public unsafe RectTransform StandardsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_StandardsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_StandardsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B14 RID: 15124
		// (get) Token: 0x0600C2AD RID: 49837 RVA: 0x00318AD8 File Offset: 0x00316CD8
		// (set) Token: 0x0600C2AE RID: 49838 RVA: 0x0005BA6E File Offset: 0x00059C6E
		public unsafe Image StandardsStar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_StandardsStar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_StandardsStar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B15 RID: 15125
		// (get) Token: 0x0600C2AF RID: 49839 RVA: 0x00318B08 File Offset: 0x00316D08
		// (set) Token: 0x0600C2B0 RID: 49840 RVA: 0x0005BA8D File Offset: 0x00059C8D
		public unsafe Text StandardsLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_StandardsLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_StandardsLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B16 RID: 15126
		// (get) Token: 0x0600C2B1 RID: 49841 RVA: 0x00318B38 File Offset: 0x00316D38
		// (set) Token: 0x0600C2B2 RID: 49842 RVA: 0x0005BAAC File Offset: 0x00059CAC
		public unsafe ColorFont _generalColorFont
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr__generalColorFont);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorFont>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr__generalColorFont), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B17 RID: 15127
		// (get) Token: 0x0600C2B3 RID: 49843 RVA: 0x00318B68 File Offset: 0x00316D68
		// (set) Token: 0x0600C2B4 RID: 49844 RVA: 0x0005BACB File Offset: 0x00059CCB
		public unsafe ColorFont _proudctColorFont
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr__proudctColorFont);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorFont>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr__proudctColorFont), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B18 RID: 15128
		// (get) Token: 0x0600C2B5 RID: 49845 RVA: 0x00318B98 File Offset: 0x00316D98
		// (set) Token: 0x0600C2B6 RID: 49846 RVA: 0x0005BAEA File Offset: 0x00059CEA
		public unsafe POI poi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_poi);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<POI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_poi), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B19 RID: 15129
		// (get) Token: 0x0600C2B7 RID: 49847 RVA: 0x00318BC8 File Offset: 0x00316DC8
		// (set) Token: 0x0600C2B8 RID: 49848 RVA: 0x0005BB09 File Offset: 0x00059D09
		public unsafe static int MAX_PURCHASED_PRODUCTS_DISPLAYED
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ContactsDetailPanel.NativeFieldInfoPtr_MAX_PURCHASED_PRODUCTS_DISPLAYED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ContactsDetailPanel.NativeFieldInfoPtr_MAX_PURCHASED_PRODUCTS_DISPLAYED, (void*)(&value));
			}
		}

		// Token: 0x040084ED RID: 34029
		private static readonly IntPtr NativeFieldInfoPtr__SelectedNPC_k__BackingField;

		// Token: 0x040084EE RID: 34030
		private static readonly IntPtr NativeFieldInfoPtr_DependenceColor_Min;

		// Token: 0x040084EF RID: 34031
		private static readonly IntPtr NativeFieldInfoPtr_DependenceColor_Max;

		// Token: 0x040084F0 RID: 34032
		private static readonly IntPtr NativeFieldInfoPtr_NameLabel;

		// Token: 0x040084F1 RID: 34033
		private static readonly IntPtr NativeFieldInfoPtr_TypeLabel;

		// Token: 0x040084F2 RID: 34034
		private static readonly IntPtr NativeFieldInfoPtr_UnlockHintLabel;

		// Token: 0x040084F3 RID: 34035
		private static readonly IntPtr NativeFieldInfoPtr_RelationshipContainer;

		// Token: 0x040084F4 RID: 34036
		private static readonly IntPtr NativeFieldInfoPtr_RelationshipScrollbar;

		// Token: 0x040084F5 RID: 34037
		private static readonly IntPtr NativeFieldInfoPtr_RelationshipLabel;

		// Token: 0x040084F6 RID: 34038
		private static readonly IntPtr NativeFieldInfoPtr_AddictionContainer;

		// Token: 0x040084F7 RID: 34039
		private static readonly IntPtr NativeFieldInfoPtr_AddictionScrollbar;

		// Token: 0x040084F8 RID: 34040
		private static readonly IntPtr NativeFieldInfoPtr_AddictionLabel;

		// Token: 0x040084F9 RID: 34041
		private static readonly IntPtr NativeFieldInfoPtr_DebtContainer;

		// Token: 0x040084FA RID: 34042
		private static readonly IntPtr NativeFieldInfoPtr_DebtLabel;

		// Token: 0x040084FB RID: 34043
		private static readonly IntPtr NativeFieldInfoPtr_PropertiesContainer;

		// Token: 0x040084FC RID: 34044
		private static readonly IntPtr NativeFieldInfoPtr_PropertiesLabel;

		// Token: 0x040084FD RID: 34045
		private static readonly IntPtr NativeFieldInfoPtr_MostPurchasedProductsContainer;

		// Token: 0x040084FE RID: 34046
		private static readonly IntPtr NativeFieldInfoPtr_MostPurchasedProductsLabel;

		// Token: 0x040084FF RID: 34047
		private static readonly IntPtr NativeFieldInfoPtr_TotalSpentContainer;

		// Token: 0x04008500 RID: 34048
		private static readonly IntPtr NativeFieldInfoPtr_TotalSpentLabel;

		// Token: 0x04008501 RID: 34049
		private static readonly IntPtr NativeFieldInfoPtr_ShowOnMapButton;

		// Token: 0x04008502 RID: 34050
		private static readonly IntPtr NativeFieldInfoPtr_StandardsContainer;

		// Token: 0x04008503 RID: 34051
		private static readonly IntPtr NativeFieldInfoPtr_StandardsStar;

		// Token: 0x04008504 RID: 34052
		private static readonly IntPtr NativeFieldInfoPtr_StandardsLabel;

		// Token: 0x04008505 RID: 34053
		private static readonly IntPtr NativeFieldInfoPtr__generalColorFont;

		// Token: 0x04008506 RID: 34054
		private static readonly IntPtr NativeFieldInfoPtr__proudctColorFont;

		// Token: 0x04008507 RID: 34055
		private static readonly IntPtr NativeFieldInfoPtr_poi;

		// Token: 0x04008508 RID: 34056
		private static readonly IntPtr NativeFieldInfoPtr_MAX_PURCHASED_PRODUCTS_DISPLAYED;

		// Token: 0x04008509 RID: 34057
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedNPC_Public_get_NPC_0;

		// Token: 0x0400850A RID: 34058
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectedNPC_Protected_set_Void_NPC_0;

		// Token: 0x0400850B RID: 34059
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_NPC_0;

		// Token: 0x0400850C RID: 34060
		private static readonly IntPtr NativeMethodInfoPtr_ShowOnMap_Public_Void_0;

		// Token: 0x0400850D RID: 34061
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
