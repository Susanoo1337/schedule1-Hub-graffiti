using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.UI.Input;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Combat
{
	// Token: 0x020006F9 RID: 1785
	public class CombatManager : NetworkSingleton<CombatManager>
	{
		// Token: 0x0600ABF4 RID: 44020 RVA: 0x002D435C File Offset: 0x002D255C
		// Note: this type is marked as 'beforefieldinit'.
		static CombatManager()
		{
			Il2CppClassPointerStore<CombatManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Combat", "CombatManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatManager>.NativeClassPtr);
			CombatManager.NativeFieldInfoPtr_MeleeLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, "MeleeLayerMask");
			CombatManager.NativeFieldInfoPtr_ExplosionLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, "ExplosionLayerMask");
			CombatManager.NativeFieldInfoPtr_RangedWeaponLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, "RangedWeaponLayerMask");
			CombatManager.NativeFieldInfoPtr_ExplosionPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, "ExplosionPrefab");
			CombatManager.NativeFieldInfoPtr_RangedWeaponInputPrompts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, "RangedWeaponInputPrompts");
			CombatManager.NativeFieldInfoPtr_explosionIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, "explosionIDs");
			CombatManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Combat.CombatManagerAssembly-CSharp.dll_Excuted");
			CombatManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Combat.CombatManagerAssembly-CSharp.dll_Excuted");
			CombatManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100686000);
			CombatManager.NativeMethodInfoPtr_CreateExplosion_Public_Void_Vector3_ExplosionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100686001);
			CombatManager.NativeMethodInfoPtr_CreateExplosion_Private_Void_Vector3_ExplosionData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100686002);
			CombatManager.NativeMethodInfoPtr_Explosion_Private_Void_Vector3_ExplosionData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100686003);
			CombatManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100686004);
			CombatManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100686005);
			CombatManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100686006);
			CombatManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100686007);
			CombatManager.NativeMethodInfoPtr_RpcWriter___Server_CreateExplosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100686008);
			CombatManager.NativeMethodInfoPtr_RpcLogic___CreateExplosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100686009);
			CombatManager.NativeMethodInfoPtr_RpcReader___Server_CreateExplosion_2907189355_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100686010);
			CombatManager.NativeMethodInfoPtr_RpcWriter___Observers_Explosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100686011);
			CombatManager.NativeMethodInfoPtr_RpcLogic___Explosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100686012);
			CombatManager.NativeMethodInfoPtr_RpcReader___Observers_Explosion_2907189355_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100686013);
			CombatManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100686014);
		}

		// Token: 0x0600ABF5 RID: 44021 RVA: 0x002D4558 File Offset: 0x002D2758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295199, XrefRangeEnd = 295202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ABF6 RID: 44022 RVA: 0x002D4594 File Offset: 0x002D2794
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 295204, RefRangeEnd = 295208, XrefRangeStart = 295202, XrefRangeEnd = 295204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateExplosion(Vector3 origin, ExplosionData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatManager.NativeMethodInfoPtr_CreateExplosion_Public_Void_Vector3_ExplosionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ABF7 RID: 44023 RVA: 0x002D45E0 File Offset: 0x002D27E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 295234, RefRangeEnd = 295236, XrefRangeStart = 295208, XrefRangeEnd = 295234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateExplosion(Vector3 origin, ExplosionData data, int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatManager.NativeMethodInfoPtr_CreateExplosion_Private_Void_Vector3_ExplosionData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ABF8 RID: 44024 RVA: 0x002D463C File Offset: 0x002D283C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 295262, RefRangeEnd = 295265, XrefRangeStart = 295236, XrefRangeEnd = 295262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Explosion(Vector3 origin, ExplosionData data, int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatManager.NativeMethodInfoPtr_Explosion_Private_Void_Vector3_ExplosionData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ABF9 RID: 44025 RVA: 0x002D4698 File Offset: 0x002D2898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295265, XrefRangeEnd = 295278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CombatManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ABFA RID: 44026 RVA: 0x002D46D4 File Offset: 0x002D28D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295278, XrefRangeEnd = 295295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ABFB RID: 44027 RVA: 0x002D4710 File Offset: 0x002D2910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295295, XrefRangeEnd = 295298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ABFC RID: 44028 RVA: 0x002D474C File Offset: 0x002D294C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ABFD RID: 44029 RVA: 0x002D4788 File Offset: 0x002D2988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295298, XrefRangeEnd = 295313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_CreateExplosion_2907189355(Vector3 origin, ExplosionData data, int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatManager.NativeMethodInfoPtr_RpcWriter___Server_CreateExplosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ABFE RID: 44030 RVA: 0x002D47E4 File Offset: 0x002D29E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295313, XrefRangeEnd = 295314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___CreateExplosion_2907189355(Vector3 origin, ExplosionData data, int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatManager.NativeMethodInfoPtr_RpcLogic___CreateExplosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ABFF RID: 44031 RVA: 0x002D4840 File Offset: 0x002D2A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295314, XrefRangeEnd = 295323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_CreateExplosion_2907189355(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatManager.NativeMethodInfoPtr_RpcReader___Server_CreateExplosion_2907189355_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC00 RID: 44032 RVA: 0x002D48A4 File Offset: 0x002D2AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295323, XrefRangeEnd = 295338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Explosion_2907189355(Vector3 origin, ExplosionData data, int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatManager.NativeMethodInfoPtr_RpcWriter___Observers_Explosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC01 RID: 44033 RVA: 0x002D4900 File Offset: 0x002D2B00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 295354, RefRangeEnd = 295356, XrefRangeStart = 295338, XrefRangeEnd = 295354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Explosion_2907189355(Vector3 origin, ExplosionData data, int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatManager.NativeMethodInfoPtr_RpcLogic___Explosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC02 RID: 44034 RVA: 0x002D495C File Offset: 0x002D2B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295356, XrefRangeEnd = 295365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Explosion_2907189355(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatManager.NativeMethodInfoPtr_RpcReader___Observers_Explosion_2907189355_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC03 RID: 44035 RVA: 0x002D49AC File Offset: 0x002D2BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295365, XrefRangeEnd = 295368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC04 RID: 44036 RVA: 0x0004E9EA File Offset: 0x0004CBEA
		public CombatManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003386 RID: 13190
		// (get) Token: 0x0600AC05 RID: 44037 RVA: 0x002D49E8 File Offset: 0x002D2BE8
		// (set) Token: 0x0600AC06 RID: 44038 RVA: 0x0004E9F3 File Offset: 0x0004CBF3
		public unsafe LayerMask MeleeLayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_MeleeLayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_MeleeLayerMask)) = value;
			}
		}

		// Token: 0x17003387 RID: 13191
		// (get) Token: 0x0600AC07 RID: 44039 RVA: 0x002D4A10 File Offset: 0x002D2C10
		// (set) Token: 0x0600AC08 RID: 44040 RVA: 0x0004EA0E File Offset: 0x0004CC0E
		public unsafe LayerMask ExplosionLayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_ExplosionLayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_ExplosionLayerMask)) = value;
			}
		}

		// Token: 0x17003388 RID: 13192
		// (get) Token: 0x0600AC09 RID: 44041 RVA: 0x002D4A38 File Offset: 0x002D2C38
		// (set) Token: 0x0600AC0A RID: 44042 RVA: 0x0004EA29 File Offset: 0x0004CC29
		public unsafe LayerMask RangedWeaponLayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_RangedWeaponLayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_RangedWeaponLayerMask)) = value;
			}
		}

		// Token: 0x17003389 RID: 13193
		// (get) Token: 0x0600AC0B RID: 44043 RVA: 0x002D4A60 File Offset: 0x002D2C60
		// (set) Token: 0x0600AC0C RID: 44044 RVA: 0x0004EA44 File Offset: 0x0004CC44
		public unsafe Explosion ExplosionPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_ExplosionPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Explosion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_ExplosionPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700338A RID: 13194
		// (get) Token: 0x0600AC0D RID: 44045 RVA: 0x002D4A90 File Offset: 0x002D2C90
		// (set) Token: 0x0600AC0E RID: 44046 RVA: 0x0004EA63 File Offset: 0x0004CC63
		public unsafe InputPromptsData RangedWeaponInputPrompts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_RangedWeaponInputPrompts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPromptsData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_RangedWeaponInputPrompts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700338B RID: 13195
		// (get) Token: 0x0600AC0F RID: 44047 RVA: 0x002D4AC0 File Offset: 0x002D2CC0
		// (set) Token: 0x0600AC10 RID: 44048 RVA: 0x0004EA82 File Offset: 0x0004CC82
		public unsafe List<int> explosionIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_explosionIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_explosionIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700338C RID: 13196
		// (get) Token: 0x0600AC11 RID: 44049 RVA: 0x002D4AF0 File Offset: 0x002D2CF0
		// (set) Token: 0x0600AC12 RID: 44050 RVA: 0x0004EAA1 File Offset: 0x0004CCA1
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700338D RID: 13197
		// (get) Token: 0x0600AC13 RID: 44051 RVA: 0x002D4B18 File Offset: 0x002D2D18
		// (set) Token: 0x0600AC14 RID: 44052 RVA: 0x0004EABC File Offset: 0x0004CCBC
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040076AD RID: 30381
		private static readonly IntPtr NativeFieldInfoPtr_MeleeLayerMask;

		// Token: 0x040076AE RID: 30382
		private static readonly IntPtr NativeFieldInfoPtr_ExplosionLayerMask;

		// Token: 0x040076AF RID: 30383
		private static readonly IntPtr NativeFieldInfoPtr_RangedWeaponLayerMask;

		// Token: 0x040076B0 RID: 30384
		private static readonly IntPtr NativeFieldInfoPtr_ExplosionPrefab;

		// Token: 0x040076B1 RID: 30385
		private static readonly IntPtr NativeFieldInfoPtr_RangedWeaponInputPrompts;

		// Token: 0x040076B2 RID: 30386
		private static readonly IntPtr NativeFieldInfoPtr_explosionIDs;

		// Token: 0x040076B3 RID: 30387
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040076B4 RID: 30388
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040076B5 RID: 30389
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040076B6 RID: 30390
		private static readonly IntPtr NativeMethodInfoPtr_CreateExplosion_Public_Void_Vector3_ExplosionData_0;

		// Token: 0x040076B7 RID: 30391
		private static readonly IntPtr NativeMethodInfoPtr_CreateExplosion_Private_Void_Vector3_ExplosionData_Int32_0;

		// Token: 0x040076B8 RID: 30392
		private static readonly IntPtr NativeMethodInfoPtr_Explosion_Private_Void_Vector3_ExplosionData_Int32_0;

		// Token: 0x040076B9 RID: 30393
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040076BA RID: 30394
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040076BB RID: 30395
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040076BC RID: 30396
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040076BD RID: 30397
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_CreateExplosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0;

		// Token: 0x040076BE RID: 30398
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___CreateExplosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0;

		// Token: 0x040076BF RID: 30399
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_CreateExplosion_2907189355_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040076C0 RID: 30400
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Explosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0;

		// Token: 0x040076C1 RID: 30401
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Explosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0;

		// Token: 0x040076C2 RID: 30402
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Explosion_2907189355_Private_Void_PooledReader_Channel_0;

		// Token: 0x040076C3 RID: 30403
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;
	}
}
