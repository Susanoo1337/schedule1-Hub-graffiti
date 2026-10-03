using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.NPCs.Relation;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000215 RID: 533
	[Serializable]
	public class RelationshipData : SaveData
	{
		// Token: 0x06002E4D RID: 11853 RVA: 0x00115784 File Offset: 0x00113984
		// Note: this type is marked as 'beforefieldinit'.
		static RelationshipData()
		{
			Il2CppClassPointerStore<RelationshipData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "RelationshipData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RelationshipData>.NativeClassPtr);
			RelationshipData.NativeFieldInfoPtr_RelationDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationshipData>.NativeClassPtr, "RelationDelta");
			RelationshipData.NativeFieldInfoPtr_Unlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationshipData>.NativeClassPtr, "Unlocked");
			RelationshipData.NativeFieldInfoPtr_UnlockType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationshipData>.NativeClassPtr, "UnlockType");
			RelationshipData.NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_EUnlockType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipData>.NativeClassPtr, 100669369);
		}

		// Token: 0x06002E4E RID: 11854 RVA: 0x00115804 File Offset: 0x00113A04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 134778, RefRangeEnd = 134779, XrefRangeStart = 134777, XrefRangeEnd = 134778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RelationshipData(float relationDelta, bool unlocked, NPCRelationData.EUnlockType unlockType) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RelationshipData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref relationDelta;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unlocked;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unlockType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipData.NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_EUnlockType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E4F RID: 11855 RVA: 0x0001778F File Offset: 0x0001598F
		public RelationshipData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000ECE RID: 3790
		// (get) Token: 0x06002E50 RID: 11856 RVA: 0x00115868 File Offset: 0x00113A68
		// (set) Token: 0x06002E51 RID: 11857 RVA: 0x00017798 File Offset: 0x00015998
		public unsafe float RelationDelta
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipData.NativeFieldInfoPtr_RelationDelta);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipData.NativeFieldInfoPtr_RelationDelta)) = value;
			}
		}

		// Token: 0x17000ECF RID: 3791
		// (get) Token: 0x06002E52 RID: 11858 RVA: 0x00115890 File Offset: 0x00113A90
		// (set) Token: 0x06002E53 RID: 11859 RVA: 0x000177B3 File Offset: 0x000159B3
		public unsafe bool Unlocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipData.NativeFieldInfoPtr_Unlocked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipData.NativeFieldInfoPtr_Unlocked)) = value;
			}
		}

		// Token: 0x17000ED0 RID: 3792
		// (get) Token: 0x06002E54 RID: 11860 RVA: 0x001158B8 File Offset: 0x00113AB8
		// (set) Token: 0x06002E55 RID: 11861 RVA: 0x000177CE File Offset: 0x000159CE
		public unsafe NPCRelationData.EUnlockType UnlockType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipData.NativeFieldInfoPtr_UnlockType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipData.NativeFieldInfoPtr_UnlockType)) = value;
			}
		}

		// Token: 0x04001F98 RID: 8088
		private static readonly IntPtr NativeFieldInfoPtr_RelationDelta;

		// Token: 0x04001F99 RID: 8089
		private static readonly IntPtr NativeFieldInfoPtr_Unlocked;

		// Token: 0x04001F9A RID: 8090
		private static readonly IntPtr NativeFieldInfoPtr_UnlockType;

		// Token: 0x04001F9B RID: 8091
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_EUnlockType_0;
	}
}
