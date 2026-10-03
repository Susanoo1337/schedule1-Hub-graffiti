using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Map;

namespace Il2CppScheduleOne.Cartel
{
	// Token: 0x02000443 RID: 1091
	public class CartelCustomerDeal : CartelActivity
	{
		// Token: 0x060062AB RID: 25259 RVA: 0x001D0F78 File Offset: 0x001CF178
		// Note: this type is marked as 'beforefieldinit'.
		static CartelCustomerDeal()
		{
			Il2CppClassPointerStore<CartelCustomerDeal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Cartel", "CartelCustomerDeal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CartelCustomerDeal>.NativeClassPtr);
			CartelCustomerDeal.NativeFieldInfoPtr_TIMEOUT_MINUTES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelCustomerDeal>.NativeClassPtr, "TIMEOUT_MINUTES");
			CartelCustomerDeal.NativeFieldInfoPtr_dealer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelCustomerDeal>.NativeClassPtr, "dealer");
			CartelCustomerDeal.NativeMethodInfoPtr_IsRegionValidForActivity_Public_Virtual_Boolean_EMapRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelCustomerDeal>.NativeClassPtr, 100676247);
			CartelCustomerDeal.NativeMethodInfoPtr_Activate_Public_Virtual_Void_EMapRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelCustomerDeal>.NativeClassPtr, 100676248);
			CartelCustomerDeal.NativeMethodInfoPtr_MinPassed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelCustomerDeal>.NativeClassPtr, 100676249);
			CartelCustomerDeal.NativeMethodInfoPtr_Deactivate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelCustomerDeal>.NativeClassPtr, 100676250);
			CartelCustomerDeal.NativeMethodInfoPtr_DealerUnconscious_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelCustomerDeal>.NativeClassPtr, 100676251);
			CartelCustomerDeal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelCustomerDeal>.NativeClassPtr, 100676252);
		}

		// Token: 0x060062AC RID: 25260 RVA: 0x001D1048 File Offset: 0x001CF248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208184, XrefRangeEnd = 208203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsRegionValidForActivity(EMapRegion region)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref region;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartelCustomerDeal.NativeMethodInfoPtr_IsRegionValidForActivity_Public_Virtual_Boolean_EMapRegion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060062AD RID: 25261 RVA: 0x001D109C File Offset: 0x001CF29C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208203, XrefRangeEnd = 208236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Activate(EMapRegion region)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref region;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartelCustomerDeal.NativeMethodInfoPtr_Activate_Public_Virtual_Void_EMapRegion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062AE RID: 25262 RVA: 0x001D10E8 File Offset: 0x001CF2E8
		[CallerCount(0)]
		public unsafe override void MinPassed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartelCustomerDeal.NativeMethodInfoPtr_MinPassed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062AF RID: 25263 RVA: 0x001D1124 File Offset: 0x001CF324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208236, XrefRangeEnd = 208251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Deactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartelCustomerDeal.NativeMethodInfoPtr_Deactivate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062B0 RID: 25264 RVA: 0x001D1160 File Offset: 0x001CF360
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DealerUnconscious()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelCustomerDeal.NativeMethodInfoPtr_DealerUnconscious_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062B1 RID: 25265 RVA: 0x001D1194 File Offset: 0x001CF394
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CartelCustomerDeal() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CartelCustomerDeal>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelCustomerDeal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062B2 RID: 25266 RVA: 0x0002E9D8 File Offset: 0x0002CBD8
		public CartelCustomerDeal(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E53 RID: 7763
		// (get) Token: 0x060062B3 RID: 25267 RVA: 0x001D11D0 File Offset: 0x001CF3D0
		// (set) Token: 0x060062B4 RID: 25268 RVA: 0x0002E9E1 File Offset: 0x0002CBE1
		public unsafe static int TIMEOUT_MINUTES
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CartelCustomerDeal.NativeFieldInfoPtr_TIMEOUT_MINUTES, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CartelCustomerDeal.NativeFieldInfoPtr_TIMEOUT_MINUTES, (void*)(&value));
			}
		}

		// Token: 0x17001E54 RID: 7764
		// (get) Token: 0x060062B5 RID: 25269 RVA: 0x001D11EC File Offset: 0x001CF3EC
		// (set) Token: 0x060062B6 RID: 25270 RVA: 0x0002E9EF File Offset: 0x0002CBEF
		public unsafe CartelDealer dealer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelCustomerDeal.NativeFieldInfoPtr_dealer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CartelDealer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelCustomerDeal.NativeFieldInfoPtr_dealer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040043FF RID: 17407
		private static readonly IntPtr NativeFieldInfoPtr_TIMEOUT_MINUTES;

		// Token: 0x04004400 RID: 17408
		private static readonly IntPtr NativeFieldInfoPtr_dealer;

		// Token: 0x04004401 RID: 17409
		private static readonly IntPtr NativeMethodInfoPtr_IsRegionValidForActivity_Public_Virtual_Boolean_EMapRegion_0;

		// Token: 0x04004402 RID: 17410
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Virtual_Void_EMapRegion_0;

		// Token: 0x04004403 RID: 17411
		private static readonly IntPtr NativeMethodInfoPtr_MinPassed_Protected_Virtual_Void_0;

		// Token: 0x04004404 RID: 17412
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Protected_Virtual_Void_0;

		// Token: 0x04004405 RID: 17413
		private static readonly IntPtr NativeMethodInfoPtr_DealerUnconscious_Private_Void_0;

		// Token: 0x04004406 RID: 17414
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
