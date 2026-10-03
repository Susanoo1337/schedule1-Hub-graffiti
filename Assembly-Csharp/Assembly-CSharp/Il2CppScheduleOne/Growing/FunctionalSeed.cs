using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerTasks;
using Il2CppScheduleOne.Trash;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x0200050E RID: 1294
	public class FunctionalSeed : MonoBehaviour
	{
		// Token: 0x060074D0 RID: 29904 RVA: 0x0020A354 File Offset: 0x00208554
		// Note: this type is marked as 'beforefieldinit'.
		static FunctionalSeed()
		{
			Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "FunctionalSeed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr);
			FunctionalSeed.NativeFieldInfoPtr_onSeedExitVial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr, "onSeedExitVial");
			FunctionalSeed.NativeFieldInfoPtr_Vial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr, "Vial");
			FunctionalSeed.NativeFieldInfoPtr_SeedBlocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr, "SeedBlocker");
			FunctionalSeed.NativeFieldInfoPtr_Cap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr, "Cap");
			FunctionalSeed.NativeFieldInfoPtr_SeedCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr, "SeedCollider");
			FunctionalSeed.NativeFieldInfoPtr_SeedRigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr, "SeedRigidbody");
			FunctionalSeed.NativeFieldInfoPtr_TrashPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr, "TrashPrefab");
			FunctionalSeed.NativeMethodInfoPtr_TriggerExit_Public_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr, 100678330);
			FunctionalSeed.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr, 100678331);
		}

		// Token: 0x060074D1 RID: 29905 RVA: 0x0020A438 File Offset: 0x00208638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228554, XrefRangeEnd = 228558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerExit(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalSeed.NativeMethodInfoPtr_TriggerExit_Public_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074D2 RID: 29906 RVA: 0x0020A47C File Offset: 0x0020867C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FunctionalSeed() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalSeed.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074D3 RID: 29907 RVA: 0x00037C13 File Offset: 0x00035E13
		public FunctionalSeed(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002412 RID: 9234
		// (get) Token: 0x060074D4 RID: 29908 RVA: 0x0020A4B8 File Offset: 0x002086B8
		// (set) Token: 0x060074D5 RID: 29909 RVA: 0x00037C1C File Offset: 0x00035E1C
		public unsafe Action onSeedExitVial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_onSeedExitVial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_onSeedExitVial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002413 RID: 9235
		// (get) Token: 0x060074D6 RID: 29910 RVA: 0x0020A4E8 File Offset: 0x002086E8
		// (set) Token: 0x060074D7 RID: 29911 RVA: 0x00037C3B File Offset: 0x00035E3B
		public unsafe Draggable Vial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_Vial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_Vial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002414 RID: 9236
		// (get) Token: 0x060074D8 RID: 29912 RVA: 0x0020A518 File Offset: 0x00208718
		// (set) Token: 0x060074D9 RID: 29913 RVA: 0x00037C5A File Offset: 0x00035E5A
		public unsafe Collider SeedBlocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_SeedBlocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_SeedBlocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002415 RID: 9237
		// (get) Token: 0x060074DA RID: 29914 RVA: 0x0020A548 File Offset: 0x00208748
		// (set) Token: 0x060074DB RID: 29915 RVA: 0x00037C79 File Offset: 0x00035E79
		public unsafe VialCap Cap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_Cap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VialCap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_Cap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002416 RID: 9238
		// (get) Token: 0x060074DC RID: 29916 RVA: 0x0020A578 File Offset: 0x00208778
		// (set) Token: 0x060074DD RID: 29917 RVA: 0x00037C98 File Offset: 0x00035E98
		public unsafe Collider SeedCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_SeedCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_SeedCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002417 RID: 9239
		// (get) Token: 0x060074DE RID: 29918 RVA: 0x0020A5A8 File Offset: 0x002087A8
		// (set) Token: 0x060074DF RID: 29919 RVA: 0x00037CB7 File Offset: 0x00035EB7
		public unsafe Rigidbody SeedRigidbody
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_SeedRigidbody);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_SeedRigidbody), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002418 RID: 9240
		// (get) Token: 0x060074E0 RID: 29920 RVA: 0x0020A5D8 File Offset: 0x002087D8
		// (set) Token: 0x060074E1 RID: 29921 RVA: 0x00037CD6 File Offset: 0x00035ED6
		public unsafe TrashItem TrashPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_TrashPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_TrashPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004F92 RID: 20370
		private static readonly IntPtr NativeFieldInfoPtr_onSeedExitVial;

		// Token: 0x04004F93 RID: 20371
		private static readonly IntPtr NativeFieldInfoPtr_Vial;

		// Token: 0x04004F94 RID: 20372
		private static readonly IntPtr NativeFieldInfoPtr_SeedBlocker;

		// Token: 0x04004F95 RID: 20373
		private static readonly IntPtr NativeFieldInfoPtr_Cap;

		// Token: 0x04004F96 RID: 20374
		private static readonly IntPtr NativeFieldInfoPtr_SeedCollider;

		// Token: 0x04004F97 RID: 20375
		private static readonly IntPtr NativeFieldInfoPtr_SeedRigidbody;

		// Token: 0x04004F98 RID: 20376
		private static readonly IntPtr NativeFieldInfoPtr_TrashPrefab;

		// Token: 0x04004F99 RID: 20377
		private static readonly IntPtr NativeMethodInfoPtr_TriggerExit_Public_Void_Collider_0;

		// Token: 0x04004F9A RID: 20378
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
