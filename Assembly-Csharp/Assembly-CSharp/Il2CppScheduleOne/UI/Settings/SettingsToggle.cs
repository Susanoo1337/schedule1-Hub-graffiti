using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x0200079B RID: 1947
	public class SettingsToggle : MonoBehaviour
	{
		// Token: 0x0600BC83 RID: 48259 RVA: 0x00306540 File Offset: 0x00304740
		// Note: this type is marked as 'beforefieldinit'.
		static SettingsToggle()
		{
			Il2CppClassPointerStore<SettingsToggle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "SettingsToggle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsToggle>.NativeClassPtr);
			SettingsToggle.NativeFieldInfoPtr_uiToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsToggle>.NativeClassPtr, "uiToggle");
			SettingsToggle.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsToggle>.NativeClassPtr, 100687894);
			SettingsToggle.NativeMethodInfoPtr_SetIsOnWithoutNotify_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsToggle>.NativeClassPtr, 100687895);
			SettingsToggle.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsToggle>.NativeClassPtr, 100687896);
			SettingsToggle.NativeMethodInfoPtr_GetReferences_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsToggle>.NativeClassPtr, 100687897);
			SettingsToggle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsToggle>.NativeClassPtr, 100687898);
		}

		// Token: 0x0600BC84 RID: 48260 RVA: 0x003065E8 File Offset: 0x003047E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314223, XrefRangeEnd = 314235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SettingsToggle.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BC85 RID: 48261 RVA: 0x00306624 File Offset: 0x00304824
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 314237, RefRangeEnd = 314242, XrefRangeStart = 314235, XrefRangeEnd = 314237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOnWithoutNotify(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsToggle.NativeMethodInfoPtr_SetIsOnWithoutNotify_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BC86 RID: 48262 RVA: 0x00306664 File Offset: 0x00304864
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnValueChanged(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SettingsToggle.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BC87 RID: 48263 RVA: 0x003066B0 File Offset: 0x003048B0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 314250, RefRangeEnd = 314255, XrefRangeStart = 314242, XrefRangeEnd = 314250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetReferences()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsToggle.NativeMethodInfoPtr_GetReferences_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BC88 RID: 48264 RVA: 0x003066E4 File Offset: 0x003048E4
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SettingsToggle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsToggle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsToggle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BC89 RID: 48265 RVA: 0x00057D76 File Offset: 0x00055F76
		public SettingsToggle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038E5 RID: 14565
		// (get) Token: 0x0600BC8A RID: 48266 RVA: 0x00306720 File Offset: 0x00304920
		// (set) Token: 0x0600BC8B RID: 48267 RVA: 0x00057D7F File Offset: 0x00055F7F
		public unsafe UIToggle uiToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsToggle.NativeFieldInfoPtr_uiToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsToggle.NativeFieldInfoPtr_uiToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400812D RID: 33069
		private static readonly IntPtr NativeFieldInfoPtr_uiToggle;

		// Token: 0x0400812E RID: 33070
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x0400812F RID: 33071
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOnWithoutNotify_Protected_Void_Boolean_0;

		// Token: 0x04008130 RID: 33072
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04008131 RID: 33073
		private static readonly IntPtr NativeMethodInfoPtr_GetReferences_Private_Void_0;

		// Token: 0x04008132 RID: 33074
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
