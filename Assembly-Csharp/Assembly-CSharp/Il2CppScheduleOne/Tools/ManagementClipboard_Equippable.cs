using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Misc;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.UI.Management;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004CB RID: 1227
	public class ManagementClipboard_Equippable : Equippable_Viewmodel
	{
		// Token: 0x06007095 RID: 28821 RVA: 0x001FDCB8 File Offset: 0x001FBEB8
		// Note: this type is marked as 'beforefieldinit'.
		static ManagementClipboard_Equippable()
		{
			Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "ManagementClipboard_Equippable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr);
			ManagementClipboard_Equippable.NativeFieldInfoPtr_Clipboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, "Clipboard");
			ManagementClipboard_Equippable.NativeFieldInfoPtr_LoweredPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, "LoweredPosition");
			ManagementClipboard_Equippable.NativeFieldInfoPtr_RaisedPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, "RaisedPosition");
			ManagementClipboard_Equippable.NativeFieldInfoPtr_Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, "Light");
			ManagementClipboard_Equippable.NativeFieldInfoPtr_SelectionInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, "SelectionInfo");
			ManagementClipboard_Equippable.NativeFieldInfoPtr_OverrideText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, "OverrideText");
			ManagementClipboard_Equippable.NativeFieldInfoPtr__heatmapToggledOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, "_heatmapToggledOn");
			ManagementClipboard_Equippable.NativeFieldInfoPtr__propertyWithHeatmapShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, "_propertyWithHeatmapShown");
			ManagementClipboard_Equippable.NativeMethodInfoPtr_ResetHeatmapToggle_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, 100677861);
			ManagementClipboard_Equippable.NativeMethodInfoPtr_get__canToggleHeatmap_Private_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, 100677862);
			ManagementClipboard_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, 100677863);
			ManagementClipboard_Equippable.NativeMethodInfoPtr_ShowInputPrompts_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, 100677864);
			ManagementClipboard_Equippable.NativeMethodInfoPtr_HideInputPrompts_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, 100677865);
			ManagementClipboard_Equippable.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, 100677866);
			ManagementClipboard_Equippable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, 100677867);
			ManagementClipboard_Equippable.NativeMethodInfoPtr_GetSelectedConfigurables_Private_List_1_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, 100677868);
			ManagementClipboard_Equippable.NativeMethodInfoPtr_CanOpenClipboard_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, 100677869);
			ManagementClipboard_Equippable.NativeMethodInfoPtr_CanCloseClipboard_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, 100677870);
			ManagementClipboard_Equippable.NativeMethodInfoPtr_UpdateHeatmap_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, 100677871);
			ManagementClipboard_Equippable.NativeMethodInfoPtr_ClearPropertyWithHeatmapShown_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, 100677872);
			ManagementClipboard_Equippable.NativeMethodInfoPtr_FullscreenEnter_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, 100677873);
			ManagementClipboard_Equippable.NativeMethodInfoPtr_FullscreenExit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, 100677874);
			ManagementClipboard_Equippable.NativeMethodInfoPtr_OverrideClipboardText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, 100677875);
			ManagementClipboard_Equippable.NativeMethodInfoPtr_EndOverride_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, 100677876);
			ManagementClipboard_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, 100677877);
		}

		// Token: 0x06007096 RID: 28822 RVA: 0x001FDEDC File Offset: 0x001FC0DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 224670, RefRangeEnd = 224671, XrefRangeStart = 224668, XrefRangeEnd = 224670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ResetHeatmapToggle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard_Equippable.NativeMethodInfoPtr_ResetHeatmapToggle_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170022D8 RID: 8920
		// (get) Token: 0x06007097 RID: 28823 RVA: 0x001FDF0C File Offset: 0x001FC10C
		public unsafe static bool _canToggleHeatmap
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224671, XrefRangeEnd = 224672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard_Equippable.NativeMethodInfoPtr_get__canToggleHeatmap_Private_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06007098 RID: 28824 RVA: 0x001FDF3C File Offset: 0x001FC13C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224672, XrefRangeEnd = 224716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManagementClipboard_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007099 RID: 28825 RVA: 0x001FDF8C File Offset: 0x001FC18C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 224726, RefRangeEnd = 224728, XrefRangeStart = 224716, XrefRangeEnd = 224726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowInputPrompts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard_Equippable.NativeMethodInfoPtr_ShowInputPrompts_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600709A RID: 28826 RVA: 0x001FDFC0 File Offset: 0x001FC1C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 224739, RefRangeEnd = 224741, XrefRangeStart = 224728, XrefRangeEnd = 224739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideInputPrompts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard_Equippable.NativeMethodInfoPtr_HideInputPrompts_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600709B RID: 28827 RVA: 0x001FDFF4 File Offset: 0x001FC1F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224741, XrefRangeEnd = 224768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManagementClipboard_Equippable.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600709C RID: 28828 RVA: 0x001FE030 File Offset: 0x001FC230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224768, XrefRangeEnd = 224825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManagementClipboard_Equippable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600709D RID: 28829 RVA: 0x001FE06C File Offset: 0x001FC26C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 224852, RefRangeEnd = 224855, XrefRangeStart = 224825, XrefRangeEnd = 224852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<IConfigurable> GetSelectedConfigurables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard_Equippable.NativeMethodInfoPtr_GetSelectedConfigurables_Private_List_1_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<IConfigurable>>(intPtr3) : null;
		}

		// Token: 0x0600709E RID: 28830 RVA: 0x001FE0AC File Offset: 0x001FC2AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224855, XrefRangeEnd = 224873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanOpenClipboard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard_Equippable.NativeMethodInfoPtr_CanOpenClipboard_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600709F RID: 28831 RVA: 0x001FE0E8 File Offset: 0x001FC2E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224873, XrefRangeEnd = 224893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanCloseClipboard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard_Equippable.NativeMethodInfoPtr_CanCloseClipboard_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060070A0 RID: 28832 RVA: 0x001FE124 File Offset: 0x001FC324
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 224943, RefRangeEnd = 224944, XrefRangeStart = 224893, XrefRangeEnd = 224943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateHeatmap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard_Equippable.NativeMethodInfoPtr_UpdateHeatmap_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070A1 RID: 28833 RVA: 0x001FE158 File Offset: 0x001FC358
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 224956, RefRangeEnd = 224959, XrefRangeStart = 224944, XrefRangeEnd = 224956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearPropertyWithHeatmapShown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard_Equippable.NativeMethodInfoPtr_ClearPropertyWithHeatmapShown_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070A2 RID: 28834 RVA: 0x001FE18C File Offset: 0x001FC38C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224959, XrefRangeEnd = 224968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FullscreenEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard_Equippable.NativeMethodInfoPtr_FullscreenEnter_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070A3 RID: 28835 RVA: 0x001FE1C0 File Offset: 0x001FC3C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224968, XrefRangeEnd = 224982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FullscreenExit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard_Equippable.NativeMethodInfoPtr_FullscreenExit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070A4 RID: 28836 RVA: 0x001FE1F4 File Offset: 0x001FC3F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 224987, RefRangeEnd = 224989, XrefRangeStart = 224982, XrefRangeEnd = 224987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideClipboardText(string overriddenText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(overriddenText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard_Equippable.NativeMethodInfoPtr_OverrideClipboardText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070A5 RID: 28837 RVA: 0x001FE238 File Offset: 0x001FC438
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 224994, RefRangeEnd = 224996, XrefRangeStart = 224989, XrefRangeEnd = 224994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndOverride()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard_Equippable.NativeMethodInfoPtr_EndOverride_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070A6 RID: 28838 RVA: 0x001FE26C File Offset: 0x001FC46C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManagementClipboard_Equippable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070A7 RID: 28839 RVA: 0x00035890 File Offset: 0x00033A90
		public ManagementClipboard_Equippable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170022D0 RID: 8912
		// (get) Token: 0x060070A8 RID: 28840 RVA: 0x001FE2A8 File Offset: 0x001FC4A8
		// (set) Token: 0x060070A9 RID: 28841 RVA: 0x00035899 File Offset: 0x00033A99
		public unsafe Transform Clipboard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_Clipboard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_Clipboard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022D1 RID: 8913
		// (get) Token: 0x060070AA RID: 28842 RVA: 0x001FE2D8 File Offset: 0x001FC4D8
		// (set) Token: 0x060070AB RID: 28843 RVA: 0x000358B8 File Offset: 0x00033AB8
		public unsafe Transform LoweredPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_LoweredPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_LoweredPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022D2 RID: 8914
		// (get) Token: 0x060070AC RID: 28844 RVA: 0x001FE308 File Offset: 0x001FC508
		// (set) Token: 0x060070AD RID: 28845 RVA: 0x000358D7 File Offset: 0x00033AD7
		public unsafe Transform RaisedPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_RaisedPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_RaisedPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022D3 RID: 8915
		// (get) Token: 0x060070AE RID: 28846 RVA: 0x001FE338 File Offset: 0x001FC538
		// (set) Token: 0x060070AF RID: 28847 RVA: 0x000358F6 File Offset: 0x00033AF6
		public unsafe ToggleableLight Light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_Light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ToggleableLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_Light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022D4 RID: 8916
		// (get) Token: 0x060070B0 RID: 28848 RVA: 0x001FE368 File Offset: 0x001FC568
		// (set) Token: 0x060070B1 RID: 28849 RVA: 0x00035915 File Offset: 0x00033B15
		public unsafe SelectionInfoUI SelectionInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_SelectionInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionInfoUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_SelectionInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022D5 RID: 8917
		// (get) Token: 0x060070B2 RID: 28850 RVA: 0x001FE398 File Offset: 0x001FC598
		// (set) Token: 0x060070B3 RID: 28851 RVA: 0x00035934 File Offset: 0x00033B34
		public unsafe TextMeshProUGUI OverrideText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_OverrideText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_OverrideText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022D6 RID: 8918
		// (get) Token: 0x060070B4 RID: 28852 RVA: 0x001FE3C8 File Offset: 0x001FC5C8
		// (set) Token: 0x060070B5 RID: 28853 RVA: 0x00035953 File Offset: 0x00033B53
		public unsafe static bool _heatmapToggledOn
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(ManagementClipboard_Equippable.NativeFieldInfoPtr__heatmapToggledOn, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManagementClipboard_Equippable.NativeFieldInfoPtr__heatmapToggledOn, (void*)(&value));
			}
		}

		// Token: 0x170022D7 RID: 8919
		// (get) Token: 0x060070B6 RID: 28854 RVA: 0x001FE3E4 File Offset: 0x001FC5E4
		// (set) Token: 0x060070B7 RID: 28855 RVA: 0x00035961 File Offset: 0x00033B61
		public unsafe Property _propertyWithHeatmapShown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr__propertyWithHeatmapShown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr__propertyWithHeatmapShown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004D03 RID: 19715
		private static readonly IntPtr NativeFieldInfoPtr_Clipboard;

		// Token: 0x04004D04 RID: 19716
		private static readonly IntPtr NativeFieldInfoPtr_LoweredPosition;

		// Token: 0x04004D05 RID: 19717
		private static readonly IntPtr NativeFieldInfoPtr_RaisedPosition;

		// Token: 0x04004D06 RID: 19718
		private static readonly IntPtr NativeFieldInfoPtr_Light;

		// Token: 0x04004D07 RID: 19719
		private static readonly IntPtr NativeFieldInfoPtr_SelectionInfo;

		// Token: 0x04004D08 RID: 19720
		private static readonly IntPtr NativeFieldInfoPtr_OverrideText;

		// Token: 0x04004D09 RID: 19721
		private static readonly IntPtr NativeFieldInfoPtr__heatmapToggledOn;

		// Token: 0x04004D0A RID: 19722
		private static readonly IntPtr NativeFieldInfoPtr__propertyWithHeatmapShown;

		// Token: 0x04004D0B RID: 19723
		private static readonly IntPtr NativeMethodInfoPtr_ResetHeatmapToggle_Public_Static_Boolean_0;

		// Token: 0x04004D0C RID: 19724
		private static readonly IntPtr NativeMethodInfoPtr_get__canToggleHeatmap_Private_Static_get_Boolean_0;

		// Token: 0x04004D0D RID: 19725
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04004D0E RID: 19726
		private static readonly IntPtr NativeMethodInfoPtr_ShowInputPrompts_Private_Void_0;

		// Token: 0x04004D0F RID: 19727
		private static readonly IntPtr NativeMethodInfoPtr_HideInputPrompts_Private_Void_0;

		// Token: 0x04004D10 RID: 19728
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x04004D11 RID: 19729
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04004D12 RID: 19730
		private static readonly IntPtr NativeMethodInfoPtr_GetSelectedConfigurables_Private_List_1_IConfigurable_0;

		// Token: 0x04004D13 RID: 19731
		private static readonly IntPtr NativeMethodInfoPtr_CanOpenClipboard_Private_Boolean_0;

		// Token: 0x04004D14 RID: 19732
		private static readonly IntPtr NativeMethodInfoPtr_CanCloseClipboard_Private_Boolean_0;

		// Token: 0x04004D15 RID: 19733
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHeatmap_Private_Void_0;

		// Token: 0x04004D16 RID: 19734
		private static readonly IntPtr NativeMethodInfoPtr_ClearPropertyWithHeatmapShown_Private_Void_0;

		// Token: 0x04004D17 RID: 19735
		private static readonly IntPtr NativeMethodInfoPtr_FullscreenEnter_Private_Void_0;

		// Token: 0x04004D18 RID: 19736
		private static readonly IntPtr NativeMethodInfoPtr_FullscreenExit_Private_Void_0;

		// Token: 0x04004D19 RID: 19737
		private static readonly IntPtr NativeMethodInfoPtr_OverrideClipboardText_Public_Void_String_0;

		// Token: 0x04004D1A RID: 19738
		private static readonly IntPtr NativeMethodInfoPtr_EndOverride_Public_Void_0;

		// Token: 0x04004D1B RID: 19739
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B87 RID: 2951
		[ObfuscatedName("ScheduleOne.Tools.ManagementClipboard_Equippable+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E960 RID: 59744 RVA: 0x0038C298 File Offset: 0x0038A498
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ManagementClipboard_Equippable.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementClipboard_Equippable.__c>.NativeClassPtr);
				ManagementClipboard_Equippable.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard_Equippable.__c>.NativeClassPtr, "<>9");
				ManagementClipboard_Equippable.__c.NativeFieldInfoPtr___9__19_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard_Equippable.__c>.NativeClassPtr, "<>9__19_0");
				ManagementClipboard_Equippable.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard_Equippable.__c>.NativeClassPtr, 100677879);
				ManagementClipboard_Equippable.__c.NativeMethodInfoPtr__UpdateHeatmap_b__19_0_Internal_Single_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard_Equippable.__c>.NativeClassPtr, 100677880);
			}

			// Token: 0x0600E961 RID: 59745 RVA: 0x0038C314 File Offset: 0x0038A514
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementClipboard_Equippable.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard_Equippable.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E962 RID: 59746 RVA: 0x0038C350 File Offset: 0x0038A550
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224661, XrefRangeEnd = 224668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _UpdateHeatmap_b__19_0(Property x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard_Equippable.__c.NativeMethodInfoPtr__UpdateHeatmap_b__19_0_Internal_Single_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E963 RID: 59747 RVA: 0x0006E1DD File Offset: 0x0006C3DD
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046CD RID: 18125
			// (get) Token: 0x0600E964 RID: 59748 RVA: 0x0038C3A0 File Offset: 0x0038A5A0
			// (set) Token: 0x0600E965 RID: 59749 RVA: 0x0006E1E6 File Offset: 0x0006C3E6
			public unsafe static ManagementClipboard_Equippable.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ManagementClipboard_Equippable.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManagementClipboard_Equippable.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ManagementClipboard_Equippable.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046CE RID: 18126
			// (get) Token: 0x0600E966 RID: 59750 RVA: 0x0038C3C8 File Offset: 0x0038A5C8
			// (set) Token: 0x0600E967 RID: 59751 RVA: 0x0006E1F8 File Offset: 0x0006C3F8
			public unsafe static Func<Property, float> __9__19_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ManagementClipboard_Equippable.__c.NativeFieldInfoPtr___9__19_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Property, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ManagementClipboard_Equippable.__c.NativeFieldInfoPtr___9__19_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009E45 RID: 40517
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009E46 RID: 40518
			private static readonly IntPtr NativeFieldInfoPtr___9__19_0;

			// Token: 0x04009E47 RID: 40519
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009E48 RID: 40520
			private static readonly IntPtr NativeMethodInfoPtr__UpdateHeatmap_b__19_0_Internal_Single_Property_0;
		}
	}
}
