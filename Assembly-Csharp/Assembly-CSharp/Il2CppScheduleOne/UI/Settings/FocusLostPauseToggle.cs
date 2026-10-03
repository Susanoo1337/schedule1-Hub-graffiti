using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x0200078B RID: 1931
	public class FocusLostPauseToggle : SettingsToggle
	{
		// Token: 0x0600BBDF RID: 48095 RVA: 0x00304178 File Offset: 0x00302378
		// Note: this type is marked as 'beforefieldinit'.
		static FocusLostPauseToggle()
		{
			Il2CppClassPointerStore<FocusLostPauseToggle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "FocusLostPauseToggle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FocusLostPauseToggle>.NativeClassPtr);
			FocusLostPauseToggle.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusLostPauseToggle>.NativeClassPtr, 100687801);
			FocusLostPauseToggle.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusLostPauseToggle>.NativeClassPtr, 100687802);
			FocusLostPauseToggle.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusLostPauseToggle>.NativeClassPtr, 100687803);
			FocusLostPauseToggle.NativeMethodInfoPtr_Redraw_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusLostPauseToggle>.NativeClassPtr, 100687804);
			FocusLostPauseToggle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusLostPauseToggle>.NativeClassPtr, 100687805);
		}

		// Token: 0x0600BBE0 RID: 48096 RVA: 0x0030420C File Offset: 0x0030240C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313410, XrefRangeEnd = 313427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FocusLostPauseToggle.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BBE1 RID: 48097 RVA: 0x00304248 File Offset: 0x00302448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313427, XrefRangeEnd = 313439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FocusLostPauseToggle.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BBE2 RID: 48098 RVA: 0x00304284 File Offset: 0x00302484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313439, XrefRangeEnd = 313449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValueChanged(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FocusLostPauseToggle.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BBE3 RID: 48099 RVA: 0x003042D0 File Offset: 0x003024D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313449, XrefRangeEnd = 313455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Redraw()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusLostPauseToggle.NativeMethodInfoPtr_Redraw_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BBE4 RID: 48100 RVA: 0x00304304 File Offset: 0x00302504
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 34977, RefRangeEnd = 34989, XrefRangeStart = 34977, XrefRangeEnd = 34989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FocusLostPauseToggle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FocusLostPauseToggle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusLostPauseToggle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BBE5 RID: 48101 RVA: 0x00057A6B File Offset: 0x00055C6B
		public FocusLostPauseToggle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040080C1 RID: 32961
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0;

		// Token: 0x040080C2 RID: 32962
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0;

		// Token: 0x040080C3 RID: 32963
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Boolean_0;

		// Token: 0x040080C4 RID: 32964
		private static readonly IntPtr NativeMethodInfoPtr_Redraw_Private_Void_0;

		// Token: 0x040080C5 RID: 32965
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
