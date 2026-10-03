using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Dialogue;
using Il2CppSystem;

namespace Il2CppScheduleOne.NPCs.Framework
{
	// Token: 0x020005EE RID: 1518
	[Serializable]
	public class Dialogue : Object
	{
		// Token: 0x06009525 RID: 38181 RVA: 0x00284248 File Offset: 0x00282448
		// Note: this type is marked as 'beforefieldinit'.
		static Dialogue()
		{
			Il2CppClassPointerStore<Dialogue>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Framework", "Dialogue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dialogue>.NativeClassPtr);
			Dialogue.NativeFieldInfoPtr_DialogueDatabase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dialogue>.NativeClassPtr, "DialogueDatabase");
			Dialogue.NativeMethodInfoPtr_GetCopy_Public_Dialogue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dialogue>.NativeClassPtr, 100682805);
			Dialogue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dialogue>.NativeClassPtr, 100682806);
		}

		// Token: 0x06009526 RID: 38182 RVA: 0x002842B4 File Offset: 0x002824B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272232, XrefRangeEnd = 272237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dialogue GetCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dialogue.NativeMethodInfoPtr_GetCopy_Public_Dialogue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dialogue>(intPtr3) : null;
		}

		// Token: 0x06009527 RID: 38183 RVA: 0x002842F4 File Offset: 0x002824F4
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dialogue() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dialogue>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dialogue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009528 RID: 38184 RVA: 0x00045C06 File Offset: 0x00043E06
		public Dialogue(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E08 RID: 11784
		// (get) Token: 0x06009529 RID: 38185 RVA: 0x00284330 File Offset: 0x00282530
		// (set) Token: 0x0600952A RID: 38186 RVA: 0x00045C0F File Offset: 0x00043E0F
		public unsafe DialogueDatabase DialogueDatabase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dialogue.NativeFieldInfoPtr_DialogueDatabase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueDatabase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dialogue.NativeFieldInfoPtr_DialogueDatabase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040066BD RID: 26301
		private static readonly IntPtr NativeFieldInfoPtr_DialogueDatabase;

		// Token: 0x040066BE RID: 26302
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Dialogue_0;

		// Token: 0x040066BF RID: 26303
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
