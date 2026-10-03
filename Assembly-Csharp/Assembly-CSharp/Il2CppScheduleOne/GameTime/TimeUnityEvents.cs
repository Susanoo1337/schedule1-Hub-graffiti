using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.GameTime
{
	// Token: 0x0200010E RID: 270
	public class TimeUnityEvents : MonoBehaviour
	{
		// Token: 0x06001A7E RID: 6782 RVA: 0x000D29E4 File Offset: 0x000D0BE4
		// Note: this type is marked as 'beforefieldinit'.
		static TimeUnityEvents()
		{
			Il2CppClassPointerStore<TimeUnityEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.GameTime", "TimeUnityEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeUnityEvents>.NativeClassPtr);
			TimeUnityEvents.NativeFieldInfoPtr_onHourPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeUnityEvents>.NativeClassPtr, "onHourPass");
			TimeUnityEvents.NativeFieldInfoPtr_onDayPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeUnityEvents>.NativeClassPtr, "onDayPass");
			TimeUnityEvents.NativeFieldInfoPtr_onSleepStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeUnityEvents>.NativeClassPtr, "onSleepStart");
			TimeUnityEvents.NativeFieldInfoPtr_onSleepEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeUnityEvents>.NativeClassPtr, "onSleepEnd");
			TimeUnityEvents.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUnityEvents>.NativeClassPtr, 100666848);
			TimeUnityEvents.NativeMethodInfoPtr_HourPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUnityEvents>.NativeClassPtr, 100666849);
			TimeUnityEvents.NativeMethodInfoPtr_DayPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUnityEvents>.NativeClassPtr, 100666850);
			TimeUnityEvents.NativeMethodInfoPtr_SleepStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUnityEvents>.NativeClassPtr, 100666851);
			TimeUnityEvents.NativeMethodInfoPtr_SleepEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUnityEvents>.NativeClassPtr, 100666852);
			TimeUnityEvents.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUnityEvents>.NativeClassPtr, 100666853);
		}

		// Token: 0x06001A7F RID: 6783 RVA: 0x000D2ADC File Offset: 0x000D0CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100608, XrefRangeEnd = 100727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeUnityEvents.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A80 RID: 6784 RVA: 0x000D2B10 File Offset: 0x000D0D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100727, XrefRangeEnd = 100728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HourPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeUnityEvents.NativeMethodInfoPtr_HourPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x000D2B44 File Offset: 0x000D0D44
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 100729, RefRangeEnd = 100734, XrefRangeStart = 100728, XrefRangeEnd = 100729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DayPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeUnityEvents.NativeMethodInfoPtr_DayPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x000D2B78 File Offset: 0x000D0D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100734, XrefRangeEnd = 100735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SleepStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeUnityEvents.NativeMethodInfoPtr_SleepStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x000D2BAC File Offset: 0x000D0DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100735, XrefRangeEnd = 100736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SleepEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeUnityEvents.NativeMethodInfoPtr_SleepEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A84 RID: 6788 RVA: 0x000D2BE0 File Offset: 0x000D0DE0
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeUnityEvents() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeUnityEvents>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeUnityEvents.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A85 RID: 6789 RVA: 0x0000E6B6 File Offset: 0x0000C8B6
		public TimeUnityEvents(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x06001A86 RID: 6790 RVA: 0x000D2C1C File Offset: 0x000D0E1C
		// (set) Token: 0x06001A87 RID: 6791 RVA: 0x0000E6BF File Offset: 0x0000C8BF
		public unsafe UnityEvent onHourPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeUnityEvents.NativeFieldInfoPtr_onHourPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeUnityEvents.NativeFieldInfoPtr_onHourPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x06001A88 RID: 6792 RVA: 0x000D2C4C File Offset: 0x000D0E4C
		// (set) Token: 0x06001A89 RID: 6793 RVA: 0x0000E6DE File Offset: 0x0000C8DE
		public unsafe UnityEvent onDayPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeUnityEvents.NativeFieldInfoPtr_onDayPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeUnityEvents.NativeFieldInfoPtr_onDayPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x06001A8A RID: 6794 RVA: 0x000D2C7C File Offset: 0x000D0E7C
		// (set) Token: 0x06001A8B RID: 6795 RVA: 0x0000E6FD File Offset: 0x0000C8FD
		public unsafe UnityEvent onSleepStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeUnityEvents.NativeFieldInfoPtr_onSleepStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeUnityEvents.NativeFieldInfoPtr_onSleepStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x06001A8C RID: 6796 RVA: 0x000D2CAC File Offset: 0x000D0EAC
		// (set) Token: 0x06001A8D RID: 6797 RVA: 0x0000E71C File Offset: 0x0000C91C
		public unsafe UnityEvent onSleepEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeUnityEvents.NativeFieldInfoPtr_onSleepEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeUnityEvents.NativeFieldInfoPtr_onSleepEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001267 RID: 4711
		private static readonly IntPtr NativeFieldInfoPtr_onHourPass;

		// Token: 0x04001268 RID: 4712
		private static readonly IntPtr NativeFieldInfoPtr_onDayPass;

		// Token: 0x04001269 RID: 4713
		private static readonly IntPtr NativeFieldInfoPtr_onSleepStart;

		// Token: 0x0400126A RID: 4714
		private static readonly IntPtr NativeFieldInfoPtr_onSleepEnd;

		// Token: 0x0400126B RID: 4715
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400126C RID: 4716
		private static readonly IntPtr NativeMethodInfoPtr_HourPass_Private_Void_0;

		// Token: 0x0400126D RID: 4717
		private static readonly IntPtr NativeMethodInfoPtr_DayPass_Private_Void_0;

		// Token: 0x0400126E RID: 4718
		private static readonly IntPtr NativeMethodInfoPtr_SleepStart_Private_Void_0;

		// Token: 0x0400126F RID: 4719
		private static readonly IntPtr NativeMethodInfoPtr_SleepEnd_Private_Void_0;

		// Token: 0x04001270 RID: 4720
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
