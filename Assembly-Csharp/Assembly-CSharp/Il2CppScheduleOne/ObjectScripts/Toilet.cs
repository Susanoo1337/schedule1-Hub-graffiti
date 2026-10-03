using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Interaction;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000599 RID: 1433
	public class Toilet : GridItem
	{
		// Token: 0x0600827E RID: 33406 RVA: 0x0023B508 File Offset: 0x00239708
		// Note: this type is marked as 'beforefieldinit'.
		static Toilet()
		{
			Il2CppClassPointerStore<Toilet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "Toilet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Toilet>.NativeClassPtr);
			Toilet.NativeFieldInfoPtr_InitialDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet>.NativeClassPtr, "InitialDelay");
			Toilet.NativeFieldInfoPtr_FlushTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet>.NativeClassPtr, "FlushTime");
			Toilet.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet>.NativeClassPtr, "IntObj");
			Toilet.NativeFieldInfoPtr_ItemLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet>.NativeClassPtr, "ItemLayerMask");
			Toilet.NativeFieldInfoPtr_ItemDetectionCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet>.NativeClassPtr, "ItemDetectionCollider");
			Toilet.NativeFieldInfoPtr_OnFlush = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet>.NativeClassPtr, "OnFlush");
			Toilet.NativeFieldInfoPtr__flushCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet>.NativeClassPtr, "_flushCoroutine");
			Toilet.NativeFieldInfoPtr_isFlushing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet>.NativeClassPtr, "isFlushing");
			Toilet.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.ToiletAssembly-CSharp.dll_Excuted");
			Toilet.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.ToiletAssembly-CSharp.dll_Excuted");
			Toilet.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100680072);
			Toilet.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100680073);
			Toilet.NativeMethodInfoPtr_SendFlush_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100680074);
			Toilet.NativeMethodInfoPtr_Flush_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100680075);
			Toilet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100680076);
			Toilet.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100680077);
			Toilet.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100680078);
			Toilet.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100680079);
			Toilet.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100680080);
			Toilet.NativeMethodInfoPtr_RpcWriter___Server_SendFlush_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100680081);
			Toilet.NativeMethodInfoPtr_RpcLogic___SendFlush_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100680082);
			Toilet.NativeMethodInfoPtr_RpcReader___Server_SendFlush_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100680083);
			Toilet.NativeMethodInfoPtr_RpcWriter___Observers_Flush_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100680084);
			Toilet.NativeMethodInfoPtr_RpcLogic___Flush_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100680085);
			Toilet.NativeMethodInfoPtr_RpcReader___Observers_Flush_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100680086);
			Toilet.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100680087);
		}

		// Token: 0x0600827F RID: 33407 RVA: 0x0023B740 File Offset: 0x00239940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246652, XrefRangeEnd = 246653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008280 RID: 33408 RVA: 0x0023B774 File Offset: 0x00239974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246653, XrefRangeEnd = 246662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008281 RID: 33409 RVA: 0x0023B7A8 File Offset: 0x002399A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246662, XrefRangeEnd = 246671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendFlush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr_SendFlush_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008282 RID: 33410 RVA: 0x0023B7DC File Offset: 0x002399DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246671, XrefRangeEnd = 246680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr_Flush_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008283 RID: 33411 RVA: 0x0023B810 File Offset: 0x00239A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246680, XrefRangeEnd = 246681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Toilet() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Toilet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008284 RID: 33412 RVA: 0x0023B84C File Offset: 0x00239A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246681, XrefRangeEnd = 246686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06008285 RID: 33413 RVA: 0x0023B88C File Offset: 0x00239A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246686, XrefRangeEnd = 246701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Toilet.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008286 RID: 33414 RVA: 0x0023B8C8 File Offset: 0x00239AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246701, XrefRangeEnd = 246702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Toilet.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008287 RID: 33415 RVA: 0x0023B904 File Offset: 0x00239B04
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Toilet.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008288 RID: 33416 RVA: 0x0023B940 File Offset: 0x00239B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendFlush_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr_RpcWriter___Server_SendFlush_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008289 RID: 33417 RVA: 0x0023B974 File Offset: 0x00239B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendFlush_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr_RpcLogic___SendFlush_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600828A RID: 33418 RVA: 0x0023B9A8 File Offset: 0x00239BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246702, XrefRangeEnd = 246712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendFlush_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr_RpcReader___Server_SendFlush_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600828B RID: 33419 RVA: 0x0023BA0C File Offset: 0x00239C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Flush_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr_RpcWriter___Observers_Flush_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600828C RID: 33420 RVA: 0x0023BA40 File Offset: 0x00239C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246712, XrefRangeEnd = 246719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Flush_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr_RpcLogic___Flush_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600828D RID: 33421 RVA: 0x0023BA74 File Offset: 0x00239C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246719, XrefRangeEnd = 246727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Flush_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr_RpcReader___Observers_Flush_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600828E RID: 33422 RVA: 0x0023BAC4 File Offset: 0x00239CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Toilet.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600828F RID: 33423 RVA: 0x0003DFBD File Offset: 0x0003C1BD
		public Toilet(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700284A RID: 10314
		// (get) Token: 0x06008290 RID: 33424 RVA: 0x0023BB00 File Offset: 0x00239D00
		// (set) Token: 0x06008291 RID: 33425 RVA: 0x0003DFC6 File Offset: 0x0003C1C6
		public unsafe float InitialDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_InitialDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_InitialDelay)) = value;
			}
		}

		// Token: 0x1700284B RID: 10315
		// (get) Token: 0x06008292 RID: 33426 RVA: 0x0023BB28 File Offset: 0x00239D28
		// (set) Token: 0x06008293 RID: 33427 RVA: 0x0003DFE1 File Offset: 0x0003C1E1
		public unsafe float FlushTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_FlushTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_FlushTime)) = value;
			}
		}

		// Token: 0x1700284C RID: 10316
		// (get) Token: 0x06008294 RID: 33428 RVA: 0x0023BB50 File Offset: 0x00239D50
		// (set) Token: 0x06008295 RID: 33429 RVA: 0x0003DFFC File Offset: 0x0003C1FC
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700284D RID: 10317
		// (get) Token: 0x06008296 RID: 33430 RVA: 0x0023BB80 File Offset: 0x00239D80
		// (set) Token: 0x06008297 RID: 33431 RVA: 0x0003E01B File Offset: 0x0003C21B
		public unsafe LayerMask ItemLayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_ItemLayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_ItemLayerMask)) = value;
			}
		}

		// Token: 0x1700284E RID: 10318
		// (get) Token: 0x06008298 RID: 33432 RVA: 0x0023BBA8 File Offset: 0x00239DA8
		// (set) Token: 0x06008299 RID: 33433 RVA: 0x0003E036 File Offset: 0x0003C236
		public unsafe SphereCollider ItemDetectionCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_ItemDetectionCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SphereCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_ItemDetectionCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700284F RID: 10319
		// (get) Token: 0x0600829A RID: 33434 RVA: 0x0023BBD8 File Offset: 0x00239DD8
		// (set) Token: 0x0600829B RID: 33435 RVA: 0x0003E055 File Offset: 0x0003C255
		public unsafe UnityEvent OnFlush
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_OnFlush);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_OnFlush), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002850 RID: 10320
		// (get) Token: 0x0600829C RID: 33436 RVA: 0x0023BC08 File Offset: 0x00239E08
		// (set) Token: 0x0600829D RID: 33437 RVA: 0x0003E074 File Offset: 0x0003C274
		public unsafe Coroutine _flushCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr__flushCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr__flushCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002851 RID: 10321
		// (get) Token: 0x0600829E RID: 33438 RVA: 0x0023BC38 File Offset: 0x00239E38
		// (set) Token: 0x0600829F RID: 33439 RVA: 0x0003E093 File Offset: 0x0003C293
		public unsafe bool isFlushing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_isFlushing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_isFlushing)) = value;
			}
		}

		// Token: 0x17002852 RID: 10322
		// (get) Token: 0x060082A0 RID: 33440 RVA: 0x0023BC60 File Offset: 0x00239E60
		// (set) Token: 0x060082A1 RID: 33441 RVA: 0x0003E0AE File Offset: 0x0003C2AE
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002853 RID: 10323
		// (get) Token: 0x060082A2 RID: 33442 RVA: 0x0023BC88 File Offset: 0x00239E88
		// (set) Token: 0x060082A3 RID: 33443 RVA: 0x0003E0C9 File Offset: 0x0003C2C9
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040058FA RID: 22778
		private static readonly IntPtr NativeFieldInfoPtr_InitialDelay;

		// Token: 0x040058FB RID: 22779
		private static readonly IntPtr NativeFieldInfoPtr_FlushTime;

		// Token: 0x040058FC RID: 22780
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x040058FD RID: 22781
		private static readonly IntPtr NativeFieldInfoPtr_ItemLayerMask;

		// Token: 0x040058FE RID: 22782
		private static readonly IntPtr NativeFieldInfoPtr_ItemDetectionCollider;

		// Token: 0x040058FF RID: 22783
		private static readonly IntPtr NativeFieldInfoPtr_OnFlush;

		// Token: 0x04005900 RID: 22784
		private static readonly IntPtr NativeFieldInfoPtr__flushCoroutine;

		// Token: 0x04005901 RID: 22785
		private static readonly IntPtr NativeFieldInfoPtr_isFlushing;

		// Token: 0x04005902 RID: 22786
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04005903 RID: 22787
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04005904 RID: 22788
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x04005905 RID: 22789
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x04005906 RID: 22790
		private static readonly IntPtr NativeMethodInfoPtr_SendFlush_Private_Void_0;

		// Token: 0x04005907 RID: 22791
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Private_Void_0;

		// Token: 0x04005908 RID: 22792
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005909 RID: 22793
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x0400590A RID: 22794
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400590B RID: 22795
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400590C RID: 22796
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400590D RID: 22797
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendFlush_2166136261_Private_Void_0;

		// Token: 0x0400590E RID: 22798
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendFlush_2166136261_Private_Void_0;

		// Token: 0x0400590F RID: 22799
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendFlush_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04005910 RID: 22800
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Flush_2166136261_Private_Void_0;

		// Token: 0x04005911 RID: 22801
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Flush_2166136261_Private_Void_0;

		// Token: 0x04005912 RID: 22802
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Flush_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04005913 RID: 22803
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000BF4 RID: 3060
		[ObfuscatedName("ScheduleOne.ObjectScripts.Toilet+<<Flush>g__Routine|11_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600ED0D RID: 60685 RVA: 0x00396B0C File Offset: 0x00394D0C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique()
			{
				Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Toilet>.NativeClassPtr, "<<Flush>g__Routine|11_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr);
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, "<>1__state");
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, "<>2__current");
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, "<>4__this");
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr__checkRate_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, "<checkRate>5__2");
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr__reps_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, "<reps>5__3");
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, "<i>5__4");
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, 100680088);
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, 100680089);
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, 100680090);
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, 100680091);
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, 100680092);
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, 100680093);
			}

			// Token: 0x0600ED0E RID: 60686 RVA: 0x00396C28 File Offset: 0x00394E28
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ED0F RID: 60687 RVA: 0x00396C70 File Offset: 0x00394E70
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ED10 RID: 60688 RVA: 0x00396CA4 File Offset: 0x00394EA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246596, XrefRangeEnd = 246647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170047E6 RID: 18406
			// (get) Token: 0x0600ED11 RID: 60689 RVA: 0x00396CE0 File Offset: 0x00394EE0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600ED12 RID: 60690 RVA: 0x00396D20 File Offset: 0x00394F20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246647, XrefRangeEnd = 246652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170047E7 RID: 18407
			// (get) Token: 0x0600ED13 RID: 60691 RVA: 0x00396D54 File Offset: 0x00394F54
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600ED14 RID: 60692 RVA: 0x0006FDCD File Offset: 0x0006DFCD
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170047E0 RID: 18400
			// (get) Token: 0x0600ED15 RID: 60693 RVA: 0x00396D94 File Offset: 0x00394F94
			// (set) Token: 0x0600ED16 RID: 60694 RVA: 0x0006FDD6 File Offset: 0x0006DFD6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170047E1 RID: 18401
			// (get) Token: 0x0600ED17 RID: 60695 RVA: 0x00396DBC File Offset: 0x00394FBC
			// (set) Token: 0x0600ED18 RID: 60696 RVA: 0x0006FDF1 File Offset: 0x0006DFF1
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047E2 RID: 18402
			// (get) Token: 0x0600ED19 RID: 60697 RVA: 0x00396DEC File Offset: 0x00394FEC
			// (set) Token: 0x0600ED1A RID: 60698 RVA: 0x0006FE10 File Offset: 0x0006E010
			public unsafe Toilet __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toilet>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047E3 RID: 18403
			// (get) Token: 0x0600ED1B RID: 60699 RVA: 0x00396E1C File Offset: 0x0039501C
			// (set) Token: 0x0600ED1C RID: 60700 RVA: 0x0006FE2F File Offset: 0x0006E02F
			public unsafe float _checkRate_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr__checkRate_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr__checkRate_5__2)) = value;
				}
			}

			// Token: 0x170047E4 RID: 18404
			// (get) Token: 0x0600ED1D RID: 60701 RVA: 0x00396E44 File Offset: 0x00395044
			// (set) Token: 0x0600ED1E RID: 60702 RVA: 0x0006FE4A File Offset: 0x0006E04A
			public unsafe int _reps_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr__reps_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr__reps_5__3)) = value;
				}
			}

			// Token: 0x170047E5 RID: 18405
			// (get) Token: 0x0600ED1F RID: 60703 RVA: 0x00396E6C File Offset: 0x0039506C
			// (set) Token: 0x0600ED20 RID: 60704 RVA: 0x0006FE65 File Offset: 0x0006E065
			public unsafe int _i_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x0400A070 RID: 41072
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A071 RID: 41073
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A072 RID: 41074
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A073 RID: 41075
			private static readonly IntPtr NativeFieldInfoPtr__checkRate_5__2;

			// Token: 0x0400A074 RID: 41076
			private static readonly IntPtr NativeFieldInfoPtr__reps_5__3;

			// Token: 0x0400A075 RID: 41077
			private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x0400A076 RID: 41078
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A077 RID: 41079
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A078 RID: 41080
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A079 RID: 41081
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A07A RID: 41082
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A07B RID: 41083
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
