using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Platform
{
	// Token: 0x020001A3 RID: 419
	public class PlatformConditionalActive : MonoBehaviour
	{
		// Token: 0x06002A2E RID: 10798 RVA: 0x00106624 File Offset: 0x00104824
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformConditionalActive()
		{
			Il2CppClassPointerStore<PlatformConditionalActive>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Platform", "PlatformConditionalActive");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformConditionalActive>.NativeClassPtr);
			PlatformConditionalActive.NativeFieldInfoPtr__targetObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformConditionalActive>.NativeClassPtr, "_targetObjects");
			PlatformConditionalActive.NativeFieldInfoPtr__mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformConditionalActive>.NativeClassPtr, "_mode");
			PlatformConditionalActive.NativeFieldInfoPtr__evaluationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformConditionalActive>.NativeClassPtr, "_evaluationMode");
			PlatformConditionalActive.NativeFieldInfoPtr__conditions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformConditionalActive>.NativeClassPtr, "_conditions");
			PlatformConditionalActive.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformConditionalActive>.NativeClassPtr, 100668688);
			PlatformConditionalActive.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformConditionalActive>.NativeClassPtr, 100668689);
			PlatformConditionalActive.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformConditionalActive>.NativeClassPtr, 100668690);
			PlatformConditionalActive.NativeMethodInfoPtr_InputDeviceChanged_Private_Void_InputDeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformConditionalActive>.NativeClassPtr, 100668691);
			PlatformConditionalActive.NativeMethodInfoPtr_EvaluateConditions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformConditionalActive>.NativeClassPtr, 100668692);
			PlatformConditionalActive.NativeMethodInfoPtr_EvaluateCondition_Public_Static_Boolean_EConditions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformConditionalActive>.NativeClassPtr, 100668693);
			PlatformConditionalActive.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformConditionalActive>.NativeClassPtr, 100668694);
		}

		// Token: 0x06002A2F RID: 10799 RVA: 0x00106730 File Offset: 0x00104930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124003, XrefRangeEnd = 124025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformConditionalActive.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A30 RID: 10800 RVA: 0x00106764 File Offset: 0x00104964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124025, XrefRangeEnd = 124047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformConditionalActive.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A31 RID: 10801 RVA: 0x00106798 File Offset: 0x00104998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124047, XrefRangeEnd = 124048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformConditionalActive.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A32 RID: 10802 RVA: 0x001067CC File Offset: 0x001049CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InputDeviceChanged(GameInput.InputDeviceType newInputDevice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newInputDevice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformConditionalActive.NativeMethodInfoPtr_InputDeviceChanged_Private_Void_InputDeviceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A33 RID: 10803 RVA: 0x0010680C File Offset: 0x00104A0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 124085, RefRangeEnd = 124087, XrefRangeStart = 124048, XrefRangeEnd = 124085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EvaluateConditions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformConditionalActive.NativeMethodInfoPtr_EvaluateConditions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A34 RID: 10804 RVA: 0x00106840 File Offset: 0x00104A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124087, XrefRangeEnd = 124089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EvaluateCondition(PlatformConditionalActive.EConditions condition)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref condition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformConditionalActive.NativeMethodInfoPtr_EvaluateCondition_Public_Static_Boolean_EConditions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A35 RID: 10805 RVA: 0x00106880 File Offset: 0x00104A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124089, XrefRangeEnd = 124104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformConditionalActive() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformConditionalActive>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformConditionalActive.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A36 RID: 10806 RVA: 0x000160A7 File Offset: 0x000142A7
		public PlatformConditionalActive(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000DD6 RID: 3542
		// (get) Token: 0x06002A37 RID: 10807 RVA: 0x001068BC File Offset: 0x00104ABC
		// (set) Token: 0x06002A38 RID: 10808 RVA: 0x000160B0 File Offset: 0x000142B0
		public unsafe List<GameObject> _targetObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformConditionalActive.NativeFieldInfoPtr__targetObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformConditionalActive.NativeFieldInfoPtr__targetObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD7 RID: 3543
		// (get) Token: 0x06002A39 RID: 10809 RVA: 0x001068EC File Offset: 0x00104AEC
		// (set) Token: 0x06002A3A RID: 10810 RVA: 0x000160CF File Offset: 0x000142CF
		public unsafe PlatformConditionalActive.EMode _mode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformConditionalActive.NativeFieldInfoPtr__mode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformConditionalActive.NativeFieldInfoPtr__mode)) = value;
			}
		}

		// Token: 0x17000DD8 RID: 3544
		// (get) Token: 0x06002A3B RID: 10811 RVA: 0x00106914 File Offset: 0x00104B14
		// (set) Token: 0x06002A3C RID: 10812 RVA: 0x000160EA File Offset: 0x000142EA
		public unsafe PlatformConditionalActive.EEvaluationMode _evaluationMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformConditionalActive.NativeFieldInfoPtr__evaluationMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformConditionalActive.NativeFieldInfoPtr__evaluationMode)) = value;
			}
		}

		// Token: 0x17000DD9 RID: 3545
		// (get) Token: 0x06002A3D RID: 10813 RVA: 0x0010693C File Offset: 0x00104B3C
		// (set) Token: 0x06002A3E RID: 10814 RVA: 0x00016105 File Offset: 0x00014305
		public unsafe List<PlatformConditionalActive.EConditions> _conditions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformConditionalActive.NativeFieldInfoPtr__conditions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlatformConditionalActive.EConditions>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformConditionalActive.NativeFieldInfoPtr__conditions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D04 RID: 7428
		private static readonly IntPtr NativeFieldInfoPtr__targetObjects;

		// Token: 0x04001D05 RID: 7429
		private static readonly IntPtr NativeFieldInfoPtr__mode;

		// Token: 0x04001D06 RID: 7430
		private static readonly IntPtr NativeFieldInfoPtr__evaluationMode;

		// Token: 0x04001D07 RID: 7431
		private static readonly IntPtr NativeFieldInfoPtr__conditions;

		// Token: 0x04001D08 RID: 7432
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001D09 RID: 7433
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04001D0A RID: 7434
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04001D0B RID: 7435
		private static readonly IntPtr NativeMethodInfoPtr_InputDeviceChanged_Private_Void_InputDeviceType_0;

		// Token: 0x04001D0C RID: 7436
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateConditions_Private_Void_0;

		// Token: 0x04001D0D RID: 7437
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateCondition_Public_Static_Boolean_EConditions_0;

		// Token: 0x04001D0E RID: 7438
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009A2 RID: 2466
		[OriginalName("Assembly-CSharp.dll", "", "EMode")]
		public enum EMode
		{
			// Token: 0x0400957D RID: 38269
			ActiveWhenConditionMet,
			// Token: 0x0400957E RID: 38270
			InactiveWhenConditionMet
		}

		// Token: 0x020009A3 RID: 2467
		[OriginalName("Assembly-CSharp.dll", "", "EEvaluationMode")]
		public enum EEvaluationMode
		{
			// Token: 0x04009580 RID: 38272
			Any,
			// Token: 0x04009581 RID: 38273
			All
		}

		// Token: 0x020009A4 RID: 2468
		[OriginalName("Assembly-CSharp.dll", "", "EConditions")]
		public enum EConditions
		{
			// Token: 0x04009583 RID: 38275
			IsWindows,
			// Token: 0x04009584 RID: 38276
			IsLinux,
			// Token: 0x04009585 RID: 38277
			IsConsole,
			// Token: 0x04009586 RID: 38278
			IsKeyboardMouse,
			// Token: 0x04009587 RID: 38279
			IsGamepad
		}
	}
}
