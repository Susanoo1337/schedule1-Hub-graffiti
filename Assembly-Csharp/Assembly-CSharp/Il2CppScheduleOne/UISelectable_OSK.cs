using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine.UI;

namespace Il2CppScheduleOne
{
	// Token: 0x020000B4 RID: 180
	public class UISelectable_OSK : UISelectable
	{
		// Token: 0x06001056 RID: 4182 RVA: 0x000B1D00 File Offset: 0x000AFF00
		// Note: this type is marked as 'beforefieldinit'.
		static UISelectable_OSK()
		{
			Il2CppClassPointerStore<UISelectable_OSK>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "UISelectable_OSK");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISelectable_OSK>.NativeClassPtr);
			UISelectable_OSK.NativeFieldInfoPtr_InputDescriptionSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectable_OSK>.NativeClassPtr, "InputDescriptionSource");
			UISelectable_OSK.NativeFieldInfoPtr_InputDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectable_OSK>.NativeClassPtr, "InputDescription");
			UISelectable_OSK.NativeFieldInfoPtr_tmpInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectable_OSK>.NativeClassPtr, "tmpInputField");
			UISelectable_OSK.NativeFieldInfoPtr_legacyInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectable_OSK>.NativeClassPtr, "legacyInputField");
			UISelectable_OSK.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable_OSK>.NativeClassPtr, 100665369);
			UISelectable_OSK.NativeMethodInfoPtr_ShowOSK_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable_OSK>.NativeClassPtr, 100665370);
			UISelectable_OSK.NativeMethodInfoPtr_OnSubmit_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable_OSK>.NativeClassPtr, 100665371);
			UISelectable_OSK.NativeMethodInfoPtr_DeselectOnPointerExit_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable_OSK>.NativeClassPtr, 100665372);
			UISelectable_OSK.NativeMethodInfoPtr_OnTriggered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable_OSK>.NativeClassPtr, 100665373);
			UISelectable_OSK.NativeMethodInfoPtr_OnCancel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable_OSK>.NativeClassPtr, 100665374);
			UISelectable_OSK.NativeMethodInfoPtr_OnSelect_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable_OSK>.NativeClassPtr, 100665375);
			UISelectable_OSK.NativeMethodInfoPtr_UpdateCaret_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable_OSK>.NativeClassPtr, 100665376);
			UISelectable_OSK.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable_OSK>.NativeClassPtr, 100665377);
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x000B1E34 File Offset: 0x000B0034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84807, XrefRangeEnd = 84843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UISelectable_OSK.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x000B1E70 File Offset: 0x000B0070
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84905, RefRangeEnd = 84906, XrefRangeStart = 84843, XrefRangeEnd = 84905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowOSK()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectable_OSK.NativeMethodInfoPtr_ShowOSK_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x000B1EA4 File Offset: 0x000B00A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84906, XrefRangeEnd = 84926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSubmit(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectable_OSK.NativeMethodInfoPtr_OnSubmit_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x000B1EE8 File Offset: 0x000B00E8
		[CallerCount(170)]
		[CachedScanResults(RefRangeStart = 31151, RefRangeEnd = 31321, XrefRangeStart = 31151, XrefRangeEnd = 31321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DeselectOnPointerExit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UISelectable_OSK.NativeMethodInfoPtr_DeselectOnPointerExit_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x000B1F30 File Offset: 0x000B0130
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84935, RefRangeEnd = 84936, XrefRangeStart = 84926, XrefRangeEnd = 84935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectable_OSK.NativeMethodInfoPtr_OnTriggered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x000B1F64 File Offset: 0x000B0164
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectable_OSK.NativeMethodInfoPtr_OnCancel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x000B1F98 File Offset: 0x000B0198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84936, XrefRangeEnd = 84944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSelect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectable_OSK.NativeMethodInfoPtr_OnSelect_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x000B1FCC File Offset: 0x000B01CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 84962, RefRangeEnd = 84964, XrefRangeStart = 84944, XrefRangeEnd = 84962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCaret()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectable_OSK.NativeMethodInfoPtr_UpdateCaret_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x000B2000 File Offset: 0x000B0200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84964, XrefRangeEnd = 84969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UISelectable_OSK() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UISelectable_OSK>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectable_OSK.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x000098D5 File Offset: 0x00007AD5
		public UISelectable_OSK(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06001061 RID: 4193 RVA: 0x000B203C File Offset: 0x000B023C
		// (set) Token: 0x06001062 RID: 4194 RVA: 0x000098DE File Offset: 0x00007ADE
		public unsafe TextMeshProUGUI InputDescriptionSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable_OSK.NativeFieldInfoPtr_InputDescriptionSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable_OSK.NativeFieldInfoPtr_InputDescriptionSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06001063 RID: 4195 RVA: 0x000B206C File Offset: 0x000B026C
		// (set) Token: 0x06001064 RID: 4196 RVA: 0x000098FD File Offset: 0x00007AFD
		public unsafe string InputDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable_OSK.NativeFieldInfoPtr_InputDescription);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable_OSK.NativeFieldInfoPtr_InputDescription), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06001065 RID: 4197 RVA: 0x000B2094 File Offset: 0x000B0294
		// (set) Token: 0x06001066 RID: 4198 RVA: 0x0000991C File Offset: 0x00007B1C
		public unsafe TMP_InputField tmpInputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable_OSK.NativeFieldInfoPtr_tmpInputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable_OSK.NativeFieldInfoPtr_tmpInputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06001067 RID: 4199 RVA: 0x000B20C4 File Offset: 0x000B02C4
		// (set) Token: 0x06001068 RID: 4200 RVA: 0x0000993B File Offset: 0x00007B3B
		public unsafe InputField legacyInputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable_OSK.NativeFieldInfoPtr_legacyInputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable_OSK.NativeFieldInfoPtr_legacyInputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B66 RID: 2918
		private static readonly IntPtr NativeFieldInfoPtr_InputDescriptionSource;

		// Token: 0x04000B67 RID: 2919
		private static readonly IntPtr NativeFieldInfoPtr_InputDescription;

		// Token: 0x04000B68 RID: 2920
		private static readonly IntPtr NativeFieldInfoPtr_tmpInputField;

		// Token: 0x04000B69 RID: 2921
		private static readonly IntPtr NativeFieldInfoPtr_legacyInputField;

		// Token: 0x04000B6A RID: 2922
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04000B6B RID: 2923
		private static readonly IntPtr NativeMethodInfoPtr_ShowOSK_Private_Void_0;

		// Token: 0x04000B6C RID: 2924
		private static readonly IntPtr NativeMethodInfoPtr_OnSubmit_Private_Void_String_0;

		// Token: 0x04000B6D RID: 2925
		private static readonly IntPtr NativeMethodInfoPtr_DeselectOnPointerExit_Protected_Virtual_Boolean_0;

		// Token: 0x04000B6E RID: 2926
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggered_Public_Void_0;

		// Token: 0x04000B6F RID: 2927
		private static readonly IntPtr NativeMethodInfoPtr_OnCancel_Private_Void_0;

		// Token: 0x04000B70 RID: 2928
		private static readonly IntPtr NativeMethodInfoPtr_OnSelect_Private_Void_0;

		// Token: 0x04000B71 RID: 2929
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCaret_Private_Void_0;

		// Token: 0x04000B72 RID: 2930
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
