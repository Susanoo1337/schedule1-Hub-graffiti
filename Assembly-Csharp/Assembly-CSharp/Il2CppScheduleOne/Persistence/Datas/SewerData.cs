using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200026D RID: 621
	public class SewerData : SaveData
	{
		// Token: 0x06003121 RID: 12577 RVA: 0x0011DB18 File Offset: 0x0011BD18
		// Note: this type is marked as 'beforefieldinit'.
		static SewerData()
		{
			Il2CppClassPointerStore<SewerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "SewerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SewerData>.NativeClassPtr);
			SewerData.NativeFieldInfoPtr_IsSewerUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerData>.NativeClassPtr, "IsSewerUnlocked");
			SewerData.NativeFieldInfoPtr_IsRandomWorldKeyCollected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerData>.NativeClassPtr, "IsRandomWorldKeyCollected");
			SewerData.NativeFieldInfoPtr_RandomSewerKeyLocationIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerData>.NativeClassPtr, "RandomSewerKeyLocationIndex");
			SewerData.NativeFieldInfoPtr_HasSewerKingBeenDefeated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerData>.NativeClassPtr, "HasSewerKingBeenDefeated");
			SewerData.NativeFieldInfoPtr_HoursSinceLastSewerGoblinAppearance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerData>.NativeClassPtr, "HoursSinceLastSewerGoblinAppearance");
			SewerData.NativeFieldInfoPtr_RandomKeyPossessorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerData>.NativeClassPtr, "RandomKeyPossessorIndex");
			SewerData.NativeFieldInfoPtr_RandomKeyPossessorSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerData>.NativeClassPtr, "RandomKeyPossessorSet");
			SewerData.NativeFieldInfoPtr_ActiveMushroomLocationIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerData>.NativeClassPtr, "ActiveMushroomLocationIndices");
			SewerData.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Int32_Boolean_Int32_Int32_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerData>.NativeClassPtr, 100669465);
		}

		// Token: 0x06003122 RID: 12578 RVA: 0x0011DBFC File Offset: 0x0011BDFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 135453, RefRangeEnd = 135455, XrefRangeStart = 135444, XrefRangeEnd = 135453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SewerData(bool isSewerUnlocked, bool isRandomWorldKeyCollected, int randomSewerKeyLocationIndex, bool hasSewerKingBeenDefeated, int hoursSinceLastSewerGoblinAppearance, int randomKeyPossessorIndex, List<int> activeMushroomLocationIndices) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SewerData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isSewerUnlocked;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isRandomWorldKeyCollected;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref randomSewerKeyLocationIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasSewerKingBeenDefeated;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hoursSinceLastSewerGoblinAppearance;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref randomKeyPossessorIndex;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activeMushroomLocationIndices);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerData.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Int32_Boolean_Int32_Int32_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003123 RID: 12579 RVA: 0x00019525 File Offset: 0x00017725
		public SewerData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FB1 RID: 4017
		// (get) Token: 0x06003124 RID: 12580 RVA: 0x0011DC9C File Offset: 0x0011BE9C
		// (set) Token: 0x06003125 RID: 12581 RVA: 0x0001952E File Offset: 0x0001772E
		public unsafe bool IsSewerUnlocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerData.NativeFieldInfoPtr_IsSewerUnlocked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerData.NativeFieldInfoPtr_IsSewerUnlocked)) = value;
			}
		}

		// Token: 0x17000FB2 RID: 4018
		// (get) Token: 0x06003126 RID: 12582 RVA: 0x0011DCC4 File Offset: 0x0011BEC4
		// (set) Token: 0x06003127 RID: 12583 RVA: 0x00019549 File Offset: 0x00017749
		public unsafe bool IsRandomWorldKeyCollected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerData.NativeFieldInfoPtr_IsRandomWorldKeyCollected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerData.NativeFieldInfoPtr_IsRandomWorldKeyCollected)) = value;
			}
		}

		// Token: 0x17000FB3 RID: 4019
		// (get) Token: 0x06003128 RID: 12584 RVA: 0x0011DCEC File Offset: 0x0011BEEC
		// (set) Token: 0x06003129 RID: 12585 RVA: 0x00019564 File Offset: 0x00017764
		public unsafe int RandomSewerKeyLocationIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerData.NativeFieldInfoPtr_RandomSewerKeyLocationIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerData.NativeFieldInfoPtr_RandomSewerKeyLocationIndex)) = value;
			}
		}

		// Token: 0x17000FB4 RID: 4020
		// (get) Token: 0x0600312A RID: 12586 RVA: 0x0011DD14 File Offset: 0x0011BF14
		// (set) Token: 0x0600312B RID: 12587 RVA: 0x0001957F File Offset: 0x0001777F
		public unsafe bool HasSewerKingBeenDefeated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerData.NativeFieldInfoPtr_HasSewerKingBeenDefeated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerData.NativeFieldInfoPtr_HasSewerKingBeenDefeated)) = value;
			}
		}

		// Token: 0x17000FB5 RID: 4021
		// (get) Token: 0x0600312C RID: 12588 RVA: 0x0011DD3C File Offset: 0x0011BF3C
		// (set) Token: 0x0600312D RID: 12589 RVA: 0x0001959A File Offset: 0x0001779A
		public unsafe int HoursSinceLastSewerGoblinAppearance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerData.NativeFieldInfoPtr_HoursSinceLastSewerGoblinAppearance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerData.NativeFieldInfoPtr_HoursSinceLastSewerGoblinAppearance)) = value;
			}
		}

		// Token: 0x17000FB6 RID: 4022
		// (get) Token: 0x0600312E RID: 12590 RVA: 0x0011DD64 File Offset: 0x0011BF64
		// (set) Token: 0x0600312F RID: 12591 RVA: 0x000195B5 File Offset: 0x000177B5
		public unsafe int RandomKeyPossessorIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerData.NativeFieldInfoPtr_RandomKeyPossessorIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerData.NativeFieldInfoPtr_RandomKeyPossessorIndex)) = value;
			}
		}

		// Token: 0x17000FB7 RID: 4023
		// (get) Token: 0x06003130 RID: 12592 RVA: 0x0011DD8C File Offset: 0x0011BF8C
		// (set) Token: 0x06003131 RID: 12593 RVA: 0x000195D0 File Offset: 0x000177D0
		public unsafe bool RandomKeyPossessorSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerData.NativeFieldInfoPtr_RandomKeyPossessorSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerData.NativeFieldInfoPtr_RandomKeyPossessorSet)) = value;
			}
		}

		// Token: 0x17000FB8 RID: 4024
		// (get) Token: 0x06003132 RID: 12594 RVA: 0x0011DDB4 File Offset: 0x0011BFB4
		// (set) Token: 0x06003133 RID: 12595 RVA: 0x000195EB File Offset: 0x000177EB
		public unsafe List<int> ActiveMushroomLocationIndices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerData.NativeFieldInfoPtr_ActiveMushroomLocationIndices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerData.NativeFieldInfoPtr_ActiveMushroomLocationIndices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040020DA RID: 8410
		private static readonly IntPtr NativeFieldInfoPtr_IsSewerUnlocked;

		// Token: 0x040020DB RID: 8411
		private static readonly IntPtr NativeFieldInfoPtr_IsRandomWorldKeyCollected;

		// Token: 0x040020DC RID: 8412
		private static readonly IntPtr NativeFieldInfoPtr_RandomSewerKeyLocationIndex;

		// Token: 0x040020DD RID: 8413
		private static readonly IntPtr NativeFieldInfoPtr_HasSewerKingBeenDefeated;

		// Token: 0x040020DE RID: 8414
		private static readonly IntPtr NativeFieldInfoPtr_HoursSinceLastSewerGoblinAppearance;

		// Token: 0x040020DF RID: 8415
		private static readonly IntPtr NativeFieldInfoPtr_RandomKeyPossessorIndex;

		// Token: 0x040020E0 RID: 8416
		private static readonly IntPtr NativeFieldInfoPtr_RandomKeyPossessorSet;

		// Token: 0x040020E1 RID: 8417
		private static readonly IntPtr NativeFieldInfoPtr_ActiveMushroomLocationIndices;

		// Token: 0x040020E2 RID: 8418
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Int32_Boolean_Int32_Int32_List_1_Int32_0;
	}
}
