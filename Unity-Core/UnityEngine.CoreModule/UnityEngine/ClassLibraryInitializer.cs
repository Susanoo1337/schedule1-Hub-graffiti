using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine
{
	// Token: 0x0200012F RID: 303
	public static class ClassLibraryInitializer : Object
	{
		// Token: 0x060017B8 RID: 6072 RVA: 0x00066134 File Offset: 0x00064334
		// Note: this type is marked as 'beforefieldinit'.
		static ClassLibraryInitializer()
		{
			Il2CppClassPointerStore<ClassLibraryInitializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ClassLibraryInitializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClassLibraryInitializer>.NativeClassPtr);
			ClassLibraryInitializer.NativeMethodInfoPtr_Init_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassLibraryInitializer>.NativeClassPtr, 100665775);
			ClassLibraryInitializer.NativeMethodInfoPtr_InitStdErrWithHandle_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassLibraryInitializer>.NativeClassPtr, 100665776);
			ClassLibraryInitializer.NativeMethodInfoPtr_InitAssemblyRedirections_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassLibraryInitializer>.NativeClassPtr, 100665777);
		}

		// Token: 0x060017B9 RID: 6073 RVA: 0x000661A0 File Offset: 0x000643A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248796, XrefRangeEnd = 1248797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Init()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassLibraryInitializer.NativeMethodInfoPtr_Init_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017BA RID: 6074 RVA: 0x000661C8 File Offset: 0x000643C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248797, XrefRangeEnd = 1248813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitStdErrWithHandle(IntPtr fileHandle)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fileHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassLibraryInitializer.NativeMethodInfoPtr_InitStdErrWithHandle_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017BB RID: 6075 RVA: 0x000661FC File Offset: 0x000643FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248813, XrefRangeEnd = 1248831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitAssemblyRedirections()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassLibraryInitializer.NativeMethodInfoPtr_InitAssemblyRedirections_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x0000BDAE File Offset: 0x00009FAE
		public ClassLibraryInitializer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040013FE RID: 5118
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Static_Void_0;

		// Token: 0x040013FF RID: 5119
		private static readonly IntPtr NativeMethodInfoPtr_InitStdErrWithHandle_Private_Static_Void_IntPtr_0;

		// Token: 0x04001400 RID: 5120
		private static readonly IntPtr NativeMethodInfoPtr_InitAssemblyRedirections_Private_Static_Void_0;

		// Token: 0x020008AE RID: 2222
		[ObfuscatedName("UnityEngine.ClassLibraryInitializer+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060039DB RID: 14811 RVA: 0x000B1784 File Offset: 0x000AF984
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ClassLibraryInitializer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClassLibraryInitializer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClassLibraryInitializer.__c>.NativeClassPtr);
				ClassLibraryInitializer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassLibraryInitializer.__c>.NativeClassPtr, "<>9");
				ClassLibraryInitializer.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassLibraryInitializer.__c>.NativeClassPtr, "<>9__2_0");
				ClassLibraryInitializer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassLibraryInitializer.__c>.NativeClassPtr, 100665779);
				ClassLibraryInitializer.__c.NativeMethodInfoPtr__InitAssemblyRedirections_b__2_0_Internal_Assembly_Object_ResolveEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassLibraryInitializer.__c>.NativeClassPtr, 100665780);
			}

			// Token: 0x060039DC RID: 14812 RVA: 0x000B1800 File Offset: 0x000AFA00
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClassLibraryInitializer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassLibraryInitializer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039DD RID: 14813 RVA: 0x000B183C File Offset: 0x000AFA3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248789, XrefRangeEnd = 1248796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Assembly _InitAssemblyRedirections_b__2_0(Object _, ResolveEventArgs args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassLibraryInitializer.__c.NativeMethodInfoPtr__InitAssemblyRedirections_b__2_0_Internal_Assembly_Object_ResolveEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
			}

			// Token: 0x060039DE RID: 14814 RVA: 0x00015D7E File Offset: 0x00013F7E
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17000A12 RID: 2578
			// (get) Token: 0x060039DF RID: 14815 RVA: 0x000B18A0 File Offset: 0x000AFAA0
			// (set) Token: 0x060039E0 RID: 14816 RVA: 0x00015D87 File Offset: 0x00013F87
			public unsafe static ClassLibraryInitializer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ClassLibraryInitializer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClassLibraryInitializer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ClassLibraryInitializer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A13 RID: 2579
			// (get) Token: 0x060039E1 RID: 14817 RVA: 0x000B18C8 File Offset: 0x000AFAC8
			// (set) Token: 0x060039E2 RID: 14818 RVA: 0x00015D99 File Offset: 0x00013F99
			public unsafe static ResolveEventHandler __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ClassLibraryInitializer.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResolveEventHandler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ClassLibraryInitializer.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002AFF RID: 11007
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002B00 RID: 11008
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04002B01 RID: 11009
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002B02 RID: 11010
			private static readonly IntPtr NativeMethodInfoPtr__InitAssemblyRedirections_b__2_0_Internal_Assembly_Object_ResolveEventArgs_0;
		}

		// Token: 0x020008AF RID: 2223
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
