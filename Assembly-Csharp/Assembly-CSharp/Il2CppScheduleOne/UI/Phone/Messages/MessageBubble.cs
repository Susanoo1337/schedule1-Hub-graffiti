using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.Messages
{
	// Token: 0x020007B9 RID: 1977
	public class MessageBubble : MonoBehaviour
	{
		// Token: 0x0600C14F RID: 49487 RVA: 0x00314F4C File Offset: 0x0031314C
		// Note: this type is marked as 'beforefieldinit'.
		static MessageBubble()
		{
			Il2CppClassPointerStore<MessageBubble>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Messages", "MessageBubble");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr);
			MessageBubble.NativeFieldInfoPtr_OtherBubbleColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "OtherBubbleColor");
			MessageBubble.NativeFieldInfoPtr_OtherTextColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "OtherTextColor");
			MessageBubble.NativeFieldInfoPtr_BaseBubbleSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "BaseBubbleSpacing");
			MessageBubble.NativeFieldInfoPtr__Height_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "<Height>k__BackingField");
			MessageBubble.NativeFieldInfoPtr__SpacingAbove_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "<SpacingAbove>k__BackingField");
			MessageBubble.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "text");
			MessageBubble.NativeFieldInfoPtr_alignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "alignment");
			MessageBubble.NativeFieldInfoPtr_showTriangle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "showTriangle");
			MessageBubble.NativeFieldInfoPtr_bubble_MinWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "bubble_MinWidth");
			MessageBubble.NativeFieldInfoPtr_bubble_MaxWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "bubble_MaxWidth");
			MessageBubble.NativeFieldInfoPtr_alignTextCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "alignTextCenter");
			MessageBubble.NativeFieldInfoPtr_autosetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "autosetPosition");
			MessageBubble.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "container");
			MessageBubble.NativeFieldInfoPtr_bubble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "bubble");
			MessageBubble.NativeFieldInfoPtr_content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "content");
			MessageBubble.NativeFieldInfoPtr_triangle_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "triangle_Left");
			MessageBubble.NativeFieldInfoPtr_triangle_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "triangle_Right");
			MessageBubble.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "button");
			MessageBubble.NativeFieldInfoPtr_displayedText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "displayedText");
			MessageBubble.NativeFieldInfoPtr_triangleShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "triangleShown");
			MessageBubble.NativeMethodInfoPtr_get_Height_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, 100688464);
			MessageBubble.NativeMethodInfoPtr_set_Height_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, 100688465);
			MessageBubble.NativeMethodInfoPtr_get_SpacingAbove_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, 100688466);
			MessageBubble.NativeMethodInfoPtr_set_SpacingAbove_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, 100688467);
			MessageBubble.NativeMethodInfoPtr_get_Container_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, 100688468);
			MessageBubble.NativeMethodInfoPtr_get_Button_Public_get_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, 100688469);
			MessageBubble.NativeMethodInfoPtr_SetupBubble_Public_Void_String_Alignment_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, 100688470);
			MessageBubble.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, 100688471);
			MessageBubble.NativeMethodInfoPtr_RefreshDisplayedText_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, 100688472);
			MessageBubble.NativeMethodInfoPtr_RefreshTriangle_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, 100688473);
			MessageBubble.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, 100688474);
		}

		// Token: 0x17003A9E RID: 15006
		// (get) Token: 0x0600C150 RID: 49488 RVA: 0x003151E8 File Offset: 0x003133E8
		// (set) Token: 0x0600C151 RID: 49489 RVA: 0x00315224 File Offset: 0x00313424
		public unsafe float Height
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageBubble.NativeMethodInfoPtr_get_Height_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29040, RefRangeEnd = 29041, XrefRangeStart = 29040, XrefRangeEnd = 29041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageBubble.NativeMethodInfoPtr_set_Height_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003A9F RID: 15007
		// (get) Token: 0x0600C152 RID: 49490 RVA: 0x00315264 File Offset: 0x00313464
		// (set) Token: 0x0600C153 RID: 49491 RVA: 0x003152A0 File Offset: 0x003134A0
		public unsafe float SpacingAbove
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageBubble.NativeMethodInfoPtr_get_SpacingAbove_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 29058, RefRangeEnd = 29072, XrefRangeStart = 29058, XrefRangeEnd = 29072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageBubble.NativeMethodInfoPtr_set_SpacingAbove_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003AA0 RID: 15008
		// (get) Token: 0x0600C154 RID: 49492 RVA: 0x003152E0 File Offset: 0x003134E0
		public unsafe RectTransform Container
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageBubble.NativeMethodInfoPtr_get_Container_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x17003AA1 RID: 15009
		// (get) Token: 0x0600C155 RID: 49493 RVA: 0x00315320 File Offset: 0x00313520
		public unsafe Button Button
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22015, RefRangeEnd = 22016, XrefRangeStart = 22015, XrefRangeEnd = 22016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageBubble.NativeMethodInfoPtr_get_Button_Public_get_Button_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Button>(intPtr3) : null;
			}
		}

		// Token: 0x0600C156 RID: 49494 RVA: 0x00315360 File Offset: 0x00313560
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 320995, RefRangeEnd = 320998, XrefRangeStart = 320975, XrefRangeEnd = 320995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupBubble(string _text, MessageBubble.Alignment _alignment, bool interactable, bool alignCenter = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _alignment;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref interactable;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alignCenter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageBubble.NativeMethodInfoPtr_SetupBubble_Public_Void_String_Alignment_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C157 RID: 49495 RVA: 0x003153CC File Offset: 0x003135CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320998, XrefRangeEnd = 320999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessageBubble.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C158 RID: 49496 RVA: 0x00315408 File Offset: 0x00313608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320999, XrefRangeEnd = 321013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshDisplayedText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessageBubble.NativeMethodInfoPtr_RefreshDisplayedText_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C159 RID: 49497 RVA: 0x00315444 File Offset: 0x00313644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321013, XrefRangeEnd = 321022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshTriangle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessageBubble.NativeMethodInfoPtr_RefreshTriangle_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C15A RID: 49498 RVA: 0x00315480 File Offset: 0x00313680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321022, XrefRangeEnd = 321028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageBubble() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageBubble.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C15B RID: 49499 RVA: 0x0005AAE6 File Offset: 0x00058CE6
		public MessageBubble(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003A8A RID: 14986
		// (get) Token: 0x0600C15C RID: 49500 RVA: 0x003154BC File Offset: 0x003136BC
		// (set) Token: 0x0600C15D RID: 49501 RVA: 0x0005AAEF File Offset: 0x00058CEF
		public unsafe static Color32 OtherBubbleColor
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(MessageBubble.NativeFieldInfoPtr_OtherBubbleColor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MessageBubble.NativeFieldInfoPtr_OtherBubbleColor, (void*)(&value));
			}
		}

		// Token: 0x17003A8B RID: 14987
		// (get) Token: 0x0600C15E RID: 49502 RVA: 0x003154D8 File Offset: 0x003136D8
		// (set) Token: 0x0600C15F RID: 49503 RVA: 0x0005AAFD File Offset: 0x00058CFD
		public unsafe static Color32 OtherTextColor
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(MessageBubble.NativeFieldInfoPtr_OtherTextColor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MessageBubble.NativeFieldInfoPtr_OtherTextColor, (void*)(&value));
			}
		}

		// Token: 0x17003A8C RID: 14988
		// (get) Token: 0x0600C160 RID: 49504 RVA: 0x003154F4 File Offset: 0x003136F4
		// (set) Token: 0x0600C161 RID: 49505 RVA: 0x0005AB0B File Offset: 0x00058D0B
		public unsafe static float BaseBubbleSpacing
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(MessageBubble.NativeFieldInfoPtr_BaseBubbleSpacing, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MessageBubble.NativeFieldInfoPtr_BaseBubbleSpacing, (void*)(&value));
			}
		}

		// Token: 0x17003A8D RID: 14989
		// (get) Token: 0x0600C162 RID: 49506 RVA: 0x00315510 File Offset: 0x00313710
		// (set) Token: 0x0600C163 RID: 49507 RVA: 0x0005AB19 File Offset: 0x00058D19
		public unsafe float _Height_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr__Height_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr__Height_k__BackingField)) = value;
			}
		}

		// Token: 0x17003A8E RID: 14990
		// (get) Token: 0x0600C164 RID: 49508 RVA: 0x00315538 File Offset: 0x00313738
		// (set) Token: 0x0600C165 RID: 49509 RVA: 0x0005AB34 File Offset: 0x00058D34
		public unsafe float _SpacingAbove_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr__SpacingAbove_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr__SpacingAbove_k__BackingField)) = value;
			}
		}

		// Token: 0x17003A8F RID: 14991
		// (get) Token: 0x0600C166 RID: 49510 RVA: 0x00315560 File Offset: 0x00313760
		// (set) Token: 0x0600C167 RID: 49511 RVA: 0x0005AB4F File Offset: 0x00058D4F
		public unsafe string text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003A90 RID: 14992
		// (get) Token: 0x0600C168 RID: 49512 RVA: 0x00315588 File Offset: 0x00313788
		// (set) Token: 0x0600C169 RID: 49513 RVA: 0x0005AB6E File Offset: 0x00058D6E
		public unsafe MessageBubble.Alignment alignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_alignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_alignment)) = value;
			}
		}

		// Token: 0x17003A91 RID: 14993
		// (get) Token: 0x0600C16A RID: 49514 RVA: 0x003155B0 File Offset: 0x003137B0
		// (set) Token: 0x0600C16B RID: 49515 RVA: 0x0005AB89 File Offset: 0x00058D89
		public unsafe bool showTriangle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_showTriangle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_showTriangle)) = value;
			}
		}

		// Token: 0x17003A92 RID: 14994
		// (get) Token: 0x0600C16C RID: 49516 RVA: 0x003155D8 File Offset: 0x003137D8
		// (set) Token: 0x0600C16D RID: 49517 RVA: 0x0005ABA4 File Offset: 0x00058DA4
		public unsafe float bubble_MinWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_bubble_MinWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_bubble_MinWidth)) = value;
			}
		}

		// Token: 0x17003A93 RID: 14995
		// (get) Token: 0x0600C16E RID: 49518 RVA: 0x00315600 File Offset: 0x00313800
		// (set) Token: 0x0600C16F RID: 49519 RVA: 0x0005ABBF File Offset: 0x00058DBF
		public unsafe float bubble_MaxWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_bubble_MaxWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_bubble_MaxWidth)) = value;
			}
		}

		// Token: 0x17003A94 RID: 14996
		// (get) Token: 0x0600C170 RID: 49520 RVA: 0x00315628 File Offset: 0x00313828
		// (set) Token: 0x0600C171 RID: 49521 RVA: 0x0005ABDA File Offset: 0x00058DDA
		public unsafe bool alignTextCenter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_alignTextCenter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_alignTextCenter)) = value;
			}
		}

		// Token: 0x17003A95 RID: 14997
		// (get) Token: 0x0600C172 RID: 49522 RVA: 0x00315650 File Offset: 0x00313850
		// (set) Token: 0x0600C173 RID: 49523 RVA: 0x0005ABF5 File Offset: 0x00058DF5
		public unsafe bool autosetPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_autosetPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_autosetPosition)) = value;
			}
		}

		// Token: 0x17003A96 RID: 14998
		// (get) Token: 0x0600C174 RID: 49524 RVA: 0x00315678 File Offset: 0x00313878
		// (set) Token: 0x0600C175 RID: 49525 RVA: 0x0005AC10 File Offset: 0x00058E10
		public unsafe RectTransform container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A97 RID: 14999
		// (get) Token: 0x0600C176 RID: 49526 RVA: 0x003156A8 File Offset: 0x003138A8
		// (set) Token: 0x0600C177 RID: 49527 RVA: 0x0005AC2F File Offset: 0x00058E2F
		public unsafe Image bubble
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_bubble);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_bubble), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A98 RID: 15000
		// (get) Token: 0x0600C178 RID: 49528 RVA: 0x003156D8 File Offset: 0x003138D8
		// (set) Token: 0x0600C179 RID: 49529 RVA: 0x0005AC4E File Offset: 0x00058E4E
		public unsafe Text content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A99 RID: 15001
		// (get) Token: 0x0600C17A RID: 49530 RVA: 0x00315708 File Offset: 0x00313908
		// (set) Token: 0x0600C17B RID: 49531 RVA: 0x0005AC6D File Offset: 0x00058E6D
		public unsafe Image triangle_Left
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_triangle_Left);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_triangle_Left), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A9A RID: 15002
		// (get) Token: 0x0600C17C RID: 49532 RVA: 0x00315738 File Offset: 0x00313938
		// (set) Token: 0x0600C17D RID: 49533 RVA: 0x0005AC8C File Offset: 0x00058E8C
		public unsafe Image triangle_Right
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_triangle_Right);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_triangle_Right), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A9B RID: 15003
		// (get) Token: 0x0600C17E RID: 49534 RVA: 0x00315768 File Offset: 0x00313968
		// (set) Token: 0x0600C17F RID: 49535 RVA: 0x0005ACAB File Offset: 0x00058EAB
		public unsafe Button button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A9C RID: 15004
		// (get) Token: 0x0600C180 RID: 49536 RVA: 0x00315798 File Offset: 0x00313998
		// (set) Token: 0x0600C181 RID: 49537 RVA: 0x0005ACCA File Offset: 0x00058ECA
		public unsafe string displayedText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_displayedText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_displayedText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003A9D RID: 15005
		// (get) Token: 0x0600C182 RID: 49538 RVA: 0x003157C0 File Offset: 0x003139C0
		// (set) Token: 0x0600C183 RID: 49539 RVA: 0x0005ACE9 File Offset: 0x00058EE9
		public unsafe bool triangleShown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_triangleShown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_triangleShown)) = value;
			}
		}

		// Token: 0x0400843C RID: 33852
		private static readonly IntPtr NativeFieldInfoPtr_OtherBubbleColor;

		// Token: 0x0400843D RID: 33853
		private static readonly IntPtr NativeFieldInfoPtr_OtherTextColor;

		// Token: 0x0400843E RID: 33854
		private static readonly IntPtr NativeFieldInfoPtr_BaseBubbleSpacing;

		// Token: 0x0400843F RID: 33855
		private static readonly IntPtr NativeFieldInfoPtr__Height_k__BackingField;

		// Token: 0x04008440 RID: 33856
		private static readonly IntPtr NativeFieldInfoPtr__SpacingAbove_k__BackingField;

		// Token: 0x04008441 RID: 33857
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x04008442 RID: 33858
		private static readonly IntPtr NativeFieldInfoPtr_alignment;

		// Token: 0x04008443 RID: 33859
		private static readonly IntPtr NativeFieldInfoPtr_showTriangle;

		// Token: 0x04008444 RID: 33860
		private static readonly IntPtr NativeFieldInfoPtr_bubble_MinWidth;

		// Token: 0x04008445 RID: 33861
		private static readonly IntPtr NativeFieldInfoPtr_bubble_MaxWidth;

		// Token: 0x04008446 RID: 33862
		private static readonly IntPtr NativeFieldInfoPtr_alignTextCenter;

		// Token: 0x04008447 RID: 33863
		private static readonly IntPtr NativeFieldInfoPtr_autosetPosition;

		// Token: 0x04008448 RID: 33864
		private static readonly IntPtr NativeFieldInfoPtr_container;

		// Token: 0x04008449 RID: 33865
		private static readonly IntPtr NativeFieldInfoPtr_bubble;

		// Token: 0x0400844A RID: 33866
		private static readonly IntPtr NativeFieldInfoPtr_content;

		// Token: 0x0400844B RID: 33867
		private static readonly IntPtr NativeFieldInfoPtr_triangle_Left;

		// Token: 0x0400844C RID: 33868
		private static readonly IntPtr NativeFieldInfoPtr_triangle_Right;

		// Token: 0x0400844D RID: 33869
		private static readonly IntPtr NativeFieldInfoPtr_button;

		// Token: 0x0400844E RID: 33870
		private static readonly IntPtr NativeFieldInfoPtr_displayedText;

		// Token: 0x0400844F RID: 33871
		private static readonly IntPtr NativeFieldInfoPtr_triangleShown;

		// Token: 0x04008450 RID: 33872
		private static readonly IntPtr NativeMethodInfoPtr_get_Height_Public_get_Single_0;

		// Token: 0x04008451 RID: 33873
		private static readonly IntPtr NativeMethodInfoPtr_set_Height_Private_set_Void_Single_0;

		// Token: 0x04008452 RID: 33874
		private static readonly IntPtr NativeMethodInfoPtr_get_SpacingAbove_Public_get_Single_0;

		// Token: 0x04008453 RID: 33875
		private static readonly IntPtr NativeMethodInfoPtr_set_SpacingAbove_Public_set_Void_Single_0;

		// Token: 0x04008454 RID: 33876
		private static readonly IntPtr NativeMethodInfoPtr_get_Container_Public_get_RectTransform_0;

		// Token: 0x04008455 RID: 33877
		private static readonly IntPtr NativeMethodInfoPtr_get_Button_Public_get_Button_0;

		// Token: 0x04008456 RID: 33878
		private static readonly IntPtr NativeMethodInfoPtr_SetupBubble_Public_Void_String_Alignment_Boolean_Boolean_0;

		// Token: 0x04008457 RID: 33879
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04008458 RID: 33880
		private static readonly IntPtr NativeMethodInfoPtr_RefreshDisplayedText_Public_Virtual_New_Void_0;

		// Token: 0x04008459 RID: 33881
		private static readonly IntPtr NativeMethodInfoPtr_RefreshTriangle_Protected_Virtual_New_Void_0;

		// Token: 0x0400845A RID: 33882
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D43 RID: 3395
		[OriginalName("Assembly-CSharp.dll", "", "Alignment")]
		public enum Alignment
		{
			// Token: 0x0400A8AB RID: 43179
			Center,
			// Token: 0x0400A8AC RID: 43180
			Left,
			// Token: 0x0400A8AD RID: 43181
			Right
		}
	}
}
