using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text.RegularExpressions;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x020003FE RID: 1022
	public static class PlayerLogExporter : Object
	{
		// Token: 0x06005AA0 RID: 23200 RVA: 0x001B3ECC File Offset: 0x001B20CC
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerLogExporter()
		{
			Il2CppClassPointerStore<PlayerLogExporter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "PlayerLogExporter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerLogExporter>.NativeClassPtr);
			PlayerLogExporter.NativeFieldInfoPtr__onSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLogExporter>.NativeClassPtr, "_onSuccess");
			PlayerLogExporter.NativeFieldInfoPtr_ExcludedRegexes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLogExporter>.NativeClassPtr, "ExcludedRegexes");
			PlayerLogExporter.NativeMethodInfoPtr_ExportPlayerLog_Public_Static_Void_Boolean_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLogExporter>.NativeClassPtr, 100675137);
			PlayerLogExporter.NativeMethodInfoPtr_SavePathSelected_Private_Static_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLogExporter>.NativeClassPtr, 100675138);
			PlayerLogExporter.NativeMethodInfoPtr_FilterLog_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLogExporter>.NativeClassPtr, 100675139);
			PlayerLogExporter.NativeMethodInfoPtr_ReadFileShared_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLogExporter>.NativeClassPtr, 100675140);
			PlayerLogExporter.NativeMethodInfoPtr_GetLogPath_Public_Static_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLogExporter>.NativeClassPtr, 100675141);
		}

		// Token: 0x06005AA1 RID: 23201 RVA: 0x001B3F88 File Offset: 0x001B2188
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195794, RefRangeEnd = 195795, XrefRangeStart = 195746, XrefRangeEnd = 195794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExportPlayerLog(bool previous, Action onSuccess = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref previous;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onSuccess);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerLogExporter.NativeMethodInfoPtr_ExportPlayerLog_Public_Static_Void_Boolean_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AA2 RID: 23202 RVA: 0x001B3FCC File Offset: 0x001B21CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195866, RefRangeEnd = 195867, XrefRangeStart = 195795, XrefRangeEnd = 195866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SavePathSelected(string savePath, bool previous)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(savePath);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref previous;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerLogExporter.NativeMethodInfoPtr_SavePathSelected_Private_Static_Void_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AA3 RID: 23203 RVA: 0x001B4010 File Offset: 0x001B2210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195867, XrefRangeEnd = 195885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FilterLog(string log)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(log);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerLogExporter.NativeMethodInfoPtr_FilterLog_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005AA4 RID: 23204 RVA: 0x001B404C File Offset: 0x001B224C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195903, RefRangeEnd = 195904, XrefRangeStart = 195885, XrefRangeEnd = 195903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ReadFileShared(string path)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerLogExporter.NativeMethodInfoPtr_ReadFileShared_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005AA5 RID: 23205 RVA: 0x001B4088 File Offset: 0x001B2288
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 195916, RefRangeEnd = 195918, XrefRangeStart = 195904, XrefRangeEnd = 195916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetLogPath(bool previous)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref previous;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerLogExporter.NativeMethodInfoPtr_GetLogPath_Public_Static_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005AA6 RID: 23206 RVA: 0x0002AF3D File Offset: 0x0002913D
		public PlayerLogExporter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001BF7 RID: 7159
		// (get) Token: 0x06005AA7 RID: 23207 RVA: 0x001B40C0 File Offset: 0x001B22C0
		// (set) Token: 0x06005AA8 RID: 23208 RVA: 0x0002AF46 File Offset: 0x00029146
		public unsafe static Action _onSuccess
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlayerLogExporter.NativeFieldInfoPtr__onSuccess, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerLogExporter.NativeFieldInfoPtr__onSuccess, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BF8 RID: 7160
		// (get) Token: 0x06005AA9 RID: 23209 RVA: 0x001B40E8 File Offset: 0x001B22E8
		// (set) Token: 0x06005AAA RID: 23210 RVA: 0x0002AF58 File Offset: 0x00029158
		public unsafe static Il2CppReferenceArray<Regex> ExcludedRegexes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlayerLogExporter.NativeFieldInfoPtr_ExcludedRegexes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Regex>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerLogExporter.NativeFieldInfoPtr_ExcludedRegexes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003E2A RID: 15914
		private static readonly IntPtr NativeFieldInfoPtr__onSuccess;

		// Token: 0x04003E2B RID: 15915
		private static readonly IntPtr NativeFieldInfoPtr_ExcludedRegexes;

		// Token: 0x04003E2C RID: 15916
		private static readonly IntPtr NativeMethodInfoPtr_ExportPlayerLog_Public_Static_Void_Boolean_Action_0;

		// Token: 0x04003E2D RID: 15917
		private static readonly IntPtr NativeMethodInfoPtr_SavePathSelected_Private_Static_Void_String_Boolean_0;

		// Token: 0x04003E2E RID: 15918
		private static readonly IntPtr NativeMethodInfoPtr_FilterLog_Public_Static_String_String_0;

		// Token: 0x04003E2F RID: 15919
		private static readonly IntPtr NativeMethodInfoPtr_ReadFileShared_Private_Static_String_String_0;

		// Token: 0x04003E30 RID: 15920
		private static readonly IntPtr NativeMethodInfoPtr_GetLogPath_Public_Static_String_Boolean_0;

		// Token: 0x02000AEB RID: 2795
		[ObfuscatedName("ScheduleOne.DevUtilities.PlayerLogExporter+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x0600E4F2 RID: 58610 RVA: 0x0037FAFC File Offset: 0x0037DCFC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<PlayerLogExporter.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerLogExporter>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerLogExporter.__c__DisplayClass2_0>.NativeClassPtr);
				PlayerLogExporter.__c__DisplayClass2_0.NativeFieldInfoPtr_previous = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLogExporter.__c__DisplayClass2_0>.NativeClassPtr, "previous");
				PlayerLogExporter.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLogExporter.__c__DisplayClass2_0>.NativeClassPtr, 100675143);
				PlayerLogExporter.__c__DisplayClass2_0.NativeMethodInfoPtr__ExportPlayerLog_b__0_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLogExporter.__c__DisplayClass2_0>.NativeClassPtr, 100675144);
			}

			// Token: 0x0600E4F3 RID: 58611 RVA: 0x0037FB64 File Offset: 0x0037DD64
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerLogExporter.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerLogExporter.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E4F4 RID: 58612 RVA: 0x0037FBA0 File Offset: 0x0037DDA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195742, XrefRangeEnd = 195746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ExportPlayerLog_b__0(string savePath)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(savePath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerLogExporter.__c__DisplayClass2_0.NativeMethodInfoPtr__ExportPlayerLog_b__0_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E4F5 RID: 58613 RVA: 0x0006BEF4 File Offset: 0x0006A0F4
			public __c__DisplayClass2_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004597 RID: 17815
			// (get) Token: 0x0600E4F6 RID: 58614 RVA: 0x0037FBE4 File Offset: 0x0037DDE4
			// (set) Token: 0x0600E4F7 RID: 58615 RVA: 0x0006BEFD File Offset: 0x0006A0FD
			public unsafe bool previous
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLogExporter.__c__DisplayClass2_0.NativeFieldInfoPtr_previous);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLogExporter.__c__DisplayClass2_0.NativeFieldInfoPtr_previous)) = value;
				}
			}

			// Token: 0x04009B6F RID: 39791
			private static readonly IntPtr NativeFieldInfoPtr_previous;

			// Token: 0x04009B70 RID: 39792
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009B71 RID: 39793
			private static readonly IntPtr NativeMethodInfoPtr__ExportPlayerLog_b__0_Internal_Void_String_0;
		}
	}
}
