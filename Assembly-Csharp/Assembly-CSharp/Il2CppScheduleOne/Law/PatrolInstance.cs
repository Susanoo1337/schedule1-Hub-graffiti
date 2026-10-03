using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs.Behaviour;
using Il2CppSystem;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x0200031D RID: 797
	[Serializable]
	public class PatrolInstance : Object
	{
		// Token: 0x06003EB2 RID: 16050 RVA: 0x0014E64C File Offset: 0x0014C84C
		// Note: this type is marked as 'beforefieldinit'.
		static PatrolInstance()
		{
			Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "PatrolInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr);
			PatrolInstance.NativeFieldInfoPtr_Route = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, "Route");
			PatrolInstance.NativeFieldInfoPtr_MinMembers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, "MinMembers");
			PatrolInstance.NativeFieldInfoPtr_MaxMembers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, "MaxMembers");
			PatrolInstance.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, "StartTime");
			PatrolInstance.NativeFieldInfoPtr_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, "EndTime");
			PatrolInstance.NativeFieldInfoPtr_IntensityRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, "IntensityRequirement");
			PatrolInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, "OnlyIfCurfewEnabled");
			PatrolInstance.NativeFieldInfoPtr__ActiveGroup_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, "<ActiveGroup>k__BackingField");
			PatrolInstance.NativeMethodInfoPtr_get_ActiveGroup_Public_get_PatrolGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, 100671276);
			PatrolInstance.NativeMethodInfoPtr_set_ActiveGroup_Protected_set_Void_PatrolGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, 100671277);
			PatrolInstance.NativeMethodInfoPtr_Evaluate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, 100671278);
			PatrolInstance.NativeMethodInfoPtr_StartPatrol_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, 100671279);
			PatrolInstance.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, 100671280);
			PatrolInstance.NativeMethodInfoPtr_EndPatrol_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, 100671281);
			PatrolInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, 100671282);
		}

		// Token: 0x170013AB RID: 5035
		// (get) Token: 0x06003EB3 RID: 16051 RVA: 0x0014E7A8 File Offset: 0x0014C9A8
		// (set) Token: 0x06003EB4 RID: 16052 RVA: 0x0014E7E8 File Offset: 0x0014C9E8
		public unsafe PatrolGroup ActiveGroup
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 2964, RefRangeEnd = 2977, XrefRangeStart = 2964, XrefRangeEnd = 2977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolInstance.NativeMethodInfoPtr_get_ActiveGroup_Public_get_PatrolGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PatrolGroup>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 2978, RefRangeEnd = 2980, XrefRangeStart = 2978, XrefRangeEnd = 2980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolInstance.NativeMethodInfoPtr_set_ActiveGroup_Protected_set_Void_PatrolGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003EB5 RID: 16053 RVA: 0x0014E82C File Offset: 0x0014CA2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152926, XrefRangeEnd = 152938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Evaluate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolInstance.NativeMethodInfoPtr_Evaluate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EB6 RID: 16054 RVA: 0x0014E860 File Offset: 0x0014CA60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 152964, RefRangeEnd = 152966, XrefRangeStart = 152938, XrefRangeEnd = 152964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartPatrol()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolInstance.NativeMethodInfoPtr_StartPatrol_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EB7 RID: 16055 RVA: 0x0014E894 File Offset: 0x0014CA94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152966, XrefRangeEnd = 152985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolInstance.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EB8 RID: 16056 RVA: 0x0014E8C8 File Offset: 0x0014CAC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152985, XrefRangeEnd = 152999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndPatrol()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolInstance.NativeMethodInfoPtr_EndPatrol_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EB9 RID: 16057 RVA: 0x0014E8FC File Offset: 0x0014CAFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152999, XrefRangeEnd = 153000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PatrolInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EBA RID: 16058 RVA: 0x0001F254 File Offset: 0x0001D454
		public PatrolInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170013A3 RID: 5027
		// (get) Token: 0x06003EBB RID: 16059 RVA: 0x0014E938 File Offset: 0x0014CB38
		// (set) Token: 0x06003EBC RID: 16060 RVA: 0x0001F25D File Offset: 0x0001D45D
		public unsafe FootPatrolRoute Route
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_Route);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootPatrolRoute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_Route), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013A4 RID: 5028
		// (get) Token: 0x06003EBD RID: 16061 RVA: 0x0014E968 File Offset: 0x0014CB68
		// (set) Token: 0x06003EBE RID: 16062 RVA: 0x0001F27C File Offset: 0x0001D47C
		public unsafe int MinMembers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_MinMembers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_MinMembers)) = value;
			}
		}

		// Token: 0x170013A5 RID: 5029
		// (get) Token: 0x06003EBF RID: 16063 RVA: 0x0014E990 File Offset: 0x0014CB90
		// (set) Token: 0x06003EC0 RID: 16064 RVA: 0x0001F297 File Offset: 0x0001D497
		public unsafe int MaxMembers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_MaxMembers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_MaxMembers)) = value;
			}
		}

		// Token: 0x170013A6 RID: 5030
		// (get) Token: 0x06003EC1 RID: 16065 RVA: 0x0014E9B8 File Offset: 0x0014CBB8
		// (set) Token: 0x06003EC2 RID: 16066 RVA: 0x0001F2B2 File Offset: 0x0001D4B2
		public unsafe int StartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_StartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_StartTime)) = value;
			}
		}

		// Token: 0x170013A7 RID: 5031
		// (get) Token: 0x06003EC3 RID: 16067 RVA: 0x0014E9E0 File Offset: 0x0014CBE0
		// (set) Token: 0x06003EC4 RID: 16068 RVA: 0x0001F2CD File Offset: 0x0001D4CD
		public unsafe int EndTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_EndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_EndTime)) = value;
			}
		}

		// Token: 0x170013A8 RID: 5032
		// (get) Token: 0x06003EC5 RID: 16069 RVA: 0x0014EA08 File Offset: 0x0014CC08
		// (set) Token: 0x06003EC6 RID: 16070 RVA: 0x0001F2E8 File Offset: 0x0001D4E8
		public unsafe int IntensityRequirement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_IntensityRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_IntensityRequirement)) = value;
			}
		}

		// Token: 0x170013A9 RID: 5033
		// (get) Token: 0x06003EC7 RID: 16071 RVA: 0x0014EA30 File Offset: 0x0014CC30
		// (set) Token: 0x06003EC8 RID: 16072 RVA: 0x0001F303 File Offset: 0x0001D503
		public unsafe bool OnlyIfCurfewEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled)) = value;
			}
		}

		// Token: 0x170013AA RID: 5034
		// (get) Token: 0x06003EC9 RID: 16073 RVA: 0x0014EA58 File Offset: 0x0014CC58
		// (set) Token: 0x06003ECA RID: 16074 RVA: 0x0001F31E File Offset: 0x0001D51E
		public unsafe PatrolGroup _ActiveGroup_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr__ActiveGroup_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PatrolGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr__ActiveGroup_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002A4B RID: 10827
		private static readonly IntPtr NativeFieldInfoPtr_Route;

		// Token: 0x04002A4C RID: 10828
		private static readonly IntPtr NativeFieldInfoPtr_MinMembers;

		// Token: 0x04002A4D RID: 10829
		private static readonly IntPtr NativeFieldInfoPtr_MaxMembers;

		// Token: 0x04002A4E RID: 10830
		private static readonly IntPtr NativeFieldInfoPtr_StartTime;

		// Token: 0x04002A4F RID: 10831
		private static readonly IntPtr NativeFieldInfoPtr_EndTime;

		// Token: 0x04002A50 RID: 10832
		private static readonly IntPtr NativeFieldInfoPtr_IntensityRequirement;

		// Token: 0x04002A51 RID: 10833
		private static readonly IntPtr NativeFieldInfoPtr_OnlyIfCurfewEnabled;

		// Token: 0x04002A52 RID: 10834
		private static readonly IntPtr NativeFieldInfoPtr__ActiveGroup_k__BackingField;

		// Token: 0x04002A53 RID: 10835
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveGroup_Public_get_PatrolGroup_0;

		// Token: 0x04002A54 RID: 10836
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveGroup_Protected_set_Void_PatrolGroup_0;

		// Token: 0x04002A55 RID: 10837
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Void_0;

		// Token: 0x04002A56 RID: 10838
		private static readonly IntPtr NativeMethodInfoPtr_StartPatrol_Public_Void_0;

		// Token: 0x04002A57 RID: 10839
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x04002A58 RID: 10840
		private static readonly IntPtr NativeMethodInfoPtr_EndPatrol_Public_Void_0;

		// Token: 0x04002A59 RID: 10841
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
