using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020007DF RID: 2015
	public class SelectionInfoUI : MonoBehaviour
	{
		// Token: 0x0600C518 RID: 50456 RVA: 0x0032019C File Offset: 0x0031E39C
		// Note: this type is marked as 'beforefieldinit'.
		static SelectionInfoUI()
		{
			Il2CppClassPointerStore<SelectionInfoUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "SelectionInfoUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionInfoUI>.NativeClassPtr);
			SelectionInfoUI.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionInfoUI>.NativeClassPtr, "Icon");
			SelectionInfoUI.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionInfoUI>.NativeClassPtr, "Title");
			SelectionInfoUI.NativeFieldInfoPtr_SelfUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionInfoUI>.NativeClassPtr, "SelfUpdate");
			SelectionInfoUI.NativeFieldInfoPtr_NonUniformTypeSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionInfoUI>.NativeClassPtr, "NonUniformTypeSprite");
			SelectionInfoUI.NativeFieldInfoPtr_CrossSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionInfoUI>.NativeClassPtr, "CrossSprite");
			SelectionInfoUI.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionInfoUI>.NativeClassPtr, 100688854);
			SelectionInfoUI.NativeMethodInfoPtr_Set_Public_Void_List_1_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionInfoUI>.NativeClassPtr, 100688855);
			SelectionInfoUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionInfoUI>.NativeClassPtr, 100688856);
		}

		// Token: 0x0600C519 RID: 50457 RVA: 0x0032026C File Offset: 0x0031E46C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326530, XrefRangeEnd = 326557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionInfoUI.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C51A RID: 50458 RVA: 0x003202A0 File Offset: 0x0031E4A0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 326604, RefRangeEnd = 326608, XrefRangeStart = 326557, XrefRangeEnd = 326604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(List<IConfigurable> Configurables)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(Configurables);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionInfoUI.NativeMethodInfoPtr_Set_Public_Void_List_1_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C51B RID: 50459 RVA: 0x003202E4 File Offset: 0x0031E4E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326608, XrefRangeEnd = 326609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectionInfoUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionInfoUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionInfoUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C51C RID: 50460 RVA: 0x0005D045 File Offset: 0x0005B245
		public SelectionInfoUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003BD4 RID: 15316
		// (get) Token: 0x0600C51D RID: 50461 RVA: 0x00320320 File Offset: 0x0031E520
		// (set) Token: 0x0600C51E RID: 50462 RVA: 0x0005D04E File Offset: 0x0005B24E
		public unsafe Image Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionInfoUI.NativeFieldInfoPtr_Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionInfoUI.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BD5 RID: 15317
		// (get) Token: 0x0600C51F RID: 50463 RVA: 0x00320350 File Offset: 0x0031E550
		// (set) Token: 0x0600C520 RID: 50464 RVA: 0x0005D06D File Offset: 0x0005B26D
		public unsafe TextMeshProUGUI Title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionInfoUI.NativeFieldInfoPtr_Title);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionInfoUI.NativeFieldInfoPtr_Title), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BD6 RID: 15318
		// (get) Token: 0x0600C521 RID: 50465 RVA: 0x00320380 File Offset: 0x0031E580
		// (set) Token: 0x0600C522 RID: 50466 RVA: 0x0005D08C File Offset: 0x0005B28C
		public unsafe bool SelfUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionInfoUI.NativeFieldInfoPtr_SelfUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionInfoUI.NativeFieldInfoPtr_SelfUpdate)) = value;
			}
		}

		// Token: 0x17003BD7 RID: 15319
		// (get) Token: 0x0600C523 RID: 50467 RVA: 0x003203A8 File Offset: 0x0031E5A8
		// (set) Token: 0x0600C524 RID: 50468 RVA: 0x0005D0A7 File Offset: 0x0005B2A7
		public unsafe Sprite NonUniformTypeSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionInfoUI.NativeFieldInfoPtr_NonUniformTypeSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionInfoUI.NativeFieldInfoPtr_NonUniformTypeSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BD8 RID: 15320
		// (get) Token: 0x0600C525 RID: 50469 RVA: 0x003203D8 File Offset: 0x0031E5D8
		// (set) Token: 0x0600C526 RID: 50470 RVA: 0x0005D0C6 File Offset: 0x0005B2C6
		public unsafe Sprite CrossSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionInfoUI.NativeFieldInfoPtr_CrossSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionInfoUI.NativeFieldInfoPtr_CrossSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008685 RID: 34437
		private static readonly IntPtr NativeFieldInfoPtr_Icon;

		// Token: 0x04008686 RID: 34438
		private static readonly IntPtr NativeFieldInfoPtr_Title;

		// Token: 0x04008687 RID: 34439
		private static readonly IntPtr NativeFieldInfoPtr_SelfUpdate;

		// Token: 0x04008688 RID: 34440
		private static readonly IntPtr NativeFieldInfoPtr_NonUniformTypeSprite;

		// Token: 0x04008689 RID: 34441
		private static readonly IntPtr NativeFieldInfoPtr_CrossSprite;

		// Token: 0x0400868A RID: 34442
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400868B RID: 34443
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_List_1_IConfigurable_0;

		// Token: 0x0400868C RID: 34444
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
