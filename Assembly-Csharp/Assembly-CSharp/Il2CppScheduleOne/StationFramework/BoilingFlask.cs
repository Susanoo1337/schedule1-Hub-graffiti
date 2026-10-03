using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x02000536 RID: 1334
	public class BoilingFlask : Fillable
	{
		// Token: 0x06007941 RID: 31041 RVA: 0x0021A428 File Offset: 0x00218628
		// Note: this type is marked as 'beforefieldinit'.
		static BoilingFlask()
		{
			Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "BoilingFlask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr);
			BoilingFlask.NativeFieldInfoPtr_TEMPERATURE_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "TEMPERATURE_MAX");
			BoilingFlask.NativeFieldInfoPtr_TEMPERATURE_MAX_VELOCITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "TEMPERATURE_MAX_VELOCITY");
			BoilingFlask.NativeFieldInfoPtr_TEMPERATURE_ACCELERATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "TEMPERATURE_ACCELERATION");
			BoilingFlask.NativeFieldInfoPtr_OVERHEAT_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "OVERHEAT_TIME");
			BoilingFlask.NativeFieldInfoPtr__CurrentTemperature_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "<CurrentTemperature>k__BackingField");
			BoilingFlask.NativeFieldInfoPtr__CurrentTemperatureVelocity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "<CurrentTemperatureVelocity>k__BackingField");
			BoilingFlask.NativeFieldInfoPtr__OverheatScale_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "<OverheatScale>k__BackingField");
			BoilingFlask.NativeFieldInfoPtr__Recipe_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "<Recipe>k__BackingField");
			BoilingFlask.NativeFieldInfoPtr_LockTemperature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "LockTemperature");
			BoilingFlask.NativeFieldInfoPtr_BoilSoundPitchCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "BoilSoundPitchCurve");
			BoilingFlask.NativeFieldInfoPtr_LabelJitterScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "LabelJitterScale");
			BoilingFlask.NativeFieldInfoPtr_Burner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "Burner");
			BoilingFlask.NativeFieldInfoPtr_TemperatureCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "TemperatureCanvas");
			BoilingFlask.NativeFieldInfoPtr_TemperatureLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "TemperatureLabel");
			BoilingFlask.NativeFieldInfoPtr_TemperatureSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "TemperatureSlider");
			BoilingFlask.NativeFieldInfoPtr_TemperatureRangeIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "TemperatureRangeIndicator");
			BoilingFlask.NativeFieldInfoPtr_SmokeParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "SmokeParticles");
			BoilingFlask.NativeFieldInfoPtr_BoilSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "BoilSound");
			BoilingFlask.NativeFieldInfoPtr_OverheatMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "OverheatMesh");
			BoilingFlask.NativeMethodInfoPtr_get_CurrentTemperature_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678889);
			BoilingFlask.NativeMethodInfoPtr_set_CurrentTemperature_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678890);
			BoilingFlask.NativeMethodInfoPtr_get_CurrentTemperatureVelocity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678891);
			BoilingFlask.NativeMethodInfoPtr_set_CurrentTemperatureVelocity_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678892);
			BoilingFlask.NativeMethodInfoPtr_get_IsTemperatureInRange_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678893);
			BoilingFlask.NativeMethodInfoPtr_get_OverheatScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678894);
			BoilingFlask.NativeMethodInfoPtr_set_OverheatScale_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678895);
			BoilingFlask.NativeMethodInfoPtr_get_Recipe_Public_get_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678896);
			BoilingFlask.NativeMethodInfoPtr_set_Recipe_Private_set_Void_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678897);
			BoilingFlask.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678898);
			BoilingFlask.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678899);
			BoilingFlask.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678900);
			BoilingFlask.NativeMethodInfoPtr_UpdateCanvas_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678901);
			BoilingFlask.NativeMethodInfoPtr_UpdateSmoke_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678902);
			BoilingFlask.NativeMethodInfoPtr_SetCanvasVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678903);
			BoilingFlask.NativeMethodInfoPtr_SetTemperature_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678904);
			BoilingFlask.NativeMethodInfoPtr_SetRecipe_Public_Void_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678905);
			BoilingFlask.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678906);
		}

		// Token: 0x17002586 RID: 9606
		// (get) Token: 0x06007942 RID: 31042 RVA: 0x0021A73C File Offset: 0x0021893C
		// (set) Token: 0x06007943 RID: 31043 RVA: 0x0021A778 File Offset: 0x00218978
		public unsafe float CurrentTemperature
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29133, RefRangeEnd = 29134, XrefRangeStart = 29133, XrefRangeEnd = 29134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_get_CurrentTemperature_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 29134, RefRangeEnd = 29137, XrefRangeStart = 29134, XrefRangeEnd = 29137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_set_CurrentTemperature_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002587 RID: 9607
		// (get) Token: 0x06007944 RID: 31044 RVA: 0x0021A7B8 File Offset: 0x002189B8
		// (set) Token: 0x06007945 RID: 31045 RVA: 0x0021A7F4 File Offset: 0x002189F4
		public unsafe float CurrentTemperatureVelocity
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29137, RefRangeEnd = 29138, XrefRangeStart = 29137, XrefRangeEnd = 29138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_get_CurrentTemperatureVelocity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_set_CurrentTemperatureVelocity_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002588 RID: 9608
		// (get) Token: 0x06007946 RID: 31046 RVA: 0x0021A834 File Offset: 0x00218A34
		public unsafe bool IsTemperatureInRange
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 233649, RefRangeEnd = 233650, XrefRangeStart = 233645, XrefRangeEnd = 233649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_get_IsTemperatureInRange_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002589 RID: 9609
		// (get) Token: 0x06007947 RID: 31047 RVA: 0x0021A870 File Offset: 0x00218A70
		// (set) Token: 0x06007948 RID: 31048 RVA: 0x0021A8AC File Offset: 0x00218AAC
		public unsafe float OverheatScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_get_OverheatScale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_set_OverheatScale_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700258A RID: 9610
		// (get) Token: 0x06007949 RID: 31049 RVA: 0x0021A8EC File Offset: 0x00218AEC
		// (set) Token: 0x0600794A RID: 31050 RVA: 0x0021A92C File Offset: 0x00218B2C
		public unsafe StationRecipe Recipe
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 32794, RefRangeEnd = 32795, XrefRangeStart = 32794, XrefRangeEnd = 32795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_get_Recipe_Public_get_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_set_Recipe_Private_set_Void_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600794B RID: 31051 RVA: 0x0021A970 File Offset: 0x00218B70
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600794C RID: 31052 RVA: 0x0021A9A4 File Offset: 0x00218BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233650, XrefRangeEnd = 233679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600794D RID: 31053 RVA: 0x0021A9D8 File Offset: 0x00218BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233679, XrefRangeEnd = 233688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600794E RID: 31054 RVA: 0x0021AA0C File Offset: 0x00218C0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 233703, RefRangeEnd = 233704, XrefRangeStart = 233688, XrefRangeEnd = 233703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCanvas()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_UpdateCanvas_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600794F RID: 31055 RVA: 0x0021AA40 File Offset: 0x00218C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233704, XrefRangeEnd = 233712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSmoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_UpdateSmoke_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007950 RID: 31056 RVA: 0x0021AA74 File Offset: 0x00218C74
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 233715, RefRangeEnd = 233718, XrefRangeStart = 233712, XrefRangeEnd = 233715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCanvasVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_SetCanvasVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007951 RID: 31057 RVA: 0x0021AAB4 File Offset: 0x00218CB4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 29134, RefRangeEnd = 29137, XrefRangeStart = 29134, XrefRangeEnd = 29137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTemperature(float temp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref temp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_SetTemperature_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007952 RID: 31058 RVA: 0x0021AAF4 File Offset: 0x00218CF4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 233729, RefRangeEnd = 233732, XrefRangeStart = 233718, XrefRangeEnd = 233729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRecipe(StationRecipe recipe)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_SetRecipe_Public_Void_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007953 RID: 31059 RVA: 0x0021AB38 File Offset: 0x00218D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233732, XrefRangeEnd = 233740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoilingFlask() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007954 RID: 31060 RVA: 0x00039B63 File Offset: 0x00037D63
		public BoilingFlask(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002573 RID: 9587
		// (get) Token: 0x06007955 RID: 31061 RVA: 0x0021AB74 File Offset: 0x00218D74
		// (set) Token: 0x06007956 RID: 31062 RVA: 0x00039B6C File Offset: 0x00037D6C
		public unsafe static float TEMPERATURE_MAX
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BoilingFlask.NativeFieldInfoPtr_TEMPERATURE_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoilingFlask.NativeFieldInfoPtr_TEMPERATURE_MAX, (void*)(&value));
			}
		}

		// Token: 0x17002574 RID: 9588
		// (get) Token: 0x06007957 RID: 31063 RVA: 0x0021AB90 File Offset: 0x00218D90
		// (set) Token: 0x06007958 RID: 31064 RVA: 0x00039B7A File Offset: 0x00037D7A
		public unsafe float TEMPERATURE_MAX_VELOCITY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TEMPERATURE_MAX_VELOCITY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TEMPERATURE_MAX_VELOCITY)) = value;
			}
		}

		// Token: 0x17002575 RID: 9589
		// (get) Token: 0x06007959 RID: 31065 RVA: 0x0021ABB8 File Offset: 0x00218DB8
		// (set) Token: 0x0600795A RID: 31066 RVA: 0x00039B95 File Offset: 0x00037D95
		public unsafe float TEMPERATURE_ACCELERATION
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TEMPERATURE_ACCELERATION);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TEMPERATURE_ACCELERATION)) = value;
			}
		}

		// Token: 0x17002576 RID: 9590
		// (get) Token: 0x0600795B RID: 31067 RVA: 0x0021ABE0 File Offset: 0x00218DE0
		// (set) Token: 0x0600795C RID: 31068 RVA: 0x00039BB0 File Offset: 0x00037DB0
		public unsafe static float OVERHEAT_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BoilingFlask.NativeFieldInfoPtr_OVERHEAT_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoilingFlask.NativeFieldInfoPtr_OVERHEAT_TIME, (void*)(&value));
			}
		}

		// Token: 0x17002577 RID: 9591
		// (get) Token: 0x0600795D RID: 31069 RVA: 0x0021ABFC File Offset: 0x00218DFC
		// (set) Token: 0x0600795E RID: 31070 RVA: 0x00039BBE File Offset: 0x00037DBE
		public unsafe float _CurrentTemperature_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr__CurrentTemperature_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr__CurrentTemperature_k__BackingField)) = value;
			}
		}

		// Token: 0x17002578 RID: 9592
		// (get) Token: 0x0600795F RID: 31071 RVA: 0x0021AC24 File Offset: 0x00218E24
		// (set) Token: 0x06007960 RID: 31072 RVA: 0x00039BD9 File Offset: 0x00037DD9
		public unsafe float _CurrentTemperatureVelocity_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr__CurrentTemperatureVelocity_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr__CurrentTemperatureVelocity_k__BackingField)) = value;
			}
		}

		// Token: 0x17002579 RID: 9593
		// (get) Token: 0x06007961 RID: 31073 RVA: 0x0021AC4C File Offset: 0x00218E4C
		// (set) Token: 0x06007962 RID: 31074 RVA: 0x00039BF4 File Offset: 0x00037DF4
		public unsafe float _OverheatScale_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr__OverheatScale_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr__OverheatScale_k__BackingField)) = value;
			}
		}

		// Token: 0x1700257A RID: 9594
		// (get) Token: 0x06007963 RID: 31075 RVA: 0x0021AC74 File Offset: 0x00218E74
		// (set) Token: 0x06007964 RID: 31076 RVA: 0x00039C0F File Offset: 0x00037E0F
		public unsafe StationRecipe _Recipe_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr__Recipe_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr__Recipe_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700257B RID: 9595
		// (get) Token: 0x06007965 RID: 31077 RVA: 0x0021ACA4 File Offset: 0x00218EA4
		// (set) Token: 0x06007966 RID: 31078 RVA: 0x00039C2E File Offset: 0x00037E2E
		public unsafe bool LockTemperature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_LockTemperature);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_LockTemperature)) = value;
			}
		}

		// Token: 0x1700257C RID: 9596
		// (get) Token: 0x06007967 RID: 31079 RVA: 0x0021ACCC File Offset: 0x00218ECC
		// (set) Token: 0x06007968 RID: 31080 RVA: 0x00039C49 File Offset: 0x00037E49
		public unsafe AnimationCurve BoilSoundPitchCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_BoilSoundPitchCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_BoilSoundPitchCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700257D RID: 9597
		// (get) Token: 0x06007969 RID: 31081 RVA: 0x0021ACFC File Offset: 0x00218EFC
		// (set) Token: 0x0600796A RID: 31082 RVA: 0x00039C68 File Offset: 0x00037E68
		public unsafe float LabelJitterScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_LabelJitterScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_LabelJitterScale)) = value;
			}
		}

		// Token: 0x1700257E RID: 9598
		// (get) Token: 0x0600796B RID: 31083 RVA: 0x0021AD24 File Offset: 0x00218F24
		// (set) Token: 0x0600796C RID: 31084 RVA: 0x00039C83 File Offset: 0x00037E83
		public unsafe BunsenBurner Burner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_Burner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BunsenBurner>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_Burner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700257F RID: 9599
		// (get) Token: 0x0600796D RID: 31085 RVA: 0x0021AD54 File Offset: 0x00218F54
		// (set) Token: 0x0600796E RID: 31086 RVA: 0x00039CA2 File Offset: 0x00037EA2
		public unsafe Canvas TemperatureCanvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TemperatureCanvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TemperatureCanvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002580 RID: 9600
		// (get) Token: 0x0600796F RID: 31087 RVA: 0x0021AD84 File Offset: 0x00218F84
		// (set) Token: 0x06007970 RID: 31088 RVA: 0x00039CC1 File Offset: 0x00037EC1
		public unsafe TextMeshProUGUI TemperatureLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TemperatureLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TemperatureLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002581 RID: 9601
		// (get) Token: 0x06007971 RID: 31089 RVA: 0x0021ADB4 File Offset: 0x00218FB4
		// (set) Token: 0x06007972 RID: 31090 RVA: 0x00039CE0 File Offset: 0x00037EE0
		public unsafe Slider TemperatureSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TemperatureSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TemperatureSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002582 RID: 9602
		// (get) Token: 0x06007973 RID: 31091 RVA: 0x0021ADE4 File Offset: 0x00218FE4
		// (set) Token: 0x06007974 RID: 31092 RVA: 0x00039CFF File Offset: 0x00037EFF
		public unsafe RectTransform TemperatureRangeIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TemperatureRangeIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TemperatureRangeIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002583 RID: 9603
		// (get) Token: 0x06007975 RID: 31093 RVA: 0x0021AE14 File Offset: 0x00219014
		// (set) Token: 0x06007976 RID: 31094 RVA: 0x00039D1E File Offset: 0x00037F1E
		public unsafe ParticleSystem SmokeParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_SmokeParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_SmokeParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002584 RID: 9604
		// (get) Token: 0x06007977 RID: 31095 RVA: 0x0021AE44 File Offset: 0x00219044
		// (set) Token: 0x06007978 RID: 31096 RVA: 0x00039D3D File Offset: 0x00037F3D
		public unsafe AudioSourceController BoilSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_BoilSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_BoilSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002585 RID: 9605
		// (get) Token: 0x06007979 RID: 31097 RVA: 0x0021AE74 File Offset: 0x00219074
		// (set) Token: 0x0600797A RID: 31098 RVA: 0x00039D5C File Offset: 0x00037F5C
		public unsafe MeshRenderer OverheatMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_OverheatMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_OverheatMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040052A5 RID: 21157
		private static readonly IntPtr NativeFieldInfoPtr_TEMPERATURE_MAX;

		// Token: 0x040052A6 RID: 21158
		private static readonly IntPtr NativeFieldInfoPtr_TEMPERATURE_MAX_VELOCITY;

		// Token: 0x040052A7 RID: 21159
		private static readonly IntPtr NativeFieldInfoPtr_TEMPERATURE_ACCELERATION;

		// Token: 0x040052A8 RID: 21160
		private static readonly IntPtr NativeFieldInfoPtr_OVERHEAT_TIME;

		// Token: 0x040052A9 RID: 21161
		private static readonly IntPtr NativeFieldInfoPtr__CurrentTemperature_k__BackingField;

		// Token: 0x040052AA RID: 21162
		private static readonly IntPtr NativeFieldInfoPtr__CurrentTemperatureVelocity_k__BackingField;

		// Token: 0x040052AB RID: 21163
		private static readonly IntPtr NativeFieldInfoPtr__OverheatScale_k__BackingField;

		// Token: 0x040052AC RID: 21164
		private static readonly IntPtr NativeFieldInfoPtr__Recipe_k__BackingField;

		// Token: 0x040052AD RID: 21165
		private static readonly IntPtr NativeFieldInfoPtr_LockTemperature;

		// Token: 0x040052AE RID: 21166
		private static readonly IntPtr NativeFieldInfoPtr_BoilSoundPitchCurve;

		// Token: 0x040052AF RID: 21167
		private static readonly IntPtr NativeFieldInfoPtr_LabelJitterScale;

		// Token: 0x040052B0 RID: 21168
		private static readonly IntPtr NativeFieldInfoPtr_Burner;

		// Token: 0x040052B1 RID: 21169
		private static readonly IntPtr NativeFieldInfoPtr_TemperatureCanvas;

		// Token: 0x040052B2 RID: 21170
		private static readonly IntPtr NativeFieldInfoPtr_TemperatureLabel;

		// Token: 0x040052B3 RID: 21171
		private static readonly IntPtr NativeFieldInfoPtr_TemperatureSlider;

		// Token: 0x040052B4 RID: 21172
		private static readonly IntPtr NativeFieldInfoPtr_TemperatureRangeIndicator;

		// Token: 0x040052B5 RID: 21173
		private static readonly IntPtr NativeFieldInfoPtr_SmokeParticles;

		// Token: 0x040052B6 RID: 21174
		private static readonly IntPtr NativeFieldInfoPtr_BoilSound;

		// Token: 0x040052B7 RID: 21175
		private static readonly IntPtr NativeFieldInfoPtr_OverheatMesh;

		// Token: 0x040052B8 RID: 21176
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentTemperature_Public_get_Single_0;

		// Token: 0x040052B9 RID: 21177
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentTemperature_Private_set_Void_Single_0;

		// Token: 0x040052BA RID: 21178
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentTemperatureVelocity_Public_get_Single_0;

		// Token: 0x040052BB RID: 21179
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentTemperatureVelocity_Private_set_Void_Single_0;

		// Token: 0x040052BC RID: 21180
		private static readonly IntPtr NativeMethodInfoPtr_get_IsTemperatureInRange_Public_get_Boolean_0;

		// Token: 0x040052BD RID: 21181
		private static readonly IntPtr NativeMethodInfoPtr_get_OverheatScale_Public_get_Single_0;

		// Token: 0x040052BE RID: 21182
		private static readonly IntPtr NativeMethodInfoPtr_set_OverheatScale_Private_set_Void_Single_0;

		// Token: 0x040052BF RID: 21183
		private static readonly IntPtr NativeMethodInfoPtr_get_Recipe_Public_get_StationRecipe_0;

		// Token: 0x040052C0 RID: 21184
		private static readonly IntPtr NativeMethodInfoPtr_set_Recipe_Private_set_Void_StationRecipe_0;

		// Token: 0x040052C1 RID: 21185
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040052C2 RID: 21186
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x040052C3 RID: 21187
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040052C4 RID: 21188
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCanvas_Private_Void_0;

		// Token: 0x040052C5 RID: 21189
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSmoke_Private_Void_0;

		// Token: 0x040052C6 RID: 21190
		private static readonly IntPtr NativeMethodInfoPtr_SetCanvasVisible_Public_Void_Boolean_0;

		// Token: 0x040052C7 RID: 21191
		private static readonly IntPtr NativeMethodInfoPtr_SetTemperature_Public_Void_Single_0;

		// Token: 0x040052C8 RID: 21192
		private static readonly IntPtr NativeMethodInfoPtr_SetRecipe_Public_Void_StationRecipe_0;

		// Token: 0x040052C9 RID: 21193
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
