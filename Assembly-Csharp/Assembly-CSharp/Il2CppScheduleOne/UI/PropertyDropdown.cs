using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Property;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000757 RID: 1879
	public class PropertyDropdown : MonoBehaviour
	{
		// Token: 0x0600B735 RID: 46901 RVA: 0x002F6108 File Offset: 0x002F4308
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyDropdown()
		{
			Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "PropertyDropdown");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr);
			PropertyDropdown.NativeFieldInfoPtr_selectedProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr, "selectedProperty");
			PropertyDropdown.NativeFieldInfoPtr_TMP_dropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr, "TMP_dropdown");
			PropertyDropdown.NativeFieldInfoPtr_dropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr, "dropdown");
			PropertyDropdown.NativeFieldInfoPtr_intToProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr, "intToProperty");
			PropertyDropdown.NativeFieldInfoPtr_onSelectionChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr, "onSelectionChanged");
			PropertyDropdown.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr, 100687263);
			PropertyDropdown.NativeMethodInfoPtr_PropertyAcquired_Private_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr, 100687264);
			PropertyDropdown.NativeMethodInfoPtr_ValueChanged_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr, 100687265);
			PropertyDropdown.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr, 100687266);
		}

		// Token: 0x0600B736 RID: 46902 RVA: 0x002F61EC File Offset: 0x002F43EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307639, XrefRangeEnd = 307709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyDropdown.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B737 RID: 46903 RVA: 0x002F6228 File Offset: 0x002F4428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307709, XrefRangeEnd = 307738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PropertyAcquired(Property p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyDropdown.NativeMethodInfoPtr_PropertyAcquired_Private_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B738 RID: 46904 RVA: 0x002F626C File Offset: 0x002F446C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307738, XrefRangeEnd = 307742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValueChanged(int newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyDropdown.NativeMethodInfoPtr_ValueChanged_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B739 RID: 46905 RVA: 0x002F62AC File Offset: 0x002F44AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307742, XrefRangeEnd = 307750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyDropdown() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyDropdown.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B73A RID: 46906 RVA: 0x000550B6 File Offset: 0x000532B6
		public PropertyDropdown(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003750 RID: 14160
		// (get) Token: 0x0600B73B RID: 46907 RVA: 0x002F62E8 File Offset: 0x002F44E8
		// (set) Token: 0x0600B73C RID: 46908 RVA: 0x000550BF File Offset: 0x000532BF
		public unsafe Property selectedProperty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDropdown.NativeFieldInfoPtr_selectedProperty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDropdown.NativeFieldInfoPtr_selectedProperty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003751 RID: 14161
		// (get) Token: 0x0600B73D RID: 46909 RVA: 0x002F6318 File Offset: 0x002F4518
		// (set) Token: 0x0600B73E RID: 46910 RVA: 0x000550DE File Offset: 0x000532DE
		public unsafe TMP_Dropdown TMP_dropdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDropdown.NativeFieldInfoPtr_TMP_dropdown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Dropdown>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDropdown.NativeFieldInfoPtr_TMP_dropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003752 RID: 14162
		// (get) Token: 0x0600B73F RID: 46911 RVA: 0x002F6348 File Offset: 0x002F4548
		// (set) Token: 0x0600B740 RID: 46912 RVA: 0x000550FD File Offset: 0x000532FD
		public unsafe Dropdown dropdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDropdown.NativeFieldInfoPtr_dropdown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dropdown>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDropdown.NativeFieldInfoPtr_dropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003753 RID: 14163
		// (get) Token: 0x0600B741 RID: 46913 RVA: 0x002F6378 File Offset: 0x002F4578
		// (set) Token: 0x0600B742 RID: 46914 RVA: 0x0005511C File Offset: 0x0005331C
		public unsafe Dictionary<int, Property> intToProperty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDropdown.NativeFieldInfoPtr_intToProperty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Property>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDropdown.NativeFieldInfoPtr_intToProperty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003754 RID: 14164
		// (get) Token: 0x0600B743 RID: 46915 RVA: 0x002F63A8 File Offset: 0x002F45A8
		// (set) Token: 0x0600B744 RID: 46916 RVA: 0x0005513B File Offset: 0x0005333B
		public unsafe Action onSelectionChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDropdown.NativeFieldInfoPtr_onSelectionChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDropdown.NativeFieldInfoPtr_onSelectionChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007DDC RID: 32220
		private static readonly IntPtr NativeFieldInfoPtr_selectedProperty;

		// Token: 0x04007DDD RID: 32221
		private static readonly IntPtr NativeFieldInfoPtr_TMP_dropdown;

		// Token: 0x04007DDE RID: 32222
		private static readonly IntPtr NativeFieldInfoPtr_dropdown;

		// Token: 0x04007DDF RID: 32223
		private static readonly IntPtr NativeFieldInfoPtr_intToProperty;

		// Token: 0x04007DE0 RID: 32224
		private static readonly IntPtr NativeFieldInfoPtr_onSelectionChanged;

		// Token: 0x04007DE1 RID: 32225
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04007DE2 RID: 32226
		private static readonly IntPtr NativeMethodInfoPtr_PropertyAcquired_Private_Void_Property_0;

		// Token: 0x04007DE3 RID: 32227
		private static readonly IntPtr NativeMethodInfoPtr_ValueChanged_Private_Void_Int32_0;

		// Token: 0x04007DE4 RID: 32228
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
