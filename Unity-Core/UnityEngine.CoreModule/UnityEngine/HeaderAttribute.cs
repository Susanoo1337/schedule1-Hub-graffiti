using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200010D RID: 269
	public class HeaderAttribute : PropertyAttribute
	{
		// Token: 0x0600168B RID: 5771 RVA: 0x00062A00 File Offset: 0x00060C00
		// Note: this type is marked as 'beforefieldinit'.
		static HeaderAttribute()
		{
			Il2CppClassPointerStore<HeaderAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "HeaderAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeaderAttribute>.NativeClassPtr);
			HeaderAttribute.NativeFieldInfoPtr_header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderAttribute>.NativeClassPtr, "header");
			HeaderAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderAttribute>.NativeClassPtr, 100665673);
		}

		// Token: 0x0600168C RID: 5772 RVA: 0x00062A58 File Offset: 0x00060C58
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 31934, RefRangeEnd = 31959, XrefRangeStart = 31934, XrefRangeEnd = 31959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HeaderAttribute(string header) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeaderAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(header);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeaderAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600168D RID: 5773 RVA: 0x0000B4DD File Offset: 0x000096DD
		public HeaderAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x0600168E RID: 5774 RVA: 0x00062AA4 File Offset: 0x00060CA4
		// (set) Token: 0x0600168F RID: 5775 RVA: 0x0000B4E6 File Offset: 0x000096E6
		public unsafe string header
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderAttribute.NativeFieldInfoPtr_header);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderAttribute.NativeFieldInfoPtr_header), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400135C RID: 4956
		private static readonly IntPtr NativeFieldInfoPtr_header;

		// Token: 0x0400135D RID: 4957
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
