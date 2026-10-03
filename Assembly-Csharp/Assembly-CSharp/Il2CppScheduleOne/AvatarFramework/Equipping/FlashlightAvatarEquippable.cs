using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x020004C1 RID: 1217
	public class FlashlightAvatarEquippable : AvatarEquippable
	{
		// Token: 0x06006F90 RID: 28560 RVA: 0x001FAE74 File Offset: 0x001F9074
		// Note: this type is marked as 'beforefieldinit'.
		static FlashlightAvatarEquippable()
		{
			Il2CppClassPointerStore<FlashlightAvatarEquippable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Equipping", "FlashlightAvatarEquippable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlashlightAvatarEquippable>.NativeClassPtr);
			FlashlightAvatarEquippable.NativeFieldInfoPtr_Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlashlightAvatarEquippable>.NativeClassPtr, "Light");
			FlashlightAvatarEquippable.NativeFieldInfoPtr_lightOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlashlightAvatarEquippable>.NativeClassPtr, "lightOffset");
			FlashlightAvatarEquippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_Avatar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlashlightAvatarEquippable>.NativeClassPtr, 100677749);
			FlashlightAvatarEquippable.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlashlightAvatarEquippable>.NativeClassPtr, 100677750);
			FlashlightAvatarEquippable.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlashlightAvatarEquippable>.NativeClassPtr, 100677751);
			FlashlightAvatarEquippable.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlashlightAvatarEquippable>.NativeClassPtr, 100677752);
			FlashlightAvatarEquippable.NativeMethodInfoPtr_UpdateLightPosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlashlightAvatarEquippable>.NativeClassPtr, 100677753);
			FlashlightAvatarEquippable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlashlightAvatarEquippable>.NativeClassPtr, 100677754);
		}

		// Token: 0x06006F91 RID: 28561 RVA: 0x001FAF44 File Offset: 0x001F9144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223820, XrefRangeEnd = 223852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(Avatar _avatar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_avatar);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FlashlightAvatarEquippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_Avatar_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F92 RID: 28562 RVA: 0x001FAF94 File Offset: 0x001F9194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223852, XrefRangeEnd = 223859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FlashlightAvatarEquippable.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F93 RID: 28563 RVA: 0x001FAFD0 File Offset: 0x001F91D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223859, XrefRangeEnd = 223860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlashlightAvatarEquippable.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F94 RID: 28564 RVA: 0x001FB004 File Offset: 0x001F9204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlashlightAvatarEquippable.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F95 RID: 28565 RVA: 0x001FB038 File Offset: 0x001F9238
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 223868, RefRangeEnd = 223871, XrefRangeStart = 223860, XrefRangeEnd = 223868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLightPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlashlightAvatarEquippable.NativeMethodInfoPtr_UpdateLightPosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F96 RID: 28566 RVA: 0x001FB06C File Offset: 0x001F926C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223871, XrefRangeEnd = 223872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlashlightAvatarEquippable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlashlightAvatarEquippable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlashlightAvatarEquippable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F97 RID: 28567 RVA: 0x00034E91 File Offset: 0x00033091
		public FlashlightAvatarEquippable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002277 RID: 8823
		// (get) Token: 0x06006F98 RID: 28568 RVA: 0x001FB0A8 File Offset: 0x001F92A8
		// (set) Token: 0x06006F99 RID: 28569 RVA: 0x00034E9A File Offset: 0x0003309A
		public unsafe OptimizedLight Light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashlightAvatarEquippable.NativeFieldInfoPtr_Light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OptimizedLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashlightAvatarEquippable.NativeFieldInfoPtr_Light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002278 RID: 8824
		// (get) Token: 0x06006F9A RID: 28570 RVA: 0x001FB0D8 File Offset: 0x001F92D8
		// (set) Token: 0x06006F9B RID: 28571 RVA: 0x00034EB9 File Offset: 0x000330B9
		public unsafe Vector3 lightOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashlightAvatarEquippable.NativeFieldInfoPtr_lightOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashlightAvatarEquippable.NativeFieldInfoPtr_lightOffset)) = value;
			}
		}

		// Token: 0x04004C67 RID: 19559
		private static readonly IntPtr NativeFieldInfoPtr_Light;

		// Token: 0x04004C68 RID: 19560
		private static readonly IntPtr NativeFieldInfoPtr_lightOffset;

		// Token: 0x04004C69 RID: 19561
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_Avatar_0;

		// Token: 0x04004C6A RID: 19562
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x04004C6B RID: 19563
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04004C6C RID: 19564
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04004C6D RID: 19565
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLightPosition_Private_Void_0;

		// Token: 0x04004C6E RID: 19566
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
