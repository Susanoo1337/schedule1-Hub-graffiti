using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Events;

namespace Il2Cpp
{
	// Token: 0x0200001E RID: 30
	public class InvertMouseSetter : MonoBehaviour
	{
		// Token: 0x0600017C RID: 380 RVA: 0x0008016C File Offset: 0x0007E36C
		// Note: this type is marked as 'beforefieldinit'.
		static InvertMouseSetter()
		{
			Il2CppClassPointerStore<InvertMouseSetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "InvertMouseSetter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvertMouseSetter>.NativeClassPtr);
			InvertMouseSetter.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvertMouseSetter>.NativeClassPtr, 100663475);
			InvertMouseSetter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvertMouseSetter>.NativeClassPtr, 100663476);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x000801C4 File Offset: 0x0007E3C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66653, XrefRangeEnd = 66675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvertMouseSetter.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x000801F8 File Offset: 0x0007E3F8
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvertMouseSetter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvertMouseSetter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvertMouseSetter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00002C6D File Offset: 0x00000E6D
		public InvertMouseSetter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200085D RID: 2141
		[ObfuscatedName("InvertMouseSetter+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D008 RID: 53256 RVA: 0x00344188 File Offset: 0x00342388
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<InvertMouseSetter.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InvertMouseSetter>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvertMouseSetter.__c>.NativeClassPtr);
				InvertMouseSetter.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvertMouseSetter.__c>.NativeClassPtr, "<>9");
				InvertMouseSetter.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvertMouseSetter.__c>.NativeClassPtr, "<>9__0_0");
				InvertMouseSetter.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvertMouseSetter.__c>.NativeClassPtr, 100663478);
				InvertMouseSetter.__c.NativeMethodInfoPtr__Awake_b__0_0_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvertMouseSetter.__c>.NativeClassPtr, 100663479);
			}

			// Token: 0x0600D009 RID: 53257 RVA: 0x00344204 File Offset: 0x00342404
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvertMouseSetter.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvertMouseSetter.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D00A RID: 53258 RVA: 0x00344240 File Offset: 0x00342440
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66649, XrefRangeEnd = 66653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__0_0(bool x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvertMouseSetter.__c.NativeMethodInfoPtr__Awake_b__0_0_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D00B RID: 53259 RVA: 0x0006276C File Offset: 0x0006096C
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EFB RID: 16123
			// (get) Token: 0x0600D00C RID: 53260 RVA: 0x00344280 File Offset: 0x00342480
			// (set) Token: 0x0600D00D RID: 53261 RVA: 0x00062775 File Offset: 0x00060975
			public unsafe static InvertMouseSetter.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InvertMouseSetter.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InvertMouseSetter.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InvertMouseSetter.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EFC RID: 16124
			// (get) Token: 0x0600D00E RID: 53262 RVA: 0x003442A8 File Offset: 0x003424A8
			// (set) Token: 0x0600D00F RID: 53263 RVA: 0x00062787 File Offset: 0x00060987
			public unsafe static UnityAction<bool> __9__0_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InvertMouseSetter.__c.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InvertMouseSetter.__c.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008DD2 RID: 36306
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008DD3 RID: 36307
			private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

			// Token: 0x04008DD4 RID: 36308
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008DD5 RID: 36309
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__0_0_Internal_Void_Boolean_0;
		}
	}
}
