using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.UI.Phone;

namespace Il2CppScheduleOne.NPCs.Framework
{
	// Token: 0x02000605 RID: 1541
	[Serializable]
	public class SupplierNPCData : NPCData
	{
		// Token: 0x06009608 RID: 38408 RVA: 0x00286AC0 File Offset: 0x00284CC0
		// Note: this type is marked as 'beforefieldinit'.
		static SupplierNPCData()
		{
			Il2CppClassPointerStore<SupplierNPCData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Framework", "SupplierNPCData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SupplierNPCData>.NativeClassPtr);
			SupplierNPCData.NativeFieldInfoPtr_MinimumDeaddropOrderLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierNPCData>.NativeClassPtr, "MinimumDeaddropOrderLimit");
			SupplierNPCData.NativeFieldInfoPtr_MaximumDeaddropOrderLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierNPCData>.NativeClassPtr, "MaximumDeaddropOrderLimit");
			SupplierNPCData.NativeFieldInfoPtr_DeliveryShopListings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierNPCData>.NativeClassPtr, "DeliveryShopListings");
			SupplierNPCData.NativeFieldInfoPtr_SupplierRecommendMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierNPCData>.NativeClassPtr, "SupplierRecommendMessage");
			SupplierNPCData.NativeFieldInfoPtr_SupplierUnlockHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierNPCData>.NativeClassPtr, "SupplierUnlockHint");
			SupplierNPCData.NativeMethodInfoPtr_GetDeepCopy_Public_Virtual_NPCData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierNPCData>.NativeClassPtr, 100682867);
			SupplierNPCData.NativeMethodInfoPtr_PopulateSupplierData_Private_Void_SupplierNPCData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierNPCData>.NativeClassPtr, 100682868);
			SupplierNPCData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierNPCData>.NativeClassPtr, 100682869);
		}

		// Token: 0x06009609 RID: 38409 RVA: 0x00286B90 File Offset: 0x00284D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272819, XrefRangeEnd = 272833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override NPCData GetDeepCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SupplierNPCData.NativeMethodInfoPtr_GetDeepCopy_Public_Virtual_NPCData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCData>(intPtr3) : null;
		}

		// Token: 0x0600960A RID: 38410 RVA: 0x00286BDC File Offset: 0x00284DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272833, XrefRangeEnd = 272847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopulateSupplierData(SupplierNPCData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierNPCData.NativeMethodInfoPtr_PopulateSupplierData_Private_Void_SupplierNPCData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600960B RID: 38411 RVA: 0x00286C20 File Offset: 0x00284E20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 272856, RefRangeEnd = 272858, XrefRangeStart = 272847, XrefRangeEnd = 272856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SupplierNPCData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SupplierNPCData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierNPCData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600960C RID: 38412 RVA: 0x0004638A File Offset: 0x0004458A
		public SupplierNPCData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E50 RID: 11856
		// (get) Token: 0x0600960D RID: 38413 RVA: 0x00286C5C File Offset: 0x00284E5C
		// (set) Token: 0x0600960E RID: 38414 RVA: 0x00046393 File Offset: 0x00044593
		public unsafe float MinimumDeaddropOrderLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierNPCData.NativeFieldInfoPtr_MinimumDeaddropOrderLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierNPCData.NativeFieldInfoPtr_MinimumDeaddropOrderLimit)) = value;
			}
		}

		// Token: 0x17002E51 RID: 11857
		// (get) Token: 0x0600960F RID: 38415 RVA: 0x00286C84 File Offset: 0x00284E84
		// (set) Token: 0x06009610 RID: 38416 RVA: 0x000463AE File Offset: 0x000445AE
		public unsafe float MaximumDeaddropOrderLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierNPCData.NativeFieldInfoPtr_MaximumDeaddropOrderLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierNPCData.NativeFieldInfoPtr_MaximumDeaddropOrderLimit)) = value;
			}
		}

		// Token: 0x17002E52 RID: 11858
		// (get) Token: 0x06009611 RID: 38417 RVA: 0x00286CAC File Offset: 0x00284EAC
		// (set) Token: 0x06009612 RID: 38418 RVA: 0x000463C9 File Offset: 0x000445C9
		public unsafe Il2CppReferenceArray<PhoneShopInterface.Listing> DeliveryShopListings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierNPCData.NativeFieldInfoPtr_DeliveryShopListings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PhoneShopInterface.Listing>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierNPCData.NativeFieldInfoPtr_DeliveryShopListings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E53 RID: 11859
		// (get) Token: 0x06009613 RID: 38419 RVA: 0x00286CDC File Offset: 0x00284EDC
		// (set) Token: 0x06009614 RID: 38420 RVA: 0x000463E8 File Offset: 0x000445E8
		public unsafe string SupplierRecommendMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierNPCData.NativeFieldInfoPtr_SupplierRecommendMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierNPCData.NativeFieldInfoPtr_SupplierRecommendMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002E54 RID: 11860
		// (get) Token: 0x06009615 RID: 38421 RVA: 0x00286D04 File Offset: 0x00284F04
		// (set) Token: 0x06009616 RID: 38422 RVA: 0x00046407 File Offset: 0x00044607
		public unsafe string SupplierUnlockHint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierNPCData.NativeFieldInfoPtr_SupplierUnlockHint);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierNPCData.NativeFieldInfoPtr_SupplierUnlockHint), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04006736 RID: 26422
		private static readonly IntPtr NativeFieldInfoPtr_MinimumDeaddropOrderLimit;

		// Token: 0x04006737 RID: 26423
		private static readonly IntPtr NativeFieldInfoPtr_MaximumDeaddropOrderLimit;

		// Token: 0x04006738 RID: 26424
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryShopListings;

		// Token: 0x04006739 RID: 26425
		private static readonly IntPtr NativeFieldInfoPtr_SupplierRecommendMessage;

		// Token: 0x0400673A RID: 26426
		private static readonly IntPtr NativeFieldInfoPtr_SupplierUnlockHint;

		// Token: 0x0400673B RID: 26427
		private static readonly IntPtr NativeMethodInfoPtr_GetDeepCopy_Public_Virtual_NPCData_0;

		// Token: 0x0400673C RID: 26428
		private static readonly IntPtr NativeMethodInfoPtr_PopulateSupplierData_Private_Void_SupplierNPCData_0;

		// Token: 0x0400673D RID: 26429
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
