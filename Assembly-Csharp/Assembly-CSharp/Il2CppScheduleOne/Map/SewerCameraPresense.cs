using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Tools;
using UnityEngine;
using UnityEngine.Rendering;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020002C6 RID: 710
	public class SewerCameraPresense : Singleton<SewerCameraPresense>
	{
		// Token: 0x0600373A RID: 14138 RVA: 0x001328A8 File Offset: 0x00130AA8
		// Note: this type is marked as 'beforefieldinit'.
		static SewerCameraPresense()
		{
			Il2CppClassPointerStore<SewerCameraPresense>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "SewerCameraPresense");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SewerCameraPresense>.NativeClassPtr);
			SewerCameraPresense.NativeFieldInfoPtr__CameraPresenceInSewerArea_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerCameraPresense>.NativeClassPtr, "<CameraPresenceInSewerArea>k__BackingField");
			SewerCameraPresense.NativeFieldInfoPtr__SmoothedCameraPresenceInSewerArea_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerCameraPresense>.NativeClassPtr, "<SmoothedCameraPresenceInSewerArea>k__BackingField");
			SewerCameraPresense.NativeFieldInfoPtr_FullPresenseVolumesContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerCameraPresense>.NativeClassPtr, "FullPresenseVolumesContainer");
			SewerCameraPresense.NativeFieldInfoPtr_FadeVolumesContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerCameraPresense>.NativeClassPtr, "FadeVolumesContainer");
			SewerCameraPresense.NativeFieldInfoPtr_SewerPPVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerCameraPresense>.NativeClassPtr, "SewerPPVolume");
			SewerCameraPresense.NativeFieldInfoPtr_fullPresenceVolumes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerCameraPresense>.NativeClassPtr, "fullPresenceVolumes");
			SewerCameraPresense.NativeFieldInfoPtr_fadeVolumes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerCameraPresense>.NativeClassPtr, "fadeVolumes");
			SewerCameraPresense.NativeMethodInfoPtr_get_CameraPresenceInSewerArea_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerCameraPresense>.NativeClassPtr, 100670262);
			SewerCameraPresense.NativeMethodInfoPtr_set_CameraPresenceInSewerArea_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerCameraPresense>.NativeClassPtr, 100670263);
			SewerCameraPresense.NativeMethodInfoPtr_get_SmoothedCameraPresenceInSewerArea_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerCameraPresense>.NativeClassPtr, 100670264);
			SewerCameraPresense.NativeMethodInfoPtr_set_SmoothedCameraPresenceInSewerArea_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerCameraPresense>.NativeClassPtr, 100670265);
			SewerCameraPresense.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerCameraPresense>.NativeClassPtr, 100670266);
			SewerCameraPresense.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerCameraPresense>.NativeClassPtr, 100670267);
			SewerCameraPresense.NativeMethodInfoPtr_UpdatePresense_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerCameraPresense>.NativeClassPtr, 100670268);
			SewerCameraPresense.NativeMethodInfoPtr_IsPointInSewerArea_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerCameraPresense>.NativeClassPtr, 100670269);
			SewerCameraPresense.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerCameraPresense>.NativeClassPtr, 100670270);
		}

		// Token: 0x17001180 RID: 4480
		// (get) Token: 0x0600373B RID: 14139 RVA: 0x00132A18 File Offset: 0x00130C18
		// (set) Token: 0x0600373C RID: 14140 RVA: 0x00132A54 File Offset: 0x00130C54
		public unsafe float CameraPresenceInSewerArea
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 55725, RefRangeEnd = 55726, XrefRangeStart = 55725, XrefRangeEnd = 55726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerCameraPresense.NativeMethodInfoPtr_get_CameraPresenceInSewerArea_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerCameraPresense.NativeMethodInfoPtr_set_CameraPresenceInSewerArea_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001181 RID: 4481
		// (get) Token: 0x0600373D RID: 14141 RVA: 0x00132A94 File Offset: 0x00130C94
		// (set) Token: 0x0600373E RID: 14142 RVA: 0x00132AD0 File Offset: 0x00130CD0
		public unsafe float SmoothedCameraPresenceInSewerArea
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerCameraPresense.NativeMethodInfoPtr_get_SmoothedCameraPresenceInSewerArea_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 126089, RefRangeEnd = 126091, XrefRangeStart = 126089, XrefRangeEnd = 126091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerCameraPresense.NativeMethodInfoPtr_set_SmoothedCameraPresenceInSewerArea_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600373F RID: 14143 RVA: 0x00132B10 File Offset: 0x00130D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143051, XrefRangeEnd = 143063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SewerCameraPresense.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003740 RID: 14144 RVA: 0x00132B4C File Offset: 0x00130D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143063, XrefRangeEnd = 143066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerCameraPresense.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003741 RID: 14145 RVA: 0x00132B80 File Offset: 0x00130D80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 143077, RefRangeEnd = 143078, XrefRangeStart = 143066, XrefRangeEnd = 143077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePresense()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerCameraPresense.NativeMethodInfoPtr_UpdatePresense_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003742 RID: 14146 RVA: 0x00132BB4 File Offset: 0x00130DB4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 143080, RefRangeEnd = 143083, XrefRangeStart = 143078, XrefRangeEnd = 143080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPointInSewerArea(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerCameraPresense.NativeMethodInfoPtr_IsPointInSewerArea_Public_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003743 RID: 14147 RVA: 0x00132C00 File Offset: 0x00130E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143083, XrefRangeEnd = 143086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SewerCameraPresense() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SewerCameraPresense>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerCameraPresense.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003744 RID: 14148 RVA: 0x0001C1AE File Offset: 0x0001A3AE
		public SewerCameraPresense(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001179 RID: 4473
		// (get) Token: 0x06003745 RID: 14149 RVA: 0x00132C3C File Offset: 0x00130E3C
		// (set) Token: 0x06003746 RID: 14150 RVA: 0x0001C1B7 File Offset: 0x0001A3B7
		public unsafe float _CameraPresenceInSewerArea_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerCameraPresense.NativeFieldInfoPtr__CameraPresenceInSewerArea_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerCameraPresense.NativeFieldInfoPtr__CameraPresenceInSewerArea_k__BackingField)) = value;
			}
		}

		// Token: 0x1700117A RID: 4474
		// (get) Token: 0x06003747 RID: 14151 RVA: 0x00132C64 File Offset: 0x00130E64
		// (set) Token: 0x06003748 RID: 14152 RVA: 0x0001C1D2 File Offset: 0x0001A3D2
		public unsafe float _SmoothedCameraPresenceInSewerArea_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerCameraPresense.NativeFieldInfoPtr__SmoothedCameraPresenceInSewerArea_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerCameraPresense.NativeFieldInfoPtr__SmoothedCameraPresenceInSewerArea_k__BackingField)) = value;
			}
		}

		// Token: 0x1700117B RID: 4475
		// (get) Token: 0x06003749 RID: 14153 RVA: 0x00132C8C File Offset: 0x00130E8C
		// (set) Token: 0x0600374A RID: 14154 RVA: 0x0001C1ED File Offset: 0x0001A3ED
		public unsafe Transform FullPresenseVolumesContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerCameraPresense.NativeFieldInfoPtr_FullPresenseVolumesContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerCameraPresense.NativeFieldInfoPtr_FullPresenseVolumesContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700117C RID: 4476
		// (get) Token: 0x0600374B RID: 14155 RVA: 0x00132CBC File Offset: 0x00130EBC
		// (set) Token: 0x0600374C RID: 14156 RVA: 0x0001C20C File Offset: 0x0001A40C
		public unsafe Transform FadeVolumesContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerCameraPresense.NativeFieldInfoPtr_FadeVolumesContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerCameraPresense.NativeFieldInfoPtr_FadeVolumesContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700117D RID: 4477
		// (get) Token: 0x0600374D RID: 14157 RVA: 0x00132CEC File Offset: 0x00130EEC
		// (set) Token: 0x0600374E RID: 14158 RVA: 0x0001C22B File Offset: 0x0001A42B
		public unsafe Volume SewerPPVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerCameraPresense.NativeFieldInfoPtr_SewerPPVolume);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Volume>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerCameraPresense.NativeFieldInfoPtr_SewerPPVolume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700117E RID: 4478
		// (get) Token: 0x0600374F RID: 14159 RVA: 0x00132D1C File Offset: 0x00130F1C
		// (set) Token: 0x06003750 RID: 14160 RVA: 0x0001C24A File Offset: 0x0001A44A
		public unsafe Il2CppReferenceArray<BoxCollider> fullPresenceVolumes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerCameraPresense.NativeFieldInfoPtr_fullPresenceVolumes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BoxCollider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerCameraPresense.NativeFieldInfoPtr_fullPresenceVolumes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700117F RID: 4479
		// (get) Token: 0x06003751 RID: 14161 RVA: 0x00132D4C File Offset: 0x00130F4C
		// (set) Token: 0x06003752 RID: 14162 RVA: 0x0001C269 File Offset: 0x0001A469
		public unsafe Il2CppReferenceArray<FadeVolume> fadeVolumes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerCameraPresense.NativeFieldInfoPtr_fadeVolumes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FadeVolume>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerCameraPresense.NativeFieldInfoPtr_fadeVolumes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040024EF RID: 9455
		private static readonly IntPtr NativeFieldInfoPtr__CameraPresenceInSewerArea_k__BackingField;

		// Token: 0x040024F0 RID: 9456
		private static readonly IntPtr NativeFieldInfoPtr__SmoothedCameraPresenceInSewerArea_k__BackingField;

		// Token: 0x040024F1 RID: 9457
		private static readonly IntPtr NativeFieldInfoPtr_FullPresenseVolumesContainer;

		// Token: 0x040024F2 RID: 9458
		private static readonly IntPtr NativeFieldInfoPtr_FadeVolumesContainer;

		// Token: 0x040024F3 RID: 9459
		private static readonly IntPtr NativeFieldInfoPtr_SewerPPVolume;

		// Token: 0x040024F4 RID: 9460
		private static readonly IntPtr NativeFieldInfoPtr_fullPresenceVolumes;

		// Token: 0x040024F5 RID: 9461
		private static readonly IntPtr NativeFieldInfoPtr_fadeVolumes;

		// Token: 0x040024F6 RID: 9462
		private static readonly IntPtr NativeMethodInfoPtr_get_CameraPresenceInSewerArea_Public_get_Single_0;

		// Token: 0x040024F7 RID: 9463
		private static readonly IntPtr NativeMethodInfoPtr_set_CameraPresenceInSewerArea_Private_set_Void_Single_0;

		// Token: 0x040024F8 RID: 9464
		private static readonly IntPtr NativeMethodInfoPtr_get_SmoothedCameraPresenceInSewerArea_Public_get_Single_0;

		// Token: 0x040024F9 RID: 9465
		private static readonly IntPtr NativeMethodInfoPtr_set_SmoothedCameraPresenceInSewerArea_Private_set_Void_Single_0;

		// Token: 0x040024FA RID: 9466
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040024FB RID: 9467
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040024FC RID: 9468
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePresense_Private_Void_0;

		// Token: 0x040024FD RID: 9469
		private static readonly IntPtr NativeMethodInfoPtr_IsPointInSewerArea_Public_Boolean_Vector3_0;

		// Token: 0x040024FE RID: 9470
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
