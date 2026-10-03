using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Configuration;
using Il2CppScheduleOne.Core;
using Il2CppScheduleOne.Core.Audio;
using Il2CppScheduleOne.Core.Settings;
using Il2CppSystem;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x02000482 RID: 1154
	public class SFXConfiguration : Configuration<SFXSettings>
	{
		// Token: 0x060067EC RID: 26604 RVA: 0x001E2948 File Offset: 0x001E0B48
		// Note: this type is marked as 'beforefieldinit'.
		static SFXConfiguration()
		{
			Il2CppClassPointerStore<SFXConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "SFXConfiguration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SFXConfiguration>.NativeClassPtr);
			SFXConfiguration.NativeFieldInfoPtr_ImpactSoundPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXConfiguration>.NativeClassPtr, "ImpactSoundPrefab");
			SFXConfiguration.NativeMethodInfoPtr_TryGetImpactTypeData_Public_Boolean_EImpactSound_byref_ImpactSound_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SFXConfiguration>.NativeClassPtr, 100676884);
			SFXConfiguration.NativeMethodInfoPtr_TryGetFootstepSoundGroup_Public_Boolean_EMaterialType_byref_FootstepSound_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SFXConfiguration>.NativeClassPtr, 100676885);
			SFXConfiguration.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SFXConfiguration>.NativeClassPtr, 100676886);
		}

		// Token: 0x060067ED RID: 26605 RVA: 0x001E29C8 File Offset: 0x001E0BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215534, XrefRangeEnd = 215549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetImpactTypeData(EImpactSound material, out SFXSettings.ImpactSound data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref material;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SFXConfiguration.NativeMethodInfoPtr_TryGetImpactTypeData_Public_Boolean_EImpactSound_byref_ImpactSound_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			data = ((intPtr4 == 0) ? null : new SFXSettings.ImpactSound(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060067EE RID: 26606 RVA: 0x001E2A34 File Offset: 0x001E0C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215549, XrefRangeEnd = 215564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetFootstepSoundGroup(EMaterialType materialType, out SFXSettings.FootstepSound group)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref materialType;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SFXConfiguration.NativeMethodInfoPtr_TryGetFootstepSoundGroup_Public_Boolean_EMaterialType_byref_FootstepSound_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			group = ((intPtr4 == 0) ? null : new SFXSettings.FootstepSound(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060067EF RID: 26607 RVA: 0x001E2AA0 File Offset: 0x001E0CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215564, XrefRangeEnd = 215567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SFXConfiguration() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SFXConfiguration>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SFXConfiguration.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067F0 RID: 26608 RVA: 0x00030F5E File Offset: 0x0002F15E
		public SFXConfiguration(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FCC RID: 8140
		// (get) Token: 0x060067F1 RID: 26609 RVA: 0x001E2ADC File Offset: 0x001E0CDC
		// (set) Token: 0x060067F2 RID: 26610 RVA: 0x00030F67 File Offset: 0x0002F167
		public unsafe AudioSourceController ImpactSoundPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXConfiguration.NativeFieldInfoPtr_ImpactSoundPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXConfiguration.NativeFieldInfoPtr_ImpactSoundPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400477C RID: 18300
		private static readonly IntPtr NativeFieldInfoPtr_ImpactSoundPrefab;

		// Token: 0x0400477D RID: 18301
		private static readonly IntPtr NativeMethodInfoPtr_TryGetImpactTypeData_Public_Boolean_EImpactSound_byref_ImpactSound_0;

		// Token: 0x0400477E RID: 18302
		private static readonly IntPtr NativeMethodInfoPtr_TryGetFootstepSoundGroup_Public_Boolean_EMaterialType_byref_FootstepSound_0;

		// Token: 0x0400477F RID: 18303
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B4F RID: 2895
		[ObfuscatedName("ScheduleOne.Audio.SFXConfiguration+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x0600E76A RID: 59242 RVA: 0x0038692C File Offset: 0x00384B2C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<SFXConfiguration.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SFXConfiguration>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SFXConfiguration.__c__DisplayClass1_0>.NativeClassPtr);
				SFXConfiguration.__c__DisplayClass1_0.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXConfiguration.__c__DisplayClass1_0>.NativeClassPtr, "material");
				SFXConfiguration.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SFXConfiguration.__c__DisplayClass1_0>.NativeClassPtr, 100676887);
				SFXConfiguration.__c__DisplayClass1_0.NativeMethodInfoPtr__TryGetImpactTypeData_b__0_Internal_Boolean_ImpactSound_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SFXConfiguration.__c__DisplayClass1_0>.NativeClassPtr, 100676888);
			}

			// Token: 0x0600E76B RID: 59243 RVA: 0x00386994 File Offset: 0x00384B94
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SFXConfiguration.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SFXConfiguration.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E76C RID: 59244 RVA: 0x003869D0 File Offset: 0x00384BD0
			[CallerCount(0)]
			public unsafe bool _TryGetImpactTypeData_b__0(SFXSettings.ImpactSound x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SFXConfiguration.__c__DisplayClass1_0.NativeMethodInfoPtr__TryGetImpactTypeData_b__0_Internal_Boolean_ImpactSound_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E76D RID: 59245 RVA: 0x0006D256 File Offset: 0x0006B456
			public __c__DisplayClass1_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004639 RID: 17977
			// (get) Token: 0x0600E76E RID: 59246 RVA: 0x00386A20 File Offset: 0x00384C20
			// (set) Token: 0x0600E76F RID: 59247 RVA: 0x0006D25F File Offset: 0x0006B45F
			public unsafe EImpactSound material
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXConfiguration.__c__DisplayClass1_0.NativeFieldInfoPtr_material);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXConfiguration.__c__DisplayClass1_0.NativeFieldInfoPtr_material)) = value;
				}
			}

			// Token: 0x04009D14 RID: 40212
			private static readonly IntPtr NativeFieldInfoPtr_material;

			// Token: 0x04009D15 RID: 40213
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009D16 RID: 40214
			private static readonly IntPtr NativeMethodInfoPtr__TryGetImpactTypeData_b__0_Internal_Boolean_ImpactSound_0;
		}

		// Token: 0x02000B50 RID: 2896
		[ObfuscatedName("ScheduleOne.Audio.SFXConfiguration+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x0600E770 RID: 59248 RVA: 0x00386A48 File Offset: 0x00384C48
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<SFXConfiguration.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SFXConfiguration>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SFXConfiguration.__c__DisplayClass2_0>.NativeClassPtr);
				SFXConfiguration.__c__DisplayClass2_0.NativeFieldInfoPtr_materialType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXConfiguration.__c__DisplayClass2_0>.NativeClassPtr, "materialType");
				SFXConfiguration.__c__DisplayClass2_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXConfiguration.__c__DisplayClass2_0>.NativeClassPtr, "<>9__1");
				SFXConfiguration.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SFXConfiguration.__c__DisplayClass2_0>.NativeClassPtr, 100676889);
				SFXConfiguration.__c__DisplayClass2_0.NativeMethodInfoPtr__TryGetFootstepSoundGroup_b__0_Internal_Boolean_FootstepSound_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SFXConfiguration.__c__DisplayClass2_0>.NativeClassPtr, 100676890);
				SFXConfiguration.__c__DisplayClass2_0.NativeMethodInfoPtr__TryGetFootstepSoundGroup_b__1_Internal_Boolean_EMaterialType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SFXConfiguration.__c__DisplayClass2_0>.NativeClassPtr, 100676891);
			}

			// Token: 0x0600E771 RID: 59249 RVA: 0x00386AD8 File Offset: 0x00384CD8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SFXConfiguration.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SFXConfiguration.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E772 RID: 59250 RVA: 0x00386B14 File Offset: 0x00384D14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215523, XrefRangeEnd = 215534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TryGetFootstepSoundGroup_b__0(SFXSettings.FootstepSound g)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(g);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SFXConfiguration.__c__DisplayClass2_0.NativeMethodInfoPtr__TryGetFootstepSoundGroup_b__0_Internal_Boolean_FootstepSound_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E773 RID: 59251 RVA: 0x00386B64 File Offset: 0x00384D64
			[CallerCount(0)]
			public unsafe bool _TryGetFootstepSoundGroup_b__1(EMaterialType mt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref mt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SFXConfiguration.__c__DisplayClass2_0.NativeMethodInfoPtr__TryGetFootstepSoundGroup_b__1_Internal_Boolean_EMaterialType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E774 RID: 59252 RVA: 0x0006D27A File Offset: 0x0006B47A
			public __c__DisplayClass2_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700463A RID: 17978
			// (get) Token: 0x0600E775 RID: 59253 RVA: 0x00386BB0 File Offset: 0x00384DB0
			// (set) Token: 0x0600E776 RID: 59254 RVA: 0x0006D283 File Offset: 0x0006B483
			public unsafe EMaterialType materialType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXConfiguration.__c__DisplayClass2_0.NativeFieldInfoPtr_materialType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXConfiguration.__c__DisplayClass2_0.NativeFieldInfoPtr_materialType)) = value;
				}
			}

			// Token: 0x1700463B RID: 17979
			// (get) Token: 0x0600E777 RID: 59255 RVA: 0x00386BD8 File Offset: 0x00384DD8
			// (set) Token: 0x0600E778 RID: 59256 RVA: 0x0006D29E File Offset: 0x0006B49E
			public unsafe Predicate<EMaterialType> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXConfiguration.__c__DisplayClass2_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<EMaterialType>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXConfiguration.__c__DisplayClass2_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009D17 RID: 40215
			private static readonly IntPtr NativeFieldInfoPtr_materialType;

			// Token: 0x04009D18 RID: 40216
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x04009D19 RID: 40217
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009D1A RID: 40218
			private static readonly IntPtr NativeMethodInfoPtr__TryGetFootstepSoundGroup_b__0_Internal_Boolean_FootstepSound_0;

			// Token: 0x04009D1B RID: 40219
			private static readonly IntPtr NativeMethodInfoPtr__TryGetFootstepSoundGroup_b__1_Internal_Boolean_EMaterialType_0;
		}
	}
}
