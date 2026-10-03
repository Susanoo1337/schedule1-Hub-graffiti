using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Product;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x02000535 RID: 1333
	public class LiquidMeth_StationItem : StationItem
	{
		// Token: 0x0600793B RID: 31035 RVA: 0x0021A300 File Offset: 0x00218500
		// Note: this type is marked as 'beforefieldinit'.
		static LiquidMeth_StationItem()
		{
			Il2CppClassPointerStore<LiquidMeth_StationItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "LiquidMeth_StationItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidMeth_StationItem>.NativeClassPtr);
			LiquidMeth_StationItem.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidMeth_StationItem>.NativeClassPtr, "Visuals");
			LiquidMeth_StationItem.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_StorableItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidMeth_StationItem>.NativeClassPtr, 100678887);
			LiquidMeth_StationItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidMeth_StationItem>.NativeClassPtr, 100678888);
		}

		// Token: 0x0600793C RID: 31036 RVA: 0x0021A36C File Offset: 0x0021856C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233626, XrefRangeEnd = 233644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(StorableItemDefinition itemDefinition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemDefinition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LiquidMeth_StationItem.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_StorableItemDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600793D RID: 31037 RVA: 0x0021A3BC File Offset: 0x002185BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233644, XrefRangeEnd = 233645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LiquidMeth_StationItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidMeth_StationItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidMeth_StationItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600793E RID: 31038 RVA: 0x00039B3B File Offset: 0x00037D3B
		public LiquidMeth_StationItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002572 RID: 9586
		// (get) Token: 0x0600793F RID: 31039 RVA: 0x0021A3F8 File Offset: 0x002185F8
		// (set) Token: 0x06007940 RID: 31040 RVA: 0x00039B44 File Offset: 0x00037D44
		public unsafe LiquidMethVisuals Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMeth_StationItem.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidMethVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMeth_StationItem.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040052A2 RID: 21154
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x040052A3 RID: 21155
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_StorableItemDefinition_0;

		// Token: 0x040052A4 RID: 21156
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
