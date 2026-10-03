using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200008A RID: 138
	public sealed class Gizmos : Object
	{
		// Token: 0x06000733 RID: 1843 RVA: 0x0002E71C File Offset: 0x0002C91C
		// Note: this type is marked as 'beforefieldinit'.
		static Gizmos()
		{
			Il2CppClassPointerStore<Gizmos>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Gizmos");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Gizmos>.NativeClassPtr);
			Gizmos.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664094);
			Gizmos.NativeMethodInfoPtr_DrawWireSphere_Public_Static_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664095);
			Gizmos.NativeMethodInfoPtr_DrawSphere_Public_Static_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664096);
			Gizmos.NativeMethodInfoPtr_DrawWireCube_Public_Static_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664097);
			Gizmos.NativeMethodInfoPtr_DrawCube_Public_Static_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664098);
			Gizmos.NativeMethodInfoPtr_DrawIcon_Public_Static_Void_Vector3_String_Boolean_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664099);
			Gizmos.NativeMethodInfoPtr_get_color_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664100);
			Gizmos.NativeMethodInfoPtr_set_color_Public_Static_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664101);
			Gizmos.NativeMethodInfoPtr_get_matrix_Public_Static_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664102);
			Gizmos.NativeMethodInfoPtr_set_matrix_Public_Static_set_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664103);
			Gizmos.NativeMethodInfoPtr_DrawRay_Public_Static_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664104);
			Gizmos.NativeMethodInfoPtr_DrawLine_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664105);
			Gizmos.NativeMethodInfoPtr_DrawWireSphere_Injected_Private_Static_Void_byref_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664106);
			Gizmos.NativeMethodInfoPtr_DrawSphere_Injected_Private_Static_Void_byref_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664107);
			Gizmos.NativeMethodInfoPtr_DrawWireCube_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664108);
			Gizmos.NativeMethodInfoPtr_DrawCube_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664109);
			Gizmos.NativeMethodInfoPtr_DrawIcon_Injected_Private_Static_Void_byref_Vector3_String_Boolean_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664110);
			Gizmos.NativeMethodInfoPtr_get_color_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664111);
			Gizmos.NativeMethodInfoPtr_set_color_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664112);
			Gizmos.NativeMethodInfoPtr_get_matrix_Injected_Private_Static_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664113);
			Gizmos.NativeMethodInfoPtr_set_matrix_Injected_Private_Static_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664114);
			Gizmos.DrawLineStripDelegateField = IL2CPP.ResolveICall<Gizmos.DrawLineStripDelegate>("UnityEngine.Gizmos::DrawLineStrip");
			Gizmos.DrawLineListDelegateField = IL2CPP.ResolveICall<Gizmos.DrawLineListDelegate>("UnityEngine.Gizmos::DrawLineList");
			Gizmos.get_exposureDelegateField = IL2CPP.ResolveICall<Gizmos.get_exposureDelegate>("UnityEngine.Gizmos::get_exposure");
			Gizmos.set_exposureDelegateField = IL2CPP.ResolveICall<Gizmos.set_exposureDelegate>("UnityEngine.Gizmos::set_exposure");
			Gizmos.get_probeSizeDelegateField = IL2CPP.ResolveICall<Gizmos.get_probeSizeDelegate>("UnityEngine.Gizmos::get_probeSize");
			Gizmos.DrawMesh_InjectedDelegateField = IL2CPP.ResolveICall<Gizmos.DrawMesh_InjectedDelegate>("UnityEngine.Gizmos::DrawMesh_Injected");
			Gizmos.DrawWireMesh_InjectedDelegateField = IL2CPP.ResolveICall<Gizmos.DrawWireMesh_InjectedDelegate>("UnityEngine.Gizmos::DrawWireMesh_Injected");
			Gizmos.DrawGUITexture_InjectedDelegateField = IL2CPP.ResolveICall<Gizmos.DrawGUITexture_InjectedDelegate>("UnityEngine.Gizmos::DrawGUITexture_Injected");
			Gizmos.DrawFrustum_InjectedDelegateField = IL2CPP.ResolveICall<Gizmos.DrawFrustum_InjectedDelegate>("UnityEngine.Gizmos::DrawFrustum_Injected");
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x0002E978 File Offset: 0x0002CB78
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 1233287, RefRangeEnd = 1233317, XrefRangeStart = 1233285, XrefRangeEnd = 1233287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLine(Vector3 from, Vector3 to)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref from;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x0002E9B8 File Offset: 0x0002CBB8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1233319, RefRangeEnd = 1233330, XrefRangeStart = 1233317, XrefRangeEnd = 1233319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawWireSphere(Vector3 center, float radius)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref center;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawWireSphere_Public_Static_Void_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x0002E9F8 File Offset: 0x0002CBF8
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1233332, RefRangeEnd = 1233345, XrefRangeStart = 1233330, XrefRangeEnd = 1233332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawSphere(Vector3 center, float radius)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref center;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawSphere_Public_Static_Void_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x0002EA38 File Offset: 0x0002CC38
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 1233347, RefRangeEnd = 1233367, XrefRangeStart = 1233345, XrefRangeEnd = 1233347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawWireCube(Vector3 center, Vector3 size)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref center;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawWireCube_Public_Static_Void_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x0002EA78 File Offset: 0x0002CC78
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1233369, RefRangeEnd = 1233376, XrefRangeStart = 1233367, XrefRangeEnd = 1233369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawCube(Vector3 center, Vector3 size)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref center;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawCube_Public_Static_Void_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x0002EAB8 File Offset: 0x0002CCB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1233378, RefRangeEnd = 1233380, XrefRangeStart = 1233376, XrefRangeEnd = 1233378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawIcon(Vector3 center, string name, bool allowScaling, Color tint)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref center;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowScaling;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawIcon_Public_Static_Void_Vector3_String_Boolean_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600073A RID: 1850 RVA: 0x0002EB18 File Offset: 0x0002CD18
		// (set) Token: 0x0600073B RID: 1851 RVA: 0x0002EB48 File Offset: 0x0002CD48
		public unsafe static Color color
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1233382, RefRangeEnd = 1233384, XrefRangeStart = 1233380, XrefRangeEnd = 1233382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_get_color_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(71)]
			[CachedScanResults(RefRangeStart = 1233386, RefRangeEnd = 1233457, XrefRangeStart = 1233384, XrefRangeEnd = 1233386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_set_color_Public_Static_set_Void_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x0600073C RID: 1852 RVA: 0x0002EB7C File Offset: 0x0002CD7C
		// (set) Token: 0x0600073D RID: 1853 RVA: 0x0002EBAC File Offset: 0x0002CDAC
		public unsafe static Matrix4x4 matrix
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1233459, RefRangeEnd = 1233461, XrefRangeStart = 1233457, XrefRangeEnd = 1233459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_get_matrix_Public_Static_get_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1233463, RefRangeEnd = 1233470, XrefRangeStart = 1233461, XrefRangeEnd = 1233463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_set_matrix_Public_Static_set_Void_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x0002EBE0 File Offset: 0x0002CDE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1233472, RefRangeEnd = 1233473, XrefRangeStart = 1233470, XrefRangeEnd = 1233472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawRay(Vector3 from, Vector3 direction)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref from;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawRay_Public_Static_Void_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x0002EC20 File Offset: 0x0002CE20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233473, XrefRangeEnd = 1233475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLine_Injected(ref Vector3 from, ref Vector3 to)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &from;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &to;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawLine_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x0002EC60 File Offset: 0x0002CE60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233475, XrefRangeEnd = 1233477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawWireSphere_Injected(ref Vector3 center, float radius)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &center;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawWireSphere_Injected_Private_Static_Void_byref_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x0002ECA0 File Offset: 0x0002CEA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233477, XrefRangeEnd = 1233479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawSphere_Injected(ref Vector3 center, float radius)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &center;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawSphere_Injected_Private_Static_Void_byref_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x0002ECE0 File Offset: 0x0002CEE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233479, XrefRangeEnd = 1233481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawWireCube_Injected(ref Vector3 center, ref Vector3 size)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &center;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawWireCube_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x0002ED20 File Offset: 0x0002CF20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233481, XrefRangeEnd = 1233483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawCube_Injected(ref Vector3 center, ref Vector3 size)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &center;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawCube_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x0002ED60 File Offset: 0x0002CF60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233483, XrefRangeEnd = 1233485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawIcon_Injected(ref Vector3 center, string name, bool allowScaling, ref Color tint)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &center;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowScaling;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &tint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawIcon_Injected_Private_Static_Void_byref_Vector3_String_Boolean_byref_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x0002EDC0 File Offset: 0x0002CFC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233485, XrefRangeEnd = 1233487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_color_Injected(out Color ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_get_color_Injected_Private_Static_Void_byref_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x0002EDF4 File Offset: 0x0002CFF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233487, XrefRangeEnd = 1233489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void set_color_Injected(ref Color value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_set_color_Injected_Private_Static_Void_byref_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x0002EE28 File Offset: 0x0002D028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233489, XrefRangeEnd = 1233491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_matrix_Injected(out Matrix4x4 ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_get_matrix_Injected_Private_Static_Void_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x0002EE5C File Offset: 0x0002D05C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233491, XrefRangeEnd = 1233493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void set_matrix_Injected(ref Matrix4x4 value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_set_matrix_Injected_Private_Static_Void_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x00005285 File Offset: 0x00003485
		public Gizmos(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x0000528E File Offset: 0x0000348E
		public unsafe static void DrawLineStrip(Vector3* points, int count, bool looped)
		{
			Gizmos.DrawLineStripDelegateField(points, count, looped);
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x0002EE90 File Offset: 0x0002D090
		public unsafe static void DrawLineStrip(ReadOnlySpan<Vector3> points, bool looped)
		{
			fixed (Vector3* pinnableReference = points.GetPinnableReference())
			{
				Vector3* points2 = pinnableReference;
				Gizmos.DrawLineStrip(points2, points.Length, looped);
			}
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x0000529D File Offset: 0x0000349D
		public unsafe static void DrawLineList(Vector3* points, int count)
		{
			Gizmos.DrawLineListDelegateField(points, count);
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x0002EEC0 File Offset: 0x0002D0C0
		public unsafe static void DrawLineList(ReadOnlySpan<Vector3> points)
		{
			bool flag = (points.Length & 1) != 0;
			if (flag)
			{
				throw new UnityException("You cannot draw a line list from an odd number of points, with two points per line the number of points must be even");
			}
			fixed (Vector3* pinnableReference = points.GetPinnableReference())
			{
				Vector3* points2 = pinnableReference;
				Gizmos.DrawLineList(points2, points.Length);
			}
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x000052AB File Offset: 0x000034AB
		public static void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation, Vector3 scale)
		{
			Gizmos.DrawMesh_Injected(mesh, submeshIndex, ref position, ref rotation, ref scale);
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x000052BA File Offset: 0x000034BA
		public static void DrawWireMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation, Vector3 scale)
		{
			Gizmos.DrawWireMesh_Injected(mesh, submeshIndex, ref position, ref rotation, ref scale);
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x000052C9 File Offset: 0x000034C9
		public static void DrawIcon(Vector3 center, string name, bool allowScaling)
		{
			Gizmos.DrawIcon(center, name, allowScaling, Color.white);
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x000052DA File Offset: 0x000034DA
		public static void DrawGUITexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat)
		{
			Gizmos.DrawGUITexture_Injected(ref screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder, mat);
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000752 RID: 1874 RVA: 0x0002EF08 File Offset: 0x0002D108
		// (set) Token: 0x06000753 RID: 1875 RVA: 0x000052EC File Offset: 0x000034EC
		public static Texture exposure
		{
			get
			{
				IntPtr intPtr = Gizmos.get_exposureDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				Gizmos.set_exposureDelegateField(IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000754 RID: 1876 RVA: 0x000052FE File Offset: 0x000034FE
		public static float probeSize
		{
			get
			{
				return Gizmos.get_probeSizeDelegateField();
			}
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x0000530A File Offset: 0x0000350A
		public static void DrawFrustum(Vector3 center, float fov, float maxRange, float minRange, float aspect)
		{
			Gizmos.DrawFrustum_Injected(ref center, fov, maxRange, minRange, aspect);
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x00005318 File Offset: 0x00003518
		public static void DrawRay(Ray r)
		{
			Gizmos.DrawLine(r.origin, r.origin + r.direction);
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x0002EF30 File Offset: 0x0002D130
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation)
		{
			Vector3 one = Vector3.one;
			Gizmos.DrawMesh(mesh, position, rotation, one);
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x0002EF50 File Offset: 0x0002D150
		public static void DrawMesh(Mesh mesh, Vector3 position)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Gizmos.DrawMesh(mesh, position, identity, one);
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x0002EF74 File Offset: 0x0002D174
		public static void DrawMesh(Mesh mesh)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Vector3 zero = Vector3.zero;
			Gizmos.DrawMesh(mesh, zero, identity, one);
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x0000533B File Offset: 0x0000353B
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Vector3 scale)
		{
			Gizmos.DrawMesh(mesh, -1, position, rotation, scale);
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x0002EFA0 File Offset: 0x0002D1A0
		public static void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation)
		{
			Vector3 one = Vector3.one;
			Gizmos.DrawMesh(mesh, submeshIndex, position, rotation, one);
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x0002EFC0 File Offset: 0x0002D1C0
		public static void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Gizmos.DrawMesh(mesh, submeshIndex, position, identity, one);
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x0002EFE8 File Offset: 0x0002D1E8
		public static void DrawMesh(Mesh mesh, int submeshIndex)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Vector3 zero = Vector3.zero;
			Gizmos.DrawMesh(mesh, submeshIndex, zero, identity, one);
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x0002F014 File Offset: 0x0002D214
		public static void DrawWireMesh(Mesh mesh, Vector3 position, Quaternion rotation)
		{
			Vector3 one = Vector3.one;
			Gizmos.DrawWireMesh(mesh, position, rotation, one);
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x0002F034 File Offset: 0x0002D234
		public static void DrawWireMesh(Mesh mesh, Vector3 position)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Gizmos.DrawWireMesh(mesh, position, identity, one);
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x0002F058 File Offset: 0x0002D258
		public static void DrawWireMesh(Mesh mesh)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Vector3 zero = Vector3.zero;
			Gizmos.DrawWireMesh(mesh, zero, identity, one);
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x00005349 File Offset: 0x00003549
		public static void DrawWireMesh(Mesh mesh, Vector3 position, Quaternion rotation, Vector3 scale)
		{
			Gizmos.DrawWireMesh(mesh, -1, position, rotation, scale);
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x0002F084 File Offset: 0x0002D284
		public static void DrawWireMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation)
		{
			Vector3 one = Vector3.one;
			Gizmos.DrawWireMesh(mesh, submeshIndex, position, rotation, one);
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x0002F0A4 File Offset: 0x0002D2A4
		public static void DrawWireMesh(Mesh mesh, int submeshIndex, Vector3 position)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Gizmos.DrawWireMesh(mesh, submeshIndex, position, identity, one);
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x0002F0CC File Offset: 0x0002D2CC
		public static void DrawWireMesh(Mesh mesh, int submeshIndex)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Vector3 zero = Vector3.zero;
			Gizmos.DrawWireMesh(mesh, submeshIndex, zero, identity, one);
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x0002F0F8 File Offset: 0x0002D2F8
		public static void DrawIcon(Vector3 center, string name)
		{
			bool allowScaling = true;
			Gizmos.DrawIcon(center, name, allowScaling);
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x0002F114 File Offset: 0x0002D314
		public static void DrawGUITexture(Rect screenRect, Texture texture)
		{
			Material mat = null;
			Gizmos.DrawGUITexture(screenRect, texture, mat);
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x00005357 File Offset: 0x00003557
		public static void DrawGUITexture(Rect screenRect, Texture texture, Material mat)
		{
			Gizmos.DrawGUITexture(screenRect, texture, 0, 0, 0, 0, mat);
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x0002F130 File Offset: 0x0002D330
		public static void DrawGUITexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder)
		{
			Material mat = null;
			Gizmos.DrawGUITexture(screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder, mat);
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x00005367 File Offset: 0x00003567
		public static void DrawMesh_Injected(Mesh mesh, int submeshIndex, ref Vector3 position, ref Quaternion rotation, ref Vector3 scale)
		{
			Gizmos.DrawMesh_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mesh), submeshIndex, ref position, ref rotation, ref scale);
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x0000537E File Offset: 0x0000357E
		public static void DrawWireMesh_Injected(Mesh mesh, int submeshIndex, ref Vector3 position, ref Quaternion rotation, ref Vector3 scale)
		{
			Gizmos.DrawWireMesh_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mesh), submeshIndex, ref position, ref rotation, ref scale);
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x00005395 File Offset: 0x00003595
		public static void DrawGUITexture_Injected(ref Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat)
		{
			Gizmos.DrawGUITexture_InjectedDelegateField(ref screenRect, IL2CPP.Il2CppObjectBaseToPtr(texture), leftBorder, rightBorder, topBorder, bottomBorder, IL2CPP.Il2CppObjectBaseToPtr(mat));
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x000053B5 File Offset: 0x000035B5
		public static void DrawFrustum_Injected(ref Vector3 center, float fov, float maxRange, float minRange, float aspect)
		{
			Gizmos.DrawFrustum_InjectedDelegateField(ref center, fov, maxRange, minRange, aspect);
		}

		// Token: 0x040005F8 RID: 1528
		private static readonly IntPtr NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_0;

		// Token: 0x040005F9 RID: 1529
		private static readonly IntPtr NativeMethodInfoPtr_DrawWireSphere_Public_Static_Void_Vector3_Single_0;

		// Token: 0x040005FA RID: 1530
		private static readonly IntPtr NativeMethodInfoPtr_DrawSphere_Public_Static_Void_Vector3_Single_0;

		// Token: 0x040005FB RID: 1531
		private static readonly IntPtr NativeMethodInfoPtr_DrawWireCube_Public_Static_Void_Vector3_Vector3_0;

		// Token: 0x040005FC RID: 1532
		private static readonly IntPtr NativeMethodInfoPtr_DrawCube_Public_Static_Void_Vector3_Vector3_0;

		// Token: 0x040005FD RID: 1533
		private static readonly IntPtr NativeMethodInfoPtr_DrawIcon_Public_Static_Void_Vector3_String_Boolean_Color_0;

		// Token: 0x040005FE RID: 1534
		private static readonly IntPtr NativeMethodInfoPtr_get_color_Public_Static_get_Color_0;

		// Token: 0x040005FF RID: 1535
		private static readonly IntPtr NativeMethodInfoPtr_set_color_Public_Static_set_Void_Color_0;

		// Token: 0x04000600 RID: 1536
		private static readonly IntPtr NativeMethodInfoPtr_get_matrix_Public_Static_get_Matrix4x4_0;

		// Token: 0x04000601 RID: 1537
		private static readonly IntPtr NativeMethodInfoPtr_set_matrix_Public_Static_set_Void_Matrix4x4_0;

		// Token: 0x04000602 RID: 1538
		private static readonly IntPtr NativeMethodInfoPtr_DrawRay_Public_Static_Void_Vector3_Vector3_0;

		// Token: 0x04000603 RID: 1539
		private static readonly IntPtr NativeMethodInfoPtr_DrawLine_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_0;

		// Token: 0x04000604 RID: 1540
		private static readonly IntPtr NativeMethodInfoPtr_DrawWireSphere_Injected_Private_Static_Void_byref_Vector3_Single_0;

		// Token: 0x04000605 RID: 1541
		private static readonly IntPtr NativeMethodInfoPtr_DrawSphere_Injected_Private_Static_Void_byref_Vector3_Single_0;

		// Token: 0x04000606 RID: 1542
		private static readonly IntPtr NativeMethodInfoPtr_DrawWireCube_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_0;

		// Token: 0x04000607 RID: 1543
		private static readonly IntPtr NativeMethodInfoPtr_DrawCube_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_0;

		// Token: 0x04000608 RID: 1544
		private static readonly IntPtr NativeMethodInfoPtr_DrawIcon_Injected_Private_Static_Void_byref_Vector3_String_Boolean_byref_Color_0;

		// Token: 0x04000609 RID: 1545
		private static readonly IntPtr NativeMethodInfoPtr_get_color_Injected_Private_Static_Void_byref_Color_0;

		// Token: 0x0400060A RID: 1546
		private static readonly IntPtr NativeMethodInfoPtr_set_color_Injected_Private_Static_Void_byref_Color_0;

		// Token: 0x0400060B RID: 1547
		private static readonly IntPtr NativeMethodInfoPtr_get_matrix_Injected_Private_Static_Void_byref_Matrix4x4_0;

		// Token: 0x0400060C RID: 1548
		private static readonly IntPtr NativeMethodInfoPtr_set_matrix_Injected_Private_Static_Void_byref_Matrix4x4_0;

		// Token: 0x0400060D RID: 1549
		private static readonly Gizmos.DrawLineStripDelegate DrawLineStripDelegateField;

		// Token: 0x0400060E RID: 1550
		private static readonly Gizmos.DrawLineListDelegate DrawLineListDelegateField;

		// Token: 0x0400060F RID: 1551
		private static readonly Gizmos.get_exposureDelegate get_exposureDelegateField;

		// Token: 0x04000610 RID: 1552
		private static readonly Gizmos.set_exposureDelegate set_exposureDelegateField;

		// Token: 0x04000611 RID: 1553
		private static readonly Gizmos.get_probeSizeDelegate get_probeSizeDelegateField;

		// Token: 0x04000612 RID: 1554
		private static readonly Gizmos.DrawMesh_InjectedDelegate DrawMesh_InjectedDelegateField;

		// Token: 0x04000613 RID: 1555
		private static readonly Gizmos.DrawWireMesh_InjectedDelegate DrawWireMesh_InjectedDelegateField;

		// Token: 0x04000614 RID: 1556
		private static readonly Gizmos.DrawGUITexture_InjectedDelegate DrawGUITexture_InjectedDelegateField;

		// Token: 0x04000615 RID: 1557
		private static readonly Gizmos.DrawFrustum_InjectedDelegate DrawFrustum_InjectedDelegateField;

		// Token: 0x020004EC RID: 1260
		// (Invoke) Token: 0x06003288 RID: 12936
		private delegate void DrawLineStripDelegate(IntPtr points, int count, bool looped);

		// Token: 0x020004ED RID: 1261
		// (Invoke) Token: 0x0600328A RID: 12938
		private delegate void DrawLineListDelegate(IntPtr points, int count);

		// Token: 0x020004EE RID: 1262
		// (Invoke) Token: 0x0600328C RID: 12940
		private delegate IntPtr get_exposureDelegate();

		// Token: 0x020004EF RID: 1263
		// (Invoke) Token: 0x0600328E RID: 12942
		private delegate void set_exposureDelegate(IntPtr value);

		// Token: 0x020004F0 RID: 1264
		// (Invoke) Token: 0x06003290 RID: 12944
		private delegate float get_probeSizeDelegate();

		// Token: 0x020004F1 RID: 1265
		// (Invoke) Token: 0x06003292 RID: 12946
		private delegate void DrawMesh_InjectedDelegate(IntPtr mesh, int submeshIndex, IntPtr position, IntPtr rotation, IntPtr scale);

		// Token: 0x020004F2 RID: 1266
		// (Invoke) Token: 0x06003294 RID: 12948
		private delegate void DrawWireMesh_InjectedDelegate(IntPtr mesh, int submeshIndex, IntPtr position, IntPtr rotation, IntPtr scale);

		// Token: 0x020004F3 RID: 1267
		// (Invoke) Token: 0x06003296 RID: 12950
		private delegate void DrawGUITexture_InjectedDelegate(IntPtr screenRect, IntPtr texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, IntPtr mat);

		// Token: 0x020004F4 RID: 1268
		// (Invoke) Token: 0x06003298 RID: 12952
		private delegate void DrawFrustum_InjectedDelegate(IntPtr center, float fov, float maxRange, float minRange, float aspect);
	}
}
