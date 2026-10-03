using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.State;
using UnityEngine;

namespace Il2CppScheduleOne.Skating
{
	// Token: 0x02000132 RID: 306
	public class Skateboard_Equippable : Equippable_Viewmodel
	{
		// Token: 0x06001EB0 RID: 7856 RVA: 0x000DFABC File Offset: 0x000DDCBC
		// Note: this type is marked as 'beforefieldinit'.
		static Skateboard_Equippable()
		{
			Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Skating", "Skateboard_Equippable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr);
			Skateboard_Equippable.NativeFieldInfoPtr_ModelLerpSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "ModelLerpSpeed");
			Skateboard_Equippable.NativeFieldInfoPtr_SurfaceSampleDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "SurfaceSampleDistance");
			Skateboard_Equippable.NativeFieldInfoPtr_SurfaceSampleRayLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "SurfaceSampleRayLength");
			Skateboard_Equippable.NativeFieldInfoPtr_BoardSpawnUpwardsShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "BoardSpawnUpwardsShift");
			Skateboard_Equippable.NativeFieldInfoPtr_BoardSpawnAngleLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "BoardSpawnAngleLimit");
			Skateboard_Equippable.NativeFieldInfoPtr_MountTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "MountTime");
			Skateboard_Equippable.NativeFieldInfoPtr_BoardMomentumTransfer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "BoardMomentumTransfer");
			Skateboard_Equippable.NativeFieldInfoPtr_DismountAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "DismountAngle");
			Skateboard_Equippable.NativeFieldInfoPtr__IsRiding_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "<IsRiding>k__BackingField");
			Skateboard_Equippable.NativeFieldInfoPtr__ActiveSkateboard_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "<ActiveSkateboard>k__BackingField");
			Skateboard_Equippable.NativeFieldInfoPtr_SkateboardPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "SkateboardPrefab");
			Skateboard_Equippable.NativeFieldInfoPtr_blockDismount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "blockDismount");
			Skateboard_Equippable.NativeFieldInfoPtr_ModelContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "ModelContainer");
			Skateboard_Equippable.NativeFieldInfoPtr_ModelPosition_Raised = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "ModelPosition_Raised");
			Skateboard_Equippable.NativeFieldInfoPtr_ModelPosition_Lowered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "ModelPosition_Lowered");
			Skateboard_Equippable.NativeFieldInfoPtr_mountTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "mountTime");
			Skateboard_Equippable.NativeFieldInfoPtr__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "_state");
			Skateboard_Equippable.NativeMethodInfoPtr_get_IsRiding_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, 100667252);
			Skateboard_Equippable.NativeMethodInfoPtr_set_IsRiding_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, 100667253);
			Skateboard_Equippable.NativeMethodInfoPtr_get_ActiveSkateboard_Public_get_Skateboard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, 100667254);
			Skateboard_Equippable.NativeMethodInfoPtr_set_ActiveSkateboard_Private_set_Void_Skateboard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, 100667255);
			Skateboard_Equippable.NativeMethodInfoPtr_get_State_Public_get_MonoState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, 100667256);
			Skateboard_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, 100667257);
			Skateboard_Equippable.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, 100667258);
			Skateboard_Equippable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, 100667259);
			Skateboard_Equippable.NativeMethodInfoPtr_UpdateModel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, 100667260);
			Skateboard_Equippable.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, 100667261);
			Skateboard_Equippable.NativeMethodInfoPtr_Mount_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, 100667262);
			Skateboard_Equippable.NativeMethodInfoPtr_Dismount_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, 100667263);
			Skateboard_Equippable.NativeMethodInfoPtr_OnMount_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, 100667264);
			Skateboard_Equippable.NativeMethodInfoPtr_OnDismount_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, 100667265);
			Skateboard_Equippable.NativeMethodInfoPtr_CanMountHere_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, 100667266);
			Skateboard_Equippable.NativeMethodInfoPtr_GetSkateboardSpawnPose_Private_Pose_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, 100667267);
			Skateboard_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, 100667268);
		}

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x06001EB1 RID: 7857 RVA: 0x000DFD94 File Offset: 0x000DDF94
		// (set) Token: 0x06001EB2 RID: 7858 RVA: 0x000DFDD0 File Offset: 0x000DDFD0
		public unsafe bool IsRiding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard_Equippable.NativeMethodInfoPtr_get_IsRiding_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard_Equippable.NativeMethodInfoPtr_set_IsRiding_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x06001EB3 RID: 7859 RVA: 0x000DFE10 File Offset: 0x000DE010
		// (set) Token: 0x06001EB4 RID: 7860 RVA: 0x000DFE50 File Offset: 0x000DE050
		public unsafe Skateboard ActiveSkateboard
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 21999, RefRangeEnd = 22015, XrefRangeStart = 21999, XrefRangeEnd = 22015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard_Equippable.NativeMethodInfoPtr_get_ActiveSkateboard_Public_get_Skateboard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Skateboard>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105299, XrefRangeEnd = 105300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard_Equippable.NativeMethodInfoPtr_set_ActiveSkateboard_Private_set_Void_Skateboard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x06001EB5 RID: 7861 RVA: 0x000DFE94 File Offset: 0x000DE094
		public unsafe MonoState State
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 38414, RefRangeEnd = 38415, XrefRangeStart = 38414, XrefRangeEnd = 38415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard_Equippable.NativeMethodInfoPtr_get_State_Public_get_MonoState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoState>(intPtr3) : null;
			}
		}

		// Token: 0x06001EB6 RID: 7862 RVA: 0x000DFED4 File Offset: 0x000DE0D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105300, XrefRangeEnd = 105345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Skateboard_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EB7 RID: 7863 RVA: 0x000DFF24 File Offset: 0x000DE124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105345, XrefRangeEnd = 105348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard_Equippable.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EB8 RID: 7864 RVA: 0x000DFF68 File Offset: 0x000DE168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105348, XrefRangeEnd = 105393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Skateboard_Equippable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EB9 RID: 7865 RVA: 0x000DFFA4 File Offset: 0x000DE1A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105393, XrefRangeEnd = 105399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateModel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard_Equippable.NativeMethodInfoPtr_UpdateModel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EBA RID: 7866 RVA: 0x000DFFD8 File Offset: 0x000DE1D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105399, XrefRangeEnd = 105418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Skateboard_Equippable.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EBB RID: 7867 RVA: 0x000E0014 File Offset: 0x000DE214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105418, XrefRangeEnd = 105420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Mount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard_Equippable.NativeMethodInfoPtr_Mount_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EBC RID: 7868 RVA: 0x000E0048 File Offset: 0x000DE248
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 105422, RefRangeEnd = 105423, XrefRangeStart = 105420, XrefRangeEnd = 105422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dismount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard_Equippable.NativeMethodInfoPtr_Dismount_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x000E007C File Offset: 0x000DE27C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105423, XrefRangeEnd = 105453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard_Equippable.NativeMethodInfoPtr_OnMount_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EBE RID: 7870 RVA: 0x000E00B0 File Offset: 0x000DE2B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105453, XrefRangeEnd = 105488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDismount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard_Equippable.NativeMethodInfoPtr_OnDismount_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EBF RID: 7871 RVA: 0x000E00E4 File Offset: 0x000DE2E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105488, XrefRangeEnd = 105495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanMountHere()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard_Equippable.NativeMethodInfoPtr_CanMountHere_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EC0 RID: 7872 RVA: 0x000E0120 File Offset: 0x000DE320
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 105553, RefRangeEnd = 105556, XrefRangeStart = 105495, XrefRangeEnd = 105553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Pose GetSkateboardSpawnPose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard_Equippable.NativeMethodInfoPtr_GetSkateboardSpawnPose_Private_Pose_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EC1 RID: 7873 RVA: 0x000E015C File Offset: 0x000DE35C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105556, XrefRangeEnd = 105557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Skateboard_Equippable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EC2 RID: 7874 RVA: 0x00010A3E File Offset: 0x0000EC3E
		public Skateboard_Equippable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x06001EC3 RID: 7875 RVA: 0x000E0198 File Offset: 0x000DE398
		// (set) Token: 0x06001EC4 RID: 7876 RVA: 0x00010A47 File Offset: 0x0000EC47
		public unsafe static float ModelLerpSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard_Equippable.NativeFieldInfoPtr_ModelLerpSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard_Equippable.NativeFieldInfoPtr_ModelLerpSpeed, (void*)(&value));
			}
		}

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x06001EC5 RID: 7877 RVA: 0x000E01B4 File Offset: 0x000DE3B4
		// (set) Token: 0x06001EC6 RID: 7878 RVA: 0x00010A55 File Offset: 0x0000EC55
		public unsafe static float SurfaceSampleDistance
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard_Equippable.NativeFieldInfoPtr_SurfaceSampleDistance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard_Equippable.NativeFieldInfoPtr_SurfaceSampleDistance, (void*)(&value));
			}
		}

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x06001EC7 RID: 7879 RVA: 0x000E01D0 File Offset: 0x000DE3D0
		// (set) Token: 0x06001EC8 RID: 7880 RVA: 0x00010A63 File Offset: 0x0000EC63
		public unsafe static float SurfaceSampleRayLength
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard_Equippable.NativeFieldInfoPtr_SurfaceSampleRayLength, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard_Equippable.NativeFieldInfoPtr_SurfaceSampleRayLength, (void*)(&value));
			}
		}

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x06001EC9 RID: 7881 RVA: 0x000E01EC File Offset: 0x000DE3EC
		// (set) Token: 0x06001ECA RID: 7882 RVA: 0x00010A71 File Offset: 0x0000EC71
		public unsafe static float BoardSpawnUpwardsShift
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard_Equippable.NativeFieldInfoPtr_BoardSpawnUpwardsShift, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard_Equippable.NativeFieldInfoPtr_BoardSpawnUpwardsShift, (void*)(&value));
			}
		}

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x06001ECB RID: 7883 RVA: 0x000E0208 File Offset: 0x000DE408
		// (set) Token: 0x06001ECC RID: 7884 RVA: 0x00010A7F File Offset: 0x0000EC7F
		public unsafe static float BoardSpawnAngleLimit
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard_Equippable.NativeFieldInfoPtr_BoardSpawnAngleLimit, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard_Equippable.NativeFieldInfoPtr_BoardSpawnAngleLimit, (void*)(&value));
			}
		}

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x06001ECD RID: 7885 RVA: 0x000E0224 File Offset: 0x000DE424
		// (set) Token: 0x06001ECE RID: 7886 RVA: 0x00010A8D File Offset: 0x0000EC8D
		public unsafe static float MountTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard_Equippable.NativeFieldInfoPtr_MountTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard_Equippable.NativeFieldInfoPtr_MountTime, (void*)(&value));
			}
		}

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x06001ECF RID: 7887 RVA: 0x000E0240 File Offset: 0x000DE440
		// (set) Token: 0x06001ED0 RID: 7888 RVA: 0x00010A9B File Offset: 0x0000EC9B
		public unsafe static float BoardMomentumTransfer
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard_Equippable.NativeFieldInfoPtr_BoardMomentumTransfer, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard_Equippable.NativeFieldInfoPtr_BoardMomentumTransfer, (void*)(&value));
			}
		}

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x06001ED1 RID: 7889 RVA: 0x000E025C File Offset: 0x000DE45C
		// (set) Token: 0x06001ED2 RID: 7890 RVA: 0x00010AA9 File Offset: 0x0000ECA9
		public unsafe static float DismountAngle
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard_Equippable.NativeFieldInfoPtr_DismountAngle, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard_Equippable.NativeFieldInfoPtr_DismountAngle, (void*)(&value));
			}
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x06001ED3 RID: 7891 RVA: 0x000E0278 File Offset: 0x000DE478
		// (set) Token: 0x06001ED4 RID: 7892 RVA: 0x00010AB7 File Offset: 0x0000ECB7
		public unsafe bool _IsRiding_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr__IsRiding_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr__IsRiding_k__BackingField)) = value;
			}
		}

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x06001ED5 RID: 7893 RVA: 0x000E02A0 File Offset: 0x000DE4A0
		// (set) Token: 0x06001ED6 RID: 7894 RVA: 0x00010AD2 File Offset: 0x0000ECD2
		public unsafe Skateboard _ActiveSkateboard_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr__ActiveSkateboard_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr__ActiveSkateboard_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x06001ED7 RID: 7895 RVA: 0x000E02D0 File Offset: 0x000DE4D0
		// (set) Token: 0x06001ED8 RID: 7896 RVA: 0x00010AF1 File Offset: 0x0000ECF1
		public unsafe Skateboard SkateboardPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr_SkateboardPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr_SkateboardPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x06001ED9 RID: 7897 RVA: 0x000E0300 File Offset: 0x000DE500
		// (set) Token: 0x06001EDA RID: 7898 RVA: 0x00010B10 File Offset: 0x0000ED10
		public unsafe bool blockDismount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr_blockDismount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr_blockDismount)) = value;
			}
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x06001EDB RID: 7899 RVA: 0x000E0328 File Offset: 0x000DE528
		// (set) Token: 0x06001EDC RID: 7900 RVA: 0x00010B2B File Offset: 0x0000ED2B
		public unsafe Transform ModelContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr_ModelContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr_ModelContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x06001EDD RID: 7901 RVA: 0x000E0358 File Offset: 0x000DE558
		// (set) Token: 0x06001EDE RID: 7902 RVA: 0x00010B4A File Offset: 0x0000ED4A
		public unsafe Transform ModelPosition_Raised
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr_ModelPosition_Raised);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr_ModelPosition_Raised), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x06001EDF RID: 7903 RVA: 0x000E0388 File Offset: 0x000DE588
		// (set) Token: 0x06001EE0 RID: 7904 RVA: 0x00010B69 File Offset: 0x0000ED69
		public unsafe Transform ModelPosition_Lowered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr_ModelPosition_Lowered);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr_ModelPosition_Lowered), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x06001EE1 RID: 7905 RVA: 0x000E03B8 File Offset: 0x000DE5B8
		// (set) Token: 0x06001EE2 RID: 7906 RVA: 0x00010B88 File Offset: 0x0000ED88
		public unsafe float mountTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr_mountTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr_mountTime)) = value;
			}
		}

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x06001EE3 RID: 7907 RVA: 0x000E03E0 File Offset: 0x000DE5E0
		// (set) Token: 0x06001EE4 RID: 7908 RVA: 0x00010BA3 File Offset: 0x0000EDA3
		public unsafe MonoState _state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr__state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr__state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400153D RID: 5437
		private static readonly IntPtr NativeFieldInfoPtr_ModelLerpSpeed;

		// Token: 0x0400153E RID: 5438
		private static readonly IntPtr NativeFieldInfoPtr_SurfaceSampleDistance;

		// Token: 0x0400153F RID: 5439
		private static readonly IntPtr NativeFieldInfoPtr_SurfaceSampleRayLength;

		// Token: 0x04001540 RID: 5440
		private static readonly IntPtr NativeFieldInfoPtr_BoardSpawnUpwardsShift;

		// Token: 0x04001541 RID: 5441
		private static readonly IntPtr NativeFieldInfoPtr_BoardSpawnAngleLimit;

		// Token: 0x04001542 RID: 5442
		private static readonly IntPtr NativeFieldInfoPtr_MountTime;

		// Token: 0x04001543 RID: 5443
		private static readonly IntPtr NativeFieldInfoPtr_BoardMomentumTransfer;

		// Token: 0x04001544 RID: 5444
		private static readonly IntPtr NativeFieldInfoPtr_DismountAngle;

		// Token: 0x04001545 RID: 5445
		private static readonly IntPtr NativeFieldInfoPtr__IsRiding_k__BackingField;

		// Token: 0x04001546 RID: 5446
		private static readonly IntPtr NativeFieldInfoPtr__ActiveSkateboard_k__BackingField;

		// Token: 0x04001547 RID: 5447
		private static readonly IntPtr NativeFieldInfoPtr_SkateboardPrefab;

		// Token: 0x04001548 RID: 5448
		private static readonly IntPtr NativeFieldInfoPtr_blockDismount;

		// Token: 0x04001549 RID: 5449
		private static readonly IntPtr NativeFieldInfoPtr_ModelContainer;

		// Token: 0x0400154A RID: 5450
		private static readonly IntPtr NativeFieldInfoPtr_ModelPosition_Raised;

		// Token: 0x0400154B RID: 5451
		private static readonly IntPtr NativeFieldInfoPtr_ModelPosition_Lowered;

		// Token: 0x0400154C RID: 5452
		private static readonly IntPtr NativeFieldInfoPtr_mountTime;

		// Token: 0x0400154D RID: 5453
		private static readonly IntPtr NativeFieldInfoPtr__state;

		// Token: 0x0400154E RID: 5454
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRiding_Public_get_Boolean_0;

		// Token: 0x0400154F RID: 5455
		private static readonly IntPtr NativeMethodInfoPtr_set_IsRiding_Private_set_Void_Boolean_0;

		// Token: 0x04001550 RID: 5456
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveSkateboard_Public_get_Skateboard_0;

		// Token: 0x04001551 RID: 5457
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveSkateboard_Private_set_Void_Skateboard_0;

		// Token: 0x04001552 RID: 5458
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_get_MonoState_0;

		// Token: 0x04001553 RID: 5459
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04001554 RID: 5460
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04001555 RID: 5461
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04001556 RID: 5462
		private static readonly IntPtr NativeMethodInfoPtr_UpdateModel_Private_Void_0;

		// Token: 0x04001557 RID: 5463
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x04001558 RID: 5464
		private static readonly IntPtr NativeMethodInfoPtr_Mount_Public_Void_0;

		// Token: 0x04001559 RID: 5465
		private static readonly IntPtr NativeMethodInfoPtr_Dismount_Public_Void_0;

		// Token: 0x0400155A RID: 5466
		private static readonly IntPtr NativeMethodInfoPtr_OnMount_Private_Void_0;

		// Token: 0x0400155B RID: 5467
		private static readonly IntPtr NativeMethodInfoPtr_OnDismount_Private_Void_0;

		// Token: 0x0400155C RID: 5468
		private static readonly IntPtr NativeMethodInfoPtr_CanMountHere_Private_Boolean_0;

		// Token: 0x0400155D RID: 5469
		private static readonly IntPtr NativeMethodInfoPtr_GetSkateboardSpawnPose_Private_Pose_0;

		// Token: 0x0400155E RID: 5470
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
