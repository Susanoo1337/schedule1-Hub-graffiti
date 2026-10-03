using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne
{
	// Token: 0x020000A1 RID: 161
	public class UIInputDetectBehaviour : MonoBehaviour
	{
		// Token: 0x06000DC2 RID: 3522 RVA: 0x000A9300 File Offset: 0x000A7500
		// Note: this type is marked as 'beforefieldinit'.
		static UIInputDetectBehaviour()
		{
			Il2CppClassPointerStore<UIInputDetectBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "UIInputDetectBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIInputDetectBehaviour>.NativeClassPtr);
			UIInputDetectBehaviour.NativeFieldInfoPtr_initialHoldThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIInputDetectBehaviour>.NativeClassPtr, "initialHoldThreshold");
			UIInputDetectBehaviour.NativeFieldInfoPtr_repeatInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIInputDetectBehaviour>.NativeClassPtr, "repeatInterval");
			UIInputDetectBehaviour.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIInputDetectBehaviour>.NativeClassPtr, "timer");
			UIInputDetectBehaviour.NativeFieldInfoPtr_wasPressedLastFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIInputDetectBehaviour>.NativeClassPtr, "wasPressedLastFrame");
			UIInputDetectBehaviour.NativeFieldInfoPtr_onAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIInputDetectBehaviour>.NativeClassPtr, "onAction");
			UIInputDetectBehaviour.NativeMethodInfoPtr_Initialize_Public_Void_Action_1_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInputDetectBehaviour>.NativeClassPtr, 100665047);
			UIInputDetectBehaviour.NativeMethodInfoPtr_ResetData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInputDetectBehaviour>.NativeClassPtr, 100665048);
			UIInputDetectBehaviour.NativeMethodInfoPtr_DoUpdate_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInputDetectBehaviour>.NativeClassPtr, 100665049);
			UIInputDetectBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInputDetectBehaviour>.NativeClassPtr, 100665050);
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x000A93E4 File Offset: 0x000A75E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 80681, RefRangeEnd = 80684, XrefRangeStart = 80680, XrefRangeEnd = 80681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Action<float> action, float holdThreshold, float repeat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref holdThreshold;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref repeat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIInputDetectBehaviour.NativeMethodInfoPtr_Initialize_Public_Void_Action_1_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x000A9444 File Offset: 0x000A7644
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 80684, RefRangeEnd = 80687, XrefRangeStart = 80684, XrefRangeEnd = 80684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIInputDetectBehaviour.NativeMethodInfoPtr_ResetData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x000A9478 File Offset: 0x000A7678
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 80687, RefRangeEnd = 80690, XrefRangeStart = 80687, XrefRangeEnd = 80687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoUpdate(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIInputDetectBehaviour.NativeMethodInfoPtr_DoUpdate_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x000A94B8 File Offset: 0x000A76B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 80691, RefRangeEnd = 80694, XrefRangeStart = 80690, XrefRangeEnd = 80691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIInputDetectBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIInputDetectBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIInputDetectBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x000084B1 File Offset: 0x000066B1
		public UIInputDetectBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06000DC8 RID: 3528 RVA: 0x000A94F4 File Offset: 0x000A76F4
		// (set) Token: 0x06000DC9 RID: 3529 RVA: 0x000084BA File Offset: 0x000066BA
		public unsafe float initialHoldThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIInputDetectBehaviour.NativeFieldInfoPtr_initialHoldThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIInputDetectBehaviour.NativeFieldInfoPtr_initialHoldThreshold)) = value;
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06000DCA RID: 3530 RVA: 0x000A951C File Offset: 0x000A771C
		// (set) Token: 0x06000DCB RID: 3531 RVA: 0x000084D5 File Offset: 0x000066D5
		public unsafe float repeatInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIInputDetectBehaviour.NativeFieldInfoPtr_repeatInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIInputDetectBehaviour.NativeFieldInfoPtr_repeatInterval)) = value;
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06000DCC RID: 3532 RVA: 0x000A9544 File Offset: 0x000A7744
		// (set) Token: 0x06000DCD RID: 3533 RVA: 0x000084F0 File Offset: 0x000066F0
		public unsafe float timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIInputDetectBehaviour.NativeFieldInfoPtr_timer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIInputDetectBehaviour.NativeFieldInfoPtr_timer)) = value;
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06000DCE RID: 3534 RVA: 0x000A956C File Offset: 0x000A776C
		// (set) Token: 0x06000DCF RID: 3535 RVA: 0x0000850B File Offset: 0x0000670B
		public unsafe bool wasPressedLastFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIInputDetectBehaviour.NativeFieldInfoPtr_wasPressedLastFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIInputDetectBehaviour.NativeFieldInfoPtr_wasPressedLastFrame)) = value;
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06000DD0 RID: 3536 RVA: 0x000A9594 File Offset: 0x000A7794
		// (set) Token: 0x06000DD1 RID: 3537 RVA: 0x00008526 File Offset: 0x00006726
		public unsafe Action<float> onAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIInputDetectBehaviour.NativeFieldInfoPtr_onAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIInputDetectBehaviour.NativeFieldInfoPtr_onAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009A4 RID: 2468
		private static readonly IntPtr NativeFieldInfoPtr_initialHoldThreshold;

		// Token: 0x040009A5 RID: 2469
		private static readonly IntPtr NativeFieldInfoPtr_repeatInterval;

		// Token: 0x040009A6 RID: 2470
		private static readonly IntPtr NativeFieldInfoPtr_timer;

		// Token: 0x040009A7 RID: 2471
		private static readonly IntPtr NativeFieldInfoPtr_wasPressedLastFrame;

		// Token: 0x040009A8 RID: 2472
		private static readonly IntPtr NativeFieldInfoPtr_onAction;

		// Token: 0x040009A9 RID: 2473
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Action_1_Single_Single_Single_0;

		// Token: 0x040009AA RID: 2474
		private static readonly IntPtr NativeMethodInfoPtr_ResetData_Public_Void_0;

		// Token: 0x040009AB RID: 2475
		private static readonly IntPtr NativeMethodInfoPtr_DoUpdate_Public_Void_Single_0;

		// Token: 0x040009AC RID: 2476
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
