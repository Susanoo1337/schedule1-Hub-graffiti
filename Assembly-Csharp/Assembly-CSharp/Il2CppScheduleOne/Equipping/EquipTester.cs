using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Core.Equipping.Framework;
using UnityEngine;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x02000586 RID: 1414
	public class EquipTester : MonoBehaviour
	{
		// Token: 0x0600810F RID: 33039 RVA: 0x00235EF4 File Offset: 0x002340F4
		// Note: this type is marked as 'beforefieldinit'.
		static EquipTester()
		{
			Il2CppClassPointerStore<EquipTester>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "EquipTester");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EquipTester>.NativeClassPtr);
			EquipTester.NativeFieldInfoPtr_TestEquippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipTester>.NativeClassPtr, "TestEquippable");
			EquipTester.NativeFieldInfoPtr__equippedItemHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipTester>.NativeClassPtr, "_equippedItemHandler");
			EquipTester.NativeMethodInfoPtr_Equip_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipTester>.NativeClassPtr, 100679874);
			EquipTester.NativeMethodInfoPtr_EquipLocally_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipTester>.NativeClassPtr, 100679875);
			EquipTester.NativeMethodInfoPtr_Unequip_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipTester>.NativeClassPtr, 100679876);
			EquipTester.NativeMethodInfoPtr_UnequipAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipTester>.NativeClassPtr, 100679877);
			EquipTester.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipTester>.NativeClassPtr, 100679878);
		}

		// Token: 0x06008110 RID: 33040 RVA: 0x00235FB0 File Offset: 0x002341B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244677, XrefRangeEnd = 244685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Equip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquipTester.NativeMethodInfoPtr_Equip_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008111 RID: 33041 RVA: 0x00235FE4 File Offset: 0x002341E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244685, XrefRangeEnd = 244693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EquipLocally()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquipTester.NativeMethodInfoPtr_EquipLocally_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008112 RID: 33042 RVA: 0x00236018 File Offset: 0x00234218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244693, XrefRangeEnd = 244701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquipTester.NativeMethodInfoPtr_Unequip_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008113 RID: 33043 RVA: 0x0023604C File Offset: 0x0023424C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244701, XrefRangeEnd = 244708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnequipAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquipTester.NativeMethodInfoPtr_UnequipAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008114 RID: 33044 RVA: 0x00236080 File Offset: 0x00234280
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EquipTester() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EquipTester>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquipTester.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008115 RID: 33045 RVA: 0x0003D706 File Offset: 0x0003B906
		public EquipTester(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027ED RID: 10221
		// (get) Token: 0x06008116 RID: 33046 RVA: 0x002360BC File Offset: 0x002342BC
		// (set) Token: 0x06008117 RID: 33047 RVA: 0x0003D70F File Offset: 0x0003B90F
		public unsafe EquippableData TestEquippable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EquipTester.NativeFieldInfoPtr_TestEquippable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EquippableData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EquipTester.NativeFieldInfoPtr_TestEquippable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027EE RID: 10222
		// (get) Token: 0x06008118 RID: 33048 RVA: 0x002360EC File Offset: 0x002342EC
		// (set) Token: 0x06008119 RID: 33049 RVA: 0x0003D72E File Offset: 0x0003B92E
		public unsafe IEquippedItemHandler _equippedItemHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EquipTester.NativeFieldInfoPtr__equippedItemHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEquippedItemHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EquipTester.NativeFieldInfoPtr__equippedItemHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040057F8 RID: 22520
		private static readonly IntPtr NativeFieldInfoPtr_TestEquippable;

		// Token: 0x040057F9 RID: 22521
		private static readonly IntPtr NativeFieldInfoPtr__equippedItemHandler;

		// Token: 0x040057FA RID: 22522
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Void_0;

		// Token: 0x040057FB RID: 22523
		private static readonly IntPtr NativeMethodInfoPtr_EquipLocally_Public_Void_0;

		// Token: 0x040057FC RID: 22524
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Void_0;

		// Token: 0x040057FD RID: 22525
		private static readonly IntPtr NativeMethodInfoPtr_UnequipAll_Public_Void_0;

		// Token: 0x040057FE RID: 22526
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
