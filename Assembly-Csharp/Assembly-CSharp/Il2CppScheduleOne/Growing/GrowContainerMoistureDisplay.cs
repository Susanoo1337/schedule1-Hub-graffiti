using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x02000515 RID: 1301
	public class GrowContainerMoistureDisplay : MonoBehaviour
	{
		// Token: 0x060075F5 RID: 30197 RVA: 0x0020E9F8 File Offset: 0x0020CBF8
		// Note: this type is marked as 'beforefieldinit'.
		static GrowContainerMoistureDisplay()
		{
			Il2CppClassPointerStore<GrowContainerMoistureDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "GrowContainerMoistureDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GrowContainerMoistureDisplay>.NativeClassPtr);
			GrowContainerMoistureDisplay.NativeFieldInfoPtr_MaxCameraDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerMoistureDisplay>.NativeClassPtr, "MaxCameraDistance");
			GrowContainerMoistureDisplay.NativeFieldInfoPtr_MinCameraDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerMoistureDisplay>.NativeClassPtr, "MinCameraDistance");
			GrowContainerMoistureDisplay.NativeFieldInfoPtr_FadeInDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerMoistureDisplay>.NativeClassPtr, "FadeInDistance");
			GrowContainerMoistureDisplay.NativeFieldInfoPtr_FadeOutDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerMoistureDisplay>.NativeClassPtr, "FadeOutDistance");
			GrowContainerMoistureDisplay.NativeFieldInfoPtr_SnapToRightAngles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerMoistureDisplay>.NativeClassPtr, "SnapToRightAngles");
			GrowContainerMoistureDisplay.NativeFieldInfoPtr_GrowContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerMoistureDisplay>.NativeClassPtr, "GrowContainer");
			GrowContainerMoistureDisplay.NativeFieldInfoPtr_WaterCanvasContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerMoistureDisplay>.NativeClassPtr, "WaterCanvasContainer");
			GrowContainerMoistureDisplay.NativeFieldInfoPtr_WaterLevelCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerMoistureDisplay>.NativeClassPtr, "WaterLevelCanvas");
			GrowContainerMoistureDisplay.NativeFieldInfoPtr_WaterLevelCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerMoistureDisplay>.NativeClassPtr, "WaterLevelCanvasGroup");
			GrowContainerMoistureDisplay.NativeFieldInfoPtr_WaterLevelSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerMoistureDisplay>.NativeClassPtr, "WaterLevelSlider");
			GrowContainerMoistureDisplay.NativeFieldInfoPtr_NoWaterIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerMoistureDisplay>.NativeClassPtr, "NoWaterIcon");
			GrowContainerMoistureDisplay.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerMoistureDisplay>.NativeClassPtr, 100678475);
			GrowContainerMoistureDisplay.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerMoistureDisplay>.NativeClassPtr, 100678476);
			GrowContainerMoistureDisplay.NativeMethodInfoPtr_UpdateCanvas_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerMoistureDisplay>.NativeClassPtr, 100678477);
			GrowContainerMoistureDisplay.NativeMethodInfoPtr_UpdateCanvasContents_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerMoistureDisplay>.NativeClassPtr, 100678478);
			GrowContainerMoistureDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerMoistureDisplay>.NativeClassPtr, 100678479);
		}

		// Token: 0x060075F6 RID: 30198 RVA: 0x0020EB68 File Offset: 0x0020CD68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 229661, RefRangeEnd = 229663, XrefRangeStart = 229658, XrefRangeEnd = 229661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainerMoistureDisplay.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075F7 RID: 30199 RVA: 0x0020EBA4 File Offset: 0x0020CDA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229663, XrefRangeEnd = 229664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerMoistureDisplay.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075F8 RID: 30200 RVA: 0x0020EBD8 File Offset: 0x0020CDD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 229732, RefRangeEnd = 229733, XrefRangeStart = 229664, XrefRangeEnd = 229732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCanvas()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerMoistureDisplay.NativeMethodInfoPtr_UpdateCanvas_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075F9 RID: 30201 RVA: 0x0020EC0C File Offset: 0x0020CE0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 229736, RefRangeEnd = 229738, XrefRangeStart = 229733, XrefRangeEnd = 229736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateCanvasContents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainerMoistureDisplay.NativeMethodInfoPtr_UpdateCanvasContents_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075FA RID: 30202 RVA: 0x0020EC48 File Offset: 0x0020CE48
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GrowContainerMoistureDisplay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GrowContainerMoistureDisplay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerMoistureDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075FB RID: 30203 RVA: 0x00038429 File Offset: 0x00036629
		public GrowContainerMoistureDisplay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700246F RID: 9327
		// (get) Token: 0x060075FC RID: 30204 RVA: 0x0020EC84 File Offset: 0x0020CE84
		// (set) Token: 0x060075FD RID: 30205 RVA: 0x00038432 File Offset: 0x00036632
		public unsafe static float MaxCameraDistance
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GrowContainerMoistureDisplay.NativeFieldInfoPtr_MaxCameraDistance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GrowContainerMoistureDisplay.NativeFieldInfoPtr_MaxCameraDistance, (void*)(&value));
			}
		}

		// Token: 0x17002470 RID: 9328
		// (get) Token: 0x060075FE RID: 30206 RVA: 0x0020ECA0 File Offset: 0x0020CEA0
		// (set) Token: 0x060075FF RID: 30207 RVA: 0x00038440 File Offset: 0x00036640
		public unsafe static float MinCameraDistance
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GrowContainerMoistureDisplay.NativeFieldInfoPtr_MinCameraDistance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GrowContainerMoistureDisplay.NativeFieldInfoPtr_MinCameraDistance, (void*)(&value));
			}
		}

		// Token: 0x17002471 RID: 9329
		// (get) Token: 0x06007600 RID: 30208 RVA: 0x0020ECBC File Offset: 0x0020CEBC
		// (set) Token: 0x06007601 RID: 30209 RVA: 0x0003844E File Offset: 0x0003664E
		public unsafe static float FadeInDistance
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GrowContainerMoistureDisplay.NativeFieldInfoPtr_FadeInDistance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GrowContainerMoistureDisplay.NativeFieldInfoPtr_FadeInDistance, (void*)(&value));
			}
		}

		// Token: 0x17002472 RID: 9330
		// (get) Token: 0x06007602 RID: 30210 RVA: 0x0020ECD8 File Offset: 0x0020CED8
		// (set) Token: 0x06007603 RID: 30211 RVA: 0x0003845C File Offset: 0x0003665C
		public unsafe static float FadeOutDistance
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GrowContainerMoistureDisplay.NativeFieldInfoPtr_FadeOutDistance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GrowContainerMoistureDisplay.NativeFieldInfoPtr_FadeOutDistance, (void*)(&value));
			}
		}

		// Token: 0x17002473 RID: 9331
		// (get) Token: 0x06007604 RID: 30212 RVA: 0x0020ECF4 File Offset: 0x0020CEF4
		// (set) Token: 0x06007605 RID: 30213 RVA: 0x0003846A File Offset: 0x0003666A
		public unsafe bool SnapToRightAngles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerMoistureDisplay.NativeFieldInfoPtr_SnapToRightAngles);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerMoistureDisplay.NativeFieldInfoPtr_SnapToRightAngles)) = value;
			}
		}

		// Token: 0x17002474 RID: 9332
		// (get) Token: 0x06007606 RID: 30214 RVA: 0x0020ED1C File Offset: 0x0020CF1C
		// (set) Token: 0x06007607 RID: 30215 RVA: 0x00038485 File Offset: 0x00036685
		public unsafe GrowContainer GrowContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerMoistureDisplay.NativeFieldInfoPtr_GrowContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GrowContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerMoistureDisplay.NativeFieldInfoPtr_GrowContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002475 RID: 9333
		// (get) Token: 0x06007608 RID: 30216 RVA: 0x0020ED4C File Offset: 0x0020CF4C
		// (set) Token: 0x06007609 RID: 30217 RVA: 0x000384A4 File Offset: 0x000366A4
		public unsafe Transform WaterCanvasContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerMoistureDisplay.NativeFieldInfoPtr_WaterCanvasContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerMoistureDisplay.NativeFieldInfoPtr_WaterCanvasContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002476 RID: 9334
		// (get) Token: 0x0600760A RID: 30218 RVA: 0x0020ED7C File Offset: 0x0020CF7C
		// (set) Token: 0x0600760B RID: 30219 RVA: 0x000384C3 File Offset: 0x000366C3
		public unsafe Canvas WaterLevelCanvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerMoistureDisplay.NativeFieldInfoPtr_WaterLevelCanvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerMoistureDisplay.NativeFieldInfoPtr_WaterLevelCanvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002477 RID: 9335
		// (get) Token: 0x0600760C RID: 30220 RVA: 0x0020EDAC File Offset: 0x0020CFAC
		// (set) Token: 0x0600760D RID: 30221 RVA: 0x000384E2 File Offset: 0x000366E2
		public unsafe CanvasGroup WaterLevelCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerMoistureDisplay.NativeFieldInfoPtr_WaterLevelCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerMoistureDisplay.NativeFieldInfoPtr_WaterLevelCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002478 RID: 9336
		// (get) Token: 0x0600760E RID: 30222 RVA: 0x0020EDDC File Offset: 0x0020CFDC
		// (set) Token: 0x0600760F RID: 30223 RVA: 0x00038501 File Offset: 0x00036701
		public unsafe Slider WaterLevelSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerMoistureDisplay.NativeFieldInfoPtr_WaterLevelSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerMoistureDisplay.NativeFieldInfoPtr_WaterLevelSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002479 RID: 9337
		// (get) Token: 0x06007610 RID: 30224 RVA: 0x0020EE0C File Offset: 0x0020D00C
		// (set) Token: 0x06007611 RID: 30225 RVA: 0x00038520 File Offset: 0x00036720
		public unsafe GameObject NoWaterIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerMoistureDisplay.NativeFieldInfoPtr_NoWaterIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerMoistureDisplay.NativeFieldInfoPtr_NoWaterIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005065 RID: 20581
		private static readonly IntPtr NativeFieldInfoPtr_MaxCameraDistance;

		// Token: 0x04005066 RID: 20582
		private static readonly IntPtr NativeFieldInfoPtr_MinCameraDistance;

		// Token: 0x04005067 RID: 20583
		private static readonly IntPtr NativeFieldInfoPtr_FadeInDistance;

		// Token: 0x04005068 RID: 20584
		private static readonly IntPtr NativeFieldInfoPtr_FadeOutDistance;

		// Token: 0x04005069 RID: 20585
		private static readonly IntPtr NativeFieldInfoPtr_SnapToRightAngles;

		// Token: 0x0400506A RID: 20586
		private static readonly IntPtr NativeFieldInfoPtr_GrowContainer;

		// Token: 0x0400506B RID: 20587
		private static readonly IntPtr NativeFieldInfoPtr_WaterCanvasContainer;

		// Token: 0x0400506C RID: 20588
		private static readonly IntPtr NativeFieldInfoPtr_WaterLevelCanvas;

		// Token: 0x0400506D RID: 20589
		private static readonly IntPtr NativeFieldInfoPtr_WaterLevelCanvasGroup;

		// Token: 0x0400506E RID: 20590
		private static readonly IntPtr NativeFieldInfoPtr_WaterLevelSlider;

		// Token: 0x0400506F RID: 20591
		private static readonly IntPtr NativeFieldInfoPtr_NoWaterIcon;

		// Token: 0x04005070 RID: 20592
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04005071 RID: 20593
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04005072 RID: 20594
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCanvas_Private_Void_0;

		// Token: 0x04005073 RID: 20595
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCanvasContents_Protected_Virtual_New_Void_0;

		// Token: 0x04005074 RID: 20596
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
