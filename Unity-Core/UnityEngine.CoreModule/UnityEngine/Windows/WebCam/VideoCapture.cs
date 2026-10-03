using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Windows.WebCam
{
	// Token: 0x02000191 RID: 401
	public class VideoCapture : Object
	{
		// Token: 0x06001E77 RID: 7799 RVA: 0x0007BE00 File Offset: 0x0007A000
		// Note: this type is marked as 'beforefieldinit'.
		static VideoCapture()
		{
			Il2CppClassPointerStore<VideoCapture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Windows.WebCam", "VideoCapture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr);
			VideoCapture.NativeFieldInfoPtr_m_NativePtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, "m_NativePtr");
			VideoCapture.NativeFieldInfoPtr_HR_SUCCESS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, "HR_SUCCESS");
			VideoCapture.NativeMethodInfoPtr_MakeCaptureResult_Private_Static_VideoCaptureResult_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100666564);
			VideoCapture.NativeMethodInfoPtr_InvokeOnCreatedVideoCaptureResourceDelegate_Private_Static_Void_OnVideoCaptureResourceCreatedCallback_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100666565);
			VideoCapture.NativeMethodInfoPtr_InvokeOnVideoModeStartedDelegate_Private_Static_Void_OnVideoModeStartedCallback_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100666567);
			VideoCapture.NativeMethodInfoPtr_InvokeOnVideoModeStoppedDelegate_Private_Static_Void_OnVideoModeStoppedCallback_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100666568);
			VideoCapture.NativeMethodInfoPtr_InvokeOnStartedRecordingVideoToDiskDelegate_Private_Static_Void_OnStartedRecordingVideoCallback_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100666569);
			VideoCapture.NativeMethodInfoPtr_InvokeOnStoppedRecordingVideoToDiskDelegate_Private_Static_Void_OnStoppedRecordingVideoCallback_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100666570);
			VideoCapture.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100666571);
			VideoCapture.NativeMethodInfoPtr_Dispose_Internal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100666572);
			VideoCapture.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100666573);
			VideoCapture.NativeMethodInfoPtr_DisposeThreaded_Internal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100666574);
		}

		// Token: 0x06001E78 RID: 7800 RVA: 0x0007BF20 File Offset: 0x0007A120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282667, XrefRangeEnd = 1282669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VideoCapture.VideoCaptureResult MakeCaptureResult(long hResult)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hResult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_MakeCaptureResult_Private_Static_VideoCaptureResult_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E79 RID: 7801 RVA: 0x0007BF60 File Offset: 0x0007A160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282669, XrefRangeEnd = 1282674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnCreatedVideoCaptureResourceDelegate(VideoCapture.OnVideoCaptureResourceCreatedCallback callback, IntPtr nativePtr)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativePtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_InvokeOnCreatedVideoCaptureResourceDelegate_Private_Static_Void_OnVideoCaptureResourceCreatedCallback_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E7A RID: 7802 RVA: 0x0007BFA4 File Offset: 0x0007A1A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282674, XrefRangeEnd = 1282676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnVideoModeStartedDelegate(VideoCapture.OnVideoModeStartedCallback callback, long hResult)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hResult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_InvokeOnVideoModeStartedDelegate_Private_Static_Void_OnVideoModeStartedCallback_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E7B RID: 7803 RVA: 0x0007BFE8 File Offset: 0x0007A1E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnVideoModeStoppedDelegate(VideoCapture.OnVideoModeStoppedCallback callback, long hResult)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hResult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_InvokeOnVideoModeStoppedDelegate_Private_Static_Void_OnVideoModeStoppedCallback_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E7C RID: 7804 RVA: 0x0007C02C File Offset: 0x0007A22C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnStartedRecordingVideoToDiskDelegate(VideoCapture.OnStartedRecordingVideoCallback callback, long hResult)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hResult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_InvokeOnStartedRecordingVideoToDiskDelegate_Private_Static_Void_OnStartedRecordingVideoCallback_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E7D RID: 7805 RVA: 0x0007C070 File Offset: 0x0007A270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnStoppedRecordingVideoToDiskDelegate(VideoCapture.OnStoppedRecordingVideoCallback callback, long hResult)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hResult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_InvokeOnStoppedRecordingVideoToDiskDelegate_Private_Static_Void_OnStoppedRecordingVideoCallback_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E7E RID: 7806 RVA: 0x0007C0B4 File Offset: 0x0007A2B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282676, XrefRangeEnd = 1282683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E7F RID: 7807 RVA: 0x0007C0E8 File Offset: 0x0007A2E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282683, XrefRangeEnd = 1282685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose_Internal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_Dispose_Internal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E80 RID: 7808 RVA: 0x0007C11C File Offset: 0x0007A31C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282685, XrefRangeEnd = 1282691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VideoCapture.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E81 RID: 7809 RVA: 0x0007C158 File Offset: 0x0007A358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282691, XrefRangeEnd = 1282693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisposeThreaded_Internal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_DisposeThreaded_Internal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E82 RID: 7810 RVA: 0x0000E560 File Offset: 0x0000C760
		public VideoCapture(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06001E83 RID: 7811 RVA: 0x0007C18C File Offset: 0x0007A38C
		// (set) Token: 0x06001E84 RID: 7812 RVA: 0x0000E569 File Offset: 0x0000C769
		public unsafe IntPtr m_NativePtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VideoCapture.NativeFieldInfoPtr_m_NativePtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VideoCapture.NativeFieldInfoPtr_m_NativePtr)) = value;
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06001E85 RID: 7813 RVA: 0x0007C1B4 File Offset: 0x0007A3B4
		// (set) Token: 0x06001E86 RID: 7814 RVA: 0x0000E584 File Offset: 0x0000C784
		public unsafe static long HR_SUCCESS
		{
			get
			{
				long result;
				IL2CPP.il2cpp_field_static_get_value(VideoCapture.NativeFieldInfoPtr_HR_SUCCESS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VideoCapture.NativeFieldInfoPtr_HR_SUCCESS, (void*)(&value));
			}
		}

		// Token: 0x040018D8 RID: 6360
		private static readonly IntPtr NativeFieldInfoPtr_m_NativePtr;

		// Token: 0x040018D9 RID: 6361
		private static readonly IntPtr NativeFieldInfoPtr_HR_SUCCESS;

		// Token: 0x040018DA RID: 6362
		private static readonly IntPtr NativeMethodInfoPtr_MakeCaptureResult_Private_Static_VideoCaptureResult_Int64_0;

		// Token: 0x040018DB RID: 6363
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnCreatedVideoCaptureResourceDelegate_Private_Static_Void_OnVideoCaptureResourceCreatedCallback_IntPtr_0;

		// Token: 0x040018DC RID: 6364
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnVideoModeStartedDelegate_Private_Static_Void_OnVideoModeStartedCallback_Int64_0;

		// Token: 0x040018DD RID: 6365
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnVideoModeStoppedDelegate_Private_Static_Void_OnVideoModeStoppedCallback_Int64_0;

		// Token: 0x040018DE RID: 6366
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnStartedRecordingVideoToDiskDelegate_Private_Static_Void_OnStartedRecordingVideoCallback_Int64_0;

		// Token: 0x040018DF RID: 6367
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnStoppedRecordingVideoToDiskDelegate_Private_Static_Void_OnStoppedRecordingVideoCallback_Int64_0;

		// Token: 0x040018E0 RID: 6368
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040018E1 RID: 6369
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Internal_Private_Void_0;

		// Token: 0x040018E2 RID: 6370
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040018E3 RID: 6371
		private static readonly IntPtr NativeMethodInfoPtr_DisposeThreaded_Internal_Private_Void_0;

		// Token: 0x02000A12 RID: 2578
		[OriginalName("UnityEngine.CoreModule.dll", "", "CaptureResultType")]
		public enum CaptureResultType
		{
			// Token: 0x04002B91 RID: 11153
			Success,
			// Token: 0x04002B92 RID: 11154
			UnknownError
		}

		// Token: 0x02000A13 RID: 2579
		[StructLayout(2)]
		public struct VideoCaptureResult
		{
			// Token: 0x06003CDE RID: 15582 RVA: 0x000B3E28 File Offset: 0x000B2028
			// Note: this type is marked as 'beforefieldinit'.
			static VideoCaptureResult()
			{
				Il2CppClassPointerStore<VideoCapture.VideoCaptureResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, "VideoCaptureResult");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VideoCapture.VideoCaptureResult>.NativeClassPtr);
				VideoCapture.VideoCaptureResult.NativeFieldInfoPtr_resultType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoCapture.VideoCaptureResult>.NativeClassPtr, "resultType");
				VideoCapture.VideoCaptureResult.NativeFieldInfoPtr_hResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoCapture.VideoCaptureResult>.NativeClassPtr, "hResult");
			}

			// Token: 0x06003CDF RID: 15583 RVA: 0x00016614 File Offset: 0x00014814
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VideoCapture.VideoCaptureResult>.NativeClassPtr, ref this));
			}

			// Token: 0x04002B93 RID: 11155
			private static readonly IntPtr NativeFieldInfoPtr_resultType;

			// Token: 0x04002B94 RID: 11156
			private static readonly IntPtr NativeFieldInfoPtr_hResult;

			// Token: 0x04002B95 RID: 11157
			[FieldOffset(0)]
			public VideoCapture.CaptureResultType resultType;

			// Token: 0x04002B96 RID: 11158
			[FieldOffset(8)]
			public long hResult;
		}

		// Token: 0x02000A14 RID: 2580
		public sealed class OnVideoCaptureResourceCreatedCallback : MulticastDelegate
		{
			// Token: 0x06003CE0 RID: 15584 RVA: 0x00016626 File Offset: 0x00014826
			// Note: this type is marked as 'beforefieldinit'.
			static OnVideoCaptureResourceCreatedCallback()
			{
				Il2CppClassPointerStore<VideoCapture.OnVideoCaptureResourceCreatedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, "OnVideoCaptureResourceCreatedCallback");
				VideoCapture.OnVideoCaptureResourceCreatedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnVideoCaptureResourceCreatedCallback>.NativeClassPtr, 100666575);
				VideoCapture.OnVideoCaptureResourceCreatedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCapture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnVideoCaptureResourceCreatedCallback>.NativeClassPtr, 100666576);
			}

			// Token: 0x06003CE1 RID: 15585 RVA: 0x000B3E7C File Offset: 0x000B207C
			[CallerCount(329)]
			[CachedScanResults(RefRangeStart = 101484, RefRangeEnd = 101813, XrefRangeStart = 101484, XrefRangeEnd = 101813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnVideoCaptureResourceCreatedCallback(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VideoCapture.OnVideoCaptureResourceCreatedCallback>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnVideoCaptureResourceCreatedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003CE2 RID: 15586 RVA: 0x000B3ED8 File Offset: 0x000B20D8
			[CallerCount(0)]
			public unsafe void Invoke(VideoCapture captureObject)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(captureObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnVideoCaptureResourceCreatedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCapture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003CE3 RID: 15587 RVA: 0x00016664 File Offset: 0x00014864
			public OnVideoCaptureResourceCreatedCallback(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06003CE4 RID: 15588 RVA: 0x0001666D File Offset: 0x0001486D
			public static implicit operator VideoCapture.OnVideoCaptureResourceCreatedCallback(Action<VideoCapture> A_0)
			{
				return DelegateSupport.ConvertDelegate<VideoCapture.OnVideoCaptureResourceCreatedCallback>(A_0);
			}

			// Token: 0x06003CE5 RID: 15589 RVA: 0x00016675 File Offset: 0x00014875
			public static VideoCapture.OnVideoCaptureResourceCreatedCallback operator +(VideoCapture.OnVideoCaptureResourceCreatedCallback A_0, VideoCapture.OnVideoCaptureResourceCreatedCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<VideoCapture.OnVideoCaptureResourceCreatedCallback>();
			}

			// Token: 0x06003CE6 RID: 15590 RVA: 0x00016683 File Offset: 0x00014883
			public static VideoCapture.OnVideoCaptureResourceCreatedCallback operator -(VideoCapture.OnVideoCaptureResourceCreatedCallback A_0, VideoCapture.OnVideoCaptureResourceCreatedCallback A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<VideoCapture.OnVideoCaptureResourceCreatedCallback>();
				}
				return result;
			}

			// Token: 0x04002B97 RID: 11159
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002B98 RID: 11160
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCapture_0;
		}

		// Token: 0x02000A15 RID: 2581
		public sealed class OnVideoModeStartedCallback : MulticastDelegate
		{
			// Token: 0x06003CE7 RID: 15591 RVA: 0x00016694 File Offset: 0x00014894
			// Note: this type is marked as 'beforefieldinit'.
			static OnVideoModeStartedCallback()
			{
				Il2CppClassPointerStore<VideoCapture.OnVideoModeStartedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, "OnVideoModeStartedCallback");
				VideoCapture.OnVideoModeStartedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnVideoModeStartedCallback>.NativeClassPtr, 100666577);
				VideoCapture.OnVideoModeStartedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnVideoModeStartedCallback>.NativeClassPtr, 100666578);
			}

			// Token: 0x06003CE8 RID: 15592 RVA: 0x000B3F1C File Offset: 0x000B211C
			[CallerCount(143)]
			[CachedScanResults(RefRangeStart = 345901, RefRangeEnd = 346044, XrefRangeStart = 345901, XrefRangeEnd = 346044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnVideoModeStartedCallback(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VideoCapture.OnVideoModeStartedCallback>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnVideoModeStartedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003CE9 RID: 15593 RVA: 0x000B3F78 File Offset: 0x000B2178
			[CallerCount(0)]
			public unsafe void Invoke(VideoCapture.VideoCaptureResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnVideoModeStartedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003CEA RID: 15594 RVA: 0x000166D2 File Offset: 0x000148D2
			public OnVideoModeStartedCallback(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06003CEB RID: 15595 RVA: 0x000166DB File Offset: 0x000148DB
			public static implicit operator VideoCapture.OnVideoModeStartedCallback(Action<VideoCapture.VideoCaptureResult> A_0)
			{
				return DelegateSupport.ConvertDelegate<VideoCapture.OnVideoModeStartedCallback>(A_0);
			}

			// Token: 0x06003CEC RID: 15596 RVA: 0x000166E3 File Offset: 0x000148E3
			public static VideoCapture.OnVideoModeStartedCallback operator +(VideoCapture.OnVideoModeStartedCallback A_0, VideoCapture.OnVideoModeStartedCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<VideoCapture.OnVideoModeStartedCallback>();
			}

			// Token: 0x06003CED RID: 15597 RVA: 0x000166F1 File Offset: 0x000148F1
			public static VideoCapture.OnVideoModeStartedCallback operator -(VideoCapture.OnVideoModeStartedCallback A_0, VideoCapture.OnVideoModeStartedCallback A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<VideoCapture.OnVideoModeStartedCallback>();
				}
				return result;
			}

			// Token: 0x04002B99 RID: 11161
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002B9A RID: 11162
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0;
		}

		// Token: 0x02000A16 RID: 2582
		public sealed class OnVideoModeStoppedCallback : MulticastDelegate
		{
			// Token: 0x06003CEE RID: 15598 RVA: 0x00016702 File Offset: 0x00014902
			// Note: this type is marked as 'beforefieldinit'.
			static OnVideoModeStoppedCallback()
			{
				Il2CppClassPointerStore<VideoCapture.OnVideoModeStoppedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, "OnVideoModeStoppedCallback");
				VideoCapture.OnVideoModeStoppedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnVideoModeStoppedCallback>.NativeClassPtr, 100666579);
				VideoCapture.OnVideoModeStoppedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnVideoModeStoppedCallback>.NativeClassPtr, 100666580);
			}

			// Token: 0x06003CEF RID: 15599 RVA: 0x000B3FB8 File Offset: 0x000B21B8
			[CallerCount(143)]
			[CachedScanResults(RefRangeStart = 345901, RefRangeEnd = 346044, XrefRangeStart = 345901, XrefRangeEnd = 346044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnVideoModeStoppedCallback(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VideoCapture.OnVideoModeStoppedCallback>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnVideoModeStoppedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003CF0 RID: 15600 RVA: 0x000B4014 File Offset: 0x000B2214
			[CallerCount(0)]
			public unsafe void Invoke(VideoCapture.VideoCaptureResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnVideoModeStoppedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003CF1 RID: 15601 RVA: 0x00016740 File Offset: 0x00014940
			public OnVideoModeStoppedCallback(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06003CF2 RID: 15602 RVA: 0x00016749 File Offset: 0x00014949
			public static implicit operator VideoCapture.OnVideoModeStoppedCallback(Action<VideoCapture.VideoCaptureResult> A_0)
			{
				return DelegateSupport.ConvertDelegate<VideoCapture.OnVideoModeStoppedCallback>(A_0);
			}

			// Token: 0x06003CF3 RID: 15603 RVA: 0x00016751 File Offset: 0x00014951
			public static VideoCapture.OnVideoModeStoppedCallback operator +(VideoCapture.OnVideoModeStoppedCallback A_0, VideoCapture.OnVideoModeStoppedCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<VideoCapture.OnVideoModeStoppedCallback>();
			}

			// Token: 0x06003CF4 RID: 15604 RVA: 0x0001675F File Offset: 0x0001495F
			public static VideoCapture.OnVideoModeStoppedCallback operator -(VideoCapture.OnVideoModeStoppedCallback A_0, VideoCapture.OnVideoModeStoppedCallback A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<VideoCapture.OnVideoModeStoppedCallback>();
				}
				return result;
			}

			// Token: 0x04002B9B RID: 11163
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002B9C RID: 11164
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0;
		}

		// Token: 0x02000A17 RID: 2583
		public sealed class OnStartedRecordingVideoCallback : MulticastDelegate
		{
			// Token: 0x06003CF5 RID: 15605 RVA: 0x00016770 File Offset: 0x00014970
			// Note: this type is marked as 'beforefieldinit'.
			static OnStartedRecordingVideoCallback()
			{
				Il2CppClassPointerStore<VideoCapture.OnStartedRecordingVideoCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, "OnStartedRecordingVideoCallback");
				VideoCapture.OnStartedRecordingVideoCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnStartedRecordingVideoCallback>.NativeClassPtr, 100666581);
				VideoCapture.OnStartedRecordingVideoCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnStartedRecordingVideoCallback>.NativeClassPtr, 100666582);
			}

			// Token: 0x06003CF6 RID: 15606 RVA: 0x000B4054 File Offset: 0x000B2254
			[CallerCount(143)]
			[CachedScanResults(RefRangeStart = 345901, RefRangeEnd = 346044, XrefRangeStart = 345901, XrefRangeEnd = 346044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnStartedRecordingVideoCallback(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VideoCapture.OnStartedRecordingVideoCallback>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnStartedRecordingVideoCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003CF7 RID: 15607 RVA: 0x000B40B0 File Offset: 0x000B22B0
			[CallerCount(0)]
			public unsafe void Invoke(VideoCapture.VideoCaptureResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnStartedRecordingVideoCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003CF8 RID: 15608 RVA: 0x000167AE File Offset: 0x000149AE
			public OnStartedRecordingVideoCallback(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06003CF9 RID: 15609 RVA: 0x000167B7 File Offset: 0x000149B7
			public static implicit operator VideoCapture.OnStartedRecordingVideoCallback(Action<VideoCapture.VideoCaptureResult> A_0)
			{
				return DelegateSupport.ConvertDelegate<VideoCapture.OnStartedRecordingVideoCallback>(A_0);
			}

			// Token: 0x06003CFA RID: 15610 RVA: 0x000167BF File Offset: 0x000149BF
			public static VideoCapture.OnStartedRecordingVideoCallback operator +(VideoCapture.OnStartedRecordingVideoCallback A_0, VideoCapture.OnStartedRecordingVideoCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<VideoCapture.OnStartedRecordingVideoCallback>();
			}

			// Token: 0x06003CFB RID: 15611 RVA: 0x000167CD File Offset: 0x000149CD
			public static VideoCapture.OnStartedRecordingVideoCallback operator -(VideoCapture.OnStartedRecordingVideoCallback A_0, VideoCapture.OnStartedRecordingVideoCallback A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<VideoCapture.OnStartedRecordingVideoCallback>();
				}
				return result;
			}

			// Token: 0x04002B9D RID: 11165
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002B9E RID: 11166
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0;
		}

		// Token: 0x02000A18 RID: 2584
		public sealed class OnStoppedRecordingVideoCallback : MulticastDelegate
		{
			// Token: 0x06003CFC RID: 15612 RVA: 0x000167DE File Offset: 0x000149DE
			// Note: this type is marked as 'beforefieldinit'.
			static OnStoppedRecordingVideoCallback()
			{
				Il2CppClassPointerStore<VideoCapture.OnStoppedRecordingVideoCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, "OnStoppedRecordingVideoCallback");
				VideoCapture.OnStoppedRecordingVideoCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnStoppedRecordingVideoCallback>.NativeClassPtr, 100666583);
				VideoCapture.OnStoppedRecordingVideoCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnStoppedRecordingVideoCallback>.NativeClassPtr, 100666584);
			}

			// Token: 0x06003CFD RID: 15613 RVA: 0x000B40F0 File Offset: 0x000B22F0
			[CallerCount(143)]
			[CachedScanResults(RefRangeStart = 345901, RefRangeEnd = 346044, XrefRangeStart = 345901, XrefRangeEnd = 346044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnStoppedRecordingVideoCallback(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VideoCapture.OnStoppedRecordingVideoCallback>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnStoppedRecordingVideoCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003CFE RID: 15614 RVA: 0x000B414C File Offset: 0x000B234C
			[CallerCount(0)]
			public unsafe void Invoke(VideoCapture.VideoCaptureResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnStoppedRecordingVideoCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003CFF RID: 15615 RVA: 0x0001681C File Offset: 0x00014A1C
			public OnStoppedRecordingVideoCallback(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06003D00 RID: 15616 RVA: 0x00016825 File Offset: 0x00014A25
			public static implicit operator VideoCapture.OnStoppedRecordingVideoCallback(Action<VideoCapture.VideoCaptureResult> A_0)
			{
				return DelegateSupport.ConvertDelegate<VideoCapture.OnStoppedRecordingVideoCallback>(A_0);
			}

			// Token: 0x06003D01 RID: 15617 RVA: 0x0001682D File Offset: 0x00014A2D
			public static VideoCapture.OnStoppedRecordingVideoCallback operator +(VideoCapture.OnStoppedRecordingVideoCallback A_0, VideoCapture.OnStoppedRecordingVideoCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<VideoCapture.OnStoppedRecordingVideoCallback>();
			}

			// Token: 0x06003D02 RID: 15618 RVA: 0x0001683B File Offset: 0x00014A3B
			public static VideoCapture.OnStoppedRecordingVideoCallback operator -(VideoCapture.OnStoppedRecordingVideoCallback A_0, VideoCapture.OnStoppedRecordingVideoCallback A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<VideoCapture.OnStoppedRecordingVideoCallback>();
				}
				return result;
			}

			// Token: 0x04002B9F RID: 11167
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002BA0 RID: 11168
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0;
		}
	}
}
