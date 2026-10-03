using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine.UI;

namespace Il2CppScheduleOne
{
	// Token: 0x0200009F RID: 159
	public class UIDropdownContent : UIScreen
	{
		// Token: 0x06000D9E RID: 3486 RVA: 0x000A8B94 File Offset: 0x000A6D94
		// Note: this type is marked as 'beforefieldinit'.
		static UIDropdownContent()
		{
			Il2CppClassPointerStore<UIDropdownContent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "UIDropdownContent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIDropdownContent>.NativeClassPtr);
			UIDropdownContent.NativeFieldInfoPtr__tmpDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDropdownContent>.NativeClassPtr, "_tmpDropdown");
			UIDropdownContent.NativeFieldInfoPtr__legacyDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDropdownContent>.NativeClassPtr, "_legacyDropdown");
			UIDropdownContent.NativeMethodInfoPtr_OnStarted_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDropdownContent>.NativeClassPtr, 100665031);
			UIDropdownContent.NativeMethodInfoPtr_Close_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDropdownContent>.NativeClassPtr, 100665032);
			UIDropdownContent.NativeMethodInfoPtr_OnDropDownChange_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDropdownContent>.NativeClassPtr, 100665033);
			UIDropdownContent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDropdownContent>.NativeClassPtr, 100665034);
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x000A8C3C File Offset: 0x000A6E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80519, XrefRangeEnd = 80577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStarted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIDropdownContent.NativeMethodInfoPtr_OnStarted_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x000A8C78 File Offset: 0x000A6E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80577, XrefRangeEnd = 80591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIDropdownContent.NativeMethodInfoPtr_Close_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x000A8CAC File Offset: 0x000A6EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80591, XrefRangeEnd = 80618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDropDownChange(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIDropdownContent.NativeMethodInfoPtr_OnDropDownChange_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x000A8CEC File Offset: 0x000A6EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80618, XrefRangeEnd = 80619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIDropdownContent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIDropdownContent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIDropdownContent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x000083AB File Offset: 0x000065AB
		public UIDropdownContent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000DA4 RID: 3492 RVA: 0x000A8D28 File Offset: 0x000A6F28
		// (set) Token: 0x06000DA5 RID: 3493 RVA: 0x000083B4 File Offset: 0x000065B4
		public unsafe TMP_Dropdown _tmpDropdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDropdownContent.NativeFieldInfoPtr__tmpDropdown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Dropdown>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDropdownContent.NativeFieldInfoPtr__tmpDropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000DA6 RID: 3494 RVA: 0x000A8D58 File Offset: 0x000A6F58
		// (set) Token: 0x06000DA7 RID: 3495 RVA: 0x000083D3 File Offset: 0x000065D3
		public unsafe Dropdown _legacyDropdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDropdownContent.NativeFieldInfoPtr__legacyDropdown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dropdown>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDropdownContent.NativeFieldInfoPtr__legacyDropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400098C RID: 2444
		private static readonly IntPtr NativeFieldInfoPtr__tmpDropdown;

		// Token: 0x0400098D RID: 2445
		private static readonly IntPtr NativeFieldInfoPtr__legacyDropdown;

		// Token: 0x0400098E RID: 2446
		private static readonly IntPtr NativeMethodInfoPtr_OnStarted_Protected_Virtual_Void_0;

		// Token: 0x0400098F RID: 2447
		private static readonly IntPtr NativeMethodInfoPtr_Close_Private_Void_0;

		// Token: 0x04000990 RID: 2448
		private static readonly IntPtr NativeMethodInfoPtr_OnDropDownChange_Private_Void_Int32_0;

		// Token: 0x04000991 RID: 2449
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
