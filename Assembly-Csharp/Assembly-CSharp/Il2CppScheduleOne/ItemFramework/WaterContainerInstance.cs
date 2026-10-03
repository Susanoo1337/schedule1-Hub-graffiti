using System;
using Il2CppFishNet.Serializing;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Storage;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x02000362 RID: 866
	[Serializable]
	public class WaterContainerInstance : StorableItemInstance
	{
		// Token: 0x06004940 RID: 18752 RVA: 0x001743B4 File Offset: 0x001725B4
		// Note: this type is marked as 'beforefieldinit'.
		static WaterContainerInstance()
		{
			Il2CppClassPointerStore<WaterContainerInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "WaterContainerInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaterContainerInstance>.NativeClassPtr);
			WaterContainerInstance.NativeFieldInfoPtr__CurrentFillAmount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterContainerInstance>.NativeClassPtr, "<CurrentFillAmount>k__BackingField");
			WaterContainerInstance.NativeMethodInfoPtr_get_CurrentFillAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterContainerInstance>.NativeClassPtr, 100672675);
			WaterContainerInstance.NativeMethodInfoPtr_set_CurrentFillAmount_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterContainerInstance>.NativeClassPtr, 100672676);
			WaterContainerInstance.NativeMethodInfoPtr_get_NormalizedFillAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterContainerInstance>.NativeClassPtr, 100672677);
			WaterContainerInstance.NativeMethodInfoPtr_get_WaterContainerDefinition_Public_get_WaterContainerDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterContainerInstance>.NativeClassPtr, 100672678);
			WaterContainerInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterContainerInstance>.NativeClassPtr, 100672679);
			WaterContainerInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterContainerInstance>.NativeClassPtr, 100672680);
			WaterContainerInstance.NativeMethodInfoPtr_ChangeFillAmount_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterContainerInstance>.NativeClassPtr, 100672681);
			WaterContainerInstance.NativeMethodInfoPtr_ChangeFillAmountByPercentage_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterContainerInstance>.NativeClassPtr, 100672682);
			WaterContainerInstance.NativeMethodInfoPtr_SetFillAmount_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterContainerInstance>.NativeClassPtr, 100672683);
			WaterContainerInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterContainerInstance>.NativeClassPtr, 100672684);
			WaterContainerInstance.NativeMethodInfoPtr_Write_Public_Virtual_Void_Writer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterContainerInstance>.NativeClassPtr, 100672685);
			WaterContainerInstance.NativeMethodInfoPtr_Read_Public_Virtual_Void_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterContainerInstance>.NativeClassPtr, 100672686);
		}

		// Token: 0x170016F3 RID: 5875
		// (get) Token: 0x06004941 RID: 18753 RVA: 0x001744E8 File Offset: 0x001726E8
		// (set) Token: 0x06004942 RID: 18754 RVA: 0x00174524 File Offset: 0x00172724
		public unsafe float CurrentFillAmount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29130, RefRangeEnd = 29131, XrefRangeStart = 29130, XrefRangeEnd = 29131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterContainerInstance.NativeMethodInfoPtr_get_CurrentFillAmount_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29131, RefRangeEnd = 29133, XrefRangeStart = 29131, XrefRangeEnd = 29133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterContainerInstance.NativeMethodInfoPtr_set_CurrentFillAmount_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016F4 RID: 5876
		// (get) Token: 0x06004943 RID: 18755 RVA: 0x00174564 File Offset: 0x00172764
		public unsafe float NormalizedFillAmount
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 168867, RefRangeEnd = 168872, XrefRangeStart = 168866, XrefRangeEnd = 168867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterContainerInstance.NativeMethodInfoPtr_get_NormalizedFillAmount_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170016F5 RID: 5877
		// (get) Token: 0x06004944 RID: 18756 RVA: 0x001745A0 File Offset: 0x001727A0
		public unsafe WaterContainerDefinition WaterContainerDefinition
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 168874, RefRangeEnd = 168881, XrefRangeStart = 168872, XrefRangeEnd = 168874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterContainerInstance.NativeMethodInfoPtr_get_WaterContainerDefinition_Public_get_WaterContainerDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WaterContainerDefinition>(intPtr3) : null;
			}
		}

		// Token: 0x06004945 RID: 18757 RVA: 0x001745E0 File Offset: 0x001727E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168882, RefRangeEnd = 168883, XrefRangeStart = 168881, XrefRangeEnd = 168882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaterContainerInstance(ItemDefinition definition, int quantity, float fillAmount) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaterContainerInstance>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fillAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterContainerInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004946 RID: 18758 RVA: 0x00174648 File Offset: 0x00172848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168883, XrefRangeEnd = 168888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref overrideQuantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterContainerInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06004947 RID: 18759 RVA: 0x001746A0 File Offset: 0x001728A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168892, RefRangeEnd = 168893, XrefRangeStart = 168888, XrefRangeEnd = 168892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeFillAmount(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterContainerInstance.NativeMethodInfoPtr_ChangeFillAmount_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004948 RID: 18760 RVA: 0x001746E0 File Offset: 0x001728E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168898, RefRangeEnd = 168899, XrefRangeStart = 168893, XrefRangeEnd = 168898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeFillAmountByPercentage(float percentage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref percentage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterContainerInstance.NativeMethodInfoPtr_ChangeFillAmountByPercentage_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004949 RID: 18761 RVA: 0x00174720 File Offset: 0x00172920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168899, XrefRangeEnd = 168902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFillAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterContainerInstance.NativeMethodInfoPtr_SetFillAmount_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600494A RID: 18762 RVA: 0x00174760 File Offset: 0x00172960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168902, XrefRangeEnd = 168907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemData GetItemData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterContainerInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemData>(intPtr3) : null;
		}

		// Token: 0x0600494B RID: 18763 RVA: 0x001747AC File Offset: 0x001729AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168907, XrefRangeEnd = 168912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(Writer writer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterContainerInstance.NativeMethodInfoPtr_Write_Public_Virtual_Void_Writer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600494C RID: 18764 RVA: 0x001747FC File Offset: 0x001729FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168912, XrefRangeEnd = 168913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Read(Reader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterContainerInstance.NativeMethodInfoPtr_Read_Public_Virtual_Void_Reader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600494D RID: 18765 RVA: 0x000239A5 File Offset: 0x00021BA5
		public WaterContainerInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016F2 RID: 5874
		// (get) Token: 0x0600494E RID: 18766 RVA: 0x0017484C File Offset: 0x00172A4C
		// (set) Token: 0x0600494F RID: 18767 RVA: 0x000239AE File Offset: 0x00021BAE
		public unsafe float _CurrentFillAmount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterContainerInstance.NativeFieldInfoPtr__CurrentFillAmount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterContainerInstance.NativeFieldInfoPtr__CurrentFillAmount_k__BackingField)) = value;
			}
		}

		// Token: 0x040031C5 RID: 12741
		private static readonly IntPtr NativeFieldInfoPtr__CurrentFillAmount_k__BackingField;

		// Token: 0x040031C6 RID: 12742
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentFillAmount_Public_get_Single_0;

		// Token: 0x040031C7 RID: 12743
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentFillAmount_Private_set_Void_Single_0;

		// Token: 0x040031C8 RID: 12744
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalizedFillAmount_Public_get_Single_0;

		// Token: 0x040031C9 RID: 12745
		private static readonly IntPtr NativeMethodInfoPtr_get_WaterContainerDefinition_Public_get_WaterContainerDefinition_0;

		// Token: 0x040031CA RID: 12746
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_Single_0;

		// Token: 0x040031CB RID: 12747
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x040031CC RID: 12748
		private static readonly IntPtr NativeMethodInfoPtr_ChangeFillAmount_Public_Void_Single_0;

		// Token: 0x040031CD RID: 12749
		private static readonly IntPtr NativeMethodInfoPtr_ChangeFillAmountByPercentage_Public_Void_Single_0;

		// Token: 0x040031CE RID: 12750
		private static readonly IntPtr NativeMethodInfoPtr_SetFillAmount_Public_Void_Single_0;

		// Token: 0x040031CF RID: 12751
		private static readonly IntPtr NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0;

		// Token: 0x040031D0 RID: 12752
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Writer_0;

		// Token: 0x040031D1 RID: 12753
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Void_Reader_0;
	}
}
