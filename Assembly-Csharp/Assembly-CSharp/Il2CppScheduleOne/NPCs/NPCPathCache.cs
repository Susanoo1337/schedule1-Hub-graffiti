using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Il2CppScheduleOne.NPCs
{
	// Token: 0x020005DA RID: 1498
	public class NPCPathCache : Il2CppSystem.Object
	{
		// Token: 0x060093CB RID: 37835 RVA: 0x0027F3A0 File Offset: 0x0027D5A0
		// Note: this type is marked as 'beforefieldinit'.
		static NPCPathCache()
		{
			Il2CppClassPointerStore<NPCPathCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs", "NPCPathCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCPathCache>.NativeClassPtr);
			NPCPathCache.NativeFieldInfoPtr__Paths_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCPathCache>.NativeClassPtr, "<Paths>k__BackingField");
			NPCPathCache.NativeMethodInfoPtr_get_Paths_Public_get_List_1_PathCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPathCache>.NativeClassPtr, 100682591);
			NPCPathCache.NativeMethodInfoPtr_set_Paths_Private_set_Void_List_1_PathCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPathCache>.NativeClassPtr, 100682592);
			NPCPathCache.NativeMethodInfoPtr_GetPath_Public_NavMeshPath_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPathCache>.NativeClassPtr, 100682593);
			NPCPathCache.NativeMethodInfoPtr_AddPath_Public_Void_Vector3_Vector3_NavMeshPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPathCache>.NativeClassPtr, 100682594);
			NPCPathCache.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPathCache>.NativeClassPtr, 100682595);
		}

		// Token: 0x17002DB0 RID: 11696
		// (get) Token: 0x060093CC RID: 37836 RVA: 0x0027F448 File Offset: 0x0027D648
		// (set) Token: 0x060093CD RID: 37837 RVA: 0x0027F488 File Offset: 0x0027D688
		public unsafe List<NPCPathCache.PathCache> Paths
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 3712, RefRangeEnd = 3724, XrefRangeStart = 3712, XrefRangeEnd = 3724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCPathCache.NativeMethodInfoPtr_get_Paths_Public_get_List_1_PathCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<NPCPathCache.PathCache>>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29107, RefRangeEnd = 29109, XrefRangeStart = 29107, XrefRangeEnd = 29109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCPathCache.NativeMethodInfoPtr_set_Paths_Private_set_Void_List_1_PathCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060093CE RID: 37838 RVA: 0x0027F4CC File Offset: 0x0027D6CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 270681, RefRangeEnd = 270682, XrefRangeStart = 270671, XrefRangeEnd = 270681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NavMeshPath GetPath(Vector3 start, Vector3 end, float sqrMaxDistance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sqrMaxDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCPathCache.NativeMethodInfoPtr_GetPath_Public_NavMeshPath_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NavMeshPath>(intPtr3) : null;
		}

		// Token: 0x060093CF RID: 37839 RVA: 0x0027F534 File Offset: 0x0027D734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270682, XrefRangeEnd = 270693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPath(Vector3 start, Vector3 end, NavMeshPath path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCPathCache.NativeMethodInfoPtr_AddPath_Public_Void_Vector3_Vector3_NavMeshPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060093D0 RID: 37840 RVA: 0x0027F594 File Offset: 0x0027D794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270693, XrefRangeEnd = 270701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCPathCache() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCPathCache>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCPathCache.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060093D1 RID: 37841 RVA: 0x00045453 File Offset: 0x00043653
		public NPCPathCache(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002DAF RID: 11695
		// (get) Token: 0x060093D2 RID: 37842 RVA: 0x0027F5D0 File Offset: 0x0027D7D0
		// (set) Token: 0x060093D3 RID: 37843 RVA: 0x0004545C File Offset: 0x0004365C
		public unsafe List<NPCPathCache.PathCache> _Paths_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPathCache.NativeFieldInfoPtr__Paths_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPCPathCache.PathCache>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPathCache.NativeFieldInfoPtr__Paths_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040065C8 RID: 26056
		private static readonly IntPtr NativeFieldInfoPtr__Paths_k__BackingField;

		// Token: 0x040065C9 RID: 26057
		private static readonly IntPtr NativeMethodInfoPtr_get_Paths_Public_get_List_1_PathCache_0;

		// Token: 0x040065CA RID: 26058
		private static readonly IntPtr NativeMethodInfoPtr_set_Paths_Private_set_Void_List_1_PathCache_0;

		// Token: 0x040065CB RID: 26059
		private static readonly IntPtr NativeMethodInfoPtr_GetPath_Public_NavMeshPath_Vector3_Vector3_Single_0;

		// Token: 0x040065CC RID: 26060
		private static readonly IntPtr NativeMethodInfoPtr_AddPath_Public_Void_Vector3_Vector3_NavMeshPath_0;

		// Token: 0x040065CD RID: 26061
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C2B RID: 3115
		[Serializable]
		public class PathCache : Il2CppSystem.Object
		{
			// Token: 0x0600EEDB RID: 61147 RVA: 0x0039BEF8 File Offset: 0x0039A0F8
			// Note: this type is marked as 'beforefieldinit'.
			static PathCache()
			{
				Il2CppClassPointerStore<NPCPathCache.PathCache>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCPathCache>.NativeClassPtr, "PathCache");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCPathCache.PathCache>.NativeClassPtr);
				NPCPathCache.PathCache.NativeFieldInfoPtr_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCPathCache.PathCache>.NativeClassPtr, "Start");
				NPCPathCache.PathCache.NativeFieldInfoPtr_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCPathCache.PathCache>.NativeClassPtr, "End");
				NPCPathCache.PathCache.NativeFieldInfoPtr_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCPathCache.PathCache>.NativeClassPtr, "Path");
				NPCPathCache.PathCache.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_NavMeshPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPathCache.PathCache>.NativeClassPtr, 100682596);
			}

			// Token: 0x0600EEDC RID: 61148 RVA: 0x0039BF74 File Offset: 0x0039A174
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270669, XrefRangeEnd = 270671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PathCache(Vector3 start, Vector3 end, NavMeshPath path) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCPathCache.PathCache>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref start;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCPathCache.PathCache.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_NavMeshPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EEDD RID: 61149 RVA: 0x00070C23 File Offset: 0x0006EE23
			public PathCache(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700486B RID: 18539
			// (get) Token: 0x0600EEDE RID: 61150 RVA: 0x0039BFDC File Offset: 0x0039A1DC
			// (set) Token: 0x0600EEDF RID: 61151 RVA: 0x00070C2C File Offset: 0x0006EE2C
			public unsafe Vector3 Start
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPathCache.PathCache.NativeFieldInfoPtr_Start);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPathCache.PathCache.NativeFieldInfoPtr_Start)) = value;
				}
			}

			// Token: 0x1700486C RID: 18540
			// (get) Token: 0x0600EEE0 RID: 61152 RVA: 0x0039C004 File Offset: 0x0039A204
			// (set) Token: 0x0600EEE1 RID: 61153 RVA: 0x00070C47 File Offset: 0x0006EE47
			public unsafe Vector3 End
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPathCache.PathCache.NativeFieldInfoPtr_End);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPathCache.PathCache.NativeFieldInfoPtr_End)) = value;
				}
			}

			// Token: 0x1700486D RID: 18541
			// (get) Token: 0x0600EEE2 RID: 61154 RVA: 0x0039C02C File Offset: 0x0039A22C
			// (set) Token: 0x0600EEE3 RID: 61155 RVA: 0x00070C62 File Offset: 0x0006EE62
			public unsafe NavMeshPath Path
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPathCache.PathCache.NativeFieldInfoPtr_Path);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavMeshPath>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPathCache.PathCache.NativeFieldInfoPtr_Path), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A1BA RID: 41402
			private static readonly IntPtr NativeFieldInfoPtr_Start;

			// Token: 0x0400A1BB RID: 41403
			private static readonly IntPtr NativeFieldInfoPtr_End;

			// Token: 0x0400A1BC RID: 41404
			private static readonly IntPtr NativeFieldInfoPtr_Path;

			// Token: 0x0400A1BD RID: 41405
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_NavMeshPath_0;
		}
	}
}
