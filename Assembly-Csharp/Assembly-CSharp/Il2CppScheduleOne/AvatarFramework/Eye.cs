using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x0200049A RID: 1178
	public class Eye : MonoBehaviour
	{
		// Token: 0x06006BAE RID: 27566 RVA: 0x001EFF5C File Offset: 0x001EE15C
		// Note: this type is marked as 'beforefieldinit'.
		static Eye()
		{
			Il2CppClassPointerStore<Eye>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "Eye");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Eye>.NativeClassPtr);
			Eye.NativeFieldInfoPtr_PupilLookSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "PupilLookSpeed");
			Eye.NativeFieldInfoPtr_defaultScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "defaultScale");
			Eye.NativeFieldInfoPtr_maxRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "maxRotation");
			Eye.NativeFieldInfoPtr_minRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "minRotation");
			Eye.NativeFieldInfoPtr__CurrentConfiguration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "<CurrentConfiguration>k__BackingField");
			Eye.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "Container");
			Eye.NativeFieldInfoPtr_TopLidContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "TopLidContainer");
			Eye.NativeFieldInfoPtr_BottomLidContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "BottomLidContainer");
			Eye.NativeFieldInfoPtr_PupilContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "PupilContainer");
			Eye.NativeFieldInfoPtr_TopLidRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "TopLidRend");
			Eye.NativeFieldInfoPtr_BottomLidRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "BottomLidRend");
			Eye.NativeFieldInfoPtr_EyeBallRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "EyeBallRend");
			Eye.NativeFieldInfoPtr_EyeLookOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "EyeLookOrigin");
			Eye.NativeFieldInfoPtr_EyeLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "EyeLight");
			Eye.NativeFieldInfoPtr_PupilRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "PupilRend");
			Eye.NativeFieldInfoPtr_blinkRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "blinkRoutine");
			Eye.NativeFieldInfoPtr_stateRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "stateRoutine");
			Eye.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "avatar");
			Eye.NativeFieldInfoPtr_defaultEyeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "defaultEyeColor");
			Eye.NativeFieldInfoPtr_AngleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "AngleOffset");
			Eye.NativeMethodInfoPtr_get_CurrentConfiguration_Public_get_EyeLidConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100677378);
			Eye.NativeMethodInfoPtr_set_CurrentConfiguration_Protected_set_Void_EyeLidConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100677379);
			Eye.NativeMethodInfoPtr_get_IsBlinking_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100677380);
			Eye.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100677381);
			Eye.NativeMethodInfoPtr_SetSize_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100677382);
			Eye.NativeMethodInfoPtr_SetLidColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100677383);
			Eye.NativeMethodInfoPtr_SetEyeballMaterial_Public_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100677384);
			Eye.NativeMethodInfoPtr_SetEyeballColor_Public_Void_Color_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100677385);
			Eye.NativeMethodInfoPtr_ResetEyeballColor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100677386);
			Eye.NativeMethodInfoPtr_ConfigureEyeLight_Public_Void_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100677387);
			Eye.NativeMethodInfoPtr_SetDilation_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100677388);
			Eye.NativeMethodInfoPtr_SetEyeLidState_Public_Void_EyeLidConfiguration_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100677389);
			Eye.NativeMethodInfoPtr_StopExistingRoutines_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100677390);
			Eye.NativeMethodInfoPtr_SetEyeLidState_Public_Void_EyeLidConfiguration_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100677391);
			Eye.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100677392);
			Eye.NativeMethodInfoPtr_Blink_Public_Void_Single_EyeLidConfiguration_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100677393);
			Eye.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100677394);
		}

		// Token: 0x17002133 RID: 8499
		// (get) Token: 0x06006BAF RID: 27567 RVA: 0x001F0270 File Offset: 0x001EE470
		// (set) Token: 0x06006BB0 RID: 27568 RVA: 0x001F02AC File Offset: 0x001EE4AC
		public unsafe Eye.EyeLidConfiguration CurrentConfiguration
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_get_CurrentConfiguration_Public_get_EyeLidConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_set_CurrentConfiguration_Protected_set_Void_EyeLidConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002134 RID: 8500
		// (get) Token: 0x06006BB1 RID: 27569 RVA: 0x001F02EC File Offset: 0x001EE4EC
		public unsafe bool IsBlinking
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_get_IsBlinking_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06006BB2 RID: 27570 RVA: 0x001F0328 File Offset: 0x001EE528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220767, XrefRangeEnd = 220773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BB3 RID: 27571 RVA: 0x001F035C File Offset: 0x001EE55C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220773, XrefRangeEnd = 220778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSize(float size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_SetSize_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BB4 RID: 27572 RVA: 0x001F039C File Offset: 0x001EE59C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220778, XrefRangeEnd = 220782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLidColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_SetLidColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BB5 RID: 27573 RVA: 0x001F03DC File Offset: 0x001EE5DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220782, XrefRangeEnd = 220784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEyeballMaterial(Material mat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_SetEyeballMaterial_Public_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BB6 RID: 27574 RVA: 0x001F0420 File Offset: 0x001EE620
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 220790, RefRangeEnd = 220802, XrefRangeStart = 220784, XrefRangeEnd = 220790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEyeballColor(Color col, float emission = 0.115f, bool writeDefault = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref emission;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeDefault;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_SetEyeballColor_Public_Void_Color_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BB7 RID: 27575 RVA: 0x001F047C File Offset: 0x001EE67C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 220808, RefRangeEnd = 220812, XrefRangeStart = 220802, XrefRangeEnd = 220808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetEyeballColor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_ResetEyeballColor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BB8 RID: 27576 RVA: 0x001F04B0 File Offset: 0x001EE6B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 220822, RefRangeEnd = 220824, XrefRangeStart = 220812, XrefRangeEnd = 220822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureEyeLight(Color color, float intensity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref intensity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_ConfigureEyeLight_Public_Void_Color_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BB9 RID: 27577 RVA: 0x001F04FC File Offset: 0x001EE6FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220824, XrefRangeEnd = 220826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDilation(float dil)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dil;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_SetDilation_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BBA RID: 27578 RVA: 0x001F053C File Offset: 0x001EE73C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 220846, RefRangeEnd = 220848, XrefRangeStart = 220826, XrefRangeEnd = 220846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEyeLidState(Eye.EyeLidConfiguration config, float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref config;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_SetEyeLidState_Public_Void_EyeLidConfiguration_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BBB RID: 27579 RVA: 0x001F0588 File Offset: 0x001EE788
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 220859, RefRangeEnd = 220861, XrefRangeStart = 220848, XrefRangeEnd = 220859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopExistingRoutines()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_StopExistingRoutines_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BBC RID: 27580 RVA: 0x001F05BC File Offset: 0x001EE7BC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 220890, RefRangeEnd = 220902, XrefRangeStart = 220861, XrefRangeEnd = 220890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEyeLidState(Eye.EyeLidConfiguration config, bool debug = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref config;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref debug;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_SetEyeLidState_Public_Void_EyeLidConfiguration_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BBD RID: 27581 RVA: 0x001F0608 File Offset: 0x001EE808
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 220922, RefRangeEnd = 220924, XrefRangeStart = 220902, XrefRangeEnd = 220922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LookAt(Vector3 position, bool instant = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instant;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BBE RID: 27582 RVA: 0x001F0654 File Offset: 0x001EE854
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 220947, RefRangeEnd = 220953, XrefRangeStart = 220924, XrefRangeEnd = 220947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Blink(float blinkDuration, Eye.EyeLidConfiguration endState, bool debug = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref blinkDuration;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endState;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref debug;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_Blink_Public_Void_Single_EyeLidConfiguration_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BBF RID: 27583 RVA: 0x001F06B0 File Offset: 0x001EE8B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220953, XrefRangeEnd = 220956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Eye() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Eye>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BC0 RID: 27584 RVA: 0x00032B35 File Offset: 0x00030D35
		public Eye(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700211F RID: 8479
		// (get) Token: 0x06006BC1 RID: 27585 RVA: 0x001F06EC File Offset: 0x001EE8EC
		// (set) Token: 0x06006BC2 RID: 27586 RVA: 0x00032B3E File Offset: 0x00030D3E
		public unsafe static float PupilLookSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Eye.NativeFieldInfoPtr_PupilLookSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Eye.NativeFieldInfoPtr_PupilLookSpeed, (void*)(&value));
			}
		}

		// Token: 0x17002120 RID: 8480
		// (get) Token: 0x06006BC3 RID: 27587 RVA: 0x001F0708 File Offset: 0x001EE908
		// (set) Token: 0x06006BC4 RID: 27588 RVA: 0x00032B4C File Offset: 0x00030D4C
		public unsafe static Vector3 defaultScale
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(Eye.NativeFieldInfoPtr_defaultScale, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Eye.NativeFieldInfoPtr_defaultScale, (void*)(&value));
			}
		}

		// Token: 0x17002121 RID: 8481
		// (get) Token: 0x06006BC5 RID: 27589 RVA: 0x001F0724 File Offset: 0x001EE924
		// (set) Token: 0x06006BC6 RID: 27590 RVA: 0x00032B5A File Offset: 0x00030D5A
		public unsafe static Vector3 maxRotation
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(Eye.NativeFieldInfoPtr_maxRotation, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Eye.NativeFieldInfoPtr_maxRotation, (void*)(&value));
			}
		}

		// Token: 0x17002122 RID: 8482
		// (get) Token: 0x06006BC7 RID: 27591 RVA: 0x001F0740 File Offset: 0x001EE940
		// (set) Token: 0x06006BC8 RID: 27592 RVA: 0x00032B68 File Offset: 0x00030D68
		public unsafe static Vector3 minRotation
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(Eye.NativeFieldInfoPtr_minRotation, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Eye.NativeFieldInfoPtr_minRotation, (void*)(&value));
			}
		}

		// Token: 0x17002123 RID: 8483
		// (get) Token: 0x06006BC9 RID: 27593 RVA: 0x001F075C File Offset: 0x001EE95C
		// (set) Token: 0x06006BCA RID: 27594 RVA: 0x00032B76 File Offset: 0x00030D76
		public unsafe Eye.EyeLidConfiguration _CurrentConfiguration_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr__CurrentConfiguration_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr__CurrentConfiguration_k__BackingField)) = value;
			}
		}

		// Token: 0x17002124 RID: 8484
		// (get) Token: 0x06006BCB RID: 27595 RVA: 0x001F0784 File Offset: 0x001EE984
		// (set) Token: 0x06006BCC RID: 27596 RVA: 0x00032B91 File Offset: 0x00030D91
		public unsafe Transform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002125 RID: 8485
		// (get) Token: 0x06006BCD RID: 27597 RVA: 0x001F07B4 File Offset: 0x001EE9B4
		// (set) Token: 0x06006BCE RID: 27598 RVA: 0x00032BB0 File Offset: 0x00030DB0
		public unsafe Transform TopLidContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_TopLidContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_TopLidContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002126 RID: 8486
		// (get) Token: 0x06006BCF RID: 27599 RVA: 0x001F07E4 File Offset: 0x001EE9E4
		// (set) Token: 0x06006BD0 RID: 27600 RVA: 0x00032BCF File Offset: 0x00030DCF
		public unsafe Transform BottomLidContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_BottomLidContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_BottomLidContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002127 RID: 8487
		// (get) Token: 0x06006BD1 RID: 27601 RVA: 0x001F0814 File Offset: 0x001EEA14
		// (set) Token: 0x06006BD2 RID: 27602 RVA: 0x00032BEE File Offset: 0x00030DEE
		public unsafe Transform PupilContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_PupilContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_PupilContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002128 RID: 8488
		// (get) Token: 0x06006BD3 RID: 27603 RVA: 0x001F0844 File Offset: 0x001EEA44
		// (set) Token: 0x06006BD4 RID: 27604 RVA: 0x00032C0D File Offset: 0x00030E0D
		public unsafe MeshRenderer TopLidRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_TopLidRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_TopLidRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002129 RID: 8489
		// (get) Token: 0x06006BD5 RID: 27605 RVA: 0x001F0874 File Offset: 0x001EEA74
		// (set) Token: 0x06006BD6 RID: 27606 RVA: 0x00032C2C File Offset: 0x00030E2C
		public unsafe MeshRenderer BottomLidRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_BottomLidRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_BottomLidRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700212A RID: 8490
		// (get) Token: 0x06006BD7 RID: 27607 RVA: 0x001F08A4 File Offset: 0x001EEAA4
		// (set) Token: 0x06006BD8 RID: 27608 RVA: 0x00032C4B File Offset: 0x00030E4B
		public unsafe MeshRenderer EyeBallRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_EyeBallRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_EyeBallRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700212B RID: 8491
		// (get) Token: 0x06006BD9 RID: 27609 RVA: 0x001F08D4 File Offset: 0x001EEAD4
		// (set) Token: 0x06006BDA RID: 27610 RVA: 0x00032C6A File Offset: 0x00030E6A
		public unsafe Transform EyeLookOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_EyeLookOrigin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_EyeLookOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700212C RID: 8492
		// (get) Token: 0x06006BDB RID: 27611 RVA: 0x001F0904 File Offset: 0x001EEB04
		// (set) Token: 0x06006BDC RID: 27612 RVA: 0x00032C89 File Offset: 0x00030E89
		public unsafe OptimizedLight EyeLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_EyeLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OptimizedLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_EyeLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700212D RID: 8493
		// (get) Token: 0x06006BDD RID: 27613 RVA: 0x001F0934 File Offset: 0x001EEB34
		// (set) Token: 0x06006BDE RID: 27614 RVA: 0x00032CA8 File Offset: 0x00030EA8
		public unsafe SkinnedMeshRenderer PupilRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_PupilRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkinnedMeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_PupilRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700212E RID: 8494
		// (get) Token: 0x06006BDF RID: 27615 RVA: 0x001F0964 File Offset: 0x001EEB64
		// (set) Token: 0x06006BE0 RID: 27616 RVA: 0x00032CC7 File Offset: 0x00030EC7
		public unsafe Coroutine blinkRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_blinkRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_blinkRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700212F RID: 8495
		// (get) Token: 0x06006BE1 RID: 27617 RVA: 0x001F0994 File Offset: 0x001EEB94
		// (set) Token: 0x06006BE2 RID: 27618 RVA: 0x00032CE6 File Offset: 0x00030EE6
		public unsafe Coroutine stateRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_stateRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_stateRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002130 RID: 8496
		// (get) Token: 0x06006BE3 RID: 27619 RVA: 0x001F09C4 File Offset: 0x001EEBC4
		// (set) Token: 0x06006BE4 RID: 27620 RVA: 0x00032D05 File Offset: 0x00030F05
		public unsafe Avatar avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002131 RID: 8497
		// (get) Token: 0x06006BE5 RID: 27621 RVA: 0x001F09F4 File Offset: 0x001EEBF4
		// (set) Token: 0x06006BE6 RID: 27622 RVA: 0x00032D24 File Offset: 0x00030F24
		public unsafe Color defaultEyeColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_defaultEyeColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_defaultEyeColor)) = value;
			}
		}

		// Token: 0x17002132 RID: 8498
		// (get) Token: 0x06006BE7 RID: 27623 RVA: 0x001F0A1C File Offset: 0x001EEC1C
		// (set) Token: 0x06006BE8 RID: 27624 RVA: 0x00032D3F File Offset: 0x00030F3F
		public unsafe Vector2 AngleOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_AngleOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_AngleOffset)) = value;
			}
		}

		// Token: 0x04004A14 RID: 18964
		private static readonly IntPtr NativeFieldInfoPtr_PupilLookSpeed;

		// Token: 0x04004A15 RID: 18965
		private static readonly IntPtr NativeFieldInfoPtr_defaultScale;

		// Token: 0x04004A16 RID: 18966
		private static readonly IntPtr NativeFieldInfoPtr_maxRotation;

		// Token: 0x04004A17 RID: 18967
		private static readonly IntPtr NativeFieldInfoPtr_minRotation;

		// Token: 0x04004A18 RID: 18968
		private static readonly IntPtr NativeFieldInfoPtr__CurrentConfiguration_k__BackingField;

		// Token: 0x04004A19 RID: 18969
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04004A1A RID: 18970
		private static readonly IntPtr NativeFieldInfoPtr_TopLidContainer;

		// Token: 0x04004A1B RID: 18971
		private static readonly IntPtr NativeFieldInfoPtr_BottomLidContainer;

		// Token: 0x04004A1C RID: 18972
		private static readonly IntPtr NativeFieldInfoPtr_PupilContainer;

		// Token: 0x04004A1D RID: 18973
		private static readonly IntPtr NativeFieldInfoPtr_TopLidRend;

		// Token: 0x04004A1E RID: 18974
		private static readonly IntPtr NativeFieldInfoPtr_BottomLidRend;

		// Token: 0x04004A1F RID: 18975
		private static readonly IntPtr NativeFieldInfoPtr_EyeBallRend;

		// Token: 0x04004A20 RID: 18976
		private static readonly IntPtr NativeFieldInfoPtr_EyeLookOrigin;

		// Token: 0x04004A21 RID: 18977
		private static readonly IntPtr NativeFieldInfoPtr_EyeLight;

		// Token: 0x04004A22 RID: 18978
		private static readonly IntPtr NativeFieldInfoPtr_PupilRend;

		// Token: 0x04004A23 RID: 18979
		private static readonly IntPtr NativeFieldInfoPtr_blinkRoutine;

		// Token: 0x04004A24 RID: 18980
		private static readonly IntPtr NativeFieldInfoPtr_stateRoutine;

		// Token: 0x04004A25 RID: 18981
		private static readonly IntPtr NativeFieldInfoPtr_avatar;

		// Token: 0x04004A26 RID: 18982
		private static readonly IntPtr NativeFieldInfoPtr_defaultEyeColor;

		// Token: 0x04004A27 RID: 18983
		private static readonly IntPtr NativeFieldInfoPtr_AngleOffset;

		// Token: 0x04004A28 RID: 18984
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentConfiguration_Public_get_EyeLidConfiguration_0;

		// Token: 0x04004A29 RID: 18985
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentConfiguration_Protected_set_Void_EyeLidConfiguration_0;

		// Token: 0x04004A2A RID: 18986
		private static readonly IntPtr NativeMethodInfoPtr_get_IsBlinking_Public_get_Boolean_0;

		// Token: 0x04004A2B RID: 18987
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004A2C RID: 18988
		private static readonly IntPtr NativeMethodInfoPtr_SetSize_Public_Void_Single_0;

		// Token: 0x04004A2D RID: 18989
		private static readonly IntPtr NativeMethodInfoPtr_SetLidColor_Public_Void_Color_0;

		// Token: 0x04004A2E RID: 18990
		private static readonly IntPtr NativeMethodInfoPtr_SetEyeballMaterial_Public_Void_Material_0;

		// Token: 0x04004A2F RID: 18991
		private static readonly IntPtr NativeMethodInfoPtr_SetEyeballColor_Public_Void_Color_Single_Boolean_0;

		// Token: 0x04004A30 RID: 18992
		private static readonly IntPtr NativeMethodInfoPtr_ResetEyeballColor_Public_Void_0;

		// Token: 0x04004A31 RID: 18993
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureEyeLight_Public_Void_Color_Single_0;

		// Token: 0x04004A32 RID: 18994
		private static readonly IntPtr NativeMethodInfoPtr_SetDilation_Public_Void_Single_0;

		// Token: 0x04004A33 RID: 18995
		private static readonly IntPtr NativeMethodInfoPtr_SetEyeLidState_Public_Void_EyeLidConfiguration_Single_0;

		// Token: 0x04004A34 RID: 18996
		private static readonly IntPtr NativeMethodInfoPtr_StopExistingRoutines_Private_Void_0;

		// Token: 0x04004A35 RID: 18997
		private static readonly IntPtr NativeMethodInfoPtr_SetEyeLidState_Public_Void_EyeLidConfiguration_Boolean_0;

		// Token: 0x04004A36 RID: 18998
		private static readonly IntPtr NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Boolean_0;

		// Token: 0x04004A37 RID: 18999
		private static readonly IntPtr NativeMethodInfoPtr_Blink_Public_Void_Single_EyeLidConfiguration_Boolean_0;

		// Token: 0x04004A38 RID: 19000
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B64 RID: 2916
		[Serializable]
		[StructLayout(2)]
		public struct EyeLidConfiguration
		{
			// Token: 0x0600E84B RID: 59467 RVA: 0x0038919C File Offset: 0x0038739C
			// Note: this type is marked as 'beforefieldinit'.
			static EyeLidConfiguration()
			{
				Il2CppClassPointerStore<Eye.EyeLidConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Eye>.NativeClassPtr, "EyeLidConfiguration");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Eye.EyeLidConfiguration>.NativeClassPtr);
				Eye.EyeLidConfiguration.NativeFieldInfoPtr_topLidOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.EyeLidConfiguration>.NativeClassPtr, "topLidOpen");
				Eye.EyeLidConfiguration.NativeFieldInfoPtr_bottomLidOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.EyeLidConfiguration>.NativeClassPtr, "bottomLidOpen");
				Eye.EyeLidConfiguration.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.EyeLidConfiguration>.NativeClassPtr, 100677396);
				Eye.EyeLidConfiguration.NativeMethodInfoPtr_Lerp_Public_Static_EyeLidConfiguration_EyeLidConfiguration_EyeLidConfiguration_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.EyeLidConfiguration>.NativeClassPtr, 100677397);
			}

			// Token: 0x0600E84C RID: 59468 RVA: 0x00389218 File Offset: 0x00387418
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220714, XrefRangeEnd = 220721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.EyeLidConfiguration.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600E84D RID: 59469 RVA: 0x00389244 File Offset: 0x00387444
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 220724, RefRangeEnd = 220726, XrefRangeStart = 220721, XrefRangeEnd = 220724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Eye.EyeLidConfiguration Lerp(Eye.EyeLidConfiguration start, Eye.EyeLidConfiguration end, float lerp)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref start;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerp;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.EyeLidConfiguration.NativeMethodInfoPtr_Lerp_Public_Static_EyeLidConfiguration_EyeLidConfiguration_EyeLidConfiguration_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E84E RID: 59470 RVA: 0x0006D8E8 File Offset: 0x0006BAE8
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Eye.EyeLidConfiguration>.NativeClassPtr, ref this));
			}

			// Token: 0x04009D91 RID: 40337
			private static readonly IntPtr NativeFieldInfoPtr_topLidOpen;

			// Token: 0x04009D92 RID: 40338
			private static readonly IntPtr NativeFieldInfoPtr_bottomLidOpen;

			// Token: 0x04009D93 RID: 40339
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x04009D94 RID: 40340
			private static readonly IntPtr NativeMethodInfoPtr_Lerp_Public_Static_EyeLidConfiguration_EyeLidConfiguration_EyeLidConfiguration_Single_0;

			// Token: 0x04009D95 RID: 40341
			[FieldOffset(0)]
			public float topLidOpen;

			// Token: 0x04009D96 RID: 40342
			[FieldOffset(4)]
			public float bottomLidOpen;
		}

		// Token: 0x02000B65 RID: 2917
		[ObfuscatedName("ScheduleOne.AvatarFramework.Eye+<>c__DisplayClass34_0")]
		public sealed class __c__DisplayClass34_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E84F RID: 59471 RVA: 0x003892A0 File Offset: 0x003874A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass34_0()
			{
				Il2CppClassPointerStore<Eye.__c__DisplayClass34_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Eye>.NativeClassPtr, "<>c__DisplayClass34_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0>.NativeClassPtr);
				Eye.__c__DisplayClass34_0.NativeFieldInfoPtr_startConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0>.NativeClassPtr, "startConfig");
				Eye.__c__DisplayClass34_0.NativeFieldInfoPtr_config = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0>.NativeClassPtr, "config");
				Eye.__c__DisplayClass34_0.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0>.NativeClassPtr, "time");
				Eye.__c__DisplayClass34_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0>.NativeClassPtr, "<>4__this");
				Eye.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0>.NativeClassPtr, 100677398);
				Eye.__c__DisplayClass34_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0>.NativeClassPtr, 100677399);
			}

			// Token: 0x0600E850 RID: 59472 RVA: 0x00389344 File Offset: 0x00387544
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass34_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E851 RID: 59473 RVA: 0x00389380 File Offset: 0x00387580
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220741, XrefRangeEnd = 220746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass34_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E852 RID: 59474 RVA: 0x0006D8FA File Offset: 0x0006BAFA
			public __c__DisplayClass34_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700467C RID: 18044
			// (get) Token: 0x0600E853 RID: 59475 RVA: 0x003893C0 File Offset: 0x003875C0
			// (set) Token: 0x0600E854 RID: 59476 RVA: 0x0006D903 File Offset: 0x0006BB03
			public unsafe Eye.EyeLidConfiguration startConfig
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.NativeFieldInfoPtr_startConfig);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.NativeFieldInfoPtr_startConfig)) = value;
				}
			}

			// Token: 0x1700467D RID: 18045
			// (get) Token: 0x0600E855 RID: 59477 RVA: 0x003893E8 File Offset: 0x003875E8
			// (set) Token: 0x0600E856 RID: 59478 RVA: 0x0006D91E File Offset: 0x0006BB1E
			public unsafe Eye.EyeLidConfiguration config
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.NativeFieldInfoPtr_config);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.NativeFieldInfoPtr_config)) = value;
				}
			}

			// Token: 0x1700467E RID: 18046
			// (get) Token: 0x0600E857 RID: 59479 RVA: 0x00389410 File Offset: 0x00387610
			// (set) Token: 0x0600E858 RID: 59480 RVA: 0x0006D939 File Offset: 0x0006BB39
			public unsafe float time
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.NativeFieldInfoPtr_time);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.NativeFieldInfoPtr_time)) = value;
				}
			}

			// Token: 0x1700467F RID: 18047
			// (get) Token: 0x0600E859 RID: 59481 RVA: 0x00389438 File Offset: 0x00387638
			// (set) Token: 0x0600E85A RID: 59482 RVA: 0x0006D954 File Offset: 0x0006BB54
			public unsafe Eye __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Eye>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009D97 RID: 40343
			private static readonly IntPtr NativeFieldInfoPtr_startConfig;

			// Token: 0x04009D98 RID: 40344
			private static readonly IntPtr NativeFieldInfoPtr_config;

			// Token: 0x04009D99 RID: 40345
			private static readonly IntPtr NativeFieldInfoPtr_time;

			// Token: 0x04009D9A RID: 40346
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009D9B RID: 40347
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009D9C RID: 40348
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000DDF RID: 3551
			[ObfuscatedName("ScheduleOne.AvatarFramework.Eye+<>c__DisplayClass34_0+<<SetEyeLidState>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06010036 RID: 65590 RVA: 0x003CE2C4 File Offset: 0x003CC4C4
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique()
				{
					Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0>.NativeClassPtr, "<<SetEyeLidState>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr);
					Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>1__state");
					Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>2__current");
					Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>4__this");
					Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<i>5__2");
					Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100677400);
					Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100677401);
					Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100677402);
					Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100677403);
					Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100677404);
					Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100677405);
				}

				// Token: 0x06010037 RID: 65591 RVA: 0x003CE3B8 File Offset: 0x003CC5B8
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06010038 RID: 65592 RVA: 0x003CE400 File Offset: 0x003CC600
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06010039 RID: 65593 RVA: 0x003CE434 File Offset: 0x003CC634
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220726, XrefRangeEnd = 220736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004E10 RID: 19984
				// (get) Token: 0x0601003A RID: 65594 RVA: 0x003CE470 File Offset: 0x003CC670
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601003B RID: 65595 RVA: 0x003CE4B0 File Offset: 0x003CC6B0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220736, XrefRangeEnd = 220741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004E11 RID: 19985
				// (get) Token: 0x0601003C RID: 65596 RVA: 0x003CE4E4 File Offset: 0x003CC6E4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601003D RID: 65597 RVA: 0x000796B9 File Offset: 0x000778B9
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004E0C RID: 19980
				// (get) Token: 0x0601003E RID: 65598 RVA: 0x003CE524 File Offset: 0x003CC724
				// (set) Token: 0x0601003F RID: 65599 RVA: 0x000796C2 File Offset: 0x000778C2
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004E0D RID: 19981
				// (get) Token: 0x06010040 RID: 65600 RVA: 0x003CE54C File Offset: 0x003CC74C
				// (set) Token: 0x06010041 RID: 65601 RVA: 0x000796DD File Offset: 0x000778DD
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004E0E RID: 19982
				// (get) Token: 0x06010042 RID: 65602 RVA: 0x003CE57C File Offset: 0x003CC77C
				// (set) Token: 0x06010043 RID: 65603 RVA: 0x000796FC File Offset: 0x000778FC
				public unsafe Eye.__c__DisplayClass34_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Eye.__c__DisplayClass34_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004E0F RID: 19983
				// (get) Token: 0x06010044 RID: 65604 RVA: 0x003CE5AC File Offset: 0x003CC7AC
				// (set) Token: 0x06010045 RID: 65605 RVA: 0x0007971B File Offset: 0x0007791B
				public unsafe float _i_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2)) = value;
					}
				}

				// Token: 0x0400AC96 RID: 44182
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AC97 RID: 44183
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AC98 RID: 44184
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AC99 RID: 44185
				private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

				// Token: 0x0400AC9A RID: 44186
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AC9B RID: 44187
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AC9C RID: 44188
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AC9D RID: 44189
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AC9E RID: 44190
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AC9F RID: 44191
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000B66 RID: 2918
		[ObfuscatedName("ScheduleOne.AvatarFramework.Eye+<>c__DisplayClass38_0")]
		public sealed class __c__DisplayClass38_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E85B RID: 59483 RVA: 0x00389468 File Offset: 0x00387668
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass38_0()
			{
				Il2CppClassPointerStore<Eye.__c__DisplayClass38_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Eye>.NativeClassPtr, "<>c__DisplayClass38_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0>.NativeClassPtr);
				Eye.__c__DisplayClass38_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0>.NativeClassPtr, "<>4__this");
				Eye.__c__DisplayClass38_0.NativeFieldInfoPtr_blinkDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0>.NativeClassPtr, "blinkDuration");
				Eye.__c__DisplayClass38_0.NativeFieldInfoPtr_debug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0>.NativeClassPtr, "debug");
				Eye.__c__DisplayClass38_0.NativeFieldInfoPtr_endState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0>.NativeClassPtr, "endState");
				Eye.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0>.NativeClassPtr, 100677406);
				Eye.__c__DisplayClass38_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0>.NativeClassPtr, 100677407);
			}

			// Token: 0x0600E85C RID: 59484 RVA: 0x0038950C File Offset: 0x0038770C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass38_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E85D RID: 59485 RVA: 0x00389548 File Offset: 0x00387748
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220762, XrefRangeEnd = 220767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass38_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E85E RID: 59486 RVA: 0x0006D973 File Offset: 0x0006BB73
			public __c__DisplayClass38_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004680 RID: 18048
			// (get) Token: 0x0600E85F RID: 59487 RVA: 0x00389588 File Offset: 0x00387788
			// (set) Token: 0x0600E860 RID: 59488 RVA: 0x0006D97C File Offset: 0x0006BB7C
			public unsafe Eye __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Eye>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004681 RID: 18049
			// (get) Token: 0x0600E861 RID: 59489 RVA: 0x003895B8 File Offset: 0x003877B8
			// (set) Token: 0x0600E862 RID: 59490 RVA: 0x0006D99B File Offset: 0x0006BB9B
			public unsafe float blinkDuration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.NativeFieldInfoPtr_blinkDuration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.NativeFieldInfoPtr_blinkDuration)) = value;
				}
			}

			// Token: 0x17004682 RID: 18050
			// (get) Token: 0x0600E863 RID: 59491 RVA: 0x003895E0 File Offset: 0x003877E0
			// (set) Token: 0x0600E864 RID: 59492 RVA: 0x0006D9B6 File Offset: 0x0006BBB6
			public unsafe bool debug
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.NativeFieldInfoPtr_debug);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.NativeFieldInfoPtr_debug)) = value;
				}
			}

			// Token: 0x17004683 RID: 18051
			// (get) Token: 0x0600E865 RID: 59493 RVA: 0x00389608 File Offset: 0x00387808
			// (set) Token: 0x0600E866 RID: 59494 RVA: 0x0006D9D1 File Offset: 0x0006BBD1
			public unsafe Eye.EyeLidConfiguration endState
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.NativeFieldInfoPtr_endState);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.NativeFieldInfoPtr_endState)) = value;
				}
			}

			// Token: 0x04009D9D RID: 40349
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009D9E RID: 40350
			private static readonly IntPtr NativeFieldInfoPtr_blinkDuration;

			// Token: 0x04009D9F RID: 40351
			private static readonly IntPtr NativeFieldInfoPtr_debug;

			// Token: 0x04009DA0 RID: 40352
			private static readonly IntPtr NativeFieldInfoPtr_endState;

			// Token: 0x04009DA1 RID: 40353
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009DA2 RID: 40354
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000DE0 RID: 3552
			[ObfuscatedName("ScheduleOne.AvatarFramework.Eye+<>c__DisplayClass38_0+<<Blink>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique : Il2CppSystem.Object
			{
				// Token: 0x06010046 RID: 65606 RVA: 0x003CE5D4 File Offset: 0x003CC7D4
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique()
				{
					Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0>.NativeClassPtr, "<<Blink>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr);
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, "<>1__state");
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, "<>2__current");
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, "<>4__this");
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__start_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, "<start>5__2");
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__end_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, "<end>5__3");
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__holdTime_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, "<holdTime>5__4");
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__duration_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, "<duration>5__5");
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__i_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, "<i>5__6");
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, 100677408);
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, 100677409);
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, 100677410);
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, 100677411);
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, 100677412);
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, 100677413);
				}

				// Token: 0x06010047 RID: 65607 RVA: 0x003CE718 File Offset: 0x003CC918
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06010048 RID: 65608 RVA: 0x003CE760 File Offset: 0x003CC960
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06010049 RID: 65609 RVA: 0x003CE794 File Offset: 0x003CC994
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220746, XrefRangeEnd = 220757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004E1A RID: 19994
				// (get) Token: 0x0601004A RID: 65610 RVA: 0x003CE7D0 File Offset: 0x003CC9D0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601004B RID: 65611 RVA: 0x003CE810 File Offset: 0x003CCA10
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220757, XrefRangeEnd = 220762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004E1B RID: 19995
				// (get) Token: 0x0601004C RID: 65612 RVA: 0x003CE844 File Offset: 0x003CCA44
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601004D RID: 65613 RVA: 0x00079736 File Offset: 0x00077936
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004E12 RID: 19986
				// (get) Token: 0x0601004E RID: 65614 RVA: 0x003CE884 File Offset: 0x003CCA84
				// (set) Token: 0x0601004F RID: 65615 RVA: 0x0007973F File Offset: 0x0007793F
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004E13 RID: 19987
				// (get) Token: 0x06010050 RID: 65616 RVA: 0x003CE8AC File Offset: 0x003CCAAC
				// (set) Token: 0x06010051 RID: 65617 RVA: 0x0007975A File Offset: 0x0007795A
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004E14 RID: 19988
				// (get) Token: 0x06010052 RID: 65618 RVA: 0x003CE8DC File Offset: 0x003CCADC
				// (set) Token: 0x06010053 RID: 65619 RVA: 0x00079779 File Offset: 0x00077979
				public unsafe Eye.__c__DisplayClass38_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Eye.__c__DisplayClass38_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004E15 RID: 19989
				// (get) Token: 0x06010054 RID: 65620 RVA: 0x003CE90C File Offset: 0x003CCB0C
				// (set) Token: 0x06010055 RID: 65621 RVA: 0x00079798 File Offset: 0x00077998
				public unsafe Eye.EyeLidConfiguration _start_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__start_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__start_5__2)) = value;
					}
				}

				// Token: 0x17004E16 RID: 19990
				// (get) Token: 0x06010056 RID: 65622 RVA: 0x003CE934 File Offset: 0x003CCB34
				// (set) Token: 0x06010057 RID: 65623 RVA: 0x000797B3 File Offset: 0x000779B3
				public unsafe Eye.EyeLidConfiguration _end_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__end_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__end_5__3)) = value;
					}
				}

				// Token: 0x17004E17 RID: 19991
				// (get) Token: 0x06010058 RID: 65624 RVA: 0x003CE95C File Offset: 0x003CCB5C
				// (set) Token: 0x06010059 RID: 65625 RVA: 0x000797CE File Offset: 0x000779CE
				public unsafe float _holdTime_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__holdTime_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__holdTime_5__4)) = value;
					}
				}

				// Token: 0x17004E18 RID: 19992
				// (get) Token: 0x0601005A RID: 65626 RVA: 0x003CE984 File Offset: 0x003CCB84
				// (set) Token: 0x0601005B RID: 65627 RVA: 0x000797E9 File Offset: 0x000779E9
				public unsafe float _duration_5__5
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__duration_5__5);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__duration_5__5)) = value;
					}
				}

				// Token: 0x17004E19 RID: 19993
				// (get) Token: 0x0601005C RID: 65628 RVA: 0x003CE9AC File Offset: 0x003CCBAC
				// (set) Token: 0x0601005D RID: 65629 RVA: 0x00079804 File Offset: 0x00077A04
				public unsafe float _i_5__6
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__i_5__6);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__i_5__6)) = value;
					}
				}

				// Token: 0x0400ACA0 RID: 44192
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400ACA1 RID: 44193
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400ACA2 RID: 44194
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400ACA3 RID: 44195
				private static readonly IntPtr NativeFieldInfoPtr__start_5__2;

				// Token: 0x0400ACA4 RID: 44196
				private static readonly IntPtr NativeFieldInfoPtr__end_5__3;

				// Token: 0x0400ACA5 RID: 44197
				private static readonly IntPtr NativeFieldInfoPtr__holdTime_5__4;

				// Token: 0x0400ACA6 RID: 44198
				private static readonly IntPtr NativeFieldInfoPtr__duration_5__5;

				// Token: 0x0400ACA7 RID: 44199
				private static readonly IntPtr NativeFieldInfoPtr__i_5__6;

				// Token: 0x0400ACA8 RID: 44200
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400ACA9 RID: 44201
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400ACAA RID: 44202
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400ACAB RID: 44203
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400ACAC RID: 44204
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400ACAD RID: 44205
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
