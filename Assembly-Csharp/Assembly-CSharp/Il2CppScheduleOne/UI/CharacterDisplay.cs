using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework;
using Il2CppScheduleOne.Clothing;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000722 RID: 1826
	public class CharacterDisplay : Singleton<CharacterDisplay>
	{
		// Token: 0x0600B010 RID: 45072 RVA: 0x002E0C10 File Offset: 0x002DEE10
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterDisplay()
		{
			Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "CharacterDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr);
			CharacterDisplay.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, "<IsOpen>k__BackingField");
			CharacterDisplay.NativeFieldInfoPtr_AlignmentPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, "AlignmentPoints");
			CharacterDisplay.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, "Container");
			CharacterDisplay.NativeFieldInfoPtr_ParentAvatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, "ParentAvatar");
			CharacterDisplay.NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, "Avatar");
			CharacterDisplay.NativeFieldInfoPtr_AvatarContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, "AvatarContainer");
			CharacterDisplay.NativeFieldInfoPtr_targetRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, "targetRotation");
			CharacterDisplay.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, 100686457);
			CharacterDisplay.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, 100686458);
			CharacterDisplay.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, 100686459);
			CharacterDisplay.NativeMethodInfoPtr_SetOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, 100686460);
			CharacterDisplay.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, 100686461);
			CharacterDisplay.NativeMethodInfoPtr_SetAppearance_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, 100686462);
			CharacterDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, 100686463);
			CharacterDisplay.NativeMethodInfoPtr__Awake_b__11_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, 100686464);
		}

		// Token: 0x170034EA RID: 13546
		// (get) Token: 0x0600B011 RID: 45073 RVA: 0x002E0D6C File Offset: 0x002DEF6C
		// (set) Token: 0x0600B012 RID: 45074 RVA: 0x002E0DA8 File Offset: 0x002DEFA8
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterDisplay.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 33070, RefRangeEnd = 33090, XrefRangeStart = 33070, XrefRangeEnd = 33090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterDisplay.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B013 RID: 45075 RVA: 0x002E0DE8 File Offset: 0x002DEFE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299590, XrefRangeEnd = 299611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterDisplay.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B014 RID: 45076 RVA: 0x002E0E24 File Offset: 0x002DF024
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 299633, RefRangeEnd = 299638, XrefRangeStart = 299611, XrefRangeEnd = 299633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterDisplay.NativeMethodInfoPtr_SetOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B015 RID: 45077 RVA: 0x002E0E64 File Offset: 0x002DF064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299638, XrefRangeEnd = 299646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterDisplay.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B016 RID: 45078 RVA: 0x002E0E98 File Offset: 0x002DF098
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 299674, RefRangeEnd = 299677, XrefRangeStart = 299646, XrefRangeEnd = 299674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAppearance(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterDisplay.NativeMethodInfoPtr_SetAppearance_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B017 RID: 45079 RVA: 0x002E0EDC File Offset: 0x002DF0DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299677, XrefRangeEnd = 299680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterDisplay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B018 RID: 45080 RVA: 0x002E0F18 File Offset: 0x002DF118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299680, XrefRangeEnd = 299682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__11_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterDisplay.NativeMethodInfoPtr__Awake_b__11_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B019 RID: 45081 RVA: 0x00050D68 File Offset: 0x0004EF68
		public CharacterDisplay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170034E3 RID: 13539
		// (get) Token: 0x0600B01A RID: 45082 RVA: 0x002E0F4C File Offset: 0x002DF14C
		// (set) Token: 0x0600B01B RID: 45083 RVA: 0x00050D71 File Offset: 0x0004EF71
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x170034E4 RID: 13540
		// (get) Token: 0x0600B01C RID: 45084 RVA: 0x002E0F74 File Offset: 0x002DF174
		// (set) Token: 0x0600B01D RID: 45085 RVA: 0x00050D8C File Offset: 0x0004EF8C
		public unsafe Il2CppReferenceArray<CharacterDisplay.SlotAlignmentPoint> AlignmentPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_AlignmentPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CharacterDisplay.SlotAlignmentPoint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_AlignmentPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034E5 RID: 13541
		// (get) Token: 0x0600B01E RID: 45086 RVA: 0x002E0FA4 File Offset: 0x002DF1A4
		// (set) Token: 0x0600B01F RID: 45087 RVA: 0x00050DAB File Offset: 0x0004EFAB
		public unsafe Transform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034E6 RID: 13542
		// (get) Token: 0x0600B020 RID: 45088 RVA: 0x002E0FD4 File Offset: 0x002DF1D4
		// (set) Token: 0x0600B021 RID: 45089 RVA: 0x00050DCA File Offset: 0x0004EFCA
		public unsafe Il2CppScheduleOne.AvatarFramework.Avatar ParentAvatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_ParentAvatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppScheduleOne.AvatarFramework.Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_ParentAvatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034E7 RID: 13543
		// (get) Token: 0x0600B022 RID: 45090 RVA: 0x002E1004 File Offset: 0x002DF204
		// (set) Token: 0x0600B023 RID: 45091 RVA: 0x00050DE9 File Offset: 0x0004EFE9
		public unsafe Il2CppScheduleOne.AvatarFramework.Avatar Avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_Avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppScheduleOne.AvatarFramework.Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034E8 RID: 13544
		// (get) Token: 0x0600B024 RID: 45092 RVA: 0x002E1034 File Offset: 0x002DF234
		// (set) Token: 0x0600B025 RID: 45093 RVA: 0x00050E08 File Offset: 0x0004F008
		public unsafe Transform AvatarContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_AvatarContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_AvatarContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034E9 RID: 13545
		// (get) Token: 0x0600B026 RID: 45094 RVA: 0x002E1064 File Offset: 0x002DF264
		// (set) Token: 0x0600B027 RID: 45095 RVA: 0x00050E27 File Offset: 0x0004F027
		public unsafe float targetRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_targetRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_targetRotation)) = value;
			}
		}

		// Token: 0x0400795E RID: 31070
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x0400795F RID: 31071
		private static readonly IntPtr NativeFieldInfoPtr_AlignmentPoints;

		// Token: 0x04007960 RID: 31072
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04007961 RID: 31073
		private static readonly IntPtr NativeFieldInfoPtr_ParentAvatar;

		// Token: 0x04007962 RID: 31074
		private static readonly IntPtr NativeFieldInfoPtr_Avatar;

		// Token: 0x04007963 RID: 31075
		private static readonly IntPtr NativeFieldInfoPtr_AvatarContainer;

		// Token: 0x04007964 RID: 31076
		private static readonly IntPtr NativeFieldInfoPtr_targetRotation;

		// Token: 0x04007965 RID: 31077
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04007966 RID: 31078
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04007967 RID: 31079
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04007968 RID: 31080
		private static readonly IntPtr NativeMethodInfoPtr_SetOpen_Public_Void_Boolean_0;

		// Token: 0x04007969 RID: 31081
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400796A RID: 31082
		private static readonly IntPtr NativeMethodInfoPtr_SetAppearance_Public_Void_AvatarSettings_0;

		// Token: 0x0400796B RID: 31083
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400796C RID: 31084
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__11_0_Private_Void_0;

		// Token: 0x02000CBC RID: 3260
		[Serializable]
		public class SlotAlignmentPoint : Il2CppSystem.Object
		{
			// Token: 0x0600F426 RID: 62502 RVA: 0x003AB9C4 File Offset: 0x003A9BC4
			// Note: this type is marked as 'beforefieldinit'.
			static SlotAlignmentPoint()
			{
				Il2CppClassPointerStore<CharacterDisplay.SlotAlignmentPoint>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, "SlotAlignmentPoint");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterDisplay.SlotAlignmentPoint>.NativeClassPtr);
				CharacterDisplay.SlotAlignmentPoint.NativeFieldInfoPtr_SlotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay.SlotAlignmentPoint>.NativeClassPtr, "SlotType");
				CharacterDisplay.SlotAlignmentPoint.NativeFieldInfoPtr_Point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay.SlotAlignmentPoint>.NativeClassPtr, "Point");
				CharacterDisplay.SlotAlignmentPoint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay.SlotAlignmentPoint>.NativeClassPtr, 100686465);
			}

			// Token: 0x0600F427 RID: 62503 RVA: 0x003ABA2C File Offset: 0x003A9C2C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SlotAlignmentPoint() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterDisplay.SlotAlignmentPoint>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterDisplay.SlotAlignmentPoint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F428 RID: 62504 RVA: 0x000734AB File Offset: 0x000716AB
			public SlotAlignmentPoint(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A1D RID: 18973
			// (get) Token: 0x0600F429 RID: 62505 RVA: 0x003ABA68 File Offset: 0x003A9C68
			// (set) Token: 0x0600F42A RID: 62506 RVA: 0x000734B4 File Offset: 0x000716B4
			public unsafe EClothingSlot SlotType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.SlotAlignmentPoint.NativeFieldInfoPtr_SlotType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.SlotAlignmentPoint.NativeFieldInfoPtr_SlotType)) = value;
				}
			}

			// Token: 0x17004A1E RID: 18974
			// (get) Token: 0x0600F42B RID: 62507 RVA: 0x003ABA90 File Offset: 0x003A9C90
			// (set) Token: 0x0600F42C RID: 62508 RVA: 0x000734CF File Offset: 0x000716CF
			public unsafe Transform Point
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.SlotAlignmentPoint.NativeFieldInfoPtr_Point);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.SlotAlignmentPoint.NativeFieldInfoPtr_Point), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A552 RID: 42322
			private static readonly IntPtr NativeFieldInfoPtr_SlotType;

			// Token: 0x0400A553 RID: 42323
			private static readonly IntPtr NativeFieldInfoPtr_Point;

			// Token: 0x0400A554 RID: 42324
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
