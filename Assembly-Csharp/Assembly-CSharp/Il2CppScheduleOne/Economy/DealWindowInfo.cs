using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x02000395 RID: 917
	[StructLayout(2)]
	public struct DealWindowInfo
	{
		// Token: 0x0600535A RID: 21338 RVA: 0x0019BD78 File Offset: 0x00199F78
		// Note: this type is marked as 'beforefieldinit'.
		static DealWindowInfo()
		{
			Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "DealWindowInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr);
			DealWindowInfo.NativeFieldInfoPtr_WINDOW_DURATION_MINS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, "WINDOW_DURATION_MINS");
			DealWindowInfo.NativeFieldInfoPtr_WINDOW_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, "WINDOW_COUNT");
			DealWindowInfo.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, "StartTime");
			DealWindowInfo.NativeFieldInfoPtr_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, "EndTime");
			DealWindowInfo.NativeFieldInfoPtr_Morning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, "Morning");
			DealWindowInfo.NativeFieldInfoPtr_Afternoon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, "Afternoon");
			DealWindowInfo.NativeFieldInfoPtr_Night = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, "Night");
			DealWindowInfo.NativeFieldInfoPtr_LateNight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, "LateNight");
			DealWindowInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, 100674244);
			DealWindowInfo.NativeMethodInfoPtr_GetWindowInfo_Public_Static_DealWindowInfo_EDealWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, 100674245);
			DealWindowInfo.NativeMethodInfoPtr_GetWindow_Public_Static_EDealWindow_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, 100674246);
		}

		// Token: 0x0600535B RID: 21339 RVA: 0x0019BE84 File Offset: 0x0019A084
		[CallerCount(494)]
		[CachedScanResults(RefRangeStart = 60743, RefRangeEnd = 61237, XrefRangeStart = 60743, XrefRangeEnd = 61237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DealWindowInfo(int startTime, int endTime)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref startTime;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600535C RID: 21340 RVA: 0x0019BEC4 File Offset: 0x0019A0C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 186472, RefRangeEnd = 186475, XrefRangeStart = 186468, XrefRangeEnd = 186472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DealWindowInfo GetWindowInfo(EDealWindow window)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref window;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowInfo.NativeMethodInfoPtr_GetWindowInfo_Public_Static_DealWindowInfo_EDealWindow_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600535D RID: 21341 RVA: 0x0019BF04 File Offset: 0x0019A104
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 186481, RefRangeEnd = 186485, XrefRangeStart = 186475, XrefRangeEnd = 186481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EDealWindow GetWindow(int time)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowInfo.NativeMethodInfoPtr_GetWindow_Public_Static_EDealWindow_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600535E RID: 21342 RVA: 0x0002774B File Offset: 0x0002594B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x170019DA RID: 6618
		// (get) Token: 0x0600535F RID: 21343 RVA: 0x0019BF44 File Offset: 0x0019A144
		// (set) Token: 0x06005360 RID: 21344 RVA: 0x0002775D File Offset: 0x0002595D
		public unsafe static int WINDOW_DURATION_MINS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DealWindowInfo.NativeFieldInfoPtr_WINDOW_DURATION_MINS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DealWindowInfo.NativeFieldInfoPtr_WINDOW_DURATION_MINS, (void*)(&value));
			}
		}

		// Token: 0x170019DB RID: 6619
		// (get) Token: 0x06005361 RID: 21345 RVA: 0x0019BF60 File Offset: 0x0019A160
		// (set) Token: 0x06005362 RID: 21346 RVA: 0x0002776B File Offset: 0x0002596B
		public unsafe static int WINDOW_COUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DealWindowInfo.NativeFieldInfoPtr_WINDOW_COUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DealWindowInfo.NativeFieldInfoPtr_WINDOW_COUNT, (void*)(&value));
			}
		}

		// Token: 0x170019DC RID: 6620
		// (get) Token: 0x06005363 RID: 21347 RVA: 0x0019BF7C File Offset: 0x0019A17C
		// (set) Token: 0x06005364 RID: 21348 RVA: 0x00027779 File Offset: 0x00025979
		public unsafe static DealWindowInfo Morning
		{
			get
			{
				DealWindowInfo result;
				IL2CPP.il2cpp_field_static_get_value(DealWindowInfo.NativeFieldInfoPtr_Morning, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DealWindowInfo.NativeFieldInfoPtr_Morning, (void*)(&value));
			}
		}

		// Token: 0x170019DD RID: 6621
		// (get) Token: 0x06005365 RID: 21349 RVA: 0x0019BF98 File Offset: 0x0019A198
		// (set) Token: 0x06005366 RID: 21350 RVA: 0x00027787 File Offset: 0x00025987
		public unsafe static DealWindowInfo Afternoon
		{
			get
			{
				DealWindowInfo result;
				IL2CPP.il2cpp_field_static_get_value(DealWindowInfo.NativeFieldInfoPtr_Afternoon, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DealWindowInfo.NativeFieldInfoPtr_Afternoon, (void*)(&value));
			}
		}

		// Token: 0x170019DE RID: 6622
		// (get) Token: 0x06005367 RID: 21351 RVA: 0x0019BFB4 File Offset: 0x0019A1B4
		// (set) Token: 0x06005368 RID: 21352 RVA: 0x00027795 File Offset: 0x00025995
		public unsafe static DealWindowInfo Night
		{
			get
			{
				DealWindowInfo result;
				IL2CPP.il2cpp_field_static_get_value(DealWindowInfo.NativeFieldInfoPtr_Night, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DealWindowInfo.NativeFieldInfoPtr_Night, (void*)(&value));
			}
		}

		// Token: 0x170019DF RID: 6623
		// (get) Token: 0x06005369 RID: 21353 RVA: 0x0019BFD0 File Offset: 0x0019A1D0
		// (set) Token: 0x0600536A RID: 21354 RVA: 0x000277A3 File Offset: 0x000259A3
		public unsafe static DealWindowInfo LateNight
		{
			get
			{
				DealWindowInfo result;
				IL2CPP.il2cpp_field_static_get_value(DealWindowInfo.NativeFieldInfoPtr_LateNight, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DealWindowInfo.NativeFieldInfoPtr_LateNight, (void*)(&value));
			}
		}

		// Token: 0x04003960 RID: 14688
		private static readonly IntPtr NativeFieldInfoPtr_WINDOW_DURATION_MINS;

		// Token: 0x04003961 RID: 14689
		private static readonly IntPtr NativeFieldInfoPtr_WINDOW_COUNT;

		// Token: 0x04003962 RID: 14690
		private static readonly IntPtr NativeFieldInfoPtr_StartTime;

		// Token: 0x04003963 RID: 14691
		private static readonly IntPtr NativeFieldInfoPtr_EndTime;

		// Token: 0x04003964 RID: 14692
		private static readonly IntPtr NativeFieldInfoPtr_Morning;

		// Token: 0x04003965 RID: 14693
		private static readonly IntPtr NativeFieldInfoPtr_Afternoon;

		// Token: 0x04003966 RID: 14694
		private static readonly IntPtr NativeFieldInfoPtr_Night;

		// Token: 0x04003967 RID: 14695
		private static readonly IntPtr NativeFieldInfoPtr_LateNight;

		// Token: 0x04003968 RID: 14696
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x04003969 RID: 14697
		private static readonly IntPtr NativeMethodInfoPtr_GetWindowInfo_Public_Static_DealWindowInfo_EDealWindow_0;

		// Token: 0x0400396A RID: 14698
		private static readonly IntPtr NativeMethodInfoPtr_GetWindow_Public_Static_EDealWindow_Int32_0;

		// Token: 0x0400396B RID: 14699
		[FieldOffset(0)]
		public int StartTime;

		// Token: 0x0400396C RID: 14700
		[FieldOffset(4)]
		public int EndTime;
	}
}
