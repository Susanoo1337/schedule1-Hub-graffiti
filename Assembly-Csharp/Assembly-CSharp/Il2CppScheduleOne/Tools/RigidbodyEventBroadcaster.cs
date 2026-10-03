using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004FA RID: 1274
	public class RigidbodyEventBroadcaster : MonoBehaviour
	{
		// Token: 0x0600731C RID: 29468 RVA: 0x00205864 File Offset: 0x00203A64
		// Note: this type is marked as 'beforefieldinit'.
		static RigidbodyEventBroadcaster()
		{
			Il2CppClassPointerStore<RigidbodyEventBroadcaster>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "RigidbodyEventBroadcaster");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RigidbodyEventBroadcaster>.NativeClassPtr);
			RigidbodyEventBroadcaster.NativeFieldInfoPtr_onTriggerEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyEventBroadcaster>.NativeClassPtr, "onTriggerEnter");
			RigidbodyEventBroadcaster.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidbodyEventBroadcaster>.NativeClassPtr, 100678181);
			RigidbodyEventBroadcaster.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidbodyEventBroadcaster>.NativeClassPtr, 100678182);
		}

		// Token: 0x0600731D RID: 29469 RVA: 0x002058D0 File Offset: 0x00203AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227155, XrefRangeEnd = 227158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RigidbodyEventBroadcaster.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600731E RID: 29470 RVA: 0x00205914 File Offset: 0x00203B14
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RigidbodyEventBroadcaster() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RigidbodyEventBroadcaster>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RigidbodyEventBroadcaster.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600731F RID: 29471 RVA: 0x00036B78 File Offset: 0x00034D78
		public RigidbodyEventBroadcaster(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700237B RID: 9083
		// (get) Token: 0x06007320 RID: 29472 RVA: 0x00205950 File Offset: 0x00203B50
		// (set) Token: 0x06007321 RID: 29473 RVA: 0x00036B81 File Offset: 0x00034D81
		public unsafe UnityEvent<Collider> onTriggerEnter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RigidbodyEventBroadcaster.NativeFieldInfoPtr_onTriggerEnter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RigidbodyEventBroadcaster.NativeFieldInfoPtr_onTriggerEnter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004E95 RID: 20117
		private static readonly IntPtr NativeFieldInfoPtr_onTriggerEnter;

		// Token: 0x04004E96 RID: 20118
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0;

		// Token: 0x04004E97 RID: 20119
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
