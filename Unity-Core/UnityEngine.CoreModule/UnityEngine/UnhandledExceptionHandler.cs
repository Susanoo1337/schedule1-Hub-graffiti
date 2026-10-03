using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000150 RID: 336
	public sealed class UnhandledExceptionHandler : Object
	{
		// Token: 0x06001942 RID: 6466 RVA: 0x0000C53B File Offset: 0x0000A73B
		// Note: this type is marked as 'beforefieldinit'.
		static UnhandledExceptionHandler()
		{
			Il2CppClassPointerStore<UnhandledExceptionHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "UnhandledExceptionHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnhandledExceptionHandler>.NativeClassPtr);
			UnhandledExceptionHandler.NativeMethodInfoPtr_RegisterUECatcher_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnhandledExceptionHandler>.NativeClassPtr, 100665987);
		}

		// Token: 0x06001943 RID: 6467 RVA: 0x0006BCBC File Offset: 0x00069EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260991, XrefRangeEnd = 1261009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterUECatcher()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnhandledExceptionHandler.NativeMethodInfoPtr_RegisterUECatcher_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x0000C574 File Offset: 0x0000A774
		public UnhandledExceptionHandler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400150B RID: 5387
		private static readonly IntPtr NativeMethodInfoPtr_RegisterUECatcher_Private_Static_Void_0;

		// Token: 0x020008F0 RID: 2288
		[ObfuscatedName("UnityEngine.UnhandledExceptionHandler+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003A58 RID: 14936 RVA: 0x000B2A08 File Offset: 0x000B0C08
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<UnhandledExceptionHandler.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnhandledExceptionHandler>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnhandledExceptionHandler.__c>.NativeClassPtr);
				UnhandledExceptionHandler.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnhandledExceptionHandler.__c>.NativeClassPtr, "<>9");
				UnhandledExceptionHandler.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnhandledExceptionHandler.__c>.NativeClassPtr, "<>9__0_0");
				UnhandledExceptionHandler.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnhandledExceptionHandler.__c>.NativeClassPtr, 100665989);
				UnhandledExceptionHandler.__c.NativeMethodInfoPtr__RegisterUECatcher_b__0_0_Internal_Void_Object_UnhandledExceptionEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnhandledExceptionHandler.__c>.NativeClassPtr, 100665990);
			}

			// Token: 0x06003A59 RID: 14937 RVA: 0x000B2A84 File Offset: 0x000B0C84
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnhandledExceptionHandler.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnhandledExceptionHandler.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003A5A RID: 14938 RVA: 0x000B2AC0 File Offset: 0x000B0CC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260984, XrefRangeEnd = 1260991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RegisterUECatcher_b__0_0(Object sender, UnhandledExceptionEventArgs e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnhandledExceptionHandler.__c.NativeMethodInfoPtr__RegisterUECatcher_b__0_0_Internal_Void_Object_UnhandledExceptionEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003A5B RID: 14939 RVA: 0x00015F52 File Offset: 0x00014152
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17000A1F RID: 2591
			// (get) Token: 0x06003A5C RID: 14940 RVA: 0x000B2B14 File Offset: 0x000B0D14
			// (set) Token: 0x06003A5D RID: 14941 RVA: 0x00015F5B File Offset: 0x0001415B
			public unsafe static UnhandledExceptionHandler.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UnhandledExceptionHandler.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnhandledExceptionHandler.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UnhandledExceptionHandler.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A20 RID: 2592
			// (get) Token: 0x06003A5E RID: 14942 RVA: 0x000B2B3C File Offset: 0x000B0D3C
			// (set) Token: 0x06003A5F RID: 14943 RVA: 0x00015F6D File Offset: 0x0001416D
			public unsafe static UnhandledExceptionEventHandler __9__0_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UnhandledExceptionHandler.__c.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnhandledExceptionEventHandler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UnhandledExceptionHandler.__c.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002B41 RID: 11073
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002B42 RID: 11074
			private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

			// Token: 0x04002B43 RID: 11075
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002B44 RID: 11076
			private static readonly IntPtr NativeMethodInfoPtr__RegisterUECatcher_b__0_0_Internal_Void_Object_UnhandledExceptionEventArgs_0;
		}

		// Token: 0x020008F1 RID: 2289
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
