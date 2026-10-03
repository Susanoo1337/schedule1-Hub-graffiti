using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Product;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x02000390 RID: 912
	[Serializable]
	public class CustomerAffinityData : Object
	{
		// Token: 0x06005217 RID: 21015 RVA: 0x0019678C File Offset: 0x0019498C
		// Note: this type is marked as 'beforefieldinit'.
		static CustomerAffinityData()
		{
			Il2CppClassPointerStore<CustomerAffinityData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "CustomerAffinityData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomerAffinityData>.NativeClassPtr);
			CustomerAffinityData.NativeFieldInfoPtr_ProductAffinities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerAffinityData>.NativeClassPtr, "ProductAffinities");
			CustomerAffinityData.NativeMethodInfoPtr_CopyTo_Public_Void_CustomerAffinityData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAffinityData>.NativeClassPtr, 100674028);
			CustomerAffinityData.NativeMethodInfoPtr_GetAffinity_Public_Single_EDrugType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAffinityData>.NativeClassPtr, 100674029);
			CustomerAffinityData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAffinityData>.NativeClassPtr, 100674030);
		}

		// Token: 0x06005218 RID: 21016 RVA: 0x0019680C File Offset: 0x00194A0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 183263, RefRangeEnd = 183264, XrefRangeStart = 183219, XrefRangeEnd = 183263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyTo(CustomerAffinityData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerAffinityData.NativeMethodInfoPtr_CopyTo_Public_Void_CustomerAffinityData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005219 RID: 21017 RVA: 0x00196850 File Offset: 0x00194A50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 183280, RefRangeEnd = 183282, XrefRangeStart = 183264, XrefRangeEnd = 183280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAffinity(EDrugType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerAffinityData.NativeMethodInfoPtr_GetAffinity_Public_Single_EDrugType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600521A RID: 21018 RVA: 0x0019689C File Offset: 0x00194A9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 183290, RefRangeEnd = 183291, XrefRangeStart = 183282, XrefRangeEnd = 183290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomerAffinityData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomerAffinityData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerAffinityData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600521B RID: 21019 RVA: 0x00027090 File Offset: 0x00025290
		public CustomerAffinityData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700198F RID: 6543
		// (get) Token: 0x0600521C RID: 21020 RVA: 0x001968D8 File Offset: 0x00194AD8
		// (set) Token: 0x0600521D RID: 21021 RVA: 0x00027099 File Offset: 0x00025299
		public unsafe List<ProductTypeAffinity> ProductAffinities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerAffinityData.NativeFieldInfoPtr_ProductAffinities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProductTypeAffinity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerAffinityData.NativeFieldInfoPtr_ProductAffinities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003860 RID: 14432
		private static readonly IntPtr NativeFieldInfoPtr_ProductAffinities;

		// Token: 0x04003861 RID: 14433
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Void_CustomerAffinityData_0;

		// Token: 0x04003862 RID: 14434
		private static readonly IntPtr NativeMethodInfoPtr_GetAffinity_Public_Single_EDrugType_0;

		// Token: 0x04003863 RID: 14435
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AA5 RID: 2725
		[ObfuscatedName("ScheduleOne.Economy.CustomerAffinityData+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x0600E2CB RID: 58059 RVA: 0x00379704 File Offset: 0x00377904
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomerAffinityData>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass1_0>.NativeClassPtr);
				CustomerAffinityData.__c__DisplayClass1_0.NativeFieldInfoPtr_affinity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass1_0>.NativeClassPtr, "affinity");
				CustomerAffinityData.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass1_0>.NativeClassPtr, 100674031);
				CustomerAffinityData.__c__DisplayClass1_0.NativeMethodInfoPtr__CopyTo_b__0_Internal_Boolean_ProductTypeAffinity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass1_0>.NativeClassPtr, 100674032);
				CustomerAffinityData.__c__DisplayClass1_0.NativeMethodInfoPtr__CopyTo_b__1_Internal_Boolean_ProductTypeAffinity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass1_0>.NativeClassPtr, 100674033);
			}

			// Token: 0x0600E2CC RID: 58060 RVA: 0x00379780 File Offset: 0x00377980
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerAffinityData.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E2CD RID: 58061 RVA: 0x003797BC File Offset: 0x003779BC
			[CallerCount(0)]
			public unsafe bool _CopyTo_b__0(ProductTypeAffinity x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerAffinityData.__c__DisplayClass1_0.NativeMethodInfoPtr__CopyTo_b__0_Internal_Boolean_ProductTypeAffinity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E2CE RID: 58062 RVA: 0x0037980C File Offset: 0x00377A0C
			[CallerCount(0)]
			public unsafe bool _CopyTo_b__1(ProductTypeAffinity x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerAffinityData.__c__DisplayClass1_0.NativeMethodInfoPtr__CopyTo_b__1_Internal_Boolean_ProductTypeAffinity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E2CF RID: 58063 RVA: 0x0006AF0D File Offset: 0x0006910D
			public __c__DisplayClass1_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004500 RID: 17664
			// (get) Token: 0x0600E2D0 RID: 58064 RVA: 0x0037985C File Offset: 0x00377A5C
			// (set) Token: 0x0600E2D1 RID: 58065 RVA: 0x0006AF16 File Offset: 0x00069116
			public unsafe ProductTypeAffinity affinity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerAffinityData.__c__DisplayClass1_0.NativeFieldInfoPtr_affinity);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductTypeAffinity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerAffinityData.__c__DisplayClass1_0.NativeFieldInfoPtr_affinity), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009A36 RID: 39478
			private static readonly IntPtr NativeFieldInfoPtr_affinity;

			// Token: 0x04009A37 RID: 39479
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009A38 RID: 39480
			private static readonly IntPtr NativeMethodInfoPtr__CopyTo_b__0_Internal_Boolean_ProductTypeAffinity_0;

			// Token: 0x04009A39 RID: 39481
			private static readonly IntPtr NativeMethodInfoPtr__CopyTo_b__1_Internal_Boolean_ProductTypeAffinity_0;
		}

		// Token: 0x02000AA6 RID: 2726
		[ObfuscatedName("ScheduleOne.Economy.CustomerAffinityData+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x0600E2D2 RID: 58066 RVA: 0x0037988C File Offset: 0x00377A8C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomerAffinityData>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass2_0>.NativeClassPtr);
				CustomerAffinityData.__c__DisplayClass2_0.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass2_0>.NativeClassPtr, "type");
				CustomerAffinityData.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass2_0>.NativeClassPtr, 100674034);
				CustomerAffinityData.__c__DisplayClass2_0.NativeMethodInfoPtr__GetAffinity_b__0_Internal_Boolean_ProductTypeAffinity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass2_0>.NativeClassPtr, 100674035);
			}

			// Token: 0x0600E2D3 RID: 58067 RVA: 0x003798F4 File Offset: 0x00377AF4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerAffinityData.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E2D4 RID: 58068 RVA: 0x00379930 File Offset: 0x00377B30
			[CallerCount(0)]
			public unsafe bool _GetAffinity_b__0(ProductTypeAffinity x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerAffinityData.__c__DisplayClass2_0.NativeMethodInfoPtr__GetAffinity_b__0_Internal_Boolean_ProductTypeAffinity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E2D5 RID: 58069 RVA: 0x0006AF35 File Offset: 0x00069135
			public __c__DisplayClass2_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004501 RID: 17665
			// (get) Token: 0x0600E2D6 RID: 58070 RVA: 0x00379980 File Offset: 0x00377B80
			// (set) Token: 0x0600E2D7 RID: 58071 RVA: 0x0006AF3E File Offset: 0x0006913E
			public unsafe EDrugType type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerAffinityData.__c__DisplayClass2_0.NativeFieldInfoPtr_type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerAffinityData.__c__DisplayClass2_0.NativeFieldInfoPtr_type)) = value;
				}
			}

			// Token: 0x04009A3A RID: 39482
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x04009A3B RID: 39483
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009A3C RID: 39484
			private static readonly IntPtr NativeMethodInfoPtr__GetAffinity_b__0_Internal_Boolean_ProductTypeAffinity_0;
		}
	}
}
