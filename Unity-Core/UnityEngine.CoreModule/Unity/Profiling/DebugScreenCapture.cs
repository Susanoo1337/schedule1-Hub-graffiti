using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;
using UnityEngine;

namespace Unity.Profiling
{
	// Token: 0x02000022 RID: 34
	public sealed class DebugScreenCapture : ValueType
	{
		// Token: 0x06000106 RID: 262 RVA: 0x0001B490 File Offset: 0x00019690
		// Note: this type is marked as 'beforefieldinit'.
		static DebugScreenCapture()
		{
			Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling", "DebugScreenCapture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr);
			DebugScreenCapture.NativeFieldInfoPtr__RawImageDataReference_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr, "<RawImageDataReference>k__BackingField");
			DebugScreenCapture.NativeFieldInfoPtr__ImageFormat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr, "<ImageFormat>k__BackingField");
			DebugScreenCapture.NativeFieldInfoPtr__Width_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr, "<Width>k__BackingField");
			DebugScreenCapture.NativeFieldInfoPtr__Height_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr, "<Height>k__BackingField");
			DebugScreenCapture.NativeMethodInfoPtr_set_RawImageDataReference_Public_set_Void_NativeArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr, 100663404);
			DebugScreenCapture.NativeMethodInfoPtr_set_ImageFormat_Public_set_Void_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr, 100663405);
			DebugScreenCapture.NativeMethodInfoPtr_set_Width_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr, 100663406);
			DebugScreenCapture.NativeMethodInfoPtr_set_Height_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr, 100663407);
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000115 RID: 277 RVA: 0x00002874 File Offset: 0x00000A74
		// (set) Token: 0x06000107 RID: 263 RVA: 0x0001B560 File Offset: 0x00019760
		public unsafe Unity.Collections.NativeArray<byte> RawImageDataReference
		{
			get
			{
				return this._RawImageDataReference_k__BackingField;
			}
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 29012, RefRangeEnd = 29030, XrefRangeStart = 29012, XrefRangeEnd = 29030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugScreenCapture.NativeMethodInfoPtr_set_RawImageDataReference_Public_set_Void_NativeArray_1_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000116 RID: 278 RVA: 0x0000287C File Offset: 0x00000A7C
		// (set) Token: 0x06000108 RID: 264 RVA: 0x0001B5AC File Offset: 0x000197AC
		public unsafe UnityEngine.TextureFormat ImageFormat
		{
			get
			{
				return this._ImageFormat_k__BackingField;
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 29051, RefRangeEnd = 29056, XrefRangeStart = 29051, XrefRangeEnd = 29056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugScreenCapture.NativeMethodInfoPtr_set_ImageFormat_Public_set_Void_TextureFormat_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000117 RID: 279 RVA: 0x00002884 File Offset: 0x00000A84
		// (set) Token: 0x06000109 RID: 265 RVA: 0x0001B5F0 File Offset: 0x000197F0
		public unsafe int Width
		{
			get
			{
				return this._Width_k__BackingField;
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 168968, RefRangeEnd = 168976, XrefRangeStart = 168968, XrefRangeEnd = 168976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugScreenCapture.NativeMethodInfoPtr_set_Width_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000118 RID: 280 RVA: 0x0000288C File Offset: 0x00000A8C
		// (set) Token: 0x0600010A RID: 266 RVA: 0x0001B634 File Offset: 0x00019834
		public unsafe int Height
		{
			get
			{
				return this._Height_k__BackingField;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29109, RefRangeEnd = 29110, XrefRangeStart = 29109, XrefRangeEnd = 29110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugScreenCapture.NativeMethodInfoPtr_set_Height_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000027DA File Offset: 0x000009DA
		public DebugScreenCapture(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000027E3 File Offset: 0x000009E3
		public DebugScreenCapture() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr))
		{
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600010D RID: 269 RVA: 0x0001B678 File Offset: 0x00019878
		// (set) Token: 0x0600010E RID: 270 RVA: 0x000027F5 File Offset: 0x000009F5
		public Unity.Collections.NativeArray<byte> _RawImageDataReference_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugScreenCapture.NativeFieldInfoPtr__RawImageDataReference_k__BackingField);
				return new Unity.Collections.NativeArray<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Unity.Collections.NativeArray<byte>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugScreenCapture.NativeFieldInfoPtr__RawImageDataReference_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Unity.Collections.NativeArray<byte>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600010F RID: 271 RVA: 0x0001B6A8 File Offset: 0x000198A8
		// (set) Token: 0x06000110 RID: 272 RVA: 0x00002823 File Offset: 0x00000A23
		public unsafe UnityEngine.TextureFormat _ImageFormat_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugScreenCapture.NativeFieldInfoPtr__ImageFormat_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugScreenCapture.NativeFieldInfoPtr__ImageFormat_k__BackingField)) = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000111 RID: 273 RVA: 0x0001B6D0 File Offset: 0x000198D0
		// (set) Token: 0x06000112 RID: 274 RVA: 0x0000283E File Offset: 0x00000A3E
		public unsafe int _Width_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugScreenCapture.NativeFieldInfoPtr__Width_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugScreenCapture.NativeFieldInfoPtr__Width_k__BackingField)) = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000113 RID: 275 RVA: 0x0001B6F8 File Offset: 0x000198F8
		// (set) Token: 0x06000114 RID: 276 RVA: 0x00002859 File Offset: 0x00000A59
		public unsafe int _Height_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugScreenCapture.NativeFieldInfoPtr__Height_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugScreenCapture.NativeFieldInfoPtr__Height_k__BackingField)) = value;
			}
		}

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeFieldInfoPtr__RawImageDataReference_k__BackingField;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeFieldInfoPtr__ImageFormat_k__BackingField;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeFieldInfoPtr__Width_k__BackingField;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeFieldInfoPtr__Height_k__BackingField;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr_set_RawImageDataReference_Public_set_Void_NativeArray_1_Byte_0;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeMethodInfoPtr_set_ImageFormat_Public_set_Void_TextureFormat_0;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeMethodInfoPtr_set_Width_Public_set_Void_Int32_0;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeMethodInfoPtr_set_Height_Public_set_Void_Int32_0;
	}
}
