using System;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020002B7 RID: 695
	public class Gate : NetworkBehaviour
	{
		// Token: 0x060035CA RID: 13770 RVA: 0x0012E454 File Offset: 0x0012C654
		// Note: this type is marked as 'beforefieldinit'.
		static Gate()
		{
			Il2CppClassPointerStore<Gate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "Gate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Gate>.NativeClassPtr);
			Gate.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "<IsOpen>k__BackingField");
			Gate.NativeFieldInfoPtr_Gate1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "Gate1");
			Gate.NativeFieldInfoPtr_Gate1Open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "Gate1Open");
			Gate.NativeFieldInfoPtr_Gate1Closed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "Gate1Closed");
			Gate.NativeFieldInfoPtr_Gate2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "Gate2");
			Gate.NativeFieldInfoPtr_Gate2Open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "Gate2Open");
			Gate.NativeFieldInfoPtr_Gate2Closed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "Gate2Closed");
			Gate.NativeFieldInfoPtr_OpenSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "OpenSpeed");
			Gate.NativeFieldInfoPtr_Acceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "Acceleration");
			Gate.NativeFieldInfoPtr_StartSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "StartSounds");
			Gate.NativeFieldInfoPtr_LoopSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "LoopSounds");
			Gate.NativeFieldInfoPtr_StopSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "StopSounds");
			Gate.NativeFieldInfoPtr_Momentum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "Momentum");
			Gate.NativeFieldInfoPtr_openDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "openDelta");
			Gate.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Map.GateAssembly-CSharp.dll_Excuted");
			Gate.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Map.GateAssembly-CSharp.dll_Excuted");
			Gate.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gate>.NativeClassPtr, 100670117);
			Gate.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gate>.NativeClassPtr, 100670118);
			Gate.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gate>.NativeClassPtr, 100670119);
			Gate.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gate>.NativeClassPtr, 100670120);
			Gate.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gate>.NativeClassPtr, 100670121);
			Gate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gate>.NativeClassPtr, 100670122);
			Gate.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gate>.NativeClassPtr, 100670123);
			Gate.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gate>.NativeClassPtr, 100670124);
			Gate.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gate>.NativeClassPtr, 100670125);
			Gate.NativeMethodInfoPtr_RpcWriter___Observers_Open_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gate>.NativeClassPtr, 100670126);
			Gate.NativeMethodInfoPtr_RpcLogic___Open_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gate>.NativeClassPtr, 100670127);
			Gate.NativeMethodInfoPtr_RpcReader___Observers_Open_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gate>.NativeClassPtr, 100670128);
			Gate.NativeMethodInfoPtr_RpcWriter___Observers_Close_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gate>.NativeClassPtr, 100670129);
			Gate.NativeMethodInfoPtr_RpcLogic___Close_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gate>.NativeClassPtr, 100670130);
			Gate.NativeMethodInfoPtr_RpcReader___Observers_Close_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gate>.NativeClassPtr, 100670131);
			Gate.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gate>.NativeClassPtr, 100670132);
		}

		// Token: 0x1700110D RID: 4365
		// (get) Token: 0x060035CB RID: 13771 RVA: 0x0012E704 File Offset: 0x0012C904
		// (set) Token: 0x060035CC RID: 13772 RVA: 0x0012E740 File Offset: 0x0012C940
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gate.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gate.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035CD RID: 13773 RVA: 0x0012E780 File Offset: 0x0012C980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141749, XrefRangeEnd = 141768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gate.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035CE RID: 13774 RVA: 0x0012E7B4 File Offset: 0x0012C9B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141768, XrefRangeEnd = 141789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gate.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035CF RID: 13775 RVA: 0x0012E7E8 File Offset: 0x0012C9E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141789, XrefRangeEnd = 141798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gate.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035D0 RID: 13776 RVA: 0x0012E81C File Offset: 0x0012CA1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141798, XrefRangeEnd = 141799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Gate() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Gate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035D1 RID: 13777 RVA: 0x0012E858 File Offset: 0x0012CA58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141799, XrefRangeEnd = 141812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Gate.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035D2 RID: 13778 RVA: 0x0012E894 File Offset: 0x0012CA94
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Gate.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035D3 RID: 13779 RVA: 0x0012E8D0 File Offset: 0x0012CAD0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Gate.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035D4 RID: 13780 RVA: 0x0012E90C File Offset: 0x0012CB0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141812, XrefRangeEnd = 141821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Open_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gate.NativeMethodInfoPtr_RpcWriter___Observers_Open_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035D5 RID: 13781 RVA: 0x0012E940 File Offset: 0x0012CB40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 141822, RefRangeEnd = 141824, XrefRangeStart = 141821, XrefRangeEnd = 141822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Open_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gate.NativeMethodInfoPtr_RpcLogic___Open_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035D6 RID: 13782 RVA: 0x0012E974 File Offset: 0x0012CB74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141824, XrefRangeEnd = 141827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Open_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gate.NativeMethodInfoPtr_RpcReader___Observers_Open_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035D7 RID: 13783 RVA: 0x0012E9C4 File Offset: 0x0012CBC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Close_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gate.NativeMethodInfoPtr_RpcWriter___Observers_Close_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035D8 RID: 13784 RVA: 0x0012E9F8 File Offset: 0x0012CBF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141827, XrefRangeEnd = 141828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Close_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gate.NativeMethodInfoPtr_RpcLogic___Close_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035D9 RID: 13785 RVA: 0x0012EA2C File Offset: 0x0012CC2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141828, XrefRangeEnd = 141830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Close_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gate.NativeMethodInfoPtr_RpcReader___Observers_Close_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035DA RID: 13786 RVA: 0x0012EA7C File Offset: 0x0012CC7C
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Gate.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035DB RID: 13787 RVA: 0x0001B54B File Offset: 0x0001974B
		public Gate(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170010FD RID: 4349
		// (get) Token: 0x060035DC RID: 13788 RVA: 0x0012EAB8 File Offset: 0x0012CCB8
		// (set) Token: 0x060035DD RID: 13789 RVA: 0x0001B554 File Offset: 0x00019754
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x170010FE RID: 4350
		// (get) Token: 0x060035DE RID: 13790 RVA: 0x0012EAE0 File Offset: 0x0012CCE0
		// (set) Token: 0x060035DF RID: 13791 RVA: 0x0001B56F File Offset: 0x0001976F
		public unsafe Transform Gate1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010FF RID: 4351
		// (get) Token: 0x060035E0 RID: 13792 RVA: 0x0012EB10 File Offset: 0x0012CD10
		// (set) Token: 0x060035E1 RID: 13793 RVA: 0x0001B58E File Offset: 0x0001978E
		public unsafe Vector3 Gate1Open
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate1Open);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate1Open)) = value;
			}
		}

		// Token: 0x17001100 RID: 4352
		// (get) Token: 0x060035E2 RID: 13794 RVA: 0x0012EB38 File Offset: 0x0012CD38
		// (set) Token: 0x060035E3 RID: 13795 RVA: 0x0001B5A9 File Offset: 0x000197A9
		public unsafe Vector3 Gate1Closed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate1Closed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate1Closed)) = value;
			}
		}

		// Token: 0x17001101 RID: 4353
		// (get) Token: 0x060035E4 RID: 13796 RVA: 0x0012EB60 File Offset: 0x0012CD60
		// (set) Token: 0x060035E5 RID: 13797 RVA: 0x0001B5C4 File Offset: 0x000197C4
		public unsafe Transform Gate2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001102 RID: 4354
		// (get) Token: 0x060035E6 RID: 13798 RVA: 0x0012EB90 File Offset: 0x0012CD90
		// (set) Token: 0x060035E7 RID: 13799 RVA: 0x0001B5E3 File Offset: 0x000197E3
		public unsafe Vector3 Gate2Open
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate2Open);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate2Open)) = value;
			}
		}

		// Token: 0x17001103 RID: 4355
		// (get) Token: 0x060035E8 RID: 13800 RVA: 0x0012EBB8 File Offset: 0x0012CDB8
		// (set) Token: 0x060035E9 RID: 13801 RVA: 0x0001B5FE File Offset: 0x000197FE
		public unsafe Vector3 Gate2Closed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate2Closed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate2Closed)) = value;
			}
		}

		// Token: 0x17001104 RID: 4356
		// (get) Token: 0x060035EA RID: 13802 RVA: 0x0012EBE0 File Offset: 0x0012CDE0
		// (set) Token: 0x060035EB RID: 13803 RVA: 0x0001B619 File Offset: 0x00019819
		public unsafe float OpenSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_OpenSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_OpenSpeed)) = value;
			}
		}

		// Token: 0x17001105 RID: 4357
		// (get) Token: 0x060035EC RID: 13804 RVA: 0x0012EC08 File Offset: 0x0012CE08
		// (set) Token: 0x060035ED RID: 13805 RVA: 0x0001B634 File Offset: 0x00019834
		public unsafe float Acceleration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Acceleration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Acceleration)) = value;
			}
		}

		// Token: 0x17001106 RID: 4358
		// (get) Token: 0x060035EE RID: 13806 RVA: 0x0012EC30 File Offset: 0x0012CE30
		// (set) Token: 0x060035EF RID: 13807 RVA: 0x0001B64F File Offset: 0x0001984F
		public unsafe Il2CppReferenceArray<AudioSourceController> StartSounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_StartSounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioSourceController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_StartSounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001107 RID: 4359
		// (get) Token: 0x060035F0 RID: 13808 RVA: 0x0012EC60 File Offset: 0x0012CE60
		// (set) Token: 0x060035F1 RID: 13809 RVA: 0x0001B66E File Offset: 0x0001986E
		public unsafe Il2CppReferenceArray<AudioSourceController> LoopSounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_LoopSounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioSourceController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_LoopSounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001108 RID: 4360
		// (get) Token: 0x060035F2 RID: 13810 RVA: 0x0012EC90 File Offset: 0x0012CE90
		// (set) Token: 0x060035F3 RID: 13811 RVA: 0x0001B68D File Offset: 0x0001988D
		public unsafe Il2CppReferenceArray<AudioSourceController> StopSounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_StopSounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioSourceController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_StopSounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001109 RID: 4361
		// (get) Token: 0x060035F4 RID: 13812 RVA: 0x0012ECC0 File Offset: 0x0012CEC0
		// (set) Token: 0x060035F5 RID: 13813 RVA: 0x0001B6AC File Offset: 0x000198AC
		public unsafe float Momentum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Momentum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Momentum)) = value;
			}
		}

		// Token: 0x1700110A RID: 4362
		// (get) Token: 0x060035F6 RID: 13814 RVA: 0x0012ECE8 File Offset: 0x0012CEE8
		// (set) Token: 0x060035F7 RID: 13815 RVA: 0x0001B6C7 File Offset: 0x000198C7
		public unsafe float openDelta
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_openDelta);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_openDelta)) = value;
			}
		}

		// Token: 0x1700110B RID: 4363
		// (get) Token: 0x060035F8 RID: 13816 RVA: 0x0012ED10 File Offset: 0x0012CF10
		// (set) Token: 0x060035F9 RID: 13817 RVA: 0x0001B6E2 File Offset: 0x000198E2
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700110C RID: 4364
		// (get) Token: 0x060035FA RID: 13818 RVA: 0x0012ED38 File Offset: 0x0012CF38
		// (set) Token: 0x060035FB RID: 13819 RVA: 0x0001B6FD File Offset: 0x000198FD
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002409 RID: 9225
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x0400240A RID: 9226
		private static readonly IntPtr NativeFieldInfoPtr_Gate1;

		// Token: 0x0400240B RID: 9227
		private static readonly IntPtr NativeFieldInfoPtr_Gate1Open;

		// Token: 0x0400240C RID: 9228
		private static readonly IntPtr NativeFieldInfoPtr_Gate1Closed;

		// Token: 0x0400240D RID: 9229
		private static readonly IntPtr NativeFieldInfoPtr_Gate2;

		// Token: 0x0400240E RID: 9230
		private static readonly IntPtr NativeFieldInfoPtr_Gate2Open;

		// Token: 0x0400240F RID: 9231
		private static readonly IntPtr NativeFieldInfoPtr_Gate2Closed;

		// Token: 0x04002410 RID: 9232
		private static readonly IntPtr NativeFieldInfoPtr_OpenSpeed;

		// Token: 0x04002411 RID: 9233
		private static readonly IntPtr NativeFieldInfoPtr_Acceleration;

		// Token: 0x04002412 RID: 9234
		private static readonly IntPtr NativeFieldInfoPtr_StartSounds;

		// Token: 0x04002413 RID: 9235
		private static readonly IntPtr NativeFieldInfoPtr_LoopSounds;

		// Token: 0x04002414 RID: 9236
		private static readonly IntPtr NativeFieldInfoPtr_StopSounds;

		// Token: 0x04002415 RID: 9237
		private static readonly IntPtr NativeFieldInfoPtr_Momentum;

		// Token: 0x04002416 RID: 9238
		private static readonly IntPtr NativeFieldInfoPtr_openDelta;

		// Token: 0x04002417 RID: 9239
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002418 RID: 9240
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002419 RID: 9241
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x0400241A RID: 9242
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x0400241B RID: 9243
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400241C RID: 9244
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x0400241D RID: 9245
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x0400241E RID: 9246
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400241F RID: 9247
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002420 RID: 9248
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002421 RID: 9249
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002422 RID: 9250
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Open_2166136261_Private_Void_0;

		// Token: 0x04002423 RID: 9251
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Open_2166136261_Public_Void_0;

		// Token: 0x04002424 RID: 9252
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Open_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002425 RID: 9253
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Close_2166136261_Private_Void_0;

		// Token: 0x04002426 RID: 9254
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Close_2166136261_Public_Void_0;

		// Token: 0x04002427 RID: 9255
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Close_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002428 RID: 9256
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
