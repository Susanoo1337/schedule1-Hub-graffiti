using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x020001CC RID: 460
	public class PropertyLoader : Loader
	{
		// Token: 0x06002C68 RID: 11368 RVA: 0x0010E840 File Offset: 0x0010CA40
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyLoader()
		{
			Il2CppClassPointerStore<PropertyLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "PropertyLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyLoader>.NativeClassPtr);
			PropertyLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyLoader>.NativeClassPtr, 100669052);
			PropertyLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyLoader>.NativeClassPtr, 100669053);
			PropertyLoader.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_PropertyData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyLoader>.NativeClassPtr, 100669054);
		}

		// Token: 0x06002C69 RID: 11369 RVA: 0x0010E8AC File Offset: 0x0010CAAC
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C6A RID: 11370 RVA: 0x0010E8E8 File Offset: 0x0010CAE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 129419, RefRangeEnd = 129420, XrefRangeStart = 129258, XrefRangeEnd = 129419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C6B RID: 11371 RVA: 0x0010E938 File Offset: 0x0010CB38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129420, XrefRangeEnd = 129522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Load(PropertyData propertyData, string propertDataString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(propertyData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propertDataString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyLoader.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_PropertyData_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C6C RID: 11372 RVA: 0x00016DA2 File Offset: 0x00014FA2
		public PropertyLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001E80 RID: 7808
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E81 RID: 7809
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;

		// Token: 0x04001E82 RID: 7810
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_New_Void_PropertyData_String_0;

		// Token: 0x020009BC RID: 2492
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.PropertyLoader+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x0600DB96 RID: 56214 RVA: 0x00365AB0 File Offset: 0x00363CB0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<PropertyLoader.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyLoader>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyLoader.__c__DisplayClass1_0>.NativeClassPtr);
				PropertyLoader.__c__DisplayClass1_0.NativeFieldInfoPtr_objectPriorities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyLoader.__c__DisplayClass1_0>.NativeClassPtr, "objectPriorities");
				PropertyLoader.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyLoader.__c__DisplayClass1_0>.NativeClassPtr, 100669055);
				PropertyLoader.__c__DisplayClass1_0.NativeMethodInfoPtr__Load_b__0_Internal_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyLoader.__c__DisplayClass1_0>.NativeClassPtr, 100669056);
			}

			// Token: 0x0600DB97 RID: 56215 RVA: 0x00365B18 File Offset: 0x00363D18
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyLoader.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyLoader.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB98 RID: 56216 RVA: 0x00365B54 File Offset: 0x00363D54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129250, XrefRangeEnd = 129254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Load_b__0(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyLoader.__c__DisplayClass1_0.NativeMethodInfoPtr__Load_b__0_Internal_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB99 RID: 56217 RVA: 0x000673F8 File Offset: 0x000655F8
			public __c__DisplayClass1_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042FE RID: 17150
			// (get) Token: 0x0600DB9A RID: 56218 RVA: 0x00365BA4 File Offset: 0x00363DA4
			// (set) Token: 0x0600DB9B RID: 56219 RVA: 0x00067401 File Offset: 0x00065601
			public unsafe Dictionary<string, int> objectPriorities
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyLoader.__c__DisplayClass1_0.NativeFieldInfoPtr_objectPriorities);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyLoader.__c__DisplayClass1_0.NativeFieldInfoPtr_objectPriorities), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040095F7 RID: 38391
			private static readonly IntPtr NativeFieldInfoPtr_objectPriorities;

			// Token: 0x040095F8 RID: 38392
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040095F9 RID: 38393
			private static readonly IntPtr NativeMethodInfoPtr__Load_b__0_Internal_Int32_String_0;
		}

		// Token: 0x020009BD RID: 2493
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.PropertyLoader+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x0600DB9C RID: 56220 RVA: 0x00365BD4 File Offset: 0x00363DD4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<PropertyLoader.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyLoader>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyLoader.__c__DisplayClass2_0>.NativeClassPtr);
				PropertyLoader.__c__DisplayClass2_0.NativeFieldInfoPtr_objectLoaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyLoader.__c__DisplayClass2_0>.NativeClassPtr, "objectLoaders");
				PropertyLoader.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyLoader.__c__DisplayClass2_0>.NativeClassPtr, 100669057);
				PropertyLoader.__c__DisplayClass2_0.NativeMethodInfoPtr__Load_b__0_Internal_Int32_DynamicSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyLoader.__c__DisplayClass2_0>.NativeClassPtr, 100669058);
			}

			// Token: 0x0600DB9D RID: 56221 RVA: 0x00365C3C File Offset: 0x00363E3C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyLoader.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyLoader.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB9E RID: 56222 RVA: 0x00365C78 File Offset: 0x00363E78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129254, XrefRangeEnd = 129258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Load_b__0(DynamicSaveData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyLoader.__c__DisplayClass2_0.NativeMethodInfoPtr__Load_b__0_Internal_Int32_DynamicSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB9F RID: 56223 RVA: 0x00067420 File Offset: 0x00065620
			public __c__DisplayClass2_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042FF RID: 17151
			// (get) Token: 0x0600DBA0 RID: 56224 RVA: 0x00365CC8 File Offset: 0x00363EC8
			// (set) Token: 0x0600DBA1 RID: 56225 RVA: 0x00067429 File Offset: 0x00065629
			public unsafe Dictionary<DynamicSaveData, BuildableItemLoader> objectLoaders
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyLoader.__c__DisplayClass2_0.NativeFieldInfoPtr_objectLoaders);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<DynamicSaveData, BuildableItemLoader>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyLoader.__c__DisplayClass2_0.NativeFieldInfoPtr_objectLoaders), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040095FA RID: 38394
			private static readonly IntPtr NativeFieldInfoPtr_objectLoaders;

			// Token: 0x040095FB RID: 38395
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040095FC RID: 38396
			private static readonly IntPtr NativeMethodInfoPtr__Load_b__0_Internal_Int32_DynamicSaveData_0;
		}
	}
}
