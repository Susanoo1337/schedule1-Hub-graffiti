using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.LowLevel
{
	// Token: 0x020001BD RID: 445
	public class PlayerLoop : Object
	{
		// Token: 0x0600208F RID: 8335 RVA: 0x00084B38 File Offset: 0x00082D38
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerLoop()
		{
			Il2CppClassPointerStore<PlayerLoop>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.LowLevel", "PlayerLoop");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerLoop>.NativeClassPtr);
			PlayerLoop.NativeMethodInfoPtr_GetCurrentPlayerLoop_Public_Static_PlayerLoopSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLoop>.NativeClassPtr, 100666840);
			PlayerLoop.NativeMethodInfoPtr_SetPlayerLoop_Public_Static_Void_PlayerLoopSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLoop>.NativeClassPtr, 100666841);
			PlayerLoop.NativeMethodInfoPtr_PlayerLoopSystemToInternal_Private_Static_Int32_PlayerLoopSystem_byref_List_1_PlayerLoopSystemInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLoop>.NativeClassPtr, 100666842);
			PlayerLoop.NativeMethodInfoPtr_InternalToPlayerLoopSystem_Private_Static_PlayerLoopSystem_Il2CppReferenceArray_1_PlayerLoopSystemInternal_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLoop>.NativeClassPtr, 100666843);
			PlayerLoop.NativeMethodInfoPtr_GetCurrentPlayerLoopInternal_Private_Static_Il2CppReferenceArray_1_PlayerLoopSystemInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLoop>.NativeClassPtr, 100666844);
			PlayerLoop.NativeMethodInfoPtr_SetPlayerLoopInternal_Private_Static_Void_Il2CppReferenceArray_1_PlayerLoopSystemInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLoop>.NativeClassPtr, 100666845);
			PlayerLoop.GetDefaultPlayerLoopInternalDelegateField = IL2CPP.ResolveICall<PlayerLoop.GetDefaultPlayerLoopInternalDelegate>("UnityEngine.LowLevel.PlayerLoop::GetDefaultPlayerLoopInternal");
		}

		// Token: 0x06002090 RID: 8336 RVA: 0x00084BF0 File Offset: 0x00082DF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1286408, RefRangeEnd = 1286409, XrefRangeStart = 1286405, XrefRangeEnd = 1286408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayerLoopSystem GetCurrentPlayerLoop()
		{
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PlayerLoop.NativeMethodInfoPtr_GetCurrentPlayerLoop_Public_Static_PlayerLoopSystem_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new PlayerLoopSystem(pointer);
		}

		// Token: 0x06002091 RID: 8337 RVA: 0x00084C1C File Offset: 0x00082E1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1286421, RefRangeEnd = 1286423, XrefRangeStart = 1286409, XrefRangeEnd = 1286421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetPlayerLoop(PlayerLoopSystem loop)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(loop));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerLoop.NativeMethodInfoPtr_SetPlayerLoop_Public_Static_Void_PlayerLoopSystem_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002092 RID: 8338 RVA: 0x00084C58 File Offset: 0x00082E58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1286436, RefRangeEnd = 1286438, XrefRangeStart = 1286423, XrefRangeEnd = 1286436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int PlayerLoopSystemToInternal(PlayerLoopSystem sys, ref List<PlayerLoopSystemInternal> internalSys)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(sys));
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(internalSys);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PlayerLoop.NativeMethodInfoPtr_PlayerLoopSystemToInternal_Private_Static_Int32_PlayerLoopSystem_byref_List_1_PlayerLoopSystemInternal_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			internalSys = ((intPtr4 == 0) ? null : new List<PlayerLoopSystemInternal>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002093 RID: 8339 RVA: 0x00084CC8 File Offset: 0x00082EC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1286458, RefRangeEnd = 1286460, XrefRangeStart = 1286438, XrefRangeEnd = 1286458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayerLoopSystem InternalToPlayerLoopSystem(Il2CppReferenceArray<PlayerLoopSystemInternal> internalSys, ref int offset)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(internalSys);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &offset;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PlayerLoop.NativeMethodInfoPtr_InternalToPlayerLoopSystem_Private_Static_PlayerLoopSystem_Il2CppReferenceArray_1_PlayerLoopSystemInternal_byref_Int32_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new PlayerLoopSystem(pointer);
		}

		// Token: 0x06002094 RID: 8340 RVA: 0x00084D14 File Offset: 0x00082F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286460, XrefRangeEnd = 1286462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<PlayerLoopSystemInternal> GetCurrentPlayerLoopInternal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerLoop.NativeMethodInfoPtr_GetCurrentPlayerLoopInternal_Private_Static_Il2CppReferenceArray_1_PlayerLoopSystemInternal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlayerLoopSystemInternal>>(intPtr3) : null;
		}

		// Token: 0x06002095 RID: 8341 RVA: 0x00084D48 File Offset: 0x00082F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286462, XrefRangeEnd = 1286464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetPlayerLoopInternal(Il2CppReferenceArray<PlayerLoopSystemInternal> loop)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(loop);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerLoop.NativeMethodInfoPtr_SetPlayerLoopInternal_Private_Static_Void_Il2CppReferenceArray_1_PlayerLoopSystemInternal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002096 RID: 8342 RVA: 0x0000F060 File Offset: 0x0000D260
		public PlayerLoop(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06002097 RID: 8343 RVA: 0x00084D80 File Offset: 0x00082F80
		public static PlayerLoopSystem GetDefaultPlayerLoop()
		{
			Il2CppReferenceArray<PlayerLoopSystemInternal> defaultPlayerLoopInternal = PlayerLoop.GetDefaultPlayerLoopInternal();
			int num = 0;
			return PlayerLoop.InternalToPlayerLoopSystem(defaultPlayerLoopInternal, ref num);
		}

		// Token: 0x06002098 RID: 8344 RVA: 0x00084DA4 File Offset: 0x00082FA4
		public static Il2CppReferenceArray<PlayerLoopSystemInternal> GetDefaultPlayerLoopInternal()
		{
			IntPtr intPtr = PlayerLoop.GetDefaultPlayerLoopInternalDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlayerLoopSystemInternal>>(intPtr2) : null;
		}

		// Token: 0x04001A4C RID: 6732
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentPlayerLoop_Public_Static_PlayerLoopSystem_0;

		// Token: 0x04001A4D RID: 6733
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerLoop_Public_Static_Void_PlayerLoopSystem_0;

		// Token: 0x04001A4E RID: 6734
		private static readonly IntPtr NativeMethodInfoPtr_PlayerLoopSystemToInternal_Private_Static_Int32_PlayerLoopSystem_byref_List_1_PlayerLoopSystemInternal_0;

		// Token: 0x04001A4F RID: 6735
		private static readonly IntPtr NativeMethodInfoPtr_InternalToPlayerLoopSystem_Private_Static_PlayerLoopSystem_Il2CppReferenceArray_1_PlayerLoopSystemInternal_byref_Int32_0;

		// Token: 0x04001A50 RID: 6736
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentPlayerLoopInternal_Private_Static_Il2CppReferenceArray_1_PlayerLoopSystemInternal_0;

		// Token: 0x04001A51 RID: 6737
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerLoopInternal_Private_Static_Void_Il2CppReferenceArray_1_PlayerLoopSystemInternal_0;

		// Token: 0x04001A52 RID: 6738
		private static readonly PlayerLoop.GetDefaultPlayerLoopInternalDelegate GetDefaultPlayerLoopInternalDelegateField;

		// Token: 0x02000A2E RID: 2606
		// (Invoke) Token: 0x06003D30 RID: 15664
		private delegate IntPtr GetDefaultPlayerLoopInternalDelegate();
	}
}
