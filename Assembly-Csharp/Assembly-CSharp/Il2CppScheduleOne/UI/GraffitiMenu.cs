using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Graffiti;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000737 RID: 1847
	public class GraffitiMenu : Singleton<GraffitiMenu>
	{
		// Token: 0x0600B21F RID: 45599 RVA: 0x002E74C8 File Offset: 0x002E56C8
		// Note: this type is marked as 'beforefieldinit'.
		static GraffitiMenu()
		{
			Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "GraffitiMenu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr);
			GraffitiMenu.NativeFieldInfoPtr_DefaultColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr, "DefaultColor");
			GraffitiMenu.NativeFieldInfoPtr_DefaultStrokeSizeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr, "DefaultStrokeSizeIndex");
			GraffitiMenu.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr, "Canvas");
			GraffitiMenu.NativeFieldInfoPtr_ColorButtonContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr, "ColorButtonContainer");
			GraffitiMenu.NativeFieldInfoPtr_ClearButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr, "ClearButton");
			GraffitiMenu.NativeFieldInfoPtr_DoneButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr, "DoneButton");
			GraffitiMenu.NativeFieldInfoPtr_ConfirmPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr, "ConfirmPanel");
			GraffitiMenu.NativeFieldInfoPtr_ConfirmButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr, "ConfirmButton");
			GraffitiMenu.NativeFieldInfoPtr_CancelButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr, "CancelButton");
			GraffitiMenu.NativeFieldInfoPtr_UndoButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr, "UndoButton");
			GraffitiMenu.NativeFieldInfoPtr_RemainigPaintContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr, "RemainigPaintContainer");
			GraffitiMenu.NativeFieldInfoPtr_RemainingPaintSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr, "RemainingPaintSlider");
			GraffitiMenu.NativeFieldInfoPtr_RemainingPaintImages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr, "RemainingPaintImages");
			GraffitiMenu.NativeFieldInfoPtr_RemainingPaintLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr, "RemainingPaintLabel");
			GraffitiMenu.NativeFieldInfoPtr_WeightButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr, "WeightButtons");
			GraffitiMenu.NativeFieldInfoPtr_Screen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr, "Screen");
			GraffitiMenu.NativeFieldInfoPtr_ColorPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr, "ColorPanel");
			GraffitiMenu.NativeFieldInfoPtr_WeightPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr, "WeightPanel");
			GraffitiMenu.NativeFieldInfoPtr_ColorButtonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr, "ColorButtonPrefab");
			GraffitiMenu.NativeFieldInfoPtr_onColorSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr, "onColorSelected");
			GraffitiMenu.NativeFieldInfoPtr_onWeightSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr, "onWeightSelected");
			GraffitiMenu.NativeFieldInfoPtr_onClearClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr, "onClearClicked");
			GraffitiMenu.NativeFieldInfoPtr_onDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr, "onDone");
			GraffitiMenu.NativeFieldInfoPtr_onUndoClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr, "onUndoClicked");
			GraffitiMenu.NativeFieldInfoPtr_onConfirmClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr, "onConfirmClicked");
			GraffitiMenu.NativeFieldInfoPtr_colorButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr, "colorButtons");
			GraffitiMenu.NativeFieldInfoPtr_activeSurface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr, "activeSurface");
			GraffitiMenu.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr, 100686717);
			GraffitiMenu.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr, 100686718);
			GraffitiMenu.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr, 100686719);
			GraffitiMenu.NativeMethodInfoPtr_ShowConfirmPanel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr, 100686720);
			GraffitiMenu.NativeMethodInfoPtr_SelectColor_Private_Void_ESprayColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr, 100686721);
			GraffitiMenu.NativeMethodInfoPtr_WeightButtonClicked_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr, 100686722);
			GraffitiMenu.NativeMethodInfoPtr_UpdateRemainingPaintIndicator_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr, 100686723);
			GraffitiMenu.NativeMethodInfoPtr_ClearClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr, 100686724);
			GraffitiMenu.NativeMethodInfoPtr_UndoClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr, 100686725);
			GraffitiMenu.NativeMethodInfoPtr_DoneClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr, 100686726);
			GraffitiMenu.NativeMethodInfoPtr_ConfirmClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr, 100686727);
			GraffitiMenu.NativeMethodInfoPtr_CancelClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr, 100686728);
			GraffitiMenu.NativeMethodInfoPtr_SetActiveSurface_Public_Void_SpraySurface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr, 100686729);
			GraffitiMenu.NativeMethodInfoPtr_ClearActiveSurface_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr, 100686730);
			GraffitiMenu.NativeMethodInfoPtr_UpdateButtons_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr, 100686731);
			GraffitiMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr, 100686732);
		}

		// Token: 0x0600B220 RID: 45600 RVA: 0x002E7854 File Offset: 0x002E5A54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301737, XrefRangeEnd = 301828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GraffitiMenu.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B221 RID: 45601 RVA: 0x002E7890 File Offset: 0x002E5A90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 301863, RefRangeEnd = 301864, XrefRangeStart = 301828, XrefRangeEnd = 301863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiMenu.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B222 RID: 45602 RVA: 0x002E78C4 File Offset: 0x002E5AC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 301872, RefRangeEnd = 301873, XrefRangeStart = 301864, XrefRangeEnd = 301872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiMenu.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B223 RID: 45603 RVA: 0x002E78F8 File Offset: 0x002E5AF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 301876, RefRangeEnd = 301878, XrefRangeStart = 301873, XrefRangeEnd = 301876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowConfirmPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiMenu.NativeMethodInfoPtr_ShowConfirmPanel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B224 RID: 45604 RVA: 0x002E792C File Offset: 0x002E5B2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 301901, RefRangeEnd = 301903, XrefRangeStart = 301878, XrefRangeEnd = 301901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectColor(ESprayColor color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiMenu.NativeMethodInfoPtr_SelectColor_Private_Void_ESprayColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B225 RID: 45605 RVA: 0x002E796C File Offset: 0x002E5B6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 301915, RefRangeEnd = 301917, XrefRangeStart = 301903, XrefRangeEnd = 301915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WeightButtonClicked(int buttonIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref buttonIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiMenu.NativeMethodInfoPtr_WeightButtonClicked_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B226 RID: 45606 RVA: 0x002E79AC File Offset: 0x002E5BAC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 301934, RefRangeEnd = 301938, XrefRangeStart = 301917, XrefRangeEnd = 301934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRemainingPaintIndicator(float remainingPaint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref remainingPaint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiMenu.NativeMethodInfoPtr_UpdateRemainingPaintIndicator_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B227 RID: 45607 RVA: 0x002E79EC File Offset: 0x002E5BEC
		[CallerCount(0)]
		public unsafe void ClearClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiMenu.NativeMethodInfoPtr_ClearClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B228 RID: 45608 RVA: 0x002E7A20 File Offset: 0x002E5C20
		[CallerCount(0)]
		public unsafe void UndoClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiMenu.NativeMethodInfoPtr_UndoClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B229 RID: 45609 RVA: 0x002E7A54 File Offset: 0x002E5C54
		[CallerCount(0)]
		public unsafe void DoneClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiMenu.NativeMethodInfoPtr_DoneClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B22A RID: 45610 RVA: 0x002E7A88 File Offset: 0x002E5C88
		[CallerCount(0)]
		public unsafe void ConfirmClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiMenu.NativeMethodInfoPtr_ConfirmClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B22B RID: 45611 RVA: 0x002E7ABC File Offset: 0x002E5CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301938, XrefRangeEnd = 301941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiMenu.NativeMethodInfoPtr_CancelClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B22C RID: 45612 RVA: 0x002E7AF0 File Offset: 0x002E5CF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 301956, RefRangeEnd = 301957, XrefRangeStart = 301941, XrefRangeEnd = 301956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActiveSurface(SpraySurface surface)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(surface);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiMenu.NativeMethodInfoPtr_SetActiveSurface_Public_Void_SpraySurface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B22D RID: 45613 RVA: 0x002E7B34 File Offset: 0x002E5D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301957, XrefRangeEnd = 301972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearActiveSurface()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiMenu.NativeMethodInfoPtr_ClearActiveSurface_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B22E RID: 45614 RVA: 0x002E7B68 File Offset: 0x002E5D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301972, XrefRangeEnd = 301986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateButtons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiMenu.NativeMethodInfoPtr_UpdateButtons_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B22F RID: 45615 RVA: 0x002E7B9C File Offset: 0x002E5D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301986, XrefRangeEnd = 301996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraffitiMenu() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B230 RID: 45616 RVA: 0x00051E9C File Offset: 0x0005009C
		public GraffitiMenu(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700358B RID: 13707
		// (get) Token: 0x0600B231 RID: 45617 RVA: 0x002E7BD8 File Offset: 0x002E5DD8
		// (set) Token: 0x0600B232 RID: 45618 RVA: 0x00051EA5 File Offset: 0x000500A5
		public unsafe static ESprayColor DefaultColor
		{
			get
			{
				ESprayColor result;
				IL2CPP.il2cpp_field_static_get_value(GraffitiMenu.NativeFieldInfoPtr_DefaultColor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GraffitiMenu.NativeFieldInfoPtr_DefaultColor, (void*)(&value));
			}
		}

		// Token: 0x1700358C RID: 13708
		// (get) Token: 0x0600B233 RID: 45619 RVA: 0x002E7BF4 File Offset: 0x002E5DF4
		// (set) Token: 0x0600B234 RID: 45620 RVA: 0x00051EB3 File Offset: 0x000500B3
		public unsafe static int DefaultStrokeSizeIndex
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(GraffitiMenu.NativeFieldInfoPtr_DefaultStrokeSizeIndex, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GraffitiMenu.NativeFieldInfoPtr_DefaultStrokeSizeIndex, (void*)(&value));
			}
		}

		// Token: 0x1700358D RID: 13709
		// (get) Token: 0x0600B235 RID: 45621 RVA: 0x002E7C10 File Offset: 0x002E5E10
		// (set) Token: 0x0600B236 RID: 45622 RVA: 0x00051EC1 File Offset: 0x000500C1
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700358E RID: 13710
		// (get) Token: 0x0600B237 RID: 45623 RVA: 0x002E7C40 File Offset: 0x002E5E40
		// (set) Token: 0x0600B238 RID: 45624 RVA: 0x00051EE0 File Offset: 0x000500E0
		public unsafe RectTransform ColorButtonContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_ColorButtonContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_ColorButtonContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700358F RID: 13711
		// (get) Token: 0x0600B239 RID: 45625 RVA: 0x002E7C70 File Offset: 0x002E5E70
		// (set) Token: 0x0600B23A RID: 45626 RVA: 0x00051EFF File Offset: 0x000500FF
		public unsafe Button ClearButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_ClearButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_ClearButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003590 RID: 13712
		// (get) Token: 0x0600B23B RID: 45627 RVA: 0x002E7CA0 File Offset: 0x002E5EA0
		// (set) Token: 0x0600B23C RID: 45628 RVA: 0x00051F1E File Offset: 0x0005011E
		public unsafe Button DoneButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_DoneButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_DoneButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003591 RID: 13713
		// (get) Token: 0x0600B23D RID: 45629 RVA: 0x002E7CD0 File Offset: 0x002E5ED0
		// (set) Token: 0x0600B23E RID: 45630 RVA: 0x00051F3D File Offset: 0x0005013D
		public unsafe Transform ConfirmPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_ConfirmPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_ConfirmPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003592 RID: 13714
		// (get) Token: 0x0600B23F RID: 45631 RVA: 0x002E7D00 File Offset: 0x002E5F00
		// (set) Token: 0x0600B240 RID: 45632 RVA: 0x00051F5C File Offset: 0x0005015C
		public unsafe Button ConfirmButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_ConfirmButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_ConfirmButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003593 RID: 13715
		// (get) Token: 0x0600B241 RID: 45633 RVA: 0x002E7D30 File Offset: 0x002E5F30
		// (set) Token: 0x0600B242 RID: 45634 RVA: 0x00051F7B File Offset: 0x0005017B
		public unsafe Button CancelButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_CancelButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_CancelButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003594 RID: 13716
		// (get) Token: 0x0600B243 RID: 45635 RVA: 0x002E7D60 File Offset: 0x002E5F60
		// (set) Token: 0x0600B244 RID: 45636 RVA: 0x00051F9A File Offset: 0x0005019A
		public unsafe Button UndoButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_UndoButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_UndoButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003595 RID: 13717
		// (get) Token: 0x0600B245 RID: 45637 RVA: 0x002E7D90 File Offset: 0x002E5F90
		// (set) Token: 0x0600B246 RID: 45638 RVA: 0x00051FB9 File Offset: 0x000501B9
		public unsafe RectTransform RemainigPaintContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_RemainigPaintContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_RemainigPaintContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003596 RID: 13718
		// (get) Token: 0x0600B247 RID: 45639 RVA: 0x002E7DC0 File Offset: 0x002E5FC0
		// (set) Token: 0x0600B248 RID: 45640 RVA: 0x00051FD8 File Offset: 0x000501D8
		public unsafe Slider RemainingPaintSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_RemainingPaintSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_RemainingPaintSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003597 RID: 13719
		// (get) Token: 0x0600B249 RID: 45641 RVA: 0x002E7DF0 File Offset: 0x002E5FF0
		// (set) Token: 0x0600B24A RID: 45642 RVA: 0x00051FF7 File Offset: 0x000501F7
		public unsafe Il2CppReferenceArray<Image> RemainingPaintImages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_RemainingPaintImages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Image>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_RemainingPaintImages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003598 RID: 13720
		// (get) Token: 0x0600B24B RID: 45643 RVA: 0x002E7E20 File Offset: 0x002E6020
		// (set) Token: 0x0600B24C RID: 45644 RVA: 0x00052016 File Offset: 0x00050216
		public unsafe TextMeshProUGUI RemainingPaintLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_RemainingPaintLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_RemainingPaintLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003599 RID: 13721
		// (get) Token: 0x0600B24D RID: 45645 RVA: 0x002E7E50 File Offset: 0x002E6050
		// (set) Token: 0x0600B24E RID: 45646 RVA: 0x00052035 File Offset: 0x00050235
		public unsafe Il2CppReferenceArray<Button> WeightButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_WeightButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Button>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_WeightButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700359A RID: 13722
		// (get) Token: 0x0600B24F RID: 45647 RVA: 0x002E7E80 File Offset: 0x002E6080
		// (set) Token: 0x0600B250 RID: 45648 RVA: 0x00052054 File Offset: 0x00050254
		public unsafe UIScreen Screen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_Screen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_Screen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700359B RID: 13723
		// (get) Token: 0x0600B251 RID: 45649 RVA: 0x002E7EB0 File Offset: 0x002E60B0
		// (set) Token: 0x0600B252 RID: 45650 RVA: 0x00052073 File Offset: 0x00050273
		public unsafe UIPanel ColorPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_ColorPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_ColorPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700359C RID: 13724
		// (get) Token: 0x0600B253 RID: 45651 RVA: 0x002E7EE0 File Offset: 0x002E60E0
		// (set) Token: 0x0600B254 RID: 45652 RVA: 0x00052092 File Offset: 0x00050292
		public unsafe UIPanel WeightPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_WeightPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_WeightPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700359D RID: 13725
		// (get) Token: 0x0600B255 RID: 45653 RVA: 0x002E7F10 File Offset: 0x002E6110
		// (set) Token: 0x0600B256 RID: 45654 RVA: 0x000520B1 File Offset: 0x000502B1
		public unsafe GameObject ColorButtonPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_ColorButtonPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_ColorButtonPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700359E RID: 13726
		// (get) Token: 0x0600B257 RID: 45655 RVA: 0x002E7F40 File Offset: 0x002E6140
		// (set) Token: 0x0600B258 RID: 45656 RVA: 0x000520D0 File Offset: 0x000502D0
		public unsafe Action<ESprayColor> onColorSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_onColorSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ESprayColor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_onColorSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700359F RID: 13727
		// (get) Token: 0x0600B259 RID: 45657 RVA: 0x002E7F70 File Offset: 0x002E6170
		// (set) Token: 0x0600B25A RID: 45658 RVA: 0x000520EF File Offset: 0x000502EF
		public unsafe Action<byte> onWeightSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_onWeightSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_onWeightSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035A0 RID: 13728
		// (get) Token: 0x0600B25B RID: 45659 RVA: 0x002E7FA0 File Offset: 0x002E61A0
		// (set) Token: 0x0600B25C RID: 45660 RVA: 0x0005210E File Offset: 0x0005030E
		public unsafe Action onClearClicked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_onClearClicked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_onClearClicked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035A1 RID: 13729
		// (get) Token: 0x0600B25D RID: 45661 RVA: 0x002E7FD0 File Offset: 0x002E61D0
		// (set) Token: 0x0600B25E RID: 45662 RVA: 0x0005212D File Offset: 0x0005032D
		public unsafe Action onDone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_onDone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_onDone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035A2 RID: 13730
		// (get) Token: 0x0600B25F RID: 45663 RVA: 0x002E8000 File Offset: 0x002E6200
		// (set) Token: 0x0600B260 RID: 45664 RVA: 0x0005214C File Offset: 0x0005034C
		public unsafe Action onUndoClicked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_onUndoClicked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_onUndoClicked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035A3 RID: 13731
		// (get) Token: 0x0600B261 RID: 45665 RVA: 0x002E8030 File Offset: 0x002E6230
		// (set) Token: 0x0600B262 RID: 45666 RVA: 0x0005216B File Offset: 0x0005036B
		public unsafe Action onConfirmClicked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_onConfirmClicked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_onConfirmClicked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035A4 RID: 13732
		// (get) Token: 0x0600B263 RID: 45667 RVA: 0x002E8060 File Offset: 0x002E6260
		// (set) Token: 0x0600B264 RID: 45668 RVA: 0x0005218A File Offset: 0x0005038A
		public unsafe List<Button> colorButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_colorButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Button>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_colorButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035A5 RID: 13733
		// (get) Token: 0x0600B265 RID: 45669 RVA: 0x002E8090 File Offset: 0x002E6290
		// (set) Token: 0x0600B266 RID: 45670 RVA: 0x000521A9 File Offset: 0x000503A9
		public unsafe SpraySurface activeSurface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_activeSurface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpraySurface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.NativeFieldInfoPtr_activeSurface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007AB2 RID: 31410
		private static readonly IntPtr NativeFieldInfoPtr_DefaultColor;

		// Token: 0x04007AB3 RID: 31411
		private static readonly IntPtr NativeFieldInfoPtr_DefaultStrokeSizeIndex;

		// Token: 0x04007AB4 RID: 31412
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04007AB5 RID: 31413
		private static readonly IntPtr NativeFieldInfoPtr_ColorButtonContainer;

		// Token: 0x04007AB6 RID: 31414
		private static readonly IntPtr NativeFieldInfoPtr_ClearButton;

		// Token: 0x04007AB7 RID: 31415
		private static readonly IntPtr NativeFieldInfoPtr_DoneButton;

		// Token: 0x04007AB8 RID: 31416
		private static readonly IntPtr NativeFieldInfoPtr_ConfirmPanel;

		// Token: 0x04007AB9 RID: 31417
		private static readonly IntPtr NativeFieldInfoPtr_ConfirmButton;

		// Token: 0x04007ABA RID: 31418
		private static readonly IntPtr NativeFieldInfoPtr_CancelButton;

		// Token: 0x04007ABB RID: 31419
		private static readonly IntPtr NativeFieldInfoPtr_UndoButton;

		// Token: 0x04007ABC RID: 31420
		private static readonly IntPtr NativeFieldInfoPtr_RemainigPaintContainer;

		// Token: 0x04007ABD RID: 31421
		private static readonly IntPtr NativeFieldInfoPtr_RemainingPaintSlider;

		// Token: 0x04007ABE RID: 31422
		private static readonly IntPtr NativeFieldInfoPtr_RemainingPaintImages;

		// Token: 0x04007ABF RID: 31423
		private static readonly IntPtr NativeFieldInfoPtr_RemainingPaintLabel;

		// Token: 0x04007AC0 RID: 31424
		private static readonly IntPtr NativeFieldInfoPtr_WeightButtons;

		// Token: 0x04007AC1 RID: 31425
		private static readonly IntPtr NativeFieldInfoPtr_Screen;

		// Token: 0x04007AC2 RID: 31426
		private static readonly IntPtr NativeFieldInfoPtr_ColorPanel;

		// Token: 0x04007AC3 RID: 31427
		private static readonly IntPtr NativeFieldInfoPtr_WeightPanel;

		// Token: 0x04007AC4 RID: 31428
		private static readonly IntPtr NativeFieldInfoPtr_ColorButtonPrefab;

		// Token: 0x04007AC5 RID: 31429
		private static readonly IntPtr NativeFieldInfoPtr_onColorSelected;

		// Token: 0x04007AC6 RID: 31430
		private static readonly IntPtr NativeFieldInfoPtr_onWeightSelected;

		// Token: 0x04007AC7 RID: 31431
		private static readonly IntPtr NativeFieldInfoPtr_onClearClicked;

		// Token: 0x04007AC8 RID: 31432
		private static readonly IntPtr NativeFieldInfoPtr_onDone;

		// Token: 0x04007AC9 RID: 31433
		private static readonly IntPtr NativeFieldInfoPtr_onUndoClicked;

		// Token: 0x04007ACA RID: 31434
		private static readonly IntPtr NativeFieldInfoPtr_onConfirmClicked;

		// Token: 0x04007ACB RID: 31435
		private static readonly IntPtr NativeFieldInfoPtr_colorButtons;

		// Token: 0x04007ACC RID: 31436
		private static readonly IntPtr NativeFieldInfoPtr_activeSurface;

		// Token: 0x04007ACD RID: 31437
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04007ACE RID: 31438
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04007ACF RID: 31439
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04007AD0 RID: 31440
		private static readonly IntPtr NativeMethodInfoPtr_ShowConfirmPanel_Public_Void_0;

		// Token: 0x04007AD1 RID: 31441
		private static readonly IntPtr NativeMethodInfoPtr_SelectColor_Private_Void_ESprayColor_0;

		// Token: 0x04007AD2 RID: 31442
		private static readonly IntPtr NativeMethodInfoPtr_WeightButtonClicked_Private_Void_Int32_0;

		// Token: 0x04007AD3 RID: 31443
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRemainingPaintIndicator_Public_Void_Single_0;

		// Token: 0x04007AD4 RID: 31444
		private static readonly IntPtr NativeMethodInfoPtr_ClearClicked_Private_Void_0;

		// Token: 0x04007AD5 RID: 31445
		private static readonly IntPtr NativeMethodInfoPtr_UndoClicked_Private_Void_0;

		// Token: 0x04007AD6 RID: 31446
		private static readonly IntPtr NativeMethodInfoPtr_DoneClicked_Private_Void_0;

		// Token: 0x04007AD7 RID: 31447
		private static readonly IntPtr NativeMethodInfoPtr_ConfirmClicked_Private_Void_0;

		// Token: 0x04007AD8 RID: 31448
		private static readonly IntPtr NativeMethodInfoPtr_CancelClicked_Private_Void_0;

		// Token: 0x04007AD9 RID: 31449
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveSurface_Public_Void_SpraySurface_0;

		// Token: 0x04007ADA RID: 31450
		private static readonly IntPtr NativeMethodInfoPtr_ClearActiveSurface_Public_Void_0;

		// Token: 0x04007ADB RID: 31451
		private static readonly IntPtr NativeMethodInfoPtr_UpdateButtons_Private_Void_0;

		// Token: 0x04007ADC RID: 31452
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000CC9 RID: 3273
		[ObfuscatedName("ScheduleOne.UI.GraffitiMenu+<>c__DisplayClass27_0")]
		public sealed class __c__DisplayClass27_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F4D5 RID: 62677 RVA: 0x003AD6D0 File Offset: 0x003AB8D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_0()
			{
				Il2CppClassPointerStore<GraffitiMenu.__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr, "<>c__DisplayClass27_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraffitiMenu.__c__DisplayClass27_0>.NativeClassPtr);
				GraffitiMenu.__c__DisplayClass27_0.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiMenu.__c__DisplayClass27_0>.NativeClassPtr, "color");
				GraffitiMenu.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiMenu.__c__DisplayClass27_0>.NativeClassPtr, "<>4__this");
				GraffitiMenu.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiMenu.__c__DisplayClass27_0>.NativeClassPtr, 100686733);
				GraffitiMenu.__c__DisplayClass27_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiMenu.__c__DisplayClass27_0>.NativeClassPtr, 100686734);
			}

			// Token: 0x0600F4D6 RID: 62678 RVA: 0x003AD74C File Offset: 0x003AB94C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraffitiMenu.__c__DisplayClass27_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiMenu.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F4D7 RID: 62679 RVA: 0x003AD788 File Offset: 0x003AB988
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301733, XrefRangeEnd = 301735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiMenu.__c__DisplayClass27_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F4D8 RID: 62680 RVA: 0x00073B2D File Offset: 0x00071D2D
			public __c__DisplayClass27_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A5D RID: 19037
			// (get) Token: 0x0600F4D9 RID: 62681 RVA: 0x003AD7BC File Offset: 0x003AB9BC
			// (set) Token: 0x0600F4DA RID: 62682 RVA: 0x00073B36 File Offset: 0x00071D36
			public unsafe ESprayColor color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.__c__DisplayClass27_0.NativeFieldInfoPtr_color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.__c__DisplayClass27_0.NativeFieldInfoPtr_color)) = value;
				}
			}

			// Token: 0x17004A5E RID: 19038
			// (get) Token: 0x0600F4DB RID: 62683 RVA: 0x003AD7E4 File Offset: 0x003AB9E4
			// (set) Token: 0x0600F4DC RID: 62684 RVA: 0x00073B51 File Offset: 0x00071D51
			public unsafe GraffitiMenu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GraffitiMenu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A5B6 RID: 42422
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x0400A5B7 RID: 42423
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A5B8 RID: 42424
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A5B9 RID: 42425
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__0_Internal_Void_0;
		}

		// Token: 0x02000CCA RID: 3274
		[ObfuscatedName("ScheduleOne.UI.GraffitiMenu+<>c__DisplayClass27_1")]
		public sealed class __c__DisplayClass27_1 : Il2CppSystem.Object
		{
			// Token: 0x0600F4DD RID: 62685 RVA: 0x003AD814 File Offset: 0x003ABA14
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_1()
			{
				Il2CppClassPointerStore<GraffitiMenu.__c__DisplayClass27_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GraffitiMenu>.NativeClassPtr, "<>c__DisplayClass27_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraffitiMenu.__c__DisplayClass27_1>.NativeClassPtr);
				GraffitiMenu.__c__DisplayClass27_1.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiMenu.__c__DisplayClass27_1>.NativeClassPtr, "index");
				GraffitiMenu.__c__DisplayClass27_1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiMenu.__c__DisplayClass27_1>.NativeClassPtr, "<>4__this");
				GraffitiMenu.__c__DisplayClass27_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiMenu.__c__DisplayClass27_1>.NativeClassPtr, 100686735);
				GraffitiMenu.__c__DisplayClass27_1.NativeMethodInfoPtr__Awake_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiMenu.__c__DisplayClass27_1>.NativeClassPtr, 100686736);
			}

			// Token: 0x0600F4DE RID: 62686 RVA: 0x003AD890 File Offset: 0x003ABA90
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraffitiMenu.__c__DisplayClass27_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiMenu.__c__DisplayClass27_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F4DF RID: 62687 RVA: 0x003AD8CC File Offset: 0x003ABACC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301735, XrefRangeEnd = 301737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiMenu.__c__DisplayClass27_1.NativeMethodInfoPtr__Awake_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F4E0 RID: 62688 RVA: 0x00073B70 File Offset: 0x00071D70
			public __c__DisplayClass27_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A5F RID: 19039
			// (get) Token: 0x0600F4E1 RID: 62689 RVA: 0x003AD900 File Offset: 0x003ABB00
			// (set) Token: 0x0600F4E2 RID: 62690 RVA: 0x00073B79 File Offset: 0x00071D79
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.__c__DisplayClass27_1.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.__c__DisplayClass27_1.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x17004A60 RID: 19040
			// (get) Token: 0x0600F4E3 RID: 62691 RVA: 0x003AD928 File Offset: 0x003ABB28
			// (set) Token: 0x0600F4E4 RID: 62692 RVA: 0x00073B94 File Offset: 0x00071D94
			public unsafe GraffitiMenu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.__c__DisplayClass27_1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GraffitiMenu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiMenu.__c__DisplayClass27_1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A5BA RID: 42426
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x0400A5BB RID: 42427
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A5BC RID: 42428
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A5BD RID: 42429
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__1_Internal_Void_0;
		}
	}
}
