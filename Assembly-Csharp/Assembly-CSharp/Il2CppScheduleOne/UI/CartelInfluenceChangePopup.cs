using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Map;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000720 RID: 1824
	public class CartelInfluenceChangePopup : MonoBehaviour
	{
		// Token: 0x0600AFEB RID: 45035 RVA: 0x002E05AC File Offset: 0x002DE7AC
		// Note: this type is marked as 'beforefieldinit'.
		static CartelInfluenceChangePopup()
		{
			Il2CppClassPointerStore<CartelInfluenceChangePopup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "CartelInfluenceChangePopup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CartelInfluenceChangePopup>.NativeClassPtr);
			CartelInfluenceChangePopup.NativeFieldInfoPtr_SLIDER_ANIMATION_DURATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelInfluenceChangePopup>.NativeClassPtr, "SLIDER_ANIMATION_DURATION");
			CartelInfluenceChangePopup.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelInfluenceChangePopup>.NativeClassPtr, "Anim");
			CartelInfluenceChangePopup.NativeFieldInfoPtr_Slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelInfluenceChangePopup>.NativeClassPtr, "Slider");
			CartelInfluenceChangePopup.NativeFieldInfoPtr_TitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelInfluenceChangePopup>.NativeClassPtr, "TitleLabel");
			CartelInfluenceChangePopup.NativeFieldInfoPtr_InfluenceCountLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelInfluenceChangePopup>.NativeClassPtr, "InfluenceCountLabel");
			CartelInfluenceChangePopup.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelInfluenceChangePopup>.NativeClassPtr, 100686426);
			CartelInfluenceChangePopup.NativeMethodInfoPtr_Show_Public_Void_EMapRegion_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelInfluenceChangePopup>.NativeClassPtr, 100686427);
			CartelInfluenceChangePopup.NativeMethodInfoPtr_SetDisplayedInfluence_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelInfluenceChangePopup>.NativeClassPtr, 100686428);
			CartelInfluenceChangePopup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelInfluenceChangePopup>.NativeClassPtr, 100686429);
		}

		// Token: 0x0600AFEC RID: 45036 RVA: 0x002E0690 File Offset: 0x002DE890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299480, XrefRangeEnd = 299500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelInfluenceChangePopup.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AFED RID: 45037 RVA: 0x002E06C4 File Offset: 0x002DE8C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299500, XrefRangeEnd = 299519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Show(EMapRegion region, float oldInfluence, float newInfluence)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref region;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldInfluence;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newInfluence;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelInfluenceChangePopup.NativeMethodInfoPtr_Show_Public_Void_EMapRegion_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AFEE RID: 45038 RVA: 0x002E0720 File Offset: 0x002DE920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299519, XrefRangeEnd = 299524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDisplayedInfluence(float influence)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref influence;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelInfluenceChangePopup.NativeMethodInfoPtr_SetDisplayedInfluence_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AFEF RID: 45039 RVA: 0x002E0760 File Offset: 0x002DE960
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CartelInfluenceChangePopup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CartelInfluenceChangePopup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelInfluenceChangePopup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AFF0 RID: 45040 RVA: 0x00050C03 File Offset: 0x0004EE03
		public CartelInfluenceChangePopup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170034D7 RID: 13527
		// (get) Token: 0x0600AFF1 RID: 45041 RVA: 0x002E079C File Offset: 0x002DE99C
		// (set) Token: 0x0600AFF2 RID: 45042 RVA: 0x00050C0C File Offset: 0x0004EE0C
		public unsafe static float SLIDER_ANIMATION_DURATION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CartelInfluenceChangePopup.NativeFieldInfoPtr_SLIDER_ANIMATION_DURATION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CartelInfluenceChangePopup.NativeFieldInfoPtr_SLIDER_ANIMATION_DURATION, (void*)(&value));
			}
		}

		// Token: 0x170034D8 RID: 13528
		// (get) Token: 0x0600AFF3 RID: 45043 RVA: 0x002E07B8 File Offset: 0x002DE9B8
		// (set) Token: 0x0600AFF4 RID: 45044 RVA: 0x00050C1A File Offset: 0x0004EE1A
		public unsafe Animation Anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelInfluenceChangePopup.NativeFieldInfoPtr_Anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelInfluenceChangePopup.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034D9 RID: 13529
		// (get) Token: 0x0600AFF5 RID: 45045 RVA: 0x002E07E8 File Offset: 0x002DE9E8
		// (set) Token: 0x0600AFF6 RID: 45046 RVA: 0x00050C39 File Offset: 0x0004EE39
		public unsafe Slider Slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelInfluenceChangePopup.NativeFieldInfoPtr_Slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelInfluenceChangePopup.NativeFieldInfoPtr_Slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034DA RID: 13530
		// (get) Token: 0x0600AFF7 RID: 45047 RVA: 0x002E0818 File Offset: 0x002DEA18
		// (set) Token: 0x0600AFF8 RID: 45048 RVA: 0x00050C58 File Offset: 0x0004EE58
		public unsafe TextMeshProUGUI TitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelInfluenceChangePopup.NativeFieldInfoPtr_TitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelInfluenceChangePopup.NativeFieldInfoPtr_TitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034DB RID: 13531
		// (get) Token: 0x0600AFF9 RID: 45049 RVA: 0x002E0848 File Offset: 0x002DEA48
		// (set) Token: 0x0600AFFA RID: 45050 RVA: 0x00050C77 File Offset: 0x0004EE77
		public unsafe TextMeshProUGUI InfluenceCountLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelInfluenceChangePopup.NativeFieldInfoPtr_InfluenceCountLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelInfluenceChangePopup.NativeFieldInfoPtr_InfluenceCountLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007949 RID: 31049
		private static readonly IntPtr NativeFieldInfoPtr_SLIDER_ANIMATION_DURATION;

		// Token: 0x0400794A RID: 31050
		private static readonly IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x0400794B RID: 31051
		private static readonly IntPtr NativeFieldInfoPtr_Slider;

		// Token: 0x0400794C RID: 31052
		private static readonly IntPtr NativeFieldInfoPtr_TitleLabel;

		// Token: 0x0400794D RID: 31053
		private static readonly IntPtr NativeFieldInfoPtr_InfluenceCountLabel;

		// Token: 0x0400794E RID: 31054
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400794F RID: 31055
		private static readonly IntPtr NativeMethodInfoPtr_Show_Public_Void_EMapRegion_Single_Single_0;

		// Token: 0x04007950 RID: 31056
		private static readonly IntPtr NativeMethodInfoPtr_SetDisplayedInfluence_Private_Void_Single_0;

		// Token: 0x04007951 RID: 31057
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000CB8 RID: 3256
		[ObfuscatedName("ScheduleOne.UI.CartelInfluenceChangePopup+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600F3F6 RID: 62454 RVA: 0x003AB188 File Offset: 0x003A9388
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CartelInfluenceChangePopup.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CartelInfluenceChangePopup>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CartelInfluenceChangePopup.__c>.NativeClassPtr);
				CartelInfluenceChangePopup.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelInfluenceChangePopup.__c>.NativeClassPtr, "<>9");
				CartelInfluenceChangePopup.__c.NativeFieldInfoPtr___9__6_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelInfluenceChangePopup.__c>.NativeClassPtr, "<>9__6_1");
				CartelInfluenceChangePopup.__c.NativeFieldInfoPtr___9__6_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelInfluenceChangePopup.__c>.NativeClassPtr, "<>9__6_2");
				CartelInfluenceChangePopup.__c.NativeFieldInfoPtr___9__6_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelInfluenceChangePopup.__c>.NativeClassPtr, "<>9__6_3");
				CartelInfluenceChangePopup.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelInfluenceChangePopup.__c>.NativeClassPtr, 100686431);
				CartelInfluenceChangePopup.__c.NativeMethodInfoPtr__Show_b__6_1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelInfluenceChangePopup.__c>.NativeClassPtr, 100686432);
				CartelInfluenceChangePopup.__c.NativeMethodInfoPtr__Show_b__6_2_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelInfluenceChangePopup.__c>.NativeClassPtr, 100686433);
				CartelInfluenceChangePopup.__c.NativeMethodInfoPtr__Show_b__6_3_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelInfluenceChangePopup.__c>.NativeClassPtr, 100686434);
			}

			// Token: 0x0600F3F7 RID: 62455 RVA: 0x003AB254 File Offset: 0x003A9454
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CartelInfluenceChangePopup.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelInfluenceChangePopup.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F3F8 RID: 62456 RVA: 0x003AB290 File Offset: 0x003A9490
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299431, XrefRangeEnd = 299436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Show_b__6_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelInfluenceChangePopup.__c.NativeMethodInfoPtr__Show_b__6_1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F3F9 RID: 62457 RVA: 0x003AB2CC File Offset: 0x003A94CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299436, XrefRangeEnd = 299440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Show_b__6_2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelInfluenceChangePopup.__c.NativeMethodInfoPtr__Show_b__6_2_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F3FA RID: 62458 RVA: 0x003AB308 File Offset: 0x003A9508
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299440, XrefRangeEnd = 299444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Show_b__6_3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelInfluenceChangePopup.__c.NativeMethodInfoPtr__Show_b__6_3_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F3FB RID: 62459 RVA: 0x00073352 File Offset: 0x00071552
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A0E RID: 18958
			// (get) Token: 0x0600F3FC RID: 62460 RVA: 0x003AB344 File Offset: 0x003A9544
			// (set) Token: 0x0600F3FD RID: 62461 RVA: 0x0007335B File Offset: 0x0007155B
			public unsafe static CartelInfluenceChangePopup.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CartelInfluenceChangePopup.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CartelInfluenceChangePopup.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CartelInfluenceChangePopup.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A0F RID: 18959
			// (get) Token: 0x0600F3FE RID: 62462 RVA: 0x003AB36C File Offset: 0x003A956C
			// (set) Token: 0x0600F3FF RID: 62463 RVA: 0x0007336D File Offset: 0x0007156D
			public unsafe static Func<bool> __9__6_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CartelInfluenceChangePopup.__c.NativeFieldInfoPtr___9__6_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CartelInfluenceChangePopup.__c.NativeFieldInfoPtr___9__6_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A10 RID: 18960
			// (get) Token: 0x0600F400 RID: 62464 RVA: 0x003AB394 File Offset: 0x003A9594
			// (set) Token: 0x0600F401 RID: 62465 RVA: 0x0007337F File Offset: 0x0007157F
			public unsafe static Func<bool> __9__6_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CartelInfluenceChangePopup.__c.NativeFieldInfoPtr___9__6_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CartelInfluenceChangePopup.__c.NativeFieldInfoPtr___9__6_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A11 RID: 18961
			// (get) Token: 0x0600F402 RID: 62466 RVA: 0x003AB3BC File Offset: 0x003A95BC
			// (set) Token: 0x0600F403 RID: 62467 RVA: 0x00073391 File Offset: 0x00071591
			public unsafe static Func<bool> __9__6_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CartelInfluenceChangePopup.__c.NativeFieldInfoPtr___9__6_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CartelInfluenceChangePopup.__c.NativeFieldInfoPtr___9__6_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A537 RID: 42295
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A538 RID: 42296
			private static readonly IntPtr NativeFieldInfoPtr___9__6_1;

			// Token: 0x0400A539 RID: 42297
			private static readonly IntPtr NativeFieldInfoPtr___9__6_2;

			// Token: 0x0400A53A RID: 42298
			private static readonly IntPtr NativeFieldInfoPtr___9__6_3;

			// Token: 0x0400A53B RID: 42299
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A53C RID: 42300
			private static readonly IntPtr NativeMethodInfoPtr__Show_b__6_1_Internal_Boolean_0;

			// Token: 0x0400A53D RID: 42301
			private static readonly IntPtr NativeMethodInfoPtr__Show_b__6_2_Internal_Boolean_0;

			// Token: 0x0400A53E RID: 42302
			private static readonly IntPtr NativeMethodInfoPtr__Show_b__6_3_Internal_Boolean_0;
		}

		// Token: 0x02000CB9 RID: 3257
		[ObfuscatedName("ScheduleOne.UI.CartelInfluenceChangePopup+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F404 RID: 62468 RVA: 0x003AB3E4 File Offset: 0x003A95E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<CartelInfluenceChangePopup.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CartelInfluenceChangePopup>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CartelInfluenceChangePopup.__c__DisplayClass6_0>.NativeClassPtr);
				CartelInfluenceChangePopup.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelInfluenceChangePopup.__c__DisplayClass6_0>.NativeClassPtr, "<>4__this");
				CartelInfluenceChangePopup.__c__DisplayClass6_0.NativeFieldInfoPtr_oldInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelInfluenceChangePopup.__c__DisplayClass6_0>.NativeClassPtr, "oldInfluence");
				CartelInfluenceChangePopup.__c__DisplayClass6_0.NativeFieldInfoPtr_region = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelInfluenceChangePopup.__c__DisplayClass6_0>.NativeClassPtr, "region");
				CartelInfluenceChangePopup.__c__DisplayClass6_0.NativeFieldInfoPtr_newInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelInfluenceChangePopup.__c__DisplayClass6_0>.NativeClassPtr, "newInfluence");
				CartelInfluenceChangePopup.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelInfluenceChangePopup.__c__DisplayClass6_0>.NativeClassPtr, 100686435);
				CartelInfluenceChangePopup.__c__DisplayClass6_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelInfluenceChangePopup.__c__DisplayClass6_0>.NativeClassPtr, 100686436);
			}

			// Token: 0x0600F405 RID: 62469 RVA: 0x003AB488 File Offset: 0x003A9688
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CartelInfluenceChangePopup.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelInfluenceChangePopup.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F406 RID: 62470 RVA: 0x003AB4C4 File Offset: 0x003A96C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299475, XrefRangeEnd = 299480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelInfluenceChangePopup.__c__DisplayClass6_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600F407 RID: 62471 RVA: 0x000733A3 File Offset: 0x000715A3
			public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A12 RID: 18962
			// (get) Token: 0x0600F408 RID: 62472 RVA: 0x003AB504 File Offset: 0x003A9704
			// (set) Token: 0x0600F409 RID: 62473 RVA: 0x000733AC File Offset: 0x000715AC
			public unsafe CartelInfluenceChangePopup __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelInfluenceChangePopup.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CartelInfluenceChangePopup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelInfluenceChangePopup.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A13 RID: 18963
			// (get) Token: 0x0600F40A RID: 62474 RVA: 0x003AB534 File Offset: 0x003A9734
			// (set) Token: 0x0600F40B RID: 62475 RVA: 0x000733CB File Offset: 0x000715CB
			public unsafe float oldInfluence
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelInfluenceChangePopup.__c__DisplayClass6_0.NativeFieldInfoPtr_oldInfluence);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelInfluenceChangePopup.__c__DisplayClass6_0.NativeFieldInfoPtr_oldInfluence)) = value;
				}
			}

			// Token: 0x17004A14 RID: 18964
			// (get) Token: 0x0600F40C RID: 62476 RVA: 0x003AB55C File Offset: 0x003A975C
			// (set) Token: 0x0600F40D RID: 62477 RVA: 0x000733E6 File Offset: 0x000715E6
			public unsafe EMapRegion region
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelInfluenceChangePopup.__c__DisplayClass6_0.NativeFieldInfoPtr_region);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelInfluenceChangePopup.__c__DisplayClass6_0.NativeFieldInfoPtr_region)) = value;
				}
			}

			// Token: 0x17004A15 RID: 18965
			// (get) Token: 0x0600F40E RID: 62478 RVA: 0x003AB584 File Offset: 0x003A9784
			// (set) Token: 0x0600F40F RID: 62479 RVA: 0x00073401 File Offset: 0x00071601
			public unsafe float newInfluence
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelInfluenceChangePopup.__c__DisplayClass6_0.NativeFieldInfoPtr_newInfluence);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelInfluenceChangePopup.__c__DisplayClass6_0.NativeFieldInfoPtr_newInfluence)) = value;
				}
			}

			// Token: 0x0400A53F RID: 42303
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A540 RID: 42304
			private static readonly IntPtr NativeFieldInfoPtr_oldInfluence;

			// Token: 0x0400A541 RID: 42305
			private static readonly IntPtr NativeFieldInfoPtr_region;

			// Token: 0x0400A542 RID: 42306
			private static readonly IntPtr NativeFieldInfoPtr_newInfluence;

			// Token: 0x0400A543 RID: 42307
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A544 RID: 42308
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000E06 RID: 3590
			[ObfuscatedName("ScheduleOne.UI.CartelInfluenceChangePopup+<>c__DisplayClass6_0+<<Show>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x060102AC RID: 66220 RVA: 0x003D5AF0 File Offset: 0x003D3CF0
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique()
				{
					Il2CppClassPointerStore<CartelInfluenceChangePopup.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CartelInfluenceChangePopup.__c__DisplayClass6_0>.NativeClassPtr, "<<Show>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CartelInfluenceChangePopup.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr);
					CartelInfluenceChangePopup.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelInfluenceChangePopup.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>1__state");
					CartelInfluenceChangePopup.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelInfluenceChangePopup.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>2__current");
					CartelInfluenceChangePopup.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelInfluenceChangePopup.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>4__this");
					CartelInfluenceChangePopup.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelInfluenceChangePopup.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<i>5__2");
					CartelInfluenceChangePopup.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelInfluenceChangePopup.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100686437);
					CartelInfluenceChangePopup.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelInfluenceChangePopup.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100686438);
					CartelInfluenceChangePopup.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelInfluenceChangePopup.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100686439);
					CartelInfluenceChangePopup.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelInfluenceChangePopup.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100686440);
					CartelInfluenceChangePopup.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelInfluenceChangePopup.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100686441);
					CartelInfluenceChangePopup.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelInfluenceChangePopup.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100686442);
				}

				// Token: 0x060102AD RID: 66221 RVA: 0x003D5BE4 File Offset: 0x003D3DE4
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CartelInfluenceChangePopup.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelInfluenceChangePopup.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060102AE RID: 66222 RVA: 0x003D5C2C File Offset: 0x003D3E2C
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelInfluenceChangePopup.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060102AF RID: 66223 RVA: 0x003D5C60 File Offset: 0x003D3E60
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299444, XrefRangeEnd = 299470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelInfluenceChangePopup.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004EFD RID: 20221
				// (get) Token: 0x060102B0 RID: 66224 RVA: 0x003D5C9C File Offset: 0x003D3E9C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelInfluenceChangePopup.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060102B1 RID: 66225 RVA: 0x003D5CDC File Offset: 0x003D3EDC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299470, XrefRangeEnd = 299475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelInfluenceChangePopup.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004EFE RID: 20222
				// (get) Token: 0x060102B2 RID: 66226 RVA: 0x003D5D10 File Offset: 0x003D3F10
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelInfluenceChangePopup.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060102B3 RID: 66227 RVA: 0x0007AA19 File Offset: 0x00078C19
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004EF9 RID: 20217
				// (get) Token: 0x060102B4 RID: 66228 RVA: 0x003D5D50 File Offset: 0x003D3F50
				// (set) Token: 0x060102B5 RID: 66229 RVA: 0x0007AA22 File Offset: 0x00078C22
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelInfluenceChangePopup.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelInfluenceChangePopup.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004EFA RID: 20218
				// (get) Token: 0x060102B6 RID: 66230 RVA: 0x003D5D78 File Offset: 0x003D3F78
				// (set) Token: 0x060102B7 RID: 66231 RVA: 0x0007AA3D File Offset: 0x00078C3D
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelInfluenceChangePopup.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelInfluenceChangePopup.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004EFB RID: 20219
				// (get) Token: 0x060102B8 RID: 66232 RVA: 0x003D5DA8 File Offset: 0x003D3FA8
				// (set) Token: 0x060102B9 RID: 66233 RVA: 0x0007AA5C File Offset: 0x00078C5C
				public unsafe CartelInfluenceChangePopup.__c__DisplayClass6_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelInfluenceChangePopup.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<CartelInfluenceChangePopup.__c__DisplayClass6_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelInfluenceChangePopup.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004EFC RID: 20220
				// (get) Token: 0x060102BA RID: 66234 RVA: 0x003D5DD8 File Offset: 0x003D3FD8
				// (set) Token: 0x060102BB RID: 66235 RVA: 0x0007AA7B File Offset: 0x00078C7B
				public unsafe float _i_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelInfluenceChangePopup.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelInfluenceChangePopup.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2)) = value;
					}
				}

				// Token: 0x0400AE1F RID: 44575
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AE20 RID: 44576
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AE21 RID: 44577
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AE22 RID: 44578
				private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

				// Token: 0x0400AE23 RID: 44579
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AE24 RID: 44580
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AE25 RID: 44581
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AE26 RID: 44582
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AE27 RID: 44583
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AE28 RID: 44584
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
