using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ObjectScripts;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x02000319 RID: 793
	public class CurfewManager : NetworkSingleton<CurfewManager>
	{
		// Token: 0x06003E03 RID: 15875 RVA: 0x0014C3B4 File Offset: 0x0014A5B4
		// Note: this type is marked as 'beforefieldinit'.
		static CurfewManager()
		{
			Il2CppClassPointerStore<CurfewManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "CurfewManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr);
			CurfewManager.NativeFieldInfoPtr_NORMAL_MESSAGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "NORMAL_MESSAGE");
			CurfewManager.NativeFieldInfoPtr_CURFEW_MESSAGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "CURFEW_MESSAGE");
			CurfewManager.NativeFieldInfoPtr_WARNING_MESSAGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "WARNING_MESSAGE");
			CurfewManager.NativeFieldInfoPtr_HOUR_BEFORE_CURFEW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "HOUR_BEFORE_CURFEW");
			CurfewManager.NativeFieldInfoPtr_WARNING_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "WARNING_TIME");
			CurfewManager.NativeFieldInfoPtr_CURFEW_START_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "CURFEW_START_TIME");
			CurfewManager.NativeFieldInfoPtr_HARD_CURFEW_START_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "HARD_CURFEW_START_TIME");
			CurfewManager.NativeFieldInfoPtr_CURFEW_END_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "CURFEW_END_TIME");
			CurfewManager.NativeFieldInfoPtr__IsEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "<IsEnabled>k__BackingField");
			CurfewManager.NativeFieldInfoPtr__IsCurrentlyActive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "<IsCurrentlyActive>k__BackingField");
			CurfewManager.NativeFieldInfoPtr__IsHardCurfewActive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "<IsHardCurfewActive>k__BackingField");
			CurfewManager.NativeFieldInfoPtr_VMSBoards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "VMSBoards");
			CurfewManager.NativeFieldInfoPtr_CurfewWarningSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "CurfewWarningSound");
			CurfewManager.NativeFieldInfoPtr_CurfewAlarmSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "CurfewAlarmSound");
			CurfewManager.NativeFieldInfoPtr_onCurfewEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "onCurfewEnabled");
			CurfewManager.NativeFieldInfoPtr_onCurfewDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "onCurfewDisabled");
			CurfewManager.NativeFieldInfoPtr_onCurfewHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "onCurfewHint");
			CurfewManager.NativeFieldInfoPtr_onCurfewWarning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "onCurfewWarning");
			CurfewManager.NativeFieldInfoPtr_onCurfewStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "onCurfewStart");
			CurfewManager.NativeFieldInfoPtr_onCurfewHardStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "onCurfewHardStart");
			CurfewManager.NativeFieldInfoPtr_onCurfewEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "onCurfewEnd");
			CurfewManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Law.CurfewManagerAssembly-CSharp.dll_Excuted");
			CurfewManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Law.CurfewManagerAssembly-CSharp.dll_Excuted");
			CurfewManager.NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100671205);
			CurfewManager.NativeMethodInfoPtr_set_IsEnabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100671206);
			CurfewManager.NativeMethodInfoPtr_get_IsCurrentlyActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100671207);
			CurfewManager.NativeMethodInfoPtr_set_IsCurrentlyActive_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100671208);
			CurfewManager.NativeMethodInfoPtr_get_IsHardCurfewActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100671209);
			CurfewManager.NativeMethodInfoPtr_set_IsHardCurfewActive_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100671210);
			CurfewManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100671211);
			CurfewManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100671212);
			CurfewManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100671213);
			CurfewManager.NativeMethodInfoPtr_Enable_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100671214);
			CurfewManager.NativeMethodInfoPtr_Disable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100671215);
			CurfewManager.NativeMethodInfoPtr_OnUncappedMinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100671216);
			CurfewManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100671217);
			CurfewManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100671218);
			CurfewManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100671219);
			CurfewManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100671220);
			CurfewManager.NativeMethodInfoPtr_RpcWriter___Observers_Enable_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100671221);
			CurfewManager.NativeMethodInfoPtr_RpcLogic___Enable_328543758_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100671222);
			CurfewManager.NativeMethodInfoPtr_RpcReader___Observers_Enable_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100671223);
			CurfewManager.NativeMethodInfoPtr_RpcWriter___Target_Enable_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100671224);
			CurfewManager.NativeMethodInfoPtr_RpcReader___Target_Enable_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100671225);
			CurfewManager.NativeMethodInfoPtr_RpcWriter___Observers_Disable_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100671226);
			CurfewManager.NativeMethodInfoPtr_RpcLogic___Disable_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100671227);
			CurfewManager.NativeMethodInfoPtr_RpcReader___Observers_Disable_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100671228);
			CurfewManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100671229);
		}

		// Token: 0x1700137A RID: 4986
		// (get) Token: 0x06003E04 RID: 15876 RVA: 0x0014C7A4 File Offset: 0x0014A9A4
		// (set) Token: 0x06003E05 RID: 15877 RVA: 0x0014C7E0 File Offset: 0x0014A9E0
		public unsafe bool IsEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_set_IsEnabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700137B RID: 4987
		// (get) Token: 0x06003E06 RID: 15878 RVA: 0x0014C820 File Offset: 0x0014AA20
		// (set) Token: 0x06003E07 RID: 15879 RVA: 0x0014C85C File Offset: 0x0014AA5C
		public unsafe bool IsCurrentlyActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_get_IsCurrentlyActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_set_IsCurrentlyActive_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700137C RID: 4988
		// (get) Token: 0x06003E08 RID: 15880 RVA: 0x0014C89C File Offset: 0x0014AA9C
		// (set) Token: 0x06003E09 RID: 15881 RVA: 0x0014C8D8 File Offset: 0x0014AAD8
		public unsafe bool IsHardCurfewActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_get_IsHardCurfewActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_set_IsHardCurfewActive_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003E0A RID: 15882 RVA: 0x0014C918 File Offset: 0x0014AB18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152470, XrefRangeEnd = 152478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CurfewManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E0B RID: 15883 RVA: 0x0014C954 File Offset: 0x0014AB54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152478, XrefRangeEnd = 152503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CurfewManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E0C RID: 15884 RVA: 0x0014C990 File Offset: 0x0014AB90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152503, XrefRangeEnd = 152506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CurfewManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E0D RID: 15885 RVA: 0x0014C9E0 File Offset: 0x0014ABE0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 152532, RefRangeEnd = 152535, XrefRangeStart = 152506, XrefRangeEnd = 152532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enable(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_Enable_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E0E RID: 15886 RVA: 0x0014CA24 File Offset: 0x0014AC24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152535, XrefRangeEnd = 152544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_Disable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E0F RID: 15887 RVA: 0x0014CA58 File Offset: 0x0014AC58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152544, XrefRangeEnd = 152551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnUncappedMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_OnUncappedMinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E10 RID: 15888 RVA: 0x0014CA8C File Offset: 0x0014AC8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152551, XrefRangeEnd = 152554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CurfewManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E11 RID: 15889 RVA: 0x0014CAC8 File Offset: 0x0014ACC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152554, XrefRangeEnd = 152576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CurfewManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E12 RID: 15890 RVA: 0x0014CB04 File Offset: 0x0014AD04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152576, XrefRangeEnd = 152579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CurfewManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E13 RID: 15891 RVA: 0x0014CB40 File Offset: 0x0014AD40
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CurfewManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E14 RID: 15892 RVA: 0x0014CB7C File Offset: 0x0014AD7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152579, XrefRangeEnd = 152588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Enable_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_RpcWriter___Observers_Enable_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E15 RID: 15893 RVA: 0x0014CBC0 File Offset: 0x0014ADC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 152595, RefRangeEnd = 152597, XrefRangeStart = 152588, XrefRangeEnd = 152595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Enable_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_RpcLogic___Enable_328543758_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E16 RID: 15894 RVA: 0x0014CC04 File Offset: 0x0014AE04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152597, XrefRangeEnd = 152599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Enable_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_RpcReader___Observers_Enable_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E17 RID: 15895 RVA: 0x0014CC54 File Offset: 0x0014AE54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152599, XrefRangeEnd = 152608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_Enable_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_RpcWriter___Target_Enable_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E18 RID: 15896 RVA: 0x0014CC98 File Offset: 0x0014AE98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152608, XrefRangeEnd = 152611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_Enable_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_RpcReader___Target_Enable_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E19 RID: 15897 RVA: 0x0014CCE8 File Offset: 0x0014AEE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Disable_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_RpcWriter___Observers_Disable_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E1A RID: 15898 RVA: 0x0014CD1C File Offset: 0x0014AF1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152611, XrefRangeEnd = 152615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Disable_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_RpcLogic___Disable_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E1B RID: 15899 RVA: 0x0014CD50 File Offset: 0x0014AF50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152615, XrefRangeEnd = 152620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Disable_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_RpcReader___Observers_Disable_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E1C RID: 15900 RVA: 0x0014CDA0 File Offset: 0x0014AFA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152620, XrefRangeEnd = 152626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CurfewManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E1D RID: 15901 RVA: 0x0001ED0E File Offset: 0x0001CF0E
		public CurfewManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001363 RID: 4963
		// (get) Token: 0x06003E1E RID: 15902 RVA: 0x0014CDDC File Offset: 0x0014AFDC
		// (set) Token: 0x06003E1F RID: 15903 RVA: 0x0001ED17 File Offset: 0x0001CF17
		public unsafe static string NORMAL_MESSAGE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CurfewManager.NativeFieldInfoPtr_NORMAL_MESSAGE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CurfewManager.NativeFieldInfoPtr_NORMAL_MESSAGE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001364 RID: 4964
		// (get) Token: 0x06003E20 RID: 15904 RVA: 0x0014CDFC File Offset: 0x0014AFFC
		// (set) Token: 0x06003E21 RID: 15905 RVA: 0x0001ED29 File Offset: 0x0001CF29
		public unsafe static string CURFEW_MESSAGE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CurfewManager.NativeFieldInfoPtr_CURFEW_MESSAGE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CurfewManager.NativeFieldInfoPtr_CURFEW_MESSAGE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001365 RID: 4965
		// (get) Token: 0x06003E22 RID: 15906 RVA: 0x0014CE1C File Offset: 0x0014B01C
		// (set) Token: 0x06003E23 RID: 15907 RVA: 0x0001ED3B File Offset: 0x0001CF3B
		public unsafe static string WARNING_MESSAGE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CurfewManager.NativeFieldInfoPtr_WARNING_MESSAGE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CurfewManager.NativeFieldInfoPtr_WARNING_MESSAGE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001366 RID: 4966
		// (get) Token: 0x06003E24 RID: 15908 RVA: 0x0014CE3C File Offset: 0x0014B03C
		// (set) Token: 0x06003E25 RID: 15909 RVA: 0x0001ED4D File Offset: 0x0001CF4D
		public unsafe static int HOUR_BEFORE_CURFEW
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CurfewManager.NativeFieldInfoPtr_HOUR_BEFORE_CURFEW, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CurfewManager.NativeFieldInfoPtr_HOUR_BEFORE_CURFEW, (void*)(&value));
			}
		}

		// Token: 0x17001367 RID: 4967
		// (get) Token: 0x06003E26 RID: 15910 RVA: 0x0014CE58 File Offset: 0x0014B058
		// (set) Token: 0x06003E27 RID: 15911 RVA: 0x0001ED5B File Offset: 0x0001CF5B
		public unsafe static int WARNING_TIME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CurfewManager.NativeFieldInfoPtr_WARNING_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CurfewManager.NativeFieldInfoPtr_WARNING_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001368 RID: 4968
		// (get) Token: 0x06003E28 RID: 15912 RVA: 0x0014CE74 File Offset: 0x0014B074
		// (set) Token: 0x06003E29 RID: 15913 RVA: 0x0001ED69 File Offset: 0x0001CF69
		public unsafe static int CURFEW_START_TIME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CurfewManager.NativeFieldInfoPtr_CURFEW_START_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CurfewManager.NativeFieldInfoPtr_CURFEW_START_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001369 RID: 4969
		// (get) Token: 0x06003E2A RID: 15914 RVA: 0x0014CE90 File Offset: 0x0014B090
		// (set) Token: 0x06003E2B RID: 15915 RVA: 0x0001ED77 File Offset: 0x0001CF77
		public unsafe static int HARD_CURFEW_START_TIME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CurfewManager.NativeFieldInfoPtr_HARD_CURFEW_START_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CurfewManager.NativeFieldInfoPtr_HARD_CURFEW_START_TIME, (void*)(&value));
			}
		}

		// Token: 0x1700136A RID: 4970
		// (get) Token: 0x06003E2C RID: 15916 RVA: 0x0014CEAC File Offset: 0x0014B0AC
		// (set) Token: 0x06003E2D RID: 15917 RVA: 0x0001ED85 File Offset: 0x0001CF85
		public unsafe static int CURFEW_END_TIME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CurfewManager.NativeFieldInfoPtr_CURFEW_END_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CurfewManager.NativeFieldInfoPtr_CURFEW_END_TIME, (void*)(&value));
			}
		}

		// Token: 0x1700136B RID: 4971
		// (get) Token: 0x06003E2E RID: 15918 RVA: 0x0014CEC8 File Offset: 0x0014B0C8
		// (set) Token: 0x06003E2F RID: 15919 RVA: 0x0001ED93 File Offset: 0x0001CF93
		public unsafe bool _IsEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr__IsEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr__IsEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x1700136C RID: 4972
		// (get) Token: 0x06003E30 RID: 15920 RVA: 0x0014CEF0 File Offset: 0x0014B0F0
		// (set) Token: 0x06003E31 RID: 15921 RVA: 0x0001EDAE File Offset: 0x0001CFAE
		public unsafe bool _IsCurrentlyActive_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr__IsCurrentlyActive_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr__IsCurrentlyActive_k__BackingField)) = value;
			}
		}

		// Token: 0x1700136D RID: 4973
		// (get) Token: 0x06003E32 RID: 15922 RVA: 0x0014CF18 File Offset: 0x0014B118
		// (set) Token: 0x06003E33 RID: 15923 RVA: 0x0001EDC9 File Offset: 0x0001CFC9
		public unsafe bool _IsHardCurfewActive_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr__IsHardCurfewActive_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr__IsHardCurfewActive_k__BackingField)) = value;
			}
		}

		// Token: 0x1700136E RID: 4974
		// (get) Token: 0x06003E34 RID: 15924 RVA: 0x0014CF40 File Offset: 0x0014B140
		// (set) Token: 0x06003E35 RID: 15925 RVA: 0x0001EDE4 File Offset: 0x0001CFE4
		public unsafe Il2CppReferenceArray<VMSBoard> VMSBoards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_VMSBoards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VMSBoard>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_VMSBoards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700136F RID: 4975
		// (get) Token: 0x06003E36 RID: 15926 RVA: 0x0014CF70 File Offset: 0x0014B170
		// (set) Token: 0x06003E37 RID: 15927 RVA: 0x0001EE03 File Offset: 0x0001D003
		public unsafe AudioSourceController CurfewWarningSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_CurfewWarningSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_CurfewWarningSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001370 RID: 4976
		// (get) Token: 0x06003E38 RID: 15928 RVA: 0x0014CFA0 File Offset: 0x0014B1A0
		// (set) Token: 0x06003E39 RID: 15929 RVA: 0x0001EE22 File Offset: 0x0001D022
		public unsafe AudioSourceController CurfewAlarmSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_CurfewAlarmSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_CurfewAlarmSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001371 RID: 4977
		// (get) Token: 0x06003E3A RID: 15930 RVA: 0x0014CFD0 File Offset: 0x0014B1D0
		// (set) Token: 0x06003E3B RID: 15931 RVA: 0x0001EE41 File Offset: 0x0001D041
		public unsafe UnityEvent onCurfewEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_onCurfewEnabled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_onCurfewEnabled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001372 RID: 4978
		// (get) Token: 0x06003E3C RID: 15932 RVA: 0x0014D000 File Offset: 0x0014B200
		// (set) Token: 0x06003E3D RID: 15933 RVA: 0x0001EE60 File Offset: 0x0001D060
		public unsafe UnityEvent onCurfewDisabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_onCurfewDisabled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_onCurfewDisabled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001373 RID: 4979
		// (get) Token: 0x06003E3E RID: 15934 RVA: 0x0014D030 File Offset: 0x0014B230
		// (set) Token: 0x06003E3F RID: 15935 RVA: 0x0001EE7F File Offset: 0x0001D07F
		public unsafe UnityEvent onCurfewHint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_onCurfewHint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_onCurfewHint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001374 RID: 4980
		// (get) Token: 0x06003E40 RID: 15936 RVA: 0x0014D060 File Offset: 0x0014B260
		// (set) Token: 0x06003E41 RID: 15937 RVA: 0x0001EE9E File Offset: 0x0001D09E
		public unsafe UnityEvent onCurfewWarning
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_onCurfewWarning);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_onCurfewWarning), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001375 RID: 4981
		// (get) Token: 0x06003E42 RID: 15938 RVA: 0x0014D090 File Offset: 0x0014B290
		// (set) Token: 0x06003E43 RID: 15939 RVA: 0x0001EEBD File Offset: 0x0001D0BD
		public unsafe UnityEvent onCurfewStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_onCurfewStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_onCurfewStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001376 RID: 4982
		// (get) Token: 0x06003E44 RID: 15940 RVA: 0x0014D0C0 File Offset: 0x0014B2C0
		// (set) Token: 0x06003E45 RID: 15941 RVA: 0x0001EEDC File Offset: 0x0001D0DC
		public unsafe UnityEvent onCurfewHardStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_onCurfewHardStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_onCurfewHardStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001377 RID: 4983
		// (get) Token: 0x06003E46 RID: 15942 RVA: 0x0014D0F0 File Offset: 0x0014B2F0
		// (set) Token: 0x06003E47 RID: 15943 RVA: 0x0001EEFB File Offset: 0x0001D0FB
		public unsafe UnityEvent onCurfewEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_onCurfewEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_onCurfewEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001378 RID: 4984
		// (get) Token: 0x06003E48 RID: 15944 RVA: 0x0014D120 File Offset: 0x0014B320
		// (set) Token: 0x06003E49 RID: 15945 RVA: 0x0001EF1A File Offset: 0x0001D11A
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001379 RID: 4985
		// (get) Token: 0x06003E4A RID: 15946 RVA: 0x0014D148 File Offset: 0x0014B348
		// (set) Token: 0x06003E4B RID: 15947 RVA: 0x0001EF35 File Offset: 0x0001D135
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040029D6 RID: 10710
		private static readonly IntPtr NativeFieldInfoPtr_NORMAL_MESSAGE;

		// Token: 0x040029D7 RID: 10711
		private static readonly IntPtr NativeFieldInfoPtr_CURFEW_MESSAGE;

		// Token: 0x040029D8 RID: 10712
		private static readonly IntPtr NativeFieldInfoPtr_WARNING_MESSAGE;

		// Token: 0x040029D9 RID: 10713
		private static readonly IntPtr NativeFieldInfoPtr_HOUR_BEFORE_CURFEW;

		// Token: 0x040029DA RID: 10714
		private static readonly IntPtr NativeFieldInfoPtr_WARNING_TIME;

		// Token: 0x040029DB RID: 10715
		private static readonly IntPtr NativeFieldInfoPtr_CURFEW_START_TIME;

		// Token: 0x040029DC RID: 10716
		private static readonly IntPtr NativeFieldInfoPtr_HARD_CURFEW_START_TIME;

		// Token: 0x040029DD RID: 10717
		private static readonly IntPtr NativeFieldInfoPtr_CURFEW_END_TIME;

		// Token: 0x040029DE RID: 10718
		private static readonly IntPtr NativeFieldInfoPtr__IsEnabled_k__BackingField;

		// Token: 0x040029DF RID: 10719
		private static readonly IntPtr NativeFieldInfoPtr__IsCurrentlyActive_k__BackingField;

		// Token: 0x040029E0 RID: 10720
		private static readonly IntPtr NativeFieldInfoPtr__IsHardCurfewActive_k__BackingField;

		// Token: 0x040029E1 RID: 10721
		private static readonly IntPtr NativeFieldInfoPtr_VMSBoards;

		// Token: 0x040029E2 RID: 10722
		private static readonly IntPtr NativeFieldInfoPtr_CurfewWarningSound;

		// Token: 0x040029E3 RID: 10723
		private static readonly IntPtr NativeFieldInfoPtr_CurfewAlarmSound;

		// Token: 0x040029E4 RID: 10724
		private static readonly IntPtr NativeFieldInfoPtr_onCurfewEnabled;

		// Token: 0x040029E5 RID: 10725
		private static readonly IntPtr NativeFieldInfoPtr_onCurfewDisabled;

		// Token: 0x040029E6 RID: 10726
		private static readonly IntPtr NativeFieldInfoPtr_onCurfewHint;

		// Token: 0x040029E7 RID: 10727
		private static readonly IntPtr NativeFieldInfoPtr_onCurfewWarning;

		// Token: 0x040029E8 RID: 10728
		private static readonly IntPtr NativeFieldInfoPtr_onCurfewStart;

		// Token: 0x040029E9 RID: 10729
		private static readonly IntPtr NativeFieldInfoPtr_onCurfewHardStart;

		// Token: 0x040029EA RID: 10730
		private static readonly IntPtr NativeFieldInfoPtr_onCurfewEnd;

		// Token: 0x040029EB RID: 10731
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040029EC RID: 10732
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040029ED RID: 10733
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0;

		// Token: 0x040029EE RID: 10734
		private static readonly IntPtr NativeMethodInfoPtr_set_IsEnabled_Protected_set_Void_Boolean_0;

		// Token: 0x040029EF RID: 10735
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCurrentlyActive_Public_get_Boolean_0;

		// Token: 0x040029F0 RID: 10736
		private static readonly IntPtr NativeMethodInfoPtr_set_IsCurrentlyActive_Protected_set_Void_Boolean_0;

		// Token: 0x040029F1 RID: 10737
		private static readonly IntPtr NativeMethodInfoPtr_get_IsHardCurfewActive_Public_get_Boolean_0;

		// Token: 0x040029F2 RID: 10738
		private static readonly IntPtr NativeMethodInfoPtr_set_IsHardCurfewActive_Protected_set_Void_Boolean_0;

		// Token: 0x040029F3 RID: 10739
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040029F4 RID: 10740
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x040029F5 RID: 10741
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x040029F6 RID: 10742
		private static readonly IntPtr NativeMethodInfoPtr_Enable_Public_Void_NetworkConnection_0;

		// Token: 0x040029F7 RID: 10743
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Void_0;

		// Token: 0x040029F8 RID: 10744
		private static readonly IntPtr NativeMethodInfoPtr_OnUncappedMinPass_Private_Void_0;

		// Token: 0x040029F9 RID: 10745
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040029FA RID: 10746
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040029FB RID: 10747
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040029FC RID: 10748
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040029FD RID: 10749
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Enable_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x040029FE RID: 10750
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Enable_328543758_Public_Void_NetworkConnection_0;

		// Token: 0x040029FF RID: 10751
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Enable_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002A00 RID: 10752
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_Enable_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04002A01 RID: 10753
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_Enable_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002A02 RID: 10754
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Disable_2166136261_Private_Void_0;

		// Token: 0x04002A03 RID: 10755
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Disable_2166136261_Public_Void_0;

		// Token: 0x04002A04 RID: 10756
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Disable_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002A05 RID: 10757
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;
	}
}
