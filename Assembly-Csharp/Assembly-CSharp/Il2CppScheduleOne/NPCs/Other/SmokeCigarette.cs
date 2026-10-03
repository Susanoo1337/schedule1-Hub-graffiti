using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Core.Equipping.Framework;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Other
{
	// Token: 0x020006A1 RID: 1697
	public class SmokeCigarette : MonoBehaviour
	{
		// Token: 0x0600A58F RID: 42383 RVA: 0x002BF09C File Offset: 0x002BD29C
		// Note: this type is marked as 'beforefieldinit'.
		static SmokeCigarette()
		{
			Il2CppClassPointerStore<SmokeCigarette>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Other", "SmokeCigarette");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmokeCigarette>.NativeClassPtr);
			SmokeCigarette.NativeFieldInfoPtr__cigarette = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmokeCigarette>.NativeClassPtr, "_cigarette");
			SmokeCigarette.NativeFieldInfoPtr__npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmokeCigarette>.NativeClassPtr, "_npc");
			SmokeCigarette.NativeFieldInfoPtr__equippedItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmokeCigarette>.NativeClassPtr, "_equippedItem");
			SmokeCigarette.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmokeCigarette>.NativeClassPtr, 100685258);
			SmokeCigarette.NativeMethodInfoPtr_Begin_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmokeCigarette>.NativeClassPtr, 100685259);
			SmokeCigarette.NativeMethodInfoPtr_End_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmokeCigarette>.NativeClassPtr, 100685260);
			SmokeCigarette.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmokeCigarette>.NativeClassPtr, 100685261);
		}

		// Token: 0x0600A590 RID: 42384 RVA: 0x002BF158 File Offset: 0x002BD358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289628, XrefRangeEnd = 289632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmokeCigarette.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A591 RID: 42385 RVA: 0x002BF18C File Offset: 0x002BD38C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 289636, RefRangeEnd = 289637, XrefRangeStart = 289632, XrefRangeEnd = 289636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmokeCigarette.NativeMethodInfoPtr_Begin_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A592 RID: 42386 RVA: 0x002BF1C0 File Offset: 0x002BD3C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 289640, RefRangeEnd = 289643, XrefRangeStart = 289637, XrefRangeEnd = 289640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmokeCigarette.NativeMethodInfoPtr_End_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A593 RID: 42387 RVA: 0x002BF1F4 File Offset: 0x002BD3F4
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SmokeCigarette() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmokeCigarette>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmokeCigarette.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A594 RID: 42388 RVA: 0x0004B952 File Offset: 0x00049B52
		public SmokeCigarette(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170031B2 RID: 12722
		// (get) Token: 0x0600A595 RID: 42389 RVA: 0x002BF230 File Offset: 0x002BD430
		// (set) Token: 0x0600A596 RID: 42390 RVA: 0x0004B95B File Offset: 0x00049B5B
		public unsafe EquippableData _cigarette
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeCigarette.NativeFieldInfoPtr__cigarette);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EquippableData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeCigarette.NativeFieldInfoPtr__cigarette), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031B3 RID: 12723
		// (get) Token: 0x0600A597 RID: 42391 RVA: 0x002BF260 File Offset: 0x002BD460
		// (set) Token: 0x0600A598 RID: 42392 RVA: 0x0004B97A File Offset: 0x00049B7A
		public unsafe NPC _npc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeCigarette.NativeFieldInfoPtr__npc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeCigarette.NativeFieldInfoPtr__npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031B4 RID: 12724
		// (get) Token: 0x0600A599 RID: 42393 RVA: 0x002BF290 File Offset: 0x002BD490
		// (set) Token: 0x0600A59A RID: 42394 RVA: 0x0004B999 File Offset: 0x00049B99
		public unsafe IEquippedItemHandler _equippedItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeCigarette.NativeFieldInfoPtr__equippedItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEquippedItemHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeCigarette.NativeFieldInfoPtr__equippedItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007287 RID: 29319
		private static readonly IntPtr NativeFieldInfoPtr__cigarette;

		// Token: 0x04007288 RID: 29320
		private static readonly IntPtr NativeFieldInfoPtr__npc;

		// Token: 0x04007289 RID: 29321
		private static readonly IntPtr NativeFieldInfoPtr__equippedItem;

		// Token: 0x0400728A RID: 29322
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400728B RID: 29323
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Void_0;

		// Token: 0x0400728C RID: 29324
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Void_0;

		// Token: 0x0400728D RID: 29325
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
