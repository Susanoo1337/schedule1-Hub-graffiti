using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x02000585 RID: 1413
	public class Equippable_Viewmodel : Equippable
	{
		// Token: 0x06008100 RID: 33024 RVA: 0x00235C28 File Offset: 0x00233E28
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_Viewmodel()
		{
			Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_Viewmodel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr);
			Equippable_Viewmodel.NativeFieldInfoPtr_localPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr, "localPosition");
			Equippable_Viewmodel.NativeFieldInfoPtr_localEulerAngles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr, "localEulerAngles");
			Equippable_Viewmodel.NativeFieldInfoPtr_localScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr, "localScale");
			Equippable_Viewmodel.NativeFieldInfoPtr_AvatarEquippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr, "AvatarEquippable");
			Equippable_Viewmodel.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr, 100679869);
			Equippable_Viewmodel.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr, 100679870);
			Equippable_Viewmodel.NativeMethodInfoPtr_PlayEquipAnimation_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr, 100679871);
			Equippable_Viewmodel.NativeMethodInfoPtr_PlayUnequipAnimation_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr, 100679872);
			Equippable_Viewmodel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr, 100679873);
		}

		// Token: 0x06008101 RID: 33025 RVA: 0x00235D0C File Offset: 0x00233F0C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 244642, RefRangeEnd = 244652, XrefRangeStart = 244610, XrefRangeEnd = 244642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Viewmodel.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008102 RID: 33026 RVA: 0x00235D5C File Offset: 0x00233F5C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 244653, RefRangeEnd = 244657, XrefRangeStart = 244652, XrefRangeEnd = 244653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Viewmodel.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008103 RID: 33027 RVA: 0x00235D98 File Offset: 0x00233F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244657, XrefRangeEnd = 244666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PlayEquipAnimation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Viewmodel.NativeMethodInfoPtr_PlayEquipAnimation_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008104 RID: 33028 RVA: 0x00235DD4 File Offset: 0x00233FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244666, XrefRangeEnd = 244677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PlayUnequipAnimation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Viewmodel.NativeMethodInfoPtr_PlayUnequipAnimation_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008105 RID: 33029 RVA: 0x00235E10 File Offset: 0x00234010
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 243221, RefRangeEnd = 243226, XrefRangeStart = 243221, XrefRangeEnd = 243226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_Viewmodel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Viewmodel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008106 RID: 33030 RVA: 0x0003D68D File Offset: 0x0003B88D
		public Equippable_Viewmodel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027E9 RID: 10217
		// (get) Token: 0x06008107 RID: 33031 RVA: 0x00235E4C File Offset: 0x0023404C
		// (set) Token: 0x06008108 RID: 33032 RVA: 0x0003D696 File Offset: 0x0003B896
		public unsafe Vector3 localPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Viewmodel.NativeFieldInfoPtr_localPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Viewmodel.NativeFieldInfoPtr_localPosition)) = value;
			}
		}

		// Token: 0x170027EA RID: 10218
		// (get) Token: 0x06008109 RID: 33033 RVA: 0x00235E74 File Offset: 0x00234074
		// (set) Token: 0x0600810A RID: 33034 RVA: 0x0003D6B1 File Offset: 0x0003B8B1
		public unsafe Vector3 localEulerAngles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Viewmodel.NativeFieldInfoPtr_localEulerAngles);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Viewmodel.NativeFieldInfoPtr_localEulerAngles)) = value;
			}
		}

		// Token: 0x170027EB RID: 10219
		// (get) Token: 0x0600810B RID: 33035 RVA: 0x00235E9C File Offset: 0x0023409C
		// (set) Token: 0x0600810C RID: 33036 RVA: 0x0003D6CC File Offset: 0x0003B8CC
		public unsafe Vector3 localScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Viewmodel.NativeFieldInfoPtr_localScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Viewmodel.NativeFieldInfoPtr_localScale)) = value;
			}
		}

		// Token: 0x170027EC RID: 10220
		// (get) Token: 0x0600810D RID: 33037 RVA: 0x00235EC4 File Offset: 0x002340C4
		// (set) Token: 0x0600810E RID: 33038 RVA: 0x0003D6E7 File Offset: 0x0003B8E7
		public unsafe AvatarEquippable AvatarEquippable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Viewmodel.NativeFieldInfoPtr_AvatarEquippable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Viewmodel.NativeFieldInfoPtr_AvatarEquippable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040057EF RID: 22511
		private static readonly IntPtr NativeFieldInfoPtr_localPosition;

		// Token: 0x040057F0 RID: 22512
		private static readonly IntPtr NativeFieldInfoPtr_localEulerAngles;

		// Token: 0x040057F1 RID: 22513
		private static readonly IntPtr NativeFieldInfoPtr_localScale;

		// Token: 0x040057F2 RID: 22514
		private static readonly IntPtr NativeFieldInfoPtr_AvatarEquippable;

		// Token: 0x040057F3 RID: 22515
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x040057F4 RID: 22516
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x040057F5 RID: 22517
		private static readonly IntPtr NativeMethodInfoPtr_PlayEquipAnimation_Protected_Virtual_New_Void_0;

		// Token: 0x040057F6 RID: 22518
		private static readonly IntPtr NativeMethodInfoPtr_PlayUnequipAnimation_Protected_Virtual_New_Void_0;

		// Token: 0x040057F7 RID: 22519
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
