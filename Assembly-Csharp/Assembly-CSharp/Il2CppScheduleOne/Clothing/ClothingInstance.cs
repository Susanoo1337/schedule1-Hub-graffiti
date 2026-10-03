using System;
using Il2CppFishNet.Serializing;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Storage;

namespace Il2CppScheduleOne.Clothing
{
	// Token: 0x02000427 RID: 1063
	[Serializable]
	public class ClothingInstance : StorableItemInstance
	{
		// Token: 0x06005DE3 RID: 24035 RVA: 0x001BF0AC File Offset: 0x001BD2AC
		// Note: this type is marked as 'beforefieldinit'.
		static ClothingInstance()
		{
			Il2CppClassPointerStore<ClothingInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Clothing", "ClothingInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingInstance>.NativeClassPtr);
			ClothingInstance.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingInstance>.NativeClassPtr, "Color");
			ClothingInstance.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingInstance>.NativeClassPtr, 100675561);
			ClothingInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_EClothingColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingInstance>.NativeClassPtr, 100675562);
			ClothingInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingInstance>.NativeClassPtr, 100675563);
			ClothingInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingInstance>.NativeClassPtr, 100675564);
			ClothingInstance.NativeMethodInfoPtr_Write_Public_Virtual_Void_Writer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingInstance>.NativeClassPtr, 100675565);
			ClothingInstance.NativeMethodInfoPtr_Read_Public_Virtual_Void_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingInstance>.NativeClassPtr, 100675566);
		}

		// Token: 0x17001CFF RID: 7423
		// (get) Token: 0x06005DE4 RID: 24036 RVA: 0x001BF168 File Offset: 0x001BD368
		public unsafe override string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200250, XrefRangeEnd = 200263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClothingInstance.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06005DE5 RID: 24037 RVA: 0x001BF1AC File Offset: 0x001BD3AC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 167252, RefRangeEnd = 167257, XrefRangeStart = 167252, XrefRangeEnd = 167257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClothingInstance(ItemDefinition definition, int quantity, EClothingColor color) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingInstance>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_EClothingColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DE6 RID: 24038 RVA: 0x001BF214 File Offset: 0x001BD414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200263, XrefRangeEnd = 200268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref overrideQuantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClothingInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06005DE7 RID: 24039 RVA: 0x001BF26C File Offset: 0x001BD46C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200268, XrefRangeEnd = 200273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemData GetItemData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClothingInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemData>(intPtr3) : null;
		}

		// Token: 0x06005DE8 RID: 24040 RVA: 0x001BF2B8 File Offset: 0x001BD4B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200273, XrefRangeEnd = 200276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(Writer writer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClothingInstance.NativeMethodInfoPtr_Write_Public_Virtual_Void_Writer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DE9 RID: 24041 RVA: 0x001BF308 File Offset: 0x001BD508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200276, XrefRangeEnd = 200277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Read(Reader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClothingInstance.NativeMethodInfoPtr_Read_Public_Virtual_Void_Reader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DEA RID: 24042 RVA: 0x0002C7DB File Offset: 0x0002A9DB
		public ClothingInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CFE RID: 7422
		// (get) Token: 0x06005DEB RID: 24043 RVA: 0x001BF358 File Offset: 0x001BD558
		// (set) Token: 0x06005DEC RID: 24044 RVA: 0x0002C7E4 File Offset: 0x0002A9E4
		public unsafe EClothingColor Color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingInstance.NativeFieldInfoPtr_Color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingInstance.NativeFieldInfoPtr_Color)) = value;
			}
		}

		// Token: 0x04004065 RID: 16485
		private static readonly IntPtr NativeFieldInfoPtr_Color;

		// Token: 0x04004066 RID: 16486
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x04004067 RID: 16487
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_EClothingColor_0;

		// Token: 0x04004068 RID: 16488
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04004069 RID: 16489
		private static readonly IntPtr NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0;

		// Token: 0x0400406A RID: 16490
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Writer_0;

		// Token: 0x0400406B RID: 16491
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Void_Reader_0;
	}
}
