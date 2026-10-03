using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.UI.Input;
using Il2CppScheduleOne.Vehicles;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000770 RID: 1904
	public class VehicleCanvas : Singleton<VehicleCanvas>
	{
		// Token: 0x0600B92F RID: 47407 RVA: 0x002FBE70 File Offset: 0x002FA070
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleCanvas()
		{
			Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "VehicleCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr);
			VehicleCanvas.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, "Canvas");
			VehicleCanvas.NativeFieldInfoPtr_SpeedText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, "SpeedText");
			VehicleCanvas.NativeFieldInfoPtr_VehiclePrompts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, "VehiclePrompts");
			VehicleCanvas.NativeFieldInfoPtr_DriverPrompts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, "DriverPrompts");
			VehicleCanvas.NativeFieldInfoPtr_currentVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, "currentVehicle");
			VehicleCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, 100687499);
			VehicleCanvas.NativeMethodInfoPtr_Subscribe_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, 100687500);
			VehicleCanvas.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, 100687501);
			VehicleCanvas.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, 100687502);
			VehicleCanvas.NativeMethodInfoPtr_VehicleEntered_Private_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, 100687503);
			VehicleCanvas.NativeMethodInfoPtr_VehicleExited_Private_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, 100687504);
			VehicleCanvas.NativeMethodInfoPtr_UpdateSpeedText_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, 100687505);
			VehicleCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, 100687506);
		}

		// Token: 0x0600B930 RID: 47408 RVA: 0x002FBFA4 File Offset: 0x002FA1A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309545, XrefRangeEnd = 309568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B931 RID: 47409 RVA: 0x002FBFE0 File Offset: 0x002FA1E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309568, XrefRangeEnd = 309587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Subscribe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCanvas.NativeMethodInfoPtr_Subscribe_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B932 RID: 47410 RVA: 0x002FC014 File Offset: 0x002FA214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309587, XrefRangeEnd = 309606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCanvas.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B933 RID: 47411 RVA: 0x002FC048 File Offset: 0x002FA248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309606, XrefRangeEnd = 309611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCanvas.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B934 RID: 47412 RVA: 0x002FC07C File Offset: 0x002FA27C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309611, XrefRangeEnd = 309616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VehicleEntered(LandVehicle veh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(veh);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCanvas.NativeMethodInfoPtr_VehicleEntered_Private_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B935 RID: 47413 RVA: 0x002FC0C0 File Offset: 0x002FA2C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309616, XrefRangeEnd = 309621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VehicleExited(LandVehicle veh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(veh);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCanvas.NativeMethodInfoPtr_VehicleExited_Private_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B936 RID: 47414 RVA: 0x002FC104 File Offset: 0x002FA304
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 309631, RefRangeEnd = 309633, XrefRangeStart = 309621, XrefRangeEnd = 309631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSpeedText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCanvas.NativeMethodInfoPtr_UpdateSpeedText_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B937 RID: 47415 RVA: 0x002FC138 File Offset: 0x002FA338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309633, XrefRangeEnd = 309636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B938 RID: 47416 RVA: 0x000562C2 File Offset: 0x000544C2
		public VehicleCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170037F2 RID: 14322
		// (get) Token: 0x0600B939 RID: 47417 RVA: 0x002FC174 File Offset: 0x002FA374
		// (set) Token: 0x0600B93A RID: 47418 RVA: 0x000562CB File Offset: 0x000544CB
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCanvas.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCanvas.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037F3 RID: 14323
		// (get) Token: 0x0600B93B RID: 47419 RVA: 0x002FC1A4 File Offset: 0x002FA3A4
		// (set) Token: 0x0600B93C RID: 47420 RVA: 0x000562EA File Offset: 0x000544EA
		public unsafe TextMeshProUGUI SpeedText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCanvas.NativeFieldInfoPtr_SpeedText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCanvas.NativeFieldInfoPtr_SpeedText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037F4 RID: 14324
		// (get) Token: 0x0600B93D RID: 47421 RVA: 0x002FC1D4 File Offset: 0x002FA3D4
		// (set) Token: 0x0600B93E RID: 47422 RVA: 0x00056309 File Offset: 0x00054509
		public unsafe InputPromptsData VehiclePrompts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCanvas.NativeFieldInfoPtr_VehiclePrompts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPromptsData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCanvas.NativeFieldInfoPtr_VehiclePrompts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037F5 RID: 14325
		// (get) Token: 0x0600B93F RID: 47423 RVA: 0x002FC204 File Offset: 0x002FA404
		// (set) Token: 0x0600B940 RID: 47424 RVA: 0x00056328 File Offset: 0x00054528
		public unsafe InputPromptsData DriverPrompts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCanvas.NativeFieldInfoPtr_DriverPrompts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPromptsData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCanvas.NativeFieldInfoPtr_DriverPrompts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037F6 RID: 14326
		// (get) Token: 0x0600B941 RID: 47425 RVA: 0x002FC234 File Offset: 0x002FA434
		// (set) Token: 0x0600B942 RID: 47426 RVA: 0x00056347 File Offset: 0x00054547
		public unsafe LandVehicle currentVehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCanvas.NativeFieldInfoPtr_currentVehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCanvas.NativeFieldInfoPtr_currentVehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007F0D RID: 32525
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04007F0E RID: 32526
		private static readonly IntPtr NativeFieldInfoPtr_SpeedText;

		// Token: 0x04007F0F RID: 32527
		private static readonly IntPtr NativeFieldInfoPtr_VehiclePrompts;

		// Token: 0x04007F10 RID: 32528
		private static readonly IntPtr NativeFieldInfoPtr_DriverPrompts;

		// Token: 0x04007F11 RID: 32529
		private static readonly IntPtr NativeFieldInfoPtr_currentVehicle;

		// Token: 0x04007F12 RID: 32530
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04007F13 RID: 32531
		private static readonly IntPtr NativeMethodInfoPtr_Subscribe_Private_Void_0;

		// Token: 0x04007F14 RID: 32532
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04007F15 RID: 32533
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04007F16 RID: 32534
		private static readonly IntPtr NativeMethodInfoPtr_VehicleEntered_Private_Void_LandVehicle_0;

		// Token: 0x04007F17 RID: 32535
		private static readonly IntPtr NativeMethodInfoPtr_VehicleExited_Private_Void_LandVehicle_0;

		// Token: 0x04007F18 RID: 32536
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSpeedText_Private_Void_0;

		// Token: 0x04007F19 RID: 32537
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
