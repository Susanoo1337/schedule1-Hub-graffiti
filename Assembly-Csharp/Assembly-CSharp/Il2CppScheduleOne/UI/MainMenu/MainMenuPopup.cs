using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppTMPro;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x020007F9 RID: 2041
	public class MainMenuPopup : Singleton<MainMenuPopup>
	{
		// Token: 0x0600C691 RID: 50833 RVA: 0x00324CC4 File Offset: 0x00322EC4
		// Note: this type is marked as 'beforefieldinit'.
		static MainMenuPopup()
		{
			Il2CppClassPointerStore<MainMenuPopup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "MainMenuPopup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainMenuPopup>.NativeClassPtr);
			MainMenuPopup.NativeFieldInfoPtr_Screen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuPopup>.NativeClassPtr, "Screen");
			MainMenuPopup.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuPopup>.NativeClassPtr, "Title");
			MainMenuPopup.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuPopup>.NativeClassPtr, "Description");
			MainMenuPopup.NativeMethodInfoPtr_Open_Public_Void_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuPopup>.NativeClassPtr, 100689018);
			MainMenuPopup.NativeMethodInfoPtr_Open_Public_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuPopup>.NativeClassPtr, 100689019);
			MainMenuPopup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuPopup>.NativeClassPtr, 100689020);
		}

		// Token: 0x0600C692 RID: 50834 RVA: 0x00324D6C File Offset: 0x00322F6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 327856, RefRangeEnd = 327858, XrefRangeStart = 327854, XrefRangeEnd = 327856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(MainMenuPopup.Data data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuPopup.NativeMethodInfoPtr_Open_Public_Void_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C693 RID: 50835 RVA: 0x00324DB0 File Offset: 0x00322FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327858, XrefRangeEnd = 327860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(string title, string description, bool isBad)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isBad;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuPopup.NativeMethodInfoPtr_Open_Public_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C694 RID: 50836 RVA: 0x00324E14 File Offset: 0x00323014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327860, XrefRangeEnd = 327863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MainMenuPopup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainMenuPopup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuPopup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C695 RID: 50837 RVA: 0x0005DBD1 File Offset: 0x0005BDD1
		public MainMenuPopup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003C41 RID: 15425
		// (get) Token: 0x0600C696 RID: 50838 RVA: 0x00324E50 File Offset: 0x00323050
		// (set) Token: 0x0600C697 RID: 50839 RVA: 0x0005DBDA File Offset: 0x0005BDDA
		public unsafe MenuScreen Screen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.NativeFieldInfoPtr_Screen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MenuScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.NativeFieldInfoPtr_Screen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C42 RID: 15426
		// (get) Token: 0x0600C698 RID: 50840 RVA: 0x00324E80 File Offset: 0x00323080
		// (set) Token: 0x0600C699 RID: 50841 RVA: 0x0005DBF9 File Offset: 0x0005BDF9
		public unsafe TextMeshProUGUI Title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.NativeFieldInfoPtr_Title);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.NativeFieldInfoPtr_Title), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C43 RID: 15427
		// (get) Token: 0x0600C69A RID: 50842 RVA: 0x00324EB0 File Offset: 0x003230B0
		// (set) Token: 0x0600C69B RID: 50843 RVA: 0x0005DC18 File Offset: 0x0005BE18
		public unsafe TextMeshProUGUI Description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.NativeFieldInfoPtr_Description);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.NativeFieldInfoPtr_Description), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400876F RID: 34671
		private static readonly IntPtr NativeFieldInfoPtr_Screen;

		// Token: 0x04008770 RID: 34672
		private static readonly IntPtr NativeFieldInfoPtr_Title;

		// Token: 0x04008771 RID: 34673
		private static readonly IntPtr NativeFieldInfoPtr_Description;

		// Token: 0x04008772 RID: 34674
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_Data_0;

		// Token: 0x04008773 RID: 34675
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_String_String_Boolean_0;

		// Token: 0x04008774 RID: 34676
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D68 RID: 3432
		public class Data : Object
		{
			// Token: 0x0600FB19 RID: 64281 RVA: 0x003BF824 File Offset: 0x003BDA24
			// Note: this type is marked as 'beforefieldinit'.
			static Data()
			{
				Il2CppClassPointerStore<MainMenuPopup.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MainMenuPopup>.NativeClassPtr, "Data");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainMenuPopup.Data>.NativeClassPtr);
				MainMenuPopup.Data.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuPopup.Data>.NativeClassPtr, "Title");
				MainMenuPopup.Data.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuPopup.Data>.NativeClassPtr, "Description");
				MainMenuPopup.Data.NativeFieldInfoPtr_IsBad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuPopup.Data>.NativeClassPtr, "IsBad");
				MainMenuPopup.Data.NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuPopup.Data>.NativeClassPtr, 100689021);
			}

			// Token: 0x0600FB1A RID: 64282 RVA: 0x003BF8A0 File Offset: 0x003BDAA0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 327852, RefRangeEnd = 327854, XrefRangeStart = 327849, XrefRangeEnd = 327852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Data(string title, string description, bool isBad) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainMenuPopup.Data>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isBad;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuPopup.Data.NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FB1B RID: 64283 RVA: 0x00076CB2 File Offset: 0x00074EB2
			public Data(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C4C RID: 19532
			// (get) Token: 0x0600FB1C RID: 64284 RVA: 0x003BF90C File Offset: 0x003BDB0C
			// (set) Token: 0x0600FB1D RID: 64285 RVA: 0x00076CBB File Offset: 0x00074EBB
			public unsafe string Title
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.Data.NativeFieldInfoPtr_Title);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.Data.NativeFieldInfoPtr_Title), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004C4D RID: 19533
			// (get) Token: 0x0600FB1E RID: 64286 RVA: 0x003BF934 File Offset: 0x003BDB34
			// (set) Token: 0x0600FB1F RID: 64287 RVA: 0x00076CDA File Offset: 0x00074EDA
			public unsafe string Description
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.Data.NativeFieldInfoPtr_Description);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.Data.NativeFieldInfoPtr_Description), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004C4E RID: 19534
			// (get) Token: 0x0600FB20 RID: 64288 RVA: 0x003BF95C File Offset: 0x003BDB5C
			// (set) Token: 0x0600FB21 RID: 64289 RVA: 0x00076CF9 File Offset: 0x00074EF9
			public unsafe bool IsBad
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.Data.NativeFieldInfoPtr_IsBad);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.Data.NativeFieldInfoPtr_IsBad)) = value;
				}
			}

			// Token: 0x0400A96B RID: 43371
			private static readonly IntPtr NativeFieldInfoPtr_Title;

			// Token: 0x0400A96C RID: 43372
			private static readonly IntPtr NativeFieldInfoPtr_Description;

			// Token: 0x0400A96D RID: 43373
			private static readonly IntPtr NativeFieldInfoPtr_IsBad;

			// Token: 0x0400A96E RID: 43374
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_0;
		}
	}
}
