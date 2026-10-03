using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Input
{
	// Token: 0x0200033A RID: 826
	public static class MouseController : Object
	{
		// Token: 0x0600471F RID: 18207 RVA: 0x0016CD18 File Offset: 0x0016AF18
		// Note: this type is marked as 'beforefieldinit'.
		static MouseController()
		{
			Il2CppClassPointerStore<MouseController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Input", "MouseController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseController>.NativeClassPtr);
			MouseController.NativeFieldInfoPtr__IsMouseVisible_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseController>.NativeClassPtr, "<IsMouseVisible>k__BackingField");
			MouseController.NativeMethodInfoPtr_get_IsMouseVisible_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseController>.NativeClassPtr, 100672413);
			MouseController.NativeMethodInfoPtr_set_IsMouseVisible_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseController>.NativeClassPtr, 100672414);
			MouseController.NativeMethodInfoPtr_LockMouse_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseController>.NativeClassPtr, 100672415);
			MouseController.NativeMethodInfoPtr_FreeMouse_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseController>.NativeClassPtr, 100672416);
		}

		// Token: 0x17001661 RID: 5729
		// (get) Token: 0x06004720 RID: 18208 RVA: 0x0016CDAC File Offset: 0x0016AFAC
		// (set) Token: 0x06004721 RID: 18209 RVA: 0x0016CDDC File Offset: 0x0016AFDC
		public unsafe static bool IsMouseVisible
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166344, XrefRangeEnd = 166348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseController.NativeMethodInfoPtr_get_IsMouseVisible_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166348, XrefRangeEnd = 166352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseController.NativeMethodInfoPtr_set_IsMouseVisible_Private_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004722 RID: 18210 RVA: 0x0016CE10 File Offset: 0x0016B010
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 166368, RefRangeEnd = 166371, XrefRangeStart = 166352, XrefRangeEnd = 166368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LockMouse(bool showCrosshair = true)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref showCrosshair;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseController.NativeMethodInfoPtr_LockMouse_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004723 RID: 18211 RVA: 0x0016CE44 File Offset: 0x0016B044
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 166391, RefRangeEnd = 166395, XrefRangeStart = 166371, XrefRangeEnd = 166391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FreeMouse(bool hideCrosshair = true)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hideCrosshair;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseController.NativeMethodInfoPtr_FreeMouse_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004724 RID: 18212 RVA: 0x00022BEF File Offset: 0x00020DEF
		public MouseController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001660 RID: 5728
		// (get) Token: 0x06004725 RID: 18213 RVA: 0x0016CE78 File Offset: 0x0016B078
		// (set) Token: 0x06004726 RID: 18214 RVA: 0x00022BF8 File Offset: 0x00020DF8
		public unsafe static bool _IsMouseVisible_k__BackingField
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(MouseController.NativeFieldInfoPtr__IsMouseVisible_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MouseController.NativeFieldInfoPtr__IsMouseVisible_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x0400305F RID: 12383
		private static readonly IntPtr NativeFieldInfoPtr__IsMouseVisible_k__BackingField;

		// Token: 0x04003060 RID: 12384
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMouseVisible_Public_Static_get_Boolean_0;

		// Token: 0x04003061 RID: 12385
		private static readonly IntPtr NativeMethodInfoPtr_set_IsMouseVisible_Private_Static_set_Void_Boolean_0;

		// Token: 0x04003062 RID: 12386
		private static readonly IntPtr NativeMethodInfoPtr_LockMouse_Public_Static_Void_Boolean_0;

		// Token: 0x04003063 RID: 12387
		private static readonly IntPtr NativeMethodInfoPtr_FreeMouse_Public_Static_Void_Boolean_0;
	}
}
