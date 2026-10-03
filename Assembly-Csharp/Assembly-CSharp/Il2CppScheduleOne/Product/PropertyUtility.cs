using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Effects;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x02000563 RID: 1379
	public class PropertyUtility : Singleton<PropertyUtility>
	{
		// Token: 0x06007E3C RID: 32316 RVA: 0x0022D47C File Offset: 0x0022B67C
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyUtility()
		{
			Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "PropertyUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr);
			PropertyUtility.NativeFieldInfoPtr_PropertyDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "PropertyDatas");
			PropertyUtility.NativeFieldInfoPtr_DrugTypeDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "DrugTypeDatas");
			PropertyUtility.NativeFieldInfoPtr_AllProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "AllProperties");
			PropertyUtility.NativeFieldInfoPtr_Products = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "Products");
			PropertyUtility.NativeFieldInfoPtr_Properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "Properties");
			PropertyUtility.NativeFieldInfoPtr_PropertiesDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "PropertiesDict");
			PropertyUtility.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, 100679575);
			PropertyUtility.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, 100679576);
			PropertyUtility.NativeMethodInfoPtr_GetProperties_Public_List_1_Effect_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, 100679577);
			PropertyUtility.NativeMethodInfoPtr_GetProperties_Public_List_1_Effect_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, 100679578);
			PropertyUtility.NativeMethodInfoPtr_GetPropertyData_Public_Static_PropertyData_EProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, 100679579);
			PropertyUtility.NativeMethodInfoPtr_GetDrugTypeData_Public_Static_DrugTypeData_EDrugType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, 100679580);
			PropertyUtility.NativeMethodInfoPtr_GetOrderedPropertyColors_Public_Static_List_1_Color32_List_1_Effect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, 100679581);
			PropertyUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, 100679582);
		}

		// Token: 0x06007E3D RID: 32317 RVA: 0x0022D5C4 File Offset: 0x0022B7C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241642, XrefRangeEnd = 241662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyUtility.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E3E RID: 32318 RVA: 0x0022D600 File Offset: 0x0022B800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241662, XrefRangeEnd = 241665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyUtility.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E3F RID: 32319 RVA: 0x0022D63C File Offset: 0x0022B83C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241665, XrefRangeEnd = 241684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Effect> GetProperties(int tier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref tier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.NativeMethodInfoPtr_GetProperties_Public_List_1_Effect_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Effect>>(intPtr3) : null;
		}

		// Token: 0x06007E40 RID: 32320 RVA: 0x0022D688 File Offset: 0x0022B888
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 241752, RefRangeEnd = 241756, XrefRangeStart = 241684, XrefRangeEnd = 241752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Effect> GetProperties(List<string> ids)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ids);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.NativeMethodInfoPtr_GetProperties_Public_List_1_Effect_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Effect>>(intPtr3) : null;
		}

		// Token: 0x06007E41 RID: 32321 RVA: 0x0022D6D8 File Offset: 0x0022B8D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 241774, RefRangeEnd = 241777, XrefRangeStart = 241756, XrefRangeEnd = 241774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertyUtility.PropertyData GetPropertyData(EProperty property)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref property;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.NativeMethodInfoPtr_GetPropertyData_Public_Static_PropertyData_EProperty_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyUtility.PropertyData>(intPtr3) : null;
		}

		// Token: 0x06007E42 RID: 32322 RVA: 0x0022D718 File Offset: 0x0022B918
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 241795, RefRangeEnd = 241798, XrefRangeStart = 241777, XrefRangeEnd = 241795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertyUtility.DrugTypeData GetDrugTypeData(EDrugType drugType)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref drugType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.NativeMethodInfoPtr_GetDrugTypeData_Public_Static_DrugTypeData_EDrugType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyUtility.DrugTypeData>(intPtr3) : null;
		}

		// Token: 0x06007E43 RID: 32323 RVA: 0x0022D758 File Offset: 0x0022B958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241798, XrefRangeEnd = 241848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Color32> GetOrderedPropertyColors(List<Effect> properties)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.NativeMethodInfoPtr_GetOrderedPropertyColors_Public_Static_List_1_Color32_List_1_Effect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Color32>>(intPtr3) : null;
		}

		// Token: 0x06007E44 RID: 32324 RVA: 0x0022D79C File Offset: 0x0022B99C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241848, XrefRangeEnd = 241898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyUtility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E45 RID: 32325 RVA: 0x0003BEAA File Offset: 0x0003A0AA
		public PropertyUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026FF RID: 9983
		// (get) Token: 0x06007E46 RID: 32326 RVA: 0x0022D7D8 File Offset: 0x0022B9D8
		// (set) Token: 0x06007E47 RID: 32327 RVA: 0x0003BEB3 File Offset: 0x0003A0B3
		public unsafe List<PropertyUtility.PropertyData> PropertyDatas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_PropertyDatas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PropertyUtility.PropertyData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_PropertyDatas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002700 RID: 9984
		// (get) Token: 0x06007E48 RID: 32328 RVA: 0x0022D808 File Offset: 0x0022BA08
		// (set) Token: 0x06007E49 RID: 32329 RVA: 0x0003BED2 File Offset: 0x0003A0D2
		public unsafe List<PropertyUtility.DrugTypeData> DrugTypeDatas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_DrugTypeDatas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PropertyUtility.DrugTypeData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_DrugTypeDatas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002701 RID: 9985
		// (get) Token: 0x06007E4A RID: 32330 RVA: 0x0022D838 File Offset: 0x0022BA38
		// (set) Token: 0x06007E4B RID: 32331 RVA: 0x0003BEF1 File Offset: 0x0003A0F1
		public unsafe List<Effect> AllProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_AllProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Effect>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_AllProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002702 RID: 9986
		// (get) Token: 0x06007E4C RID: 32332 RVA: 0x0022D868 File Offset: 0x0022BA68
		// (set) Token: 0x06007E4D RID: 32333 RVA: 0x0003BF10 File Offset: 0x0003A110
		public unsafe List<ProductDefinition> Products
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_Products);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProductDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_Products), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002703 RID: 9987
		// (get) Token: 0x06007E4E RID: 32334 RVA: 0x0022D898 File Offset: 0x0022BA98
		// (set) Token: 0x06007E4F RID: 32335 RVA: 0x0003BF2F File Offset: 0x0003A12F
		public unsafe List<PropertyItemDefinition> Properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_Properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PropertyItemDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_Properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002704 RID: 9988
		// (get) Token: 0x06007E50 RID: 32336 RVA: 0x0022D8C8 File Offset: 0x0022BAC8
		// (set) Token: 0x06007E51 RID: 32337 RVA: 0x0003BF4E File Offset: 0x0003A14E
		public unsafe Dictionary<string, Effect> PropertiesDict
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_PropertiesDict);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Effect>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_PropertiesDict), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005636 RID: 22070
		private static readonly IntPtr NativeFieldInfoPtr_PropertyDatas;

		// Token: 0x04005637 RID: 22071
		private static readonly IntPtr NativeFieldInfoPtr_DrugTypeDatas;

		// Token: 0x04005638 RID: 22072
		private static readonly IntPtr NativeFieldInfoPtr_AllProperties;

		// Token: 0x04005639 RID: 22073
		private static readonly IntPtr NativeFieldInfoPtr_Products;

		// Token: 0x0400563A RID: 22074
		private static readonly IntPtr NativeFieldInfoPtr_Properties;

		// Token: 0x0400563B RID: 22075
		private static readonly IntPtr NativeFieldInfoPtr_PropertiesDict;

		// Token: 0x0400563C RID: 22076
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400563D RID: 22077
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400563E RID: 22078
		private static readonly IntPtr NativeMethodInfoPtr_GetProperties_Public_List_1_Effect_Int32_0;

		// Token: 0x0400563F RID: 22079
		private static readonly IntPtr NativeMethodInfoPtr_GetProperties_Public_List_1_Effect_List_1_String_0;

		// Token: 0x04005640 RID: 22080
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyData_Public_Static_PropertyData_EProperty_0;

		// Token: 0x04005641 RID: 22081
		private static readonly IntPtr NativeMethodInfoPtr_GetDrugTypeData_Public_Static_DrugTypeData_EDrugType_0;

		// Token: 0x04005642 RID: 22082
		private static readonly IntPtr NativeMethodInfoPtr_GetOrderedPropertyColors_Public_Static_List_1_Color32_List_1_Effect_0;

		// Token: 0x04005643 RID: 22083
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BD5 RID: 3029
		[Serializable]
		public class PropertyData : Il2CppSystem.Object
		{
			// Token: 0x0600EC16 RID: 60438 RVA: 0x003941C4 File Offset: 0x003923C4
			// Note: this type is marked as 'beforefieldinit'.
			static PropertyData()
			{
				Il2CppClassPointerStore<PropertyUtility.PropertyData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "PropertyData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyUtility.PropertyData>.NativeClassPtr);
				PropertyUtility.PropertyData.NativeFieldInfoPtr_Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.PropertyData>.NativeClassPtr, "Property");
				PropertyUtility.PropertyData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.PropertyData>.NativeClassPtr, "Name");
				PropertyUtility.PropertyData.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.PropertyData>.NativeClassPtr, "Description");
				PropertyUtility.PropertyData.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.PropertyData>.NativeClassPtr, "Color");
				PropertyUtility.PropertyData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.PropertyData>.NativeClassPtr, 100679583);
			}

			// Token: 0x0600EC17 RID: 60439 RVA: 0x00394254 File Offset: 0x00392454
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PropertyData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyUtility.PropertyData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.PropertyData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC18 RID: 60440 RVA: 0x0006F5B0 File Offset: 0x0006D7B0
			public PropertyData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004795 RID: 18325
			// (get) Token: 0x0600EC19 RID: 60441 RVA: 0x00394290 File Offset: 0x00392490
			// (set) Token: 0x0600EC1A RID: 60442 RVA: 0x0006F5B9 File Offset: 0x0006D7B9
			public unsafe EProperty Property
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.PropertyData.NativeFieldInfoPtr_Property);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.PropertyData.NativeFieldInfoPtr_Property)) = value;
				}
			}

			// Token: 0x17004796 RID: 18326
			// (get) Token: 0x0600EC1B RID: 60443 RVA: 0x003942B8 File Offset: 0x003924B8
			// (set) Token: 0x0600EC1C RID: 60444 RVA: 0x0006F5D4 File Offset: 0x0006D7D4
			public unsafe string Name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.PropertyData.NativeFieldInfoPtr_Name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.PropertyData.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004797 RID: 18327
			// (get) Token: 0x0600EC1D RID: 60445 RVA: 0x003942E0 File Offset: 0x003924E0
			// (set) Token: 0x0600EC1E RID: 60446 RVA: 0x0006F5F3 File Offset: 0x0006D7F3
			public unsafe string Description
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.PropertyData.NativeFieldInfoPtr_Description);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.PropertyData.NativeFieldInfoPtr_Description), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004798 RID: 18328
			// (get) Token: 0x0600EC1F RID: 60447 RVA: 0x00394308 File Offset: 0x00392508
			// (set) Token: 0x0600EC20 RID: 60448 RVA: 0x0006F612 File Offset: 0x0006D812
			public unsafe Color Color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.PropertyData.NativeFieldInfoPtr_Color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.PropertyData.NativeFieldInfoPtr_Color)) = value;
				}
			}

			// Token: 0x04009FE1 RID: 40929
			private static readonly IntPtr NativeFieldInfoPtr_Property;

			// Token: 0x04009FE2 RID: 40930
			private static readonly IntPtr NativeFieldInfoPtr_Name;

			// Token: 0x04009FE3 RID: 40931
			private static readonly IntPtr NativeFieldInfoPtr_Description;

			// Token: 0x04009FE4 RID: 40932
			private static readonly IntPtr NativeFieldInfoPtr_Color;

			// Token: 0x04009FE5 RID: 40933
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000BD6 RID: 3030
		[Serializable]
		public class DrugTypeData : Il2CppSystem.Object
		{
			// Token: 0x0600EC21 RID: 60449 RVA: 0x00394330 File Offset: 0x00392530
			// Note: this type is marked as 'beforefieldinit'.
			static DrugTypeData()
			{
				Il2CppClassPointerStore<PropertyUtility.DrugTypeData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "DrugTypeData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyUtility.DrugTypeData>.NativeClassPtr);
				PropertyUtility.DrugTypeData.NativeFieldInfoPtr_DrugType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.DrugTypeData>.NativeClassPtr, "DrugType");
				PropertyUtility.DrugTypeData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.DrugTypeData>.NativeClassPtr, "Name");
				PropertyUtility.DrugTypeData.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.DrugTypeData>.NativeClassPtr, "Color");
				PropertyUtility.DrugTypeData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.DrugTypeData>.NativeClassPtr, 100679584);
			}

			// Token: 0x0600EC22 RID: 60450 RVA: 0x003943AC File Offset: 0x003925AC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DrugTypeData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyUtility.DrugTypeData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.DrugTypeData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC23 RID: 60451 RVA: 0x0006F62D File Offset: 0x0006D82D
			public DrugTypeData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004799 RID: 18329
			// (get) Token: 0x0600EC24 RID: 60452 RVA: 0x003943E8 File Offset: 0x003925E8
			// (set) Token: 0x0600EC25 RID: 60453 RVA: 0x0006F636 File Offset: 0x0006D836
			public unsafe EDrugType DrugType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.DrugTypeData.NativeFieldInfoPtr_DrugType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.DrugTypeData.NativeFieldInfoPtr_DrugType)) = value;
				}
			}

			// Token: 0x1700479A RID: 18330
			// (get) Token: 0x0600EC26 RID: 60454 RVA: 0x00394410 File Offset: 0x00392610
			// (set) Token: 0x0600EC27 RID: 60455 RVA: 0x0006F651 File Offset: 0x0006D851
			public unsafe string Name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.DrugTypeData.NativeFieldInfoPtr_Name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.DrugTypeData.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700479B RID: 18331
			// (get) Token: 0x0600EC28 RID: 60456 RVA: 0x00394438 File Offset: 0x00392638
			// (set) Token: 0x0600EC29 RID: 60457 RVA: 0x0006F670 File Offset: 0x0006D870
			public unsafe Color Color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.DrugTypeData.NativeFieldInfoPtr_Color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.DrugTypeData.NativeFieldInfoPtr_Color)) = value;
				}
			}

			// Token: 0x04009FE6 RID: 40934
			private static readonly IntPtr NativeFieldInfoPtr_DrugType;

			// Token: 0x04009FE7 RID: 40935
			private static readonly IntPtr NativeFieldInfoPtr_Name;

			// Token: 0x04009FE8 RID: 40936
			private static readonly IntPtr NativeFieldInfoPtr_Color;

			// Token: 0x04009FE9 RID: 40937
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000BD7 RID: 3031
		[ObfuscatedName("ScheduleOne.Product.PropertyUtility+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600EC2A RID: 60458 RVA: 0x00394460 File Offset: 0x00392660
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PropertyUtility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyUtility.__c>.NativeClassPtr);
				PropertyUtility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.__c>.NativeClassPtr, "<>9");
				PropertyUtility.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.__c>.NativeClassPtr, "<>9__14_0");
				PropertyUtility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c>.NativeClassPtr, 100679586);
				PropertyUtility.__c.NativeMethodInfoPtr__GetOrderedPropertyColors_b__14_0_Internal_Int32_Effect_Effect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c>.NativeClassPtr, 100679587);
			}

			// Token: 0x0600EC2B RID: 60459 RVA: 0x003944DC File Offset: 0x003926DC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyUtility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC2C RID: 60460 RVA: 0x00394518 File Offset: 0x00392718
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetOrderedPropertyColors_b__14_0(Effect x, Effect y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c.NativeMethodInfoPtr__GetOrderedPropertyColors_b__14_0_Internal_Int32_Effect_Effect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EC2D RID: 60461 RVA: 0x0006F68B File Offset: 0x0006D88B
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700479C RID: 18332
			// (get) Token: 0x0600EC2E RID: 60462 RVA: 0x00394578 File Offset: 0x00392778
			// (set) Token: 0x0600EC2F RID: 60463 RVA: 0x0006F694 File Offset: 0x0006D894
			public unsafe static PropertyUtility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PropertyUtility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyUtility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PropertyUtility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700479D RID: 18333
			// (get) Token: 0x0600EC30 RID: 60464 RVA: 0x003945A0 File Offset: 0x003927A0
			// (set) Token: 0x0600EC31 RID: 60465 RVA: 0x0006F6A6 File Offset: 0x0006D8A6
			public unsafe static Comparison<Effect> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PropertyUtility.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<Effect>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PropertyUtility.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009FEA RID: 40938
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009FEB RID: 40939
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x04009FEC RID: 40940
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009FED RID: 40941
			private static readonly IntPtr NativeMethodInfoPtr__GetOrderedPropertyColors_b__14_0_Internal_Int32_Effect_Effect_0;
		}

		// Token: 0x02000BD8 RID: 3032
		[ObfuscatedName("ScheduleOne.Product.PropertyUtility+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
		{
			// Token: 0x0600EC32 RID: 60466 RVA: 0x003945C8 File Offset: 0x003927C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass10_0>.NativeClassPtr);
				PropertyUtility.__c__DisplayClass10_0.NativeFieldInfoPtr_tier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass10_0>.NativeClassPtr, "tier");
				PropertyUtility.__c__DisplayClass10_0.NativeFieldInfoPtr_excludePostMixingRework = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass10_0>.NativeClassPtr, "excludePostMixingRework");
				PropertyUtility.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass10_0>.NativeClassPtr, 100679588);
				PropertyUtility.__c__DisplayClass10_0.NativeMethodInfoPtr__GetProperties_b__0_Internal_Boolean_Effect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass10_0>.NativeClassPtr, 100679589);
			}

			// Token: 0x0600EC33 RID: 60467 RVA: 0x00394644 File Offset: 0x00392844
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC34 RID: 60468 RVA: 0x00394680 File Offset: 0x00392880
			[CallerCount(0)]
			public unsafe bool _GetProperties_b__0(Effect x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c__DisplayClass10_0.NativeMethodInfoPtr__GetProperties_b__0_Internal_Boolean_Effect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EC35 RID: 60469 RVA: 0x0006F6B8 File Offset: 0x0006D8B8
			public __c__DisplayClass10_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700479E RID: 18334
			// (get) Token: 0x0600EC36 RID: 60470 RVA: 0x003946D0 File Offset: 0x003928D0
			// (set) Token: 0x0600EC37 RID: 60471 RVA: 0x0006F6C1 File Offset: 0x0006D8C1
			public unsafe int tier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass10_0.NativeFieldInfoPtr_tier);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass10_0.NativeFieldInfoPtr_tier)) = value;
				}
			}

			// Token: 0x1700479F RID: 18335
			// (get) Token: 0x0600EC38 RID: 60472 RVA: 0x003946F8 File Offset: 0x003928F8
			// (set) Token: 0x0600EC39 RID: 60473 RVA: 0x0006F6DC File Offset: 0x0006D8DC
			public unsafe bool excludePostMixingRework
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass10_0.NativeFieldInfoPtr_excludePostMixingRework);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass10_0.NativeFieldInfoPtr_excludePostMixingRework)) = value;
				}
			}

			// Token: 0x04009FEE RID: 40942
			private static readonly IntPtr NativeFieldInfoPtr_tier;

			// Token: 0x04009FEF RID: 40943
			private static readonly IntPtr NativeFieldInfoPtr_excludePostMixingRework;

			// Token: 0x04009FF0 RID: 40944
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009FF1 RID: 40945
			private static readonly IntPtr NativeMethodInfoPtr__GetProperties_b__0_Internal_Boolean_Effect_0;
		}

		// Token: 0x02000BD9 RID: 3033
		[ObfuscatedName("ScheduleOne.Product.PropertyUtility+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
		{
			// Token: 0x0600EC3A RID: 60474 RVA: 0x00394720 File Offset: 0x00392920
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_0>.NativeClassPtr);
				PropertyUtility.__c__DisplayClass11_0.NativeFieldInfoPtr_ids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_0>.NativeClassPtr, "ids");
				PropertyUtility.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_0>.NativeClassPtr, 100679590);
				PropertyUtility.__c__DisplayClass11_0.NativeMethodInfoPtr__GetProperties_b__0_Internal_Boolean_Effect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_0>.NativeClassPtr, 100679591);
			}

			// Token: 0x0600EC3B RID: 60475 RVA: 0x00394788 File Offset: 0x00392988
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC3C RID: 60476 RVA: 0x003947C4 File Offset: 0x003929C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241638, XrefRangeEnd = 241642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetProperties_b__0(Effect x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c__DisplayClass11_0.NativeMethodInfoPtr__GetProperties_b__0_Internal_Boolean_Effect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EC3D RID: 60477 RVA: 0x0006F6F7 File Offset: 0x0006D8F7
			public __c__DisplayClass11_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170047A0 RID: 18336
			// (get) Token: 0x0600EC3E RID: 60478 RVA: 0x00394814 File Offset: 0x00392A14
			// (set) Token: 0x0600EC3F RID: 60479 RVA: 0x0006F700 File Offset: 0x0006D900
			public unsafe List<string> ids
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass11_0.NativeFieldInfoPtr_ids);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass11_0.NativeFieldInfoPtr_ids), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009FF2 RID: 40946
			private static readonly IntPtr NativeFieldInfoPtr_ids;

			// Token: 0x04009FF3 RID: 40947
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009FF4 RID: 40948
			private static readonly IntPtr NativeMethodInfoPtr__GetProperties_b__0_Internal_Boolean_Effect_0;
		}

		// Token: 0x02000BDA RID: 3034
		[ObfuscatedName("ScheduleOne.Product.PropertyUtility+<>c__DisplayClass11_1")]
		public sealed class __c__DisplayClass11_1 : Il2CppSystem.Object
		{
			// Token: 0x0600EC40 RID: 60480 RVA: 0x00394844 File Offset: 0x00392A44
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_1()
			{
				Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "<>c__DisplayClass11_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_1>.NativeClassPtr);
				PropertyUtility.__c__DisplayClass11_1.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_1>.NativeClassPtr, "id");
				PropertyUtility.__c__DisplayClass11_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_1>.NativeClassPtr, 100679592);
				PropertyUtility.__c__DisplayClass11_1.NativeMethodInfoPtr__GetProperties_b__1_Internal_Boolean_Effect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_1>.NativeClassPtr, 100679593);
			}

			// Token: 0x0600EC41 RID: 60481 RVA: 0x003948AC File Offset: 0x00392AAC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c__DisplayClass11_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC42 RID: 60482 RVA: 0x003948E8 File Offset: 0x00392AE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetProperties_b__1(Effect x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c__DisplayClass11_1.NativeMethodInfoPtr__GetProperties_b__1_Internal_Boolean_Effect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EC43 RID: 60483 RVA: 0x0006F71F File Offset: 0x0006D91F
			public __c__DisplayClass11_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170047A1 RID: 18337
			// (get) Token: 0x0600EC44 RID: 60484 RVA: 0x00394938 File Offset: 0x00392B38
			// (set) Token: 0x0600EC45 RID: 60485 RVA: 0x0006F728 File Offset: 0x0006D928
			public unsafe string id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass11_1.NativeFieldInfoPtr_id);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass11_1.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009FF5 RID: 40949
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04009FF6 RID: 40950
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009FF7 RID: 40951
			private static readonly IntPtr NativeMethodInfoPtr__GetProperties_b__1_Internal_Boolean_Effect_0;
		}

		// Token: 0x02000BDB RID: 3035
		[ObfuscatedName("ScheduleOne.Product.PropertyUtility+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
		{
			// Token: 0x0600EC46 RID: 60486 RVA: 0x00394960 File Offset: 0x00392B60
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass12_0>.NativeClassPtr);
				PropertyUtility.__c__DisplayClass12_0.NativeFieldInfoPtr_property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass12_0>.NativeClassPtr, "property");
				PropertyUtility.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass12_0>.NativeClassPtr, 100679594);
				PropertyUtility.__c__DisplayClass12_0.NativeMethodInfoPtr__GetPropertyData_b__0_Internal_Boolean_PropertyData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass12_0>.NativeClassPtr, 100679595);
			}

			// Token: 0x0600EC47 RID: 60487 RVA: 0x003949C8 File Offset: 0x00392BC8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC48 RID: 60488 RVA: 0x00394A04 File Offset: 0x00392C04
			[CallerCount(0)]
			public unsafe bool _GetPropertyData_b__0(PropertyUtility.PropertyData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c__DisplayClass12_0.NativeMethodInfoPtr__GetPropertyData_b__0_Internal_Boolean_PropertyData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EC49 RID: 60489 RVA: 0x0006F747 File Offset: 0x0006D947
			public __c__DisplayClass12_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170047A2 RID: 18338
			// (get) Token: 0x0600EC4A RID: 60490 RVA: 0x00394A54 File Offset: 0x00392C54
			// (set) Token: 0x0600EC4B RID: 60491 RVA: 0x0006F750 File Offset: 0x0006D950
			public unsafe EProperty property
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass12_0.NativeFieldInfoPtr_property);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass12_0.NativeFieldInfoPtr_property)) = value;
				}
			}

			// Token: 0x04009FF8 RID: 40952
			private static readonly IntPtr NativeFieldInfoPtr_property;

			// Token: 0x04009FF9 RID: 40953
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009FFA RID: 40954
			private static readonly IntPtr NativeMethodInfoPtr__GetPropertyData_b__0_Internal_Boolean_PropertyData_0;
		}

		// Token: 0x02000BDC RID: 3036
		[ObfuscatedName("ScheduleOne.Product.PropertyUtility+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
		{
			// Token: 0x0600EC4C RID: 60492 RVA: 0x00394A7C File Offset: 0x00392C7C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass13_0>.NativeClassPtr);
				PropertyUtility.__c__DisplayClass13_0.NativeFieldInfoPtr_drugType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass13_0>.NativeClassPtr, "drugType");
				PropertyUtility.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass13_0>.NativeClassPtr, 100679596);
				PropertyUtility.__c__DisplayClass13_0.NativeMethodInfoPtr__GetDrugTypeData_b__0_Internal_Boolean_DrugTypeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass13_0>.NativeClassPtr, 100679597);
			}

			// Token: 0x0600EC4D RID: 60493 RVA: 0x00394AE4 File Offset: 0x00392CE4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC4E RID: 60494 RVA: 0x00394B20 File Offset: 0x00392D20
			[CallerCount(0)]
			public unsafe bool _GetDrugTypeData_b__0(PropertyUtility.DrugTypeData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c__DisplayClass13_0.NativeMethodInfoPtr__GetDrugTypeData_b__0_Internal_Boolean_DrugTypeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EC4F RID: 60495 RVA: 0x0006F76B File Offset: 0x0006D96B
			public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170047A3 RID: 18339
			// (get) Token: 0x0600EC50 RID: 60496 RVA: 0x00394B70 File Offset: 0x00392D70
			// (set) Token: 0x0600EC51 RID: 60497 RVA: 0x0006F774 File Offset: 0x0006D974
			public unsafe EDrugType drugType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass13_0.NativeFieldInfoPtr_drugType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass13_0.NativeFieldInfoPtr_drugType)) = value;
				}
			}

			// Token: 0x04009FFB RID: 40955
			private static readonly IntPtr NativeFieldInfoPtr_drugType;

			// Token: 0x04009FFC RID: 40956
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009FFD RID: 40957
			private static readonly IntPtr NativeMethodInfoPtr__GetDrugTypeData_b__0_Internal_Boolean_DrugTypeData_0;
		}
	}
}
