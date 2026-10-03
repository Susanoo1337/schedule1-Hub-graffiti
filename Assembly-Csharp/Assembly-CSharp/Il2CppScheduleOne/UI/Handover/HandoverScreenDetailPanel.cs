using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Handover
{
	// Token: 0x02000814 RID: 2068
	public class HandoverScreenDetailPanel : MonoBehaviour
	{
		// Token: 0x0600C8D9 RID: 51417 RVA: 0x0032BC20 File Offset: 0x00329E20
		// Note: this type is marked as 'beforefieldinit'.
		static HandoverScreenDetailPanel()
		{
			Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Handover", "HandoverScreenDetailPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr);
			HandoverScreenDetailPanel.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, "Container");
			HandoverScreenDetailPanel.NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, "NameLabel");
			HandoverScreenDetailPanel.NativeFieldInfoPtr_RelationshipContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, "RelationshipContainer");
			HandoverScreenDetailPanel.NativeFieldInfoPtr_RelationshipScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, "RelationshipScrollbar");
			HandoverScreenDetailPanel.NativeFieldInfoPtr_AddictionContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, "AddictionContainer");
			HandoverScreenDetailPanel.NativeFieldInfoPtr_AdditionScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, "AdditionScrollbar");
			HandoverScreenDetailPanel.NativeFieldInfoPtr_StandardsStar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, "StandardsStar");
			HandoverScreenDetailPanel.NativeFieldInfoPtr_StandardsLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, "StandardsLabel");
			HandoverScreenDetailPanel.NativeFieldInfoPtr_FavouriteDrugLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, "FavouriteDrugLabel");
			HandoverScreenDetailPanel.NativeFieldInfoPtr_EffectsLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, "EffectsLabel");
			HandoverScreenDetailPanel.NativeMethodInfoPtr_Open_Public_Void_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, 100689229);
			HandoverScreenDetailPanel.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, 100689230);
			HandoverScreenDetailPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, 100689231);
		}

		// Token: 0x0600C8DA RID: 51418 RVA: 0x0032BD54 File Offset: 0x00329F54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 331025, RefRangeEnd = 331026, XrefRangeStart = 330966, XrefRangeEnd = 331025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreenDetailPanel.NativeMethodInfoPtr_Open_Public_Void_Customer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C8DB RID: 51419 RVA: 0x0032BD98 File Offset: 0x00329F98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 187975, RefRangeEnd = 187977, XrefRangeStart = 187975, XrefRangeEnd = 187977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreenDetailPanel.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C8DC RID: 51420 RVA: 0x0032BDCC File Offset: 0x00329FCC
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HandoverScreenDetailPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreenDetailPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C8DD RID: 51421 RVA: 0x0005F0DB File Offset: 0x0005D2DB
		public HandoverScreenDetailPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003CF8 RID: 15608
		// (get) Token: 0x0600C8DE RID: 51422 RVA: 0x0032BE08 File Offset: 0x0032A008
		// (set) Token: 0x0600C8DF RID: 51423 RVA: 0x0005F0E4 File Offset: 0x0005D2E4
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CF9 RID: 15609
		// (get) Token: 0x0600C8E0 RID: 51424 RVA: 0x0032BE38 File Offset: 0x0032A038
		// (set) Token: 0x0600C8E1 RID: 51425 RVA: 0x0005F103 File Offset: 0x0005D303
		public unsafe TextMeshProUGUI NameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_NameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CFA RID: 15610
		// (get) Token: 0x0600C8E2 RID: 51426 RVA: 0x0032BE68 File Offset: 0x0032A068
		// (set) Token: 0x0600C8E3 RID: 51427 RVA: 0x0005F122 File Offset: 0x0005D322
		public unsafe RectTransform RelationshipContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_RelationshipContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_RelationshipContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CFB RID: 15611
		// (get) Token: 0x0600C8E4 RID: 51428 RVA: 0x0032BE98 File Offset: 0x0032A098
		// (set) Token: 0x0600C8E5 RID: 51429 RVA: 0x0005F141 File Offset: 0x0005D341
		public unsafe Scrollbar RelationshipScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_RelationshipScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_RelationshipScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CFC RID: 15612
		// (get) Token: 0x0600C8E6 RID: 51430 RVA: 0x0032BEC8 File Offset: 0x0032A0C8
		// (set) Token: 0x0600C8E7 RID: 51431 RVA: 0x0005F160 File Offset: 0x0005D360
		public unsafe RectTransform AddictionContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_AddictionContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_AddictionContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CFD RID: 15613
		// (get) Token: 0x0600C8E8 RID: 51432 RVA: 0x0032BEF8 File Offset: 0x0032A0F8
		// (set) Token: 0x0600C8E9 RID: 51433 RVA: 0x0005F17F File Offset: 0x0005D37F
		public unsafe Scrollbar AdditionScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_AdditionScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_AdditionScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CFE RID: 15614
		// (get) Token: 0x0600C8EA RID: 51434 RVA: 0x0032BF28 File Offset: 0x0032A128
		// (set) Token: 0x0600C8EB RID: 51435 RVA: 0x0005F19E File Offset: 0x0005D39E
		public unsafe Image StandardsStar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_StandardsStar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_StandardsStar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CFF RID: 15615
		// (get) Token: 0x0600C8EC RID: 51436 RVA: 0x0032BF58 File Offset: 0x0032A158
		// (set) Token: 0x0600C8ED RID: 51437 RVA: 0x0005F1BD File Offset: 0x0005D3BD
		public unsafe TextMeshProUGUI StandardsLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_StandardsLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_StandardsLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D00 RID: 15616
		// (get) Token: 0x0600C8EE RID: 51438 RVA: 0x0032BF88 File Offset: 0x0032A188
		// (set) Token: 0x0600C8EF RID: 51439 RVA: 0x0005F1DC File Offset: 0x0005D3DC
		public unsafe TextMeshProUGUI FavouriteDrugLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_FavouriteDrugLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_FavouriteDrugLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D01 RID: 15617
		// (get) Token: 0x0600C8F0 RID: 51440 RVA: 0x0032BFB8 File Offset: 0x0032A1B8
		// (set) Token: 0x0600C8F1 RID: 51441 RVA: 0x0005F1FB File Offset: 0x0005D3FB
		public unsafe TextMeshProUGUI EffectsLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_EffectsLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_EffectsLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040088DD RID: 35037
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040088DE RID: 35038
		private static readonly IntPtr NativeFieldInfoPtr_NameLabel;

		// Token: 0x040088DF RID: 35039
		private static readonly IntPtr NativeFieldInfoPtr_RelationshipContainer;

		// Token: 0x040088E0 RID: 35040
		private static readonly IntPtr NativeFieldInfoPtr_RelationshipScrollbar;

		// Token: 0x040088E1 RID: 35041
		private static readonly IntPtr NativeFieldInfoPtr_AddictionContainer;

		// Token: 0x040088E2 RID: 35042
		private static readonly IntPtr NativeFieldInfoPtr_AdditionScrollbar;

		// Token: 0x040088E3 RID: 35043
		private static readonly IntPtr NativeFieldInfoPtr_StandardsStar;

		// Token: 0x040088E4 RID: 35044
		private static readonly IntPtr NativeFieldInfoPtr_StandardsLabel;

		// Token: 0x040088E5 RID: 35045
		private static readonly IntPtr NativeFieldInfoPtr_FavouriteDrugLabel;

		// Token: 0x040088E6 RID: 35046
		private static readonly IntPtr NativeFieldInfoPtr_EffectsLabel;

		// Token: 0x040088E7 RID: 35047
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_Customer_0;

		// Token: 0x040088E8 RID: 35048
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x040088E9 RID: 35049
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
