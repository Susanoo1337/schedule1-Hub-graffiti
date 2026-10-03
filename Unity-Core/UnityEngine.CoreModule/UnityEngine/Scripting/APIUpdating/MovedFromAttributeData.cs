using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Scripting.APIUpdating
{
	// Token: 0x020001B0 RID: 432
	public sealed class MovedFromAttributeData : ValueType
	{
		// Token: 0x06001FC7 RID: 8135 RVA: 0x000827B4 File Offset: 0x000809B4
		// Note: this type is marked as 'beforefieldinit'.
		static MovedFromAttributeData()
		{
			Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Scripting.APIUpdating", "MovedFromAttributeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr);
			MovedFromAttributeData.NativeFieldInfoPtr_className = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, "className");
			MovedFromAttributeData.NativeFieldInfoPtr_nameSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, "nameSpace");
			MovedFromAttributeData.NativeFieldInfoPtr_assembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, "assembly");
			MovedFromAttributeData.NativeFieldInfoPtr_classHasChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, "classHasChanged");
			MovedFromAttributeData.NativeFieldInfoPtr_nameSpaceHasChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, "nameSpaceHasChanged");
			MovedFromAttributeData.NativeFieldInfoPtr_assemblyHasChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, "assemblyHasChanged");
			MovedFromAttributeData.NativeFieldInfoPtr_autoUdpateAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, "autoUdpateAPI");
			MovedFromAttributeData.NativeMethodInfoPtr_Set_Public_Void_Boolean_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, 100666771);
		}

		// Token: 0x06001FC8 RID: 8136 RVA: 0x00082884 File Offset: 0x00080A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285914, XrefRangeEnd = 1285917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(bool autoUpdateAPI, string sourceNamespace = null, string sourceAssembly = null, string sourceClassName = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref autoUpdateAPI;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sourceNamespace);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sourceAssembly);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sourceClassName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MovedFromAttributeData.NativeMethodInfoPtr_Set_Public_Void_Boolean_String_String_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FC9 RID: 8137 RVA: 0x0000EB98 File Offset: 0x0000CD98
		public MovedFromAttributeData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06001FCA RID: 8138 RVA: 0x0000EBA1 File Offset: 0x0000CDA1
		public MovedFromAttributeData() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr))
		{
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x06001FCB RID: 8139 RVA: 0x00082900 File Offset: 0x00080B00
		// (set) Token: 0x06001FCC RID: 8140 RVA: 0x0000EBB3 File Offset: 0x0000CDB3
		public unsafe string className
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_className);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_className), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x06001FCD RID: 8141 RVA: 0x00082928 File Offset: 0x00080B28
		// (set) Token: 0x06001FCE RID: 8142 RVA: 0x0000EBD2 File Offset: 0x0000CDD2
		public unsafe string nameSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_nameSpace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_nameSpace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06001FCF RID: 8143 RVA: 0x00082950 File Offset: 0x00080B50
		// (set) Token: 0x06001FD0 RID: 8144 RVA: 0x0000EBF1 File Offset: 0x0000CDF1
		public unsafe string assembly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_assembly);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_assembly), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06001FD1 RID: 8145 RVA: 0x00082978 File Offset: 0x00080B78
		// (set) Token: 0x06001FD2 RID: 8146 RVA: 0x0000EC10 File Offset: 0x0000CE10
		public unsafe bool classHasChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_classHasChanged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_classHasChanged)) = value;
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06001FD3 RID: 8147 RVA: 0x000829A0 File Offset: 0x00080BA0
		// (set) Token: 0x06001FD4 RID: 8148 RVA: 0x0000EC2B File Offset: 0x0000CE2B
		public unsafe bool nameSpaceHasChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_nameSpaceHasChanged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_nameSpaceHasChanged)) = value;
			}
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06001FD5 RID: 8149 RVA: 0x000829C8 File Offset: 0x00080BC8
		// (set) Token: 0x06001FD6 RID: 8150 RVA: 0x0000EC46 File Offset: 0x0000CE46
		public unsafe bool assemblyHasChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_assemblyHasChanged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_assemblyHasChanged)) = value;
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06001FD7 RID: 8151 RVA: 0x000829F0 File Offset: 0x00080BF0
		// (set) Token: 0x06001FD8 RID: 8152 RVA: 0x0000EC61 File Offset: 0x0000CE61
		public unsafe bool autoUdpateAPI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_autoUdpateAPI);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_autoUdpateAPI)) = value;
			}
		}

		// Token: 0x040019CF RID: 6607
		private static readonly IntPtr NativeFieldInfoPtr_className;

		// Token: 0x040019D0 RID: 6608
		private static readonly IntPtr NativeFieldInfoPtr_nameSpace;

		// Token: 0x040019D1 RID: 6609
		private static readonly IntPtr NativeFieldInfoPtr_assembly;

		// Token: 0x040019D2 RID: 6610
		private static readonly IntPtr NativeFieldInfoPtr_classHasChanged;

		// Token: 0x040019D3 RID: 6611
		private static readonly IntPtr NativeFieldInfoPtr_nameSpaceHasChanged;

		// Token: 0x040019D4 RID: 6612
		private static readonly IntPtr NativeFieldInfoPtr_assemblyHasChanged;

		// Token: 0x040019D5 RID: 6613
		private static readonly IntPtr NativeFieldInfoPtr_autoUdpateAPI;

		// Token: 0x040019D6 RID: 6614
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_Boolean_String_String_String_0;
	}
}
