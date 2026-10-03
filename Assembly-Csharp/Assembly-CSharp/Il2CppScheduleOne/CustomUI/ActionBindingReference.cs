using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.InputSystem;

namespace Il2CppScheduleOne.CustomUI
{
	// Token: 0x02000840 RID: 2112
	[Serializable]
	public class ActionBindingReference : Object
	{
		// Token: 0x0600CDF6 RID: 52726 RVA: 0x0033C048 File Offset: 0x0033A248
		// Note: this type is marked as 'beforefieldinit'.
		static ActionBindingReference()
		{
			Il2CppClassPointerStore<ActionBindingReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.CustomUI", "ActionBindingReference");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionBindingReference>.NativeClassPtr);
			ActionBindingReference.NativeFieldInfoPtr_ActionReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBindingReference>.NativeClassPtr, "ActionReference");
			ActionBindingReference.NativeFieldInfoPtr_BindingId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBindingReference>.NativeClassPtr, "BindingId");
			ActionBindingReference.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionBindingReference>.NativeClassPtr, 100689823);
		}

		// Token: 0x0600CDF7 RID: 52727 RVA: 0x0033C0B4 File Offset: 0x0033A2B4
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionBindingReference() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionBindingReference>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionBindingReference.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CDF8 RID: 52728 RVA: 0x00061DC1 File Offset: 0x0005FFC1
		public ActionBindingReference(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003EA0 RID: 16032
		// (get) Token: 0x0600CDF9 RID: 52729 RVA: 0x0033C0F0 File Offset: 0x0033A2F0
		// (set) Token: 0x0600CDFA RID: 52730 RVA: 0x00061DCA File Offset: 0x0005FFCA
		public unsafe InputActionReference ActionReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionBindingReference.NativeFieldInfoPtr_ActionReference);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionBindingReference.NativeFieldInfoPtr_ActionReference), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003EA1 RID: 16033
		// (get) Token: 0x0600CDFB RID: 52731 RVA: 0x0033C120 File Offset: 0x0033A320
		// (set) Token: 0x0600CDFC RID: 52732 RVA: 0x00061DE9 File Offset: 0x0005FFE9
		public unsafe string BindingId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionBindingReference.NativeFieldInfoPtr_BindingId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionBindingReference.NativeFieldInfoPtr_BindingId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04008C40 RID: 35904
		private static readonly IntPtr NativeFieldInfoPtr_ActionReference;

		// Token: 0x04008C41 RID: 35905
		private static readonly IntPtr NativeFieldInfoPtr_BindingId;

		// Token: 0x04008C42 RID: 35906
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
