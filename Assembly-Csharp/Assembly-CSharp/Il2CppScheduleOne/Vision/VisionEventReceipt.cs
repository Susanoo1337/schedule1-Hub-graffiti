using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Vision
{
	// Token: 0x0200019E RID: 414
	[Serializable]
	public class VisionEventReceipt : Object
	{
		// Token: 0x060029FF RID: 10751 RVA: 0x00105D84 File Offset: 0x00103F84
		// Note: this type is marked as 'beforefieldinit'.
		static VisionEventReceipt()
		{
			Il2CppClassPointerStore<VisionEventReceipt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vision", "VisionEventReceipt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisionEventReceipt>.NativeClassPtr);
			VisionEventReceipt.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionEventReceipt>.NativeClassPtr, "Target");
			VisionEventReceipt.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionEventReceipt>.NativeClassPtr, "State");
			VisionEventReceipt.NativeMethodInfoPtr__ctor_Public_Void_NetworkObject_EVisualState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionEventReceipt>.NativeClassPtr, 100668660);
			VisionEventReceipt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionEventReceipt>.NativeClassPtr, 100668661);
		}

		// Token: 0x06002A00 RID: 10752 RVA: 0x00105E04 File Offset: 0x00104004
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 123667, RefRangeEnd = 123677, XrefRangeStart = 123665, XrefRangeEnd = 123667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisionEventReceipt(NetworkObject target, EVisualState state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisionEventReceipt>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionEventReceipt.NativeMethodInfoPtr__ctor_Public_Void_NetworkObject_EVisualState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A01 RID: 10753 RVA: 0x00105E60 File Offset: 0x00104060
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisionEventReceipt() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisionEventReceipt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionEventReceipt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A02 RID: 10754 RVA: 0x00015FC0 File Offset: 0x000141C0
		public VisionEventReceipt(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000DCB RID: 3531
		// (get) Token: 0x06002A03 RID: 10755 RVA: 0x00105E9C File Offset: 0x0010409C
		// (set) Token: 0x06002A04 RID: 10756 RVA: 0x00015FC9 File Offset: 0x000141C9
		public unsafe NetworkObject Target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEventReceipt.NativeFieldInfoPtr_Target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEventReceipt.NativeFieldInfoPtr_Target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DCC RID: 3532
		// (get) Token: 0x06002A05 RID: 10757 RVA: 0x00105ECC File Offset: 0x001040CC
		// (set) Token: 0x06002A06 RID: 10758 RVA: 0x00015FE8 File Offset: 0x000141E8
		public unsafe EVisualState State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEventReceipt.NativeFieldInfoPtr_State);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEventReceipt.NativeFieldInfoPtr_State)) = value;
			}
		}

		// Token: 0x04001CE4 RID: 7396
		private static readonly IntPtr NativeFieldInfoPtr_Target;

		// Token: 0x04001CE5 RID: 7397
		private static readonly IntPtr NativeFieldInfoPtr_State;

		// Token: 0x04001CE6 RID: 7398
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NetworkObject_EVisualState_0;

		// Token: 0x04001CE7 RID: 7399
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
