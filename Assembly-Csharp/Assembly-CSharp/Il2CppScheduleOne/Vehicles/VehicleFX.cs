using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020000D7 RID: 215
	public class VehicleFX : MonoBehaviour
	{
		// Token: 0x060014A4 RID: 5284 RVA: 0x000C0790 File Offset: 0x000BE990
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleFX()
		{
			Il2CppClassPointerStore<VehicleFX>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "VehicleFX");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleFX>.NativeClassPtr);
			VehicleFX.NativeFieldInfoPtr_exhaustFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleFX>.NativeClassPtr, "exhaustFX");
			VehicleFX.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleFX>.NativeClassPtr, 100666246);
			VehicleFX.NativeMethodInfoPtr_OnVehicleStart_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleFX>.NativeClassPtr, 100666247);
			VehicleFX.NativeMethodInfoPtr_OnVehicleStop_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleFX>.NativeClassPtr, 100666248);
			VehicleFX.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleFX>.NativeClassPtr, 100666249);
		}

		// Token: 0x060014A5 RID: 5285 RVA: 0x000C0824 File Offset: 0x000BEA24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94325, XrefRangeEnd = 94349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleFX.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x000C0860 File Offset: 0x000BEA60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94349, XrefRangeEnd = 94351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnVehicleStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleFX.NativeMethodInfoPtr_OnVehicleStart_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014A7 RID: 5287 RVA: 0x000C089C File Offset: 0x000BEA9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94351, XrefRangeEnd = 94353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnVehicleStop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleFX.NativeMethodInfoPtr_OnVehicleStop_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x000C08D8 File Offset: 0x000BEAD8
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleFX() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleFX>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleFX.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x0000B570 File Offset: 0x00009770
		public VehicleFX(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x060014AA RID: 5290 RVA: 0x000C0914 File Offset: 0x000BEB14
		// (set) Token: 0x060014AB RID: 5291 RVA: 0x0000B579 File Offset: 0x00009779
		public unsafe Il2CppReferenceArray<ParticleSystem> exhaustFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleFX.NativeFieldInfoPtr_exhaustFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParticleSystem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleFX.NativeFieldInfoPtr_exhaustFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E88 RID: 3720
		private static readonly IntPtr NativeFieldInfoPtr_exhaustFX;

		// Token: 0x04000E89 RID: 3721
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04000E8A RID: 3722
		private static readonly IntPtr NativeMethodInfoPtr_OnVehicleStart_Public_Virtual_New_Void_0;

		// Token: 0x04000E8B RID: 3723
		private static readonly IntPtr NativeMethodInfoPtr_OnVehicleStop_Public_Virtual_New_Void_0;

		// Token: 0x04000E8C RID: 3724
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
