using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000124 RID: 292
	public sealed class ContextMenu : Attribute
	{
		// Token: 0x0600177F RID: 6015 RVA: 0x00065830 File Offset: 0x00063A30
		// Note: this type is marked as 'beforefieldinit'.
		static ContextMenu()
		{
			Il2CppClassPointerStore<ContextMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ContextMenu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContextMenu>.NativeClassPtr);
			ContextMenu.NativeFieldInfoPtr_menuItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextMenu>.NativeClassPtr, "menuItem");
			ContextMenu.NativeFieldInfoPtr_validate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextMenu>.NativeClassPtr, "validate");
			ContextMenu.NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextMenu>.NativeClassPtr, "priority");
			ContextMenu.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextMenu>.NativeClassPtr, 100665759);
			ContextMenu.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextMenu>.NativeClassPtr, 100665760);
			ContextMenu.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextMenu>.NativeClassPtr, 100665761);
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x000658D8 File Offset: 0x00063AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247088, XrefRangeEnd = 1247090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContextMenu(string itemName) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextMenu>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(itemName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextMenu.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x00065924 File Offset: 0x00063B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247090, XrefRangeEnd = 1247092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContextMenu(string itemName, bool isValidateFunction) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextMenu>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(itemName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isValidateFunction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextMenu.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001782 RID: 6018 RVA: 0x00065980 File Offset: 0x00063B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247092, XrefRangeEnd = 1247094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContextMenu(string itemName, bool isValidateFunction, int priority) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextMenu>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(itemName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isValidateFunction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextMenu.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001783 RID: 6019 RVA: 0x0000BB13 File Offset: 0x00009D13
		public ContextMenu(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06001784 RID: 6020 RVA: 0x000659E8 File Offset: 0x00063BE8
		// (set) Token: 0x06001785 RID: 6021 RVA: 0x0000BB1C File Offset: 0x00009D1C
		public unsafe string menuItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextMenu.NativeFieldInfoPtr_menuItem);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextMenu.NativeFieldInfoPtr_menuItem), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06001786 RID: 6022 RVA: 0x00065A10 File Offset: 0x00063C10
		// (set) Token: 0x06001787 RID: 6023 RVA: 0x0000BB3B File Offset: 0x00009D3B
		public unsafe bool validate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextMenu.NativeFieldInfoPtr_validate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextMenu.NativeFieldInfoPtr_validate)) = value;
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06001788 RID: 6024 RVA: 0x00065A38 File Offset: 0x00063C38
		// (set) Token: 0x06001789 RID: 6025 RVA: 0x0000BB56 File Offset: 0x00009D56
		public unsafe int priority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextMenu.NativeFieldInfoPtr_priority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextMenu.NativeFieldInfoPtr_priority)) = value;
			}
		}

		// Token: 0x040013E5 RID: 5093
		private static readonly IntPtr NativeFieldInfoPtr_menuItem;

		// Token: 0x040013E6 RID: 5094
		private static readonly IntPtr NativeFieldInfoPtr_validate;

		// Token: 0x040013E7 RID: 5095
		private static readonly IntPtr NativeFieldInfoPtr_priority;

		// Token: 0x040013E8 RID: 5096
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040013E9 RID: 5097
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0;

		// Token: 0x040013EA RID: 5098
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Int32_0;
	}
}
