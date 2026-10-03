using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.GameTime
{
	// Token: 0x0200010B RID: 267
	public class TimedCallback : Object
	{
		// Token: 0x060019C1 RID: 6593 RVA: 0x000CFCAC File Offset: 0x000CDEAC
		// Note: this type is marked as 'beforefieldinit'.
		static TimedCallback()
		{
			Il2CppClassPointerStore<TimedCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.GameTime", "TimedCallback");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimedCallback>.NativeClassPtr);
			TimedCallback.NativeFieldInfoPtr__remainingMinutes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedCallback>.NativeClassPtr, "_remainingMinutes");
			TimedCallback.NativeFieldInfoPtr__callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedCallback>.NativeClassPtr, "_callback");
			TimedCallback.NativeFieldInfoPtr__initialRemainingMinutes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedCallback>.NativeClassPtr, "_initialRemainingMinutes");
			TimedCallback.NativeMethodInfoPtr__ctor_Public_Void_Action_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedCallback>.NativeClassPtr, 100666719);
			TimedCallback.NativeMethodInfoPtr_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedCallback>.NativeClassPtr, 100666720);
			TimedCallback.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedCallback>.NativeClassPtr, 100666721);
			TimedCallback.NativeMethodInfoPtr_OnTimeSkip_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedCallback>.NativeClassPtr, 100666722);
			TimedCallback.NativeMethodInfoPtr_Tick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedCallback>.NativeClassPtr, 100666723);
			TimedCallback.NativeMethodInfoPtr_Execute_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedCallback>.NativeClassPtr, 100666724);
			TimedCallback.NativeMethodInfoPtr_Cleanup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedCallback>.NativeClassPtr, 100666725);
		}

		// Token: 0x060019C2 RID: 6594 RVA: 0x000CFDA4 File Offset: 0x000CDFA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 99338, RefRangeEnd = 99340, XrefRangeStart = 99295, XrefRangeEnd = 99338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimedCallback(Action callback, int durationMinutes, bool tickAtEndOfDay = true, bool tickOnTimeSkip = true) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimedCallback>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationMinutes;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tickAtEndOfDay;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tickOnTimeSkip;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimedCallback.NativeMethodInfoPtr__ctor_Public_Void_Action_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019C3 RID: 6595 RVA: 0x000CFE1C File Offset: 0x000CE01C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99381, RefRangeEnd = 99382, XrefRangeStart = 99340, XrefRangeEnd = 99381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimedCallback.NativeMethodInfoPtr_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019C4 RID: 6596 RVA: 0x000CFE50 File Offset: 0x000CE050
		[CallerCount(0)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimedCallback.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019C5 RID: 6597 RVA: 0x000CFE84 File Offset: 0x000CE084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99382, XrefRangeEnd = 99383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTimeSkip(int skippedMinutes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref skippedMinutes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimedCallback.NativeMethodInfoPtr_OnTimeSkip_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019C6 RID: 6598 RVA: 0x000CFEC4 File Offset: 0x000CE0C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99383, XrefRangeEnd = 99384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Tick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimedCallback.NativeMethodInfoPtr_Tick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019C7 RID: 6599 RVA: 0x000CFEF8 File Offset: 0x000CE0F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99384, XrefRangeEnd = 99385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimedCallback.NativeMethodInfoPtr_Execute_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019C8 RID: 6600 RVA: 0x000CFF2C File Offset: 0x000CE12C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 99425, RefRangeEnd = 99429, XrefRangeStart = 99385, XrefRangeEnd = 99425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimedCallback.NativeMethodInfoPtr_Cleanup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019C9 RID: 6601 RVA: 0x0000E269 File Offset: 0x0000C469
		public TimedCallback(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x060019CA RID: 6602 RVA: 0x000CFF60 File Offset: 0x000CE160
		// (set) Token: 0x060019CB RID: 6603 RVA: 0x0000E272 File Offset: 0x0000C472
		public unsafe int _remainingMinutes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedCallback.NativeFieldInfoPtr__remainingMinutes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedCallback.NativeFieldInfoPtr__remainingMinutes)) = value;
			}
		}

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x060019CC RID: 6604 RVA: 0x000CFF88 File Offset: 0x000CE188
		// (set) Token: 0x060019CD RID: 6605 RVA: 0x0000E28D File Offset: 0x0000C48D
		public unsafe Action _callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedCallback.NativeFieldInfoPtr__callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedCallback.NativeFieldInfoPtr__callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x060019CE RID: 6606 RVA: 0x000CFFB8 File Offset: 0x000CE1B8
		// (set) Token: 0x060019CF RID: 6607 RVA: 0x0000E2AC File Offset: 0x0000C4AC
		public unsafe int _initialRemainingMinutes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedCallback.NativeFieldInfoPtr__initialRemainingMinutes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedCallback.NativeFieldInfoPtr__initialRemainingMinutes)) = value;
			}
		}

		// Token: 0x040011CE RID: 4558
		private static readonly IntPtr NativeFieldInfoPtr__remainingMinutes;

		// Token: 0x040011CF RID: 4559
		private static readonly IntPtr NativeFieldInfoPtr__callback;

		// Token: 0x040011D0 RID: 4560
		private static readonly IntPtr NativeFieldInfoPtr__initialRemainingMinutes;

		// Token: 0x040011D1 RID: 4561
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Action_Int32_Boolean_Boolean_0;

		// Token: 0x040011D2 RID: 4562
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Public_Void_0;

		// Token: 0x040011D3 RID: 4563
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x040011D4 RID: 4564
		private static readonly IntPtr NativeMethodInfoPtr_OnTimeSkip_Private_Void_Int32_0;

		// Token: 0x040011D5 RID: 4565
		private static readonly IntPtr NativeMethodInfoPtr_Tick_Private_Void_0;

		// Token: 0x040011D6 RID: 4566
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Void_0;

		// Token: 0x040011D7 RID: 4567
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Private_Void_0;
	}
}
