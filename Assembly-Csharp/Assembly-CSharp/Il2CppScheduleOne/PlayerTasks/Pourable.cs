using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.Trash;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x02000178 RID: 376
	public class Pourable : Draggable
	{
		// Token: 0x06002600 RID: 9728 RVA: 0x000F8EC0 File Offset: 0x000F70C0
		// Note: this type is marked as 'beforefieldinit'.
		static Pourable()
		{
			Il2CppClassPointerStore<Pourable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "Pourable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pourable>.NativeClassPtr);
			Pourable.NativeFieldInfoPtr__IsPouring_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "<IsPouring>k__BackingField");
			Pourable.NativeFieldInfoPtr_onInitialPour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "onInitialPour");
			Pourable.NativeFieldInfoPtr_Unlimited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "Unlimited");
			Pourable.NativeFieldInfoPtr_StartQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "StartQuantity");
			Pourable.NativeFieldInfoPtr_PourRate_L = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "PourRate_L");
			Pourable.NativeFieldInfoPtr_AngleFromUpToPour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "AngleFromUpToPour");
			Pourable.NativeFieldInfoPtr_ShakeBoostRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "ShakeBoostRate");
			Pourable.NativeFieldInfoPtr_AffectsCoverage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "AffectsCoverage");
			Pourable.NativeFieldInfoPtr_ParticleMinMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "ParticleMinMultiplier");
			Pourable.NativeFieldInfoPtr_ParticleMaxMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "ParticleMaxMultiplier");
			Pourable.NativeFieldInfoPtr_PourParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "PourParticles");
			Pourable.NativeFieldInfoPtr_PourPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "PourPoint");
			Pourable.NativeFieldInfoPtr_PourLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "PourLoop");
			Pourable.NativeFieldInfoPtr_TrashItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "TrashItem");
			Pourable.NativeFieldInfoPtr_TargetGrowContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "TargetGrowContainer");
			Pourable.NativeFieldInfoPtr__NormalizedPourRate_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "<NormalizedPourRate>k__BackingField");
			Pourable.NativeFieldInfoPtr__CurrentQuantity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "<CurrentQuantity>k__BackingField");
			Pourable.NativeFieldInfoPtr_hasPoured = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "hasPoured");
			Pourable.NativeFieldInfoPtr_autoSetCurrentQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "autoSetCurrentQuantity");
			Pourable.NativeFieldInfoPtr_particleMinSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "particleMinSizes");
			Pourable.NativeFieldInfoPtr_particleMaxSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "particleMaxSizes");
			Pourable.NativeFieldInfoPtr_accelerometer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pourable>.NativeClassPtr, "accelerometer");
			Pourable.NativeMethodInfoPtr_get_IsPouring_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pourable>.NativeClassPtr, 100668207);
			Pourable.NativeMethodInfoPtr_set_IsPouring_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pourable>.NativeClassPtr, 100668208);
			Pourable.NativeMethodInfoPtr_get_NormalizedPourRate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pourable>.NativeClassPtr, 100668209);
			Pourable.NativeMethodInfoPtr_set_NormalizedPourRate_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pourable>.NativeClassPtr, 100668210);
			Pourable.NativeMethodInfoPtr_get_CurrentQuantity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pourable>.NativeClassPtr, 100668211);
			Pourable.NativeMethodInfoPtr_set_CurrentQuantity_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pourable>.NativeClassPtr, 100668212);
			Pourable.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pourable>.NativeClassPtr, 100668213);
			Pourable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pourable>.NativeClassPtr, 100668214);
			Pourable.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pourable>.NativeClassPtr, 100668215);
			Pourable.NativeMethodInfoPtr_UpdatePouring_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pourable>.NativeClassPtr, 100668216);
			Pourable.NativeMethodInfoPtr_GetShakeBoost_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pourable>.NativeClassPtr, 100668217);
			Pourable.NativeMethodInfoPtr_PourAmount_Protected_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pourable>.NativeClassPtr, 100668218);
			Pourable.NativeMethodInfoPtr_IsPourPointOverPot_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pourable>.NativeClassPtr, 100668219);
			Pourable.NativeMethodInfoPtr_CanPour_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pourable>.NativeClassPtr, 100668220);
			Pourable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pourable>.NativeClassPtr, 100668221);
		}

		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x06002601 RID: 9729 RVA: 0x000F91D4 File Offset: 0x000F73D4
		// (set) Token: 0x06002602 RID: 9730 RVA: 0x000F9210 File Offset: 0x000F7410
		public unsafe bool IsPouring
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pourable.NativeMethodInfoPtr_get_IsPouring_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pourable.NativeMethodInfoPtr_set_IsPouring_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x06002603 RID: 9731 RVA: 0x000F9250 File Offset: 0x000F7450
		// (set) Token: 0x06002604 RID: 9732 RVA: 0x000F928C File Offset: 0x000F748C
		public unsafe float NormalizedPourRate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pourable.NativeMethodInfoPtr_get_NormalizedPourRate_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pourable.NativeMethodInfoPtr_set_NormalizedPourRate_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C94 RID: 3220
		// (get) Token: 0x06002605 RID: 9733 RVA: 0x000F92CC File Offset: 0x000F74CC
		// (set) Token: 0x06002606 RID: 9734 RVA: 0x000F9308 File Offset: 0x000F7508
		public unsafe float CurrentQuantity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pourable.NativeMethodInfoPtr_get_CurrentQuantity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pourable.NativeMethodInfoPtr_set_CurrentQuantity_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002607 RID: 9735 RVA: 0x000F9348 File Offset: 0x000F7548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117324, XrefRangeEnd = 117369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pourable.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002608 RID: 9736 RVA: 0x000F9384 File Offset: 0x000F7584
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pourable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002609 RID: 9737 RVA: 0x000F93C0 File Offset: 0x000F75C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117369, XrefRangeEnd = 117370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pourable.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600260A RID: 9738 RVA: 0x000F93FC File Offset: 0x000F75FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117370, XrefRangeEnd = 117402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdatePouring()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pourable.NativeMethodInfoPtr_UpdatePouring_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600260B RID: 9739 RVA: 0x000F9438 File Offset: 0x000F7638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117402, XrefRangeEnd = 117403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetShakeBoost()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pourable.NativeMethodInfoPtr_GetShakeBoost_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600260C RID: 9740 RVA: 0x000F9474 File Offset: 0x000F7674
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 117408, RefRangeEnd = 117411, XrefRangeStart = 117403, XrefRangeEnd = 117408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PourAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pourable.NativeMethodInfoPtr_PourAmount_Protected_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600260D RID: 9741 RVA: 0x000F94C0 File Offset: 0x000F76C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117412, RefRangeEnd = 117413, XrefRangeStart = 117411, XrefRangeEnd = 117412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPourPointOverPot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pourable.NativeMethodInfoPtr_IsPourPointOverPot_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600260E RID: 9742 RVA: 0x000F94FC File Offset: 0x000F76FC
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 29255, RefRangeEnd = 29273, XrefRangeStart = 29255, XrefRangeEnd = 29273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanPour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pourable.NativeMethodInfoPtr_CanPour_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600260F RID: 9743 RVA: 0x000F9544 File Offset: 0x000F7744
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 117414, RefRangeEnd = 117417, XrefRangeStart = 117413, XrefRangeEnd = 117414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Pourable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pourable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pourable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002610 RID: 9744 RVA: 0x00014031 File Offset: 0x00012231
		public Pourable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x06002611 RID: 9745 RVA: 0x000F9580 File Offset: 0x000F7780
		// (set) Token: 0x06002612 RID: 9746 RVA: 0x0001403A File Offset: 0x0001223A
		public unsafe bool _IsPouring_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr__IsPouring_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr__IsPouring_k__BackingField)) = value;
			}
		}

		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x06002613 RID: 9747 RVA: 0x000F95A8 File Offset: 0x000F77A8
		// (set) Token: 0x06002614 RID: 9748 RVA: 0x00014055 File Offset: 0x00012255
		public unsafe Action onInitialPour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_onInitialPour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_onInitialPour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C7E RID: 3198
		// (get) Token: 0x06002615 RID: 9749 RVA: 0x000F95D8 File Offset: 0x000F77D8
		// (set) Token: 0x06002616 RID: 9750 RVA: 0x00014074 File Offset: 0x00012274
		public unsafe bool Unlimited
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_Unlimited);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_Unlimited)) = value;
			}
		}

		// Token: 0x17000C7F RID: 3199
		// (get) Token: 0x06002617 RID: 9751 RVA: 0x000F9600 File Offset: 0x000F7800
		// (set) Token: 0x06002618 RID: 9752 RVA: 0x0001408F File Offset: 0x0001228F
		public unsafe float StartQuantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_StartQuantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_StartQuantity)) = value;
			}
		}

		// Token: 0x17000C80 RID: 3200
		// (get) Token: 0x06002619 RID: 9753 RVA: 0x000F9628 File Offset: 0x000F7828
		// (set) Token: 0x0600261A RID: 9754 RVA: 0x000140AA File Offset: 0x000122AA
		public unsafe float PourRate_L
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_PourRate_L);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_PourRate_L)) = value;
			}
		}

		// Token: 0x17000C81 RID: 3201
		// (get) Token: 0x0600261B RID: 9755 RVA: 0x000F9650 File Offset: 0x000F7850
		// (set) Token: 0x0600261C RID: 9756 RVA: 0x000140C5 File Offset: 0x000122C5
		public unsafe float AngleFromUpToPour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_AngleFromUpToPour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_AngleFromUpToPour)) = value;
			}
		}

		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x0600261D RID: 9757 RVA: 0x000F9678 File Offset: 0x000F7878
		// (set) Token: 0x0600261E RID: 9758 RVA: 0x000140E0 File Offset: 0x000122E0
		public unsafe float ShakeBoostRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_ShakeBoostRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_ShakeBoostRate)) = value;
			}
		}

		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x0600261F RID: 9759 RVA: 0x000F96A0 File Offset: 0x000F78A0
		// (set) Token: 0x06002620 RID: 9760 RVA: 0x000140FB File Offset: 0x000122FB
		public unsafe bool AffectsCoverage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_AffectsCoverage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_AffectsCoverage)) = value;
			}
		}

		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x06002621 RID: 9761 RVA: 0x000F96C8 File Offset: 0x000F78C8
		// (set) Token: 0x06002622 RID: 9762 RVA: 0x00014116 File Offset: 0x00012316
		public unsafe float ParticleMinMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_ParticleMinMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_ParticleMinMultiplier)) = value;
			}
		}

		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x06002623 RID: 9763 RVA: 0x000F96F0 File Offset: 0x000F78F0
		// (set) Token: 0x06002624 RID: 9764 RVA: 0x00014131 File Offset: 0x00012331
		public unsafe float ParticleMaxMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_ParticleMaxMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_ParticleMaxMultiplier)) = value;
			}
		}

		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x06002625 RID: 9765 RVA: 0x000F9718 File Offset: 0x000F7918
		// (set) Token: 0x06002626 RID: 9766 RVA: 0x0001414C File Offset: 0x0001234C
		public unsafe Il2CppReferenceArray<ParticleSystem> PourParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_PourParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParticleSystem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_PourParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x06002627 RID: 9767 RVA: 0x000F9748 File Offset: 0x000F7948
		// (set) Token: 0x06002628 RID: 9768 RVA: 0x0001416B File Offset: 0x0001236B
		public unsafe Transform PourPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_PourPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_PourPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C88 RID: 3208
		// (get) Token: 0x06002629 RID: 9769 RVA: 0x000F9778 File Offset: 0x000F7978
		// (set) Token: 0x0600262A RID: 9770 RVA: 0x0001418A File Offset: 0x0001238A
		public unsafe AudioSourceController PourLoop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_PourLoop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_PourLoop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x0600262B RID: 9771 RVA: 0x000F97A8 File Offset: 0x000F79A8
		// (set) Token: 0x0600262C RID: 9772 RVA: 0x000141A9 File Offset: 0x000123A9
		public unsafe TrashItem TrashItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_TrashItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_TrashItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x0600262D RID: 9773 RVA: 0x000F97D8 File Offset: 0x000F79D8
		// (set) Token: 0x0600262E RID: 9774 RVA: 0x000141C8 File Offset: 0x000123C8
		public unsafe GrowContainer TargetGrowContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_TargetGrowContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GrowContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_TargetGrowContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C8B RID: 3211
		// (get) Token: 0x0600262F RID: 9775 RVA: 0x000F9808 File Offset: 0x000F7A08
		// (set) Token: 0x06002630 RID: 9776 RVA: 0x000141E7 File Offset: 0x000123E7
		public unsafe float _NormalizedPourRate_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr__NormalizedPourRate_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr__NormalizedPourRate_k__BackingField)) = value;
			}
		}

		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x06002631 RID: 9777 RVA: 0x000F9830 File Offset: 0x000F7A30
		// (set) Token: 0x06002632 RID: 9778 RVA: 0x00014202 File Offset: 0x00012402
		public unsafe float _CurrentQuantity_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr__CurrentQuantity_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr__CurrentQuantity_k__BackingField)) = value;
			}
		}

		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x06002633 RID: 9779 RVA: 0x000F9858 File Offset: 0x000F7A58
		// (set) Token: 0x06002634 RID: 9780 RVA: 0x0001421D File Offset: 0x0001241D
		public unsafe bool hasPoured
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_hasPoured);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_hasPoured)) = value;
			}
		}

		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x06002635 RID: 9781 RVA: 0x000F9880 File Offset: 0x000F7A80
		// (set) Token: 0x06002636 RID: 9782 RVA: 0x00014238 File Offset: 0x00012438
		public unsafe bool autoSetCurrentQuantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_autoSetCurrentQuantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_autoSetCurrentQuantity)) = value;
			}
		}

		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x06002637 RID: 9783 RVA: 0x000F98A8 File Offset: 0x000F7AA8
		// (set) Token: 0x06002638 RID: 9784 RVA: 0x00014253 File Offset: 0x00012453
		public unsafe Il2CppStructArray<float> particleMinSizes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_particleMinSizes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_particleMinSizes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C90 RID: 3216
		// (get) Token: 0x06002639 RID: 9785 RVA: 0x000F98D8 File Offset: 0x000F7AD8
		// (set) Token: 0x0600263A RID: 9786 RVA: 0x00014272 File Offset: 0x00012472
		public unsafe Il2CppStructArray<float> particleMaxSizes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_particleMaxSizes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_particleMaxSizes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C91 RID: 3217
		// (get) Token: 0x0600263B RID: 9787 RVA: 0x000F9908 File Offset: 0x000F7B08
		// (set) Token: 0x0600263C RID: 9788 RVA: 0x00014291 File Offset: 0x00012491
		public unsafe AverageAcceleration accelerometer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_accelerometer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AverageAcceleration>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pourable.NativeFieldInfoPtr_accelerometer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A3A RID: 6714
		private static readonly IntPtr NativeFieldInfoPtr__IsPouring_k__BackingField;

		// Token: 0x04001A3B RID: 6715
		private static readonly IntPtr NativeFieldInfoPtr_onInitialPour;

		// Token: 0x04001A3C RID: 6716
		private static readonly IntPtr NativeFieldInfoPtr_Unlimited;

		// Token: 0x04001A3D RID: 6717
		private static readonly IntPtr NativeFieldInfoPtr_StartQuantity;

		// Token: 0x04001A3E RID: 6718
		private static readonly IntPtr NativeFieldInfoPtr_PourRate_L;

		// Token: 0x04001A3F RID: 6719
		private static readonly IntPtr NativeFieldInfoPtr_AngleFromUpToPour;

		// Token: 0x04001A40 RID: 6720
		private static readonly IntPtr NativeFieldInfoPtr_ShakeBoostRate;

		// Token: 0x04001A41 RID: 6721
		private static readonly IntPtr NativeFieldInfoPtr_AffectsCoverage;

		// Token: 0x04001A42 RID: 6722
		private static readonly IntPtr NativeFieldInfoPtr_ParticleMinMultiplier;

		// Token: 0x04001A43 RID: 6723
		private static readonly IntPtr NativeFieldInfoPtr_ParticleMaxMultiplier;

		// Token: 0x04001A44 RID: 6724
		private static readonly IntPtr NativeFieldInfoPtr_PourParticles;

		// Token: 0x04001A45 RID: 6725
		private static readonly IntPtr NativeFieldInfoPtr_PourPoint;

		// Token: 0x04001A46 RID: 6726
		private static readonly IntPtr NativeFieldInfoPtr_PourLoop;

		// Token: 0x04001A47 RID: 6727
		private static readonly IntPtr NativeFieldInfoPtr_TrashItem;

		// Token: 0x04001A48 RID: 6728
		private static readonly IntPtr NativeFieldInfoPtr_TargetGrowContainer;

		// Token: 0x04001A49 RID: 6729
		private static readonly IntPtr NativeFieldInfoPtr__NormalizedPourRate_k__BackingField;

		// Token: 0x04001A4A RID: 6730
		private static readonly IntPtr NativeFieldInfoPtr__CurrentQuantity_k__BackingField;

		// Token: 0x04001A4B RID: 6731
		private static readonly IntPtr NativeFieldInfoPtr_hasPoured;

		// Token: 0x04001A4C RID: 6732
		private static readonly IntPtr NativeFieldInfoPtr_autoSetCurrentQuantity;

		// Token: 0x04001A4D RID: 6733
		private static readonly IntPtr NativeFieldInfoPtr_particleMinSizes;

		// Token: 0x04001A4E RID: 6734
		private static readonly IntPtr NativeFieldInfoPtr_particleMaxSizes;

		// Token: 0x04001A4F RID: 6735
		private static readonly IntPtr NativeFieldInfoPtr_accelerometer;

		// Token: 0x04001A50 RID: 6736
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPouring_Public_get_Boolean_0;

		// Token: 0x04001A51 RID: 6737
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPouring_Protected_set_Void_Boolean_0;

		// Token: 0x04001A52 RID: 6738
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalizedPourRate_Public_get_Single_0;

		// Token: 0x04001A53 RID: 6739
		private static readonly IntPtr NativeMethodInfoPtr_set_NormalizedPourRate_Private_set_Void_Single_0;

		// Token: 0x04001A54 RID: 6740
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentQuantity_Public_get_Single_0;

		// Token: 0x04001A55 RID: 6741
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentQuantity_Protected_set_Void_Single_0;

		// Token: 0x04001A56 RID: 6742
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04001A57 RID: 6743
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04001A58 RID: 6744
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_0;

		// Token: 0x04001A59 RID: 6745
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePouring_Protected_Virtual_New_Void_0;

		// Token: 0x04001A5A RID: 6746
		private static readonly IntPtr NativeMethodInfoPtr_GetShakeBoost_Private_Single_0;

		// Token: 0x04001A5B RID: 6747
		private static readonly IntPtr NativeMethodInfoPtr_PourAmount_Protected_Virtual_New_Void_Single_0;

		// Token: 0x04001A5C RID: 6748
		private static readonly IntPtr NativeMethodInfoPtr_IsPourPointOverPot_Protected_Boolean_0;

		// Token: 0x04001A5D RID: 6749
		private static readonly IntPtr NativeMethodInfoPtr_CanPour_Protected_Virtual_New_Boolean_0;

		// Token: 0x04001A5E RID: 6750
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
