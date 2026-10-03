using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x02000499 RID: 1177
	public class CharacterCustomizationShop : MonoBehaviour
	{
		// Token: 0x06006BA5 RID: 27557 RVA: 0x001EFE10 File Offset: 0x001EE010
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterCustomizationShop()
		{
			Il2CppClassPointerStore<CharacterCustomizationShop>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "CharacterCustomizationShop");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCustomizationShop>.NativeClassPtr);
			CharacterCustomizationShop.NativeFieldInfoPtr_CameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationShop>.NativeClassPtr, "CameraPosition");
			CharacterCustomizationShop.NativeFieldInfoPtr_RigContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationShop>.NativeClassPtr, "RigContainer");
			CharacterCustomizationShop.NativeFieldInfoPtr_AvatarRig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationShop>.NativeClassPtr, "AvatarRig");
			CharacterCustomizationShop.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationShop>.NativeClassPtr, 100677377);
		}

		// Token: 0x06006BA6 RID: 27558 RVA: 0x001EFE90 File Offset: 0x001EE090
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterCustomizationShop() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCustomizationShop>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationShop.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BA7 RID: 27559 RVA: 0x00032ACF File Offset: 0x00030CCF
		public CharacterCustomizationShop(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700211C RID: 8476
		// (get) Token: 0x06006BA8 RID: 27560 RVA: 0x001EFECC File Offset: 0x001EE0CC
		// (set) Token: 0x06006BA9 RID: 27561 RVA: 0x00032AD8 File Offset: 0x00030CD8
		public unsafe Transform CameraPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationShop.NativeFieldInfoPtr_CameraPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationShop.NativeFieldInfoPtr_CameraPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700211D RID: 8477
		// (get) Token: 0x06006BAA RID: 27562 RVA: 0x001EFEFC File Offset: 0x001EE0FC
		// (set) Token: 0x06006BAB RID: 27563 RVA: 0x00032AF7 File Offset: 0x00030CF7
		public unsafe Transform RigContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationShop.NativeFieldInfoPtr_RigContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationShop.NativeFieldInfoPtr_RigContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700211E RID: 8478
		// (get) Token: 0x06006BAC RID: 27564 RVA: 0x001EFF2C File Offset: 0x001EE12C
		// (set) Token: 0x06006BAD RID: 27565 RVA: 0x00032B16 File Offset: 0x00030D16
		public unsafe Avatar AvatarRig
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationShop.NativeFieldInfoPtr_AvatarRig);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationShop.NativeFieldInfoPtr_AvatarRig), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004A10 RID: 18960
		private static readonly IntPtr NativeFieldInfoPtr_CameraPosition;

		// Token: 0x04004A11 RID: 18961
		private static readonly IntPtr NativeFieldInfoPtr_RigContainer;

		// Token: 0x04004A12 RID: 18962
		private static readonly IntPtr NativeFieldInfoPtr_AvatarRig;

		// Token: 0x04004A13 RID: 18963
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
