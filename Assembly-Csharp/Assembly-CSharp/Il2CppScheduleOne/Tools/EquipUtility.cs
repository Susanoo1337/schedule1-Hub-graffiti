using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004DE RID: 1246
	public class EquipUtility : MonoBehaviour
	{
		// Token: 0x0600719F RID: 29087 RVA: 0x00200C2C File Offset: 0x001FEE2C
		// Note: this type is marked as 'beforefieldinit'.
		static EquipUtility()
		{
			Il2CppClassPointerStore<EquipUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "EquipUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EquipUtility>.NativeClassPtr);
			EquipUtility.NativeFieldInfoPtr_Equippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipUtility>.NativeClassPtr, "Equippable");
			EquipUtility.NativeMethodInfoPtr_Equip_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipUtility>.NativeClassPtr, 100677977);
			EquipUtility.NativeMethodInfoPtr_Unequip_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipUtility>.NativeClassPtr, 100677978);
			EquipUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipUtility>.NativeClassPtr, 100677979);
		}

		// Token: 0x060071A0 RID: 29088 RVA: 0x00200CAC File Offset: 0x001FEEAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225557, XrefRangeEnd = 225561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Equip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquipUtility.NativeMethodInfoPtr_Equip_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071A1 RID: 29089 RVA: 0x00200CE0 File Offset: 0x001FEEE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225561, XrefRangeEnd = 225567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquipUtility.NativeMethodInfoPtr_Unequip_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071A2 RID: 29090 RVA: 0x00200D14 File Offset: 0x001FEF14
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EquipUtility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EquipUtility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquipUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071A3 RID: 29091 RVA: 0x00036104 File Offset: 0x00034304
		public EquipUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700231C RID: 8988
		// (get) Token: 0x060071A4 RID: 29092 RVA: 0x00200D50 File Offset: 0x001FEF50
		// (set) Token: 0x060071A5 RID: 29093 RVA: 0x0003610D File Offset: 0x0003430D
		public unsafe AvatarEquippable Equippable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EquipUtility.NativeFieldInfoPtr_Equippable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EquipUtility.NativeFieldInfoPtr_Equippable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004DA6 RID: 19878
		private static readonly IntPtr NativeFieldInfoPtr_Equippable;

		// Token: 0x04004DA7 RID: 19879
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Void_0;

		// Token: 0x04004DA8 RID: 19880
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Void_0;

		// Token: 0x04004DA9 RID: 19881
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
