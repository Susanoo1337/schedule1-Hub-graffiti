using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x020003E8 RID: 1000
	public class BirdsEyeView : Singleton<BirdsEyeView>
	{
		// Token: 0x06005909 RID: 22793 RVA: 0x001AEEE8 File Offset: 0x001AD0E8
		// Note: this type is marked as 'beforefieldinit'.
		static BirdsEyeView()
		{
			Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "BirdsEyeView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr);
			BirdsEyeView.NativeFieldInfoPtr_bounds_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "bounds_Min");
			BirdsEyeView.NativeFieldInfoPtr_bounds_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "bounds_Max");
			BirdsEyeView.NativeFieldInfoPtr_lateralMovementSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "lateralMovementSpeed");
			BirdsEyeView.NativeFieldInfoPtr_scrollMovementSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "scrollMovementSpeed");
			BirdsEyeView.NativeFieldInfoPtr_targetFollowSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "targetFollowSpeed");
			BirdsEyeView.NativeFieldInfoPtr_xSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "xSpeed");
			BirdsEyeView.NativeFieldInfoPtr_ySpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "ySpeed");
			BirdsEyeView.NativeFieldInfoPtr_yMinLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "yMinLimit");
			BirdsEyeView.NativeFieldInfoPtr_yMaxLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "yMaxLimit");
			BirdsEyeView.NativeFieldInfoPtr_rotationOriginPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "rotationOriginPoint");
			BirdsEyeView.NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "distance");
			BirdsEyeView.NativeFieldInfoPtr_prevDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "prevDistance");
			BirdsEyeView.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "x");
			BirdsEyeView.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "y");
			BirdsEyeView.NativeFieldInfoPtr_targetTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "targetTransform");
			BirdsEyeView.NativeFieldInfoPtr__isEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "<isEnabled>k__BackingField");
			BirdsEyeView.NativeFieldInfoPtr_originSlideRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "originSlideRoutine");
			BirdsEyeView.NativeMethodInfoPtr_get_playerCam_Private_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100674969);
			BirdsEyeView.NativeMethodInfoPtr_get_isEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100674970);
			BirdsEyeView.NativeMethodInfoPtr_set_isEnabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100674971);
			BirdsEyeView.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100674972);
			BirdsEyeView.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100674973);
			BirdsEyeView.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100674974);
			BirdsEyeView.NativeMethodInfoPtr_Enable_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100674975);
			BirdsEyeView.NativeMethodInfoPtr_Disable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100674976);
			BirdsEyeView.NativeMethodInfoPtr_UpdateLateralMovement_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100674977);
			BirdsEyeView.NativeMethodInfoPtr_UpdateScrollMovement_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100674978);
			BirdsEyeView.NativeMethodInfoPtr_UpdateRotation_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100674979);
			BirdsEyeView.NativeMethodInfoPtr_FinalizeCameraMovement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100674980);
			BirdsEyeView.NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100674981);
			BirdsEyeView.NativeMethodInfoPtr_CancelOriginSlide_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100674982);
			BirdsEyeView.NativeMethodInfoPtr_SlideCameraOrigin_Public_Void_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100674983);
			BirdsEyeView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100674984);
		}

		// Token: 0x17001B81 RID: 7041
		// (get) Token: 0x0600590A RID: 22794 RVA: 0x001AF1AC File Offset: 0x001AD3AC
		public unsafe Transform playerCam
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 193740, RefRangeEnd = 193747, XrefRangeStart = 193734, XrefRangeEnd = 193740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_get_playerCam_Private_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17001B82 RID: 7042
		// (get) Token: 0x0600590B RID: 22795 RVA: 0x001AF1EC File Offset: 0x001AD3EC
		// (set) Token: 0x0600590C RID: 22796 RVA: 0x001AF228 File Offset: 0x001AD428
		public unsafe bool isEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_get_isEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_set_isEnabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600590D RID: 22797 RVA: 0x001AF268 File Offset: 0x001AD468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193747, XrefRangeEnd = 193764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BirdsEyeView.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600590E RID: 22798 RVA: 0x001AF2A4 File Offset: 0x001AD4A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193764, XrefRangeEnd = 193767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BirdsEyeView.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600590F RID: 22799 RVA: 0x001AF2E0 File Offset: 0x001AD4E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193767, XrefRangeEnd = 193768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BirdsEyeView.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005910 RID: 22800 RVA: 0x001AF31C File Offset: 0x001AD51C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193768, XrefRangeEnd = 193781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enable(Vector3 startPosition, Quaternion startRotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref startPosition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startRotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_Enable_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005911 RID: 22801 RVA: 0x001AF368 File Offset: 0x001AD568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193781, XrefRangeEnd = 193790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Disable(bool reenableCameraLook = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref reenableCameraLook;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_Disable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005912 RID: 22802 RVA: 0x001AF3A8 File Offset: 0x001AD5A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193815, RefRangeEnd = 193816, XrefRangeStart = 193790, XrefRangeEnd = 193815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLateralMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_UpdateLateralMovement_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005913 RID: 22803 RVA: 0x001AF3DC File Offset: 0x001AD5DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193830, RefRangeEnd = 193831, XrefRangeStart = 193816, XrefRangeEnd = 193830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateScrollMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_UpdateScrollMovement_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005914 RID: 22804 RVA: 0x001AF410 File Offset: 0x001AD610
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193868, RefRangeEnd = 193869, XrefRangeStart = 193831, XrefRangeEnd = 193868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_UpdateRotation_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005915 RID: 22805 RVA: 0x001AF444 File Offset: 0x001AD644
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193883, RefRangeEnd = 193884, XrefRangeStart = 193869, XrefRangeEnd = 193883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinalizeCameraMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_FinalizeCameraMovement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005916 RID: 22806 RVA: 0x001AF478 File Offset: 0x001AD678
		[CallerCount(0)]
		public unsafe static float ClampAngle(float angle, float min, float max)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref angle;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005917 RID: 22807 RVA: 0x001AF4D4 File Offset: 0x001AD6D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193884, XrefRangeEnd = 193886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelOriginSlide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_CancelOriginSlide_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005918 RID: 22808 RVA: 0x001AF508 File Offset: 0x001AD708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193886, XrefRangeEnd = 193911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SlideCameraOrigin(Vector3 position, float offsetDistance, float time = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetDistance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_SlideCameraOrigin_Public_Void_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005919 RID: 22809 RVA: 0x001AF564 File Offset: 0x001AD764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193911, XrefRangeEnd = 193916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BirdsEyeView() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600591A RID: 22810 RVA: 0x0002A23F File Offset: 0x0002843F
		public BirdsEyeView(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B70 RID: 7024
		// (get) Token: 0x0600591B RID: 22811 RVA: 0x001AF5A0 File Offset: 0x001AD7A0
		// (set) Token: 0x0600591C RID: 22812 RVA: 0x0002A248 File Offset: 0x00028448
		public unsafe Vector3 bounds_Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_bounds_Min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_bounds_Min)) = value;
			}
		}

		// Token: 0x17001B71 RID: 7025
		// (get) Token: 0x0600591D RID: 22813 RVA: 0x001AF5C8 File Offset: 0x001AD7C8
		// (set) Token: 0x0600591E RID: 22814 RVA: 0x0002A263 File Offset: 0x00028463
		public unsafe Vector3 bounds_Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_bounds_Max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_bounds_Max)) = value;
			}
		}

		// Token: 0x17001B72 RID: 7026
		// (get) Token: 0x0600591F RID: 22815 RVA: 0x001AF5F0 File Offset: 0x001AD7F0
		// (set) Token: 0x06005920 RID: 22816 RVA: 0x0002A27E File Offset: 0x0002847E
		public unsafe float lateralMovementSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_lateralMovementSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_lateralMovementSpeed)) = value;
			}
		}

		// Token: 0x17001B73 RID: 7027
		// (get) Token: 0x06005921 RID: 22817 RVA: 0x001AF618 File Offset: 0x001AD818
		// (set) Token: 0x06005922 RID: 22818 RVA: 0x0002A299 File Offset: 0x00028499
		public unsafe float scrollMovementSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_scrollMovementSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_scrollMovementSpeed)) = value;
			}
		}

		// Token: 0x17001B74 RID: 7028
		// (get) Token: 0x06005923 RID: 22819 RVA: 0x001AF640 File Offset: 0x001AD840
		// (set) Token: 0x06005924 RID: 22820 RVA: 0x0002A2B4 File Offset: 0x000284B4
		public unsafe float targetFollowSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_targetFollowSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_targetFollowSpeed)) = value;
			}
		}

		// Token: 0x17001B75 RID: 7029
		// (get) Token: 0x06005925 RID: 22821 RVA: 0x001AF668 File Offset: 0x001AD868
		// (set) Token: 0x06005926 RID: 22822 RVA: 0x0002A2CF File Offset: 0x000284CF
		public unsafe float xSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_xSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_xSpeed)) = value;
			}
		}

		// Token: 0x17001B76 RID: 7030
		// (get) Token: 0x06005927 RID: 22823 RVA: 0x001AF690 File Offset: 0x001AD890
		// (set) Token: 0x06005928 RID: 22824 RVA: 0x0002A2EA File Offset: 0x000284EA
		public unsafe float ySpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_ySpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_ySpeed)) = value;
			}
		}

		// Token: 0x17001B77 RID: 7031
		// (get) Token: 0x06005929 RID: 22825 RVA: 0x001AF6B8 File Offset: 0x001AD8B8
		// (set) Token: 0x0600592A RID: 22826 RVA: 0x0002A305 File Offset: 0x00028505
		public unsafe float yMinLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_yMinLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_yMinLimit)) = value;
			}
		}

		// Token: 0x17001B78 RID: 7032
		// (get) Token: 0x0600592B RID: 22827 RVA: 0x001AF6E0 File Offset: 0x001AD8E0
		// (set) Token: 0x0600592C RID: 22828 RVA: 0x0002A320 File Offset: 0x00028520
		public unsafe float yMaxLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_yMaxLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_yMaxLimit)) = value;
			}
		}

		// Token: 0x17001B79 RID: 7033
		// (get) Token: 0x0600592D RID: 22829 RVA: 0x001AF708 File Offset: 0x001AD908
		// (set) Token: 0x0600592E RID: 22830 RVA: 0x0002A33B File Offset: 0x0002853B
		public unsafe Vector3 rotationOriginPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_rotationOriginPoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_rotationOriginPoint)) = value;
			}
		}

		// Token: 0x17001B7A RID: 7034
		// (get) Token: 0x0600592F RID: 22831 RVA: 0x001AF730 File Offset: 0x001AD930
		// (set) Token: 0x06005930 RID: 22832 RVA: 0x0002A356 File Offset: 0x00028556
		public unsafe float distance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_distance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_distance)) = value;
			}
		}

		// Token: 0x17001B7B RID: 7035
		// (get) Token: 0x06005931 RID: 22833 RVA: 0x001AF758 File Offset: 0x001AD958
		// (set) Token: 0x06005932 RID: 22834 RVA: 0x0002A371 File Offset: 0x00028571
		public unsafe float prevDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_prevDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_prevDistance)) = value;
			}
		}

		// Token: 0x17001B7C RID: 7036
		// (get) Token: 0x06005933 RID: 22835 RVA: 0x001AF780 File Offset: 0x001AD980
		// (set) Token: 0x06005934 RID: 22836 RVA: 0x0002A38C File Offset: 0x0002858C
		public unsafe float x
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_x);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_x)) = value;
			}
		}

		// Token: 0x17001B7D RID: 7037
		// (get) Token: 0x06005935 RID: 22837 RVA: 0x001AF7A8 File Offset: 0x001AD9A8
		// (set) Token: 0x06005936 RID: 22838 RVA: 0x0002A3A7 File Offset: 0x000285A7
		public unsafe float y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_y);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_y)) = value;
			}
		}

		// Token: 0x17001B7E RID: 7038
		// (get) Token: 0x06005937 RID: 22839 RVA: 0x001AF7D0 File Offset: 0x001AD9D0
		// (set) Token: 0x06005938 RID: 22840 RVA: 0x0002A3C2 File Offset: 0x000285C2
		public unsafe Transform targetTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_targetTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_targetTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B7F RID: 7039
		// (get) Token: 0x06005939 RID: 22841 RVA: 0x001AF800 File Offset: 0x001ADA00
		// (set) Token: 0x0600593A RID: 22842 RVA: 0x0002A3E1 File Offset: 0x000285E1
		public unsafe bool _isEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr__isEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr__isEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17001B80 RID: 7040
		// (get) Token: 0x0600593B RID: 22843 RVA: 0x001AF828 File Offset: 0x001ADA28
		// (set) Token: 0x0600593C RID: 22844 RVA: 0x0002A3FC File Offset: 0x000285FC
		public unsafe Coroutine originSlideRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_originSlideRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_originSlideRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003D2A RID: 15658
		private static readonly IntPtr NativeFieldInfoPtr_bounds_Min;

		// Token: 0x04003D2B RID: 15659
		private static readonly IntPtr NativeFieldInfoPtr_bounds_Max;

		// Token: 0x04003D2C RID: 15660
		private static readonly IntPtr NativeFieldInfoPtr_lateralMovementSpeed;

		// Token: 0x04003D2D RID: 15661
		private static readonly IntPtr NativeFieldInfoPtr_scrollMovementSpeed;

		// Token: 0x04003D2E RID: 15662
		private static readonly IntPtr NativeFieldInfoPtr_targetFollowSpeed;

		// Token: 0x04003D2F RID: 15663
		private static readonly IntPtr NativeFieldInfoPtr_xSpeed;

		// Token: 0x04003D30 RID: 15664
		private static readonly IntPtr NativeFieldInfoPtr_ySpeed;

		// Token: 0x04003D31 RID: 15665
		private static readonly IntPtr NativeFieldInfoPtr_yMinLimit;

		// Token: 0x04003D32 RID: 15666
		private static readonly IntPtr NativeFieldInfoPtr_yMaxLimit;

		// Token: 0x04003D33 RID: 15667
		private static readonly IntPtr NativeFieldInfoPtr_rotationOriginPoint;

		// Token: 0x04003D34 RID: 15668
		private static readonly IntPtr NativeFieldInfoPtr_distance;

		// Token: 0x04003D35 RID: 15669
		private static readonly IntPtr NativeFieldInfoPtr_prevDistance;

		// Token: 0x04003D36 RID: 15670
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x04003D37 RID: 15671
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04003D38 RID: 15672
		private static readonly IntPtr NativeFieldInfoPtr_targetTransform;

		// Token: 0x04003D39 RID: 15673
		private static readonly IntPtr NativeFieldInfoPtr__isEnabled_k__BackingField;

		// Token: 0x04003D3A RID: 15674
		private static readonly IntPtr NativeFieldInfoPtr_originSlideRoutine;

		// Token: 0x04003D3B RID: 15675
		private static readonly IntPtr NativeMethodInfoPtr_get_playerCam_Private_get_Transform_0;

		// Token: 0x04003D3C RID: 15676
		private static readonly IntPtr NativeMethodInfoPtr_get_isEnabled_Public_get_Boolean_0;

		// Token: 0x04003D3D RID: 15677
		private static readonly IntPtr NativeMethodInfoPtr_set_isEnabled_Protected_set_Void_Boolean_0;

		// Token: 0x04003D3E RID: 15678
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04003D3F RID: 15679
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04003D40 RID: 15680
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04003D41 RID: 15681
		private static readonly IntPtr NativeMethodInfoPtr_Enable_Public_Void_Vector3_Quaternion_0;

		// Token: 0x04003D42 RID: 15682
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Void_Boolean_0;

		// Token: 0x04003D43 RID: 15683
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLateralMovement_Protected_Void_0;

		// Token: 0x04003D44 RID: 15684
		private static readonly IntPtr NativeMethodInfoPtr_UpdateScrollMovement_Protected_Void_0;

		// Token: 0x04003D45 RID: 15685
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRotation_Protected_Void_0;

		// Token: 0x04003D46 RID: 15686
		private static readonly IntPtr NativeMethodInfoPtr_FinalizeCameraMovement_Private_Void_0;

		// Token: 0x04003D47 RID: 15687
		private static readonly IntPtr NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0;

		// Token: 0x04003D48 RID: 15688
		private static readonly IntPtr NativeMethodInfoPtr_CancelOriginSlide_Private_Void_0;

		// Token: 0x04003D49 RID: 15689
		private static readonly IntPtr NativeMethodInfoPtr_SlideCameraOrigin_Public_Void_Vector3_Single_Single_0;

		// Token: 0x04003D4A RID: 15690
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000ADD RID: 2781
		[ObfuscatedName("ScheduleOne.DevUtilities.BirdsEyeView+<>c__DisplayClass33_0")]
		public sealed class __c__DisplayClass33_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E4BC RID: 58556 RVA: 0x0037F0D0 File Offset: 0x0037D2D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass33_0()
			{
				Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "<>c__DisplayClass33_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0>.NativeClassPtr);
				BirdsEyeView.__c__DisplayClass33_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0>.NativeClassPtr, "<>4__this");
				BirdsEyeView.__c__DisplayClass33_0.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0>.NativeClassPtr, "position");
				BirdsEyeView.__c__DisplayClass33_0.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0>.NativeClassPtr, "time");
				BirdsEyeView.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0>.NativeClassPtr, 100674985);
				BirdsEyeView.__c__DisplayClass33_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0>.NativeClassPtr, 100674986);
			}

			// Token: 0x0600E4BD RID: 58557 RVA: 0x0037F160 File Offset: 0x0037D360
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass33_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E4BE RID: 58558 RVA: 0x0037F19C File Offset: 0x0037D39C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193729, XrefRangeEnd = 193734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.__c__DisplayClass33_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E4BF RID: 58559 RVA: 0x0006BD86 File Offset: 0x00069F86
			public __c__DisplayClass33_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700458B RID: 17803
			// (get) Token: 0x0600E4C0 RID: 58560 RVA: 0x0037F1DC File Offset: 0x0037D3DC
			// (set) Token: 0x0600E4C1 RID: 58561 RVA: 0x0006BD8F File Offset: 0x00069F8F
			public unsafe BirdsEyeView __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BirdsEyeView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700458C RID: 17804
			// (get) Token: 0x0600E4C2 RID: 58562 RVA: 0x0037F20C File Offset: 0x0037D40C
			// (set) Token: 0x0600E4C3 RID: 58563 RVA: 0x0006BDAE File Offset: 0x00069FAE
			public unsafe Vector3 position
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.NativeFieldInfoPtr_position);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.NativeFieldInfoPtr_position)) = value;
				}
			}

			// Token: 0x1700458D RID: 17805
			// (get) Token: 0x0600E4C4 RID: 58564 RVA: 0x0037F234 File Offset: 0x0037D434
			// (set) Token: 0x0600E4C5 RID: 58565 RVA: 0x0006BDC9 File Offset: 0x00069FC9
			public unsafe float time
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.NativeFieldInfoPtr_time);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.NativeFieldInfoPtr_time)) = value;
				}
			}

			// Token: 0x04009B51 RID: 39761
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009B52 RID: 39762
			private static readonly IntPtr NativeFieldInfoPtr_position;

			// Token: 0x04009B53 RID: 39763
			private static readonly IntPtr NativeFieldInfoPtr_time;

			// Token: 0x04009B54 RID: 39764
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009B55 RID: 39765
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000DD2 RID: 3538
			[ObfuscatedName("ScheduleOne.DevUtilities.BirdsEyeView+<>c__DisplayClass33_0+<<SlideCameraOrigin>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600FF58 RID: 65368 RVA: 0x003CB938 File Offset: 0x003C9B38
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique()
				{
					Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0>.NativeClassPtr, "<<SlideCameraOrigin>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr);
					BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr, "<>1__state");
					BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr, "<>2__current");
					BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr, "<>4__this");
					BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr__startPosition_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr, "<startPosition>5__2");
					BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr, "<i>5__3");
					BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr, 100674987);
					BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr, 100674988);
					BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr, 100674989);
					BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr, 100674990);
					BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr, 100674991);
					BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr, 100674992);
				}

				// Token: 0x0600FF59 RID: 65369 RVA: 0x003CBA40 File Offset: 0x003C9C40
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FF5A RID: 65370 RVA: 0x003CBA88 File Offset: 0x003C9C88
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FF5B RID: 65371 RVA: 0x003CBABC File Offset: 0x003C9CBC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193713, XrefRangeEnd = 193724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004DBC RID: 19900
				// (get) Token: 0x0600FF5C RID: 65372 RVA: 0x003CBAF8 File Offset: 0x003C9CF8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FF5D RID: 65373 RVA: 0x003CBB38 File Offset: 0x003C9D38
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193724, XrefRangeEnd = 193729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004DBD RID: 19901
				// (get) Token: 0x0600FF5E RID: 65374 RVA: 0x003CBB6C File Offset: 0x003C9D6C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FF5F RID: 65375 RVA: 0x00078F97 File Offset: 0x00077197
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004DB7 RID: 19895
				// (get) Token: 0x0600FF60 RID: 65376 RVA: 0x003CBBAC File Offset: 0x003C9DAC
				// (set) Token: 0x0600FF61 RID: 65377 RVA: 0x00078FA0 File Offset: 0x000771A0
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004DB8 RID: 19896
				// (get) Token: 0x0600FF62 RID: 65378 RVA: 0x003CBBD4 File Offset: 0x003C9DD4
				// (set) Token: 0x0600FF63 RID: 65379 RVA: 0x00078FBB File Offset: 0x000771BB
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004DB9 RID: 19897
				// (get) Token: 0x0600FF64 RID: 65380 RVA: 0x003CBC04 File Offset: 0x003C9E04
				// (set) Token: 0x0600FF65 RID: 65381 RVA: 0x00078FDA File Offset: 0x000771DA
				public unsafe BirdsEyeView.__c__DisplayClass33_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<BirdsEyeView.__c__DisplayClass33_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004DBA RID: 19898
				// (get) Token: 0x0600FF66 RID: 65382 RVA: 0x003CBC34 File Offset: 0x003C9E34
				// (set) Token: 0x0600FF67 RID: 65383 RVA: 0x00078FF9 File Offset: 0x000771F9
				public unsafe Vector3 _startPosition_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr__startPosition_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr__startPosition_5__2)) = value;
					}
				}

				// Token: 0x17004DBB RID: 19899
				// (get) Token: 0x0600FF68 RID: 65384 RVA: 0x003CBC5C File Offset: 0x003C9E5C
				// (set) Token: 0x0600FF69 RID: 65385 RVA: 0x00079014 File Offset: 0x00077214
				public unsafe float _i_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr__i_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
					}
				}

				// Token: 0x0400AC0D RID: 44045
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AC0E RID: 44046
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AC0F RID: 44047
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AC10 RID: 44048
				private static readonly IntPtr NativeFieldInfoPtr__startPosition_5__2;

				// Token: 0x0400AC11 RID: 44049
				private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

				// Token: 0x0400AC12 RID: 44050
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AC13 RID: 44051
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AC14 RID: 44052
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AC15 RID: 44053
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AC16 RID: 44054
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AC17 RID: 44055
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
