using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Combat;
using Il2CppScheduleOne.Core.Audio;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x02000480 RID: 1152
	public class RBImpactSounds : MonoBehaviour
	{
		// Token: 0x060067D3 RID: 26579 RVA: 0x001E251C File Offset: 0x001E071C
		// Note: this type is marked as 'beforefieldinit'.
		static RBImpactSounds()
		{
			Il2CppClassPointerStore<RBImpactSounds>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "RBImpactSounds");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RBImpactSounds>.NativeClassPtr);
			RBImpactSounds.NativeFieldInfoPtr_MinImpactMomentum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RBImpactSounds>.NativeClassPtr, "MinImpactMomentum");
			RBImpactSounds.NativeFieldInfoPtr_SoundCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RBImpactSounds>.NativeClassPtr, "SoundCooldown");
			RBImpactSounds.NativeFieldInfoPtr__material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RBImpactSounds>.NativeClassPtr, "_material");
			RBImpactSounds.NativeFieldInfoPtr__lastImpactTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RBImpactSounds>.NativeClassPtr, "_lastImpactTime");
			RBImpactSounds.NativeFieldInfoPtr__rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RBImpactSounds>.NativeClassPtr, "_rb");
			RBImpactSounds.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBImpactSounds>.NativeClassPtr, 100676877);
			RBImpactSounds.NativeMethodInfoPtr_OnImpacted_Private_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBImpactSounds>.NativeClassPtr, 100676878);
			RBImpactSounds.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBImpactSounds>.NativeClassPtr, 100676879);
			RBImpactSounds.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RBImpactSounds>.NativeClassPtr, 100676880);
		}

		// Token: 0x060067D4 RID: 26580 RVA: 0x001E2600 File Offset: 0x001E0800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215466, XrefRangeEnd = 215493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBImpactSounds.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067D5 RID: 26581 RVA: 0x001E2634 File Offset: 0x001E0834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215493, XrefRangeEnd = 215501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnImpacted(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBImpactSounds.NativeMethodInfoPtr_OnImpacted_Private_Void_Impact_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067D6 RID: 26582 RVA: 0x001E2678 File Offset: 0x001E0878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215501, XrefRangeEnd = 215521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollisionEnter(Collision collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBImpactSounds.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067D7 RID: 26583 RVA: 0x001E26BC File Offset: 0x001E08BC
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RBImpactSounds() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RBImpactSounds>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RBImpactSounds.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067D8 RID: 26584 RVA: 0x00030E9D File Offset: 0x0002F09D
		public RBImpactSounds(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FC5 RID: 8133
		// (get) Token: 0x060067D9 RID: 26585 RVA: 0x001E26F8 File Offset: 0x001E08F8
		// (set) Token: 0x060067DA RID: 26586 RVA: 0x00030EA6 File Offset: 0x0002F0A6
		public unsafe static float MinImpactMomentum
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(RBImpactSounds.NativeFieldInfoPtr_MinImpactMomentum, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RBImpactSounds.NativeFieldInfoPtr_MinImpactMomentum, (void*)(&value));
			}
		}

		// Token: 0x17001FC6 RID: 8134
		// (get) Token: 0x060067DB RID: 26587 RVA: 0x001E2714 File Offset: 0x001E0914
		// (set) Token: 0x060067DC RID: 26588 RVA: 0x00030EB4 File Offset: 0x0002F0B4
		public unsafe static float SoundCooldown
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(RBImpactSounds.NativeFieldInfoPtr_SoundCooldown, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RBImpactSounds.NativeFieldInfoPtr_SoundCooldown, (void*)(&value));
			}
		}

		// Token: 0x17001FC7 RID: 8135
		// (get) Token: 0x060067DD RID: 26589 RVA: 0x001E2730 File Offset: 0x001E0930
		// (set) Token: 0x060067DE RID: 26590 RVA: 0x00030EC2 File Offset: 0x0002F0C2
		public unsafe EImpactSound _material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBImpactSounds.NativeFieldInfoPtr__material);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBImpactSounds.NativeFieldInfoPtr__material)) = value;
			}
		}

		// Token: 0x17001FC8 RID: 8136
		// (get) Token: 0x060067DF RID: 26591 RVA: 0x001E2758 File Offset: 0x001E0958
		// (set) Token: 0x060067E0 RID: 26592 RVA: 0x00030EDD File Offset: 0x0002F0DD
		public unsafe float _lastImpactTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBImpactSounds.NativeFieldInfoPtr__lastImpactTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBImpactSounds.NativeFieldInfoPtr__lastImpactTime)) = value;
			}
		}

		// Token: 0x17001FC9 RID: 8137
		// (get) Token: 0x060067E1 RID: 26593 RVA: 0x001E2780 File Offset: 0x001E0980
		// (set) Token: 0x060067E2 RID: 26594 RVA: 0x00030EF8 File Offset: 0x0002F0F8
		public unsafe Rigidbody _rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBImpactSounds.NativeFieldInfoPtr__rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RBImpactSounds.NativeFieldInfoPtr__rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400476E RID: 18286
		private static readonly IntPtr NativeFieldInfoPtr_MinImpactMomentum;

		// Token: 0x0400476F RID: 18287
		private static readonly IntPtr NativeFieldInfoPtr_SoundCooldown;

		// Token: 0x04004770 RID: 18288
		private static readonly IntPtr NativeFieldInfoPtr__material;

		// Token: 0x04004771 RID: 18289
		private static readonly IntPtr NativeFieldInfoPtr__lastImpactTime;

		// Token: 0x04004772 RID: 18290
		private static readonly IntPtr NativeFieldInfoPtr__rb;

		// Token: 0x04004773 RID: 18291
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004774 RID: 18292
		private static readonly IntPtr NativeMethodInfoPtr_OnImpacted_Private_Void_Impact_0;

		// Token: 0x04004775 RID: 18293
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0;

		// Token: 0x04004776 RID: 18294
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
