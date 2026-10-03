using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004E9 RID: 1257
	public class IntervalEvent : MonoBehaviour
	{
		// Token: 0x06007231 RID: 29233 RVA: 0x00202960 File Offset: 0x00200B60
		// Note: this type is marked as 'beforefieldinit'.
		static IntervalEvent()
		{
			Il2CppClassPointerStore<IntervalEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "IntervalEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntervalEvent>.NativeClassPtr);
			IntervalEvent.NativeFieldInfoPtr_Interval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntervalEvent>.NativeClassPtr, "Interval");
			IntervalEvent.NativeFieldInfoPtr_Event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntervalEvent>.NativeClassPtr, "Event");
			IntervalEvent.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntervalEvent>.NativeClassPtr, 100678072);
			IntervalEvent.NativeMethodInfoPtr_Execute_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntervalEvent>.NativeClassPtr, 100678073);
			IntervalEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntervalEvent>.NativeClassPtr, 100678074);
		}

		// Token: 0x06007232 RID: 29234 RVA: 0x002029F4 File Offset: 0x00200BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226220, XrefRangeEnd = 226223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntervalEvent.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007233 RID: 29235 RVA: 0x00202A28 File Offset: 0x00200C28
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 100729, RefRangeEnd = 100734, XrefRangeStart = 100729, XrefRangeEnd = 100734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntervalEvent.NativeMethodInfoPtr_Execute_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007234 RID: 29236 RVA: 0x00202A5C File Offset: 0x00200C5C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 68082, RefRangeEnd = 68086, XrefRangeStart = 68082, XrefRangeEnd = 68086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntervalEvent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntervalEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntervalEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007235 RID: 29237 RVA: 0x000364EF File Offset: 0x000346EF
		public IntervalEvent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002343 RID: 9027
		// (get) Token: 0x06007236 RID: 29238 RVA: 0x00202A98 File Offset: 0x00200C98
		// (set) Token: 0x06007237 RID: 29239 RVA: 0x000364F8 File Offset: 0x000346F8
		public unsafe float Interval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntervalEvent.NativeFieldInfoPtr_Interval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntervalEvent.NativeFieldInfoPtr_Interval)) = value;
			}
		}

		// Token: 0x17002344 RID: 9028
		// (get) Token: 0x06007238 RID: 29240 RVA: 0x00202AC0 File Offset: 0x00200CC0
		// (set) Token: 0x06007239 RID: 29241 RVA: 0x00036513 File Offset: 0x00034713
		public unsafe UnityEvent Event
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntervalEvent.NativeFieldInfoPtr_Event);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntervalEvent.NativeFieldInfoPtr_Event), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004E01 RID: 19969
		private static readonly IntPtr NativeFieldInfoPtr_Interval;

		// Token: 0x04004E02 RID: 19970
		private static readonly IntPtr NativeFieldInfoPtr_Event;

		// Token: 0x04004E03 RID: 19971
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04004E04 RID: 19972
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Void_0;

		// Token: 0x04004E05 RID: 19973
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
