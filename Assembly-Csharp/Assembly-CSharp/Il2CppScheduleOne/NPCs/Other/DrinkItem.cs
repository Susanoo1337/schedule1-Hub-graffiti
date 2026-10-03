using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Other
{
	// Token: 0x0200069E RID: 1694
	public class DrinkItem : MonoBehaviour
	{
		// Token: 0x0600A566 RID: 42342 RVA: 0x002BE7EC File Offset: 0x002BC9EC
		// Note: this type is marked as 'beforefieldinit'.
		static DrinkItem()
		{
			Il2CppClassPointerStore<DrinkItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Other", "DrinkItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrinkItem>.NativeClassPtr);
			DrinkItem.NativeFieldInfoPtr_DrinkPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrinkItem>.NativeClassPtr, "DrinkPrefab");
			DrinkItem.NativeFieldInfoPtr__npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrinkItem>.NativeClassPtr, "_npc");
			DrinkItem.NativeFieldInfoPtr__active_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrinkItem>.NativeClassPtr, "<active>k__BackingField");
			DrinkItem.NativeMethodInfoPtr_get_active_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrinkItem>.NativeClassPtr, 100685237);
			DrinkItem.NativeMethodInfoPtr_set_active_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrinkItem>.NativeClassPtr, 100685238);
			DrinkItem.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrinkItem>.NativeClassPtr, 100685239);
			DrinkItem.NativeMethodInfoPtr_Begin_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrinkItem>.NativeClassPtr, 100685240);
			DrinkItem.NativeMethodInfoPtr_End_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrinkItem>.NativeClassPtr, 100685241);
			DrinkItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrinkItem>.NativeClassPtr, 100685242);
		}

		// Token: 0x170031AB RID: 12715
		// (get) Token: 0x0600A567 RID: 42343 RVA: 0x002BE8D0 File Offset: 0x002BCAD0
		// (set) Token: 0x0600A568 RID: 42344 RVA: 0x002BE90C File Offset: 0x002BCB0C
		public unsafe bool active
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrinkItem.NativeMethodInfoPtr_get_active_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrinkItem.NativeMethodInfoPtr_set_active_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A569 RID: 42345 RVA: 0x002BE94C File Offset: 0x002BCB4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289588, XrefRangeEnd = 289596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrinkItem.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A56A RID: 42346 RVA: 0x002BE980 File Offset: 0x002BCB80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289596, XrefRangeEnd = 289602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrinkItem.NativeMethodInfoPtr_Begin_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A56B RID: 42347 RVA: 0x002BE9B4 File Offset: 0x002BCBB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289602, XrefRangeEnd = 289610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrinkItem.NativeMethodInfoPtr_End_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A56C RID: 42348 RVA: 0x002BE9E8 File Offset: 0x002BCBE8
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DrinkItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrinkItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrinkItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A56D RID: 42349 RVA: 0x0004B86A File Offset: 0x00049A6A
		public DrinkItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170031A8 RID: 12712
		// (get) Token: 0x0600A56E RID: 42350 RVA: 0x002BEA24 File Offset: 0x002BCC24
		// (set) Token: 0x0600A56F RID: 42351 RVA: 0x0004B873 File Offset: 0x00049A73
		public unsafe AvatarEquippable DrinkPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrinkItem.NativeFieldInfoPtr_DrinkPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrinkItem.NativeFieldInfoPtr_DrinkPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031A9 RID: 12713
		// (get) Token: 0x0600A570 RID: 42352 RVA: 0x002BEA54 File Offset: 0x002BCC54
		// (set) Token: 0x0600A571 RID: 42353 RVA: 0x0004B892 File Offset: 0x00049A92
		public unsafe NPC _npc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrinkItem.NativeFieldInfoPtr__npc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrinkItem.NativeFieldInfoPtr__npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031AA RID: 12714
		// (get) Token: 0x0600A572 RID: 42354 RVA: 0x002BEA84 File Offset: 0x002BCC84
		// (set) Token: 0x0600A573 RID: 42355 RVA: 0x0004B8B1 File Offset: 0x00049AB1
		public unsafe bool _active_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrinkItem.NativeFieldInfoPtr__active_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrinkItem.NativeFieldInfoPtr__active_k__BackingField)) = value;
			}
		}

		// Token: 0x0400726B RID: 29291
		private static readonly IntPtr NativeFieldInfoPtr_DrinkPrefab;

		// Token: 0x0400726C RID: 29292
		private static readonly IntPtr NativeFieldInfoPtr__npc;

		// Token: 0x0400726D RID: 29293
		private static readonly IntPtr NativeFieldInfoPtr__active_k__BackingField;

		// Token: 0x0400726E RID: 29294
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_get_Boolean_0;

		// Token: 0x0400726F RID: 29295
		private static readonly IntPtr NativeMethodInfoPtr_set_active_Protected_set_Void_Boolean_0;

		// Token: 0x04007270 RID: 29296
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04007271 RID: 29297
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Void_0;

		// Token: 0x04007272 RID: 29298
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Void_0;

		// Token: 0x04007273 RID: 29299
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
