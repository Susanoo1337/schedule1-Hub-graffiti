using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Cutscenes
{
	// Token: 0x02000420 RID: 1056
	public class EndCutscene : Cutscene
	{
		// Token: 0x06005D53 RID: 23891 RVA: 0x001BCF6C File Offset: 0x001BB16C
		// Note: this type is marked as 'beforefieldinit'.
		static EndCutscene()
		{
			Il2CppClassPointerStore<EndCutscene>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Cutscenes", "EndCutscene");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr);
			EndCutscene.NativeFieldInfoPtr_onStandUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr, "onStandUp");
			EndCutscene.NativeFieldInfoPtr_onRunStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr, "onRunStart");
			EndCutscene.NativeFieldInfoPtr_onEngineStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr, "onEngineStart");
			EndCutscene.NativeFieldInfoPtr_onLightsOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr, "onLightsOn");
			EndCutscene.NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr, "Avatar");
			EndCutscene.NativeMethodInfoPtr_Play_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr, 100675480);
			EndCutscene.NativeMethodInfoPtr_StandUp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr, 100675481);
			EndCutscene.NativeMethodInfoPtr_RunStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr, 100675482);
			EndCutscene.NativeMethodInfoPtr_EngineStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr, 100675483);
			EndCutscene.NativeMethodInfoPtr_LightsOn_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr, 100675484);
			EndCutscene.NativeMethodInfoPtr_On3rdPerson_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr, 100675485);
			EndCutscene.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr, 100675486);
		}

		// Token: 0x06005D54 RID: 23892 RVA: 0x001BD08C File Offset: 0x001BB28C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199567, XrefRangeEnd = 199574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EndCutscene.NativeMethodInfoPtr_Play_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D55 RID: 23893 RVA: 0x001BD0C8 File Offset: 0x001BB2C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199574, XrefRangeEnd = 199575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StandUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndCutscene.NativeMethodInfoPtr_StandUp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D56 RID: 23894 RVA: 0x001BD0FC File Offset: 0x001BB2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199575, XrefRangeEnd = 199576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndCutscene.NativeMethodInfoPtr_RunStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D57 RID: 23895 RVA: 0x001BD130 File Offset: 0x001BB330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199576, XrefRangeEnd = 199577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EngineStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndCutscene.NativeMethodInfoPtr_EngineStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D58 RID: 23896 RVA: 0x001BD164 File Offset: 0x001BB364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199577, XrefRangeEnd = 199578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LightsOn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndCutscene.NativeMethodInfoPtr_LightsOn_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D59 RID: 23897 RVA: 0x001BD198 File Offset: 0x001BB398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199578, XrefRangeEnd = 199584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void On3rdPerson()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndCutscene.NativeMethodInfoPtr_On3rdPerson_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D5A RID: 23898 RVA: 0x001BD1CC File Offset: 0x001BB3CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EndCutscene() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndCutscene.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D5B RID: 23899 RVA: 0x0002C3BB File Offset: 0x0002A5BB
		public EndCutscene(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CD5 RID: 7381
		// (get) Token: 0x06005D5C RID: 23900 RVA: 0x001BD208 File Offset: 0x001BB408
		// (set) Token: 0x06005D5D RID: 23901 RVA: 0x0002C3C4 File Offset: 0x0002A5C4
		public unsafe UnityEvent onStandUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndCutscene.NativeFieldInfoPtr_onStandUp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndCutscene.NativeFieldInfoPtr_onStandUp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CD6 RID: 7382
		// (get) Token: 0x06005D5E RID: 23902 RVA: 0x001BD238 File Offset: 0x001BB438
		// (set) Token: 0x06005D5F RID: 23903 RVA: 0x0002C3E3 File Offset: 0x0002A5E3
		public unsafe UnityEvent onRunStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndCutscene.NativeFieldInfoPtr_onRunStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndCutscene.NativeFieldInfoPtr_onRunStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CD7 RID: 7383
		// (get) Token: 0x06005D60 RID: 23904 RVA: 0x001BD268 File Offset: 0x001BB468
		// (set) Token: 0x06005D61 RID: 23905 RVA: 0x0002C402 File Offset: 0x0002A602
		public unsafe UnityEvent onEngineStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndCutscene.NativeFieldInfoPtr_onEngineStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndCutscene.NativeFieldInfoPtr_onEngineStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CD8 RID: 7384
		// (get) Token: 0x06005D62 RID: 23906 RVA: 0x001BD298 File Offset: 0x001BB498
		// (set) Token: 0x06005D63 RID: 23907 RVA: 0x0002C421 File Offset: 0x0002A621
		public unsafe UnityEvent onLightsOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndCutscene.NativeFieldInfoPtr_onLightsOn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndCutscene.NativeFieldInfoPtr_onLightsOn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CD9 RID: 7385
		// (get) Token: 0x06005D64 RID: 23908 RVA: 0x001BD2C8 File Offset: 0x001BB4C8
		// (set) Token: 0x06005D65 RID: 23909 RVA: 0x0002C440 File Offset: 0x0002A640
		public unsafe Avatar Avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndCutscene.NativeFieldInfoPtr_Avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndCutscene.NativeFieldInfoPtr_Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004007 RID: 16391
		private static readonly IntPtr NativeFieldInfoPtr_onStandUp;

		// Token: 0x04004008 RID: 16392
		private static readonly IntPtr NativeFieldInfoPtr_onRunStart;

		// Token: 0x04004009 RID: 16393
		private static readonly IntPtr NativeFieldInfoPtr_onEngineStart;

		// Token: 0x0400400A RID: 16394
		private static readonly IntPtr NativeFieldInfoPtr_onLightsOn;

		// Token: 0x0400400B RID: 16395
		private static readonly IntPtr NativeFieldInfoPtr_Avatar;

		// Token: 0x0400400C RID: 16396
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Virtual_Void_0;

		// Token: 0x0400400D RID: 16397
		private static readonly IntPtr NativeMethodInfoPtr_StandUp_Public_Void_0;

		// Token: 0x0400400E RID: 16398
		private static readonly IntPtr NativeMethodInfoPtr_RunStart_Public_Void_0;

		// Token: 0x0400400F RID: 16399
		private static readonly IntPtr NativeMethodInfoPtr_EngineStart_Public_Void_0;

		// Token: 0x04004010 RID: 16400
		private static readonly IntPtr NativeMethodInfoPtr_LightsOn_Public_Void_0;

		// Token: 0x04004011 RID: 16401
		private static readonly IntPtr NativeMethodInfoPtr_On3rdPerson_Public_Void_0;

		// Token: 0x04004012 RID: 16402
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
