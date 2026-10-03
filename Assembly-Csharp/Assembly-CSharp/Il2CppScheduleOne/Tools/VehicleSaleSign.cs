using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Vehicles;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000501 RID: 1281
	public class VehicleSaleSign : MonoBehaviour
	{
		// Token: 0x0600738B RID: 29579 RVA: 0x00206A40 File Offset: 0x00204C40
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleSaleSign()
		{
			Il2CppClassPointerStore<VehicleSaleSign>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "VehicleSaleSign");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleSaleSign>.NativeClassPtr);
			VehicleSaleSign.NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSaleSign>.NativeClassPtr, "NameLabel");
			VehicleSaleSign.NativeFieldInfoPtr_PriceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSaleSign>.NativeClassPtr, "PriceLabel");
			VehicleSaleSign.NativeFieldInfoPtr_VehiclePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSaleSign>.NativeClassPtr, "VehiclePrefab");
			VehicleSaleSign.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSaleSign>.NativeClassPtr, 100678222);
			VehicleSaleSign.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSaleSign>.NativeClassPtr, 100678223);
		}

		// Token: 0x0600738C RID: 29580 RVA: 0x00206AD4 File Offset: 0x00204CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227553, XrefRangeEnd = 227573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSaleSign.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600738D RID: 29581 RVA: 0x00206B08 File Offset: 0x00204D08
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleSaleSign() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleSaleSign>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSaleSign.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600738E RID: 29582 RVA: 0x00036FAB File Offset: 0x000351AB
		public VehicleSaleSign(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023A1 RID: 9121
		// (get) Token: 0x0600738F RID: 29583 RVA: 0x00206B44 File Offset: 0x00204D44
		// (set) Token: 0x06007390 RID: 29584 RVA: 0x00036FB4 File Offset: 0x000351B4
		public unsafe TextMeshPro NameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSaleSign.NativeFieldInfoPtr_NameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSaleSign.NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023A2 RID: 9122
		// (get) Token: 0x06007391 RID: 29585 RVA: 0x00206B74 File Offset: 0x00204D74
		// (set) Token: 0x06007392 RID: 29586 RVA: 0x00036FD3 File Offset: 0x000351D3
		public unsafe TextMeshPro PriceLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSaleSign.NativeFieldInfoPtr_PriceLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSaleSign.NativeFieldInfoPtr_PriceLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023A3 RID: 9123
		// (get) Token: 0x06007393 RID: 29587 RVA: 0x00206BA4 File Offset: 0x00204DA4
		// (set) Token: 0x06007394 RID: 29588 RVA: 0x00036FF2 File Offset: 0x000351F2
		public unsafe LandVehicle VehiclePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSaleSign.NativeFieldInfoPtr_VehiclePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSaleSign.NativeFieldInfoPtr_VehiclePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004ED2 RID: 20178
		private static readonly IntPtr NativeFieldInfoPtr_NameLabel;

		// Token: 0x04004ED3 RID: 20179
		private static readonly IntPtr NativeFieldInfoPtr_PriceLabel;

		// Token: 0x04004ED4 RID: 20180
		private static readonly IntPtr NativeFieldInfoPtr_VehiclePrefab;

		// Token: 0x04004ED5 RID: 20181
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004ED6 RID: 20182
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
