using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000123 RID: 291
	public sealed class CreateAssetMenuAttribute : Attribute
	{
		// Token: 0x06001770 RID: 6000 RVA: 0x000655F8 File Offset: 0x000637F8
		// Note: this type is marked as 'beforefieldinit'.
		static CreateAssetMenuAttribute()
		{
			Il2CppClassPointerStore<CreateAssetMenuAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "CreateAssetMenuAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateAssetMenuAttribute>.NativeClassPtr);
			CreateAssetMenuAttribute.NativeFieldInfoPtr__menuName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateAssetMenuAttribute>.NativeClassPtr, "<menuName>k__BackingField");
			CreateAssetMenuAttribute.NativeFieldInfoPtr__fileName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateAssetMenuAttribute>.NativeClassPtr, "<fileName>k__BackingField");
			CreateAssetMenuAttribute.NativeFieldInfoPtr__order_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateAssetMenuAttribute>.NativeClassPtr, "<order>k__BackingField");
			CreateAssetMenuAttribute.NativeMethodInfoPtr_set_menuName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateAssetMenuAttribute>.NativeClassPtr, 100665755);
			CreateAssetMenuAttribute.NativeMethodInfoPtr_set_fileName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateAssetMenuAttribute>.NativeClassPtr, 100665756);
			CreateAssetMenuAttribute.NativeMethodInfoPtr_set_order_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateAssetMenuAttribute>.NativeClassPtr, 100665757);
			CreateAssetMenuAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateAssetMenuAttribute>.NativeClassPtr, 100665758);
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x0600177C RID: 6012 RVA: 0x0000BAFB File Offset: 0x00009CFB
		// (set) Token: 0x06001771 RID: 6001 RVA: 0x000656B4 File Offset: 0x000638B4
		public unsafe string menuName
		{
			get
			{
				return this._menuName_k__BackingField;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29107, RefRangeEnd = 29109, XrefRangeStart = 29107, XrefRangeEnd = 29109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateAssetMenuAttribute.NativeMethodInfoPtr_set_menuName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x0600177D RID: 6013 RVA: 0x0000BB03 File Offset: 0x00009D03
		// (set) Token: 0x06001772 RID: 6002 RVA: 0x000656F8 File Offset: 0x000638F8
		public unsafe string fileName
		{
			get
			{
				return this._fileName_k__BackingField;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateAssetMenuAttribute.NativeMethodInfoPtr_set_fileName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x0600177E RID: 6014 RVA: 0x0000BB0B File Offset: 0x00009D0B
		// (set) Token: 0x06001773 RID: 6003 RVA: 0x0006573C File Offset: 0x0006393C
		public unsafe int order
		{
			get
			{
				return this._order_k__BackingField;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29057, RefRangeEnd = 29058, XrefRangeStart = 29057, XrefRangeEnd = 29058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateAssetMenuAttribute.NativeMethodInfoPtr_set_order_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001774 RID: 6004 RVA: 0x0006577C File Offset: 0x0006397C
		[CallerCount(207)]
		[CachedScanResults(RefRangeStart = 360552, RefRangeEnd = 360759, XrefRangeStart = 360552, XrefRangeEnd = 360759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CreateAssetMenuAttribute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateAssetMenuAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateAssetMenuAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001775 RID: 6005 RVA: 0x0000BA99 File Offset: 0x00009C99
		public CreateAssetMenuAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06001776 RID: 6006 RVA: 0x000657B8 File Offset: 0x000639B8
		// (set) Token: 0x06001777 RID: 6007 RVA: 0x0000BAA2 File Offset: 0x00009CA2
		public unsafe string _menuName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateAssetMenuAttribute.NativeFieldInfoPtr__menuName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateAssetMenuAttribute.NativeFieldInfoPtr__menuName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06001778 RID: 6008 RVA: 0x000657E0 File Offset: 0x000639E0
		// (set) Token: 0x06001779 RID: 6009 RVA: 0x0000BAC1 File Offset: 0x00009CC1
		public unsafe string _fileName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateAssetMenuAttribute.NativeFieldInfoPtr__fileName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateAssetMenuAttribute.NativeFieldInfoPtr__fileName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x0600177A RID: 6010 RVA: 0x00065808 File Offset: 0x00063A08
		// (set) Token: 0x0600177B RID: 6011 RVA: 0x0000BAE0 File Offset: 0x00009CE0
		public unsafe int _order_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateAssetMenuAttribute.NativeFieldInfoPtr__order_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateAssetMenuAttribute.NativeFieldInfoPtr__order_k__BackingField)) = value;
			}
		}

		// Token: 0x040013DE RID: 5086
		private static readonly IntPtr NativeFieldInfoPtr__menuName_k__BackingField;

		// Token: 0x040013DF RID: 5087
		private static readonly IntPtr NativeFieldInfoPtr__fileName_k__BackingField;

		// Token: 0x040013E0 RID: 5088
		private static readonly IntPtr NativeFieldInfoPtr__order_k__BackingField;

		// Token: 0x040013E1 RID: 5089
		private static readonly IntPtr NativeMethodInfoPtr_set_menuName_Public_set_Void_String_0;

		// Token: 0x040013E2 RID: 5090
		private static readonly IntPtr NativeMethodInfoPtr_set_fileName_Public_set_Void_String_0;

		// Token: 0x040013E3 RID: 5091
		private static readonly IntPtr NativeMethodInfoPtr_set_order_Public_set_Void_Int32_0;

		// Token: 0x040013E4 RID: 5092
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
