using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Il2CppScheduleOne.Configuration
{
	// Token: 0x02000424 RID: 1060
	public class ConfigurationService : PersistentSingleton<ConfigurationService>
	{
		// Token: 0x06005DB1 RID: 23985 RVA: 0x001BE434 File Offset: 0x001BC634
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigurationService()
		{
			Il2CppClassPointerStore<ConfigurationService>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Configuration", "ConfigurationService");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigurationService>.NativeClassPtr);
			ConfigurationService.NativeFieldInfoPtr__configurations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationService>.NativeClassPtr, "_configurations");
			ConfigurationService.NativeMethodInfoPtr_get_Configurations_Public_get_Il2CppReferenceArray_1_BaseConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationService>.NativeClassPtr, 100675533);
			ConfigurationService.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationService>.NativeClassPtr, 100675534);
			ConfigurationService.NativeMethodInfoPtr_ResetConfigurations_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationService>.NativeClassPtr, 100675535);
			ConfigurationService.NativeMethodInfoPtr_TryGetConfiguration_Public_Boolean_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationService>.NativeClassPtr, 100675536);
			ConfigurationService.NativeMethodInfoPtr_TryGetConfiguration_Public_Boolean_String_byref_BaseConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationService>.NativeClassPtr, 100675537);
			ConfigurationService.NativeMethodInfoPtr_GetConfigurationAndListenForChanges_Public_Void_Action_1_BaseConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationService>.NativeClassPtr, 100675538);
			ConfigurationService.NativeMethodInfoPtr_UnsubscribeFromConfigurationChanges_Public_Void_Action_1_BaseConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationService>.NativeClassPtr, 100675539);
			ConfigurationService.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationService>.NativeClassPtr, 100675540);
		}

		// Token: 0x17001CF4 RID: 7412
		// (get) Token: 0x06005DB2 RID: 23986 RVA: 0x001BE518 File Offset: 0x001BC718
		public unsafe Il2CppReferenceArray<BaseConfiguration> Configurations
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationService.NativeMethodInfoPtr_get_Configurations_Public_get_Il2CppReferenceArray_1_BaseConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BaseConfiguration>>(intPtr3) : null;
			}
		}

		// Token: 0x06005DB3 RID: 23987 RVA: 0x001BE558 File Offset: 0x001BC758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199982, XrefRangeEnd = 199986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigurationService.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DB4 RID: 23988 RVA: 0x001BE594 File Offset: 0x001BC794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199986, XrefRangeEnd = 199987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetConfigurations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationService.NativeMethodInfoPtr_ResetConfigurations_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DB5 RID: 23989 RVA: 0x001BE5C8 File Offset: 0x001BC7C8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 199994, RefRangeEnd = 200000, XrefRangeStart = 199987, XrefRangeEnd = 199994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetConfiguration<T>(out T configuration) where T : BaseConfiguration
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref configuration;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ConfigurationService.MethodInfoStoreGeneric_TryGetConfiguration_Public_Boolean_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				configuration = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06005DB6 RID: 23990 RVA: 0x001BE654 File Offset: 0x001BC854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200000, XrefRangeEnd = 200020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetConfiguration(string configurationName, out BaseConfiguration configuration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(configurationName);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ConfigurationService.NativeMethodInfoPtr_TryGetConfiguration_Public_Boolean_String_byref_BaseConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			configuration = ((intPtr4 == 0) ? null : new BaseConfiguration(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005DB7 RID: 23991 RVA: 0x001BE6C4 File Offset: 0x001BC8C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 200036, RefRangeEnd = 200039, XrefRangeStart = 200020, XrefRangeEnd = 200036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetConfigurationAndListenForChanges<T>(Action<BaseConfiguration> onConfigChanged) where T : BaseConfiguration
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onConfigChanged);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationService.MethodInfoStoreGeneric_GetConfigurationAndListenForChanges_Public_Void_Action_1_BaseConfiguration_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DB8 RID: 23992 RVA: 0x001BE708 File Offset: 0x001BC908
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 200055, RefRangeEnd = 200056, XrefRangeStart = 200039, XrefRangeEnd = 200055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnsubscribeFromConfigurationChanges<T>(Action<BaseConfiguration> onConfigChanged) where T : BaseConfiguration
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onConfigChanged);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationService.MethodInfoStoreGeneric_UnsubscribeFromConfigurationChanges_Public_Void_Action_1_BaseConfiguration_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DB9 RID: 23993 RVA: 0x001BE74C File Offset: 0x001BC94C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200056, XrefRangeEnd = 200059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigurationService() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigurationService>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationService.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DBA RID: 23994 RVA: 0x0002C6C1 File Offset: 0x0002A8C1
		public ConfigurationService(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CF3 RID: 7411
		// (get) Token: 0x06005DBB RID: 23995 RVA: 0x001BE788 File Offset: 0x001BC988
		// (set) Token: 0x06005DBC RID: 23996 RVA: 0x0002C6CA File Offset: 0x0002A8CA
		public unsafe Il2CppReferenceArray<BaseConfiguration> _configurations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationService.NativeFieldInfoPtr__configurations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BaseConfiguration>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationService.NativeFieldInfoPtr__configurations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004042 RID: 16450
		private static readonly IntPtr NativeFieldInfoPtr__configurations;

		// Token: 0x04004043 RID: 16451
		private static readonly IntPtr NativeMethodInfoPtr_get_Configurations_Public_get_Il2CppReferenceArray_1_BaseConfiguration_0;

		// Token: 0x04004044 RID: 16452
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04004045 RID: 16453
		private static readonly IntPtr NativeMethodInfoPtr_ResetConfigurations_Private_Void_0;

		// Token: 0x04004046 RID: 16454
		private static readonly IntPtr NativeMethodInfoPtr_TryGetConfiguration_Public_Boolean_byref_T_0;

		// Token: 0x04004047 RID: 16455
		private static readonly IntPtr NativeMethodInfoPtr_TryGetConfiguration_Public_Boolean_String_byref_BaseConfiguration_0;

		// Token: 0x04004048 RID: 16456
		private static readonly IntPtr NativeMethodInfoPtr_GetConfigurationAndListenForChanges_Public_Void_Action_1_BaseConfiguration_0;

		// Token: 0x04004049 RID: 16457
		private static readonly IntPtr NativeMethodInfoPtr_UnsubscribeFromConfigurationChanges_Public_Void_Action_1_BaseConfiguration_0;

		// Token: 0x0400404A RID: 16458
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B0D RID: 2829
		[ObfuscatedName("ScheduleOne.Configuration.ConfigurationService+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x0600E5C6 RID: 58822 RVA: 0x00381F84 File Offset: 0x00380184
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<ConfigurationService.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfigurationService>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigurationService.__c__DisplayClass6_0>.NativeClassPtr);
				ConfigurationService.__c__DisplayClass6_0.NativeFieldInfoPtr_configurationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationService.__c__DisplayClass6_0>.NativeClassPtr, "configurationName");
				ConfigurationService.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationService.__c__DisplayClass6_0>.NativeClassPtr, 100675541);
				ConfigurationService.__c__DisplayClass6_0.NativeMethodInfoPtr__TryGetConfiguration_b__0_Internal_Boolean_BaseConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationService.__c__DisplayClass6_0>.NativeClassPtr, 100675542);
			}

			// Token: 0x0600E5C7 RID: 58823 RVA: 0x00381FEC File Offset: 0x003801EC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigurationService.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationService.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E5C8 RID: 58824 RVA: 0x00382028 File Offset: 0x00380228
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199979, XrefRangeEnd = 199982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TryGetConfiguration_b__0(BaseConfiguration config)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(config);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationService.__c__DisplayClass6_0.NativeMethodInfoPtr__TryGetConfiguration_b__0_Internal_Boolean_BaseConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E5C9 RID: 58825 RVA: 0x0006C5AF File Offset: 0x0006A7AF
			public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045C9 RID: 17865
			// (get) Token: 0x0600E5CA RID: 58826 RVA: 0x00382078 File Offset: 0x00380278
			// (set) Token: 0x0600E5CB RID: 58827 RVA: 0x0006C5B8 File Offset: 0x0006A7B8
			public unsafe string configurationName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationService.__c__DisplayClass6_0.NativeFieldInfoPtr_configurationName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationService.__c__DisplayClass6_0.NativeFieldInfoPtr_configurationName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009BEC RID: 39916
			private static readonly IntPtr NativeFieldInfoPtr_configurationName;

			// Token: 0x04009BED RID: 39917
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009BEE RID: 39918
			private static readonly IntPtr NativeMethodInfoPtr__TryGetConfiguration_b__0_Internal_Boolean_BaseConfiguration_0;
		}

		// Token: 0x02000B0E RID: 2830
		private sealed class MethodInfoStoreGeneric_TryGetConfiguration_Public_Boolean_byref_T_0<T>
		{
			// Token: 0x04009BEF RID: 39919
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ConfigurationService.NativeMethodInfoPtr_TryGetConfiguration_Public_Boolean_byref_T_0, Il2CppClassPointerStore<ConfigurationService>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000B0F RID: 2831
		private sealed class MethodInfoStoreGeneric_GetConfigurationAndListenForChanges_Public_Void_Action_1_BaseConfiguration_0<T>
		{
			// Token: 0x04009BF0 RID: 39920
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ConfigurationService.NativeMethodInfoPtr_GetConfigurationAndListenForChanges_Public_Void_Action_1_BaseConfiguration_0, Il2CppClassPointerStore<ConfigurationService>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000B10 RID: 2832
		private sealed class MethodInfoStoreGeneric_UnsubscribeFromConfigurationChanges_Public_Void_Action_1_BaseConfiguration_0<T>
		{
			// Token: 0x04009BF1 RID: 39921
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ConfigurationService.NativeMethodInfoPtr_UnsubscribeFromConfigurationChanges_Public_Void_Action_1_BaseConfiguration_0, Il2CppClassPointerStore<ConfigurationService>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
