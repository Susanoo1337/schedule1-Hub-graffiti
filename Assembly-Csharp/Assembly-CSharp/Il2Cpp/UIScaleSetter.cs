using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Events;

namespace Il2Cpp
{
	// Token: 0x02000020 RID: 32
	public class UIScaleSetter : MonoBehaviour
	{
		// Token: 0x06000196 RID: 406 RVA: 0x00080774 File Offset: 0x0007E974
		// Note: this type is marked as 'beforefieldinit'.
		static UIScaleSetter()
		{
			Il2CppClassPointerStore<UIScaleSetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UIScaleSetter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIScaleSetter>.NativeClassPtr);
			UIScaleSetter.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScaleSetter>.NativeClassPtr, 100663486);
			UIScaleSetter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScaleSetter>.NativeClassPtr, 100663487);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x000807CC File Offset: 0x0007E9CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66706, XrefRangeEnd = 66728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScaleSetter.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00080800 File Offset: 0x0007EA00
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIScaleSetter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIScaleSetter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScaleSetter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00002D31 File Offset: 0x00000F31
		public UIScaleSetter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200085E RID: 2142
		[ObfuscatedName("UIScaleSetter+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D010 RID: 53264 RVA: 0x003442D0 File Offset: 0x003424D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<UIScaleSetter.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIScaleSetter>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIScaleSetter.__c>.NativeClassPtr);
				UIScaleSetter.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScaleSetter.__c>.NativeClassPtr, "<>9");
				UIScaleSetter.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScaleSetter.__c>.NativeClassPtr, "<>9__0_0");
				UIScaleSetter.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScaleSetter.__c>.NativeClassPtr, 100663489);
				UIScaleSetter.__c.NativeMethodInfoPtr__Awake_b__0_0_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScaleSetter.__c>.NativeClassPtr, 100663490);
			}

			// Token: 0x0600D011 RID: 53265 RVA: 0x0034434C File Offset: 0x0034254C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIScaleSetter.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScaleSetter.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D012 RID: 53266 RVA: 0x00344388 File Offset: 0x00342588
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66688, XrefRangeEnd = 66706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__0_0(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScaleSetter.__c.NativeMethodInfoPtr__Awake_b__0_0_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D013 RID: 53267 RVA: 0x00062799 File Offset: 0x00060999
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EFD RID: 16125
			// (get) Token: 0x0600D014 RID: 53268 RVA: 0x003443C8 File Offset: 0x003425C8
			// (set) Token: 0x0600D015 RID: 53269 RVA: 0x000627A2 File Offset: 0x000609A2
			public unsafe static UIScaleSetter.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UIScaleSetter.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScaleSetter.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UIScaleSetter.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EFE RID: 16126
			// (get) Token: 0x0600D016 RID: 53270 RVA: 0x003443F0 File Offset: 0x003425F0
			// (set) Token: 0x0600D017 RID: 53271 RVA: 0x000627B4 File Offset: 0x000609B4
			public unsafe static UnityAction<float> __9__0_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UIScaleSetter.__c.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UIScaleSetter.__c.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008DD6 RID: 36310
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008DD7 RID: 36311
			private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

			// Token: 0x04008DD8 RID: 36312
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008DD9 RID: 36313
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__0_0_Internal_Void_Single_0;
		}
	}
}
