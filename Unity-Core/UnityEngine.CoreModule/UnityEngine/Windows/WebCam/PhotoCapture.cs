using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Windows.WebCam
{
	// Token: 0x0200018F RID: 399
	public class PhotoCapture : Object
	{
		// Token: 0x06001E52 RID: 7762 RVA: 0x0007B5A4 File Offset: 0x000797A4
		// Note: this type is marked as 'beforefieldinit'.
		static PhotoCapture()
		{
			Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Windows.WebCam", "PhotoCapture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr);
			PhotoCapture.NativeFieldInfoPtr_m_NativePtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, "m_NativePtr");
			PhotoCapture.NativeFieldInfoPtr_HR_SUCCESS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, "HR_SUCCESS");
			PhotoCapture.NativeMethodInfoPtr_MakeCaptureResult_Private_Static_PhotoCaptureResult_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100666531);
			PhotoCapture.NativeMethodInfoPtr_InvokeOnCreatedResourceDelegate_Private_Static_Void_OnCaptureResourceCreatedCallback_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100666532);
			PhotoCapture.NativeMethodInfoPtr_InvokeOnPhotoModeStartedDelegate_Private_Static_Void_OnPhotoModeStartedCallback_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100666534);
			PhotoCapture.NativeMethodInfoPtr_InvokeOnPhotoModeStoppedDelegate_Private_Static_Void_OnPhotoModeStoppedCallback_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100666535);
			PhotoCapture.NativeMethodInfoPtr_InvokeOnCapturedPhotoToDiskDelegate_Private_Static_Void_OnCapturedToDiskCallback_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100666536);
			PhotoCapture.NativeMethodInfoPtr_InvokeOnCapturedPhotoToMemoryDelegate_Private_Static_Void_OnCapturedToMemoryCallback_Int64_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100666537);
			PhotoCapture.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100666538);
			PhotoCapture.NativeMethodInfoPtr_Dispose_Internal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100666539);
			PhotoCapture.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100666540);
			PhotoCapture.NativeMethodInfoPtr_DisposeThreaded_Internal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100666541);
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x0007B6C4 File Offset: 0x000798C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282597, XrefRangeEnd = 1282599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PhotoCapture.PhotoCaptureResult MakeCaptureResult(long hResult)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hResult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_MakeCaptureResult_Private_Static_PhotoCaptureResult_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x0007B704 File Offset: 0x00079904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282599, XrefRangeEnd = 1282604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnCreatedResourceDelegate(PhotoCapture.OnCaptureResourceCreatedCallback callback, IntPtr nativePtr)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativePtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_InvokeOnCreatedResourceDelegate_Private_Static_Void_OnCaptureResourceCreatedCallback_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E55 RID: 7765 RVA: 0x0007B748 File Offset: 0x00079948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282604, XrefRangeEnd = 1282606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnPhotoModeStartedDelegate(PhotoCapture.OnPhotoModeStartedCallback callback, long hResult)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hResult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_InvokeOnPhotoModeStartedDelegate_Private_Static_Void_OnPhotoModeStartedCallback_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E56 RID: 7766 RVA: 0x0007B78C File Offset: 0x0007998C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnPhotoModeStoppedDelegate(PhotoCapture.OnPhotoModeStoppedCallback callback, long hResult)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hResult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_InvokeOnPhotoModeStoppedDelegate_Private_Static_Void_OnPhotoModeStoppedCallback_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x0007B7D0 File Offset: 0x000799D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnCapturedPhotoToDiskDelegate(PhotoCapture.OnCapturedToDiskCallback callback, long hResult)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hResult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_InvokeOnCapturedPhotoToDiskDelegate_Private_Static_Void_OnCapturedToDiskCallback_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E58 RID: 7768 RVA: 0x0007B814 File Offset: 0x00079A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282606, XrefRangeEnd = 1282613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnCapturedPhotoToMemoryDelegate(PhotoCapture.OnCapturedToMemoryCallback callback, long hResult, IntPtr photoCaptureFramePtr)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hResult;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref photoCaptureFramePtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_InvokeOnCapturedPhotoToMemoryDelegate_Private_Static_Void_OnCapturedToMemoryCallback_Int64_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E59 RID: 7769 RVA: 0x0007B868 File Offset: 0x00079A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282613, XrefRangeEnd = 1282620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E5A RID: 7770 RVA: 0x0007B89C File Offset: 0x00079A9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282620, XrefRangeEnd = 1282622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose_Internal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_Dispose_Internal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E5B RID: 7771 RVA: 0x0007B8D0 File Offset: 0x00079AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282622, XrefRangeEnd = 1282628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PhotoCapture.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E5C RID: 7772 RVA: 0x0007B90C File Offset: 0x00079B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282628, XrefRangeEnd = 1282630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisposeThreaded_Internal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_DisposeThreaded_Internal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E5D RID: 7773 RVA: 0x0000E4B9 File Offset: 0x0000C6B9
		public PhotoCapture(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06001E5E RID: 7774 RVA: 0x0007B940 File Offset: 0x00079B40
		// (set) Token: 0x06001E5F RID: 7775 RVA: 0x0000E4C2 File Offset: 0x0000C6C2
		public unsafe IntPtr m_NativePtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhotoCapture.NativeFieldInfoPtr_m_NativePtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhotoCapture.NativeFieldInfoPtr_m_NativePtr)) = value;
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06001E60 RID: 7776 RVA: 0x0007B968 File Offset: 0x00079B68
		// (set) Token: 0x06001E61 RID: 7777 RVA: 0x0000E4DD File Offset: 0x0000C6DD
		public unsafe static long HR_SUCCESS
		{
			get
			{
				long result;
				IL2CPP.il2cpp_field_static_get_value(PhotoCapture.NativeFieldInfoPtr_HR_SUCCESS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PhotoCapture.NativeFieldInfoPtr_HR_SUCCESS, (void*)(&value));
			}
		}

		// Token: 0x040018BD RID: 6333
		private static readonly IntPtr NativeFieldInfoPtr_m_NativePtr;

		// Token: 0x040018BE RID: 6334
		private static readonly IntPtr NativeFieldInfoPtr_HR_SUCCESS;

		// Token: 0x040018BF RID: 6335
		private static readonly IntPtr NativeMethodInfoPtr_MakeCaptureResult_Private_Static_PhotoCaptureResult_Int64_0;

		// Token: 0x040018C0 RID: 6336
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnCreatedResourceDelegate_Private_Static_Void_OnCaptureResourceCreatedCallback_IntPtr_0;

		// Token: 0x040018C1 RID: 6337
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnPhotoModeStartedDelegate_Private_Static_Void_OnPhotoModeStartedCallback_Int64_0;

		// Token: 0x040018C2 RID: 6338
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnPhotoModeStoppedDelegate_Private_Static_Void_OnPhotoModeStoppedCallback_Int64_0;

		// Token: 0x040018C3 RID: 6339
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnCapturedPhotoToDiskDelegate_Private_Static_Void_OnCapturedToDiskCallback_Int64_0;

		// Token: 0x040018C4 RID: 6340
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnCapturedPhotoToMemoryDelegate_Private_Static_Void_OnCapturedToMemoryCallback_Int64_IntPtr_0;

		// Token: 0x040018C5 RID: 6341
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040018C6 RID: 6342
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Internal_Private_Void_0;

		// Token: 0x040018C7 RID: 6343
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040018C8 RID: 6344
		private static readonly IntPtr NativeMethodInfoPtr_DisposeThreaded_Internal_Private_Void_0;

		// Token: 0x02000A0B RID: 2571
		[OriginalName("UnityEngine.CoreModule.dll", "", "CaptureResultType")]
		public enum CaptureResultType
		{
			// Token: 0x04002B80 RID: 11136
			Success,
			// Token: 0x04002B81 RID: 11137
			UnknownError
		}

		// Token: 0x02000A0C RID: 2572
		[StructLayout(2)]
		public struct PhotoCaptureResult
		{
			// Token: 0x06003CB9 RID: 15545 RVA: 0x000B3AB4 File Offset: 0x000B1CB4
			// Note: this type is marked as 'beforefieldinit'.
			static PhotoCaptureResult()
			{
				Il2CppClassPointerStore<PhotoCapture.PhotoCaptureResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, "PhotoCaptureResult");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhotoCapture.PhotoCaptureResult>.NativeClassPtr);
				PhotoCapture.PhotoCaptureResult.NativeFieldInfoPtr_resultType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoCapture.PhotoCaptureResult>.NativeClassPtr, "resultType");
				PhotoCapture.PhotoCaptureResult.NativeFieldInfoPtr_hResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoCapture.PhotoCaptureResult>.NativeClassPtr, "hResult");
			}

			// Token: 0x06003CBA RID: 15546 RVA: 0x000163DC File Offset: 0x000145DC
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PhotoCapture.PhotoCaptureResult>.NativeClassPtr, ref this));
			}

			// Token: 0x04002B82 RID: 11138
			private static readonly IntPtr NativeFieldInfoPtr_resultType;

			// Token: 0x04002B83 RID: 11139
			private static readonly IntPtr NativeFieldInfoPtr_hResult;

			// Token: 0x04002B84 RID: 11140
			[FieldOffset(0)]
			public PhotoCapture.CaptureResultType resultType;

			// Token: 0x04002B85 RID: 11141
			[FieldOffset(8)]
			public long hResult;
		}

		// Token: 0x02000A0D RID: 2573
		public sealed class OnCaptureResourceCreatedCallback : MulticastDelegate
		{
			// Token: 0x06003CBB RID: 15547 RVA: 0x000163EE File Offset: 0x000145EE
			// Note: this type is marked as 'beforefieldinit'.
			static OnCaptureResourceCreatedCallback()
			{
				Il2CppClassPointerStore<PhotoCapture.OnCaptureResourceCreatedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, "OnCaptureResourceCreatedCallback");
				PhotoCapture.OnCaptureResourceCreatedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnCaptureResourceCreatedCallback>.NativeClassPtr, 100666542);
				PhotoCapture.OnCaptureResourceCreatedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCapture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnCaptureResourceCreatedCallback>.NativeClassPtr, 100666543);
			}

			// Token: 0x06003CBC RID: 15548 RVA: 0x000B3B08 File Offset: 0x000B1D08
			[CallerCount(329)]
			[CachedScanResults(RefRangeStart = 101484, RefRangeEnd = 101813, XrefRangeStart = 101484, XrefRangeEnd = 101813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnCaptureResourceCreatedCallback(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhotoCapture.OnCaptureResourceCreatedCallback>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnCaptureResourceCreatedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003CBD RID: 15549 RVA: 0x000B3B64 File Offset: 0x000B1D64
			[CallerCount(0)]
			public unsafe void Invoke(PhotoCapture captureObject)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(captureObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnCaptureResourceCreatedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCapture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003CBE RID: 15550 RVA: 0x0001642C File Offset: 0x0001462C
			public OnCaptureResourceCreatedCallback(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06003CBF RID: 15551 RVA: 0x00016435 File Offset: 0x00014635
			public static implicit operator PhotoCapture.OnCaptureResourceCreatedCallback(Action<PhotoCapture> A_0)
			{
				return DelegateSupport.ConvertDelegate<PhotoCapture.OnCaptureResourceCreatedCallback>(A_0);
			}

			// Token: 0x06003CC0 RID: 15552 RVA: 0x0001643D File Offset: 0x0001463D
			public static PhotoCapture.OnCaptureResourceCreatedCallback operator +(PhotoCapture.OnCaptureResourceCreatedCallback A_0, PhotoCapture.OnCaptureResourceCreatedCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PhotoCapture.OnCaptureResourceCreatedCallback>();
			}

			// Token: 0x06003CC1 RID: 15553 RVA: 0x0001644B File Offset: 0x0001464B
			public static PhotoCapture.OnCaptureResourceCreatedCallback operator -(PhotoCapture.OnCaptureResourceCreatedCallback A_0, PhotoCapture.OnCaptureResourceCreatedCallback A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<PhotoCapture.OnCaptureResourceCreatedCallback>();
				}
				return result;
			}

			// Token: 0x04002B86 RID: 11142
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002B87 RID: 11143
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCapture_0;
		}

		// Token: 0x02000A0E RID: 2574
		public sealed class OnPhotoModeStartedCallback : MulticastDelegate
		{
			// Token: 0x06003CC2 RID: 15554 RVA: 0x0001645C File Offset: 0x0001465C
			// Note: this type is marked as 'beforefieldinit'.
			static OnPhotoModeStartedCallback()
			{
				Il2CppClassPointerStore<PhotoCapture.OnPhotoModeStartedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, "OnPhotoModeStartedCallback");
				PhotoCapture.OnPhotoModeStartedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnPhotoModeStartedCallback>.NativeClassPtr, 100666544);
				PhotoCapture.OnPhotoModeStartedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnPhotoModeStartedCallback>.NativeClassPtr, 100666545);
			}

			// Token: 0x06003CC3 RID: 15555 RVA: 0x000B3BA8 File Offset: 0x000B1DA8
			[CallerCount(143)]
			[CachedScanResults(RefRangeStart = 345901, RefRangeEnd = 346044, XrefRangeStart = 345901, XrefRangeEnd = 346044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnPhotoModeStartedCallback(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhotoCapture.OnPhotoModeStartedCallback>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnPhotoModeStartedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003CC4 RID: 15556 RVA: 0x000B3C04 File Offset: 0x000B1E04
			[CallerCount(0)]
			public unsafe void Invoke(PhotoCapture.PhotoCaptureResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnPhotoModeStartedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003CC5 RID: 15557 RVA: 0x0001649A File Offset: 0x0001469A
			public OnPhotoModeStartedCallback(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06003CC6 RID: 15558 RVA: 0x000164A3 File Offset: 0x000146A3
			public static implicit operator PhotoCapture.OnPhotoModeStartedCallback(Action<PhotoCapture.PhotoCaptureResult> A_0)
			{
				return DelegateSupport.ConvertDelegate<PhotoCapture.OnPhotoModeStartedCallback>(A_0);
			}

			// Token: 0x06003CC7 RID: 15559 RVA: 0x000164AB File Offset: 0x000146AB
			public static PhotoCapture.OnPhotoModeStartedCallback operator +(PhotoCapture.OnPhotoModeStartedCallback A_0, PhotoCapture.OnPhotoModeStartedCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PhotoCapture.OnPhotoModeStartedCallback>();
			}

			// Token: 0x06003CC8 RID: 15560 RVA: 0x000164B9 File Offset: 0x000146B9
			public static PhotoCapture.OnPhotoModeStartedCallback operator -(PhotoCapture.OnPhotoModeStartedCallback A_0, PhotoCapture.OnPhotoModeStartedCallback A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<PhotoCapture.OnPhotoModeStartedCallback>();
				}
				return result;
			}

			// Token: 0x04002B88 RID: 11144
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002B89 RID: 11145
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0;
		}

		// Token: 0x02000A0F RID: 2575
		public sealed class OnPhotoModeStoppedCallback : MulticastDelegate
		{
			// Token: 0x06003CC9 RID: 15561 RVA: 0x000164CA File Offset: 0x000146CA
			// Note: this type is marked as 'beforefieldinit'.
			static OnPhotoModeStoppedCallback()
			{
				Il2CppClassPointerStore<PhotoCapture.OnPhotoModeStoppedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, "OnPhotoModeStoppedCallback");
				PhotoCapture.OnPhotoModeStoppedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnPhotoModeStoppedCallback>.NativeClassPtr, 100666546);
				PhotoCapture.OnPhotoModeStoppedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnPhotoModeStoppedCallback>.NativeClassPtr, 100666547);
			}

			// Token: 0x06003CCA RID: 15562 RVA: 0x000B3C44 File Offset: 0x000B1E44
			[CallerCount(143)]
			[CachedScanResults(RefRangeStart = 345901, RefRangeEnd = 346044, XrefRangeStart = 345901, XrefRangeEnd = 346044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnPhotoModeStoppedCallback(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhotoCapture.OnPhotoModeStoppedCallback>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnPhotoModeStoppedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003CCB RID: 15563 RVA: 0x000B3CA0 File Offset: 0x000B1EA0
			[CallerCount(0)]
			public unsafe void Invoke(PhotoCapture.PhotoCaptureResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnPhotoModeStoppedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003CCC RID: 15564 RVA: 0x00016508 File Offset: 0x00014708
			public OnPhotoModeStoppedCallback(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06003CCD RID: 15565 RVA: 0x00016511 File Offset: 0x00014711
			public static implicit operator PhotoCapture.OnPhotoModeStoppedCallback(Action<PhotoCapture.PhotoCaptureResult> A_0)
			{
				return DelegateSupport.ConvertDelegate<PhotoCapture.OnPhotoModeStoppedCallback>(A_0);
			}

			// Token: 0x06003CCE RID: 15566 RVA: 0x00016519 File Offset: 0x00014719
			public static PhotoCapture.OnPhotoModeStoppedCallback operator +(PhotoCapture.OnPhotoModeStoppedCallback A_0, PhotoCapture.OnPhotoModeStoppedCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PhotoCapture.OnPhotoModeStoppedCallback>();
			}

			// Token: 0x06003CCF RID: 15567 RVA: 0x00016527 File Offset: 0x00014727
			public static PhotoCapture.OnPhotoModeStoppedCallback operator -(PhotoCapture.OnPhotoModeStoppedCallback A_0, PhotoCapture.OnPhotoModeStoppedCallback A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<PhotoCapture.OnPhotoModeStoppedCallback>();
				}
				return result;
			}

			// Token: 0x04002B8A RID: 11146
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002B8B RID: 11147
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0;
		}

		// Token: 0x02000A10 RID: 2576
		public sealed class OnCapturedToDiskCallback : MulticastDelegate
		{
			// Token: 0x06003CD0 RID: 15568 RVA: 0x00016538 File Offset: 0x00014738
			// Note: this type is marked as 'beforefieldinit'.
			static OnCapturedToDiskCallback()
			{
				Il2CppClassPointerStore<PhotoCapture.OnCapturedToDiskCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, "OnCapturedToDiskCallback");
				PhotoCapture.OnCapturedToDiskCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnCapturedToDiskCallback>.NativeClassPtr, 100666548);
				PhotoCapture.OnCapturedToDiskCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnCapturedToDiskCallback>.NativeClassPtr, 100666549);
			}

			// Token: 0x06003CD1 RID: 15569 RVA: 0x000B3CE0 File Offset: 0x000B1EE0
			[CallerCount(143)]
			[CachedScanResults(RefRangeStart = 345901, RefRangeEnd = 346044, XrefRangeStart = 345901, XrefRangeEnd = 346044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnCapturedToDiskCallback(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhotoCapture.OnCapturedToDiskCallback>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnCapturedToDiskCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003CD2 RID: 15570 RVA: 0x000B3D3C File Offset: 0x000B1F3C
			[CallerCount(0)]
			public unsafe void Invoke(PhotoCapture.PhotoCaptureResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnCapturedToDiskCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003CD3 RID: 15571 RVA: 0x00016576 File Offset: 0x00014776
			public OnCapturedToDiskCallback(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06003CD4 RID: 15572 RVA: 0x0001657F File Offset: 0x0001477F
			public static implicit operator PhotoCapture.OnCapturedToDiskCallback(Action<PhotoCapture.PhotoCaptureResult> A_0)
			{
				return DelegateSupport.ConvertDelegate<PhotoCapture.OnCapturedToDiskCallback>(A_0);
			}

			// Token: 0x06003CD5 RID: 15573 RVA: 0x00016587 File Offset: 0x00014787
			public static PhotoCapture.OnCapturedToDiskCallback operator +(PhotoCapture.OnCapturedToDiskCallback A_0, PhotoCapture.OnCapturedToDiskCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PhotoCapture.OnCapturedToDiskCallback>();
			}

			// Token: 0x06003CD6 RID: 15574 RVA: 0x00016595 File Offset: 0x00014795
			public static PhotoCapture.OnCapturedToDiskCallback operator -(PhotoCapture.OnCapturedToDiskCallback A_0, PhotoCapture.OnCapturedToDiskCallback A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<PhotoCapture.OnCapturedToDiskCallback>();
				}
				return result;
			}

			// Token: 0x04002B8C RID: 11148
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002B8D RID: 11149
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0;
		}

		// Token: 0x02000A11 RID: 2577
		public sealed class OnCapturedToMemoryCallback : MulticastDelegate
		{
			// Token: 0x06003CD7 RID: 15575 RVA: 0x000165A6 File Offset: 0x000147A6
			// Note: this type is marked as 'beforefieldinit'.
			static OnCapturedToMemoryCallback()
			{
				Il2CppClassPointerStore<PhotoCapture.OnCapturedToMemoryCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, "OnCapturedToMemoryCallback");
				PhotoCapture.OnCapturedToMemoryCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnCapturedToMemoryCallback>.NativeClassPtr, 100666550);
				PhotoCapture.OnCapturedToMemoryCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_PhotoCaptureFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnCapturedToMemoryCallback>.NativeClassPtr, 100666551);
			}

			// Token: 0x06003CD8 RID: 15576 RVA: 0x000B3D7C File Offset: 0x000B1F7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282594, XrefRangeEnd = 1282597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnCapturedToMemoryCallback(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhotoCapture.OnCapturedToMemoryCallback>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnCapturedToMemoryCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003CD9 RID: 15577 RVA: 0x000B3DD8 File Offset: 0x000B1FD8
			[CallerCount(0)]
			public unsafe void Invoke(PhotoCapture.PhotoCaptureResult result, PhotoCaptureFrame photoCaptureFrame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref result;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(photoCaptureFrame);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnCapturedToMemoryCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_PhotoCaptureFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003CDA RID: 15578 RVA: 0x000165E4 File Offset: 0x000147E4
			public OnCapturedToMemoryCallback(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06003CDB RID: 15579 RVA: 0x000165ED File Offset: 0x000147ED
			public static implicit operator PhotoCapture.OnCapturedToMemoryCallback(Action<PhotoCapture.PhotoCaptureResult, PhotoCaptureFrame> A_0)
			{
				return DelegateSupport.ConvertDelegate<PhotoCapture.OnCapturedToMemoryCallback>(A_0);
			}

			// Token: 0x06003CDC RID: 15580 RVA: 0x000165F5 File Offset: 0x000147F5
			public static PhotoCapture.OnCapturedToMemoryCallback operator +(PhotoCapture.OnCapturedToMemoryCallback A_0, PhotoCapture.OnCapturedToMemoryCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PhotoCapture.OnCapturedToMemoryCallback>();
			}

			// Token: 0x06003CDD RID: 15581 RVA: 0x00016603 File Offset: 0x00014803
			public static PhotoCapture.OnCapturedToMemoryCallback operator -(PhotoCapture.OnCapturedToMemoryCallback A_0, PhotoCapture.OnCapturedToMemoryCallback A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<PhotoCapture.OnCapturedToMemoryCallback>();
				}
				return result;
			}

			// Token: 0x04002B8E RID: 11150
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002B8F RID: 11151
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_PhotoCaptureFrame_0;
		}
	}
}
