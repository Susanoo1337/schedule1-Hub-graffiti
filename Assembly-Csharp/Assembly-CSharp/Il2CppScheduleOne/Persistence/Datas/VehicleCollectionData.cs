using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200027B RID: 635
	[Serializable]
	public class VehicleCollectionData : SaveData
	{
		// Token: 0x0600319C RID: 12700 RVA: 0x0011EEC4 File Offset: 0x0011D0C4
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleCollectionData()
		{
			Il2CppClassPointerStore<VehicleCollectionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "VehicleCollectionData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleCollectionData>.NativeClassPtr);
			VehicleCollectionData.NativeFieldInfoPtr_Vehicles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCollectionData>.NativeClassPtr, "Vehicles");
			VehicleCollectionData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_VehicleData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCollectionData>.NativeClassPtr, 100669482);
		}

		// Token: 0x0600319D RID: 12701 RVA: 0x0011EF1C File Offset: 0x0011D11C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 134314, RefRangeEnd = 134323, XrefRangeStart = 134314, XrefRangeEnd = 134323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleCollectionData(Il2CppReferenceArray<VehicleData> vehicles) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleCollectionData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicles);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCollectionData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_VehicleData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600319E RID: 12702 RVA: 0x00019A4D File Offset: 0x00017C4D
		public VehicleCollectionData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FD8 RID: 4056
		// (get) Token: 0x0600319F RID: 12703 RVA: 0x0011EF68 File Offset: 0x0011D168
		// (set) Token: 0x060031A0 RID: 12704 RVA: 0x00019A56 File Offset: 0x00017C56
		public unsafe Il2CppReferenceArray<VehicleData> Vehicles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCollectionData.NativeFieldInfoPtr_Vehicles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VehicleData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCollectionData.NativeFieldInfoPtr_Vehicles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002112 RID: 8466
		private static readonly IntPtr NativeFieldInfoPtr_Vehicles;

		// Token: 0x04002113 RID: 8467
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_VehicleData_0;
	}
}
