using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x020003C5 RID: 965
	[Serializable]
	public class DialogueDatabase : ScriptableObject
	{
		// Token: 0x0600570A RID: 22282 RVA: 0x001A8BEC File Offset: 0x001A6DEC
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueDatabase()
		{
			Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueDatabase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr);
			DialogueDatabase.NativeFieldInfoPtr_Modules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr, "Modules");
			DialogueDatabase.NativeFieldInfoPtr_GenericEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr, "GenericEntries");
			DialogueDatabase.NativeFieldInfoPtr_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr, "handler");
			DialogueDatabase.NativeMethodInfoPtr_get_runtimeModules_Private_get_List_1_DialogueModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr, 100674726);
			DialogueDatabase.NativeMethodInfoPtr_Initialize_Public_Void_DialogueHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr, 100674727);
			DialogueDatabase.NativeMethodInfoPtr_GetModule_Public_DialogueModule_EDialogueModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr, 100674728);
			DialogueDatabase.NativeMethodInfoPtr_GetChain_Public_DialogueChain_EDialogueModule_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr, 100674729);
			DialogueDatabase.NativeMethodInfoPtr_HasChain_Public_Boolean_EDialogueModule_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr, 100674730);
			DialogueDatabase.NativeMethodInfoPtr_GetLine_Public_String_EDialogueModule_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr, 100674731);
			DialogueDatabase.NativeMethodInfoPtr_HasLine_Public_Boolean_EDialogueModule_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr, 100674732);
			DialogueDatabase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr, 100674733);
		}

		// Token: 0x17001AE0 RID: 6880
		// (get) Token: 0x0600570B RID: 22283 RVA: 0x001A8CF8 File Offset: 0x001A6EF8
		public unsafe List<DialogueModule> runtimeModules
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 59719, RefRangeEnd = 59721, XrefRangeStart = 59719, XrefRangeEnd = 59721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueDatabase.NativeMethodInfoPtr_get_runtimeModules_Private_get_List_1_DialogueModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DialogueModule>>(intPtr3) : null;
			}
		}

		// Token: 0x0600570C RID: 22284 RVA: 0x001A8D38 File Offset: 0x001A6F38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(DialogueHandler _handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_handler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueDatabase.NativeMethodInfoPtr_Initialize_Public_Void_DialogueHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600570D RID: 22285 RVA: 0x001A8D7C File Offset: 0x001A6F7C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 191599, RefRangeEnd = 191604, XrefRangeStart = 191576, XrefRangeEnd = 191599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueModule GetModule(EDialogueModule moduleType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref moduleType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueDatabase.NativeMethodInfoPtr_GetModule_Public_DialogueModule_EDialogueModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogueModule>(intPtr3) : null;
		}

		// Token: 0x0600570E RID: 22286 RVA: 0x001A8DC8 File Offset: 0x001A6FC8
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 191620, RefRangeEnd = 191646, XrefRangeStart = 191604, XrefRangeEnd = 191620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueChain GetChain(EDialogueModule moduleType, string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref moduleType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueDatabase.NativeMethodInfoPtr_GetChain_Public_DialogueChain_EDialogueModule_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogueChain>(intPtr3) : null;
		}

		// Token: 0x0600570F RID: 22287 RVA: 0x001A8E28 File Offset: 0x001A7028
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191662, RefRangeEnd = 191663, XrefRangeStart = 191646, XrefRangeEnd = 191662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasChain(EDialogueModule moduleType, string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref moduleType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueDatabase.NativeMethodInfoPtr_HasChain_Public_Boolean_EDialogueModule_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005710 RID: 22288 RVA: 0x001A8E84 File Offset: 0x001A7084
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 191681, RefRangeEnd = 191718, XrefRangeStart = 191663, XrefRangeEnd = 191681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLine(EDialogueModule moduleType, string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref moduleType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueDatabase.NativeMethodInfoPtr_GetLine_Public_String_EDialogueModule_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005711 RID: 22289 RVA: 0x001A8EDC File Offset: 0x001A70DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191718, XrefRangeEnd = 191734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasLine(EDialogueModule moduleType, string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref moduleType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueDatabase.NativeMethodInfoPtr_HasLine_Public_Boolean_EDialogueModule_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005712 RID: 22290 RVA: 0x001A8F38 File Offset: 0x001A7138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191734, XrefRangeEnd = 191742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueDatabase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueDatabase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005713 RID: 22291 RVA: 0x000291A6 File Offset: 0x000273A6
		public DialogueDatabase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001ADD RID: 6877
		// (get) Token: 0x06005714 RID: 22292 RVA: 0x001A8F74 File Offset: 0x001A7174
		// (set) Token: 0x06005715 RID: 22293 RVA: 0x000291AF File Offset: 0x000273AF
		public unsafe List<DialogueModule> Modules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueDatabase.NativeFieldInfoPtr_Modules);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueModule>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueDatabase.NativeFieldInfoPtr_Modules), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ADE RID: 6878
		// (get) Token: 0x06005716 RID: 22294 RVA: 0x001A8FA4 File Offset: 0x001A71A4
		// (set) Token: 0x06005717 RID: 22295 RVA: 0x000291CE File Offset: 0x000273CE
		public unsafe List<Entry> GenericEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueDatabase.NativeFieldInfoPtr_GenericEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Entry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueDatabase.NativeFieldInfoPtr_GenericEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ADF RID: 6879
		// (get) Token: 0x06005718 RID: 22296 RVA: 0x001A8FD4 File Offset: 0x001A71D4
		// (set) Token: 0x06005719 RID: 22297 RVA: 0x000291ED File Offset: 0x000273ED
		public unsafe DialogueHandler handler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueDatabase.NativeFieldInfoPtr_handler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueDatabase.NativeFieldInfoPtr_handler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003BED RID: 15341
		private static readonly IntPtr NativeFieldInfoPtr_Modules;

		// Token: 0x04003BEE RID: 15342
		private static readonly IntPtr NativeFieldInfoPtr_GenericEntries;

		// Token: 0x04003BEF RID: 15343
		private static readonly IntPtr NativeFieldInfoPtr_handler;

		// Token: 0x04003BF0 RID: 15344
		private static readonly IntPtr NativeMethodInfoPtr_get_runtimeModules_Private_get_List_1_DialogueModule_0;

		// Token: 0x04003BF1 RID: 15345
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_DialogueHandler_0;

		// Token: 0x04003BF2 RID: 15346
		private static readonly IntPtr NativeMethodInfoPtr_GetModule_Public_DialogueModule_EDialogueModule_0;

		// Token: 0x04003BF3 RID: 15347
		private static readonly IntPtr NativeMethodInfoPtr_GetChain_Public_DialogueChain_EDialogueModule_String_0;

		// Token: 0x04003BF4 RID: 15348
		private static readonly IntPtr NativeMethodInfoPtr_HasChain_Public_Boolean_EDialogueModule_String_0;

		// Token: 0x04003BF5 RID: 15349
		private static readonly IntPtr NativeMethodInfoPtr_GetLine_Public_String_EDialogueModule_String_0;

		// Token: 0x04003BF6 RID: 15350
		private static readonly IntPtr NativeMethodInfoPtr_HasLine_Public_Boolean_EDialogueModule_String_0;

		// Token: 0x04003BF7 RID: 15351
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AC7 RID: 2759
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueDatabase+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E40A RID: 58378 RVA: 0x0037CF60 File Offset: 0x0037B160
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<DialogueDatabase.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueDatabase.__c__DisplayClass6_0>.NativeClassPtr);
				DialogueDatabase.__c__DisplayClass6_0.NativeFieldInfoPtr_moduleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueDatabase.__c__DisplayClass6_0>.NativeClassPtr, "moduleType");
				DialogueDatabase.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueDatabase.__c__DisplayClass6_0>.NativeClassPtr, 100674734);
				DialogueDatabase.__c__DisplayClass6_0.NativeMethodInfoPtr__GetModule_b__0_Internal_Boolean_DialogueModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueDatabase.__c__DisplayClass6_0>.NativeClassPtr, 100674735);
			}

			// Token: 0x0600E40B RID: 58379 RVA: 0x0037CFC8 File Offset: 0x0037B1C8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueDatabase.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueDatabase.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E40C RID: 58380 RVA: 0x0037D004 File Offset: 0x0037B204
			[CallerCount(0)]
			public unsafe bool _GetModule_b__0(DialogueModule module)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(module);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueDatabase.__c__DisplayClass6_0.NativeMethodInfoPtr__GetModule_b__0_Internal_Boolean_DialogueModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E40D RID: 58381 RVA: 0x0006B895 File Offset: 0x00069A95
			public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004560 RID: 17760
			// (get) Token: 0x0600E40E RID: 58382 RVA: 0x0037D054 File Offset: 0x0037B254
			// (set) Token: 0x0600E40F RID: 58383 RVA: 0x0006B89E File Offset: 0x00069A9E
			public unsafe EDialogueModule moduleType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueDatabase.__c__DisplayClass6_0.NativeFieldInfoPtr_moduleType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueDatabase.__c__DisplayClass6_0.NativeFieldInfoPtr_moduleType)) = value;
				}
			}

			// Token: 0x04009AEF RID: 39663
			private static readonly IntPtr NativeFieldInfoPtr_moduleType;

			// Token: 0x04009AF0 RID: 39664
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009AF1 RID: 39665
			private static readonly IntPtr NativeMethodInfoPtr__GetModule_b__0_Internal_Boolean_DialogueModule_0;
		}
	}
}
