using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x020004B6 RID: 1206
	[Serializable]
	public class BasicAvatarSettings : ScriptableObject
	{
		// Token: 0x06006DA6 RID: 28070 RVA: 0x001F5DD8 File Offset: 0x001F3FD8
		// Note: this type is marked as 'beforefieldinit'.
		static BasicAvatarSettings()
		{
			Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "BasicAvatarSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr);
			BasicAvatarSettings.NativeFieldInfoPtr_GenderScaleMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "GenderScaleMultiplier");
			BasicAvatarSettings.NativeFieldInfoPtr_MaleUnderwearPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "MaleUnderwearPath");
			BasicAvatarSettings.NativeFieldInfoPtr_FemaleUnderwearPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "FemaleUnderwearPath");
			BasicAvatarSettings.NativeFieldInfoPtr_Gender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "Gender");
			BasicAvatarSettings.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "Weight");
			BasicAvatarSettings.NativeFieldInfoPtr_SkinColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "SkinColor");
			BasicAvatarSettings.NativeFieldInfoPtr_HairStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "HairStyle");
			BasicAvatarSettings.NativeFieldInfoPtr_HairColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "HairColor");
			BasicAvatarSettings.NativeFieldInfoPtr_Mouth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "Mouth");
			BasicAvatarSettings.NativeFieldInfoPtr_FacialHair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "FacialHair");
			BasicAvatarSettings.NativeFieldInfoPtr_FacialDetails = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "FacialDetails");
			BasicAvatarSettings.NativeFieldInfoPtr_FacialDetailsIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "FacialDetailsIntensity");
			BasicAvatarSettings.NativeFieldInfoPtr_EyeballColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "EyeballColor");
			BasicAvatarSettings.NativeFieldInfoPtr_UpperEyeLidRestingPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "UpperEyeLidRestingPosition");
			BasicAvatarSettings.NativeFieldInfoPtr_LowerEyeLidRestingPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "LowerEyeLidRestingPosition");
			BasicAvatarSettings.NativeFieldInfoPtr_PupilDilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "PupilDilation");
			BasicAvatarSettings.NativeFieldInfoPtr_EyebrowScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "EyebrowScale");
			BasicAvatarSettings.NativeFieldInfoPtr_EyebrowThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "EyebrowThickness");
			BasicAvatarSettings.NativeFieldInfoPtr_EyebrowRestingHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "EyebrowRestingHeight");
			BasicAvatarSettings.NativeFieldInfoPtr_EyebrowRestingAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "EyebrowRestingAngle");
			BasicAvatarSettings.NativeFieldInfoPtr_Top = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "Top");
			BasicAvatarSettings.NativeFieldInfoPtr_TopColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "TopColor");
			BasicAvatarSettings.NativeFieldInfoPtr_Bottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "Bottom");
			BasicAvatarSettings.NativeFieldInfoPtr_BottomColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "BottomColor");
			BasicAvatarSettings.NativeFieldInfoPtr_Shoes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "Shoes");
			BasicAvatarSettings.NativeFieldInfoPtr_ShoesColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "ShoesColor");
			BasicAvatarSettings.NativeFieldInfoPtr_Headwear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "Headwear");
			BasicAvatarSettings.NativeFieldInfoPtr_HeadwearColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "HeadwearColor");
			BasicAvatarSettings.NativeFieldInfoPtr_Eyewear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "Eyewear");
			BasicAvatarSettings.NativeFieldInfoPtr_EyewearColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "EyewearColor");
			BasicAvatarSettings.NativeFieldInfoPtr_Tattoos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "Tattoos");
			BasicAvatarSettings.NativeMethodInfoPtr_SetValue_Public_T_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, 100677615);
			BasicAvatarSettings.NativeMethodInfoPtr_GetValue_Public_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, 100677616);
			BasicAvatarSettings.NativeMethodInfoPtr_GetAvatarSettings_Public_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, 100677617);
			BasicAvatarSettings.NativeMethodInfoPtr_GetNippleColor_Public_Static_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, 100677618);
			BasicAvatarSettings.NativeMethodInfoPtr_GetJson_Public_Virtual_New_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, 100677619);
			BasicAvatarSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, 100677620);
		}

		// Token: 0x06006DA7 RID: 28071 RVA: 0x001F60EC File Offset: 0x001F42EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222261, XrefRangeEnd = 222266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T SetValue<T>(string fieldName, T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
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
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicAvatarSettings.MethodInfoStoreGeneric_SetValue_Public_T_String_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06006DA8 RID: 28072 RVA: 0x001F6194 File Offset: 0x001F4394
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222272, RefRangeEnd = 222273, XrefRangeStart = 222266, XrefRangeEnd = 222272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetValue<T>(string fieldName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(fieldName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicAvatarSettings.MethodInfoStoreGeneric_GetValue_Public_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06006DA9 RID: 28073 RVA: 0x001F61E0 File Offset: 0x001F43E0
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 222375, RefRangeEnd = 222387, XrefRangeStart = 222273, XrefRangeEnd = 222375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarSettings GetAvatarSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicAvatarSettings.NativeMethodInfoPtr_GetAvatarSettings_Public_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr3) : null;
		}

		// Token: 0x06006DAA RID: 28074 RVA: 0x001F6220 File Offset: 0x001F4420
		[CallerCount(0)]
		public unsafe static Color GetNippleColor(Color skinColor)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref skinColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicAvatarSettings.NativeMethodInfoPtr_GetNippleColor_Public_Static_Color_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006DAB RID: 28075 RVA: 0x001F6260 File Offset: 0x001F4460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetJson(bool prettyPrint = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref prettyPrint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicAvatarSettings.NativeMethodInfoPtr_GetJson_Public_Virtual_New_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06006DAC RID: 28076 RVA: 0x001F62B0 File Offset: 0x001F44B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222387, XrefRangeEnd = 222395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BasicAvatarSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicAvatarSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DAD RID: 28077 RVA: 0x00033C5E File Offset: 0x00031E5E
		public BasicAvatarSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021B5 RID: 8629
		// (get) Token: 0x06006DAE RID: 28078 RVA: 0x001F62EC File Offset: 0x001F44EC
		// (set) Token: 0x06006DAF RID: 28079 RVA: 0x00033C67 File Offset: 0x00031E67
		public unsafe static float GenderScaleMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BasicAvatarSettings.NativeFieldInfoPtr_GenderScaleMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BasicAvatarSettings.NativeFieldInfoPtr_GenderScaleMultiplier, (void*)(&value));
			}
		}

		// Token: 0x170021B6 RID: 8630
		// (get) Token: 0x06006DB0 RID: 28080 RVA: 0x001F6308 File Offset: 0x001F4508
		// (set) Token: 0x06006DB1 RID: 28081 RVA: 0x00033C75 File Offset: 0x00031E75
		public unsafe static string MaleUnderwearPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BasicAvatarSettings.NativeFieldInfoPtr_MaleUnderwearPath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BasicAvatarSettings.NativeFieldInfoPtr_MaleUnderwearPath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170021B7 RID: 8631
		// (get) Token: 0x06006DB2 RID: 28082 RVA: 0x001F6328 File Offset: 0x001F4528
		// (set) Token: 0x06006DB3 RID: 28083 RVA: 0x00033C87 File Offset: 0x00031E87
		public unsafe static string FemaleUnderwearPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BasicAvatarSettings.NativeFieldInfoPtr_FemaleUnderwearPath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BasicAvatarSettings.NativeFieldInfoPtr_FemaleUnderwearPath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170021B8 RID: 8632
		// (get) Token: 0x06006DB4 RID: 28084 RVA: 0x001F6348 File Offset: 0x001F4548
		// (set) Token: 0x06006DB5 RID: 28085 RVA: 0x00033C99 File Offset: 0x00031E99
		public unsafe int Gender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Gender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Gender)) = value;
			}
		}

		// Token: 0x170021B9 RID: 8633
		// (get) Token: 0x06006DB6 RID: 28086 RVA: 0x001F6370 File Offset: 0x001F4570
		// (set) Token: 0x06006DB7 RID: 28087 RVA: 0x00033CB4 File Offset: 0x00031EB4
		public unsafe float Weight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Weight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Weight)) = value;
			}
		}

		// Token: 0x170021BA RID: 8634
		// (get) Token: 0x06006DB8 RID: 28088 RVA: 0x001F6398 File Offset: 0x001F4598
		// (set) Token: 0x06006DB9 RID: 28089 RVA: 0x00033CCF File Offset: 0x00031ECF
		public unsafe Color SkinColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_SkinColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_SkinColor)) = value;
			}
		}

		// Token: 0x170021BB RID: 8635
		// (get) Token: 0x06006DBA RID: 28090 RVA: 0x001F63C0 File Offset: 0x001F45C0
		// (set) Token: 0x06006DBB RID: 28091 RVA: 0x00033CEA File Offset: 0x00031EEA
		public unsafe string HairStyle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_HairStyle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_HairStyle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170021BC RID: 8636
		// (get) Token: 0x06006DBC RID: 28092 RVA: 0x001F63E8 File Offset: 0x001F45E8
		// (set) Token: 0x06006DBD RID: 28093 RVA: 0x00033D09 File Offset: 0x00031F09
		public unsafe Color HairColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_HairColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_HairColor)) = value;
			}
		}

		// Token: 0x170021BD RID: 8637
		// (get) Token: 0x06006DBE RID: 28094 RVA: 0x001F6410 File Offset: 0x001F4610
		// (set) Token: 0x06006DBF RID: 28095 RVA: 0x00033D24 File Offset: 0x00031F24
		public unsafe string Mouth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Mouth);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Mouth), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170021BE RID: 8638
		// (get) Token: 0x06006DC0 RID: 28096 RVA: 0x001F6438 File Offset: 0x001F4638
		// (set) Token: 0x06006DC1 RID: 28097 RVA: 0x00033D43 File Offset: 0x00031F43
		public unsafe string FacialHair
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_FacialHair);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_FacialHair), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170021BF RID: 8639
		// (get) Token: 0x06006DC2 RID: 28098 RVA: 0x001F6460 File Offset: 0x001F4660
		// (set) Token: 0x06006DC3 RID: 28099 RVA: 0x00033D62 File Offset: 0x00031F62
		public unsafe string FacialDetails
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_FacialDetails);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_FacialDetails), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170021C0 RID: 8640
		// (get) Token: 0x06006DC4 RID: 28100 RVA: 0x001F6488 File Offset: 0x001F4688
		// (set) Token: 0x06006DC5 RID: 28101 RVA: 0x00033D81 File Offset: 0x00031F81
		public unsafe float FacialDetailsIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_FacialDetailsIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_FacialDetailsIntensity)) = value;
			}
		}

		// Token: 0x170021C1 RID: 8641
		// (get) Token: 0x06006DC6 RID: 28102 RVA: 0x001F64B0 File Offset: 0x001F46B0
		// (set) Token: 0x06006DC7 RID: 28103 RVA: 0x00033D9C File Offset: 0x00031F9C
		public unsafe Color EyeballColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyeballColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyeballColor)) = value;
			}
		}

		// Token: 0x170021C2 RID: 8642
		// (get) Token: 0x06006DC8 RID: 28104 RVA: 0x001F64D8 File Offset: 0x001F46D8
		// (set) Token: 0x06006DC9 RID: 28105 RVA: 0x00033DB7 File Offset: 0x00031FB7
		public unsafe float UpperEyeLidRestingPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_UpperEyeLidRestingPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_UpperEyeLidRestingPosition)) = value;
			}
		}

		// Token: 0x170021C3 RID: 8643
		// (get) Token: 0x06006DCA RID: 28106 RVA: 0x001F6500 File Offset: 0x001F4700
		// (set) Token: 0x06006DCB RID: 28107 RVA: 0x00033DD2 File Offset: 0x00031FD2
		public unsafe float LowerEyeLidRestingPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_LowerEyeLidRestingPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_LowerEyeLidRestingPosition)) = value;
			}
		}

		// Token: 0x170021C4 RID: 8644
		// (get) Token: 0x06006DCC RID: 28108 RVA: 0x001F6528 File Offset: 0x001F4728
		// (set) Token: 0x06006DCD RID: 28109 RVA: 0x00033DED File Offset: 0x00031FED
		public unsafe float PupilDilation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_PupilDilation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_PupilDilation)) = value;
			}
		}

		// Token: 0x170021C5 RID: 8645
		// (get) Token: 0x06006DCE RID: 28110 RVA: 0x001F6550 File Offset: 0x001F4750
		// (set) Token: 0x06006DCF RID: 28111 RVA: 0x00033E08 File Offset: 0x00032008
		public unsafe float EyebrowScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyebrowScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyebrowScale)) = value;
			}
		}

		// Token: 0x170021C6 RID: 8646
		// (get) Token: 0x06006DD0 RID: 28112 RVA: 0x001F6578 File Offset: 0x001F4778
		// (set) Token: 0x06006DD1 RID: 28113 RVA: 0x00033E23 File Offset: 0x00032023
		public unsafe float EyebrowThickness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyebrowThickness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyebrowThickness)) = value;
			}
		}

		// Token: 0x170021C7 RID: 8647
		// (get) Token: 0x06006DD2 RID: 28114 RVA: 0x001F65A0 File Offset: 0x001F47A0
		// (set) Token: 0x06006DD3 RID: 28115 RVA: 0x00033E3E File Offset: 0x0003203E
		public unsafe float EyebrowRestingHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyebrowRestingHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyebrowRestingHeight)) = value;
			}
		}

		// Token: 0x170021C8 RID: 8648
		// (get) Token: 0x06006DD4 RID: 28116 RVA: 0x001F65C8 File Offset: 0x001F47C8
		// (set) Token: 0x06006DD5 RID: 28117 RVA: 0x00033E59 File Offset: 0x00032059
		public unsafe float EyebrowRestingAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyebrowRestingAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyebrowRestingAngle)) = value;
			}
		}

		// Token: 0x170021C9 RID: 8649
		// (get) Token: 0x06006DD6 RID: 28118 RVA: 0x001F65F0 File Offset: 0x001F47F0
		// (set) Token: 0x06006DD7 RID: 28119 RVA: 0x00033E74 File Offset: 0x00032074
		public unsafe string Top
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Top);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Top), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170021CA RID: 8650
		// (get) Token: 0x06006DD8 RID: 28120 RVA: 0x001F6618 File Offset: 0x001F4818
		// (set) Token: 0x06006DD9 RID: 28121 RVA: 0x00033E93 File Offset: 0x00032093
		public unsafe Color TopColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_TopColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_TopColor)) = value;
			}
		}

		// Token: 0x170021CB RID: 8651
		// (get) Token: 0x06006DDA RID: 28122 RVA: 0x001F6640 File Offset: 0x001F4840
		// (set) Token: 0x06006DDB RID: 28123 RVA: 0x00033EAE File Offset: 0x000320AE
		public unsafe string Bottom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Bottom);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Bottom), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170021CC RID: 8652
		// (get) Token: 0x06006DDC RID: 28124 RVA: 0x001F6668 File Offset: 0x001F4868
		// (set) Token: 0x06006DDD RID: 28125 RVA: 0x00033ECD File Offset: 0x000320CD
		public unsafe Color BottomColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_BottomColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_BottomColor)) = value;
			}
		}

		// Token: 0x170021CD RID: 8653
		// (get) Token: 0x06006DDE RID: 28126 RVA: 0x001F6690 File Offset: 0x001F4890
		// (set) Token: 0x06006DDF RID: 28127 RVA: 0x00033EE8 File Offset: 0x000320E8
		public unsafe string Shoes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Shoes);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Shoes), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170021CE RID: 8654
		// (get) Token: 0x06006DE0 RID: 28128 RVA: 0x001F66B8 File Offset: 0x001F48B8
		// (set) Token: 0x06006DE1 RID: 28129 RVA: 0x00033F07 File Offset: 0x00032107
		public unsafe Color ShoesColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_ShoesColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_ShoesColor)) = value;
			}
		}

		// Token: 0x170021CF RID: 8655
		// (get) Token: 0x06006DE2 RID: 28130 RVA: 0x001F66E0 File Offset: 0x001F48E0
		// (set) Token: 0x06006DE3 RID: 28131 RVA: 0x00033F22 File Offset: 0x00032122
		public unsafe string Headwear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Headwear);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Headwear), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170021D0 RID: 8656
		// (get) Token: 0x06006DE4 RID: 28132 RVA: 0x001F6708 File Offset: 0x001F4908
		// (set) Token: 0x06006DE5 RID: 28133 RVA: 0x00033F41 File Offset: 0x00032141
		public unsafe Color HeadwearColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_HeadwearColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_HeadwearColor)) = value;
			}
		}

		// Token: 0x170021D1 RID: 8657
		// (get) Token: 0x06006DE6 RID: 28134 RVA: 0x001F6730 File Offset: 0x001F4930
		// (set) Token: 0x06006DE7 RID: 28135 RVA: 0x00033F5C File Offset: 0x0003215C
		public unsafe string Eyewear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Eyewear);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Eyewear), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170021D2 RID: 8658
		// (get) Token: 0x06006DE8 RID: 28136 RVA: 0x001F6758 File Offset: 0x001F4958
		// (set) Token: 0x06006DE9 RID: 28137 RVA: 0x00033F7B File Offset: 0x0003217B
		public unsafe Color EyewearColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyewearColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyewearColor)) = value;
			}
		}

		// Token: 0x170021D3 RID: 8659
		// (get) Token: 0x06006DEA RID: 28138 RVA: 0x001F6780 File Offset: 0x001F4980
		// (set) Token: 0x06006DEB RID: 28139 RVA: 0x00033F96 File Offset: 0x00032196
		public unsafe List<string> Tattoos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Tattoos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Tattoos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004B46 RID: 19270
		private static readonly IntPtr NativeFieldInfoPtr_GenderScaleMultiplier;

		// Token: 0x04004B47 RID: 19271
		private static readonly IntPtr NativeFieldInfoPtr_MaleUnderwearPath;

		// Token: 0x04004B48 RID: 19272
		private static readonly IntPtr NativeFieldInfoPtr_FemaleUnderwearPath;

		// Token: 0x04004B49 RID: 19273
		private static readonly IntPtr NativeFieldInfoPtr_Gender;

		// Token: 0x04004B4A RID: 19274
		private static readonly IntPtr NativeFieldInfoPtr_Weight;

		// Token: 0x04004B4B RID: 19275
		private static readonly IntPtr NativeFieldInfoPtr_SkinColor;

		// Token: 0x04004B4C RID: 19276
		private static readonly IntPtr NativeFieldInfoPtr_HairStyle;

		// Token: 0x04004B4D RID: 19277
		private static readonly IntPtr NativeFieldInfoPtr_HairColor;

		// Token: 0x04004B4E RID: 19278
		private static readonly IntPtr NativeFieldInfoPtr_Mouth;

		// Token: 0x04004B4F RID: 19279
		private static readonly IntPtr NativeFieldInfoPtr_FacialHair;

		// Token: 0x04004B50 RID: 19280
		private static readonly IntPtr NativeFieldInfoPtr_FacialDetails;

		// Token: 0x04004B51 RID: 19281
		private static readonly IntPtr NativeFieldInfoPtr_FacialDetailsIntensity;

		// Token: 0x04004B52 RID: 19282
		private static readonly IntPtr NativeFieldInfoPtr_EyeballColor;

		// Token: 0x04004B53 RID: 19283
		private static readonly IntPtr NativeFieldInfoPtr_UpperEyeLidRestingPosition;

		// Token: 0x04004B54 RID: 19284
		private static readonly IntPtr NativeFieldInfoPtr_LowerEyeLidRestingPosition;

		// Token: 0x04004B55 RID: 19285
		private static readonly IntPtr NativeFieldInfoPtr_PupilDilation;

		// Token: 0x04004B56 RID: 19286
		private static readonly IntPtr NativeFieldInfoPtr_EyebrowScale;

		// Token: 0x04004B57 RID: 19287
		private static readonly IntPtr NativeFieldInfoPtr_EyebrowThickness;

		// Token: 0x04004B58 RID: 19288
		private static readonly IntPtr NativeFieldInfoPtr_EyebrowRestingHeight;

		// Token: 0x04004B59 RID: 19289
		private static readonly IntPtr NativeFieldInfoPtr_EyebrowRestingAngle;

		// Token: 0x04004B5A RID: 19290
		private static readonly IntPtr NativeFieldInfoPtr_Top;

		// Token: 0x04004B5B RID: 19291
		private static readonly IntPtr NativeFieldInfoPtr_TopColor;

		// Token: 0x04004B5C RID: 19292
		private static readonly IntPtr NativeFieldInfoPtr_Bottom;

		// Token: 0x04004B5D RID: 19293
		private static readonly IntPtr NativeFieldInfoPtr_BottomColor;

		// Token: 0x04004B5E RID: 19294
		private static readonly IntPtr NativeFieldInfoPtr_Shoes;

		// Token: 0x04004B5F RID: 19295
		private static readonly IntPtr NativeFieldInfoPtr_ShoesColor;

		// Token: 0x04004B60 RID: 19296
		private static readonly IntPtr NativeFieldInfoPtr_Headwear;

		// Token: 0x04004B61 RID: 19297
		private static readonly IntPtr NativeFieldInfoPtr_HeadwearColor;

		// Token: 0x04004B62 RID: 19298
		private static readonly IntPtr NativeFieldInfoPtr_Eyewear;

		// Token: 0x04004B63 RID: 19299
		private static readonly IntPtr NativeFieldInfoPtr_EyewearColor;

		// Token: 0x04004B64 RID: 19300
		private static readonly IntPtr NativeFieldInfoPtr_Tattoos;

		// Token: 0x04004B65 RID: 19301
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_T_String_T_0;

		// Token: 0x04004B66 RID: 19302
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_T_String_0;

		// Token: 0x04004B67 RID: 19303
		private static readonly IntPtr NativeMethodInfoPtr_GetAvatarSettings_Public_AvatarSettings_0;

		// Token: 0x04004B68 RID: 19304
		private static readonly IntPtr NativeMethodInfoPtr_GetNippleColor_Public_Static_Color_Color_0;

		// Token: 0x04004B69 RID: 19305
		private static readonly IntPtr NativeMethodInfoPtr_GetJson_Public_Virtual_New_String_Boolean_0;

		// Token: 0x04004B6A RID: 19306
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B74 RID: 2932
		private sealed class MethodInfoStoreGeneric_SetValue_Public_T_String_T_0<T>
		{
			// Token: 0x04009DE0 RID: 40416
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BasicAvatarSettings.NativeMethodInfoPtr_SetValue_Public_T_String_T_0, Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000B75 RID: 2933
		private sealed class MethodInfoStoreGeneric_GetValue_Public_T_String_0<T>
		{
			// Token: 0x04009DE1 RID: 40417
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BasicAvatarSettings.NativeMethodInfoPtr_GetValue_Public_T_String_0, Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
