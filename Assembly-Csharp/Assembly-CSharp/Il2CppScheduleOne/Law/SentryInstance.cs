using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Police;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x0200031F RID: 799
	[Serializable]
	public class SentryInstance : Object
	{
		// Token: 0x06003EEA RID: 16106 RVA: 0x0014EDB0 File Offset: 0x0014CFB0
		// Note: this type is marked as 'beforefieldinit'.
		static SentryInstance()
		{
			Il2CppClassPointerStore<SentryInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "SentryInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr);
			SentryInstance.NativeFieldInfoPtr__potentialLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, "_potentialLocations");
			SentryInstance.NativeFieldInfoPtr_MinMembers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, "MinMembers");
			SentryInstance.NativeFieldInfoPtr_MaxMembers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, "MaxMembers");
			SentryInstance.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, "StartTime");
			SentryInstance.NativeFieldInfoPtr_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, "EndTime");
			SentryInstance.NativeFieldInfoPtr_IntensityRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, "IntensityRequirement");
			SentryInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, "OnlyIfCurfewEnabled");
			SentryInstance.NativeFieldInfoPtr__activeOfficers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, "_activeOfficers");
			SentryInstance.NativeFieldInfoPtr__activeLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, "_activeLocation");
			SentryInstance.NativeMethodInfoPtr_Evaluate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, 100671284);
			SentryInstance.NativeMethodInfoPtr_StartEntry_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, 100671285);
			SentryInstance.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, 100671286);
			SentryInstance.NativeMethodInfoPtr_EndSentry_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, 100671287);
			SentryInstance.NativeMethodInfoPtr_GetRandomUnoccupiedLocation_Private_SentryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, 100671288);
			SentryInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, 100671289);
		}

		// Token: 0x06003EEB RID: 16107 RVA: 0x0014EF0C File Offset: 0x0014D10C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153117, XrefRangeEnd = 153134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Evaluate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryInstance.NativeMethodInfoPtr_Evaluate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EEC RID: 16108 RVA: 0x0014EF40 File Offset: 0x0014D140
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 153173, RefRangeEnd = 153175, XrefRangeStart = 153134, XrefRangeEnd = 153173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartEntry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryInstance.NativeMethodInfoPtr_StartEntry_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EED RID: 16109 RVA: 0x0014EF74 File Offset: 0x0014D174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153175, XrefRangeEnd = 153181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryInstance.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EEE RID: 16110 RVA: 0x0014EFA8 File Offset: 0x0014D1A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 153202, RefRangeEnd = 153203, XrefRangeStart = 153181, XrefRangeEnd = 153202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndSentry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryInstance.NativeMethodInfoPtr_EndSentry_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EEF RID: 16111 RVA: 0x0014EFDC File Offset: 0x0014D1DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 153219, RefRangeEnd = 153222, XrefRangeStart = 153203, XrefRangeEnd = 153219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SentryLocation GetRandomUnoccupiedLocation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryInstance.NativeMethodInfoPtr_GetRandomUnoccupiedLocation_Private_SentryLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SentryLocation>(intPtr3) : null;
		}

		// Token: 0x06003EF0 RID: 16112 RVA: 0x0014F01C File Offset: 0x0014D21C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153222, XrefRangeEnd = 153230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SentryInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EF1 RID: 16113 RVA: 0x0001F40A File Offset: 0x0001D60A
		public SentryInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170013BA RID: 5050
		// (get) Token: 0x06003EF2 RID: 16114 RVA: 0x0014F058 File Offset: 0x0014D258
		// (set) Token: 0x06003EF3 RID: 16115 RVA: 0x0001F413 File Offset: 0x0001D613
		public unsafe Il2CppReferenceArray<SentryLocation> _potentialLocations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr__potentialLocations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SentryLocation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr__potentialLocations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013BB RID: 5051
		// (get) Token: 0x06003EF4 RID: 16116 RVA: 0x0014F088 File Offset: 0x0014D288
		// (set) Token: 0x06003EF5 RID: 16117 RVA: 0x0001F432 File Offset: 0x0001D632
		public unsafe int MinMembers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_MinMembers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_MinMembers)) = value;
			}
		}

		// Token: 0x170013BC RID: 5052
		// (get) Token: 0x06003EF6 RID: 16118 RVA: 0x0014F0B0 File Offset: 0x0014D2B0
		// (set) Token: 0x06003EF7 RID: 16119 RVA: 0x0001F44D File Offset: 0x0001D64D
		public unsafe int MaxMembers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_MaxMembers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_MaxMembers)) = value;
			}
		}

		// Token: 0x170013BD RID: 5053
		// (get) Token: 0x06003EF8 RID: 16120 RVA: 0x0014F0D8 File Offset: 0x0014D2D8
		// (set) Token: 0x06003EF9 RID: 16121 RVA: 0x0001F468 File Offset: 0x0001D668
		public unsafe int StartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_StartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_StartTime)) = value;
			}
		}

		// Token: 0x170013BE RID: 5054
		// (get) Token: 0x06003EFA RID: 16122 RVA: 0x0014F100 File Offset: 0x0014D300
		// (set) Token: 0x06003EFB RID: 16123 RVA: 0x0001F483 File Offset: 0x0001D683
		public unsafe int EndTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_EndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_EndTime)) = value;
			}
		}

		// Token: 0x170013BF RID: 5055
		// (get) Token: 0x06003EFC RID: 16124 RVA: 0x0014F128 File Offset: 0x0014D328
		// (set) Token: 0x06003EFD RID: 16125 RVA: 0x0001F49E File Offset: 0x0001D69E
		public unsafe int IntensityRequirement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_IntensityRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_IntensityRequirement)) = value;
			}
		}

		// Token: 0x170013C0 RID: 5056
		// (get) Token: 0x06003EFE RID: 16126 RVA: 0x0014F150 File Offset: 0x0014D350
		// (set) Token: 0x06003EFF RID: 16127 RVA: 0x0001F4B9 File Offset: 0x0001D6B9
		public unsafe bool OnlyIfCurfewEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled)) = value;
			}
		}

		// Token: 0x170013C1 RID: 5057
		// (get) Token: 0x06003F00 RID: 16128 RVA: 0x0014F178 File Offset: 0x0014D378
		// (set) Token: 0x06003F01 RID: 16129 RVA: 0x0001F4D4 File Offset: 0x0001D6D4
		public unsafe List<PoliceOfficer> _activeOfficers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr__activeOfficers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PoliceOfficer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr__activeOfficers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013C2 RID: 5058
		// (get) Token: 0x06003F02 RID: 16130 RVA: 0x0014F1A8 File Offset: 0x0014D3A8
		// (set) Token: 0x06003F03 RID: 16131 RVA: 0x0001F4F3 File Offset: 0x0001D6F3
		public unsafe SentryLocation _activeLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr__activeLocation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SentryLocation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr__activeLocation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002A69 RID: 10857
		private static readonly IntPtr NativeFieldInfoPtr__potentialLocations;

		// Token: 0x04002A6A RID: 10858
		private static readonly IntPtr NativeFieldInfoPtr_MinMembers;

		// Token: 0x04002A6B RID: 10859
		private static readonly IntPtr NativeFieldInfoPtr_MaxMembers;

		// Token: 0x04002A6C RID: 10860
		private static readonly IntPtr NativeFieldInfoPtr_StartTime;

		// Token: 0x04002A6D RID: 10861
		private static readonly IntPtr NativeFieldInfoPtr_EndTime;

		// Token: 0x04002A6E RID: 10862
		private static readonly IntPtr NativeFieldInfoPtr_IntensityRequirement;

		// Token: 0x04002A6F RID: 10863
		private static readonly IntPtr NativeFieldInfoPtr_OnlyIfCurfewEnabled;

		// Token: 0x04002A70 RID: 10864
		private static readonly IntPtr NativeFieldInfoPtr__activeOfficers;

		// Token: 0x04002A71 RID: 10865
		private static readonly IntPtr NativeFieldInfoPtr__activeLocation;

		// Token: 0x04002A72 RID: 10866
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Void_0;

		// Token: 0x04002A73 RID: 10867
		private static readonly IntPtr NativeMethodInfoPtr_StartEntry_Public_Void_0;

		// Token: 0x04002A74 RID: 10868
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x04002A75 RID: 10869
		private static readonly IntPtr NativeMethodInfoPtr_EndSentry_Public_Void_0;

		// Token: 0x04002A76 RID: 10870
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomUnoccupiedLocation_Private_SentryLocation_0;

		// Token: 0x04002A77 RID: 10871
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
