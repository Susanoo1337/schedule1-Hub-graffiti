using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Effects.MixMaps
{
	// Token: 0x020006CE RID: 1742
	public class MixerMapGenerator : MonoBehaviour
	{
		// Token: 0x0600A771 RID: 42865 RVA: 0x002C65C8 File Offset: 0x002C47C8
		// Note: this type is marked as 'beforefieldinit'.
		static MixerMapGenerator()
		{
			Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Effects.MixMaps", "MixerMapGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr);
			MixerMapGenerator.NativeFieldInfoPtr_MapRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr, "MapRadius");
			MixerMapGenerator.NativeFieldInfoPtr_MapName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr, "MapName");
			MixerMapGenerator.NativeFieldInfoPtr_BasePlateMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr, "BasePlateMesh");
			MixerMapGenerator.NativeFieldInfoPtr_EffectPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr, "EffectPrefab");
			MixerMapGenerator.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr, 100685541);
			MixerMapGenerator.NativeMethodInfoPtr_CreateEffectPrefabs_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr, 100685542);
			MixerMapGenerator.NativeMethodInfoPtr_GetEffect_Public_MixMapEffect_Effect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr, 100685543);
			MixerMapGenerator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr, 100685544);
		}

		// Token: 0x0600A772 RID: 42866 RVA: 0x002C6698 File Offset: 0x002C4898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290955, XrefRangeEnd = 290961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixerMapGenerator.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A773 RID: 42867 RVA: 0x002C66CC File Offset: 0x002C48CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290961, XrefRangeEnd = 291003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateEffectPrefabs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixerMapGenerator.NativeMethodInfoPtr_CreateEffectPrefabs_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A774 RID: 42868 RVA: 0x002C6700 File Offset: 0x002C4900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291003, XrefRangeEnd = 291024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixMapEffect GetEffect(Effect effect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(effect);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixerMapGenerator.NativeMethodInfoPtr_GetEffect_Public_MixMapEffect_Effect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MixMapEffect>(intPtr3) : null;
		}

		// Token: 0x0600A775 RID: 42869 RVA: 0x002C6750 File Offset: 0x002C4950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291024, XrefRangeEnd = 291029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixerMapGenerator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixerMapGenerator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A776 RID: 42870 RVA: 0x0004C1EA File Offset: 0x0004A3EA
		public MixerMapGenerator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170031FE RID: 12798
		// (get) Token: 0x0600A777 RID: 42871 RVA: 0x002C678C File Offset: 0x002C498C
		// (set) Token: 0x0600A778 RID: 42872 RVA: 0x0004C1F3 File Offset: 0x0004A3F3
		public unsafe float MapRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapGenerator.NativeFieldInfoPtr_MapRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapGenerator.NativeFieldInfoPtr_MapRadius)) = value;
			}
		}

		// Token: 0x170031FF RID: 12799
		// (get) Token: 0x0600A779 RID: 42873 RVA: 0x002C67B4 File Offset: 0x002C49B4
		// (set) Token: 0x0600A77A RID: 42874 RVA: 0x0004C20E File Offset: 0x0004A40E
		public unsafe string MapName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapGenerator.NativeFieldInfoPtr_MapName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapGenerator.NativeFieldInfoPtr_MapName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003200 RID: 12800
		// (get) Token: 0x0600A77B RID: 42875 RVA: 0x002C67DC File Offset: 0x002C49DC
		// (set) Token: 0x0600A77C RID: 42876 RVA: 0x0004C22D File Offset: 0x0004A42D
		public unsafe Transform BasePlateMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapGenerator.NativeFieldInfoPtr_BasePlateMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapGenerator.NativeFieldInfoPtr_BasePlateMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003201 RID: 12801
		// (get) Token: 0x0600A77D RID: 42877 RVA: 0x002C680C File Offset: 0x002C4A0C
		// (set) Token: 0x0600A77E RID: 42878 RVA: 0x0004C24C File Offset: 0x0004A44C
		public unsafe MixMapEffect EffectPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapGenerator.NativeFieldInfoPtr_EffectPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MixMapEffect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapGenerator.NativeFieldInfoPtr_EffectPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040073C7 RID: 29639
		private static readonly IntPtr NativeFieldInfoPtr_MapRadius;

		// Token: 0x040073C8 RID: 29640
		private static readonly IntPtr NativeFieldInfoPtr_MapName;

		// Token: 0x040073C9 RID: 29641
		private static readonly IntPtr NativeFieldInfoPtr_BasePlateMesh;

		// Token: 0x040073CA RID: 29642
		private static readonly IntPtr NativeFieldInfoPtr_EffectPrefab;

		// Token: 0x040073CB RID: 29643
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x040073CC RID: 29644
		private static readonly IntPtr NativeMethodInfoPtr_CreateEffectPrefabs_Public_Void_0;

		// Token: 0x040073CD RID: 29645
		private static readonly IntPtr NativeMethodInfoPtr_GetEffect_Public_MixMapEffect_Effect_0;

		// Token: 0x040073CE RID: 29646
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C7E RID: 3198
		[ObfuscatedName("ScheduleOne.Effects.MixMaps.MixerMapGenerator+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600F229 RID: 61993 RVA: 0x003A5F64 File Offset: 0x003A4164
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MixerMapGenerator.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixerMapGenerator.__c>.NativeClassPtr);
				MixerMapGenerator.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixerMapGenerator.__c>.NativeClassPtr, "<>9");
				MixerMapGenerator.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixerMapGenerator.__c>.NativeClassPtr, "<>9__6_0");
				MixerMapGenerator.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixerMapGenerator.__c>.NativeClassPtr, 100685546);
				MixerMapGenerator.__c.NativeMethodInfoPtr__GetEffect_b__6_0_Internal_Boolean_MixMapEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixerMapGenerator.__c>.NativeClassPtr, 100685547);
			}

			// Token: 0x0600F22A RID: 61994 RVA: 0x003A5FE0 File Offset: 0x003A41E0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixerMapGenerator.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixerMapGenerator.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F22B RID: 61995 RVA: 0x003A601C File Offset: 0x003A421C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290950, XrefRangeEnd = 290955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetEffect_b__6_0(MixMapEffect effect)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(effect);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixerMapGenerator.__c.NativeMethodInfoPtr__GetEffect_b__6_0_Internal_Boolean_MixMapEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F22C RID: 61996 RVA: 0x00072496 File Offset: 0x00070696
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004983 RID: 18819
			// (get) Token: 0x0600F22D RID: 61997 RVA: 0x003A606C File Offset: 0x003A426C
			// (set) Token: 0x0600F22E RID: 61998 RVA: 0x0007249F File Offset: 0x0007069F
			public unsafe static MixerMapGenerator.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MixerMapGenerator.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MixerMapGenerator.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MixerMapGenerator.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004984 RID: 18820
			// (get) Token: 0x0600F22F RID: 61999 RVA: 0x003A6094 File Offset: 0x003A4294
			// (set) Token: 0x0600F230 RID: 62000 RVA: 0x000724B1 File Offset: 0x000706B1
			public unsafe static Func<MixMapEffect, bool> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MixerMapGenerator.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MixMapEffect, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MixerMapGenerator.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A3DE RID: 41950
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A3DF RID: 41951
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x0400A3E0 RID: 41952
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A3E1 RID: 41953
			private static readonly IntPtr NativeMethodInfoPtr__GetEffect_b__6_0_Internal_Boolean_MixMapEffect_0;
		}
	}
}
