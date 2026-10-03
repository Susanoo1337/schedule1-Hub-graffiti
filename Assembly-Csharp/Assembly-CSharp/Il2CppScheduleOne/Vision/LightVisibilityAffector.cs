using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vision
{
	// Token: 0x02000199 RID: 409
	public class LightVisibilityAffector : MonoBehaviour
	{
		// Token: 0x06002943 RID: 10563 RVA: 0x00103858 File Offset: 0x00101A58
		// Note: this type is marked as 'beforefieldinit'.
		static LightVisibilityAffector()
		{
			Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vision", "LightVisibilityAffector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr);
			LightVisibilityAffector.NativeFieldInfoPtr_PointLightEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr, "PointLightEffect");
			LightVisibilityAffector.NativeFieldInfoPtr_SpotLightEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr, "SpotLightEffect");
			LightVisibilityAffector.NativeFieldInfoPtr_EffectMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr, "EffectMultiplier");
			LightVisibilityAffector.NativeFieldInfoPtr_uniquenessCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr, "uniquenessCode");
			LightVisibilityAffector.NativeFieldInfoPtr_updateDistanceThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr, "updateDistanceThreshold");
			LightVisibilityAffector.NativeFieldInfoPtr_light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr, "light");
			LightVisibilityAffector.NativeFieldInfoPtr_attribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr, "attribute");
			LightVisibilityAffector.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr, 100668587);
			LightVisibilityAffector.NativeMethodInfoPtr_PlayerSpawned_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr, 100668588);
			LightVisibilityAffector.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr, 100668589);
			LightVisibilityAffector.NativeMethodInfoPtr_UpdateVisibility_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr, 100668590);
			LightVisibilityAffector.NativeMethodInfoPtr_UpdateAttribute_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr, 100668591);
			LightVisibilityAffector.NativeMethodInfoPtr_ClearAttribute_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr, 100668592);
			LightVisibilityAffector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr, 100668593);
		}

		// Token: 0x06002944 RID: 10564 RVA: 0x001039A0 File Offset: 0x00101BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122616, XrefRangeEnd = 122640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LightVisibilityAffector.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002945 RID: 10565 RVA: 0x001039DC File Offset: 0x00101BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122640, XrefRangeEnd = 122669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerSpawned()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightVisibilityAffector.NativeMethodInfoPtr_PlayerSpawned_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002946 RID: 10566 RVA: 0x00103A10 File Offset: 0x00101C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122669, XrefRangeEnd = 122687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightVisibilityAffector.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002947 RID: 10567 RVA: 0x00103A44 File Offset: 0x00101C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122687, XrefRangeEnd = 122746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateVisibility()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LightVisibilityAffector.NativeMethodInfoPtr_UpdateVisibility_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002948 RID: 10568 RVA: 0x00103A80 File Offset: 0x00101C80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 122751, RefRangeEnd = 122752, XrefRangeStart = 122746, XrefRangeEnd = 122751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAttribute(float visibity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visibity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightVisibilityAffector.NativeMethodInfoPtr_UpdateAttribute_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002949 RID: 10569 RVA: 0x00103AC0 File Offset: 0x00101CC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 122760, RefRangeEnd = 122761, XrefRangeStart = 122752, XrefRangeEnd = 122760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightVisibilityAffector.NativeMethodInfoPtr_ClearAttribute_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600294A RID: 10570 RVA: 0x00103AF4 File Offset: 0x00101CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122761, XrefRangeEnd = 122766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightVisibilityAffector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightVisibilityAffector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600294B RID: 10571 RVA: 0x000159C3 File Offset: 0x00013BC3
		public LightVisibilityAffector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D8B RID: 3467
		// (get) Token: 0x0600294C RID: 10572 RVA: 0x00103B30 File Offset: 0x00101D30
		// (set) Token: 0x0600294D RID: 10573 RVA: 0x000159CC File Offset: 0x00013BCC
		public unsafe static float PointLightEffect
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LightVisibilityAffector.NativeFieldInfoPtr_PointLightEffect, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LightVisibilityAffector.NativeFieldInfoPtr_PointLightEffect, (void*)(&value));
			}
		}

		// Token: 0x17000D8C RID: 3468
		// (get) Token: 0x0600294E RID: 10574 RVA: 0x00103B4C File Offset: 0x00101D4C
		// (set) Token: 0x0600294F RID: 10575 RVA: 0x000159DA File Offset: 0x00013BDA
		public unsafe static float SpotLightEffect
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LightVisibilityAffector.NativeFieldInfoPtr_SpotLightEffect, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LightVisibilityAffector.NativeFieldInfoPtr_SpotLightEffect, (void*)(&value));
			}
		}

		// Token: 0x17000D8D RID: 3469
		// (get) Token: 0x06002950 RID: 10576 RVA: 0x00103B68 File Offset: 0x00101D68
		// (set) Token: 0x06002951 RID: 10577 RVA: 0x000159E8 File Offset: 0x00013BE8
		public unsafe float EffectMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightVisibilityAffector.NativeFieldInfoPtr_EffectMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightVisibilityAffector.NativeFieldInfoPtr_EffectMultiplier)) = value;
			}
		}

		// Token: 0x17000D8E RID: 3470
		// (get) Token: 0x06002952 RID: 10578 RVA: 0x00103B90 File Offset: 0x00101D90
		// (set) Token: 0x06002953 RID: 10579 RVA: 0x00015A03 File Offset: 0x00013C03
		public unsafe string uniquenessCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightVisibilityAffector.NativeFieldInfoPtr_uniquenessCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightVisibilityAffector.NativeFieldInfoPtr_uniquenessCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D8F RID: 3471
		// (get) Token: 0x06002954 RID: 10580 RVA: 0x00103BB8 File Offset: 0x00101DB8
		// (set) Token: 0x06002955 RID: 10581 RVA: 0x00015A22 File Offset: 0x00013C22
		public unsafe int updateDistanceThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightVisibilityAffector.NativeFieldInfoPtr_updateDistanceThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightVisibilityAffector.NativeFieldInfoPtr_updateDistanceThreshold)) = value;
			}
		}

		// Token: 0x17000D90 RID: 3472
		// (get) Token: 0x06002956 RID: 10582 RVA: 0x00103BE0 File Offset: 0x00101DE0
		// (set) Token: 0x06002957 RID: 10583 RVA: 0x00015A3D File Offset: 0x00013C3D
		public unsafe Light light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightVisibilityAffector.NativeFieldInfoPtr_light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightVisibilityAffector.NativeFieldInfoPtr_light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D91 RID: 3473
		// (get) Token: 0x06002958 RID: 10584 RVA: 0x00103C10 File Offset: 0x00101E10
		// (set) Token: 0x06002959 RID: 10585 RVA: 0x00015A5C File Offset: 0x00013C5C
		public unsafe VisibilityAttribute attribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightVisibilityAffector.NativeFieldInfoPtr_attribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisibilityAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightVisibilityAffector.NativeFieldInfoPtr_attribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C6C RID: 7276
		private static readonly IntPtr NativeFieldInfoPtr_PointLightEffect;

		// Token: 0x04001C6D RID: 7277
		private static readonly IntPtr NativeFieldInfoPtr_SpotLightEffect;

		// Token: 0x04001C6E RID: 7278
		private static readonly IntPtr NativeFieldInfoPtr_EffectMultiplier;

		// Token: 0x04001C6F RID: 7279
		private static readonly IntPtr NativeFieldInfoPtr_uniquenessCode;

		// Token: 0x04001C70 RID: 7280
		private static readonly IntPtr NativeFieldInfoPtr_updateDistanceThreshold;

		// Token: 0x04001C71 RID: 7281
		private static readonly IntPtr NativeFieldInfoPtr_light;

		// Token: 0x04001C72 RID: 7282
		private static readonly IntPtr NativeFieldInfoPtr_attribute;

		// Token: 0x04001C73 RID: 7283
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04001C74 RID: 7284
		private static readonly IntPtr NativeMethodInfoPtr_PlayerSpawned_Private_Void_0;

		// Token: 0x04001C75 RID: 7285
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04001C76 RID: 7286
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisibility_Protected_Virtual_New_Void_0;

		// Token: 0x04001C77 RID: 7287
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAttribute_Private_Void_Single_0;

		// Token: 0x04001C78 RID: 7288
		private static readonly IntPtr NativeMethodInfoPtr_ClearAttribute_Private_Void_0;

		// Token: 0x04001C79 RID: 7289
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
