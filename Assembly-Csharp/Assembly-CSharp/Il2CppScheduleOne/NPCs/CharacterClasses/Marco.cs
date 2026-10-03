using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Dialogue;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x02000638 RID: 1592
	public class Marco : NPC
	{
		// Token: 0x06009873 RID: 39027 RVA: 0x0028E680 File Offset: 0x0028C880
		// Note: this type is marked as 'beforefieldinit'.
		static Marco()
		{
			Il2CppClassPointerStore<Marco>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.CharacterClasses", "Marco");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Marco>.NativeClassPtr);
			Marco.NativeFieldInfoPtr_VehicleRecoveryPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Marco>.NativeClassPtr, "VehicleRecoveryPoint");
			Marco.NativeFieldInfoPtr_VehicleDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Marco>.NativeClassPtr, "VehicleDetector");
			Marco.NativeFieldInfoPtr_RecoveryConversation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Marco>.NativeClassPtr, "RecoveryConversation");
			Marco.NativeFieldInfoPtr_GreetingDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Marco>.NativeClassPtr, "GreetingDialogue");
			Marco.NativeFieldInfoPtr_GreetedVariable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Marco>.NativeClassPtr, "GreetedVariable");
			Marco.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Marco>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.MarcoAssembly-CSharp.dll_Excuted");
			Marco.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Marco>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.MarcoAssembly-CSharp.dll_Excuted");
			Marco.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marco>.NativeClassPtr, 100683143);
			Marco.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marco>.NativeClassPtr, 100683144);
			Marco.NativeMethodInfoPtr_ShouldShowRecoverVehicle_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marco>.NativeClassPtr, 100683145);
			Marco.NativeMethodInfoPtr_RecoverVehicleValid_Private_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marco>.NativeClassPtr, 100683146);
			Marco.NativeMethodInfoPtr_RepaintVehicleValid_Private_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marco>.NativeClassPtr, 100683147);
			Marco.NativeMethodInfoPtr_RecoverVehicle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marco>.NativeClassPtr, 100683148);
			Marco.NativeMethodInfoPtr_Loaded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marco>.NativeClassPtr, 100683149);
			Marco.NativeMethodInfoPtr_EnableGreeting_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marco>.NativeClassPtr, 100683150);
			Marco.NativeMethodInfoPtr_SetGreeted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marco>.NativeClassPtr, 100683151);
			Marco.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marco>.NativeClassPtr, 100683152);
			Marco.NativeMethodInfoPtr__Awake_b__5_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marco>.NativeClassPtr, 100683153);
			Marco.NativeMethodInfoPtr__Start_b__6_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marco>.NativeClassPtr, 100683154);
			Marco.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marco>.NativeClassPtr, 100683155);
			Marco.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marco>.NativeClassPtr, 100683156);
			Marco.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marco>.NativeClassPtr, 100683157);
			Marco.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marco>.NativeClassPtr, 100683158);
		}

		// Token: 0x06009874 RID: 39028 RVA: 0x0028E87C File Offset: 0x0028CA7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273277, XrefRangeEnd = 273278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Marco.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009875 RID: 39029 RVA: 0x0028E8B8 File Offset: 0x0028CAB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273278, XrefRangeEnd = 273301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Marco.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009876 RID: 39030 RVA: 0x0028E8F4 File Offset: 0x0028CAF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273301, XrefRangeEnd = 273310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldShowRecoverVehicle(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marco.NativeMethodInfoPtr_ShouldShowRecoverVehicle_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009877 RID: 39031 RVA: 0x0028E940 File Offset: 0x0028CB40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273310, XrefRangeEnd = 273326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RecoverVehicleValid(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Marco.NativeMethodInfoPtr_RecoverVehicleValid_Private_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06009878 RID: 39032 RVA: 0x0028E998 File Offset: 0x0028CB98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273326, XrefRangeEnd = 273335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RepaintVehicleValid(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Marco.NativeMethodInfoPtr_RepaintVehicleValid_Private_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06009879 RID: 39033 RVA: 0x0028E9F0 File Offset: 0x0028CBF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273335, XrefRangeEnd = 273344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecoverVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marco.NativeMethodInfoPtr_RecoverVehicle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600987A RID: 39034 RVA: 0x0028EA24 File Offset: 0x0028CC24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273344, XrefRangeEnd = 273373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Loaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marco.NativeMethodInfoPtr_Loaded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600987B RID: 39035 RVA: 0x0028EA58 File Offset: 0x0028CC58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273373, XrefRangeEnd = 273385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableGreeting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marco.NativeMethodInfoPtr_EnableGreeting_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600987C RID: 39036 RVA: 0x0028EA8C File Offset: 0x0028CC8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273385, XrefRangeEnd = 273405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGreeted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marco.NativeMethodInfoPtr_SetGreeted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600987D RID: 39037 RVA: 0x0028EAC0 File Offset: 0x0028CCC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273405, XrefRangeEnd = 273410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Marco() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Marco>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marco.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600987E RID: 39038 RVA: 0x0028EAFC File Offset: 0x0028CCFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273410, XrefRangeEnd = 273416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__5_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marco.NativeMethodInfoPtr__Awake_b__5_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600987F RID: 39039 RVA: 0x0028EB30 File Offset: 0x0028CD30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273416, XrefRangeEnd = 273419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__6_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marco.NativeMethodInfoPtr__Start_b__6_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009880 RID: 39040 RVA: 0x0028EB64 File Offset: 0x0028CD64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273419, XrefRangeEnd = 273420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Marco.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009881 RID: 39041 RVA: 0x0028EBA0 File Offset: 0x0028CDA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273420, XrefRangeEnd = 273421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Marco.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009882 RID: 39042 RVA: 0x0028EBDC File Offset: 0x0028CDDC
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Marco.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009883 RID: 39043 RVA: 0x0028EC18 File Offset: 0x0028CE18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 273483, RefRangeEnd = 273484, XrefRangeStart = 273421, XrefRangeEnd = 273483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Marco.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009884 RID: 39044 RVA: 0x00047247 File Offset: 0x00045447
		public Marco(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002ECA RID: 11978
		// (get) Token: 0x06009885 RID: 39045 RVA: 0x0028EC54 File Offset: 0x0028CE54
		// (set) Token: 0x06009886 RID: 39046 RVA: 0x00047250 File Offset: 0x00045450
		public unsafe Transform VehicleRecoveryPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Marco.NativeFieldInfoPtr_VehicleRecoveryPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Marco.NativeFieldInfoPtr_VehicleRecoveryPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ECB RID: 11979
		// (get) Token: 0x06009887 RID: 39047 RVA: 0x0028EC84 File Offset: 0x0028CE84
		// (set) Token: 0x06009888 RID: 39048 RVA: 0x0004726F File Offset: 0x0004546F
		public unsafe VehicleDetector VehicleDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Marco.NativeFieldInfoPtr_VehicleDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Marco.NativeFieldInfoPtr_VehicleDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ECC RID: 11980
		// (get) Token: 0x06009889 RID: 39049 RVA: 0x0028ECB4 File Offset: 0x0028CEB4
		// (set) Token: 0x0600988A RID: 39050 RVA: 0x0004728E File Offset: 0x0004548E
		public unsafe DialogueContainer RecoveryConversation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Marco.NativeFieldInfoPtr_RecoveryConversation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Marco.NativeFieldInfoPtr_RecoveryConversation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ECD RID: 11981
		// (get) Token: 0x0600988B RID: 39051 RVA: 0x0028ECE4 File Offset: 0x0028CEE4
		// (set) Token: 0x0600988C RID: 39052 RVA: 0x000472AD File Offset: 0x000454AD
		public unsafe DialogueContainer GreetingDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Marco.NativeFieldInfoPtr_GreetingDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Marco.NativeFieldInfoPtr_GreetingDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ECE RID: 11982
		// (get) Token: 0x0600988D RID: 39053 RVA: 0x0028ED14 File Offset: 0x0028CF14
		// (set) Token: 0x0600988E RID: 39054 RVA: 0x000472CC File Offset: 0x000454CC
		public unsafe string GreetedVariable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Marco.NativeFieldInfoPtr_GreetedVariable);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Marco.NativeFieldInfoPtr_GreetedVariable), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002ECF RID: 11983
		// (get) Token: 0x0600988F RID: 39055 RVA: 0x0028ED3C File Offset: 0x0028CF3C
		// (set) Token: 0x06009890 RID: 39056 RVA: 0x000472EB File Offset: 0x000454EB
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Marco.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Marco.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002ED0 RID: 11984
		// (get) Token: 0x06009891 RID: 39057 RVA: 0x0028ED64 File Offset: 0x0028CF64
		// (set) Token: 0x06009892 RID: 39058 RVA: 0x00047306 File Offset: 0x00045506
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Marco.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Marco.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040068C1 RID: 26817
		private static readonly IntPtr NativeFieldInfoPtr_VehicleRecoveryPoint;

		// Token: 0x040068C2 RID: 26818
		private static readonly IntPtr NativeFieldInfoPtr_VehicleDetector;

		// Token: 0x040068C3 RID: 26819
		private static readonly IntPtr NativeFieldInfoPtr_RecoveryConversation;

		// Token: 0x040068C4 RID: 26820
		private static readonly IntPtr NativeFieldInfoPtr_GreetingDialogue;

		// Token: 0x040068C5 RID: 26821
		private static readonly IntPtr NativeFieldInfoPtr_GreetedVariable;

		// Token: 0x040068C6 RID: 26822
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040068C7 RID: 26823
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040068C8 RID: 26824
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040068C9 RID: 26825
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x040068CA RID: 26826
		private static readonly IntPtr NativeMethodInfoPtr_ShouldShowRecoverVehicle_Private_Boolean_Boolean_0;

		// Token: 0x040068CB RID: 26827
		private static readonly IntPtr NativeMethodInfoPtr_RecoverVehicleValid_Private_Boolean_byref_String_0;

		// Token: 0x040068CC RID: 26828
		private static readonly IntPtr NativeMethodInfoPtr_RepaintVehicleValid_Private_Boolean_byref_String_0;

		// Token: 0x040068CD RID: 26829
		private static readonly IntPtr NativeMethodInfoPtr_RecoverVehicle_Private_Void_0;

		// Token: 0x040068CE RID: 26830
		private static readonly IntPtr NativeMethodInfoPtr_Loaded_Private_Void_0;

		// Token: 0x040068CF RID: 26831
		private static readonly IntPtr NativeMethodInfoPtr_EnableGreeting_Private_Void_0;

		// Token: 0x040068D0 RID: 26832
		private static readonly IntPtr NativeMethodInfoPtr_SetGreeted_Private_Void_0;

		// Token: 0x040068D1 RID: 26833
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040068D2 RID: 26834
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_0_Private_Void_0;

		// Token: 0x040068D3 RID: 26835
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__6_0_Private_Void_0;

		// Token: 0x040068D4 RID: 26836
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040068D5 RID: 26837
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040068D6 RID: 26838
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040068D7 RID: 26839
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;
	}
}
