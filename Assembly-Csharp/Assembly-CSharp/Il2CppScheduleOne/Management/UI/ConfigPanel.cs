using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Management.UI
{
	// Token: 0x020002F6 RID: 758
	public class ConfigPanel : MonoBehaviour
	{
		// Token: 0x06003BFF RID: 15359 RVA: 0x00145884 File Offset: 0x00143A84
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigPanel()
		{
			Il2CppClassPointerStore<ConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management.UI", "ConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigPanel>.NativeClassPtr);
			ConfigPanel.NativeFieldInfoPtr__ContentPanel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigPanel>.NativeClassPtr, "<ContentPanel>k__BackingField");
			ConfigPanel.NativeMethodInfoPtr_get_ContentPanel_Public_get_UIContentPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigPanel>.NativeClassPtr, 100670989);
			ConfigPanel.NativeMethodInfoPtr_set_ContentPanel_Private_set_Void_UIContentPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigPanel>.NativeClassPtr, 100670990);
			ConfigPanel.NativeMethodInfoPtr_Bind_Public_Void_List_1_EntityConfiguration_UIScreen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigPanel>.NativeClassPtr, 100670991);
			ConfigPanel.NativeMethodInfoPtr_BindInternal_Protected_Virtual_New_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigPanel>.NativeClassPtr, 100670992);
			ConfigPanel.NativeMethodInfoPtr_ConfigureScreen_Private_Void_UIScreen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigPanel>.NativeClassPtr, 100670993);
			ConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigPanel>.NativeClassPtr, 100670994);
		}

		// Token: 0x170012CA RID: 4810
		// (get) Token: 0x06003C00 RID: 15360 RVA: 0x00145940 File Offset: 0x00143B40
		// (set) Token: 0x06003C01 RID: 15361 RVA: 0x00145980 File Offset: 0x00143B80
		public unsafe UIContentPanel ContentPanel
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigPanel.NativeMethodInfoPtr_get_ContentPanel_Public_get_UIContentPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIContentPanel>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigPanel.NativeMethodInfoPtr_set_ContentPanel_Private_set_Void_UIContentPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003C02 RID: 15362 RVA: 0x001459C4 File Offset: 0x00143BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150803, XrefRangeEnd = 150804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bind(List<EntityConfiguration> configs, UIScreen screen = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(screen);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigPanel.NativeMethodInfoPtr_Bind_Public_Void_List_1_EntityConfiguration_UIScreen_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C03 RID: 15363 RVA: 0x00145A18 File Offset: 0x00143C18
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void BindInternal(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigPanel.NativeMethodInfoPtr_BindInternal_Protected_Virtual_New_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C04 RID: 15364 RVA: 0x00145A68 File Offset: 0x00143C68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 150829, RefRangeEnd = 150831, XrefRangeStart = 150804, XrefRangeEnd = 150829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureScreen(UIScreen screen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(screen);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigPanel.NativeMethodInfoPtr_ConfigureScreen_Private_Void_UIScreen_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C05 RID: 15365 RVA: 0x00145AAC File Offset: 0x00143CAC
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C06 RID: 15366 RVA: 0x0001DEBB File Offset: 0x0001C0BB
		public ConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170012C9 RID: 4809
		// (get) Token: 0x06003C07 RID: 15367 RVA: 0x00145AE8 File Offset: 0x00143CE8
		// (set) Token: 0x06003C08 RID: 15368 RVA: 0x0001DEC4 File Offset: 0x0001C0C4
		public unsafe UIContentPanel _ContentPanel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigPanel.NativeFieldInfoPtr__ContentPanel_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIContentPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigPanel.NativeFieldInfoPtr__ContentPanel_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400287D RID: 10365
		private static readonly IntPtr NativeFieldInfoPtr__ContentPanel_k__BackingField;

		// Token: 0x0400287E RID: 10366
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentPanel_Public_get_UIContentPanel_0;

		// Token: 0x0400287F RID: 10367
		private static readonly IntPtr NativeMethodInfoPtr_set_ContentPanel_Private_set_Void_UIContentPanel_0;

		// Token: 0x04002880 RID: 10368
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Void_List_1_EntityConfiguration_UIScreen_0;

		// Token: 0x04002881 RID: 10369
		private static readonly IntPtr NativeMethodInfoPtr_BindInternal_Protected_Virtual_New_Void_List_1_EntityConfiguration_0;

		// Token: 0x04002882 RID: 10370
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureScreen_Private_Void_UIScreen_0;

		// Token: 0x04002883 RID: 10371
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
