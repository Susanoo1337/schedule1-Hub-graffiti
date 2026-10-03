using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x020004C2 RID: 1218
	public class AvatarEquippable : MonoBehaviour
	{
		// Token: 0x06006F9C RID: 28572 RVA: 0x001FB100 File Offset: 0x001F9300
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarEquippable()
		{
			Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Equipping", "AvatarEquippable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr);
			AvatarEquippable.NativeFieldInfoPtr_AlignmentPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, "AlignmentPoint");
			AvatarEquippable.NativeFieldInfoPtr_Suspiciousness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, "Suspiciousness");
			AvatarEquippable.NativeFieldInfoPtr_Hand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, "Hand");
			AvatarEquippable.NativeFieldInfoPtr_TriggerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, "TriggerType");
			AvatarEquippable.NativeFieldInfoPtr_AnimationTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, "AnimationTrigger");
			AvatarEquippable.NativeFieldInfoPtr__equipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, "_equipped");
			AvatarEquippable.NativeFieldInfoPtr_AssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, "AssetPath");
			AvatarEquippable.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, "avatar");
			AvatarEquippable.NativeMethodInfoPtr_RecalculateAssetPath_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, 100677755);
			AvatarEquippable.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, 100677756);
			AvatarEquippable.NativeMethodInfoPtr_Equip_Public_Virtual_New_Void_Avatar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, 100677757);
			AvatarEquippable.NativeMethodInfoPtr_InitializeAnimation_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, 100677758);
			AvatarEquippable.NativeMethodInfoPtr_Unequip_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, 100677759);
			AvatarEquippable.NativeMethodInfoPtr_PositionAnimationModel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, 100677760);
			AvatarEquippable.NativeMethodInfoPtr_SetTrigger_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, 100677761);
			AvatarEquippable.NativeMethodInfoPtr_SetBool_Protected_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, 100677762);
			AvatarEquippable.NativeMethodInfoPtr_ResetTrigger_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, 100677763);
			AvatarEquippable.NativeMethodInfoPtr_ReceiveMessage_Public_Virtual_New_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, 100677764);
			AvatarEquippable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, 100677765);
			AvatarEquippable.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, 100677766);
		}

		// Token: 0x06006F9D RID: 28573 RVA: 0x001FB2C0 File Offset: 0x001F94C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223879, XrefRangeEnd = 223893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateAssetPath()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEquippable.NativeMethodInfoPtr_RecalculateAssetPath_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F9E RID: 28574 RVA: 0x001FB2F4 File Offset: 0x001F94F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223893, XrefRangeEnd = 223905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarEquippable.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F9F RID: 28575 RVA: 0x001FB330 File Offset: 0x001F9530
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 223929, RefRangeEnd = 223933, XrefRangeStart = 223905, XrefRangeEnd = 223929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Equip(Avatar _avatar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_avatar);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarEquippable.NativeMethodInfoPtr_Equip_Public_Virtual_New_Void_Avatar_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FA0 RID: 28576 RVA: 0x001FB380 File Offset: 0x001F9580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223933, XrefRangeEnd = 223944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeAnimation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarEquippable.NativeMethodInfoPtr_InitializeAnimation_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FA1 RID: 28577 RVA: 0x001FB3BC File Offset: 0x001F95BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 223954, RefRangeEnd = 223957, XrefRangeStart = 223944, XrefRangeEnd = 223954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarEquippable.NativeMethodInfoPtr_Unequip_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FA2 RID: 28578 RVA: 0x001FB3F8 File Offset: 0x001F95F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223971, RefRangeEnd = 223972, XrefRangeStart = 223957, XrefRangeEnd = 223971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PositionAnimationModel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEquippable.NativeMethodInfoPtr_PositionAnimationModel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FA3 RID: 28579 RVA: 0x001FB42C File Offset: 0x001F962C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 223988, RefRangeEnd = 223993, XrefRangeStart = 223972, XrefRangeEnd = 223988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTrigger(string anim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(anim);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEquippable.NativeMethodInfoPtr_SetTrigger_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FA4 RID: 28580 RVA: 0x001FB470 File Offset: 0x001F9670
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 224009, RefRangeEnd = 224010, XrefRangeStart = 223993, XrefRangeEnd = 224009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBool(string anim, bool val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(anim);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEquippable.NativeMethodInfoPtr_SetBool_Protected_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FA5 RID: 28581 RVA: 0x001FB4C0 File Offset: 0x001F96C0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 224026, RefRangeEnd = 224031, XrefRangeStart = 224010, XrefRangeEnd = 224026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetTrigger(string anim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(anim);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEquippable.NativeMethodInfoPtr_ResetTrigger_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FA6 RID: 28582 RVA: 0x001FB504 File Offset: 0x001F9704
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ReceiveMessage(string message, Il2CppSystem.Object parameter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarEquippable.NativeMethodInfoPtr_ReceiveMessage_Public_Virtual_New_Void_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FA7 RID: 28583 RVA: 0x001FB564 File Offset: 0x001F9764
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 224039, RefRangeEnd = 224043, XrefRangeStart = 224031, XrefRangeEnd = 224039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarEquippable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEquippable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FA8 RID: 28584 RVA: 0x001FB5A0 File Offset: 0x001F97A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224043, XrefRangeEnd = 224048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEquippable.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06006FA9 RID: 28585 RVA: 0x00034ED4 File Offset: 0x000330D4
		public AvatarEquippable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002279 RID: 8825
		// (get) Token: 0x06006FAA RID: 28586 RVA: 0x001FB5E0 File Offset: 0x001F97E0
		// (set) Token: 0x06006FAB RID: 28587 RVA: 0x00034EDD File Offset: 0x000330DD
		public unsafe Transform AlignmentPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_AlignmentPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_AlignmentPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700227A RID: 8826
		// (get) Token: 0x06006FAC RID: 28588 RVA: 0x001FB610 File Offset: 0x001F9810
		// (set) Token: 0x06006FAD RID: 28589 RVA: 0x00034EFC File Offset: 0x000330FC
		public unsafe float Suspiciousness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_Suspiciousness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_Suspiciousness)) = value;
			}
		}

		// Token: 0x1700227B RID: 8827
		// (get) Token: 0x06006FAE RID: 28590 RVA: 0x001FB638 File Offset: 0x001F9838
		// (set) Token: 0x06006FAF RID: 28591 RVA: 0x00034F17 File Offset: 0x00033117
		public unsafe AvatarEquippable.EHand Hand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_Hand);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_Hand)) = value;
			}
		}

		// Token: 0x1700227C RID: 8828
		// (get) Token: 0x06006FB0 RID: 28592 RVA: 0x001FB660 File Offset: 0x001F9860
		// (set) Token: 0x06006FB1 RID: 28593 RVA: 0x00034F32 File Offset: 0x00033132
		public unsafe AvatarEquippable.ETriggerType TriggerType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_TriggerType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_TriggerType)) = value;
			}
		}

		// Token: 0x1700227D RID: 8829
		// (get) Token: 0x06006FB2 RID: 28594 RVA: 0x001FB688 File Offset: 0x001F9888
		// (set) Token: 0x06006FB3 RID: 28595 RVA: 0x00034F4D File Offset: 0x0003314D
		public unsafe string AnimationTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_AnimationTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_AnimationTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700227E RID: 8830
		// (get) Token: 0x06006FB4 RID: 28596 RVA: 0x001FB6B0 File Offset: 0x001F98B0
		// (set) Token: 0x06006FB5 RID: 28597 RVA: 0x00034F6C File Offset: 0x0003316C
		public unsafe bool _equipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr__equipped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr__equipped)) = value;
			}
		}

		// Token: 0x1700227F RID: 8831
		// (get) Token: 0x06006FB6 RID: 28598 RVA: 0x001FB6D8 File Offset: 0x001F98D8
		// (set) Token: 0x06006FB7 RID: 28599 RVA: 0x00034F87 File Offset: 0x00033187
		public unsafe string AssetPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_AssetPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_AssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002280 RID: 8832
		// (get) Token: 0x06006FB8 RID: 28600 RVA: 0x001FB700 File Offset: 0x001F9900
		// (set) Token: 0x06006FB9 RID: 28601 RVA: 0x00034FA6 File Offset: 0x000331A6
		public unsafe Avatar avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004C6F RID: 19567
		private static readonly IntPtr NativeFieldInfoPtr_AlignmentPoint;

		// Token: 0x04004C70 RID: 19568
		private static readonly IntPtr NativeFieldInfoPtr_Suspiciousness;

		// Token: 0x04004C71 RID: 19569
		private static readonly IntPtr NativeFieldInfoPtr_Hand;

		// Token: 0x04004C72 RID: 19570
		private static readonly IntPtr NativeFieldInfoPtr_TriggerType;

		// Token: 0x04004C73 RID: 19571
		private static readonly IntPtr NativeFieldInfoPtr_AnimationTrigger;

		// Token: 0x04004C74 RID: 19572
		private static readonly IntPtr NativeFieldInfoPtr__equipped;

		// Token: 0x04004C75 RID: 19573
		private static readonly IntPtr NativeFieldInfoPtr_AssetPath;

		// Token: 0x04004C76 RID: 19574
		private static readonly IntPtr NativeFieldInfoPtr_avatar;

		// Token: 0x04004C77 RID: 19575
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateAssetPath_Public_Void_0;

		// Token: 0x04004C78 RID: 19576
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04004C79 RID: 19577
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_New_Void_Avatar_0;

		// Token: 0x04004C7A RID: 19578
		private static readonly IntPtr NativeMethodInfoPtr_InitializeAnimation_Public_Virtual_New_Void_0;

		// Token: 0x04004C7B RID: 19579
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_New_Void_0;

		// Token: 0x04004C7C RID: 19580
		private static readonly IntPtr NativeMethodInfoPtr_PositionAnimationModel_Private_Void_0;

		// Token: 0x04004C7D RID: 19581
		private static readonly IntPtr NativeMethodInfoPtr_SetTrigger_Protected_Void_String_0;

		// Token: 0x04004C7E RID: 19582
		private static readonly IntPtr NativeMethodInfoPtr_SetBool_Protected_Void_String_Boolean_0;

		// Token: 0x04004C7F RID: 19583
		private static readonly IntPtr NativeMethodInfoPtr_ResetTrigger_Protected_Void_String_0;

		// Token: 0x04004C80 RID: 19584
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveMessage_Public_Virtual_New_Void_String_Object_0;

		// Token: 0x04004C81 RID: 19585
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004C82 RID: 19586
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000B7E RID: 2942
		[OriginalName("Assembly-CSharp.dll", "", "ETriggerType")]
		public enum ETriggerType
		{
			// Token: 0x04009E07 RID: 40455
			Trigger,
			// Token: 0x04009E08 RID: 40456
			Bool
		}

		// Token: 0x02000B7F RID: 2943
		[OriginalName("Assembly-CSharp.dll", "", "EHand")]
		public enum EHand
		{
			// Token: 0x04009E0A RID: 40458
			Left,
			// Token: 0x04009E0B RID: 40459
			Right
		}

		// Token: 0x02000B80 RID: 2944
		[ObfuscatedName("ScheduleOne.AvatarFramework.Equipping.AvatarEquippable+<<InitializeAnimation>g__Wait|13_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600E8FD RID: 59645 RVA: 0x0038B134 File Offset: 0x00389334
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvObObUnique()
			{
				Il2CppClassPointerStore<AvatarEquippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, "<<InitializeAnimation>g__Wait|13_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEquippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvObObUnique>.NativeClassPtr);
				AvatarEquippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEquippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvObObUnique>.NativeClassPtr, "<>1__state");
				AvatarEquippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEquippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvObObUnique>.NativeClassPtr, "<>2__current");
				AvatarEquippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEquippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvObObUnique>.NativeClassPtr, "<>4__this");
				AvatarEquippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvObObUnique>.NativeClassPtr, 100677767);
				AvatarEquippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvObObUnique>.NativeClassPtr, 100677768);
				AvatarEquippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvObObUnique>.NativeClassPtr, 100677769);
				AvatarEquippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvObObUnique>.NativeClassPtr, 100677770);
				AvatarEquippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvObObUnique>.NativeClassPtr, 100677771);
				AvatarEquippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvObObUnique>.NativeClassPtr, 100677772);
			}

			// Token: 0x0600E8FE RID: 59646 RVA: 0x0038B214 File Offset: 0x00389414
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEquippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEquippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E8FF RID: 59647 RVA: 0x0038B25C File Offset: 0x0038945C
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEquippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E900 RID: 59648 RVA: 0x0038B290 File Offset: 0x00389490
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223872, XrefRangeEnd = 223874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEquippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170046AC RID: 18092
			// (get) Token: 0x0600E901 RID: 59649 RVA: 0x0038B2CC File Offset: 0x003894CC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEquippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E902 RID: 59650 RVA: 0x0038B30C File Offset: 0x0038950C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223874, XrefRangeEnd = 223879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEquippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170046AD RID: 18093
			// (get) Token: 0x0600E903 RID: 59651 RVA: 0x0038B340 File Offset: 0x00389540
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEquippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E904 RID: 59652 RVA: 0x0006DE6A File Offset: 0x0006C06A
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046A9 RID: 18089
			// (get) Token: 0x0600E905 RID: 59653 RVA: 0x0038B380 File Offset: 0x00389580
			// (set) Token: 0x0600E906 RID: 59654 RVA: 0x0006DE73 File Offset: 0x0006C073
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170046AA RID: 18090
			// (get) Token: 0x0600E907 RID: 59655 RVA: 0x0038B3A8 File Offset: 0x003895A8
			// (set) Token: 0x0600E908 RID: 59656 RVA: 0x0006DE8E File Offset: 0x0006C08E
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046AB RID: 18091
			// (get) Token: 0x0600E909 RID: 59657 RVA: 0x0038B3D8 File Offset: 0x003895D8
			// (set) Token: 0x0600E90A RID: 59658 RVA: 0x0006DEAD File Offset: 0x0006C0AD
			public unsafe AvatarEquippable __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009E0C RID: 40460
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009E0D RID: 40461
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009E0E RID: 40462
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009E0F RID: 40463
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009E10 RID: 40464
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009E11 RID: 40465
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009E12 RID: 40466
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009E13 RID: 40467
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009E14 RID: 40468
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
