using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Core.Settings.Framework;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Configuration
{
	// Token: 0x02000422 RID: 1058
	public class BaseConfiguration : ScriptableObject
	{
		// Token: 0x06005D99 RID: 23961 RVA: 0x001BDB6C File Offset: 0x001BBD6C
		// Note: this type is marked as 'beforefieldinit'.
		static BaseConfiguration()
		{
			Il2CppClassPointerStore<BaseConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Configuration", "BaseConfiguration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseConfiguration>.NativeClassPtr);
			BaseConfiguration.NativeFieldInfoPtr_OnConfigurationChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseConfiguration>.NativeClassPtr, "OnConfigurationChanged");
			BaseConfiguration.NativeMethodInfoPtr_ResetConfigurationToDefault_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseConfiguration>.NativeClassPtr, 100675515);
			BaseConfiguration.NativeMethodInfoPtr_ValidateConfiguration_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseConfiguration>.NativeClassPtr, 100675516);
			BaseConfiguration.NativeMethodInfoPtr_GetSettings_Public_Abstract_Virtual_New_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseConfiguration>.NativeClassPtr, 100675517);
			BaseConfiguration.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseConfiguration>.NativeClassPtr, 100675518);
		}

		// Token: 0x06005D9A RID: 23962 RVA: 0x001BDC00 File Offset: 0x001BBE00
		[CallerCount(0)]
		public unsafe virtual void ResetConfigurationToDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseConfiguration.NativeMethodInfoPtr_ResetConfigurationToDefault_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D9B RID: 23963 RVA: 0x001BDC3C File Offset: 0x001BBE3C
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ValidateConfiguration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseConfiguration.NativeMethodInfoPtr_ValidateConfiguration_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D9C RID: 23964 RVA: 0x001BDC78 File Offset: 0x001BBE78
		[CallerCount(0)]
		public unsafe virtual Settings GetSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseConfiguration.NativeMethodInfoPtr_GetSettings_Public_Abstract_Virtual_New_Settings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Settings>(intPtr3) : null;
		}

		// Token: 0x06005D9D RID: 23965 RVA: 0x001BDCC4 File Offset: 0x001BBEC4
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 79617, RefRangeEnd = 79648, XrefRangeStart = 79617, XrefRangeEnd = 79648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseConfiguration() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseConfiguration>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseConfiguration.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D9E RID: 23966 RVA: 0x0002C690 File Offset: 0x0002A890
		public BaseConfiguration(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CEE RID: 7406
		// (get) Token: 0x06005D9F RID: 23967 RVA: 0x001BDD00 File Offset: 0x001BBF00
		// (set) Token: 0x06005DA0 RID: 23968 RVA: 0x0002C699 File Offset: 0x0002A899
		public unsafe Action<BaseConfiguration> OnConfigurationChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseConfiguration.NativeFieldInfoPtr_OnConfigurationChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<BaseConfiguration>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseConfiguration.NativeFieldInfoPtr_OnConfigurationChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004031 RID: 16433
		private static readonly IntPtr NativeFieldInfoPtr_OnConfigurationChanged;

		// Token: 0x04004032 RID: 16434
		private static readonly IntPtr NativeMethodInfoPtr_ResetConfigurationToDefault_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04004033 RID: 16435
		private static readonly IntPtr NativeMethodInfoPtr_ValidateConfiguration_Public_Virtual_New_Void_0;

		// Token: 0x04004034 RID: 16436
		private static readonly IntPtr NativeMethodInfoPtr_GetSettings_Public_Abstract_Virtual_New_Settings_0;

		// Token: 0x04004035 RID: 16437
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
