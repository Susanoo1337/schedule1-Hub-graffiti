using System;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Core.Weather;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Weather
{
	// Token: 0x020006E0 RID: 1760
	public class WeatherVolume : NetworkBehaviour
	{
		// Token: 0x0600A9BA RID: 43450 RVA: 0x002CDBAC File Offset: 0x002CBDAC
		// Note: this type is marked as 'beforefieldinit'.
		static WeatherVolume()
		{
			Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Weather", "WeatherVolume");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr);
			WeatherVolume.NativeFieldInfoPtr__rainController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, "_rainController");
			WeatherVolume.NativeFieldInfoPtr__cloudController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, "_cloudController");
			WeatherVolume.NativeFieldInfoPtr__thunderController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, "_thunderController");
			WeatherVolume.NativeFieldInfoPtr__showGizmos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, "_showGizmos");
			WeatherVolume.NativeFieldInfoPtr__weatherBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, "_weatherBounds");
			WeatherVolume.NativeFieldInfoPtr__volumeSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, "_volumeSize");
			WeatherVolume.NativeFieldInfoPtr__blendSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, "_blendSize");
			WeatherVolume.NativeFieldInfoPtr__anchorPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, "_anchorPosition");
			WeatherVolume.NativeFieldInfoPtr__blendAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, "_blendAmount");
			WeatherVolume.NativeFieldInfoPtr__isInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, "_isInitialized");
			WeatherVolume.NativeFieldInfoPtr__velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, "_velocity");
			WeatherVolume.NativeFieldInfoPtr__weatherProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, "_weatherProfile");
			WeatherVolume.NativeFieldInfoPtr__effectControllers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, "_effectControllers");
			WeatherVolume.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Weather.WeatherVolumeAssembly-CSharp.dll_Excuted");
			WeatherVolume.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Weather.WeatherVolumeAssembly-CSharp.dll_Excuted");
			WeatherVolume.NativeMethodInfoPtr_get_BlendAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, 100685820);
			WeatherVolume.NativeMethodInfoPtr_get_WeatherBounds_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, 100685821);
			WeatherVolume.NativeMethodInfoPtr_get_BlendSize_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, 100685822);
			WeatherVolume.NativeMethodInfoPtr_get_VolumeSize_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, 100685823);
			WeatherVolume.NativeMethodInfoPtr_get_Center_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, 100685824);
			WeatherVolume.NativeMethodInfoPtr_get_MinBounds_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, 100685825);
			WeatherVolume.NativeMethodInfoPtr_get_MaxBounds_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, 100685826);
			WeatherVolume.NativeMethodInfoPtr_get_EffectControllers_Public_get_List_1_WeatherEffectController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, 100685827);
			WeatherVolume.NativeMethodInfoPtr_get_WeatherProfile_Public_get_WeatherProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, 100685828);
			WeatherVolume.NativeMethodInfoPtr_get_TopRightBlendCorner_Protected_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, 100685829);
			WeatherVolume.NativeMethodInfoPtr_get_BottomRightBlendCorner_Protected_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, 100685830);
			WeatherVolume.NativeMethodInfoPtr_get_TopLeftBlendCorner_Protected_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, 100685831);
			WeatherVolume.NativeMethodInfoPtr_get_BottomLeftBlendCorner_Protected_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, 100685832);
			WeatherVolume.NativeMethodInfoPtr_Initialise_Public_Void_WeatherProfile_Vector3_Vector3_Vector3_Single_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, 100685833);
			WeatherVolume.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, 100685834);
			WeatherVolume.NativeMethodInfoPtr_SetAnchor_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, 100685835);
			WeatherVolume.NativeMethodInfoPtr_SetNeighbourVolume_Public_Void_WeatherVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, 100685836);
			WeatherVolume.NativeMethodInfoPtr_BlendEffects_Public_Void_Single_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, 100685837);
			WeatherVolume.NativeMethodInfoPtr_SetShaderNumericParameter_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, 100685838);
			WeatherVolume.NativeMethodInfoPtr_SetShaderColorParameter_Public_Void_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, 100685839);
			WeatherVolume.NativeMethodInfoPtr_SetVisualEffectNumericParameter_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, 100685840);
			WeatherVolume.NativeMethodInfoPtr_UpdateVolume_Public_Void_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, 100685841);
			WeatherVolume.NativeMethodInfoPtr_IsInRightHalf_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, 100685842);
			WeatherVolume.NativeMethodInfoPtr_GetClosestPointOnLeft_Public_Vector2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, 100685843);
			WeatherVolume.NativeMethodInfoPtr_GetClosestPointOnRight_Public_Vector2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, 100685844);
			WeatherVolume.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, 100685845);
			WeatherVolume.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, 100685846);
			WeatherVolume.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, 100685847);
			WeatherVolume.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, 100685848);
			WeatherVolume.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, 100685849);
			WeatherVolume.NativeMethodInfoPtr_RpcWriter___Observers_Initialise_495303214_Private_Void_WeatherProfile_Vector3_Vector3_Vector3_Single_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, 100685850);
			WeatherVolume.NativeMethodInfoPtr_RpcLogic___Initialise_495303214_Public_Void_WeatherProfile_Vector3_Vector3_Vector3_Single_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, 100685851);
			WeatherVolume.NativeMethodInfoPtr_RpcReader___Observers_Initialise_495303214_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, 100685852);
			WeatherVolume.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, 100685853);
		}

		// Token: 0x170032C0 RID: 12992
		// (get) Token: 0x0600A9BB RID: 43451 RVA: 0x002CDFB0 File Offset: 0x002CC1B0
		public unsafe float BlendAmount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherVolume.NativeMethodInfoPtr_get_BlendAmount_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170032C1 RID: 12993
		// (get) Token: 0x0600A9BC RID: 43452 RVA: 0x002CDFEC File Offset: 0x002CC1EC
		public unsafe Vector3 WeatherBounds
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 161183, RefRangeEnd = 161192, XrefRangeStart = 161183, XrefRangeEnd = 161192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherVolume.NativeMethodInfoPtr_get_WeatherBounds_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170032C2 RID: 12994
		// (get) Token: 0x0600A9BD RID: 43453 RVA: 0x002CE028 File Offset: 0x002CC228
		public unsafe Vector3 BlendSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherVolume.NativeMethodInfoPtr_get_BlendSize_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170032C3 RID: 12995
		// (get) Token: 0x0600A9BE RID: 43454 RVA: 0x002CE064 File Offset: 0x002CC264
		public unsafe Vector3 VolumeSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherVolume.NativeMethodInfoPtr_get_VolumeSize_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170032C4 RID: 12996
		// (get) Token: 0x0600A9BF RID: 43455 RVA: 0x002CE0A0 File Offset: 0x002CC2A0
		public unsafe Vector3 Center
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 101087, RefRangeEnd = 101108, XrefRangeStart = 101087, XrefRangeEnd = 101108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherVolume.NativeMethodInfoPtr_get_Center_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170032C5 RID: 12997
		// (get) Token: 0x0600A9C0 RID: 43456 RVA: 0x002CE0DC File Offset: 0x002CC2DC
		public unsafe Vector3 MinBounds
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293821, XrefRangeEnd = 293823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherVolume.NativeMethodInfoPtr_get_MinBounds_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170032C6 RID: 12998
		// (get) Token: 0x0600A9C1 RID: 43457 RVA: 0x002CE118 File Offset: 0x002CC318
		public unsafe Vector3 MaxBounds
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293823, XrefRangeEnd = 293825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherVolume.NativeMethodInfoPtr_get_MaxBounds_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170032C7 RID: 12999
		// (get) Token: 0x0600A9C2 RID: 43458 RVA: 0x002CE154 File Offset: 0x002CC354
		public unsafe List<WeatherEffectController> EffectControllers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherVolume.NativeMethodInfoPtr_get_EffectControllers_Public_get_List_1_WeatherEffectController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<WeatherEffectController>>(intPtr3) : null;
			}
		}

		// Token: 0x170032C8 RID: 13000
		// (get) Token: 0x0600A9C3 RID: 43459 RVA: 0x002CE194 File Offset: 0x002CC394
		public unsafe WeatherProfile WeatherProfile
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherVolume.NativeMethodInfoPtr_get_WeatherProfile_Public_get_WeatherProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WeatherProfile>(intPtr3) : null;
			}
		}

		// Token: 0x170032C9 RID: 13001
		// (get) Token: 0x0600A9C4 RID: 43460 RVA: 0x002CE1D4 File Offset: 0x002CC3D4
		public unsafe Vector3 TopRightBlendCorner
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 293831, RefRangeEnd = 293833, XrefRangeStart = 293825, XrefRangeEnd = 293831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherVolume.NativeMethodInfoPtr_get_TopRightBlendCorner_Protected_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170032CA RID: 13002
		// (get) Token: 0x0600A9C5 RID: 43461 RVA: 0x002CE210 File Offset: 0x002CC410
		public unsafe Vector3 BottomRightBlendCorner
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 293839, RefRangeEnd = 293841, XrefRangeStart = 293833, XrefRangeEnd = 293839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherVolume.NativeMethodInfoPtr_get_BottomRightBlendCorner_Protected_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170032CB RID: 13003
		// (get) Token: 0x0600A9C6 RID: 43462 RVA: 0x002CE24C File Offset: 0x002CC44C
		public unsafe Vector3 TopLeftBlendCorner
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 293847, RefRangeEnd = 293849, XrefRangeStart = 293841, XrefRangeEnd = 293847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherVolume.NativeMethodInfoPtr_get_TopLeftBlendCorner_Protected_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170032CC RID: 13004
		// (get) Token: 0x0600A9C7 RID: 43463 RVA: 0x002CE288 File Offset: 0x002CC488
		public unsafe Vector3 BottomLeftBlendCorner
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 293855, RefRangeEnd = 293857, XrefRangeStart = 293849, XrefRangeEnd = 293855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherVolume.NativeMethodInfoPtr_get_BottomLeftBlendCorner_Protected_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600A9C8 RID: 43464 RVA: 0x002CE2C4 File Offset: 0x002CC4C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 293859, RefRangeEnd = 293860, XrefRangeStart = 293857, XrefRangeEnd = 293859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialise(WeatherProfile profile, Vector3 weatherBounds, Vector3 volumeSize, Vector3 blendSize, float blendAmount, Vector3 anchorPosition, float heightMapWorldSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(profile);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weatherBounds;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volumeSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blendSize;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blendAmount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anchorPosition;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref heightMapWorldSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherVolume.NativeMethodInfoPtr_Initialise_Public_Void_WeatherProfile_Vector3_Vector3_Vector3_Single_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A9C9 RID: 43465 RVA: 0x002CE35C File Offset: 0x002CC55C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293860, XrefRangeEnd = 293867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherVolume.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A9CA RID: 43466 RVA: 0x002CE390 File Offset: 0x002CC590
		[CallerCount(0)]
		public unsafe void SetAnchor(Vector3 anchorPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref anchorPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherVolume.NativeMethodInfoPtr_SetAnchor_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A9CB RID: 43467 RVA: 0x002CE3D0 File Offset: 0x002CC5D0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 293896, RefRangeEnd = 293900, XrefRangeStart = 293867, XrefRangeEnd = 293896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNeighbourVolume(WeatherVolume neighbourVolume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(neighbourVolume);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherVolume.NativeMethodInfoPtr_SetNeighbourVolume_Public_Void_WeatherVolume_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A9CC RID: 43468 RVA: 0x002CE414 File Offset: 0x002CC614
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 293917, RefRangeEnd = 293922, XrefRangeStart = 293900, XrefRangeEnd = 293917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BlendEffects(float blend, AnimationCurve blendCurve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref blend;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(blendCurve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherVolume.NativeMethodInfoPtr_BlendEffects_Public_Void_Single_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A9CD RID: 43469 RVA: 0x002CE464 File Offset: 0x002CC664
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 293950, RefRangeEnd = 293951, XrefRangeStart = 293922, XrefRangeEnd = 293950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetShaderNumericParameter(string paramater, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(paramater);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherVolume.NativeMethodInfoPtr_SetShaderNumericParameter_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A9CE RID: 43470 RVA: 0x002CE4B4 File Offset: 0x002CC6B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 293979, RefRangeEnd = 293980, XrefRangeStart = 293951, XrefRangeEnd = 293979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetShaderColorParameter(string paramater, Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(paramater);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherVolume.NativeMethodInfoPtr_SetShaderColorParameter_Public_Void_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A9CF RID: 43471 RVA: 0x002CE504 File Offset: 0x002CC704
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 293995, RefRangeEnd = 293997, XrefRangeStart = 293980, XrefRangeEnd = 293995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisualEffectNumericParameter(string paramater, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(paramater);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherVolume.NativeMethodInfoPtr_SetVisualEffectNumericParameter_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A9D0 RID: 43472 RVA: 0x002CE554 File Offset: 0x002CC754
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 294016, RefRangeEnd = 294017, XrefRangeStart = 293997, XrefRangeEnd = 294016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVolume(Vector3 playerPosition, float enclosureBlend, float enclosurePan)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref playerPosition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enclosureBlend;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enclosurePan;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherVolume.NativeMethodInfoPtr_UpdateVolume_Public_Void_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A9D1 RID: 43473 RVA: 0x002CE5B0 File Offset: 0x002CC7B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 294019, RefRangeEnd = 294020, XrefRangeStart = 294017, XrefRangeEnd = 294019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsInRightHalf(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherVolume.NativeMethodInfoPtr_IsInRightHalf_Public_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A9D2 RID: 43474 RVA: 0x002CE5FC File Offset: 0x002CC7FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 294026, RefRangeEnd = 294028, XrefRangeStart = 294020, XrefRangeEnd = 294026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetClosestPointOnLeft(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherVolume.NativeMethodInfoPtr_GetClosestPointOnLeft_Public_Vector2_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A9D3 RID: 43475 RVA: 0x002CE648 File Offset: 0x002CC848
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 294034, RefRangeEnd = 294036, XrefRangeStart = 294028, XrefRangeEnd = 294034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetClosestPointOnRight(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherVolume.NativeMethodInfoPtr_GetClosestPointOnRight_Public_Vector2_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A9D4 RID: 43476 RVA: 0x002CE694 File Offset: 0x002CC894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294036, XrefRangeEnd = 294045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherVolume.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A9D5 RID: 43477 RVA: 0x002CE6C8 File Offset: 0x002CC8C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294045, XrefRangeEnd = 294046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeatherVolume() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherVolume.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A9D6 RID: 43478 RVA: 0x002CE704 File Offset: 0x002CC904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294046, XrefRangeEnd = 294053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeatherVolume.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A9D7 RID: 43479 RVA: 0x002CE740 File Offset: 0x002CC940
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeatherVolume.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A9D8 RID: 43480 RVA: 0x002CE77C File Offset: 0x002CC97C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeatherVolume.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A9D9 RID: 43481 RVA: 0x002CE7B8 File Offset: 0x002CC9B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 294084, RefRangeEnd = 294085, XrefRangeStart = 294053, XrefRangeEnd = 294084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Initialise_495303214(WeatherProfile profile, Vector3 weatherBounds, Vector3 volumeSize, Vector3 blendSize, float blendAmount, Vector3 anchorPosition, float heightMapWorldSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(profile);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weatherBounds;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volumeSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blendSize;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blendAmount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anchorPosition;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref heightMapWorldSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherVolume.NativeMethodInfoPtr_RpcWriter___Observers_Initialise_495303214_Private_Void_WeatherProfile_Vector3_Vector3_Vector3_Single_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A9DA RID: 43482 RVA: 0x002CE850 File Offset: 0x002CCA50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 294159, RefRangeEnd = 294161, XrefRangeStart = 294085, XrefRangeEnd = 294159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Initialise_495303214(WeatherProfile profile, Vector3 weatherBounds, Vector3 volumeSize, Vector3 blendSize, float blendAmount, Vector3 anchorPosition, float heightMapWorldSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(profile);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weatherBounds;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volumeSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blendSize;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blendAmount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anchorPosition;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref heightMapWorldSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherVolume.NativeMethodInfoPtr_RpcLogic___Initialise_495303214_Public_Void_WeatherProfile_Vector3_Vector3_Vector3_Single_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A9DB RID: 43483 RVA: 0x002CE8E8 File Offset: 0x002CCAE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294161, XrefRangeEnd = 294188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Initialise_495303214(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherVolume.NativeMethodInfoPtr_RpcReader___Observers_Initialise_495303214_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A9DC RID: 43484 RVA: 0x002CE938 File Offset: 0x002CCB38
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeatherVolume.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A9DD RID: 43485 RVA: 0x0004D564 File Offset: 0x0004B764
		public WeatherVolume(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170032B1 RID: 12977
		// (get) Token: 0x0600A9DE RID: 43486 RVA: 0x002CE974 File Offset: 0x002CCB74
		// (set) Token: 0x0600A9DF RID: 43487 RVA: 0x0004D56D File Offset: 0x0004B76D
		public unsafe RainController _rainController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherVolume.NativeFieldInfoPtr__rainController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RainController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherVolume.NativeFieldInfoPtr__rainController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032B2 RID: 12978
		// (get) Token: 0x0600A9E0 RID: 43488 RVA: 0x002CE9A4 File Offset: 0x002CCBA4
		// (set) Token: 0x0600A9E1 RID: 43489 RVA: 0x0004D58C File Offset: 0x0004B78C
		public unsafe CloudController _cloudController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherVolume.NativeFieldInfoPtr__cloudController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CloudController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherVolume.NativeFieldInfoPtr__cloudController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032B3 RID: 12979
		// (get) Token: 0x0600A9E2 RID: 43490 RVA: 0x002CE9D4 File Offset: 0x002CCBD4
		// (set) Token: 0x0600A9E3 RID: 43491 RVA: 0x0004D5AB File Offset: 0x0004B7AB
		public unsafe ThunderController _thunderController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherVolume.NativeFieldInfoPtr__thunderController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThunderController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherVolume.NativeFieldInfoPtr__thunderController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032B4 RID: 12980
		// (get) Token: 0x0600A9E4 RID: 43492 RVA: 0x002CEA04 File Offset: 0x002CCC04
		// (set) Token: 0x0600A9E5 RID: 43493 RVA: 0x0004D5CA File Offset: 0x0004B7CA
		public unsafe bool _showGizmos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherVolume.NativeFieldInfoPtr__showGizmos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherVolume.NativeFieldInfoPtr__showGizmos)) = value;
			}
		}

		// Token: 0x170032B5 RID: 12981
		// (get) Token: 0x0600A9E6 RID: 43494 RVA: 0x002CEA2C File Offset: 0x002CCC2C
		// (set) Token: 0x0600A9E7 RID: 43495 RVA: 0x0004D5E5 File Offset: 0x0004B7E5
		public unsafe Vector3 _weatherBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherVolume.NativeFieldInfoPtr__weatherBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherVolume.NativeFieldInfoPtr__weatherBounds)) = value;
			}
		}

		// Token: 0x170032B6 RID: 12982
		// (get) Token: 0x0600A9E8 RID: 43496 RVA: 0x002CEA54 File Offset: 0x002CCC54
		// (set) Token: 0x0600A9E9 RID: 43497 RVA: 0x0004D600 File Offset: 0x0004B800
		public unsafe Vector3 _volumeSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherVolume.NativeFieldInfoPtr__volumeSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherVolume.NativeFieldInfoPtr__volumeSize)) = value;
			}
		}

		// Token: 0x170032B7 RID: 12983
		// (get) Token: 0x0600A9EA RID: 43498 RVA: 0x002CEA7C File Offset: 0x002CCC7C
		// (set) Token: 0x0600A9EB RID: 43499 RVA: 0x0004D61B File Offset: 0x0004B81B
		public unsafe Vector3 _blendSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherVolume.NativeFieldInfoPtr__blendSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherVolume.NativeFieldInfoPtr__blendSize)) = value;
			}
		}

		// Token: 0x170032B8 RID: 12984
		// (get) Token: 0x0600A9EC RID: 43500 RVA: 0x002CEAA4 File Offset: 0x002CCCA4
		// (set) Token: 0x0600A9ED RID: 43501 RVA: 0x0004D636 File Offset: 0x0004B836
		public unsafe Vector3 _anchorPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherVolume.NativeFieldInfoPtr__anchorPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherVolume.NativeFieldInfoPtr__anchorPosition)) = value;
			}
		}

		// Token: 0x170032B9 RID: 12985
		// (get) Token: 0x0600A9EE RID: 43502 RVA: 0x002CEACC File Offset: 0x002CCCCC
		// (set) Token: 0x0600A9EF RID: 43503 RVA: 0x0004D651 File Offset: 0x0004B851
		public unsafe float _blendAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherVolume.NativeFieldInfoPtr__blendAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherVolume.NativeFieldInfoPtr__blendAmount)) = value;
			}
		}

		// Token: 0x170032BA RID: 12986
		// (get) Token: 0x0600A9F0 RID: 43504 RVA: 0x002CEAF4 File Offset: 0x002CCCF4
		// (set) Token: 0x0600A9F1 RID: 43505 RVA: 0x0004D66C File Offset: 0x0004B86C
		public unsafe bool _isInitialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherVolume.NativeFieldInfoPtr__isInitialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherVolume.NativeFieldInfoPtr__isInitialized)) = value;
			}
		}

		// Token: 0x170032BB RID: 12987
		// (get) Token: 0x0600A9F2 RID: 43506 RVA: 0x002CEB1C File Offset: 0x002CCD1C
		// (set) Token: 0x0600A9F3 RID: 43507 RVA: 0x0004D687 File Offset: 0x0004B887
		public unsafe Vector3 _velocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherVolume.NativeFieldInfoPtr__velocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherVolume.NativeFieldInfoPtr__velocity)) = value;
			}
		}

		// Token: 0x170032BC RID: 12988
		// (get) Token: 0x0600A9F4 RID: 43508 RVA: 0x002CEB44 File Offset: 0x002CCD44
		// (set) Token: 0x0600A9F5 RID: 43509 RVA: 0x0004D6A2 File Offset: 0x0004B8A2
		public unsafe WeatherProfile _weatherProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherVolume.NativeFieldInfoPtr__weatherProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeatherProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherVolume.NativeFieldInfoPtr__weatherProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032BD RID: 12989
		// (get) Token: 0x0600A9F6 RID: 43510 RVA: 0x002CEB74 File Offset: 0x002CCD74
		// (set) Token: 0x0600A9F7 RID: 43511 RVA: 0x0004D6C1 File Offset: 0x0004B8C1
		public unsafe List<WeatherEffectController> _effectControllers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherVolume.NativeFieldInfoPtr__effectControllers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WeatherEffectController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherVolume.NativeFieldInfoPtr__effectControllers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032BE RID: 12990
		// (get) Token: 0x0600A9F8 RID: 43512 RVA: 0x002CEBA4 File Offset: 0x002CCDA4
		// (set) Token: 0x0600A9F9 RID: 43513 RVA: 0x0004D6E0 File Offset: 0x0004B8E0
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherVolume.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherVolume.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170032BF RID: 12991
		// (get) Token: 0x0600A9FA RID: 43514 RVA: 0x002CEBCC File Offset: 0x002CCDCC
		// (set) Token: 0x0600A9FB RID: 43515 RVA: 0x0004D6FB File Offset: 0x0004B8FB
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherVolume.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherVolume.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04007550 RID: 30032
		private static readonly IntPtr NativeFieldInfoPtr__rainController;

		// Token: 0x04007551 RID: 30033
		private static readonly IntPtr NativeFieldInfoPtr__cloudController;

		// Token: 0x04007552 RID: 30034
		private static readonly IntPtr NativeFieldInfoPtr__thunderController;

		// Token: 0x04007553 RID: 30035
		private static readonly IntPtr NativeFieldInfoPtr__showGizmos;

		// Token: 0x04007554 RID: 30036
		private static readonly IntPtr NativeFieldInfoPtr__weatherBounds;

		// Token: 0x04007555 RID: 30037
		private static readonly IntPtr NativeFieldInfoPtr__volumeSize;

		// Token: 0x04007556 RID: 30038
		private static readonly IntPtr NativeFieldInfoPtr__blendSize;

		// Token: 0x04007557 RID: 30039
		private static readonly IntPtr NativeFieldInfoPtr__anchorPosition;

		// Token: 0x04007558 RID: 30040
		private static readonly IntPtr NativeFieldInfoPtr__blendAmount;

		// Token: 0x04007559 RID: 30041
		private static readonly IntPtr NativeFieldInfoPtr__isInitialized;

		// Token: 0x0400755A RID: 30042
		private static readonly IntPtr NativeFieldInfoPtr__velocity;

		// Token: 0x0400755B RID: 30043
		private static readonly IntPtr NativeFieldInfoPtr__weatherProfile;

		// Token: 0x0400755C RID: 30044
		private static readonly IntPtr NativeFieldInfoPtr__effectControllers;

		// Token: 0x0400755D RID: 30045
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400755E RID: 30046
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400755F RID: 30047
		private static readonly IntPtr NativeMethodInfoPtr_get_BlendAmount_Public_get_Single_0;

		// Token: 0x04007560 RID: 30048
		private static readonly IntPtr NativeMethodInfoPtr_get_WeatherBounds_Public_get_Vector3_0;

		// Token: 0x04007561 RID: 30049
		private static readonly IntPtr NativeMethodInfoPtr_get_BlendSize_Public_get_Vector3_0;

		// Token: 0x04007562 RID: 30050
		private static readonly IntPtr NativeMethodInfoPtr_get_VolumeSize_Public_get_Vector3_0;

		// Token: 0x04007563 RID: 30051
		private static readonly IntPtr NativeMethodInfoPtr_get_Center_Public_get_Vector3_0;

		// Token: 0x04007564 RID: 30052
		private static readonly IntPtr NativeMethodInfoPtr_get_MinBounds_Public_get_Vector3_0;

		// Token: 0x04007565 RID: 30053
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxBounds_Public_get_Vector3_0;

		// Token: 0x04007566 RID: 30054
		private static readonly IntPtr NativeMethodInfoPtr_get_EffectControllers_Public_get_List_1_WeatherEffectController_0;

		// Token: 0x04007567 RID: 30055
		private static readonly IntPtr NativeMethodInfoPtr_get_WeatherProfile_Public_get_WeatherProfile_0;

		// Token: 0x04007568 RID: 30056
		private static readonly IntPtr NativeMethodInfoPtr_get_TopRightBlendCorner_Protected_get_Vector3_0;

		// Token: 0x04007569 RID: 30057
		private static readonly IntPtr NativeMethodInfoPtr_get_BottomRightBlendCorner_Protected_get_Vector3_0;

		// Token: 0x0400756A RID: 30058
		private static readonly IntPtr NativeMethodInfoPtr_get_TopLeftBlendCorner_Protected_get_Vector3_0;

		// Token: 0x0400756B RID: 30059
		private static readonly IntPtr NativeMethodInfoPtr_get_BottomLeftBlendCorner_Protected_get_Vector3_0;

		// Token: 0x0400756C RID: 30060
		private static readonly IntPtr NativeMethodInfoPtr_Initialise_Public_Void_WeatherProfile_Vector3_Vector3_Vector3_Single_Vector3_Single_0;

		// Token: 0x0400756D RID: 30061
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400756E RID: 30062
		private static readonly IntPtr NativeMethodInfoPtr_SetAnchor_Public_Void_Vector3_0;

		// Token: 0x0400756F RID: 30063
		private static readonly IntPtr NativeMethodInfoPtr_SetNeighbourVolume_Public_Void_WeatherVolume_0;

		// Token: 0x04007570 RID: 30064
		private static readonly IntPtr NativeMethodInfoPtr_BlendEffects_Public_Void_Single_AnimationCurve_0;

		// Token: 0x04007571 RID: 30065
		private static readonly IntPtr NativeMethodInfoPtr_SetShaderNumericParameter_Public_Void_String_Single_0;

		// Token: 0x04007572 RID: 30066
		private static readonly IntPtr NativeMethodInfoPtr_SetShaderColorParameter_Public_Void_String_Color_0;

		// Token: 0x04007573 RID: 30067
		private static readonly IntPtr NativeMethodInfoPtr_SetVisualEffectNumericParameter_Public_Void_String_Single_0;

		// Token: 0x04007574 RID: 30068
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVolume_Public_Void_Vector3_Single_Single_0;

		// Token: 0x04007575 RID: 30069
		private static readonly IntPtr NativeMethodInfoPtr_IsInRightHalf_Public_Boolean_Vector3_0;

		// Token: 0x04007576 RID: 30070
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestPointOnLeft_Public_Vector2_Vector3_0;

		// Token: 0x04007577 RID: 30071
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestPointOnRight_Public_Vector2_Vector3_0;

		// Token: 0x04007578 RID: 30072
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04007579 RID: 30073
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400757A RID: 30074
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400757B RID: 30075
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400757C RID: 30076
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400757D RID: 30077
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Initialise_495303214_Private_Void_WeatherProfile_Vector3_Vector3_Vector3_Single_Vector3_Single_0;

		// Token: 0x0400757E RID: 30078
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Initialise_495303214_Public_Void_WeatherProfile_Vector3_Vector3_Vector3_Single_Vector3_Single_0;

		// Token: 0x0400757F RID: 30079
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Initialise_495303214_Private_Void_PooledReader_Channel_0;

		// Token: 0x04007580 RID: 30080
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000C99 RID: 3225
		[ObfuscatedName("ScheduleOne.Weather.WeatherVolume+<>c__DisplayClass42_0")]
		public sealed class __c__DisplayClass42_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F2FD RID: 62205 RVA: 0x003A8550 File Offset: 0x003A6750
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass42_0()
			{
				Il2CppClassPointerStore<WeatherVolume.__c__DisplayClass42_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WeatherVolume>.NativeClassPtr, "<>c__DisplayClass42_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeatherVolume.__c__DisplayClass42_0>.NativeClassPtr);
				WeatherVolume.__c__DisplayClass42_0.NativeFieldInfoPtr_neighbourVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherVolume.__c__DisplayClass42_0>.NativeClassPtr, "neighbourVolume");
				WeatherVolume.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherVolume.__c__DisplayClass42_0>.NativeClassPtr, 100685854);
				WeatherVolume.__c__DisplayClass42_0.NativeMethodInfoPtr__SetNeighbourVolume_b__0_Internal_Void_WeatherEffectController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherVolume.__c__DisplayClass42_0>.NativeClassPtr, 100685855);
			}

			// Token: 0x0600F2FE RID: 62206 RVA: 0x003A85B8 File Offset: 0x003A67B8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass42_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeatherVolume.__c__DisplayClass42_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherVolume.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F2FF RID: 62207 RVA: 0x003A85F4 File Offset: 0x003A67F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293819, XrefRangeEnd = 293821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetNeighbourVolume_b__0(WeatherEffectController effectController)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(effectController);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherVolume.__c__DisplayClass42_0.NativeMethodInfoPtr__SetNeighbourVolume_b__0_Internal_Void_WeatherEffectController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F300 RID: 62208 RVA: 0x00072AA7 File Offset: 0x00070CA7
			public __c__DisplayClass42_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170049B7 RID: 18871
			// (get) Token: 0x0600F301 RID: 62209 RVA: 0x003A8638 File Offset: 0x003A6838
			// (set) Token: 0x0600F302 RID: 62210 RVA: 0x00072AB0 File Offset: 0x00070CB0
			public unsafe WeatherVolume neighbourVolume
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherVolume.__c__DisplayClass42_0.NativeFieldInfoPtr_neighbourVolume);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeatherVolume>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherVolume.__c__DisplayClass42_0.NativeFieldInfoPtr_neighbourVolume), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A45E RID: 42078
			private static readonly IntPtr NativeFieldInfoPtr_neighbourVolume;

			// Token: 0x0400A45F RID: 42079
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A460 RID: 42080
			private static readonly IntPtr NativeMethodInfoPtr__SetNeighbourVolume_b__0_Internal_Void_WeatherEffectController_0;
		}
	}
}
