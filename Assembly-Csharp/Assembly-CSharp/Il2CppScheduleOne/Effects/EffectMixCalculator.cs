using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Product;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppScheduleOne.Effects
{
	// Token: 0x020006CB RID: 1739
	public static class EffectMixCalculator : Object
	{
		// Token: 0x0600A756 RID: 42838 RVA: 0x002C6108 File Offset: 0x002C4308
		// Note: this type is marked as 'beforefieldinit'.
		static EffectMixCalculator()
		{
			Il2CppClassPointerStore<EffectMixCalculator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Effects", "EffectMixCalculator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EffectMixCalculator>.NativeClassPtr);
			EffectMixCalculator.NativeFieldInfoPtr_MAX_PROPERTIES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectMixCalculator>.NativeClassPtr, "MAX_PROPERTIES");
			EffectMixCalculator.NativeFieldInfoPtr_MAX_DELTA_DIFFERENCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectMixCalculator>.NativeClassPtr, "MAX_DELTA_DIFFERENCE");
			EffectMixCalculator.NativeMethodInfoPtr_MixProperties_Public_Static_List_1_Effect_List_1_Effect_Effect_EDrugType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectMixCalculator>.NativeClassPtr, 100685533);
			EffectMixCalculator.NativeMethodInfoPtr_Shuffle_Public_Static_Void_List_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectMixCalculator>.NativeClassPtr, 100685534);
		}

		// Token: 0x0600A757 RID: 42839 RVA: 0x002C6188 File Offset: 0x002C4388
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 290899, RefRangeEnd = 290903, XrefRangeStart = 290797, XrefRangeEnd = 290899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Effect> MixProperties(List<Effect> existingProperties, Effect newProperty, EDrugType drugType)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(existingProperties);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newProperty);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref drugType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectMixCalculator.NativeMethodInfoPtr_MixProperties_Public_Static_List_1_Effect_List_1_Effect_Effect_EDrugType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Effect>>(intPtr3) : null;
		}

		// Token: 0x0600A758 RID: 42840 RVA: 0x002C61EC File Offset: 0x002C43EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290903, XrefRangeEnd = 290915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Shuffle<T>(List<T> list, int seed)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectMixCalculator.MethodInfoStoreGeneric_Shuffle_Public_Static_Void_List_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A759 RID: 42841 RVA: 0x0004C124 File Offset: 0x0004A324
		public EffectMixCalculator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170031F7 RID: 12791
		// (get) Token: 0x0600A75A RID: 42842 RVA: 0x002C6230 File Offset: 0x002C4430
		// (set) Token: 0x0600A75B RID: 42843 RVA: 0x0004C12D File Offset: 0x0004A32D
		public unsafe static int MAX_PROPERTIES
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(EffectMixCalculator.NativeFieldInfoPtr_MAX_PROPERTIES, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EffectMixCalculator.NativeFieldInfoPtr_MAX_PROPERTIES, (void*)(&value));
			}
		}

		// Token: 0x170031F8 RID: 12792
		// (get) Token: 0x0600A75C RID: 42844 RVA: 0x002C624C File Offset: 0x002C444C
		// (set) Token: 0x0600A75D RID: 42845 RVA: 0x0004C13B File Offset: 0x0004A33B
		public unsafe static float MAX_DELTA_DIFFERENCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(EffectMixCalculator.NativeFieldInfoPtr_MAX_DELTA_DIFFERENCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EffectMixCalculator.NativeFieldInfoPtr_MAX_DELTA_DIFFERENCE, (void*)(&value));
			}
		}

		// Token: 0x040073B9 RID: 29625
		private static readonly IntPtr NativeFieldInfoPtr_MAX_PROPERTIES;

		// Token: 0x040073BA RID: 29626
		private static readonly IntPtr NativeFieldInfoPtr_MAX_DELTA_DIFFERENCE;

		// Token: 0x040073BB RID: 29627
		private static readonly IntPtr NativeMethodInfoPtr_MixProperties_Public_Static_List_1_Effect_List_1_Effect_Effect_EDrugType_0;

		// Token: 0x040073BC RID: 29628
		private static readonly IntPtr NativeMethodInfoPtr_Shuffle_Public_Static_Void_List_1_T_Int32_0;

		// Token: 0x02000C7C RID: 3196
		public class Reaction : Object
		{
			// Token: 0x0600F221 RID: 61985 RVA: 0x003A5E0C File Offset: 0x003A400C
			// Note: this type is marked as 'beforefieldinit'.
			static Reaction()
			{
				Il2CppClassPointerStore<EffectMixCalculator.Reaction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EffectMixCalculator>.NativeClassPtr, "Reaction");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EffectMixCalculator.Reaction>.NativeClassPtr);
				EffectMixCalculator.Reaction.NativeFieldInfoPtr_Existing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectMixCalculator.Reaction>.NativeClassPtr, "Existing");
				EffectMixCalculator.Reaction.NativeFieldInfoPtr_Output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectMixCalculator.Reaction>.NativeClassPtr, "Output");
				EffectMixCalculator.Reaction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectMixCalculator.Reaction>.NativeClassPtr, 100685535);
			}

			// Token: 0x0600F222 RID: 61986 RVA: 0x003A5E74 File Offset: 0x003A4074
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Reaction() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EffectMixCalculator.Reaction>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectMixCalculator.Reaction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F223 RID: 61987 RVA: 0x0007244F File Offset: 0x0007064F
			public Reaction(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004981 RID: 18817
			// (get) Token: 0x0600F224 RID: 61988 RVA: 0x003A5EB0 File Offset: 0x003A40B0
			// (set) Token: 0x0600F225 RID: 61989 RVA: 0x00072458 File Offset: 0x00070658
			public unsafe Effect Existing
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectMixCalculator.Reaction.NativeFieldInfoPtr_Existing);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Effect>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectMixCalculator.Reaction.NativeFieldInfoPtr_Existing), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004982 RID: 18818
			// (get) Token: 0x0600F226 RID: 61990 RVA: 0x003A5EE0 File Offset: 0x003A40E0
			// (set) Token: 0x0600F227 RID: 61991 RVA: 0x00072477 File Offset: 0x00070677
			public unsafe Effect Output
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectMixCalculator.Reaction.NativeFieldInfoPtr_Output);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Effect>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectMixCalculator.Reaction.NativeFieldInfoPtr_Output), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A3DA RID: 41946
			private static readonly IntPtr NativeFieldInfoPtr_Existing;

			// Token: 0x0400A3DB RID: 41947
			private static readonly IntPtr NativeFieldInfoPtr_Output;

			// Token: 0x0400A3DC RID: 41948
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000C7D RID: 3197
		private sealed class MethodInfoStoreGeneric_Shuffle_Public_Static_Void_List_1_T_Int32_0<T>
		{
			// Token: 0x0400A3DD RID: 41949
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EffectMixCalculator.NativeMethodInfoPtr_Shuffle_Public_Static_Void_List_1_T_Int32_0, Il2CppClassPointerStore<EffectMixCalculator>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
