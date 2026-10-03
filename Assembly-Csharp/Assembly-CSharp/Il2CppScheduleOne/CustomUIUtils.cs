using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Il2CppScheduleOne
{
	// Token: 0x02000097 RID: 151
	public static class CustomUIUtils : Il2CppSystem.Object
	{
		// Token: 0x06000D0B RID: 3339 RVA: 0x000A6B64 File Offset: 0x000A4D64
		// Note: this type is marked as 'beforefieldinit'.
		static CustomUIUtils()
		{
			Il2CppClassPointerStore<CustomUIUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "CustomUIUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomUIUtils>.NativeClassPtr);
			CustomUIUtils.NativeMethodInfoPtr_GetSystemMouse_Public_Static_Mouse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomUIUtils>.NativeClassPtr, 100664937);
			CustomUIUtils.NativeMethodInfoPtr_GetVirtualMouse_Public_Static_Mouse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomUIUtils>.NativeClassPtr, 100664938);
			CustomUIUtils.NativeMethodInfoPtr_GetScreenPosition_Public_Static_Vector2_Canvas_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomUIUtils>.NativeClassPtr, 100664939);
			CustomUIUtils.NativeMethodInfoPtr_GetScreenPosition_Public_Static_Vector2_Canvas_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomUIUtils>.NativeClassPtr, 100664940);
			CustomUIUtils.NativeMethodInfoPtr_GetSelectables_Public_Static_List_1_UISelectable_UIScreen_UIPanel_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomUIUtils>.NativeClassPtr, 100664941);
			CustomUIUtils.NativeMethodInfoPtr_FindBestElementWeighted_Public_Static_T_Vector2_Canvas_T_List_1_T_NavigationSettings_byref_List_1_CandidateInfo_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomUIUtils>.NativeClassPtr, 100664942);
			CustomUIUtils.NativeMethodInfoPtr_RaycastRectTransform_Public_Static_Boolean_RectTransform_Canvas_Vector2_Vector2_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomUIUtils>.NativeClassPtr, 100664943);
			CustomUIUtils.NativeMethodInfoPtr_GetWeightedScore_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomUIUtils>.NativeClassPtr, 100664944);
			CustomUIUtils.NativeMethodInfoPtr_GetDirectionMatch_Public_Static_Single_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomUIUtils>.NativeClassPtr, 100664945);
			CustomUIUtils.NativeMethodInfoPtr_GetDirectionMatchForCorners_Public_Static_Single_Vector2_Vector2_RectTransform_Canvas_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomUIUtils>.NativeClassPtr, 100664946);
			CustomUIUtils.NativeMethodInfoPtr_GetDistanceOfClosestPoint_Public_Static_Single_Vector2_RectTransform_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomUIUtils>.NativeClassPtr, 100664947);
			CustomUIUtils.NativeMethodInfoPtr_SnapDirection_Public_Static_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomUIUtils>.NativeClassPtr, 100664948);
			CustomUIUtils.NativeMethodInfoPtr_IsHorizontal_Public_Static_Boolean_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomUIUtils>.NativeClassPtr, 100664949);
			CustomUIUtils.NativeMethodInfoPtr_IsVertical_Public_Static_Boolean_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomUIUtils>.NativeClassPtr, 100664950);
			CustomUIUtils.NativeMethodInfoPtr_ToScreenDirection_Public_Static_ScreenDirection_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomUIUtils>.NativeClassPtr, 100664951);
			CustomUIUtils.NativeMethodInfoPtr_ClampToDirection_Public_Static_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomUIUtils>.NativeClassPtr, 100664952);
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x000A6CD4 File Offset: 0x000A4ED4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 79289, RefRangeEnd = 79291, XrefRangeStart = 79278, XrefRangeEnd = 79289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mouse GetSystemMouse()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomUIUtils.NativeMethodInfoPtr_GetSystemMouse_Public_Static_Mouse_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mouse>(intPtr3) : null;
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x000A6D08 File Offset: 0x000A4F08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79302, RefRangeEnd = 79303, XrefRangeStart = 79291, XrefRangeEnd = 79302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mouse GetVirtualMouse()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomUIUtils.NativeMethodInfoPtr_GetVirtualMouse_Public_Static_Mouse_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mouse>(intPtr3) : null;
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x000A6D3C File Offset: 0x000A4F3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79325, RefRangeEnd = 79326, XrefRangeStart = 79303, XrefRangeEnd = 79325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 GetScreenPosition(Canvas canvas, RectTransform selectable)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvas);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomUIUtils.NativeMethodInfoPtr_GetScreenPosition_Public_Static_Vector2_Canvas_RectTransform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x000A6D90 File Offset: 0x000A4F90
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 79344, RefRangeEnd = 79353, XrefRangeStart = 79326, XrefRangeEnd = 79344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 GetScreenPosition(Canvas canvas, Vector3 worldPosition)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvas);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomUIUtils.NativeMethodInfoPtr_GetScreenPosition_Public_Static_Vector2_Canvas_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x000A6DE0 File Offset: 0x000A4FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79353, XrefRangeEnd = 79403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<UISelectable> GetSelectables(UIScreen screen, UIPanel current = null, bool includeCurrentPanel = true)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(screen);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(current);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeCurrentPanel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomUIUtils.NativeMethodInfoPtr_GetSelectables_Public_Static_List_1_UISelectable_UIScreen_UIPanel_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<UISelectable>>(intPtr3) : null;
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x000A6E44 File Offset: 0x000A5044
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79434, RefRangeEnd = 79435, XrefRangeStart = 79403, XrefRangeEnd = 79434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T FindBestElementWeighted<T>(Vector2 dir, Canvas canvas, T current, List<T> candidates, UIContentPanel.NavigationSettings settings, out List<CustomUIUtils.CandidateInfo<T>> validCandidates)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dir;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(canvas);
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = current;
				if (!(t is string))
				{
					ref T ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr4 = ref current;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(candidates);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr5 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CustomUIUtils.MethodInfoStoreGeneric_FindBestElementWeighted_Public_Static_T_Vector2_Canvas_T_List_1_T_NavigationSettings_byref_List_1_CandidateInfo_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			validCandidates = ((intPtr4 == 0) ? null : new List<CustomUIUtils.CandidateInfo<T>>(intPtr4));
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x000A6F38 File Offset: 0x000A5138
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 79444, RefRangeEnd = 79446, XrefRangeStart = 79435, XrefRangeEnd = 79444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RaycastRectTransform(RectTransform rect, Canvas canvas, Vector2 p, Vector2 d, out Vector2 hitPoint)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(canvas);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hitPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomUIUtils.NativeMethodInfoPtr_RaycastRectTransform_Public_Static_Boolean_RectTransform_Canvas_Vector2_Vector2_byref_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x000A6FB8 File Offset: 0x000A51B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79446, RefRangeEnd = 79447, XrefRangeStart = 79446, XrefRangeEnd = 79446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetWeightedScore(float directionMatch, float distance, float directionWeight, float distanceWeight)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref directionMatch;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref directionWeight;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distanceWeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomUIUtils.NativeMethodInfoPtr_GetWeightedScore_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x000A7020 File Offset: 0x000A5220
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79449, RefRangeEnd = 79450, XrefRangeStart = 79447, XrefRangeEnd = 79449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetDirectionMatch(Vector2 dir, Vector2 fromScreenPos, Vector2 toScreenPos)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dir;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromScreenPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toScreenPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomUIUtils.NativeMethodInfoPtr_GetDirectionMatch_Public_Static_Single_Vector2_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x000A707C File Offset: 0x000A527C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79459, RefRangeEnd = 79460, XrefRangeStart = 79450, XrefRangeEnd = 79459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetDirectionMatchForCorners(Vector2 dir, Vector2 screenPos, RectTransform rectTransform, Canvas canvas, float intersectionOffset = 50f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dir;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref screenPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(canvas);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref intersectionOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomUIUtils.NativeMethodInfoPtr_GetDirectionMatchForCorners_Public_Static_Single_Vector2_Vector2_RectTransform_Canvas_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x000A70FC File Offset: 0x000A52FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79460, XrefRangeEnd = 79472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetDistanceOfClosestPoint(Vector2 screenPos, RectTransform rectTransform, Canvas canvas)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref screenPos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(canvas);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomUIUtils.NativeMethodInfoPtr_GetDistanceOfClosestPoint_Public_Static_Single_Vector2_RectTransform_Canvas_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x000A7160 File Offset: 0x000A5360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79472, XrefRangeEnd = 79473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 SnapDirection(Vector2 dir, float threshold = 0.1f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dir;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref threshold;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomUIUtils.NativeMethodInfoPtr_SnapDirection_Public_Static_Vector2_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x000A71AC File Offset: 0x000A53AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79473, XrefRangeEnd = 79474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsHorizontal(Vector2 val, float threshold = 0.2f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref val;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref threshold;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomUIUtils.NativeMethodInfoPtr_IsHorizontal_Public_Static_Boolean_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x000A71F8 File Offset: 0x000A53F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79474, XrefRangeEnd = 79475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsVertical(Vector2 val, float threshold = 0.2f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref val;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref threshold;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomUIUtils.NativeMethodInfoPtr_IsVertical_Public_Static_Boolean_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x000A7244 File Offset: 0x000A5444
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 79476, RefRangeEnd = 79478, XrefRangeStart = 79475, XrefRangeEnd = 79476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScreenDirection ToScreenDirection(Vector2 val)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomUIUtils.NativeMethodInfoPtr_ToScreenDirection_Public_Static_ScreenDirection_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x000A7284 File Offset: 0x000A5484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79478, XrefRangeEnd = 79481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 ClampToDirection(Vector2 val, Vector2 dir)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref val;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomUIUtils.NativeMethodInfoPtr_ClampToDirection_Public_Static_Vector2_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x0000801C File Offset: 0x0000621C
		public CustomUIUtils(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000929 RID: 2345
		private static readonly IntPtr NativeMethodInfoPtr_GetSystemMouse_Public_Static_Mouse_0;

		// Token: 0x0400092A RID: 2346
		private static readonly IntPtr NativeMethodInfoPtr_GetVirtualMouse_Public_Static_Mouse_0;

		// Token: 0x0400092B RID: 2347
		private static readonly IntPtr NativeMethodInfoPtr_GetScreenPosition_Public_Static_Vector2_Canvas_RectTransform_0;

		// Token: 0x0400092C RID: 2348
		private static readonly IntPtr NativeMethodInfoPtr_GetScreenPosition_Public_Static_Vector2_Canvas_Vector3_0;

		// Token: 0x0400092D RID: 2349
		private static readonly IntPtr NativeMethodInfoPtr_GetSelectables_Public_Static_List_1_UISelectable_UIScreen_UIPanel_Boolean_0;

		// Token: 0x0400092E RID: 2350
		private static readonly IntPtr NativeMethodInfoPtr_FindBestElementWeighted_Public_Static_T_Vector2_Canvas_T_List_1_T_NavigationSettings_byref_List_1_CandidateInfo_1_T_0;

		// Token: 0x0400092F RID: 2351
		private static readonly IntPtr NativeMethodInfoPtr_RaycastRectTransform_Public_Static_Boolean_RectTransform_Canvas_Vector2_Vector2_byref_Vector2_0;

		// Token: 0x04000930 RID: 2352
		private static readonly IntPtr NativeMethodInfoPtr_GetWeightedScore_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x04000931 RID: 2353
		private static readonly IntPtr NativeMethodInfoPtr_GetDirectionMatch_Public_Static_Single_Vector2_Vector2_Vector2_0;

		// Token: 0x04000932 RID: 2354
		private static readonly IntPtr NativeMethodInfoPtr_GetDirectionMatchForCorners_Public_Static_Single_Vector2_Vector2_RectTransform_Canvas_Single_0;

		// Token: 0x04000933 RID: 2355
		private static readonly IntPtr NativeMethodInfoPtr_GetDistanceOfClosestPoint_Public_Static_Single_Vector2_RectTransform_Canvas_0;

		// Token: 0x04000934 RID: 2356
		private static readonly IntPtr NativeMethodInfoPtr_SnapDirection_Public_Static_Vector2_Vector2_Single_0;

		// Token: 0x04000935 RID: 2357
		private static readonly IntPtr NativeMethodInfoPtr_IsHorizontal_Public_Static_Boolean_Vector2_Single_0;

		// Token: 0x04000936 RID: 2358
		private static readonly IntPtr NativeMethodInfoPtr_IsVertical_Public_Static_Boolean_Vector2_Single_0;

		// Token: 0x04000937 RID: 2359
		private static readonly IntPtr NativeMethodInfoPtr_ToScreenDirection_Public_Static_ScreenDirection_Vector2_0;

		// Token: 0x04000938 RID: 2360
		private static readonly IntPtr NativeMethodInfoPtr_ClampToDirection_Public_Static_Vector2_Vector2_Vector2_0;

		// Token: 0x020008AC RID: 2220
		public class CandidateInfo<T> : Il2CppSystem.Object
		{
			// Token: 0x0600D3FB RID: 54267 RVA: 0x0034D454 File Offset: 0x0034B654
			// Note: this type is marked as 'beforefieldinit'.
			static CandidateInfo()
			{
				Il2CppClassPointerStore<CustomUIUtils.CandidateInfo<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomUIUtils>.NativeClassPtr, "CandidateInfo`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomUIUtils.CandidateInfo<T>>.NativeClassPtr);
				CustomUIUtils.CandidateInfo<T>.NativeFieldInfoPtr_Candidate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomUIUtils.CandidateInfo<T>>.NativeClassPtr, "Candidate");
				CustomUIUtils.CandidateInfo<T>.NativeFieldInfoPtr_DirectionMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomUIUtils.CandidateInfo<T>>.NativeClassPtr, "DirectionMatch");
				CustomUIUtils.CandidateInfo<T>.NativeFieldInfoPtr_Distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomUIUtils.CandidateInfo<T>>.NativeClassPtr, "Distance");
				CustomUIUtils.CandidateInfo<T>.NativeFieldInfoPtr_Score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomUIUtils.CandidateInfo<T>>.NativeClassPtr, "Score");
				CustomUIUtils.CandidateInfo<T>.NativeMethodInfoPtr__ctor_Public_Void_T_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomUIUtils.CandidateInfo<T>>.NativeClassPtr, 100664953);
			}

			// Token: 0x0600D3FC RID: 54268 RVA: 0x0034D520 File Offset: 0x0034B720
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 79275, RefRangeEnd = 79276, XrefRangeStart = 79273, XrefRangeEnd = 79275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CandidateInfo(T candidate, float directionMatch, float distance, float score) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomUIUtils.CandidateInfo<T>>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				IntPtr* ptr2 = ptr;
				T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = candidate;
					if (!(t is string))
					{
						ref T ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref candidate;
				}
				*ptr2 = ref ptr4;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref directionMatch;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomUIUtils.CandidateInfo<T>.NativeMethodInfoPtr__ctor_Public_Void_T_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3FD RID: 54269 RVA: 0x000643F6 File Offset: 0x000625F6
			public CandidateInfo(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004087 RID: 16519
			// (get) Token: 0x0600D3FE RID: 54270 RVA: 0x0034D5E0 File Offset: 0x0034B7E0
			// (set) Token: 0x0600D3FF RID: 54271 RVA: 0x0034D608 File Offset: 0x0034B808
			public unsafe T Candidate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomUIUtils.CandidateInfo<T>.NativeFieldInfoPtr_Candidate);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomUIUtils.CandidateInfo<T>.NativeFieldInfoPtr_Candidate);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase);
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x17004088 RID: 16520
			// (get) Token: 0x0600D400 RID: 54272 RVA: 0x0034D6B0 File Offset: 0x0034B8B0
			// (set) Token: 0x0600D401 RID: 54273 RVA: 0x000643FF File Offset: 0x000625FF
			public unsafe float DirectionMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomUIUtils.CandidateInfo<T>.NativeFieldInfoPtr_DirectionMatch);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomUIUtils.CandidateInfo<T>.NativeFieldInfoPtr_DirectionMatch)) = value;
				}
			}

			// Token: 0x17004089 RID: 16521
			// (get) Token: 0x0600D402 RID: 54274 RVA: 0x0034D6D8 File Offset: 0x0034B8D8
			// (set) Token: 0x0600D403 RID: 54275 RVA: 0x0006441A File Offset: 0x0006261A
			public unsafe float Distance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomUIUtils.CandidateInfo<T>.NativeFieldInfoPtr_Distance);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomUIUtils.CandidateInfo<T>.NativeFieldInfoPtr_Distance)) = value;
				}
			}

			// Token: 0x1700408A RID: 16522
			// (get) Token: 0x0600D404 RID: 54276 RVA: 0x0034D700 File Offset: 0x0034B900
			// (set) Token: 0x0600D405 RID: 54277 RVA: 0x00064435 File Offset: 0x00062635
			public unsafe float Score
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomUIUtils.CandidateInfo<T>.NativeFieldInfoPtr_Score);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomUIUtils.CandidateInfo<T>.NativeFieldInfoPtr_Score)) = value;
				}
			}

			// Token: 0x0400905E RID: 36958
			private static readonly IntPtr NativeFieldInfoPtr_Candidate;

			// Token: 0x0400905F RID: 36959
			private static readonly IntPtr NativeFieldInfoPtr_DirectionMatch;

			// Token: 0x04009060 RID: 36960
			private static readonly IntPtr NativeFieldInfoPtr_Distance;

			// Token: 0x04009061 RID: 36961
			private static readonly IntPtr NativeFieldInfoPtr_Score;

			// Token: 0x04009062 RID: 36962
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_T_Single_Single_Single_0;
		}

		// Token: 0x020008AD RID: 2221
		[ObfuscatedName("ScheduleOne.CustomUIUtils+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D406 RID: 54278 RVA: 0x0034D728 File Offset: 0x0034B928
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CustomUIUtils.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomUIUtils>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomUIUtils.__c>.NativeClassPtr);
				CustomUIUtils.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomUIUtils.__c>.NativeClassPtr, "<>9");
				CustomUIUtils.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomUIUtils.__c>.NativeClassPtr, "<>9__4_0");
				CustomUIUtils.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomUIUtils.__c>.NativeClassPtr, 100664955);
				CustomUIUtils.__c.NativeMethodInfoPtr__GetSelectables_b__4_0_Internal_Boolean_UISelectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomUIUtils.__c>.NativeClassPtr, 100664956);
			}

			// Token: 0x0600D407 RID: 54279 RVA: 0x0034D7A4 File Offset: 0x0034B9A4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomUIUtils.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomUIUtils.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D408 RID: 54280 RVA: 0x0034D7E0 File Offset: 0x0034B9E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79276, XrefRangeEnd = 79278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetSelectables_b__4_0(UISelectable s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomUIUtils.__c.NativeMethodInfoPtr__GetSelectables_b__4_0_Internal_Boolean_UISelectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D409 RID: 54281 RVA: 0x00064450 File Offset: 0x00062650
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700408B RID: 16523
			// (get) Token: 0x0600D40A RID: 54282 RVA: 0x0034D830 File Offset: 0x0034BA30
			// (set) Token: 0x0600D40B RID: 54283 RVA: 0x00064459 File Offset: 0x00062659
			public unsafe static CustomUIUtils.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CustomUIUtils.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomUIUtils.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CustomUIUtils.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700408C RID: 16524
			// (get) Token: 0x0600D40C RID: 54284 RVA: 0x0034D858 File Offset: 0x0034BA58
			// (set) Token: 0x0600D40D RID: 54285 RVA: 0x0006446B File Offset: 0x0006266B
			public unsafe static Func<UISelectable, bool> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CustomUIUtils.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<UISelectable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CustomUIUtils.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009063 RID: 36963
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009064 RID: 36964
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x04009065 RID: 36965
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009066 RID: 36966
			private static readonly IntPtr NativeMethodInfoPtr__GetSelectables_b__4_0_Internal_Boolean_UISelectable_0;
		}

		// Token: 0x020008AE RID: 2222
		private sealed class MethodInfoStoreGeneric_FindBestElementWeighted_Public_Static_T_Vector2_Canvas_T_List_1_T_NavigationSettings_byref_List_1_CandidateInfo_1_T_0<T>
		{
			// Token: 0x04009067 RID: 36967
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CustomUIUtils.NativeMethodInfoPtr_FindBestElementWeighted_Public_Static_T_Vector2_Canvas_T_List_1_T_NavigationSettings_byref_List_1_CandidateInfo_1_T_0, Il2CppClassPointerStore<CustomUIUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
