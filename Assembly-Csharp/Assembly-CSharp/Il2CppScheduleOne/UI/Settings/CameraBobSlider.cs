using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x02000788 RID: 1928
	public class CameraBobSlider : SettingsSlider
	{
		// Token: 0x0600BBBE RID: 48062 RVA: 0x00303A38 File Offset: 0x00301C38
		// Note: this type is marked as 'beforefieldinit'.
		static CameraBobSlider()
		{
			Il2CppClassPointerStore<CameraBobSlider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "CameraBobSlider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraBobSlider>.NativeClassPtr);
			CameraBobSlider.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraBobSlider>.NativeClassPtr, 100687784);
			CameraBobSlider.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraBobSlider>.NativeClassPtr, 100687785);
			CameraBobSlider.NativeMethodInfoPtr_OnDragEnd_Protected_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraBobSlider>.NativeClassPtr, 100687786);
			CameraBobSlider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraBobSlider>.NativeClassPtr, 100687787);
		}

		// Token: 0x0600BBBF RID: 48063 RVA: 0x00303AB8 File Offset: 0x00301CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313227, XrefRangeEnd = 313233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CameraBobSlider.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BBC0 RID: 48064 RVA: 0x00303AF4 File Offset: 0x00301CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313233, XrefRangeEnd = 313234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValueChanged(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CameraBobSlider.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BBC1 RID: 48065 RVA: 0x00303B40 File Offset: 0x00301D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313234, XrefRangeEnd = 313244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDragEnd(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CameraBobSlider.NativeMethodInfoPtr_OnDragEnd_Protected_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BBC2 RID: 48066 RVA: 0x00303B8C File Offset: 0x00301D8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313244, XrefRangeEnd = 313245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraBobSlider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraBobSlider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraBobSlider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BBC3 RID: 48067 RVA: 0x000579D2 File Offset: 0x00055BD2
		public CameraBobSlider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040080AB RID: 32939
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x040080AC RID: 32940
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0;

		// Token: 0x040080AD RID: 32941
		private static readonly IntPtr NativeMethodInfoPtr_OnDragEnd_Protected_Virtual_Void_Single_0;

		// Token: 0x040080AE RID: 32942
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
