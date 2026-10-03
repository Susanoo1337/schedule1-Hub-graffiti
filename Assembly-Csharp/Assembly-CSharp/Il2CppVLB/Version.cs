using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppVLB
{
	// Token: 0x02000078 RID: 120
	public static class Version : Object
	{
		// Token: 0x060008DA RID: 2266 RVA: 0x00097F80 File Offset: 0x00096180
		// Note: this type is marked as 'beforefieldinit'.
		static Version()
		{
			Il2CppClassPointerStore<Version>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "Version");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Version>.NativeClassPtr);
			Version.NativeFieldInfoPtr_Current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version>.NativeClassPtr, "Current");
			Version.NativeMethodInfoPtr_get_CurrentAsString_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100664437);
			Version.NativeMethodInfoPtr_GetVersionAsString_Private_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100664438);
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x060008DB RID: 2267 RVA: 0x00097FEC File Offset: 0x000961EC
		public unsafe static string CurrentAsString
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74410, XrefRangeEnd = 74420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_get_CurrentAsString_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x00098018 File Offset: 0x00096218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74420, XrefRangeEnd = 74430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetVersionAsString(int version)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref version;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_GetVersionAsString_Private_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x00006196 File Offset: 0x00004396
		public Version(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x060008DE RID: 2270 RVA: 0x00098050 File Offset: 0x00096250
		// (set) Token: 0x060008DF RID: 2271 RVA: 0x0000619F File Offset: 0x0000439F
		public unsafe static int Current
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Version.NativeFieldInfoPtr_Current, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Version.NativeFieldInfoPtr_Current, (void*)(&value));
			}
		}

		// Token: 0x0400063D RID: 1597
		private static readonly IntPtr NativeFieldInfoPtr_Current;

		// Token: 0x0400063E RID: 1598
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentAsString_Public_Static_get_String_0;

		// Token: 0x0400063F RID: 1599
		private static readonly IntPtr NativeMethodInfoPtr_GetVersionAsString_Private_Static_String_Int32_0;
	}
}
