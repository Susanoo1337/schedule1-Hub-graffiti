using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;
using UnityEngine;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x02000514 RID: 1300
	public class GrowContainerInteraction : MonoBehaviour
	{
		// Token: 0x060075E8 RID: 30184 RVA: 0x0020E720 File Offset: 0x0020C920
		// Note: this type is marked as 'beforefieldinit'.
		static GrowContainerInteraction()
		{
			Il2CppClassPointerStore<GrowContainerInteraction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "GrowContainerInteraction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GrowContainerInteraction>.NativeClassPtr);
			GrowContainerInteraction.NativeFieldInfoPtr__interactableObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerInteraction>.NativeClassPtr, "_interactableObject");
			GrowContainerInteraction.NativeFieldInfoPtr__interactableActivatedThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerInteraction>.NativeClassPtr, "_interactableActivatedThisFrame");
			GrowContainerInteraction.NativeFieldInfoPtr_displayLocationPointDefaultLocalPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerInteraction>.NativeClassPtr, "displayLocationPointDefaultLocalPosition");
			GrowContainerInteraction.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerInteraction>.NativeClassPtr, 100678470);
			GrowContainerInteraction.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerInteraction>.NativeClassPtr, 100678471);
			GrowContainerInteraction.NativeMethodInfoPtr_ConfigureInteraction_Public_Void_String_EInteractableState_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerInteraction>.NativeClassPtr, 100678472);
			GrowContainerInteraction.NativeMethodInfoPtr_TryGetFallbackInteractionMessage_Protected_Virtual_New_Boolean_byref_String_byref_EInteractableState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerInteraction>.NativeClassPtr, 100678473);
			GrowContainerInteraction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerInteraction>.NativeClassPtr, 100678474);
		}

		// Token: 0x060075E9 RID: 30185 RVA: 0x0020E7F0 File Offset: 0x0020C9F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 229647, RefRangeEnd = 229648, XrefRangeStart = 229645, XrefRangeEnd = 229647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainerInteraction.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075EA RID: 30186 RVA: 0x0020E82C File Offset: 0x0020CA2C
		[CallerCount(0)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerInteraction.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075EB RID: 30187 RVA: 0x0020E860 File Offset: 0x0020CA60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229648, XrefRangeEnd = 229651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureInteraction(string labelText, InteractableObject.EInteractableState interactionState, bool setLabelPosition = false, Vector3 labelPosition = default(Vector3))
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(labelText);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref interactionState;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setLabelPosition;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref labelPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerInteraction.NativeMethodInfoPtr_ConfigureInteraction_Public_Void_String_EInteractableState_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075EC RID: 30188 RVA: 0x0020E8CC File Offset: 0x0020CACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229651, XrefRangeEnd = 229654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TryGetFallbackInteractionMessage(out string message, out InteractableObject.EInteractableState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &state;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainerInteraction.NativeMethodInfoPtr_TryGetFallbackInteractionMessage_Protected_Virtual_New_Boolean_byref_String_byref_EInteractableState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			message = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060075ED RID: 30189 RVA: 0x0020E93C File Offset: 0x0020CB3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 229657, RefRangeEnd = 229658, XrefRangeStart = 229654, XrefRangeEnd = 229657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GrowContainerInteraction() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GrowContainerInteraction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerInteraction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075EE RID: 30190 RVA: 0x000383CB File Offset: 0x000365CB
		public GrowContainerInteraction(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700246C RID: 9324
		// (get) Token: 0x060075EF RID: 30191 RVA: 0x0020E978 File Offset: 0x0020CB78
		// (set) Token: 0x060075F0 RID: 30192 RVA: 0x000383D4 File Offset: 0x000365D4
		public unsafe InteractableObject _interactableObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerInteraction.NativeFieldInfoPtr__interactableObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerInteraction.NativeFieldInfoPtr__interactableObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700246D RID: 9325
		// (get) Token: 0x060075F1 RID: 30193 RVA: 0x0020E9A8 File Offset: 0x0020CBA8
		// (set) Token: 0x060075F2 RID: 30194 RVA: 0x000383F3 File Offset: 0x000365F3
		public unsafe bool _interactableActivatedThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerInteraction.NativeFieldInfoPtr__interactableActivatedThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerInteraction.NativeFieldInfoPtr__interactableActivatedThisFrame)) = value;
			}
		}

		// Token: 0x1700246E RID: 9326
		// (get) Token: 0x060075F3 RID: 30195 RVA: 0x0020E9D0 File Offset: 0x0020CBD0
		// (set) Token: 0x060075F4 RID: 30196 RVA: 0x0003840E File Offset: 0x0003660E
		public unsafe Vector3 displayLocationPointDefaultLocalPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerInteraction.NativeFieldInfoPtr_displayLocationPointDefaultLocalPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerInteraction.NativeFieldInfoPtr_displayLocationPointDefaultLocalPosition)) = value;
			}
		}

		// Token: 0x0400505D RID: 20573
		private static readonly IntPtr NativeFieldInfoPtr__interactableObject;

		// Token: 0x0400505E RID: 20574
		private static readonly IntPtr NativeFieldInfoPtr__interactableActivatedThisFrame;

		// Token: 0x0400505F RID: 20575
		private static readonly IntPtr NativeFieldInfoPtr_displayLocationPointDefaultLocalPosition;

		// Token: 0x04005060 RID: 20576
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04005061 RID: 20577
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04005062 RID: 20578
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureInteraction_Public_Void_String_EInteractableState_Boolean_Vector3_0;

		// Token: 0x04005063 RID: 20579
		private static readonly IntPtr NativeMethodInfoPtr_TryGetFallbackInteractionMessage_Protected_Virtual_New_Boolean_byref_String_byref_EInteractableState_0;

		// Token: 0x04005064 RID: 20580
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
