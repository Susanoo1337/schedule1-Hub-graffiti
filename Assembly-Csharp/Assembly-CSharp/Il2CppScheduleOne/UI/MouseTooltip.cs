using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000742 RID: 1858
	public class MouseTooltip : Singleton<MouseTooltip>
	{
		// Token: 0x0600B44C RID: 46156 RVA: 0x002ED9D0 File Offset: 0x002EBBD0
		// Note: this type is marked as 'beforefieldinit'.
		static MouseTooltip()
		{
			Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "MouseTooltip");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr);
			MouseTooltip.NativeFieldInfoPtr_IconRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, "IconRect");
			MouseTooltip.NativeFieldInfoPtr_IconImg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, "IconImg");
			MouseTooltip.NativeFieldInfoPtr_TooltipRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, "TooltipRect");
			MouseTooltip.NativeFieldInfoPtr_TooltipLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, "TooltipLabel");
			MouseTooltip.NativeFieldInfoPtr_TooltipOffset_NoIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, "TooltipOffset_NoIcon");
			MouseTooltip.NativeFieldInfoPtr_TooltipOffset_WithIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, "TooltipOffset_WithIcon");
			MouseTooltip.NativeFieldInfoPtr_IconOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, "IconOffset");
			MouseTooltip.NativeFieldInfoPtr_Color_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, "Color_Invalid");
			MouseTooltip.NativeFieldInfoPtr_Sprite_Cross = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, "Sprite_Cross");
			MouseTooltip.NativeFieldInfoPtr_tooltipShownThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, "tooltipShownThisFrame");
			MouseTooltip.NativeFieldInfoPtr_iconShownThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, "iconShownThisFrame");
			MouseTooltip.NativeMethodInfoPtr_ShowTooltip_Public_Void_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, 100686938);
			MouseTooltip.NativeMethodInfoPtr_ShowIcon_Public_Void_Sprite_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, 100686939);
			MouseTooltip.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, 100686940);
			MouseTooltip.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, 100686941);
		}

		// Token: 0x0600B44D RID: 46157 RVA: 0x002EDB2C File Offset: 0x002EBD2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 303984, RefRangeEnd = 303986, XrefRangeStart = 303984, XrefRangeEnd = 303984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowTooltip(string text, Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseTooltip.NativeMethodInfoPtr_ShowTooltip_Public_Void_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B44E RID: 46158 RVA: 0x002EDB7C File Offset: 0x002EBD7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 303987, RefRangeEnd = 303989, XrefRangeStart = 303986, XrefRangeEnd = 303987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowIcon(Sprite sprite, Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseTooltip.NativeMethodInfoPtr_ShowIcon_Public_Void_Sprite_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B44F RID: 46159 RVA: 0x002EDBCC File Offset: 0x002EBDCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303989, XrefRangeEnd = 304005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseTooltip.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B450 RID: 46160 RVA: 0x002EDC00 File Offset: 0x002EBE00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304005, XrefRangeEnd = 304008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseTooltip() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseTooltip.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B451 RID: 46161 RVA: 0x000534D1 File Offset: 0x000516D1
		public MouseTooltip(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003651 RID: 13905
		// (get) Token: 0x0600B452 RID: 46162 RVA: 0x002EDC3C File Offset: 0x002EBE3C
		// (set) Token: 0x0600B453 RID: 46163 RVA: 0x000534DA File Offset: 0x000516DA
		public unsafe RectTransform IconRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_IconRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_IconRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003652 RID: 13906
		// (get) Token: 0x0600B454 RID: 46164 RVA: 0x002EDC6C File Offset: 0x002EBE6C
		// (set) Token: 0x0600B455 RID: 46165 RVA: 0x000534F9 File Offset: 0x000516F9
		public unsafe Image IconImg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_IconImg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_IconImg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003653 RID: 13907
		// (get) Token: 0x0600B456 RID: 46166 RVA: 0x002EDC9C File Offset: 0x002EBE9C
		// (set) Token: 0x0600B457 RID: 46167 RVA: 0x00053518 File Offset: 0x00051718
		public unsafe RectTransform TooltipRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_TooltipRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_TooltipRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003654 RID: 13908
		// (get) Token: 0x0600B458 RID: 46168 RVA: 0x002EDCCC File Offset: 0x002EBECC
		// (set) Token: 0x0600B459 RID: 46169 RVA: 0x00053537 File Offset: 0x00051737
		public unsafe TextMeshProUGUI TooltipLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_TooltipLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_TooltipLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003655 RID: 13909
		// (get) Token: 0x0600B45A RID: 46170 RVA: 0x002EDCFC File Offset: 0x002EBEFC
		// (set) Token: 0x0600B45B RID: 46171 RVA: 0x00053556 File Offset: 0x00051756
		public unsafe Vector3 TooltipOffset_NoIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_TooltipOffset_NoIcon);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_TooltipOffset_NoIcon)) = value;
			}
		}

		// Token: 0x17003656 RID: 13910
		// (get) Token: 0x0600B45C RID: 46172 RVA: 0x002EDD24 File Offset: 0x002EBF24
		// (set) Token: 0x0600B45D RID: 46173 RVA: 0x00053571 File Offset: 0x00051771
		public unsafe Vector3 TooltipOffset_WithIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_TooltipOffset_WithIcon);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_TooltipOffset_WithIcon)) = value;
			}
		}

		// Token: 0x17003657 RID: 13911
		// (get) Token: 0x0600B45E RID: 46174 RVA: 0x002EDD4C File Offset: 0x002EBF4C
		// (set) Token: 0x0600B45F RID: 46175 RVA: 0x0005358C File Offset: 0x0005178C
		public unsafe Vector3 IconOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_IconOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_IconOffset)) = value;
			}
		}

		// Token: 0x17003658 RID: 13912
		// (get) Token: 0x0600B460 RID: 46176 RVA: 0x002EDD74 File Offset: 0x002EBF74
		// (set) Token: 0x0600B461 RID: 46177 RVA: 0x000535A7 File Offset: 0x000517A7
		public unsafe Color Color_Invalid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_Color_Invalid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_Color_Invalid)) = value;
			}
		}

		// Token: 0x17003659 RID: 13913
		// (get) Token: 0x0600B462 RID: 46178 RVA: 0x002EDD9C File Offset: 0x002EBF9C
		// (set) Token: 0x0600B463 RID: 46179 RVA: 0x000535C2 File Offset: 0x000517C2
		public unsafe Sprite Sprite_Cross
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_Sprite_Cross);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_Sprite_Cross), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700365A RID: 13914
		// (get) Token: 0x0600B464 RID: 46180 RVA: 0x002EDDCC File Offset: 0x002EBFCC
		// (set) Token: 0x0600B465 RID: 46181 RVA: 0x000535E1 File Offset: 0x000517E1
		public unsafe bool tooltipShownThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_tooltipShownThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_tooltipShownThisFrame)) = value;
			}
		}

		// Token: 0x1700365B RID: 13915
		// (get) Token: 0x0600B466 RID: 46182 RVA: 0x002EDDF4 File Offset: 0x002EBFF4
		// (set) Token: 0x0600B467 RID: 46183 RVA: 0x000535FC File Offset: 0x000517FC
		public unsafe bool iconShownThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_iconShownThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_iconShownThisFrame)) = value;
			}
		}

		// Token: 0x04007C0D RID: 31757
		private static readonly IntPtr NativeFieldInfoPtr_IconRect;

		// Token: 0x04007C0E RID: 31758
		private static readonly IntPtr NativeFieldInfoPtr_IconImg;

		// Token: 0x04007C0F RID: 31759
		private static readonly IntPtr NativeFieldInfoPtr_TooltipRect;

		// Token: 0x04007C10 RID: 31760
		private static readonly IntPtr NativeFieldInfoPtr_TooltipLabel;

		// Token: 0x04007C11 RID: 31761
		private static readonly IntPtr NativeFieldInfoPtr_TooltipOffset_NoIcon;

		// Token: 0x04007C12 RID: 31762
		private static readonly IntPtr NativeFieldInfoPtr_TooltipOffset_WithIcon;

		// Token: 0x04007C13 RID: 31763
		private static readonly IntPtr NativeFieldInfoPtr_IconOffset;

		// Token: 0x04007C14 RID: 31764
		private static readonly IntPtr NativeFieldInfoPtr_Color_Invalid;

		// Token: 0x04007C15 RID: 31765
		private static readonly IntPtr NativeFieldInfoPtr_Sprite_Cross;

		// Token: 0x04007C16 RID: 31766
		private static readonly IntPtr NativeFieldInfoPtr_tooltipShownThisFrame;

		// Token: 0x04007C17 RID: 31767
		private static readonly IntPtr NativeFieldInfoPtr_iconShownThisFrame;

		// Token: 0x04007C18 RID: 31768
		private static readonly IntPtr NativeMethodInfoPtr_ShowTooltip_Public_Void_String_Color_0;

		// Token: 0x04007C19 RID: 31769
		private static readonly IntPtr NativeMethodInfoPtr_ShowIcon_Public_Void_Sprite_Color_0;

		// Token: 0x04007C1A RID: 31770
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04007C1B RID: 31771
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
