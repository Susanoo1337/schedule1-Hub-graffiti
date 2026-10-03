using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x0200049D RID: 1181
	public class EyeController : MonoBehaviour
	{
		// Token: 0x06006C0F RID: 27663 RVA: 0x001F10CC File Offset: 0x001EF2CC
		// Note: this type is marked as 'beforefieldinit'.
		static EyeController()
		{
			Il2CppClassPointerStore<EyeController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "EyeController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EyeController>.NativeClassPtr);
			EyeController.NativeFieldInfoPtr_eyeHeightMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "eyeHeightMultiplier");
			EyeController.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "DEBUG");
			EyeController.NativeFieldInfoPtr__EyesOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "<EyesOpen>k__BackingField");
			EyeController.NativeFieldInfoPtr_leftEye = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "leftEye");
			EyeController.NativeFieldInfoPtr_rightEye = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "rightEye");
			EyeController.NativeFieldInfoPtr_eyeSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "eyeSpacing");
			EyeController.NativeFieldInfoPtr_eyeHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "eyeHeight");
			EyeController.NativeFieldInfoPtr_eyeSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "eyeSize");
			EyeController.NativeFieldInfoPtr_LeftRestingEyeState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "LeftRestingEyeState");
			EyeController.NativeFieldInfoPtr_RightRestingEyeState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "RightRestingEyeState");
			EyeController.NativeFieldInfoPtr_eyeBallMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "eyeBallMaterial");
			EyeController.NativeFieldInfoPtr_PupilDilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "PupilDilation");
			EyeController.NativeFieldInfoPtr_BlinkingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "BlinkingEnabled");
			EyeController.NativeFieldInfoPtr_blinkInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "blinkInterval");
			EyeController.NativeFieldInfoPtr_blinkIntervalSpread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "blinkIntervalSpread");
			EyeController.NativeFieldInfoPtr_blinkDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "blinkDuration");
			EyeController.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "avatar");
			EyeController.NativeFieldInfoPtr_blinkRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "blinkRoutine");
			EyeController.NativeFieldInfoPtr_timeUntilNextBlink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "timeUntilNextBlink");
			EyeController.NativeFieldInfoPtr_eyeBallTintOverridden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "eyeBallTintOverridden");
			EyeController.NativeFieldInfoPtr_eyeLidOverridden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "eyeLidOverridden");
			EyeController.NativeFieldInfoPtr_defaultLeftEyeRestingState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "defaultLeftEyeRestingState");
			EyeController.NativeFieldInfoPtr_defaultRightEyeRestingState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "defaultRightEyeRestingState");
			EyeController.NativeFieldInfoPtr_defaultDilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "defaultDilation");
			EyeController.NativeFieldInfoPtr_defaultEyeballColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "defaultEyeballColor");
			EyeController.NativeFieldInfoPtr_currentEyeballColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "currentEyeballColor");
			EyeController.NativeMethodInfoPtr_get_EyesOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100677424);
			EyeController.NativeMethodInfoPtr_set_EyesOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100677425);
			EyeController.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100677426);
			EyeController.NativeMethodInfoPtr_Update_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100677427);
			EyeController.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100677428);
			EyeController.NativeMethodInfoPtr_SetEyeballTint_Public_Void_Color_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100677429);
			EyeController.NativeMethodInfoPtr_ResetEyeballTint_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100677430);
			EyeController.NativeMethodInfoPtr_OverrideEyeLids_Public_Void_EyeLidConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100677431);
			EyeController.NativeMethodInfoPtr_ResetEyeLids_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100677432);
			EyeController.NativeMethodInfoPtr_RagdollChange_Private_Void_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100677433);
			EyeController.NativeMethodInfoPtr_SetEyesOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100677434);
			EyeController.NativeMethodInfoPtr_ApplyDilation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100677435);
			EyeController.NativeMethodInfoPtr_SetPupilDilation_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100677436);
			EyeController.NativeMethodInfoPtr_SetEyeballMaterial_Public_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100677437);
			EyeController.NativeMethodInfoPtr_ResetEyeballMaterial_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100677438);
			EyeController.NativeMethodInfoPtr_ResetPupilDilation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100677439);
			EyeController.NativeMethodInfoPtr_ApplyRestingEyeLidState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100677440);
			EyeController.NativeMethodInfoPtr_ForceBlink_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100677441);
			EyeController.NativeMethodInfoPtr_SetLeftEyeRestingLidState_Public_Void_EyeLidConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100677442);
			EyeController.NativeMethodInfoPtr_SetRightEyeRestingLidState_Public_Void_EyeLidConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100677443);
			EyeController.NativeMethodInfoPtr_BlinkRoutine_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100677444);
			EyeController.NativeMethodInfoPtr_ResetBlinkCounter_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100677445);
			EyeController.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100677446);
			EyeController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100677447);
			EyeController.NativeMethodInfoPtr__BlinkRoutine_b__47_0_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100677449);
		}

		// Token: 0x1700215B RID: 8539
		// (get) Token: 0x06006C10 RID: 27664 RVA: 0x001F14F8 File Offset: 0x001EF6F8
		// (set) Token: 0x06006C11 RID: 27665 RVA: 0x001F1534 File Offset: 0x001EF734
		public unsafe bool EyesOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_get_EyesOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_set_EyesOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006C12 RID: 27666 RVA: 0x001F1574 File Offset: 0x001EF774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221026, XrefRangeEnd = 221043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EyeController.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C13 RID: 27667 RVA: 0x001F15B0 File Offset: 0x001EF7B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221043, XrefRangeEnd = 221058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_Update_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C14 RID: 27668 RVA: 0x001F15E4 File Offset: 0x001EF7E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221058, XrefRangeEnd = 221061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C15 RID: 27669 RVA: 0x001F1618 File Offset: 0x001EF818
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 221063, RefRangeEnd = 221069, XrefRangeStart = 221061, XrefRangeEnd = 221063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEyeballTint(Color col, bool overrideDefault = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideDefault;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_SetEyeballTint_Public_Void_Color_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C16 RID: 27670 RVA: 0x001F1664 File Offset: 0x001EF864
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 221071, RefRangeEnd = 221077, XrefRangeStart = 221069, XrefRangeEnd = 221071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetEyeballTint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_ResetEyeballTint_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C17 RID: 27671 RVA: 0x001F1698 File Offset: 0x001EF898
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 221077, RefRangeEnd = 221086, XrefRangeStart = 221077, XrefRangeEnd = 221077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideEyeLids(Eye.EyeLidConfiguration eyeLidConfiguration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref eyeLidConfiguration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_OverrideEyeLids_Public_Void_EyeLidConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C18 RID: 27672 RVA: 0x001F16D8 File Offset: 0x001EF8D8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 221086, RefRangeEnd = 221098, XrefRangeStart = 221086, XrefRangeEnd = 221086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetEyeLids()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_ResetEyeLids_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C19 RID: 27673 RVA: 0x001F170C File Offset: 0x001EF90C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221098, XrefRangeEnd = 221101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RagdollChange(bool oldValue, bool newValue, bool playStandUpAnim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref oldValue;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playStandUpAnim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_RagdollChange_Private_Void_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C1A RID: 27674 RVA: 0x001F1768 File Offset: 0x001EF968
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 221116, RefRangeEnd = 221118, XrefRangeStart = 221101, XrefRangeEnd = 221116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEyesOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_SetEyesOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C1B RID: 27675 RVA: 0x001F17A8 File Offset: 0x001EF9A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221118, XrefRangeEnd = 221121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyDilation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_ApplyDilation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C1C RID: 27676 RVA: 0x001F17DC File Offset: 0x001EF9DC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 221123, RefRangeEnd = 221130, XrefRangeStart = 221121, XrefRangeEnd = 221123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPupilDilation(float dilation, bool writeDefault = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dilation;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeDefault;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_SetPupilDilation_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C1D RID: 27677 RVA: 0x001F1828 File Offset: 0x001EFA28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221134, RefRangeEnd = 221135, XrefRangeStart = 221130, XrefRangeEnd = 221134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEyeballMaterial(Material material)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_SetEyeballMaterial_Public_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C1E RID: 27678 RVA: 0x001F186C File Offset: 0x001EFA6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 221138, RefRangeEnd = 221141, XrefRangeStart = 221135, XrefRangeEnd = 221138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetEyeballMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_ResetEyeballMaterial_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C1F RID: 27679 RVA: 0x001F18A0 File Offset: 0x001EFAA0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 221143, RefRangeEnd = 221152, XrefRangeStart = 221141, XrefRangeEnd = 221143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetPupilDilation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_ResetPupilDilation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C20 RID: 27680 RVA: 0x001F18D4 File Offset: 0x001EFAD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyRestingEyeLidState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_ApplyRestingEyeLidState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C21 RID: 27681 RVA: 0x001F1908 File Offset: 0x001EFB08
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 221155, RefRangeEnd = 221182, XrefRangeStart = 221152, XrefRangeEnd = 221155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceBlink()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_ForceBlink_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C22 RID: 27682 RVA: 0x001F193C File Offset: 0x001EFB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221182, XrefRangeEnd = 221183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLeftEyeRestingLidState(Eye.EyeLidConfiguration config)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref config;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_SetLeftEyeRestingLidState_Public_Void_EyeLidConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C23 RID: 27683 RVA: 0x001F197C File Offset: 0x001EFB7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221183, XrefRangeEnd = 221184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRightEyeRestingLidState(Eye.EyeLidConfiguration config)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref config;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_SetRightEyeRestingLidState_Public_Void_EyeLidConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C24 RID: 27684 RVA: 0x001F19BC File Offset: 0x001EFBBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221184, XrefRangeEnd = 221189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator BlinkRoutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_BlinkRoutine_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06006C25 RID: 27685 RVA: 0x001F19FC File Offset: 0x001EFBFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221189, XrefRangeEnd = 221190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetBlinkCounter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_ResetBlinkCounter_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C26 RID: 27686 RVA: 0x001F1A30 File Offset: 0x001EFC30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221192, RefRangeEnd = 221193, XrefRangeStart = 221190, XrefRangeEnd = 221192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LookAt(Vector3 position, bool instant = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instant;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C27 RID: 27687 RVA: 0x001F1A7C File Offset: 0x001EFC7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221193, XrefRangeEnd = 221194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EyeController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EyeController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C28 RID: 27688 RVA: 0x001F1AB8 File Offset: 0x001EFCB8
		[CallerCount(0)]
		public unsafe bool _BlinkRoutine_b__47_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr__BlinkRoutine_b__47_0_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006C29 RID: 27689 RVA: 0x00032EB3 File Offset: 0x000310B3
		public EyeController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002141 RID: 8513
		// (get) Token: 0x06006C2A RID: 27690 RVA: 0x001F1AF4 File Offset: 0x001EFCF4
		// (set) Token: 0x06006C2B RID: 27691 RVA: 0x00032EBC File Offset: 0x000310BC
		public unsafe static float eyeHeightMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(EyeController.NativeFieldInfoPtr_eyeHeightMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EyeController.NativeFieldInfoPtr_eyeHeightMultiplier, (void*)(&value));
			}
		}

		// Token: 0x17002142 RID: 8514
		// (get) Token: 0x06006C2C RID: 27692 RVA: 0x001F1B10 File Offset: 0x001EFD10
		// (set) Token: 0x06006C2D RID: 27693 RVA: 0x00032ECA File Offset: 0x000310CA
		public unsafe bool DEBUG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_DEBUG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_DEBUG)) = value;
			}
		}

		// Token: 0x17002143 RID: 8515
		// (get) Token: 0x06006C2E RID: 27694 RVA: 0x001F1B38 File Offset: 0x001EFD38
		// (set) Token: 0x06006C2F RID: 27695 RVA: 0x00032EE5 File Offset: 0x000310E5
		public unsafe bool _EyesOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr__EyesOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr__EyesOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002144 RID: 8516
		// (get) Token: 0x06006C30 RID: 27696 RVA: 0x001F1B60 File Offset: 0x001EFD60
		// (set) Token: 0x06006C31 RID: 27697 RVA: 0x00032F00 File Offset: 0x00031100
		public unsafe Eye leftEye
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_leftEye);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Eye>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_leftEye), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002145 RID: 8517
		// (get) Token: 0x06006C32 RID: 27698 RVA: 0x001F1B90 File Offset: 0x001EFD90
		// (set) Token: 0x06006C33 RID: 27699 RVA: 0x00032F1F File Offset: 0x0003111F
		public unsafe Eye rightEye
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_rightEye);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Eye>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_rightEye), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002146 RID: 8518
		// (get) Token: 0x06006C34 RID: 27700 RVA: 0x001F1BC0 File Offset: 0x001EFDC0
		// (set) Token: 0x06006C35 RID: 27701 RVA: 0x00032F3E File Offset: 0x0003113E
		public unsafe float eyeSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeSpacing)) = value;
			}
		}

		// Token: 0x17002147 RID: 8519
		// (get) Token: 0x06006C36 RID: 27702 RVA: 0x001F1BE8 File Offset: 0x001EFDE8
		// (set) Token: 0x06006C37 RID: 27703 RVA: 0x00032F59 File Offset: 0x00031159
		public unsafe float eyeHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeHeight)) = value;
			}
		}

		// Token: 0x17002148 RID: 8520
		// (get) Token: 0x06006C38 RID: 27704 RVA: 0x001F1C10 File Offset: 0x001EFE10
		// (set) Token: 0x06006C39 RID: 27705 RVA: 0x00032F74 File Offset: 0x00031174
		public unsafe float eyeSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeSize)) = value;
			}
		}

		// Token: 0x17002149 RID: 8521
		// (get) Token: 0x06006C3A RID: 27706 RVA: 0x001F1C38 File Offset: 0x001EFE38
		// (set) Token: 0x06006C3B RID: 27707 RVA: 0x00032F8F File Offset: 0x0003118F
		public unsafe Eye.EyeLidConfiguration LeftRestingEyeState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_LeftRestingEyeState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_LeftRestingEyeState)) = value;
			}
		}

		// Token: 0x1700214A RID: 8522
		// (get) Token: 0x06006C3C RID: 27708 RVA: 0x001F1C60 File Offset: 0x001EFE60
		// (set) Token: 0x06006C3D RID: 27709 RVA: 0x00032FAA File Offset: 0x000311AA
		public unsafe Eye.EyeLidConfiguration RightRestingEyeState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_RightRestingEyeState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_RightRestingEyeState)) = value;
			}
		}

		// Token: 0x1700214B RID: 8523
		// (get) Token: 0x06006C3E RID: 27710 RVA: 0x001F1C88 File Offset: 0x001EFE88
		// (set) Token: 0x06006C3F RID: 27711 RVA: 0x00032FC5 File Offset: 0x000311C5
		public unsafe Material eyeBallMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeBallMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeBallMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700214C RID: 8524
		// (get) Token: 0x06006C40 RID: 27712 RVA: 0x001F1CB8 File Offset: 0x001EFEB8
		// (set) Token: 0x06006C41 RID: 27713 RVA: 0x00032FE4 File Offset: 0x000311E4
		public unsafe float PupilDilation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_PupilDilation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_PupilDilation)) = value;
			}
		}

		// Token: 0x1700214D RID: 8525
		// (get) Token: 0x06006C42 RID: 27714 RVA: 0x001F1CE0 File Offset: 0x001EFEE0
		// (set) Token: 0x06006C43 RID: 27715 RVA: 0x00032FFF File Offset: 0x000311FF
		public unsafe bool BlinkingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_BlinkingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_BlinkingEnabled)) = value;
			}
		}

		// Token: 0x1700214E RID: 8526
		// (get) Token: 0x06006C44 RID: 27716 RVA: 0x001F1D08 File Offset: 0x001EFF08
		// (set) Token: 0x06006C45 RID: 27717 RVA: 0x0003301A File Offset: 0x0003121A
		public unsafe float blinkInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_blinkInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_blinkInterval)) = value;
			}
		}

		// Token: 0x1700214F RID: 8527
		// (get) Token: 0x06006C46 RID: 27718 RVA: 0x001F1D30 File Offset: 0x001EFF30
		// (set) Token: 0x06006C47 RID: 27719 RVA: 0x00033035 File Offset: 0x00031235
		public unsafe float blinkIntervalSpread
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_blinkIntervalSpread);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_blinkIntervalSpread)) = value;
			}
		}

		// Token: 0x17002150 RID: 8528
		// (get) Token: 0x06006C48 RID: 27720 RVA: 0x001F1D58 File Offset: 0x001EFF58
		// (set) Token: 0x06006C49 RID: 27721 RVA: 0x00033050 File Offset: 0x00031250
		public unsafe float blinkDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_blinkDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_blinkDuration)) = value;
			}
		}

		// Token: 0x17002151 RID: 8529
		// (get) Token: 0x06006C4A RID: 27722 RVA: 0x001F1D80 File Offset: 0x001EFF80
		// (set) Token: 0x06006C4B RID: 27723 RVA: 0x0003306B File Offset: 0x0003126B
		public unsafe Avatar avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002152 RID: 8530
		// (get) Token: 0x06006C4C RID: 27724 RVA: 0x001F1DB0 File Offset: 0x001EFFB0
		// (set) Token: 0x06006C4D RID: 27725 RVA: 0x0003308A File Offset: 0x0003128A
		public unsafe Coroutine blinkRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_blinkRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_blinkRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002153 RID: 8531
		// (get) Token: 0x06006C4E RID: 27726 RVA: 0x001F1DE0 File Offset: 0x001EFFE0
		// (set) Token: 0x06006C4F RID: 27727 RVA: 0x000330A9 File Offset: 0x000312A9
		public unsafe float timeUntilNextBlink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_timeUntilNextBlink);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_timeUntilNextBlink)) = value;
			}
		}

		// Token: 0x17002154 RID: 8532
		// (get) Token: 0x06006C50 RID: 27728 RVA: 0x001F1E08 File Offset: 0x001F0008
		// (set) Token: 0x06006C51 RID: 27729 RVA: 0x000330C4 File Offset: 0x000312C4
		public unsafe bool eyeBallTintOverridden
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeBallTintOverridden);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeBallTintOverridden)) = value;
			}
		}

		// Token: 0x17002155 RID: 8533
		// (get) Token: 0x06006C52 RID: 27730 RVA: 0x001F1E30 File Offset: 0x001F0030
		// (set) Token: 0x06006C53 RID: 27731 RVA: 0x000330DF File Offset: 0x000312DF
		public unsafe bool eyeLidOverridden
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeLidOverridden);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeLidOverridden)) = value;
			}
		}

		// Token: 0x17002156 RID: 8534
		// (get) Token: 0x06006C54 RID: 27732 RVA: 0x001F1E58 File Offset: 0x001F0058
		// (set) Token: 0x06006C55 RID: 27733 RVA: 0x000330FA File Offset: 0x000312FA
		public unsafe Eye.EyeLidConfiguration defaultLeftEyeRestingState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_defaultLeftEyeRestingState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_defaultLeftEyeRestingState)) = value;
			}
		}

		// Token: 0x17002157 RID: 8535
		// (get) Token: 0x06006C56 RID: 27734 RVA: 0x001F1E80 File Offset: 0x001F0080
		// (set) Token: 0x06006C57 RID: 27735 RVA: 0x00033115 File Offset: 0x00031315
		public unsafe Eye.EyeLidConfiguration defaultRightEyeRestingState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_defaultRightEyeRestingState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_defaultRightEyeRestingState)) = value;
			}
		}

		// Token: 0x17002158 RID: 8536
		// (get) Token: 0x06006C58 RID: 27736 RVA: 0x001F1EA8 File Offset: 0x001F00A8
		// (set) Token: 0x06006C59 RID: 27737 RVA: 0x00033130 File Offset: 0x00031330
		public unsafe float defaultDilation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_defaultDilation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_defaultDilation)) = value;
			}
		}

		// Token: 0x17002159 RID: 8537
		// (get) Token: 0x06006C5A RID: 27738 RVA: 0x001F1ED0 File Offset: 0x001F00D0
		// (set) Token: 0x06006C5B RID: 27739 RVA: 0x0003314B File Offset: 0x0003134B
		public unsafe Color defaultEyeballColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_defaultEyeballColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_defaultEyeballColor)) = value;
			}
		}

		// Token: 0x1700215A RID: 8538
		// (get) Token: 0x06006C5C RID: 27740 RVA: 0x001F1EF8 File Offset: 0x001F00F8
		// (set) Token: 0x06006C5D RID: 27741 RVA: 0x00033166 File Offset: 0x00031366
		public unsafe Color currentEyeballColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_currentEyeballColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_currentEyeballColor)) = value;
			}
		}

		// Token: 0x04004A4F RID: 19023
		private static readonly IntPtr NativeFieldInfoPtr_eyeHeightMultiplier;

		// Token: 0x04004A50 RID: 19024
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x04004A51 RID: 19025
		private static readonly IntPtr NativeFieldInfoPtr__EyesOpen_k__BackingField;

		// Token: 0x04004A52 RID: 19026
		private static readonly IntPtr NativeFieldInfoPtr_leftEye;

		// Token: 0x04004A53 RID: 19027
		private static readonly IntPtr NativeFieldInfoPtr_rightEye;

		// Token: 0x04004A54 RID: 19028
		private static readonly IntPtr NativeFieldInfoPtr_eyeSpacing;

		// Token: 0x04004A55 RID: 19029
		private static readonly IntPtr NativeFieldInfoPtr_eyeHeight;

		// Token: 0x04004A56 RID: 19030
		private static readonly IntPtr NativeFieldInfoPtr_eyeSize;

		// Token: 0x04004A57 RID: 19031
		private static readonly IntPtr NativeFieldInfoPtr_LeftRestingEyeState;

		// Token: 0x04004A58 RID: 19032
		private static readonly IntPtr NativeFieldInfoPtr_RightRestingEyeState;

		// Token: 0x04004A59 RID: 19033
		private static readonly IntPtr NativeFieldInfoPtr_eyeBallMaterial;

		// Token: 0x04004A5A RID: 19034
		private static readonly IntPtr NativeFieldInfoPtr_PupilDilation;

		// Token: 0x04004A5B RID: 19035
		private static readonly IntPtr NativeFieldInfoPtr_BlinkingEnabled;

		// Token: 0x04004A5C RID: 19036
		private static readonly IntPtr NativeFieldInfoPtr_blinkInterval;

		// Token: 0x04004A5D RID: 19037
		private static readonly IntPtr NativeFieldInfoPtr_blinkIntervalSpread;

		// Token: 0x04004A5E RID: 19038
		private static readonly IntPtr NativeFieldInfoPtr_blinkDuration;

		// Token: 0x04004A5F RID: 19039
		private static readonly IntPtr NativeFieldInfoPtr_avatar;

		// Token: 0x04004A60 RID: 19040
		private static readonly IntPtr NativeFieldInfoPtr_blinkRoutine;

		// Token: 0x04004A61 RID: 19041
		private static readonly IntPtr NativeFieldInfoPtr_timeUntilNextBlink;

		// Token: 0x04004A62 RID: 19042
		private static readonly IntPtr NativeFieldInfoPtr_eyeBallTintOverridden;

		// Token: 0x04004A63 RID: 19043
		private static readonly IntPtr NativeFieldInfoPtr_eyeLidOverridden;

		// Token: 0x04004A64 RID: 19044
		private static readonly IntPtr NativeFieldInfoPtr_defaultLeftEyeRestingState;

		// Token: 0x04004A65 RID: 19045
		private static readonly IntPtr NativeFieldInfoPtr_defaultRightEyeRestingState;

		// Token: 0x04004A66 RID: 19046
		private static readonly IntPtr NativeFieldInfoPtr_defaultDilation;

		// Token: 0x04004A67 RID: 19047
		private static readonly IntPtr NativeFieldInfoPtr_defaultEyeballColor;

		// Token: 0x04004A68 RID: 19048
		private static readonly IntPtr NativeFieldInfoPtr_currentEyeballColor;

		// Token: 0x04004A69 RID: 19049
		private static readonly IntPtr NativeMethodInfoPtr_get_EyesOpen_Public_get_Boolean_0;

		// Token: 0x04004A6A RID: 19050
		private static readonly IntPtr NativeMethodInfoPtr_set_EyesOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04004A6B RID: 19051
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04004A6C RID: 19052
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Void_0;

		// Token: 0x04004A6D RID: 19053
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04004A6E RID: 19054
		private static readonly IntPtr NativeMethodInfoPtr_SetEyeballTint_Public_Void_Color_Boolean_0;

		// Token: 0x04004A6F RID: 19055
		private static readonly IntPtr NativeMethodInfoPtr_ResetEyeballTint_Public_Void_0;

		// Token: 0x04004A70 RID: 19056
		private static readonly IntPtr NativeMethodInfoPtr_OverrideEyeLids_Public_Void_EyeLidConfiguration_0;

		// Token: 0x04004A71 RID: 19057
		private static readonly IntPtr NativeMethodInfoPtr_ResetEyeLids_Public_Void_0;

		// Token: 0x04004A72 RID: 19058
		private static readonly IntPtr NativeMethodInfoPtr_RagdollChange_Private_Void_Boolean_Boolean_Boolean_0;

		// Token: 0x04004A73 RID: 19059
		private static readonly IntPtr NativeMethodInfoPtr_SetEyesOpen_Public_Void_Boolean_0;

		// Token: 0x04004A74 RID: 19060
		private static readonly IntPtr NativeMethodInfoPtr_ApplyDilation_Private_Void_0;

		// Token: 0x04004A75 RID: 19061
		private static readonly IntPtr NativeMethodInfoPtr_SetPupilDilation_Public_Void_Single_Boolean_0;

		// Token: 0x04004A76 RID: 19062
		private static readonly IntPtr NativeMethodInfoPtr_SetEyeballMaterial_Public_Void_Material_0;

		// Token: 0x04004A77 RID: 19063
		private static readonly IntPtr NativeMethodInfoPtr_ResetEyeballMaterial_Public_Void_0;

		// Token: 0x04004A78 RID: 19064
		private static readonly IntPtr NativeMethodInfoPtr_ResetPupilDilation_Public_Void_0;

		// Token: 0x04004A79 RID: 19065
		private static readonly IntPtr NativeMethodInfoPtr_ApplyRestingEyeLidState_Private_Void_0;

		// Token: 0x04004A7A RID: 19066
		private static readonly IntPtr NativeMethodInfoPtr_ForceBlink_Public_Void_0;

		// Token: 0x04004A7B RID: 19067
		private static readonly IntPtr NativeMethodInfoPtr_SetLeftEyeRestingLidState_Public_Void_EyeLidConfiguration_0;

		// Token: 0x04004A7C RID: 19068
		private static readonly IntPtr NativeMethodInfoPtr_SetRightEyeRestingLidState_Public_Void_EyeLidConfiguration_0;

		// Token: 0x04004A7D RID: 19069
		private static readonly IntPtr NativeMethodInfoPtr_BlinkRoutine_Private_IEnumerator_0;

		// Token: 0x04004A7E RID: 19070
		private static readonly IntPtr NativeMethodInfoPtr_ResetBlinkCounter_Private_Void_0;

		// Token: 0x04004A7F RID: 19071
		private static readonly IntPtr NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Boolean_0;

		// Token: 0x04004A80 RID: 19072
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004A81 RID: 19073
		private static readonly IntPtr NativeMethodInfoPtr__BlinkRoutine_b__47_0_Private_Boolean_0;

		// Token: 0x02000B68 RID: 2920
		[ObfuscatedName("ScheduleOne.AvatarFramework.EyeController+<BlinkRoutine>d__47")]
		public sealed class _BlinkRoutine_d__47 : Il2CppSystem.Object
		{
			// Token: 0x0600E867 RID: 59495 RVA: 0x00389630 File Offset: 0x00387830
			// Note: this type is marked as 'beforefieldinit'.
			static _BlinkRoutine_d__47()
			{
				Il2CppClassPointerStore<EyeController._BlinkRoutine_d__47>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "<BlinkRoutine>d__47");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EyeController._BlinkRoutine_d__47>.NativeClassPtr);
				EyeController._BlinkRoutine_d__47.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController._BlinkRoutine_d__47>.NativeClassPtr, "<>1__state");
				EyeController._BlinkRoutine_d__47.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController._BlinkRoutine_d__47>.NativeClassPtr, "<>2__current");
				EyeController._BlinkRoutine_d__47.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController._BlinkRoutine_d__47>.NativeClassPtr, "<>4__this");
				EyeController._BlinkRoutine_d__47.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController._BlinkRoutine_d__47>.NativeClassPtr, 100677450);
				EyeController._BlinkRoutine_d__47.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController._BlinkRoutine_d__47>.NativeClassPtr, 100677451);
				EyeController._BlinkRoutine_d__47.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController._BlinkRoutine_d__47>.NativeClassPtr, 100677452);
				EyeController._BlinkRoutine_d__47.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController._BlinkRoutine_d__47>.NativeClassPtr, 100677453);
				EyeController._BlinkRoutine_d__47.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController._BlinkRoutine_d__47>.NativeClassPtr, 100677454);
				EyeController._BlinkRoutine_d__47.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController._BlinkRoutine_d__47>.NativeClassPtr, 100677455);
			}

			// Token: 0x0600E868 RID: 59496 RVA: 0x00389710 File Offset: 0x00387910
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BlinkRoutine_d__47(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EyeController._BlinkRoutine_d__47>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController._BlinkRoutine_d__47.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E869 RID: 59497 RVA: 0x00389758 File Offset: 0x00387958
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController._BlinkRoutine_d__47.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E86A RID: 59498 RVA: 0x0038978C File Offset: 0x0038798C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221001, XrefRangeEnd = 221021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController._BlinkRoutine_d__47.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004687 RID: 18055
			// (get) Token: 0x0600E86B RID: 59499 RVA: 0x003897C8 File Offset: 0x003879C8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController._BlinkRoutine_d__47.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E86C RID: 59500 RVA: 0x00389808 File Offset: 0x00387A08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221021, XrefRangeEnd = 221026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController._BlinkRoutine_d__47.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004688 RID: 18056
			// (get) Token: 0x0600E86D RID: 59501 RVA: 0x0038983C File Offset: 0x00387A3C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController._BlinkRoutine_d__47.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E86E RID: 59502 RVA: 0x0006D9EC File Offset: 0x0006BBEC
			public _BlinkRoutine_d__47(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004684 RID: 18052
			// (get) Token: 0x0600E86F RID: 59503 RVA: 0x0038987C File Offset: 0x00387A7C
			// (set) Token: 0x0600E870 RID: 59504 RVA: 0x0006D9F5 File Offset: 0x0006BBF5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController._BlinkRoutine_d__47.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController._BlinkRoutine_d__47.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004685 RID: 18053
			// (get) Token: 0x0600E871 RID: 59505 RVA: 0x003898A4 File Offset: 0x00387AA4
			// (set) Token: 0x0600E872 RID: 59506 RVA: 0x0006DA10 File Offset: 0x0006BC10
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController._BlinkRoutine_d__47.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController._BlinkRoutine_d__47.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004686 RID: 18054
			// (get) Token: 0x0600E873 RID: 59507 RVA: 0x003898D4 File Offset: 0x00387AD4
			// (set) Token: 0x0600E874 RID: 59508 RVA: 0x0006DA2F File Offset: 0x0006BC2F
			public unsafe EyeController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController._BlinkRoutine_d__47.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EyeController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController._BlinkRoutine_d__47.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009DA6 RID: 40358
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009DA7 RID: 40359
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009DA8 RID: 40360
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009DA9 RID: 40361
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009DAA RID: 40362
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009DAB RID: 40363
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009DAC RID: 40364
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009DAD RID: 40365
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009DAE RID: 40366
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
