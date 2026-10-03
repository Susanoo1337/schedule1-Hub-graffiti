using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine.Rendering
{
	// Token: 0x0200022F RID: 559
	public class RenderPipeline : Object
	{
		// Token: 0x060025D6 RID: 9686 RVA: 0x00096954 File Offset: 0x00094B54
		// Note: this type is marked as 'beforefieldinit'.
		static RenderPipeline()
		{
			Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "RenderPipeline");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr);
			RenderPipeline.NativeFieldInfoPtr__disposed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, "<disposed>k__BackingField");
			RenderPipeline.NativeMethodInfoPtr_Render_Protected_Abstract_Virtual_New_Void_ScriptableRenderContext_Il2CppReferenceArray_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100667343);
			RenderPipeline.NativeMethodInfoPtr_ProcessRenderRequests_Protected_Virtual_New_Void_ScriptableRenderContext_Camera_RequestData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100667344);
			RenderPipeline.NativeMethodInfoPtr_IsRenderRequestSupported_FamOrAssem_Virtual_New_Boolean_Camera_RequestData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100667345);
			RenderPipeline.NativeMethodInfoPtr_BeginContextRendering_Protected_Static_Void_ScriptableRenderContext_List_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100667346);
			RenderPipeline.NativeMethodInfoPtr_BeginCameraRendering_Protected_Static_Void_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100667347);
			RenderPipeline.NativeMethodInfoPtr_EndContextRendering_Protected_Static_Void_ScriptableRenderContext_List_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100667348);
			RenderPipeline.NativeMethodInfoPtr_EndCameraRendering_Protected_Static_Void_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100667349);
			RenderPipeline.NativeMethodInfoPtr_Render_Protected_Virtual_New_Void_ScriptableRenderContext_List_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100667350);
			RenderPipeline.NativeMethodInfoPtr_InternalRender_Internal_Void_ScriptableRenderContext_List_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100667351);
			RenderPipeline.NativeMethodInfoPtr_InternalProcessRenderRequests_Internal_Void_ScriptableRenderContext_Camera_RequestData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100667352);
			RenderPipeline.NativeMethodInfoPtr_get_disposed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100667353);
			RenderPipeline.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100667354);
			RenderPipeline.NativeMethodInfoPtr_Dispose_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100667355);
			RenderPipeline.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100667356);
			RenderPipeline.NativeMethodInfoPtr_get_defaultSettings_Public_Virtual_New_get_RenderPipelineGlobalSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100667357);
			RenderPipeline.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100667358);
		}

		// Token: 0x060025D7 RID: 9687 RVA: 0x00096AD8 File Offset: 0x00094CD8
		[CallerCount(0)]
		public unsafe virtual void Render(ScriptableRenderContext context, Il2CppReferenceArray<Camera> cameras)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref context;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cameras);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipeline.NativeMethodInfoPtr_Render_Protected_Abstract_Virtual_New_Void_ScriptableRenderContext_Il2CppReferenceArray_1_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025D8 RID: 9688 RVA: 0x00096B34 File Offset: 0x00094D34
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ProcessRenderRequests<RequestData>(ScriptableRenderContext context, Camera camera, RequestData renderRequest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref context;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			RequestData ptr4;
			if (!typeof(RequestData).IsValueType)
			{
				RequestData requestData = renderRequest;
				if (!(requestData is string))
				{
					ref RequestData ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(requestData as Il2CppObjectBase);
					if (ref ptr3 != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(requestData as string);
				}
			}
			else
			{
				ptr4 = ref renderRequest;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipeline.MethodInfoStoreGeneric_ProcessRenderRequests_Protected_Virtual_New_Void_ScriptableRenderContext_Camera_RequestData_0<RequestData>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025D9 RID: 9689 RVA: 0x00096BEC File Offset: 0x00094DEC
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 1228272, RefRangeEnd = 1228309, XrefRangeStart = 1228272, XrefRangeEnd = 1228309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsRenderRequestSupported<RequestData>(Camera camera, RequestData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			RequestData ptr4;
			if (!typeof(RequestData).IsValueType)
			{
				RequestData requestData = data;
				if (!(requestData is string))
				{
					ref RequestData ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(requestData as Il2CppObjectBase);
					if (ref ptr3 != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(requestData as string);
				}
			}
			else
			{
				ptr4 = ref data;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipeline.MethodInfoStoreGeneric_IsRenderRequestSupported_FamOrAssem_Virtual_New_Boolean_Camera_RequestData_0<RequestData>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025DA RID: 9690 RVA: 0x00096CA4 File Offset: 0x00094EA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1290706, RefRangeEnd = 1290708, XrefRangeStart = 1290693, XrefRangeEnd = 1290706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginContextRendering(ScriptableRenderContext context, List<Camera> cameras)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref context;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cameras);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipeline.NativeMethodInfoPtr_BeginContextRendering_Protected_Static_Void_ScriptableRenderContext_List_1_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025DB RID: 9691 RVA: 0x00096CE8 File Offset: 0x00094EE8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1290715, RefRangeEnd = 1290719, XrefRangeStart = 1290708, XrefRangeEnd = 1290715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginCameraRendering(ScriptableRenderContext context, Camera camera)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref context;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipeline.NativeMethodInfoPtr_BeginCameraRendering_Protected_Static_Void_ScriptableRenderContext_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025DC RID: 9692 RVA: 0x00096D2C File Offset: 0x00094F2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1290732, RefRangeEnd = 1290734, XrefRangeStart = 1290719, XrefRangeEnd = 1290732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndContextRendering(ScriptableRenderContext context, List<Camera> cameras)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref context;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cameras);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipeline.NativeMethodInfoPtr_EndContextRendering_Protected_Static_Void_ScriptableRenderContext_List_1_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025DD RID: 9693 RVA: 0x00096D70 File Offset: 0x00094F70
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1290741, RefRangeEnd = 1290745, XrefRangeStart = 1290734, XrefRangeEnd = 1290741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndCameraRendering(ScriptableRenderContext context, Camera camera)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref context;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipeline.NativeMethodInfoPtr_EndCameraRendering_Protected_Static_Void_ScriptableRenderContext_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025DE RID: 9694 RVA: 0x00096DB4 File Offset: 0x00094FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290745, XrefRangeEnd = 1290749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Render(ScriptableRenderContext context, List<Camera> cameras)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref context;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cameras);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipeline.NativeMethodInfoPtr_Render_Protected_Virtual_New_Void_ScriptableRenderContext_List_1_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025DF RID: 9695 RVA: 0x00096E10 File Offset: 0x00095010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290749, XrefRangeEnd = 1290756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalRender(ScriptableRenderContext context, List<Camera> cameras)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref context;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cameras);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipeline.NativeMethodInfoPtr_InternalRender_Internal_Void_ScriptableRenderContext_List_1_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025E0 RID: 9696 RVA: 0x00096E60 File Offset: 0x00095060
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1290764, RefRangeEnd = 1290765, XrefRangeStart = 1290756, XrefRangeEnd = 1290764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalProcessRenderRequests<RequestData>(ScriptableRenderContext context, Camera camera, RequestData renderRequest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref context;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			RequestData ptr4;
			if (!typeof(RequestData).IsValueType)
			{
				RequestData requestData = renderRequest;
				if (!(requestData is string))
				{
					ref RequestData ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(requestData as Il2CppObjectBase);
					if (ref ptr3 != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(requestData as string);
				}
			}
			else
			{
				ptr4 = ref renderRequest;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipeline.MethodInfoStoreGeneric_InternalProcessRenderRequests_Internal_Void_ScriptableRenderContext_Camera_RequestData_0<RequestData>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x060025E1 RID: 9697 RVA: 0x00096F10 File Offset: 0x00095110
		// (set) Token: 0x060025E2 RID: 9698 RVA: 0x00096F4C File Offset: 0x0009514C
		public unsafe bool disposed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipeline.NativeMethodInfoPtr_get_disposed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 32215, RefRangeEnd = 32216, XrefRangeStart = 32215, XrefRangeEnd = 32216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipeline.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060025E3 RID: 9699 RVA: 0x00096F8C File Offset: 0x0009518C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290765, XrefRangeEnd = 1290769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipeline.NativeMethodInfoPtr_Dispose_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025E4 RID: 9700 RVA: 0x00096FC0 File Offset: 0x000951C0
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref disposing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipeline.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x060025E5 RID: 9701 RVA: 0x0009700C File Offset: 0x0009520C
		public unsafe virtual RenderPipelineGlobalSettings defaultSettings
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1019274, RefRangeEnd = 1019275, XrefRangeStart = 1019274, XrefRangeEnd = 1019275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipeline.NativeMethodInfoPtr_get_defaultSettings_Public_Virtual_New_get_RenderPipelineGlobalSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderPipelineGlobalSettings>(intPtr3) : null;
			}
		}

		// Token: 0x060025E6 RID: 9702 RVA: 0x00097058 File Offset: 0x00095258
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderPipeline() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipeline.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025E7 RID: 9703 RVA: 0x000114DA File Offset: 0x0000F6DA
		public RenderPipeline(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x060025E8 RID: 9704 RVA: 0x00097094 File Offset: 0x00095294
		// (set) Token: 0x060025E9 RID: 9705 RVA: 0x000114E3 File Offset: 0x0000F6E3
		public unsafe bool _disposed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderPipeline.NativeFieldInfoPtr__disposed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderPipeline.NativeFieldInfoPtr__disposed_k__BackingField)) = value;
			}
		}

		// Token: 0x060025EA RID: 9706 RVA: 0x000114FE File Offset: 0x0000F6FE
		public static void BeginFrameRendering(ScriptableRenderContext context, Il2CppReferenceArray<Camera> cameras)
		{
			RenderPipelineManager.BeginContextRendering(context, new List<Camera>(cameras));
		}

		// Token: 0x060025EB RID: 9707 RVA: 0x0001150E File Offset: 0x0000F70E
		public static void EndFrameRendering(ScriptableRenderContext context, Il2CppReferenceArray<Camera> cameras)
		{
			RenderPipelineManager.EndContextRendering(context, new List<Camera>(cameras));
		}

		// Token: 0x060025EC RID: 9708 RVA: 0x000970BC File Offset: 0x000952BC
		public static bool SupportsRenderRequest<RequestData>(Camera camera, RequestData data)
		{
			bool result = false;
			bool flag = GraphicsSettings.currentRenderPipeline != null;
			if (flag)
			{
				bool flag2 = RenderPipelineManager.currentPipeline == null;
				if (flag2)
				{
					RenderPipelineManager.PrepareRenderPipeline(GraphicsSettings.currentRenderPipeline);
				}
				result = RenderPipelineManager.currentPipeline.IsRenderRequestSupported<RequestData>(camera, data);
			}
			return result;
		}

		// Token: 0x060025ED RID: 9709 RVA: 0x0001151E File Offset: 0x0000F71E
		public static void SubmitRenderRequest<RequestData>(Camera camera, RequestData data)
		{
			camera.SubmitRenderRequest<RequestData>(data);
		}

		// Token: 0x0400206C RID: 8300
		private static readonly IntPtr NativeFieldInfoPtr__disposed_k__BackingField;

		// Token: 0x0400206D RID: 8301
		private static readonly IntPtr NativeMethodInfoPtr_Render_Protected_Abstract_Virtual_New_Void_ScriptableRenderContext_Il2CppReferenceArray_1_Camera_0;

		// Token: 0x0400206E RID: 8302
		private static readonly IntPtr NativeMethodInfoPtr_ProcessRenderRequests_Protected_Virtual_New_Void_ScriptableRenderContext_Camera_RequestData_0;

		// Token: 0x0400206F RID: 8303
		private static readonly IntPtr NativeMethodInfoPtr_IsRenderRequestSupported_FamOrAssem_Virtual_New_Boolean_Camera_RequestData_0;

		// Token: 0x04002070 RID: 8304
		private static readonly IntPtr NativeMethodInfoPtr_BeginContextRendering_Protected_Static_Void_ScriptableRenderContext_List_1_Camera_0;

		// Token: 0x04002071 RID: 8305
		private static readonly IntPtr NativeMethodInfoPtr_BeginCameraRendering_Protected_Static_Void_ScriptableRenderContext_Camera_0;

		// Token: 0x04002072 RID: 8306
		private static readonly IntPtr NativeMethodInfoPtr_EndContextRendering_Protected_Static_Void_ScriptableRenderContext_List_1_Camera_0;

		// Token: 0x04002073 RID: 8307
		private static readonly IntPtr NativeMethodInfoPtr_EndCameraRendering_Protected_Static_Void_ScriptableRenderContext_Camera_0;

		// Token: 0x04002074 RID: 8308
		private static readonly IntPtr NativeMethodInfoPtr_Render_Protected_Virtual_New_Void_ScriptableRenderContext_List_1_Camera_0;

		// Token: 0x04002075 RID: 8309
		private static readonly IntPtr NativeMethodInfoPtr_InternalRender_Internal_Void_ScriptableRenderContext_List_1_Camera_0;

		// Token: 0x04002076 RID: 8310
		private static readonly IntPtr NativeMethodInfoPtr_InternalProcessRenderRequests_Internal_Void_ScriptableRenderContext_Camera_RequestData_0;

		// Token: 0x04002077 RID: 8311
		private static readonly IntPtr NativeMethodInfoPtr_get_disposed_Public_get_Boolean_0;

		// Token: 0x04002078 RID: 8312
		private static readonly IntPtr NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0;

		// Token: 0x04002079 RID: 8313
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Internal_Void_0;

		// Token: 0x0400207A RID: 8314
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x0400207B RID: 8315
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Virtual_New_get_RenderPipelineGlobalSettings_0;

		// Token: 0x0400207C RID: 8316
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000B67 RID: 2919
		public class StandardRequest : Object
		{
			// Token: 0x06003FB7 RID: 16311 RVA: 0x000B4FE4 File Offset: 0x000B31E4
			// Note: this type is marked as 'beforefieldinit'.
			static StandardRequest()
			{
				Il2CppClassPointerStore<RenderPipeline.StandardRequest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, "StandardRequest");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderPipeline.StandardRequest>.NativeClassPtr);
				RenderPipeline.StandardRequest.NativeFieldInfoPtr_destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipeline.StandardRequest>.NativeClassPtr, "destination");
				RenderPipeline.StandardRequest.NativeFieldInfoPtr_mipLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipeline.StandardRequest>.NativeClassPtr, "mipLevel");
				RenderPipeline.StandardRequest.NativeFieldInfoPtr_face = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipeline.StandardRequest>.NativeClassPtr, "face");
				RenderPipeline.StandardRequest.NativeFieldInfoPtr_slice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipeline.StandardRequest>.NativeClassPtr, "slice");
			}

			// Token: 0x06003FB8 RID: 16312 RVA: 0x00018631 File Offset: 0x00016831
			public StandardRequest(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17000A33 RID: 2611
			// (get) Token: 0x06003FB9 RID: 16313 RVA: 0x000B5060 File Offset: 0x000B3260
			// (set) Token: 0x06003FBA RID: 16314 RVA: 0x0001863A File Offset: 0x0001683A
			public unsafe RenderTexture destination
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderPipeline.StandardRequest.NativeFieldInfoPtr_destination);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderPipeline.StandardRequest.NativeFieldInfoPtr_destination), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A34 RID: 2612
			// (get) Token: 0x06003FBB RID: 16315 RVA: 0x000B5090 File Offset: 0x000B3290
			// (set) Token: 0x06003FBC RID: 16316 RVA: 0x00018659 File Offset: 0x00016859
			public unsafe int mipLevel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderPipeline.StandardRequest.NativeFieldInfoPtr_mipLevel);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderPipeline.StandardRequest.NativeFieldInfoPtr_mipLevel)) = value;
				}
			}

			// Token: 0x17000A35 RID: 2613
			// (get) Token: 0x06003FBD RID: 16317 RVA: 0x000B50B8 File Offset: 0x000B32B8
			// (set) Token: 0x06003FBE RID: 16318 RVA: 0x00018674 File Offset: 0x00016874
			public unsafe CubemapFace face
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderPipeline.StandardRequest.NativeFieldInfoPtr_face);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderPipeline.StandardRequest.NativeFieldInfoPtr_face)) = value;
				}
			}

			// Token: 0x17000A36 RID: 2614
			// (get) Token: 0x06003FBF RID: 16319 RVA: 0x000B50E0 File Offset: 0x000B32E0
			// (set) Token: 0x06003FC0 RID: 16320 RVA: 0x0001868F File Offset: 0x0001688F
			public unsafe int slice
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderPipeline.StandardRequest.NativeFieldInfoPtr_slice);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderPipeline.StandardRequest.NativeFieldInfoPtr_slice)) = value;
				}
			}

			// Token: 0x04002BDA RID: 11226
			private static readonly IntPtr NativeFieldInfoPtr_destination;

			// Token: 0x04002BDB RID: 11227
			private static readonly IntPtr NativeFieldInfoPtr_mipLevel;

			// Token: 0x04002BDC RID: 11228
			private static readonly IntPtr NativeFieldInfoPtr_face;

			// Token: 0x04002BDD RID: 11229
			private static readonly IntPtr NativeFieldInfoPtr_slice;
		}

		// Token: 0x02000B68 RID: 2920
		private sealed class MethodInfoStoreGeneric_ProcessRenderRequests_Protected_Virtual_New_Void_ScriptableRenderContext_Camera_RequestData_0<RequestData>
		{
			// Token: 0x04002BDE RID: 11230
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(RenderPipeline.NativeMethodInfoPtr_ProcessRenderRequests_Protected_Virtual_New_Void_ScriptableRenderContext_Camera_RequestData_0, Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<RequestData>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000B69 RID: 2921
		private sealed class MethodInfoStoreGeneric_IsRenderRequestSupported_FamOrAssem_Virtual_New_Boolean_Camera_RequestData_0<RequestData>
		{
			// Token: 0x04002BDF RID: 11231
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(RenderPipeline.NativeMethodInfoPtr_IsRenderRequestSupported_FamOrAssem_Virtual_New_Boolean_Camera_RequestData_0, Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<RequestData>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000B6A RID: 2922
		private sealed class MethodInfoStoreGeneric_InternalProcessRenderRequests_Internal_Void_ScriptableRenderContext_Camera_RequestData_0<RequestData>
		{
			// Token: 0x04002BE0 RID: 11232
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(RenderPipeline.NativeMethodInfoPtr_InternalProcessRenderRequests_Internal_Void_ScriptableRenderContext_Camera_RequestData_0, Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<RequestData>.NativeClassPtr))
			}))));
		}
	}
}
