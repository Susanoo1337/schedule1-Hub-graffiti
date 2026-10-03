using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Clothing
{
	// Token: 0x02000428 RID: 1064
	public class ClothingUtility : Singleton<ClothingUtility>
	{
		// Token: 0x06005DED RID: 24045 RVA: 0x001BF380 File Offset: 0x001BD580
		// Note: this type is marked as 'beforefieldinit'.
		static ClothingUtility()
		{
			Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Clothing", "ClothingUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr);
			ClothingUtility.NativeFieldInfoPtr_ColorDataList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, "ColorDataList");
			ClothingUtility.NativeFieldInfoPtr_ClothingSlotDataList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, "ClothingSlotDataList");
			ClothingUtility.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, 100675567);
			ClothingUtility.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, 100675568);
			ClothingUtility.NativeMethodInfoPtr_GetColorData_Public_ColorData_EClothingColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, 100675569);
			ClothingUtility.NativeMethodInfoPtr_GetSlotData_Public_ClothingSlotData_EClothingSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, 100675570);
			ClothingUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, 100675571);
		}

		// Token: 0x06005DEE RID: 24046 RVA: 0x001BF43C File Offset: 0x001BD63C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200277, XrefRangeEnd = 200332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClothingUtility.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DEF RID: 24047 RVA: 0x001BF478 File Offset: 0x001BD678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200332, XrefRangeEnd = 200429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DF0 RID: 24048 RVA: 0x001BF4AC File Offset: 0x001BD6AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 200443, RefRangeEnd = 200446, XrefRangeStart = 200429, XrefRangeEnd = 200443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClothingUtility.ColorData GetColorData(EClothingColor color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.NativeMethodInfoPtr_GetColorData_Public_ColorData_EClothingColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClothingUtility.ColorData>(intPtr3) : null;
		}

		// Token: 0x06005DF1 RID: 24049 RVA: 0x001BF4F8 File Offset: 0x001BD6F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 200460, RefRangeEnd = 200462, XrefRangeStart = 200446, XrefRangeEnd = 200460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClothingUtility.ClothingSlotData GetSlotData(EClothingSlot slot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref slot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.NativeMethodInfoPtr_GetSlotData_Public_ClothingSlotData_EClothingSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClothingUtility.ClothingSlotData>(intPtr3) : null;
		}

		// Token: 0x06005DF2 RID: 24050 RVA: 0x001BF544 File Offset: 0x001BD744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200462, XrefRangeEnd = 200479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClothingUtility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DF3 RID: 24051 RVA: 0x0002C7FF File Offset: 0x0002A9FF
		public ClothingUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D00 RID: 7424
		// (get) Token: 0x06005DF4 RID: 24052 RVA: 0x001BF580 File Offset: 0x001BD780
		// (set) Token: 0x06005DF5 RID: 24053 RVA: 0x0002C808 File Offset: 0x0002AA08
		public unsafe List<ClothingUtility.ColorData> ColorDataList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.NativeFieldInfoPtr_ColorDataList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ClothingUtility.ColorData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.NativeFieldInfoPtr_ColorDataList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D01 RID: 7425
		// (get) Token: 0x06005DF6 RID: 24054 RVA: 0x001BF5B0 File Offset: 0x001BD7B0
		// (set) Token: 0x06005DF7 RID: 24055 RVA: 0x0002C827 File Offset: 0x0002AA27
		public unsafe List<ClothingUtility.ClothingSlotData> ClothingSlotDataList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.NativeFieldInfoPtr_ClothingSlotDataList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ClothingUtility.ClothingSlotData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.NativeFieldInfoPtr_ClothingSlotDataList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400406C RID: 16492
		private static readonly IntPtr NativeFieldInfoPtr_ColorDataList;

		// Token: 0x0400406D RID: 16493
		private static readonly IntPtr NativeFieldInfoPtr_ClothingSlotDataList;

		// Token: 0x0400406E RID: 16494
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400406F RID: 16495
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04004070 RID: 16496
		private static readonly IntPtr NativeMethodInfoPtr_GetColorData_Public_ColorData_EClothingColor_0;

		// Token: 0x04004071 RID: 16497
		private static readonly IntPtr NativeMethodInfoPtr_GetSlotData_Public_ClothingSlotData_EClothingSlot_0;

		// Token: 0x04004072 RID: 16498
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B11 RID: 2833
		[Serializable]
		public class ColorData : Il2CppSystem.Object
		{
			// Token: 0x0600E5CF RID: 58831 RVA: 0x0038219C File Offset: 0x0038039C
			// Note: this type is marked as 'beforefieldinit'.
			static ColorData()
			{
				Il2CppClassPointerStore<ClothingUtility.ColorData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, "ColorData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingUtility.ColorData>.NativeClassPtr);
				ClothingUtility.ColorData.NativeFieldInfoPtr_ColorType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility.ColorData>.NativeClassPtr, "ColorType");
				ClothingUtility.ColorData.NativeFieldInfoPtr_ActualColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility.ColorData>.NativeClassPtr, "ActualColor");
				ClothingUtility.ColorData.NativeFieldInfoPtr_LabelColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility.ColorData>.NativeClassPtr, "LabelColor");
				ClothingUtility.ColorData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.ColorData>.NativeClassPtr, 100675572);
			}

			// Token: 0x0600E5D0 RID: 58832 RVA: 0x00382218 File Offset: 0x00380418
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ColorData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingUtility.ColorData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.ColorData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E5D1 RID: 58833 RVA: 0x0006C5D7 File Offset: 0x0006A7D7
			public ColorData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045CA RID: 17866
			// (get) Token: 0x0600E5D2 RID: 58834 RVA: 0x00382254 File Offset: 0x00380454
			// (set) Token: 0x0600E5D3 RID: 58835 RVA: 0x0006C5E0 File Offset: 0x0006A7E0
			public unsafe EClothingColor ColorType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ColorData.NativeFieldInfoPtr_ColorType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ColorData.NativeFieldInfoPtr_ColorType)) = value;
				}
			}

			// Token: 0x170045CB RID: 17867
			// (get) Token: 0x0600E5D4 RID: 58836 RVA: 0x0038227C File Offset: 0x0038047C
			// (set) Token: 0x0600E5D5 RID: 58837 RVA: 0x0006C5FB File Offset: 0x0006A7FB
			public unsafe Color ActualColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ColorData.NativeFieldInfoPtr_ActualColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ColorData.NativeFieldInfoPtr_ActualColor)) = value;
				}
			}

			// Token: 0x170045CC RID: 17868
			// (get) Token: 0x0600E5D6 RID: 58838 RVA: 0x003822A4 File Offset: 0x003804A4
			// (set) Token: 0x0600E5D7 RID: 58839 RVA: 0x0006C616 File Offset: 0x0006A816
			public unsafe Color LabelColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ColorData.NativeFieldInfoPtr_LabelColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ColorData.NativeFieldInfoPtr_LabelColor)) = value;
				}
			}

			// Token: 0x04009BF2 RID: 39922
			private static readonly IntPtr NativeFieldInfoPtr_ColorType;

			// Token: 0x04009BF3 RID: 39923
			private static readonly IntPtr NativeFieldInfoPtr_ActualColor;

			// Token: 0x04009BF4 RID: 39924
			private static readonly IntPtr NativeFieldInfoPtr_LabelColor;

			// Token: 0x04009BF5 RID: 39925
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000B12 RID: 2834
		[Serializable]
		public class ClothingSlotData : Il2CppSystem.Object
		{
			// Token: 0x0600E5D8 RID: 58840 RVA: 0x003822CC File Offset: 0x003804CC
			// Note: this type is marked as 'beforefieldinit'.
			static ClothingSlotData()
			{
				Il2CppClassPointerStore<ClothingUtility.ClothingSlotData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, "ClothingSlotData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingUtility.ClothingSlotData>.NativeClassPtr);
				ClothingUtility.ClothingSlotData.NativeFieldInfoPtr_Slot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility.ClothingSlotData>.NativeClassPtr, "Slot");
				ClothingUtility.ClothingSlotData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility.ClothingSlotData>.NativeClassPtr, "Name");
				ClothingUtility.ClothingSlotData.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility.ClothingSlotData>.NativeClassPtr, "Icon");
				ClothingUtility.ClothingSlotData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.ClothingSlotData>.NativeClassPtr, 100675573);
			}

			// Token: 0x0600E5D9 RID: 58841 RVA: 0x00382348 File Offset: 0x00380548
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ClothingSlotData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingUtility.ClothingSlotData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.ClothingSlotData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E5DA RID: 58842 RVA: 0x0006C631 File Offset: 0x0006A831
			public ClothingSlotData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045CD RID: 17869
			// (get) Token: 0x0600E5DB RID: 58843 RVA: 0x00382384 File Offset: 0x00380584
			// (set) Token: 0x0600E5DC RID: 58844 RVA: 0x0006C63A File Offset: 0x0006A83A
			public unsafe EClothingSlot Slot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ClothingSlotData.NativeFieldInfoPtr_Slot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ClothingSlotData.NativeFieldInfoPtr_Slot)) = value;
				}
			}

			// Token: 0x170045CE RID: 17870
			// (get) Token: 0x0600E5DD RID: 58845 RVA: 0x003823AC File Offset: 0x003805AC
			// (set) Token: 0x0600E5DE RID: 58846 RVA: 0x0006C655 File Offset: 0x0006A855
			public unsafe string Name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ClothingSlotData.NativeFieldInfoPtr_Name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ClothingSlotData.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170045CF RID: 17871
			// (get) Token: 0x0600E5DF RID: 58847 RVA: 0x003823D4 File Offset: 0x003805D4
			// (set) Token: 0x0600E5E0 RID: 58848 RVA: 0x0006C674 File Offset: 0x0006A874
			public unsafe Sprite Icon
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ClothingSlotData.NativeFieldInfoPtr_Icon);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ClothingSlotData.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009BF6 RID: 39926
			private static readonly IntPtr NativeFieldInfoPtr_Slot;

			// Token: 0x04009BF7 RID: 39927
			private static readonly IntPtr NativeFieldInfoPtr_Name;

			// Token: 0x04009BF8 RID: 39928
			private static readonly IntPtr NativeFieldInfoPtr_Icon;

			// Token: 0x04009BF9 RID: 39929
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000B13 RID: 2835
		[ObfuscatedName("ScheduleOne.Clothing.ClothingUtility+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E5E1 RID: 58849 RVA: 0x00382404 File Offset: 0x00380604
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass4_0>.NativeClassPtr);
				ClothingUtility.__c__DisplayClass4_0.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass4_0>.NativeClassPtr, "color");
				ClothingUtility.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass4_0>.NativeClassPtr, 100675574);
				ClothingUtility.__c__DisplayClass4_0.NativeMethodInfoPtr__Awake_b__0_Internal_Boolean_ColorData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass4_0>.NativeClassPtr, 100675575);
			}

			// Token: 0x0600E5E2 RID: 58850 RVA: 0x0038246C File Offset: 0x0038066C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E5E3 RID: 58851 RVA: 0x003824A8 File Offset: 0x003806A8
			[CallerCount(0)]
			public unsafe bool _Awake_b__0(ClothingUtility.ColorData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.__c__DisplayClass4_0.NativeMethodInfoPtr__Awake_b__0_Internal_Boolean_ColorData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E5E4 RID: 58852 RVA: 0x0006C693 File Offset: 0x0006A893
			public __c__DisplayClass4_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045D0 RID: 17872
			// (get) Token: 0x0600E5E5 RID: 58853 RVA: 0x003824F8 File Offset: 0x003806F8
			// (set) Token: 0x0600E5E6 RID: 58854 RVA: 0x0006C69C File Offset: 0x0006A89C
			public unsafe EClothingColor color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.__c__DisplayClass4_0.NativeFieldInfoPtr_color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.__c__DisplayClass4_0.NativeFieldInfoPtr_color)) = value;
				}
			}

			// Token: 0x04009BFA RID: 39930
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x04009BFB RID: 39931
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009BFC RID: 39932
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__0_Internal_Boolean_ColorData_0;
		}

		// Token: 0x02000B14 RID: 2836
		[ObfuscatedName("ScheduleOne.Clothing.ClothingUtility+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E5E7 RID: 58855 RVA: 0x00382520 File Offset: 0x00380720
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_0>.NativeClassPtr);
				ClothingUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_0>.NativeClassPtr, "color");
				ClothingUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_0>.NativeClassPtr, 100675576);
				ClothingUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__OnValidate_b__0_Internal_Boolean_ColorData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_0>.NativeClassPtr, 100675577);
			}

			// Token: 0x0600E5E8 RID: 58856 RVA: 0x00382588 File Offset: 0x00380788
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E5E9 RID: 58857 RVA: 0x003825C4 File Offset: 0x003807C4
			[CallerCount(0)]
			public unsafe bool _OnValidate_b__0(ClothingUtility.ColorData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__OnValidate_b__0_Internal_Boolean_ColorData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E5EA RID: 58858 RVA: 0x0006C6B7 File Offset: 0x0006A8B7
			public __c__DisplayClass5_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045D1 RID: 17873
			// (get) Token: 0x0600E5EB RID: 58859 RVA: 0x00382614 File Offset: 0x00380814
			// (set) Token: 0x0600E5EC RID: 58860 RVA: 0x0006C6C0 File Offset: 0x0006A8C0
			public unsafe EClothingColor color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_color)) = value;
				}
			}

			// Token: 0x04009BFD RID: 39933
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x04009BFE RID: 39934
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009BFF RID: 39935
			private static readonly IntPtr NativeMethodInfoPtr__OnValidate_b__0_Internal_Boolean_ColorData_0;
		}

		// Token: 0x02000B15 RID: 2837
		[ObfuscatedName("ScheduleOne.Clothing.ClothingUtility+<>c__DisplayClass5_1")]
		public sealed class __c__DisplayClass5_1 : Il2CppSystem.Object
		{
			// Token: 0x0600E5ED RID: 58861 RVA: 0x0038263C File Offset: 0x0038083C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_1()
			{
				Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, "<>c__DisplayClass5_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_1>.NativeClassPtr);
				ClothingUtility.__c__DisplayClass5_1.NativeFieldInfoPtr_slot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_1>.NativeClassPtr, "slot");
				ClothingUtility.__c__DisplayClass5_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_1>.NativeClassPtr, 100675578);
				ClothingUtility.__c__DisplayClass5_1.NativeMethodInfoPtr__OnValidate_b__1_Internal_Boolean_ClothingSlotData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_1>.NativeClassPtr, 100675579);
			}

			// Token: 0x0600E5EE RID: 58862 RVA: 0x003826A4 File Offset: 0x003808A4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.__c__DisplayClass5_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E5EF RID: 58863 RVA: 0x003826E0 File Offset: 0x003808E0
			[CallerCount(0)]
			public unsafe bool _OnValidate_b__1(ClothingUtility.ClothingSlotData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.__c__DisplayClass5_1.NativeMethodInfoPtr__OnValidate_b__1_Internal_Boolean_ClothingSlotData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E5F0 RID: 58864 RVA: 0x0006C6DB File Offset: 0x0006A8DB
			public __c__DisplayClass5_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045D2 RID: 17874
			// (get) Token: 0x0600E5F1 RID: 58865 RVA: 0x00382730 File Offset: 0x00380930
			// (set) Token: 0x0600E5F2 RID: 58866 RVA: 0x0006C6E4 File Offset: 0x0006A8E4
			public unsafe EClothingSlot slot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.__c__DisplayClass5_1.NativeFieldInfoPtr_slot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.__c__DisplayClass5_1.NativeFieldInfoPtr_slot)) = value;
				}
			}

			// Token: 0x04009C00 RID: 39936
			private static readonly IntPtr NativeFieldInfoPtr_slot;

			// Token: 0x04009C01 RID: 39937
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009C02 RID: 39938
			private static readonly IntPtr NativeMethodInfoPtr__OnValidate_b__1_Internal_Boolean_ClothingSlotData_0;
		}

		// Token: 0x02000B16 RID: 2838
		[ObfuscatedName("ScheduleOne.Clothing.ClothingUtility+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E5F3 RID: 58867 RVA: 0x00382758 File Offset: 0x00380958
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass6_0>.NativeClassPtr);
				ClothingUtility.__c__DisplayClass6_0.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass6_0>.NativeClassPtr, "color");
				ClothingUtility.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass6_0>.NativeClassPtr, 100675580);
				ClothingUtility.__c__DisplayClass6_0.NativeMethodInfoPtr__GetColorData_b__0_Internal_Boolean_ColorData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass6_0>.NativeClassPtr, 100675581);
			}

			// Token: 0x0600E5F4 RID: 58868 RVA: 0x003827C0 File Offset: 0x003809C0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E5F5 RID: 58869 RVA: 0x003827FC File Offset: 0x003809FC
			[CallerCount(0)]
			public unsafe bool _GetColorData_b__0(ClothingUtility.ColorData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.__c__DisplayClass6_0.NativeMethodInfoPtr__GetColorData_b__0_Internal_Boolean_ColorData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E5F6 RID: 58870 RVA: 0x0006C6FF File Offset: 0x0006A8FF
			public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045D3 RID: 17875
			// (get) Token: 0x0600E5F7 RID: 58871 RVA: 0x0038284C File Offset: 0x00380A4C
			// (set) Token: 0x0600E5F8 RID: 58872 RVA: 0x0006C708 File Offset: 0x0006A908
			public unsafe EClothingColor color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.__c__DisplayClass6_0.NativeFieldInfoPtr_color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.__c__DisplayClass6_0.NativeFieldInfoPtr_color)) = value;
				}
			}

			// Token: 0x04009C03 RID: 39939
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x04009C04 RID: 39940
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009C05 RID: 39941
			private static readonly IntPtr NativeMethodInfoPtr__GetColorData_b__0_Internal_Boolean_ColorData_0;
		}

		// Token: 0x02000B17 RID: 2839
		[ObfuscatedName("ScheduleOne.Clothing.ClothingUtility+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E5F9 RID: 58873 RVA: 0x00382874 File Offset: 0x00380A74
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass7_0>.NativeClassPtr);
				ClothingUtility.__c__DisplayClass7_0.NativeFieldInfoPtr_slot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass7_0>.NativeClassPtr, "slot");
				ClothingUtility.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass7_0>.NativeClassPtr, 100675582);
				ClothingUtility.__c__DisplayClass7_0.NativeMethodInfoPtr__GetSlotData_b__0_Internal_Boolean_ClothingSlotData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass7_0>.NativeClassPtr, 100675583);
			}

			// Token: 0x0600E5FA RID: 58874 RVA: 0x003828DC File Offset: 0x00380ADC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E5FB RID: 58875 RVA: 0x00382918 File Offset: 0x00380B18
			[CallerCount(0)]
			public unsafe bool _GetSlotData_b__0(ClothingUtility.ClothingSlotData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.__c__DisplayClass7_0.NativeMethodInfoPtr__GetSlotData_b__0_Internal_Boolean_ClothingSlotData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E5FC RID: 58876 RVA: 0x0006C723 File Offset: 0x0006A923
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045D4 RID: 17876
			// (get) Token: 0x0600E5FD RID: 58877 RVA: 0x00382968 File Offset: 0x00380B68
			// (set) Token: 0x0600E5FE RID: 58878 RVA: 0x0006C72C File Offset: 0x0006A92C
			public unsafe EClothingSlot slot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.__c__DisplayClass7_0.NativeFieldInfoPtr_slot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.__c__DisplayClass7_0.NativeFieldInfoPtr_slot)) = value;
				}
			}

			// Token: 0x04009C06 RID: 39942
			private static readonly IntPtr NativeFieldInfoPtr_slot;

			// Token: 0x04009C07 RID: 39943
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009C08 RID: 39944
			private static readonly IntPtr NativeMethodInfoPtr__GetSlotData_b__0_Internal_Boolean_ClothingSlotData_0;
		}
	}
}
