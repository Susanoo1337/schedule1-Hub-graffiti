using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004F7 RID: 1271
	public class RandomIntervalEvent : MonoBehaviour
	{
		// Token: 0x06007302 RID: 29442 RVA: 0x00205404 File Offset: 0x00203604
		// Note: this type is marked as 'beforefieldinit'.
		static RandomIntervalEvent()
		{
			Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "RandomIntervalEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr);
			RandomIntervalEvent.NativeFieldInfoPtr_MinInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr, "MinInterval");
			RandomIntervalEvent.NativeFieldInfoPtr_MaxInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr, "MaxInterval");
			RandomIntervalEvent.NativeFieldInfoPtr_ExecuteOnEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr, "ExecuteOnEnable");
			RandomIntervalEvent.NativeFieldInfoPtr_OnInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr, "OnInterval");
			RandomIntervalEvent.NativeFieldInfoPtr_nextInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr, "nextInterval");
			RandomIntervalEvent.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr, 100678170);
			RandomIntervalEvent.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr, 100678171);
			RandomIntervalEvent.NativeMethodInfoPtr_Execute_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr, 100678172);
			RandomIntervalEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr, 100678173);
		}

		// Token: 0x06007303 RID: 29443 RVA: 0x002054E8 File Offset: 0x002036E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227105, XrefRangeEnd = 227110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomIntervalEvent.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007304 RID: 29444 RVA: 0x0020551C File Offset: 0x0020371C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227110, XrefRangeEnd = 227114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomIntervalEvent.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007305 RID: 29445 RVA: 0x00205550 File Offset: 0x00203750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227114, XrefRangeEnd = 227117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomIntervalEvent.NativeMethodInfoPtr_Execute_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007306 RID: 29446 RVA: 0x00205584 File Offset: 0x00203784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227117, XrefRangeEnd = 227118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RandomIntervalEvent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomIntervalEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007307 RID: 29447 RVA: 0x00036AB3 File Offset: 0x00034CB3
		public RandomIntervalEvent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002375 RID: 9077
		// (get) Token: 0x06007308 RID: 29448 RVA: 0x002055C0 File Offset: 0x002037C0
		// (set) Token: 0x06007309 RID: 29449 RVA: 0x00036ABC File Offset: 0x00034CBC
		public unsafe float MinInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomIntervalEvent.NativeFieldInfoPtr_MinInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomIntervalEvent.NativeFieldInfoPtr_MinInterval)) = value;
			}
		}

		// Token: 0x17002376 RID: 9078
		// (get) Token: 0x0600730A RID: 29450 RVA: 0x002055E8 File Offset: 0x002037E8
		// (set) Token: 0x0600730B RID: 29451 RVA: 0x00036AD7 File Offset: 0x00034CD7
		public unsafe float MaxInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomIntervalEvent.NativeFieldInfoPtr_MaxInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomIntervalEvent.NativeFieldInfoPtr_MaxInterval)) = value;
			}
		}

		// Token: 0x17002377 RID: 9079
		// (get) Token: 0x0600730C RID: 29452 RVA: 0x00205610 File Offset: 0x00203810
		// (set) Token: 0x0600730D RID: 29453 RVA: 0x00036AF2 File Offset: 0x00034CF2
		public unsafe bool ExecuteOnEnable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomIntervalEvent.NativeFieldInfoPtr_ExecuteOnEnable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomIntervalEvent.NativeFieldInfoPtr_ExecuteOnEnable)) = value;
			}
		}

		// Token: 0x17002378 RID: 9080
		// (get) Token: 0x0600730E RID: 29454 RVA: 0x00205638 File Offset: 0x00203838
		// (set) Token: 0x0600730F RID: 29455 RVA: 0x00036B0D File Offset: 0x00034D0D
		public unsafe UnityEvent OnInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomIntervalEvent.NativeFieldInfoPtr_OnInterval);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomIntervalEvent.NativeFieldInfoPtr_OnInterval), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002379 RID: 9081
		// (get) Token: 0x06007310 RID: 29456 RVA: 0x00205668 File Offset: 0x00203868
		// (set) Token: 0x06007311 RID: 29457 RVA: 0x00036B2C File Offset: 0x00034D2C
		public unsafe float nextInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomIntervalEvent.NativeFieldInfoPtr_nextInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomIntervalEvent.NativeFieldInfoPtr_nextInterval)) = value;
			}
		}

		// Token: 0x04004E87 RID: 20103
		private static readonly IntPtr NativeFieldInfoPtr_MinInterval;

		// Token: 0x04004E88 RID: 20104
		private static readonly IntPtr NativeFieldInfoPtr_MaxInterval;

		// Token: 0x04004E89 RID: 20105
		private static readonly IntPtr NativeFieldInfoPtr_ExecuteOnEnable;

		// Token: 0x04004E8A RID: 20106
		private static readonly IntPtr NativeFieldInfoPtr_OnInterval;

		// Token: 0x04004E8B RID: 20107
		private static readonly IntPtr NativeFieldInfoPtr_nextInterval;

		// Token: 0x04004E8C RID: 20108
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04004E8D RID: 20109
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004E8E RID: 20110
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Void_0;

		// Token: 0x04004E8F RID: 20111
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
