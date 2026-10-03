using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.NPCs.Behaviour;
using Il2CppScheduleOne.Police;
using Il2CppSystem;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x02000321 RID: 801
	[Serializable]
	public class VehiclePatrolInstance : Object
	{
		// Token: 0x06003F0D RID: 16141 RVA: 0x0014F38C File Offset: 0x0014D58C
		// Note: this type is marked as 'beforefieldinit'.
		static VehiclePatrolInstance()
		{
			Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "VehiclePatrolInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr);
			VehiclePatrolInstance.NativeFieldInfoPtr_Route = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, "Route");
			VehiclePatrolInstance.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, "StartTime");
			VehiclePatrolInstance.NativeFieldInfoPtr_IntensityRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, "IntensityRequirement");
			VehiclePatrolInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, "OnlyIfCurfewEnabled");
			VehiclePatrolInstance.NativeFieldInfoPtr_activeOfficer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, "activeOfficer");
			VehiclePatrolInstance.NativeFieldInfoPtr_latestStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, "latestStartTime");
			VehiclePatrolInstance.NativeFieldInfoPtr_startedThisCycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, "startedThisCycle");
			VehiclePatrolInstance.NativeMethodInfoPtr_get_nearestStation_Private_get_PoliceStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, 100671294);
			VehiclePatrolInstance.NativeMethodInfoPtr_Evaluate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, 100671295);
			VehiclePatrolInstance.NativeMethodInfoPtr_CheckEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, 100671296);
			VehiclePatrolInstance.NativeMethodInfoPtr_StartPatrol_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, 100671297);
			VehiclePatrolInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, 100671298);
		}

		// Token: 0x170013CD RID: 5069
		// (get) Token: 0x06003F0E RID: 16142 RVA: 0x0014F4AC File Offset: 0x0014D6AC
		public unsafe PoliceStation nearestStation
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 153252, RefRangeEnd = 153258, XrefRangeStart = 153246, XrefRangeEnd = 153252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePatrolInstance.NativeMethodInfoPtr_get_nearestStation_Private_get_PoliceStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PoliceStation>(intPtr3) : null;
			}
		}

		// Token: 0x06003F0F RID: 16143 RVA: 0x0014F4EC File Offset: 0x0014D6EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 153295, RefRangeEnd = 153296, XrefRangeStart = 153258, XrefRangeEnd = 153295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Evaluate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePatrolInstance.NativeMethodInfoPtr_Evaluate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F10 RID: 16144 RVA: 0x0014F520 File Offset: 0x0014D720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153296, XrefRangeEnd = 153301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePatrolInstance.NativeMethodInfoPtr_CheckEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F11 RID: 16145 RVA: 0x0014F554 File Offset: 0x0014D754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153301, XrefRangeEnd = 153320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartPatrol()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePatrolInstance.NativeMethodInfoPtr_StartPatrol_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F12 RID: 16146 RVA: 0x0014F588 File Offset: 0x0014D788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153320, XrefRangeEnd = 153321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehiclePatrolInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePatrolInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F13 RID: 16147 RVA: 0x0001F559 File Offset: 0x0001D759
		public VehiclePatrolInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170013C6 RID: 5062
		// (get) Token: 0x06003F14 RID: 16148 RVA: 0x0014F5C4 File Offset: 0x0014D7C4
		// (set) Token: 0x06003F15 RID: 16149 RVA: 0x0001F562 File Offset: 0x0001D762
		public unsafe VehiclePatrolRoute Route
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_Route);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehiclePatrolRoute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_Route), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013C7 RID: 5063
		// (get) Token: 0x06003F16 RID: 16150 RVA: 0x0014F5F4 File Offset: 0x0014D7F4
		// (set) Token: 0x06003F17 RID: 16151 RVA: 0x0001F581 File Offset: 0x0001D781
		public unsafe int StartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_StartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_StartTime)) = value;
			}
		}

		// Token: 0x170013C8 RID: 5064
		// (get) Token: 0x06003F18 RID: 16152 RVA: 0x0014F61C File Offset: 0x0014D81C
		// (set) Token: 0x06003F19 RID: 16153 RVA: 0x0001F59C File Offset: 0x0001D79C
		public unsafe int IntensityRequirement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_IntensityRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_IntensityRequirement)) = value;
			}
		}

		// Token: 0x170013C9 RID: 5065
		// (get) Token: 0x06003F1A RID: 16154 RVA: 0x0014F644 File Offset: 0x0014D844
		// (set) Token: 0x06003F1B RID: 16155 RVA: 0x0001F5B7 File Offset: 0x0001D7B7
		public unsafe bool OnlyIfCurfewEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled)) = value;
			}
		}

		// Token: 0x170013CA RID: 5066
		// (get) Token: 0x06003F1C RID: 16156 RVA: 0x0014F66C File Offset: 0x0014D86C
		// (set) Token: 0x06003F1D RID: 16157 RVA: 0x0001F5D2 File Offset: 0x0001D7D2
		public unsafe PoliceOfficer activeOfficer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_activeOfficer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceOfficer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_activeOfficer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013CB RID: 5067
		// (get) Token: 0x06003F1E RID: 16158 RVA: 0x0014F69C File Offset: 0x0014D89C
		// (set) Token: 0x06003F1F RID: 16159 RVA: 0x0001F5F1 File Offset: 0x0001D7F1
		public unsafe int latestStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_latestStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_latestStartTime)) = value;
			}
		}

		// Token: 0x170013CC RID: 5068
		// (get) Token: 0x06003F20 RID: 16160 RVA: 0x0014F6C4 File Offset: 0x0014D8C4
		// (set) Token: 0x06003F21 RID: 16161 RVA: 0x0001F60C File Offset: 0x0001D80C
		public unsafe bool startedThisCycle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_startedThisCycle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_startedThisCycle)) = value;
			}
		}

		// Token: 0x04002A7D RID: 10877
		private static readonly IntPtr NativeFieldInfoPtr_Route;

		// Token: 0x04002A7E RID: 10878
		private static readonly IntPtr NativeFieldInfoPtr_StartTime;

		// Token: 0x04002A7F RID: 10879
		private static readonly IntPtr NativeFieldInfoPtr_IntensityRequirement;

		// Token: 0x04002A80 RID: 10880
		private static readonly IntPtr NativeFieldInfoPtr_OnlyIfCurfewEnabled;

		// Token: 0x04002A81 RID: 10881
		private static readonly IntPtr NativeFieldInfoPtr_activeOfficer;

		// Token: 0x04002A82 RID: 10882
		private static readonly IntPtr NativeFieldInfoPtr_latestStartTime;

		// Token: 0x04002A83 RID: 10883
		private static readonly IntPtr NativeFieldInfoPtr_startedThisCycle;

		// Token: 0x04002A84 RID: 10884
		private static readonly IntPtr NativeMethodInfoPtr_get_nearestStation_Private_get_PoliceStation_0;

		// Token: 0x04002A85 RID: 10885
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Void_0;

		// Token: 0x04002A86 RID: 10886
		private static readonly IntPtr NativeMethodInfoPtr_CheckEnd_Private_Void_0;

		// Token: 0x04002A87 RID: 10887
		private static readonly IntPtr NativeMethodInfoPtr_StartPatrol_Public_Void_0;

		// Token: 0x04002A88 RID: 10888
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
