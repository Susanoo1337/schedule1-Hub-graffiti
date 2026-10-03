using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Vehicles.Modification;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200027C RID: 636
	[Serializable]
	public class VehicleData : SaveData
	{
		// Token: 0x060031A1 RID: 12705 RVA: 0x0011EF98 File Offset: 0x0011D198
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleData()
		{
			Il2CppClassPointerStore<VehicleData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "VehicleData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleData>.NativeClassPtr);
			VehicleData.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, "GUID");
			VehicleData.NativeFieldInfoPtr_VehicleCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, "VehicleCode");
			VehicleData.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, "Position");
			VehicleData.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, "Rotation");
			VehicleData.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, "Color");
			VehicleData.NativeFieldInfoPtr_VehicleContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, "VehicleContents");
			VehicleData.NativeFieldInfoPtr_SpraySurfaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, "SpraySurfaces");
			VehicleData.NativeMethodInfoPtr__ctor_Public_Void_Guid_String_Vector3_Quaternion_EVehicleColor_ItemSet_List_1_SpraySurfaceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, 100669483);
		}

		// Token: 0x060031A2 RID: 12706 RVA: 0x0011F068 File Offset: 0x0011D268
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 135541, RefRangeEnd = 135542, XrefRangeStart = 135524, XrefRangeEnd = 135541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleData(Guid guid, string code, Vector3 pos, Quaternion rot, EVehicleColor col, ItemSet vehicleContents, List<SpraySurfaceData> spraySurfaces) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(code);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref col;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vehicleContents);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spraySurfaces);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleData.NativeMethodInfoPtr__ctor_Public_Void_Guid_String_Vector3_Quaternion_EVehicleColor_ItemSet_List_1_SpraySurfaceData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031A3 RID: 12707 RVA: 0x00019A75 File Offset: 0x00017C75
		public VehicleData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FD9 RID: 4057
		// (get) Token: 0x060031A4 RID: 12708 RVA: 0x0011F114 File Offset: 0x0011D314
		// (set) Token: 0x060031A5 RID: 12709 RVA: 0x00019A7E File Offset: 0x00017C7E
		public unsafe string GUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_GUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_GUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FDA RID: 4058
		// (get) Token: 0x060031A6 RID: 12710 RVA: 0x0011F13C File Offset: 0x0011D33C
		// (set) Token: 0x060031A7 RID: 12711 RVA: 0x00019A9D File Offset: 0x00017C9D
		public unsafe string VehicleCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_VehicleCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_VehicleCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FDB RID: 4059
		// (get) Token: 0x060031A8 RID: 12712 RVA: 0x0011F164 File Offset: 0x0011D364
		// (set) Token: 0x060031A9 RID: 12713 RVA: 0x00019ABC File Offset: 0x00017CBC
		public unsafe Vector3 Position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_Position)) = value;
			}
		}

		// Token: 0x17000FDC RID: 4060
		// (get) Token: 0x060031AA RID: 12714 RVA: 0x0011F18C File Offset: 0x0011D38C
		// (set) Token: 0x060031AB RID: 12715 RVA: 0x00019AD7 File Offset: 0x00017CD7
		public unsafe Quaternion Rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_Rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_Rotation)) = value;
			}
		}

		// Token: 0x17000FDD RID: 4061
		// (get) Token: 0x060031AC RID: 12716 RVA: 0x0011F1B4 File Offset: 0x0011D3B4
		// (set) Token: 0x060031AD RID: 12717 RVA: 0x00019AF2 File Offset: 0x00017CF2
		public unsafe string Color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_Color);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_Color), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FDE RID: 4062
		// (get) Token: 0x060031AE RID: 12718 RVA: 0x0011F1DC File Offset: 0x0011D3DC
		// (set) Token: 0x060031AF RID: 12719 RVA: 0x00019B11 File Offset: 0x00017D11
		public unsafe ItemSet VehicleContents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_VehicleContents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_VehicleContents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FDF RID: 4063
		// (get) Token: 0x060031B0 RID: 12720 RVA: 0x0011F20C File Offset: 0x0011D40C
		// (set) Token: 0x060031B1 RID: 12721 RVA: 0x00019B30 File Offset: 0x00017D30
		public unsafe List<SpraySurfaceData> SpraySurfaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_SpraySurfaces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SpraySurfaceData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_SpraySurfaces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002114 RID: 8468
		private static readonly IntPtr NativeFieldInfoPtr_GUID;

		// Token: 0x04002115 RID: 8469
		private static readonly IntPtr NativeFieldInfoPtr_VehicleCode;

		// Token: 0x04002116 RID: 8470
		private static readonly IntPtr NativeFieldInfoPtr_Position;

		// Token: 0x04002117 RID: 8471
		private static readonly IntPtr NativeFieldInfoPtr_Rotation;

		// Token: 0x04002118 RID: 8472
		private static readonly IntPtr NativeFieldInfoPtr_Color;

		// Token: 0x04002119 RID: 8473
		private static readonly IntPtr NativeFieldInfoPtr_VehicleContents;

		// Token: 0x0400211A RID: 8474
		private static readonly IntPtr NativeFieldInfoPtr_SpraySurfaces;

		// Token: 0x0400211B RID: 8475
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_String_Vector3_Quaternion_EVehicleColor_ItemSet_List_1_SpraySurfaceData_0;
	}
}
