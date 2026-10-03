using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x020003CE RID: 974
	public class DialogueManager : Singleton<DialogueManager>
	{
		// Token: 0x060057BA RID: 22458 RVA: 0x001AB550 File Offset: 0x001A9750
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueManager()
		{
			Il2CppClassPointerStore<DialogueManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueManager>.NativeClassPtr);
			DialogueManager.NativeFieldInfoPtr_DefaultDatabase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueManager>.NativeClassPtr, "DefaultDatabase");
			DialogueManager.NativeFieldInfoPtr_DefaultModules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueManager>.NativeClassPtr, "DefaultModules");
			DialogueManager.NativeMethodInfoPtr_Get_Public_DialogueModule_EDialogueModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueManager>.NativeClassPtr, 100674838);
			DialogueManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueManager>.NativeClassPtr, 100674839);
		}

		// Token: 0x060057BB RID: 22459 RVA: 0x001AB5D0 File Offset: 0x001A97D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 192613, RefRangeEnd = 192614, XrefRangeStart = 192586, XrefRangeEnd = 192613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueModule Get(EDialogueModule moduleType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref moduleType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueManager.NativeMethodInfoPtr_Get_Public_DialogueModule_EDialogueModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogueModule>(intPtr3) : null;
		}

		// Token: 0x060057BC RID: 22460 RVA: 0x001AB61C File Offset: 0x001A981C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192614, XrefRangeEnd = 192624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057BD RID: 22461 RVA: 0x00029683 File Offset: 0x00027883
		public DialogueManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B0B RID: 6923
		// (get) Token: 0x060057BE RID: 22462 RVA: 0x001AB658 File Offset: 0x001A9858
		// (set) Token: 0x060057BF RID: 22463 RVA: 0x0002968C File Offset: 0x0002788C
		public unsafe DialogueDatabase DefaultDatabase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueManager.NativeFieldInfoPtr_DefaultDatabase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueDatabase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueManager.NativeFieldInfoPtr_DefaultDatabase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B0C RID: 6924
		// (get) Token: 0x060057C0 RID: 22464 RVA: 0x001AB688 File Offset: 0x001A9888
		// (set) Token: 0x060057C1 RID: 22465 RVA: 0x000296AB File Offset: 0x000278AB
		public unsafe List<DialogueModule> DefaultModules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueManager.NativeFieldInfoPtr_DefaultModules);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueModule>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueManager.NativeFieldInfoPtr_DefaultModules), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003C64 RID: 15460
		private static readonly IntPtr NativeFieldInfoPtr_DefaultDatabase;

		// Token: 0x04003C65 RID: 15461
		private static readonly IntPtr NativeFieldInfoPtr_DefaultModules;

		// Token: 0x04003C66 RID: 15462
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_DialogueModule_EDialogueModule_0;

		// Token: 0x04003C67 RID: 15463
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AD1 RID: 2769
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueManager+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x0600E451 RID: 58449 RVA: 0x0037DD0C File Offset: 0x0037BF0C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<DialogueManager.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueManager>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueManager.__c__DisplayClass2_0>.NativeClassPtr);
				DialogueManager.__c__DisplayClass2_0.NativeFieldInfoPtr_moduleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueManager.__c__DisplayClass2_0>.NativeClassPtr, "moduleType");
				DialogueManager.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueManager.__c__DisplayClass2_0>.NativeClassPtr, 100674840);
				DialogueManager.__c__DisplayClass2_0.NativeMethodInfoPtr__Get_b__0_Internal_Boolean_DialogueModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueManager.__c__DisplayClass2_0>.NativeClassPtr, 100674841);
			}

			// Token: 0x0600E452 RID: 58450 RVA: 0x0037DD74 File Offset: 0x0037BF74
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueManager.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueManager.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E453 RID: 58451 RVA: 0x0037DDB0 File Offset: 0x0037BFB0
			[CallerCount(0)]
			public unsafe bool _Get_b__0(DialogueModule x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueManager.__c__DisplayClass2_0.NativeMethodInfoPtr__Get_b__0_Internal_Boolean_DialogueModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E454 RID: 58452 RVA: 0x0006BA7E File Offset: 0x00069C7E
			public __c__DisplayClass2_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700456D RID: 17773
			// (get) Token: 0x0600E455 RID: 58453 RVA: 0x0037DE00 File Offset: 0x0037C000
			// (set) Token: 0x0600E456 RID: 58454 RVA: 0x0006BA87 File Offset: 0x00069C87
			public unsafe EDialogueModule moduleType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueManager.__c__DisplayClass2_0.NativeFieldInfoPtr_moduleType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueManager.__c__DisplayClass2_0.NativeFieldInfoPtr_moduleType)) = value;
				}
			}

			// Token: 0x04009B15 RID: 39701
			private static readonly IntPtr NativeFieldInfoPtr_moduleType;

			// Token: 0x04009B16 RID: 39702
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009B17 RID: 39703
			private static readonly IntPtr NativeMethodInfoPtr__Get_b__0_Internal_Boolean_DialogueModule_0;
		}
	}
}
