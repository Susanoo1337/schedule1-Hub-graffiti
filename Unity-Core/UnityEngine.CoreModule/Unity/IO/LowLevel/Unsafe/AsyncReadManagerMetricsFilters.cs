using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.IO.LowLevel.Unsafe
{
	// Token: 0x02000031 RID: 49
	public class AsyncReadManagerMetricsFilters : Object
	{
		// Token: 0x060001AC RID: 428 RVA: 0x0001CC98 File Offset: 0x0001AE98
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncReadManagerMetricsFilters()
		{
			Il2CppClassPointerStore<AsyncReadManagerMetricsFilters>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IO.LowLevel.Unsafe", "AsyncReadManagerMetricsFilters");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncReadManagerMetricsFilters>.NativeClassPtr);
			AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_TypeIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerMetricsFilters>.NativeClassPtr, "TypeIDs");
			AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_States = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerMetricsFilters>.NativeClassPtr, "States");
			AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_ReadTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerMetricsFilters>.NativeClassPtr, "ReadTypes");
			AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_PriorityLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerMetricsFilters>.NativeClassPtr, "PriorityLevels");
			AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_Subsystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerMetricsFilters>.NativeClassPtr, "Subsystems");
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00002D7C File Offset: 0x00000F7C
		public AsyncReadManagerMetricsFilters(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001AE RID: 430 RVA: 0x0001CD2C File Offset: 0x0001AF2C
		// (set) Token: 0x060001AF RID: 431 RVA: 0x00002D85 File Offset: 0x00000F85
		public unsafe Il2CppStructArray<ulong> TypeIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_TypeIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ulong>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_TypeIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x0001CD5C File Offset: 0x0001AF5C
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x00002DA4 File Offset: 0x00000FA4
		public unsafe Il2CppStructArray<ProcessingState> States
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_States);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ProcessingState>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_States), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x0001CD8C File Offset: 0x0001AF8C
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x00002DC3 File Offset: 0x00000FC3
		public unsafe Il2CppStructArray<FileReadType> ReadTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_ReadTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<FileReadType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_ReadTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x0001CDBC File Offset: 0x0001AFBC
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x00002DE2 File Offset: 0x00000FE2
		public unsafe Il2CppStructArray<Priority> PriorityLevels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_PriorityLevels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Priority>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_PriorityLevels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x0001CDEC File Offset: 0x0001AFEC
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x00002E01 File Offset: 0x00001001
		public unsafe Il2CppStructArray<AssetLoadingSubsystem> Subsystems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_Subsystems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<AssetLoadingSubsystem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_Subsystems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00002E20 File Offset: 0x00001020
		public void SetTypeIDFilter(Il2CppStructArray<ulong> _typeIDs)
		{
			this.TypeIDs = _typeIDs;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002E2A File Offset: 0x0000102A
		public void SetStateFilter(Il2CppStructArray<ProcessingState> _states)
		{
			this.States = _states;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00002E34 File Offset: 0x00001034
		public void SetReadTypeFilter(Il2CppStructArray<FileReadType> _readTypes)
		{
			this.ReadTypes = _readTypes;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00002E3E File Offset: 0x0000103E
		public void SetPriorityFilter(Il2CppStructArray<Priority> _priorityLevels)
		{
			this.PriorityLevels = _priorityLevels;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00002E48 File Offset: 0x00001048
		public void SetSubsystemFilter(Il2CppStructArray<AssetLoadingSubsystem> _subsystems)
		{
			this.Subsystems = _subsystems;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00002E52 File Offset: 0x00001052
		public void SetTypeIDFilter(ulong _typeID)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00002E5F File Offset: 0x0000105F
		public void SetStateFilter(ProcessingState _state)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00002E6C File Offset: 0x0000106C
		public void SetReadTypeFilter(FileReadType _readType)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00002E79 File Offset: 0x00001079
		public void SetPriorityFilter(Priority _priorityLevel)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00002E86 File Offset: 0x00001086
		public void SetSubsystemFilter(AssetLoadingSubsystem _subsystem)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00002E93 File Offset: 0x00001093
		public void RemoveTypeIDFilter()
		{
			this.TypeIDs = null;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00002E9D File Offset: 0x0000109D
		public void RemoveStateFilter()
		{
			this.States = null;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00002EA7 File Offset: 0x000010A7
		public void RemoveReadTypeFilter()
		{
			this.ReadTypes = null;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00002EB1 File Offset: 0x000010B1
		public void RemovePriorityFilter()
		{
			this.PriorityLevels = null;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00002EBB File Offset: 0x000010BB
		public void RemoveSubsystemFilter()
		{
			this.Subsystems = null;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00002EC5 File Offset: 0x000010C5
		public void ClearFilters()
		{
			this.RemoveTypeIDFilter();
			this.RemoveStateFilter();
			this.RemoveReadTypeFilter();
			this.RemovePriorityFilter();
			this.RemoveSubsystemFilter();
		}

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeFieldInfoPtr_TypeIDs;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeFieldInfoPtr_States;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeFieldInfoPtr_ReadTypes;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeFieldInfoPtr_PriorityLevels;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeFieldInfoPtr_Subsystems;
	}
}
