using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Reporting
{
	// Token: 0x0200013B RID: 315
	public static class ScreenshotUtil : Il2CppSystem.Object
	{
		// Token: 0x06001F77 RID: 8055 RVA: 0x000E1E70 File Offset: 0x000E0070
		// Note: this type is marked as 'beforefieldinit'.
		static ScreenshotUtil()
		{
			Il2CppClassPointerStore<ScreenshotUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Reporting", "ScreenshotUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenshotUtil>.NativeClassPtr);
			ScreenshotUtil.NativeFieldInfoPtr_OnPrepareScreenshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotUtil>.NativeClassPtr, "OnPrepareScreenshot");
			ScreenshotUtil.NativeFieldInfoPtr_OnScreenshotDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotUtil>.NativeClassPtr, "OnScreenshotDone");
			ScreenshotUtil.NativeFieldInfoPtr_BixTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotUtil>.NativeClassPtr, "BixTex");
			ScreenshotUtil.NativeFieldInfoPtr_TexDimensionMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotUtil>.NativeClassPtr, "TexDimensionMax");
			ScreenshotUtil.NativeMethodInfoPtr_add_OnPrepareScreenshot_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotUtil>.NativeClassPtr, 100667361);
			ScreenshotUtil.NativeMethodInfoPtr_remove_OnPrepareScreenshot_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotUtil>.NativeClassPtr, 100667362);
			ScreenshotUtil.NativeMethodInfoPtr_add_OnScreenshotDone_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotUtil>.NativeClassPtr, 100667363);
			ScreenshotUtil.NativeMethodInfoPtr_remove_OnScreenshotDone_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotUtil>.NativeClassPtr, 100667364);
			ScreenshotUtil.NativeMethodInfoPtr_CaptureScreenshot_Public_Static_IEnumerator_Boolean_Action_1_Il2CppStructArray_1_Byte_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotUtil>.NativeClassPtr, 100667365);
			ScreenshotUtil.NativeMethodInfoPtr_CaptureScreenshotAsTexture_Private_Static_IEnumerator_Boolean_Action_1_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotUtil>.NativeClassPtr, 100667366);
			ScreenshotUtil.NativeMethodInfoPtr_Scale_Private_Static_Void_Texture2D_Single_FilterMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotUtil>.NativeClassPtr, 100667367);
		}

		// Token: 0x06001F78 RID: 8056 RVA: 0x000E1F7C File Offset: 0x000E017C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 106840, RefRangeEnd = 106842, XrefRangeStart = 106833, XrefRangeEnd = 106840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnPrepareScreenshot(Action value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotUtil.NativeMethodInfoPtr_add_OnPrepareScreenshot_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F79 RID: 8057 RVA: 0x000E1FB4 File Offset: 0x000E01B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 106849, RefRangeEnd = 106851, XrefRangeStart = 106842, XrefRangeEnd = 106849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnPrepareScreenshot(Action value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotUtil.NativeMethodInfoPtr_remove_OnPrepareScreenshot_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F7A RID: 8058 RVA: 0x000E1FEC File Offset: 0x000E01EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 106858, RefRangeEnd = 106860, XrefRangeStart = 106851, XrefRangeEnd = 106858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnScreenshotDone(Action value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotUtil.NativeMethodInfoPtr_add_OnScreenshotDone_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F7B RID: 8059 RVA: 0x000E2024 File Offset: 0x000E0224
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 106867, RefRangeEnd = 106869, XrefRangeStart = 106860, XrefRangeEnd = 106867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnScreenshotDone(Action value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotUtil.NativeMethodInfoPtr_remove_OnScreenshotDone_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F7C RID: 8060 RVA: 0x000E205C File Offset: 0x000E025C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106869, XrefRangeEnd = 106874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator CaptureScreenshot(bool resizeLargeScreenshots, Action<Il2CppStructArray<byte>> onCapturedCallback, Action<string> onErrorCallback)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref resizeLargeScreenshots;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onCapturedCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onErrorCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotUtil.NativeMethodInfoPtr_CaptureScreenshot_Public_Static_IEnumerator_Boolean_Action_1_Il2CppStructArray_1_Byte_Action_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001F7D RID: 8061 RVA: 0x000E20C0 File Offset: 0x000E02C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator CaptureScreenshotAsTexture(bool resizeLargeScreenshots, Action<Il2CppStructArray<byte>> onCapturedCallback)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref resizeLargeScreenshots;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onCapturedCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotUtil.NativeMethodInfoPtr_CaptureScreenshotAsTexture_Private_Static_IEnumerator_Boolean_Action_1_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001F7E RID: 8062 RVA: 0x000E2114 File Offset: 0x000E0314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106874, XrefRangeEnd = 106893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Scale(Texture2D texture, float scale, FilterMode filterMode = FilterMode.Trilinear, bool updateMipMaps = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filterMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateMipMaps;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotUtil.NativeMethodInfoPtr_Scale_Private_Static_Void_Texture2D_Single_FilterMode_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F7F RID: 8063 RVA: 0x00011086 File Offset: 0x0000F286
		public ScreenshotUtil(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x06001F80 RID: 8064 RVA: 0x000E2174 File Offset: 0x000E0374
		// (set) Token: 0x06001F81 RID: 8065 RVA: 0x0001108F File Offset: 0x0000F28F
		public unsafe static Action OnPrepareScreenshot
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScreenshotUtil.NativeFieldInfoPtr_OnPrepareScreenshot, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScreenshotUtil.NativeFieldInfoPtr_OnPrepareScreenshot, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x06001F82 RID: 8066 RVA: 0x000E219C File Offset: 0x000E039C
		// (set) Token: 0x06001F83 RID: 8067 RVA: 0x000110A1 File Offset: 0x0000F2A1
		public unsafe static Action OnScreenshotDone
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScreenshotUtil.NativeFieldInfoPtr_OnScreenshotDone, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScreenshotUtil.NativeFieldInfoPtr_OnScreenshotDone, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x06001F84 RID: 8068 RVA: 0x000E21C4 File Offset: 0x000E03C4
		// (set) Token: 0x06001F85 RID: 8069 RVA: 0x000110B3 File Offset: 0x0000F2B3
		public unsafe static int BixTex
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ScreenshotUtil.NativeFieldInfoPtr_BixTex, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScreenshotUtil.NativeFieldInfoPtr_BixTex, (void*)(&value));
			}
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x06001F86 RID: 8070 RVA: 0x000E21E0 File Offset: 0x000E03E0
		// (set) Token: 0x06001F87 RID: 8071 RVA: 0x000110C1 File Offset: 0x0000F2C1
		public unsafe static float TexDimensionMax
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ScreenshotUtil.NativeFieldInfoPtr_TexDimensionMax, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScreenshotUtil.NativeFieldInfoPtr_TexDimensionMax, (void*)(&value));
			}
		}

		// Token: 0x040015B7 RID: 5559
		private static readonly IntPtr NativeFieldInfoPtr_OnPrepareScreenshot;

		// Token: 0x040015B8 RID: 5560
		private static readonly IntPtr NativeFieldInfoPtr_OnScreenshotDone;

		// Token: 0x040015B9 RID: 5561
		private static readonly IntPtr NativeFieldInfoPtr_BixTex;

		// Token: 0x040015BA RID: 5562
		private static readonly IntPtr NativeFieldInfoPtr_TexDimensionMax;

		// Token: 0x040015BB RID: 5563
		private static readonly IntPtr NativeMethodInfoPtr_add_OnPrepareScreenshot_Public_Static_add_Void_Action_0;

		// Token: 0x040015BC RID: 5564
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnPrepareScreenshot_Public_Static_rem_Void_Action_0;

		// Token: 0x040015BD RID: 5565
		private static readonly IntPtr NativeMethodInfoPtr_add_OnScreenshotDone_Public_Static_add_Void_Action_0;

		// Token: 0x040015BE RID: 5566
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnScreenshotDone_Public_Static_rem_Void_Action_0;

		// Token: 0x040015BF RID: 5567
		private static readonly IntPtr NativeMethodInfoPtr_CaptureScreenshot_Public_Static_IEnumerator_Boolean_Action_1_Il2CppStructArray_1_Byte_Action_1_String_0;

		// Token: 0x040015C0 RID: 5568
		private static readonly IntPtr NativeMethodInfoPtr_CaptureScreenshotAsTexture_Private_Static_IEnumerator_Boolean_Action_1_Il2CppStructArray_1_Byte_0;

		// Token: 0x040015C1 RID: 5569
		private static readonly IntPtr NativeMethodInfoPtr_Scale_Private_Static_Void_Texture2D_Single_FilterMode_Boolean_0;

		// Token: 0x02000965 RID: 2405
		[ObfuscatedName("ScheduleOne.Reporting.ScreenshotUtil+<CaptureScreenshotAsTexture>d__9")]
		public sealed class _CaptureScreenshotAsTexture_d__9 : Il2CppSystem.Object
		{
			// Token: 0x0600D927 RID: 55591 RVA: 0x0035E958 File Offset: 0x0035CB58
			// Note: this type is marked as 'beforefieldinit'.
			static _CaptureScreenshotAsTexture_d__9()
			{
				Il2CppClassPointerStore<ScreenshotUtil._CaptureScreenshotAsTexture_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScreenshotUtil>.NativeClassPtr, "<CaptureScreenshotAsTexture>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenshotUtil._CaptureScreenshotAsTexture_d__9>.NativeClassPtr);
				ScreenshotUtil._CaptureScreenshotAsTexture_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotUtil._CaptureScreenshotAsTexture_d__9>.NativeClassPtr, "<>1__state");
				ScreenshotUtil._CaptureScreenshotAsTexture_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotUtil._CaptureScreenshotAsTexture_d__9>.NativeClassPtr, "<>2__current");
				ScreenshotUtil._CaptureScreenshotAsTexture_d__9.NativeFieldInfoPtr_resizeLargeScreenshots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotUtil._CaptureScreenshotAsTexture_d__9>.NativeClassPtr, "resizeLargeScreenshots");
				ScreenshotUtil._CaptureScreenshotAsTexture_d__9.NativeFieldInfoPtr_onCapturedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotUtil._CaptureScreenshotAsTexture_d__9>.NativeClassPtr, "onCapturedCallback");
				ScreenshotUtil._CaptureScreenshotAsTexture_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotUtil._CaptureScreenshotAsTexture_d__9>.NativeClassPtr, 100667368);
				ScreenshotUtil._CaptureScreenshotAsTexture_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotUtil._CaptureScreenshotAsTexture_d__9>.NativeClassPtr, 100667369);
				ScreenshotUtil._CaptureScreenshotAsTexture_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotUtil._CaptureScreenshotAsTexture_d__9>.NativeClassPtr, 100667370);
				ScreenshotUtil._CaptureScreenshotAsTexture_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotUtil._CaptureScreenshotAsTexture_d__9>.NativeClassPtr, 100667371);
				ScreenshotUtil._CaptureScreenshotAsTexture_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotUtil._CaptureScreenshotAsTexture_d__9>.NativeClassPtr, 100667372);
				ScreenshotUtil._CaptureScreenshotAsTexture_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotUtil._CaptureScreenshotAsTexture_d__9>.NativeClassPtr, 100667373);
			}

			// Token: 0x0600D928 RID: 55592 RVA: 0x0035EA4C File Offset: 0x0035CC4C
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CaptureScreenshotAsTexture_d__9(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenshotUtil._CaptureScreenshotAsTexture_d__9>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotUtil._CaptureScreenshotAsTexture_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D929 RID: 55593 RVA: 0x0035EA94 File Offset: 0x0035CC94
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotUtil._CaptureScreenshotAsTexture_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D92A RID: 55594 RVA: 0x0035EAC8 File Offset: 0x0035CCC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106820, XrefRangeEnd = 106828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotUtil._CaptureScreenshotAsTexture_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004257 RID: 16983
			// (get) Token: 0x0600D92B RID: 55595 RVA: 0x0035EB04 File Offset: 0x0035CD04
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotUtil._CaptureScreenshotAsTexture_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D92C RID: 55596 RVA: 0x0035EB44 File Offset: 0x0035CD44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106828, XrefRangeEnd = 106833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotUtil._CaptureScreenshotAsTexture_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004258 RID: 16984
			// (get) Token: 0x0600D92D RID: 55597 RVA: 0x0035EB78 File Offset: 0x0035CD78
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotUtil._CaptureScreenshotAsTexture_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D92E RID: 55598 RVA: 0x000661E9 File Offset: 0x000643E9
			public _CaptureScreenshotAsTexture_d__9(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004253 RID: 16979
			// (get) Token: 0x0600D92F RID: 55599 RVA: 0x0035EBB8 File Offset: 0x0035CDB8
			// (set) Token: 0x0600D930 RID: 55600 RVA: 0x000661F2 File Offset: 0x000643F2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotUtil._CaptureScreenshotAsTexture_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotUtil._CaptureScreenshotAsTexture_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004254 RID: 16980
			// (get) Token: 0x0600D931 RID: 55601 RVA: 0x0035EBE0 File Offset: 0x0035CDE0
			// (set) Token: 0x0600D932 RID: 55602 RVA: 0x0006620D File Offset: 0x0006440D
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotUtil._CaptureScreenshotAsTexture_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotUtil._CaptureScreenshotAsTexture_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004255 RID: 16981
			// (get) Token: 0x0600D933 RID: 55603 RVA: 0x0035EC10 File Offset: 0x0035CE10
			// (set) Token: 0x0600D934 RID: 55604 RVA: 0x0006622C File Offset: 0x0006442C
			public unsafe bool resizeLargeScreenshots
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotUtil._CaptureScreenshotAsTexture_d__9.NativeFieldInfoPtr_resizeLargeScreenshots);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotUtil._CaptureScreenshotAsTexture_d__9.NativeFieldInfoPtr_resizeLargeScreenshots)) = value;
				}
			}

			// Token: 0x17004256 RID: 16982
			// (get) Token: 0x0600D935 RID: 55605 RVA: 0x0035EC38 File Offset: 0x0035CE38
			// (set) Token: 0x0600D936 RID: 55606 RVA: 0x00066247 File Offset: 0x00064447
			public unsafe Action<Il2CppStructArray<byte>> onCapturedCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotUtil._CaptureScreenshotAsTexture_d__9.NativeFieldInfoPtr_onCapturedCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Il2CppStructArray<byte>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotUtil._CaptureScreenshotAsTexture_d__9.NativeFieldInfoPtr_onCapturedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400943F RID: 37951
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009440 RID: 37952
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009441 RID: 37953
			private static readonly IntPtr NativeFieldInfoPtr_resizeLargeScreenshots;

			// Token: 0x04009442 RID: 37954
			private static readonly IntPtr NativeFieldInfoPtr_onCapturedCallback;

			// Token: 0x04009443 RID: 37955
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009444 RID: 37956
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009445 RID: 37957
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009446 RID: 37958
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009447 RID: 37959
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009448 RID: 37960
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
