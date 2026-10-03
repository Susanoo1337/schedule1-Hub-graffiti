using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004F9 RID: 1273
	public class ResetRenderShit : MonoBehaviour
	{
		// Token: 0x06007316 RID: 29462 RVA: 0x00205758 File Offset: 0x00203958
		// Note: this type is marked as 'beforefieldinit'.
		static ResetRenderShit()
		{
			Il2CppClassPointerStore<ResetRenderShit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "ResetRenderShit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResetRenderShit>.NativeClassPtr);
			ResetRenderShit.NativeFieldInfoPtr_rendererData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResetRenderShit>.NativeClassPtr, "rendererData");
			ResetRenderShit.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResetRenderShit>.NativeClassPtr, 100678176);
			ResetRenderShit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResetRenderShit>.NativeClassPtr, 100678177);
		}

		// Token: 0x06007317 RID: 29463 RVA: 0x002057C4 File Offset: 0x002039C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227131, XrefRangeEnd = 227155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResetRenderShit.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007318 RID: 29464 RVA: 0x002057F8 File Offset: 0x002039F8
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResetRenderShit() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResetRenderShit>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResetRenderShit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007319 RID: 29465 RVA: 0x00036B50 File Offset: 0x00034D50
		public ResetRenderShit(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700237A RID: 9082
		// (get) Token: 0x0600731A RID: 29466 RVA: 0x00205834 File Offset: 0x00203A34
		// (set) Token: 0x0600731B RID: 29467 RVA: 0x00036B59 File Offset: 0x00034D59
		public unsafe UniversalRendererData rendererData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResetRenderShit.NativeFieldInfoPtr_rendererData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalRendererData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResetRenderShit.NativeFieldInfoPtr_rendererData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004E92 RID: 20114
		private static readonly IntPtr NativeFieldInfoPtr_rendererData;

		// Token: 0x04004E93 RID: 20115
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004E94 RID: 20116
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BA2 RID: 2978
		[ObfuscatedName("ScheduleOne.Tools.ResetRenderShit+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600EA43 RID: 59971 RVA: 0x0038EC04 File Offset: 0x0038CE04
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ResetRenderShit.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResetRenderShit>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResetRenderShit.__c>.NativeClassPtr);
				ResetRenderShit.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResetRenderShit.__c>.NativeClassPtr, "<>9");
				ResetRenderShit.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResetRenderShit.__c>.NativeClassPtr, "<>9__1_0");
				ResetRenderShit.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResetRenderShit.__c>.NativeClassPtr, 100678179);
				ResetRenderShit.__c.NativeMethodInfoPtr__Awake_b__1_0_Internal_Boolean_ScriptableRendererFeature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResetRenderShit.__c>.NativeClassPtr, 100678180);
			}

			// Token: 0x0600EA44 RID: 59972 RVA: 0x0038EC80 File Offset: 0x0038CE80
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResetRenderShit.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResetRenderShit.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EA45 RID: 59973 RVA: 0x0038ECBC File Offset: 0x0038CEBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227126, XrefRangeEnd = 227131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Awake_b__1_0(ScriptableRendererFeature x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResetRenderShit.__c.NativeMethodInfoPtr__Awake_b__1_0_Internal_Boolean_ScriptableRendererFeature_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EA46 RID: 59974 RVA: 0x0006E838 File Offset: 0x0006CA38
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700470F RID: 18191
			// (get) Token: 0x0600EA47 RID: 59975 RVA: 0x0038ED0C File Offset: 0x0038CF0C
			// (set) Token: 0x0600EA48 RID: 59976 RVA: 0x0006E841 File Offset: 0x0006CA41
			public unsafe static ResetRenderShit.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResetRenderShit.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResetRenderShit.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResetRenderShit.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004710 RID: 18192
			// (get) Token: 0x0600EA49 RID: 59977 RVA: 0x0038ED34 File Offset: 0x0038CF34
			// (set) Token: 0x0600EA4A RID: 59978 RVA: 0x0006E853 File Offset: 0x0006CA53
			public unsafe static Predicate<ScriptableRendererFeature> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResetRenderShit.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<ScriptableRendererFeature>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResetRenderShit.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009ECD RID: 40653
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009ECE RID: 40654
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x04009ECF RID: 40655
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009ED0 RID: 40656
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__1_0_Internal_Boolean_ScriptableRendererFeature_0;
		}
	}
}
