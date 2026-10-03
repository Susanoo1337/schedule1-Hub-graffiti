using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x0200079E RID: 1950
	public class TargetFPSSlider : SettingsSlider
	{
		// Token: 0x0600BC97 RID: 48279 RVA: 0x00306A00 File Offset: 0x00304C00
		// Note: this type is marked as 'beforefieldinit'.
		static TargetFPSSlider()
		{
			Il2CppClassPointerStore<TargetFPSSlider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "TargetFPSSlider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetFPSSlider>.NativeClassPtr);
			TargetFPSSlider.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetFPSSlider>.NativeClassPtr, 100687906);
			TargetFPSSlider.NativeMethodInfoPtr_OnDragEnd_Protected_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetFPSSlider>.NativeClassPtr, 100687907);
			TargetFPSSlider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetFPSSlider>.NativeClassPtr, 100687908);
		}

		// Token: 0x0600BC98 RID: 48280 RVA: 0x00306A6C File Offset: 0x00304C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314319, XrefRangeEnd = 314325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TargetFPSSlider.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BC99 RID: 48281 RVA: 0x00306AA8 File Offset: 0x00304CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314325, XrefRangeEnd = 314335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDragEnd(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TargetFPSSlider.NativeMethodInfoPtr_OnDragEnd_Protected_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BC9A RID: 48282 RVA: 0x00306AF4 File Offset: 0x00304CF4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 313838, RefRangeEnd = 313842, XrefRangeStart = 313838, XrefRangeEnd = 313842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TargetFPSSlider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetFPSSlider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetFPSSlider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BC9B RID: 48283 RVA: 0x00057DB0 File Offset: 0x00055FB0
		public TargetFPSSlider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400813A RID: 33082
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0;

		// Token: 0x0400813B RID: 33083
		private static readonly IntPtr NativeMethodInfoPtr_OnDragEnd_Protected_Virtual_Void_Single_0;

		// Token: 0x0400813C RID: 33084
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
