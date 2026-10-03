using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020000D3 RID: 211
	public class SpeedZone : MonoBehaviour
	{
		// Token: 0x06001441 RID: 5185 RVA: 0x000BF6D0 File Offset: 0x000BD8D0
		// Note: this type is marked as 'beforefieldinit'.
		static SpeedZone()
		{
			Il2CppClassPointerStore<SpeedZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "SpeedZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpeedZone>.NativeClassPtr);
			SpeedZone.NativeFieldInfoPtr_speedZones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedZone>.NativeClassPtr, "speedZones");
			SpeedZone.NativeFieldInfoPtr_col = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedZone>.NativeClassPtr, "col");
			SpeedZone.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedZone>.NativeClassPtr, "speed");
			SpeedZone.NativeFieldInfoPtr_query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedZone>.NativeClassPtr, "query");
			SpeedZone.NativeMethodInfoPtr_Awake_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedZone>.NativeClassPtr, 100666217);
			SpeedZone.NativeMethodInfoPtr_GetSpeedZones_Public_Static_IEnumerable_1_SpeedZone_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedZone>.NativeClassPtr, 100666218);
			SpeedZone.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedZone>.NativeClassPtr, 100666219);
			SpeedZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedZone>.NativeClassPtr, 100666220);
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x000BF7A0 File Offset: 0x000BD9A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93786, XrefRangeEnd = 93796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpeedZone.NativeMethodInfoPtr_Awake_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x000BF7DC File Offset: 0x000BD9DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 93824, RefRangeEnd = 93825, XrefRangeStart = 93796, XrefRangeEnd = 93824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<SpeedZone> GetSpeedZones(Vector3 point)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpeedZone.NativeMethodInfoPtr_GetSpeedZones_Public_Static_IEnumerable_1_SpeedZone_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<SpeedZone>>(intPtr3) : null;
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x000BF81C File Offset: 0x000BDA1C
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpeedZone.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x000BF850 File Offset: 0x000BDA50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93825, XrefRangeEnd = 93826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpeedZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpeedZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpeedZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x0000B239 File Offset: 0x00009439
		public SpeedZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06001447 RID: 5191 RVA: 0x000BF88C File Offset: 0x000BDA8C
		// (set) Token: 0x06001448 RID: 5192 RVA: 0x0000B242 File Offset: 0x00009442
		public unsafe static List<SpeedZone> speedZones
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SpeedZone.NativeFieldInfoPtr_speedZones, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SpeedZone>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpeedZone.NativeFieldInfoPtr_speedZones, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06001449 RID: 5193 RVA: 0x000BF8B4 File Offset: 0x000BDAB4
		// (set) Token: 0x0600144A RID: 5194 RVA: 0x0000B254 File Offset: 0x00009454
		public unsafe BoxCollider col
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpeedZone.NativeFieldInfoPtr_col);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpeedZone.NativeFieldInfoPtr_col), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x0600144B RID: 5195 RVA: 0x000BF8E4 File Offset: 0x000BDAE4
		// (set) Token: 0x0600144C RID: 5196 RVA: 0x0000B273 File Offset: 0x00009473
		public unsafe float speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpeedZone.NativeFieldInfoPtr_speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpeedZone.NativeFieldInfoPtr_speed)) = value;
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x0600144D RID: 5197 RVA: 0x000BF90C File Offset: 0x000BDB0C
		// (set) Token: 0x0600144E RID: 5198 RVA: 0x0000B28E File Offset: 0x0000948E
		public unsafe static List<SpeedZone> query
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SpeedZone.NativeFieldInfoPtr_query, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SpeedZone>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpeedZone.NativeFieldInfoPtr_query, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E4D RID: 3661
		private static readonly IntPtr NativeFieldInfoPtr_speedZones;

		// Token: 0x04000E4E RID: 3662
		private static readonly IntPtr NativeFieldInfoPtr_col;

		// Token: 0x04000E4F RID: 3663
		private static readonly IntPtr NativeFieldInfoPtr_speed;

		// Token: 0x04000E50 RID: 3664
		private static readonly IntPtr NativeFieldInfoPtr_query;

		// Token: 0x04000E51 RID: 3665
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_New_Void_0;

		// Token: 0x04000E52 RID: 3666
		private static readonly IntPtr NativeMethodInfoPtr_GetSpeedZones_Public_Static_IEnumerable_1_SpeedZone_Vector3_0;

		// Token: 0x04000E53 RID: 3667
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04000E54 RID: 3668
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
