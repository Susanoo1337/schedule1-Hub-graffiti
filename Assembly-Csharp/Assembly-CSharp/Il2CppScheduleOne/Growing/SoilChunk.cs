using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerTasks;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x02000522 RID: 1314
	public class SoilChunk : Clickable
	{
		// Token: 0x0600777E RID: 30590 RVA: 0x00213A40 File Offset: 0x00211C40
		// Note: this type is marked as 'beforefieldinit'.
		static SoilChunk()
		{
			Il2CppClassPointerStore<SoilChunk>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "SoilChunk");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr);
			SoilChunk.NativeFieldInfoPtr__CurrentLerp_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, "<CurrentLerp>k__BackingField");
			SoilChunk.NativeFieldInfoPtr_EndTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, "EndTransform");
			SoilChunk.NativeFieldInfoPtr_LerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, "LerpTime");
			SoilChunk.NativeFieldInfoPtr_localPos_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, "localPos_Start");
			SoilChunk.NativeFieldInfoPtr_localEulerAngles_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, "localEulerAngles_Start");
			SoilChunk.NativeFieldInfoPtr_localScale_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, "localScale_Start");
			SoilChunk.NativeFieldInfoPtr_lerpRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, "lerpRoutine");
			SoilChunk.NativeFieldInfoPtr__collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, "_collider");
			SoilChunk.NativeFieldInfoPtr__LurePositionOffset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, "<LurePositionOffset>k__BackingField");
			SoilChunk.NativeMethodInfoPtr_get_CurrentLerp_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, 100678650);
			SoilChunk.NativeMethodInfoPtr_set_CurrentLerp_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, 100678651);
			SoilChunk.NativeMethodInfoPtr_get_RegisterDefaultLureWhenEmpty_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, 100678652);
			SoilChunk.NativeMethodInfoPtr_get_LurePositionOffset_Protected_Virtual_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, 100678653);
			SoilChunk.NativeMethodInfoPtr_set_LurePositionOffset_Protected_Virtual_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, 100678654);
			SoilChunk.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, 100678655);
			SoilChunk.NativeMethodInfoPtr_SetLerpedTransform_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, 100678656);
			SoilChunk.NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, 100678657);
			SoilChunk.NativeMethodInfoPtr_StopLerp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, 100678658);
			SoilChunk.NativeMethodInfoPtr_SetChunkClickable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, 100678659);
			SoilChunk.NativeMethodInfoPtr_SetColliderEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, 100678660);
			SoilChunk.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, 100678661);
			SoilChunk.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, 100678662);
		}

		// Token: 0x170024F9 RID: 9465
		// (get) Token: 0x0600777F RID: 30591 RVA: 0x00213C28 File Offset: 0x00211E28
		// (set) Token: 0x06007780 RID: 30592 RVA: 0x00213C64 File Offset: 0x00211E64
		public unsafe float CurrentLerp
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.NativeMethodInfoPtr_get_CurrentLerp_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.NativeMethodInfoPtr_set_CurrentLerp_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170024FA RID: 9466
		// (get) Token: 0x06007781 RID: 30593 RVA: 0x00213CA4 File Offset: 0x00211EA4
		public unsafe override bool RegisterDefaultLureWhenEmpty
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 29255, RefRangeEnd = 29273, XrefRangeStart = 29255, XrefRangeEnd = 29273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoilChunk.NativeMethodInfoPtr_get_RegisterDefaultLureWhenEmpty_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170024FB RID: 9467
		// (get) Token: 0x06007782 RID: 30594 RVA: 0x00213CEC File Offset: 0x00211EEC
		// (set) Token: 0x06007783 RID: 30595 RVA: 0x00213D34 File Offset: 0x00211F34
		public unsafe override Vector3 LurePositionOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoilChunk.NativeMethodInfoPtr_get_LurePositionOffset_Protected_Virtual_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoilChunk.NativeMethodInfoPtr_set_LurePositionOffset_Protected_Virtual_set_Void_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007784 RID: 30596 RVA: 0x00213D80 File Offset: 0x00211F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231198, XrefRangeEnd = 231209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoilChunk.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007785 RID: 30597 RVA: 0x00213DBC File Offset: 0x00211FBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 231224, RefRangeEnd = 231226, XrefRangeStart = 231209, XrefRangeEnd = 231224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLerpedTransform(float _lerp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _lerp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.NativeMethodInfoPtr_SetLerpedTransform_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007786 RID: 30598 RVA: 0x00213DFC File Offset: 0x00211FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231226, XrefRangeEnd = 231240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartClick(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoilChunk.NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007787 RID: 30599 RVA: 0x00213E48 File Offset: 0x00212048
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 231241, RefRangeEnd = 231242, XrefRangeStart = 231240, XrefRangeEnd = 231241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopLerp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.NativeMethodInfoPtr_StopLerp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007788 RID: 30600 RVA: 0x00213E7C File Offset: 0x0021207C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 231247, RefRangeEnd = 231251, XrefRangeStart = 231242, XrefRangeEnd = 231247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetChunkClickable(bool clickable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref clickable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.NativeMethodInfoPtr_SetChunkClickable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007789 RID: 30601 RVA: 0x00213EBC File Offset: 0x002120BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 231261, RefRangeEnd = 231264, XrefRangeStart = 231251, XrefRangeEnd = 231261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColliderEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.NativeMethodInfoPtr_SetColliderEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600778A RID: 30602 RVA: 0x00213EFC File Offset: 0x002120FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231264, XrefRangeEnd = 231265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SoilChunk() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600778B RID: 30603 RVA: 0x00213F38 File Offset: 0x00212138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231265, XrefRangeEnd = 231270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600778C RID: 30604 RVA: 0x00038FD4 File Offset: 0x000371D4
		public SoilChunk(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024F0 RID: 9456
		// (get) Token: 0x0600778D RID: 30605 RVA: 0x00213F78 File Offset: 0x00212178
		// (set) Token: 0x0600778E RID: 30606 RVA: 0x00038FDD File Offset: 0x000371DD
		public unsafe float _CurrentLerp_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr__CurrentLerp_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr__CurrentLerp_k__BackingField)) = value;
			}
		}

		// Token: 0x170024F1 RID: 9457
		// (get) Token: 0x0600778F RID: 30607 RVA: 0x00213FA0 File Offset: 0x002121A0
		// (set) Token: 0x06007790 RID: 30608 RVA: 0x00038FF8 File Offset: 0x000371F8
		public unsafe Transform EndTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_EndTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_EndTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024F2 RID: 9458
		// (get) Token: 0x06007791 RID: 30609 RVA: 0x00213FD0 File Offset: 0x002121D0
		// (set) Token: 0x06007792 RID: 30610 RVA: 0x00039017 File Offset: 0x00037217
		public unsafe float LerpTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_LerpTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_LerpTime)) = value;
			}
		}

		// Token: 0x170024F3 RID: 9459
		// (get) Token: 0x06007793 RID: 30611 RVA: 0x00213FF8 File Offset: 0x002121F8
		// (set) Token: 0x06007794 RID: 30612 RVA: 0x00039032 File Offset: 0x00037232
		public unsafe Vector3 localPos_Start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_localPos_Start);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_localPos_Start)) = value;
			}
		}

		// Token: 0x170024F4 RID: 9460
		// (get) Token: 0x06007795 RID: 30613 RVA: 0x00214020 File Offset: 0x00212220
		// (set) Token: 0x06007796 RID: 30614 RVA: 0x0003904D File Offset: 0x0003724D
		public unsafe Vector3 localEulerAngles_Start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_localEulerAngles_Start);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_localEulerAngles_Start)) = value;
			}
		}

		// Token: 0x170024F5 RID: 9461
		// (get) Token: 0x06007797 RID: 30615 RVA: 0x00214048 File Offset: 0x00212248
		// (set) Token: 0x06007798 RID: 30616 RVA: 0x00039068 File Offset: 0x00037268
		public unsafe Vector3 localScale_Start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_localScale_Start);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_localScale_Start)) = value;
			}
		}

		// Token: 0x170024F6 RID: 9462
		// (get) Token: 0x06007799 RID: 30617 RVA: 0x00214070 File Offset: 0x00212270
		// (set) Token: 0x0600779A RID: 30618 RVA: 0x00039083 File Offset: 0x00037283
		public unsafe Coroutine lerpRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_lerpRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_lerpRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024F7 RID: 9463
		// (get) Token: 0x0600779B RID: 30619 RVA: 0x002140A0 File Offset: 0x002122A0
		// (set) Token: 0x0600779C RID: 30620 RVA: 0x000390A2 File Offset: 0x000372A2
		public unsafe Collider _collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr__collider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr__collider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024F8 RID: 9464
		// (get) Token: 0x0600779D RID: 30621 RVA: 0x002140D0 File Offset: 0x002122D0
		// (set) Token: 0x0600779E RID: 30622 RVA: 0x000390C1 File Offset: 0x000372C1
		public new unsafe Vector3 _LurePositionOffset_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr__LurePositionOffset_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr__LurePositionOffset_k__BackingField)) = value;
			}
		}

		// Token: 0x0400516A RID: 20842
		private static readonly IntPtr NativeFieldInfoPtr__CurrentLerp_k__BackingField;

		// Token: 0x0400516B RID: 20843
		private static readonly IntPtr NativeFieldInfoPtr_EndTransform;

		// Token: 0x0400516C RID: 20844
		private static readonly IntPtr NativeFieldInfoPtr_LerpTime;

		// Token: 0x0400516D RID: 20845
		private static readonly IntPtr NativeFieldInfoPtr_localPos_Start;

		// Token: 0x0400516E RID: 20846
		private static readonly IntPtr NativeFieldInfoPtr_localEulerAngles_Start;

		// Token: 0x0400516F RID: 20847
		private static readonly IntPtr NativeFieldInfoPtr_localScale_Start;

		// Token: 0x04005170 RID: 20848
		private static readonly IntPtr NativeFieldInfoPtr_lerpRoutine;

		// Token: 0x04005171 RID: 20849
		private static readonly IntPtr NativeFieldInfoPtr__collider;

		// Token: 0x04005172 RID: 20850
		private static readonly IntPtr NativeFieldInfoPtr__LurePositionOffset_k__BackingField;

		// Token: 0x04005173 RID: 20851
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentLerp_Public_get_Single_0;

		// Token: 0x04005174 RID: 20852
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentLerp_Protected_set_Void_Single_0;

		// Token: 0x04005175 RID: 20853
		private static readonly IntPtr NativeMethodInfoPtr_get_RegisterDefaultLureWhenEmpty_Public_Virtual_get_Boolean_0;

		// Token: 0x04005176 RID: 20854
		private static readonly IntPtr NativeMethodInfoPtr_get_LurePositionOffset_Protected_Virtual_get_Vector3_0;

		// Token: 0x04005177 RID: 20855
		private static readonly IntPtr NativeMethodInfoPtr_set_LurePositionOffset_Protected_Virtual_set_Void_Vector3_0;

		// Token: 0x04005178 RID: 20856
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04005179 RID: 20857
		private static readonly IntPtr NativeMethodInfoPtr_SetLerpedTransform_Public_Void_Single_0;

		// Token: 0x0400517A RID: 20858
		private static readonly IntPtr NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0;

		// Token: 0x0400517B RID: 20859
		private static readonly IntPtr NativeMethodInfoPtr_StopLerp_Public_Void_0;

		// Token: 0x0400517C RID: 20860
		private static readonly IntPtr NativeMethodInfoPtr_SetChunkClickable_Public_Void_Boolean_0;

		// Token: 0x0400517D RID: 20861
		private static readonly IntPtr NativeMethodInfoPtr_SetColliderEnabled_Public_Void_Boolean_0;

		// Token: 0x0400517E RID: 20862
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400517F RID: 20863
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000BAF RID: 2991
		[ObfuscatedName("ScheduleOne.Growing.SoilChunk+<<StartClick>g__Lerp|19_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600EACF RID: 60111 RVA: 0x00390580 File Offset: 0x0038E780
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique()
			{
				Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, "<<StartClick>g__Lerp|19_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr);
				SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr, "<>1__state");
				SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr, "<>2__current");
				SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr, "<>4__this");
				SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr, "<i>5__2");
				SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr, 100678663);
				SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr, 100678664);
				SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr, 100678665);
				SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr, 100678666);
				SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr, 100678667);
				SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr, 100678668);
			}

			// Token: 0x0600EAD0 RID: 60112 RVA: 0x00390674 File Offset: 0x0038E874
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EAD1 RID: 60113 RVA: 0x003906BC File Offset: 0x0038E8BC
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EAD2 RID: 60114 RVA: 0x003906F0 File Offset: 0x0038E8F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231184, XrefRangeEnd = 231193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700473E RID: 18238
			// (get) Token: 0x0600EAD3 RID: 60115 RVA: 0x0039072C File Offset: 0x0038E92C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EAD4 RID: 60116 RVA: 0x0039076C File Offset: 0x0038E96C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231193, XrefRangeEnd = 231198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700473F RID: 18239
			// (get) Token: 0x0600EAD5 RID: 60117 RVA: 0x003907A0 File Offset: 0x0038E9A0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EAD6 RID: 60118 RVA: 0x0006EC6C File Offset: 0x0006CE6C
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700473A RID: 18234
			// (get) Token: 0x0600EAD7 RID: 60119 RVA: 0x003907E0 File Offset: 0x0038E9E0
			// (set) Token: 0x0600EAD8 RID: 60120 RVA: 0x0006EC75 File Offset: 0x0006CE75
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700473B RID: 18235
			// (get) Token: 0x0600EAD9 RID: 60121 RVA: 0x00390808 File Offset: 0x0038EA08
			// (set) Token: 0x0600EADA RID: 60122 RVA: 0x0006EC90 File Offset: 0x0006CE90
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700473C RID: 18236
			// (get) Token: 0x0600EADB RID: 60123 RVA: 0x00390838 File Offset: 0x0038EA38
			// (set) Token: 0x0600EADC RID: 60124 RVA: 0x0006ECAF File Offset: 0x0006CEAF
			public unsafe SoilChunk __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SoilChunk>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700473D RID: 18237
			// (get) Token: 0x0600EADD RID: 60125 RVA: 0x00390868 File Offset: 0x0038EA68
			// (set) Token: 0x0600EADE RID: 60126 RVA: 0x0006ECCE File Offset: 0x0006CECE
			public unsafe float _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x04009F21 RID: 40737
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009F22 RID: 40738
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009F23 RID: 40739
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009F24 RID: 40740
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x04009F25 RID: 40741
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009F26 RID: 40742
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009F27 RID: 40743
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009F28 RID: 40744
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009F29 RID: 40745
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009F2A RID: 40746
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
