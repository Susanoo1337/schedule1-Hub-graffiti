using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts.WateringCan;
using Il2CppScheduleOne.Trash;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x02000577 RID: 1399
	public class Equippable_TrashGrabber : Equippable_Viewmodel
	{
		// Token: 0x06007F80 RID: 32640 RVA: 0x002317A4 File Offset: 0x0022F9A4
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_TrashGrabber()
		{
			Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_TrashGrabber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr);
			Equippable_TrashGrabber.NativeFieldInfoPtr__Instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "<Instance>k__BackingField");
			Equippable_TrashGrabber.NativeFieldInfoPtr_TrashDropSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "TrashDropSpacing");
			Equippable_TrashGrabber.NativeFieldInfoPtr_TrashContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "TrashContent");
			Equippable_TrashGrabber.NativeFieldInfoPtr_TrashContent_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "TrashContent_Min");
			Equippable_TrashGrabber.NativeFieldInfoPtr_TrashContent_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "TrashContent_Max");
			Equippable_TrashGrabber.NativeFieldInfoPtr_GrabAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "GrabAnim");
			Equippable_TrashGrabber.NativeFieldInfoPtr_Bin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "Bin");
			Equippable_TrashGrabber.NativeFieldInfoPtr_BinRaisedPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "BinRaisedPosition");
			Equippable_TrashGrabber.NativeFieldInfoPtr_TrashDropSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "TrashDropSound");
			Equippable_TrashGrabber.NativeFieldInfoPtr_DropTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "DropTime");
			Equippable_TrashGrabber.NativeFieldInfoPtr_DropForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "DropForce");
			Equippable_TrashGrabber.NativeFieldInfoPtr_TrashDropOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "TrashDropOffset");
			Equippable_TrashGrabber.NativeFieldInfoPtr_onPickup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "onPickup");
			Equippable_TrashGrabber.NativeFieldInfoPtr__currentDropTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "<currentDropTime>k__BackingField");
			Equippable_TrashGrabber.NativeFieldInfoPtr__timeSinceLastDrop_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "<timeSinceLastDrop>k__BackingField");
			Equippable_TrashGrabber.NativeFieldInfoPtr_trashGrabberInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "trashGrabberInstance");
			Equippable_TrashGrabber.NativeFieldInfoPtr_defaultBinPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "defaultBinPosition");
			Equippable_TrashGrabber.NativeFieldInfoPtr_defaultBinScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "defaultBinScale");
			Equippable_TrashGrabber.NativeMethodInfoPtr_get_Instance_Public_Static_get_Equippable_TrashGrabber_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679734);
			Equippable_TrashGrabber.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_Equippable_TrashGrabber_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679735);
			Equippable_TrashGrabber.NativeMethodInfoPtr_get_IsEquipped_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679736);
			Equippable_TrashGrabber.NativeMethodInfoPtr_get_currentDropTime_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679737);
			Equippable_TrashGrabber.NativeMethodInfoPtr_set_currentDropTime_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679738);
			Equippable_TrashGrabber.NativeMethodInfoPtr_get_timeSinceLastDrop_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679739);
			Equippable_TrashGrabber.NativeMethodInfoPtr_set_timeSinceLastDrop_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679740);
			Equippable_TrashGrabber.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679741);
			Equippable_TrashGrabber.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679742);
			Equippable_TrashGrabber.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679743);
			Equippable_TrashGrabber.NativeMethodInfoPtr_EjectTrash_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679744);
			Equippable_TrashGrabber.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679745);
			Equippable_TrashGrabber.NativeMethodInfoPtr_PickupTrash_Public_Void_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679746);
			Equippable_TrashGrabber.NativeMethodInfoPtr_GetCapacity_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679747);
			Equippable_TrashGrabber.NativeMethodInfoPtr_RefreshVisuals_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679748);
			Equippable_TrashGrabber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679749);
		}

		// Token: 0x1700276F RID: 10095
		// (get) Token: 0x06007F81 RID: 32641 RVA: 0x00231A7C File Offset: 0x0022FC7C
		// (set) Token: 0x06007F82 RID: 32642 RVA: 0x00231AB0 File Offset: 0x0022FCB0
		public unsafe static Equippable_TrashGrabber Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243259, XrefRangeEnd = 243261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_get_Instance_Public_Static_get_Equippable_TrashGrabber_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Equippable_TrashGrabber>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243261, XrefRangeEnd = 243265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_Equippable_TrashGrabber_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002770 RID: 10096
		// (get) Token: 0x06007F83 RID: 32643 RVA: 0x00231AE8 File Offset: 0x0022FCE8
		public unsafe static bool IsEquipped
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 243271, RefRangeEnd = 243273, XrefRangeStart = 243265, XrefRangeEnd = 243271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_get_IsEquipped_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002771 RID: 10097
		// (get) Token: 0x06007F84 RID: 32644 RVA: 0x00231B18 File Offset: 0x0022FD18
		// (set) Token: 0x06007F85 RID: 32645 RVA: 0x00231B54 File Offset: 0x0022FD54
		public unsafe float currentDropTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_get_currentDropTime_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_set_currentDropTime_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002772 RID: 10098
		// (get) Token: 0x06007F86 RID: 32646 RVA: 0x00231B94 File Offset: 0x0022FD94
		// (set) Token: 0x06007F87 RID: 32647 RVA: 0x00231BD0 File Offset: 0x0022FDD0
		public unsafe float timeSinceLastDrop
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_get_timeSinceLastDrop_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_set_timeSinceLastDrop_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007F88 RID: 32648 RVA: 0x00231C10 File Offset: 0x0022FE10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243273, XrefRangeEnd = 243303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_TrashGrabber.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007F89 RID: 32649 RVA: 0x00231C60 File Offset: 0x0022FE60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243303, XrefRangeEnd = 243323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_TrashGrabber.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007F8A RID: 32650 RVA: 0x00231C9C File Offset: 0x0022FE9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243323, XrefRangeEnd = 243354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_TrashGrabber.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007F8B RID: 32651 RVA: 0x00231CD8 File Offset: 0x0022FED8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 243385, RefRangeEnd = 243386, XrefRangeStart = 243354, XrefRangeEnd = 243385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EjectTrash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_EjectTrash_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007F8C RID: 32652 RVA: 0x00231D0C File Offset: 0x0022FF0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243386, XrefRangeEnd = 243396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007F8D RID: 32653 RVA: 0x00231D40 File Offset: 0x0022FF40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 243401, RefRangeEnd = 243402, XrefRangeStart = 243396, XrefRangeEnd = 243401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PickupTrash(TrashItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_PickupTrash_Public_Void_TrashItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007F8E RID: 32654 RVA: 0x00231D84 File Offset: 0x0022FF84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 243403, RefRangeEnd = 243405, XrefRangeStart = 243402, XrefRangeEnd = 243403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCapacity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_GetCapacity_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007F8F RID: 32655 RVA: 0x00231DC0 File Offset: 0x0022FFC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 243419, RefRangeEnd = 243420, XrefRangeStart = 243405, XrefRangeEnd = 243419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_RefreshVisuals_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007F90 RID: 32656 RVA: 0x00231DF4 File Offset: 0x0022FFF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243420, XrefRangeEnd = 243423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_TrashGrabber() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007F91 RID: 32657 RVA: 0x0003C8AB File Offset: 0x0003AAAB
		public Equippable_TrashGrabber(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700275D RID: 10077
		// (get) Token: 0x06007F92 RID: 32658 RVA: 0x00231E30 File Offset: 0x00230030
		// (set) Token: 0x06007F93 RID: 32659 RVA: 0x0003C8B4 File Offset: 0x0003AAB4
		public unsafe static Equippable_TrashGrabber _Instance_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Equippable_TrashGrabber.NativeFieldInfoPtr__Instance_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable_TrashGrabber>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Equippable_TrashGrabber.NativeFieldInfoPtr__Instance_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700275E RID: 10078
		// (get) Token: 0x06007F94 RID: 32660 RVA: 0x00231E58 File Offset: 0x00230058
		// (set) Token: 0x06007F95 RID: 32661 RVA: 0x0003C8C6 File Offset: 0x0003AAC6
		public unsafe static float TrashDropSpacing
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashDropSpacing, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashDropSpacing, (void*)(&value));
			}
		}

		// Token: 0x1700275F RID: 10079
		// (get) Token: 0x06007F96 RID: 32662 RVA: 0x00231E74 File Offset: 0x00230074
		// (set) Token: 0x06007F97 RID: 32663 RVA: 0x0003C8D4 File Offset: 0x0003AAD4
		public unsafe Transform TrashContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashContent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashContent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002760 RID: 10080
		// (get) Token: 0x06007F98 RID: 32664 RVA: 0x00231EA4 File Offset: 0x002300A4
		// (set) Token: 0x06007F99 RID: 32665 RVA: 0x0003C8F3 File Offset: 0x0003AAF3
		public unsafe Transform TrashContent_Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashContent_Min);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashContent_Min), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002761 RID: 10081
		// (get) Token: 0x06007F9A RID: 32666 RVA: 0x00231ED4 File Offset: 0x002300D4
		// (set) Token: 0x06007F9B RID: 32667 RVA: 0x0003C912 File Offset: 0x0003AB12
		public unsafe Transform TrashContent_Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashContent_Max);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashContent_Max), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002762 RID: 10082
		// (get) Token: 0x06007F9C RID: 32668 RVA: 0x00231F04 File Offset: 0x00230104
		// (set) Token: 0x06007F9D RID: 32669 RVA: 0x0003C931 File Offset: 0x0003AB31
		public unsafe Animation GrabAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_GrabAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_GrabAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002763 RID: 10083
		// (get) Token: 0x06007F9E RID: 32670 RVA: 0x00231F34 File Offset: 0x00230134
		// (set) Token: 0x06007F9F RID: 32671 RVA: 0x0003C950 File Offset: 0x0003AB50
		public unsafe Transform Bin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_Bin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_Bin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002764 RID: 10084
		// (get) Token: 0x06007FA0 RID: 32672 RVA: 0x00231F64 File Offset: 0x00230164
		// (set) Token: 0x06007FA1 RID: 32673 RVA: 0x0003C96F File Offset: 0x0003AB6F
		public unsafe Transform BinRaisedPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_BinRaisedPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_BinRaisedPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002765 RID: 10085
		// (get) Token: 0x06007FA2 RID: 32674 RVA: 0x00231F94 File Offset: 0x00230194
		// (set) Token: 0x06007FA3 RID: 32675 RVA: 0x0003C98E File Offset: 0x0003AB8E
		public unsafe AudioSourceController TrashDropSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashDropSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashDropSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002766 RID: 10086
		// (get) Token: 0x06007FA4 RID: 32676 RVA: 0x00231FC4 File Offset: 0x002301C4
		// (set) Token: 0x06007FA5 RID: 32677 RVA: 0x0003C9AD File Offset: 0x0003ABAD
		public unsafe float DropTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_DropTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_DropTime)) = value;
			}
		}

		// Token: 0x17002767 RID: 10087
		// (get) Token: 0x06007FA6 RID: 32678 RVA: 0x00231FEC File Offset: 0x002301EC
		// (set) Token: 0x06007FA7 RID: 32679 RVA: 0x0003C9C8 File Offset: 0x0003ABC8
		public unsafe float DropForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_DropForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_DropForce)) = value;
			}
		}

		// Token: 0x17002768 RID: 10088
		// (get) Token: 0x06007FA8 RID: 32680 RVA: 0x00232014 File Offset: 0x00230214
		// (set) Token: 0x06007FA9 RID: 32681 RVA: 0x0003C9E3 File Offset: 0x0003ABE3
		public unsafe Vector3 TrashDropOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashDropOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashDropOffset)) = value;
			}
		}

		// Token: 0x17002769 RID: 10089
		// (get) Token: 0x06007FAA RID: 32682 RVA: 0x0023203C File Offset: 0x0023023C
		// (set) Token: 0x06007FAB RID: 32683 RVA: 0x0003C9FE File Offset: 0x0003ABFE
		public unsafe UnityEvent onPickup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_onPickup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_onPickup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700276A RID: 10090
		// (get) Token: 0x06007FAC RID: 32684 RVA: 0x0023206C File Offset: 0x0023026C
		// (set) Token: 0x06007FAD RID: 32685 RVA: 0x0003CA1D File Offset: 0x0003AC1D
		public unsafe float _currentDropTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr__currentDropTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr__currentDropTime_k__BackingField)) = value;
			}
		}

		// Token: 0x1700276B RID: 10091
		// (get) Token: 0x06007FAE RID: 32686 RVA: 0x00232094 File Offset: 0x00230294
		// (set) Token: 0x06007FAF RID: 32687 RVA: 0x0003CA38 File Offset: 0x0003AC38
		public unsafe float _timeSinceLastDrop_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr__timeSinceLastDrop_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr__timeSinceLastDrop_k__BackingField)) = value;
			}
		}

		// Token: 0x1700276C RID: 10092
		// (get) Token: 0x06007FB0 RID: 32688 RVA: 0x002320BC File Offset: 0x002302BC
		// (set) Token: 0x06007FB1 RID: 32689 RVA: 0x0003CA53 File Offset: 0x0003AC53
		public unsafe TrashGrabberInstance trashGrabberInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_trashGrabberInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashGrabberInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_trashGrabberInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700276D RID: 10093
		// (get) Token: 0x06007FB2 RID: 32690 RVA: 0x002320EC File Offset: 0x002302EC
		// (set) Token: 0x06007FB3 RID: 32691 RVA: 0x0003CA72 File Offset: 0x0003AC72
		public unsafe Pose defaultBinPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_defaultBinPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_defaultBinPosition)) = value;
			}
		}

		// Token: 0x1700276E RID: 10094
		// (get) Token: 0x06007FB4 RID: 32692 RVA: 0x00232114 File Offset: 0x00230314
		// (set) Token: 0x06007FB5 RID: 32693 RVA: 0x0003CA8D File Offset: 0x0003AC8D
		public unsafe Vector3 defaultBinScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_defaultBinScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_defaultBinScale)) = value;
			}
		}

		// Token: 0x04005706 RID: 22278
		private static readonly IntPtr NativeFieldInfoPtr__Instance_k__BackingField;

		// Token: 0x04005707 RID: 22279
		private static readonly IntPtr NativeFieldInfoPtr_TrashDropSpacing;

		// Token: 0x04005708 RID: 22280
		private static readonly IntPtr NativeFieldInfoPtr_TrashContent;

		// Token: 0x04005709 RID: 22281
		private static readonly IntPtr NativeFieldInfoPtr_TrashContent_Min;

		// Token: 0x0400570A RID: 22282
		private static readonly IntPtr NativeFieldInfoPtr_TrashContent_Max;

		// Token: 0x0400570B RID: 22283
		private static readonly IntPtr NativeFieldInfoPtr_GrabAnim;

		// Token: 0x0400570C RID: 22284
		private static readonly IntPtr NativeFieldInfoPtr_Bin;

		// Token: 0x0400570D RID: 22285
		private static readonly IntPtr NativeFieldInfoPtr_BinRaisedPosition;

		// Token: 0x0400570E RID: 22286
		private static readonly IntPtr NativeFieldInfoPtr_TrashDropSound;

		// Token: 0x0400570F RID: 22287
		private static readonly IntPtr NativeFieldInfoPtr_DropTime;

		// Token: 0x04005710 RID: 22288
		private static readonly IntPtr NativeFieldInfoPtr_DropForce;

		// Token: 0x04005711 RID: 22289
		private static readonly IntPtr NativeFieldInfoPtr_TrashDropOffset;

		// Token: 0x04005712 RID: 22290
		private static readonly IntPtr NativeFieldInfoPtr_onPickup;

		// Token: 0x04005713 RID: 22291
		private static readonly IntPtr NativeFieldInfoPtr__currentDropTime_k__BackingField;

		// Token: 0x04005714 RID: 22292
		private static readonly IntPtr NativeFieldInfoPtr__timeSinceLastDrop_k__BackingField;

		// Token: 0x04005715 RID: 22293
		private static readonly IntPtr NativeFieldInfoPtr_trashGrabberInstance;

		// Token: 0x04005716 RID: 22294
		private static readonly IntPtr NativeFieldInfoPtr_defaultBinPosition;

		// Token: 0x04005717 RID: 22295
		private static readonly IntPtr NativeFieldInfoPtr_defaultBinScale;

		// Token: 0x04005718 RID: 22296
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_Equippable_TrashGrabber_0;

		// Token: 0x04005719 RID: 22297
		private static readonly IntPtr NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_Equippable_TrashGrabber_0;

		// Token: 0x0400571A RID: 22298
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEquipped_Public_Static_get_Boolean_0;

		// Token: 0x0400571B RID: 22299
		private static readonly IntPtr NativeMethodInfoPtr_get_currentDropTime_Private_get_Single_0;

		// Token: 0x0400571C RID: 22300
		private static readonly IntPtr NativeMethodInfoPtr_set_currentDropTime_Private_set_Void_Single_0;

		// Token: 0x0400571D RID: 22301
		private static readonly IntPtr NativeMethodInfoPtr_get_timeSinceLastDrop_Private_get_Single_0;

		// Token: 0x0400571E RID: 22302
		private static readonly IntPtr NativeMethodInfoPtr_set_timeSinceLastDrop_Private_set_Void_Single_0;

		// Token: 0x0400571F RID: 22303
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04005720 RID: 22304
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x04005721 RID: 22305
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04005722 RID: 22306
		private static readonly IntPtr NativeMethodInfoPtr_EjectTrash_Private_Void_0;

		// Token: 0x04005723 RID: 22307
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04005724 RID: 22308
		private static readonly IntPtr NativeMethodInfoPtr_PickupTrash_Public_Void_TrashItem_0;

		// Token: 0x04005725 RID: 22309
		private static readonly IntPtr NativeMethodInfoPtr_GetCapacity_Public_Int32_0;

		// Token: 0x04005726 RID: 22310
		private static readonly IntPtr NativeMethodInfoPtr_RefreshVisuals_Private_Void_0;

		// Token: 0x04005727 RID: 22311
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
