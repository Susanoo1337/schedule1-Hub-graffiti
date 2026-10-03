using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.UI.Phone
{
	// Token: 0x020007A3 RID: 1955
	public class CustomerSelector : MonoBehaviour
	{
		// Token: 0x0600BD1B RID: 48411 RVA: 0x00308234 File Offset: 0x00306434
		// Note: this type is marked as 'beforefieldinit'.
		static CustomerSelector()
		{
			Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone", "CustomerSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr);
			CustomerSelector.NativeFieldInfoPtr_ButtonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, "ButtonPrefab");
			CustomerSelector.NativeFieldInfoPtr_EntriesContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, "EntriesContainer");
			CustomerSelector.NativeFieldInfoPtr_CustomersPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, "CustomersPanel");
			CustomerSelector.NativeFieldInfoPtr_onCustomerSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, "onCustomerSelected");
			CustomerSelector.NativeFieldInfoPtr_customerEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, "customerEntries");
			CustomerSelector.NativeFieldInfoPtr_entryToCustomer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, "entryToCustomer");
			CustomerSelector.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, 100687969);
			CustomerSelector.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, 100687970);
			CustomerSelector.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, 100687971);
			CustomerSelector.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, 100687972);
			CustomerSelector.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, 100687973);
			CustomerSelector.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, 100687974);
			CustomerSelector.NativeMethodInfoPtr_CreateEntry_Private_Void_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, 100687975);
			CustomerSelector.NativeMethodInfoPtr_CustomerSelected_Private_Void_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, 100687976);
			CustomerSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, 100687977);
		}

		// Token: 0x0600BD1C RID: 48412 RVA: 0x00308390 File Offset: 0x00306590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315144, XrefRangeEnd = 315179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BD1D RID: 48413 RVA: 0x003083C4 File Offset: 0x003065C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315179, XrefRangeEnd = 315189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BD1E RID: 48414 RVA: 0x003083F8 File Offset: 0x003065F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315189, XrefRangeEnd = 315211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BD1F RID: 48415 RVA: 0x0030842C File Offset: 0x0030662C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315211, XrefRangeEnd = 315230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BD20 RID: 48416 RVA: 0x00308470 File Offset: 0x00306670
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 315274, RefRangeEnd = 315275, XrefRangeStart = 315230, XrefRangeEnd = 315274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BD21 RID: 48417 RVA: 0x003084A4 File Offset: 0x003066A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 187975, RefRangeEnd = 187977, XrefRangeStart = 187975, XrefRangeEnd = 187977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BD22 RID: 48418 RVA: 0x003084D8 File Offset: 0x003066D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 315357, RefRangeEnd = 315358, XrefRangeStart = 315275, XrefRangeEnd = 315357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateEntry(Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.NativeMethodInfoPtr_CreateEntry_Private_Void_Customer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BD23 RID: 48419 RVA: 0x0030851C File Offset: 0x0030671C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315358, XrefRangeEnd = 315368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CustomerSelected(Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.NativeMethodInfoPtr_CustomerSelected_Private_Void_Customer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BD24 RID: 48420 RVA: 0x00308560 File Offset: 0x00306760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315368, XrefRangeEnd = 315383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomerSelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BD25 RID: 48421 RVA: 0x00058237 File Offset: 0x00056437
		public CustomerSelector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700390F RID: 14607
		// (get) Token: 0x0600BD26 RID: 48422 RVA: 0x0030859C File Offset: 0x0030679C
		// (set) Token: 0x0600BD27 RID: 48423 RVA: 0x00058240 File Offset: 0x00056440
		public unsafe GameObject ButtonPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.NativeFieldInfoPtr_ButtonPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.NativeFieldInfoPtr_ButtonPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003910 RID: 14608
		// (get) Token: 0x0600BD28 RID: 48424 RVA: 0x003085CC File Offset: 0x003067CC
		// (set) Token: 0x0600BD29 RID: 48425 RVA: 0x0005825F File Offset: 0x0005645F
		public unsafe RectTransform EntriesContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.NativeFieldInfoPtr_EntriesContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.NativeFieldInfoPtr_EntriesContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003911 RID: 14609
		// (get) Token: 0x0600BD2A RID: 48426 RVA: 0x003085FC File Offset: 0x003067FC
		// (set) Token: 0x0600BD2B RID: 48427 RVA: 0x0005827E File Offset: 0x0005647E
		public unsafe UIPanel CustomersPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.NativeFieldInfoPtr_CustomersPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.NativeFieldInfoPtr_CustomersPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003912 RID: 14610
		// (get) Token: 0x0600BD2C RID: 48428 RVA: 0x0030862C File Offset: 0x0030682C
		// (set) Token: 0x0600BD2D RID: 48429 RVA: 0x0005829D File Offset: 0x0005649D
		public unsafe UnityEvent<Customer> onCustomerSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.NativeFieldInfoPtr_onCustomerSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Customer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.NativeFieldInfoPtr_onCustomerSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003913 RID: 14611
		// (get) Token: 0x0600BD2E RID: 48430 RVA: 0x0030865C File Offset: 0x0030685C
		// (set) Token: 0x0600BD2F RID: 48431 RVA: 0x000582BC File Offset: 0x000564BC
		public unsafe List<RectTransform> customerEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.NativeFieldInfoPtr_customerEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.NativeFieldInfoPtr_customerEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003914 RID: 14612
		// (get) Token: 0x0600BD30 RID: 48432 RVA: 0x0030868C File Offset: 0x0030688C
		// (set) Token: 0x0600BD31 RID: 48433 RVA: 0x000582DB File Offset: 0x000564DB
		public unsafe Dictionary<RectTransform, Customer> entryToCustomer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.NativeFieldInfoPtr_entryToCustomer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<RectTransform, Customer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.NativeFieldInfoPtr_entryToCustomer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400818C RID: 33164
		private static readonly IntPtr NativeFieldInfoPtr_ButtonPrefab;

		// Token: 0x0400818D RID: 33165
		private static readonly IntPtr NativeFieldInfoPtr_EntriesContainer;

		// Token: 0x0400818E RID: 33166
		private static readonly IntPtr NativeFieldInfoPtr_CustomersPanel;

		// Token: 0x0400818F RID: 33167
		private static readonly IntPtr NativeFieldInfoPtr_onCustomerSelected;

		// Token: 0x04008190 RID: 33168
		private static readonly IntPtr NativeFieldInfoPtr_customerEntries;

		// Token: 0x04008191 RID: 33169
		private static readonly IntPtr NativeFieldInfoPtr_entryToCustomer;

		// Token: 0x04008192 RID: 33170
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04008193 RID: 33171
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04008194 RID: 33172
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04008195 RID: 33173
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04008196 RID: 33174
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04008197 RID: 33175
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04008198 RID: 33176
		private static readonly IntPtr NativeMethodInfoPtr_CreateEntry_Private_Void_Customer_0;

		// Token: 0x04008199 RID: 33177
		private static readonly IntPtr NativeMethodInfoPtr_CustomerSelected_Private_Void_Customer_0;

		// Token: 0x0400819A RID: 33178
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D17 RID: 3351
		[ObfuscatedName("ScheduleOne.UI.Phone.CustomerSelector+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600F80C RID: 63500 RVA: 0x003B6B3C File Offset: 0x003B4D3C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CustomerSelector.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomerSelector.__c>.NativeClassPtr);
				CustomerSelector.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerSelector.__c>.NativeClassPtr, "<>9");
				CustomerSelector.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerSelector.__c>.NativeClassPtr, "<>9__10_0");
				CustomerSelector.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector.__c>.NativeClassPtr, 100687979);
				CustomerSelector.__c.NativeMethodInfoPtr__Open_b__10_0_Internal_Boolean_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector.__c>.NativeClassPtr, 100687980);
			}

			// Token: 0x0600F80D RID: 63501 RVA: 0x003B6BB8 File Offset: 0x003B4DB8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomerSelector.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F80E RID: 63502 RVA: 0x003B6BF4 File Offset: 0x003B4DF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315123, XrefRangeEnd = 315126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Open_b__10_0(RectTransform x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.__c.NativeMethodInfoPtr__Open_b__10_0_Internal_Boolean_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F80F RID: 63503 RVA: 0x000754A3 File Offset: 0x000736A3
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B67 RID: 19303
			// (get) Token: 0x0600F810 RID: 63504 RVA: 0x003B6C44 File Offset: 0x003B4E44
			// (set) Token: 0x0600F811 RID: 63505 RVA: 0x000754AC File Offset: 0x000736AC
			public unsafe static CustomerSelector.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CustomerSelector.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomerSelector.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CustomerSelector.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B68 RID: 19304
			// (get) Token: 0x0600F812 RID: 63506 RVA: 0x003B6C6C File Offset: 0x003B4E6C
			// (set) Token: 0x0600F813 RID: 63507 RVA: 0x000754BE File Offset: 0x000736BE
			public unsafe static Func<RectTransform, bool> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CustomerSelector.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RectTransform, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CustomerSelector.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A7B0 RID: 42928
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A7B1 RID: 42929
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x0400A7B2 RID: 42930
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A7B3 RID: 42931
			private static readonly IntPtr NativeMethodInfoPtr__Open_b__10_0_Internal_Boolean_RectTransform_0;
		}

		// Token: 0x02000D18 RID: 3352
		[ObfuscatedName("ScheduleOne.UI.Phone.CustomerSelector+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F814 RID: 63508 RVA: 0x003B6C94 File Offset: 0x003B4E94
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<CustomerSelector.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomerSelector.__c__DisplayClass12_0>.NativeClassPtr);
				CustomerSelector.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerSelector.__c__DisplayClass12_0>.NativeClassPtr, "<>4__this");
				CustomerSelector.__c__DisplayClass12_0.NativeFieldInfoPtr_customer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerSelector.__c__DisplayClass12_0>.NativeClassPtr, "customer");
				CustomerSelector.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector.__c__DisplayClass12_0>.NativeClassPtr, 100687981);
				CustomerSelector.__c__DisplayClass12_0.NativeMethodInfoPtr__CreateEntry_b__0_Internal_Boolean_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector.__c__DisplayClass12_0>.NativeClassPtr, 100687982);
				CustomerSelector.__c__DisplayClass12_0.NativeMethodInfoPtr__CreateEntry_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector.__c__DisplayClass12_0>.NativeClassPtr, 100687983);
			}

			// Token: 0x0600F815 RID: 63509 RVA: 0x003B6D24 File Offset: 0x003B4F24
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomerSelector.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F816 RID: 63510 RVA: 0x003B6D60 File Offset: 0x003B4F60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315126, XrefRangeEnd = 315134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CreateEntry_b__0(RectTransform x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.__c__DisplayClass12_0.NativeMethodInfoPtr__CreateEntry_b__0_Internal_Boolean_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F817 RID: 63511 RVA: 0x003B6DB0 File Offset: 0x003B4FB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315134, XrefRangeEnd = 315144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateEntry_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.__c__DisplayClass12_0.NativeMethodInfoPtr__CreateEntry_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F818 RID: 63512 RVA: 0x000754D0 File Offset: 0x000736D0
			public __c__DisplayClass12_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B69 RID: 19305
			// (get) Token: 0x0600F819 RID: 63513 RVA: 0x003B6DE4 File Offset: 0x003B4FE4
			// (set) Token: 0x0600F81A RID: 63514 RVA: 0x000754D9 File Offset: 0x000736D9
			public unsafe CustomerSelector __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomerSelector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B6A RID: 19306
			// (get) Token: 0x0600F81B RID: 63515 RVA: 0x003B6E14 File Offset: 0x003B5014
			// (set) Token: 0x0600F81C RID: 63516 RVA: 0x000754F8 File Offset: 0x000736F8
			public unsafe Customer customer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.__c__DisplayClass12_0.NativeFieldInfoPtr_customer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.__c__DisplayClass12_0.NativeFieldInfoPtr_customer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A7B4 RID: 42932
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A7B5 RID: 42933
			private static readonly IntPtr NativeFieldInfoPtr_customer;

			// Token: 0x0400A7B6 RID: 42934
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A7B7 RID: 42935
			private static readonly IntPtr NativeMethodInfoPtr__CreateEntry_b__0_Internal_Boolean_RectTransform_0;

			// Token: 0x0400A7B8 RID: 42936
			private static readonly IntPtr NativeMethodInfoPtr__CreateEntry_b__1_Internal_Void_0;
		}
	}
}
