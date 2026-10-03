using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020007E2 RID: 2018
	public class BotanistUIElement : WorldspaceUIElement
	{
		// Token: 0x0600C576 RID: 50550 RVA: 0x003213BC File Offset: 0x0031F5BC
		// Note: this type is marked as 'beforefieldinit'.
		static BotanistUIElement()
		{
			Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "BotanistUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr);
			BotanistUIElement.NativeFieldInfoPtr_SupplyIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr, "SupplyIcon");
			BotanistUIElement.NativeFieldInfoPtr_NoSupply = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr, "NoSupply");
			BotanistUIElement.NativeFieldInfoPtr_SupplyLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr, "SupplyLabel");
			BotanistUIElement.NativeFieldInfoPtr_PotRects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr, "PotRects");
			BotanistUIElement.NativeFieldInfoPtr__AssignedBotanist_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr, "<AssignedBotanist>k__BackingField");
			BotanistUIElement.NativeMethodInfoPtr_get_AssignedBotanist_Public_get_Botanist_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr, 100688888);
			BotanistUIElement.NativeMethodInfoPtr_set_AssignedBotanist_Protected_set_Void_Botanist_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr, 100688889);
			BotanistUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Botanist_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr, 100688890);
			BotanistUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr, 100688891);
			BotanistUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr, 100688892);
		}

		// Token: 0x17003BF7 RID: 15351
		// (get) Token: 0x0600C577 RID: 50551 RVA: 0x003214B4 File Offset: 0x0031F6B4
		// (set) Token: 0x0600C578 RID: 50552 RVA: 0x003214F4 File Offset: 0x0031F6F4
		public unsafe Botanist AssignedBotanist
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22015, RefRangeEnd = 22016, XrefRangeStart = 22015, XrefRangeEnd = 22016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistUIElement.NativeMethodInfoPtr_get_AssignedBotanist_Public_get_Botanist_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Botanist>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistUIElement.NativeMethodInfoPtr_set_AssignedBotanist_Protected_set_Void_Botanist_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600C579 RID: 50553 RVA: 0x00321538 File Offset: 0x0031F738
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327094, RefRangeEnd = 327095, XrefRangeStart = 327083, XrefRangeEnd = 327094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Botanist bot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(bot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Botanist_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C57A RID: 50554 RVA: 0x0032157C File Offset: 0x0031F77C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327095, XrefRangeEnd = 327131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BotanistUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C57B RID: 50555 RVA: 0x003215B8 File Offset: 0x0031F7B8
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BotanistUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C57C RID: 50556 RVA: 0x0005D3B2 File Offset: 0x0005B5B2
		public BotanistUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003BF2 RID: 15346
		// (get) Token: 0x0600C57D RID: 50557 RVA: 0x003215F4 File Offset: 0x0031F7F4
		// (set) Token: 0x0600C57E RID: 50558 RVA: 0x0005D3BB File Offset: 0x0005B5BB
		public unsafe Image SupplyIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistUIElement.NativeFieldInfoPtr_SupplyIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistUIElement.NativeFieldInfoPtr_SupplyIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BF3 RID: 15347
		// (get) Token: 0x0600C57F RID: 50559 RVA: 0x00321624 File Offset: 0x0031F824
		// (set) Token: 0x0600C580 RID: 50560 RVA: 0x0005D3DA File Offset: 0x0005B5DA
		public unsafe GameObject NoSupply
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistUIElement.NativeFieldInfoPtr_NoSupply);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistUIElement.NativeFieldInfoPtr_NoSupply), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BF4 RID: 15348
		// (get) Token: 0x0600C581 RID: 50561 RVA: 0x00321654 File Offset: 0x0031F854
		// (set) Token: 0x0600C582 RID: 50562 RVA: 0x0005D3F9 File Offset: 0x0005B5F9
		public unsafe TextMeshProUGUI SupplyLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistUIElement.NativeFieldInfoPtr_SupplyLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistUIElement.NativeFieldInfoPtr_SupplyLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BF5 RID: 15349
		// (get) Token: 0x0600C583 RID: 50563 RVA: 0x00321684 File Offset: 0x0031F884
		// (set) Token: 0x0600C584 RID: 50564 RVA: 0x0005D418 File Offset: 0x0005B618
		public unsafe Il2CppReferenceArray<RectTransform> PotRects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistUIElement.NativeFieldInfoPtr_PotRects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistUIElement.NativeFieldInfoPtr_PotRects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BF6 RID: 15350
		// (get) Token: 0x0600C585 RID: 50565 RVA: 0x003216B4 File Offset: 0x0031F8B4
		// (set) Token: 0x0600C586 RID: 50566 RVA: 0x0005D437 File Offset: 0x0005B637
		public unsafe Botanist _AssignedBotanist_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistUIElement.NativeFieldInfoPtr__AssignedBotanist_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Botanist>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistUIElement.NativeFieldInfoPtr__AssignedBotanist_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040086C0 RID: 34496
		private static readonly IntPtr NativeFieldInfoPtr_SupplyIcon;

		// Token: 0x040086C1 RID: 34497
		private static readonly IntPtr NativeFieldInfoPtr_NoSupply;

		// Token: 0x040086C2 RID: 34498
		private static readonly IntPtr NativeFieldInfoPtr_SupplyLabel;

		// Token: 0x040086C3 RID: 34499
		private static readonly IntPtr NativeFieldInfoPtr_PotRects;

		// Token: 0x040086C4 RID: 34500
		private static readonly IntPtr NativeFieldInfoPtr__AssignedBotanist_k__BackingField;

		// Token: 0x040086C5 RID: 34501
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedBotanist_Public_get_Botanist_0;

		// Token: 0x040086C6 RID: 34502
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedBotanist_Protected_set_Void_Botanist_0;

		// Token: 0x040086C7 RID: 34503
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Botanist_0;

		// Token: 0x040086C8 RID: 34504
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x040086C9 RID: 34505
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
