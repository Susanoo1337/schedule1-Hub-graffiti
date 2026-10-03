using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000762 RID: 1890
	public class TabItemUI : MonoBehaviour
	{
		// Token: 0x0600B847 RID: 47175 RVA: 0x002F9634 File Offset: 0x002F7834
		// Note: this type is marked as 'beforefieldinit'.
		static TabItemUI()
		{
			Il2CppClassPointerStore<TabItemUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "TabItemUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TabItemUI>.NativeClassPtr);
			TabItemUI.NativeFieldInfoPtr__button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabItemUI>.NativeClassPtr, "_button");
			TabItemUI.NativeFieldInfoPtr__label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabItemUI>.NativeClassPtr, "_label");
			TabItemUI.NativeFieldInfoPtr__content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabItemUI>.NativeClassPtr, "_content");
			TabItemUI.NativeFieldInfoPtr__indicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabItemUI>.NativeClassPtr, "_indicator");
			TabItemUI.NativeFieldInfoPtr__indicatorLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabItemUI>.NativeClassPtr, "_indicatorLabel");
			TabItemUI.NativeFieldInfoPtr__contentPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabItemUI>.NativeClassPtr, "_contentPanel");
			TabItemUI.NativeMethodInfoPtr_get_Button_Public_get_ButtonUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabItemUI>.NativeClassPtr, 100687416);
			TabItemUI.NativeMethodInfoPtr_get_Label_Public_get_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabItemUI>.NativeClassPtr, 100687417);
			TabItemUI.NativeMethodInfoPtr_get_Content_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabItemUI>.NativeClassPtr, 100687418);
			TabItemUI.NativeMethodInfoPtr_SetIndicator_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabItemUI>.NativeClassPtr, 100687419);
			TabItemUI.NativeMethodInfoPtr_HideIndicator_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabItemUI>.NativeClassPtr, 100687420);
			TabItemUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabItemUI>.NativeClassPtr, 100687421);
		}

		// Token: 0x170037AC RID: 14252
		// (get) Token: 0x0600B848 RID: 47176 RVA: 0x002F9754 File Offset: 0x002F7954
		public unsafe ButtonUI Button
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabItemUI.NativeMethodInfoPtr_get_Button_Public_get_ButtonUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ButtonUI>(intPtr3) : null;
			}
		}

		// Token: 0x170037AD RID: 14253
		// (get) Token: 0x0600B849 RID: 47177 RVA: 0x002F9794 File Offset: 0x002F7994
		public unsafe Text Label
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabItemUI.NativeMethodInfoPtr_get_Label_Public_get_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Text>(intPtr3) : null;
			}
		}

		// Token: 0x170037AE RID: 14254
		// (get) Token: 0x0600B84A RID: 47178 RVA: 0x002F97D4 File Offset: 0x002F79D4
		public unsafe GameObject Content
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 2964, RefRangeEnd = 2977, XrefRangeStart = 2964, XrefRangeEnd = 2977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabItemUI.NativeMethodInfoPtr_get_Content_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x0600B84B RID: 47179 RVA: 0x002F9814 File Offset: 0x002F7A14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 309034, RefRangeEnd = 309035, XrefRangeStart = 309026, XrefRangeEnd = 309034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIndicator(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabItemUI.NativeMethodInfoPtr_SetIndicator_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B84C RID: 47180 RVA: 0x002F9858 File Offset: 0x002F7A58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 309040, RefRangeEnd = 309041, XrefRangeStart = 309035, XrefRangeEnd = 309040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideIndicator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabItemUI.NativeMethodInfoPtr_HideIndicator_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B84D RID: 47181 RVA: 0x002F988C File Offset: 0x002F7A8C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TabItemUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TabItemUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabItemUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B84E RID: 47182 RVA: 0x00055A63 File Offset: 0x00053C63
		public TabItemUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170037A6 RID: 14246
		// (get) Token: 0x0600B84F RID: 47183 RVA: 0x002F98C8 File Offset: 0x002F7AC8
		// (set) Token: 0x0600B850 RID: 47184 RVA: 0x00055A6C File Offset: 0x00053C6C
		public unsafe ButtonUI _button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabItemUI.NativeFieldInfoPtr__button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ButtonUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabItemUI.NativeFieldInfoPtr__button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037A7 RID: 14247
		// (get) Token: 0x0600B851 RID: 47185 RVA: 0x002F98F8 File Offset: 0x002F7AF8
		// (set) Token: 0x0600B852 RID: 47186 RVA: 0x00055A8B File Offset: 0x00053C8B
		public unsafe Text _label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabItemUI.NativeFieldInfoPtr__label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabItemUI.NativeFieldInfoPtr__label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037A8 RID: 14248
		// (get) Token: 0x0600B853 RID: 47187 RVA: 0x002F9928 File Offset: 0x002F7B28
		// (set) Token: 0x0600B854 RID: 47188 RVA: 0x00055AAA File Offset: 0x00053CAA
		public unsafe GameObject _content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabItemUI.NativeFieldInfoPtr__content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabItemUI.NativeFieldInfoPtr__content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037A9 RID: 14249
		// (get) Token: 0x0600B855 RID: 47189 RVA: 0x002F9958 File Offset: 0x002F7B58
		// (set) Token: 0x0600B856 RID: 47190 RVA: 0x00055AC9 File Offset: 0x00053CC9
		public unsafe GameObject _indicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabItemUI.NativeFieldInfoPtr__indicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabItemUI.NativeFieldInfoPtr__indicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037AA RID: 14250
		// (get) Token: 0x0600B857 RID: 47191 RVA: 0x002F9988 File Offset: 0x002F7B88
		// (set) Token: 0x0600B858 RID: 47192 RVA: 0x00055AE8 File Offset: 0x00053CE8
		public unsafe Text _indicatorLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabItemUI.NativeFieldInfoPtr__indicatorLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabItemUI.NativeFieldInfoPtr__indicatorLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037AB RID: 14251
		// (get) Token: 0x0600B859 RID: 47193 RVA: 0x002F99B8 File Offset: 0x002F7BB8
		// (set) Token: 0x0600B85A RID: 47194 RVA: 0x00055B07 File Offset: 0x00053D07
		public unsafe UIPanel _contentPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabItemUI.NativeFieldInfoPtr__contentPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabItemUI.NativeFieldInfoPtr__contentPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007E88 RID: 32392
		private static readonly IntPtr NativeFieldInfoPtr__button;

		// Token: 0x04007E89 RID: 32393
		private static readonly IntPtr NativeFieldInfoPtr__label;

		// Token: 0x04007E8A RID: 32394
		private static readonly IntPtr NativeFieldInfoPtr__content;

		// Token: 0x04007E8B RID: 32395
		private static readonly IntPtr NativeFieldInfoPtr__indicator;

		// Token: 0x04007E8C RID: 32396
		private static readonly IntPtr NativeFieldInfoPtr__indicatorLabel;

		// Token: 0x04007E8D RID: 32397
		private static readonly IntPtr NativeFieldInfoPtr__contentPanel;

		// Token: 0x04007E8E RID: 32398
		private static readonly IntPtr NativeMethodInfoPtr_get_Button_Public_get_ButtonUI_0;

		// Token: 0x04007E8F RID: 32399
		private static readonly IntPtr NativeMethodInfoPtr_get_Label_Public_get_Text_0;

		// Token: 0x04007E90 RID: 32400
		private static readonly IntPtr NativeMethodInfoPtr_get_Content_Public_get_GameObject_0;

		// Token: 0x04007E91 RID: 32401
		private static readonly IntPtr NativeMethodInfoPtr_SetIndicator_Public_Void_String_0;

		// Token: 0x04007E92 RID: 32402
		private static readonly IntPtr NativeMethodInfoPtr_HideIndicator_Public_Void_0;

		// Token: 0x04007E93 RID: 32403
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
