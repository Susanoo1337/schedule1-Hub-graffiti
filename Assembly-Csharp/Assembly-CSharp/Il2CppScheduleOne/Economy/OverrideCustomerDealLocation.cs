using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x0200039C RID: 924
	public class OverrideCustomerDealLocation : MonoBehaviour
	{
		// Token: 0x0600538A RID: 21386 RVA: 0x0019C5AC File Offset: 0x0019A7AC
		// Note: this type is marked as 'beforefieldinit'.
		static OverrideCustomerDealLocation()
		{
			Il2CppClassPointerStore<OverrideCustomerDealLocation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "OverrideCustomerDealLocation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OverrideCustomerDealLocation>.NativeClassPtr);
			OverrideCustomerDealLocation.NativeFieldInfoPtr_Location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverrideCustomerDealLocation>.NativeClassPtr, "Location");
			OverrideCustomerDealLocation.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverrideCustomerDealLocation>.NativeClassPtr, 100674259);
			OverrideCustomerDealLocation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverrideCustomerDealLocation>.NativeClassPtr, 100674260);
		}

		// Token: 0x0600538B RID: 21387 RVA: 0x0019C618 File Offset: 0x0019A818
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverrideCustomerDealLocation.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600538C RID: 21388 RVA: 0x0019C64C File Offset: 0x0019A84C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OverrideCustomerDealLocation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverrideCustomerDealLocation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverrideCustomerDealLocation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600538D RID: 21389 RVA: 0x000278A1 File Offset: 0x00025AA1
		public OverrideCustomerDealLocation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170019E8 RID: 6632
		// (get) Token: 0x0600538E RID: 21390 RVA: 0x0019C688 File Offset: 0x0019A888
		// (set) Token: 0x0600538F RID: 21391 RVA: 0x000278AA File Offset: 0x00025AAA
		public unsafe DeliveryLocation Location
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverrideCustomerDealLocation.NativeFieldInfoPtr_Location);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryLocation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverrideCustomerDealLocation.NativeFieldInfoPtr_Location), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400398C RID: 14732
		private static readonly IntPtr NativeFieldInfoPtr_Location;

		// Token: 0x0400398D RID: 14733
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400398E RID: 14734
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
