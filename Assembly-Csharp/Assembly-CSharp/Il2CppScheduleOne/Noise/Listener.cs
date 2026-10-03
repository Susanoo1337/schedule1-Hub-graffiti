using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Noise
{
	// Token: 0x0200028D RID: 653
	public class Listener : MonoBehaviour
	{
		// Token: 0x0600320B RID: 12811 RVA: 0x00120694 File Offset: 0x0011E894
		// Note: this type is marked as 'beforefieldinit'.
		static Listener()
		{
			Il2CppClassPointerStore<Listener>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Noise", "Listener");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Listener>.NativeClassPtr);
			Listener.NativeFieldInfoPtr_listeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Listener>.NativeClassPtr, "listeners");
			Listener.NativeFieldInfoPtr_Sensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Listener>.NativeClassPtr, "Sensitivity");
			Listener.NativeFieldInfoPtr_HearingOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Listener>.NativeClassPtr, "HearingOrigin");
			Listener.NativeFieldInfoPtr__SquaredHearingRange_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Listener>.NativeClassPtr, "<SquaredHearingRange>k__BackingField");
			Listener.NativeFieldInfoPtr_onNoiseHeard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Listener>.NativeClassPtr, "onNoiseHeard");
			Listener.NativeMethodInfoPtr_get_SquaredHearingRange_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listener>.NativeClassPtr, 100669525);
			Listener.NativeMethodInfoPtr_set_SquaredHearingRange_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listener>.NativeClassPtr, 100669526);
			Listener.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listener>.NativeClassPtr, 100669527);
			Listener.NativeMethodInfoPtr_OnEnable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listener>.NativeClassPtr, 100669528);
			Listener.NativeMethodInfoPtr_OnDisable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listener>.NativeClassPtr, 100669529);
			Listener.NativeMethodInfoPtr_Notify_Public_Void_NoiseEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listener>.NativeClassPtr, 100669530);
			Listener.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listener>.NativeClassPtr, 100669531);
		}

		// Token: 0x17000FF9 RID: 4089
		// (get) Token: 0x0600320C RID: 12812 RVA: 0x001207B4 File Offset: 0x0011E9B4
		// (set) Token: 0x0600320D RID: 12813 RVA: 0x001207F0 File Offset: 0x0011E9F0
		public unsafe float SquaredHearingRange
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29130, RefRangeEnd = 29131, XrefRangeStart = 29130, XrefRangeEnd = 29131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listener.NativeMethodInfoPtr_get_SquaredHearingRange_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29131, RefRangeEnd = 29133, XrefRangeStart = 29131, XrefRangeEnd = 29133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listener.NativeMethodInfoPtr_set_SquaredHearingRange_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600320E RID: 12814 RVA: 0x00120830 File Offset: 0x0011EA30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136005, XrefRangeEnd = 136012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listener.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600320F RID: 12815 RVA: 0x00120864 File Offset: 0x0011EA64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136012, XrefRangeEnd = 136025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listener.NativeMethodInfoPtr_OnEnable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003210 RID: 12816 RVA: 0x00120898 File Offset: 0x0011EA98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136025, XrefRangeEnd = 136033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listener.NativeMethodInfoPtr_OnDisable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003211 RID: 12817 RVA: 0x001208CC File Offset: 0x0011EACC
		[CallerCount(0)]
		public unsafe void Notify(NoiseEvent nEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(nEvent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listener.NativeMethodInfoPtr_Notify_Public_Void_NoiseEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003212 RID: 12818 RVA: 0x00120910 File Offset: 0x0011EB10
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 68082, RefRangeEnd = 68086, XrefRangeStart = 68082, XrefRangeEnd = 68086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Listener() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Listener>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listener.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003213 RID: 12819 RVA: 0x00019CC7 File Offset: 0x00017EC7
		public Listener(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FF4 RID: 4084
		// (get) Token: 0x06003214 RID: 12820 RVA: 0x0012094C File Offset: 0x0011EB4C
		// (set) Token: 0x06003215 RID: 12821 RVA: 0x00019CD0 File Offset: 0x00017ED0
		public unsafe static List<Listener> listeners
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Listener.NativeFieldInfoPtr_listeners, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Listener>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Listener.NativeFieldInfoPtr_listeners, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FF5 RID: 4085
		// (get) Token: 0x06003216 RID: 12822 RVA: 0x00120974 File Offset: 0x0011EB74
		// (set) Token: 0x06003217 RID: 12823 RVA: 0x00019CE2 File Offset: 0x00017EE2
		public unsafe float Sensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Listener.NativeFieldInfoPtr_Sensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Listener.NativeFieldInfoPtr_Sensitivity)) = value;
			}
		}

		// Token: 0x17000FF6 RID: 4086
		// (get) Token: 0x06003218 RID: 12824 RVA: 0x0012099C File Offset: 0x0011EB9C
		// (set) Token: 0x06003219 RID: 12825 RVA: 0x00019CFD File Offset: 0x00017EFD
		public unsafe Transform HearingOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Listener.NativeFieldInfoPtr_HearingOrigin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Listener.NativeFieldInfoPtr_HearingOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FF7 RID: 4087
		// (get) Token: 0x0600321A RID: 12826 RVA: 0x001209CC File Offset: 0x0011EBCC
		// (set) Token: 0x0600321B RID: 12827 RVA: 0x00019D1C File Offset: 0x00017F1C
		public unsafe float _SquaredHearingRange_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Listener.NativeFieldInfoPtr__SquaredHearingRange_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Listener.NativeFieldInfoPtr__SquaredHearingRange_k__BackingField)) = value;
			}
		}

		// Token: 0x17000FF8 RID: 4088
		// (get) Token: 0x0600321C RID: 12828 RVA: 0x001209F4 File Offset: 0x0011EBF4
		// (set) Token: 0x0600321D RID: 12829 RVA: 0x00019D37 File Offset: 0x00017F37
		public unsafe Listener.HearingEvent onNoiseHeard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Listener.NativeFieldInfoPtr_onNoiseHeard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Listener.HearingEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Listener.NativeFieldInfoPtr_onNoiseHeard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400214D RID: 8525
		private static readonly IntPtr NativeFieldInfoPtr_listeners;

		// Token: 0x0400214E RID: 8526
		private static readonly IntPtr NativeFieldInfoPtr_Sensitivity;

		// Token: 0x0400214F RID: 8527
		private static readonly IntPtr NativeFieldInfoPtr_HearingOrigin;

		// Token: 0x04002150 RID: 8528
		private static readonly IntPtr NativeFieldInfoPtr__SquaredHearingRange_k__BackingField;

		// Token: 0x04002151 RID: 8529
		private static readonly IntPtr NativeFieldInfoPtr_onNoiseHeard;

		// Token: 0x04002152 RID: 8530
		private static readonly IntPtr NativeMethodInfoPtr_get_SquaredHearingRange_Public_get_Single_0;

		// Token: 0x04002153 RID: 8531
		private static readonly IntPtr NativeMethodInfoPtr_set_SquaredHearingRange_Protected_set_Void_Single_0;

		// Token: 0x04002154 RID: 8532
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04002155 RID: 8533
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Void_0;

		// Token: 0x04002156 RID: 8534
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Void_0;

		// Token: 0x04002157 RID: 8535
		private static readonly IntPtr NativeMethodInfoPtr_Notify_Public_Void_NoiseEvent_0;

		// Token: 0x04002158 RID: 8536
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009F5 RID: 2549
		public sealed class HearingEvent : MulticastDelegate
		{
			// Token: 0x0600DD16 RID: 56598 RVA: 0x00369A54 File Offset: 0x00367C54
			// Note: this type is marked as 'beforefieldinit'.
			static HearingEvent()
			{
				Il2CppClassPointerStore<Listener.HearingEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Listener>.NativeClassPtr, "HearingEvent");
				Listener.HearingEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listener.HearingEvent>.NativeClassPtr, 100669533);
				Listener.HearingEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_NoiseEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listener.HearingEvent>.NativeClassPtr, 100669534);
				Listener.HearingEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_NoiseEvent_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listener.HearingEvent>.NativeClassPtr, 100669535);
				Listener.HearingEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listener.HearingEvent>.NativeClassPtr, 100669536);
			}

			// Token: 0x0600DD17 RID: 56599 RVA: 0x00369AC8 File Offset: 0x00367CC8
			[CallerCount(329)]
			[CachedScanResults(RefRangeStart = 101484, RefRangeEnd = 101813, XrefRangeStart = 101484, XrefRangeEnd = 101813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HearingEvent(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Listener.HearingEvent>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listener.HearingEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD18 RID: 56600 RVA: 0x00369B24 File Offset: 0x00367D24
			[CallerCount(0)]
			public unsafe void Invoke(NoiseEvent nEvent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listener.HearingEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_NoiseEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD19 RID: 56601 RVA: 0x00369B68 File Offset: 0x00367D68
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 71797, RefRangeEnd = 71798, XrefRangeStart = 71797, XrefRangeEnd = 71798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(NoiseEvent nEvent, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nEvent);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listener.HearingEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_NoiseEvent_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600DD1A RID: 56602 RVA: 0x00369BDC File Offset: 0x00367DDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listener.HearingEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD1B RID: 56603 RVA: 0x000680D1 File Offset: 0x000662D1
			public HearingEvent(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600DD1C RID: 56604 RVA: 0x000680DA File Offset: 0x000662DA
			public static implicit operator Listener.HearingEvent(Action<NoiseEvent> A_0)
			{
				return DelegateSupport.ConvertDelegate<Listener.HearingEvent>(A_0);
			}

			// Token: 0x0600DD1D RID: 56605 RVA: 0x000680E2 File Offset: 0x000662E2
			public static Listener.HearingEvent operator +(Listener.HearingEvent A_0, Listener.HearingEvent A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Listener.HearingEvent>();
			}

			// Token: 0x0600DD1E RID: 56606 RVA: 0x000680F0 File Offset: 0x000662F0
			public static Listener.HearingEvent operator -(Listener.HearingEvent A_0, Listener.HearingEvent A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<Listener.HearingEvent>();
				}
				return result;
			}

			// Token: 0x040096B7 RID: 38583
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040096B8 RID: 38584
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_NoiseEvent_0;

			// Token: 0x040096B9 RID: 38585
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_NoiseEvent_AsyncCallback_Object_0;

			// Token: 0x040096BA RID: 38586
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
