using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x020003C7 RID: 967
	[Serializable]
	public class DialogueEvent : Object
	{
		// Token: 0x06005723 RID: 22307 RVA: 0x001A915C File Offset: 0x001A735C
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueEvent()
		{
			Il2CppClassPointerStore<DialogueEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueEvent>.NativeClassPtr);
			DialogueEvent.NativeFieldInfoPtr_Dialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueEvent>.NativeClassPtr, "Dialogue");
			DialogueEvent.NativeFieldInfoPtr_onDialogueEnded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueEvent>.NativeClassPtr, "onDialogueEnded");
			DialogueEvent.NativeFieldInfoPtr_NodeEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueEvent>.NativeClassPtr, "NodeEvents");
			DialogueEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueEvent>.NativeClassPtr, 100674738);
		}

		// Token: 0x06005724 RID: 22308 RVA: 0x001A91DC File Offset: 0x001A73DC
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueEvent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005725 RID: 22309 RVA: 0x00029265 File Offset: 0x00027465
		public DialogueEvent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001AE3 RID: 6883
		// (get) Token: 0x06005726 RID: 22310 RVA: 0x001A9218 File Offset: 0x001A7418
		// (set) Token: 0x06005727 RID: 22311 RVA: 0x0002926E File Offset: 0x0002746E
		public unsafe DialogueContainer Dialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueEvent.NativeFieldInfoPtr_Dialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueEvent.NativeFieldInfoPtr_Dialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AE4 RID: 6884
		// (get) Token: 0x06005728 RID: 22312 RVA: 0x001A9248 File Offset: 0x001A7448
		// (set) Token: 0x06005729 RID: 22313 RVA: 0x0002928D File Offset: 0x0002748D
		public unsafe UnityEvent onDialogueEnded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueEvent.NativeFieldInfoPtr_onDialogueEnded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueEvent.NativeFieldInfoPtr_onDialogueEnded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AE5 RID: 6885
		// (get) Token: 0x0600572A RID: 22314 RVA: 0x001A9278 File Offset: 0x001A7478
		// (set) Token: 0x0600572B RID: 22315 RVA: 0x000292AC File Offset: 0x000274AC
		public unsafe Il2CppReferenceArray<DialogueNodeEvent> NodeEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueEvent.NativeFieldInfoPtr_NodeEvents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogueNodeEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueEvent.NativeFieldInfoPtr_NodeEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003BFC RID: 15356
		private static readonly IntPtr NativeFieldInfoPtr_Dialogue;

		// Token: 0x04003BFD RID: 15357
		private static readonly IntPtr NativeFieldInfoPtr_onDialogueEnded;

		// Token: 0x04003BFE RID: 15358
		private static readonly IntPtr NativeFieldInfoPtr_NodeEvents;

		// Token: 0x04003BFF RID: 15359
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
