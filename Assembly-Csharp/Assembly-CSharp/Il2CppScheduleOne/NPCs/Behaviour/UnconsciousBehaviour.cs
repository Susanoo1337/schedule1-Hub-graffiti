using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000689 RID: 1673
	public class UnconsciousBehaviour : Behaviour
	{
		// Token: 0x0600A285 RID: 41605 RVA: 0x002B3EF8 File Offset: 0x002B20F8
		// Note: this type is marked as 'beforefieldinit'.
		static UnconsciousBehaviour()
		{
			Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "UnconsciousBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr);
			UnconsciousBehaviour.NativeFieldInfoPtr_SnoreInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, "SnoreInterval");
			UnconsciousBehaviour.NativeFieldInfoPtr_SnoreChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, "SnoreChance");
			UnconsciousBehaviour.NativeFieldInfoPtr_Particles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, "Particles");
			UnconsciousBehaviour.NativeFieldInfoPtr_PlaySnoreSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, "PlaySnoreSounds");
			UnconsciousBehaviour.NativeFieldInfoPtr_timeOnLastSnore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, "timeOnLastSnore");
			UnconsciousBehaviour.NativeFieldInfoPtr__shouldPlaySnoreSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, "_shouldPlaySnoreSounds");
			UnconsciousBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.UnconsciousBehaviourAssembly-CSharp.dll_Excuted");
			UnconsciousBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.UnconsciousBehaviourAssembly-CSharp.dll_Excuted");
			UnconsciousBehaviour.NativeMethodInfoPtr_Activate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, 100684797);
			UnconsciousBehaviour.NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, 100684798);
			UnconsciousBehaviour.NativeMethodInfoPtr_OnActiveTick_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, 100684799);
			UnconsciousBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, 100684800);
			UnconsciousBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, 100684801);
			UnconsciousBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, 100684802);
			UnconsciousBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, 100684803);
			UnconsciousBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, 100684804);
			UnconsciousBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, 100684805);
		}

		// Token: 0x0600A286 RID: 41606 RVA: 0x002B407C File Offset: 0x002B227C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286437, XrefRangeEnd = 286464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Activate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnconsciousBehaviour.NativeMethodInfoPtr_Activate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A287 RID: 41607 RVA: 0x002B40B8 File Offset: 0x002B22B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286464, XrefRangeEnd = 286478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Deactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnconsciousBehaviour.NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A288 RID: 41608 RVA: 0x002B40F4 File Offset: 0x002B22F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286478, XrefRangeEnd = 286483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnActiveTick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnconsciousBehaviour.NativeMethodInfoPtr_OnActiveTick_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A289 RID: 41609 RVA: 0x002B4130 File Offset: 0x002B2330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnconsciousBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A28A RID: 41610 RVA: 0x002B416C File Offset: 0x002B236C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnconsciousBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnconsciousBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A28B RID: 41611 RVA: 0x002B41A8 File Offset: 0x002B23A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286483, XrefRangeEnd = 286484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnconsciousBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A28C RID: 41612 RVA: 0x002B41E4 File Offset: 0x002B23E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286484, XrefRangeEnd = 286485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnconsciousBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A28D RID: 41613 RVA: 0x002B4220 File Offset: 0x002B2420
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnconsciousBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A28E RID: 41614 RVA: 0x002B425C File Offset: 0x002B245C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnconsciousBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A28F RID: 41615 RVA: 0x0004A87E File Offset: 0x00048A7E
		public UnconsciousBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030FA RID: 12538
		// (get) Token: 0x0600A290 RID: 41616 RVA: 0x002B4298 File Offset: 0x002B2498
		// (set) Token: 0x0600A291 RID: 41617 RVA: 0x0004A887 File Offset: 0x00048A87
		public unsafe static float SnoreInterval
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(UnconsciousBehaviour.NativeFieldInfoPtr_SnoreInterval, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnconsciousBehaviour.NativeFieldInfoPtr_SnoreInterval, (void*)(&value));
			}
		}

		// Token: 0x170030FB RID: 12539
		// (get) Token: 0x0600A292 RID: 41618 RVA: 0x002B42B4 File Offset: 0x002B24B4
		// (set) Token: 0x0600A293 RID: 41619 RVA: 0x0004A895 File Offset: 0x00048A95
		public unsafe static float SnoreChance
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(UnconsciousBehaviour.NativeFieldInfoPtr_SnoreChance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnconsciousBehaviour.NativeFieldInfoPtr_SnoreChance, (void*)(&value));
			}
		}

		// Token: 0x170030FC RID: 12540
		// (get) Token: 0x0600A294 RID: 41620 RVA: 0x002B42D0 File Offset: 0x002B24D0
		// (set) Token: 0x0600A295 RID: 41621 RVA: 0x0004A8A3 File Offset: 0x00048AA3
		public unsafe ParticleSystem Particles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconsciousBehaviour.NativeFieldInfoPtr_Particles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconsciousBehaviour.NativeFieldInfoPtr_Particles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030FD RID: 12541
		// (get) Token: 0x0600A296 RID: 41622 RVA: 0x002B4300 File Offset: 0x002B2500
		// (set) Token: 0x0600A297 RID: 41623 RVA: 0x0004A8C2 File Offset: 0x00048AC2
		public unsafe bool PlaySnoreSounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconsciousBehaviour.NativeFieldInfoPtr_PlaySnoreSounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconsciousBehaviour.NativeFieldInfoPtr_PlaySnoreSounds)) = value;
			}
		}

		// Token: 0x170030FE RID: 12542
		// (get) Token: 0x0600A298 RID: 41624 RVA: 0x002B4328 File Offset: 0x002B2528
		// (set) Token: 0x0600A299 RID: 41625 RVA: 0x0004A8DD File Offset: 0x00048ADD
		public unsafe float timeOnLastSnore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconsciousBehaviour.NativeFieldInfoPtr_timeOnLastSnore);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconsciousBehaviour.NativeFieldInfoPtr_timeOnLastSnore)) = value;
			}
		}

		// Token: 0x170030FF RID: 12543
		// (get) Token: 0x0600A29A RID: 41626 RVA: 0x002B4350 File Offset: 0x002B2550
		// (set) Token: 0x0600A29B RID: 41627 RVA: 0x0004A8F8 File Offset: 0x00048AF8
		public unsafe bool _shouldPlaySnoreSounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconsciousBehaviour.NativeFieldInfoPtr__shouldPlaySnoreSounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconsciousBehaviour.NativeFieldInfoPtr__shouldPlaySnoreSounds)) = value;
			}
		}

		// Token: 0x17003100 RID: 12544
		// (get) Token: 0x0600A29C RID: 41628 RVA: 0x002B4378 File Offset: 0x002B2578
		// (set) Token: 0x0600A29D RID: 41629 RVA: 0x0004A913 File Offset: 0x00048B13
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconsciousBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconsciousBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17003101 RID: 12545
		// (get) Token: 0x0600A29E RID: 41630 RVA: 0x002B43A0 File Offset: 0x002B25A0
		// (set) Token: 0x0600A29F RID: 41631 RVA: 0x0004A92E File Offset: 0x00048B2E
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconsciousBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconsciousBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04007045 RID: 28741
		private static readonly IntPtr NativeFieldInfoPtr_SnoreInterval;

		// Token: 0x04007046 RID: 28742
		private static readonly IntPtr NativeFieldInfoPtr_SnoreChance;

		// Token: 0x04007047 RID: 28743
		private static readonly IntPtr NativeFieldInfoPtr_Particles;

		// Token: 0x04007048 RID: 28744
		private static readonly IntPtr NativeFieldInfoPtr_PlaySnoreSounds;

		// Token: 0x04007049 RID: 28745
		private static readonly IntPtr NativeFieldInfoPtr_timeOnLastSnore;

		// Token: 0x0400704A RID: 28746
		private static readonly IntPtr NativeFieldInfoPtr__shouldPlaySnoreSounds;

		// Token: 0x0400704B RID: 28747
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400704C RID: 28748
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400704D RID: 28749
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Virtual_Void_0;

		// Token: 0x0400704E RID: 28750
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0;

		// Token: 0x0400704F RID: 28751
		private static readonly IntPtr NativeMethodInfoPtr_OnActiveTick_Public_Virtual_Void_0;

		// Token: 0x04007050 RID: 28752
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Virtual_Void_0;

		// Token: 0x04007051 RID: 28753
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007052 RID: 28754
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04007053 RID: 28755
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04007054 RID: 28756
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04007055 RID: 28757
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
