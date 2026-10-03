using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x02000582 RID: 1410
	public class Equippable_Revolver : Equippable_RangedWeapon
	{
		// Token: 0x060080DF RID: 32991 RVA: 0x00235518 File Offset: 0x00233718
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_Revolver()
		{
			Il2CppClassPointerStore<Equippable_Revolver>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_Revolver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_Revolver>.NativeClassPtr);
			Equippable_Revolver.NativeFieldInfoPtr_Bullets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Revolver>.NativeClassPtr, "Bullets");
			Equippable_Revolver.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Revolver>.NativeClassPtr, 100679854);
			Equippable_Revolver.NativeMethodInfoPtr_Fire_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Revolver>.NativeClassPtr, 100679855);
			Equippable_Revolver.NativeMethodInfoPtr_Reload_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Revolver>.NativeClassPtr, 100679856);
			Equippable_Revolver.NativeMethodInfoPtr_NotifyIncrementalReload_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Revolver>.NativeClassPtr, 100679857);
			Equippable_Revolver.NativeMethodInfoPtr_SetDisplayedBullets_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Revolver>.NativeClassPtr, 100679858);
			Equippable_Revolver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Revolver>.NativeClassPtr, 100679859);
		}

		// Token: 0x060080E0 RID: 32992 RVA: 0x002355D4 File Offset: 0x002337D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244505, XrefRangeEnd = 244508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Revolver.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080E1 RID: 32993 RVA: 0x00235624 File Offset: 0x00233824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244508, XrefRangeEnd = 244511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Fire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Revolver.NativeMethodInfoPtr_Fire_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080E2 RID: 32994 RVA: 0x00235660 File Offset: 0x00233860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244511, XrefRangeEnd = 244526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Revolver.NativeMethodInfoPtr_Reload_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080E3 RID: 32995 RVA: 0x0023569C File Offset: 0x0023389C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244526, XrefRangeEnd = 244528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NotifyIncrementalReload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Revolver.NativeMethodInfoPtr_NotifyIncrementalReload_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080E4 RID: 32996 RVA: 0x002356D8 File Offset: 0x002338D8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 244531, RefRangeEnd = 244535, XrefRangeStart = 244528, XrefRangeEnd = 244531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDisplayedBullets(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Revolver.NativeMethodInfoPtr_SetDisplayedBullets_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080E5 RID: 32997 RVA: 0x00235718 File Offset: 0x00233918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244535, XrefRangeEnd = 244536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_Revolver() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_Revolver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Revolver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080E6 RID: 32998 RVA: 0x0003D5CD File Offset: 0x0003B7CD
		public Equippable_Revolver(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027E2 RID: 10210
		// (get) Token: 0x060080E7 RID: 32999 RVA: 0x00235754 File Offset: 0x00233954
		// (set) Token: 0x060080E8 RID: 33000 RVA: 0x0003D5D6 File Offset: 0x0003B7D6
		public unsafe Il2CppReferenceArray<Transform> Bullets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Revolver.NativeFieldInfoPtr_Bullets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Revolver.NativeFieldInfoPtr_Bullets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040057DA RID: 22490
		private static readonly IntPtr NativeFieldInfoPtr_Bullets;

		// Token: 0x040057DB RID: 22491
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x040057DC RID: 22492
		private static readonly IntPtr NativeMethodInfoPtr_Fire_Public_Virtual_Void_0;

		// Token: 0x040057DD RID: 22493
		private static readonly IntPtr NativeMethodInfoPtr_Reload_Public_Virtual_Void_0;

		// Token: 0x040057DE RID: 22494
		private static readonly IntPtr NativeMethodInfoPtr_NotifyIncrementalReload_Protected_Virtual_Void_0;

		// Token: 0x040057DF RID: 22495
		private static readonly IntPtr NativeMethodInfoPtr_SetDisplayedBullets_Private_Void_Int32_0;

		// Token: 0x040057E0 RID: 22496
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
