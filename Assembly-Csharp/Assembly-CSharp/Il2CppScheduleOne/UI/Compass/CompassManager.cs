using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Compass
{
	// Token: 0x02000815 RID: 2069
	public class CompassManager : Singleton<CompassManager>
	{
		// Token: 0x0600C8F2 RID: 51442 RVA: 0x0032BFE8 File Offset: 0x0032A1E8
		// Note: this type is marked as 'beforefieldinit'.
		static CompassManager()
		{
			Il2CppClassPointerStore<CompassManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Compass", "CompassManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompassManager>.NativeClassPtr);
			CompassManager.NativeFieldInfoPtr_NOTCH_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "NOTCH_COUNT");
			CompassManager.NativeFieldInfoPtr_DISTANCE_LABEL_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "DISTANCE_LABEL_THRESHOLD");
			CompassManager.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "Container");
			CompassManager.NativeFieldInfoPtr_NotchUIContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "NotchUIContainer");
			CompassManager.NativeFieldInfoPtr_ElementUIContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "ElementUIContainer");
			CompassManager.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "Canvas");
			CompassManager.NativeFieldInfoPtr_DirectionIndicatorPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "DirectionIndicatorPrefab");
			CompassManager.NativeFieldInfoPtr_NotchPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "NotchPrefab");
			CompassManager.NativeFieldInfoPtr_ElementPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "ElementPrefab");
			CompassManager.NativeFieldInfoPtr_CompassEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "CompassEnabled");
			CompassManager.NativeFieldInfoPtr_ElementContentSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "ElementContentSize");
			CompassManager.NativeFieldInfoPtr_CompassUIRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "CompassUIRange");
			CompassManager.NativeFieldInfoPtr_FullAlphaRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "FullAlphaRange");
			CompassManager.NativeFieldInfoPtr_AngleDivisor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "AngleDivisor");
			CompassManager.NativeFieldInfoPtr_ClosedYPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "ClosedYPos");
			CompassManager.NativeFieldInfoPtr_OpenYPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "OpenYPos");
			CompassManager.NativeFieldInfoPtr_notchPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "notchPositions");
			CompassManager.NativeFieldInfoPtr_notches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "notches");
			CompassManager.NativeFieldInfoPtr_elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "elements");
			CompassManager.NativeFieldInfoPtr_lerpContainerPositionCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "lerpContainerPositionCoroutine");
			CompassManager.NativeMethodInfoPtr_get_cam_Private_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100689232);
			CompassManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100689233);
			CompassManager.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100689234);
			CompassManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100689235);
			CompassManager.NativeMethodInfoPtr_SetCompassEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100689236);
			CompassManager.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100689237);
			CompassManager.NativeMethodInfoPtr_UpdateNotches_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100689238);
			CompassManager.NativeMethodInfoPtr_UpdateElements_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100689239);
			CompassManager.NativeMethodInfoPtr_UpdateElement_Private_Void_Element_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100689240);
			CompassManager.NativeMethodInfoPtr_GetCompassData_Public_Void_Vector3_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100689241);
			CompassManager.NativeMethodInfoPtr_AddElement_Public_Element_Transform_RectTransform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100689242);
			CompassManager.NativeMethodInfoPtr_RemoveElement_Public_Void_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100689243);
			CompassManager.NativeMethodInfoPtr_RemoveElement_Public_Void_Element_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100689244);
			CompassManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100689245);
			CompassManager.NativeMethodInfoPtr_Method_Private_IEnumerator_Single_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100689246);
		}

		// Token: 0x17003D16 RID: 15638
		// (get) Token: 0x0600C8F3 RID: 51443 RVA: 0x0032C2D4 File Offset: 0x0032A4D4
		public unsafe Transform cam
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 331068, RefRangeEnd = 331071, XrefRangeStart = 331062, XrefRangeEnd = 331068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_get_cam_Private_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x0600C8F4 RID: 51444 RVA: 0x0032C314 File Offset: 0x0032A514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331071, XrefRangeEnd = 331132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompassManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C8F5 RID: 51445 RVA: 0x0032C350 File Offset: 0x0032A550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331132, XrefRangeEnd = 331142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C8F6 RID: 51446 RVA: 0x0032C384 File Offset: 0x0032A584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331142, XrefRangeEnd = 331161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C8F7 RID: 51447 RVA: 0x0032C3B8 File Offset: 0x0032A5B8
		[CallerCount(0)]
		public unsafe void SetCompassEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_SetCompassEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C8F8 RID: 51448 RVA: 0x0032C3F8 File Offset: 0x0032A5F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 331169, RefRangeEnd = 331170, XrefRangeStart = 331161, XrefRangeEnd = 331169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C8F9 RID: 51449 RVA: 0x0032C438 File Offset: 0x0032A638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331170, XrefRangeEnd = 331180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateNotches()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_UpdateNotches_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C8FA RID: 51450 RVA: 0x0032C46C File Offset: 0x0032A66C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 331208, RefRangeEnd = 331209, XrefRangeStart = 331180, XrefRangeEnd = 331208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateElements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_UpdateElements_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C8FB RID: 51451 RVA: 0x0032C4A0 File Offset: 0x0032A6A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 331228, RefRangeEnd = 331229, XrefRangeStart = 331209, XrefRangeEnd = 331228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateElement(CompassManager.Element element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_UpdateElement_Private_Void_Element_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C8FC RID: 51452 RVA: 0x0032C4E4 File Offset: 0x0032A6E4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 331245, RefRangeEnd = 331249, XrefRangeStart = 331229, XrefRangeEnd = 331245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetCompassData(Vector3 worldPosition, out float xPos, out float alpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldPosition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &xPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &alpha;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_GetCompassData_Public_Void_Vector3_byref_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C8FD RID: 51453 RVA: 0x0032C540 File Offset: 0x0032A740
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 331294, RefRangeEnd = 331296, XrefRangeStart = 331249, XrefRangeEnd = 331294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompassManager.Element AddElement(Transform transform, RectTransform contentPrefab, bool visible = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contentPrefab);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_AddElement_Public_Element_Transform_RectTransform_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CompassManager.Element>(intPtr3) : null;
		}

		// Token: 0x0600C8FE RID: 51454 RVA: 0x0032C5B0 File Offset: 0x0032A7B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331296, XrefRangeEnd = 331308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveElement(Transform transform, bool alsoDestroyRect = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alsoDestroyRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_RemoveElement_Public_Void_Transform_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C8FF RID: 51455 RVA: 0x0032C600 File Offset: 0x0032A800
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 331317, RefRangeEnd = 331318, XrefRangeStart = 331308, XrefRangeEnd = 331317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveElement(CompassManager.Element el, bool alsoDestroyRect = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(el);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alsoDestroyRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_RemoveElement_Public_Void_Element_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C900 RID: 51456 RVA: 0x0032C650 File Offset: 0x0032A850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331318, XrefRangeEnd = 331342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompassManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompassManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C901 RID: 51457 RVA: 0x0032C68C File Offset: 0x0032A88C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331342, XrefRangeEnd = 331347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_Single_Boolean_PDM_0(float yPos, bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref yPos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_Method_Private_IEnumerator_Single_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600C902 RID: 51458 RVA: 0x0005F21A File Offset: 0x0005D41A
		public CompassManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003D02 RID: 15618
		// (get) Token: 0x0600C903 RID: 51459 RVA: 0x0032C6E8 File Offset: 0x0032A8E8
		// (set) Token: 0x0600C904 RID: 51460 RVA: 0x0005F223 File Offset: 0x0005D423
		public unsafe static int NOTCH_COUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CompassManager.NativeFieldInfoPtr_NOTCH_COUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompassManager.NativeFieldInfoPtr_NOTCH_COUNT, (void*)(&value));
			}
		}

		// Token: 0x17003D03 RID: 15619
		// (get) Token: 0x0600C905 RID: 51461 RVA: 0x0032C704 File Offset: 0x0032A904
		// (set) Token: 0x0600C906 RID: 51462 RVA: 0x0005F231 File Offset: 0x0005D431
		public unsafe static float DISTANCE_LABEL_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CompassManager.NativeFieldInfoPtr_DISTANCE_LABEL_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompassManager.NativeFieldInfoPtr_DISTANCE_LABEL_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17003D04 RID: 15620
		// (get) Token: 0x0600C907 RID: 51463 RVA: 0x0032C720 File Offset: 0x0032A920
		// (set) Token: 0x0600C908 RID: 51464 RVA: 0x0005F23F File Offset: 0x0005D43F
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D05 RID: 15621
		// (get) Token: 0x0600C909 RID: 51465 RVA: 0x0032C750 File Offset: 0x0032A950
		// (set) Token: 0x0600C90A RID: 51466 RVA: 0x0005F25E File Offset: 0x0005D45E
		public unsafe RectTransform NotchUIContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_NotchUIContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_NotchUIContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D06 RID: 15622
		// (get) Token: 0x0600C90B RID: 51467 RVA: 0x0032C780 File Offset: 0x0032A980
		// (set) Token: 0x0600C90C RID: 51468 RVA: 0x0005F27D File Offset: 0x0005D47D
		public unsafe RectTransform ElementUIContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_ElementUIContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_ElementUIContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D07 RID: 15623
		// (get) Token: 0x0600C90D RID: 51469 RVA: 0x0032C7B0 File Offset: 0x0032A9B0
		// (set) Token: 0x0600C90E RID: 51470 RVA: 0x0005F29C File Offset: 0x0005D49C
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D08 RID: 15624
		// (get) Token: 0x0600C90F RID: 51471 RVA: 0x0032C7E0 File Offset: 0x0032A9E0
		// (set) Token: 0x0600C910 RID: 51472 RVA: 0x0005F2BB File Offset: 0x0005D4BB
		public unsafe GameObject DirectionIndicatorPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_DirectionIndicatorPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_DirectionIndicatorPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D09 RID: 15625
		// (get) Token: 0x0600C911 RID: 51473 RVA: 0x0032C810 File Offset: 0x0032AA10
		// (set) Token: 0x0600C912 RID: 51474 RVA: 0x0005F2DA File Offset: 0x0005D4DA
		public unsafe GameObject NotchPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_NotchPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_NotchPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D0A RID: 15626
		// (get) Token: 0x0600C913 RID: 51475 RVA: 0x0032C840 File Offset: 0x0032AA40
		// (set) Token: 0x0600C914 RID: 51476 RVA: 0x0005F2F9 File Offset: 0x0005D4F9
		public unsafe GameObject ElementPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_ElementPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_ElementPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D0B RID: 15627
		// (get) Token: 0x0600C915 RID: 51477 RVA: 0x0032C870 File Offset: 0x0032AA70
		// (set) Token: 0x0600C916 RID: 51478 RVA: 0x0005F318 File Offset: 0x0005D518
		public unsafe bool CompassEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_CompassEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_CompassEnabled)) = value;
			}
		}

		// Token: 0x17003D0C RID: 15628
		// (get) Token: 0x0600C917 RID: 51479 RVA: 0x0032C898 File Offset: 0x0032AA98
		// (set) Token: 0x0600C918 RID: 51480 RVA: 0x0005F333 File Offset: 0x0005D533
		public unsafe Vector2 ElementContentSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_ElementContentSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_ElementContentSize)) = value;
			}
		}

		// Token: 0x17003D0D RID: 15629
		// (get) Token: 0x0600C919 RID: 51481 RVA: 0x0032C8C0 File Offset: 0x0032AAC0
		// (set) Token: 0x0600C91A RID: 51482 RVA: 0x0005F34E File Offset: 0x0005D54E
		public unsafe float CompassUIRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_CompassUIRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_CompassUIRange)) = value;
			}
		}

		// Token: 0x17003D0E RID: 15630
		// (get) Token: 0x0600C91B RID: 51483 RVA: 0x0032C8E8 File Offset: 0x0032AAE8
		// (set) Token: 0x0600C91C RID: 51484 RVA: 0x0005F369 File Offset: 0x0005D569
		public unsafe float FullAlphaRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_FullAlphaRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_FullAlphaRange)) = value;
			}
		}

		// Token: 0x17003D0F RID: 15631
		// (get) Token: 0x0600C91D RID: 51485 RVA: 0x0032C910 File Offset: 0x0032AB10
		// (set) Token: 0x0600C91E RID: 51486 RVA: 0x0005F384 File Offset: 0x0005D584
		public unsafe float AngleDivisor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_AngleDivisor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_AngleDivisor)) = value;
			}
		}

		// Token: 0x17003D10 RID: 15632
		// (get) Token: 0x0600C91F RID: 51487 RVA: 0x0032C938 File Offset: 0x0032AB38
		// (set) Token: 0x0600C920 RID: 51488 RVA: 0x0005F39F File Offset: 0x0005D59F
		public unsafe float ClosedYPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_ClosedYPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_ClosedYPos)) = value;
			}
		}

		// Token: 0x17003D11 RID: 15633
		// (get) Token: 0x0600C921 RID: 51489 RVA: 0x0032C960 File Offset: 0x0032AB60
		// (set) Token: 0x0600C922 RID: 51490 RVA: 0x0005F3BA File Offset: 0x0005D5BA
		public unsafe float OpenYPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_OpenYPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_OpenYPos)) = value;
			}
		}

		// Token: 0x17003D12 RID: 15634
		// (get) Token: 0x0600C923 RID: 51491 RVA: 0x0032C988 File Offset: 0x0032AB88
		// (set) Token: 0x0600C924 RID: 51492 RVA: 0x0005F3D5 File Offset: 0x0005D5D5
		public unsafe List<Vector3> notchPositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_notchPositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_notchPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D13 RID: 15635
		// (get) Token: 0x0600C925 RID: 51493 RVA: 0x0032C9B8 File Offset: 0x0032ABB8
		// (set) Token: 0x0600C926 RID: 51494 RVA: 0x0005F3F4 File Offset: 0x0005D5F4
		public unsafe List<CompassManager.Notch> notches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_notches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CompassManager.Notch>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_notches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D14 RID: 15636
		// (get) Token: 0x0600C927 RID: 51495 RVA: 0x0032C9E8 File Offset: 0x0032ABE8
		// (set) Token: 0x0600C928 RID: 51496 RVA: 0x0005F413 File Offset: 0x0005D613
		public unsafe List<CompassManager.Element> elements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_elements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CompassManager.Element>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_elements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D15 RID: 15637
		// (get) Token: 0x0600C929 RID: 51497 RVA: 0x0032CA18 File Offset: 0x0032AC18
		// (set) Token: 0x0600C92A RID: 51498 RVA: 0x0005F432 File Offset: 0x0005D632
		public unsafe Coroutine lerpContainerPositionCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_lerpContainerPositionCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_lerpContainerPositionCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040088EA RID: 35050
		private static readonly IntPtr NativeFieldInfoPtr_NOTCH_COUNT;

		// Token: 0x040088EB RID: 35051
		private static readonly IntPtr NativeFieldInfoPtr_DISTANCE_LABEL_THRESHOLD;

		// Token: 0x040088EC RID: 35052
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040088ED RID: 35053
		private static readonly IntPtr NativeFieldInfoPtr_NotchUIContainer;

		// Token: 0x040088EE RID: 35054
		private static readonly IntPtr NativeFieldInfoPtr_ElementUIContainer;

		// Token: 0x040088EF RID: 35055
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x040088F0 RID: 35056
		private static readonly IntPtr NativeFieldInfoPtr_DirectionIndicatorPrefab;

		// Token: 0x040088F1 RID: 35057
		private static readonly IntPtr NativeFieldInfoPtr_NotchPrefab;

		// Token: 0x040088F2 RID: 35058
		private static readonly IntPtr NativeFieldInfoPtr_ElementPrefab;

		// Token: 0x040088F3 RID: 35059
		private static readonly IntPtr NativeFieldInfoPtr_CompassEnabled;

		// Token: 0x040088F4 RID: 35060
		private static readonly IntPtr NativeFieldInfoPtr_ElementContentSize;

		// Token: 0x040088F5 RID: 35061
		private static readonly IntPtr NativeFieldInfoPtr_CompassUIRange;

		// Token: 0x040088F6 RID: 35062
		private static readonly IntPtr NativeFieldInfoPtr_FullAlphaRange;

		// Token: 0x040088F7 RID: 35063
		private static readonly IntPtr NativeFieldInfoPtr_AngleDivisor;

		// Token: 0x040088F8 RID: 35064
		private static readonly IntPtr NativeFieldInfoPtr_ClosedYPos;

		// Token: 0x040088F9 RID: 35065
		private static readonly IntPtr NativeFieldInfoPtr_OpenYPos;

		// Token: 0x040088FA RID: 35066
		private static readonly IntPtr NativeFieldInfoPtr_notchPositions;

		// Token: 0x040088FB RID: 35067
		private static readonly IntPtr NativeFieldInfoPtr_notches;

		// Token: 0x040088FC RID: 35068
		private static readonly IntPtr NativeFieldInfoPtr_elements;

		// Token: 0x040088FD RID: 35069
		private static readonly IntPtr NativeFieldInfoPtr_lerpContainerPositionCoroutine;

		// Token: 0x040088FE RID: 35070
		private static readonly IntPtr NativeMethodInfoPtr_get_cam_Private_get_Transform_0;

		// Token: 0x040088FF RID: 35071
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04008900 RID: 35072
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04008901 RID: 35073
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04008902 RID: 35074
		private static readonly IntPtr NativeMethodInfoPtr_SetCompassEnabled_Public_Void_Boolean_0;

		// Token: 0x04008903 RID: 35075
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0;

		// Token: 0x04008904 RID: 35076
		private static readonly IntPtr NativeMethodInfoPtr_UpdateNotches_Private_Void_0;

		// Token: 0x04008905 RID: 35077
		private static readonly IntPtr NativeMethodInfoPtr_UpdateElements_Private_Void_0;

		// Token: 0x04008906 RID: 35078
		private static readonly IntPtr NativeMethodInfoPtr_UpdateElement_Private_Void_Element_0;

		// Token: 0x04008907 RID: 35079
		private static readonly IntPtr NativeMethodInfoPtr_GetCompassData_Public_Void_Vector3_byref_Single_byref_Single_0;

		// Token: 0x04008908 RID: 35080
		private static readonly IntPtr NativeMethodInfoPtr_AddElement_Public_Element_Transform_RectTransform_Boolean_0;

		// Token: 0x04008909 RID: 35081
		private static readonly IntPtr NativeMethodInfoPtr_RemoveElement_Public_Void_Transform_Boolean_0;

		// Token: 0x0400890A RID: 35082
		private static readonly IntPtr NativeMethodInfoPtr_RemoveElement_Public_Void_Element_Boolean_0;

		// Token: 0x0400890B RID: 35083
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400890C RID: 35084
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_Single_Boolean_PDM_0;

		// Token: 0x02000D76 RID: 3446
		public class Notch : Il2CppSystem.Object
		{
			// Token: 0x0600FB6E RID: 64366 RVA: 0x003C05D0 File Offset: 0x003BE7D0
			// Note: this type is marked as 'beforefieldinit'.
			static Notch()
			{
				Il2CppClassPointerStore<CompassManager.Notch>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "Notch");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompassManager.Notch>.NativeClassPtr);
				CompassManager.Notch.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.Notch>.NativeClassPtr, "Rect");
				CompassManager.Notch.NativeFieldInfoPtr_Group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.Notch>.NativeClassPtr, "Group");
				CompassManager.Notch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager.Notch>.NativeClassPtr, 100689247);
			}

			// Token: 0x0600FB6F RID: 64367 RVA: 0x003C0638 File Offset: 0x003BE838
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Notch() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompassManager.Notch>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.Notch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FB70 RID: 64368 RVA: 0x00076FF6 File Offset: 0x000751F6
			public Notch(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C64 RID: 19556
			// (get) Token: 0x0600FB71 RID: 64369 RVA: 0x003C0674 File Offset: 0x003BE874
			// (set) Token: 0x0600FB72 RID: 64370 RVA: 0x00076FFF File Offset: 0x000751FF
			public unsafe RectTransform Rect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Notch.NativeFieldInfoPtr_Rect);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Notch.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C65 RID: 19557
			// (get) Token: 0x0600FB73 RID: 64371 RVA: 0x003C06A4 File Offset: 0x003BE8A4
			// (set) Token: 0x0600FB74 RID: 64372 RVA: 0x0007701E File Offset: 0x0007521E
			public unsafe CanvasGroup Group
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Notch.NativeFieldInfoPtr_Group);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Notch.NativeFieldInfoPtr_Group), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A9A2 RID: 43426
			private static readonly IntPtr NativeFieldInfoPtr_Rect;

			// Token: 0x0400A9A3 RID: 43427
			private static readonly IntPtr NativeFieldInfoPtr_Group;

			// Token: 0x0400A9A4 RID: 43428
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000D77 RID: 3447
		public class Element : Il2CppSystem.Object
		{
			// Token: 0x0600FB75 RID: 64373 RVA: 0x003C06D4 File Offset: 0x003BE8D4
			// Note: this type is marked as 'beforefieldinit'.
			static Element()
			{
				Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "Element");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr);
				CompassManager.Element.NativeFieldInfoPtr_LastState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr, "LastState");
				CompassManager.Element.NativeFieldInfoPtr__Rect_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr, "<Rect>k__BackingField");
				CompassManager.Element.NativeFieldInfoPtr__Group_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr, "<Group>k__BackingField");
				CompassManager.Element.NativeFieldInfoPtr__DistanceLabel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr, "<DistanceLabel>k__BackingField");
				CompassManager.Element.NativeFieldInfoPtr__TargetTransform_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr, "<TargetTransform>k__BackingField");
				CompassManager.Element.NativeFieldInfoPtr_go = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr, "go");
				CompassManager.Element.NativeMethodInfoPtr_get_Visible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr, 100689248);
				CompassManager.Element.NativeMethodInfoPtr_set_Visible_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr, 100689249);
				CompassManager.Element.NativeMethodInfoPtr_get_Rect_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr, 100689250);
				CompassManager.Element.NativeMethodInfoPtr_set_Rect_Private_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr, 100689251);
				CompassManager.Element.NativeMethodInfoPtr_get_Group_Public_get_CanvasGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr, 100689252);
				CompassManager.Element.NativeMethodInfoPtr_set_Group_Private_set_Void_CanvasGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr, 100689253);
				CompassManager.Element.NativeMethodInfoPtr_get_DistanceLabel_Public_get_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr, 100689254);
				CompassManager.Element.NativeMethodInfoPtr_set_DistanceLabel_Private_set_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr, 100689255);
				CompassManager.Element.NativeMethodInfoPtr_get_TargetTransform_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr, 100689256);
				CompassManager.Element.NativeMethodInfoPtr_set_TargetTransform_Private_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr, 100689257);
				CompassManager.Element.NativeMethodInfoPtr__ctor_Public_Void_RectTransform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr, 100689258);
				CompassManager.Element.NativeMethodInfoPtr_SetTarget_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr, 100689259);
			}

			// Token: 0x17004C6C RID: 19564
			// (get) Token: 0x0600FB76 RID: 64374 RVA: 0x003C0868 File Offset: 0x003BEA68
			// (set) Token: 0x0600FB77 RID: 64375 RVA: 0x003C08A4 File Offset: 0x003BEAA4
			public unsafe bool Visible
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331026, XrefRangeEnd = 331028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.Element.NativeMethodInfoPtr_get_Visible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 331030, RefRangeEnd = 331031, XrefRangeStart = 331028, XrefRangeEnd = 331030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.Element.NativeMethodInfoPtr_set_Visible_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17004C6D RID: 19565
			// (get) Token: 0x0600FB78 RID: 64376 RVA: 0x003C08E4 File Offset: 0x003BEAE4
			// (set) Token: 0x0600FB79 RID: 64377 RVA: 0x003C0924 File Offset: 0x003BEB24
			public unsafe RectTransform Rect
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.Element.NativeMethodInfoPtr_get_Rect_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.Element.NativeMethodInfoPtr_set_Rect_Private_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17004C6E RID: 19566
			// (get) Token: 0x0600FB7A RID: 64378 RVA: 0x003C0968 File Offset: 0x003BEB68
			// (set) Token: 0x0600FB7B RID: 64379 RVA: 0x003C09A8 File Offset: 0x003BEBA8
			public unsafe CanvasGroup Group
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.Element.NativeMethodInfoPtr_get_Group_Public_get_CanvasGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.Element.NativeMethodInfoPtr_set_Group_Private_set_Void_CanvasGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17004C6F RID: 19567
			// (get) Token: 0x0600FB7C RID: 64380 RVA: 0x003C09EC File Offset: 0x003BEBEC
			// (set) Token: 0x0600FB7D RID: 64381 RVA: 0x003C0A2C File Offset: 0x003BEC2C
			public unsafe TextMeshProUGUI DistanceLabel
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.Element.NativeMethodInfoPtr_get_DistanceLabel_Public_get_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.Element.NativeMethodInfoPtr_set_DistanceLabel_Private_set_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17004C70 RID: 19568
			// (get) Token: 0x0600FB7E RID: 64382 RVA: 0x003C0A70 File Offset: 0x003BEC70
			// (set) Token: 0x0600FB7F RID: 64383 RVA: 0x003C0AB0 File Offset: 0x003BECB0
			public unsafe Transform TargetTransform
			{
				[CallerCount(13)]
				[CachedScanResults(RefRangeStart = 2964, RefRangeEnd = 2977, XrefRangeStart = 2964, XrefRangeEnd = 2977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.Element.NativeMethodInfoPtr_get_TargetTransform_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
				}
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 2978, RefRangeEnd = 2980, XrefRangeStart = 2978, XrefRangeEnd = 2980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.Element.NativeMethodInfoPtr_set_TargetTransform_Private_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600FB80 RID: 64384 RVA: 0x003C0AF4 File Offset: 0x003BECF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331031, XrefRangeEnd = 331048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Element(RectTransform rect, Transform transform) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.Element.NativeMethodInfoPtr__ctor_Public_Void_RectTransform_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FB81 RID: 64385 RVA: 0x003C0B54 File Offset: 0x003BED54
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 2978, RefRangeEnd = 2980, XrefRangeStart = 2978, XrefRangeEnd = 2980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetTarget(Transform transform)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.Element.NativeMethodInfoPtr_SetTarget_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FB82 RID: 64386 RVA: 0x0007703D File Offset: 0x0007523D
			public Element(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C66 RID: 19558
			// (get) Token: 0x0600FB83 RID: 64387 RVA: 0x003C0B98 File Offset: 0x003BED98
			// (set) Token: 0x0600FB84 RID: 64388 RVA: 0x00077046 File Offset: 0x00075246
			public unsafe bool LastState
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Element.NativeFieldInfoPtr_LastState);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Element.NativeFieldInfoPtr_LastState)) = value;
				}
			}

			// Token: 0x17004C67 RID: 19559
			// (get) Token: 0x0600FB85 RID: 64389 RVA: 0x003C0BC0 File Offset: 0x003BEDC0
			// (set) Token: 0x0600FB86 RID: 64390 RVA: 0x00077061 File Offset: 0x00075261
			public unsafe RectTransform _Rect_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Element.NativeFieldInfoPtr__Rect_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Element.NativeFieldInfoPtr__Rect_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C68 RID: 19560
			// (get) Token: 0x0600FB87 RID: 64391 RVA: 0x003C0BF0 File Offset: 0x003BEDF0
			// (set) Token: 0x0600FB88 RID: 64392 RVA: 0x00077080 File Offset: 0x00075280
			public unsafe CanvasGroup _Group_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Element.NativeFieldInfoPtr__Group_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Element.NativeFieldInfoPtr__Group_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C69 RID: 19561
			// (get) Token: 0x0600FB89 RID: 64393 RVA: 0x003C0C20 File Offset: 0x003BEE20
			// (set) Token: 0x0600FB8A RID: 64394 RVA: 0x0007709F File Offset: 0x0007529F
			public unsafe TextMeshProUGUI _DistanceLabel_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Element.NativeFieldInfoPtr__DistanceLabel_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Element.NativeFieldInfoPtr__DistanceLabel_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C6A RID: 19562
			// (get) Token: 0x0600FB8B RID: 64395 RVA: 0x003C0C50 File Offset: 0x003BEE50
			// (set) Token: 0x0600FB8C RID: 64396 RVA: 0x000770BE File Offset: 0x000752BE
			public unsafe Transform _TargetTransform_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Element.NativeFieldInfoPtr__TargetTransform_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Element.NativeFieldInfoPtr__TargetTransform_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C6B RID: 19563
			// (get) Token: 0x0600FB8D RID: 64397 RVA: 0x003C0C80 File Offset: 0x003BEE80
			// (set) Token: 0x0600FB8E RID: 64398 RVA: 0x000770DD File Offset: 0x000752DD
			public unsafe GameObject go
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Element.NativeFieldInfoPtr_go);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Element.NativeFieldInfoPtr_go), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A9A5 RID: 43429
			private static readonly IntPtr NativeFieldInfoPtr_LastState;

			// Token: 0x0400A9A6 RID: 43430
			private static readonly IntPtr NativeFieldInfoPtr__Rect_k__BackingField;

			// Token: 0x0400A9A7 RID: 43431
			private static readonly IntPtr NativeFieldInfoPtr__Group_k__BackingField;

			// Token: 0x0400A9A8 RID: 43432
			private static readonly IntPtr NativeFieldInfoPtr__DistanceLabel_k__BackingField;

			// Token: 0x0400A9A9 RID: 43433
			private static readonly IntPtr NativeFieldInfoPtr__TargetTransform_k__BackingField;

			// Token: 0x0400A9AA RID: 43434
			private static readonly IntPtr NativeFieldInfoPtr_go;

			// Token: 0x0400A9AB RID: 43435
			private static readonly IntPtr NativeMethodInfoPtr_get_Visible_Public_get_Boolean_0;

			// Token: 0x0400A9AC RID: 43436
			private static readonly IntPtr NativeMethodInfoPtr_set_Visible_Public_set_Void_Boolean_0;

			// Token: 0x0400A9AD RID: 43437
			private static readonly IntPtr NativeMethodInfoPtr_get_Rect_Public_get_RectTransform_0;

			// Token: 0x0400A9AE RID: 43438
			private static readonly IntPtr NativeMethodInfoPtr_set_Rect_Private_set_Void_RectTransform_0;

			// Token: 0x0400A9AF RID: 43439
			private static readonly IntPtr NativeMethodInfoPtr_get_Group_Public_get_CanvasGroup_0;

			// Token: 0x0400A9B0 RID: 43440
			private static readonly IntPtr NativeMethodInfoPtr_set_Group_Private_set_Void_CanvasGroup_0;

			// Token: 0x0400A9B1 RID: 43441
			private static readonly IntPtr NativeMethodInfoPtr_get_DistanceLabel_Public_get_TextMeshProUGUI_0;

			// Token: 0x0400A9B2 RID: 43442
			private static readonly IntPtr NativeMethodInfoPtr_set_DistanceLabel_Private_set_Void_TextMeshProUGUI_0;

			// Token: 0x0400A9B3 RID: 43443
			private static readonly IntPtr NativeMethodInfoPtr_get_TargetTransform_Public_get_Transform_0;

			// Token: 0x0400A9B4 RID: 43444
			private static readonly IntPtr NativeMethodInfoPtr_set_TargetTransform_Private_set_Void_Transform_0;

			// Token: 0x0400A9B5 RID: 43445
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RectTransform_Transform_0;

			// Token: 0x0400A9B6 RID: 43446
			private static readonly IntPtr NativeMethodInfoPtr_SetTarget_Public_Void_Transform_0;
		}

		// Token: 0x02000D78 RID: 3448
		[ObfuscatedName("ScheduleOne.UI.Compass.CompassManager+<<SetVisible>g__LerpContainerPosition|28_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique : Il2CppSystem.Object
		{
			// Token: 0x0600FB8F RID: 64399 RVA: 0x003C0CB0 File Offset: 0x003BEEB0
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique()
			{
				Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "<<SetVisible>g__LerpContainerPosition|28_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr);
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, "<>1__state");
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, "<>2__current");
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr_visible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, "visible");
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, "<>4__this");
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr_yPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, "yPos");
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr__t_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, "<t>5__2");
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr__startPos_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, "<startPos>5__3");
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr__endPos_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, "<endPos>5__4");
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, 100689260);
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, 100689261);
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, 100689262);
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, 100689263);
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, 100689264);
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, 100689265);
			}

			// Token: 0x0600FB90 RID: 64400 RVA: 0x003C0DF4 File Offset: 0x003BEFF4
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FB91 RID: 64401 RVA: 0x003C0E3C File Offset: 0x003BF03C
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FB92 RID: 64402 RVA: 0x003C0E70 File Offset: 0x003BF070
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331048, XrefRangeEnd = 331057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004C79 RID: 19577
			// (get) Token: 0x0600FB93 RID: 64403 RVA: 0x003C0EAC File Offset: 0x003BF0AC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600FB94 RID: 64404 RVA: 0x003C0EEC File Offset: 0x003BF0EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331057, XrefRangeEnd = 331062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004C7A RID: 19578
			// (get) Token: 0x0600FB95 RID: 64405 RVA: 0x003C0F20 File Offset: 0x003BF120
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600FB96 RID: 64406 RVA: 0x000770FC File Offset: 0x000752FC
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C71 RID: 19569
			// (get) Token: 0x0600FB97 RID: 64407 RVA: 0x003C0F60 File Offset: 0x003BF160
			// (set) Token: 0x0600FB98 RID: 64408 RVA: 0x00077105 File Offset: 0x00075305
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004C72 RID: 19570
			// (get) Token: 0x0600FB99 RID: 64409 RVA: 0x003C0F88 File Offset: 0x003BF188
			// (set) Token: 0x0600FB9A RID: 64410 RVA: 0x00077120 File Offset: 0x00075320
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C73 RID: 19571
			// (get) Token: 0x0600FB9B RID: 64411 RVA: 0x003C0FB8 File Offset: 0x003BF1B8
			// (set) Token: 0x0600FB9C RID: 64412 RVA: 0x0007713F File Offset: 0x0007533F
			public unsafe bool visible
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr_visible);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr_visible)) = value;
				}
			}

			// Token: 0x17004C74 RID: 19572
			// (get) Token: 0x0600FB9D RID: 64413 RVA: 0x003C0FE0 File Offset: 0x003BF1E0
			// (set) Token: 0x0600FB9E RID: 64414 RVA: 0x0007715A File Offset: 0x0007535A
			public unsafe CompassManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompassManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C75 RID: 19573
			// (get) Token: 0x0600FB9F RID: 64415 RVA: 0x003C1010 File Offset: 0x003BF210
			// (set) Token: 0x0600FBA0 RID: 64416 RVA: 0x00077179 File Offset: 0x00075379
			public unsafe float yPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr_yPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr_yPos)) = value;
				}
			}

			// Token: 0x17004C76 RID: 19574
			// (get) Token: 0x0600FBA1 RID: 64417 RVA: 0x003C1038 File Offset: 0x003BF238
			// (set) Token: 0x0600FBA2 RID: 64418 RVA: 0x00077194 File Offset: 0x00075394
			public unsafe float _t_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr__t_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr__t_5__2)) = value;
				}
			}

			// Token: 0x17004C77 RID: 19575
			// (get) Token: 0x0600FBA3 RID: 64419 RVA: 0x003C1060 File Offset: 0x003BF260
			// (set) Token: 0x0600FBA4 RID: 64420 RVA: 0x000771AF File Offset: 0x000753AF
			public unsafe Vector2 _startPos_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr__startPos_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr__startPos_5__3)) = value;
				}
			}

			// Token: 0x17004C78 RID: 19576
			// (get) Token: 0x0600FBA5 RID: 64421 RVA: 0x003C1088 File Offset: 0x003BF288
			// (set) Token: 0x0600FBA6 RID: 64422 RVA: 0x000771CA File Offset: 0x000753CA
			public unsafe Vector2 _endPos_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr__endPos_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr__endPos_5__4)) = value;
				}
			}

			// Token: 0x0400A9B7 RID: 43447
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A9B8 RID: 43448
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A9B9 RID: 43449
			private static readonly IntPtr NativeFieldInfoPtr_visible;

			// Token: 0x0400A9BA RID: 43450
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A9BB RID: 43451
			private static readonly IntPtr NativeFieldInfoPtr_yPos;

			// Token: 0x0400A9BC RID: 43452
			private static readonly IntPtr NativeFieldInfoPtr__t_5__2;

			// Token: 0x0400A9BD RID: 43453
			private static readonly IntPtr NativeFieldInfoPtr__startPos_5__3;

			// Token: 0x0400A9BE RID: 43454
			private static readonly IntPtr NativeFieldInfoPtr__endPos_5__4;

			// Token: 0x0400A9BF RID: 43455
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A9C0 RID: 43456
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A9C1 RID: 43457
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A9C2 RID: 43458
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A9C3 RID: 43459
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A9C4 RID: 43460
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
