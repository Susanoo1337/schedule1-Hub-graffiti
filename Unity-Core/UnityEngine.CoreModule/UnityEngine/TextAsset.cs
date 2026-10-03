using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text;
using Unity.Collections;

namespace UnityEngine
{
	// Token: 0x0200014E RID: 334
	public class TextAsset : Object
	{
		// Token: 0x06001929 RID: 6441 RVA: 0x0006B630 File Offset: 0x00069830
		// Note: this type is marked as 'beforefieldinit'.
		static TextAsset()
		{
			Il2CppClassPointerStore<TextAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "TextAsset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextAsset>.NativeClassPtr);
			TextAsset.NativeMethodInfoPtr_get_bytes_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100665970);
			TextAsset.NativeMethodInfoPtr_Internal_CreateInstance_Private_Static_Void_TextAsset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100665971);
			TextAsset.NativeMethodInfoPtr_GetDataPtr_Private_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100665972);
			TextAsset.NativeMethodInfoPtr_GetDataSize_Private_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100665973);
			TextAsset.NativeMethodInfoPtr_get_text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100665974);
			TextAsset.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100665975);
			TextAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100665976);
			TextAsset.NativeMethodInfoPtr__ctor_Internal_Void_CreateOptions_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100665977);
			TextAsset.NativeMethodInfoPtr_GetData_Public_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100665978);
			TextAsset.NativeMethodInfoPtr_DecodeString_Internal_Static_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100665979);
			TextAsset.GetPreviewBytesDelegateField = IL2CPP.ResolveICall<TextAsset.GetPreviewBytesDelegate>("UnityEngine.TextAsset::GetPreviewBytes");
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x0600192A RID: 6442 RVA: 0x0006B738 File Offset: 0x00069938
		public unsafe Il2CppStructArray<byte> bytes
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1260922, RefRangeEnd = 1260924, XrefRangeStart = 1260920, XrefRangeEnd = 1260922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextAsset.NativeMethodInfoPtr_get_bytes_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x0600192B RID: 6443 RVA: 0x0006B778 File Offset: 0x00069978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260924, XrefRangeEnd = 1260926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_CreateInstance(TextAsset self, string text)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextAsset.NativeMethodInfoPtr_Internal_CreateInstance_Private_Static_Void_TextAsset_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600192C RID: 6444 RVA: 0x0006B7C0 File Offset: 0x000699C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1260928, RefRangeEnd = 1260929, XrefRangeStart = 1260926, XrefRangeEnd = 1260928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetDataPtr()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextAsset.NativeMethodInfoPtr_GetDataPtr_Private_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600192D RID: 6445 RVA: 0x0006B7FC File Offset: 0x000699FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1260931, RefRangeEnd = 1260932, XrefRangeStart = 1260929, XrefRangeEnd = 1260931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long GetDataSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextAsset.NativeMethodInfoPtr_GetDataSize_Private_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x0600192E RID: 6446 RVA: 0x0006B838 File Offset: 0x00069A38
		public unsafe string text
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1260936, RefRangeEnd = 1260938, XrefRangeStart = 1260932, XrefRangeEnd = 1260936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextAsset.NativeMethodInfoPtr_get_text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600192F RID: 6447 RVA: 0x0006B870 File Offset: 0x00069A70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1260936, RefRangeEnd = 1260938, XrefRangeStart = 1260936, XrefRangeEnd = 1260938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextAsset.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001930 RID: 6448 RVA: 0x0006B8B4 File Offset: 0x00069AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260938, XrefRangeEnd = 1260944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextAsset() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextAsset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001931 RID: 6449 RVA: 0x0006B8F0 File Offset: 0x00069AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260944, XrefRangeEnd = 1260950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextAsset(TextAsset.CreateOptions options, string text) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextAsset>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref options;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextAsset.NativeMethodInfoPtr__ctor_Internal_Void_CreateOptions_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001932 RID: 6450 RVA: 0x0006B94C File Offset: 0x00069B4C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1260955, RefRangeEnd = 1260959, XrefRangeStart = 1260950, XrefRangeEnd = 1260955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Unity.Collections.NativeArray<T> GetData<T>() where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(TextAsset.MethodInfoStoreGeneric_GetData_Public_NativeArray_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Unity.Collections.NativeArray<T>(pointer);
		}

		// Token: 0x06001933 RID: 6451 RVA: 0x0006B984 File Offset: 0x00069B84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260959, XrefRangeEnd = 1260976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string DecodeString(Il2CppStructArray<byte> bytes)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextAsset.NativeMethodInfoPtr_DecodeString_Internal_Static_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001934 RID: 6452 RVA: 0x0000C506 File Offset: 0x0000A706
		public TextAsset(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06001935 RID: 6453 RVA: 0x0006B9C0 File Offset: 0x00069BC0
		public Il2CppStructArray<byte> GetPreviewBytes(int maxByteCount)
		{
			IntPtr intPtr = TextAsset.GetPreviewBytesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), maxByteCount);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06001936 RID: 6454 RVA: 0x0000C50F File Offset: 0x0000A70F
		public long dataSize
		{
			get
			{
				return this.GetDataSize();
			}
		}

		// Token: 0x06001937 RID: 6455 RVA: 0x0006B9F0 File Offset: 0x00069BF0
		public string GetPreview(int maxChars)
		{
			return TextAsset.DecodeString(this.GetPreviewBytes(maxChars * 4));
		}

		// Token: 0x040014F9 RID: 5369
		private static readonly IntPtr NativeMethodInfoPtr_get_bytes_Public_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x040014FA RID: 5370
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CreateInstance_Private_Static_Void_TextAsset_String_0;

		// Token: 0x040014FB RID: 5371
		private static readonly IntPtr NativeMethodInfoPtr_GetDataPtr_Private_IntPtr_0;

		// Token: 0x040014FC RID: 5372
		private static readonly IntPtr NativeMethodInfoPtr_GetDataSize_Private_Int64_0;

		// Token: 0x040014FD RID: 5373
		private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_get_String_0;

		// Token: 0x040014FE RID: 5374
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040014FF RID: 5375
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001500 RID: 5376
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CreateOptions_String_0;

		// Token: 0x04001501 RID: 5377
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_NativeArray_1_T_0;

		// Token: 0x04001502 RID: 5378
		private static readonly IntPtr NativeMethodInfoPtr_DecodeString_Internal_Static_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001503 RID: 5379
		private static readonly TextAsset.GetPreviewBytesDelegate GetPreviewBytesDelegateField;

		// Token: 0x020008EC RID: 2284
		[OriginalName("UnityEngine.CoreModule.dll", "", "CreateOptions")]
		public enum CreateOptions
		{
			// Token: 0x04002B3C RID: 11068
			None,
			// Token: 0x04002B3D RID: 11069
			CreateNativeObject
		}

		// Token: 0x020008ED RID: 2285
		public static class EncodingUtility : Object
		{
			// Token: 0x06003A4F RID: 14927 RVA: 0x00015EE7 File Offset: 0x000140E7
			// Note: this type is marked as 'beforefieldinit'.
			static EncodingUtility()
			{
				Il2CppClassPointerStore<TextAsset.EncodingUtility>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, "EncodingUtility");
				TextAsset.EncodingUtility.NativeFieldInfoPtr_encodingLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextAsset.EncodingUtility>.NativeClassPtr, "encodingLookup");
				TextAsset.EncodingUtility.NativeFieldInfoPtr_targetEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextAsset.EncodingUtility>.NativeClassPtr, "targetEncoding");
			}

			// Token: 0x06003A50 RID: 14928 RVA: 0x00015F25 File Offset: 0x00014125
			public EncodingUtility(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17000A1D RID: 2589
			// (get) Token: 0x06003A51 RID: 14929 RVA: 0x000B2964 File Offset: 0x000B0B64
			// (set) Token: 0x06003A52 RID: 14930 RVA: 0x00015F2E File Offset: 0x0001412E
			public unsafe static Il2CppReferenceArray<KeyValuePair<Il2CppStructArray<byte>, Encoding>> encodingLookup
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TextAsset.EncodingUtility.NativeFieldInfoPtr_encodingLookup, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeyValuePair<Il2CppStructArray<byte>, Encoding>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TextAsset.EncodingUtility.NativeFieldInfoPtr_encodingLookup, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A1E RID: 2590
			// (get) Token: 0x06003A53 RID: 14931 RVA: 0x000B298C File Offset: 0x000B0B8C
			// (set) Token: 0x06003A54 RID: 14932 RVA: 0x00015F40 File Offset: 0x00014140
			public unsafe static Encoding targetEncoding
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TextAsset.EncodingUtility.NativeFieldInfoPtr_targetEncoding, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TextAsset.EncodingUtility.NativeFieldInfoPtr_targetEncoding, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002B3E RID: 11070
			private static readonly IntPtr NativeFieldInfoPtr_encodingLookup;

			// Token: 0x04002B3F RID: 11071
			private static readonly IntPtr NativeFieldInfoPtr_targetEncoding;
		}

		// Token: 0x020008EE RID: 2286
		private sealed class MethodInfoStoreGeneric_GetData_Public_NativeArray_1_T_0<T>
		{
			// Token: 0x04002B40 RID: 11072
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TextAsset.NativeMethodInfoPtr_GetData_Public_NativeArray_1_T_0, Il2CppClassPointerStore<TextAsset>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020008EF RID: 2287
		// (Invoke) Token: 0x06003A57 RID: 14935
		private delegate IntPtr GetPreviewBytesDelegate(IntPtr @this, int maxByteCount);
	}
}
