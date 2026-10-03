using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000274 RID: 628
	[Serializable]
	public class TimeData : SaveData
	{
		// Token: 0x06003166 RID: 12646 RVA: 0x0011E61C File Offset: 0x0011C81C
		// Note: this type is marked as 'beforefieldinit'.
		static TimeData()
		{
			Il2CppClassPointerStore<TimeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "TimeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeData>.NativeClassPtr);
			TimeData.NativeFieldInfoPtr_TimeOfDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeData>.NativeClassPtr, "TimeOfDay");
			TimeData.NativeFieldInfoPtr_ElapsedDays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeData>.NativeClassPtr, "ElapsedDays");
			TimeData.NativeFieldInfoPtr_Playtime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeData>.NativeClassPtr, "Playtime");
			TimeData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeData>.NativeClassPtr, 100669474);
		}

		// Token: 0x06003167 RID: 12647 RVA: 0x0011E69C File Offset: 0x0011C89C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 135487, RefRangeEnd = 135488, XrefRangeStart = 135486, XrefRangeEnd = 135487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeData(int timeOfDay, int elapsedDays, int playtime) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref timeOfDay;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedDays;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playtime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003168 RID: 12648 RVA: 0x000197F9 File Offset: 0x000179F9
		public TimeData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FC8 RID: 4040
		// (get) Token: 0x06003169 RID: 12649 RVA: 0x0011E700 File Offset: 0x0011C900
		// (set) Token: 0x0600316A RID: 12650 RVA: 0x00019802 File Offset: 0x00017A02
		public unsafe int TimeOfDay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeData.NativeFieldInfoPtr_TimeOfDay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeData.NativeFieldInfoPtr_TimeOfDay)) = value;
			}
		}

		// Token: 0x17000FC9 RID: 4041
		// (get) Token: 0x0600316B RID: 12651 RVA: 0x0011E728 File Offset: 0x0011C928
		// (set) Token: 0x0600316C RID: 12652 RVA: 0x0001981D File Offset: 0x00017A1D
		public unsafe int ElapsedDays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeData.NativeFieldInfoPtr_ElapsedDays);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeData.NativeFieldInfoPtr_ElapsedDays)) = value;
			}
		}

		// Token: 0x17000FCA RID: 4042
		// (get) Token: 0x0600316D RID: 12653 RVA: 0x0011E750 File Offset: 0x0011C950
		// (set) Token: 0x0600316E RID: 12654 RVA: 0x00019838 File Offset: 0x00017A38
		public unsafe int Playtime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeData.NativeFieldInfoPtr_Playtime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeData.NativeFieldInfoPtr_Playtime)) = value;
			}
		}

		// Token: 0x040020FA RID: 8442
		private static readonly IntPtr NativeFieldInfoPtr_TimeOfDay;

		// Token: 0x040020FB RID: 8443
		private static readonly IntPtr NativeFieldInfoPtr_ElapsedDays;

		// Token: 0x040020FC RID: 8444
		private static readonly IntPtr NativeFieldInfoPtr_Playtime;

		// Token: 0x040020FD RID: 8445
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;
	}
}
