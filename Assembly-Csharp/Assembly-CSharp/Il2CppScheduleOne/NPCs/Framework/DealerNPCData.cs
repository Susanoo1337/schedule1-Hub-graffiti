using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.Economy;

namespace Il2CppScheduleOne.NPCs.Framework
{
	// Token: 0x02000600 RID: 1536
	[Serializable]
	public class DealerNPCData : NPCData
	{
		// Token: 0x060095BD RID: 38333 RVA: 0x00285B74 File Offset: 0x00283D74
		// Note: this type is marked as 'beforefieldinit'.
		static DealerNPCData()
		{
			Il2CppClassPointerStore<DealerNPCData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Framework", "DealerNPCData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealerNPCData>.NativeClassPtr);
			DealerNPCData.NativeFieldInfoPtr_DealerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerNPCData>.NativeClassPtr, "DealerType");
			DealerNPCData.NativeFieldInfoPtr_HomeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerNPCData>.NativeClassPtr, "HomeName");
			DealerNPCData.NativeFieldInfoPtr_SigningFee = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerNPCData>.NativeClassPtr, "SigningFee");
			DealerNPCData.NativeFieldInfoPtr_SalesCutPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerNPCData>.NativeClassPtr, "SalesCutPercentage");
			DealerNPCData.NativeFieldInfoPtr_RecruitDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerNPCData>.NativeClassPtr, "RecruitDialogue");
			DealerNPCData.NativeFieldInfoPtr_CollectCashDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerNPCData>.NativeClassPtr, "CollectCashDialogue");
			DealerNPCData.NativeFieldInfoPtr_AssignCustomersDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerNPCData>.NativeClassPtr, "AssignCustomersDialogue");
			DealerNPCData.NativeMethodInfoPtr_GetDeepCopy_Public_Virtual_NPCData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerNPCData>.NativeClassPtr, 100682842);
			DealerNPCData.NativeMethodInfoPtr_PopulateDealerData_Private_Void_DealerNPCData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerNPCData>.NativeClassPtr, 100682843);
			DealerNPCData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerNPCData>.NativeClassPtr, 100682844);
		}

		// Token: 0x060095BE RID: 38334 RVA: 0x00285C6C File Offset: 0x00283E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272325, XrefRangeEnd = 272338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override NPCData GetDeepCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DealerNPCData.NativeMethodInfoPtr_GetDeepCopy_Public_Virtual_NPCData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCData>(intPtr3) : null;
		}

		// Token: 0x060095BF RID: 38335 RVA: 0x00285CB8 File Offset: 0x00283EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272338, XrefRangeEnd = 272344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopulateDealerData(DealerNPCData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerNPCData.NativeMethodInfoPtr_PopulateDealerData_Private_Void_DealerNPCData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095C0 RID: 38336 RVA: 0x00285CFC File Offset: 0x00283EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272344, XrefRangeEnd = 272349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DealerNPCData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealerNPCData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerNPCData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095C1 RID: 38337 RVA: 0x0004611C File Offset: 0x0004431C
		public DealerNPCData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E30 RID: 11824
		// (get) Token: 0x060095C2 RID: 38338 RVA: 0x00285D38 File Offset: 0x00283F38
		// (set) Token: 0x060095C3 RID: 38339 RVA: 0x00046125 File Offset: 0x00044325
		public unsafe EDealerType DealerType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerNPCData.NativeFieldInfoPtr_DealerType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerNPCData.NativeFieldInfoPtr_DealerType)) = value;
			}
		}

		// Token: 0x17002E31 RID: 11825
		// (get) Token: 0x060095C4 RID: 38340 RVA: 0x00285D60 File Offset: 0x00283F60
		// (set) Token: 0x060095C5 RID: 38341 RVA: 0x00046140 File Offset: 0x00044340
		public unsafe string HomeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerNPCData.NativeFieldInfoPtr_HomeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerNPCData.NativeFieldInfoPtr_HomeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002E32 RID: 11826
		// (get) Token: 0x060095C6 RID: 38342 RVA: 0x00285D88 File Offset: 0x00283F88
		// (set) Token: 0x060095C7 RID: 38343 RVA: 0x0004615F File Offset: 0x0004435F
		public unsafe float SigningFee
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerNPCData.NativeFieldInfoPtr_SigningFee);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerNPCData.NativeFieldInfoPtr_SigningFee)) = value;
			}
		}

		// Token: 0x17002E33 RID: 11827
		// (get) Token: 0x060095C8 RID: 38344 RVA: 0x00285DB0 File Offset: 0x00283FB0
		// (set) Token: 0x060095C9 RID: 38345 RVA: 0x0004617A File Offset: 0x0004437A
		public unsafe float SalesCutPercentage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerNPCData.NativeFieldInfoPtr_SalesCutPercentage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerNPCData.NativeFieldInfoPtr_SalesCutPercentage)) = value;
			}
		}

		// Token: 0x17002E34 RID: 11828
		// (get) Token: 0x060095CA RID: 38346 RVA: 0x00285DD8 File Offset: 0x00283FD8
		// (set) Token: 0x060095CB RID: 38347 RVA: 0x00046195 File Offset: 0x00044395
		public unsafe DialogueContainer RecruitDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerNPCData.NativeFieldInfoPtr_RecruitDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerNPCData.NativeFieldInfoPtr_RecruitDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E35 RID: 11829
		// (get) Token: 0x060095CC RID: 38348 RVA: 0x00285E08 File Offset: 0x00284008
		// (set) Token: 0x060095CD RID: 38349 RVA: 0x000461B4 File Offset: 0x000443B4
		public unsafe DialogueContainer CollectCashDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerNPCData.NativeFieldInfoPtr_CollectCashDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerNPCData.NativeFieldInfoPtr_CollectCashDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E36 RID: 11830
		// (get) Token: 0x060095CE RID: 38350 RVA: 0x00285E38 File Offset: 0x00284038
		// (set) Token: 0x060095CF RID: 38351 RVA: 0x000461D3 File Offset: 0x000443D3
		public unsafe DialogueContainer AssignCustomersDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerNPCData.NativeFieldInfoPtr_AssignCustomersDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerNPCData.NativeFieldInfoPtr_AssignCustomersDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006709 RID: 26377
		private static readonly IntPtr NativeFieldInfoPtr_DealerType;

		// Token: 0x0400670A RID: 26378
		private static readonly IntPtr NativeFieldInfoPtr_HomeName;

		// Token: 0x0400670B RID: 26379
		private static readonly IntPtr NativeFieldInfoPtr_SigningFee;

		// Token: 0x0400670C RID: 26380
		private static readonly IntPtr NativeFieldInfoPtr_SalesCutPercentage;

		// Token: 0x0400670D RID: 26381
		private static readonly IntPtr NativeFieldInfoPtr_RecruitDialogue;

		// Token: 0x0400670E RID: 26382
		private static readonly IntPtr NativeFieldInfoPtr_CollectCashDialogue;

		// Token: 0x0400670F RID: 26383
		private static readonly IntPtr NativeFieldInfoPtr_AssignCustomersDialogue;

		// Token: 0x04006710 RID: 26384
		private static readonly IntPtr NativeMethodInfoPtr_GetDeepCopy_Public_Virtual_NPCData_0;

		// Token: 0x04006711 RID: 26385
		private static readonly IntPtr NativeMethodInfoPtr_PopulateDealerData_Private_Void_DealerNPCData_0;

		// Token: 0x04006712 RID: 26386
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
