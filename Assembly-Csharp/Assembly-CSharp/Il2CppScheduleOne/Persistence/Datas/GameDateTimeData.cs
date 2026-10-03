using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.GameTime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000208 RID: 520
	[Serializable]
	public class GameDateTimeData : SaveData
	{
		// Token: 0x06002DFD RID: 11773 RVA: 0x00114844 File Offset: 0x00112A44
		// Note: this type is marked as 'beforefieldinit'.
		static GameDateTimeData()
		{
			Il2CppClassPointerStore<GameDateTimeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "GameDateTimeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDateTimeData>.NativeClassPtr);
			GameDateTimeData.NativeFieldInfoPtr_ElapsedDays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDateTimeData>.NativeClassPtr, "ElapsedDays");
			GameDateTimeData.NativeFieldInfoPtr_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDateTimeData>.NativeClassPtr, "Time");
			GameDateTimeData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDateTimeData>.NativeClassPtr, 100669335);
			GameDateTimeData.NativeMethodInfoPtr__ctor_Public_Void_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDateTimeData>.NativeClassPtr, 100669336);
		}

		// Token: 0x06002DFE RID: 11774 RVA: 0x001148C4 File Offset: 0x00112AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134592, XrefRangeEnd = 134593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameDateTimeData(int _elapsedDays, int _time) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameDateTimeData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _elapsedDays;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDateTimeData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DFF RID: 11775 RVA: 0x0011491C File Offset: 0x00112B1C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 134594, RefRangeEnd = 134598, XrefRangeStart = 134593, XrefRangeEnd = 134594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameDateTimeData(GameDateTime gameDateTime) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameDateTimeData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gameDateTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDateTimeData.NativeMethodInfoPtr__ctor_Public_Void_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E00 RID: 11776 RVA: 0x00017497 File Offset: 0x00015697
		public GameDateTimeData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EBE RID: 3774
		// (get) Token: 0x06002E01 RID: 11777 RVA: 0x00114964 File Offset: 0x00112B64
		// (set) Token: 0x06002E02 RID: 11778 RVA: 0x000174A0 File Offset: 0x000156A0
		public unsafe int ElapsedDays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDateTimeData.NativeFieldInfoPtr_ElapsedDays);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDateTimeData.NativeFieldInfoPtr_ElapsedDays)) = value;
			}
		}

		// Token: 0x17000EBF RID: 3775
		// (get) Token: 0x06002E03 RID: 11779 RVA: 0x0011498C File Offset: 0x00112B8C
		// (set) Token: 0x06002E04 RID: 11780 RVA: 0x000174BB File Offset: 0x000156BB
		public unsafe int Time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDateTimeData.NativeFieldInfoPtr_Time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDateTimeData.NativeFieldInfoPtr_Time)) = value;
			}
		}

		// Token: 0x04001F72 RID: 8050
		private static readonly IntPtr NativeFieldInfoPtr_ElapsedDays;

		// Token: 0x04001F73 RID: 8051
		private static readonly IntPtr NativeFieldInfoPtr_Time;

		// Token: 0x04001F74 RID: 8052
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x04001F75 RID: 8053
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameDateTime_0;
	}
}
