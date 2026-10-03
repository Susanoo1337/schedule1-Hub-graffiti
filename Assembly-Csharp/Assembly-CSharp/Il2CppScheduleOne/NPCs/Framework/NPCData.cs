using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Core;
using Il2CppSystem;

namespace Il2CppScheduleOne.NPCs.Framework
{
	// Token: 0x02000603 RID: 1539
	[Serializable]
	public class NPCData : Object
	{
		// Token: 0x060095DB RID: 38363 RVA: 0x00286198 File Offset: 0x00284398
		// Note: this type is marked as 'beforefieldinit'.
		static NPCData()
		{
			Il2CppClassPointerStore<NPCData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Framework", "NPCData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCData>.NativeClassPtr);
			NPCData.NativeFieldInfoPtr__basicInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCData>.NativeClassPtr, "_basicInfo");
			NPCData.NativeFieldInfoPtr__appearance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCData>.NativeClassPtr, "_appearance");
			NPCData.NativeFieldInfoPtr__health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCData>.NativeClassPtr, "_health");
			NPCData.NativeFieldInfoPtr__movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCData>.NativeClassPtr, "_movement");
			NPCData.NativeFieldInfoPtr__interaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCData>.NativeClassPtr, "_interaction");
			NPCData.NativeFieldInfoPtr__relationship = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCData>.NativeClassPtr, "_relationship");
			NPCData.NativeFieldInfoPtr__messaging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCData>.NativeClassPtr, "_messaging");
			NPCData.NativeFieldInfoPtr__dialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCData>.NativeClassPtr, "_dialogue");
			NPCData.NativeFieldInfoPtr__voice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCData>.NativeClassPtr, "_voice");
			NPCData.NativeFieldInfoPtr__inventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCData>.NativeClassPtr, "_inventory");
			NPCData.NativeFieldInfoPtr__behaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCData>.NativeClassPtr, "_behaviour");
			NPCData.NativeFieldInfoPtr__weatherBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCData>.NativeClassPtr, "_weatherBehaviour");
			NPCData.NativeMethodInfoPtr_get_BasicInfo_Public_get_BasicInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCData>.NativeClassPtr, 100682850);
			NPCData.NativeMethodInfoPtr_get_Appearance_Public_get_Appearance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCData>.NativeClassPtr, 100682851);
			NPCData.NativeMethodInfoPtr_get_Health_Public_get_Health_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCData>.NativeClassPtr, 100682852);
			NPCData.NativeMethodInfoPtr_get_Movement_Public_get_Movement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCData>.NativeClassPtr, 100682853);
			NPCData.NativeMethodInfoPtr_get_Interaction_Public_get_Interaction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCData>.NativeClassPtr, 100682854);
			NPCData.NativeMethodInfoPtr_get_Relationship_Public_get_Relationship_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCData>.NativeClassPtr, 100682855);
			NPCData.NativeMethodInfoPtr_get_Messaging_Public_get_Messaging_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCData>.NativeClassPtr, 100682856);
			NPCData.NativeMethodInfoPtr_get_Dialogue_Public_get_Dialogue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCData>.NativeClassPtr, 100682857);
			NPCData.NativeMethodInfoPtr_get_Voice_Public_get_Voice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCData>.NativeClassPtr, 100682858);
			NPCData.NativeMethodInfoPtr_get_Inventory_Public_get_Inventory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCData>.NativeClassPtr, 100682859);
			NPCData.NativeMethodInfoPtr_get_Behaviour_Public_get_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCData>.NativeClassPtr, 100682860);
			NPCData.NativeMethodInfoPtr_get_WeatherBehaviour_Public_get_WeatherBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCData>.NativeClassPtr, 100682861);
			NPCData.NativeMethodInfoPtr_GetDeepCopy_Public_Virtual_New_NPCData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCData>.NativeClassPtr, 100682862);
			NPCData.NativeMethodInfoPtr_PopulateNPCData_Protected_Void_NPCData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCData>.NativeClassPtr, 100682863);
			NPCData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCData>.NativeClassPtr, 100682864);
		}

		// Token: 0x17002E44 RID: 11844
		// (get) Token: 0x060095DC RID: 38364 RVA: 0x002863E4 File Offset: 0x002845E4
		public unsafe BasicInfo BasicInfo
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 272366, RefRangeEnd = 272376, XrefRangeStart = 272362, XrefRangeEnd = 272366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCData.NativeMethodInfoPtr_get_BasicInfo_Public_get_BasicInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BasicInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17002E45 RID: 11845
		// (get) Token: 0x060095DD RID: 38365 RVA: 0x00286424 File Offset: 0x00284624
		public unsafe Appearance Appearance
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 272380, RefRangeEnd = 272386, XrefRangeStart = 272376, XrefRangeEnd = 272380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCData.NativeMethodInfoPtr_get_Appearance_Public_get_Appearance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Appearance>(intPtr3) : null;
			}
		}

		// Token: 0x17002E46 RID: 11846
		// (get) Token: 0x060095DE RID: 38366 RVA: 0x00286464 File Offset: 0x00284664
		public unsafe Health Health
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 272390, RefRangeEnd = 272402, XrefRangeStart = 272386, XrefRangeEnd = 272390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCData.NativeMethodInfoPtr_get_Health_Public_get_Health_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Health>(intPtr3) : null;
			}
		}

		// Token: 0x17002E47 RID: 11847
		// (get) Token: 0x060095DF RID: 38367 RVA: 0x002864A4 File Offset: 0x002846A4
		public unsafe Movement Movement
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 272406, RefRangeEnd = 272411, XrefRangeStart = 272402, XrefRangeEnd = 272406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCData.NativeMethodInfoPtr_get_Movement_Public_get_Movement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Movement>(intPtr3) : null;
			}
		}

		// Token: 0x17002E48 RID: 11848
		// (get) Token: 0x060095E0 RID: 38368 RVA: 0x002864E4 File Offset: 0x002846E4
		public unsafe Interaction Interaction
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 272415, RefRangeEnd = 272416, XrefRangeStart = 272411, XrefRangeEnd = 272415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCData.NativeMethodInfoPtr_get_Interaction_Public_get_Interaction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Interaction>(intPtr3) : null;
			}
		}

		// Token: 0x17002E49 RID: 11849
		// (get) Token: 0x060095E1 RID: 38369 RVA: 0x00286524 File Offset: 0x00284724
		public unsafe Relationship Relationship
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 272420, RefRangeEnd = 272423, XrefRangeStart = 272416, XrefRangeEnd = 272420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCData.NativeMethodInfoPtr_get_Relationship_Public_get_Relationship_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Relationship>(intPtr3) : null;
			}
		}

		// Token: 0x17002E4A RID: 11850
		// (get) Token: 0x060095E2 RID: 38370 RVA: 0x00286564 File Offset: 0x00284764
		public unsafe Messaging Messaging
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 272427, RefRangeEnd = 272431, XrefRangeStart = 272423, XrefRangeEnd = 272427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCData.NativeMethodInfoPtr_get_Messaging_Public_get_Messaging_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Messaging>(intPtr3) : null;
			}
		}

		// Token: 0x17002E4B RID: 11851
		// (get) Token: 0x060095E3 RID: 38371 RVA: 0x002865A4 File Offset: 0x002847A4
		public unsafe Dialogue Dialogue
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 272435, RefRangeEnd = 272436, XrefRangeStart = 272431, XrefRangeEnd = 272435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCData.NativeMethodInfoPtr_get_Dialogue_Public_get_Dialogue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dialogue>(intPtr3) : null;
			}
		}

		// Token: 0x17002E4C RID: 11852
		// (get) Token: 0x060095E4 RID: 38372 RVA: 0x002865E4 File Offset: 0x002847E4
		public unsafe Voice Voice
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 272440, RefRangeEnd = 272442, XrefRangeStart = 272436, XrefRangeEnd = 272440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCData.NativeMethodInfoPtr_get_Voice_Public_get_Voice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Voice>(intPtr3) : null;
			}
		}

		// Token: 0x17002E4D RID: 11853
		// (get) Token: 0x060095E5 RID: 38373 RVA: 0x00286624 File Offset: 0x00284824
		public unsafe Inventory Inventory
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 272446, RefRangeEnd = 272465, XrefRangeStart = 272442, XrefRangeEnd = 272446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCData.NativeMethodInfoPtr_get_Inventory_Public_get_Inventory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Inventory>(intPtr3) : null;
			}
		}

		// Token: 0x17002E4E RID: 11854
		// (get) Token: 0x060095E6 RID: 38374 RVA: 0x00286664 File Offset: 0x00284864
		public unsafe Behaviour Behaviour
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 272469, RefRangeEnd = 272472, XrefRangeStart = 272465, XrefRangeEnd = 272469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCData.NativeMethodInfoPtr_get_Behaviour_Public_get_Behaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Behaviour>(intPtr3) : null;
			}
		}

		// Token: 0x17002E4F RID: 11855
		// (get) Token: 0x060095E7 RID: 38375 RVA: 0x002866A4 File Offset: 0x002848A4
		public unsafe WeatherBehaviour WeatherBehaviour
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 272476, RefRangeEnd = 272479, XrefRangeStart = 272472, XrefRangeEnd = 272476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCData.NativeMethodInfoPtr_get_WeatherBehaviour_Public_get_WeatherBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WeatherBehaviour>(intPtr3) : null;
			}
		}

		// Token: 0x060095E8 RID: 38376 RVA: 0x002866E4 File Offset: 0x002848E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272479, XrefRangeEnd = 272484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual NPCData GetDeepCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCData.NativeMethodInfoPtr_GetDeepCopy_Public_Virtual_New_NPCData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCData>(intPtr3) : null;
		}

		// Token: 0x060095E9 RID: 38377 RVA: 0x00286730 File Offset: 0x00284930
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 272667, RefRangeEnd = 272672, XrefRangeStart = 272484, XrefRangeEnd = 272667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopulateNPCData(NPCData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCData.NativeMethodInfoPtr_PopulateNPCData_Protected_Void_NPCData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095EA RID: 38378 RVA: 0x00286774 File Offset: 0x00284974
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 272805, RefRangeEnd = 272811, XrefRangeStart = 272672, XrefRangeEnd = 272805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095EB RID: 38379 RVA: 0x00046204 File Offset: 0x00044404
		public NPCData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E38 RID: 11832
		// (get) Token: 0x060095EC RID: 38380 RVA: 0x002867B0 File Offset: 0x002849B0
		// (set) Token: 0x060095ED RID: 38381 RVA: 0x0004620D File Offset: 0x0004440D
		public unsafe ValueOrReference<BasicInfo, BasicInfoPreset> _basicInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCData.NativeFieldInfoPtr__basicInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValueOrReference<BasicInfo, BasicInfoPreset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCData.NativeFieldInfoPtr__basicInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E39 RID: 11833
		// (get) Token: 0x060095EE RID: 38382 RVA: 0x002867E0 File Offset: 0x002849E0
		// (set) Token: 0x060095EF RID: 38383 RVA: 0x0004622C File Offset: 0x0004442C
		public unsafe ValueOrReference<Appearance, AppearancePreset> _appearance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCData.NativeFieldInfoPtr__appearance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValueOrReference<Appearance, AppearancePreset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCData.NativeFieldInfoPtr__appearance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E3A RID: 11834
		// (get) Token: 0x060095F0 RID: 38384 RVA: 0x00286810 File Offset: 0x00284A10
		// (set) Token: 0x060095F1 RID: 38385 RVA: 0x0004624B File Offset: 0x0004444B
		public unsafe ValueOrReference<Health, HealthPreset> _health
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCData.NativeFieldInfoPtr__health);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValueOrReference<Health, HealthPreset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCData.NativeFieldInfoPtr__health), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E3B RID: 11835
		// (get) Token: 0x060095F2 RID: 38386 RVA: 0x00286840 File Offset: 0x00284A40
		// (set) Token: 0x060095F3 RID: 38387 RVA: 0x0004626A File Offset: 0x0004446A
		public unsafe ValueOrReference<Movement, MovementPreset> _movement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCData.NativeFieldInfoPtr__movement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValueOrReference<Movement, MovementPreset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCData.NativeFieldInfoPtr__movement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E3C RID: 11836
		// (get) Token: 0x060095F4 RID: 38388 RVA: 0x00286870 File Offset: 0x00284A70
		// (set) Token: 0x060095F5 RID: 38389 RVA: 0x00046289 File Offset: 0x00044489
		public unsafe ValueOrReference<Interaction, InteractionPreset> _interaction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCData.NativeFieldInfoPtr__interaction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValueOrReference<Interaction, InteractionPreset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCData.NativeFieldInfoPtr__interaction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E3D RID: 11837
		// (get) Token: 0x060095F6 RID: 38390 RVA: 0x002868A0 File Offset: 0x00284AA0
		// (set) Token: 0x060095F7 RID: 38391 RVA: 0x000462A8 File Offset: 0x000444A8
		public unsafe ValueOrReference<Relationship, RelationshipPreset> _relationship
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCData.NativeFieldInfoPtr__relationship);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValueOrReference<Relationship, RelationshipPreset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCData.NativeFieldInfoPtr__relationship), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E3E RID: 11838
		// (get) Token: 0x060095F8 RID: 38392 RVA: 0x002868D0 File Offset: 0x00284AD0
		// (set) Token: 0x060095F9 RID: 38393 RVA: 0x000462C7 File Offset: 0x000444C7
		public unsafe ValueOrReference<Messaging, MessagingPreset> _messaging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCData.NativeFieldInfoPtr__messaging);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValueOrReference<Messaging, MessagingPreset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCData.NativeFieldInfoPtr__messaging), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E3F RID: 11839
		// (get) Token: 0x060095FA RID: 38394 RVA: 0x00286900 File Offset: 0x00284B00
		// (set) Token: 0x060095FB RID: 38395 RVA: 0x000462E6 File Offset: 0x000444E6
		public unsafe ValueOrReference<Dialogue, DialoguePreset> _dialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCData.NativeFieldInfoPtr__dialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValueOrReference<Dialogue, DialoguePreset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCData.NativeFieldInfoPtr__dialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E40 RID: 11840
		// (get) Token: 0x060095FC RID: 38396 RVA: 0x00286930 File Offset: 0x00284B30
		// (set) Token: 0x060095FD RID: 38397 RVA: 0x00046305 File Offset: 0x00044505
		public unsafe ValueOrReference<Voice, VoicePreset> _voice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCData.NativeFieldInfoPtr__voice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValueOrReference<Voice, VoicePreset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCData.NativeFieldInfoPtr__voice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E41 RID: 11841
		// (get) Token: 0x060095FE RID: 38398 RVA: 0x00286960 File Offset: 0x00284B60
		// (set) Token: 0x060095FF RID: 38399 RVA: 0x00046324 File Offset: 0x00044524
		public unsafe ValueOrReference<Inventory, InventoryPreset> _inventory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCData.NativeFieldInfoPtr__inventory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValueOrReference<Inventory, InventoryPreset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCData.NativeFieldInfoPtr__inventory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E42 RID: 11842
		// (get) Token: 0x06009600 RID: 38400 RVA: 0x00286990 File Offset: 0x00284B90
		// (set) Token: 0x06009601 RID: 38401 RVA: 0x00046343 File Offset: 0x00044543
		public unsafe ValueOrReference<Behaviour, BehaviourPreset> _behaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCData.NativeFieldInfoPtr__behaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValueOrReference<Behaviour, BehaviourPreset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCData.NativeFieldInfoPtr__behaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E43 RID: 11843
		// (get) Token: 0x06009602 RID: 38402 RVA: 0x002869C0 File Offset: 0x00284BC0
		// (set) Token: 0x06009603 RID: 38403 RVA: 0x00046362 File Offset: 0x00044562
		public unsafe ValueOrReference<WeatherBehaviour, WeatherBehaviourPreset> _weatherBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCData.NativeFieldInfoPtr__weatherBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValueOrReference<WeatherBehaviour, WeatherBehaviourPreset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCData.NativeFieldInfoPtr__weatherBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006719 RID: 26393
		private static readonly IntPtr NativeFieldInfoPtr__basicInfo;

		// Token: 0x0400671A RID: 26394
		private static readonly IntPtr NativeFieldInfoPtr__appearance;

		// Token: 0x0400671B RID: 26395
		private static readonly IntPtr NativeFieldInfoPtr__health;

		// Token: 0x0400671C RID: 26396
		private static readonly IntPtr NativeFieldInfoPtr__movement;

		// Token: 0x0400671D RID: 26397
		private static readonly IntPtr NativeFieldInfoPtr__interaction;

		// Token: 0x0400671E RID: 26398
		private static readonly IntPtr NativeFieldInfoPtr__relationship;

		// Token: 0x0400671F RID: 26399
		private static readonly IntPtr NativeFieldInfoPtr__messaging;

		// Token: 0x04006720 RID: 26400
		private static readonly IntPtr NativeFieldInfoPtr__dialogue;

		// Token: 0x04006721 RID: 26401
		private static readonly IntPtr NativeFieldInfoPtr__voice;

		// Token: 0x04006722 RID: 26402
		private static readonly IntPtr NativeFieldInfoPtr__inventory;

		// Token: 0x04006723 RID: 26403
		private static readonly IntPtr NativeFieldInfoPtr__behaviour;

		// Token: 0x04006724 RID: 26404
		private static readonly IntPtr NativeFieldInfoPtr__weatherBehaviour;

		// Token: 0x04006725 RID: 26405
		private static readonly IntPtr NativeMethodInfoPtr_get_BasicInfo_Public_get_BasicInfo_0;

		// Token: 0x04006726 RID: 26406
		private static readonly IntPtr NativeMethodInfoPtr_get_Appearance_Public_get_Appearance_0;

		// Token: 0x04006727 RID: 26407
		private static readonly IntPtr NativeMethodInfoPtr_get_Health_Public_get_Health_0;

		// Token: 0x04006728 RID: 26408
		private static readonly IntPtr NativeMethodInfoPtr_get_Movement_Public_get_Movement_0;

		// Token: 0x04006729 RID: 26409
		private static readonly IntPtr NativeMethodInfoPtr_get_Interaction_Public_get_Interaction_0;

		// Token: 0x0400672A RID: 26410
		private static readonly IntPtr NativeMethodInfoPtr_get_Relationship_Public_get_Relationship_0;

		// Token: 0x0400672B RID: 26411
		private static readonly IntPtr NativeMethodInfoPtr_get_Messaging_Public_get_Messaging_0;

		// Token: 0x0400672C RID: 26412
		private static readonly IntPtr NativeMethodInfoPtr_get_Dialogue_Public_get_Dialogue_0;

		// Token: 0x0400672D RID: 26413
		private static readonly IntPtr NativeMethodInfoPtr_get_Voice_Public_get_Voice_0;

		// Token: 0x0400672E RID: 26414
		private static readonly IntPtr NativeMethodInfoPtr_get_Inventory_Public_get_Inventory_0;

		// Token: 0x0400672F RID: 26415
		private static readonly IntPtr NativeMethodInfoPtr_get_Behaviour_Public_get_Behaviour_0;

		// Token: 0x04006730 RID: 26416
		private static readonly IntPtr NativeMethodInfoPtr_get_WeatherBehaviour_Public_get_WeatherBehaviour_0;

		// Token: 0x04006731 RID: 26417
		private static readonly IntPtr NativeMethodInfoPtr_GetDeepCopy_Public_Virtual_New_NPCData_0;

		// Token: 0x04006732 RID: 26418
		private static readonly IntPtr NativeMethodInfoPtr_PopulateNPCData_Protected_Void_NPCData_0;

		// Token: 0x04006733 RID: 26419
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
