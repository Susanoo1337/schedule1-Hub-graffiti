using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Quests;
using Il2CppScheduleOne.UI.Handover;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.NPCs
{
	// Token: 0x020005CC RID: 1484
	public class Billy : NPC
	{
		// Token: 0x06008FB5 RID: 36789 RVA: 0x0026E810 File Offset: 0x0026CA10
		// Note: this type is marked as 'beforefieldinit'.
		static Billy()
		{
			Il2CppClassPointerStore<Billy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs", "Billy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Billy>.NativeClassPtr);
			Billy.NativeFieldInfoPtr_REQUESTED_PRODUCT_AMOUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Billy>.NativeClassPtr, "REQUESTED_PRODUCT_AMOUNT");
			Billy.NativeFieldInfoPtr_REQUESTED_PRODUCT_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Billy>.NativeClassPtr, "REQUESTED_PRODUCT_ID");
			Billy.NativeFieldInfoPtr_TradeContract = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Billy>.NativeClassPtr, "TradeContract");
			Billy.NativeFieldInfoPtr_RDXDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Billy>.NativeClassPtr, "RDXDefinition");
			Billy.NativeFieldInfoPtr_customerComp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Billy>.NativeClassPtr, "customerComp");
			Billy.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Billy>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.BillyAssembly-CSharp.dll_Excuted");
			Billy.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Billy>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.BillyAssembly-CSharp.dll_Excuted");
			Billy.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Billy>.NativeClassPtr, 100681921);
			Billy.NativeMethodInfoPtr_OpenRDXTradeHandover_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Billy>.NativeClassPtr, 100681922);
			Billy.NativeMethodInfoPtr_HandoverOutcome_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Billy>.NativeClassPtr, 100681923);
			Billy.NativeMethodInfoPtr_GetSucccessChance_Private_Single_List_1_ItemInstance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Billy>.NativeClassPtr, 100681924);
			Billy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Billy>.NativeClassPtr, 100681925);
			Billy.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Billy>.NativeClassPtr, 100681926);
			Billy.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Billy>.NativeClassPtr, 100681927);
			Billy.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Billy>.NativeClassPtr, 100681928);
			Billy.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Billy>.NativeClassPtr, 100681929);
		}

		// Token: 0x06008FB6 RID: 36790 RVA: 0x0026E980 File Offset: 0x0026CB80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263528, XrefRangeEnd = 263529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Billy.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008FB7 RID: 36791 RVA: 0x0026E9BC File Offset: 0x0026CBBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263529, XrefRangeEnd = 263554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenRDXTradeHandover()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Billy.NativeMethodInfoPtr_OpenRDXTradeHandover_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008FB8 RID: 36792 RVA: 0x0026E9F0 File Offset: 0x0026CBF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263554, XrefRangeEnd = 263572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandoverOutcome(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> givenItems, float payment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref outcome;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(givenItems);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref payment;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Billy.NativeMethodInfoPtr_HandoverOutcome_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008FB9 RID: 36793 RVA: 0x0026EA50 File Offset: 0x0026CC50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263572, XrefRangeEnd = 263594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetSucccessChance(List<ItemInstance> items, float price)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref price;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Billy.NativeMethodInfoPtr_GetSucccessChance_Private_Single_List_1_ItemInstance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008FBA RID: 36794 RVA: 0x0026EAAC File Offset: 0x0026CCAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263594, XrefRangeEnd = 263595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Billy() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Billy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Billy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008FBB RID: 36795 RVA: 0x0026EAE8 File Offset: 0x0026CCE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263595, XrefRangeEnd = 263596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Billy.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008FBC RID: 36796 RVA: 0x0026EB24 File Offset: 0x0026CD24
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Billy.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008FBD RID: 36797 RVA: 0x0026EB60 File Offset: 0x0026CD60
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Billy.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008FBE RID: 36798 RVA: 0x0026EB9C File Offset: 0x0026CD9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 263630, RefRangeEnd = 263631, XrefRangeStart = 263596, XrefRangeEnd = 263630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Billy.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008FBF RID: 36799 RVA: 0x00043E76 File Offset: 0x00042076
		public Billy(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C83 RID: 11395
		// (get) Token: 0x06008FC0 RID: 36800 RVA: 0x0026EBD8 File Offset: 0x0026CDD8
		// (set) Token: 0x06008FC1 RID: 36801 RVA: 0x00043E7F File Offset: 0x0004207F
		public unsafe static int REQUESTED_PRODUCT_AMOUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Billy.NativeFieldInfoPtr_REQUESTED_PRODUCT_AMOUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Billy.NativeFieldInfoPtr_REQUESTED_PRODUCT_AMOUNT, (void*)(&value));
			}
		}

		// Token: 0x17002C84 RID: 11396
		// (get) Token: 0x06008FC2 RID: 36802 RVA: 0x0026EBF4 File Offset: 0x0026CDF4
		// (set) Token: 0x06008FC3 RID: 36803 RVA: 0x00043E8D File Offset: 0x0004208D
		public unsafe static string REQUESTED_PRODUCT_ID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Billy.NativeFieldInfoPtr_REQUESTED_PRODUCT_ID, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Billy.NativeFieldInfoPtr_REQUESTED_PRODUCT_ID, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002C85 RID: 11397
		// (get) Token: 0x06008FC4 RID: 36804 RVA: 0x0026EC14 File Offset: 0x0026CE14
		// (set) Token: 0x06008FC5 RID: 36805 RVA: 0x00043E9F File Offset: 0x0004209F
		public unsafe Contract TradeContract
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Billy.NativeFieldInfoPtr_TradeContract);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Contract>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Billy.NativeFieldInfoPtr_TradeContract), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C86 RID: 11398
		// (get) Token: 0x06008FC6 RID: 36806 RVA: 0x0026EC44 File Offset: 0x0026CE44
		// (set) Token: 0x06008FC7 RID: 36807 RVA: 0x00043EBE File Offset: 0x000420BE
		public unsafe ItemDefinition RDXDefinition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Billy.NativeFieldInfoPtr_RDXDefinition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Billy.NativeFieldInfoPtr_RDXDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C87 RID: 11399
		// (get) Token: 0x06008FC8 RID: 36808 RVA: 0x0026EC74 File Offset: 0x0026CE74
		// (set) Token: 0x06008FC9 RID: 36809 RVA: 0x00043EDD File Offset: 0x000420DD
		public unsafe Customer customerComp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Billy.NativeFieldInfoPtr_customerComp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Billy.NativeFieldInfoPtr_customerComp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C88 RID: 11400
		// (get) Token: 0x06008FCA RID: 36810 RVA: 0x0026ECA4 File Offset: 0x0026CEA4
		// (set) Token: 0x06008FCB RID: 36811 RVA: 0x00043EFC File Offset: 0x000420FC
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Billy.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Billy.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002C89 RID: 11401
		// (get) Token: 0x06008FCC RID: 36812 RVA: 0x0026ECCC File Offset: 0x0026CECC
		// (set) Token: 0x06008FCD RID: 36813 RVA: 0x00043F17 File Offset: 0x00042117
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Billy.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Billy.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400629B RID: 25243
		private static readonly IntPtr NativeFieldInfoPtr_REQUESTED_PRODUCT_AMOUNT;

		// Token: 0x0400629C RID: 25244
		private static readonly IntPtr NativeFieldInfoPtr_REQUESTED_PRODUCT_ID;

		// Token: 0x0400629D RID: 25245
		private static readonly IntPtr NativeFieldInfoPtr_TradeContract;

		// Token: 0x0400629E RID: 25246
		private static readonly IntPtr NativeFieldInfoPtr_RDXDefinition;

		// Token: 0x0400629F RID: 25247
		private static readonly IntPtr NativeFieldInfoPtr_customerComp;

		// Token: 0x040062A0 RID: 25248
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040062A1 RID: 25249
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040062A2 RID: 25250
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040062A3 RID: 25251
		private static readonly IntPtr NativeMethodInfoPtr_OpenRDXTradeHandover_Public_Void_0;

		// Token: 0x040062A4 RID: 25252
		private static readonly IntPtr NativeMethodInfoPtr_HandoverOutcome_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_0;

		// Token: 0x040062A5 RID: 25253
		private static readonly IntPtr NativeMethodInfoPtr_GetSucccessChance_Private_Single_List_1_ItemInstance_Single_0;

		// Token: 0x040062A6 RID: 25254
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040062A7 RID: 25255
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040062A8 RID: 25256
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040062A9 RID: 25257
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040062AA RID: 25258
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;
	}
}
