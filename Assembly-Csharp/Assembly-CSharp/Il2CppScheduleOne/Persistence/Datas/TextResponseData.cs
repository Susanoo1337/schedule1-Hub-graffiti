using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000273 RID: 627
	[Serializable]
	public class TextResponseData : Object
	{
		// Token: 0x0600315E RID: 12638 RVA: 0x0011E4B0 File Offset: 0x0011C6B0
		// Note: this type is marked as 'beforefieldinit'.
		static TextResponseData()
		{
			Il2CppClassPointerStore<TextResponseData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "TextResponseData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextResponseData>.NativeClassPtr);
			TextResponseData.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextResponseData>.NativeClassPtr, "Text");
			TextResponseData.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextResponseData>.NativeClassPtr, "Label");
			TextResponseData.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextResponseData>.NativeClassPtr, 100669472);
			TextResponseData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextResponseData>.NativeClassPtr, 100669473);
		}

		// Token: 0x0600315F RID: 12639 RVA: 0x0011E530 File Offset: 0x0011C730
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 100943, RefRangeEnd = 100996, XrefRangeStart = 100943, XrefRangeEnd = 100996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextResponseData(string text, string label) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextResponseData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextResponseData.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003160 RID: 12640 RVA: 0x0011E590 File Offset: 0x0011C790
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 135485, RefRangeEnd = 135486, XrefRangeStart = 135477, XrefRangeEnd = 135485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextResponseData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextResponseData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextResponseData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003161 RID: 12641 RVA: 0x000197B2 File Offset: 0x000179B2
		public TextResponseData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FC6 RID: 4038
		// (get) Token: 0x06003162 RID: 12642 RVA: 0x0011E5CC File Offset: 0x0011C7CC
		// (set) Token: 0x06003163 RID: 12643 RVA: 0x000197BB File Offset: 0x000179BB
		public unsafe string Text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextResponseData.NativeFieldInfoPtr_Text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextResponseData.NativeFieldInfoPtr_Text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FC7 RID: 4039
		// (get) Token: 0x06003164 RID: 12644 RVA: 0x0011E5F4 File Offset: 0x0011C7F4
		// (set) Token: 0x06003165 RID: 12645 RVA: 0x000197DA File Offset: 0x000179DA
		public unsafe string Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextResponseData.NativeFieldInfoPtr_Label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextResponseData.NativeFieldInfoPtr_Label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040020F6 RID: 8438
		private static readonly IntPtr NativeFieldInfoPtr_Text;

		// Token: 0x040020F7 RID: 8439
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x040020F8 RID: 8440
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x040020F9 RID: 8441
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
