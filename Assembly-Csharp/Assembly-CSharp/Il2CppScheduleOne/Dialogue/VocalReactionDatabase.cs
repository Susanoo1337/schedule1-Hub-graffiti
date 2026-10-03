using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x020003D7 RID: 983
	[Serializable]
	public class VocalReactionDatabase : Object
	{
		// Token: 0x06005818 RID: 22552 RVA: 0x001AC620 File Offset: 0x001AA820
		// Note: this type is marked as 'beforefieldinit'.
		static VocalReactionDatabase()
		{
			Il2CppClassPointerStore<VocalReactionDatabase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "VocalReactionDatabase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VocalReactionDatabase>.NativeClassPtr);
			VocalReactionDatabase.NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VocalReactionDatabase>.NativeClassPtr, "Entries");
			VocalReactionDatabase.NativeMethodInfoPtr_GetEntry_Public_Entry_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VocalReactionDatabase>.NativeClassPtr, 100674878);
			VocalReactionDatabase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VocalReactionDatabase>.NativeClassPtr, 100674879);
		}

		// Token: 0x06005819 RID: 22553 RVA: 0x001AC68C File Offset: 0x001AA88C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192878, XrefRangeEnd = 192889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VocalReactionDatabase.Entry GetEntry(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VocalReactionDatabase.NativeMethodInfoPtr_GetEntry_Public_Entry_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VocalReactionDatabase.Entry>(intPtr3) : null;
		}

		// Token: 0x0600581A RID: 22554 RVA: 0x001AC6DC File Offset: 0x001AA8DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192889, XrefRangeEnd = 192897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VocalReactionDatabase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VocalReactionDatabase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VocalReactionDatabase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600581B RID: 22555 RVA: 0x000299D9 File Offset: 0x00027BD9
		public VocalReactionDatabase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B27 RID: 6951
		// (get) Token: 0x0600581C RID: 22556 RVA: 0x001AC718 File Offset: 0x001AA918
		// (set) Token: 0x0600581D RID: 22557 RVA: 0x000299E2 File Offset: 0x00027BE2
		public unsafe List<VocalReactionDatabase.Entry> Entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VocalReactionDatabase.NativeFieldInfoPtr_Entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VocalReactionDatabase.Entry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VocalReactionDatabase.NativeFieldInfoPtr_Entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003CA1 RID: 15521
		private static readonly IntPtr NativeFieldInfoPtr_Entries;

		// Token: 0x04003CA2 RID: 15522
		private static readonly IntPtr NativeMethodInfoPtr_GetEntry_Public_Entry_String_0;

		// Token: 0x04003CA3 RID: 15523
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AD8 RID: 2776
		[Serializable]
		public class Entry : Object
		{
			// Token: 0x0600E47B RID: 58491 RVA: 0x0037E4D4 File Offset: 0x0037C6D4
			// Note: this type is marked as 'beforefieldinit'.
			static Entry()
			{
				Il2CppClassPointerStore<VocalReactionDatabase.Entry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VocalReactionDatabase>.NativeClassPtr, "Entry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VocalReactionDatabase.Entry>.NativeClassPtr);
				VocalReactionDatabase.Entry.NativeFieldInfoPtr_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VocalReactionDatabase.Entry>.NativeClassPtr, "Key");
				VocalReactionDatabase.Entry.NativeFieldInfoPtr_Reactions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VocalReactionDatabase.Entry>.NativeClassPtr, "Reactions");
				VocalReactionDatabase.Entry.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VocalReactionDatabase.Entry>.NativeClassPtr, 100674880);
				VocalReactionDatabase.Entry.NativeMethodInfoPtr_GetRandomReaction_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VocalReactionDatabase.Entry>.NativeClassPtr, 100674881);
				VocalReactionDatabase.Entry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VocalReactionDatabase.Entry>.NativeClassPtr, 100674882);
			}

			// Token: 0x17004576 RID: 17782
			// (get) Token: 0x0600E47C RID: 58492 RVA: 0x0037E564 File Offset: 0x0037C764
			public unsafe string name
			{
				[CallerCount(12)]
				[CachedScanResults(RefRangeStart = 3712, RefRangeEnd = 3724, XrefRangeStart = 3712, XrefRangeEnd = 3724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VocalReactionDatabase.Entry.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600E47D RID: 58493 RVA: 0x0037E59C File Offset: 0x0037C79C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192877, XrefRangeEnd = 192878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string GetRandomReaction()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VocalReactionDatabase.Entry.NativeMethodInfoPtr_GetRandomReaction_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600E47E RID: 58494 RVA: 0x0037E5D4 File Offset: 0x0037C7D4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VocalReactionDatabase.Entry>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VocalReactionDatabase.Entry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E47F RID: 58495 RVA: 0x0006BB92 File Offset: 0x00069D92
			public Entry(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004574 RID: 17780
			// (get) Token: 0x0600E480 RID: 58496 RVA: 0x0037E610 File Offset: 0x0037C810
			// (set) Token: 0x0600E481 RID: 58497 RVA: 0x0006BB9B File Offset: 0x00069D9B
			public unsafe string Key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VocalReactionDatabase.Entry.NativeFieldInfoPtr_Key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VocalReactionDatabase.Entry.NativeFieldInfoPtr_Key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004575 RID: 17781
			// (get) Token: 0x0600E482 RID: 58498 RVA: 0x0037E638 File Offset: 0x0037C838
			// (set) Token: 0x0600E483 RID: 58499 RVA: 0x0006BBBA File Offset: 0x00069DBA
			public unsafe Il2CppStringArray Reactions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VocalReactionDatabase.Entry.NativeFieldInfoPtr_Reactions);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VocalReactionDatabase.Entry.NativeFieldInfoPtr_Reactions), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009B2A RID: 39722
			private static readonly IntPtr NativeFieldInfoPtr_Key;

			// Token: 0x04009B2B RID: 39723
			private static readonly IntPtr NativeFieldInfoPtr_Reactions;

			// Token: 0x04009B2C RID: 39724
			private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

			// Token: 0x04009B2D RID: 39725
			private static readonly IntPtr NativeMethodInfoPtr_GetRandomReaction_Public_String_0;

			// Token: 0x04009B2E RID: 39726
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
