using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Core.Settings.Framework;
using Il2CppSystem;

namespace Il2CppScheduleOne.Configuration
{
	// Token: 0x02000423 RID: 1059
	public class Configuration<T> : BaseConfiguration where T : Settings
	{
		// Token: 0x06005DA1 RID: 23969 RVA: 0x001BDD30 File Offset: 0x001BBF30
		// Note: this type is marked as 'beforefieldinit'.
		static Configuration()
		{
			Il2CppClassPointerStore<Configuration<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Configuration", "Configuration`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Configuration<T>>.NativeClassPtr);
			Configuration<T>.NativeFieldInfoPtr__Settings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Configuration<T>>.NativeClassPtr, "<Settings>k__BackingField");
			Configuration<T>.NativeFieldInfoPtr__DefaultSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Configuration<T>>.NativeClassPtr, "<DefaultSettings>k__BackingField");
			Configuration<T>.NativeMethodInfoPtr_get_Settings_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Configuration<T>>.NativeClassPtr, 100675519);
			Configuration<T>.NativeMethodInfoPtr_set_Settings_Private_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Configuration<T>>.NativeClassPtr, 100675520);
			Configuration<T>.NativeMethodInfoPtr_get_DefaultSettings_Private_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Configuration<T>>.NativeClassPtr, 100675521);
			Configuration<T>.NativeMethodInfoPtr_set_DefaultSettings_Private_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Configuration<T>>.NativeClassPtr, 100675522);
			Configuration<T>.NativeMethodInfoPtr_ValidateConfiguration_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Configuration<T>>.NativeClassPtr, 100675523);
			Configuration<T>.NativeMethodInfoPtr_ResetConfigurationToDefault_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Configuration<T>>.NativeClassPtr, 100675524);
			Configuration<T>.NativeMethodInfoPtr_GetSettings_Public_Virtual_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Configuration<T>>.NativeClassPtr, 100675525);
			Configuration<T>.NativeMethodInfoPtr_ApplySettings_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Configuration<T>>.NativeClassPtr, 100675526);
			Configuration<T>.NativeMethodInfoPtr_ApplyOverwrites_Private_Static_Void_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Configuration<T>>.NativeClassPtr, 100675527);
			Configuration<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Configuration<T>>.NativeClassPtr, 100675528);
		}

		// Token: 0x17001CF1 RID: 7409
		// (get) Token: 0x06005DA2 RID: 23970 RVA: 0x001BDE8C File Offset: 0x001BC08C
		// (set) Token: 0x06005DA3 RID: 23971 RVA: 0x001BDEC8 File Offset: 0x001BC0C8
		public unsafe T Settings
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Configuration<T>.NativeMethodInfoPtr_get_Settings_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				IntPtr* ptr2 = ptr;
				T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					if (!(t is string))
					{
						ref T ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
						if (ref ptr3 != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref value;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Configuration<T>.NativeMethodInfoPtr_set_Settings_Private_set_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001CF2 RID: 7410
		// (get) Token: 0x06005DA4 RID: 23972 RVA: 0x001BDF58 File Offset: 0x001BC158
		// (set) Token: 0x06005DA5 RID: 23973 RVA: 0x001BDF94 File Offset: 0x001BC194
		public unsafe T DefaultSettings
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Configuration<T>.NativeMethodInfoPtr_get_DefaultSettings_Private_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				IntPtr* ptr2 = ptr;
				T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					if (!(t is string))
					{
						ref T ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
						if (ref ptr3 != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref value;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Configuration<T>.NativeMethodInfoPtr_set_DefaultSettings_Private_set_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005DA6 RID: 23974 RVA: 0x001BE024 File Offset: 0x001BC224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199909, XrefRangeEnd = 199943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ValidateConfiguration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Configuration<T>.NativeMethodInfoPtr_ValidateConfiguration_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DA7 RID: 23975 RVA: 0x001BE060 File Offset: 0x001BC260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199943, XrefRangeEnd = 199949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ResetConfigurationToDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Configuration<T>.NativeMethodInfoPtr_ResetConfigurationToDefault_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DA8 RID: 23976 RVA: 0x001BE09C File Offset: 0x001BC29C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Settings GetSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Configuration<T>.NativeMethodInfoPtr_GetSettings_Public_Virtual_Settings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Settings>(intPtr3) : null;
		}

		// Token: 0x06005DA9 RID: 23977 RVA: 0x001BE0E8 File Offset: 0x001BC2E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199949, XrefRangeEnd = 199956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplySettings(T newSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = newSettings;
				if (!(t is string))
				{
					ref T ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
					if (ref ptr3 != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr4 = ref newSettings;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Configuration<T>.NativeMethodInfoPtr_ApplySettings_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DAA RID: 23978 RVA: 0x001BE178 File Offset: 0x001BC378
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 199971, RefRangeEnd = 199972, XrefRangeStart = 199956, XrefRangeEnd = 199971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ApplyOverwrites(T from, T to)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = from;
				if (!(t is string))
				{
					ref T ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
					if (ref ptr3 != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr4 = ref from;
			}
			*ptr2 = ref ptr4;
			IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			T ptr7;
			if (!typeof(T).IsValueType)
			{
				T t2 = to;
				if (!(t2 is string))
				{
					ref T ptr6 = ptr7 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase);
					if (ref ptr6 != null)
					{
						ptr7 = ref ptr6;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr6)))
						{
							ptr7 = IL2CPP.il2cpp_object_unbox(ref ptr6);
						}
					}
				}
				else
				{
					ptr7 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
				}
			}
			else
			{
				ptr7 = ref to;
			}
			*ptr5 = ref ptr7;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Configuration<T>.NativeMethodInfoPtr_ApplyOverwrites_Private_Static_Void_T_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DAB RID: 23979 RVA: 0x001BE258 File Offset: 0x001BC458
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 199973, RefRangeEnd = 199979, XrefRangeStart = 199972, XrefRangeEnd = 199973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Configuration() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Configuration<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Configuration<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DAC RID: 23980 RVA: 0x0002C6B8 File Offset: 0x0002A8B8
		public Configuration(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CEF RID: 7407
		// (get) Token: 0x06005DAD RID: 23981 RVA: 0x001BE294 File Offset: 0x001BC494
		// (set) Token: 0x06005DAE RID: 23982 RVA: 0x001BE2BC File Offset: 0x001BC4BC
		public unsafe T _Settings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Configuration<T>.NativeFieldInfoPtr__Settings_k__BackingField);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Configuration<T>.NativeFieldInfoPtr__Settings_k__BackingField);
				Type typeFromHandle = typeof(T);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase);
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x17001CF0 RID: 7408
		// (get) Token: 0x06005DAF RID: 23983 RVA: 0x001BE364 File Offset: 0x001BC564
		// (set) Token: 0x06005DB0 RID: 23984 RVA: 0x001BE38C File Offset: 0x001BC58C
		public unsafe T _DefaultSettings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Configuration<T>.NativeFieldInfoPtr__DefaultSettings_k__BackingField);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Configuration<T>.NativeFieldInfoPtr__DefaultSettings_k__BackingField);
				Type typeFromHandle = typeof(T);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase);
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x04004036 RID: 16438
		private static readonly IntPtr NativeFieldInfoPtr__Settings_k__BackingField;

		// Token: 0x04004037 RID: 16439
		private static readonly IntPtr NativeFieldInfoPtr__DefaultSettings_k__BackingField;

		// Token: 0x04004038 RID: 16440
		private static readonly IntPtr NativeMethodInfoPtr_get_Settings_Public_get_T_0;

		// Token: 0x04004039 RID: 16441
		private static readonly IntPtr NativeMethodInfoPtr_set_Settings_Private_set_Void_T_0;

		// Token: 0x0400403A RID: 16442
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultSettings_Private_get_T_0;

		// Token: 0x0400403B RID: 16443
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultSettings_Private_set_Void_T_0;

		// Token: 0x0400403C RID: 16444
		private static readonly IntPtr NativeMethodInfoPtr_ValidateConfiguration_Public_Virtual_Void_0;

		// Token: 0x0400403D RID: 16445
		private static readonly IntPtr NativeMethodInfoPtr_ResetConfigurationToDefault_Public_Virtual_Void_0;

		// Token: 0x0400403E RID: 16446
		private static readonly IntPtr NativeMethodInfoPtr_GetSettings_Public_Virtual_Settings_0;

		// Token: 0x0400403F RID: 16447
		private static readonly IntPtr NativeMethodInfoPtr_ApplySettings_Public_Void_T_0;

		// Token: 0x04004040 RID: 16448
		private static readonly IntPtr NativeMethodInfoPtr_ApplyOverwrites_Private_Static_Void_T_T_0;

		// Token: 0x04004041 RID: 16449
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000B0B RID: 2827
		[ObfuscatedName("ScheduleOne.Configuration.Configuration`1+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Object
		{
			// Token: 0x0600E5B6 RID: 58806 RVA: 0x00381C44 File Offset: 0x0037FE44
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<Configuration<T>.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Configuration<T>>.NativeClassPtr, "<>c__DisplayClass12_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Configuration<T>.__c__DisplayClass12_0>.NativeClassPtr);
				Configuration<T>.__c__DisplayClass12_0.NativeFieldInfoPtr_toObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Configuration<T>.__c__DisplayClass12_0>.NativeClassPtr, "toObj");
				Configuration<T>.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Configuration<T>.__c__DisplayClass12_0>.NativeClassPtr, 100675529);
				Configuration<T>.__c__DisplayClass12_0.NativeMethodInfoPtr__ApplyOverwrites_b__0_Internal_Boolean_SettingsObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Configuration<T>.__c__DisplayClass12_0>.NativeClassPtr, 100675530);
			}

			// Token: 0x0600E5B7 RID: 58807 RVA: 0x00381CE8 File Offset: 0x0037FEE8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Configuration<T>.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Configuration<T>.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E5B8 RID: 58808 RVA: 0x00381D24 File Offset: 0x0037FF24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199901, XrefRangeEnd = 199903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ApplyOverwrites_b__0(SettingsObject obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Configuration<T>.__c__DisplayClass12_0.NativeMethodInfoPtr__ApplyOverwrites_b__0_Internal_Boolean_SettingsObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E5B9 RID: 58809 RVA: 0x0006C525 File Offset: 0x0006A725
			public __c__DisplayClass12_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045C5 RID: 17861
			// (get) Token: 0x0600E5BA RID: 58810 RVA: 0x00381D74 File Offset: 0x0037FF74
			// (set) Token: 0x0600E5BB RID: 58811 RVA: 0x0006C52E File Offset: 0x0006A72E
			public unsafe SettingsObject toObj
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Configuration<T>.__c__DisplayClass12_0.NativeFieldInfoPtr_toObj);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SettingsObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Configuration<T>.__c__DisplayClass12_0.NativeFieldInfoPtr_toObj), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009BE4 RID: 39908
			private static readonly IntPtr NativeFieldInfoPtr_toObj;

			// Token: 0x04009BE5 RID: 39909
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009BE6 RID: 39910
			private static readonly IntPtr NativeMethodInfoPtr__ApplyOverwrites_b__0_Internal_Boolean_SettingsObject_0;
		}

		// Token: 0x02000B0C RID: 2828
		[ObfuscatedName("ScheduleOne.Configuration.Configuration`1+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x0600E5BC RID: 58812 RVA: 0x00381DA4 File Offset: 0x0037FFA4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<Configuration<T>.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Configuration<T>>.NativeClassPtr, "<>c__DisplayClass8_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Configuration<T>.__c__DisplayClass8_0>.NativeClassPtr);
				Configuration<T>.__c__DisplayClass8_0.NativeFieldInfoPtr_settingsObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Configuration<T>.__c__DisplayClass8_0>.NativeClassPtr, "settingsObjects");
				Configuration<T>.__c__DisplayClass8_0.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Configuration<T>.__c__DisplayClass8_0>.NativeClassPtr, "i");
				Configuration<T>.__c__DisplayClass8_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Configuration<T>.__c__DisplayClass8_0>.NativeClassPtr, "<>9__0");
				Configuration<T>.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Configuration<T>.__c__DisplayClass8_0>.NativeClassPtr, 100675531);
				Configuration<T>.__c__DisplayClass8_0.NativeMethodInfoPtr__ValidateConfiguration_b__0_Internal_Boolean_SettingsObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Configuration<T>.__c__DisplayClass8_0>.NativeClassPtr, 100675532);
			}

			// Token: 0x0600E5BD RID: 58813 RVA: 0x00381E70 File Offset: 0x00380070
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Configuration<T>.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Configuration<T>.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E5BE RID: 58814 RVA: 0x00381EAC File Offset: 0x003800AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199903, XrefRangeEnd = 199909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ValidateConfiguration_b__0(SettingsObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Configuration<T>.__c__DisplayClass8_0.NativeMethodInfoPtr__ValidateConfiguration_b__0_Internal_Boolean_SettingsObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E5BF RID: 58815 RVA: 0x0006C54D File Offset: 0x0006A74D
			public __c__DisplayClass8_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045C6 RID: 17862
			// (get) Token: 0x0600E5C0 RID: 58816 RVA: 0x00381EFC File Offset: 0x003800FC
			// (set) Token: 0x0600E5C1 RID: 58817 RVA: 0x0006C556 File Offset: 0x0006A756
			public unsafe Il2CppReferenceArray<SettingsObject> settingsObjects
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Configuration<T>.__c__DisplayClass8_0.NativeFieldInfoPtr_settingsObjects);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SettingsObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Configuration<T>.__c__DisplayClass8_0.NativeFieldInfoPtr_settingsObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045C7 RID: 17863
			// (get) Token: 0x0600E5C2 RID: 58818 RVA: 0x00381F2C File Offset: 0x0038012C
			// (set) Token: 0x0600E5C3 RID: 58819 RVA: 0x0006C575 File Offset: 0x0006A775
			public unsafe int i
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Configuration<T>.__c__DisplayClass8_0.NativeFieldInfoPtr_i);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Configuration<T>.__c__DisplayClass8_0.NativeFieldInfoPtr_i)) = value;
				}
			}

			// Token: 0x170045C8 RID: 17864
			// (get) Token: 0x0600E5C4 RID: 58820 RVA: 0x00381F54 File Offset: 0x00380154
			// (set) Token: 0x0600E5C5 RID: 58821 RVA: 0x0006C590 File Offset: 0x0006A790
			public unsafe Func<SettingsObject, bool> __9__0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Configuration<T>.__c__DisplayClass8_0.NativeFieldInfoPtr___9__0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SettingsObject, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Configuration<T>.__c__DisplayClass8_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009BE7 RID: 39911
			private static readonly IntPtr NativeFieldInfoPtr_settingsObjects;

			// Token: 0x04009BE8 RID: 39912
			private static readonly IntPtr NativeFieldInfoPtr_i;

			// Token: 0x04009BE9 RID: 39913
			private static readonly IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x04009BEA RID: 39914
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009BEB RID: 39915
			private static readonly IntPtr NativeMethodInfoPtr__ValidateConfiguration_b__0_Internal_Boolean_SettingsObject_0;
		}
	}
}
