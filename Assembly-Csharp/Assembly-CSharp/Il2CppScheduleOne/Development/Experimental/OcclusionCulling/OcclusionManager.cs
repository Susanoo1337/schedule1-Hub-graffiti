using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Diagnostics;
using UnityEngine;

namespace Il2CppScheduleOne.Development.Experimental.OcclusionCulling
{
	// Token: 0x02000707 RID: 1799
	public class OcclusionManager : Singleton<OcclusionManager>
	{
		// Token: 0x0600AD5D RID: 44381 RVA: 0x002D9110 File Offset: 0x002D7310
		// Note: this type is marked as 'beforefieldinit'.
		static OcclusionManager()
		{
			Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Development.Experimental.OcclusionCulling", "OcclusionManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr);
			OcclusionManager.NativeFieldInfoPtr_Bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr, "Bounds");
			OcclusionManager.NativeFieldInfoPtr__cellSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr, "_cellSize");
			OcclusionManager.NativeFieldInfoPtr__maxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr, "_maxDistance");
			OcclusionManager.NativeFieldInfoPtr__visibilityThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr, "_visibilityThreshold");
			OcclusionManager.NativeFieldInfoPtr__occlusionDataAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr, "_occlusionDataAsset");
			OcclusionManager.NativeFieldInfoPtr__inclusionZones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr, "_inclusionZones");
			OcclusionManager.NativeFieldInfoPtr__occlusionObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr, "_occlusionObjects");
			OcclusionManager.NativeFieldInfoPtr__occlusionLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr, "_occlusionLayerMask");
			OcclusionManager.NativeFieldInfoPtr__treeLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr, "_treeLayerMask");
			OcclusionManager.NativeFieldInfoPtr__debugDrawGizmos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr, "_debugDrawGizmos");
			OcclusionManager.NativeFieldInfoPtr__debugDrawCells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr, "_debugDrawCells");
			OcclusionManager.NativeFieldInfoPtr__boundsColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr, "_boundsColor");
			OcclusionManager.NativeFieldInfoPtr__inclusionZoneColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr, "_inclusionZoneColor");
			OcclusionManager.NativeFieldInfoPtr__cellColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr, "_cellColor");
			OcclusionManager.NativeFieldInfoPtr__debugDrawRays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr, "_debugDrawRays");
			OcclusionManager.NativeFieldInfoPtr__cellLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr, "_cellLocation");
			OcclusionManager.NativeFieldInfoPtr__showCellStateForSpecifiedObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr, "_showCellStateForSpecifiedObject");
			OcclusionManager.NativeFieldInfoPtr__debugSpecifiedObjectIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr, "_debugSpecifiedObjectIndex");
			OcclusionManager.NativeFieldInfoPtr__debugSphereSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr, "_debugSphereSize");
			OcclusionManager.NativeFieldInfoPtr__bakeRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr, "_bakeRoutine");
			OcclusionManager.NativeFieldInfoPtr__stopwatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr, "_stopwatch");
			OcclusionManager.NativeFieldInfoPtr__debugCellCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr, "_debugCellCount");
			OcclusionManager.NativeFieldInfoPtr__debugRayCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr, "_debugRayCount");
			OcclusionManager.NativeFieldInfoPtr__treeLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr, "_treeLayer");
			OcclusionManager.NativeFieldInfoPtr__isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr, "_isActive");
			OcclusionManager.NativeFieldInfoPtr_hits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr, "hits");
			OcclusionManager.NativeMethodInfoPtr_RunOcclusionBake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr, 100686185);
			OcclusionManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr, 100686186);
			OcclusionManager.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr, 100686187);
			OcclusionManager.NativeMethodInfoPtr_DoOcclusionBakeRoutine_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr, 100686188);
			OcclusionManager.NativeMethodInfoPtr_IsObjectVisible_Private_Boolean_Vector3_OcclusionObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr, 100686189);
			OcclusionManager.NativeMethodInfoPtr_IsObjectCornersVisible_Private_Boolean_Vector3_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr, 100686190);
			OcclusionManager.NativeMethodInfoPtr_IsObjectFaceVisible_Private_Boolean_Vector3_Vector3_Vector3_Vector3_Vector3_Single_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr, 100686191);
			OcclusionManager.NativeMethodInfoPtr_IsPointVisible_Private_Boolean_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr, 100686192);
			OcclusionManager.NativeMethodInfoPtr_WorldToCellIndex_Private_Vector3Int_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr, 100686193);
			OcclusionManager.NativeMethodInfoPtr_GetObjectVisiblityState_Private_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr, 100686194);
			OcclusionManager.NativeMethodInfoPtr_SetObjectStateBasedOnPosition_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr, 100686195);
			OcclusionManager.NativeMethodInfoPtr_GetStateAtWorldPosition_Public_Boolean_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr, 100686196);
			OcclusionManager.NativeMethodInfoPtr_WorldPositionToOcclusionIndex_Public_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr, 100686197);
			OcclusionManager.NativeMethodInfoPtr_DebugCellRays_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr, 100686198);
			OcclusionManager.NativeMethodInfoPtr_CalculateCells_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr, 100686199);
			OcclusionManager.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr, 100686200);
			OcclusionManager.NativeMethodInfoPtr_DebugSpecifiedObjectState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr, 100686201);
			OcclusionManager.NativeMethodInfoPtr_CheckData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr, 100686202);
			OcclusionManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr, 100686203);
		}

		// Token: 0x0600AD5E RID: 44382 RVA: 0x002D94C4 File Offset: 0x002D76C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296944, XrefRangeEnd = 296945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunOcclusionBake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionManager.NativeMethodInfoPtr_RunOcclusionBake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD5F RID: 44383 RVA: 0x002D94F8 File Offset: 0x002D76F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296945, XrefRangeEnd = 296965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD60 RID: 44384 RVA: 0x002D952C File Offset: 0x002D772C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 296986, RefRangeEnd = 296988, XrefRangeStart = 296965, XrefRangeEnd = 296986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActive(bool isActive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isActive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionManager.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD61 RID: 44385 RVA: 0x002D956C File Offset: 0x002D776C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 297096, RefRangeEnd = 297097, XrefRangeStart = 296988, XrefRangeEnd = 297096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoOcclusionBakeRoutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionManager.NativeMethodInfoPtr_DoOcclusionBakeRoutine_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD62 RID: 44386 RVA: 0x002D95A0 File Offset: 0x002D77A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 297145, RefRangeEnd = 297147, XrefRangeStart = 297097, XrefRangeEnd = 297145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsObjectVisible(Vector3 point, OcclusionObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionManager.NativeMethodInfoPtr_IsObjectVisible_Private_Boolean_Vector3_OcclusionObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600AD63 RID: 44387 RVA: 0x002D95FC File Offset: 0x002D77FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297147, XrefRangeEnd = 297149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsObjectCornersVisible(Vector3 point, Il2CppStructArray<Vector3> corners)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(corners);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionManager.NativeMethodInfoPtr_IsObjectCornersVisible_Private_Boolean_Vector3_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600AD64 RID: 44388 RVA: 0x002D9658 File Offset: 0x002D7858
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 297152, RefRangeEnd = 297158, XrefRangeStart = 297149, XrefRangeEnd = 297152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsObjectFaceVisible(Vector3 cell, Vector3 origin, Vector3 normal, Vector3 axisU, Vector3 axisV, float sizeNormal, float sizeU, float sizeV, int N)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cell;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref origin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normal;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisU;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisV;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizeNormal;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizeU;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizeV;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref N;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionManager.NativeMethodInfoPtr_IsObjectFaceVisible_Private_Boolean_Vector3_Vector3_Vector3_Vector3_Vector3_Single_Single_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600AD65 RID: 44389 RVA: 0x002D9714 File Offset: 0x002D7914
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 297178, RefRangeEnd = 297181, XrefRangeStart = 297158, XrefRangeEnd = 297178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPointVisible(Vector3 p1, Vector3 p2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref p1;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionManager.NativeMethodInfoPtr_IsPointVisible_Private_Boolean_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600AD66 RID: 44390 RVA: 0x002D976C File Offset: 0x002D796C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297181, XrefRangeEnd = 297193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3Int WorldToCellIndex(Vector3 worldPos, Vector3 origin, Vector3 cellSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldPos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref origin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cellSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionManager.NativeMethodInfoPtr_WorldToCellIndex_Private_Vector3Int_Vector3_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600AD67 RID: 44391 RVA: 0x002D97D4 File Offset: 0x002D79D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 297193, RefRangeEnd = 297196, XrefRangeStart = 297193, XrefRangeEnd = 297193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetObjectVisiblityState(int dataIndex, int objectIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dataIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objectIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionManager.NativeMethodInfoPtr_GetObjectVisiblityState_Private_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600AD68 RID: 44392 RVA: 0x002D982C File Offset: 0x002D7A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297196, XrefRangeEnd = 297208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetObjectStateBasedOnPosition(Vector3 worldPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionManager.NativeMethodInfoPtr_SetObjectStateBasedOnPosition_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD69 RID: 44393 RVA: 0x002D986C File Offset: 0x002D7A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297208, XrefRangeEnd = 297209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetStateAtWorldPosition(Vector3 worldPos, int objectIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldPos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objectIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionManager.NativeMethodInfoPtr_GetStateAtWorldPosition_Public_Boolean_Vector3_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600AD6A RID: 44394 RVA: 0x002D98C4 File Offset: 0x002D7AC4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 297235, RefRangeEnd = 297238, XrefRangeStart = 297209, XrefRangeEnd = 297235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int WorldPositionToOcclusionIndex(Vector3 worldPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionManager.NativeMethodInfoPtr_WorldPositionToOcclusionIndex_Public_Int32_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600AD6B RID: 44395 RVA: 0x002D9910 File Offset: 0x002D7B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297238, XrefRangeEnd = 297283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DebugCellRays()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionManager.NativeMethodInfoPtr_DebugCellRays_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD6C RID: 44396 RVA: 0x002D9944 File Offset: 0x002D7B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297283, XrefRangeEnd = 297332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateCells()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionManager.NativeMethodInfoPtr_CalculateCells_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD6D RID: 44397 RVA: 0x002D9978 File Offset: 0x002D7B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297332, XrefRangeEnd = 297413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionManager.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD6E RID: 44398 RVA: 0x002D99AC File Offset: 0x002D7BAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 297462, RefRangeEnd = 297463, XrefRangeStart = 297413, XrefRangeEnd = 297462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DebugSpecifiedObjectState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionManager.NativeMethodInfoPtr_DebugSpecifiedObjectState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD6F RID: 44399 RVA: 0x002D99E0 File Offset: 0x002D7BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297463, XrefRangeEnd = 297478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionManager.NativeMethodInfoPtr_CheckData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD70 RID: 44400 RVA: 0x002D9A14 File Offset: 0x002D7C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297478, XrefRangeEnd = 297492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OcclusionManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OcclusionManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD71 RID: 44401 RVA: 0x0004F39E File Offset: 0x0004D59E
		public OcclusionManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170033F6 RID: 13302
		// (get) Token: 0x0600AD72 RID: 44402 RVA: 0x002D9A50 File Offset: 0x002D7C50
		// (set) Token: 0x0600AD73 RID: 44403 RVA: 0x0004F3A7 File Offset: 0x0004D5A7
		public unsafe Vector3 Bounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr_Bounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr_Bounds)) = value;
			}
		}

		// Token: 0x170033F7 RID: 13303
		// (get) Token: 0x0600AD74 RID: 44404 RVA: 0x002D9A78 File Offset: 0x002D7C78
		// (set) Token: 0x0600AD75 RID: 44405 RVA: 0x0004F3C2 File Offset: 0x0004D5C2
		public unsafe float _cellSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__cellSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__cellSize)) = value;
			}
		}

		// Token: 0x170033F8 RID: 13304
		// (get) Token: 0x0600AD76 RID: 44406 RVA: 0x002D9AA0 File Offset: 0x002D7CA0
		// (set) Token: 0x0600AD77 RID: 44407 RVA: 0x0004F3DD File Offset: 0x0004D5DD
		public unsafe float _maxDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__maxDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__maxDistance)) = value;
			}
		}

		// Token: 0x170033F9 RID: 13305
		// (get) Token: 0x0600AD78 RID: 44408 RVA: 0x002D9AC8 File Offset: 0x002D7CC8
		// (set) Token: 0x0600AD79 RID: 44409 RVA: 0x0004F3F8 File Offset: 0x0004D5F8
		public unsafe float _visibilityThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__visibilityThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__visibilityThreshold)) = value;
			}
		}

		// Token: 0x170033FA RID: 13306
		// (get) Token: 0x0600AD7A RID: 44410 RVA: 0x002D9AF0 File Offset: 0x002D7CF0
		// (set) Token: 0x0600AD7B RID: 44411 RVA: 0x0004F413 File Offset: 0x0004D613
		public unsafe OcclusionData _occlusionDataAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__occlusionDataAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OcclusionData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__occlusionDataAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033FB RID: 13307
		// (get) Token: 0x0600AD7C RID: 44412 RVA: 0x002D9B20 File Offset: 0x002D7D20
		// (set) Token: 0x0600AD7D RID: 44413 RVA: 0x0004F432 File Offset: 0x0004D632
		public unsafe List<Collider> _inclusionZones
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__inclusionZones);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__inclusionZones), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033FC RID: 13308
		// (get) Token: 0x0600AD7E RID: 44414 RVA: 0x002D9B50 File Offset: 0x002D7D50
		// (set) Token: 0x0600AD7F RID: 44415 RVA: 0x0004F451 File Offset: 0x0004D651
		public unsafe List<OcclusionObject> _occlusionObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__occlusionObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<OcclusionObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__occlusionObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033FD RID: 13309
		// (get) Token: 0x0600AD80 RID: 44416 RVA: 0x002D9B80 File Offset: 0x002D7D80
		// (set) Token: 0x0600AD81 RID: 44417 RVA: 0x0004F470 File Offset: 0x0004D670
		public unsafe LayerMask _occlusionLayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__occlusionLayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__occlusionLayerMask)) = value;
			}
		}

		// Token: 0x170033FE RID: 13310
		// (get) Token: 0x0600AD82 RID: 44418 RVA: 0x002D9BA8 File Offset: 0x002D7DA8
		// (set) Token: 0x0600AD83 RID: 44419 RVA: 0x0004F48B File Offset: 0x0004D68B
		public unsafe LayerMask _treeLayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__treeLayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__treeLayerMask)) = value;
			}
		}

		// Token: 0x170033FF RID: 13311
		// (get) Token: 0x0600AD84 RID: 44420 RVA: 0x002D9BD0 File Offset: 0x002D7DD0
		// (set) Token: 0x0600AD85 RID: 44421 RVA: 0x0004F4A6 File Offset: 0x0004D6A6
		public unsafe bool _debugDrawGizmos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__debugDrawGizmos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__debugDrawGizmos)) = value;
			}
		}

		// Token: 0x17003400 RID: 13312
		// (get) Token: 0x0600AD86 RID: 44422 RVA: 0x002D9BF8 File Offset: 0x002D7DF8
		// (set) Token: 0x0600AD87 RID: 44423 RVA: 0x0004F4C1 File Offset: 0x0004D6C1
		public unsafe bool _debugDrawCells
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__debugDrawCells);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__debugDrawCells)) = value;
			}
		}

		// Token: 0x17003401 RID: 13313
		// (get) Token: 0x0600AD88 RID: 44424 RVA: 0x002D9C20 File Offset: 0x002D7E20
		// (set) Token: 0x0600AD89 RID: 44425 RVA: 0x0004F4DC File Offset: 0x0004D6DC
		public unsafe Color _boundsColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__boundsColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__boundsColor)) = value;
			}
		}

		// Token: 0x17003402 RID: 13314
		// (get) Token: 0x0600AD8A RID: 44426 RVA: 0x002D9C48 File Offset: 0x002D7E48
		// (set) Token: 0x0600AD8B RID: 44427 RVA: 0x0004F4F7 File Offset: 0x0004D6F7
		public unsafe Color _inclusionZoneColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__inclusionZoneColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__inclusionZoneColor)) = value;
			}
		}

		// Token: 0x17003403 RID: 13315
		// (get) Token: 0x0600AD8C RID: 44428 RVA: 0x002D9C70 File Offset: 0x002D7E70
		// (set) Token: 0x0600AD8D RID: 44429 RVA: 0x0004F512 File Offset: 0x0004D712
		public unsafe Color _cellColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__cellColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__cellColor)) = value;
			}
		}

		// Token: 0x17003404 RID: 13316
		// (get) Token: 0x0600AD8E RID: 44430 RVA: 0x002D9C98 File Offset: 0x002D7E98
		// (set) Token: 0x0600AD8F RID: 44431 RVA: 0x0004F52D File Offset: 0x0004D72D
		public unsafe bool _debugDrawRays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__debugDrawRays);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__debugDrawRays)) = value;
			}
		}

		// Token: 0x17003405 RID: 13317
		// (get) Token: 0x0600AD90 RID: 44432 RVA: 0x002D9CC0 File Offset: 0x002D7EC0
		// (set) Token: 0x0600AD91 RID: 44433 RVA: 0x0004F548 File Offset: 0x0004D748
		public unsafe Transform _cellLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__cellLocation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__cellLocation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003406 RID: 13318
		// (get) Token: 0x0600AD92 RID: 44434 RVA: 0x002D9CF0 File Offset: 0x002D7EF0
		// (set) Token: 0x0600AD93 RID: 44435 RVA: 0x0004F567 File Offset: 0x0004D767
		public unsafe bool _showCellStateForSpecifiedObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__showCellStateForSpecifiedObject);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__showCellStateForSpecifiedObject)) = value;
			}
		}

		// Token: 0x17003407 RID: 13319
		// (get) Token: 0x0600AD94 RID: 44436 RVA: 0x002D9D18 File Offset: 0x002D7F18
		// (set) Token: 0x0600AD95 RID: 44437 RVA: 0x0004F582 File Offset: 0x0004D782
		public unsafe int _debugSpecifiedObjectIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__debugSpecifiedObjectIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__debugSpecifiedObjectIndex)) = value;
			}
		}

		// Token: 0x17003408 RID: 13320
		// (get) Token: 0x0600AD96 RID: 44438 RVA: 0x002D9D40 File Offset: 0x002D7F40
		// (set) Token: 0x0600AD97 RID: 44439 RVA: 0x0004F59D File Offset: 0x0004D79D
		public unsafe float _debugSphereSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__debugSphereSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__debugSphereSize)) = value;
			}
		}

		// Token: 0x17003409 RID: 13321
		// (get) Token: 0x0600AD98 RID: 44440 RVA: 0x002D9D68 File Offset: 0x002D7F68
		// (set) Token: 0x0600AD99 RID: 44441 RVA: 0x0004F5B8 File Offset: 0x0004D7B8
		public unsafe Coroutine _bakeRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__bakeRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__bakeRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700340A RID: 13322
		// (get) Token: 0x0600AD9A RID: 44442 RVA: 0x002D9D98 File Offset: 0x002D7F98
		// (set) Token: 0x0600AD9B RID: 44443 RVA: 0x0004F5D7 File Offset: 0x0004D7D7
		public unsafe Stopwatch _stopwatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__stopwatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stopwatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__stopwatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700340B RID: 13323
		// (get) Token: 0x0600AD9C RID: 44444 RVA: 0x002D9DC8 File Offset: 0x002D7FC8
		// (set) Token: 0x0600AD9D RID: 44445 RVA: 0x0004F5F6 File Offset: 0x0004D7F6
		public unsafe int _debugCellCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__debugCellCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__debugCellCount)) = value;
			}
		}

		// Token: 0x1700340C RID: 13324
		// (get) Token: 0x0600AD9E RID: 44446 RVA: 0x002D9DF0 File Offset: 0x002D7FF0
		// (set) Token: 0x0600AD9F RID: 44447 RVA: 0x0004F611 File Offset: 0x0004D811
		public unsafe int _debugRayCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__debugRayCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__debugRayCount)) = value;
			}
		}

		// Token: 0x1700340D RID: 13325
		// (get) Token: 0x0600ADA0 RID: 44448 RVA: 0x002D9E18 File Offset: 0x002D8018
		// (set) Token: 0x0600ADA1 RID: 44449 RVA: 0x0004F62C File Offset: 0x0004D82C
		public unsafe int _treeLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__treeLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__treeLayer)) = value;
			}
		}

		// Token: 0x1700340E RID: 13326
		// (get) Token: 0x0600ADA2 RID: 44450 RVA: 0x002D9E40 File Offset: 0x002D8040
		// (set) Token: 0x0600ADA3 RID: 44451 RVA: 0x0004F647 File Offset: 0x0004D847
		public unsafe bool _isActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__isActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr__isActive)) = value;
			}
		}

		// Token: 0x1700340F RID: 13327
		// (get) Token: 0x0600ADA4 RID: 44452 RVA: 0x002D9E68 File Offset: 0x002D8068
		// (set) Token: 0x0600ADA5 RID: 44453 RVA: 0x0004F662 File Offset: 0x0004D862
		public unsafe Il2CppStructArray<RaycastHit> hits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr_hits);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager.NativeFieldInfoPtr_hits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040077BF RID: 30655
		private static readonly IntPtr NativeFieldInfoPtr_Bounds;

		// Token: 0x040077C0 RID: 30656
		private static readonly IntPtr NativeFieldInfoPtr__cellSize;

		// Token: 0x040077C1 RID: 30657
		private static readonly IntPtr NativeFieldInfoPtr__maxDistance;

		// Token: 0x040077C2 RID: 30658
		private static readonly IntPtr NativeFieldInfoPtr__visibilityThreshold;

		// Token: 0x040077C3 RID: 30659
		private static readonly IntPtr NativeFieldInfoPtr__occlusionDataAsset;

		// Token: 0x040077C4 RID: 30660
		private static readonly IntPtr NativeFieldInfoPtr__inclusionZones;

		// Token: 0x040077C5 RID: 30661
		private static readonly IntPtr NativeFieldInfoPtr__occlusionObjects;

		// Token: 0x040077C6 RID: 30662
		private static readonly IntPtr NativeFieldInfoPtr__occlusionLayerMask;

		// Token: 0x040077C7 RID: 30663
		private static readonly IntPtr NativeFieldInfoPtr__treeLayerMask;

		// Token: 0x040077C8 RID: 30664
		private static readonly IntPtr NativeFieldInfoPtr__debugDrawGizmos;

		// Token: 0x040077C9 RID: 30665
		private static readonly IntPtr NativeFieldInfoPtr__debugDrawCells;

		// Token: 0x040077CA RID: 30666
		private static readonly IntPtr NativeFieldInfoPtr__boundsColor;

		// Token: 0x040077CB RID: 30667
		private static readonly IntPtr NativeFieldInfoPtr__inclusionZoneColor;

		// Token: 0x040077CC RID: 30668
		private static readonly IntPtr NativeFieldInfoPtr__cellColor;

		// Token: 0x040077CD RID: 30669
		private static readonly IntPtr NativeFieldInfoPtr__debugDrawRays;

		// Token: 0x040077CE RID: 30670
		private static readonly IntPtr NativeFieldInfoPtr__cellLocation;

		// Token: 0x040077CF RID: 30671
		private static readonly IntPtr NativeFieldInfoPtr__showCellStateForSpecifiedObject;

		// Token: 0x040077D0 RID: 30672
		private static readonly IntPtr NativeFieldInfoPtr__debugSpecifiedObjectIndex;

		// Token: 0x040077D1 RID: 30673
		private static readonly IntPtr NativeFieldInfoPtr__debugSphereSize;

		// Token: 0x040077D2 RID: 30674
		private static readonly IntPtr NativeFieldInfoPtr__bakeRoutine;

		// Token: 0x040077D3 RID: 30675
		private static readonly IntPtr NativeFieldInfoPtr__stopwatch;

		// Token: 0x040077D4 RID: 30676
		private static readonly IntPtr NativeFieldInfoPtr__debugCellCount;

		// Token: 0x040077D5 RID: 30677
		private static readonly IntPtr NativeFieldInfoPtr__debugRayCount;

		// Token: 0x040077D6 RID: 30678
		private static readonly IntPtr NativeFieldInfoPtr__treeLayer;

		// Token: 0x040077D7 RID: 30679
		private static readonly IntPtr NativeFieldInfoPtr__isActive;

		// Token: 0x040077D8 RID: 30680
		private static readonly IntPtr NativeFieldInfoPtr_hits;

		// Token: 0x040077D9 RID: 30681
		private static readonly IntPtr NativeMethodInfoPtr_RunOcclusionBake_Public_Void_0;

		// Token: 0x040077DA RID: 30682
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040077DB RID: 30683
		private static readonly IntPtr NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0;

		// Token: 0x040077DC RID: 30684
		private static readonly IntPtr NativeMethodInfoPtr_DoOcclusionBakeRoutine_Private_Void_0;

		// Token: 0x040077DD RID: 30685
		private static readonly IntPtr NativeMethodInfoPtr_IsObjectVisible_Private_Boolean_Vector3_OcclusionObject_0;

		// Token: 0x040077DE RID: 30686
		private static readonly IntPtr NativeMethodInfoPtr_IsObjectCornersVisible_Private_Boolean_Vector3_Il2CppStructArray_1_Vector3_0;

		// Token: 0x040077DF RID: 30687
		private static readonly IntPtr NativeMethodInfoPtr_IsObjectFaceVisible_Private_Boolean_Vector3_Vector3_Vector3_Vector3_Vector3_Single_Single_Single_Int32_0;

		// Token: 0x040077E0 RID: 30688
		private static readonly IntPtr NativeMethodInfoPtr_IsPointVisible_Private_Boolean_Vector3_Vector3_0;

		// Token: 0x040077E1 RID: 30689
		private static readonly IntPtr NativeMethodInfoPtr_WorldToCellIndex_Private_Vector3Int_Vector3_Vector3_Vector3_0;

		// Token: 0x040077E2 RID: 30690
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectVisiblityState_Private_Boolean_Int32_Int32_0;

		// Token: 0x040077E3 RID: 30691
		private static readonly IntPtr NativeMethodInfoPtr_SetObjectStateBasedOnPosition_Public_Void_Vector3_0;

		// Token: 0x040077E4 RID: 30692
		private static readonly IntPtr NativeMethodInfoPtr_GetStateAtWorldPosition_Public_Boolean_Vector3_Int32_0;

		// Token: 0x040077E5 RID: 30693
		private static readonly IntPtr NativeMethodInfoPtr_WorldPositionToOcclusionIndex_Public_Int32_Vector3_0;

		// Token: 0x040077E6 RID: 30694
		private static readonly IntPtr NativeMethodInfoPtr_DebugCellRays_Private_Void_0;

		// Token: 0x040077E7 RID: 30695
		private static readonly IntPtr NativeMethodInfoPtr_CalculateCells_Private_Void_0;

		// Token: 0x040077E8 RID: 30696
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x040077E9 RID: 30697
		private static readonly IntPtr NativeMethodInfoPtr_DebugSpecifiedObjectState_Private_Void_0;

		// Token: 0x040077EA RID: 30698
		private static readonly IntPtr NativeMethodInfoPtr_CheckData_Public_Void_0;

		// Token: 0x040077EB RID: 30699
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
