using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Vehicles;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020002C3 RID: 707
	public class ParkingSpot : MonoBehaviour
	{
		// Token: 0x060036C3 RID: 14019 RVA: 0x00131310 File Offset: 0x0012F510
		// Note: this type is marked as 'beforefieldinit'.
		static ParkingSpot()
		{
			Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "ParkingSpot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr);
			ParkingSpot.NativeFieldInfoPtr_ParentLot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr, "ParentLot");
			ParkingSpot.NativeFieldInfoPtr_AlignmentPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr, "AlignmentPoint");
			ParkingSpot.NativeFieldInfoPtr_Alignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr, "Alignment");
			ParkingSpot.NativeFieldInfoPtr_OccupantVehicle_Readonly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr, "OccupantVehicle_Readonly");
			ParkingSpot.NativeFieldInfoPtr__OccupantVehicle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr, "<OccupantVehicle>k__BackingField");
			ParkingSpot.NativeMethodInfoPtr_get_OccupantVehicle_Public_get_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr, 100670216);
			ParkingSpot.NativeMethodInfoPtr_set_OccupantVehicle_Protected_set_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr, 100670217);
			ParkingSpot.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr, 100670218);
			ParkingSpot.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr, 100670219);
			ParkingSpot.NativeMethodInfoPtr_SetOccupant_Public_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr, 100670220);
			ParkingSpot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr, 100670221);
		}

		// Token: 0x17001152 RID: 4434
		// (get) Token: 0x060036C4 RID: 14020 RVA: 0x0013141C File Offset: 0x0012F61C
		// (set) Token: 0x060036C5 RID: 14021 RVA: 0x0013145C File Offset: 0x0012F65C
		public unsafe LandVehicle OccupantVehicle
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30474, RefRangeEnd = 30475, XrefRangeStart = 30474, XrefRangeEnd = 30475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingSpot.NativeMethodInfoPtr_get_OccupantVehicle_Public_get_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingSpot.NativeMethodInfoPtr_set_OccupantVehicle_Protected_set_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060036C6 RID: 14022 RVA: 0x001314A0 File Offset: 0x0012F6A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142592, XrefRangeEnd = 142624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingSpot.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036C7 RID: 14023 RVA: 0x001314D4 File Offset: 0x0012F6D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142624, XrefRangeEnd = 142647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingSpot.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036C8 RID: 14024 RVA: 0x00131508 File Offset: 0x0012F708
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 142649, RefRangeEnd = 142651, XrefRangeStart = 142647, XrefRangeEnd = 142649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOccupant(LandVehicle vehicle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingSpot.NativeMethodInfoPtr_SetOccupant_Public_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036C9 RID: 14025 RVA: 0x0013154C File Offset: 0x0012F74C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParkingSpot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingSpot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036CA RID: 14026 RVA: 0x0001BD4D File Offset: 0x00019F4D
		public ParkingSpot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700114D RID: 4429
		// (get) Token: 0x060036CB RID: 14027 RVA: 0x00131588 File Offset: 0x0012F788
		// (set) Token: 0x060036CC RID: 14028 RVA: 0x0001BD56 File Offset: 0x00019F56
		public unsafe ParkingLot ParentLot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingSpot.NativeFieldInfoPtr_ParentLot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParkingLot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingSpot.NativeFieldInfoPtr_ParentLot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700114E RID: 4430
		// (get) Token: 0x060036CD RID: 14029 RVA: 0x001315B8 File Offset: 0x0012F7B8
		// (set) Token: 0x060036CE RID: 14030 RVA: 0x0001BD75 File Offset: 0x00019F75
		public unsafe Transform AlignmentPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingSpot.NativeFieldInfoPtr_AlignmentPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingSpot.NativeFieldInfoPtr_AlignmentPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700114F RID: 4431
		// (get) Token: 0x060036CF RID: 14031 RVA: 0x001315E8 File Offset: 0x0012F7E8
		// (set) Token: 0x060036D0 RID: 14032 RVA: 0x0001BD94 File Offset: 0x00019F94
		public unsafe EParkingAlignment Alignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingSpot.NativeFieldInfoPtr_Alignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingSpot.NativeFieldInfoPtr_Alignment)) = value;
			}
		}

		// Token: 0x17001150 RID: 4432
		// (get) Token: 0x060036D1 RID: 14033 RVA: 0x00131610 File Offset: 0x0012F810
		// (set) Token: 0x060036D2 RID: 14034 RVA: 0x0001BDAF File Offset: 0x00019FAF
		public unsafe LandVehicle OccupantVehicle_Readonly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingSpot.NativeFieldInfoPtr_OccupantVehicle_Readonly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingSpot.NativeFieldInfoPtr_OccupantVehicle_Readonly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001151 RID: 4433
		// (get) Token: 0x060036D3 RID: 14035 RVA: 0x00131640 File Offset: 0x0012F840
		// (set) Token: 0x060036D4 RID: 14036 RVA: 0x0001BDCE File Offset: 0x00019FCE
		public unsafe LandVehicle _OccupantVehicle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingSpot.NativeFieldInfoPtr__OccupantVehicle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingSpot.NativeFieldInfoPtr__OccupantVehicle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040024A4 RID: 9380
		private static readonly IntPtr NativeFieldInfoPtr_ParentLot;

		// Token: 0x040024A5 RID: 9381
		private static readonly IntPtr NativeFieldInfoPtr_AlignmentPoint;

		// Token: 0x040024A6 RID: 9382
		private static readonly IntPtr NativeFieldInfoPtr_Alignment;

		// Token: 0x040024A7 RID: 9383
		private static readonly IntPtr NativeFieldInfoPtr_OccupantVehicle_Readonly;

		// Token: 0x040024A8 RID: 9384
		private static readonly IntPtr NativeFieldInfoPtr__OccupantVehicle_k__BackingField;

		// Token: 0x040024A9 RID: 9385
		private static readonly IntPtr NativeMethodInfoPtr_get_OccupantVehicle_Public_get_LandVehicle_0;

		// Token: 0x040024AA RID: 9386
		private static readonly IntPtr NativeMethodInfoPtr_set_OccupantVehicle_Protected_set_Void_LandVehicle_0;

		// Token: 0x040024AB RID: 9387
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040024AC RID: 9388
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x040024AD RID: 9389
		private static readonly IntPtr NativeMethodInfoPtr_SetOccupant_Public_Void_LandVehicle_0;

		// Token: 0x040024AE RID: 9390
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
