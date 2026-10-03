using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x02000525 RID: 1317
	[Serializable]
	public class StorableItemInstance : ItemInstance
	{
		// Token: 0x060077AB RID: 30635 RVA: 0x0021437C File Offset: 0x0021257C
		// Note: this type is marked as 'beforefieldinit'.
		static StorableItemInstance()
		{
			Il2CppClassPointerStore<StorableItemInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "StorableItemInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorableItemInstance>.NativeClassPtr);
			StorableItemInstance.NativeMethodInfoPtr_get_StoredItem_Public_Virtual_New_get_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorableItemInstance>.NativeClassPtr, 100678673);
			StorableItemInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorableItemInstance>.NativeClassPtr, 100678674);
			StorableItemInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorableItemInstance>.NativeClassPtr, 100678675);
			StorableItemInstance.NativeMethodInfoPtr_GetMonetaryValue_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorableItemInstance>.NativeClassPtr, 100678676);
		}

		// Token: 0x170024FE RID: 9470
		// (get) Token: 0x060077AC RID: 30636 RVA: 0x002143FC File Offset: 0x002125FC
		public unsafe virtual StoredItem StoredItem
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 231299, RefRangeEnd = 231301, XrefRangeStart = 231287, XrefRangeEnd = 231299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorableItemInstance.NativeMethodInfoPtr_get_StoredItem_Public_Virtual_New_get_StoredItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StoredItem>(intPtr3) : null;
			}
		}

		// Token: 0x060077AD RID: 30637 RVA: 0x00214448 File Offset: 0x00212648
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 231314, RefRangeEnd = 231334, XrefRangeStart = 231301, XrefRangeEnd = 231314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorableItemInstance(ItemDefinition definition, int quantity) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorableItemInstance>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorableItemInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077AE RID: 30638 RVA: 0x002144A4 File Offset: 0x002126A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231334, XrefRangeEnd = 231351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref overrideQuantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorableItemInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x060077AF RID: 30639 RVA: 0x002144FC File Offset: 0x002126FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231351, XrefRangeEnd = 231356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float GetMonetaryValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorableItemInstance.NativeMethodInfoPtr_GetMonetaryValue_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060077B0 RID: 30640 RVA: 0x0003912C File Offset: 0x0003732C
		public StorableItemInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005186 RID: 20870
		private static readonly IntPtr NativeMethodInfoPtr_get_StoredItem_Public_Virtual_New_get_StoredItem_0;

		// Token: 0x04005187 RID: 20871
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_0;

		// Token: 0x04005188 RID: 20872
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04005189 RID: 20873
		private static readonly IntPtr NativeMethodInfoPtr_GetMonetaryValue_Public_Virtual_Single_0;
	}
}
