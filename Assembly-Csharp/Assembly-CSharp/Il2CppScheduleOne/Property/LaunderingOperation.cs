using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Property
{
	// Token: 0x02000164 RID: 356
	public class LaunderingOperation : Object
	{
		// Token: 0x06002308 RID: 8968 RVA: 0x000EEAEC File Offset: 0x000ECCEC
		// Note: this type is marked as 'beforefieldinit'.
		static LaunderingOperation()
		{
			Il2CppClassPointerStore<LaunderingOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property", "LaunderingOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LaunderingOperation>.NativeClassPtr);
			LaunderingOperation.NativeFieldInfoPtr_business = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingOperation>.NativeClassPtr, "business");
			LaunderingOperation.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingOperation>.NativeClassPtr, "amount");
			LaunderingOperation.NativeFieldInfoPtr_minutesSinceStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingOperation>.NativeClassPtr, "minutesSinceStarted");
			LaunderingOperation.NativeFieldInfoPtr_completionTime_Minutes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingOperation>.NativeClassPtr, "completionTime_Minutes");
			LaunderingOperation.NativeMethodInfoPtr__ctor_Public_Void_Business_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingOperation>.NativeClassPtr, 100667819);
		}

		// Token: 0x06002309 RID: 8969 RVA: 0x000EEB80 File Offset: 0x000ECD80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112432, XrefRangeEnd = 112434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LaunderingOperation(Business _business, float _amount, int _minutesSinceStarted) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LaunderingOperation>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_business);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _minutesSinceStarted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingOperation.NativeMethodInfoPtr__ctor_Public_Void_Business_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600230A RID: 8970 RVA: 0x000129E5 File Offset: 0x00010BE5
		public LaunderingOperation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x0600230B RID: 8971 RVA: 0x000EEBE8 File Offset: 0x000ECDE8
		// (set) Token: 0x0600230C RID: 8972 RVA: 0x000129EE File Offset: 0x00010BEE
		public unsafe Business business
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingOperation.NativeFieldInfoPtr_business);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Business>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingOperation.NativeFieldInfoPtr_business), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x0600230D RID: 8973 RVA: 0x000EEC18 File Offset: 0x000ECE18
		// (set) Token: 0x0600230E RID: 8974 RVA: 0x00012A0D File Offset: 0x00010C0D
		public unsafe float amount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingOperation.NativeFieldInfoPtr_amount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingOperation.NativeFieldInfoPtr_amount)) = value;
			}
		}

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x0600230F RID: 8975 RVA: 0x000EEC40 File Offset: 0x000ECE40
		// (set) Token: 0x06002310 RID: 8976 RVA: 0x00012A28 File Offset: 0x00010C28
		public unsafe int minutesSinceStarted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingOperation.NativeFieldInfoPtr_minutesSinceStarted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingOperation.NativeFieldInfoPtr_minutesSinceStarted)) = value;
			}
		}

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x06002311 RID: 8977 RVA: 0x000EEC68 File Offset: 0x000ECE68
		// (set) Token: 0x06002312 RID: 8978 RVA: 0x00012A43 File Offset: 0x00010C43
		public unsafe int completionTime_Minutes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingOperation.NativeFieldInfoPtr_completionTime_Minutes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingOperation.NativeFieldInfoPtr_completionTime_Minutes)) = value;
			}
		}

		// Token: 0x0400182D RID: 6189
		private static readonly IntPtr NativeFieldInfoPtr_business;

		// Token: 0x0400182E RID: 6190
		private static readonly IntPtr NativeFieldInfoPtr_amount;

		// Token: 0x0400182F RID: 6191
		private static readonly IntPtr NativeFieldInfoPtr_minutesSinceStarted;

		// Token: 0x04001830 RID: 6192
		private static readonly IntPtr NativeFieldInfoPtr_completionTime_Minutes;

		// Token: 0x04001831 RID: 6193
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Business_Single_Int32_0;
	}
}
