using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Input
{
	// Token: 0x02000805 RID: 2053
	public class InputPromptsBindingData : ScriptableObject
	{
		// Token: 0x0600C780 RID: 51072 RVA: 0x003278D0 File Offset: 0x00325AD0
		// Note: this type is marked as 'beforefieldinit'.
		static InputPromptsBindingData()
		{
			Il2CppClassPointerStore<InputPromptsBindingData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Input", "InputPromptsBindingData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputPromptsBindingData>.NativeClassPtr);
			InputPromptsBindingData.NativeFieldInfoPtr_ControlScheme = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsBindingData>.NativeClassPtr, "ControlScheme");
			InputPromptsBindingData.NativeFieldInfoPtr_PlatformType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsBindingData>.NativeClassPtr, "PlatformType");
			InputPromptsBindingData.NativeFieldInfoPtr_ControlPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsBindingData>.NativeClassPtr, "ControlPath");
			InputPromptsBindingData.NativeFieldInfoPtr_Sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsBindingData>.NativeClassPtr, "Sprite");
			InputPromptsBindingData.NativeFieldInfoPtr_SpriteVariation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsBindingData>.NativeClassPtr, "SpriteVariation");
			InputPromptsBindingData.NativeFieldInfoPtr_SpriteSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsBindingData>.NativeClassPtr, "SpriteSize");
			InputPromptsBindingData.NativeFieldInfoPtr_SpriteLabelSettingType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsBindingData>.NativeClassPtr, "SpriteLabelSettingType");
			InputPromptsBindingData.NativeFieldInfoPtr_SpriteLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsBindingData>.NativeClassPtr, "SpriteLabel");
			InputPromptsBindingData.NativeFieldInfoPtr_SpritePixelMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsBindingData>.NativeClassPtr, "SpritePixelMultiplier");
			InputPromptsBindingData.NativeFieldInfoPtr_EnableSpriteBackdrop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsBindingData>.NativeClassPtr, "EnableSpriteBackdrop");
			InputPromptsBindingData.NativeFieldInfoPtr_SpriteColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsBindingData>.NativeClassPtr, "SpriteColor");
			InputPromptsBindingData.NativeFieldInfoPtr_InlineId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsBindingData>.NativeClassPtr, "InlineId");
			InputPromptsBindingData.NativeFieldInfoPtr_InlineLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsBindingData>.NativeClassPtr, "InlineLabel");
			InputPromptsBindingData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsBindingData>.NativeClassPtr, 100689118);
		}

		// Token: 0x0600C781 RID: 51073 RVA: 0x00327A18 File Offset: 0x00325C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328977, XrefRangeEnd = 328978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputPromptsBindingData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputPromptsBindingData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsBindingData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C782 RID: 51074 RVA: 0x0005E3E4 File Offset: 0x0005C5E4
		public InputPromptsBindingData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003C89 RID: 15497
		// (get) Token: 0x0600C783 RID: 51075 RVA: 0x00327A54 File Offset: 0x00325C54
		// (set) Token: 0x0600C784 RID: 51076 RVA: 0x0005E3ED File Offset: 0x0005C5ED
		public unsafe GameInput.InputDeviceType ControlScheme
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsBindingData.NativeFieldInfoPtr_ControlScheme);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsBindingData.NativeFieldInfoPtr_ControlScheme)) = value;
			}
		}

		// Token: 0x17003C8A RID: 15498
		// (get) Token: 0x0600C785 RID: 51077 RVA: 0x00327A7C File Offset: 0x00325C7C
		// (set) Token: 0x0600C786 RID: 51078 RVA: 0x0005E408 File Offset: 0x0005C608
		public unsafe EPlatformType PlatformType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsBindingData.NativeFieldInfoPtr_PlatformType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsBindingData.NativeFieldInfoPtr_PlatformType)) = value;
			}
		}

		// Token: 0x17003C8B RID: 15499
		// (get) Token: 0x0600C787 RID: 51079 RVA: 0x00327AA4 File Offset: 0x00325CA4
		// (set) Token: 0x0600C788 RID: 51080 RVA: 0x0005E423 File Offset: 0x0005C623
		public unsafe string ControlPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsBindingData.NativeFieldInfoPtr_ControlPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsBindingData.NativeFieldInfoPtr_ControlPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003C8C RID: 15500
		// (get) Token: 0x0600C789 RID: 51081 RVA: 0x00327ACC File Offset: 0x00325CCC
		// (set) Token: 0x0600C78A RID: 51082 RVA: 0x0005E442 File Offset: 0x0005C642
		public unsafe Sprite Sprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsBindingData.NativeFieldInfoPtr_Sprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsBindingData.NativeFieldInfoPtr_Sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C8D RID: 15501
		// (get) Token: 0x0600C78B RID: 51083 RVA: 0x00327AFC File Offset: 0x00325CFC
		// (set) Token: 0x0600C78C RID: 51084 RVA: 0x0005E461 File Offset: 0x0005C661
		public unsafe Sprite SpriteVariation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsBindingData.NativeFieldInfoPtr_SpriteVariation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsBindingData.NativeFieldInfoPtr_SpriteVariation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C8E RID: 15502
		// (get) Token: 0x0600C78D RID: 51085 RVA: 0x00327B2C File Offset: 0x00325D2C
		// (set) Token: 0x0600C78E RID: 51086 RVA: 0x0005E480 File Offset: 0x0005C680
		public unsafe Vector2 SpriteSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsBindingData.NativeFieldInfoPtr_SpriteSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsBindingData.NativeFieldInfoPtr_SpriteSize)) = value;
			}
		}

		// Token: 0x17003C8F RID: 15503
		// (get) Token: 0x0600C78F RID: 51087 RVA: 0x00327B54 File Offset: 0x00325D54
		// (set) Token: 0x0600C790 RID: 51088 RVA: 0x0005E49B File Offset: 0x0005C69B
		public unsafe InputPromptsBindingData.ESpriteSettingType SpriteLabelSettingType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsBindingData.NativeFieldInfoPtr_SpriteLabelSettingType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsBindingData.NativeFieldInfoPtr_SpriteLabelSettingType)) = value;
			}
		}

		// Token: 0x17003C90 RID: 15504
		// (get) Token: 0x0600C791 RID: 51089 RVA: 0x00327B7C File Offset: 0x00325D7C
		// (set) Token: 0x0600C792 RID: 51090 RVA: 0x0005E4B6 File Offset: 0x0005C6B6
		public unsafe string SpriteLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsBindingData.NativeFieldInfoPtr_SpriteLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsBindingData.NativeFieldInfoPtr_SpriteLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003C91 RID: 15505
		// (get) Token: 0x0600C793 RID: 51091 RVA: 0x00327BA4 File Offset: 0x00325DA4
		// (set) Token: 0x0600C794 RID: 51092 RVA: 0x0005E4D5 File Offset: 0x0005C6D5
		public unsafe float SpritePixelMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsBindingData.NativeFieldInfoPtr_SpritePixelMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsBindingData.NativeFieldInfoPtr_SpritePixelMultiplier)) = value;
			}
		}

		// Token: 0x17003C92 RID: 15506
		// (get) Token: 0x0600C795 RID: 51093 RVA: 0x00327BCC File Offset: 0x00325DCC
		// (set) Token: 0x0600C796 RID: 51094 RVA: 0x0005E4F0 File Offset: 0x0005C6F0
		public unsafe bool EnableSpriteBackdrop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsBindingData.NativeFieldInfoPtr_EnableSpriteBackdrop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsBindingData.NativeFieldInfoPtr_EnableSpriteBackdrop)) = value;
			}
		}

		// Token: 0x17003C93 RID: 15507
		// (get) Token: 0x0600C797 RID: 51095 RVA: 0x00327BF4 File Offset: 0x00325DF4
		// (set) Token: 0x0600C798 RID: 51096 RVA: 0x0005E50B File Offset: 0x0005C70B
		public unsafe Color SpriteColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsBindingData.NativeFieldInfoPtr_SpriteColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsBindingData.NativeFieldInfoPtr_SpriteColor)) = value;
			}
		}

		// Token: 0x17003C94 RID: 15508
		// (get) Token: 0x0600C799 RID: 51097 RVA: 0x00327C1C File Offset: 0x00325E1C
		// (set) Token: 0x0600C79A RID: 51098 RVA: 0x0005E526 File Offset: 0x0005C726
		public unsafe string InlineId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsBindingData.NativeFieldInfoPtr_InlineId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsBindingData.NativeFieldInfoPtr_InlineId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003C95 RID: 15509
		// (get) Token: 0x0600C79B RID: 51099 RVA: 0x00327C44 File Offset: 0x00325E44
		// (set) Token: 0x0600C79C RID: 51100 RVA: 0x0005E545 File Offset: 0x0005C745
		public unsafe string InlineLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsBindingData.NativeFieldInfoPtr_InlineLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsBindingData.NativeFieldInfoPtr_InlineLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04008802 RID: 34818
		private static readonly IntPtr NativeFieldInfoPtr_ControlScheme;

		// Token: 0x04008803 RID: 34819
		private static readonly IntPtr NativeFieldInfoPtr_PlatformType;

		// Token: 0x04008804 RID: 34820
		private static readonly IntPtr NativeFieldInfoPtr_ControlPath;

		// Token: 0x04008805 RID: 34821
		private static readonly IntPtr NativeFieldInfoPtr_Sprite;

		// Token: 0x04008806 RID: 34822
		private static readonly IntPtr NativeFieldInfoPtr_SpriteVariation;

		// Token: 0x04008807 RID: 34823
		private static readonly IntPtr NativeFieldInfoPtr_SpriteSize;

		// Token: 0x04008808 RID: 34824
		private static readonly IntPtr NativeFieldInfoPtr_SpriteLabelSettingType;

		// Token: 0x04008809 RID: 34825
		private static readonly IntPtr NativeFieldInfoPtr_SpriteLabel;

		// Token: 0x0400880A RID: 34826
		private static readonly IntPtr NativeFieldInfoPtr_SpritePixelMultiplier;

		// Token: 0x0400880B RID: 34827
		private static readonly IntPtr NativeFieldInfoPtr_EnableSpriteBackdrop;

		// Token: 0x0400880C RID: 34828
		private static readonly IntPtr NativeFieldInfoPtr_SpriteColor;

		// Token: 0x0400880D RID: 34829
		private static readonly IntPtr NativeFieldInfoPtr_InlineId;

		// Token: 0x0400880E RID: 34830
		private static readonly IntPtr NativeFieldInfoPtr_InlineLabel;

		// Token: 0x0400880F RID: 34831
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D6E RID: 3438
		[OriginalName("Assembly-CSharp.dll", "", "ESpriteSettingType")]
		public enum ESpriteSettingType
		{
			// Token: 0x0400A984 RID: 43396
			Auto,
			// Token: 0x0400A985 RID: 43397
			Custom
		}
	}
}
