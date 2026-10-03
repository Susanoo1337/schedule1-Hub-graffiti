using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000107 RID: 263
	public class PlayerPrefs : Object
	{
		// Token: 0x0600165D RID: 5725 RVA: 0x000620A8 File Offset: 0x000602A8
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerPrefs()
		{
			Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "PlayerPrefs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr);
			PlayerPrefs.NativeMethodInfoPtr_TrySetInt_Private_Static_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100665653);
			PlayerPrefs.NativeMethodInfoPtr_TrySetFloat_Private_Static_Boolean_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100665654);
			PlayerPrefs.NativeMethodInfoPtr_TrySetSetString_Private_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100665655);
			PlayerPrefs.NativeMethodInfoPtr_SetInt_Public_Static_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100665656);
			PlayerPrefs.NativeMethodInfoPtr_GetInt_Public_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100665657);
			PlayerPrefs.NativeMethodInfoPtr_GetInt_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100665658);
			PlayerPrefs.NativeMethodInfoPtr_SetFloat_Public_Static_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100665659);
			PlayerPrefs.NativeMethodInfoPtr_GetFloat_Public_Static_Single_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100665660);
			PlayerPrefs.NativeMethodInfoPtr_SetString_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100665661);
			PlayerPrefs.NativeMethodInfoPtr_GetString_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100665662);
			PlayerPrefs.NativeMethodInfoPtr_GetString_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100665663);
			PlayerPrefs.NativeMethodInfoPtr_HasKey_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100665664);
			PlayerPrefs.NativeMethodInfoPtr_DeleteKey_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100665665);
			PlayerPrefs.NativeMethodInfoPtr_Save_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100665666);
			PlayerPrefs.DeleteAllDelegateField = IL2CPP.ResolveICall<PlayerPrefs.DeleteAllDelegate>("UnityEngine.PlayerPrefs::DeleteAll");
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x00062200 File Offset: 0x00060400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245908, XrefRangeEnd = 1245910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TrySetInt(string key, int value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_TrySetInt_Private_Static_Boolean_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600165F RID: 5727 RVA: 0x00062250 File Offset: 0x00060450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245910, XrefRangeEnd = 1245912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TrySetFloat(string key, float value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_TrySetFloat_Private_Static_Boolean_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x000622A0 File Offset: 0x000604A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245912, XrefRangeEnd = 1245914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TrySetSetString(string key, string value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_TrySetSetString_Private_Static_Boolean_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x000622F4 File Offset: 0x000604F4
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 1245916, RefRangeEnd = 1245934, XrefRangeStart = 1245914, XrefRangeEnd = 1245916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetInt(string key, int value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_SetInt_Public_Static_Void_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x00062338 File Offset: 0x00060538
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 1245936, RefRangeEnd = 1245964, XrefRangeStart = 1245934, XrefRangeEnd = 1245936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetInt(string key, int defaultValue)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_GetInt_Public_Static_Int32_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x00062388 File Offset: 0x00060588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245964, XrefRangeEnd = 1245966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetInt(string key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_GetInt_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001664 RID: 5732 RVA: 0x000623CC File Offset: 0x000605CC
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1245968, RefRangeEnd = 1245983, XrefRangeStart = 1245966, XrefRangeEnd = 1245968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetFloat(string key, float value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_SetFloat_Public_Static_Void_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001665 RID: 5733 RVA: 0x00062410 File Offset: 0x00060610
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 1245985, RefRangeEnd = 1246013, XrefRangeStart = 1245983, XrefRangeEnd = 1245985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetFloat(string key, float defaultValue)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_GetFloat_Public_Static_Single_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x00062460 File Offset: 0x00060660
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1246015, RefRangeEnd = 1246022, XrefRangeStart = 1246013, XrefRangeEnd = 1246015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetString(string key, string value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_SetString_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x000624A8 File Offset: 0x000606A8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1246024, RefRangeEnd = 1246028, XrefRangeStart = 1246022, XrefRangeEnd = 1246024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetString(string key, string defaultValue)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_GetString_Public_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x000624F8 File Offset: 0x000606F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1246032, RefRangeEnd = 1246035, XrefRangeStart = 1246028, XrefRangeEnd = 1246032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetString(string key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_GetString_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001669 RID: 5737 RVA: 0x00062534 File Offset: 0x00060734
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1246037, RefRangeEnd = 1246041, XrefRangeStart = 1246035, XrefRangeEnd = 1246037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasKey(string key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_HasKey_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x00062578 File Offset: 0x00060778
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1246043, RefRangeEnd = 1246044, XrefRangeStart = 1246041, XrefRangeEnd = 1246043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeleteKey(string key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_DeleteKey_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x000625B0 File Offset: 0x000607B0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1246046, RefRangeEnd = 1246052, XrefRangeStart = 1246044, XrefRangeEnd = 1246046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Save()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_Save_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x0000B3B1 File Offset: 0x000095B1
		public PlayerPrefs(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0600166D RID: 5741 RVA: 0x000625D8 File Offset: 0x000607D8
		public static float GetFloat(string key)
		{
			return PlayerPrefs.GetFloat(key, 0f);
		}

		// Token: 0x0600166E RID: 5742 RVA: 0x0000B3BA File Offset: 0x000095BA
		public static void DeleteAll()
		{
			PlayerPrefs.DeleteAllDelegateField();
		}

		// Token: 0x04001342 RID: 4930
		private static readonly IntPtr NativeMethodInfoPtr_TrySetInt_Private_Static_Boolean_String_Int32_0;

		// Token: 0x04001343 RID: 4931
		private static readonly IntPtr NativeMethodInfoPtr_TrySetFloat_Private_Static_Boolean_String_Single_0;

		// Token: 0x04001344 RID: 4932
		private static readonly IntPtr NativeMethodInfoPtr_TrySetSetString_Private_Static_Boolean_String_String_0;

		// Token: 0x04001345 RID: 4933
		private static readonly IntPtr NativeMethodInfoPtr_SetInt_Public_Static_Void_String_Int32_0;

		// Token: 0x04001346 RID: 4934
		private static readonly IntPtr NativeMethodInfoPtr_GetInt_Public_Static_Int32_String_Int32_0;

		// Token: 0x04001347 RID: 4935
		private static readonly IntPtr NativeMethodInfoPtr_GetInt_Public_Static_Int32_String_0;

		// Token: 0x04001348 RID: 4936
		private static readonly IntPtr NativeMethodInfoPtr_SetFloat_Public_Static_Void_String_Single_0;

		// Token: 0x04001349 RID: 4937
		private static readonly IntPtr NativeMethodInfoPtr_GetFloat_Public_Static_Single_String_Single_0;

		// Token: 0x0400134A RID: 4938
		private static readonly IntPtr NativeMethodInfoPtr_SetString_Public_Static_Void_String_String_0;

		// Token: 0x0400134B RID: 4939
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Static_String_String_String_0;

		// Token: 0x0400134C RID: 4940
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Static_String_String_0;

		// Token: 0x0400134D RID: 4941
		private static readonly IntPtr NativeMethodInfoPtr_HasKey_Public_Static_Boolean_String_0;

		// Token: 0x0400134E RID: 4942
		private static readonly IntPtr NativeMethodInfoPtr_DeleteKey_Public_Static_Void_String_0;

		// Token: 0x0400134F RID: 4943
		private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Static_Void_0;

		// Token: 0x04001350 RID: 4944
		private static readonly PlayerPrefs.DeleteAllDelegate DeleteAllDelegateField;

		// Token: 0x02000893 RID: 2195
		// (Invoke) Token: 0x060039AE RID: 14766
		private delegate void DeleteAllDelegate();
	}
}
