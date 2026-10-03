using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200023B RID: 571
	public class NPCHealthData : SaveData
	{
		// Token: 0x06002F53 RID: 12115 RVA: 0x00118390 File Offset: 0x00116590
		// Note: this type is marked as 'beforefieldinit'.
		static NPCHealthData()
		{
			Il2CppClassPointerStore<NPCHealthData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "NPCHealthData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCHealthData>.NativeClassPtr);
			NPCHealthData.NativeFieldInfoPtr_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealthData>.NativeClassPtr, "Health");
			NPCHealthData.NativeFieldInfoPtr_IsDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealthData>.NativeClassPtr, "IsDead");
			NPCHealthData.NativeFieldInfoPtr_DaysPassedSinceDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealthData>.NativeClassPtr, "DaysPassedSinceDeath");
			NPCHealthData.NativeFieldInfoPtr_HoursSinceAttackedByPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealthData>.NativeClassPtr, "HoursSinceAttackedByPlayer");
			NPCHealthData.NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealthData>.NativeClassPtr, 100669409);
		}

		// Token: 0x06002F54 RID: 12116 RVA: 0x00118424 File Offset: 0x00116624
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 135004, RefRangeEnd = 135005, XrefRangeStart = 135003, XrefRangeEnd = 135004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCHealthData(float health, bool isDead, int daysPassedSinceDeath, int hoursSinceAttackedByPlayer) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCHealthData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref health;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDead;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref daysPassedSinceDeath;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hoursSinceAttackedByPlayer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealthData.NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F55 RID: 12117 RVA: 0x000181DA File Offset: 0x000163DA
		public NPCHealthData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F17 RID: 3863
		// (get) Token: 0x06002F56 RID: 12118 RVA: 0x00118498 File Offset: 0x00116698
		// (set) Token: 0x06002F57 RID: 12119 RVA: 0x000181E3 File Offset: 0x000163E3
		public unsafe float Health
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealthData.NativeFieldInfoPtr_Health);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealthData.NativeFieldInfoPtr_Health)) = value;
			}
		}

		// Token: 0x17000F18 RID: 3864
		// (get) Token: 0x06002F58 RID: 12120 RVA: 0x001184C0 File Offset: 0x001166C0
		// (set) Token: 0x06002F59 RID: 12121 RVA: 0x000181FE File Offset: 0x000163FE
		public unsafe bool IsDead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealthData.NativeFieldInfoPtr_IsDead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealthData.NativeFieldInfoPtr_IsDead)) = value;
			}
		}

		// Token: 0x17000F19 RID: 3865
		// (get) Token: 0x06002F5A RID: 12122 RVA: 0x001184E8 File Offset: 0x001166E8
		// (set) Token: 0x06002F5B RID: 12123 RVA: 0x00018219 File Offset: 0x00016419
		public unsafe int DaysPassedSinceDeath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealthData.NativeFieldInfoPtr_DaysPassedSinceDeath);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealthData.NativeFieldInfoPtr_DaysPassedSinceDeath)) = value;
			}
		}

		// Token: 0x17000F1A RID: 3866
		// (get) Token: 0x06002F5C RID: 12124 RVA: 0x00118510 File Offset: 0x00116710
		// (set) Token: 0x06002F5D RID: 12125 RVA: 0x00018234 File Offset: 0x00016434
		public unsafe int HoursSinceAttackedByPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealthData.NativeFieldInfoPtr_HoursSinceAttackedByPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealthData.NativeFieldInfoPtr_HoursSinceAttackedByPlayer)) = value;
			}
		}

		// Token: 0x04002009 RID: 8201
		private static readonly IntPtr NativeFieldInfoPtr_Health;

		// Token: 0x0400200A RID: 8202
		private static readonly IntPtr NativeFieldInfoPtr_IsDead;

		// Token: 0x0400200B RID: 8203
		private static readonly IntPtr NativeFieldInfoPtr_DaysPassedSinceDeath;

		// Token: 0x0400200C RID: 8204
		private static readonly IntPtr NativeFieldInfoPtr_HoursSinceAttackedByPlayer;

		// Token: 0x0400200D RID: 8205
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_Int32_Int32_0;
	}
}
