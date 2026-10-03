using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.GameTime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Cartel
{
	// Token: 0x0200044B RID: 1099
	[Serializable]
	public class CartelDealInfo : Object
	{
		// Token: 0x06006379 RID: 25465 RVA: 0x001D3F28 File Offset: 0x001D2128
		// Note: this type is marked as 'beforefieldinit'.
		static CartelDealInfo()
		{
			Il2CppClassPointerStore<CartelDealInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Cartel", "CartelDealInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CartelDealInfo>.NativeClassPtr);
			CartelDealInfo.NativeFieldInfoPtr_RequestedProductID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelDealInfo>.NativeClassPtr, "RequestedProductID");
			CartelDealInfo.NativeFieldInfoPtr_RequestedProductQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelDealInfo>.NativeClassPtr, "RequestedProductQuantity");
			CartelDealInfo.NativeFieldInfoPtr_PaymentAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelDealInfo>.NativeClassPtr, "PaymentAmount");
			CartelDealInfo.NativeFieldInfoPtr_DueTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelDealInfo>.NativeClassPtr, "DueTime");
			CartelDealInfo.NativeFieldInfoPtr_Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelDealInfo>.NativeClassPtr, "Status");
			CartelDealInfo.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_GameDateTime_EStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealInfo>.NativeClassPtr, 100676367);
			CartelDealInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealInfo>.NativeClassPtr, 100676368);
			CartelDealInfo.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealInfo>.NativeClassPtr, 100676369);
		}

		// Token: 0x0600637A RID: 25466 RVA: 0x001D3FF8 File Offset: 0x001D21F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209453, XrefRangeEnd = 209455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CartelDealInfo(string requestedProductID, int requestedProductQuantity, int payment, GameDateTime dueTime, CartelDealInfo.EStatus status) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CartelDealInfo>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(requestedProductID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requestedProductQuantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref payment;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dueTime;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref status;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealInfo.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_GameDateTime_EStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600637B RID: 25467 RVA: 0x001D407C File Offset: 0x001D227C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 209459, RefRangeEnd = 209460, XrefRangeStart = 209455, XrefRangeEnd = 209459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CartelDealInfo() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CartelDealInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600637C RID: 25468 RVA: 0x001D40B8 File Offset: 0x001D22B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209460, XrefRangeEnd = 209465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealInfo.NativeMethodInfoPtr_IsValid_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600637D RID: 25469 RVA: 0x0002EE6F File Offset: 0x0002D06F
		public CartelDealInfo(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E8C RID: 7820
		// (get) Token: 0x0600637E RID: 25470 RVA: 0x001D40F4 File Offset: 0x001D22F4
		// (set) Token: 0x0600637F RID: 25471 RVA: 0x0002EE78 File Offset: 0x0002D078
		public unsafe string RequestedProductID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealInfo.NativeFieldInfoPtr_RequestedProductID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealInfo.NativeFieldInfoPtr_RequestedProductID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001E8D RID: 7821
		// (get) Token: 0x06006380 RID: 25472 RVA: 0x001D411C File Offset: 0x001D231C
		// (set) Token: 0x06006381 RID: 25473 RVA: 0x0002EE97 File Offset: 0x0002D097
		public unsafe int RequestedProductQuantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealInfo.NativeFieldInfoPtr_RequestedProductQuantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealInfo.NativeFieldInfoPtr_RequestedProductQuantity)) = value;
			}
		}

		// Token: 0x17001E8E RID: 7822
		// (get) Token: 0x06006382 RID: 25474 RVA: 0x001D4144 File Offset: 0x001D2344
		// (set) Token: 0x06006383 RID: 25475 RVA: 0x0002EEB2 File Offset: 0x0002D0B2
		public unsafe int PaymentAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealInfo.NativeFieldInfoPtr_PaymentAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealInfo.NativeFieldInfoPtr_PaymentAmount)) = value;
			}
		}

		// Token: 0x17001E8F RID: 7823
		// (get) Token: 0x06006384 RID: 25476 RVA: 0x001D416C File Offset: 0x001D236C
		// (set) Token: 0x06006385 RID: 25477 RVA: 0x0002EECD File Offset: 0x0002D0CD
		public unsafe GameDateTime DueTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealInfo.NativeFieldInfoPtr_DueTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealInfo.NativeFieldInfoPtr_DueTime)) = value;
			}
		}

		// Token: 0x17001E90 RID: 7824
		// (get) Token: 0x06006386 RID: 25478 RVA: 0x001D4194 File Offset: 0x001D2394
		// (set) Token: 0x06006387 RID: 25479 RVA: 0x0002EEE8 File Offset: 0x0002D0E8
		public unsafe CartelDealInfo.EStatus Status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealInfo.NativeFieldInfoPtr_Status);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealInfo.NativeFieldInfoPtr_Status)) = value;
			}
		}

		// Token: 0x04004492 RID: 17554
		private static readonly IntPtr NativeFieldInfoPtr_RequestedProductID;

		// Token: 0x04004493 RID: 17555
		private static readonly IntPtr NativeFieldInfoPtr_RequestedProductQuantity;

		// Token: 0x04004494 RID: 17556
		private static readonly IntPtr NativeFieldInfoPtr_PaymentAmount;

		// Token: 0x04004495 RID: 17557
		private static readonly IntPtr NativeFieldInfoPtr_DueTime;

		// Token: 0x04004496 RID: 17558
		private static readonly IntPtr NativeFieldInfoPtr_Status;

		// Token: 0x04004497 RID: 17559
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_GameDateTime_EStatus_0;

		// Token: 0x04004498 RID: 17560
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004499 RID: 17561
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;

		// Token: 0x02000B3B RID: 2875
		[OriginalName("Assembly-CSharp.dll", "", "EStatus")]
		public enum EStatus
		{
			// Token: 0x04009CB5 RID: 40117
			Pending,
			// Token: 0x04009CB6 RID: 40118
			Overdue
		}
	}
}
