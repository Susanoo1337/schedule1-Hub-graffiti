using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000111 RID: 273
	public sealed class TextAreaAttribute : PropertyAttribute
	{
		// Token: 0x060016A1 RID: 5793 RVA: 0x00062D64 File Offset: 0x00060F64
		// Note: this type is marked as 'beforefieldinit'.
		static TextAreaAttribute()
		{
			Il2CppClassPointerStore<TextAreaAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "TextAreaAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextAreaAttribute>.NativeClassPtr);
			TextAreaAttribute.NativeFieldInfoPtr_minLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextAreaAttribute>.NativeClassPtr, "minLines");
			TextAreaAttribute.NativeFieldInfoPtr_maxLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextAreaAttribute>.NativeClassPtr, "maxLines");
			TextAreaAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAreaAttribute>.NativeClassPtr, 100665677);
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x00062DD0 File Offset: 0x00060FD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextAreaAttribute(int minLines, int maxLines) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextAreaAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minLines;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxLines;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextAreaAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x0000B58C File Offset: 0x0000978C
		public TextAreaAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x060016A4 RID: 5796 RVA: 0x00062E28 File Offset: 0x00061028
		// (set) Token: 0x060016A5 RID: 5797 RVA: 0x0000B595 File Offset: 0x00009795
		public unsafe int minLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextAreaAttribute.NativeFieldInfoPtr_minLines);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextAreaAttribute.NativeFieldInfoPtr_minLines)) = value;
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x060016A6 RID: 5798 RVA: 0x00062E50 File Offset: 0x00061050
		// (set) Token: 0x060016A7 RID: 5799 RVA: 0x0000B5B0 File Offset: 0x000097B0
		public unsafe int maxLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextAreaAttribute.NativeFieldInfoPtr_maxLines);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextAreaAttribute.NativeFieldInfoPtr_maxLines)) = value;
			}
		}

		// Token: 0x04001365 RID: 4965
		private static readonly IntPtr NativeFieldInfoPtr_minLines;

		// Token: 0x04001366 RID: 4966
		private static readonly IntPtr NativeFieldInfoPtr_maxLines;

		// Token: 0x04001367 RID: 4967
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;
	}
}
