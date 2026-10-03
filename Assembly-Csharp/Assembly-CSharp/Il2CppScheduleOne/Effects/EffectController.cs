using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Effects
{
	// Token: 0x020006A3 RID: 1699
	public class EffectController : NetworkBehaviour
	{
		// Token: 0x0600A5AE RID: 42414 RVA: 0x002BF610 File Offset: 0x002BD810
		// Note: this type is marked as 'beforefieldinit'.
		static EffectController()
		{
			Il2CppClassPointerStore<EffectController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Effects", "EffectController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EffectController>.NativeClassPtr);
			EffectController.NativeFieldInfoPtr__IsActive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectController>.NativeClassPtr, "<IsActive>k__BackingField");
			EffectController.NativeFieldInfoPtr__distanceToPlayerNormalised = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectController>.NativeClassPtr, "_distanceToPlayerNormalised");
			EffectController.NativeFieldInfoPtr__enclosureBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectController>.NativeClassPtr, "_enclosureBlend");
			EffectController.NativeFieldInfoPtr__enclosurePan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectController>.NativeClassPtr, "_enclosurePan");
			EffectController.NativeFieldInfoPtr__playerPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectController>.NativeClassPtr, "_playerPosition");
			EffectController.NativeFieldInfoPtr__anchoredPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectController>.NativeClassPtr, "_anchoredPosition");
			EffectController.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectController>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Effects.EffectControllerAssembly-CSharp.dll_Excuted");
			EffectController.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectController>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Effects.EffectControllerAssembly-CSharp.dll_Excuted");
			EffectController.NativeMethodInfoPtr_Activate_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectController>.NativeClassPtr, 100685267);
			EffectController.NativeMethodInfoPtr_Deactivate_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectController>.NativeClassPtr, 100685268);
			EffectController.NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectController>.NativeClassPtr, 100685269);
			EffectController.NativeMethodInfoPtr_set_IsActive_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectController>.NativeClassPtr, 100685270);
			EffectController.NativeMethodInfoPtr_UpdateProperties_Public_Virtual_New_Void_Vector3_Vector3_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectController>.NativeClassPtr, 100685271);
			EffectController.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectController>.NativeClassPtr, 100685272);
			EffectController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectController>.NativeClassPtr, 100685273);
			EffectController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectController>.NativeClassPtr, 100685274);
			EffectController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectController>.NativeClassPtr, 100685275);
			EffectController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectController>.NativeClassPtr, 100685276);
		}

		// Token: 0x0600A5AF RID: 42415 RVA: 0x002BF7A8 File Offset: 0x002BD9A8
		[CallerCount(0)]
		public unsafe virtual void Activate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EffectController.NativeMethodInfoPtr_Activate_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5B0 RID: 42416 RVA: 0x002BF7E4 File Offset: 0x002BD9E4
		[CallerCount(0)]
		public unsafe virtual void Deactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EffectController.NativeMethodInfoPtr_Deactivate_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170031C3 RID: 12739
		// (get) Token: 0x0600A5B1 RID: 42417 RVA: 0x002BF820 File Offset: 0x002BDA20
		// (set) Token: 0x0600A5B2 RID: 42418 RVA: 0x002BF85C File Offset: 0x002BDA5C
		public unsafe bool IsActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectController.NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectController.NativeMethodInfoPtr_set_IsActive_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A5B3 RID: 42419 RVA: 0x002BF89C File Offset: 0x002BDA9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 289694, RefRangeEnd = 289696, XrefRangeStart = 289694, XrefRangeEnd = 289694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateProperties(Vector3 anchorPosition, Vector3 playerPosition, float sqrDistanceToPlayer, float enclosureBlend, float enclosurePan)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref anchorPosition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sqrDistanceToPlayer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enclosureBlend;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enclosurePan;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EffectController.NativeMethodInfoPtr_UpdateProperties_Public_Virtual_New_Void_Vector3_Vector3_Single_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5B4 RID: 42420 RVA: 0x002BF920 File Offset: 0x002BDB20
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 289701, RefRangeEnd = 289704, XrefRangeStart = 289696, XrefRangeEnd = 289701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EffectController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EffectController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectController.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5B5 RID: 42421 RVA: 0x002BF95C File Offset: 0x002BDB5C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 289704, RefRangeEnd = 289707, XrefRangeStart = 289704, XrefRangeEnd = 289704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EffectController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5B6 RID: 42422 RVA: 0x002BF998 File Offset: 0x002BDB98
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 216767, RefRangeEnd = 216770, XrefRangeStart = 216767, XrefRangeEnd = 216770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EffectController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5B7 RID: 42423 RVA: 0x002BF9D4 File Offset: 0x002BDBD4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EffectController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5B8 RID: 42424 RVA: 0x002BFA10 File Offset: 0x002BDC10
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EffectController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5B9 RID: 42425 RVA: 0x0004BA7B File Offset: 0x00049C7B
		public EffectController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170031BB RID: 12731
		// (get) Token: 0x0600A5BA RID: 42426 RVA: 0x002BFA4C File Offset: 0x002BDC4C
		// (set) Token: 0x0600A5BB RID: 42427 RVA: 0x0004BA84 File Offset: 0x00049C84
		public unsafe bool _IsActive_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectController.NativeFieldInfoPtr__IsActive_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectController.NativeFieldInfoPtr__IsActive_k__BackingField)) = value;
			}
		}

		// Token: 0x170031BC RID: 12732
		// (get) Token: 0x0600A5BC RID: 42428 RVA: 0x002BFA74 File Offset: 0x002BDC74
		// (set) Token: 0x0600A5BD RID: 42429 RVA: 0x0004BA9F File Offset: 0x00049C9F
		public unsafe float _distanceToPlayerNormalised
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectController.NativeFieldInfoPtr__distanceToPlayerNormalised);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectController.NativeFieldInfoPtr__distanceToPlayerNormalised)) = value;
			}
		}

		// Token: 0x170031BD RID: 12733
		// (get) Token: 0x0600A5BE RID: 42430 RVA: 0x002BFA9C File Offset: 0x002BDC9C
		// (set) Token: 0x0600A5BF RID: 42431 RVA: 0x0004BABA File Offset: 0x00049CBA
		public unsafe float _enclosureBlend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectController.NativeFieldInfoPtr__enclosureBlend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectController.NativeFieldInfoPtr__enclosureBlend)) = value;
			}
		}

		// Token: 0x170031BE RID: 12734
		// (get) Token: 0x0600A5C0 RID: 42432 RVA: 0x002BFAC4 File Offset: 0x002BDCC4
		// (set) Token: 0x0600A5C1 RID: 42433 RVA: 0x0004BAD5 File Offset: 0x00049CD5
		public unsafe float _enclosurePan
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectController.NativeFieldInfoPtr__enclosurePan);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectController.NativeFieldInfoPtr__enclosurePan)) = value;
			}
		}

		// Token: 0x170031BF RID: 12735
		// (get) Token: 0x0600A5C2 RID: 42434 RVA: 0x002BFAEC File Offset: 0x002BDCEC
		// (set) Token: 0x0600A5C3 RID: 42435 RVA: 0x0004BAF0 File Offset: 0x00049CF0
		public unsafe Vector3 _playerPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectController.NativeFieldInfoPtr__playerPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectController.NativeFieldInfoPtr__playerPosition)) = value;
			}
		}

		// Token: 0x170031C0 RID: 12736
		// (get) Token: 0x0600A5C4 RID: 42436 RVA: 0x002BFB14 File Offset: 0x002BDD14
		// (set) Token: 0x0600A5C5 RID: 42437 RVA: 0x0004BB0B File Offset: 0x00049D0B
		public unsafe Vector3 _anchoredPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectController.NativeFieldInfoPtr__anchoredPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectController.NativeFieldInfoPtr__anchoredPosition)) = value;
			}
		}

		// Token: 0x170031C1 RID: 12737
		// (get) Token: 0x0600A5C6 RID: 42438 RVA: 0x002BFB3C File Offset: 0x002BDD3C
		// (set) Token: 0x0600A5C7 RID: 42439 RVA: 0x0004BB26 File Offset: 0x00049D26
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectController.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectController.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170031C2 RID: 12738
		// (get) Token: 0x0600A5C8 RID: 42440 RVA: 0x002BFB64 File Offset: 0x002BDD64
		// (set) Token: 0x0600A5C9 RID: 42441 RVA: 0x0004BB41 File Offset: 0x00049D41
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectController.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectController.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04007299 RID: 29337
		private static readonly IntPtr NativeFieldInfoPtr__IsActive_k__BackingField;

		// Token: 0x0400729A RID: 29338
		private static readonly IntPtr NativeFieldInfoPtr__distanceToPlayerNormalised;

		// Token: 0x0400729B RID: 29339
		private static readonly IntPtr NativeFieldInfoPtr__enclosureBlend;

		// Token: 0x0400729C RID: 29340
		private static readonly IntPtr NativeFieldInfoPtr__enclosurePan;

		// Token: 0x0400729D RID: 29341
		private static readonly IntPtr NativeFieldInfoPtr__playerPosition;

		// Token: 0x0400729E RID: 29342
		private static readonly IntPtr NativeFieldInfoPtr__anchoredPosition;

		// Token: 0x0400729F RID: 29343
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040072A0 RID: 29344
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040072A1 RID: 29345
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040072A2 RID: 29346
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040072A3 RID: 29347
		private static readonly IntPtr NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0;

		// Token: 0x040072A4 RID: 29348
		private static readonly IntPtr NativeMethodInfoPtr_set_IsActive_Protected_set_Void_Boolean_0;

		// Token: 0x040072A5 RID: 29349
		private static readonly IntPtr NativeMethodInfoPtr_UpdateProperties_Public_Virtual_New_Void_Vector3_Vector3_Single_Single_Single_0;

		// Token: 0x040072A6 RID: 29350
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040072A7 RID: 29351
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040072A8 RID: 29352
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040072A9 RID: 29353
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040072AA RID: 29354
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
