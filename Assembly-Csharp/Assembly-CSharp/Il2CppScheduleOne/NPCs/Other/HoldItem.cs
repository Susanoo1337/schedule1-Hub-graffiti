using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Other
{
	// Token: 0x0200069F RID: 1695
	public class HoldItem : MonoBehaviour
	{
		// Token: 0x0600A574 RID: 42356 RVA: 0x002BEAAC File Offset: 0x002BCCAC
		// Note: this type is marked as 'beforefieldinit'.
		static HoldItem()
		{
			Il2CppClassPointerStore<HoldItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Other", "HoldItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HoldItem>.NativeClassPtr);
			HoldItem.NativeFieldInfoPtr_Equippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoldItem>.NativeClassPtr, "Equippable");
			HoldItem.NativeFieldInfoPtr__active_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoldItem>.NativeClassPtr, "<active>k__BackingField");
			HoldItem.NativeFieldInfoPtr__npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoldItem>.NativeClassPtr, "_npc");
			HoldItem.NativeMethodInfoPtr_get_active_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoldItem>.NativeClassPtr, 100685243);
			HoldItem.NativeMethodInfoPtr_set_active_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoldItem>.NativeClassPtr, 100685244);
			HoldItem.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoldItem>.NativeClassPtr, 100685245);
			HoldItem.NativeMethodInfoPtr_Begin_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoldItem>.NativeClassPtr, 100685246);
			HoldItem.NativeMethodInfoPtr_End_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoldItem>.NativeClassPtr, 100685247);
			HoldItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoldItem>.NativeClassPtr, 100685248);
		}

		// Token: 0x170031AF RID: 12719
		// (get) Token: 0x0600A575 RID: 42357 RVA: 0x002BEB90 File Offset: 0x002BCD90
		// (set) Token: 0x0600A576 RID: 42358 RVA: 0x002BEBCC File Offset: 0x002BCDCC
		public unsafe bool active
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoldItem.NativeMethodInfoPtr_get_active_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 33070, RefRangeEnd = 33090, XrefRangeStart = 33070, XrefRangeEnd = 33090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoldItem.NativeMethodInfoPtr_set_active_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A577 RID: 42359 RVA: 0x002BEC0C File Offset: 0x002BCE0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289610, XrefRangeEnd = 289614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoldItem.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A578 RID: 42360 RVA: 0x002BEC40 File Offset: 0x002BCE40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289614, XrefRangeEnd = 289619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoldItem.NativeMethodInfoPtr_Begin_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A579 RID: 42361 RVA: 0x002BEC74 File Offset: 0x002BCE74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289619, XrefRangeEnd = 289623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoldItem.NativeMethodInfoPtr_End_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A57A RID: 42362 RVA: 0x002BECA8 File Offset: 0x002BCEA8
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HoldItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HoldItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoldItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A57B RID: 42363 RVA: 0x0004B8CC File Offset: 0x00049ACC
		public HoldItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170031AC RID: 12716
		// (get) Token: 0x0600A57C RID: 42364 RVA: 0x002BECE4 File Offset: 0x002BCEE4
		// (set) Token: 0x0600A57D RID: 42365 RVA: 0x0004B8D5 File Offset: 0x00049AD5
		public unsafe AvatarEquippable Equippable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoldItem.NativeFieldInfoPtr_Equippable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoldItem.NativeFieldInfoPtr_Equippable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031AD RID: 12717
		// (get) Token: 0x0600A57E RID: 42366 RVA: 0x002BED14 File Offset: 0x002BCF14
		// (set) Token: 0x0600A57F RID: 42367 RVA: 0x0004B8F4 File Offset: 0x00049AF4
		public unsafe bool _active_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoldItem.NativeFieldInfoPtr__active_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoldItem.NativeFieldInfoPtr__active_k__BackingField)) = value;
			}
		}

		// Token: 0x170031AE RID: 12718
		// (get) Token: 0x0600A580 RID: 42368 RVA: 0x002BED3C File Offset: 0x002BCF3C
		// (set) Token: 0x0600A581 RID: 42369 RVA: 0x0004B90F File Offset: 0x00049B0F
		public unsafe NPC _npc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoldItem.NativeFieldInfoPtr__npc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoldItem.NativeFieldInfoPtr__npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007274 RID: 29300
		private static readonly IntPtr NativeFieldInfoPtr_Equippable;

		// Token: 0x04007275 RID: 29301
		private static readonly IntPtr NativeFieldInfoPtr__active_k__BackingField;

		// Token: 0x04007276 RID: 29302
		private static readonly IntPtr NativeFieldInfoPtr__npc;

		// Token: 0x04007277 RID: 29303
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_get_Boolean_0;

		// Token: 0x04007278 RID: 29304
		private static readonly IntPtr NativeMethodInfoPtr_set_active_Protected_set_Void_Boolean_0;

		// Token: 0x04007279 RID: 29305
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400727A RID: 29306
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Void_0;

		// Token: 0x0400727B RID: 29307
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Void_0;

		// Token: 0x0400727C RID: 29308
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
