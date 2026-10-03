using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Police;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x02000320 RID: 800
	public class SentryLocation : MonoBehaviour
	{
		// Token: 0x06003F04 RID: 16132 RVA: 0x0014F1D8 File Offset: 0x0014D3D8
		// Note: this type is marked as 'beforefieldinit'.
		static SentryLocation()
		{
			Il2CppClassPointerStore<SentryLocation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "SentryLocation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SentryLocation>.NativeClassPtr);
			SentryLocation.NativeFieldInfoPtr_Routes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryLocation>.NativeClassPtr, "Routes");
			SentryLocation.NativeFieldInfoPtr__AssignedOfficers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryLocation>.NativeClassPtr, "<AssignedOfficers>k__BackingField");
			SentryLocation.NativeMethodInfoPtr_get_AssignedOfficers_Public_get_List_1_PoliceOfficer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryLocation>.NativeClassPtr, 100671290);
			SentryLocation.NativeMethodInfoPtr_set_AssignedOfficers_Private_set_Void_List_1_PoliceOfficer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryLocation>.NativeClassPtr, 100671291);
			SentryLocation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryLocation>.NativeClassPtr, 100671292);
		}

		// Token: 0x170013C5 RID: 5061
		// (get) Token: 0x06003F05 RID: 16133 RVA: 0x0014F26C File Offset: 0x0014D46C
		// (set) Token: 0x06003F06 RID: 16134 RVA: 0x0014F2AC File Offset: 0x0014D4AC
		public unsafe List<PoliceOfficer> AssignedOfficers
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryLocation.NativeMethodInfoPtr_get_AssignedOfficers_Public_get_List_1_PoliceOfficer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<PoliceOfficer>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryLocation.NativeMethodInfoPtr_set_AssignedOfficers_Private_set_Void_List_1_PoliceOfficer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F07 RID: 16135 RVA: 0x0014F2F0 File Offset: 0x0014D4F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153231, XrefRangeEnd = 153246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SentryLocation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SentryLocation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryLocation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F08 RID: 16136 RVA: 0x0001F512 File Offset: 0x0001D712
		public SentryLocation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170013C3 RID: 5059
		// (get) Token: 0x06003F09 RID: 16137 RVA: 0x0014F32C File Offset: 0x0014D52C
		// (set) Token: 0x06003F0A RID: 16138 RVA: 0x0001F51B File Offset: 0x0001D71B
		public unsafe List<SentryLocation.SentryRoute> Routes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryLocation.NativeFieldInfoPtr_Routes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SentryLocation.SentryRoute>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryLocation.NativeFieldInfoPtr_Routes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013C4 RID: 5060
		// (get) Token: 0x06003F0B RID: 16139 RVA: 0x0014F35C File Offset: 0x0014D55C
		// (set) Token: 0x06003F0C RID: 16140 RVA: 0x0001F53A File Offset: 0x0001D73A
		public unsafe List<PoliceOfficer> _AssignedOfficers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryLocation.NativeFieldInfoPtr__AssignedOfficers_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PoliceOfficer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryLocation.NativeFieldInfoPtr__AssignedOfficers_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002A78 RID: 10872
		private static readonly IntPtr NativeFieldInfoPtr_Routes;

		// Token: 0x04002A79 RID: 10873
		private static readonly IntPtr NativeFieldInfoPtr__AssignedOfficers_k__BackingField;

		// Token: 0x04002A7A RID: 10874
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedOfficers_Public_get_List_1_PoliceOfficer_0;

		// Token: 0x04002A7B RID: 10875
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedOfficers_Private_set_Void_List_1_PoliceOfficer_0;

		// Token: 0x04002A7C RID: 10876
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A40 RID: 2624
		[Serializable]
		public class SentryRoute : Il2CppSystem.Object
		{
			// Token: 0x0600DF6D RID: 57197 RVA: 0x00370298 File Offset: 0x0036E498
			// Note: this type is marked as 'beforefieldinit'.
			static SentryRoute()
			{
				Il2CppClassPointerStore<SentryLocation.SentryRoute>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SentryLocation>.NativeClassPtr, "SentryRoute");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SentryLocation.SentryRoute>.NativeClassPtr);
				SentryLocation.SentryRoute.NativeFieldInfoPtr_RoutePoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryLocation.SentryRoute>.NativeClassPtr, "RoutePoints");
				SentryLocation.SentryRoute.NativeFieldInfoPtr_MinutesPerPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryLocation.SentryRoute>.NativeClassPtr, "MinutesPerPoint");
				SentryLocation.SentryRoute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryLocation.SentryRoute>.NativeClassPtr, 100671293);
			}

			// Token: 0x0600DF6E RID: 57198 RVA: 0x00370300 File Offset: 0x0036E500
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153230, XrefRangeEnd = 153231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SentryRoute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SentryLocation.SentryRoute>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryLocation.SentryRoute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF6F RID: 57199 RVA: 0x00069379 File Offset: 0x00067579
			public SentryRoute(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043FF RID: 17407
			// (get) Token: 0x0600DF70 RID: 57200 RVA: 0x0037033C File Offset: 0x0036E53C
			// (set) Token: 0x0600DF71 RID: 57201 RVA: 0x00069382 File Offset: 0x00067582
			public unsafe Il2CppReferenceArray<Transform> RoutePoints
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryLocation.SentryRoute.NativeFieldInfoPtr_RoutePoints);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryLocation.SentryRoute.NativeFieldInfoPtr_RoutePoints), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004400 RID: 17408
			// (get) Token: 0x0600DF72 RID: 57202 RVA: 0x0037036C File Offset: 0x0036E56C
			// (set) Token: 0x0600DF73 RID: 57203 RVA: 0x000693A1 File Offset: 0x000675A1
			public unsafe int MinutesPerPoint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryLocation.SentryRoute.NativeFieldInfoPtr_MinutesPerPoint);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryLocation.SentryRoute.NativeFieldInfoPtr_MinutesPerPoint)) = value;
				}
			}

			// Token: 0x0400982B RID: 38955
			private static readonly IntPtr NativeFieldInfoPtr_RoutePoints;

			// Token: 0x0400982C RID: 38956
			private static readonly IntPtr NativeFieldInfoPtr_MinutesPerPoint;

			// Token: 0x0400982D RID: 38957
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
