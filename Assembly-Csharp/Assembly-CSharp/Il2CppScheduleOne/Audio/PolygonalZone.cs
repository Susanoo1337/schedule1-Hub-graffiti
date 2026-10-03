using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x02000487 RID: 1159
	public class PolygonalZone : MonoBehaviour
	{
		// Token: 0x06006846 RID: 26694 RVA: 0x001E3934 File Offset: 0x001E1B34
		// Note: this type is marked as 'beforefieldinit'.
		static PolygonalZone()
		{
			Il2CppClassPointerStore<PolygonalZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "PolygonalZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PolygonalZone>.NativeClassPtr);
			PolygonalZone.NativeFieldInfoPtr_PointContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonalZone>.NativeClassPtr, "PointContainer");
			PolygonalZone.NativeFieldInfoPtr_IsClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonalZone>.NativeClassPtr, "IsClosed");
			PolygonalZone.NativeFieldInfoPtr_VerticalSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonalZone>.NativeClassPtr, "VerticalSize");
			PolygonalZone.NativeFieldInfoPtr_ZoneColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonalZone>.NativeClassPtr, "ZoneColor");
			PolygonalZone.NativeFieldInfoPtr_points = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonalZone>.NativeClassPtr, "points");
			PolygonalZone.NativeFieldInfoPtr_bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonalZone>.NativeClassPtr, "bounds");
			PolygonalZone.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonalZone>.NativeClassPtr, 100676927);
			PolygonalZone.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonalZone>.NativeClassPtr, 100676928);
			PolygonalZone.NativeMethodInfoPtr_IsPointInsidePolygon_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonalZone>.NativeClassPtr, 100676929);
			PolygonalZone.NativeMethodInfoPtr_IsPointInsideZone_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonalZone>.NativeClassPtr, 100676930);
			PolygonalZone.NativeMethodInfoPtr_GetDistanceToClosestPointOnZone_Public_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonalZone>.NativeClassPtr, 100676931);
			PolygonalZone.NativeMethodInfoPtr_GetPoints_Protected_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonalZone>.NativeClassPtr, 100676932);
			PolygonalZone.NativeMethodInfoPtr_DoBoundsContainPoint_Protected_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonalZone>.NativeClassPtr, 100676933);
			PolygonalZone.NativeMethodInfoPtr_GetBoundingPoints_Protected_Tuple_2_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonalZone>.NativeClassPtr, 100676934);
			PolygonalZone.NativeMethodInfoPtr_CalculateWindingNumber_Protected_Int32_Il2CppStructArray_1_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonalZone>.NativeClassPtr, 100676935);
			PolygonalZone.NativeMethodInfoPtr_GetClosestPointOnPolygon_Protected_Vector3_Il2CppStructArray_1_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonalZone>.NativeClassPtr, 100676936);
			PolygonalZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonalZone>.NativeClassPtr, 100676937);
			PolygonalZone.NativeMethodInfoPtr_Method_Internal_Static_Boolean_Vector2_Vector2_Vector2_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonalZone>.NativeClassPtr, 100676938);
			PolygonalZone.NativeMethodInfoPtr_Method_Internal_Static_Single_Vector2_Vector2_Vector2_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonalZone>.NativeClassPtr, 100676939);
			PolygonalZone.NativeMethodInfoPtr_Method_Internal_Static_Single_Vector2_Vector2_Vector2_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonalZone>.NativeClassPtr, 100676940);
			PolygonalZone.NativeMethodInfoPtr_Method_Internal_Static_Int32_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonalZone>.NativeClassPtr, 100676941);
			PolygonalZone.NativeMethodInfoPtr_Method_Internal_Static_Vector3_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonalZone>.NativeClassPtr, 100676942);
		}

		// Token: 0x06006847 RID: 26695 RVA: 0x001E3B1C File Offset: 0x001E1D1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216003, RefRangeEnd = 216004, XrefRangeStart = 215926, XrefRangeEnd = 216003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PolygonalZone.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006848 RID: 26696 RVA: 0x001E3B58 File Offset: 0x001E1D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216004, XrefRangeEnd = 216032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonalZone.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006849 RID: 26697 RVA: 0x001E3B8C File Offset: 0x001E1D8C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 216039, RefRangeEnd = 216044, XrefRangeStart = 216032, XrefRangeEnd = 216039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPointInsidePolygon(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonalZone.NativeMethodInfoPtr_IsPointInsidePolygon_Public_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600684A RID: 26698 RVA: 0x001E3BD8 File Offset: 0x001E1DD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216044, XrefRangeEnd = 216049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPointInsideZone(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonalZone.NativeMethodInfoPtr_IsPointInsideZone_Public_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600684B RID: 26699 RVA: 0x001E3C24 File Offset: 0x001E1E24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216050, RefRangeEnd = 216051, XrefRangeStart = 216049, XrefRangeEnd = 216050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetDistanceToClosestPointOnZone(Vector3 source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref source;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonalZone.NativeMethodInfoPtr_GetDistanceToClosestPointOnZone_Public_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600684C RID: 26700 RVA: 0x001E3C70 File Offset: 0x001E1E70
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 216063, RefRangeEnd = 216067, XrefRangeStart = 216051, XrefRangeEnd = 216063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<Vector3> GetPoints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonalZone.NativeMethodInfoPtr_GetPoints_Protected_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
		}

		// Token: 0x0600684D RID: 26701 RVA: 0x001E3CB0 File Offset: 0x001E1EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216067, XrefRangeEnd = 216069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoBoundsContainPoint(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonalZone.NativeMethodInfoPtr_DoBoundsContainPoint_Protected_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600684E RID: 26702 RVA: 0x001E3CFC File Offset: 0x001E1EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216069, XrefRangeEnd = 216143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Tuple<Vector3, Vector3> GetBoundingPoints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonalZone.NativeMethodInfoPtr_GetBoundingPoints_Protected_Tuple_2_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tuple<Vector3, Vector3>>(intPtr3) : null;
		}

		// Token: 0x0600684F RID: 26703 RVA: 0x001E3D3C File Offset: 0x001E1F3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216147, RefRangeEnd = 216148, XrefRangeStart = 216143, XrefRangeEnd = 216147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CalculateWindingNumber(Il2CppStructArray<Vector2> polygon, Vector2 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(polygon);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonalZone.NativeMethodInfoPtr_CalculateWindingNumber_Protected_Int32_Il2CppStructArray_1_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006850 RID: 26704 RVA: 0x001E3D98 File Offset: 0x001E1F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216148, XrefRangeEnd = 216153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetClosestPointOnPolygon(Il2CppStructArray<Vector3> polyPoints, Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(polyPoints);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonalZone.NativeMethodInfoPtr_GetClosestPointOnPolygon_Protected_Vector3_Il2CppStructArray_1_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006851 RID: 26705 RVA: 0x001E3DF4 File Offset: 0x001E1FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216153, XrefRangeEnd = 216154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PolygonalZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PolygonalZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonalZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006852 RID: 26706 RVA: 0x001E3E30 File Offset: 0x001E2030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216154, XrefRangeEnd = 216155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Method_Internal_Static_Boolean_Vector2_Vector2_Vector2_PDM_0(Vector2 start, Vector2 end, Vector2 point)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonalZone.NativeMethodInfoPtr_Method_Internal_Static_Boolean_Vector2_Vector2_Vector2_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006853 RID: 26707 RVA: 0x001E3E8C File Offset: 0x001E208C
		[CallerCount(0)]
		public unsafe static float Method_Internal_Static_Single_Vector2_Vector2_Vector2_PDM_0(Vector2 start, Vector2 end, Vector2 point)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonalZone.NativeMethodInfoPtr_Method_Internal_Static_Single_Vector2_Vector2_Vector2_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006854 RID: 26708 RVA: 0x001E3EE8 File Offset: 0x001E20E8
		[CallerCount(0)]
		public unsafe static float Method_Internal_Static_Single_Vector2_Vector2_Vector2_PDM_1(Vector2 start, Vector2 end, Vector2 point)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonalZone.NativeMethodInfoPtr_Method_Internal_Static_Single_Vector2_Vector2_Vector2_PDM_1, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006855 RID: 26709 RVA: 0x001E3F44 File Offset: 0x001E2144
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 216155, RefRangeEnd = 216157, XrefRangeStart = 216155, XrefRangeEnd = 216155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Method_Internal_Static_Int32_Vector2_Vector2_Vector2_0(Vector2 start, Vector2 end, Vector2 point)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonalZone.NativeMethodInfoPtr_Method_Internal_Static_Int32_Vector2_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006856 RID: 26710 RVA: 0x001E3FA0 File Offset: 0x001E21A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 216167, RefRangeEnd = 216169, XrefRangeStart = 216157, XrefRangeEnd = 216167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 Method_Internal_Static_Vector3_Vector3_Vector3_Vector3_0(Vector3 lineStart, Vector3 lineEnd, Vector3 point)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lineStart;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineEnd;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonalZone.NativeMethodInfoPtr_Method_Internal_Static_Vector3_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006857 RID: 26711 RVA: 0x0003122C File Offset: 0x0002F42C
		public PolygonalZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FE7 RID: 8167
		// (get) Token: 0x06006858 RID: 26712 RVA: 0x001E3FFC File Offset: 0x001E21FC
		// (set) Token: 0x06006859 RID: 26713 RVA: 0x00031235 File Offset: 0x0002F435
		public unsafe Transform PointContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolygonalZone.NativeFieldInfoPtr_PointContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolygonalZone.NativeFieldInfoPtr_PointContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FE8 RID: 8168
		// (get) Token: 0x0600685A RID: 26714 RVA: 0x001E402C File Offset: 0x001E222C
		// (set) Token: 0x0600685B RID: 26715 RVA: 0x00031254 File Offset: 0x0002F454
		public unsafe bool IsClosed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolygonalZone.NativeFieldInfoPtr_IsClosed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolygonalZone.NativeFieldInfoPtr_IsClosed)) = value;
			}
		}

		// Token: 0x17001FE9 RID: 8169
		// (get) Token: 0x0600685C RID: 26716 RVA: 0x001E4054 File Offset: 0x001E2254
		// (set) Token: 0x0600685D RID: 26717 RVA: 0x0003126F File Offset: 0x0002F46F
		public unsafe float VerticalSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolygonalZone.NativeFieldInfoPtr_VerticalSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolygonalZone.NativeFieldInfoPtr_VerticalSize)) = value;
			}
		}

		// Token: 0x17001FEA RID: 8170
		// (get) Token: 0x0600685E RID: 26718 RVA: 0x001E407C File Offset: 0x001E227C
		// (set) Token: 0x0600685F RID: 26719 RVA: 0x0003128A File Offset: 0x0002F48A
		public unsafe Color ZoneColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolygonalZone.NativeFieldInfoPtr_ZoneColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolygonalZone.NativeFieldInfoPtr_ZoneColor)) = value;
			}
		}

		// Token: 0x17001FEB RID: 8171
		// (get) Token: 0x06006860 RID: 26720 RVA: 0x001E40A4 File Offset: 0x001E22A4
		// (set) Token: 0x06006861 RID: 26721 RVA: 0x000312A5 File Offset: 0x0002F4A5
		public unsafe Il2CppStructArray<Vector3> points
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolygonalZone.NativeFieldInfoPtr_points);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolygonalZone.NativeFieldInfoPtr_points), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FEC RID: 8172
		// (get) Token: 0x06006862 RID: 26722 RVA: 0x001E40D4 File Offset: 0x001E22D4
		// (set) Token: 0x06006863 RID: 26723 RVA: 0x000312C4 File Offset: 0x0002F4C4
		public unsafe Tuple<Vector3, Vector3> bounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolygonalZone.NativeFieldInfoPtr_bounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tuple<Vector3, Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolygonalZone.NativeFieldInfoPtr_bounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040047B1 RID: 18353
		private static readonly IntPtr NativeFieldInfoPtr_PointContainer;

		// Token: 0x040047B2 RID: 18354
		private static readonly IntPtr NativeFieldInfoPtr_IsClosed;

		// Token: 0x040047B3 RID: 18355
		private static readonly IntPtr NativeFieldInfoPtr_VerticalSize;

		// Token: 0x040047B4 RID: 18356
		private static readonly IntPtr NativeFieldInfoPtr_ZoneColor;

		// Token: 0x040047B5 RID: 18357
		private static readonly IntPtr NativeFieldInfoPtr_points;

		// Token: 0x040047B6 RID: 18358
		private static readonly IntPtr NativeFieldInfoPtr_bounds;

		// Token: 0x040047B7 RID: 18359
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040047B8 RID: 18360
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x040047B9 RID: 18361
		private static readonly IntPtr NativeMethodInfoPtr_IsPointInsidePolygon_Public_Boolean_Vector3_0;

		// Token: 0x040047BA RID: 18362
		private static readonly IntPtr NativeMethodInfoPtr_IsPointInsideZone_Public_Boolean_Vector3_0;

		// Token: 0x040047BB RID: 18363
		private static readonly IntPtr NativeMethodInfoPtr_GetDistanceToClosestPointOnZone_Public_Single_Vector3_0;

		// Token: 0x040047BC RID: 18364
		private static readonly IntPtr NativeMethodInfoPtr_GetPoints_Protected_Il2CppStructArray_1_Vector3_0;

		// Token: 0x040047BD RID: 18365
		private static readonly IntPtr NativeMethodInfoPtr_DoBoundsContainPoint_Protected_Boolean_Vector3_0;

		// Token: 0x040047BE RID: 18366
		private static readonly IntPtr NativeMethodInfoPtr_GetBoundingPoints_Protected_Tuple_2_Vector3_Vector3_0;

		// Token: 0x040047BF RID: 18367
		private static readonly IntPtr NativeMethodInfoPtr_CalculateWindingNumber_Protected_Int32_Il2CppStructArray_1_Vector2_Vector2_0;

		// Token: 0x040047C0 RID: 18368
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestPointOnPolygon_Protected_Vector3_Il2CppStructArray_1_Vector3_Vector3_0;

		// Token: 0x040047C1 RID: 18369
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040047C2 RID: 18370
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Boolean_Vector2_Vector2_Vector2_PDM_0;

		// Token: 0x040047C3 RID: 18371
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Single_Vector2_Vector2_Vector2_PDM_0;

		// Token: 0x040047C4 RID: 18372
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Single_Vector2_Vector2_Vector2_PDM_1;

		// Token: 0x040047C5 RID: 18373
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Int32_Vector2_Vector2_Vector2_0;

		// Token: 0x040047C6 RID: 18374
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Vector3_Vector3_Vector3_Vector3_0;

		// Token: 0x02000B53 RID: 2899
		[ObfuscatedName("ScheduleOne.Audio.PolygonalZone+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E79D RID: 59293 RVA: 0x003872A0 File Offset: 0x003854A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PolygonalZone.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PolygonalZone>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PolygonalZone.__c>.NativeClassPtr);
				PolygonalZone.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonalZone.__c>.NativeClassPtr, "<>9");
				PolygonalZone.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonalZone.__c>.NativeClassPtr, "<>9__6_0");
				PolygonalZone.__c.NativeFieldInfoPtr___9__6_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonalZone.__c>.NativeClassPtr, "<>9__6_1");
				PolygonalZone.__c.NativeFieldInfoPtr___9__6_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonalZone.__c>.NativeClassPtr, "<>9__6_2");
				PolygonalZone.__c.NativeFieldInfoPtr___9__6_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonalZone.__c>.NativeClassPtr, "<>9__6_3");
				PolygonalZone.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonalZone.__c>.NativeClassPtr, "<>9__13_0");
				PolygonalZone.__c.NativeFieldInfoPtr___9__13_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonalZone.__c>.NativeClassPtr, "<>9__13_1");
				PolygonalZone.__c.NativeFieldInfoPtr___9__13_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonalZone.__c>.NativeClassPtr, "<>9__13_2");
				PolygonalZone.__c.NativeFieldInfoPtr___9__13_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonalZone.__c>.NativeClassPtr, "<>9__13_3");
				PolygonalZone.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonalZone.__c>.NativeClassPtr, 100676944);
				PolygonalZone.__c.NativeMethodInfoPtr__Awake_b__6_0_Internal_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonalZone.__c>.NativeClassPtr, 100676945);
				PolygonalZone.__c.NativeMethodInfoPtr__Awake_b__6_1_Internal_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonalZone.__c>.NativeClassPtr, 100676946);
				PolygonalZone.__c.NativeMethodInfoPtr__Awake_b__6_2_Internal_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonalZone.__c>.NativeClassPtr, 100676947);
				PolygonalZone.__c.NativeMethodInfoPtr__Awake_b__6_3_Internal_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonalZone.__c>.NativeClassPtr, 100676948);
				PolygonalZone.__c.NativeMethodInfoPtr__GetBoundingPoints_b__13_0_Internal_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonalZone.__c>.NativeClassPtr, 100676949);
				PolygonalZone.__c.NativeMethodInfoPtr__GetBoundingPoints_b__13_1_Internal_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonalZone.__c>.NativeClassPtr, 100676950);
				PolygonalZone.__c.NativeMethodInfoPtr__GetBoundingPoints_b__13_2_Internal_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonalZone.__c>.NativeClassPtr, 100676951);
				PolygonalZone.__c.NativeMethodInfoPtr__GetBoundingPoints_b__13_3_Internal_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonalZone.__c>.NativeClassPtr, 100676952);
			}

			// Token: 0x0600E79E RID: 59294 RVA: 0x00387434 File Offset: 0x00385634
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PolygonalZone.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonalZone.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E79F RID: 59295 RVA: 0x00387470 File Offset: 0x00385670
			[CallerCount(0)]
			public unsafe float _Awake_b__6_0(Vector3 p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonalZone.__c.NativeMethodInfoPtr__Awake_b__6_0_Internal_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E7A0 RID: 59296 RVA: 0x003874BC File Offset: 0x003856BC
			[CallerCount(0)]
			public unsafe float _Awake_b__6_1(Vector3 p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonalZone.__c.NativeMethodInfoPtr__Awake_b__6_1_Internal_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E7A1 RID: 59297 RVA: 0x00387508 File Offset: 0x00385708
			[CallerCount(0)]
			public unsafe float _Awake_b__6_2(Vector3 p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonalZone.__c.NativeMethodInfoPtr__Awake_b__6_2_Internal_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E7A2 RID: 59298 RVA: 0x00387554 File Offset: 0x00385754
			[CallerCount(0)]
			public unsafe float _Awake_b__6_3(Vector3 p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonalZone.__c.NativeMethodInfoPtr__Awake_b__6_3_Internal_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E7A3 RID: 59299 RVA: 0x003875A0 File Offset: 0x003857A0
			[CallerCount(0)]
			public unsafe float _GetBoundingPoints_b__13_0(Vector3 p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonalZone.__c.NativeMethodInfoPtr__GetBoundingPoints_b__13_0_Internal_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E7A4 RID: 59300 RVA: 0x003875EC File Offset: 0x003857EC
			[CallerCount(0)]
			public unsafe float _GetBoundingPoints_b__13_1(Vector3 p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonalZone.__c.NativeMethodInfoPtr__GetBoundingPoints_b__13_1_Internal_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E7A5 RID: 59301 RVA: 0x00387638 File Offset: 0x00385838
			[CallerCount(0)]
			public unsafe float _GetBoundingPoints_b__13_2(Vector3 p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonalZone.__c.NativeMethodInfoPtr__GetBoundingPoints_b__13_2_Internal_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E7A6 RID: 59302 RVA: 0x00387684 File Offset: 0x00385884
			[CallerCount(0)]
			public unsafe float _GetBoundingPoints_b__13_3(Vector3 p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonalZone.__c.NativeMethodInfoPtr__GetBoundingPoints_b__13_3_Internal_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E7A7 RID: 59303 RVA: 0x0006D3ED File Offset: 0x0006B5ED
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700464A RID: 17994
			// (get) Token: 0x0600E7A8 RID: 59304 RVA: 0x003876D0 File Offset: 0x003858D0
			// (set) Token: 0x0600E7A9 RID: 59305 RVA: 0x0006D3F6 File Offset: 0x0006B5F6
			public unsafe static PolygonalZone.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PolygonalZone.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PolygonalZone.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PolygonalZone.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700464B RID: 17995
			// (get) Token: 0x0600E7AA RID: 59306 RVA: 0x003876F8 File Offset: 0x003858F8
			// (set) Token: 0x0600E7AB RID: 59307 RVA: 0x0006D408 File Offset: 0x0006B608
			public unsafe static Func<Vector3, float> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PolygonalZone.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PolygonalZone.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700464C RID: 17996
			// (get) Token: 0x0600E7AC RID: 59308 RVA: 0x00387720 File Offset: 0x00385920
			// (set) Token: 0x0600E7AD RID: 59309 RVA: 0x0006D41A File Offset: 0x0006B61A
			public unsafe static Func<Vector3, float> __9__6_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PolygonalZone.__c.NativeFieldInfoPtr___9__6_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PolygonalZone.__c.NativeFieldInfoPtr___9__6_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700464D RID: 17997
			// (get) Token: 0x0600E7AE RID: 59310 RVA: 0x00387748 File Offset: 0x00385948
			// (set) Token: 0x0600E7AF RID: 59311 RVA: 0x0006D42C File Offset: 0x0006B62C
			public unsafe static Func<Vector3, float> __9__6_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PolygonalZone.__c.NativeFieldInfoPtr___9__6_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PolygonalZone.__c.NativeFieldInfoPtr___9__6_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700464E RID: 17998
			// (get) Token: 0x0600E7B0 RID: 59312 RVA: 0x00387770 File Offset: 0x00385970
			// (set) Token: 0x0600E7B1 RID: 59313 RVA: 0x0006D43E File Offset: 0x0006B63E
			public unsafe static Func<Vector3, float> __9__6_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PolygonalZone.__c.NativeFieldInfoPtr___9__6_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PolygonalZone.__c.NativeFieldInfoPtr___9__6_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700464F RID: 17999
			// (get) Token: 0x0600E7B2 RID: 59314 RVA: 0x00387798 File Offset: 0x00385998
			// (set) Token: 0x0600E7B3 RID: 59315 RVA: 0x0006D450 File Offset: 0x0006B650
			public unsafe static Func<Vector3, float> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PolygonalZone.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PolygonalZone.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004650 RID: 18000
			// (get) Token: 0x0600E7B4 RID: 59316 RVA: 0x003877C0 File Offset: 0x003859C0
			// (set) Token: 0x0600E7B5 RID: 59317 RVA: 0x0006D462 File Offset: 0x0006B662
			public unsafe static Func<Vector3, float> __9__13_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PolygonalZone.__c.NativeFieldInfoPtr___9__13_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PolygonalZone.__c.NativeFieldInfoPtr___9__13_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004651 RID: 18001
			// (get) Token: 0x0600E7B6 RID: 59318 RVA: 0x003877E8 File Offset: 0x003859E8
			// (set) Token: 0x0600E7B7 RID: 59319 RVA: 0x0006D474 File Offset: 0x0006B674
			public unsafe static Func<Vector3, float> __9__13_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PolygonalZone.__c.NativeFieldInfoPtr___9__13_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PolygonalZone.__c.NativeFieldInfoPtr___9__13_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004652 RID: 18002
			// (get) Token: 0x0600E7B8 RID: 59320 RVA: 0x00387810 File Offset: 0x00385A10
			// (set) Token: 0x0600E7B9 RID: 59321 RVA: 0x0006D486 File Offset: 0x0006B686
			public unsafe static Func<Vector3, float> __9__13_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PolygonalZone.__c.NativeFieldInfoPtr___9__13_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PolygonalZone.__c.NativeFieldInfoPtr___9__13_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009D32 RID: 40242
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009D33 RID: 40243
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x04009D34 RID: 40244
			private static readonly IntPtr NativeFieldInfoPtr___9__6_1;

			// Token: 0x04009D35 RID: 40245
			private static readonly IntPtr NativeFieldInfoPtr___9__6_2;

			// Token: 0x04009D36 RID: 40246
			private static readonly IntPtr NativeFieldInfoPtr___9__6_3;

			// Token: 0x04009D37 RID: 40247
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x04009D38 RID: 40248
			private static readonly IntPtr NativeFieldInfoPtr___9__13_1;

			// Token: 0x04009D39 RID: 40249
			private static readonly IntPtr NativeFieldInfoPtr___9__13_2;

			// Token: 0x04009D3A RID: 40250
			private static readonly IntPtr NativeFieldInfoPtr___9__13_3;

			// Token: 0x04009D3B RID: 40251
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009D3C RID: 40252
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__6_0_Internal_Single_Vector3_0;

			// Token: 0x04009D3D RID: 40253
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__6_1_Internal_Single_Vector3_0;

			// Token: 0x04009D3E RID: 40254
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__6_2_Internal_Single_Vector3_0;

			// Token: 0x04009D3F RID: 40255
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__6_3_Internal_Single_Vector3_0;

			// Token: 0x04009D40 RID: 40256
			private static readonly IntPtr NativeMethodInfoPtr__GetBoundingPoints_b__13_0_Internal_Single_Vector3_0;

			// Token: 0x04009D41 RID: 40257
			private static readonly IntPtr NativeMethodInfoPtr__GetBoundingPoints_b__13_1_Internal_Single_Vector3_0;

			// Token: 0x04009D42 RID: 40258
			private static readonly IntPtr NativeMethodInfoPtr__GetBoundingPoints_b__13_2_Internal_Single_Vector3_0;

			// Token: 0x04009D43 RID: 40259
			private static readonly IntPtr NativeMethodInfoPtr__GetBoundingPoints_b__13_3_Internal_Single_Vector3_0;
		}
	}
}
