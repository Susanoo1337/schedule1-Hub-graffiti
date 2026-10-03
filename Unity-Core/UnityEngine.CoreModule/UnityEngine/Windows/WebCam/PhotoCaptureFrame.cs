using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Windows.WebCam
{
	// Token: 0x02000190 RID: 400
	public sealed class PhotoCaptureFrame : Object
	{
		// Token: 0x06001E62 RID: 7778 RVA: 0x0007B984 File Offset: 0x00079B84
		// Note: this type is marked as 'beforefieldinit'.
		static PhotoCaptureFrame()
		{
			Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Windows.WebCam", "PhotoCaptureFrame");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr);
			PhotoCaptureFrame.NativeFieldInfoPtr_m_NativePtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, "m_NativePtr");
			PhotoCaptureFrame.NativeFieldInfoPtr__dataLength_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, "<dataLength>k__BackingField");
			PhotoCaptureFrame.NativeFieldInfoPtr__hasLocationData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, "<hasLocationData>k__BackingField");
			PhotoCaptureFrame.NativeFieldInfoPtr__pixelFormat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, "<pixelFormat>k__BackingField");
			PhotoCaptureFrame.NativeMethodInfoPtr_get_dataLength_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100666552);
			PhotoCaptureFrame.NativeMethodInfoPtr_set_dataLength_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100666553);
			PhotoCaptureFrame.NativeMethodInfoPtr_set_hasLocationData_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100666554);
			PhotoCaptureFrame.NativeMethodInfoPtr_set_pixelFormat_Private_set_Void_CapturePixelFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100666555);
			PhotoCaptureFrame.NativeMethodInfoPtr_GetDataLength_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100666556);
			PhotoCaptureFrame.NativeMethodInfoPtr_GetHasLocationData_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100666557);
			PhotoCaptureFrame.NativeMethodInfoPtr_GetCapturePixelFormat_Private_CapturePixelFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100666558);
			PhotoCaptureFrame.NativeMethodInfoPtr_Cleanup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100666560);
			PhotoCaptureFrame.NativeMethodInfoPtr_Dispose_Internal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100666561);
			PhotoCaptureFrame.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100666562);
			PhotoCaptureFrame.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100666563);
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06001E63 RID: 7779 RVA: 0x0007BAE0 File Offset: 0x00079CE0
		// (set) Token: 0x06001E64 RID: 7780 RVA: 0x0007BB1C File Offset: 0x00079D1C
		public unsafe int dataLength
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 3891, RefRangeEnd = 3894, XrefRangeStart = 3891, XrefRangeEnd = 3894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_get_dataLength_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29109, RefRangeEnd = 29110, XrefRangeStart = 29109, XrefRangeEnd = 29110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_set_dataLength_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000675 RID: 1653
		// (set) Token: 0x06001E65 RID: 7781 RVA: 0x0007BB5C File Offset: 0x00079D5C
		public unsafe bool hasLocationData
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_set_hasLocationData_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000676 RID: 1654
		// (set) Token: 0x06001E66 RID: 7782 RVA: 0x0007BB9C File Offset: 0x00079D9C
		public unsafe CapturePixelFormat pixelFormat
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29057, RefRangeEnd = 29058, XrefRangeStart = 29057, XrefRangeEnd = 29058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_set_pixelFormat_Private_set_Void_CapturePixelFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E67 RID: 7783 RVA: 0x0007BBDC File Offset: 0x00079DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282630, XrefRangeEnd = 1282632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetDataLength()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_GetDataLength_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E68 RID: 7784 RVA: 0x0007BC18 File Offset: 0x00079E18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282632, XrefRangeEnd = 1282645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetHasLocationData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_GetHasLocationData_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E69 RID: 7785 RVA: 0x0007BC54 File Offset: 0x00079E54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282645, XrefRangeEnd = 1282647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CapturePixelFormat GetCapturePixelFormat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_GetCapturePixelFormat_Private_CapturePixelFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E6A RID: 7786 RVA: 0x0007BC90 File Offset: 0x00079E90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1282654, RefRangeEnd = 1282656, XrefRangeStart = 1282647, XrefRangeEnd = 1282654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_Cleanup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E6B RID: 7787 RVA: 0x0007BCC4 File Offset: 0x00079EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282656, XrefRangeEnd = 1282658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose_Internal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_Dispose_Internal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x0007BCF8 File Offset: 0x00079EF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282658, XrefRangeEnd = 1282663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x0007BD2C File Offset: 0x00079F2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282663, XrefRangeEnd = 1282667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x0000E4EB File Offset: 0x0000C6EB
		public PhotoCaptureFrame(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06001E6F RID: 7791 RVA: 0x0007BD60 File Offset: 0x00079F60
		// (set) Token: 0x06001E70 RID: 7792 RVA: 0x0000E4F4 File Offset: 0x0000C6F4
		public unsafe IntPtr m_NativePtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhotoCaptureFrame.NativeFieldInfoPtr_m_NativePtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhotoCaptureFrame.NativeFieldInfoPtr_m_NativePtr)) = value;
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06001E71 RID: 7793 RVA: 0x0007BD88 File Offset: 0x00079F88
		// (set) Token: 0x06001E72 RID: 7794 RVA: 0x0000E50F File Offset: 0x0000C70F
		public unsafe int _dataLength_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhotoCaptureFrame.NativeFieldInfoPtr__dataLength_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhotoCaptureFrame.NativeFieldInfoPtr__dataLength_k__BackingField)) = value;
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06001E73 RID: 7795 RVA: 0x0007BDB0 File Offset: 0x00079FB0
		// (set) Token: 0x06001E74 RID: 7796 RVA: 0x0000E52A File Offset: 0x0000C72A
		public unsafe bool _hasLocationData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhotoCaptureFrame.NativeFieldInfoPtr__hasLocationData_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhotoCaptureFrame.NativeFieldInfoPtr__hasLocationData_k__BackingField)) = value;
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06001E75 RID: 7797 RVA: 0x0007BDD8 File Offset: 0x00079FD8
		// (set) Token: 0x06001E76 RID: 7798 RVA: 0x0000E545 File Offset: 0x0000C745
		public unsafe CapturePixelFormat _pixelFormat_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhotoCaptureFrame.NativeFieldInfoPtr__pixelFormat_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhotoCaptureFrame.NativeFieldInfoPtr__pixelFormat_k__BackingField)) = value;
			}
		}

		// Token: 0x040018C9 RID: 6345
		private static readonly IntPtr NativeFieldInfoPtr_m_NativePtr;

		// Token: 0x040018CA RID: 6346
		private static readonly IntPtr NativeFieldInfoPtr__dataLength_k__BackingField;

		// Token: 0x040018CB RID: 6347
		private static readonly IntPtr NativeFieldInfoPtr__hasLocationData_k__BackingField;

		// Token: 0x040018CC RID: 6348
		private static readonly IntPtr NativeFieldInfoPtr__pixelFormat_k__BackingField;

		// Token: 0x040018CD RID: 6349
		private static readonly IntPtr NativeMethodInfoPtr_get_dataLength_Public_get_Int32_0;

		// Token: 0x040018CE RID: 6350
		private static readonly IntPtr NativeMethodInfoPtr_set_dataLength_Private_set_Void_Int32_0;

		// Token: 0x040018CF RID: 6351
		private static readonly IntPtr NativeMethodInfoPtr_set_hasLocationData_Private_set_Void_Boolean_0;

		// Token: 0x040018D0 RID: 6352
		private static readonly IntPtr NativeMethodInfoPtr_set_pixelFormat_Private_set_Void_CapturePixelFormat_0;

		// Token: 0x040018D1 RID: 6353
		private static readonly IntPtr NativeMethodInfoPtr_GetDataLength_Private_Int32_0;

		// Token: 0x040018D2 RID: 6354
		private static readonly IntPtr NativeMethodInfoPtr_GetHasLocationData_Private_Boolean_0;

		// Token: 0x040018D3 RID: 6355
		private static readonly IntPtr NativeMethodInfoPtr_GetCapturePixelFormat_Private_CapturePixelFormat_0;

		// Token: 0x040018D4 RID: 6356
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Private_Void_0;

		// Token: 0x040018D5 RID: 6357
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Internal_Private_Void_0;

		// Token: 0x040018D6 RID: 6358
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040018D7 RID: 6359
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;
	}
}
