using System;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000729 RID: 1833
	public class DailySummary : NetworkSingleton<DailySummary>
	{
		// Token: 0x0600B095 RID: 45205 RVA: 0x002E2658 File Offset: 0x002E0858
		// Note: this type is marked as 'beforefieldinit'.
		static DailySummary()
		{
			Il2CppClassPointerStore<DailySummary>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "DailySummary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailySummary>.NativeClassPtr);
			DailySummary.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "<IsOpen>k__BackingField");
			DailySummary.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "Canvas");
			DailySummary.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "Container");
			DailySummary.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "Anim");
			DailySummary.NativeFieldInfoPtr_TitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "TitleLabel");
			DailySummary.NativeFieldInfoPtr_ProductEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "ProductEntries");
			DailySummary.NativeFieldInfoPtr_PlayerEarningsLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "PlayerEarningsLabel");
			DailySummary.NativeFieldInfoPtr_DealerEarningsLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "DealerEarningsLabel");
			DailySummary.NativeFieldInfoPtr_XPGainedLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "XPGainedLabel");
			DailySummary.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "State");
			DailySummary.NativeFieldInfoPtr_onClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "onClosed");
			DailySummary.NativeFieldInfoPtr_itemsSoldByPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "itemsSoldByPlayer");
			DailySummary.NativeFieldInfoPtr_moneyEarnedByPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "moneyEarnedByPlayer");
			DailySummary.NativeFieldInfoPtr_moneyEarnedByDealers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "moneyEarnedByDealers");
			DailySummary.NativeFieldInfoPtr__xpGained_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "<xpGained>k__BackingField");
			DailySummary.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.UI.DailySummaryAssembly-CSharp.dll_Excuted");
			DailySummary.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.UI.DailySummaryAssembly-CSharp.dll_Excuted");
			DailySummary.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100686513);
			DailySummary.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100686514);
			DailySummary.NativeMethodInfoPtr_get_xpGained_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100686515);
			DailySummary.NativeMethodInfoPtr_set_xpGained_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100686516);
			DailySummary.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100686517);
			DailySummary.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100686518);
			DailySummary.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100686519);
			DailySummary.NativeMethodInfoPtr_SleepEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100686520);
			DailySummary.NativeMethodInfoPtr_AddSoldItem_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100686521);
			DailySummary.NativeMethodInfoPtr_AddPlayerMoney_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100686522);
			DailySummary.NativeMethodInfoPtr_AddDealerMoney_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100686523);
			DailySummary.NativeMethodInfoPtr_AddXP_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100686524);
			DailySummary.NativeMethodInfoPtr_ClearStats_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100686525);
			DailySummary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100686526);
			DailySummary.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100686527);
			DailySummary.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100686528);
			DailySummary.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100686529);
			DailySummary.NativeMethodInfoPtr_RpcWriter___Observers_AddSoldItem_3643459082_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100686530);
			DailySummary.NativeMethodInfoPtr_RpcLogic___AddSoldItem_3643459082_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100686531);
			DailySummary.NativeMethodInfoPtr_RpcReader___Observers_AddSoldItem_3643459082_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100686532);
			DailySummary.NativeMethodInfoPtr_RpcWriter___Observers_AddPlayerMoney_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100686533);
			DailySummary.NativeMethodInfoPtr_RpcLogic___AddPlayerMoney_431000436_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100686534);
			DailySummary.NativeMethodInfoPtr_RpcReader___Observers_AddPlayerMoney_431000436_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100686535);
			DailySummary.NativeMethodInfoPtr_RpcWriter___Observers_AddDealerMoney_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100686536);
			DailySummary.NativeMethodInfoPtr_RpcLogic___AddDealerMoney_431000436_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100686537);
			DailySummary.NativeMethodInfoPtr_RpcReader___Observers_AddDealerMoney_431000436_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100686538);
			DailySummary.NativeMethodInfoPtr_RpcWriter___Observers_AddXP_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100686539);
			DailySummary.NativeMethodInfoPtr_RpcLogic___AddXP_3316948804_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100686540);
			DailySummary.NativeMethodInfoPtr_RpcReader___Observers_AddXP_3316948804_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100686541);
			DailySummary.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100686542);
		}

		// Token: 0x1700351B RID: 13595
		// (get) Token: 0x0600B096 RID: 45206 RVA: 0x002E2A34 File Offset: 0x002E0C34
		// (set) Token: 0x0600B097 RID: 45207 RVA: 0x002E2A70 File Offset: 0x002E0C70
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700351C RID: 13596
		// (get) Token: 0x0600B098 RID: 45208 RVA: 0x002E2AB0 File Offset: 0x002E0CB0
		// (set) Token: 0x0600B099 RID: 45209 RVA: 0x002E2AEC File Offset: 0x002E0CEC
		public unsafe int xpGained
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_get_xpGained_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_set_xpGained_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B09A RID: 45210 RVA: 0x002E2B2C File Offset: 0x002E0D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300055, XrefRangeEnd = 300084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailySummary.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B09B RID: 45211 RVA: 0x002E2B68 File Offset: 0x002E0D68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 300166, RefRangeEnd = 300167, XrefRangeStart = 300084, XrefRangeEnd = 300166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B09C RID: 45212 RVA: 0x002E2B9C File Offset: 0x002E0D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300167, XrefRangeEnd = 300178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B09D RID: 45213 RVA: 0x002E2BD0 File Offset: 0x002E0DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300178, XrefRangeEnd = 300181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SleepEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_SleepEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B09E RID: 45214 RVA: 0x002E2C04 File Offset: 0x002E0E04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 300182, RefRangeEnd = 300183, XrefRangeStart = 300181, XrefRangeEnd = 300182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSoldItem(string id, int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_AddSoldItem_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B09F RID: 45215 RVA: 0x002E2C54 File Offset: 0x002E0E54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 300193, RefRangeEnd = 300194, XrefRangeStart = 300183, XrefRangeEnd = 300193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPlayerMoney(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_AddPlayerMoney_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B0A0 RID: 45216 RVA: 0x002E2C94 File Offset: 0x002E0E94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 300204, RefRangeEnd = 300205, XrefRangeStart = 300194, XrefRangeEnd = 300204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDealerMoney(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_AddDealerMoney_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B0A1 RID: 45217 RVA: 0x002E2CD4 File Offset: 0x002E0ED4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 300216, RefRangeEnd = 300217, XrefRangeStart = 300205, XrefRangeEnd = 300216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddXP(int xp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref xp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_AddXP_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B0A2 RID: 45218 RVA: 0x002E2D14 File Offset: 0x002E0F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearStats()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_ClearStats_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B0A3 RID: 45219 RVA: 0x002E2D48 File Offset: 0x002E0F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300217, XrefRangeEnd = 300227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DailySummary() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailySummary>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B0A4 RID: 45220 RVA: 0x002E2D84 File Offset: 0x002E0F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300227, XrefRangeEnd = 300255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailySummary.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B0A5 RID: 45221 RVA: 0x002E2DC0 File Offset: 0x002E0FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300255, XrefRangeEnd = 300258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailySummary.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B0A6 RID: 45222 RVA: 0x002E2DFC File Offset: 0x002E0FFC
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailySummary.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B0A7 RID: 45223 RVA: 0x002E2E38 File Offset: 0x002E1038
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 300280, RefRangeEnd = 300281, XrefRangeStart = 300258, XrefRangeEnd = 300280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddSoldItem_3643459082(string id, int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcWriter___Observers_AddSoldItem_3643459082_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B0A8 RID: 45224 RVA: 0x002E2E88 File Offset: 0x002E1088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300281, XrefRangeEnd = 300294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AddSoldItem_3643459082(string id, int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcLogic___AddSoldItem_3643459082_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B0A9 RID: 45225 RVA: 0x002E2ED8 File Offset: 0x002E10D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300294, XrefRangeEnd = 300306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddSoldItem_3643459082(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcReader___Observers_AddSoldItem_3643459082_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B0AA RID: 45226 RVA: 0x002E2F28 File Offset: 0x002E1128
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 300193, RefRangeEnd = 300194, XrefRangeStart = 300193, XrefRangeEnd = 300194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddPlayerMoney_431000436(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcWriter___Observers_AddPlayerMoney_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B0AB RID: 45227 RVA: 0x002E2F68 File Offset: 0x002E1168
		[CallerCount(0)]
		public unsafe void RpcLogic___AddPlayerMoney_431000436(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcLogic___AddPlayerMoney_431000436_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B0AC RID: 45228 RVA: 0x002E2FA8 File Offset: 0x002E11A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300306, XrefRangeEnd = 300308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddPlayerMoney_431000436(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcReader___Observers_AddPlayerMoney_431000436_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B0AD RID: 45229 RVA: 0x002E2FF8 File Offset: 0x002E11F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 300204, RefRangeEnd = 300205, XrefRangeStart = 300204, XrefRangeEnd = 300205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddDealerMoney_431000436(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcWriter___Observers_AddDealerMoney_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B0AE RID: 45230 RVA: 0x002E3038 File Offset: 0x002E1238
		[CallerCount(0)]
		public unsafe void RpcLogic___AddDealerMoney_431000436(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcLogic___AddDealerMoney_431000436_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B0AF RID: 45231 RVA: 0x002E3078 File Offset: 0x002E1278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300308, XrefRangeEnd = 300310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddDealerMoney_431000436(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcReader___Observers_AddDealerMoney_431000436_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B0B0 RID: 45232 RVA: 0x002E30C8 File Offset: 0x002E12C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 300216, RefRangeEnd = 300217, XrefRangeStart = 300216, XrefRangeEnd = 300217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddXP_3316948804(int xp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref xp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcWriter___Observers_AddXP_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B0B1 RID: 45233 RVA: 0x002E3108 File Offset: 0x002E1308
		[CallerCount(0)]
		public unsafe void RpcLogic___AddXP_3316948804(int xp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref xp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcLogic___AddXP_3316948804_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B0B2 RID: 45234 RVA: 0x002E3148 File Offset: 0x002E1348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300310, XrefRangeEnd = 300313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddXP_3316948804(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcReader___Observers_AddXP_3316948804_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B0B3 RID: 45235 RVA: 0x002E3198 File Offset: 0x002E1398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300313, XrefRangeEnd = 300316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailySummary.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B0B4 RID: 45236 RVA: 0x0005117D File Offset: 0x0004F37D
		public DailySummary(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700350A RID: 13578
		// (get) Token: 0x0600B0B5 RID: 45237 RVA: 0x002E31D4 File Offset: 0x002E13D4
		// (set) Token: 0x0600B0B6 RID: 45238 RVA: 0x00051186 File Offset: 0x0004F386
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x1700350B RID: 13579
		// (get) Token: 0x0600B0B7 RID: 45239 RVA: 0x002E31FC File Offset: 0x002E13FC
		// (set) Token: 0x0600B0B8 RID: 45240 RVA: 0x000511A1 File Offset: 0x0004F3A1
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700350C RID: 13580
		// (get) Token: 0x0600B0B9 RID: 45241 RVA: 0x002E322C File Offset: 0x002E142C
		// (set) Token: 0x0600B0BA RID: 45242 RVA: 0x000511C0 File Offset: 0x0004F3C0
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700350D RID: 13581
		// (get) Token: 0x0600B0BB RID: 45243 RVA: 0x002E325C File Offset: 0x002E145C
		// (set) Token: 0x0600B0BC RID: 45244 RVA: 0x000511DF File Offset: 0x0004F3DF
		public unsafe Animation Anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_Anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700350E RID: 13582
		// (get) Token: 0x0600B0BD RID: 45245 RVA: 0x002E328C File Offset: 0x002E148C
		// (set) Token: 0x0600B0BE RID: 45246 RVA: 0x000511FE File Offset: 0x0004F3FE
		public unsafe TextMeshProUGUI TitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_TitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_TitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700350F RID: 13583
		// (get) Token: 0x0600B0BF RID: 45247 RVA: 0x002E32BC File Offset: 0x002E14BC
		// (set) Token: 0x0600B0C0 RID: 45248 RVA: 0x0005121D File Offset: 0x0004F41D
		public unsafe Il2CppReferenceArray<RectTransform> ProductEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_ProductEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_ProductEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003510 RID: 13584
		// (get) Token: 0x0600B0C1 RID: 45249 RVA: 0x002E32EC File Offset: 0x002E14EC
		// (set) Token: 0x0600B0C2 RID: 45250 RVA: 0x0005123C File Offset: 0x0004F43C
		public unsafe TextMeshProUGUI PlayerEarningsLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_PlayerEarningsLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_PlayerEarningsLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003511 RID: 13585
		// (get) Token: 0x0600B0C3 RID: 45251 RVA: 0x002E331C File Offset: 0x002E151C
		// (set) Token: 0x0600B0C4 RID: 45252 RVA: 0x0005125B File Offset: 0x0004F45B
		public unsafe TextMeshProUGUI DealerEarningsLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_DealerEarningsLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_DealerEarningsLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003512 RID: 13586
		// (get) Token: 0x0600B0C5 RID: 45253 RVA: 0x002E334C File Offset: 0x002E154C
		// (set) Token: 0x0600B0C6 RID: 45254 RVA: 0x0005127A File Offset: 0x0004F47A
		public unsafe TextMeshProUGUI XPGainedLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_XPGainedLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_XPGainedLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003513 RID: 13587
		// (get) Token: 0x0600B0C7 RID: 45255 RVA: 0x002E337C File Offset: 0x002E157C
		// (set) Token: 0x0600B0C8 RID: 45256 RVA: 0x00051299 File Offset: 0x0004F499
		public unsafe UIScreenMonoState State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_State);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScreenMonoState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_State), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003514 RID: 13588
		// (get) Token: 0x0600B0C9 RID: 45257 RVA: 0x002E33AC File Offset: 0x002E15AC
		// (set) Token: 0x0600B0CA RID: 45258 RVA: 0x000512B8 File Offset: 0x0004F4B8
		public unsafe UnityEvent onClosed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_onClosed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_onClosed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003515 RID: 13589
		// (get) Token: 0x0600B0CB RID: 45259 RVA: 0x002E33DC File Offset: 0x002E15DC
		// (set) Token: 0x0600B0CC RID: 45260 RVA: 0x000512D7 File Offset: 0x0004F4D7
		public unsafe Dictionary<string, int> itemsSoldByPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_itemsSoldByPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_itemsSoldByPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003516 RID: 13590
		// (get) Token: 0x0600B0CD RID: 45261 RVA: 0x002E340C File Offset: 0x002E160C
		// (set) Token: 0x0600B0CE RID: 45262 RVA: 0x000512F6 File Offset: 0x0004F4F6
		public unsafe float moneyEarnedByPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_moneyEarnedByPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_moneyEarnedByPlayer)) = value;
			}
		}

		// Token: 0x17003517 RID: 13591
		// (get) Token: 0x0600B0CF RID: 45263 RVA: 0x002E3434 File Offset: 0x002E1634
		// (set) Token: 0x0600B0D0 RID: 45264 RVA: 0x00051311 File Offset: 0x0004F511
		public unsafe float moneyEarnedByDealers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_moneyEarnedByDealers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_moneyEarnedByDealers)) = value;
			}
		}

		// Token: 0x17003518 RID: 13592
		// (get) Token: 0x0600B0D1 RID: 45265 RVA: 0x002E345C File Offset: 0x002E165C
		// (set) Token: 0x0600B0D2 RID: 45266 RVA: 0x0005132C File Offset: 0x0004F52C
		public unsafe int _xpGained_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr__xpGained_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr__xpGained_k__BackingField)) = value;
			}
		}

		// Token: 0x17003519 RID: 13593
		// (get) Token: 0x0600B0D3 RID: 45267 RVA: 0x002E3484 File Offset: 0x002E1684
		// (set) Token: 0x0600B0D4 RID: 45268 RVA: 0x00051347 File Offset: 0x0004F547
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700351A RID: 13594
		// (get) Token: 0x0600B0D5 RID: 45269 RVA: 0x002E34AC File Offset: 0x002E16AC
		// (set) Token: 0x0600B0D6 RID: 45270 RVA: 0x00051362 File Offset: 0x0004F562
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040079B2 RID: 31154
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x040079B3 RID: 31155
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x040079B4 RID: 31156
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040079B5 RID: 31157
		private static readonly IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x040079B6 RID: 31158
		private static readonly IntPtr NativeFieldInfoPtr_TitleLabel;

		// Token: 0x040079B7 RID: 31159
		private static readonly IntPtr NativeFieldInfoPtr_ProductEntries;

		// Token: 0x040079B8 RID: 31160
		private static readonly IntPtr NativeFieldInfoPtr_PlayerEarningsLabel;

		// Token: 0x040079B9 RID: 31161
		private static readonly IntPtr NativeFieldInfoPtr_DealerEarningsLabel;

		// Token: 0x040079BA RID: 31162
		private static readonly IntPtr NativeFieldInfoPtr_XPGainedLabel;

		// Token: 0x040079BB RID: 31163
		private static readonly IntPtr NativeFieldInfoPtr_State;

		// Token: 0x040079BC RID: 31164
		private static readonly IntPtr NativeFieldInfoPtr_onClosed;

		// Token: 0x040079BD RID: 31165
		private static readonly IntPtr NativeFieldInfoPtr_itemsSoldByPlayer;

		// Token: 0x040079BE RID: 31166
		private static readonly IntPtr NativeFieldInfoPtr_moneyEarnedByPlayer;

		// Token: 0x040079BF RID: 31167
		private static readonly IntPtr NativeFieldInfoPtr_moneyEarnedByDealers;

		// Token: 0x040079C0 RID: 31168
		private static readonly IntPtr NativeFieldInfoPtr__xpGained_k__BackingField;

		// Token: 0x040079C1 RID: 31169
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040079C2 RID: 31170
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040079C3 RID: 31171
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x040079C4 RID: 31172
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x040079C5 RID: 31173
		private static readonly IntPtr NativeMethodInfoPtr_get_xpGained_Public_get_Int32_0;

		// Token: 0x040079C6 RID: 31174
		private static readonly IntPtr NativeMethodInfoPtr_set_xpGained_Private_set_Void_Int32_0;

		// Token: 0x040079C7 RID: 31175
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040079C8 RID: 31176
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x040079C9 RID: 31177
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x040079CA RID: 31178
		private static readonly IntPtr NativeMethodInfoPtr_SleepEnd_Private_Void_0;

		// Token: 0x040079CB RID: 31179
		private static readonly IntPtr NativeMethodInfoPtr_AddSoldItem_Public_Void_String_Int32_0;

		// Token: 0x040079CC RID: 31180
		private static readonly IntPtr NativeMethodInfoPtr_AddPlayerMoney_Public_Void_Single_0;

		// Token: 0x040079CD RID: 31181
		private static readonly IntPtr NativeMethodInfoPtr_AddDealerMoney_Public_Void_Single_0;

		// Token: 0x040079CE RID: 31182
		private static readonly IntPtr NativeMethodInfoPtr_AddXP_Public_Void_Int32_0;

		// Token: 0x040079CF RID: 31183
		private static readonly IntPtr NativeMethodInfoPtr_ClearStats_Private_Void_0;

		// Token: 0x040079D0 RID: 31184
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040079D1 RID: 31185
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040079D2 RID: 31186
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040079D3 RID: 31187
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040079D4 RID: 31188
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddSoldItem_3643459082_Private_Void_String_Int32_0;

		// Token: 0x040079D5 RID: 31189
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AddSoldItem_3643459082_Public_Void_String_Int32_0;

		// Token: 0x040079D6 RID: 31190
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddSoldItem_3643459082_Private_Void_PooledReader_Channel_0;

		// Token: 0x040079D7 RID: 31191
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddPlayerMoney_431000436_Private_Void_Single_0;

		// Token: 0x040079D8 RID: 31192
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AddPlayerMoney_431000436_Public_Void_Single_0;

		// Token: 0x040079D9 RID: 31193
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddPlayerMoney_431000436_Private_Void_PooledReader_Channel_0;

		// Token: 0x040079DA RID: 31194
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddDealerMoney_431000436_Private_Void_Single_0;

		// Token: 0x040079DB RID: 31195
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AddDealerMoney_431000436_Public_Void_Single_0;

		// Token: 0x040079DC RID: 31196
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddDealerMoney_431000436_Private_Void_PooledReader_Channel_0;

		// Token: 0x040079DD RID: 31197
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddXP_3316948804_Private_Void_Int32_0;

		// Token: 0x040079DE RID: 31198
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AddXP_3316948804_Public_Void_Int32_0;

		// Token: 0x040079DF RID: 31199
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddXP_3316948804_Private_Void_PooledReader_Channel_0;

		// Token: 0x040079E0 RID: 31200
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000CBE RID: 3262
		[ObfuscatedName("ScheduleOne.UI.DailySummary+<>c__DisplayClass22_0")]
		public sealed class __c__DisplayClass22_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F433 RID: 62515 RVA: 0x003ABBE4 File Offset: 0x003A9DE4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_0()
			{
				Il2CppClassPointerStore<DailySummary.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "<>c__DisplayClass22_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailySummary.__c__DisplayClass22_0>.NativeClassPtr);
				DailySummary.__c__DisplayClass22_0.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary.__c__DisplayClass22_0>.NativeClassPtr, "items");
				DailySummary.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary.__c__DisplayClass22_0>.NativeClassPtr, "<>4__this");
				DailySummary.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary.__c__DisplayClass22_0>.NativeClassPtr, 100686543);
				DailySummary.__c__DisplayClass22_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary.__c__DisplayClass22_0>.NativeClassPtr, 100686544);
			}

			// Token: 0x0600F434 RID: 62516 RVA: 0x003ABC60 File Offset: 0x003A9E60
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailySummary.__c__DisplayClass22_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F435 RID: 62517 RVA: 0x003ABC9C File Offset: 0x003A9E9C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 300054, RefRangeEnd = 300055, XrefRangeStart = 300049, XrefRangeEnd = 300054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.__c__DisplayClass22_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600F436 RID: 62518 RVA: 0x00073516 File Offset: 0x00071716
			public __c__DisplayClass22_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A20 RID: 18976
			// (get) Token: 0x0600F437 RID: 62519 RVA: 0x003ABCDC File Offset: 0x003A9EDC
			// (set) Token: 0x0600F438 RID: 62520 RVA: 0x0007351F File Offset: 0x0007171F
			public unsafe Il2CppStringArray items
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.__c__DisplayClass22_0.NativeFieldInfoPtr_items);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.__c__DisplayClass22_0.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A21 RID: 18977
			// (get) Token: 0x0600F439 RID: 62521 RVA: 0x003ABD0C File Offset: 0x003A9F0C
			// (set) Token: 0x0600F43A RID: 62522 RVA: 0x0007353E File Offset: 0x0007173E
			public unsafe DailySummary __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DailySummary>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A558 RID: 42328
			private static readonly IntPtr NativeFieldInfoPtr_items;

			// Token: 0x0400A559 RID: 42329
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A55A RID: 42330
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A55B RID: 42331
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x02000E07 RID: 3591
			[ObfuscatedName("ScheduleOne.UI.DailySummary+<>c__DisplayClass22_0+<<Open>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x060102BC RID: 66236 RVA: 0x003D5E00 File Offset: 0x003D4000
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<DailySummary.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DailySummary.__c__DisplayClass22_0>.NativeClassPtr, "<<Open>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailySummary.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					DailySummary.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					DailySummary.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					DailySummary.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					DailySummary.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100686545);
					DailySummary.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100686546);
					DailySummary.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100686547);
					DailySummary.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100686548);
					DailySummary.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100686549);
					DailySummary.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100686550);
				}

				// Token: 0x060102BD RID: 66237 RVA: 0x003D5EE0 File Offset: 0x003D40E0
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailySummary.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060102BE RID: 66238 RVA: 0x003D5F28 File Offset: 0x003D4128
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060102BF RID: 66239 RVA: 0x003D5F5C File Offset: 0x003D415C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300038, XrefRangeEnd = 300044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004F02 RID: 20226
				// (get) Token: 0x060102C0 RID: 66240 RVA: 0x003D5F98 File Offset: 0x003D4198
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060102C1 RID: 66241 RVA: 0x003D5FD8 File Offset: 0x003D41D8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300044, XrefRangeEnd = 300049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004F03 RID: 20227
				// (get) Token: 0x060102C2 RID: 66242 RVA: 0x003D600C File Offset: 0x003D420C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060102C3 RID: 66243 RVA: 0x0007AA96 File Offset: 0x00078C96
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004EFF RID: 20223
				// (get) Token: 0x060102C4 RID: 66244 RVA: 0x003D604C File Offset: 0x003D424C
				// (set) Token: 0x060102C5 RID: 66245 RVA: 0x0007AA9F File Offset: 0x00078C9F
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004F00 RID: 20224
				// (get) Token: 0x060102C6 RID: 66246 RVA: 0x003D6074 File Offset: 0x003D4274
				// (set) Token: 0x060102C7 RID: 66247 RVA: 0x0007AABA File Offset: 0x00078CBA
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004F01 RID: 20225
				// (get) Token: 0x060102C8 RID: 66248 RVA: 0x003D60A4 File Offset: 0x003D42A4
				// (set) Token: 0x060102C9 RID: 66249 RVA: 0x0007AAD9 File Offset: 0x00078CD9
				public unsafe DailySummary.__c__DisplayClass22_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DailySummary.__c__DisplayClass22_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AE29 RID: 44585
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AE2A RID: 44586
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AE2B RID: 44587
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AE2C RID: 44588
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AE2D RID: 44589
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AE2E RID: 44590
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AE2F RID: 44591
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AE30 RID: 44592
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AE31 RID: 44593
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
