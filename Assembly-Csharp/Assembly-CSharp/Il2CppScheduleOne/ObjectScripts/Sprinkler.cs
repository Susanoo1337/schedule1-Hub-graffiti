using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x020005BA RID: 1466
	public class Sprinkler : GridItem
	{
		// Token: 0x06008D3D RID: 36157 RVA: 0x00265E54 File Offset: 0x00264054
		// Note: this type is marked as 'beforefieldinit'.
		static Sprinkler()
		{
			Il2CppClassPointerStore<Sprinkler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "Sprinkler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr);
			Sprinkler.NativeFieldInfoPtr__IsSprinkling_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, "<IsSprinkling>k__BackingField");
			Sprinkler.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, "IntObj");
			Sprinkler.NativeFieldInfoPtr_WaterParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, "WaterParticles");
			Sprinkler.NativeFieldInfoPtr_ClickSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, "ClickSound");
			Sprinkler.NativeFieldInfoPtr_WaterSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, "WaterSound");
			Sprinkler.NativeFieldInfoPtr_ApplyWaterDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, "ApplyWaterDelay");
			Sprinkler.NativeFieldInfoPtr_ParticleStopDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, "ParticleStopDelay");
			Sprinkler.NativeFieldInfoPtr_Cooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, "Cooldown");
			Sprinkler.NativeFieldInfoPtr_TilesToWater = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, "TilesToWater");
			Sprinkler.NativeFieldInfoPtr_MinTilesToWater = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, "MinTilesToWater");
			Sprinkler.NativeFieldInfoPtr_onSprinklerStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, "onSprinklerStart");
			Sprinkler.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.SprinklerAssembly-CSharp.dll_Excuted");
			Sprinkler.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.SprinklerAssembly-CSharp.dll_Excuted");
			Sprinkler.NativeMethodInfoPtr_get_IsSprinkling_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100681585);
			Sprinkler.NativeMethodInfoPtr_set_IsSprinkling_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100681586);
			Sprinkler.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100681587);
			Sprinkler.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100681588);
			Sprinkler.NativeMethodInfoPtr_CanWater_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100681589);
			Sprinkler.NativeMethodInfoPtr_SendWater_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100681590);
			Sprinkler.NativeMethodInfoPtr_Water_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100681591);
			Sprinkler.NativeMethodInfoPtr_AddWater_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100681592);
			Sprinkler.NativeMethodInfoPtr_GetPots_Protected_Virtual_New_List_1_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100681593);
			Sprinkler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100681594);
			Sprinkler.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100681595);
			Sprinkler.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100681596);
			Sprinkler.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100681597);
			Sprinkler.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100681598);
			Sprinkler.NativeMethodInfoPtr_RpcWriter___Server_SendWater_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100681599);
			Sprinkler.NativeMethodInfoPtr_RpcLogic___SendWater_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100681600);
			Sprinkler.NativeMethodInfoPtr_RpcReader___Server_SendWater_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100681601);
			Sprinkler.NativeMethodInfoPtr_RpcWriter___Observers_Water_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100681602);
			Sprinkler.NativeMethodInfoPtr_RpcLogic___Water_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100681603);
			Sprinkler.NativeMethodInfoPtr_RpcReader___Observers_Water_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100681604);
			Sprinkler.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100681605);
		}

		// Token: 0x17002BD1 RID: 11217
		// (get) Token: 0x06008D3E RID: 36158 RVA: 0x0026612C File Offset: 0x0026432C
		// (set) Token: 0x06008D3F RID: 36159 RVA: 0x00266168 File Offset: 0x00264368
		public unsafe bool IsSprinkling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr_get_IsSprinkling_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr_set_IsSprinkling_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008D40 RID: 36160 RVA: 0x002661A8 File Offset: 0x002643A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260933, XrefRangeEnd = 260934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D41 RID: 36161 RVA: 0x002661DC File Offset: 0x002643DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260934, XrefRangeEnd = 260954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D42 RID: 36162 RVA: 0x00266210 File Offset: 0x00264410
		[CallerCount(0)]
		public unsafe bool CanWater()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr_CanWater_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008D43 RID: 36163 RVA: 0x0026624C File Offset: 0x0026444C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260954, XrefRangeEnd = 260975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendWater()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr_SendWater_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D44 RID: 36164 RVA: 0x00266280 File Offset: 0x00264480
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 260996, RefRangeEnd = 260999, XrefRangeStart = 260975, XrefRangeEnd = 260996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Water()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr_Water_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D45 RID: 36165 RVA: 0x002662B4 File Offset: 0x002644B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260999, XrefRangeEnd = 261011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddWater(float normalizedAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref normalizedAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr_AddWater_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D46 RID: 36166 RVA: 0x002662F4 File Offset: 0x002644F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261011, XrefRangeEnd = 261103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<Pot> GetPots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sprinkler.NativeMethodInfoPtr_GetPots_Protected_Virtual_New_List_1_Pot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Pot>>(intPtr3) : null;
		}

		// Token: 0x06008D47 RID: 36167 RVA: 0x00266340 File Offset: 0x00264540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261103, XrefRangeEnd = 261111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sprinkler() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D48 RID: 36168 RVA: 0x0026637C File Offset: 0x0026457C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261111, XrefRangeEnd = 261116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06008D49 RID: 36169 RVA: 0x002663BC File Offset: 0x002645BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261116, XrefRangeEnd = 261131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sprinkler.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D4A RID: 36170 RVA: 0x002663F8 File Offset: 0x002645F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261131, XrefRangeEnd = 261132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sprinkler.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D4B RID: 36171 RVA: 0x00266434 File Offset: 0x00264634
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sprinkler.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D4C RID: 36172 RVA: 0x00266470 File Offset: 0x00264670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261132, XrefRangeEnd = 261141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendWater_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr_RpcWriter___Server_SendWater_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D4D RID: 36173 RVA: 0x002664A4 File Offset: 0x002646A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 260996, RefRangeEnd = 260999, XrefRangeStart = 260996, XrefRangeEnd = 260999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendWater_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr_RpcLogic___SendWater_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D4E RID: 36174 RVA: 0x002664D8 File Offset: 0x002646D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261141, XrefRangeEnd = 261144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendWater_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr_RpcReader___Server_SendWater_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D4F RID: 36175 RVA: 0x0026653C File Offset: 0x0026473C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261144, XrefRangeEnd = 261153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Water_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr_RpcWriter___Observers_Water_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D50 RID: 36176 RVA: 0x00266570 File Offset: 0x00264770
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 261159, RefRangeEnd = 261162, XrefRangeStart = 261153, XrefRangeEnd = 261159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Water_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr_RpcLogic___Water_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D51 RID: 36177 RVA: 0x002665A4 File Offset: 0x002647A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261162, XrefRangeEnd = 261165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Water_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr_RpcReader___Observers_Water_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D52 RID: 36178 RVA: 0x002665F4 File Offset: 0x002647F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sprinkler.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D53 RID: 36179 RVA: 0x00042C2E File Offset: 0x00040E2E
		public Sprinkler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002BC4 RID: 11204
		// (get) Token: 0x06008D54 RID: 36180 RVA: 0x00266630 File Offset: 0x00264830
		// (set) Token: 0x06008D55 RID: 36181 RVA: 0x00042C37 File Offset: 0x00040E37
		public unsafe bool _IsSprinkling_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr__IsSprinkling_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr__IsSprinkling_k__BackingField)) = value;
			}
		}

		// Token: 0x17002BC5 RID: 11205
		// (get) Token: 0x06008D56 RID: 36182 RVA: 0x00266658 File Offset: 0x00264858
		// (set) Token: 0x06008D57 RID: 36183 RVA: 0x00042C52 File Offset: 0x00040E52
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BC6 RID: 11206
		// (get) Token: 0x06008D58 RID: 36184 RVA: 0x00266688 File Offset: 0x00264888
		// (set) Token: 0x06008D59 RID: 36185 RVA: 0x00042C71 File Offset: 0x00040E71
		public unsafe Il2CppReferenceArray<ParticleSystem> WaterParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_WaterParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParticleSystem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_WaterParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BC7 RID: 11207
		// (get) Token: 0x06008D5A RID: 36186 RVA: 0x002666B8 File Offset: 0x002648B8
		// (set) Token: 0x06008D5B RID: 36187 RVA: 0x00042C90 File Offset: 0x00040E90
		public unsafe AudioSourceController ClickSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_ClickSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_ClickSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BC8 RID: 11208
		// (get) Token: 0x06008D5C RID: 36188 RVA: 0x002666E8 File Offset: 0x002648E8
		// (set) Token: 0x06008D5D RID: 36189 RVA: 0x00042CAF File Offset: 0x00040EAF
		public unsafe AudioSourceController WaterSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_WaterSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_WaterSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BC9 RID: 11209
		// (get) Token: 0x06008D5E RID: 36190 RVA: 0x00266718 File Offset: 0x00264918
		// (set) Token: 0x06008D5F RID: 36191 RVA: 0x00042CCE File Offset: 0x00040ECE
		public unsafe float ApplyWaterDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_ApplyWaterDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_ApplyWaterDelay)) = value;
			}
		}

		// Token: 0x17002BCA RID: 11210
		// (get) Token: 0x06008D60 RID: 36192 RVA: 0x00266740 File Offset: 0x00264940
		// (set) Token: 0x06008D61 RID: 36193 RVA: 0x00042CE9 File Offset: 0x00040EE9
		public unsafe float ParticleStopDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_ParticleStopDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_ParticleStopDelay)) = value;
			}
		}

		// Token: 0x17002BCB RID: 11211
		// (get) Token: 0x06008D62 RID: 36194 RVA: 0x00266768 File Offset: 0x00264968
		// (set) Token: 0x06008D63 RID: 36195 RVA: 0x00042D04 File Offset: 0x00040F04
		public unsafe float Cooldown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_Cooldown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_Cooldown)) = value;
			}
		}

		// Token: 0x17002BCC RID: 11212
		// (get) Token: 0x06008D64 RID: 36196 RVA: 0x00266790 File Offset: 0x00264990
		// (set) Token: 0x06008D65 RID: 36197 RVA: 0x00042D1F File Offset: 0x00040F1F
		public unsafe List<Coordinate> TilesToWater
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_TilesToWater);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Coordinate>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_TilesToWater), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BCD RID: 11213
		// (get) Token: 0x06008D66 RID: 36198 RVA: 0x002667C0 File Offset: 0x002649C0
		// (set) Token: 0x06008D67 RID: 36199 RVA: 0x00042D3E File Offset: 0x00040F3E
		public unsafe int MinTilesToWater
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_MinTilesToWater);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_MinTilesToWater)) = value;
			}
		}

		// Token: 0x17002BCE RID: 11214
		// (get) Token: 0x06008D68 RID: 36200 RVA: 0x002667E8 File Offset: 0x002649E8
		// (set) Token: 0x06008D69 RID: 36201 RVA: 0x00042D59 File Offset: 0x00040F59
		public unsafe UnityEvent onSprinklerStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_onSprinklerStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_onSprinklerStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BCF RID: 11215
		// (get) Token: 0x06008D6A RID: 36202 RVA: 0x00266818 File Offset: 0x00264A18
		// (set) Token: 0x06008D6B RID: 36203 RVA: 0x00042D78 File Offset: 0x00040F78
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002BD0 RID: 11216
		// (get) Token: 0x06008D6C RID: 36204 RVA: 0x00266840 File Offset: 0x00264A40
		// (set) Token: 0x06008D6D RID: 36205 RVA: 0x00042D93 File Offset: 0x00040F93
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040060E8 RID: 24808
		private static readonly IntPtr NativeFieldInfoPtr__IsSprinkling_k__BackingField;

		// Token: 0x040060E9 RID: 24809
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x040060EA RID: 24810
		private static readonly IntPtr NativeFieldInfoPtr_WaterParticles;

		// Token: 0x040060EB RID: 24811
		private static readonly IntPtr NativeFieldInfoPtr_ClickSound;

		// Token: 0x040060EC RID: 24812
		private static readonly IntPtr NativeFieldInfoPtr_WaterSound;

		// Token: 0x040060ED RID: 24813
		private static readonly IntPtr NativeFieldInfoPtr_ApplyWaterDelay;

		// Token: 0x040060EE RID: 24814
		private static readonly IntPtr NativeFieldInfoPtr_ParticleStopDelay;

		// Token: 0x040060EF RID: 24815
		private static readonly IntPtr NativeFieldInfoPtr_Cooldown;

		// Token: 0x040060F0 RID: 24816
		private static readonly IntPtr NativeFieldInfoPtr_TilesToWater;

		// Token: 0x040060F1 RID: 24817
		private static readonly IntPtr NativeFieldInfoPtr_MinTilesToWater;

		// Token: 0x040060F2 RID: 24818
		private static readonly IntPtr NativeFieldInfoPtr_onSprinklerStart;

		// Token: 0x040060F3 RID: 24819
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040060F4 RID: 24820
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040060F5 RID: 24821
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSprinkling_Public_get_Boolean_0;

		// Token: 0x040060F6 RID: 24822
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSprinkling_Private_set_Void_Boolean_0;

		// Token: 0x040060F7 RID: 24823
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x040060F8 RID: 24824
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x040060F9 RID: 24825
		private static readonly IntPtr NativeMethodInfoPtr_CanWater_Private_Boolean_0;

		// Token: 0x040060FA RID: 24826
		private static readonly IntPtr NativeMethodInfoPtr_SendWater_Private_Void_0;

		// Token: 0x040060FB RID: 24827
		private static readonly IntPtr NativeMethodInfoPtr_Water_Private_Void_0;

		// Token: 0x040060FC RID: 24828
		private static readonly IntPtr NativeMethodInfoPtr_AddWater_Public_Void_Single_0;

		// Token: 0x040060FD RID: 24829
		private static readonly IntPtr NativeMethodInfoPtr_GetPots_Protected_Virtual_New_List_1_Pot_0;

		// Token: 0x040060FE RID: 24830
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040060FF RID: 24831
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04006100 RID: 24832
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04006101 RID: 24833
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04006102 RID: 24834
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04006103 RID: 24835
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendWater_2166136261_Private_Void_0;

		// Token: 0x04006104 RID: 24836
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendWater_2166136261_Private_Void_0;

		// Token: 0x04006105 RID: 24837
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendWater_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04006106 RID: 24838
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Water_2166136261_Private_Void_0;

		// Token: 0x04006107 RID: 24839
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Water_2166136261_Private_Void_0;

		// Token: 0x04006108 RID: 24840
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Water_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006109 RID: 24841
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000C13 RID: 3091
		[ObfuscatedName("ScheduleOne.ObjectScripts.Sprinkler+<<Water>g__Routine|18_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600EDEA RID: 60906 RVA: 0x00399320 File Offset: 0x00397520
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique()
			{
				Il2CppClassPointerStore<Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, "<<Water>g__Routine|18_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique>.NativeClassPtr);
				Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique>.NativeClassPtr, "<>1__state");
				Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique>.NativeClassPtr, "<>2__current");
				Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique>.NativeClassPtr, "<>4__this");
				Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeFieldInfoPtr__segments_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique>.NativeClassPtr, "<segments>5__2");
				Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique>.NativeClassPtr, "<i>5__3");
				Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique>.NativeClassPtr, 100681606);
				Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique>.NativeClassPtr, 100681607);
				Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique>.NativeClassPtr, 100681608);
				Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique>.NativeClassPtr, 100681609);
				Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique>.NativeClassPtr, 100681610);
				Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique>.NativeClassPtr, 100681611);
			}

			// Token: 0x0600EDEB RID: 60907 RVA: 0x00399428 File Offset: 0x00397628
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EDEC RID: 60908 RVA: 0x00399470 File Offset: 0x00397670
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EDED RID: 60909 RVA: 0x003994A4 File Offset: 0x003976A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260916, XrefRangeEnd = 260925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004821 RID: 18465
			// (get) Token: 0x0600EDEE RID: 60910 RVA: 0x003994E0 File Offset: 0x003976E0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EDEF RID: 60911 RVA: 0x00399520 File Offset: 0x00397720
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260925, XrefRangeEnd = 260930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004822 RID: 18466
			// (get) Token: 0x0600EDF0 RID: 60912 RVA: 0x00399554 File Offset: 0x00397754
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EDF1 RID: 60913 RVA: 0x0007047C File Offset: 0x0006E67C
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700481C RID: 18460
			// (get) Token: 0x0600EDF2 RID: 60914 RVA: 0x00399594 File Offset: 0x00397794
			// (set) Token: 0x0600EDF3 RID: 60915 RVA: 0x00070485 File Offset: 0x0006E685
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700481D RID: 18461
			// (get) Token: 0x0600EDF4 RID: 60916 RVA: 0x003995BC File Offset: 0x003977BC
			// (set) Token: 0x0600EDF5 RID: 60917 RVA: 0x000704A0 File Offset: 0x0006E6A0
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700481E RID: 18462
			// (get) Token: 0x0600EDF6 RID: 60918 RVA: 0x003995EC File Offset: 0x003977EC
			// (set) Token: 0x0600EDF7 RID: 60919 RVA: 0x000704BF File Offset: 0x0006E6BF
			public unsafe Sprinkler __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprinkler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700481F RID: 18463
			// (get) Token: 0x0600EDF8 RID: 60920 RVA: 0x0039961C File Offset: 0x0039781C
			// (set) Token: 0x0600EDF9 RID: 60921 RVA: 0x000704DE File Offset: 0x0006E6DE
			public unsafe int _segments_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeFieldInfoPtr__segments_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeFieldInfoPtr__segments_5__2)) = value;
				}
			}

			// Token: 0x17004820 RID: 18464
			// (get) Token: 0x0600EDFA RID: 60922 RVA: 0x00399644 File Offset: 0x00397844
			// (set) Token: 0x0600EDFB RID: 60923 RVA: 0x000704F9 File Offset: 0x0006E6F9
			public unsafe int _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x0400A11A RID: 41242
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A11B RID: 41243
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A11C RID: 41244
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A11D RID: 41245
			private static readonly IntPtr NativeFieldInfoPtr__segments_5__2;

			// Token: 0x0400A11E RID: 41246
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x0400A11F RID: 41247
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A120 RID: 41248
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A121 RID: 41249
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A122 RID: 41250
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A123 RID: 41251
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A124 RID: 41252
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000C14 RID: 3092
		[ObfuscatedName("ScheduleOne.ObjectScripts.Sprinkler+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : Il2CppSystem.Object
		{
			// Token: 0x0600EDFC RID: 60924 RVA: 0x0039966C File Offset: 0x0039786C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<Sprinkler.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sprinkler.__c__DisplayClass20_0>.NativeClassPtr);
				Sprinkler.__c__DisplayClass20_0.NativeFieldInfoPtr_potTileCounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler.__c__DisplayClass20_0>.NativeClassPtr, "potTileCounts");
				Sprinkler.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler.__c__DisplayClass20_0>.NativeClassPtr, "<>4__this");
				Sprinkler.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler.__c__DisplayClass20_0>.NativeClassPtr, 100681612);
				Sprinkler.__c__DisplayClass20_0.NativeMethodInfoPtr__GetPots_b__0_Internal_Boolean_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler.__c__DisplayClass20_0>.NativeClassPtr, 100681613);
			}

			// Token: 0x0600EDFD RID: 60925 RVA: 0x003996E8 File Offset: 0x003978E8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sprinkler.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EDFE RID: 60926 RVA: 0x00399724 File Offset: 0x00397924
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260930, XrefRangeEnd = 260933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetPots_b__0(Pot pot)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.__c__DisplayClass20_0.NativeMethodInfoPtr__GetPots_b__0_Internal_Boolean_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EDFF RID: 60927 RVA: 0x00070514 File Offset: 0x0006E714
			public __c__DisplayClass20_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004823 RID: 18467
			// (get) Token: 0x0600EE00 RID: 60928 RVA: 0x00399774 File Offset: 0x00397974
			// (set) Token: 0x0600EE01 RID: 60929 RVA: 0x0007051D File Offset: 0x0006E71D
			public unsafe Dictionary<Pot, int> potTileCounts
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.__c__DisplayClass20_0.NativeFieldInfoPtr_potTileCounts);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Pot, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.__c__DisplayClass20_0.NativeFieldInfoPtr_potTileCounts), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004824 RID: 18468
			// (get) Token: 0x0600EE02 RID: 60930 RVA: 0x003997A4 File Offset: 0x003979A4
			// (set) Token: 0x0600EE03 RID: 60931 RVA: 0x0007053C File Offset: 0x0006E73C
			public unsafe Sprinkler __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprinkler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A125 RID: 41253
			private static readonly IntPtr NativeFieldInfoPtr_potTileCounts;

			// Token: 0x0400A126 RID: 41254
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A127 RID: 41255
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A128 RID: 41256
			private static readonly IntPtr NativeMethodInfoPtr__GetPots_b__0_Internal_Boolean_Pot_0;
		}
	}
}
