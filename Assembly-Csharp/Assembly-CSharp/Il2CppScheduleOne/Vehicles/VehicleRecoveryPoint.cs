using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020000DD RID: 221
	public class VehicleRecoveryPoint : MonoBehaviour
	{
		// Token: 0x06001542 RID: 5442 RVA: 0x000C2994 File Offset: 0x000C0B94
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleRecoveryPoint()
		{
			Il2CppClassPointerStore<VehicleRecoveryPoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "VehicleRecoveryPoint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleRecoveryPoint>.NativeClassPtr);
			VehicleRecoveryPoint.NativeFieldInfoPtr_recoveryPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleRecoveryPoint>.NativeClassPtr, "recoveryPoints");
			VehicleRecoveryPoint.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleRecoveryPoint>.NativeClassPtr, 100666314);
			VehicleRecoveryPoint.NativeMethodInfoPtr_GetClosestRecoveryPoint_Public_Static_VehicleRecoveryPoint_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleRecoveryPoint>.NativeClassPtr, 100666315);
			VehicleRecoveryPoint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleRecoveryPoint>.NativeClassPtr, 100666316);
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x000C2A14 File Offset: 0x000C0C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94904, XrefRangeEnd = 94914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleRecoveryPoint.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x000C2A50 File Offset: 0x000C0C50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 94941, RefRangeEnd = 94942, XrefRangeStart = 94914, XrefRangeEnd = 94941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VehicleRecoveryPoint GetClosestRecoveryPoint(Vector3 pos)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleRecoveryPoint.NativeMethodInfoPtr_GetClosestRecoveryPoint_Public_Static_VehicleRecoveryPoint_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VehicleRecoveryPoint>(intPtr3) : null;
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x000C2A90 File Offset: 0x000C0C90
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleRecoveryPoint() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleRecoveryPoint>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleRecoveryPoint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001546 RID: 5446 RVA: 0x0000BA3E File Offset: 0x00009C3E
		public VehicleRecoveryPoint(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06001547 RID: 5447 RVA: 0x000C2ACC File Offset: 0x000C0CCC
		// (set) Token: 0x06001548 RID: 5448 RVA: 0x0000BA47 File Offset: 0x00009C47
		public unsafe static List<VehicleRecoveryPoint> recoveryPoints
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VehicleRecoveryPoint.NativeFieldInfoPtr_recoveryPoints, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VehicleRecoveryPoint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleRecoveryPoint.NativeFieldInfoPtr_recoveryPoints, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EF2 RID: 3826
		private static readonly IntPtr NativeFieldInfoPtr_recoveryPoints;

		// Token: 0x04000EF3 RID: 3827
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04000EF4 RID: 3828
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestRecoveryPoint_Public_Static_VehicleRecoveryPoint_Vector3_0;

		// Token: 0x04000EF5 RID: 3829
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
