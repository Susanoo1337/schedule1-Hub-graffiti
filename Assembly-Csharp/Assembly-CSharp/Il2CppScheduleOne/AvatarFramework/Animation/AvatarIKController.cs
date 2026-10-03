using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRootMotion.FinalIK;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Animation
{
	// Token: 0x020004BC RID: 1212
	public class AvatarIKController : MonoBehaviour
	{
		// Token: 0x06006F07 RID: 28423 RVA: 0x001F97BC File Offset: 0x001F79BC
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarIKController()
		{
			Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Animation", "AvatarIKController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr);
			AvatarIKController.NativeFieldInfoPtr_BodyIK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr, "BodyIK");
			AvatarIKController.NativeFieldInfoPtr_defaultLeftLegBendTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr, "defaultLeftLegBendTarget");
			AvatarIKController.NativeFieldInfoPtr_defaultRightLegBendTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr, "defaultRightLegBendTarget");
			AvatarIKController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr, 100677712);
			AvatarIKController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr, 100677713);
			AvatarIKController.NativeMethodInfoPtr_SetIKActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr, 100677714);
			AvatarIKController.NativeMethodInfoPtr_OverrideLegBendTargets_Public_Void_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr, 100677715);
			AvatarIKController.NativeMethodInfoPtr_ResetLegBendTargets_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr, 100677716);
			AvatarIKController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr, 100677717);
		}

		// Token: 0x06006F08 RID: 28424 RVA: 0x001F98A0 File Offset: 0x001F7AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223481, XrefRangeEnd = 223485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarIKController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F09 RID: 28425 RVA: 0x001F98D4 File Offset: 0x001F7AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223485, XrefRangeEnd = 223487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarIKController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F0A RID: 28426 RVA: 0x001F9908 File Offset: 0x001F7B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223487, XrefRangeEnd = 223489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIKActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarIKController.NativeMethodInfoPtr_SetIKActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F0B RID: 28427 RVA: 0x001F9948 File Offset: 0x001F7B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223489, XrefRangeEnd = 223492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideLegBendTargets(Transform leftLegTarget, Transform rightLegTarget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(leftLegTarget);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rightLegTarget);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarIKController.NativeMethodInfoPtr_OverrideLegBendTargets_Public_Void_Transform_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F0C RID: 28428 RVA: 0x001F999C File Offset: 0x001F7B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223492, XrefRangeEnd = 223495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetLegBendTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarIKController.NativeMethodInfoPtr_ResetLegBendTargets_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F0D RID: 28429 RVA: 0x001F99D0 File Offset: 0x001F7BD0
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarIKController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarIKController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F0E RID: 28430 RVA: 0x0003497F File Offset: 0x00032B7F
		public AvatarIKController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002245 RID: 8773
		// (get) Token: 0x06006F0F RID: 28431 RVA: 0x001F9A0C File Offset: 0x001F7C0C
		// (set) Token: 0x06006F10 RID: 28432 RVA: 0x00034988 File Offset: 0x00032B88
		public unsafe BipedIK BodyIK
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarIKController.NativeFieldInfoPtr_BodyIK);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BipedIK>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarIKController.NativeFieldInfoPtr_BodyIK), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002246 RID: 8774
		// (get) Token: 0x06006F11 RID: 28433 RVA: 0x001F9A3C File Offset: 0x001F7C3C
		// (set) Token: 0x06006F12 RID: 28434 RVA: 0x000349A7 File Offset: 0x00032BA7
		public unsafe Transform defaultLeftLegBendTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarIKController.NativeFieldInfoPtr_defaultLeftLegBendTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarIKController.NativeFieldInfoPtr_defaultLeftLegBendTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002247 RID: 8775
		// (get) Token: 0x06006F13 RID: 28435 RVA: 0x001F9A6C File Offset: 0x001F7C6C
		// (set) Token: 0x06006F14 RID: 28436 RVA: 0x000349C6 File Offset: 0x00032BC6
		public unsafe Transform defaultRightLegBendTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarIKController.NativeFieldInfoPtr_defaultRightLegBendTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarIKController.NativeFieldInfoPtr_defaultRightLegBendTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004C17 RID: 19479
		private static readonly IntPtr NativeFieldInfoPtr_BodyIK;

		// Token: 0x04004C18 RID: 19480
		private static readonly IntPtr NativeFieldInfoPtr_defaultLeftLegBendTarget;

		// Token: 0x04004C19 RID: 19481
		private static readonly IntPtr NativeFieldInfoPtr_defaultRightLegBendTarget;

		// Token: 0x04004C1A RID: 19482
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004C1B RID: 19483
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004C1C RID: 19484
		private static readonly IntPtr NativeMethodInfoPtr_SetIKActive_Public_Void_Boolean_0;

		// Token: 0x04004C1D RID: 19485
		private static readonly IntPtr NativeMethodInfoPtr_OverrideLegBendTargets_Public_Void_Transform_Transform_0;

		// Token: 0x04004C1E RID: 19486
		private static readonly IntPtr NativeMethodInfoPtr_ResetLegBendTargets_Public_Void_0;

		// Token: 0x04004C1F RID: 19487
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
