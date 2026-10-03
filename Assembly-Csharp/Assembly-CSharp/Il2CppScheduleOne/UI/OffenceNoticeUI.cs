using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Police;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000752 RID: 1874
	public class OffenceNoticeUI : Singleton<OffenceNoticeUI>
	{
		// Token: 0x0600B6B8 RID: 46776 RVA: 0x002F4A10 File Offset: 0x002F2C10
		// Note: this type is marked as 'beforefieldinit'.
		static OffenceNoticeUI()
		{
			Il2CppClassPointerStore<OffenceNoticeUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "OffenceNoticeUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OffenceNoticeUI>.NativeClassPtr);
			OffenceNoticeUI.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffenceNoticeUI>.NativeClassPtr, "container");
			OffenceNoticeUI.NativeFieldInfoPtr_charges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffenceNoticeUI>.NativeClassPtr, "charges");
			OffenceNoticeUI.NativeFieldInfoPtr_penalties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffenceNoticeUI>.NativeClassPtr, "penalties");
			OffenceNoticeUI.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffenceNoticeUI>.NativeClassPtr, 100687196);
			OffenceNoticeUI.NativeMethodInfoPtr_ShowOffenceNotice_Public_Void_Offense_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffenceNoticeUI>.NativeClassPtr, 100687197);
			OffenceNoticeUI.NativeMethodInfoPtr_Close_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffenceNoticeUI>.NativeClassPtr, 100687198);
			OffenceNoticeUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffenceNoticeUI>.NativeClassPtr, 100687199);
			OffenceNoticeUI.NativeMethodInfoPtr__Start_b__3_0_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffenceNoticeUI>.NativeClassPtr, 100687200);
		}

		// Token: 0x0600B6B9 RID: 46777 RVA: 0x002F4AE0 File Offset: 0x002F2CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306864, XrefRangeEnd = 306884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OffenceNoticeUI.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6BA RID: 46778 RVA: 0x002F4B1C File Offset: 0x002F2D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306884, XrefRangeEnd = 306934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowOffenceNotice(Offense offence)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(offence);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffenceNoticeUI.NativeMethodInfoPtr_ShowOffenceNotice_Public_Void_Offense_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6BB RID: 46779 RVA: 0x002F4B60 File Offset: 0x002F2D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306934, XrefRangeEnd = 306937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffenceNoticeUI.NativeMethodInfoPtr_Close_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6BC RID: 46780 RVA: 0x002F4B94 File Offset: 0x002F2D94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306937, XrefRangeEnd = 306952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OffenceNoticeUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OffenceNoticeUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffenceNoticeUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6BD RID: 46781 RVA: 0x002F4BD0 File Offset: 0x002F2DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306952, XrefRangeEnd = 306954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Start_b__3_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffenceNoticeUI.NativeMethodInfoPtr__Start_b__3_0_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B6BE RID: 46782 RVA: 0x00054C3F File Offset: 0x00052E3F
		public OffenceNoticeUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003728 RID: 14120
		// (get) Token: 0x0600B6BF RID: 46783 RVA: 0x002F4C0C File Offset: 0x002F2E0C
		// (set) Token: 0x0600B6C0 RID: 46784 RVA: 0x00054C48 File Offset: 0x00052E48
		public unsafe GameObject container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffenceNoticeUI.NativeFieldInfoPtr_container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffenceNoticeUI.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003729 RID: 14121
		// (get) Token: 0x0600B6C1 RID: 46785 RVA: 0x002F4C3C File Offset: 0x002F2E3C
		// (set) Token: 0x0600B6C2 RID: 46786 RVA: 0x00054C67 File Offset: 0x00052E67
		public unsafe List<Text> charges
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffenceNoticeUI.NativeFieldInfoPtr_charges);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Text>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffenceNoticeUI.NativeFieldInfoPtr_charges), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700372A RID: 14122
		// (get) Token: 0x0600B6C3 RID: 46787 RVA: 0x002F4C6C File Offset: 0x002F2E6C
		// (set) Token: 0x0600B6C4 RID: 46788 RVA: 0x00054C86 File Offset: 0x00052E86
		public unsafe List<Text> penalties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffenceNoticeUI.NativeFieldInfoPtr_penalties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Text>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffenceNoticeUI.NativeFieldInfoPtr_penalties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007D8F RID: 32143
		private static readonly IntPtr NativeFieldInfoPtr_container;

		// Token: 0x04007D90 RID: 32144
		private static readonly IntPtr NativeFieldInfoPtr_charges;

		// Token: 0x04007D91 RID: 32145
		private static readonly IntPtr NativeFieldInfoPtr_penalties;

		// Token: 0x04007D92 RID: 32146
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04007D93 RID: 32147
		private static readonly IntPtr NativeMethodInfoPtr_ShowOffenceNotice_Public_Void_Offense_0;

		// Token: 0x04007D94 RID: 32148
		private static readonly IntPtr NativeMethodInfoPtr_Close_Private_Void_0;

		// Token: 0x04007D95 RID: 32149
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007D96 RID: 32150
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__3_0_Private_Boolean_0;
	}
}
