using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x0200031A RID: 794
	[Serializable]
	public class LawActivitySettings : Object
	{
		// Token: 0x06003E4C RID: 15948 RVA: 0x0014D170 File Offset: 0x0014B370
		// Note: this type is marked as 'beforefieldinit'.
		static LawActivitySettings()
		{
			Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "LawActivitySettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr);
			LawActivitySettings.NativeFieldInfoPtr_Patrols = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr, "Patrols");
			LawActivitySettings.NativeFieldInfoPtr_Checkpoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr, "Checkpoints");
			LawActivitySettings.NativeFieldInfoPtr_Curfews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr, "Curfews");
			LawActivitySettings.NativeFieldInfoPtr_VehiclePatrols = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr, "VehiclePatrols");
			LawActivitySettings.NativeFieldInfoPtr_Sentries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr, "Sentries");
			LawActivitySettings.NativeMethodInfoPtr_Evaluate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr, 100671230);
			LawActivitySettings.NativeMethodInfoPtr_End_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr, 100671231);
			LawActivitySettings.NativeMethodInfoPtr_OnLoaded_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr, 100671232);
			LawActivitySettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr, 100671233);
		}

		// Token: 0x06003E4D RID: 15949 RVA: 0x0014D254 File Offset: 0x0014B454
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 152663, RefRangeEnd = 152664, XrefRangeStart = 152626, XrefRangeEnd = 152663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Evaluate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawActivitySettings.NativeMethodInfoPtr_Evaluate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E4E RID: 15950 RVA: 0x0014D288 File Offset: 0x0014B488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152664, XrefRangeEnd = 152665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawActivitySettings.NativeMethodInfoPtr_End_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E4F RID: 15951 RVA: 0x0014D2BC File Offset: 0x0014B4BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152665, XrefRangeEnd = 152673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLoaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawActivitySettings.NativeMethodInfoPtr_OnLoaded_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E50 RID: 15952 RVA: 0x0014D2F0 File Offset: 0x0014B4F0
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LawActivitySettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawActivitySettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E51 RID: 15953 RVA: 0x0001EF50 File Offset: 0x0001D150
		public LawActivitySettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700137D RID: 4989
		// (get) Token: 0x06003E52 RID: 15954 RVA: 0x0014D32C File Offset: 0x0014B52C
		// (set) Token: 0x06003E53 RID: 15955 RVA: 0x0001EF59 File Offset: 0x0001D159
		public unsafe Il2CppReferenceArray<PatrolInstance> Patrols
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawActivitySettings.NativeFieldInfoPtr_Patrols);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PatrolInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawActivitySettings.NativeFieldInfoPtr_Patrols), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700137E RID: 4990
		// (get) Token: 0x06003E54 RID: 15956 RVA: 0x0014D35C File Offset: 0x0014B55C
		// (set) Token: 0x06003E55 RID: 15957 RVA: 0x0001EF78 File Offset: 0x0001D178
		public unsafe Il2CppReferenceArray<CheckpointInstance> Checkpoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawActivitySettings.NativeFieldInfoPtr_Checkpoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CheckpointInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawActivitySettings.NativeFieldInfoPtr_Checkpoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700137F RID: 4991
		// (get) Token: 0x06003E56 RID: 15958 RVA: 0x0014D38C File Offset: 0x0014B58C
		// (set) Token: 0x06003E57 RID: 15959 RVA: 0x0001EF97 File Offset: 0x0001D197
		public unsafe Il2CppReferenceArray<CurfewInstance> Curfews
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawActivitySettings.NativeFieldInfoPtr_Curfews);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CurfewInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawActivitySettings.NativeFieldInfoPtr_Curfews), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001380 RID: 4992
		// (get) Token: 0x06003E58 RID: 15960 RVA: 0x0014D3BC File Offset: 0x0014B5BC
		// (set) Token: 0x06003E59 RID: 15961 RVA: 0x0001EFB6 File Offset: 0x0001D1B6
		public unsafe Il2CppReferenceArray<VehiclePatrolInstance> VehiclePatrols
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawActivitySettings.NativeFieldInfoPtr_VehiclePatrols);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VehiclePatrolInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawActivitySettings.NativeFieldInfoPtr_VehiclePatrols), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001381 RID: 4993
		// (get) Token: 0x06003E5A RID: 15962 RVA: 0x0014D3EC File Offset: 0x0014B5EC
		// (set) Token: 0x06003E5B RID: 15963 RVA: 0x0001EFD5 File Offset: 0x0001D1D5
		public unsafe Il2CppReferenceArray<SentryInstance> Sentries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawActivitySettings.NativeFieldInfoPtr_Sentries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SentryInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawActivitySettings.NativeFieldInfoPtr_Sentries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002A06 RID: 10758
		private static readonly IntPtr NativeFieldInfoPtr_Patrols;

		// Token: 0x04002A07 RID: 10759
		private static readonly IntPtr NativeFieldInfoPtr_Checkpoints;

		// Token: 0x04002A08 RID: 10760
		private static readonly IntPtr NativeFieldInfoPtr_Curfews;

		// Token: 0x04002A09 RID: 10761
		private static readonly IntPtr NativeFieldInfoPtr_VehiclePatrols;

		// Token: 0x04002A0A RID: 10762
		private static readonly IntPtr NativeFieldInfoPtr_Sentries;

		// Token: 0x04002A0B RID: 10763
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Void_0;

		// Token: 0x04002A0C RID: 10764
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Void_0;

		// Token: 0x04002A0D RID: 10765
		private static readonly IntPtr NativeMethodInfoPtr_OnLoaded_Public_Void_0;

		// Token: 0x04002A0E RID: 10766
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
