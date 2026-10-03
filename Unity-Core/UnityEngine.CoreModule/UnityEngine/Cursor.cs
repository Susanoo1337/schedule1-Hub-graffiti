using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000EB RID: 235
	public class Cursor : Object
	{
		// Token: 0x060012F0 RID: 4848 RVA: 0x0005440C File Offset: 0x0005260C
		// Note: this type is marked as 'beforefieldinit'.
		static Cursor()
		{
			Il2CppClassPointerStore<Cursor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Cursor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cursor>.NativeClassPtr);
			Cursor.NativeMethodInfoPtr_SetCursor_Public_Static_Void_Texture2D_Vector2_CursorMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor>.NativeClassPtr, 100665163);
			Cursor.NativeMethodInfoPtr_set_visible_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor>.NativeClassPtr, 100665164);
			Cursor.NativeMethodInfoPtr_get_lockState_Public_Static_get_CursorLockMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor>.NativeClassPtr, 100665165);
			Cursor.NativeMethodInfoPtr_set_lockState_Public_Static_set_Void_CursorLockMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor>.NativeClassPtr, 100665166);
			Cursor.NativeMethodInfoPtr_SetCursor_Injected_Private_Static_Void_Texture2D_byref_Vector2_CursorMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor>.NativeClassPtr, 100665167);
			Cursor.get_visibleDelegateField = IL2CPP.ResolveICall<Cursor.get_visibleDelegate>("UnityEngine.Cursor::get_visible");
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x000544B0 File Offset: 0x000526B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1241908, RefRangeEnd = 1241911, XrefRangeStart = 1241906, XrefRangeEnd = 1241908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetCursor(Texture2D texture, Vector2 hotspot, CursorMode cursorMode)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hotspot;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cursorMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cursor.NativeMethodInfoPtr_SetCursor_Public_Static_Void_Texture2D_Vector2_CursorMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x060012F8 RID: 4856 RVA: 0x0000A67F File Offset: 0x0000887F
		// (set) Token: 0x060012F2 RID: 4850 RVA: 0x00054504 File Offset: 0x00052704
		public unsafe static bool visible
		{
			get
			{
				return Cursor.get_visibleDelegateField();
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1241913, RefRangeEnd = 1241919, XrefRangeStart = 1241911, XrefRangeEnd = 1241913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cursor.NativeMethodInfoPtr_set_visible_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x060012F3 RID: 4851 RVA: 0x00054538 File Offset: 0x00052738
		// (set) Token: 0x060012F4 RID: 4852 RVA: 0x00054568 File Offset: 0x00052768
		public unsafe static CursorLockMode lockState
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1241921, RefRangeEnd = 1241928, XrefRangeStart = 1241919, XrefRangeEnd = 1241921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cursor.NativeMethodInfoPtr_get_lockState_Public_Static_get_CursorLockMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1241930, RefRangeEnd = 1241937, XrefRangeStart = 1241928, XrefRangeEnd = 1241930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cursor.NativeMethodInfoPtr_set_lockState_Public_Static_set_Void_CursorLockMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x0005459C File Offset: 0x0005279C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241937, XrefRangeEnd = 1241939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetCursor_Injected(Texture2D texture, ref Vector2 hotspot, CursorMode cursorMode)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hotspot;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cursorMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cursor.NativeMethodInfoPtr_SetCursor_Injected_Private_Static_Void_Texture2D_byref_Vector2_CursorMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x0000A666 File Offset: 0x00008866
		public Cursor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x0000A66F File Offset: 0x0000886F
		public static void SetCursor(Texture2D texture, CursorMode cursorMode)
		{
			Cursor.SetCursor(texture, Vector2.zero, cursorMode);
		}

		// Token: 0x04000F47 RID: 3911
		private static readonly IntPtr NativeMethodInfoPtr_SetCursor_Public_Static_Void_Texture2D_Vector2_CursorMode_0;

		// Token: 0x04000F48 RID: 3912
		private static readonly IntPtr NativeMethodInfoPtr_set_visible_Public_Static_set_Void_Boolean_0;

		// Token: 0x04000F49 RID: 3913
		private static readonly IntPtr NativeMethodInfoPtr_get_lockState_Public_Static_get_CursorLockMode_0;

		// Token: 0x04000F4A RID: 3914
		private static readonly IntPtr NativeMethodInfoPtr_set_lockState_Public_Static_set_Void_CursorLockMode_0;

		// Token: 0x04000F4B RID: 3915
		private static readonly IntPtr NativeMethodInfoPtr_SetCursor_Injected_Private_Static_Void_Texture2D_byref_Vector2_CursorMode_0;

		// Token: 0x04000F4C RID: 3916
		private static readonly Cursor.get_visibleDelegate get_visibleDelegateField;

		// Token: 0x02000870 RID: 2160
		// (Invoke) Token: 0x06003973 RID: 14707
		private delegate bool get_visibleDelegate();
	}
}
