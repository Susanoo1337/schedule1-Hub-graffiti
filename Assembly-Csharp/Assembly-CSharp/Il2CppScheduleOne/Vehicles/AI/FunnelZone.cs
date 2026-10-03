using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x020000E4 RID: 228
	public class FunnelZone : MonoBehaviour
	{
		// Token: 0x06001601 RID: 5633 RVA: 0x000C4810 File Offset: 0x000C2A10
		// Note: this type is marked as 'beforefieldinit'.
		static FunnelZone()
		{
			Il2CppClassPointerStore<FunnelZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "FunnelZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FunnelZone>.NativeClassPtr);
			FunnelZone.NativeFieldInfoPtr_funnelZones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunnelZone>.NativeClassPtr, "funnelZones");
			FunnelZone.NativeFieldInfoPtr_col = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunnelZone>.NativeClassPtr, "col");
			FunnelZone.NativeFieldInfoPtr_entryPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunnelZone>.NativeClassPtr, "entryPoint");
			FunnelZone.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunnelZone>.NativeClassPtr, 100666369);
			FunnelZone.NativeMethodInfoPtr_GetFunnelZone_Public_Static_FunnelZone_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunnelZone>.NativeClassPtr, 100666370);
			FunnelZone.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunnelZone>.NativeClassPtr, 100666371);
			FunnelZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunnelZone>.NativeClassPtr, 100666372);
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x000C48CC File Offset: 0x000C2ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95293, XrefRangeEnd = 95303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunnelZone.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x000C4908 File Offset: 0x000C2B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95303, XrefRangeEnd = 95321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FunnelZone GetFunnelZone(Vector3 point)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunnelZone.NativeMethodInfoPtr_GetFunnelZone_Public_Static_FunnelZone_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FunnelZone>(intPtr3) : null;
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x000C4948 File Offset: 0x000C2B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95321, XrefRangeEnd = 95333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunnelZone.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x000C497C File Offset: 0x000C2B7C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FunnelZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunnelZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunnelZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x0000C125 File Offset: 0x0000A325
		public FunnelZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x06001607 RID: 5639 RVA: 0x000C49B8 File Offset: 0x000C2BB8
		// (set) Token: 0x06001608 RID: 5640 RVA: 0x0000C12E File Offset: 0x0000A32E
		public unsafe static List<FunnelZone> funnelZones
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FunnelZone.NativeFieldInfoPtr_funnelZones, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FunnelZone>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FunnelZone.NativeFieldInfoPtr_funnelZones, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x06001609 RID: 5641 RVA: 0x000C49E0 File Offset: 0x000C2BE0
		// (set) Token: 0x0600160A RID: 5642 RVA: 0x0000C140 File Offset: 0x0000A340
		public unsafe BoxCollider col
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunnelZone.NativeFieldInfoPtr_col);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunnelZone.NativeFieldInfoPtr_col), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x0600160B RID: 5643 RVA: 0x000C4A10 File Offset: 0x000C2C10
		// (set) Token: 0x0600160C RID: 5644 RVA: 0x0000C15F File Offset: 0x0000A35F
		public unsafe Transform entryPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunnelZone.NativeFieldInfoPtr_entryPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunnelZone.NativeFieldInfoPtr_entryPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F73 RID: 3955
		private static readonly IntPtr NativeFieldInfoPtr_funnelZones;

		// Token: 0x04000F74 RID: 3956
		private static readonly IntPtr NativeFieldInfoPtr_col;

		// Token: 0x04000F75 RID: 3957
		private static readonly IntPtr NativeFieldInfoPtr_entryPoint;

		// Token: 0x04000F76 RID: 3958
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04000F77 RID: 3959
		private static readonly IntPtr NativeMethodInfoPtr_GetFunnelZone_Public_Static_FunnelZone_Vector3_0;

		// Token: 0x04000F78 RID: 3960
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04000F79 RID: 3961
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
