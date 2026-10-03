using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Quests;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.ScriptableObjects
{
	// Token: 0x02000456 RID: 1110
	[Serializable]
	public class PhoneCallData : ScriptableObject
	{
		// Token: 0x060064DE RID: 25822 RVA: 0x001D8E60 File Offset: 0x001D7060
		// Note: this type is marked as 'beforefieldinit'.
		static PhoneCallData()
		{
			Il2CppClassPointerStore<PhoneCallData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ScriptableObjects", "PhoneCallData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhoneCallData>.NativeClassPtr);
			PhoneCallData.NativeFieldInfoPtr_CallerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCallData>.NativeClassPtr, "CallerID");
			PhoneCallData.NativeFieldInfoPtr_Stages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCallData>.NativeClassPtr, "Stages");
			PhoneCallData.NativeFieldInfoPtr_onCallCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCallData>.NativeClassPtr, "onCallCompleted");
			PhoneCallData.NativeMethodInfoPtr_Completed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCallData>.NativeClassPtr, 100676545);
			PhoneCallData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCallData>.NativeClassPtr, 100676546);
		}

		// Token: 0x060064DF RID: 25823 RVA: 0x001D8EF4 File Offset: 0x001D70F4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 100729, RefRangeEnd = 100734, XrefRangeStart = 100729, XrefRangeEnd = 100734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Completed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneCallData.NativeMethodInfoPtr_Completed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064E0 RID: 25824 RVA: 0x001D8F28 File Offset: 0x001D7128
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 79617, RefRangeEnd = 79648, XrefRangeStart = 79617, XrefRangeEnd = 79648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PhoneCallData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhoneCallData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneCallData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064E1 RID: 25825 RVA: 0x0002F830 File Offset: 0x0002DA30
		public PhoneCallData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EEB RID: 7915
		// (get) Token: 0x060064E2 RID: 25826 RVA: 0x001D8F64 File Offset: 0x001D7164
		// (set) Token: 0x060064E3 RID: 25827 RVA: 0x0002F839 File Offset: 0x0002DA39
		public unsafe CallerID CallerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.NativeFieldInfoPtr_CallerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallerID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.NativeFieldInfoPtr_CallerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EEC RID: 7916
		// (get) Token: 0x060064E4 RID: 25828 RVA: 0x001D8F94 File Offset: 0x001D7194
		// (set) Token: 0x060064E5 RID: 25829 RVA: 0x0002F858 File Offset: 0x0002DA58
		public unsafe Il2CppReferenceArray<PhoneCallData.Stage> Stages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.NativeFieldInfoPtr_Stages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PhoneCallData.Stage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.NativeFieldInfoPtr_Stages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EED RID: 7917
		// (get) Token: 0x060064E6 RID: 25830 RVA: 0x001D8FC4 File Offset: 0x001D71C4
		// (set) Token: 0x060064E7 RID: 25831 RVA: 0x0002F877 File Offset: 0x0002DA77
		public unsafe UnityEvent onCallCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.NativeFieldInfoPtr_onCallCompleted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.NativeFieldInfoPtr_onCallCompleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400458A RID: 17802
		private static readonly IntPtr NativeFieldInfoPtr_CallerID;

		// Token: 0x0400458B RID: 17803
		private static readonly IntPtr NativeFieldInfoPtr_Stages;

		// Token: 0x0400458C RID: 17804
		private static readonly IntPtr NativeFieldInfoPtr_onCallCompleted;

		// Token: 0x0400458D RID: 17805
		private static readonly IntPtr NativeMethodInfoPtr_Completed_Public_Void_0;

		// Token: 0x0400458E RID: 17806
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B40 RID: 2880
		[Serializable]
		public class Stage : Il2CppSystem.Object
		{
			// Token: 0x0600E6FF RID: 59135 RVA: 0x003855C4 File Offset: 0x003837C4
			// Note: this type is marked as 'beforefieldinit'.
			static Stage()
			{
				Il2CppClassPointerStore<PhoneCallData.Stage>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhoneCallData>.NativeClassPtr, "Stage");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhoneCallData.Stage>.NativeClassPtr);
				PhoneCallData.Stage.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCallData.Stage>.NativeClassPtr, "Text");
				PhoneCallData.Stage.NativeFieldInfoPtr_OnStartTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCallData.Stage>.NativeClassPtr, "OnStartTriggers");
				PhoneCallData.Stage.NativeFieldInfoPtr_OnDoneTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCallData.Stage>.NativeClassPtr, "OnDoneTriggers");
				PhoneCallData.Stage.NativeMethodInfoPtr_OnStageStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCallData.Stage>.NativeClassPtr, 100676547);
				PhoneCallData.Stage.NativeMethodInfoPtr_OnStageEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCallData.Stage>.NativeClassPtr, 100676548);
				PhoneCallData.Stage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCallData.Stage>.NativeClassPtr, 100676549);
			}

			// Token: 0x0600E700 RID: 59136 RVA: 0x00385668 File Offset: 0x00383868
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 211425, RefRangeEnd = 211427, XrefRangeStart = 211423, XrefRangeEnd = 211425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void OnStageStart()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneCallData.Stage.NativeMethodInfoPtr_OnStageStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E701 RID: 59137 RVA: 0x0038569C File Offset: 0x0038389C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 211429, RefRangeEnd = 211432, XrefRangeStart = 211427, XrefRangeEnd = 211429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void OnStageEnd()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneCallData.Stage.NativeMethodInfoPtr_OnStageEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E702 RID: 59138 RVA: 0x003856D0 File Offset: 0x003838D0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Stage() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhoneCallData.Stage>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneCallData.Stage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E703 RID: 59139 RVA: 0x0006CF34 File Offset: 0x0006B134
			public Stage(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700461B RID: 17947
			// (get) Token: 0x0600E704 RID: 59140 RVA: 0x0038570C File Offset: 0x0038390C
			// (set) Token: 0x0600E705 RID: 59141 RVA: 0x0006CF3D File Offset: 0x0006B13D
			public unsafe string Text
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.Stage.NativeFieldInfoPtr_Text);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.Stage.NativeFieldInfoPtr_Text), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700461C RID: 17948
			// (get) Token: 0x0600E706 RID: 59142 RVA: 0x00385734 File Offset: 0x00383934
			// (set) Token: 0x0600E707 RID: 59143 RVA: 0x0006CF5C File Offset: 0x0006B15C
			public unsafe Il2CppReferenceArray<SystemTrigger> OnStartTriggers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.Stage.NativeFieldInfoPtr_OnStartTriggers);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SystemTrigger>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.Stage.NativeFieldInfoPtr_OnStartTriggers), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700461D RID: 17949
			// (get) Token: 0x0600E708 RID: 59144 RVA: 0x00385764 File Offset: 0x00383964
			// (set) Token: 0x0600E709 RID: 59145 RVA: 0x0006CF7B File Offset: 0x0006B17B
			public unsafe Il2CppReferenceArray<SystemTrigger> OnDoneTriggers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.Stage.NativeFieldInfoPtr_OnDoneTriggers);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SystemTrigger>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.Stage.NativeFieldInfoPtr_OnDoneTriggers), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009CCB RID: 40139
			private static readonly IntPtr NativeFieldInfoPtr_Text;

			// Token: 0x04009CCC RID: 40140
			private static readonly IntPtr NativeFieldInfoPtr_OnStartTriggers;

			// Token: 0x04009CCD RID: 40141
			private static readonly IntPtr NativeFieldInfoPtr_OnDoneTriggers;

			// Token: 0x04009CCE RID: 40142
			private static readonly IntPtr NativeMethodInfoPtr_OnStageStart_Public_Void_0;

			// Token: 0x04009CCF RID: 40143
			private static readonly IntPtr NativeMethodInfoPtr_OnStageEnd_Public_Void_0;

			// Token: 0x04009CD0 RID: 40144
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
