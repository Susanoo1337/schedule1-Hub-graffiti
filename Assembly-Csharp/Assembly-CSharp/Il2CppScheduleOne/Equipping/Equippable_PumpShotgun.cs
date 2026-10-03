using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x02000580 RID: 1408
	public class Equippable_PumpShotgun : Equippable_RangedWeapon
	{
		// Token: 0x06008045 RID: 32837 RVA: 0x00233ABC File Offset: 0x00231CBC
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_PumpShotgun()
		{
			Il2CppClassPointerStore<Equippable_PumpShotgun>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_PumpShotgun");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_PumpShotgun>.NativeClassPtr);
			Equippable_PumpShotgun.NativeFieldInfoPtr_PelletCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_PumpShotgun>.NativeClassPtr, "PelletCount");
			Equippable_PumpShotgun.NativeMethodInfoPtr_GetBulletDirections_Protected_Virtual_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_PumpShotgun>.NativeClassPtr, 100679799);
			Equippable_PumpShotgun.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_PumpShotgun>.NativeClassPtr, 100679800);
		}

		// Token: 0x06008046 RID: 32838 RVA: 0x00233B28 File Offset: 0x00231D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243862, XrefRangeEnd = 243873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<Vector3> GetBulletDirections()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_PumpShotgun.NativeMethodInfoPtr_GetBulletDirections_Protected_Virtual_Il2CppStructArray_1_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06008047 RID: 32839 RVA: 0x00233B74 File Offset: 0x00231D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243873, XrefRangeEnd = 243874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_PumpShotgun() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_PumpShotgun>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_PumpShotgun.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008048 RID: 32840 RVA: 0x0003CFA0 File Offset: 0x0003B1A0
		public Equippable_PumpShotgun(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027A2 RID: 10146
		// (get) Token: 0x06008049 RID: 32841 RVA: 0x00233BB0 File Offset: 0x00231DB0
		// (set) Token: 0x0600804A RID: 32842 RVA: 0x0003CFA9 File Offset: 0x0003B1A9
		public unsafe int PelletCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_PumpShotgun.NativeFieldInfoPtr_PelletCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_PumpShotgun.NativeFieldInfoPtr_PelletCount)) = value;
			}
		}

		// Token: 0x0400577C RID: 22396
		private static readonly IntPtr NativeFieldInfoPtr_PelletCount;

		// Token: 0x0400577D RID: 22397
		private static readonly IntPtr NativeMethodInfoPtr_GetBulletDirections_Protected_Virtual_Il2CppStructArray_1_Vector3_0;

		// Token: 0x0400577E RID: 22398
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
