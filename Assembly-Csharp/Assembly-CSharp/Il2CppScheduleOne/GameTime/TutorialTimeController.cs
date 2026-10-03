using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.GameTime
{
	// Token: 0x0200010F RID: 271
	public class TutorialTimeController : MonoBehaviour
	{
		// Token: 0x06001A8E RID: 6798 RVA: 0x000D2CDC File Offset: 0x000D0EDC
		// Note: this type is marked as 'beforefieldinit'.
		static TutorialTimeController()
		{
			Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.GameTime", "TutorialTimeController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr);
			TutorialTimeController.NativeFieldInfoPtr_TimeProgressionCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, "TimeProgressionCurve");
			TutorialTimeController.NativeFieldInfoPtr_KeyFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, "KeyFrames");
			TutorialTimeController.NativeFieldInfoPtr_currentKeyFrameIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, "currentKeyFrameIndex");
			TutorialTimeController.NativeFieldInfoPtr_disabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, "disabled");
			TutorialTimeController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, 100666854);
			TutorialTimeController.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, 100666855);
			TutorialTimeController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, 100666856);
			TutorialTimeController.NativeMethodInfoPtr_GetCurrentKeyFrameStart_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, 100666857);
			TutorialTimeController.NativeMethodInfoPtr_IncrementKeyframe_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, 100666858);
			TutorialTimeController.NativeMethodInfoPtr_Disable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, 100666859);
			TutorialTimeController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, 100666860);
		}

		// Token: 0x06001A8F RID: 6799 RVA: 0x000D2DE8 File Offset: 0x000D0FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100736, XrefRangeEnd = 100754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialTimeController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x000D2E1C File Offset: 0x000D101C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100754, XrefRangeEnd = 100772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialTimeController.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x000D2E50 File Offset: 0x000D1050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100772, XrefRangeEnd = 100788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialTimeController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A92 RID: 6802 RVA: 0x000D2E84 File Offset: 0x000D1084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100788, XrefRangeEnd = 100792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCurrentKeyFrameStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialTimeController.NativeMethodInfoPtr_GetCurrentKeyFrameStart_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A93 RID: 6803 RVA: 0x000D2EC0 File Offset: 0x000D10C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100792, XrefRangeEnd = 100800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IncrementKeyframe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialTimeController.NativeMethodInfoPtr_IncrementKeyframe_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A94 RID: 6804 RVA: 0x000D2EF4 File Offset: 0x000D10F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100800, XrefRangeEnd = 100806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialTimeController.NativeMethodInfoPtr_Disable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A95 RID: 6805 RVA: 0x000D2F28 File Offset: 0x000D1128
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TutorialTimeController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialTimeController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x0000E73B File Offset: 0x0000C93B
		public TutorialTimeController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x06001A97 RID: 6807 RVA: 0x000D2F64 File Offset: 0x000D1164
		// (set) Token: 0x06001A98 RID: 6808 RVA: 0x0000E744 File Offset: 0x0000C944
		public unsafe AnimationCurve TimeProgressionCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.NativeFieldInfoPtr_TimeProgressionCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.NativeFieldInfoPtr_TimeProgressionCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x06001A99 RID: 6809 RVA: 0x000D2F94 File Offset: 0x000D1194
		// (set) Token: 0x06001A9A RID: 6810 RVA: 0x0000E763 File Offset: 0x0000C963
		public unsafe Il2CppReferenceArray<TutorialTimeController.KeyFrame> KeyFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.NativeFieldInfoPtr_KeyFrames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TutorialTimeController.KeyFrame>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.NativeFieldInfoPtr_KeyFrames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x06001A9B RID: 6811 RVA: 0x000D2FC4 File Offset: 0x000D11C4
		// (set) Token: 0x06001A9C RID: 6812 RVA: 0x0000E782 File Offset: 0x0000C982
		public unsafe int currentKeyFrameIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.NativeFieldInfoPtr_currentKeyFrameIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.NativeFieldInfoPtr_currentKeyFrameIndex)) = value;
			}
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x06001A9D RID: 6813 RVA: 0x000D2FEC File Offset: 0x000D11EC
		// (set) Token: 0x06001A9E RID: 6814 RVA: 0x0000E79D File Offset: 0x0000C99D
		public unsafe bool disabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.NativeFieldInfoPtr_disabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.NativeFieldInfoPtr_disabled)) = value;
			}
		}

		// Token: 0x04001271 RID: 4721
		private static readonly IntPtr NativeFieldInfoPtr_TimeProgressionCurve;

		// Token: 0x04001272 RID: 4722
		private static readonly IntPtr NativeFieldInfoPtr_KeyFrames;

		// Token: 0x04001273 RID: 4723
		private static readonly IntPtr NativeFieldInfoPtr_currentKeyFrameIndex;

		// Token: 0x04001274 RID: 4724
		private static readonly IntPtr NativeFieldInfoPtr_disabled;

		// Token: 0x04001275 RID: 4725
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001276 RID: 4726
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04001277 RID: 4727
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001278 RID: 4728
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentKeyFrameStart_Private_Int32_0;

		// Token: 0x04001279 RID: 4729
		private static readonly IntPtr NativeMethodInfoPtr_IncrementKeyframe_Public_Void_0;

		// Token: 0x0400127A RID: 4730
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Void_0;

		// Token: 0x0400127B RID: 4731
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000945 RID: 2373
		[Serializable]
		public sealed class KeyFrame : ValueType
		{
			// Token: 0x0600D87B RID: 55419 RVA: 0x0035CA50 File Offset: 0x0035AC50
			// Note: this type is marked as 'beforefieldinit'.
			static KeyFrame()
			{
				Il2CppClassPointerStore<TutorialTimeController.KeyFrame>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, "KeyFrame");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialTimeController.KeyFrame>.NativeClassPtr);
				TutorialTimeController.KeyFrame.NativeFieldInfoPtr_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialTimeController.KeyFrame>.NativeClassPtr, "Time");
				TutorialTimeController.KeyFrame.NativeFieldInfoPtr_SpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialTimeController.KeyFrame>.NativeClassPtr, "SpeedMultiplier");
				TutorialTimeController.KeyFrame.NativeFieldInfoPtr_Note = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialTimeController.KeyFrame>.NativeClassPtr, "Note");
			}

			// Token: 0x0600D87C RID: 55420 RVA: 0x00065CB9 File Offset: 0x00063EB9
			public KeyFrame(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600D87D RID: 55421 RVA: 0x00065CC2 File Offset: 0x00063EC2
			public KeyFrame() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialTimeController.KeyFrame>.NativeClassPtr))
			{
			}

			// Token: 0x17004221 RID: 16929
			// (get) Token: 0x0600D87E RID: 55422 RVA: 0x0035CAB8 File Offset: 0x0035ACB8
			// (set) Token: 0x0600D87F RID: 55423 RVA: 0x00065CD4 File Offset: 0x00063ED4
			public unsafe int Time
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.KeyFrame.NativeFieldInfoPtr_Time);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.KeyFrame.NativeFieldInfoPtr_Time)) = value;
				}
			}

			// Token: 0x17004222 RID: 16930
			// (get) Token: 0x0600D880 RID: 55424 RVA: 0x0035CAE0 File Offset: 0x0035ACE0
			// (set) Token: 0x0600D881 RID: 55425 RVA: 0x00065CEF File Offset: 0x00063EEF
			public unsafe float SpeedMultiplier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.KeyFrame.NativeFieldInfoPtr_SpeedMultiplier);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.KeyFrame.NativeFieldInfoPtr_SpeedMultiplier)) = value;
				}
			}

			// Token: 0x17004223 RID: 16931
			// (get) Token: 0x0600D882 RID: 55426 RVA: 0x0035CB08 File Offset: 0x0035AD08
			// (set) Token: 0x0600D883 RID: 55427 RVA: 0x00065D0A File Offset: 0x00063F0A
			public unsafe string Note
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.KeyFrame.NativeFieldInfoPtr_Note);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.KeyFrame.NativeFieldInfoPtr_Note), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040093A3 RID: 37795
			private static readonly IntPtr NativeFieldInfoPtr_Time;

			// Token: 0x040093A4 RID: 37796
			private static readonly IntPtr NativeFieldInfoPtr_SpeedMultiplier;

			// Token: 0x040093A5 RID: 37797
			private static readonly IntPtr NativeFieldInfoPtr_Note;
		}
	}
}
