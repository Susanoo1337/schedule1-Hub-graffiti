using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x020003C8 RID: 968
	[Serializable]
	public class DialogueNodeEvent : Object
	{
		// Token: 0x0600572C RID: 22316 RVA: 0x001A92A8 File Offset: 0x001A74A8
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueNodeEvent()
		{
			Il2CppClassPointerStore<DialogueNodeEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueNodeEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueNodeEvent>.NativeClassPtr);
			DialogueNodeEvent.NativeFieldInfoPtr_NodeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueNodeEvent>.NativeClassPtr, "NodeLabel");
			DialogueNodeEvent.NativeFieldInfoPtr_onNodeDisplayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueNodeEvent>.NativeClassPtr, "onNodeDisplayed");
			DialogueNodeEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueNodeEvent>.NativeClassPtr, 100674739);
		}

		// Token: 0x0600572D RID: 22317 RVA: 0x001A9314 File Offset: 0x001A7514
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueNodeEvent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueNodeEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueNodeEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600572E RID: 22318 RVA: 0x000292CB File Offset: 0x000274CB
		public DialogueNodeEvent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001AE6 RID: 6886
		// (get) Token: 0x0600572F RID: 22319 RVA: 0x001A9350 File Offset: 0x001A7550
		// (set) Token: 0x06005730 RID: 22320 RVA: 0x000292D4 File Offset: 0x000274D4
		public unsafe string NodeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeEvent.NativeFieldInfoPtr_NodeLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeEvent.NativeFieldInfoPtr_NodeLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001AE7 RID: 6887
		// (get) Token: 0x06005731 RID: 22321 RVA: 0x001A9378 File Offset: 0x001A7578
		// (set) Token: 0x06005732 RID: 22322 RVA: 0x000292F3 File Offset: 0x000274F3
		public unsafe UnityEvent onNodeDisplayed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeEvent.NativeFieldInfoPtr_onNodeDisplayed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeEvent.NativeFieldInfoPtr_onNodeDisplayed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003C00 RID: 15360
		private static readonly IntPtr NativeFieldInfoPtr_NodeLabel;

		// Token: 0x04003C01 RID: 15361
		private static readonly IntPtr NativeFieldInfoPtr_onNodeDisplayed;

		// Token: 0x04003C02 RID: 15362
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
