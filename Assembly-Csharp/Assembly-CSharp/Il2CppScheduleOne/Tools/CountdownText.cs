using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004D9 RID: 1241
	public class CountdownText : MonoBehaviour
	{
		// Token: 0x06007169 RID: 29033 RVA: 0x00200310 File Offset: 0x001FE510
		// Note: this type is marked as 'beforefieldinit'.
		static CountdownText()
		{
			Il2CppClassPointerStore<CountdownText>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "CountdownText");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CountdownText>.NativeClassPtr);
			CountdownText.NativeFieldInfoPtr_TimeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, "TimeLabel");
			CountdownText.NativeFieldInfoPtr_Year = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, "Year");
			CountdownText.NativeFieldInfoPtr_Month = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, "Month");
			CountdownText.NativeFieldInfoPtr_Day = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, "Day");
			CountdownText.NativeFieldInfoPtr_Hour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, "Hour");
			CountdownText.NativeFieldInfoPtr_Minute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, "Minute");
			CountdownText.NativeFieldInfoPtr_Second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, "Second");
			CountdownText.NativeFieldInfoPtr_targetPDTDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, "targetPDTDate");
			CountdownText.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, 100677955);
			CountdownText.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, 100677956);
			CountdownText.NativeMethodInfoPtr_UpdateCountdown_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, 100677957);
			CountdownText.NativeMethodInfoPtr_FormatTime_Private_String_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, 100677958);
			CountdownText.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, 100677959);
		}

		// Token: 0x0600716A RID: 29034 RVA: 0x00200444 File Offset: 0x001FE644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225436, XrefRangeEnd = 225447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownText.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600716B RID: 29035 RVA: 0x00200478 File Offset: 0x001FE678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225447, XrefRangeEnd = 225448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownText.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600716C RID: 29036 RVA: 0x002004AC File Offset: 0x001FE6AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 225459, RefRangeEnd = 225460, XrefRangeStart = 225448, XrefRangeEnd = 225459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCountdown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownText.NativeMethodInfoPtr_UpdateCountdown_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600716D RID: 29037 RVA: 0x002004E0 File Offset: 0x001FE6E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225460, XrefRangeEnd = 225485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatTime(TimeSpan timeSpan)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref timeSpan;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownText.NativeMethodInfoPtr_FormatTime_Private_String_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600716E RID: 29038 RVA: 0x00200524 File Offset: 0x001FE724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225485, XrefRangeEnd = 225486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CountdownText() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CountdownText>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownText.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600716F RID: 29039 RVA: 0x00035F49 File Offset: 0x00034149
		public CountdownText(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700230E RID: 8974
		// (get) Token: 0x06007170 RID: 29040 RVA: 0x00200560 File Offset: 0x001FE760
		// (set) Token: 0x06007171 RID: 29041 RVA: 0x00035F52 File Offset: 0x00034152
		public unsafe TextMeshProUGUI TimeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_TimeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_TimeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700230F RID: 8975
		// (get) Token: 0x06007172 RID: 29042 RVA: 0x00200590 File Offset: 0x001FE790
		// (set) Token: 0x06007173 RID: 29043 RVA: 0x00035F71 File Offset: 0x00034171
		public unsafe int Year
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Year);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Year)) = value;
			}
		}

		// Token: 0x17002310 RID: 8976
		// (get) Token: 0x06007174 RID: 29044 RVA: 0x002005B8 File Offset: 0x001FE7B8
		// (set) Token: 0x06007175 RID: 29045 RVA: 0x00035F8C File Offset: 0x0003418C
		public unsafe int Month
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Month);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Month)) = value;
			}
		}

		// Token: 0x17002311 RID: 8977
		// (get) Token: 0x06007176 RID: 29046 RVA: 0x002005E0 File Offset: 0x001FE7E0
		// (set) Token: 0x06007177 RID: 29047 RVA: 0x00035FA7 File Offset: 0x000341A7
		public unsafe int Day
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Day);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Day)) = value;
			}
		}

		// Token: 0x17002312 RID: 8978
		// (get) Token: 0x06007178 RID: 29048 RVA: 0x00200608 File Offset: 0x001FE808
		// (set) Token: 0x06007179 RID: 29049 RVA: 0x00035FC2 File Offset: 0x000341C2
		public unsafe int Hour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Hour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Hour)) = value;
			}
		}

		// Token: 0x17002313 RID: 8979
		// (get) Token: 0x0600717A RID: 29050 RVA: 0x00200630 File Offset: 0x001FE830
		// (set) Token: 0x0600717B RID: 29051 RVA: 0x00035FDD File Offset: 0x000341DD
		public unsafe int Minute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Minute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Minute)) = value;
			}
		}

		// Token: 0x17002314 RID: 8980
		// (get) Token: 0x0600717C RID: 29052 RVA: 0x00200658 File Offset: 0x001FE858
		// (set) Token: 0x0600717D RID: 29053 RVA: 0x00035FF8 File Offset: 0x000341F8
		public unsafe int Second
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Second);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Second)) = value;
			}
		}

		// Token: 0x17002315 RID: 8981
		// (get) Token: 0x0600717E RID: 29054 RVA: 0x00200680 File Offset: 0x001FE880
		// (set) Token: 0x0600717F RID: 29055 RVA: 0x00036013 File Offset: 0x00034213
		public unsafe DateTime targetPDTDate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_targetPDTDate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_targetPDTDate)) = value;
			}
		}

		// Token: 0x04004D88 RID: 19848
		private static readonly IntPtr NativeFieldInfoPtr_TimeLabel;

		// Token: 0x04004D89 RID: 19849
		private static readonly IntPtr NativeFieldInfoPtr_Year;

		// Token: 0x04004D8A RID: 19850
		private static readonly IntPtr NativeFieldInfoPtr_Month;

		// Token: 0x04004D8B RID: 19851
		private static readonly IntPtr NativeFieldInfoPtr_Day;

		// Token: 0x04004D8C RID: 19852
		private static readonly IntPtr NativeFieldInfoPtr_Hour;

		// Token: 0x04004D8D RID: 19853
		private static readonly IntPtr NativeFieldInfoPtr_Minute;

		// Token: 0x04004D8E RID: 19854
		private static readonly IntPtr NativeFieldInfoPtr_Second;

		// Token: 0x04004D8F RID: 19855
		private static readonly IntPtr NativeFieldInfoPtr_targetPDTDate;

		// Token: 0x04004D90 RID: 19856
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004D91 RID: 19857
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004D92 RID: 19858
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCountdown_Private_Void_0;

		// Token: 0x04004D93 RID: 19859
		private static readonly IntPtr NativeMethodInfoPtr_FormatTime_Private_String_TimeSpan_0;

		// Token: 0x04004D94 RID: 19860
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
