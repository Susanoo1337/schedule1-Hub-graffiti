using System;
using Il2CppFishNet.Serializing;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Core.Items.Framework;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.Persistence.Datas;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x02000351 RID: 849
	[Serializable]
	public class ItemInstance : BaseItemInstance
	{
		// Token: 0x06004813 RID: 18451 RVA: 0x0017018C File Offset: 0x0016E38C
		// Note: this type is marked as 'beforefieldinit'.
		static ItemInstance()
		{
			Il2CppClassPointerStore<ItemInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr);
			ItemInstance.NativeMethodInfoPtr_get_Definition_Public_get_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100672520);
			ItemInstance.NativeMethodInfoPtr_get_Equippable_Public_Virtual_New_get_Equippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100672521);
			ItemInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100672522);
			ItemInstance.NativeMethodInfoPtr_CanStackWith_Public_Virtual_New_Boolean_ItemInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100672523);
			ItemInstance.NativeMethodInfoPtr_GetCopy_Public_Abstract_Virtual_New_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100672524);
			ItemInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_New_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100672525);
			ItemInstance.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Writer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100672526);
			ItemInstance.NativeMethodInfoPtr_Read_Public_Virtual_New_Void_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100672527);
			ItemInstance.NativeMethodInfoPtr_CreateInstanceAndRead_Public_Static_ItemInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100672528);
		}

		// Token: 0x17001698 RID: 5784
		// (get) Token: 0x06004814 RID: 18452 RVA: 0x00170270 File Offset: 0x0016E470
		public unsafe ItemDefinition Definition
		{
			[CallerCount(140)]
			[CachedScanResults(RefRangeStart = 167312, RefRangeEnd = 167452, XrefRangeStart = 167292, XrefRangeEnd = 167312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInstance.NativeMethodInfoPtr_get_Definition_Public_get_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr3) : null;
			}
		}

		// Token: 0x17001699 RID: 5785
		// (get) Token: 0x06004815 RID: 18453 RVA: 0x001702B0 File Offset: 0x0016E4B0
		public unsafe virtual Equippable Equippable
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 167453, RefRangeEnd = 167455, XrefRangeStart = 167452, XrefRangeEnd = 167453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInstance.NativeMethodInfoPtr_get_Equippable_Public_Virtual_New_get_Equippable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Equippable>(intPtr3) : null;
			}
		}

		// Token: 0x06004816 RID: 18454 RVA: 0x001702FC File Offset: 0x0016E4FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 167457, RefRangeEnd = 167459, XrefRangeStart = 167455, XrefRangeEnd = 167457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemInstance(ItemDefinition definition, int quantity) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004817 RID: 18455 RVA: 0x00170358 File Offset: 0x0016E558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167459, XrefRangeEnd = 167462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanStackWith(ItemInstance other, bool checkQuantities = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkQuantities;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInstance.NativeMethodInfoPtr_CanStackWith_Public_Virtual_New_Boolean_ItemInstance_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004818 RID: 18456 RVA: 0x001703C0 File Offset: 0x0016E5C0
		[CallerCount(0)]
		public unsafe virtual ItemInstance GetCopy(int overrideQuantity = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref overrideQuantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInstance.NativeMethodInfoPtr_GetCopy_Public_Abstract_Virtual_New_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06004819 RID: 18457 RVA: 0x00170418 File Offset: 0x0016E618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167462, XrefRangeEnd = 167467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ItemData GetItemData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_New_ItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemData>(intPtr3) : null;
		}

		// Token: 0x0600481A RID: 18458 RVA: 0x00170464 File Offset: 0x0016E664
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 167471, RefRangeEnd = 167473, XrefRangeStart = 167467, XrefRangeEnd = 167471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Write(Writer writer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInstance.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Writer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600481B RID: 18459 RVA: 0x001704B4 File Offset: 0x0016E6B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 167473, RefRangeEnd = 167475, XrefRangeStart = 167473, XrefRangeEnd = 167473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Read(Reader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInstance.NativeMethodInfoPtr_Read_Public_Virtual_New_Void_Reader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600481C RID: 18460 RVA: 0x00170504 File Offset: 0x0016E704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167475, XrefRangeEnd = 167478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ItemInstance CreateInstanceAndRead(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInstance.NativeMethodInfoPtr_CreateInstanceAndRead_Public_Static_ItemInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x0600481D RID: 18461 RVA: 0x00023203 File Offset: 0x00021403
		public ItemInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040030F5 RID: 12533
		private static readonly IntPtr NativeMethodInfoPtr_get_Definition_Public_get_ItemDefinition_0;

		// Token: 0x040030F6 RID: 12534
		private static readonly IntPtr NativeMethodInfoPtr_get_Equippable_Public_Virtual_New_get_Equippable_0;

		// Token: 0x040030F7 RID: 12535
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_0;

		// Token: 0x040030F8 RID: 12536
		private static readonly IntPtr NativeMethodInfoPtr_CanStackWith_Public_Virtual_New_Boolean_ItemInstance_Boolean_0;

		// Token: 0x040030F9 RID: 12537
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Abstract_Virtual_New_ItemInstance_Int32_0;

		// Token: 0x040030FA RID: 12538
		private static readonly IntPtr NativeMethodInfoPtr_GetItemData_Public_Virtual_New_ItemData_0;

		// Token: 0x040030FB RID: 12539
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Writer_0;

		// Token: 0x040030FC RID: 12540
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_New_Void_Reader_0;

		// Token: 0x040030FD RID: 12541
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstanceAndRead_Public_Static_ItemInstance_Reader_0;
	}
}
