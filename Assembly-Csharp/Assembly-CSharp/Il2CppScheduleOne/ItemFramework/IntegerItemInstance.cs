using System;
using Il2CppFishNet.Serializing;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Storage;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x0200034E RID: 846
	public class IntegerItemInstance : StorableItemInstance
	{
		// Token: 0x060047F2 RID: 18418 RVA: 0x0016FAF0 File Offset: 0x0016DCF0
		// Note: this type is marked as 'beforefieldinit'.
		static IntegerItemInstance()
		{
			Il2CppClassPointerStore<IntegerItemInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "IntegerItemInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntegerItemInstance>.NativeClassPtr);
			IntegerItemInstance.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegerItemInstance>.NativeClassPtr, "Value");
			IntegerItemInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemInstance>.NativeClassPtr, 100672509);
			IntegerItemInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemInstance>.NativeClassPtr, 100672510);
			IntegerItemInstance.NativeMethodInfoPtr_ChangeValue_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemInstance>.NativeClassPtr, 100672511);
			IntegerItemInstance.NativeMethodInfoPtr_SetValue_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemInstance>.NativeClassPtr, 100672512);
			IntegerItemInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemInstance>.NativeClassPtr, 100672513);
			IntegerItemInstance.NativeMethodInfoPtr_Write_Public_Virtual_Void_Writer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemInstance>.NativeClassPtr, 100672514);
			IntegerItemInstance.NativeMethodInfoPtr_Read_Public_Virtual_Void_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemInstance>.NativeClassPtr, 100672515);
		}

		// Token: 0x060047F3 RID: 18419 RVA: 0x0016FBC0 File Offset: 0x0016DDC0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 167252, RefRangeEnd = 167257, XrefRangeStart = 167251, XrefRangeEnd = 167252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntegerItemInstance(ItemDefinition definition, int quantity, int value) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntegerItemInstance>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntegerItemInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047F4 RID: 18420 RVA: 0x0016FC28 File Offset: 0x0016DE28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167257, XrefRangeEnd = 167262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref overrideQuantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntegerItemInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x060047F5 RID: 18421 RVA: 0x0016FC80 File Offset: 0x0016DE80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 167263, RefRangeEnd = 167264, XrefRangeStart = 167262, XrefRangeEnd = 167263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeValue(int change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntegerItemInstance.NativeMethodInfoPtr_ChangeValue_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047F6 RID: 18422 RVA: 0x0016FCC0 File Offset: 0x0016DEC0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 167265, RefRangeEnd = 167273, XrefRangeStart = 167264, XrefRangeEnd = 167265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntegerItemInstance.NativeMethodInfoPtr_SetValue_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047F7 RID: 18423 RVA: 0x0016FD00 File Offset: 0x0016DF00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167273, XrefRangeEnd = 167278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemData GetItemData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntegerItemInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemData>(intPtr3) : null;
		}

		// Token: 0x060047F8 RID: 18424 RVA: 0x0016FD4C File Offset: 0x0016DF4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 167283, RefRangeEnd = 167284, XrefRangeStart = 167278, XrefRangeEnd = 167283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(Writer writer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntegerItemInstance.NativeMethodInfoPtr_Write_Public_Virtual_Void_Writer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047F9 RID: 18425 RVA: 0x0016FD9C File Offset: 0x0016DF9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 167284, RefRangeEnd = 167285, XrefRangeStart = 167284, XrefRangeEnd = 167284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Read(Reader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntegerItemInstance.NativeMethodInfoPtr_Read_Public_Virtual_Void_Reader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047FA RID: 18426 RVA: 0x00023100 File Offset: 0x00021300
		public IntegerItemInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001690 RID: 5776
		// (get) Token: 0x060047FB RID: 18427 RVA: 0x0016FDEC File Offset: 0x0016DFEC
		// (set) Token: 0x060047FC RID: 18428 RVA: 0x00023109 File Offset: 0x00021309
		public unsafe int Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegerItemInstance.NativeFieldInfoPtr_Value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegerItemInstance.NativeFieldInfoPtr_Value)) = value;
			}
		}

		// Token: 0x040030E2 RID: 12514
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x040030E3 RID: 12515
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_Int32_0;

		// Token: 0x040030E4 RID: 12516
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x040030E5 RID: 12517
		private static readonly IntPtr NativeMethodInfoPtr_ChangeValue_Public_Void_Int32_0;

		// Token: 0x040030E6 RID: 12518
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Int32_0;

		// Token: 0x040030E7 RID: 12519
		private static readonly IntPtr NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0;

		// Token: 0x040030E8 RID: 12520
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Writer_0;

		// Token: 0x040030E9 RID: 12521
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Void_Reader_0;
	}
}
