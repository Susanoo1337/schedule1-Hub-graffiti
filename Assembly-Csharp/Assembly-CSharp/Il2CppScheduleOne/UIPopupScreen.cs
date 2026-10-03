using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppScheduleOne
{
	// Token: 0x020000A9 RID: 169
	public class UIPopupScreen : UIScreen
	{
		// Token: 0x06000EC3 RID: 3779 RVA: 0x000AC900 File Offset: 0x000AAB00
		// Note: this type is marked as 'beforefieldinit'.
		static UIPopupScreen()
		{
			Il2CppClassPointerStore<UIPopupScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "UIPopupScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIPopupScreen>.NativeClassPtr);
			UIPopupScreen.NativeFieldInfoPtr_popupID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen>.NativeClassPtr, "popupID");
			UIPopupScreen.NativeMethodInfoPtr_get_PopupID_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen>.NativeClassPtr, 100665165);
			UIPopupScreen.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen>.NativeClassPtr, 100665166);
			UIPopupScreen.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen>.NativeClassPtr, 100665167);
			UIPopupScreen.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen>.NativeClassPtr, 100665168);
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06000EC4 RID: 3780 RVA: 0x000AC994 File Offset: 0x000AAB94
		public unsafe string PopupID
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22015, RefRangeEnd = 22016, XrefRangeStart = 22015, XrefRangeEnd = 22016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen.NativeMethodInfoPtr_get_PopupID_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x000AC9CC File Offset: 0x000AABCC
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Open([Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIPopupScreen.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x000ACA28 File Offset: 0x000AAC28
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIPopupScreen.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x000ACA64 File Offset: 0x000AAC64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 81996, RefRangeEnd = 81998, XrefRangeStart = 81991, XrefRangeEnd = 81996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIPopupScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIPopupScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EC8 RID: 3784 RVA: 0x00008C69 File Offset: 0x00006E69
		public virtual void Open(params Object[] args)
		{
			this.Open(new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000EC9 RID: 3785 RVA: 0x00008C77 File Offset: 0x00006E77
		public UIPopupScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06000ECA RID: 3786 RVA: 0x000ACAA0 File Offset: 0x000AACA0
		// (set) Token: 0x06000ECB RID: 3787 RVA: 0x00008C80 File Offset: 0x00006E80
		public unsafe string popupID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen.NativeFieldInfoPtr_popupID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen.NativeFieldInfoPtr_popupID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000A52 RID: 2642
		private static readonly IntPtr NativeFieldInfoPtr_popupID;

		// Token: 0x04000A53 RID: 2643
		private static readonly IntPtr NativeMethodInfoPtr_get_PopupID_Public_get_String_0;

		// Token: 0x04000A54 RID: 2644
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_New_Void_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000A55 RID: 2645
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0;

		// Token: 0x04000A56 RID: 2646
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
