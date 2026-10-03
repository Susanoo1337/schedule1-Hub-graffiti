using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Interaction
{
	// Token: 0x02000332 RID: 818
	public class InteractableToggleable : MonoBehaviour
	{
		// Token: 0x06004625 RID: 17957 RVA: 0x00169FF8 File Offset: 0x001681F8
		// Note: this type is marked as 'beforefieldinit'.
		static InteractableToggleable()
		{
			Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Interaction", "InteractableToggleable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr);
			InteractableToggleable.NativeFieldInfoPtr__IsActivated_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, "<IsActivated>k__BackingField");
			InteractableToggleable.NativeFieldInfoPtr_ActivateMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, "ActivateMessage");
			InteractableToggleable.NativeFieldInfoPtr_DeactivateMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, "DeactivateMessage");
			InteractableToggleable.NativeFieldInfoPtr_CoolDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, "CoolDown");
			InteractableToggleable.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, "IntObj");
			InteractableToggleable.NativeFieldInfoPtr_onToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, "onToggle");
			InteractableToggleable.NativeFieldInfoPtr_onActivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, "onActivate");
			InteractableToggleable.NativeFieldInfoPtr_onDeactivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, "onDeactivate");
			InteractableToggleable.NativeFieldInfoPtr_lastActivated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, "lastActivated");
			InteractableToggleable.NativeMethodInfoPtr_get_IsActivated_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, 100672329);
			InteractableToggleable.NativeMethodInfoPtr_set_IsActivated_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, 100672330);
			InteractableToggleable.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, 100672331);
			InteractableToggleable.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, 100672332);
			InteractableToggleable.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, 100672333);
			InteractableToggleable.NativeMethodInfoPtr_Toggle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, 100672334);
			InteractableToggleable.NativeMethodInfoPtr_SetState_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, 100672335);
			InteractableToggleable.NativeMethodInfoPtr_PoliceDetected_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, 100672336);
			InteractableToggleable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr, 100672337);
		}

		// Token: 0x17001612 RID: 5650
		// (get) Token: 0x06004626 RID: 17958 RVA: 0x0016A190 File Offset: 0x00168390
		// (set) Token: 0x06004627 RID: 17959 RVA: 0x0016A1CC File Offset: 0x001683CC
		public unsafe bool IsActivated
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableToggleable.NativeMethodInfoPtr_get_IsActivated_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 30482, RefRangeEnd = 30484, XrefRangeStart = 30482, XrefRangeEnd = 30484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableToggleable.NativeMethodInfoPtr_set_IsActivated_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004628 RID: 17960 RVA: 0x0016A20C File Offset: 0x0016840C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165333, XrefRangeEnd = 165347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableToggleable.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004629 RID: 17961 RVA: 0x0016A240 File Offset: 0x00168440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165347, XrefRangeEnd = 165349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableToggleable.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600462A RID: 17962 RVA: 0x0016A274 File Offset: 0x00168474
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 165354, RefRangeEnd = 165355, XrefRangeStart = 165349, XrefRangeEnd = 165354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableToggleable.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600462B RID: 17963 RVA: 0x0016A2A8 File Offset: 0x001684A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 165354, RefRangeEnd = 165355, XrefRangeStart = 165354, XrefRangeEnd = 165355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Toggle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableToggleable.NativeMethodInfoPtr_Toggle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600462C RID: 17964 RVA: 0x0016A2DC File Offset: 0x001684DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 165357, RefRangeEnd = 165358, XrefRangeStart = 165355, XrefRangeEnd = 165357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetState(bool activated)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref activated;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableToggleable.NativeMethodInfoPtr_SetState_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600462D RID: 17965 RVA: 0x0016A31C File Offset: 0x0016851C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165358, XrefRangeEnd = 165362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PoliceDetected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableToggleable.NativeMethodInfoPtr_PoliceDetected_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600462E RID: 17966 RVA: 0x0016A350 File Offset: 0x00168550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165362, XrefRangeEnd = 165384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InteractableToggleable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractableToggleable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableToggleable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600462F RID: 17967 RVA: 0x000222E7 File Offset: 0x000204E7
		public InteractableToggleable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001609 RID: 5641
		// (get) Token: 0x06004630 RID: 17968 RVA: 0x0016A38C File Offset: 0x0016858C
		// (set) Token: 0x06004631 RID: 17969 RVA: 0x000222F0 File Offset: 0x000204F0
		public unsafe bool _IsActivated_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr__IsActivated_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr__IsActivated_k__BackingField)) = value;
			}
		}

		// Token: 0x1700160A RID: 5642
		// (get) Token: 0x06004632 RID: 17970 RVA: 0x0016A3B4 File Offset: 0x001685B4
		// (set) Token: 0x06004633 RID: 17971 RVA: 0x0002230B File Offset: 0x0002050B
		public unsafe string ActivateMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_ActivateMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_ActivateMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700160B RID: 5643
		// (get) Token: 0x06004634 RID: 17972 RVA: 0x0016A3DC File Offset: 0x001685DC
		// (set) Token: 0x06004635 RID: 17973 RVA: 0x0002232A File Offset: 0x0002052A
		public unsafe string DeactivateMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_DeactivateMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_DeactivateMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700160C RID: 5644
		// (get) Token: 0x06004636 RID: 17974 RVA: 0x0016A404 File Offset: 0x00168604
		// (set) Token: 0x06004637 RID: 17975 RVA: 0x00022349 File Offset: 0x00020549
		public unsafe float CoolDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_CoolDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_CoolDown)) = value;
			}
		}

		// Token: 0x1700160D RID: 5645
		// (get) Token: 0x06004638 RID: 17976 RVA: 0x0016A42C File Offset: 0x0016862C
		// (set) Token: 0x06004639 RID: 17977 RVA: 0x00022364 File Offset: 0x00020564
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700160E RID: 5646
		// (get) Token: 0x0600463A RID: 17978 RVA: 0x0016A45C File Offset: 0x0016865C
		// (set) Token: 0x0600463B RID: 17979 RVA: 0x00022383 File Offset: 0x00020583
		public unsafe UnityEvent onToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_onToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_onToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700160F RID: 5647
		// (get) Token: 0x0600463C RID: 17980 RVA: 0x0016A48C File Offset: 0x0016868C
		// (set) Token: 0x0600463D RID: 17981 RVA: 0x000223A2 File Offset: 0x000205A2
		public unsafe UnityEvent onActivate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_onActivate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_onActivate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001610 RID: 5648
		// (get) Token: 0x0600463E RID: 17982 RVA: 0x0016A4BC File Offset: 0x001686BC
		// (set) Token: 0x0600463F RID: 17983 RVA: 0x000223C1 File Offset: 0x000205C1
		public unsafe UnityEvent onDeactivate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_onDeactivate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_onDeactivate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001611 RID: 5649
		// (get) Token: 0x06004640 RID: 17984 RVA: 0x0016A4EC File Offset: 0x001686EC
		// (set) Token: 0x06004641 RID: 17985 RVA: 0x000223E0 File Offset: 0x000205E0
		public unsafe float lastActivated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_lastActivated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableToggleable.NativeFieldInfoPtr_lastActivated)) = value;
			}
		}

		// Token: 0x04002FC4 RID: 12228
		private static readonly IntPtr NativeFieldInfoPtr__IsActivated_k__BackingField;

		// Token: 0x04002FC5 RID: 12229
		private static readonly IntPtr NativeFieldInfoPtr_ActivateMessage;

		// Token: 0x04002FC6 RID: 12230
		private static readonly IntPtr NativeFieldInfoPtr_DeactivateMessage;

		// Token: 0x04002FC7 RID: 12231
		private static readonly IntPtr NativeFieldInfoPtr_CoolDown;

		// Token: 0x04002FC8 RID: 12232
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x04002FC9 RID: 12233
		private static readonly IntPtr NativeFieldInfoPtr_onToggle;

		// Token: 0x04002FCA RID: 12234
		private static readonly IntPtr NativeFieldInfoPtr_onActivate;

		// Token: 0x04002FCB RID: 12235
		private static readonly IntPtr NativeFieldInfoPtr_onDeactivate;

		// Token: 0x04002FCC RID: 12236
		private static readonly IntPtr NativeFieldInfoPtr_lastActivated;

		// Token: 0x04002FCD RID: 12237
		private static readonly IntPtr NativeMethodInfoPtr_get_IsActivated_Public_get_Boolean_0;

		// Token: 0x04002FCE RID: 12238
		private static readonly IntPtr NativeMethodInfoPtr_set_IsActivated_Private_set_Void_Boolean_0;

		// Token: 0x04002FCF RID: 12239
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04002FD0 RID: 12240
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x04002FD1 RID: 12241
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x04002FD2 RID: 12242
		private static readonly IntPtr NativeMethodInfoPtr_Toggle_Public_Void_0;

		// Token: 0x04002FD3 RID: 12243
		private static readonly IntPtr NativeMethodInfoPtr_SetState_Public_Void_Boolean_0;

		// Token: 0x04002FD4 RID: 12244
		private static readonly IntPtr NativeMethodInfoPtr_PoliceDetected_Public_Void_0;

		// Token: 0x04002FD5 RID: 12245
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
