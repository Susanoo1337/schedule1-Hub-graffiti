using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Cutscenes
{
	// Token: 0x0200041F RID: 1055
	public class CutsceneManager : Singleton<CutsceneManager>
	{
		// Token: 0x06005D47 RID: 23879 RVA: 0x001BCD40 File Offset: 0x001BAF40
		// Note: this type is marked as 'beforefieldinit'.
		static CutsceneManager()
		{
			Il2CppClassPointerStore<CutsceneManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Cutscenes", "CutsceneManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CutsceneManager>.NativeClassPtr);
			CutsceneManager.NativeFieldInfoPtr_Cutscenes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutsceneManager>.NativeClassPtr, "Cutscenes");
			CutsceneManager.NativeFieldInfoPtr_cutsceneName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutsceneManager>.NativeClassPtr, "cutsceneName");
			CutsceneManager.NativeFieldInfoPtr_playingCutscene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutsceneManager>.NativeClassPtr, "playingCutscene");
			CutsceneManager.NativeMethodInfoPtr_RunCutscene_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutsceneManager>.NativeClassPtr, 100675474);
			CutsceneManager.NativeMethodInfoPtr_Play_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutsceneManager>.NativeClassPtr, 100675475);
			CutsceneManager.NativeMethodInfoPtr_Ended_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutsceneManager>.NativeClassPtr, 100675476);
			CutsceneManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutsceneManager>.NativeClassPtr, 100675477);
		}

		// Token: 0x06005D48 RID: 23880 RVA: 0x001BCDFC File Offset: 0x001BAFFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199499, XrefRangeEnd = 199525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunCutscene()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutsceneManager.NativeMethodInfoPtr_RunCutscene_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D49 RID: 23881 RVA: 0x001BCE30 File Offset: 0x001BB030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199525, XrefRangeEnd = 199551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutsceneManager.NativeMethodInfoPtr_Play_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D4A RID: 23882 RVA: 0x001BCE74 File Offset: 0x001BB074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199551, XrefRangeEnd = 199560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Ended()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutsceneManager.NativeMethodInfoPtr_Ended_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D4B RID: 23883 RVA: 0x001BCEA8 File Offset: 0x001BB0A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199560, XrefRangeEnd = 199567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CutsceneManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CutsceneManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutsceneManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D4C RID: 23884 RVA: 0x0002C355 File Offset: 0x0002A555
		public CutsceneManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CD2 RID: 7378
		// (get) Token: 0x06005D4D RID: 23885 RVA: 0x001BCEE4 File Offset: 0x001BB0E4
		// (set) Token: 0x06005D4E RID: 23886 RVA: 0x0002C35E File Offset: 0x0002A55E
		public unsafe List<Cutscene> Cutscenes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutsceneManager.NativeFieldInfoPtr_Cutscenes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Cutscene>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutsceneManager.NativeFieldInfoPtr_Cutscenes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CD3 RID: 7379
		// (get) Token: 0x06005D4F RID: 23887 RVA: 0x001BCF14 File Offset: 0x001BB114
		// (set) Token: 0x06005D50 RID: 23888 RVA: 0x0002C37D File Offset: 0x0002A57D
		public unsafe string cutsceneName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutsceneManager.NativeFieldInfoPtr_cutsceneName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutsceneManager.NativeFieldInfoPtr_cutsceneName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001CD4 RID: 7380
		// (get) Token: 0x06005D51 RID: 23889 RVA: 0x001BCF3C File Offset: 0x001BB13C
		// (set) Token: 0x06005D52 RID: 23890 RVA: 0x0002C39C File Offset: 0x0002A59C
		public unsafe Cutscene playingCutscene
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutsceneManager.NativeFieldInfoPtr_playingCutscene);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cutscene>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutsceneManager.NativeFieldInfoPtr_playingCutscene), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004000 RID: 16384
		private static readonly IntPtr NativeFieldInfoPtr_Cutscenes;

		// Token: 0x04004001 RID: 16385
		private static readonly IntPtr NativeFieldInfoPtr_cutsceneName;

		// Token: 0x04004002 RID: 16386
		private static readonly IntPtr NativeFieldInfoPtr_playingCutscene;

		// Token: 0x04004003 RID: 16387
		private static readonly IntPtr NativeMethodInfoPtr_RunCutscene_Private_Void_0;

		// Token: 0x04004004 RID: 16388
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_String_0;

		// Token: 0x04004005 RID: 16389
		private static readonly IntPtr NativeMethodInfoPtr_Ended_Private_Void_0;

		// Token: 0x04004006 RID: 16390
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B07 RID: 2823
		[ObfuscatedName("ScheduleOne.Cutscenes.CutsceneManager+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x0600E592 RID: 58770 RVA: 0x003815B8 File Offset: 0x0037F7B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<CutsceneManager.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CutsceneManager>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CutsceneManager.__c__DisplayClass4_0>.NativeClassPtr);
				CutsceneManager.__c__DisplayClass4_0.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutsceneManager.__c__DisplayClass4_0>.NativeClassPtr, "name");
				CutsceneManager.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutsceneManager.__c__DisplayClass4_0>.NativeClassPtr, 100675478);
				CutsceneManager.__c__DisplayClass4_0.NativeMethodInfoPtr__Play_b__0_Internal_Boolean_Cutscene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutsceneManager.__c__DisplayClass4_0>.NativeClassPtr, 100675479);
			}

			// Token: 0x0600E593 RID: 58771 RVA: 0x00381620 File Offset: 0x0037F820
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CutsceneManager.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutsceneManager.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E594 RID: 58772 RVA: 0x0038165C File Offset: 0x0037F85C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199495, XrefRangeEnd = 199499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Play_b__0(Cutscene c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutsceneManager.__c__DisplayClass4_0.NativeMethodInfoPtr__Play_b__0_Internal_Boolean_Cutscene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E595 RID: 58773 RVA: 0x0006C427 File Offset: 0x0006A627
			public __c__DisplayClass4_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045BB RID: 17851
			// (get) Token: 0x0600E596 RID: 58774 RVA: 0x003816AC File Offset: 0x0037F8AC
			// (set) Token: 0x0600E597 RID: 58775 RVA: 0x0006C430 File Offset: 0x0006A630
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutsceneManager.__c__DisplayClass4_0.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutsceneManager.__c__DisplayClass4_0.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009BD0 RID: 39888
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04009BD1 RID: 39889
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009BD2 RID: 39890
			private static readonly IntPtr NativeMethodInfoPtr__Play_b__0_Internal_Boolean_Cutscene_0;
		}
	}
}
