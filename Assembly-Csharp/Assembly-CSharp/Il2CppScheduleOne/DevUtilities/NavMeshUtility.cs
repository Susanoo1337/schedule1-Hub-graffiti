using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x020003F9 RID: 1017
	public static class NavMeshUtility : Il2CppSystem.Object
	{
		// Token: 0x06005A3F RID: 23103 RVA: 0x001B2A28 File Offset: 0x001B0C28
		// Note: this type is marked as 'beforefieldinit'.
		static NavMeshUtility()
		{
			Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "NavMeshUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr);
			NavMeshUtility.NativeFieldInfoPtr_SAMPLE_MAX_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, "SAMPLE_MAX_DISTANCE");
			NavMeshUtility.NativeFieldInfoPtr_SAMPLE_CACHE_MAX_DIST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, "SAMPLE_CACHE_MAX_DIST");
			NavMeshUtility.NativeFieldInfoPtr_SAMPLE_CACHE_MAX_SQR_DIST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, "SAMPLE_CACHE_MAX_SQR_DIST");
			NavMeshUtility.NativeFieldInfoPtr_MAX_CACHE_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, "MAX_CACHE_SIZE");
			NavMeshUtility.NativeFieldInfoPtr_SampleCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, "SampleCache");
			NavMeshUtility.NativeFieldInfoPtr_sampleCacheKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, "sampleCacheKeys");
			NavMeshUtility.NativeMethodInfoPtr_GetPathLength_Public_Static_Single_NavMeshPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, 100675097);
			NavMeshUtility.NativeMethodInfoPtr_GetReachableAccessPoint_Public_Static_Transform_ITransitEntity_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, 100675098);
			NavMeshUtility.NativeMethodInfoPtr_IsAtTransitEntity_Public_Static_Boolean_ITransitEntity_NPC_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, 100675099);
			NavMeshUtility.NativeMethodInfoPtr_GetNavMeshAgentID_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, 100675100);
			NavMeshUtility.NativeMethodInfoPtr_SamplePosition_Public_Static_Boolean_Vector3_byref_NavMeshHit_Single_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, 100675101);
			NavMeshUtility.NativeMethodInfoPtr_CacheSampleResult_Private_Static_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, 100675102);
			NavMeshUtility.NativeMethodInfoPtr_Quantize_Private_Static_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, 100675103);
			NavMeshUtility.NativeMethodInfoPtr_ClearCache_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, 100675104);
		}

		// Token: 0x06005A40 RID: 23104 RVA: 0x001B2B70 File Offset: 0x001B0D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194852, XrefRangeEnd = 194861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetPathLength(NavMeshPath path)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavMeshUtility.NativeMethodInfoPtr_GetPathLength_Public_Static_Single_NavMeshPath_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005A41 RID: 23105 RVA: 0x001B2BB4 File Offset: 0x001B0DB4
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 194916, RefRangeEnd = 194942, XrefRangeStart = 194861, XrefRangeEnd = 194916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Transform GetReachableAccessPoint(ITransitEntity entity, NPC npc)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavMeshUtility.NativeMethodInfoPtr_GetReachableAccessPoint_Public_Static_Transform_ITransitEntity_NPC_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06005A42 RID: 23106 RVA: 0x001B2C0C File Offset: 0x001B0E0C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 194963, RefRangeEnd = 194968, XrefRangeStart = 194942, XrefRangeEnd = 194963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsAtTransitEntity(ITransitEntity entity, NPC npc, float distanceThreshold = 0.4f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(npc);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distanceThreshold;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavMeshUtility.NativeMethodInfoPtr_IsAtTransitEntity_Public_Static_Boolean_ITransitEntity_NPC_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005A43 RID: 23107 RVA: 0x001B2C70 File Offset: 0x001B0E70
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 194974, RefRangeEnd = 194977, XrefRangeStart = 194968, XrefRangeEnd = 194974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetNavMeshAgentID(string name)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavMeshUtility.NativeMethodInfoPtr_GetNavMeshAgentID_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005A44 RID: 23108 RVA: 0x001B2CB4 File Offset: 0x001B0EB4
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 195003, RefRangeEnd = 195016, XrefRangeStart = 194977, XrefRangeEnd = 195003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SamplePosition(Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int areaMask, bool useCache = true)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sourcePosition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hit;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref areaMask;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useCache;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavMeshUtility.NativeMethodInfoPtr_SamplePosition_Public_Static_Boolean_Vector3_byref_NavMeshHit_Single_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005A45 RID: 23109 RVA: 0x001B2D2C File Offset: 0x001B0F2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195065, RefRangeEnd = 195066, XrefRangeStart = 195016, XrefRangeEnd = 195065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CacheSampleResult(Vector3 sourcePosition, Vector3 hitPosition)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sourcePosition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hitPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavMeshUtility.NativeMethodInfoPtr_CacheSampleResult_Private_Static_Void_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A46 RID: 23110 RVA: 0x001B2D6C File Offset: 0x001B0F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195066, XrefRangeEnd = 195069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 Quantize(Vector3 position, float precision = 0.1f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref precision;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavMeshUtility.NativeMethodInfoPtr_Quantize_Private_Static_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005A47 RID: 23111 RVA: 0x001B2DB8 File Offset: 0x001B0FB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195078, RefRangeEnd = 195079, XrefRangeStart = 195069, XrefRangeEnd = 195078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearCache()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavMeshUtility.NativeMethodInfoPtr_ClearCache_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A48 RID: 23112 RVA: 0x0002ACD9 File Offset: 0x00028ED9
		public NavMeshUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001BDB RID: 7131
		// (get) Token: 0x06005A49 RID: 23113 RVA: 0x001B2DE0 File Offset: 0x001B0FE0
		// (set) Token: 0x06005A4A RID: 23114 RVA: 0x0002ACE2 File Offset: 0x00028EE2
		public unsafe static float SAMPLE_MAX_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NavMeshUtility.NativeFieldInfoPtr_SAMPLE_MAX_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NavMeshUtility.NativeFieldInfoPtr_SAMPLE_MAX_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x17001BDC RID: 7132
		// (get) Token: 0x06005A4B RID: 23115 RVA: 0x001B2DFC File Offset: 0x001B0FFC
		// (set) Token: 0x06005A4C RID: 23116 RVA: 0x0002ACF0 File Offset: 0x00028EF0
		public unsafe static float SAMPLE_CACHE_MAX_DIST
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NavMeshUtility.NativeFieldInfoPtr_SAMPLE_CACHE_MAX_DIST, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NavMeshUtility.NativeFieldInfoPtr_SAMPLE_CACHE_MAX_DIST, (void*)(&value));
			}
		}

		// Token: 0x17001BDD RID: 7133
		// (get) Token: 0x06005A4D RID: 23117 RVA: 0x001B2E18 File Offset: 0x001B1018
		// (set) Token: 0x06005A4E RID: 23118 RVA: 0x0002ACFE File Offset: 0x00028EFE
		public unsafe static float SAMPLE_CACHE_MAX_SQR_DIST
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NavMeshUtility.NativeFieldInfoPtr_SAMPLE_CACHE_MAX_SQR_DIST, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NavMeshUtility.NativeFieldInfoPtr_SAMPLE_CACHE_MAX_SQR_DIST, (void*)(&value));
			}
		}

		// Token: 0x17001BDE RID: 7134
		// (get) Token: 0x06005A4F RID: 23119 RVA: 0x001B2E34 File Offset: 0x001B1034
		// (set) Token: 0x06005A50 RID: 23120 RVA: 0x0002AD0C File Offset: 0x00028F0C
		public unsafe static float MAX_CACHE_SIZE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NavMeshUtility.NativeFieldInfoPtr_MAX_CACHE_SIZE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NavMeshUtility.NativeFieldInfoPtr_MAX_CACHE_SIZE, (void*)(&value));
			}
		}

		// Token: 0x17001BDF RID: 7135
		// (get) Token: 0x06005A51 RID: 23121 RVA: 0x001B2E50 File Offset: 0x001B1050
		// (set) Token: 0x06005A52 RID: 23122 RVA: 0x0002AD1A File Offset: 0x00028F1A
		public unsafe static Dictionary<Vector3, Vector3> SampleCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NavMeshUtility.NativeFieldInfoPtr_SampleCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Vector3, Vector3>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NavMeshUtility.NativeFieldInfoPtr_SampleCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BE0 RID: 7136
		// (get) Token: 0x06005A53 RID: 23123 RVA: 0x001B2E78 File Offset: 0x001B1078
		// (set) Token: 0x06005A54 RID: 23124 RVA: 0x0002AD2C File Offset: 0x00028F2C
		public unsafe static List<Vector3> sampleCacheKeys
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NavMeshUtility.NativeFieldInfoPtr_sampleCacheKeys, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NavMeshUtility.NativeFieldInfoPtr_sampleCacheKeys, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003DEB RID: 15851
		private static readonly IntPtr NativeFieldInfoPtr_SAMPLE_MAX_DISTANCE;

		// Token: 0x04003DEC RID: 15852
		private static readonly IntPtr NativeFieldInfoPtr_SAMPLE_CACHE_MAX_DIST;

		// Token: 0x04003DED RID: 15853
		private static readonly IntPtr NativeFieldInfoPtr_SAMPLE_CACHE_MAX_SQR_DIST;

		// Token: 0x04003DEE RID: 15854
		private static readonly IntPtr NativeFieldInfoPtr_MAX_CACHE_SIZE;

		// Token: 0x04003DEF RID: 15855
		private static readonly IntPtr NativeFieldInfoPtr_SampleCache;

		// Token: 0x04003DF0 RID: 15856
		private static readonly IntPtr NativeFieldInfoPtr_sampleCacheKeys;

		// Token: 0x04003DF1 RID: 15857
		private static readonly IntPtr NativeMethodInfoPtr_GetPathLength_Public_Static_Single_NavMeshPath_0;

		// Token: 0x04003DF2 RID: 15858
		private static readonly IntPtr NativeMethodInfoPtr_GetReachableAccessPoint_Public_Static_Transform_ITransitEntity_NPC_0;

		// Token: 0x04003DF3 RID: 15859
		private static readonly IntPtr NativeMethodInfoPtr_IsAtTransitEntity_Public_Static_Boolean_ITransitEntity_NPC_Single_0;

		// Token: 0x04003DF4 RID: 15860
		private static readonly IntPtr NativeMethodInfoPtr_GetNavMeshAgentID_Public_Static_Int32_String_0;

		// Token: 0x04003DF5 RID: 15861
		private static readonly IntPtr NativeMethodInfoPtr_SamplePosition_Public_Static_Boolean_Vector3_byref_NavMeshHit_Single_Int32_Boolean_0;

		// Token: 0x04003DF6 RID: 15862
		private static readonly IntPtr NativeMethodInfoPtr_CacheSampleResult_Private_Static_Void_Vector3_Vector3_0;

		// Token: 0x04003DF7 RID: 15863
		private static readonly IntPtr NativeMethodInfoPtr_Quantize_Private_Static_Vector3_Vector3_Single_0;

		// Token: 0x04003DF8 RID: 15864
		private static readonly IntPtr NativeMethodInfoPtr_ClearCache_Public_Static_Void_0;
	}
}
