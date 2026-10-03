using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Dialogue;

namespace Il2CppScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x02000616 RID: 1558
	public class Fixer : NPC
	{
		// Token: 0x060096D3 RID: 38611 RVA: 0x002893AC File Offset: 0x002875AC
		// Note: this type is marked as 'beforefieldinit'.
		static Fixer()
		{
			Il2CppClassPointerStore<Fixer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.CharacterClasses", "Fixer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Fixer>.NativeClassPtr);
			Fixer.NativeFieldInfoPtr_ADDITIONAL_SIGNING_FEE_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fixer>.NativeClassPtr, "ADDITIONAL_SIGNING_FEE_1");
			Fixer.NativeFieldInfoPtr_ADDITIONAL_SIGNING_FEE_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fixer>.NativeClassPtr, "ADDITIONAL_SIGNING_FEE_2");
			Fixer.NativeFieldInfoPtr_MAX_SIGNING_FEE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fixer>.NativeClassPtr, "MAX_SIGNING_FEE");
			Fixer.NativeFieldInfoPtr_ADDITIONAL_FEE_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fixer>.NativeClassPtr, "ADDITIONAL_FEE_THRESHOLD");
			Fixer.NativeFieldInfoPtr_GreetingDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fixer>.NativeClassPtr, "GreetingDialogue");
			Fixer.NativeFieldInfoPtr_GreetedVariable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fixer>.NativeClassPtr, "GreetedVariable");
			Fixer.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fixer>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.FixerAssembly-CSharp.dll_Excuted");
			Fixer.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fixer>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.FixerAssembly-CSharp.dll_Excuted");
			Fixer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fixer>.NativeClassPtr, 100682956);
			Fixer.NativeMethodInfoPtr_Loaded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fixer>.NativeClassPtr, 100682957);
			Fixer.NativeMethodInfoPtr_EnableGreeting_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fixer>.NativeClassPtr, 100682958);
			Fixer.NativeMethodInfoPtr_SetGreeted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fixer>.NativeClassPtr, 100682959);
			Fixer.NativeMethodInfoPtr_GetAdditionalSigningFee_Public_Static_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fixer>.NativeClassPtr, 100682960);
			Fixer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fixer>.NativeClassPtr, 100682961);
			Fixer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fixer>.NativeClassPtr, 100682962);
			Fixer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fixer>.NativeClassPtr, 100682963);
			Fixer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fixer>.NativeClassPtr, 100682964);
			Fixer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fixer>.NativeClassPtr, 100682965);
		}

		// Token: 0x060096D4 RID: 38612 RVA: 0x00289544 File Offset: 0x00287744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273000, XrefRangeEnd = 273013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Fixer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096D5 RID: 38613 RVA: 0x00289580 File Offset: 0x00287780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273013, XrefRangeEnd = 273042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Loaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fixer.NativeMethodInfoPtr_Loaded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096D6 RID: 38614 RVA: 0x002895B4 File Offset: 0x002877B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273042, XrefRangeEnd = 273054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableGreeting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fixer.NativeMethodInfoPtr_EnableGreeting_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096D7 RID: 38615 RVA: 0x002895E8 File Offset: 0x002877E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273054, XrefRangeEnd = 273074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGreeted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fixer.NativeMethodInfoPtr_SetGreeted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096D8 RID: 38616 RVA: 0x0028961C File Offset: 0x0028781C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 273102, RefRangeEnd = 273105, XrefRangeStart = 273074, XrefRangeEnd = 273102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetAdditionalSigningFee()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fixer.NativeMethodInfoPtr_GetAdditionalSigningFee_Public_Static_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060096D9 RID: 38617 RVA: 0x0028964C File Offset: 0x0028784C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273105, XrefRangeEnd = 273110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Fixer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Fixer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fixer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096DA RID: 38618 RVA: 0x00289688 File Offset: 0x00287888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Fixer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096DB RID: 38619 RVA: 0x002896C4 File Offset: 0x002878C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Fixer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096DC RID: 38620 RVA: 0x00289700 File Offset: 0x00287900
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Fixer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096DD RID: 38621 RVA: 0x0028973C File Offset: 0x0028793C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Fixer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096DE RID: 38622 RVA: 0x0004687B File Offset: 0x00044A7B
		public Fixer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E78 RID: 11896
		// (get) Token: 0x060096DF RID: 38623 RVA: 0x00289778 File Offset: 0x00287978
		// (set) Token: 0x060096E0 RID: 38624 RVA: 0x00046884 File Offset: 0x00044A84
		public unsafe static int ADDITIONAL_SIGNING_FEE_1
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Fixer.NativeFieldInfoPtr_ADDITIONAL_SIGNING_FEE_1, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Fixer.NativeFieldInfoPtr_ADDITIONAL_SIGNING_FEE_1, (void*)(&value));
			}
		}

		// Token: 0x17002E79 RID: 11897
		// (get) Token: 0x060096E1 RID: 38625 RVA: 0x00289794 File Offset: 0x00287994
		// (set) Token: 0x060096E2 RID: 38626 RVA: 0x00046892 File Offset: 0x00044A92
		public unsafe static int ADDITIONAL_SIGNING_FEE_2
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Fixer.NativeFieldInfoPtr_ADDITIONAL_SIGNING_FEE_2, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Fixer.NativeFieldInfoPtr_ADDITIONAL_SIGNING_FEE_2, (void*)(&value));
			}
		}

		// Token: 0x17002E7A RID: 11898
		// (get) Token: 0x060096E3 RID: 38627 RVA: 0x002897B0 File Offset: 0x002879B0
		// (set) Token: 0x060096E4 RID: 38628 RVA: 0x000468A0 File Offset: 0x00044AA0
		public unsafe static int MAX_SIGNING_FEE
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Fixer.NativeFieldInfoPtr_MAX_SIGNING_FEE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Fixer.NativeFieldInfoPtr_MAX_SIGNING_FEE, (void*)(&value));
			}
		}

		// Token: 0x17002E7B RID: 11899
		// (get) Token: 0x060096E5 RID: 38629 RVA: 0x002897CC File Offset: 0x002879CC
		// (set) Token: 0x060096E6 RID: 38630 RVA: 0x000468AE File Offset: 0x00044AAE
		public unsafe static int ADDITIONAL_FEE_THRESHOLD
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Fixer.NativeFieldInfoPtr_ADDITIONAL_FEE_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Fixer.NativeFieldInfoPtr_ADDITIONAL_FEE_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17002E7C RID: 11900
		// (get) Token: 0x060096E7 RID: 38631 RVA: 0x002897E8 File Offset: 0x002879E8
		// (set) Token: 0x060096E8 RID: 38632 RVA: 0x000468BC File Offset: 0x00044ABC
		public unsafe DialogueContainer GreetingDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fixer.NativeFieldInfoPtr_GreetingDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fixer.NativeFieldInfoPtr_GreetingDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E7D RID: 11901
		// (get) Token: 0x060096E9 RID: 38633 RVA: 0x00289818 File Offset: 0x00287A18
		// (set) Token: 0x060096EA RID: 38634 RVA: 0x000468DB File Offset: 0x00044ADB
		public unsafe string GreetedVariable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fixer.NativeFieldInfoPtr_GreetedVariable);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fixer.NativeFieldInfoPtr_GreetedVariable), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002E7E RID: 11902
		// (get) Token: 0x060096EB RID: 38635 RVA: 0x00289840 File Offset: 0x00287A40
		// (set) Token: 0x060096EC RID: 38636 RVA: 0x000468FA File Offset: 0x00044AFA
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fixer.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fixer.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002E7F RID: 11903
		// (get) Token: 0x060096ED RID: 38637 RVA: 0x00289868 File Offset: 0x00287A68
		// (set) Token: 0x060096EE RID: 38638 RVA: 0x00046915 File Offset: 0x00044B15
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fixer.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fixer.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040067B7 RID: 26551
		private static readonly IntPtr NativeFieldInfoPtr_ADDITIONAL_SIGNING_FEE_1;

		// Token: 0x040067B8 RID: 26552
		private static readonly IntPtr NativeFieldInfoPtr_ADDITIONAL_SIGNING_FEE_2;

		// Token: 0x040067B9 RID: 26553
		private static readonly IntPtr NativeFieldInfoPtr_MAX_SIGNING_FEE;

		// Token: 0x040067BA RID: 26554
		private static readonly IntPtr NativeFieldInfoPtr_ADDITIONAL_FEE_THRESHOLD;

		// Token: 0x040067BB RID: 26555
		private static readonly IntPtr NativeFieldInfoPtr_GreetingDialogue;

		// Token: 0x040067BC RID: 26556
		private static readonly IntPtr NativeFieldInfoPtr_GreetedVariable;

		// Token: 0x040067BD RID: 26557
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040067BE RID: 26558
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040067BF RID: 26559
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040067C0 RID: 26560
		private static readonly IntPtr NativeMethodInfoPtr_Loaded_Private_Void_0;

		// Token: 0x040067C1 RID: 26561
		private static readonly IntPtr NativeMethodInfoPtr_EnableGreeting_Private_Void_0;

		// Token: 0x040067C2 RID: 26562
		private static readonly IntPtr NativeMethodInfoPtr_SetGreeted_Private_Void_0;

		// Token: 0x040067C3 RID: 26563
		private static readonly IntPtr NativeMethodInfoPtr_GetAdditionalSigningFee_Public_Static_Single_0;

		// Token: 0x040067C4 RID: 26564
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040067C5 RID: 26565
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040067C6 RID: 26566
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040067C7 RID: 26567
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040067C8 RID: 26568
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
