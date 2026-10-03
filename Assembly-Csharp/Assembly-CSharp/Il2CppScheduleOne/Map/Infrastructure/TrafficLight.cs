using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Misc;
using UnityEngine;

namespace Il2CppScheduleOne.Map.Infrastructure
{
	// Token: 0x020002CF RID: 719
	public class TrafficLight : MonoBehaviour
	{
		// Token: 0x0600386B RID: 14443 RVA: 0x00136E78 File Offset: 0x00135078
		// Note: this type is marked as 'beforefieldinit'.
		static TrafficLight()
		{
			Il2CppClassPointerStore<TrafficLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map.Infrastructure", "TrafficLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr);
			TrafficLight.NativeFieldInfoPtr__redLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, "_redLight");
			TrafficLight.NativeFieldInfoPtr__orangeLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, "_orangeLight");
			TrafficLight.NativeFieldInfoPtr__greenLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, "_greenLight");
			TrafficLight.NativeFieldInfoPtr__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, "_state");
			TrafficLight.NativeMethodInfoPtr_get_CurrentState_Public_get_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, 100670440);
			TrafficLight.NativeMethodInfoPtr_set_CurrentState_Public_set_Void_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, 100670441);
			TrafficLight.NativeMethodInfoPtr_ApplyState_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, 100670442);
			TrafficLight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, 100670443);
		}

		// Token: 0x170011D4 RID: 4564
		// (get) Token: 0x0600386C RID: 14444 RVA: 0x00136F48 File Offset: 0x00135148
		// (set) Token: 0x0600386D RID: 14445 RVA: 0x00136F84 File Offset: 0x00135184
		public unsafe TrafficLight.State CurrentState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrafficLight.NativeMethodInfoPtr_get_CurrentState_Public_get_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrafficLight.NativeMethodInfoPtr_set_CurrentState_Public_set_Void_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600386E RID: 14446 RVA: 0x00136FC4 File Offset: 0x001351C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144864, XrefRangeEnd = 144868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrafficLight.NativeMethodInfoPtr_ApplyState_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600386F RID: 14447 RVA: 0x00137000 File Offset: 0x00135200
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrafficLight() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrafficLight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003870 RID: 14448 RVA: 0x0001C9A8 File Offset: 0x0001ABA8
		public TrafficLight(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170011D0 RID: 4560
		// (get) Token: 0x06003871 RID: 14449 RVA: 0x0013703C File Offset: 0x0013523C
		// (set) Token: 0x06003872 RID: 14450 RVA: 0x0001C9B1 File Offset: 0x0001ABB1
		public unsafe ToggleableLight _redLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr__redLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ToggleableLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr__redLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011D1 RID: 4561
		// (get) Token: 0x06003873 RID: 14451 RVA: 0x0013706C File Offset: 0x0013526C
		// (set) Token: 0x06003874 RID: 14452 RVA: 0x0001C9D0 File Offset: 0x0001ABD0
		public unsafe ToggleableLight _orangeLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr__orangeLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ToggleableLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr__orangeLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011D2 RID: 4562
		// (get) Token: 0x06003875 RID: 14453 RVA: 0x0013709C File Offset: 0x0013529C
		// (set) Token: 0x06003876 RID: 14454 RVA: 0x0001C9EF File Offset: 0x0001ABEF
		public unsafe ToggleableLight _greenLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr__greenLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ToggleableLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr__greenLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011D3 RID: 4563
		// (get) Token: 0x06003877 RID: 14455 RVA: 0x001370CC File Offset: 0x001352CC
		// (set) Token: 0x06003878 RID: 14456 RVA: 0x0001CA0E File Offset: 0x0001AC0E
		public unsafe TrafficLight.State _state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr__state)) = value;
			}
		}

		// Token: 0x040025CA RID: 9674
		private static readonly IntPtr NativeFieldInfoPtr__redLight;

		// Token: 0x040025CB RID: 9675
		private static readonly IntPtr NativeFieldInfoPtr__orangeLight;

		// Token: 0x040025CC RID: 9676
		private static readonly IntPtr NativeFieldInfoPtr__greenLight;

		// Token: 0x040025CD RID: 9677
		private static readonly IntPtr NativeFieldInfoPtr__state;

		// Token: 0x040025CE RID: 9678
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentState_Public_get_State_0;

		// Token: 0x040025CF RID: 9679
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentState_Public_set_Void_State_0;

		// Token: 0x040025D0 RID: 9680
		private static readonly IntPtr NativeMethodInfoPtr_ApplyState_Protected_Virtual_New_Void_0;

		// Token: 0x040025D1 RID: 9681
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A25 RID: 2597
		[OriginalName("Assembly-CSharp.dll", "", "State")]
		public enum State
		{
			// Token: 0x040097BD RID: 38845
			Red,
			// Token: 0x040097BE RID: 38846
			Orange,
			// Token: 0x040097BF RID: 38847
			Green
		}
	}
}
