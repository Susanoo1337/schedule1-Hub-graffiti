using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x02000559 RID: 1369
	public class ProductConsumeAnimation : MonoBehaviour
	{
		// Token: 0x06007C58 RID: 31832 RVA: 0x00224DF8 File Offset: 0x00222FF8
		// Note: this type is marked as 'beforefieldinit'.
		static ProductConsumeAnimation()
		{
			Il2CppClassPointerStore<ProductConsumeAnimation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "ProductConsumeAnimation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductConsumeAnimation>.NativeClassPtr);
			ProductConsumeAnimation.NativeFieldInfoPtr__ConsumeDescription_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductConsumeAnimation>.NativeClassPtr, "<ConsumeDescription>k__BackingField");
			ProductConsumeAnimation.NativeFieldInfoPtr__PrepareDuration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductConsumeAnimation>.NativeClassPtr, "<PrepareDuration>k__BackingField");
			ProductConsumeAnimation.NativeFieldInfoPtr__EffectsApplyDelay_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductConsumeAnimation>.NativeClassPtr, "<EffectsApplyDelay>k__BackingField");
			ProductConsumeAnimation.NativeFieldInfoPtr__thirdPersonAnimationBool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductConsumeAnimation>.NativeClassPtr, "_thirdPersonAnimationBool");
			ProductConsumeAnimation.NativeFieldInfoPtr__thirdPersonAnimationTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductConsumeAnimation>.NativeClassPtr, "_thirdPersonAnimationTrigger");
			ProductConsumeAnimation.NativeFieldInfoPtr__thirdPersonEquippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductConsumeAnimation>.NativeClassPtr, "_thirdPersonEquippable");
			ProductConsumeAnimation.NativeFieldInfoPtr_ConsumeSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductConsumeAnimation>.NativeClassPtr, "ConsumeSound");
			ProductConsumeAnimation.NativeFieldInfoPtr_onPrepareStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductConsumeAnimation>.NativeClassPtr, "onPrepareStart");
			ProductConsumeAnimation.NativeFieldInfoPtr_onPrepareCancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductConsumeAnimation>.NativeClassPtr, "onPrepareCancel");
			ProductConsumeAnimation.NativeFieldInfoPtr_onConsume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductConsumeAnimation>.NativeClassPtr, "onConsume");
			ProductConsumeAnimation.NativeMethodInfoPtr_get_ConsumeDescription_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductConsumeAnimation>.NativeClassPtr, 100679257);
			ProductConsumeAnimation.NativeMethodInfoPtr_set_ConsumeDescription_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductConsumeAnimation>.NativeClassPtr, 100679258);
			ProductConsumeAnimation.NativeMethodInfoPtr_get_PrepareDuration_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductConsumeAnimation>.NativeClassPtr, 100679259);
			ProductConsumeAnimation.NativeMethodInfoPtr_set_PrepareDuration_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductConsumeAnimation>.NativeClassPtr, 100679260);
			ProductConsumeAnimation.NativeMethodInfoPtr_get_EffectsApplyDelay_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductConsumeAnimation>.NativeClassPtr, 100679261);
			ProductConsumeAnimation.NativeMethodInfoPtr_set_EffectsApplyDelay_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductConsumeAnimation>.NativeClassPtr, 100679262);
			ProductConsumeAnimation.NativeMethodInfoPtr_StartPrepare_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductConsumeAnimation>.NativeClassPtr, 100679263);
			ProductConsumeAnimation.NativeMethodInfoPtr_CancelPrepare_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductConsumeAnimation>.NativeClassPtr, 100679264);
			ProductConsumeAnimation.NativeMethodInfoPtr_StartConsume_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductConsumeAnimation>.NativeClassPtr, 100679265);
			ProductConsumeAnimation.NativeMethodInfoPtr_StopConsume_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductConsumeAnimation>.NativeClassPtr, 100679266);
			ProductConsumeAnimation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductConsumeAnimation>.NativeClassPtr, 100679267);
		}

		// Token: 0x17002681 RID: 9857
		// (get) Token: 0x06007C59 RID: 31833 RVA: 0x00224FCC File Offset: 0x002231CC
		// (set) Token: 0x06007C5A RID: 31834 RVA: 0x00225004 File Offset: 0x00223204
		public unsafe string ConsumeDescription
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductConsumeAnimation.NativeMethodInfoPtr_get_ConsumeDescription_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductConsumeAnimation.NativeMethodInfoPtr_set_ConsumeDescription_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002682 RID: 9858
		// (get) Token: 0x06007C5B RID: 31835 RVA: 0x00225048 File Offset: 0x00223248
		// (set) Token: 0x06007C5C RID: 31836 RVA: 0x00225084 File Offset: 0x00223284
		public unsafe float PrepareDuration
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 55725, RefRangeEnd = 55726, XrefRangeStart = 55725, XrefRangeEnd = 55726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductConsumeAnimation.NativeMethodInfoPtr_get_PrepareDuration_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductConsumeAnimation.NativeMethodInfoPtr_set_PrepareDuration_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002683 RID: 9859
		// (get) Token: 0x06007C5D RID: 31837 RVA: 0x002250C4 File Offset: 0x002232C4
		// (set) Token: 0x06007C5E RID: 31838 RVA: 0x00225100 File Offset: 0x00223300
		public unsafe float EffectsApplyDelay
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductConsumeAnimation.NativeMethodInfoPtr_get_EffectsApplyDelay_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 126089, RefRangeEnd = 126091, XrefRangeStart = 126089, XrefRangeEnd = 126091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductConsumeAnimation.NativeMethodInfoPtr_set_EffectsApplyDelay_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007C5F RID: 31839 RVA: 0x00225140 File Offset: 0x00223340
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236558, RefRangeEnd = 236559, XrefRangeStart = 236557, XrefRangeEnd = 236558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartPrepare()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductConsumeAnimation.NativeMethodInfoPtr_StartPrepare_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C60 RID: 31840 RVA: 0x00225174 File Offset: 0x00223374
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236560, RefRangeEnd = 236561, XrefRangeStart = 236559, XrefRangeEnd = 236560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelPrepare()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductConsumeAnimation.NativeMethodInfoPtr_CancelPrepare_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C61 RID: 31841 RVA: 0x002251A8 File Offset: 0x002233A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236596, RefRangeEnd = 236597, XrefRangeStart = 236561, XrefRangeEnd = 236596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartConsume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductConsumeAnimation.NativeMethodInfoPtr_StartConsume_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C62 RID: 31842 RVA: 0x002251DC File Offset: 0x002233DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236613, RefRangeEnd = 236614, XrefRangeStart = 236597, XrefRangeEnd = 236613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopConsume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductConsumeAnimation.NativeMethodInfoPtr_StopConsume_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C63 RID: 31843 RVA: 0x00225210 File Offset: 0x00223410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236614, XrefRangeEnd = 236624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductConsumeAnimation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductConsumeAnimation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductConsumeAnimation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C64 RID: 31844 RVA: 0x0003B37E File Offset: 0x0003957E
		public ProductConsumeAnimation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002677 RID: 9847
		// (get) Token: 0x06007C65 RID: 31845 RVA: 0x0022524C File Offset: 0x0022344C
		// (set) Token: 0x06007C66 RID: 31846 RVA: 0x0003B387 File Offset: 0x00039587
		public unsafe string _ConsumeDescription_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductConsumeAnimation.NativeFieldInfoPtr__ConsumeDescription_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductConsumeAnimation.NativeFieldInfoPtr__ConsumeDescription_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002678 RID: 9848
		// (get) Token: 0x06007C67 RID: 31847 RVA: 0x00225274 File Offset: 0x00223474
		// (set) Token: 0x06007C68 RID: 31848 RVA: 0x0003B3A6 File Offset: 0x000395A6
		public unsafe float _PrepareDuration_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductConsumeAnimation.NativeFieldInfoPtr__PrepareDuration_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductConsumeAnimation.NativeFieldInfoPtr__PrepareDuration_k__BackingField)) = value;
			}
		}

		// Token: 0x17002679 RID: 9849
		// (get) Token: 0x06007C69 RID: 31849 RVA: 0x0022529C File Offset: 0x0022349C
		// (set) Token: 0x06007C6A RID: 31850 RVA: 0x0003B3C1 File Offset: 0x000395C1
		public unsafe float _EffectsApplyDelay_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductConsumeAnimation.NativeFieldInfoPtr__EffectsApplyDelay_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductConsumeAnimation.NativeFieldInfoPtr__EffectsApplyDelay_k__BackingField)) = value;
			}
		}

		// Token: 0x1700267A RID: 9850
		// (get) Token: 0x06007C6B RID: 31851 RVA: 0x002252C4 File Offset: 0x002234C4
		// (set) Token: 0x06007C6C RID: 31852 RVA: 0x0003B3DC File Offset: 0x000395DC
		public unsafe string _thirdPersonAnimationBool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductConsumeAnimation.NativeFieldInfoPtr__thirdPersonAnimationBool);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductConsumeAnimation.NativeFieldInfoPtr__thirdPersonAnimationBool), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700267B RID: 9851
		// (get) Token: 0x06007C6D RID: 31853 RVA: 0x002252EC File Offset: 0x002234EC
		// (set) Token: 0x06007C6E RID: 31854 RVA: 0x0003B3FB File Offset: 0x000395FB
		public unsafe string _thirdPersonAnimationTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductConsumeAnimation.NativeFieldInfoPtr__thirdPersonAnimationTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductConsumeAnimation.NativeFieldInfoPtr__thirdPersonAnimationTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700267C RID: 9852
		// (get) Token: 0x06007C6F RID: 31855 RVA: 0x00225314 File Offset: 0x00223514
		// (set) Token: 0x06007C70 RID: 31856 RVA: 0x0003B41A File Offset: 0x0003961A
		public unsafe AvatarEquippable _thirdPersonEquippable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductConsumeAnimation.NativeFieldInfoPtr__thirdPersonEquippable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductConsumeAnimation.NativeFieldInfoPtr__thirdPersonEquippable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700267D RID: 9853
		// (get) Token: 0x06007C71 RID: 31857 RVA: 0x00225344 File Offset: 0x00223544
		// (set) Token: 0x06007C72 RID: 31858 RVA: 0x0003B439 File Offset: 0x00039639
		public unsafe AudioSourceController ConsumeSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductConsumeAnimation.NativeFieldInfoPtr_ConsumeSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductConsumeAnimation.NativeFieldInfoPtr_ConsumeSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700267E RID: 9854
		// (get) Token: 0x06007C73 RID: 31859 RVA: 0x00225374 File Offset: 0x00223574
		// (set) Token: 0x06007C74 RID: 31860 RVA: 0x0003B458 File Offset: 0x00039658
		public unsafe UnityEvent onPrepareStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductConsumeAnimation.NativeFieldInfoPtr_onPrepareStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductConsumeAnimation.NativeFieldInfoPtr_onPrepareStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700267F RID: 9855
		// (get) Token: 0x06007C75 RID: 31861 RVA: 0x002253A4 File Offset: 0x002235A4
		// (set) Token: 0x06007C76 RID: 31862 RVA: 0x0003B477 File Offset: 0x00039677
		public unsafe UnityEvent onPrepareCancel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductConsumeAnimation.NativeFieldInfoPtr_onPrepareCancel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductConsumeAnimation.NativeFieldInfoPtr_onPrepareCancel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002680 RID: 9856
		// (get) Token: 0x06007C77 RID: 31863 RVA: 0x002253D4 File Offset: 0x002235D4
		// (set) Token: 0x06007C78 RID: 31864 RVA: 0x0003B496 File Offset: 0x00039696
		public unsafe UnityEvent onConsume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductConsumeAnimation.NativeFieldInfoPtr_onConsume);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductConsumeAnimation.NativeFieldInfoPtr_onConsume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040054C8 RID: 21704
		private static readonly IntPtr NativeFieldInfoPtr__ConsumeDescription_k__BackingField;

		// Token: 0x040054C9 RID: 21705
		private static readonly IntPtr NativeFieldInfoPtr__PrepareDuration_k__BackingField;

		// Token: 0x040054CA RID: 21706
		private static readonly IntPtr NativeFieldInfoPtr__EffectsApplyDelay_k__BackingField;

		// Token: 0x040054CB RID: 21707
		private static readonly IntPtr NativeFieldInfoPtr__thirdPersonAnimationBool;

		// Token: 0x040054CC RID: 21708
		private static readonly IntPtr NativeFieldInfoPtr__thirdPersonAnimationTrigger;

		// Token: 0x040054CD RID: 21709
		private static readonly IntPtr NativeFieldInfoPtr__thirdPersonEquippable;

		// Token: 0x040054CE RID: 21710
		private static readonly IntPtr NativeFieldInfoPtr_ConsumeSound;

		// Token: 0x040054CF RID: 21711
		private static readonly IntPtr NativeFieldInfoPtr_onPrepareStart;

		// Token: 0x040054D0 RID: 21712
		private static readonly IntPtr NativeFieldInfoPtr_onPrepareCancel;

		// Token: 0x040054D1 RID: 21713
		private static readonly IntPtr NativeFieldInfoPtr_onConsume;

		// Token: 0x040054D2 RID: 21714
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumeDescription_Public_get_String_0;

		// Token: 0x040054D3 RID: 21715
		private static readonly IntPtr NativeMethodInfoPtr_set_ConsumeDescription_Private_set_Void_String_0;

		// Token: 0x040054D4 RID: 21716
		private static readonly IntPtr NativeMethodInfoPtr_get_PrepareDuration_Public_get_Single_0;

		// Token: 0x040054D5 RID: 21717
		private static readonly IntPtr NativeMethodInfoPtr_set_PrepareDuration_Private_set_Void_Single_0;

		// Token: 0x040054D6 RID: 21718
		private static readonly IntPtr NativeMethodInfoPtr_get_EffectsApplyDelay_Public_get_Single_0;

		// Token: 0x040054D7 RID: 21719
		private static readonly IntPtr NativeMethodInfoPtr_set_EffectsApplyDelay_Private_set_Void_Single_0;

		// Token: 0x040054D8 RID: 21720
		private static readonly IntPtr NativeMethodInfoPtr_StartPrepare_Public_Void_0;

		// Token: 0x040054D9 RID: 21721
		private static readonly IntPtr NativeMethodInfoPtr_CancelPrepare_Public_Void_0;

		// Token: 0x040054DA RID: 21722
		private static readonly IntPtr NativeMethodInfoPtr_StartConsume_Public_Void_0;

		// Token: 0x040054DB RID: 21723
		private static readonly IntPtr NativeMethodInfoPtr_StopConsume_Public_Void_0;

		// Token: 0x040054DC RID: 21724
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
