using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x020003E7 RID: 999
	public class AverageAcceleration : MonoBehaviour
	{
		// Token: 0x060058F4 RID: 22772 RVA: 0x001AEB80 File Offset: 0x001ACD80
		// Note: this type is marked as 'beforefieldinit'.
		static AverageAcceleration()
		{
			Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "AverageAcceleration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr);
			AverageAcceleration.NativeFieldInfoPtr__Acceleration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, "<Acceleration>k__BackingField");
			AverageAcceleration.NativeFieldInfoPtr_Rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, "Rb");
			AverageAcceleration.NativeFieldInfoPtr_TimeWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, "TimeWindow");
			AverageAcceleration.NativeFieldInfoPtr_accelerations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, "accelerations");
			AverageAcceleration.NativeFieldInfoPtr_currentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, "currentIndex");
			AverageAcceleration.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, "timer");
			AverageAcceleration.NativeFieldInfoPtr_prevVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, "prevVelocity");
			AverageAcceleration.NativeMethodInfoPtr_get_Acceleration_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, 100674964);
			AverageAcceleration.NativeMethodInfoPtr_set_Acceleration_Private_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, 100674965);
			AverageAcceleration.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, 100674966);
			AverageAcceleration.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, 100674967);
			AverageAcceleration.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, 100674968);
		}

		// Token: 0x17001B6F RID: 7023
		// (get) Token: 0x060058F5 RID: 22773 RVA: 0x001AECA0 File Offset: 0x001ACEA0
		// (set) Token: 0x060058F6 RID: 22774 RVA: 0x001AECDC File Offset: 0x001ACEDC
		public unsafe Vector3 Acceleration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AverageAcceleration.NativeMethodInfoPtr_get_Acceleration_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AverageAcceleration.NativeMethodInfoPtr_set_Acceleration_Private_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060058F7 RID: 22775 RVA: 0x001AED1C File Offset: 0x001ACF1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193679, XrefRangeEnd = 193700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AverageAcceleration.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058F8 RID: 22776 RVA: 0x001AED50 File Offset: 0x001ACF50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193700, XrefRangeEnd = 193710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AverageAcceleration.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058F9 RID: 22777 RVA: 0x001AED84 File Offset: 0x001ACF84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193710, XrefRangeEnd = 193713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AverageAcceleration() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AverageAcceleration.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058FA RID: 22778 RVA: 0x0002A171 File Offset: 0x00028371
		public AverageAcceleration(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B68 RID: 7016
		// (get) Token: 0x060058FB RID: 22779 RVA: 0x001AEDC0 File Offset: 0x001ACFC0
		// (set) Token: 0x060058FC RID: 22780 RVA: 0x0002A17A File Offset: 0x0002837A
		public unsafe Vector3 _Acceleration_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr__Acceleration_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr__Acceleration_k__BackingField)) = value;
			}
		}

		// Token: 0x17001B69 RID: 7017
		// (get) Token: 0x060058FD RID: 22781 RVA: 0x001AEDE8 File Offset: 0x001ACFE8
		// (set) Token: 0x060058FE RID: 22782 RVA: 0x0002A195 File Offset: 0x00028395
		public unsafe Rigidbody Rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_Rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_Rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B6A RID: 7018
		// (get) Token: 0x060058FF RID: 22783 RVA: 0x001AEE18 File Offset: 0x001AD018
		// (set) Token: 0x06005900 RID: 22784 RVA: 0x0002A1B4 File Offset: 0x000283B4
		public unsafe float TimeWindow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_TimeWindow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_TimeWindow)) = value;
			}
		}

		// Token: 0x17001B6B RID: 7019
		// (get) Token: 0x06005901 RID: 22785 RVA: 0x001AEE40 File Offset: 0x001AD040
		// (set) Token: 0x06005902 RID: 22786 RVA: 0x0002A1CF File Offset: 0x000283CF
		public unsafe Il2CppStructArray<Vector3> accelerations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_accelerations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_accelerations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B6C RID: 7020
		// (get) Token: 0x06005903 RID: 22787 RVA: 0x001AEE70 File Offset: 0x001AD070
		// (set) Token: 0x06005904 RID: 22788 RVA: 0x0002A1EE File Offset: 0x000283EE
		public unsafe int currentIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_currentIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_currentIndex)) = value;
			}
		}

		// Token: 0x17001B6D RID: 7021
		// (get) Token: 0x06005905 RID: 22789 RVA: 0x001AEE98 File Offset: 0x001AD098
		// (set) Token: 0x06005906 RID: 22790 RVA: 0x0002A209 File Offset: 0x00028409
		public unsafe float timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_timer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_timer)) = value;
			}
		}

		// Token: 0x17001B6E RID: 7022
		// (get) Token: 0x06005907 RID: 22791 RVA: 0x001AEEC0 File Offset: 0x001AD0C0
		// (set) Token: 0x06005908 RID: 22792 RVA: 0x0002A224 File Offset: 0x00028424
		public unsafe Vector3 prevVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_prevVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_prevVelocity)) = value;
			}
		}

		// Token: 0x04003D1E RID: 15646
		private static readonly IntPtr NativeFieldInfoPtr__Acceleration_k__BackingField;

		// Token: 0x04003D1F RID: 15647
		private static readonly IntPtr NativeFieldInfoPtr_Rb;

		// Token: 0x04003D20 RID: 15648
		private static readonly IntPtr NativeFieldInfoPtr_TimeWindow;

		// Token: 0x04003D21 RID: 15649
		private static readonly IntPtr NativeFieldInfoPtr_accelerations;

		// Token: 0x04003D22 RID: 15650
		private static readonly IntPtr NativeFieldInfoPtr_currentIndex;

		// Token: 0x04003D23 RID: 15651
		private static readonly IntPtr NativeFieldInfoPtr_timer;

		// Token: 0x04003D24 RID: 15652
		private static readonly IntPtr NativeFieldInfoPtr_prevVelocity;

		// Token: 0x04003D25 RID: 15653
		private static readonly IntPtr NativeMethodInfoPtr_get_Acceleration_Public_get_Vector3_0;

		// Token: 0x04003D26 RID: 15654
		private static readonly IntPtr NativeMethodInfoPtr_set_Acceleration_Private_set_Void_Vector3_0;

		// Token: 0x04003D27 RID: 15655
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04003D28 RID: 15656
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04003D29 RID: 15657
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
