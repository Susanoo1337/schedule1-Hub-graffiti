using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSteamworks;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppScheduleOne.Platform
{
	// Token: 0x020001A2 RID: 418
	public static class PlatformAuth : Object
	{
		// Token: 0x06002A11 RID: 10769 RVA: 0x001060B0 File Offset: 0x001042B0
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformAuth()
		{
			Il2CppClassPointerStore<PlatformAuth>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Platform", "PlatformAuth");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformAuth>.NativeClassPtr);
			PlatformAuth.NativeFieldInfoPtr_AuthRequestTimeoutSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformAuth>.NativeClassPtr, "AuthRequestTimeoutSeconds");
			PlatformAuth.NativeFieldInfoPtr__authState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformAuth>.NativeClassPtr, "_authState");
			PlatformAuth.NativeFieldInfoPtr_AuthTicketBufferSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformAuth>.NativeClassPtr, "AuthTicketBufferSize");
			PlatformAuth.NativeFieldInfoPtr__appTicket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformAuth>.NativeClassPtr, "_appTicket");
			PlatformAuth.NativeFieldInfoPtr_appTicketCallbackResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformAuth>.NativeClassPtr, "appTicketCallbackResponse");
			PlatformAuth.NativeFieldInfoPtr__tokenCompletion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformAuth>.NativeClassPtr, "_tokenCompletion");
			PlatformAuth.NativeFieldInfoPtr__currentAuthTicket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformAuth>.NativeClassPtr, "_currentAuthTicket");
			PlatformAuth.NativeMethodInfoPtr_get_AuthState_Public_Static_get_EAuthState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAuth>.NativeClassPtr, 100668666);
			PlatformAuth.NativeMethodInfoPtr_set_AuthState_Private_Static_set_Void_EAuthState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAuth>.NativeClassPtr, 100668667);
			PlatformAuth.NativeMethodInfoPtr_PrepareAuth_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAuth>.NativeClassPtr, 100668668);
			PlatformAuth.NativeMethodInfoPtr_GetAuthToken_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAuth>.NativeClassPtr, 100668669);
			PlatformAuth.NativeMethodInfoPtr_InitSteamAppTicket_Private_Static_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAuth>.NativeClassPtr, 100668670);
			PlatformAuth.NativeMethodInfoPtr_OnEncryptedAppTicketResponse_Private_Static_Void_EncryptedAppTicketResponse_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAuth>.NativeClassPtr, 100668671);
			PlatformAuth.NativeMethodInfoPtr_GetAppTicket_Private_Static_Task_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAuth>.NativeClassPtr, 100668672);
			PlatformAuth.NativeMethodInfoPtr_CleanTicket_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAuth>.NativeClassPtr, 100668673);
			PlatformAuth.NativeMethodInfoPtr_GetAuthSessionTicket_Public_Static_Boolean_CSteamID_byref_SteamSessionAuthTicket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAuth>.NativeClassPtr, 100668674);
			PlatformAuth.NativeMethodInfoPtr_CancelCurrentAuthSessionTicket_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAuth>.NativeClassPtr, 100668675);
			PlatformAuth.NativeMethodInfoPtr_BeginAuthSession_Public_Static_EBeginAuthSessionResult_SteamSessionAuthTicket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAuth>.NativeClassPtr, 100668676);
			PlatformAuth.NativeMethodInfoPtr_EndAuthSession_Public_Static_Void_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAuth>.NativeClassPtr, 100668677);
			PlatformAuth.NativeMethodInfoPtr_Method_Internal_Static_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAuth>.NativeClassPtr, 100668679);
		}

		// Token: 0x17000DD5 RID: 3541
		// (get) Token: 0x06002A12 RID: 10770 RVA: 0x00106270 File Offset: 0x00104470
		// (set) Token: 0x06002A13 RID: 10771 RVA: 0x001062A0 File Offset: 0x001044A0
		public unsafe static PlatformAuth.EAuthState AuthState
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123783, XrefRangeEnd = 123787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAuth.NativeMethodInfoPtr_get_AuthState_Public_Static_get_EAuthState_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 123804, RefRangeEnd = 123807, XrefRangeStart = 123787, XrefRangeEnd = 123804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAuth.NativeMethodInfoPtr_set_AuthState_Private_Static_set_Void_EAuthState_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A14 RID: 10772 RVA: 0x001062D4 File Offset: 0x001044D4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 123841, RefRangeEnd = 123846, XrefRangeStart = 123807, XrefRangeEnd = 123841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PrepareAuth()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAuth.NativeMethodInfoPtr_PrepareAuth_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A15 RID: 10773 RVA: 0x001062FC File Offset: 0x001044FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 123855, RefRangeEnd = 123857, XrefRangeStart = 123846, XrefRangeEnd = 123855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetAuthToken()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAuth.NativeMethodInfoPtr_GetAuthToken_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002A16 RID: 10774 RVA: 0x00106328 File Offset: 0x00104528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123857, XrefRangeEnd = 123866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task InitSteamAppTicket()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAuth.NativeMethodInfoPtr_InitSteamAppTicket_Private_Static_Task_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06002A17 RID: 10775 RVA: 0x0010635C File Offset: 0x0010455C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123866, XrefRangeEnd = 123889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnEncryptedAppTicketResponse(EncryptedAppTicketResponse_t response, bool ioFailure)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref response;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ioFailure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAuth.NativeMethodInfoPtr_OnEncryptedAppTicketResponse_Private_Static_Void_EncryptedAppTicketResponse_t_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A18 RID: 10776 RVA: 0x0010639C File Offset: 0x0010459C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123889, XrefRangeEnd = 123911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<string> GetAppTicket()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAuth.NativeMethodInfoPtr_GetAppTicket_Private_Static_Task_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<string>>(intPtr3) : null;
		}

		// Token: 0x06002A19 RID: 10777 RVA: 0x001063D0 File Offset: 0x001045D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123911, XrefRangeEnd = 123917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CleanTicket(string ticket)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ticket);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAuth.NativeMethodInfoPtr_CleanTicket_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002A1A RID: 10778 RVA: 0x0010640C File Offset: 0x0010460C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123917, XrefRangeEnd = 123955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetAuthSessionTicket(CSteamID recipientSteamId, out SteamSessionAuthTicket result)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref recipientSteamId;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PlatformAuth.NativeMethodInfoPtr_GetAuthSessionTicket_Public_Static_Boolean_CSteamID_byref_SteamSessionAuthTicket_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			result = ((intPtr4 == 0) ? null : new SteamSessionAuthTicket(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002A1B RID: 10779 RVA: 0x0010646C File Offset: 0x0010466C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 123976, RefRangeEnd = 123979, XrefRangeStart = 123955, XrefRangeEnd = 123976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CancelCurrentAuthSessionTicket()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAuth.NativeMethodInfoPtr_CancelCurrentAuthSessionTicket_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A1C RID: 10780 RVA: 0x00106494 File Offset: 0x00104694
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123988, RefRangeEnd = 123989, XrefRangeStart = 123979, XrefRangeEnd = 123988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EBeginAuthSessionResult BeginAuthSession(SteamSessionAuthTicket ticket)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ticket));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAuth.NativeMethodInfoPtr_BeginAuthSession_Public_Static_EBeginAuthSessionResult_SteamSessionAuthTicket_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A1D RID: 10781 RVA: 0x001064DC File Offset: 0x001046DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123998, RefRangeEnd = 123999, XrefRangeStart = 123989, XrefRangeEnd = 123998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndAuthSession(CSteamID steamID)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref steamID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAuth.NativeMethodInfoPtr_EndAuthSession_Public_Static_Void_CSteamID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A1E RID: 10782 RVA: 0x00106510 File Offset: 0x00104710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123999, XrefRangeEnd = 124003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator Method_Internal_Static_IEnumerator_PDM_0()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAuth.NativeMethodInfoPtr_Method_Internal_Static_IEnumerator_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002A1F RID: 10783 RVA: 0x00016030 File Offset: 0x00014230
		public PlatformAuth(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000DCE RID: 3534
		// (get) Token: 0x06002A20 RID: 10784 RVA: 0x00106544 File Offset: 0x00104744
		// (set) Token: 0x06002A21 RID: 10785 RVA: 0x00016039 File Offset: 0x00014239
		public unsafe static float AuthRequestTimeoutSeconds
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlatformAuth.NativeFieldInfoPtr_AuthRequestTimeoutSeconds, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlatformAuth.NativeFieldInfoPtr_AuthRequestTimeoutSeconds, (void*)(&value));
			}
		}

		// Token: 0x17000DCF RID: 3535
		// (get) Token: 0x06002A22 RID: 10786 RVA: 0x00106560 File Offset: 0x00104760
		// (set) Token: 0x06002A23 RID: 10787 RVA: 0x00016047 File Offset: 0x00014247
		public unsafe static PlatformAuth.EAuthState _authState
		{
			get
			{
				PlatformAuth.EAuthState result;
				IL2CPP.il2cpp_field_static_get_value(PlatformAuth.NativeFieldInfoPtr__authState, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlatformAuth.NativeFieldInfoPtr__authState, (void*)(&value));
			}
		}

		// Token: 0x17000DD0 RID: 3536
		// (get) Token: 0x06002A24 RID: 10788 RVA: 0x0010657C File Offset: 0x0010477C
		// (set) Token: 0x06002A25 RID: 10789 RVA: 0x00016055 File Offset: 0x00014255
		public unsafe static int AuthTicketBufferSize
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PlatformAuth.NativeFieldInfoPtr_AuthTicketBufferSize, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlatformAuth.NativeFieldInfoPtr_AuthTicketBufferSize, (void*)(&value));
			}
		}

		// Token: 0x17000DD1 RID: 3537
		// (get) Token: 0x06002A26 RID: 10790 RVA: 0x00106598 File Offset: 0x00104798
		// (set) Token: 0x06002A27 RID: 10791 RVA: 0x00016063 File Offset: 0x00014263
		public unsafe static string _appTicket
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlatformAuth.NativeFieldInfoPtr__appTicket, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlatformAuth.NativeFieldInfoPtr__appTicket, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DD2 RID: 3538
		// (get) Token: 0x06002A28 RID: 10792 RVA: 0x001065B8 File Offset: 0x001047B8
		// (set) Token: 0x06002A29 RID: 10793 RVA: 0x00016075 File Offset: 0x00014275
		public unsafe static CallResult<EncryptedAppTicketResponse_t> appTicketCallbackResponse
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlatformAuth.NativeFieldInfoPtr_appTicketCallbackResponse, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallResult<EncryptedAppTicketResponse_t>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlatformAuth.NativeFieldInfoPtr_appTicketCallbackResponse, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD3 RID: 3539
		// (get) Token: 0x06002A2A RID: 10794 RVA: 0x001065E0 File Offset: 0x001047E0
		// (set) Token: 0x06002A2B RID: 10795 RVA: 0x00016087 File Offset: 0x00014287
		public unsafe static TaskCompletionSource<string> _tokenCompletion
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlatformAuth.NativeFieldInfoPtr__tokenCompletion, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskCompletionSource<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlatformAuth.NativeFieldInfoPtr__tokenCompletion, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD4 RID: 3540
		// (get) Token: 0x06002A2C RID: 10796 RVA: 0x00106608 File Offset: 0x00104808
		// (set) Token: 0x06002A2D RID: 10797 RVA: 0x00016099 File Offset: 0x00014299
		public unsafe static HAuthTicket _currentAuthTicket
		{
			get
			{
				HAuthTicket result;
				IL2CPP.il2cpp_field_static_get_value(PlatformAuth.NativeFieldInfoPtr__currentAuthTicket, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlatformAuth.NativeFieldInfoPtr__currentAuthTicket, (void*)(&value));
			}
		}

		// Token: 0x04001CF0 RID: 7408
		private static readonly IntPtr NativeFieldInfoPtr_AuthRequestTimeoutSeconds;

		// Token: 0x04001CF1 RID: 7409
		private static readonly IntPtr NativeFieldInfoPtr__authState;

		// Token: 0x04001CF2 RID: 7410
		private static readonly IntPtr NativeFieldInfoPtr_AuthTicketBufferSize;

		// Token: 0x04001CF3 RID: 7411
		private static readonly IntPtr NativeFieldInfoPtr__appTicket;

		// Token: 0x04001CF4 RID: 7412
		private static readonly IntPtr NativeFieldInfoPtr_appTicketCallbackResponse;

		// Token: 0x04001CF5 RID: 7413
		private static readonly IntPtr NativeFieldInfoPtr__tokenCompletion;

		// Token: 0x04001CF6 RID: 7414
		private static readonly IntPtr NativeFieldInfoPtr__currentAuthTicket;

		// Token: 0x04001CF7 RID: 7415
		private static readonly IntPtr NativeMethodInfoPtr_get_AuthState_Public_Static_get_EAuthState_0;

		// Token: 0x04001CF8 RID: 7416
		private static readonly IntPtr NativeMethodInfoPtr_set_AuthState_Private_Static_set_Void_EAuthState_0;

		// Token: 0x04001CF9 RID: 7417
		private static readonly IntPtr NativeMethodInfoPtr_PrepareAuth_Public_Static_Void_0;

		// Token: 0x04001CFA RID: 7418
		private static readonly IntPtr NativeMethodInfoPtr_GetAuthToken_Public_Static_String_0;

		// Token: 0x04001CFB RID: 7419
		private static readonly IntPtr NativeMethodInfoPtr_InitSteamAppTicket_Private_Static_Task_0;

		// Token: 0x04001CFC RID: 7420
		private static readonly IntPtr NativeMethodInfoPtr_OnEncryptedAppTicketResponse_Private_Static_Void_EncryptedAppTicketResponse_t_Boolean_0;

		// Token: 0x04001CFD RID: 7421
		private static readonly IntPtr NativeMethodInfoPtr_GetAppTicket_Private_Static_Task_1_String_0;

		// Token: 0x04001CFE RID: 7422
		private static readonly IntPtr NativeMethodInfoPtr_CleanTicket_Private_Static_String_String_0;

		// Token: 0x04001CFF RID: 7423
		private static readonly IntPtr NativeMethodInfoPtr_GetAuthSessionTicket_Public_Static_Boolean_CSteamID_byref_SteamSessionAuthTicket_0;

		// Token: 0x04001D00 RID: 7424
		private static readonly IntPtr NativeMethodInfoPtr_CancelCurrentAuthSessionTicket_Public_Static_Void_0;

		// Token: 0x04001D01 RID: 7425
		private static readonly IntPtr NativeMethodInfoPtr_BeginAuthSession_Public_Static_EBeginAuthSessionResult_SteamSessionAuthTicket_0;

		// Token: 0x04001D02 RID: 7426
		private static readonly IntPtr NativeMethodInfoPtr_EndAuthSession_Public_Static_Void_CSteamID_0;

		// Token: 0x04001D03 RID: 7427
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_IEnumerator_PDM_0;

		// Token: 0x0200099F RID: 2463
		[OriginalName("Assembly-CSharp.dll", "", "EAuthState")]
		public enum EAuthState
		{
			// Token: 0x0400956B RID: 38251
			NotRequested,
			// Token: 0x0400956C RID: 38252
			Pending,
			// Token: 0x0400956D RID: 38253
			Ready,
			// Token: 0x0400956E RID: 38254
			Failed
		}

		// Token: 0x020009A0 RID: 2464
		[ObfuscatedName("ScheduleOne.Platform.PlatformAuth+<<PrepareAuth>g__Timeout|6_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Object
		{
			// Token: 0x0600DACC RID: 56012 RVA: 0x003636A8 File Offset: 0x003618A8
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
			{
				Il2CppClassPointerStore<PlatformAuth.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlatformAuth>.NativeClassPtr, "<<PrepareAuth>g__Timeout|6_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformAuth.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
				PlatformAuth.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformAuth.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
				PlatformAuth.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformAuth.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
				PlatformAuth.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAuth.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668680);
				PlatformAuth.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAuth.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668681);
				PlatformAuth.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAuth.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668682);
				PlatformAuth.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAuth.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668683);
				PlatformAuth.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAuth.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668684);
				PlatformAuth.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAuth.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668685);
			}

			// Token: 0x0600DACD RID: 56013 RVA: 0x00363774 File Offset: 0x00361974
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformAuth.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAuth.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DACE RID: 56014 RVA: 0x003637BC File Offset: 0x003619BC
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAuth.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DACF RID: 56015 RVA: 0x003637F0 File Offset: 0x003619F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123692, XrefRangeEnd = 123700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAuth.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170042CC RID: 17100
			// (get) Token: 0x0600DAD0 RID: 56016 RVA: 0x0036382C File Offset: 0x00361A2C
			public unsafe Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAuth.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DAD1 RID: 56017 RVA: 0x0036386C File Offset: 0x00361A6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123700, XrefRangeEnd = 123705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAuth.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170042CD RID: 17101
			// (get) Token: 0x0600DAD2 RID: 56018 RVA: 0x003638A0 File Offset: 0x00361AA0
			public unsafe Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAuth.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DAD3 RID: 56019 RVA: 0x00066DFA File Offset: 0x00064FFA
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042CA RID: 17098
			// (get) Token: 0x0600DAD4 RID: 56020 RVA: 0x003638E0 File Offset: 0x00361AE0
			// (set) Token: 0x0600DAD5 RID: 56021 RVA: 0x00066E03 File Offset: 0x00065003
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformAuth.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformAuth.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170042CB RID: 17099
			// (get) Token: 0x0600DAD6 RID: 56022 RVA: 0x00363908 File Offset: 0x00361B08
			// (set) Token: 0x0600DAD7 RID: 56023 RVA: 0x00066E1E File Offset: 0x0006501E
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformAuth.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformAuth.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400956F RID: 38255
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009570 RID: 38256
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009571 RID: 38257
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009572 RID: 38258
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009573 RID: 38259
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009574 RID: 38260
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009575 RID: 38261
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009576 RID: 38262
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020009A1 RID: 2465
		[ObfuscatedName("ScheduleOne.Platform.PlatformAuth+<InitSteamAppTicket>d__13")]
		public sealed class _InitSteamAppTicket_d__13 : ValueType
		{
			// Token: 0x0600DAD8 RID: 56024 RVA: 0x00363938 File Offset: 0x00361B38
			// Note: this type is marked as 'beforefieldinit'.
			static _InitSteamAppTicket_d__13()
			{
				Il2CppClassPointerStore<PlatformAuth._InitSteamAppTicket_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlatformAuth>.NativeClassPtr, "<InitSteamAppTicket>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformAuth._InitSteamAppTicket_d__13>.NativeClassPtr);
				PlatformAuth._InitSteamAppTicket_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformAuth._InitSteamAppTicket_d__13>.NativeClassPtr, "<>1__state");
				PlatformAuth._InitSteamAppTicket_d__13.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformAuth._InitSteamAppTicket_d__13>.NativeClassPtr, "<>t__builder");
				PlatformAuth._InitSteamAppTicket_d__13.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformAuth._InitSteamAppTicket_d__13>.NativeClassPtr, "<>u__1");
				PlatformAuth._InitSteamAppTicket_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAuth._InitSteamAppTicket_d__13>.NativeClassPtr, 100668686);
				PlatformAuth._InitSteamAppTicket_d__13.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAuth._InitSteamAppTicket_d__13>.NativeClassPtr, 100668687);
			}

			// Token: 0x0600DAD9 RID: 56025 RVA: 0x003639C8 File Offset: 0x00361BC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123705, XrefRangeEnd = 123779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAuth._InitSteamAppTicket_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DADA RID: 56026 RVA: 0x00363A00 File Offset: 0x00361C00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123779, XrefRangeEnd = 123783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAuth._InitSteamAppTicket_d__13.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DADB RID: 56027 RVA: 0x00066E3D File Offset: 0x0006503D
			public _InitSteamAppTicket_d__13(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600DADC RID: 56028 RVA: 0x00066E46 File Offset: 0x00065046
			public _InitSteamAppTicket_d__13() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformAuth._InitSteamAppTicket_d__13>.NativeClassPtr))
			{
			}

			// Token: 0x170042CE RID: 17102
			// (get) Token: 0x0600DADD RID: 56029 RVA: 0x00363A48 File Offset: 0x00361C48
			// (set) Token: 0x0600DADE RID: 56030 RVA: 0x00066E58 File Offset: 0x00065058
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformAuth._InitSteamAppTicket_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformAuth._InitSteamAppTicket_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170042CF RID: 17103
			// (get) Token: 0x0600DADF RID: 56031 RVA: 0x00363A70 File Offset: 0x00361C70
			// (set) Token: 0x0600DAE0 RID: 56032 RVA: 0x00066E73 File Offset: 0x00065073
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformAuth._InitSteamAppTicket_d__13.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformAuth._InitSteamAppTicket_d__13.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170042D0 RID: 17104
			// (get) Token: 0x0600DAE1 RID: 56033 RVA: 0x00363AA0 File Offset: 0x00361CA0
			// (set) Token: 0x0600DAE2 RID: 56034 RVA: 0x00066EA1 File Offset: 0x000650A1
			public TaskAwaiter<string> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformAuth._InitSteamAppTicket_d__13.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<string>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<string>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformAuth._InitSteamAppTicket_d__13.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<string>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04009577 RID: 38263
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009578 RID: 38264
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04009579 RID: 38265
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400957A RID: 38266
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400957B RID: 38267
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
