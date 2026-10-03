using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000105 RID: 261
	public class PlayerConnectionInternal : Object
	{
		// Token: 0x06001647 RID: 5703 RVA: 0x00061AA4 File Offset: 0x0005FCA4
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerConnectionInternal()
		{
			Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "PlayerConnectionInternal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr);
			PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_SendMessage_Private_Virtual_Final_New_Void_Guid_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100665635);
			PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_TrySendMessage_Private_Virtual_Final_New_Boolean_Guid_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100665636);
			PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_Poll_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100665637);
			PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_RegisterInternal_Private_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100665638);
			PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_UnregisterInternal_Private_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100665639);
			PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_Initialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100665640);
			PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_IsConnected_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100665641);
			PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_DisconnectAll_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100665642);
			PlayerConnectionInternal.NativeMethodInfoPtr_IsConnected_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100665643);
			PlayerConnectionInternal.NativeMethodInfoPtr_Initialize_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100665644);
			PlayerConnectionInternal.NativeMethodInfoPtr_RegisterInternal_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100665645);
			PlayerConnectionInternal.NativeMethodInfoPtr_UnregisterInternal_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100665646);
			PlayerConnectionInternal.NativeMethodInfoPtr_SendMessage_Private_Static_Void_String_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100665647);
			PlayerConnectionInternal.NativeMethodInfoPtr_TrySendMessage_Private_Static_Boolean_String_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100665648);
			PlayerConnectionInternal.NativeMethodInfoPtr_PollInternal_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100665649);
			PlayerConnectionInternal.NativeMethodInfoPtr_DisconnectAll_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100665650);
			PlayerConnectionInternal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100665651);
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x00061C28 File Offset: 0x0005FE28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245862, XrefRangeEnd = 1245870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_IPlayerEditorConnectionNative_SendMessage(Guid messageId, Il2CppStructArray<byte> data, int playerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref messageId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_SendMessage_Private_Virtual_Final_New_Void_Guid_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001649 RID: 5705 RVA: 0x00061C88 File Offset: 0x0005FE88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245870, XrefRangeEnd = 1245878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool UnityEngine_IPlayerEditorConnectionNative_TrySendMessage(Guid messageId, Il2CppStructArray<byte> data, int playerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref messageId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_TrySendMessage_Private_Virtual_Final_New_Boolean_Guid_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600164A RID: 5706 RVA: 0x00061CF4 File Offset: 0x0005FEF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245878, XrefRangeEnd = 1245880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_IPlayerEditorConnectionNative_Poll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_Poll_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600164B RID: 5707 RVA: 0x00061D28 File Offset: 0x0005FF28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245880, XrefRangeEnd = 1245885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_IPlayerEditorConnectionNative_RegisterInternal(Guid messageId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref messageId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_RegisterInternal_Private_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x00061D68 File Offset: 0x0005FF68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245885, XrefRangeEnd = 1245890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_IPlayerEditorConnectionNative_UnregisterInternal(Guid messageId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref messageId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_UnregisterInternal_Private_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x00061DA8 File Offset: 0x0005FFA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245890, XrefRangeEnd = 1245892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_IPlayerEditorConnectionNative_Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_Initialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x00061DDC File Offset: 0x0005FFDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245892, XrefRangeEnd = 1245894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool UnityEngine_IPlayerEditorConnectionNative_IsConnected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_IsConnected_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x00061E18 File Offset: 0x00060018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245894, XrefRangeEnd = 1245896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_IPlayerEditorConnectionNative_DisconnectAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_DisconnectAll_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001650 RID: 5712 RVA: 0x00061E4C File Offset: 0x0006004C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsConnected()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_IsConnected_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x00061E7C File Offset: 0x0006007C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_Initialize_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x00061EA4 File Offset: 0x000600A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245896, XrefRangeEnd = 1245898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterInternal(string messageId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(messageId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_RegisterInternal_Private_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x00061EDC File Offset: 0x000600DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245898, XrefRangeEnd = 1245900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnregisterInternal(string messageId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(messageId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_UnregisterInternal_Private_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x00061F14 File Offset: 0x00060114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245900, XrefRangeEnd = 1245902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SendMessage(string messageId, Il2CppStructArray<byte> data, int playerId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(messageId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_SendMessage_Private_Static_Void_String_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x00061F6C File Offset: 0x0006016C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245902, XrefRangeEnd = 1245904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TrySendMessage(string messageId, Il2CppStructArray<byte> data, int playerId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(messageId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_TrySendMessage_Private_Static_Boolean_String_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x00061FD0 File Offset: 0x000601D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PollInternal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_PollInternal_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x00061FF8 File Offset: 0x000601F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DisconnectAll()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_DisconnectAll_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x00062020 File Offset: 0x00060220
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerConnectionInternal() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x0000B366 File Offset: 0x00009566
		public PlayerConnectionInternal(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001330 RID: 4912
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_SendMessage_Private_Virtual_Final_New_Void_Guid_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04001331 RID: 4913
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_TrySendMessage_Private_Virtual_Final_New_Boolean_Guid_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04001332 RID: 4914
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_Poll_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001333 RID: 4915
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_RegisterInternal_Private_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04001334 RID: 4916
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_UnregisterInternal_Private_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04001335 RID: 4917
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_Initialize_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001336 RID: 4918
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_IsConnected_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001337 RID: 4919
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_DisconnectAll_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001338 RID: 4920
		private static readonly IntPtr NativeMethodInfoPtr_IsConnected_Private_Static_Boolean_0;

		// Token: 0x04001339 RID: 4921
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Static_Void_0;

		// Token: 0x0400133A RID: 4922
		private static readonly IntPtr NativeMethodInfoPtr_RegisterInternal_Private_Static_Void_String_0;

		// Token: 0x0400133B RID: 4923
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterInternal_Private_Static_Void_String_0;

		// Token: 0x0400133C RID: 4924
		private static readonly IntPtr NativeMethodInfoPtr_SendMessage_Private_Static_Void_String_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x0400133D RID: 4925
		private static readonly IntPtr NativeMethodInfoPtr_TrySendMessage_Private_Static_Boolean_String_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x0400133E RID: 4926
		private static readonly IntPtr NativeMethodInfoPtr_PollInternal_Private_Static_Void_0;

		// Token: 0x0400133F RID: 4927
		private static readonly IntPtr NativeMethodInfoPtr_DisconnectAll_Private_Static_Void_0;

		// Token: 0x04001340 RID: 4928
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000892 RID: 2194
		public enum MulticastFlags
		{
			// Token: 0x04002AED RID: 10989
			kRequestImmediateConnect = 1,
			// Token: 0x04002AEE RID: 10990
			kSupportsProfile,
			// Token: 0x04002AEF RID: 10991
			kCustomMessage = 4,
			// Token: 0x04002AF0 RID: 10992
			kUseAlternateIP = 8
		}
	}
}
