using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x0200078A RID: 1930
	public class DisplayModeDropdown : SettingsDropdown
	{
		// Token: 0x0600BBD7 RID: 48087 RVA: 0x00303F5C File Offset: 0x0030215C
		// Note: this type is marked as 'beforefieldinit'.
		static DisplayModeDropdown()
		{
			Il2CppClassPointerStore<DisplayModeDropdown>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "DisplayModeDropdown");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisplayModeDropdown>.NativeClassPtr);
			DisplayModeDropdown.NativeMethodInfoPtr_get_displayModes_Private_get_Il2CppStructArray_1_EDisplayMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayModeDropdown>.NativeClassPtr, 100687795);
			DisplayModeDropdown.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayModeDropdown>.NativeClassPtr, 100687796);
			DisplayModeDropdown.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayModeDropdown>.NativeClassPtr, 100687797);
			DisplayModeDropdown.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayModeDropdown>.NativeClassPtr, 100687798);
			DisplayModeDropdown.NativeMethodInfoPtr_RegenerateOptions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayModeDropdown>.NativeClassPtr, 100687799);
			DisplayModeDropdown.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayModeDropdown>.NativeClassPtr, 100687800);
		}

		// Token: 0x170038CB RID: 14539
		// (get) Token: 0x0600BBD8 RID: 48088 RVA: 0x00304004 File Offset: 0x00302204
		public unsafe Il2CppStructArray<DisplaySettings.EDisplayMode> displayModes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313316, XrefRangeEnd = 313317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayModeDropdown.NativeMethodInfoPtr_get_displayModes_Private_get_Il2CppStructArray_1_EDisplayMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<DisplaySettings.EDisplayMode>>(intPtr3) : null;
			}
		}

		// Token: 0x0600BBD9 RID: 48089 RVA: 0x00304044 File Offset: 0x00302244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313317, XrefRangeEnd = 313344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DisplayModeDropdown.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BBDA RID: 48090 RVA: 0x00304080 File Offset: 0x00302280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313344, XrefRangeEnd = 313370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DisplayModeDropdown.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BBDB RID: 48091 RVA: 0x003040BC File Offset: 0x003022BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313370, XrefRangeEnd = 313382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValueChanged(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DisplayModeDropdown.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BBDC RID: 48092 RVA: 0x00304108 File Offset: 0x00302308
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 313409, RefRangeEnd = 313410, XrefRangeStart = 313382, XrefRangeEnd = 313409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegenerateOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayModeDropdown.NativeMethodInfoPtr_RegenerateOptions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BBDD RID: 48093 RVA: 0x0030413C File Offset: 0x0030233C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 34977, RefRangeEnd = 34989, XrefRangeStart = 34977, XrefRangeEnd = 34989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DisplayModeDropdown() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisplayModeDropdown>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayModeDropdown.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BBDE RID: 48094 RVA: 0x00057A62 File Offset: 0x00055C62
		public DisplayModeDropdown(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040080BB RID: 32955
		private static readonly IntPtr NativeMethodInfoPtr_get_displayModes_Private_get_Il2CppStructArray_1_EDisplayMode_0;

		// Token: 0x040080BC RID: 32956
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0;

		// Token: 0x040080BD RID: 32957
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0;

		// Token: 0x040080BE RID: 32958
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Int32_0;

		// Token: 0x040080BF RID: 32959
		private static readonly IntPtr NativeMethodInfoPtr_RegenerateOptions_Private_Void_0;

		// Token: 0x040080C0 RID: 32960
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
