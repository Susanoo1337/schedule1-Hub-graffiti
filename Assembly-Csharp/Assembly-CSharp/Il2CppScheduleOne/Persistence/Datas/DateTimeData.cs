using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000203 RID: 515
	[Serializable]
	public class DateTimeData : SaveData
	{
		// Token: 0x06002DC0 RID: 11712 RVA: 0x00113C48 File Offset: 0x00111E48
		// Note: this type is marked as 'beforefieldinit'.
		static DateTimeData()
		{
			Il2CppClassPointerStore<DateTimeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "DateTimeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTimeData>.NativeClassPtr);
			DateTimeData.NativeFieldInfoPtr_Year = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeData>.NativeClassPtr, "Year");
			DateTimeData.NativeFieldInfoPtr_Month = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeData>.NativeClassPtr, "Month");
			DateTimeData.NativeFieldInfoPtr_Day = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeData>.NativeClassPtr, "Day");
			DateTimeData.NativeFieldInfoPtr_Hour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeData>.NativeClassPtr, "Hour");
			DateTimeData.NativeFieldInfoPtr_Minute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeData>.NativeClassPtr, "Minute");
			DateTimeData.NativeFieldInfoPtr_Second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeData>.NativeClassPtr, "Second");
			DateTimeData.NativeMethodInfoPtr__ctor_Public_Void_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeData>.NativeClassPtr, 100669319);
			DateTimeData.NativeMethodInfoPtr_GetDateTime_Public_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeData>.NativeClassPtr, 100669320);
		}

		// Token: 0x06002DC1 RID: 11713 RVA: 0x00113D18 File Offset: 0x00111F18
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 134356, RefRangeEnd = 134362, XrefRangeStart = 134346, XrefRangeEnd = 134356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTimeData(DateTime date) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DateTimeData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref date;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeData.NativeMethodInfoPtr__ctor_Public_Void_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DC2 RID: 11714 RVA: 0x00113D60 File Offset: 0x00111F60
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 134363, RefRangeEnd = 134366, XrefRangeStart = 134362, XrefRangeEnd = 134363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime GetDateTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeData.NativeMethodInfoPtr_GetDateTime_Public_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002DC3 RID: 11715 RVA: 0x00017260 File Offset: 0x00015460
		public DateTimeData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EAC RID: 3756
		// (get) Token: 0x06002DC4 RID: 11716 RVA: 0x00113D9C File Offset: 0x00111F9C
		// (set) Token: 0x06002DC5 RID: 11717 RVA: 0x00017269 File Offset: 0x00015469
		public unsafe int Year
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Year);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Year)) = value;
			}
		}

		// Token: 0x17000EAD RID: 3757
		// (get) Token: 0x06002DC6 RID: 11718 RVA: 0x00113DC4 File Offset: 0x00111FC4
		// (set) Token: 0x06002DC7 RID: 11719 RVA: 0x00017284 File Offset: 0x00015484
		public unsafe int Month
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Month);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Month)) = value;
			}
		}

		// Token: 0x17000EAE RID: 3758
		// (get) Token: 0x06002DC8 RID: 11720 RVA: 0x00113DEC File Offset: 0x00111FEC
		// (set) Token: 0x06002DC9 RID: 11721 RVA: 0x0001729F File Offset: 0x0001549F
		public unsafe int Day
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Day);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Day)) = value;
			}
		}

		// Token: 0x17000EAF RID: 3759
		// (get) Token: 0x06002DCA RID: 11722 RVA: 0x00113E14 File Offset: 0x00112014
		// (set) Token: 0x06002DCB RID: 11723 RVA: 0x000172BA File Offset: 0x000154BA
		public unsafe int Hour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Hour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Hour)) = value;
			}
		}

		// Token: 0x17000EB0 RID: 3760
		// (get) Token: 0x06002DCC RID: 11724 RVA: 0x00113E3C File Offset: 0x0011203C
		// (set) Token: 0x06002DCD RID: 11725 RVA: 0x000172D5 File Offset: 0x000154D5
		public unsafe int Minute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Minute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Minute)) = value;
			}
		}

		// Token: 0x17000EB1 RID: 3761
		// (get) Token: 0x06002DCE RID: 11726 RVA: 0x00113E64 File Offset: 0x00112064
		// (set) Token: 0x06002DCF RID: 11727 RVA: 0x000172F0 File Offset: 0x000154F0
		public unsafe int Second
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Second);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Second)) = value;
			}
		}

		// Token: 0x04001F51 RID: 8017
		private static readonly IntPtr NativeFieldInfoPtr_Year;

		// Token: 0x04001F52 RID: 8018
		private static readonly IntPtr NativeFieldInfoPtr_Month;

		// Token: 0x04001F53 RID: 8019
		private static readonly IntPtr NativeFieldInfoPtr_Day;

		// Token: 0x04001F54 RID: 8020
		private static readonly IntPtr NativeFieldInfoPtr_Hour;

		// Token: 0x04001F55 RID: 8021
		private static readonly IntPtr NativeFieldInfoPtr_Minute;

		// Token: 0x04001F56 RID: 8022
		private static readonly IntPtr NativeFieldInfoPtr_Second;

		// Token: 0x04001F57 RID: 8023
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DateTime_0;

		// Token: 0x04001F58 RID: 8024
		private static readonly IntPtr NativeMethodInfoPtr_GetDateTime_Public_DateTime_0;
	}
}
