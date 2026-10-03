using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x020003CF RID: 975
	public class DialogueModule : MonoBehaviour
	{
		// Token: 0x060057C2 RID: 22466 RVA: 0x001AB6B8 File Offset: 0x001A98B8
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueModule()
		{
			Il2CppClassPointerStore<DialogueModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueModule>.NativeClassPtr);
			DialogueModule.NativeFieldInfoPtr_ModuleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueModule>.NativeClassPtr, "ModuleType");
			DialogueModule.NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueModule>.NativeClassPtr, "Entries");
			DialogueModule.NativeMethodInfoPtr_GetEntry_Public_Entry_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueModule>.NativeClassPtr, 100674842);
			DialogueModule.NativeMethodInfoPtr_GetChain_Public_DialogueChain_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueModule>.NativeClassPtr, 100674843);
			DialogueModule.NativeMethodInfoPtr_HasChain_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueModule>.NativeClassPtr, 100674844);
			DialogueModule.NativeMethodInfoPtr_GetLine_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueModule>.NativeClassPtr, 100674845);
			DialogueModule.NativeMethodInfoPtr_HasLine_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueModule>.NativeClassPtr, 100674846);
			DialogueModule.NativeMethodInfoPtr_GetWordCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueModule>.NativeClassPtr, 100674847);
			DialogueModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueModule>.NativeClassPtr, 100674848);
		}

		// Token: 0x060057C3 RID: 22467 RVA: 0x001AB79C File Offset: 0x001A999C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 192639, RefRangeEnd = 192643, XrefRangeStart = 192625, XrefRangeEnd = 192639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Entry GetEntry(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DialogueModule.NativeMethodInfoPtr_GetEntry_Public_Entry_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Entry(pointer);
		}

		// Token: 0x060057C4 RID: 22468 RVA: 0x001AB7E4 File Offset: 0x001A99E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 192652, RefRangeEnd = 192653, XrefRangeStart = 192643, XrefRangeEnd = 192652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueChain GetChain(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueModule.NativeMethodInfoPtr_GetChain_Public_DialogueChain_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogueChain>(intPtr3) : null;
		}

		// Token: 0x060057C5 RID: 22469 RVA: 0x001AB834 File Offset: 0x001A9A34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 192654, RefRangeEnd = 192655, XrefRangeStart = 192653, XrefRangeEnd = 192654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasChain(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueModule.NativeMethodInfoPtr_HasChain_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060057C6 RID: 22470 RVA: 0x001AB884 File Offset: 0x001A9A84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 192660, RefRangeEnd = 192661, XrefRangeStart = 192655, XrefRangeEnd = 192660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLine(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueModule.NativeMethodInfoPtr_GetLine_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060057C7 RID: 22471 RVA: 0x001AB8CC File Offset: 0x001A9ACC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 192662, RefRangeEnd = 192664, XrefRangeStart = 192661, XrefRangeEnd = 192662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasLine(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueModule.NativeMethodInfoPtr_HasLine_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060057C8 RID: 22472 RVA: 0x001AB91C File Offset: 0x001A9B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192664, XrefRangeEnd = 192688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetWordCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueModule.NativeMethodInfoPtr_GetWordCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060057C9 RID: 22473 RVA: 0x001AB958 File Offset: 0x001A9B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192688, XrefRangeEnd = 192696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueModule() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057CA RID: 22474 RVA: 0x000296CA File Offset: 0x000278CA
		public DialogueModule(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B0D RID: 6925
		// (get) Token: 0x060057CB RID: 22475 RVA: 0x001AB994 File Offset: 0x001A9B94
		// (set) Token: 0x060057CC RID: 22476 RVA: 0x000296D3 File Offset: 0x000278D3
		public unsafe EDialogueModule ModuleType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueModule.NativeFieldInfoPtr_ModuleType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueModule.NativeFieldInfoPtr_ModuleType)) = value;
			}
		}

		// Token: 0x17001B0E RID: 6926
		// (get) Token: 0x060057CD RID: 22477 RVA: 0x001AB9BC File Offset: 0x001A9BBC
		// (set) Token: 0x060057CE RID: 22478 RVA: 0x000296EE File Offset: 0x000278EE
		public unsafe List<Entry> Entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueModule.NativeFieldInfoPtr_Entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Entry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueModule.NativeFieldInfoPtr_Entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003C68 RID: 15464
		private static readonly IntPtr NativeFieldInfoPtr_ModuleType;

		// Token: 0x04003C69 RID: 15465
		private static readonly IntPtr NativeFieldInfoPtr_Entries;

		// Token: 0x04003C6A RID: 15466
		private static readonly IntPtr NativeMethodInfoPtr_GetEntry_Public_Entry_String_0;

		// Token: 0x04003C6B RID: 15467
		private static readonly IntPtr NativeMethodInfoPtr_GetChain_Public_DialogueChain_String_0;

		// Token: 0x04003C6C RID: 15468
		private static readonly IntPtr NativeMethodInfoPtr_HasChain_Public_Boolean_String_0;

		// Token: 0x04003C6D RID: 15469
		private static readonly IntPtr NativeMethodInfoPtr_GetLine_Public_String_String_0;

		// Token: 0x04003C6E RID: 15470
		private static readonly IntPtr NativeMethodInfoPtr_HasLine_Public_Boolean_String_0;

		// Token: 0x04003C6F RID: 15471
		private static readonly IntPtr NativeMethodInfoPtr_GetWordCount_Public_Int32_0;

		// Token: 0x04003C70 RID: 15472
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AD2 RID: 2770
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueModule+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E457 RID: 58455 RVA: 0x0037DE28 File Offset: 0x0037C028
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<DialogueModule.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueModule>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueModule.__c__DisplayClass2_0>.NativeClassPtr);
				DialogueModule.__c__DisplayClass2_0.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueModule.__c__DisplayClass2_0>.NativeClassPtr, "key");
				DialogueModule.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueModule.__c__DisplayClass2_0>.NativeClassPtr, 100674849);
				DialogueModule.__c__DisplayClass2_0.NativeMethodInfoPtr__GetEntry_b__0_Internal_Boolean_Entry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueModule.__c__DisplayClass2_0>.NativeClassPtr, 100674850);
			}

			// Token: 0x0600E458 RID: 58456 RVA: 0x0037DE90 File Offset: 0x0037C090
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueModule.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueModule.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E459 RID: 58457 RVA: 0x0037DECC File Offset: 0x0037C0CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192624, XrefRangeEnd = 192625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetEntry_b__0(Entry x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueModule.__c__DisplayClass2_0.NativeMethodInfoPtr__GetEntry_b__0_Internal_Boolean_Entry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E45A RID: 58458 RVA: 0x0006BAA2 File Offset: 0x00069CA2
			public __c__DisplayClass2_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700456E RID: 17774
			// (get) Token: 0x0600E45B RID: 58459 RVA: 0x0037DF20 File Offset: 0x0037C120
			// (set) Token: 0x0600E45C RID: 58460 RVA: 0x0006BAAB File Offset: 0x00069CAB
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueModule.__c__DisplayClass2_0.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueModule.__c__DisplayClass2_0.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009B18 RID: 39704
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x04009B19 RID: 39705
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009B1A RID: 39706
			private static readonly IntPtr NativeMethodInfoPtr__GetEntry_b__0_Internal_Boolean_Entry_0;
		}
	}
}
