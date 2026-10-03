using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne
{
	// Token: 0x020000A2 RID: 162
	public class UIMapItem : MonoBehaviour
	{
		// Token: 0x06000DD2 RID: 3538 RVA: 0x000A95C4 File Offset: 0x000A77C4
		// Note: this type is marked as 'beforefieldinit'.
		static UIMapItem()
		{
			Il2CppClassPointerStore<UIMapItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "UIMapItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIMapItem>.NativeClassPtr);
			UIMapItem.NativeFieldInfoPtr_mapPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIMapItem>.NativeClassPtr, "mapPanel");
			UIMapItem.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIMapItem>.NativeClassPtr, "button");
			UIMapItem.NativeFieldInfoPtr_rectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIMapItem>.NativeClassPtr, "rectTransform");
			UIMapItem.NativeMethodInfoPtr_GetRectTransform_Public_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIMapItem>.NativeClassPtr, 100665051);
			UIMapItem.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIMapItem>.NativeClassPtr, 100665052);
			UIMapItem.NativeMethodInfoPtr_SetMapPanel_Public_Void_UIMapPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIMapItem>.NativeClassPtr, 100665053);
			UIMapItem.NativeMethodInfoPtr_GetMapPosition_Public_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIMapItem>.NativeClassPtr, 100665054);
			UIMapItem.NativeMethodInfoPtr_OnClick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIMapItem>.NativeClassPtr, 100665055);
			UIMapItem.NativeMethodInfoPtr_OnPointerEnter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIMapItem>.NativeClassPtr, 100665056);
			UIMapItem.NativeMethodInfoPtr_OnPointerExit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIMapItem>.NativeClassPtr, 100665057);
			UIMapItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIMapItem>.NativeClassPtr, 100665058);
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x000A96D0 File Offset: 0x000A78D0
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 2964, RefRangeEnd = 2977, XrefRangeStart = 2964, XrefRangeEnd = 2977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectTransform GetRectTransform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIMapItem.NativeMethodInfoPtr_GetRectTransform_Public_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x000A9710 File Offset: 0x000A7910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80694, XrefRangeEnd = 80712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIMapItem.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x000A9744 File Offset: 0x000A7944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMapPanel(UIMapPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIMapItem.NativeMethodInfoPtr_SetMapPanel_Public_Void_UIMapPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x000A9788 File Offset: 0x000A7988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80712, XrefRangeEnd = 80713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetMapPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIMapItem.NativeMethodInfoPtr_GetMapPosition_Public_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x000A97C4 File Offset: 0x000A79C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 80736, RefRangeEnd = 80738, XrefRangeStart = 80713, XrefRangeEnd = 80736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIMapItem.NativeMethodInfoPtr_OnClick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x000A97F8 File Offset: 0x000A79F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80738, XrefRangeEnd = 80761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIMapItem.NativeMethodInfoPtr_OnPointerEnter_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x000A982C File Offset: 0x000A7A2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 80784, RefRangeEnd = 80786, XrefRangeStart = 80761, XrefRangeEnd = 80784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerExit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIMapItem.NativeMethodInfoPtr_OnPointerExit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x000A9860 File Offset: 0x000A7A60
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIMapItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIMapItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIMapItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x00008545 File Offset: 0x00006745
		public UIMapItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06000DDC RID: 3548 RVA: 0x000A989C File Offset: 0x000A7A9C
		// (set) Token: 0x06000DDD RID: 3549 RVA: 0x0000854E File Offset: 0x0000674E
		public unsafe UIMapPanel mapPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMapItem.NativeFieldInfoPtr_mapPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIMapPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMapItem.NativeFieldInfoPtr_mapPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000DDE RID: 3550 RVA: 0x000A98CC File Offset: 0x000A7ACC
		// (set) Token: 0x06000DDF RID: 3551 RVA: 0x0000856D File Offset: 0x0000676D
		public unsafe Button button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMapItem.NativeFieldInfoPtr_button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMapItem.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06000DE0 RID: 3552 RVA: 0x000A98FC File Offset: 0x000A7AFC
		// (set) Token: 0x06000DE1 RID: 3553 RVA: 0x0000858C File Offset: 0x0000678C
		public unsafe RectTransform rectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMapItem.NativeFieldInfoPtr_rectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMapItem.NativeFieldInfoPtr_rectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009AD RID: 2477
		private static readonly IntPtr NativeFieldInfoPtr_mapPanel;

		// Token: 0x040009AE RID: 2478
		private static readonly IntPtr NativeFieldInfoPtr_button;

		// Token: 0x040009AF RID: 2479
		private static readonly IntPtr NativeFieldInfoPtr_rectTransform;

		// Token: 0x040009B0 RID: 2480
		private static readonly IntPtr NativeMethodInfoPtr_GetRectTransform_Public_RectTransform_0;

		// Token: 0x040009B1 RID: 2481
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040009B2 RID: 2482
		private static readonly IntPtr NativeMethodInfoPtr_SetMapPanel_Public_Void_UIMapPanel_0;

		// Token: 0x040009B3 RID: 2483
		private static readonly IntPtr NativeMethodInfoPtr_GetMapPosition_Public_Vector2_0;

		// Token: 0x040009B4 RID: 2484
		private static readonly IntPtr NativeMethodInfoPtr_OnClick_Public_Void_0;

		// Token: 0x040009B5 RID: 2485
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Void_0;

		// Token: 0x040009B6 RID: 2486
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerExit_Public_Void_0;

		// Token: 0x040009B7 RID: 2487
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
