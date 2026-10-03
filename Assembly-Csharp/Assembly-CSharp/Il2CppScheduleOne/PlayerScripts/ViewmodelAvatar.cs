using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework;
using Il2CppScheduleOne.DevUtilities;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x0200032D RID: 813
	public class ViewmodelAvatar : Singleton<ViewmodelAvatar>
	{
		// Token: 0x06004514 RID: 17684 RVA: 0x00166CE0 File Offset: 0x00164EE0
		// Note: this type is marked as 'beforefieldinit'.
		static ViewmodelAvatar()
		{
			Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "ViewmodelAvatar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr);
			ViewmodelAvatar.NativeFieldInfoPtr__IsVisible_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, "<IsVisible>k__BackingField");
			ViewmodelAvatar.NativeFieldInfoPtr_ArmShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, "ArmShift");
			ViewmodelAvatar.NativeFieldInfoPtr_ParentAvatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, "ParentAvatar");
			ViewmodelAvatar.NativeFieldInfoPtr_Animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, "Animator");
			ViewmodelAvatar.NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, "Avatar");
			ViewmodelAvatar.NativeFieldInfoPtr_RightHandContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, "RightHandContainer");
			ViewmodelAvatar.NativeFieldInfoPtr__leftShoulderDefaultLocalPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, "_leftShoulderDefaultLocalPos");
			ViewmodelAvatar.NativeFieldInfoPtr__rightShoulderDefaultLocalPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, "_rightShoulderDefaultLocalPos");
			ViewmodelAvatar.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, 100672238);
			ViewmodelAvatar.NativeMethodInfoPtr_set_IsVisible_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, 100672239);
			ViewmodelAvatar.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, 100672240);
			ViewmodelAvatar.NativeMethodInfoPtr_SetVisibility_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, 100672241);
			ViewmodelAvatar.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, 100672242);
			ViewmodelAvatar.NativeMethodInfoPtr_SetBoneTransforms_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, 100672243);
			ViewmodelAvatar.NativeMethodInfoPtr_SetAppearance_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, 100672244);
			ViewmodelAvatar.NativeMethodInfoPtr_SetAnimatorController_Public_Void_RuntimeAnimatorController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, 100672245);
			ViewmodelAvatar.NativeMethodInfoPtr_SetOffset_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, 100672246);
			ViewmodelAvatar.NativeMethodInfoPtr_SetRotationOffset_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, 100672247);
			ViewmodelAvatar.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, 100672248);
			ViewmodelAvatar.NativeMethodInfoPtr__Awake_b__11_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, 100672249);
		}

		// Token: 0x170015B3 RID: 5555
		// (get) Token: 0x06004515 RID: 17685 RVA: 0x00166EA0 File Offset: 0x001650A0
		// (set) Token: 0x06004516 RID: 17686 RVA: 0x00166EDC File Offset: 0x001650DC
		public unsafe bool IsVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelAvatar.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 33070, RefRangeEnd = 33090, XrefRangeStart = 33070, XrefRangeEnd = 33090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelAvatar.NativeMethodInfoPtr_set_IsVisible_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004517 RID: 17687 RVA: 0x00166F1C File Offset: 0x0016511C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164343, XrefRangeEnd = 164367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ViewmodelAvatar.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004518 RID: 17688 RVA: 0x00166F58 File Offset: 0x00165158
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 164375, RefRangeEnd = 164380, XrefRangeStart = 164367, XrefRangeEnd = 164375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisibility(bool isVisible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isVisible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelAvatar.NativeMethodInfoPtr_SetVisibility_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004519 RID: 17689 RVA: 0x00166F98 File Offset: 0x00165198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164380, XrefRangeEnd = 164381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelAvatar.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600451A RID: 17690 RVA: 0x00166FCC File Offset: 0x001651CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164394, RefRangeEnd = 164395, XrefRangeStart = 164381, XrefRangeEnd = 164394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBoneTransforms()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelAvatar.NativeMethodInfoPtr_SetBoneTransforms_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600451B RID: 17691 RVA: 0x00167000 File Offset: 0x00165200
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 164425, RefRangeEnd = 164427, XrefRangeStart = 164395, XrefRangeEnd = 164425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAppearance(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelAvatar.NativeMethodInfoPtr_SetAppearance_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600451C RID: 17692 RVA: 0x00167044 File Offset: 0x00165244
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 164429, RefRangeEnd = 164431, XrefRangeStart = 164427, XrefRangeEnd = 164429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAnimatorController(RuntimeAnimatorController controller)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelAvatar.NativeMethodInfoPtr_SetAnimatorController_Public_Void_RuntimeAnimatorController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600451D RID: 17693 RVA: 0x00167088 File Offset: 0x00165288
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 164433, RefRangeEnd = 164435, XrefRangeStart = 164431, XrefRangeEnd = 164433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOffset(Vector3 offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelAvatar.NativeMethodInfoPtr_SetOffset_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600451E RID: 17694 RVA: 0x001670C8 File Offset: 0x001652C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164438, RefRangeEnd = 164439, XrefRangeStart = 164435, XrefRangeEnd = 164438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRotationOffset(Vector3 eulerAngles)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref eulerAngles;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelAvatar.NativeMethodInfoPtr_SetRotationOffset_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600451F RID: 17695 RVA: 0x00167108 File Offset: 0x00165308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164439, XrefRangeEnd = 164442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ViewmodelAvatar() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelAvatar.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004520 RID: 17696 RVA: 0x00167144 File Offset: 0x00165344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164442, XrefRangeEnd = 164444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__11_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelAvatar.NativeMethodInfoPtr__Awake_b__11_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004521 RID: 17697 RVA: 0x00021977 File Offset: 0x0001FB77
		public ViewmodelAvatar(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015AB RID: 5547
		// (get) Token: 0x06004522 RID: 17698 RVA: 0x00167178 File Offset: 0x00165378
		// (set) Token: 0x06004523 RID: 17699 RVA: 0x00021980 File Offset: 0x0001FB80
		public unsafe bool _IsVisible_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr__IsVisible_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr__IsVisible_k__BackingField)) = value;
			}
		}

		// Token: 0x170015AC RID: 5548
		// (get) Token: 0x06004524 RID: 17700 RVA: 0x001671A0 File Offset: 0x001653A0
		// (set) Token: 0x06004525 RID: 17701 RVA: 0x0002199B File Offset: 0x0001FB9B
		public unsafe float ArmShift
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr_ArmShift);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr_ArmShift)) = value;
			}
		}

		// Token: 0x170015AD RID: 5549
		// (get) Token: 0x06004526 RID: 17702 RVA: 0x001671C8 File Offset: 0x001653C8
		// (set) Token: 0x06004527 RID: 17703 RVA: 0x000219B6 File Offset: 0x0001FBB6
		public unsafe Il2CppScheduleOne.AvatarFramework.Avatar ParentAvatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr_ParentAvatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppScheduleOne.AvatarFramework.Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr_ParentAvatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015AE RID: 5550
		// (get) Token: 0x06004528 RID: 17704 RVA: 0x001671F8 File Offset: 0x001653F8
		// (set) Token: 0x06004529 RID: 17705 RVA: 0x000219D5 File Offset: 0x0001FBD5
		public unsafe Animator Animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr_Animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr_Animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015AF RID: 5551
		// (get) Token: 0x0600452A RID: 17706 RVA: 0x00167228 File Offset: 0x00165428
		// (set) Token: 0x0600452B RID: 17707 RVA: 0x000219F4 File Offset: 0x0001FBF4
		public unsafe Il2CppScheduleOne.AvatarFramework.Avatar Avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr_Avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppScheduleOne.AvatarFramework.Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr_Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015B0 RID: 5552
		// (get) Token: 0x0600452C RID: 17708 RVA: 0x00167258 File Offset: 0x00165458
		// (set) Token: 0x0600452D RID: 17709 RVA: 0x00021A13 File Offset: 0x0001FC13
		public unsafe Transform RightHandContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr_RightHandContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr_RightHandContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015B1 RID: 5553
		// (get) Token: 0x0600452E RID: 17710 RVA: 0x00167288 File Offset: 0x00165488
		// (set) Token: 0x0600452F RID: 17711 RVA: 0x00021A32 File Offset: 0x0001FC32
		public unsafe Vector3 _leftShoulderDefaultLocalPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr__leftShoulderDefaultLocalPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr__leftShoulderDefaultLocalPos)) = value;
			}
		}

		// Token: 0x170015B2 RID: 5554
		// (get) Token: 0x06004530 RID: 17712 RVA: 0x001672B0 File Offset: 0x001654B0
		// (set) Token: 0x06004531 RID: 17713 RVA: 0x00021A4D File Offset: 0x0001FC4D
		public unsafe Vector3 _rightShoulderDefaultLocalPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr__rightShoulderDefaultLocalPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr__rightShoulderDefaultLocalPos)) = value;
			}
		}

		// Token: 0x04002F13 RID: 12051
		private static readonly IntPtr NativeFieldInfoPtr__IsVisible_k__BackingField;

		// Token: 0x04002F14 RID: 12052
		private static readonly IntPtr NativeFieldInfoPtr_ArmShift;

		// Token: 0x04002F15 RID: 12053
		private static readonly IntPtr NativeFieldInfoPtr_ParentAvatar;

		// Token: 0x04002F16 RID: 12054
		private static readonly IntPtr NativeFieldInfoPtr_Animator;

		// Token: 0x04002F17 RID: 12055
		private static readonly IntPtr NativeFieldInfoPtr_Avatar;

		// Token: 0x04002F18 RID: 12056
		private static readonly IntPtr NativeFieldInfoPtr_RightHandContainer;

		// Token: 0x04002F19 RID: 12057
		private static readonly IntPtr NativeFieldInfoPtr__leftShoulderDefaultLocalPos;

		// Token: 0x04002F1A RID: 12058
		private static readonly IntPtr NativeFieldInfoPtr__rightShoulderDefaultLocalPos;

		// Token: 0x04002F1B RID: 12059
		private static readonly IntPtr NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0;

		// Token: 0x04002F1C RID: 12060
		private static readonly IntPtr NativeMethodInfoPtr_set_IsVisible_Private_set_Void_Boolean_0;

		// Token: 0x04002F1D RID: 12061
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04002F1E RID: 12062
		private static readonly IntPtr NativeMethodInfoPtr_SetVisibility_Public_Void_Boolean_0;

		// Token: 0x04002F1F RID: 12063
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04002F20 RID: 12064
		private static readonly IntPtr NativeMethodInfoPtr_SetBoneTransforms_Private_Void_0;

		// Token: 0x04002F21 RID: 12065
		private static readonly IntPtr NativeMethodInfoPtr_SetAppearance_Public_Void_AvatarSettings_0;

		// Token: 0x04002F22 RID: 12066
		private static readonly IntPtr NativeMethodInfoPtr_SetAnimatorController_Public_Void_RuntimeAnimatorController_0;

		// Token: 0x04002F23 RID: 12067
		private static readonly IntPtr NativeMethodInfoPtr_SetOffset_Public_Void_Vector3_0;

		// Token: 0x04002F24 RID: 12068
		private static readonly IntPtr NativeMethodInfoPtr_SetRotationOffset_Public_Void_Vector3_0;

		// Token: 0x04002F25 RID: 12069
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002F26 RID: 12070
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__11_0_Private_Void_0;
	}
}
