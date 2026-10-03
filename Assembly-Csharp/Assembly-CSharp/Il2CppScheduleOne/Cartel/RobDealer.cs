using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.Map;
using Il2CppSystem;

namespace Il2CppScheduleOne.Cartel
{
	// Token: 0x02000444 RID: 1092
	public class RobDealer : CartelActivity
	{
		// Token: 0x060062B7 RID: 25271 RVA: 0x001D121C File Offset: 0x001CF41C
		// Note: this type is marked as 'beforefieldinit'.
		static RobDealer()
		{
			Il2CppClassPointerStore<RobDealer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Cartel", "RobDealer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RobDealer>.NativeClassPtr);
			RobDealer.NativeMethodInfoPtr_IsRegionValidForActivity_Public_Virtual_Boolean_EMapRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RobDealer>.NativeClassPtr, 100676253);
			RobDealer.NativeMethodInfoPtr_GetDealerToRob_Private_Dealer_EMapRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RobDealer>.NativeClassPtr, 100676254);
			RobDealer.NativeMethodInfoPtr_Activate_Public_Virtual_Void_EMapRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RobDealer>.NativeClassPtr, 100676255);
			RobDealer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RobDealer>.NativeClassPtr, 100676256);
		}

		// Token: 0x060062B8 RID: 25272 RVA: 0x001D129C File Offset: 0x001CF49C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208251, XrefRangeEnd = 208257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsRegionValidForActivity(EMapRegion region)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref region;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RobDealer.NativeMethodInfoPtr_IsRegionValidForActivity_Public_Virtual_Boolean_EMapRegion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060062B9 RID: 25273 RVA: 0x001D12F0 File Offset: 0x001CF4F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 208284, RefRangeEnd = 208286, XrefRangeStart = 208257, XrefRangeEnd = 208284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dealer GetDealerToRob(EMapRegion region)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref region;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RobDealer.NativeMethodInfoPtr_GetDealerToRob_Private_Dealer_EMapRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dealer>(intPtr3) : null;
		}

		// Token: 0x060062BA RID: 25274 RVA: 0x001D133C File Offset: 0x001CF53C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208286, XrefRangeEnd = 208294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Activate(EMapRegion region)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref region;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RobDealer.NativeMethodInfoPtr_Activate_Public_Virtual_Void_EMapRegion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062BB RID: 25275 RVA: 0x001D1388 File Offset: 0x001CF588
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RobDealer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RobDealer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RobDealer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062BC RID: 25276 RVA: 0x0002EA0E File Offset: 0x0002CC0E
		public RobDealer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004407 RID: 17415
		private static readonly IntPtr NativeMethodInfoPtr_IsRegionValidForActivity_Public_Virtual_Boolean_EMapRegion_0;

		// Token: 0x04004408 RID: 17416
		private static readonly IntPtr NativeMethodInfoPtr_GetDealerToRob_Private_Dealer_EMapRegion_0;

		// Token: 0x04004409 RID: 17417
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Virtual_Void_EMapRegion_0;

		// Token: 0x0400440A RID: 17418
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B35 RID: 2869
		[ObfuscatedName("ScheduleOne.Cartel.RobDealer+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x0600E6AD RID: 59053 RVA: 0x00384734 File Offset: 0x00382934
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<RobDealer.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RobDealer>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RobDealer.__c__DisplayClass1_0>.NativeClassPtr);
				RobDealer.__c__DisplayClass1_0.NativeFieldInfoPtr_region = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RobDealer.__c__DisplayClass1_0>.NativeClassPtr, "region");
				RobDealer.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RobDealer.__c__DisplayClass1_0>.NativeClassPtr, 100676257);
				RobDealer.__c__DisplayClass1_0.NativeMethodInfoPtr__GetDealerToRob_b__0_Internal_Boolean_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RobDealer.__c__DisplayClass1_0>.NativeClassPtr, 100676258);
			}

			// Token: 0x0600E6AE RID: 59054 RVA: 0x0038479C File Offset: 0x0038299C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RobDealer.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RobDealer.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E6AF RID: 59055 RVA: 0x003847D8 File Offset: 0x003829D8
			[CallerCount(0)]
			public unsafe bool _GetDealerToRob_b__0(Dealer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RobDealer.__c__DisplayClass1_0.NativeMethodInfoPtr__GetDealerToRob_b__0_Internal_Boolean_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E6B0 RID: 59056 RVA: 0x0006CD08 File Offset: 0x0006AF08
			public __c__DisplayClass1_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004606 RID: 17926
			// (get) Token: 0x0600E6B1 RID: 59057 RVA: 0x00384828 File Offset: 0x00382A28
			// (set) Token: 0x0600E6B2 RID: 59058 RVA: 0x0006CD11 File Offset: 0x0006AF11
			public unsafe EMapRegion region
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RobDealer.__c__DisplayClass1_0.NativeFieldInfoPtr_region);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RobDealer.__c__DisplayClass1_0.NativeFieldInfoPtr_region)) = value;
				}
			}

			// Token: 0x04009C9D RID: 40093
			private static readonly IntPtr NativeFieldInfoPtr_region;

			// Token: 0x04009C9E RID: 40094
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009C9F RID: 40095
			private static readonly IntPtr NativeMethodInfoPtr__GetDealerToRob_b__0_Internal_Boolean_Dealer_0;
		}
	}
}
