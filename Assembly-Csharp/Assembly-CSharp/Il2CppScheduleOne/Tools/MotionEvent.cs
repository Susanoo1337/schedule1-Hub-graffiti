using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004EC RID: 1260
	public class MotionEvent : Il2CppSystem.Object
	{
		// Token: 0x06007252 RID: 29266 RVA: 0x00202FB4 File Offset: 0x002011B4
		// Note: this type is marked as 'beforefieldinit'.
		static MotionEvent()
		{
			Il2CppClassPointerStore<MotionEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "MotionEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MotionEvent>.NativeClassPtr);
			MotionEvent.NativeFieldInfoPtr_Actions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionEvent>.NativeClassPtr, "Actions");
			MotionEvent.NativeFieldInfoPtr_LastUpdatedDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionEvent>.NativeClassPtr, "LastUpdatedDistance");
			MotionEvent.NativeMethodInfoPtr_Update_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionEvent>.NativeClassPtr, 100678085);
			MotionEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionEvent>.NativeClassPtr, 100678086);
		}

		// Token: 0x06007253 RID: 29267 RVA: 0x00203034 File Offset: 0x00201234
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 226254, RefRangeEnd = 226256, XrefRangeStart = 226240, XrefRangeEnd = 226254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update(Vector3 newPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionEvent.NativeMethodInfoPtr_Update_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007254 RID: 29268 RVA: 0x00203074 File Offset: 0x00201274
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 226266, RefRangeEnd = 226268, XrefRangeStart = 226256, XrefRangeEnd = 226266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MotionEvent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MotionEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007255 RID: 29269 RVA: 0x000365DF File Offset: 0x000347DF
		public MotionEvent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700234A RID: 9034
		// (get) Token: 0x06007256 RID: 29270 RVA: 0x002030B0 File Offset: 0x002012B0
		// (set) Token: 0x06007257 RID: 29271 RVA: 0x000365E8 File Offset: 0x000347E8
		public unsafe List<Action> Actions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionEvent.NativeFieldInfoPtr_Actions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Action>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionEvent.NativeFieldInfoPtr_Actions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700234B RID: 9035
		// (get) Token: 0x06007258 RID: 29272 RVA: 0x002030E0 File Offset: 0x002012E0
		// (set) Token: 0x06007259 RID: 29273 RVA: 0x00036607 File Offset: 0x00034807
		public unsafe Vector3 LastUpdatedDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionEvent.NativeFieldInfoPtr_LastUpdatedDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionEvent.NativeFieldInfoPtr_LastUpdatedDistance)) = value;
			}
		}

		// Token: 0x04004E15 RID: 19989
		private static readonly IntPtr NativeFieldInfoPtr_Actions;

		// Token: 0x04004E16 RID: 19990
		private static readonly IntPtr NativeFieldInfoPtr_LastUpdatedDistance;

		// Token: 0x04004E17 RID: 19991
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_Vector3_0;

		// Token: 0x04004E18 RID: 19992
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
