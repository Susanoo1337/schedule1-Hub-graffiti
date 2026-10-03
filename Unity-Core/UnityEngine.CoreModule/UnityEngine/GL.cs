using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000097 RID: 151
	public sealed class GL : Object
	{
		// Token: 0x06000903 RID: 2307 RVA: 0x00033F60 File Offset: 0x00032160
		// Note: this type is marked as 'beforefieldinit'.
		static GL()
		{
			Il2CppClassPointerStore<GL>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "GL");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GL>.NativeClassPtr);
			GL.NativeMethodInfoPtr_Vertex3_Public_Static_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664213);
			GL.NativeMethodInfoPtr_Vertex_Public_Static_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664214);
			GL.NativeMethodInfoPtr_TexCoord3_Public_Static_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664215);
			GL.NativeMethodInfoPtr_TexCoord2_Public_Static_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664216);
			GL.NativeMethodInfoPtr_MultiTexCoord3_Public_Static_Void_Int32_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664217);
			GL.NativeMethodInfoPtr_MultiTexCoord2_Public_Static_Void_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664218);
			GL.NativeMethodInfoPtr_ImmediateColor_Private_Static_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664219);
			GL.NativeMethodInfoPtr_Color_Public_Static_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664220);
			GL.NativeMethodInfoPtr_get_wireframe_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664221);
			GL.NativeMethodInfoPtr_set_wireframe_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664222);
			GL.NativeMethodInfoPtr_set_invertCulling_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664223);
			GL.NativeMethodInfoPtr_SetViewMatrix_Private_Static_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664224);
			GL.NativeMethodInfoPtr_set_modelview_Public_Static_set_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664225);
			GL.NativeMethodInfoPtr_PushMatrix_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664226);
			GL.NativeMethodInfoPtr_PopMatrix_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664227);
			GL.NativeMethodInfoPtr_LoadOrtho_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664228);
			GL.NativeMethodInfoPtr_LoadProjectionMatrix_Public_Static_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664229);
			GL.NativeMethodInfoPtr_GetGPUProjectionMatrix_Public_Static_Matrix4x4_Matrix4x4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664230);
			GL.NativeMethodInfoPtr_GLLoadPixelMatrixScript_Private_Static_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664231);
			GL.NativeMethodInfoPtr_LoadPixelMatrix_Public_Static_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664232);
			GL.NativeMethodInfoPtr_Begin_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664233);
			GL.NativeMethodInfoPtr_End_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664234);
			GL.NativeMethodInfoPtr_GLClear_Private_Static_Void_Boolean_Boolean_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664235);
			GL.NativeMethodInfoPtr_Clear_Public_Static_Void_Boolean_Boolean_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664236);
			GL.NativeMethodInfoPtr_Clear_Public_Static_Void_Boolean_Boolean_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664237);
			GL.NativeMethodInfoPtr_Viewport_Public_Static_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664238);
			GL.NativeMethodInfoPtr_SetViewMatrix_Injected_Private_Static_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664239);
			GL.NativeMethodInfoPtr_LoadProjectionMatrix_Injected_Private_Static_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664240);
			GL.NativeMethodInfoPtr_GetGPUProjectionMatrix_Injected_Private_Static_Void_byref_Matrix4x4_Boolean_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664241);
			GL.NativeMethodInfoPtr_GLClear_Injected_Private_Static_Void_Boolean_Boolean_byref_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664242);
			GL.NativeMethodInfoPtr_Viewport_Injected_Private_Static_Void_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664243);
			GL.VerticesDelegateField = IL2CPP.ResolveICall<GL.VerticesDelegate>("UnityEngine.GL::Vertices");
			GL.get_sRGBWriteDelegateField = IL2CPP.ResolveICall<GL.get_sRGBWriteDelegate>("UnityEngine.GL::get_sRGBWrite");
			GL.set_sRGBWriteDelegateField = IL2CPP.ResolveICall<GL.set_sRGBWriteDelegate>("UnityEngine.GL::set_sRGBWrite");
			GL.get_invertCullingDelegateField = IL2CPP.ResolveICall<GL.get_invertCullingDelegate>("UnityEngine.GL::get_invertCulling");
			GL.FlushDelegateField = IL2CPP.ResolveICall<GL.FlushDelegate>("UnityEngine.GL::Flush");
			GL.RenderTargetBarrierDelegateField = IL2CPP.ResolveICall<GL.RenderTargetBarrierDelegate>("UnityEngine.GL::RenderTargetBarrier");
			GL.IssuePluginEventDelegateField = IL2CPP.ResolveICall<GL.IssuePluginEventDelegate>("UnityEngine.GL::IssuePluginEvent");
			GL.SetRevertBackfacingDelegateField = IL2CPP.ResolveICall<GL.SetRevertBackfacingDelegate>("UnityEngine.GL::SetRevertBackfacing");
			GL.LoadIdentityDelegateField = IL2CPP.ResolveICall<GL.LoadIdentityDelegate>("UnityEngine.GL::LoadIdentity");
			GL.LoadPixelMatrixDelegateField = IL2CPP.ResolveICall<GL.LoadPixelMatrixDelegate>("UnityEngine.GL::LoadPixelMatrix");
			GL.InvalidateStateDelegateField = IL2CPP.ResolveICall<GL.InvalidateStateDelegate>("UnityEngine.GL::InvalidateState");
			GL.GLIssuePluginEventDelegateField = IL2CPP.ResolveICall<GL.GLIssuePluginEventDelegate>("UnityEngine.GL::GLIssuePluginEvent");
			GL.ClearWithSkyboxDelegateField = IL2CPP.ResolveICall<GL.ClearWithSkyboxDelegate>("UnityEngine.GL::ClearWithSkybox");
			GL.GetWorldViewMatrix_InjectedDelegateField = IL2CPP.ResolveICall<GL.GetWorldViewMatrix_InjectedDelegate>("UnityEngine.GL::GetWorldViewMatrix_Injected");
			GL.MultMatrix_InjectedDelegateField = IL2CPP.ResolveICall<GL.MultMatrix_InjectedDelegate>("UnityEngine.GL::MultMatrix_Injected");
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x000342E0 File Offset: 0x000324E0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1234161, RefRangeEnd = 1234171, XrefRangeStart = 1234159, XrefRangeEnd = 1234161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Vertex3(float x, float y, float z)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_Vertex3_Public_Static_Void_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x00034330 File Offset: 0x00032530
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1234173, RefRangeEnd = 1234175, XrefRangeStart = 1234171, XrefRangeEnd = 1234173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Vertex(Vector3 v)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_Vertex_Public_Static_Void_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x00034364 File Offset: 0x00032564
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1234177, RefRangeEnd = 1234181, XrefRangeStart = 1234175, XrefRangeEnd = 1234177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TexCoord3(float x, float y, float z)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_TexCoord3_Public_Static_Void_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x000343B4 File Offset: 0x000325B4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1234183, RefRangeEnd = 1234189, XrefRangeStart = 1234181, XrefRangeEnd = 1234183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TexCoord2(float x, float y)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_TexCoord2_Public_Static_Void_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x000343F4 File Offset: 0x000325F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234189, XrefRangeEnd = 1234191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MultiTexCoord3(int unit, float x, float y, float z)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref unit;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_MultiTexCoord3_Public_Static_Void_Int32_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x00034450 File Offset: 0x00032650
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1234193, RefRangeEnd = 1234195, XrefRangeStart = 1234191, XrefRangeEnd = 1234193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MultiTexCoord2(int unit, float x, float y)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref unit;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_MultiTexCoord2_Public_Static_Void_Int32_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x000344A0 File Offset: 0x000326A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234195, XrefRangeEnd = 1234197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ImmediateColor(float r, float g, float b, float a)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref r;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref g;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref a;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_ImmediateColor_Private_Static_Void_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x000344FC File Offset: 0x000326FC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1234199, RefRangeEnd = 1234208, XrefRangeStart = 1234197, XrefRangeEnd = 1234199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Color(Color c)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref c;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_Color_Public_Static_Void_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x00034530 File Offset: 0x00032730
		// (set) Token: 0x0600090D RID: 2317 RVA: 0x00034560 File Offset: 0x00032760
		public unsafe static bool wireframe
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1234210, RefRangeEnd = 1234212, XrefRangeStart = 1234208, XrefRangeEnd = 1234210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_get_wireframe_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1234214, RefRangeEnd = 1234219, XrefRangeStart = 1234212, XrefRangeEnd = 1234214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_set_wireframe_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000929 RID: 2345 RVA: 0x00005ECF File Offset: 0x000040CF
		// (set) Token: 0x0600090E RID: 2318 RVA: 0x00034594 File Offset: 0x00032794
		public unsafe static bool invertCulling
		{
			get
			{
				return GL.get_invertCullingDelegateField();
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234219, XrefRangeEnd = 1234221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_set_invertCulling_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x000345C8 File Offset: 0x000327C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234221, XrefRangeEnd = 1234223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetViewMatrix(Matrix4x4 m)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref m;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_SetViewMatrix_Private_Static_Void_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x0600092D RID: 2349 RVA: 0x00034AD8 File Offset: 0x00032CD8
		// (set) Token: 0x06000910 RID: 2320 RVA: 0x000345FC File Offset: 0x000327FC
		public unsafe static Matrix4x4 modelview
		{
			get
			{
				return GL.GetWorldViewMatrix();
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1234225, RefRangeEnd = 1234227, XrefRangeStart = 1234223, XrefRangeEnd = 1234225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_set_modelview_Public_Static_set_Void_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x00034630 File Offset: 0x00032830
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1234229, RefRangeEnd = 1234232, XrefRangeStart = 1234227, XrefRangeEnd = 1234229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PushMatrix()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_PushMatrix_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x00034658 File Offset: 0x00032858
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1234234, RefRangeEnd = 1234237, XrefRangeStart = 1234232, XrefRangeEnd = 1234234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PopMatrix()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_PopMatrix_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x00034680 File Offset: 0x00032880
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1234239, RefRangeEnd = 1234242, XrefRangeStart = 1234237, XrefRangeEnd = 1234239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LoadOrtho()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_LoadOrtho_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x000346A8 File Offset: 0x000328A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1234244, RefRangeEnd = 1234246, XrefRangeStart = 1234242, XrefRangeEnd = 1234244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LoadProjectionMatrix(Matrix4x4 mat)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_LoadProjectionMatrix_Public_Static_Void_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x000346DC File Offset: 0x000328DC
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 1234248, RefRangeEnd = 1234266, XrefRangeStart = 1234246, XrefRangeEnd = 1234248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 GetGPUProjectionMatrix(Matrix4x4 proj, bool renderIntoTexture)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref proj;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderIntoTexture;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_GetGPUProjectionMatrix_Public_Static_Matrix4x4_Matrix4x4_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x00034728 File Offset: 0x00032928
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1234268, RefRangeEnd = 1234270, XrefRangeStart = 1234266, XrefRangeEnd = 1234268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GLLoadPixelMatrixScript(float left, float right, float bottom, float top)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref left;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bottom;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref top;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_GLLoadPixelMatrixScript_Private_Static_Void_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x00034784 File Offset: 0x00032984
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1234268, RefRangeEnd = 1234270, XrefRangeStart = 1234268, XrefRangeEnd = 1234270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LoadPixelMatrix(float left, float right, float bottom, float top)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref left;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bottom;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref top;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_LoadPixelMatrix_Public_Static_Void_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x000347E0 File Offset: 0x000329E0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1234272, RefRangeEnd = 1234277, XrefRangeStart = 1234270, XrefRangeEnd = 1234272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Begin(int mode)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_Begin_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x00034814 File Offset: 0x00032A14
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1234279, RefRangeEnd = 1234284, XrefRangeStart = 1234277, XrefRangeEnd = 1234279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void End()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_End_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x0003483C File Offset: 0x00032A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234284, XrefRangeEnd = 1234286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GLClear(bool clearDepth, bool clearColor, Color backgroundColor, float depth)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref clearDepth;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref backgroundColor;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_GLClear_Private_Static_Void_Boolean_Boolean_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x00034898 File Offset: 0x00032A98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1234288, RefRangeEnd = 1234289, XrefRangeStart = 1234286, XrefRangeEnd = 1234288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Clear(bool clearDepth, bool clearColor, Color backgroundColor, float depth)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref clearDepth;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref backgroundColor;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_Clear_Public_Static_Void_Boolean_Boolean_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x000348F4 File Offset: 0x00032AF4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1234291, RefRangeEnd = 1234298, XrefRangeStart = 1234289, XrefRangeEnd = 1234291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Clear(bool clearDepth, bool clearColor, Color backgroundColor)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref clearDepth;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref backgroundColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_Clear_Public_Static_Void_Boolean_Boolean_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x00034944 File Offset: 0x00032B44
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1234300, RefRangeEnd = 1234303, XrefRangeStart = 1234298, XrefRangeEnd = 1234300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Viewport(Rect pixelRect)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pixelRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_Viewport_Public_Static_Void_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x00034978 File Offset: 0x00032B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234303, XrefRangeEnd = 1234305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetViewMatrix_Injected(ref Matrix4x4 m)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &m;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_SetViewMatrix_Injected_Private_Static_Void_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x000349AC File Offset: 0x00032BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234305, XrefRangeEnd = 1234307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LoadProjectionMatrix_Injected(ref Matrix4x4 mat)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &mat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_LoadProjectionMatrix_Injected_Private_Static_Void_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x000349E0 File Offset: 0x00032BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234307, XrefRangeEnd = 1234309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetGPUProjectionMatrix_Injected(ref Matrix4x4 proj, bool renderIntoTexture, out Matrix4x4 ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &proj;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderIntoTexture;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_GetGPUProjectionMatrix_Injected_Private_Static_Void_byref_Matrix4x4_Boolean_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x00034A30 File Offset: 0x00032C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234309, XrefRangeEnd = 1234311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GLClear_Injected(bool clearDepth, bool clearColor, ref Color backgroundColor, float depth)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref clearDepth;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &backgroundColor;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_GLClear_Injected_Private_Static_Void_Boolean_Boolean_byref_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x00034A8C File Offset: 0x00032C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234311, XrefRangeEnd = 1234313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Viewport_Injected(ref Rect pixelRect)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &pixelRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_Viewport_Injected_Private_Static_Void_byref_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x00005E66 File Offset: 0x00004066
		public GL(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x00005E6F File Offset: 0x0000406F
		public unsafe static void Vertices(Vector3* v, Vector3* coords, Vector4* colors, int length)
		{
			GL.VerticesDelegateField(v, coords, colors, length);
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x00005E7F File Offset: 0x0000407F
		public static void TexCoord(Vector3 v)
		{
			GL.TexCoord3(v.x, v.y, v.z);
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x00005E9A File Offset: 0x0000409A
		public static void MultiTexCoord(int unit, Vector3 v)
		{
			GL.MultiTexCoord3(unit, v.x, v.y, v.z);
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000927 RID: 2343 RVA: 0x00005EB6 File Offset: 0x000040B6
		// (set) Token: 0x06000928 RID: 2344 RVA: 0x00005EC2 File Offset: 0x000040C2
		public static bool sRGBWrite
		{
			get
			{
				return GL.get_sRGBWriteDelegateField();
			}
			set
			{
				GL.set_sRGBWriteDelegateField(value);
			}
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00005EDB File Offset: 0x000040DB
		public static void Flush()
		{
			GL.FlushDelegateField();
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x00005EE7 File Offset: 0x000040E7
		public static void RenderTargetBarrier()
		{
			GL.RenderTargetBarrierDelegateField();
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x00034AC0 File Offset: 0x00032CC0
		public static Matrix4x4 GetWorldViewMatrix()
		{
			Matrix4x4 result;
			GL.GetWorldViewMatrix_Injected(out result);
			return result;
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x00005EF3 File Offset: 0x000040F3
		public static void MultMatrix(Matrix4x4 m)
		{
			GL.MultMatrix_Injected(ref m);
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x00005EFC File Offset: 0x000040FC
		public static void IssuePluginEvent(int eventID)
		{
			GL.IssuePluginEventDelegateField(eventID);
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x00005F09 File Offset: 0x00004109
		public static void SetRevertBackfacing(bool revertBackFaces)
		{
			GL.SetRevertBackfacingDelegateField(revertBackFaces);
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x00005F16 File Offset: 0x00004116
		public static void LoadIdentity()
		{
			GL.LoadIdentityDelegateField();
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x00005F22 File Offset: 0x00004122
		public static void LoadPixelMatrix()
		{
			GL.LoadPixelMatrixDelegateField();
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x00005F2E File Offset: 0x0000412E
		public static void InvalidateState()
		{
			GL.InvalidateStateDelegateField();
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x00005F3A File Offset: 0x0000413A
		public static void GLIssuePluginEvent(IntPtr callback, int eventID)
		{
			GL.GLIssuePluginEventDelegateField(callback, eventID);
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x00034AF0 File Offset: 0x00032CF0
		public static void IssuePluginEvent(IntPtr callback, int eventID)
		{
			bool flag = callback == IntPtr.Zero;
			if (flag)
			{
				throw new ArgumentException("Null callback specified.", "callback");
			}
			GL.GLIssuePluginEvent(callback, eventID);
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x00005F48 File Offset: 0x00004148
		public static void ClearWithSkybox(bool clearDepth, Camera camera)
		{
			GL.ClearWithSkyboxDelegateField(clearDepth, IL2CPP.Il2CppObjectBaseToPtr(camera));
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x00005F5B File Offset: 0x0000415B
		public static void GetWorldViewMatrix_Injected(out Matrix4x4 ret)
		{
			GL.GetWorldViewMatrix_InjectedDelegateField(out ret);
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x00005F68 File Offset: 0x00004168
		public static void MultMatrix_Injected(ref Matrix4x4 m)
		{
			GL.MultMatrix_InjectedDelegateField(ref m);
		}

		// Token: 0x040006ED RID: 1773
		private static readonly IntPtr NativeMethodInfoPtr_Vertex3_Public_Static_Void_Single_Single_Single_0;

		// Token: 0x040006EE RID: 1774
		private static readonly IntPtr NativeMethodInfoPtr_Vertex_Public_Static_Void_Vector3_0;

		// Token: 0x040006EF RID: 1775
		private static readonly IntPtr NativeMethodInfoPtr_TexCoord3_Public_Static_Void_Single_Single_Single_0;

		// Token: 0x040006F0 RID: 1776
		private static readonly IntPtr NativeMethodInfoPtr_TexCoord2_Public_Static_Void_Single_Single_0;

		// Token: 0x040006F1 RID: 1777
		private static readonly IntPtr NativeMethodInfoPtr_MultiTexCoord3_Public_Static_Void_Int32_Single_Single_Single_0;

		// Token: 0x040006F2 RID: 1778
		private static readonly IntPtr NativeMethodInfoPtr_MultiTexCoord2_Public_Static_Void_Int32_Single_Single_0;

		// Token: 0x040006F3 RID: 1779
		private static readonly IntPtr NativeMethodInfoPtr_ImmediateColor_Private_Static_Void_Single_Single_Single_Single_0;

		// Token: 0x040006F4 RID: 1780
		private static readonly IntPtr NativeMethodInfoPtr_Color_Public_Static_Void_Color_0;

		// Token: 0x040006F5 RID: 1781
		private static readonly IntPtr NativeMethodInfoPtr_get_wireframe_Public_Static_get_Boolean_0;

		// Token: 0x040006F6 RID: 1782
		private static readonly IntPtr NativeMethodInfoPtr_set_wireframe_Public_Static_set_Void_Boolean_0;

		// Token: 0x040006F7 RID: 1783
		private static readonly IntPtr NativeMethodInfoPtr_set_invertCulling_Public_Static_set_Void_Boolean_0;

		// Token: 0x040006F8 RID: 1784
		private static readonly IntPtr NativeMethodInfoPtr_SetViewMatrix_Private_Static_Void_Matrix4x4_0;

		// Token: 0x040006F9 RID: 1785
		private static readonly IntPtr NativeMethodInfoPtr_set_modelview_Public_Static_set_Void_Matrix4x4_0;

		// Token: 0x040006FA RID: 1786
		private static readonly IntPtr NativeMethodInfoPtr_PushMatrix_Public_Static_Void_0;

		// Token: 0x040006FB RID: 1787
		private static readonly IntPtr NativeMethodInfoPtr_PopMatrix_Public_Static_Void_0;

		// Token: 0x040006FC RID: 1788
		private static readonly IntPtr NativeMethodInfoPtr_LoadOrtho_Public_Static_Void_0;

		// Token: 0x040006FD RID: 1789
		private static readonly IntPtr NativeMethodInfoPtr_LoadProjectionMatrix_Public_Static_Void_Matrix4x4_0;

		// Token: 0x040006FE RID: 1790
		private static readonly IntPtr NativeMethodInfoPtr_GetGPUProjectionMatrix_Public_Static_Matrix4x4_Matrix4x4_Boolean_0;

		// Token: 0x040006FF RID: 1791
		private static readonly IntPtr NativeMethodInfoPtr_GLLoadPixelMatrixScript_Private_Static_Void_Single_Single_Single_Single_0;

		// Token: 0x04000700 RID: 1792
		private static readonly IntPtr NativeMethodInfoPtr_LoadPixelMatrix_Public_Static_Void_Single_Single_Single_Single_0;

		// Token: 0x04000701 RID: 1793
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Static_Void_Int32_0;

		// Token: 0x04000702 RID: 1794
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Static_Void_0;

		// Token: 0x04000703 RID: 1795
		private static readonly IntPtr NativeMethodInfoPtr_GLClear_Private_Static_Void_Boolean_Boolean_Color_Single_0;

		// Token: 0x04000704 RID: 1796
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Static_Void_Boolean_Boolean_Color_Single_0;

		// Token: 0x04000705 RID: 1797
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Static_Void_Boolean_Boolean_Color_0;

		// Token: 0x04000706 RID: 1798
		private static readonly IntPtr NativeMethodInfoPtr_Viewport_Public_Static_Void_Rect_0;

		// Token: 0x04000707 RID: 1799
		private static readonly IntPtr NativeMethodInfoPtr_SetViewMatrix_Injected_Private_Static_Void_byref_Matrix4x4_0;

		// Token: 0x04000708 RID: 1800
		private static readonly IntPtr NativeMethodInfoPtr_LoadProjectionMatrix_Injected_Private_Static_Void_byref_Matrix4x4_0;

		// Token: 0x04000709 RID: 1801
		private static readonly IntPtr NativeMethodInfoPtr_GetGPUProjectionMatrix_Injected_Private_Static_Void_byref_Matrix4x4_Boolean_byref_Matrix4x4_0;

		// Token: 0x0400070A RID: 1802
		private static readonly IntPtr NativeMethodInfoPtr_GLClear_Injected_Private_Static_Void_Boolean_Boolean_byref_Color_Single_0;

		// Token: 0x0400070B RID: 1803
		private static readonly IntPtr NativeMethodInfoPtr_Viewport_Injected_Private_Static_Void_byref_Rect_0;

		// Token: 0x0400070C RID: 1804
		public const int TRIANGLES = 4;

		// Token: 0x0400070D RID: 1805
		public const int TRIANGLE_STRIP = 5;

		// Token: 0x0400070E RID: 1806
		public const int QUADS = 7;

		// Token: 0x0400070F RID: 1807
		public const int LINES = 1;

		// Token: 0x04000710 RID: 1808
		public const int LINE_STRIP = 2;

		// Token: 0x04000711 RID: 1809
		private static readonly GL.VerticesDelegate VerticesDelegateField;

		// Token: 0x04000712 RID: 1810
		private static readonly GL.get_sRGBWriteDelegate get_sRGBWriteDelegateField;

		// Token: 0x04000713 RID: 1811
		private static readonly GL.set_sRGBWriteDelegate set_sRGBWriteDelegateField;

		// Token: 0x04000714 RID: 1812
		private static readonly GL.get_invertCullingDelegate get_invertCullingDelegateField;

		// Token: 0x04000715 RID: 1813
		private static readonly GL.FlushDelegate FlushDelegateField;

		// Token: 0x04000716 RID: 1814
		private static readonly GL.RenderTargetBarrierDelegate RenderTargetBarrierDelegateField;

		// Token: 0x04000717 RID: 1815
		private static readonly GL.IssuePluginEventDelegate IssuePluginEventDelegateField;

		// Token: 0x04000718 RID: 1816
		private static readonly GL.SetRevertBackfacingDelegate SetRevertBackfacingDelegateField;

		// Token: 0x04000719 RID: 1817
		private static readonly GL.LoadIdentityDelegate LoadIdentityDelegateField;

		// Token: 0x0400071A RID: 1818
		private static readonly GL.LoadPixelMatrixDelegate LoadPixelMatrixDelegateField;

		// Token: 0x0400071B RID: 1819
		private static readonly GL.InvalidateStateDelegate InvalidateStateDelegateField;

		// Token: 0x0400071C RID: 1820
		private static readonly GL.GLIssuePluginEventDelegate GLIssuePluginEventDelegateField;

		// Token: 0x0400071D RID: 1821
		private static readonly GL.ClearWithSkyboxDelegate ClearWithSkyboxDelegateField;

		// Token: 0x0400071E RID: 1822
		private static readonly GL.GetWorldViewMatrix_InjectedDelegate GetWorldViewMatrix_InjectedDelegateField;

		// Token: 0x0400071F RID: 1823
		private static readonly GL.MultMatrix_InjectedDelegate MultMatrix_InjectedDelegateField;

		// Token: 0x0200054F RID: 1359
		// (Invoke) Token: 0x06003358 RID: 13144
		private delegate void VerticesDelegate(IntPtr v, IntPtr coords, IntPtr colors, int length);

		// Token: 0x02000550 RID: 1360
		// (Invoke) Token: 0x0600335A RID: 13146
		private delegate bool get_sRGBWriteDelegate();

		// Token: 0x02000551 RID: 1361
		// (Invoke) Token: 0x0600335C RID: 13148
		private delegate void set_sRGBWriteDelegate(bool value);

		// Token: 0x02000552 RID: 1362
		// (Invoke) Token: 0x0600335E RID: 13150
		private delegate bool get_invertCullingDelegate();

		// Token: 0x02000553 RID: 1363
		// (Invoke) Token: 0x06003360 RID: 13152
		private delegate void FlushDelegate();

		// Token: 0x02000554 RID: 1364
		// (Invoke) Token: 0x06003362 RID: 13154
		private delegate void RenderTargetBarrierDelegate();

		// Token: 0x02000555 RID: 1365
		// (Invoke) Token: 0x06003364 RID: 13156
		private delegate void IssuePluginEventDelegate(int eventID);

		// Token: 0x02000556 RID: 1366
		// (Invoke) Token: 0x06003366 RID: 13158
		private delegate void SetRevertBackfacingDelegate(bool revertBackFaces);

		// Token: 0x02000557 RID: 1367
		// (Invoke) Token: 0x06003368 RID: 13160
		private delegate void LoadIdentityDelegate();

		// Token: 0x02000558 RID: 1368
		// (Invoke) Token: 0x0600336A RID: 13162
		private delegate void LoadPixelMatrixDelegate();

		// Token: 0x02000559 RID: 1369
		// (Invoke) Token: 0x0600336C RID: 13164
		private delegate void InvalidateStateDelegate();

		// Token: 0x0200055A RID: 1370
		// (Invoke) Token: 0x0600336E RID: 13166
		private delegate void GLIssuePluginEventDelegate(IntPtr callback, int eventID);

		// Token: 0x0200055B RID: 1371
		// (Invoke) Token: 0x06003370 RID: 13168
		private delegate void ClearWithSkyboxDelegate(bool clearDepth, IntPtr camera);

		// Token: 0x0200055C RID: 1372
		// (Invoke) Token: 0x06003372 RID: 13170
		private delegate void GetWorldViewMatrix_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x0200055D RID: 1373
		// (Invoke) Token: 0x06003374 RID: 13172
		private delegate void MultMatrix_InjectedDelegate(IntPtr m);
	}
}
