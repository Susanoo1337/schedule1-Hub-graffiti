using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Scripting.APIUpdating
{
	// Token: 0x020001B1 RID: 433
	public class MovedFromAttribute : Attribute
	{
		// Token: 0x06001FD9 RID: 8153 RVA: 0x00082A18 File Offset: 0x00080C18
		// Note: this type is marked as 'beforefieldinit'.
		static MovedFromAttribute()
		{
			Il2CppClassPointerStore<MovedFromAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Scripting.APIUpdating", "MovedFromAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MovedFromAttribute>.NativeClassPtr);
			MovedFromAttribute.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttribute>.NativeClassPtr, "data");
			MovedFromAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MovedFromAttribute>.NativeClassPtr, 100666772);
			MovedFromAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MovedFromAttribute>.NativeClassPtr, 100666773);
		}

		// Token: 0x06001FDA RID: 8154 RVA: 0x00082A84 File Offset: 0x00080C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285917, XrefRangeEnd = 1285921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MovedFromAttribute(bool autoUpdateAPI, string sourceNamespace = null, string sourceAssembly = null, string sourceClassName = null) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MovedFromAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref autoUpdateAPI;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sourceNamespace);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sourceAssembly);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sourceClassName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MovedFromAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FDB RID: 8155 RVA: 0x00082B04 File Offset: 0x00080D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285921, XrefRangeEnd = 1285925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MovedFromAttribute(string sourceNamespace) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MovedFromAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MovedFromAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FDC RID: 8156 RVA: 0x0000EC7C File Offset: 0x0000CE7C
		public MovedFromAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06001FDD RID: 8157 RVA: 0x00082B50 File Offset: 0x00080D50
		// (set) Token: 0x06001FDE RID: 8158 RVA: 0x0000EC85 File Offset: 0x0000CE85
		public MovedFromAttributeData data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttribute.NativeFieldInfoPtr_data);
				return new MovedFromAttributeData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttribute.NativeFieldInfoPtr_data), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06001FDF RID: 8159 RVA: 0x0000ECB3 File Offset: 0x0000CEB3
		public bool AffectsAPIUpdater
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x06001FE0 RID: 8160 RVA: 0x0000ECC0 File Offset: 0x0000CEC0
		public bool IsInDifferentAssembly
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x040019D7 RID: 6615
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x040019D8 RID: 6616
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_String_String_String_0;

		// Token: 0x040019D9 RID: 6617
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
