using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Tools;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x02000361 RID: 865
	[Serializable]
	public class WaterContainerDefinition : StorableItemDefinition
	{
		// Token: 0x06004937 RID: 18743 RVA: 0x001741F8 File Offset: 0x001723F8
		// Note: this type is marked as 'beforefieldinit'.
		static WaterContainerDefinition()
		{
			Il2CppClassPointerStore<WaterContainerDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "WaterContainerDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaterContainerDefinition>.NativeClassPtr);
			WaterContainerDefinition.NativeFieldInfoPtr_Capacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterContainerDefinition>.NativeClassPtr, "Capacity");
			WaterContainerDefinition.NativeFieldInfoPtr_FillablePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterContainerDefinition>.NativeClassPtr, "FillablePrefab");
			WaterContainerDefinition.NativeMethodInfoPtr_ValidateDefinition_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterContainerDefinition>.NativeClassPtr, 100672672);
			WaterContainerDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterContainerDefinition>.NativeClassPtr, 100672673);
			WaterContainerDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterContainerDefinition>.NativeClassPtr, 100672674);
		}

		// Token: 0x06004938 RID: 18744 RVA: 0x0017428C File Offset: 0x0017248C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ValidateDefinition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterContainerDefinition.NativeMethodInfoPtr_ValidateDefinition_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004939 RID: 18745 RVA: 0x001742C8 File Offset: 0x001724C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168861, XrefRangeEnd = 168865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterContainerDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x0600493A RID: 18746 RVA: 0x00174320 File Offset: 0x00172520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168865, XrefRangeEnd = 168866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaterContainerDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaterContainerDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterContainerDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600493B RID: 18747 RVA: 0x00023962 File Offset: 0x00021B62
		public WaterContainerDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016F0 RID: 5872
		// (get) Token: 0x0600493C RID: 18748 RVA: 0x0017435C File Offset: 0x0017255C
		// (set) Token: 0x0600493D RID: 18749 RVA: 0x0002396B File Offset: 0x00021B6B
		public unsafe float Capacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterContainerDefinition.NativeFieldInfoPtr_Capacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterContainerDefinition.NativeFieldInfoPtr_Capacity)) = value;
			}
		}

		// Token: 0x170016F1 RID: 5873
		// (get) Token: 0x0600493E RID: 18750 RVA: 0x00174384 File Offset: 0x00172584
		// (set) Token: 0x0600493F RID: 18751 RVA: 0x00023986 File Offset: 0x00021B86
		public unsafe FillableWaterContainer FillablePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterContainerDefinition.NativeFieldInfoPtr_FillablePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FillableWaterContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterContainerDefinition.NativeFieldInfoPtr_FillablePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031C0 RID: 12736
		private static readonly IntPtr NativeFieldInfoPtr_Capacity;

		// Token: 0x040031C1 RID: 12737
		private static readonly IntPtr NativeFieldInfoPtr_FillablePrefab;

		// Token: 0x040031C2 RID: 12738
		private static readonly IntPtr NativeMethodInfoPtr_ValidateDefinition_Public_Virtual_Void_0;

		// Token: 0x040031C3 RID: 12739
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x040031C4 RID: 12740
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
