using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Tools;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200074F RID: 1871
	public class EyelidOverlay : Singleton<EyelidOverlay>
	{
		// Token: 0x0600B67B RID: 46715 RVA: 0x002F3F80 File Offset: 0x002F2180
		// Note: this type is marked as 'beforefieldinit'.
		static EyelidOverlay()
		{
			Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "EyelidOverlay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr);
			EyelidOverlay.NativeFieldInfoPtr_MaxTiredOpenAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, "MaxTiredOpenAmount");
			EyelidOverlay.NativeFieldInfoPtr_AutoUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, "AutoUpdate");
			EyelidOverlay.NativeFieldInfoPtr_Open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, "Open");
			EyelidOverlay.NativeFieldInfoPtr_Closed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, "Closed");
			EyelidOverlay.NativeFieldInfoPtr_Upper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, "Upper");
			EyelidOverlay.NativeFieldInfoPtr_Lower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, "Lower");
			EyelidOverlay.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, "Canvas");
			EyelidOverlay.NativeFieldInfoPtr_CurrentOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, "CurrentOpen");
			EyelidOverlay.NativeFieldInfoPtr_OpenMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, "OpenMultiplier");
			EyelidOverlay.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, 100687173);
			EyelidOverlay.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, 100687174);
			EyelidOverlay.NativeMethodInfoPtr_SetOpen_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, 100687175);
			EyelidOverlay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, 100687176);
		}

		// Token: 0x0600B67C RID: 46716 RVA: 0x002F40B4 File Offset: 0x002F22B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306699, XrefRangeEnd = 306705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EyelidOverlay.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B67D RID: 46717 RVA: 0x002F40F0 File Offset: 0x002F22F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306705, XrefRangeEnd = 306714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyelidOverlay.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B67E RID: 46718 RVA: 0x002F4124 File Offset: 0x002F2324
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 306722, RefRangeEnd = 306725, XrefRangeStart = 306714, XrefRangeEnd = 306722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOpen(float openness)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref openness;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyelidOverlay.NativeMethodInfoPtr_SetOpen_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B67F RID: 46719 RVA: 0x002F4164 File Offset: 0x002F2364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306725, XrefRangeEnd = 306728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EyelidOverlay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyelidOverlay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B680 RID: 46720 RVA: 0x00054A11 File Offset: 0x00052C11
		public EyelidOverlay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003712 RID: 14098
		// (get) Token: 0x0600B681 RID: 46721 RVA: 0x002F41A0 File Offset: 0x002F23A0
		// (set) Token: 0x0600B682 RID: 46722 RVA: 0x00054A1A File Offset: 0x00052C1A
		public unsafe static float MaxTiredOpenAmount
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(EyelidOverlay.NativeFieldInfoPtr_MaxTiredOpenAmount, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EyelidOverlay.NativeFieldInfoPtr_MaxTiredOpenAmount, (void*)(&value));
			}
		}

		// Token: 0x17003713 RID: 14099
		// (get) Token: 0x0600B683 RID: 46723 RVA: 0x002F41BC File Offset: 0x002F23BC
		// (set) Token: 0x0600B684 RID: 46724 RVA: 0x00054A28 File Offset: 0x00052C28
		public unsafe bool AutoUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_AutoUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_AutoUpdate)) = value;
			}
		}

		// Token: 0x17003714 RID: 14100
		// (get) Token: 0x0600B685 RID: 46725 RVA: 0x002F41E4 File Offset: 0x002F23E4
		// (set) Token: 0x0600B686 RID: 46726 RVA: 0x00054A43 File Offset: 0x00052C43
		public unsafe float Open
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_Open);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_Open)) = value;
			}
		}

		// Token: 0x17003715 RID: 14101
		// (get) Token: 0x0600B687 RID: 46727 RVA: 0x002F420C File Offset: 0x002F240C
		// (set) Token: 0x0600B688 RID: 46728 RVA: 0x00054A5E File Offset: 0x00052C5E
		public unsafe float Closed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_Closed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_Closed)) = value;
			}
		}

		// Token: 0x17003716 RID: 14102
		// (get) Token: 0x0600B689 RID: 46729 RVA: 0x002F4234 File Offset: 0x002F2434
		// (set) Token: 0x0600B68A RID: 46730 RVA: 0x00054A79 File Offset: 0x00052C79
		public unsafe RectTransform Upper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_Upper);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_Upper), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003717 RID: 14103
		// (get) Token: 0x0600B68B RID: 46731 RVA: 0x002F4264 File Offset: 0x002F2464
		// (set) Token: 0x0600B68C RID: 46732 RVA: 0x00054A98 File Offset: 0x00052C98
		public unsafe RectTransform Lower
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_Lower);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_Lower), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003718 RID: 14104
		// (get) Token: 0x0600B68D RID: 46733 RVA: 0x002F4294 File Offset: 0x002F2494
		// (set) Token: 0x0600B68E RID: 46734 RVA: 0x00054AB7 File Offset: 0x00052CB7
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003719 RID: 14105
		// (get) Token: 0x0600B68F RID: 46735 RVA: 0x002F42C4 File Offset: 0x002F24C4
		// (set) Token: 0x0600B690 RID: 46736 RVA: 0x00054AD6 File Offset: 0x00052CD6
		public unsafe float CurrentOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_CurrentOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_CurrentOpen)) = value;
			}
		}

		// Token: 0x1700371A RID: 14106
		// (get) Token: 0x0600B691 RID: 46737 RVA: 0x002F42EC File Offset: 0x002F24EC
		// (set) Token: 0x0600B692 RID: 46738 RVA: 0x00054AF1 File Offset: 0x00052CF1
		public unsafe FloatSmoother OpenMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_OpenMultiplier);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_OpenMultiplier), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007D6B RID: 32107
		private static readonly IntPtr NativeFieldInfoPtr_MaxTiredOpenAmount;

		// Token: 0x04007D6C RID: 32108
		private static readonly IntPtr NativeFieldInfoPtr_AutoUpdate;

		// Token: 0x04007D6D RID: 32109
		private static readonly IntPtr NativeFieldInfoPtr_Open;

		// Token: 0x04007D6E RID: 32110
		private static readonly IntPtr NativeFieldInfoPtr_Closed;

		// Token: 0x04007D6F RID: 32111
		private static readonly IntPtr NativeFieldInfoPtr_Upper;

		// Token: 0x04007D70 RID: 32112
		private static readonly IntPtr NativeFieldInfoPtr_Lower;

		// Token: 0x04007D71 RID: 32113
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04007D72 RID: 32114
		private static readonly IntPtr NativeFieldInfoPtr_CurrentOpen;

		// Token: 0x04007D73 RID: 32115
		private static readonly IntPtr NativeFieldInfoPtr_OpenMultiplier;

		// Token: 0x04007D74 RID: 32116
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04007D75 RID: 32117
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04007D76 RID: 32118
		private static readonly IntPtr NativeMethodInfoPtr_SetOpen_Public_Void_Single_0;

		// Token: 0x04007D77 RID: 32119
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
