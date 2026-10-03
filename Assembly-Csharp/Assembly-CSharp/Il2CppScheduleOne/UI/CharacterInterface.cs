using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.State;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000723 RID: 1827
	public class CharacterInterface : MonoBehaviour
	{
		// Token: 0x0600B028 RID: 45096 RVA: 0x002E108C File Offset: 0x002DF28C
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterInterface()
		{
			Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "CharacterInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr);
			CharacterInterface.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, "<IsOpen>k__BackingField");
			CharacterInterface.NativeFieldInfoPtr_ClothingSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, "ClothingSlots");
			CharacterInterface.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, "Container");
			CharacterInterface.NativeFieldInfoPtr_RotationSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, "RotationSlider");
			CharacterInterface.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, "State");
			CharacterInterface.NativeFieldInfoPtr_SlotAlignmentPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, "SlotAlignmentPoints");
			CharacterInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, 100686466);
			CharacterInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, 100686467);
			CharacterInterface.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, 100686468);
			CharacterInterface.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, 100686469);
			CharacterInterface.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, 100686470);
			CharacterInterface.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, 100686471);
			CharacterInterface.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, 100686472);
			CharacterInterface.NativeMethodInfoPtr_SetIsActiveGameplayScreen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, 100686473);
			CharacterInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, 100686474);
			CharacterInterface.NativeMethodInfoPtr__Start_b__10_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, 100686475);
		}

		// Token: 0x170034F1 RID: 13553
		// (get) Token: 0x0600B029 RID: 45097 RVA: 0x002E11FC File Offset: 0x002DF3FC
		// (set) Token: 0x0600B02A RID: 45098 RVA: 0x002E1238 File Offset: 0x002DF438
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 30482, RefRangeEnd = 30484, XrefRangeStart = 30482, XrefRangeEnd = 30484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B02B RID: 45099 RVA: 0x002E1278 File Offset: 0x002DF478
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 299685, RefRangeEnd = 299686, XrefRangeStart = 299682, XrefRangeEnd = 299685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterInterface.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B02C RID: 45100 RVA: 0x002E12AC File Offset: 0x002DF4AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299686, XrefRangeEnd = 299719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterInterface.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B02D RID: 45101 RVA: 0x002E12E0 File Offset: 0x002DF4E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 299736, RefRangeEnd = 299737, XrefRangeStart = 299719, XrefRangeEnd = 299736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterInterface.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B02E RID: 45102 RVA: 0x002E1314 File Offset: 0x002DF514
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 299786, RefRangeEnd = 299787, XrefRangeStart = 299737, XrefRangeEnd = 299786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterInterface.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B02F RID: 45103 RVA: 0x002E1348 File Offset: 0x002DF548
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 299685, RefRangeEnd = 299686, XrefRangeStart = 299685, XrefRangeEnd = 299686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterInterface.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B030 RID: 45104 RVA: 0x002E137C File Offset: 0x002DF57C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 299790, RefRangeEnd = 299791, XrefRangeStart = 299787, XrefRangeEnd = 299790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsActiveGameplayScreen(bool isActive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isActive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterInterface.NativeMethodInfoPtr_SetIsActiveGameplayScreen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B031 RID: 45105 RVA: 0x002E13BC File Offset: 0x002DF5BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299791, XrefRangeEnd = 299799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B032 RID: 45106 RVA: 0x002E13F8 File Offset: 0x002DF5F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299799, XrefRangeEnd = 299805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__10_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterInterface.NativeMethodInfoPtr__Start_b__10_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B033 RID: 45107 RVA: 0x00050E42 File Offset: 0x0004F042
		public CharacterInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170034EB RID: 13547
		// (get) Token: 0x0600B034 RID: 45108 RVA: 0x002E142C File Offset: 0x002DF62C
		// (set) Token: 0x0600B035 RID: 45109 RVA: 0x00050E4B File Offset: 0x0004F04B
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x170034EC RID: 13548
		// (get) Token: 0x0600B036 RID: 45110 RVA: 0x002E1454 File Offset: 0x002DF654
		// (set) Token: 0x0600B037 RID: 45111 RVA: 0x00050E66 File Offset: 0x0004F066
		public unsafe Il2CppReferenceArray<ClothingSlotUI> ClothingSlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.NativeFieldInfoPtr_ClothingSlots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ClothingSlotUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.NativeFieldInfoPtr_ClothingSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034ED RID: 13549
		// (get) Token: 0x0600B038 RID: 45112 RVA: 0x002E1484 File Offset: 0x002DF684
		// (set) Token: 0x0600B039 RID: 45113 RVA: 0x00050E85 File Offset: 0x0004F085
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034EE RID: 13550
		// (get) Token: 0x0600B03A RID: 45114 RVA: 0x002E14B4 File Offset: 0x002DF6B4
		// (set) Token: 0x0600B03B RID: 45115 RVA: 0x00050EA4 File Offset: 0x0004F0A4
		public unsafe Slider RotationSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.NativeFieldInfoPtr_RotationSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.NativeFieldInfoPtr_RotationSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034EF RID: 13551
		// (get) Token: 0x0600B03C RID: 45116 RVA: 0x002E14E4 File Offset: 0x002DF6E4
		// (set) Token: 0x0600B03D RID: 45117 RVA: 0x00050EC3 File Offset: 0x0004F0C3
		public unsafe MonoState State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.NativeFieldInfoPtr_State);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.NativeFieldInfoPtr_State), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034F0 RID: 13552
		// (get) Token: 0x0600B03E RID: 45118 RVA: 0x002E1514 File Offset: 0x002DF714
		// (set) Token: 0x0600B03F RID: 45119 RVA: 0x00050EE2 File Offset: 0x0004F0E2
		public unsafe Dictionary<ClothingSlotUI, Transform> SlotAlignmentPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.NativeFieldInfoPtr_SlotAlignmentPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ClothingSlotUI, Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.NativeFieldInfoPtr_SlotAlignmentPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400796D RID: 31085
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x0400796E RID: 31086
		private static readonly IntPtr NativeFieldInfoPtr_ClothingSlots;

		// Token: 0x0400796F RID: 31087
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04007970 RID: 31088
		private static readonly IntPtr NativeFieldInfoPtr_RotationSlider;

		// Token: 0x04007971 RID: 31089
		private static readonly IntPtr NativeFieldInfoPtr_State;

		// Token: 0x04007972 RID: 31090
		private static readonly IntPtr NativeFieldInfoPtr_SlotAlignmentPoints;

		// Token: 0x04007973 RID: 31091
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04007974 RID: 31092
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04007975 RID: 31093
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04007976 RID: 31094
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04007977 RID: 31095
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04007978 RID: 31096
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04007979 RID: 31097
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x0400797A RID: 31098
		private static readonly IntPtr NativeMethodInfoPtr_SetIsActiveGameplayScreen_Public_Void_Boolean_0;

		// Token: 0x0400797B RID: 31099
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400797C RID: 31100
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__10_0_Private_Void_0;

		// Token: 0x02000CBD RID: 3261
		[ObfuscatedName("ScheduleOne.UI.CharacterInterface+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F42D RID: 62509 RVA: 0x003ABAC0 File Offset: 0x003A9CC0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<CharacterInterface.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterInterface.__c__DisplayClass12_0>.NativeClassPtr);
				CharacterInterface.__c__DisplayClass12_0.NativeFieldInfoPtr_slotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInterface.__c__DisplayClass12_0>.NativeClassPtr, "slotUI");
				CharacterInterface.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInterface.__c__DisplayClass12_0>.NativeClassPtr, 100686476);
				CharacterInterface.__c__DisplayClass12_0.NativeMethodInfoPtr__Open_b__0_Internal_Boolean_SlotAlignmentPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInterface.__c__DisplayClass12_0>.NativeClassPtr, 100686477);
			}

			// Token: 0x0600F42E RID: 62510 RVA: 0x003ABB28 File Offset: 0x003A9D28
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterInterface.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterInterface.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F42F RID: 62511 RVA: 0x003ABB64 File Offset: 0x003A9D64
			[CallerCount(0)]
			public unsafe bool _Open_b__0(CharacterDisplay.SlotAlignmentPoint x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterInterface.__c__DisplayClass12_0.NativeMethodInfoPtr__Open_b__0_Internal_Boolean_SlotAlignmentPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F430 RID: 62512 RVA: 0x000734EE File Offset: 0x000716EE
			public __c__DisplayClass12_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A1F RID: 18975
			// (get) Token: 0x0600F431 RID: 62513 RVA: 0x003ABBB4 File Offset: 0x003A9DB4
			// (set) Token: 0x0600F432 RID: 62514 RVA: 0x000734F7 File Offset: 0x000716F7
			public unsafe ClothingSlotUI slotUI
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.__c__DisplayClass12_0.NativeFieldInfoPtr_slotUI);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClothingSlotUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.__c__DisplayClass12_0.NativeFieldInfoPtr_slotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A555 RID: 42325
			private static readonly IntPtr NativeFieldInfoPtr_slotUI;

			// Token: 0x0400A556 RID: 42326
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A557 RID: 42327
			private static readonly IntPtr NativeMethodInfoPtr__Open_b__0_Internal_Boolean_SlotAlignmentPoint_0;
		}
	}
}
