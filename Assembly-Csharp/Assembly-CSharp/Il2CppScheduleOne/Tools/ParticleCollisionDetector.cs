using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004EF RID: 1263
	public class ParticleCollisionDetector : MonoBehaviour
	{
		// Token: 0x06007278 RID: 29304 RVA: 0x00203638 File Offset: 0x00201838
		// Note: this type is marked as 'beforefieldinit'.
		static ParticleCollisionDetector()
		{
			Il2CppClassPointerStore<ParticleCollisionDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "ParticleCollisionDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleCollisionDetector>.NativeClassPtr);
			ParticleCollisionDetector.NativeFieldInfoPtr_onCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleCollisionDetector>.NativeClassPtr, "onCollision");
			ParticleCollisionDetector.NativeFieldInfoPtr_ps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleCollisionDetector>.NativeClassPtr, "ps");
			ParticleCollisionDetector.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleCollisionDetector>.NativeClassPtr, 100678097);
			ParticleCollisionDetector.NativeMethodInfoPtr_OnParticleCollision_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleCollisionDetector>.NativeClassPtr, 100678098);
			ParticleCollisionDetector.NativeMethodInfoPtr_OnParticleTrigger_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleCollisionDetector>.NativeClassPtr, 100678099);
			ParticleCollisionDetector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleCollisionDetector>.NativeClassPtr, 100678100);
		}

		// Token: 0x06007279 RID: 29305 RVA: 0x002036E0 File Offset: 0x002018E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226382, XrefRangeEnd = 226386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleCollisionDetector.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600727A RID: 29306 RVA: 0x00203714 File Offset: 0x00201914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226386, XrefRangeEnd = 226389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnParticleCollision(GameObject other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleCollisionDetector.NativeMethodInfoPtr_OnParticleCollision_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600727B RID: 29307 RVA: 0x00203758 File Offset: 0x00201958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226389, XrefRangeEnd = 226399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnParticleTrigger()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleCollisionDetector.NativeMethodInfoPtr_OnParticleTrigger_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600727C RID: 29308 RVA: 0x0020378C File Offset: 0x0020198C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226399, XrefRangeEnd = 226407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParticleCollisionDetector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleCollisionDetector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleCollisionDetector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600727D RID: 29309 RVA: 0x00036707 File Offset: 0x00034907
		public ParticleCollisionDetector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002354 RID: 9044
		// (get) Token: 0x0600727E RID: 29310 RVA: 0x002037C8 File Offset: 0x002019C8
		// (set) Token: 0x0600727F RID: 29311 RVA: 0x00036710 File Offset: 0x00034910
		public unsafe UnityEvent<GameObject> onCollision
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleCollisionDetector.NativeFieldInfoPtr_onCollision);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleCollisionDetector.NativeFieldInfoPtr_onCollision), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002355 RID: 9045
		// (get) Token: 0x06007280 RID: 29312 RVA: 0x002037F8 File Offset: 0x002019F8
		// (set) Token: 0x06007281 RID: 29313 RVA: 0x0003672F File Offset: 0x0003492F
		public unsafe ParticleSystem ps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleCollisionDetector.NativeFieldInfoPtr_ps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleCollisionDetector.NativeFieldInfoPtr_ps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004E2B RID: 20011
		private static readonly IntPtr NativeFieldInfoPtr_onCollision;

		// Token: 0x04004E2C RID: 20012
		private static readonly IntPtr NativeFieldInfoPtr_ps;

		// Token: 0x04004E2D RID: 20013
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004E2E RID: 20014
		private static readonly IntPtr NativeMethodInfoPtr_OnParticleCollision_Public_Void_GameObject_0;

		// Token: 0x04004E2F RID: 20015
		private static readonly IntPtr NativeMethodInfoPtr_OnParticleTrigger_Private_Void_0;

		// Token: 0x04004E30 RID: 20016
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
