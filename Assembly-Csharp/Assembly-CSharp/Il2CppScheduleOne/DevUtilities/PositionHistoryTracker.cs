using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000400 RID: 1024
	public class PositionHistoryTracker : MonoBehaviour
	{
		// Token: 0x06005AB7 RID: 23223 RVA: 0x001B44DC File Offset: 0x001B26DC
		// Note: this type is marked as 'beforefieldinit'.
		static PositionHistoryTracker()
		{
			Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "PositionHistoryTracker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr);
			PositionHistoryTracker.NativeFieldInfoPtr_recordingFrequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr, "recordingFrequency");
			PositionHistoryTracker.NativeFieldInfoPtr_historyDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr, "historyDuration");
			PositionHistoryTracker.NativeFieldInfoPtr_positionHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr, "positionHistory");
			PositionHistoryTracker.NativeFieldInfoPtr_lastRecordTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr, "lastRecordTime");
			PositionHistoryTracker.NativeMethodInfoPtr_get_RecordedTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr, 100675153);
			PositionHistoryTracker.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr, 100675154);
			PositionHistoryTracker.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr, 100675155);
			PositionHistoryTracker.NativeMethodInfoPtr_RecordPosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr, 100675156);
			PositionHistoryTracker.NativeMethodInfoPtr_GetPositionXSecondsAgo_Public_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr, 100675157);
			PositionHistoryTracker.NativeMethodInfoPtr_ClearHistory_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr, 100675158);
			PositionHistoryTracker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr, 100675159);
		}

		// Token: 0x17001C00 RID: 7168
		// (get) Token: 0x06005AB8 RID: 23224 RVA: 0x001B45E8 File Offset: 0x001B27E8
		public unsafe float RecordedTime
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 196073, RefRangeEnd = 196075, XrefRangeStart = 196072, XrefRangeEnd = 196073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PositionHistoryTracker.NativeMethodInfoPtr_get_RecordedTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005AB9 RID: 23225 RVA: 0x001B4624 File Offset: 0x001B2824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196075, XrefRangeEnd = 196076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PositionHistoryTracker.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ABA RID: 23226 RVA: 0x001B4658 File Offset: 0x001B2858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196076, XrefRangeEnd = 196088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PositionHistoryTracker.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ABB RID: 23227 RVA: 0x001B468C File Offset: 0x001B288C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196088, XrefRangeEnd = 196098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PositionHistoryTracker.NativeMethodInfoPtr_RecordPosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ABC RID: 23228 RVA: 0x001B46C0 File Offset: 0x001B28C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 196103, RefRangeEnd = 196105, XrefRangeStart = 196098, XrefRangeEnd = 196103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPositionXSecondsAgo(float secondsAgo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref secondsAgo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PositionHistoryTracker.NativeMethodInfoPtr_GetPositionXSecondsAgo_Public_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005ABD RID: 23229 RVA: 0x001B470C File Offset: 0x001B290C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 196106, RefRangeEnd = 196107, XrefRangeStart = 196105, XrefRangeEnd = 196106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearHistory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PositionHistoryTracker.NativeMethodInfoPtr_ClearHistory_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ABE RID: 23230 RVA: 0x001B4740 File Offset: 0x001B2940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196107, XrefRangeEnd = 196115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PositionHistoryTracker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PositionHistoryTracker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ABF RID: 23231 RVA: 0x0002AF73 File Offset: 0x00029173
		public PositionHistoryTracker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001BFC RID: 7164
		// (get) Token: 0x06005AC0 RID: 23232 RVA: 0x001B477C File Offset: 0x001B297C
		// (set) Token: 0x06005AC1 RID: 23233 RVA: 0x0002AF7C File Offset: 0x0002917C
		public unsafe float recordingFrequency
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PositionHistoryTracker.NativeFieldInfoPtr_recordingFrequency);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PositionHistoryTracker.NativeFieldInfoPtr_recordingFrequency)) = value;
			}
		}

		// Token: 0x17001BFD RID: 7165
		// (get) Token: 0x06005AC2 RID: 23234 RVA: 0x001B47A4 File Offset: 0x001B29A4
		// (set) Token: 0x06005AC3 RID: 23235 RVA: 0x0002AF97 File Offset: 0x00029197
		public unsafe float historyDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PositionHistoryTracker.NativeFieldInfoPtr_historyDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PositionHistoryTracker.NativeFieldInfoPtr_historyDuration)) = value;
			}
		}

		// Token: 0x17001BFE RID: 7166
		// (get) Token: 0x06005AC4 RID: 23236 RVA: 0x001B47CC File Offset: 0x001B29CC
		// (set) Token: 0x06005AC5 RID: 23237 RVA: 0x0002AFB2 File Offset: 0x000291B2
		public unsafe List<Vector3> positionHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PositionHistoryTracker.NativeFieldInfoPtr_positionHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PositionHistoryTracker.NativeFieldInfoPtr_positionHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BFF RID: 7167
		// (get) Token: 0x06005AC6 RID: 23238 RVA: 0x001B47FC File Offset: 0x001B29FC
		// (set) Token: 0x06005AC7 RID: 23239 RVA: 0x0002AFD1 File Offset: 0x000291D1
		public unsafe float lastRecordTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PositionHistoryTracker.NativeFieldInfoPtr_lastRecordTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PositionHistoryTracker.NativeFieldInfoPtr_lastRecordTime)) = value;
			}
		}

		// Token: 0x04003E3A RID: 15930
		private static readonly IntPtr NativeFieldInfoPtr_recordingFrequency;

		// Token: 0x04003E3B RID: 15931
		private static readonly IntPtr NativeFieldInfoPtr_historyDuration;

		// Token: 0x04003E3C RID: 15932
		private static readonly IntPtr NativeFieldInfoPtr_positionHistory;

		// Token: 0x04003E3D RID: 15933
		private static readonly IntPtr NativeFieldInfoPtr_lastRecordTime;

		// Token: 0x04003E3E RID: 15934
		private static readonly IntPtr NativeMethodInfoPtr_get_RecordedTime_Public_get_Single_0;

		// Token: 0x04003E3F RID: 15935
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04003E40 RID: 15936
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04003E41 RID: 15937
		private static readonly IntPtr NativeMethodInfoPtr_RecordPosition_Private_Void_0;

		// Token: 0x04003E42 RID: 15938
		private static readonly IntPtr NativeMethodInfoPtr_GetPositionXSecondsAgo_Public_Vector3_Single_0;

		// Token: 0x04003E43 RID: 15939
		private static readonly IntPtr NativeMethodInfoPtr_ClearHistory_Public_Void_0;

		// Token: 0x04003E44 RID: 15940
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
