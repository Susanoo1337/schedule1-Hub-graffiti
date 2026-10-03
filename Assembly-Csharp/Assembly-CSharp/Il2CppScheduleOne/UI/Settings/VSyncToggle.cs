using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x020007A0 RID: 1952
	public class VSyncToggle : SettingsToggle
	{
		// Token: 0x0600BCA2 RID: 48290 RVA: 0x00306CB0 File Offset: 0x00304EB0
		// Note: this type is marked as 'beforefieldinit'.
		static VSyncToggle()
		{
			Il2CppClassPointerStore<VSyncToggle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "VSyncToggle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VSyncToggle>.NativeClassPtr);
			VSyncToggle.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VSyncToggle>.NativeClassPtr, 100687913);
			VSyncToggle.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VSyncToggle>.NativeClassPtr, 100687914);
			VSyncToggle.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VSyncToggle>.NativeClassPtr, 100687915);
			VSyncToggle.NativeMethodInfoPtr_Redraw_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VSyncToggle>.NativeClassPtr, 100687916);
			VSyncToggle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VSyncToggle>.NativeClassPtr, 100687917);
		}

		// Token: 0x0600BCA3 RID: 48291 RVA: 0x00306D44 File Offset: 0x00304F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314357, XrefRangeEnd = 314386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VSyncToggle.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BCA4 RID: 48292 RVA: 0x00306D80 File Offset: 0x00304F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314386, XrefRangeEnd = 314412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VSyncToggle.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BCA5 RID: 48293 RVA: 0x00306DBC File Offset: 0x00304FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314412, XrefRangeEnd = 314421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValueChanged(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VSyncToggle.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BCA6 RID: 48294 RVA: 0x00306E08 File Offset: 0x00305008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314421, XrefRangeEnd = 314427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Redraw()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VSyncToggle.NativeMethodInfoPtr_Redraw_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BCA7 RID: 48295 RVA: 0x00306E3C File Offset: 0x0030503C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VSyncToggle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VSyncToggle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VSyncToggle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BCA8 RID: 48296 RVA: 0x00057DC2 File Offset: 0x00055FC2
		public VSyncToggle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04008141 RID: 33089
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0;

		// Token: 0x04008142 RID: 33090
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0;

		// Token: 0x04008143 RID: 33091
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04008144 RID: 33092
		private static readonly IntPtr NativeMethodInfoPtr_Redraw_Private_Void_0;

		// Token: 0x04008145 RID: 33093
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
