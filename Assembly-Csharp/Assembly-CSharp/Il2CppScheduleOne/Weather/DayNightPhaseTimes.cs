using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Weather
{
	// Token: 0x020006D2 RID: 1746
	[Serializable]
	[StructLayout(2)]
	public struct DayNightPhaseTimes
	{
		// Token: 0x0600A7CF RID: 42959 RVA: 0x002C77CC File Offset: 0x002C59CC
		// Note: this type is marked as 'beforefieldinit'.
		static DayNightPhaseTimes()
		{
			Il2CppClassPointerStore<DayNightPhaseTimes>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Weather", "DayNightPhaseTimes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DayNightPhaseTimes>.NativeClassPtr);
			DayNightPhaseTimes.NativeFieldInfoPtr_MinDawnHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightPhaseTimes>.NativeClassPtr, "MinDawnHour");
			DayNightPhaseTimes.NativeFieldInfoPtr_SunRiseHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightPhaseTimes>.NativeClassPtr, "SunRiseHour");
			DayNightPhaseTimes.NativeFieldInfoPtr_MaxDawnHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightPhaseTimes>.NativeClassPtr, "MaxDawnHour");
			DayNightPhaseTimes.NativeFieldInfoPtr_MinDuskHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightPhaseTimes>.NativeClassPtr, "MinDuskHour");
			DayNightPhaseTimes.NativeFieldInfoPtr_SunSetHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightPhaseTimes>.NativeClassPtr, "SunSetHour");
			DayNightPhaseTimes.NativeFieldInfoPtr_MaxDuskHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightPhaseTimes>.NativeClassPtr, "MaxDuskHour");
		}

		// Token: 0x0600A7D0 RID: 42960 RVA: 0x0004C507 File Offset: 0x0004A707
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DayNightPhaseTimes>.NativeClassPtr, ref this));
		}

		// Token: 0x04007401 RID: 29697
		private static readonly IntPtr NativeFieldInfoPtr_MinDawnHour;

		// Token: 0x04007402 RID: 29698
		private static readonly IntPtr NativeFieldInfoPtr_SunRiseHour;

		// Token: 0x04007403 RID: 29699
		private static readonly IntPtr NativeFieldInfoPtr_MaxDawnHour;

		// Token: 0x04007404 RID: 29700
		private static readonly IntPtr NativeFieldInfoPtr_MinDuskHour;

		// Token: 0x04007405 RID: 29701
		private static readonly IntPtr NativeFieldInfoPtr_SunSetHour;

		// Token: 0x04007406 RID: 29702
		private static readonly IntPtr NativeFieldInfoPtr_MaxDuskHour;

		// Token: 0x04007407 RID: 29703
		[FieldOffset(0)]
		public int MinDawnHour;

		// Token: 0x04007408 RID: 29704
		[FieldOffset(4)]
		public int SunRiseHour;

		// Token: 0x04007409 RID: 29705
		[FieldOffset(8)]
		public int MaxDawnHour;

		// Token: 0x0400740A RID: 29706
		[FieldOffset(12)]
		public int MinDuskHour;

		// Token: 0x0400740B RID: 29707
		[FieldOffset(16)]
		public int SunSetHour;

		// Token: 0x0400740C RID: 29708
		[FieldOffset(20)]
		public int MaxDuskHour;
	}
}
