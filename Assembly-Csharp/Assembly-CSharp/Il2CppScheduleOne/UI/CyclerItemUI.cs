using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000728 RID: 1832
	public class CyclerItemUI : MonoBehaviour
	{
		// Token: 0x0600B089 RID: 45193 RVA: 0x002E2420 File Offset: 0x002E0620
		// Note: this type is marked as 'beforefieldinit'.
		static CyclerItemUI()
		{
			Il2CppClassPointerStore<CyclerItemUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "CyclerItemUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CyclerItemUI>.NativeClassPtr);
			CyclerItemUI.NativeFieldInfoPtr__label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CyclerItemUI>.NativeClassPtr, "_label");
			CyclerItemUI.NativeFieldInfoPtr__content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CyclerItemUI>.NativeClassPtr, "_content");
			CyclerItemUI.NativeFieldInfoPtr__contentPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CyclerItemUI>.NativeClassPtr, "_contentPanel");
			CyclerItemUI.NativeMethodInfoPtr_get_ContentPanel_Public_get_UIPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CyclerItemUI>.NativeClassPtr, 100686509);
			CyclerItemUI.NativeMethodInfoPtr_get_Content_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CyclerItemUI>.NativeClassPtr, 100686510);
			CyclerItemUI.NativeMethodInfoPtr_get_Label_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CyclerItemUI>.NativeClassPtr, 100686511);
			CyclerItemUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CyclerItemUI>.NativeClassPtr, 100686512);
		}

		// Token: 0x17003507 RID: 13575
		// (get) Token: 0x0600B08A RID: 45194 RVA: 0x002E24DC File Offset: 0x002E06DC
		public unsafe UIPanel ContentPanel
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 2964, RefRangeEnd = 2977, XrefRangeStart = 2964, XrefRangeEnd = 2977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CyclerItemUI.NativeMethodInfoPtr_get_ContentPanel_Public_get_UIPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr3) : null;
			}
		}

		// Token: 0x17003508 RID: 13576
		// (get) Token: 0x0600B08B RID: 45195 RVA: 0x002E251C File Offset: 0x002E071C
		public unsafe GameObject Content
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CyclerItemUI.NativeMethodInfoPtr_get_Content_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x17003509 RID: 13577
		// (get) Token: 0x0600B08C RID: 45196 RVA: 0x002E255C File Offset: 0x002E075C
		public unsafe string Label
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CyclerItemUI.NativeMethodInfoPtr_get_Label_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600B08D RID: 45197 RVA: 0x002E2594 File Offset: 0x002E0794
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CyclerItemUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CyclerItemUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CyclerItemUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B08E RID: 45198 RVA: 0x00051117 File Offset: 0x0004F317
		public CyclerItemUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003504 RID: 13572
		// (get) Token: 0x0600B08F RID: 45199 RVA: 0x002E25D0 File Offset: 0x002E07D0
		// (set) Token: 0x0600B090 RID: 45200 RVA: 0x00051120 File Offset: 0x0004F320
		public unsafe string _label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CyclerItemUI.NativeFieldInfoPtr__label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CyclerItemUI.NativeFieldInfoPtr__label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003505 RID: 13573
		// (get) Token: 0x0600B091 RID: 45201 RVA: 0x002E25F8 File Offset: 0x002E07F8
		// (set) Token: 0x0600B092 RID: 45202 RVA: 0x0005113F File Offset: 0x0004F33F
		public unsafe GameObject _content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CyclerItemUI.NativeFieldInfoPtr__content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CyclerItemUI.NativeFieldInfoPtr__content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003506 RID: 13574
		// (get) Token: 0x0600B093 RID: 45203 RVA: 0x002E2628 File Offset: 0x002E0828
		// (set) Token: 0x0600B094 RID: 45204 RVA: 0x0005115E File Offset: 0x0004F35E
		public unsafe UIPanel _contentPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CyclerItemUI.NativeFieldInfoPtr__contentPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CyclerItemUI.NativeFieldInfoPtr__contentPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040079AB RID: 31147
		private static readonly IntPtr NativeFieldInfoPtr__label;

		// Token: 0x040079AC RID: 31148
		private static readonly IntPtr NativeFieldInfoPtr__content;

		// Token: 0x040079AD RID: 31149
		private static readonly IntPtr NativeFieldInfoPtr__contentPanel;

		// Token: 0x040079AE RID: 31150
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentPanel_Public_get_UIPanel_0;

		// Token: 0x040079AF RID: 31151
		private static readonly IntPtr NativeMethodInfoPtr_get_Content_Public_get_GameObject_0;

		// Token: 0x040079B0 RID: 31152
		private static readonly IntPtr NativeMethodInfoPtr_get_Label_Public_get_String_0;

		// Token: 0x040079B1 RID: 31153
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
