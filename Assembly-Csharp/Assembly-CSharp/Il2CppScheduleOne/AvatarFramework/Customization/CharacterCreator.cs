using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Clothing;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.State;
using Il2CppScheduleOne.UI.CharacterCreator;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x020004B7 RID: 1207
	public class CharacterCreator : Singleton<CharacterCreator>
	{
		// Token: 0x06006DEC RID: 28140 RVA: 0x001F67B0 File Offset: 0x001F49B0
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterCreator()
		{
			Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "CharacterCreator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr);
			CharacterCreator.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "<IsOpen>k__BackingField");
			CharacterCreator.NativeFieldInfoPtr_Fields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "Fields");
			CharacterCreator.NativeFieldInfoPtr__ActiveSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "<ActiveSettings>k__BackingField");
			CharacterCreator.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "Container");
			CharacterCreator.NativeFieldInfoPtr_CameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "CameraPosition");
			CharacterCreator.NativeFieldInfoPtr_RigContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "RigContainer");
			CharacterCreator.NativeFieldInfoPtr_Rig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "Rig");
			CharacterCreator.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "Canvas");
			CharacterCreator.NativeFieldInfoPtr_CanvasAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "CanvasAnimation");
			CharacterCreator.NativeFieldInfoPtr_CreatorMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "CreatorMenu");
			CharacterCreator.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "State");
			CharacterCreator.NativeFieldInfoPtr_DefaultSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "DefaultSettings");
			CharacterCreator.NativeFieldInfoPtr_Presets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "Presets");
			CharacterCreator.NativeFieldInfoPtr_onComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "onComplete");
			CharacterCreator.NativeFieldInfoPtr_onCompleteWithClothing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "onCompleteWithClothing");
			CharacterCreator.NativeFieldInfoPtr_lastSelectedClothingDefinitions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "lastSelectedClothingDefinitions");
			CharacterCreator.NativeFieldInfoPtr_rigTargetY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "rigTargetY");
			CharacterCreator.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100677621);
			CharacterCreator.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100677622);
			CharacterCreator.NativeMethodInfoPtr_get_ActiveSettings_Public_get_BasicAvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100677623);
			CharacterCreator.NativeMethodInfoPtr_set_ActiveSettings_Protected_set_Void_BasicAvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100677624);
			CharacterCreator.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100677625);
			CharacterCreator.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100677626);
			CharacterCreator.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100677627);
			CharacterCreator.NativeMethodInfoPtr_Open_Public_Void_BasicAvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100677628);
			CharacterCreator.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100677629);
			CharacterCreator.NativeMethodInfoPtr_DisableStuff_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100677630);
			CharacterCreator.NativeMethodInfoPtr_Done_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100677631);
			CharacterCreator.NativeMethodInfoPtr_SliderChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100677632);
			CharacterCreator.NativeMethodInfoPtr_SetValue_Public_T_String_T_ClothingDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100677633);
			CharacterCreator.NativeMethodInfoPtr_SelectPreset_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100677634);
			CharacterCreator.NativeMethodInfoPtr_RefreshCategory_Public_Void_ECategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100677635);
			CharacterCreator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100677636);
		}

		// Token: 0x170021E5 RID: 8677
		// (get) Token: 0x06006DED RID: 28141 RVA: 0x001F6A74 File Offset: 0x001F4C74
		// (set) Token: 0x06006DEE RID: 28142 RVA: 0x001F6AB0 File Offset: 0x001F4CB0
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170021E6 RID: 8678
		// (get) Token: 0x06006DEF RID: 28143 RVA: 0x001F6AF0 File Offset: 0x001F4CF0
		// (set) Token: 0x06006DF0 RID: 28144 RVA: 0x001F6B30 File Offset: 0x001F4D30
		public unsafe BasicAvatarSettings ActiveSettings
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 2980, RefRangeEnd = 2987, XrefRangeStart = 2980, XrefRangeEnd = 2987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_get_ActiveSettings_Public_get_BasicAvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BasicAvatarSettings>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_set_ActiveSettings_Protected_set_Void_BasicAvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006DF1 RID: 28145 RVA: 0x001F6B74 File Offset: 0x001F4D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222395, XrefRangeEnd = 222409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreator.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DF2 RID: 28146 RVA: 0x001F6BB0 File Offset: 0x001F4DB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222409, XrefRangeEnd = 222415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreator.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DF3 RID: 28147 RVA: 0x001F6BEC File Offset: 0x001F4DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222415, XrefRangeEnd = 222419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DF4 RID: 28148 RVA: 0x001F6C20 File Offset: 0x001F4E20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222475, RefRangeEnd = 222476, XrefRangeStart = 222419, XrefRangeEnd = 222475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(BasicAvatarSettings initialSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(initialSettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_Open_Public_Void_BasicAvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DF5 RID: 28149 RVA: 0x001F6C64 File Offset: 0x001F4E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222476, XrefRangeEnd = 222490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DF6 RID: 28150 RVA: 0x001F6C98 File Offset: 0x001F4E98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222493, RefRangeEnd = 222494, XrefRangeStart = 222490, XrefRangeEnd = 222493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableStuff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_DisableStuff_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DF7 RID: 28151 RVA: 0x001F6CCC File Offset: 0x001F4ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222494, XrefRangeEnd = 222556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Done()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_Done_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DF8 RID: 28152 RVA: 0x001F6D00 File Offset: 0x001F4F00
		[CallerCount(0)]
		public unsafe void SliderChanged(float newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_SliderChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DF9 RID: 28153 RVA: 0x001F6D40 File Offset: 0x001F4F40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222576, RefRangeEnd = 222577, XrefRangeStart = 222556, XrefRangeEnd = 222576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T SetValue<T>(string fieldName, T value, ClothingDefinition definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(fieldName);
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				if (!(t is string))
				{
					ref T ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
					if (ref ptr3 != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr4 = ref value;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(definition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.MethodInfoStoreGeneric_SetValue_Public_T_String_T_ClothingDefinition_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06006DFA RID: 28154 RVA: 0x001F6DFC File Offset: 0x001F4FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222577, XrefRangeEnd = 222615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectPreset(string presetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(presetName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_SelectPreset_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DFB RID: 28155 RVA: 0x001F6E40 File Offset: 0x001F5040
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222619, RefRangeEnd = 222620, XrefRangeStart = 222615, XrefRangeEnd = 222619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshCategory(CharacterCreator.ECategory category)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref category;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_RefreshCategory_Public_Void_ECategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DFC RID: 28156 RVA: 0x001F6E80 File Offset: 0x001F5080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222620, XrefRangeEnd = 222637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterCreator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DFD RID: 28157 RVA: 0x00033FB5 File Offset: 0x000321B5
		public CharacterCreator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021D4 RID: 8660
		// (get) Token: 0x06006DFE RID: 28158 RVA: 0x001F6EBC File Offset: 0x001F50BC
		// (set) Token: 0x06006DFF RID: 28159 RVA: 0x00033FBE File Offset: 0x000321BE
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x170021D5 RID: 8661
		// (get) Token: 0x06006E00 RID: 28160 RVA: 0x001F6EE4 File Offset: 0x001F50E4
		// (set) Token: 0x06006E01 RID: 28161 RVA: 0x00033FD9 File Offset: 0x000321D9
		public unsafe List<BaseCharacterCreatorField> Fields
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_Fields);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BaseCharacterCreatorField>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_Fields), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021D6 RID: 8662
		// (get) Token: 0x06006E02 RID: 28162 RVA: 0x001F6F14 File Offset: 0x001F5114
		// (set) Token: 0x06006E03 RID: 28163 RVA: 0x00033FF8 File Offset: 0x000321F8
		public unsafe BasicAvatarSettings _ActiveSettings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr__ActiveSettings_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BasicAvatarSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr__ActiveSettings_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021D7 RID: 8663
		// (get) Token: 0x06006E04 RID: 28164 RVA: 0x001F6F44 File Offset: 0x001F5144
		// (set) Token: 0x06006E05 RID: 28165 RVA: 0x00034017 File Offset: 0x00032217
		public unsafe Transform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021D8 RID: 8664
		// (get) Token: 0x06006E06 RID: 28166 RVA: 0x001F6F74 File Offset: 0x001F5174
		// (set) Token: 0x06006E07 RID: 28167 RVA: 0x00034036 File Offset: 0x00032236
		public unsafe Transform CameraPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_CameraPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_CameraPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021D9 RID: 8665
		// (get) Token: 0x06006E08 RID: 28168 RVA: 0x001F6FA4 File Offset: 0x001F51A4
		// (set) Token: 0x06006E09 RID: 28169 RVA: 0x00034055 File Offset: 0x00032255
		public unsafe Transform RigContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_RigContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_RigContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021DA RID: 8666
		// (get) Token: 0x06006E0A RID: 28170 RVA: 0x001F6FD4 File Offset: 0x001F51D4
		// (set) Token: 0x06006E0B RID: 28171 RVA: 0x00034074 File Offset: 0x00032274
		public unsafe Avatar Rig
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_Rig);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_Rig), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021DB RID: 8667
		// (get) Token: 0x06006E0C RID: 28172 RVA: 0x001F7004 File Offset: 0x001F5204
		// (set) Token: 0x06006E0D RID: 28173 RVA: 0x00034093 File Offset: 0x00032293
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021DC RID: 8668
		// (get) Token: 0x06006E0E RID: 28174 RVA: 0x001F7034 File Offset: 0x001F5234
		// (set) Token: 0x06006E0F RID: 28175 RVA: 0x000340B2 File Offset: 0x000322B2
		public unsafe Animation CanvasAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_CanvasAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_CanvasAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021DD RID: 8669
		// (get) Token: 0x06006E10 RID: 28176 RVA: 0x001F7064 File Offset: 0x001F5264
		// (set) Token: 0x06006E11 RID: 28177 RVA: 0x000340D1 File Offset: 0x000322D1
		public unsafe CharacterCreatorMenu CreatorMenu
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_CreatorMenu);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCreatorMenu>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_CreatorMenu), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021DE RID: 8670
		// (get) Token: 0x06006E12 RID: 28178 RVA: 0x001F7094 File Offset: 0x001F5294
		// (set) Token: 0x06006E13 RID: 28179 RVA: 0x000340F0 File Offset: 0x000322F0
		public unsafe MonoState State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_State);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_State), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021DF RID: 8671
		// (get) Token: 0x06006E14 RID: 28180 RVA: 0x001F70C4 File Offset: 0x001F52C4
		// (set) Token: 0x06006E15 RID: 28181 RVA: 0x0003410F File Offset: 0x0003230F
		public unsafe BasicAvatarSettings DefaultSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_DefaultSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BasicAvatarSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_DefaultSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021E0 RID: 8672
		// (get) Token: 0x06006E16 RID: 28182 RVA: 0x001F70F4 File Offset: 0x001F52F4
		// (set) Token: 0x06006E17 RID: 28183 RVA: 0x0003412E File Offset: 0x0003232E
		public unsafe List<BasicAvatarSettings> Presets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_Presets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BasicAvatarSettings>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_Presets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021E1 RID: 8673
		// (get) Token: 0x06006E18 RID: 28184 RVA: 0x001F7124 File Offset: 0x001F5324
		// (set) Token: 0x06006E19 RID: 28185 RVA: 0x0003414D File Offset: 0x0003234D
		public unsafe UnityEvent<BasicAvatarSettings> onComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_onComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<BasicAvatarSettings>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_onComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021E2 RID: 8674
		// (get) Token: 0x06006E1A RID: 28186 RVA: 0x001F7154 File Offset: 0x001F5354
		// (set) Token: 0x06006E1B RID: 28187 RVA: 0x0003416C File Offset: 0x0003236C
		public unsafe UnityEvent<BasicAvatarSettings, List<ClothingInstance>> onCompleteWithClothing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_onCompleteWithClothing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<BasicAvatarSettings, List<ClothingInstance>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_onCompleteWithClothing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021E3 RID: 8675
		// (get) Token: 0x06006E1C RID: 28188 RVA: 0x001F7184 File Offset: 0x001F5384
		// (set) Token: 0x06006E1D RID: 28189 RVA: 0x0003418B File Offset: 0x0003238B
		public unsafe Dictionary<string, ClothingDefinition> lastSelectedClothingDefinitions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_lastSelectedClothingDefinitions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ClothingDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_lastSelectedClothingDefinitions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021E4 RID: 8676
		// (get) Token: 0x06006E1E RID: 28190 RVA: 0x001F71B4 File Offset: 0x001F53B4
		// (set) Token: 0x06006E1F RID: 28191 RVA: 0x000341AA File Offset: 0x000323AA
		public unsafe float rigTargetY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_rigTargetY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_rigTargetY)) = value;
			}
		}

		// Token: 0x04004B6B RID: 19307
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04004B6C RID: 19308
		private static readonly IntPtr NativeFieldInfoPtr_Fields;

		// Token: 0x04004B6D RID: 19309
		private static readonly IntPtr NativeFieldInfoPtr__ActiveSettings_k__BackingField;

		// Token: 0x04004B6E RID: 19310
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04004B6F RID: 19311
		private static readonly IntPtr NativeFieldInfoPtr_CameraPosition;

		// Token: 0x04004B70 RID: 19312
		private static readonly IntPtr NativeFieldInfoPtr_RigContainer;

		// Token: 0x04004B71 RID: 19313
		private static readonly IntPtr NativeFieldInfoPtr_Rig;

		// Token: 0x04004B72 RID: 19314
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04004B73 RID: 19315
		private static readonly IntPtr NativeFieldInfoPtr_CanvasAnimation;

		// Token: 0x04004B74 RID: 19316
		private static readonly IntPtr NativeFieldInfoPtr_CreatorMenu;

		// Token: 0x04004B75 RID: 19317
		private static readonly IntPtr NativeFieldInfoPtr_State;

		// Token: 0x04004B76 RID: 19318
		private static readonly IntPtr NativeFieldInfoPtr_DefaultSettings;

		// Token: 0x04004B77 RID: 19319
		private static readonly IntPtr NativeFieldInfoPtr_Presets;

		// Token: 0x04004B78 RID: 19320
		private static readonly IntPtr NativeFieldInfoPtr_onComplete;

		// Token: 0x04004B79 RID: 19321
		private static readonly IntPtr NativeFieldInfoPtr_onCompleteWithClothing;

		// Token: 0x04004B7A RID: 19322
		private static readonly IntPtr NativeFieldInfoPtr_lastSelectedClothingDefinitions;

		// Token: 0x04004B7B RID: 19323
		private static readonly IntPtr NativeFieldInfoPtr_rigTargetY;

		// Token: 0x04004B7C RID: 19324
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04004B7D RID: 19325
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04004B7E RID: 19326
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveSettings_Public_get_BasicAvatarSettings_0;

		// Token: 0x04004B7F RID: 19327
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveSettings_Protected_set_Void_BasicAvatarSettings_0;

		// Token: 0x04004B80 RID: 19328
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04004B81 RID: 19329
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04004B82 RID: 19330
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004B83 RID: 19331
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_BasicAvatarSettings_0;

		// Token: 0x04004B84 RID: 19332
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04004B85 RID: 19333
		private static readonly IntPtr NativeMethodInfoPtr_DisableStuff_Public_Void_0;

		// Token: 0x04004B86 RID: 19334
		private static readonly IntPtr NativeMethodInfoPtr_Done_Public_Void_0;

		// Token: 0x04004B87 RID: 19335
		private static readonly IntPtr NativeMethodInfoPtr_SliderChanged_Public_Void_Single_0;

		// Token: 0x04004B88 RID: 19336
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_T_String_T_ClothingDefinition_0;

		// Token: 0x04004B89 RID: 19337
		private static readonly IntPtr NativeMethodInfoPtr_SelectPreset_Public_Void_String_0;

		// Token: 0x04004B8A RID: 19338
		private static readonly IntPtr NativeMethodInfoPtr_RefreshCategory_Public_Void_ECategory_0;

		// Token: 0x04004B8B RID: 19339
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B76 RID: 2934
		[OriginalName("Assembly-CSharp.dll", "", "ECategory")]
		public enum ECategory
		{
			// Token: 0x04009DE3 RID: 40419
			Body,
			// Token: 0x04009DE4 RID: 40420
			Hair,
			// Token: 0x04009DE5 RID: 40421
			Face,
			// Token: 0x04009DE6 RID: 40422
			Eyes,
			// Token: 0x04009DE7 RID: 40423
			Eyebrows,
			// Token: 0x04009DE8 RID: 40424
			Clothing,
			// Token: 0x04009DE9 RID: 40425
			Accessories
		}

		// Token: 0x02000B77 RID: 2935
		[ObfuscatedName("ScheduleOne.AvatarFramework.Customization.CharacterCreator+<>c__DisplayClass33_0")]
		public sealed class __c__DisplayClass33_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E8D6 RID: 59606 RVA: 0x0038AAC8 File Offset: 0x00388CC8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass33_0()
			{
				Il2CppClassPointerStore<CharacterCreator.__c__DisplayClass33_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "<>c__DisplayClass33_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreator.__c__DisplayClass33_0>.NativeClassPtr);
				CharacterCreator.__c__DisplayClass33_0.NativeFieldInfoPtr_presetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator.__c__DisplayClass33_0>.NativeClassPtr, "presetName");
				CharacterCreator.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator.__c__DisplayClass33_0>.NativeClassPtr, 100677637);
				CharacterCreator.__c__DisplayClass33_0.NativeMethodInfoPtr__SelectPreset_b__0_Internal_Boolean_BasicAvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator.__c__DisplayClass33_0>.NativeClassPtr, 100677638);
			}

			// Token: 0x0600E8D7 RID: 59607 RVA: 0x0038AB30 File Offset: 0x00388D30
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass33_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreator.__c__DisplayClass33_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E8D8 RID: 59608 RVA: 0x0038AB6C File Offset: 0x00388D6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SelectPreset_b__0(BasicAvatarSettings p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.__c__DisplayClass33_0.NativeMethodInfoPtr__SelectPreset_b__0_Internal_Boolean_BasicAvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E8D9 RID: 59609 RVA: 0x0006DD1F File Offset: 0x0006BF1F
			public __c__DisplayClass33_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700469E RID: 18078
			// (get) Token: 0x0600E8DA RID: 59610 RVA: 0x0038ABBC File Offset: 0x00388DBC
			// (set) Token: 0x0600E8DB RID: 59611 RVA: 0x0006DD28 File Offset: 0x0006BF28
			public unsafe string presetName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.__c__DisplayClass33_0.NativeFieldInfoPtr_presetName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.__c__DisplayClass33_0.NativeFieldInfoPtr_presetName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009DEA RID: 40426
			private static readonly IntPtr NativeFieldInfoPtr_presetName;

			// Token: 0x04009DEB RID: 40427
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009DEC RID: 40428
			private static readonly IntPtr NativeMethodInfoPtr__SelectPreset_b__0_Internal_Boolean_BasicAvatarSettings_0;
		}

		// Token: 0x02000B78 RID: 2936
		private sealed class MethodInfoStoreGeneric_SetValue_Public_T_String_T_ClothingDefinition_0<T>
		{
			// Token: 0x04009DED RID: 40429
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CharacterCreator.NativeMethodInfoPtr_SetValue_Public_T_String_T_ClothingDefinition_0, Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
