using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020002C2 RID: 706
	public class ParkingLot : MonoBehaviour
	{
		// Token: 0x060036A7 RID: 13991 RVA: 0x00130E14 File Offset: 0x0012F014
		// Note: this type is marked as 'beforefieldinit'.
		static ParkingLot()
		{
			Il2CppClassPointerStore<ParkingLot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "ParkingLot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr);
			ParkingLot.NativeFieldInfoPtr_BakedGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, "BakedGUID");
			ParkingLot.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, "<GUID>k__BackingField");
			ParkingLot.NativeFieldInfoPtr_ParkingSpots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, "ParkingSpots");
			ParkingLot.NativeFieldInfoPtr_EntryPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, "EntryPoint");
			ParkingLot.NativeFieldInfoPtr_HiddenVehicleAccessPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, "HiddenVehicleAccessPoint");
			ParkingLot.NativeFieldInfoPtr_UseExitPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, "UseExitPoint");
			ParkingLot.NativeFieldInfoPtr_ExitAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, "ExitAlignment");
			ParkingLot.NativeFieldInfoPtr_ExitPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, "ExitPoint");
			ParkingLot.NativeFieldInfoPtr_ExitPointVehicleDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, "ExitPointVehicleDetector");
			ParkingLot.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, 100670205);
			ParkingLot.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, 100670206);
			ParkingLot.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, 100670207);
			ParkingLot.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, 100670208);
			ParkingLot.NativeMethodInfoPtr_GetRandomFreeSpot_Public_ParkingSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, 100670209);
			ParkingLot.NativeMethodInfoPtr_GetRandomFreeSpotIndex_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, 100670210);
			ParkingLot.NativeMethodInfoPtr_GetFreeParkingSpots_Public_List_1_ParkingSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, 100670211);
			ParkingLot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, 100670212);
		}

		// Token: 0x1700114C RID: 4428
		// (get) Token: 0x060036A8 RID: 13992 RVA: 0x00130F98 File Offset: 0x0012F198
		// (set) Token: 0x060036A9 RID: 13993 RVA: 0x00130FD4 File Offset: 0x0012F1D4
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingLot.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 49913, RefRangeEnd = 49917, XrefRangeStart = 49913, XrefRangeEnd = 49917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingLot.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060036AA RID: 13994 RVA: 0x00131014 File Offset: 0x0012F214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142475, XrefRangeEnd = 142518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingLot.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036AB RID: 13995 RVA: 0x00131048 File Offset: 0x0012F248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142518, XrefRangeEnd = 142522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingLot.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036AC RID: 13996 RVA: 0x00131088 File Offset: 0x0012F288
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 142539, RefRangeEnd = 142540, XrefRangeStart = 142522, XrefRangeEnd = 142539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParkingSpot GetRandomFreeSpot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingLot.NativeMethodInfoPtr_GetRandomFreeSpot_Public_ParkingSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParkingSpot>(intPtr3) : null;
		}

		// Token: 0x060036AD RID: 13997 RVA: 0x001310C8 File Offset: 0x0012F2C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 142549, RefRangeEnd = 142551, XrefRangeStart = 142540, XrefRangeEnd = 142549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetRandomFreeSpotIndex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingLot.NativeMethodInfoPtr_GetRandomFreeSpotIndex_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060036AE RID: 13998 RVA: 0x00131104 File Offset: 0x0012F304
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 142579, RefRangeEnd = 142581, XrefRangeStart = 142551, XrefRangeEnd = 142579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ParkingSpot> GetFreeParkingSpots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingLot.NativeMethodInfoPtr_GetFreeParkingSpots_Public_List_1_ParkingSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ParkingSpot>>(intPtr3) : null;
		}

		// Token: 0x060036AF RID: 13999 RVA: 0x00131144 File Offset: 0x0012F344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142581, XrefRangeEnd = 142592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParkingLot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingLot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036B0 RID: 14000 RVA: 0x0001BC39 File Offset: 0x00019E39
		public ParkingLot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001143 RID: 4419
		// (get) Token: 0x060036B1 RID: 14001 RVA: 0x00131180 File Offset: 0x0012F380
		// (set) Token: 0x060036B2 RID: 14002 RVA: 0x0001BC42 File Offset: 0x00019E42
		public unsafe string BakedGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_BakedGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_BakedGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001144 RID: 4420
		// (get) Token: 0x060036B3 RID: 14003 RVA: 0x001311A8 File Offset: 0x0012F3A8
		// (set) Token: 0x060036B4 RID: 14004 RVA: 0x0001BC61 File Offset: 0x00019E61
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x17001145 RID: 4421
		// (get) Token: 0x060036B5 RID: 14005 RVA: 0x001311D0 File Offset: 0x0012F3D0
		// (set) Token: 0x060036B6 RID: 14006 RVA: 0x0001BC7C File Offset: 0x00019E7C
		public unsafe List<ParkingSpot> ParkingSpots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_ParkingSpots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ParkingSpot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_ParkingSpots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001146 RID: 4422
		// (get) Token: 0x060036B7 RID: 14007 RVA: 0x00131200 File Offset: 0x0012F400
		// (set) Token: 0x060036B8 RID: 14008 RVA: 0x0001BC9B File Offset: 0x00019E9B
		public unsafe Transform EntryPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_EntryPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_EntryPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001147 RID: 4423
		// (get) Token: 0x060036B9 RID: 14009 RVA: 0x00131230 File Offset: 0x0012F430
		// (set) Token: 0x060036BA RID: 14010 RVA: 0x0001BCBA File Offset: 0x00019EBA
		public unsafe Transform HiddenVehicleAccessPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_HiddenVehicleAccessPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_HiddenVehicleAccessPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001148 RID: 4424
		// (get) Token: 0x060036BB RID: 14011 RVA: 0x00131260 File Offset: 0x0012F460
		// (set) Token: 0x060036BC RID: 14012 RVA: 0x0001BCD9 File Offset: 0x00019ED9
		public unsafe bool UseExitPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_UseExitPoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_UseExitPoint)) = value;
			}
		}

		// Token: 0x17001149 RID: 4425
		// (get) Token: 0x060036BD RID: 14013 RVA: 0x00131288 File Offset: 0x0012F488
		// (set) Token: 0x060036BE RID: 14014 RVA: 0x0001BCF4 File Offset: 0x00019EF4
		public unsafe EParkingAlignment ExitAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_ExitAlignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_ExitAlignment)) = value;
			}
		}

		// Token: 0x1700114A RID: 4426
		// (get) Token: 0x060036BF RID: 14015 RVA: 0x001312B0 File Offset: 0x0012F4B0
		// (set) Token: 0x060036C0 RID: 14016 RVA: 0x0001BD0F File Offset: 0x00019F0F
		public unsafe Transform ExitPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_ExitPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_ExitPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700114B RID: 4427
		// (get) Token: 0x060036C1 RID: 14017 RVA: 0x001312E0 File Offset: 0x0012F4E0
		// (set) Token: 0x060036C2 RID: 14018 RVA: 0x0001BD2E File Offset: 0x00019F2E
		public unsafe VehicleDetector ExitPointVehicleDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_ExitPointVehicleDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_ExitPointVehicleDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002493 RID: 9363
		private static readonly IntPtr NativeFieldInfoPtr_BakedGUID;

		// Token: 0x04002494 RID: 9364
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04002495 RID: 9365
		private static readonly IntPtr NativeFieldInfoPtr_ParkingSpots;

		// Token: 0x04002496 RID: 9366
		private static readonly IntPtr NativeFieldInfoPtr_EntryPoint;

		// Token: 0x04002497 RID: 9367
		private static readonly IntPtr NativeFieldInfoPtr_HiddenVehicleAccessPoint;

		// Token: 0x04002498 RID: 9368
		private static readonly IntPtr NativeFieldInfoPtr_UseExitPoint;

		// Token: 0x04002499 RID: 9369
		private static readonly IntPtr NativeFieldInfoPtr_ExitAlignment;

		// Token: 0x0400249A RID: 9370
		private static readonly IntPtr NativeFieldInfoPtr_ExitPoint;

		// Token: 0x0400249B RID: 9371
		private static readonly IntPtr NativeFieldInfoPtr_ExitPointVehicleDetector;

		// Token: 0x0400249C RID: 9372
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x0400249D RID: 9373
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x0400249E RID: 9374
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400249F RID: 9375
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x040024A0 RID: 9376
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomFreeSpot_Public_ParkingSpot_0;

		// Token: 0x040024A1 RID: 9377
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomFreeSpotIndex_Public_Int32_0;

		// Token: 0x040024A2 RID: 9378
		private static readonly IntPtr NativeMethodInfoPtr_GetFreeParkingSpots_Public_List_1_ParkingSpot_0;

		// Token: 0x040024A3 RID: 9379
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A17 RID: 2583
		[ObfuscatedName("ScheduleOne.Map.ParkingLot+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DE48 RID: 56904 RVA: 0x0036D188 File Offset: 0x0036B388
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ParkingLot.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParkingLot.__c>.NativeClassPtr);
				ParkingLot.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingLot.__c>.NativeClassPtr, "<>9");
				ParkingLot.__c.NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingLot.__c>.NativeClassPtr, "<>9__16_0");
				ParkingLot.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingLot.__c>.NativeClassPtr, 100670214);
				ParkingLot.__c.NativeMethodInfoPtr__GetFreeParkingSpots_b__16_0_Internal_Boolean_ParkingSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingLot.__c>.NativeClassPtr, 100670215);
			}

			// Token: 0x0600DE49 RID: 56905 RVA: 0x0036D204 File Offset: 0x0036B404
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParkingLot.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingLot.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE4A RID: 56906 RVA: 0x0036D240 File Offset: 0x0036B440
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142471, XrefRangeEnd = 142475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetFreeParkingSpots_b__16_0(ParkingSpot x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingLot.__c.NativeMethodInfoPtr__GetFreeParkingSpots_b__16_0_Internal_Boolean_ParkingSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DE4B RID: 56907 RVA: 0x00068A5A File Offset: 0x00066C5A
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043AD RID: 17325
			// (get) Token: 0x0600DE4C RID: 56908 RVA: 0x0036D290 File Offset: 0x0036B490
			// (set) Token: 0x0600DE4D RID: 56909 RVA: 0x00068A63 File Offset: 0x00066C63
			public unsafe static ParkingLot.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ParkingLot.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParkingLot.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ParkingLot.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043AE RID: 17326
			// (get) Token: 0x0600DE4E RID: 56910 RVA: 0x0036D2B8 File Offset: 0x0036B4B8
			// (set) Token: 0x0600DE4F RID: 56911 RVA: 0x00068A75 File Offset: 0x00066C75
			public unsafe static Func<ParkingSpot, bool> __9__16_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ParkingLot.__c.NativeFieldInfoPtr___9__16_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ParkingSpot, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ParkingLot.__c.NativeFieldInfoPtr___9__16_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400976C RID: 38764
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400976D RID: 38765
			private static readonly IntPtr NativeFieldInfoPtr___9__16_0;

			// Token: 0x0400976E RID: 38766
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400976F RID: 38767
			private static readonly IntPtr NativeMethodInfoPtr__GetFreeParkingSpots_b__16_0_Internal_Boolean_ParkingSpot_0;
		}
	}
}
