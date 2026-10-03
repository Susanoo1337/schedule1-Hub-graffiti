using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Map;
using Il2CppSystem;

namespace Il2CppScheduleOne.Cartel
{
	// Token: 0x02000446 RID: 1094
	public class StealDeadDrop : CartelActivity
	{
		// Token: 0x060062C7 RID: 25287 RVA: 0x001D15EC File Offset: 0x001CF7EC
		// Note: this type is marked as 'beforefieldinit'.
		static StealDeadDrop()
		{
			Il2CppClassPointerStore<StealDeadDrop>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Cartel", "StealDeadDrop");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StealDeadDrop>.NativeClassPtr);
			StealDeadDrop.NativeFieldInfoPtr_MIN_TIME_SINCE_CONTENTS_CHANGED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StealDeadDrop>.NativeClassPtr, "MIN_TIME_SINCE_CONTENTS_CHANGED");
			StealDeadDrop.NativeFieldInfoPtr_ItemsToLeave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StealDeadDrop>.NativeClassPtr, "ItemsToLeave");
			StealDeadDrop.NativeMethodInfoPtr_IsRegionValidForActivity_Public_Virtual_Boolean_EMapRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StealDeadDrop>.NativeClassPtr, 100676265);
			StealDeadDrop.NativeMethodInfoPtr_Activate_Public_Virtual_Void_EMapRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StealDeadDrop>.NativeClassPtr, 100676266);
			StealDeadDrop.NativeMethodInfoPtr_GetRandomDropToStealFrom_Private_Static_DeadDrop_EMapRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StealDeadDrop>.NativeClassPtr, 100676267);
			StealDeadDrop.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StealDeadDrop>.NativeClassPtr, 100676268);
		}

		// Token: 0x060062C8 RID: 25288 RVA: 0x001D1694 File Offset: 0x001CF894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208398, XrefRangeEnd = 208404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsRegionValidForActivity(EMapRegion region)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref region;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StealDeadDrop.NativeMethodInfoPtr_IsRegionValidForActivity_Public_Virtual_Boolean_EMapRegion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060062C9 RID: 25289 RVA: 0x001D16E8 File Offset: 0x001CF8E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208404, XrefRangeEnd = 208421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Activate(EMapRegion region)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref region;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StealDeadDrop.NativeMethodInfoPtr_Activate_Public_Virtual_Void_EMapRegion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062CA RID: 25290 RVA: 0x001D1734 File Offset: 0x001CF934
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 208488, RefRangeEnd = 208490, XrefRangeStart = 208421, XrefRangeEnd = 208488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DeadDrop GetRandomDropToStealFrom(EMapRegion region)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref region;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StealDeadDrop.NativeMethodInfoPtr_GetRandomDropToStealFrom_Private_Static_DeadDrop_EMapRegion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeadDrop>(intPtr3) : null;
		}

		// Token: 0x060062CB RID: 25291 RVA: 0x001D1774 File Offset: 0x001CF974
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StealDeadDrop() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StealDeadDrop>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StealDeadDrop.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062CC RID: 25292 RVA: 0x0002EA5A File Offset: 0x0002CC5A
		public StealDeadDrop(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E57 RID: 7767
		// (get) Token: 0x060062CD RID: 25293 RVA: 0x001D17B0 File Offset: 0x001CF9B0
		// (set) Token: 0x060062CE RID: 25294 RVA: 0x0002EA63 File Offset: 0x0002CC63
		public unsafe static int MIN_TIME_SINCE_CONTENTS_CHANGED
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(StealDeadDrop.NativeFieldInfoPtr_MIN_TIME_SINCE_CONTENTS_CHANGED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StealDeadDrop.NativeFieldInfoPtr_MIN_TIME_SINCE_CONTENTS_CHANGED, (void*)(&value));
			}
		}

		// Token: 0x17001E58 RID: 7768
		// (get) Token: 0x060062CF RID: 25295 RVA: 0x001D17CC File Offset: 0x001CF9CC
		// (set) Token: 0x060062D0 RID: 25296 RVA: 0x0002EA71 File Offset: 0x0002CC71
		public unsafe Il2CppReferenceArray<ItemDefinition> ItemsToLeave
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StealDeadDrop.NativeFieldInfoPtr_ItemsToLeave);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StealDeadDrop.NativeFieldInfoPtr_ItemsToLeave), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004411 RID: 17425
		private static readonly IntPtr NativeFieldInfoPtr_MIN_TIME_SINCE_CONTENTS_CHANGED;

		// Token: 0x04004412 RID: 17426
		private static readonly IntPtr NativeFieldInfoPtr_ItemsToLeave;

		// Token: 0x04004413 RID: 17427
		private static readonly IntPtr NativeMethodInfoPtr_IsRegionValidForActivity_Public_Virtual_Boolean_EMapRegion_0;

		// Token: 0x04004414 RID: 17428
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Virtual_Void_EMapRegion_0;

		// Token: 0x04004415 RID: 17429
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomDropToStealFrom_Private_Static_DeadDrop_EMapRegion_0;

		// Token: 0x04004416 RID: 17430
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B37 RID: 2871
		[ObfuscatedName("ScheduleOne.Cartel.StealDeadDrop+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600E6B9 RID: 59065 RVA: 0x0038496C File Offset: 0x00382B6C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<StealDeadDrop.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StealDeadDrop>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StealDeadDrop.__c>.NativeClassPtr);
				StealDeadDrop.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StealDeadDrop.__c>.NativeClassPtr, "<>9");
				StealDeadDrop.__c.NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StealDeadDrop.__c>.NativeClassPtr, "<>9__4_1");
				StealDeadDrop.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StealDeadDrop.__c>.NativeClassPtr, 100676270);
				StealDeadDrop.__c.NativeMethodInfoPtr__GetRandomDropToStealFrom_b__4_1_Internal_Single_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StealDeadDrop.__c>.NativeClassPtr, 100676271);
			}

			// Token: 0x0600E6BA RID: 59066 RVA: 0x003849E8 File Offset: 0x00382BE8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StealDeadDrop.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StealDeadDrop.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E6BB RID: 59067 RVA: 0x00384A24 File Offset: 0x00382C24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208397, XrefRangeEnd = 208398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _GetRandomDropToStealFrom_b__4_1(ItemInstance item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StealDeadDrop.__c.NativeMethodInfoPtr__GetRandomDropToStealFrom_b__4_1_Internal_Single_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E6BC RID: 59068 RVA: 0x0006CD50 File Offset: 0x0006AF50
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004608 RID: 17928
			// (get) Token: 0x0600E6BD RID: 59069 RVA: 0x00384A74 File Offset: 0x00382C74
			// (set) Token: 0x0600E6BE RID: 59070 RVA: 0x0006CD59 File Offset: 0x0006AF59
			public unsafe static StealDeadDrop.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StealDeadDrop.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StealDeadDrop.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StealDeadDrop.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004609 RID: 17929
			// (get) Token: 0x0600E6BF RID: 59071 RVA: 0x00384A9C File Offset: 0x00382C9C
			// (set) Token: 0x0600E6C0 RID: 59072 RVA: 0x0006CD6B File Offset: 0x0006AF6B
			public unsafe static Func<ItemInstance, float> __9__4_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StealDeadDrop.__c.NativeFieldInfoPtr___9__4_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ItemInstance, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StealDeadDrop.__c.NativeFieldInfoPtr___9__4_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009CA3 RID: 40099
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009CA4 RID: 40100
			private static readonly IntPtr NativeFieldInfoPtr___9__4_1;

			// Token: 0x04009CA5 RID: 40101
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009CA6 RID: 40102
			private static readonly IntPtr NativeMethodInfoPtr__GetRandomDropToStealFrom_b__4_1_Internal_Single_ItemInstance_0;
		}

		// Token: 0x02000B38 RID: 2872
		[ObfuscatedName("ScheduleOne.Cartel.StealDeadDrop+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x0600E6C1 RID: 59073 RVA: 0x00384AC4 File Offset: 0x00382CC4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<StealDeadDrop.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StealDeadDrop>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StealDeadDrop.__c__DisplayClass4_0>.NativeClassPtr);
				StealDeadDrop.__c__DisplayClass4_0.NativeFieldInfoPtr_region = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StealDeadDrop.__c__DisplayClass4_0>.NativeClassPtr, "region");
				StealDeadDrop.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StealDeadDrop.__c__DisplayClass4_0>.NativeClassPtr, 100676272);
				StealDeadDrop.__c__DisplayClass4_0.NativeMethodInfoPtr__GetRandomDropToStealFrom_b__0_Internal_Boolean_DeadDrop_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StealDeadDrop.__c__DisplayClass4_0>.NativeClassPtr, 100676273);
			}

			// Token: 0x0600E6C2 RID: 59074 RVA: 0x00384B2C File Offset: 0x00382D2C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StealDeadDrop.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StealDeadDrop.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E6C3 RID: 59075 RVA: 0x00384B68 File Offset: 0x00382D68
			[CallerCount(0)]
			public unsafe bool _GetRandomDropToStealFrom_b__0(DeadDrop dd)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StealDeadDrop.__c__DisplayClass4_0.NativeMethodInfoPtr__GetRandomDropToStealFrom_b__0_Internal_Boolean_DeadDrop_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E6C4 RID: 59076 RVA: 0x0006CD7D File Offset: 0x0006AF7D
			public __c__DisplayClass4_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700460A RID: 17930
			// (get) Token: 0x0600E6C5 RID: 59077 RVA: 0x00384BB8 File Offset: 0x00382DB8
			// (set) Token: 0x0600E6C6 RID: 59078 RVA: 0x0006CD86 File Offset: 0x0006AF86
			public unsafe EMapRegion region
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StealDeadDrop.__c__DisplayClass4_0.NativeFieldInfoPtr_region);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StealDeadDrop.__c__DisplayClass4_0.NativeFieldInfoPtr_region)) = value;
				}
			}

			// Token: 0x04009CA7 RID: 40103
			private static readonly IntPtr NativeFieldInfoPtr_region;

			// Token: 0x04009CA8 RID: 40104
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009CA9 RID: 40105
			private static readonly IntPtr NativeMethodInfoPtr__GetRandomDropToStealFrom_b__0_Internal_Boolean_DeadDrop_0;
		}
	}
}
