using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.VoiceOver;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x020003D5 RID: 981
	[Serializable]
	public class DialogueNodeData : Il2CppSystem.Object
	{
		// Token: 0x060057FF RID: 22527 RVA: 0x001AC2A8 File Offset: 0x001AA4A8
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueNodeData()
		{
			Il2CppClassPointerStore<DialogueNodeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueNodeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueNodeData>.NativeClassPtr);
			DialogueNodeData.NativeFieldInfoPtr_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueNodeData>.NativeClassPtr, "Guid");
			DialogueNodeData.NativeFieldInfoPtr_DialogueText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueNodeData>.NativeClassPtr, "DialogueText");
			DialogueNodeData.NativeFieldInfoPtr_DialogueNodeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueNodeData>.NativeClassPtr, "DialogueNodeLabel");
			DialogueNodeData.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueNodeData>.NativeClassPtr, "Position");
			DialogueNodeData.NativeFieldInfoPtr_choices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueNodeData>.NativeClassPtr, "choices");
			DialogueNodeData.NativeFieldInfoPtr_VoiceLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueNodeData>.NativeClassPtr, "VoiceLine");
			DialogueNodeData.NativeMethodInfoPtr_GetCopy_Public_DialogueNodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueNodeData>.NativeClassPtr, 100674875);
			DialogueNodeData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueNodeData>.NativeClassPtr, 100674876);
		}

		// Token: 0x06005800 RID: 22528 RVA: 0x001AC378 File Offset: 0x001AA578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192868, XrefRangeEnd = 192877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueNodeData GetCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueNodeData.NativeMethodInfoPtr_GetCopy_Public_DialogueNodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogueNodeData>(intPtr3) : null;
		}

		// Token: 0x06005801 RID: 22529 RVA: 0x001AC3B8 File Offset: 0x001AA5B8
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueNodeData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueNodeData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueNodeData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005802 RID: 22530 RVA: 0x000298B8 File Offset: 0x00027AB8
		public DialogueNodeData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B1E RID: 6942
		// (get) Token: 0x06005803 RID: 22531 RVA: 0x001AC3F4 File Offset: 0x001AA5F4
		// (set) Token: 0x06005804 RID: 22532 RVA: 0x000298C1 File Offset: 0x00027AC1
		public unsafe string Guid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_Guid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_Guid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001B1F RID: 6943
		// (get) Token: 0x06005805 RID: 22533 RVA: 0x001AC41C File Offset: 0x001AA61C
		// (set) Token: 0x06005806 RID: 22534 RVA: 0x000298E0 File Offset: 0x00027AE0
		public unsafe string DialogueText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_DialogueText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_DialogueText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001B20 RID: 6944
		// (get) Token: 0x06005807 RID: 22535 RVA: 0x001AC444 File Offset: 0x001AA644
		// (set) Token: 0x06005808 RID: 22536 RVA: 0x000298FF File Offset: 0x00027AFF
		public unsafe string DialogueNodeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_DialogueNodeLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_DialogueNodeLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001B21 RID: 6945
		// (get) Token: 0x06005809 RID: 22537 RVA: 0x001AC46C File Offset: 0x001AA66C
		// (set) Token: 0x0600580A RID: 22538 RVA: 0x0002991E File Offset: 0x00027B1E
		public unsafe Vector2 Position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_Position)) = value;
			}
		}

		// Token: 0x17001B22 RID: 6946
		// (get) Token: 0x0600580B RID: 22539 RVA: 0x001AC494 File Offset: 0x001AA694
		// (set) Token: 0x0600580C RID: 22540 RVA: 0x00029939 File Offset: 0x00027B39
		public unsafe Il2CppReferenceArray<DialogueChoiceData> choices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_choices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogueChoiceData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_choices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B23 RID: 6947
		// (get) Token: 0x0600580D RID: 22541 RVA: 0x001AC4C4 File Offset: 0x001AA6C4
		// (set) Token: 0x0600580E RID: 22542 RVA: 0x00029958 File Offset: 0x00027B58
		public unsafe EVOLineType VoiceLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_VoiceLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_VoiceLine)) = value;
			}
		}

		// Token: 0x04003C95 RID: 15509
		private static readonly IntPtr NativeFieldInfoPtr_Guid;

		// Token: 0x04003C96 RID: 15510
		private static readonly IntPtr NativeFieldInfoPtr_DialogueText;

		// Token: 0x04003C97 RID: 15511
		private static readonly IntPtr NativeFieldInfoPtr_DialogueNodeLabel;

		// Token: 0x04003C98 RID: 15512
		private static readonly IntPtr NativeFieldInfoPtr_Position;

		// Token: 0x04003C99 RID: 15513
		private static readonly IntPtr NativeFieldInfoPtr_choices;

		// Token: 0x04003C9A RID: 15514
		private static readonly IntPtr NativeFieldInfoPtr_VoiceLine;

		// Token: 0x04003C9B RID: 15515
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_DialogueNodeData_0;

		// Token: 0x04003C9C RID: 15516
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
