using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Core.Equipping.Framework;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x02000322 RID: 802
	public class HotbarSlot : ItemSlot
	{
		// Token: 0x06003F22 RID: 16162 RVA: 0x0014F6EC File Offset: 0x0014D8EC
		// Note: this type is marked as 'beforefieldinit'.
		static HotbarSlot()
		{
			Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "HotbarSlot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr);
			HotbarSlot.NativeFieldInfoPtr__IsSelected_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, "<IsSelected>k__BackingField");
			HotbarSlot.NativeFieldInfoPtr_onEquipChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, "onEquipChanged");
			HotbarSlot.NativeFieldInfoPtr__equippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, "_equippable");
			HotbarSlot.NativeFieldInfoPtr__equippedItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, "_equippedItem");
			HotbarSlot.NativeMethodInfoPtr_get_IsSelected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, 100671299);
			HotbarSlot.NativeMethodInfoPtr_set_IsSelected_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, 100671300);
			HotbarSlot.NativeMethodInfoPtr_SetStoredItem_Public_Virtual_Void_ItemInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, 100671301);
			HotbarSlot.NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, 100671302);
			HotbarSlot.NativeMethodInfoPtr_Select_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, 100671303);
			HotbarSlot.NativeMethodInfoPtr_Equip_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, 100671304);
			HotbarSlot.NativeMethodInfoPtr_Unequip_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, 100671305);
			HotbarSlot.NativeMethodInfoPtr_Deselect_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, 100671306);
			HotbarSlot.NativeMethodInfoPtr_CanSlotAcceptCash_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, 100671307);
			HotbarSlot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, 100671308);
		}

		// Token: 0x170013D2 RID: 5074
		// (get) Token: 0x06003F23 RID: 16163 RVA: 0x0014F834 File Offset: 0x0014DA34
		// (set) Token: 0x06003F24 RID: 16164 RVA: 0x0014F870 File Offset: 0x0014DA70
		public unsafe bool IsSelected
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotbarSlot.NativeMethodInfoPtr_get_IsSelected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotbarSlot.NativeMethodInfoPtr_set_IsSelected_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F25 RID: 16165 RVA: 0x0014F8B0 File Offset: 0x0014DAB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153325, XrefRangeEnd = 153332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetStoredItem(ItemInstance instance, bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _internal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HotbarSlot.NativeMethodInfoPtr_SetStoredItem_Public_Virtual_Void_ItemInstance_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F26 RID: 16166 RVA: 0x0014F90C File Offset: 0x0014DB0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153332, XrefRangeEnd = 153334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearStoredInstance(bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _internal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HotbarSlot.NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F27 RID: 16167 RVA: 0x0014F958 File Offset: 0x0014DB58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153334, XrefRangeEnd = 153340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Select()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HotbarSlot.NativeMethodInfoPtr_Select_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F28 RID: 16168 RVA: 0x0014F994 File Offset: 0x0014DB94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 153359, RefRangeEnd = 153361, XrefRangeStart = 153340, XrefRangeEnd = 153359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Equip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotbarSlot.NativeMethodInfoPtr_Equip_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F29 RID: 16169 RVA: 0x0014F9C8 File Offset: 0x0014DBC8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 153372, RefRangeEnd = 153375, XrefRangeStart = 153361, XrefRangeEnd = 153372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotbarSlot.NativeMethodInfoPtr_Unequip_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F2A RID: 16170 RVA: 0x0014F9FC File Offset: 0x0014DBFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153375, XrefRangeEnd = 153381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Deselect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HotbarSlot.NativeMethodInfoPtr_Deselect_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F2B RID: 16171 RVA: 0x0014FA38 File Offset: 0x0014DC38
		[CallerCount(170)]
		[CachedScanResults(RefRangeStart = 31151, RefRangeEnd = 31321, XrefRangeStart = 31151, XrefRangeEnd = 31321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanSlotAcceptCash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HotbarSlot.NativeMethodInfoPtr_CanSlotAcceptCash_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003F2C RID: 16172 RVA: 0x0014FA80 File Offset: 0x0014DC80
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 153382, RefRangeEnd = 153385, XrefRangeStart = 153381, XrefRangeEnd = 153382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HotbarSlot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotbarSlot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F2D RID: 16173 RVA: 0x0001F627 File Offset: 0x0001D827
		public HotbarSlot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170013CE RID: 5070
		// (get) Token: 0x06003F2E RID: 16174 RVA: 0x0014FABC File Offset: 0x0014DCBC
		// (set) Token: 0x06003F2F RID: 16175 RVA: 0x0001F630 File Offset: 0x0001D830
		public unsafe bool _IsSelected_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotbarSlot.NativeFieldInfoPtr__IsSelected_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotbarSlot.NativeFieldInfoPtr__IsSelected_k__BackingField)) = value;
			}
		}

		// Token: 0x170013CF RID: 5071
		// (get) Token: 0x06003F30 RID: 16176 RVA: 0x0014FAE4 File Offset: 0x0014DCE4
		// (set) Token: 0x06003F31 RID: 16177 RVA: 0x0001F64B File Offset: 0x0001D84B
		public unsafe HotbarSlot.EquipEvent onEquipChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotbarSlot.NativeFieldInfoPtr_onEquipChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HotbarSlot.EquipEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotbarSlot.NativeFieldInfoPtr_onEquipChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013D0 RID: 5072
		// (get) Token: 0x06003F32 RID: 16178 RVA: 0x0014FB14 File Offset: 0x0014DD14
		// (set) Token: 0x06003F33 RID: 16179 RVA: 0x0001F66A File Offset: 0x0001D86A
		public unsafe Equippable _equippable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotbarSlot.NativeFieldInfoPtr__equippable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotbarSlot.NativeFieldInfoPtr__equippable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013D1 RID: 5073
		// (get) Token: 0x06003F34 RID: 16180 RVA: 0x0014FB44 File Offset: 0x0014DD44
		// (set) Token: 0x06003F35 RID: 16181 RVA: 0x0001F689 File Offset: 0x0001D889
		public unsafe IEquippedItemHandler _equippedItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotbarSlot.NativeFieldInfoPtr__equippedItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEquippedItemHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotbarSlot.NativeFieldInfoPtr__equippedItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002A89 RID: 10889
		private static readonly IntPtr NativeFieldInfoPtr__IsSelected_k__BackingField;

		// Token: 0x04002A8A RID: 10890
		private static readonly IntPtr NativeFieldInfoPtr_onEquipChanged;

		// Token: 0x04002A8B RID: 10891
		private static readonly IntPtr NativeFieldInfoPtr__equippable;

		// Token: 0x04002A8C RID: 10892
		private static readonly IntPtr NativeFieldInfoPtr__equippedItem;

		// Token: 0x04002A8D RID: 10893
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSelected_Public_get_Boolean_0;

		// Token: 0x04002A8E RID: 10894
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSelected_Protected_set_Void_Boolean_0;

		// Token: 0x04002A8F RID: 10895
		private static readonly IntPtr NativeMethodInfoPtr_SetStoredItem_Public_Virtual_Void_ItemInstance_Boolean_0;

		// Token: 0x04002A90 RID: 10896
		private static readonly IntPtr NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_Void_Boolean_0;

		// Token: 0x04002A91 RID: 10897
		private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Virtual_New_Void_0;

		// Token: 0x04002A92 RID: 10898
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Private_Void_0;

		// Token: 0x04002A93 RID: 10899
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Private_Void_0;

		// Token: 0x04002A94 RID: 10900
		private static readonly IntPtr NativeMethodInfoPtr_Deselect_Public_Virtual_New_Void_0;

		// Token: 0x04002A95 RID: 10901
		private static readonly IntPtr NativeMethodInfoPtr_CanSlotAcceptCash_Public_Virtual_Boolean_0;

		// Token: 0x04002A96 RID: 10902
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A41 RID: 2625
		public sealed class EquipEvent : MulticastDelegate
		{
			// Token: 0x0600DF74 RID: 57204 RVA: 0x00370394 File Offset: 0x0036E594
			// Note: this type is marked as 'beforefieldinit'.
			static EquipEvent()
			{
				Il2CppClassPointerStore<HotbarSlot.EquipEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, "EquipEvent");
				HotbarSlot.EquipEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot.EquipEvent>.NativeClassPtr, 100671309);
				HotbarSlot.EquipEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot.EquipEvent>.NativeClassPtr, 100671310);
				HotbarSlot.EquipEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot.EquipEvent>.NativeClassPtr, 100671311);
				HotbarSlot.EquipEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot.EquipEvent>.NativeClassPtr, 100671312);
			}

			// Token: 0x0600DF75 RID: 57205 RVA: 0x00370408 File Offset: 0x0036E608
			[CallerCount(56)]
			[CachedScanResults(RefRangeStart = 151132, RefRangeEnd = 151188, XrefRangeStart = 151132, XrefRangeEnd = 151188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EquipEvent(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HotbarSlot.EquipEvent>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotbarSlot.EquipEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF76 RID: 57206 RVA: 0x00370464 File Offset: 0x0036E664
			[CallerCount(0)]
			public unsafe void Invoke(bool equipped)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref equipped;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotbarSlot.EquipEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF77 RID: 57207 RVA: 0x003704A4 File Offset: 0x0036E6A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153321, XrefRangeEnd = 153325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(bool equipped, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref equipped;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotbarSlot.EquipEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600DF78 RID: 57208 RVA: 0x00370514 File Offset: 0x0036E714
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotbarSlot.EquipEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF79 RID: 57209 RVA: 0x000693BC File Offset: 0x000675BC
			public EquipEvent(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600DF7A RID: 57210 RVA: 0x000693C5 File Offset: 0x000675C5
			public static implicit operator HotbarSlot.EquipEvent(Action<bool> A_0)
			{
				return DelegateSupport.ConvertDelegate<HotbarSlot.EquipEvent>(A_0);
			}

			// Token: 0x0600DF7B RID: 57211 RVA: 0x000693CD File Offset: 0x000675CD
			public static HotbarSlot.EquipEvent operator +(HotbarSlot.EquipEvent A_0, HotbarSlot.EquipEvent A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<HotbarSlot.EquipEvent>();
			}

			// Token: 0x0600DF7C RID: 57212 RVA: 0x000693DB File Offset: 0x000675DB
			public static HotbarSlot.EquipEvent operator -(HotbarSlot.EquipEvent A_0, HotbarSlot.EquipEvent A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<HotbarSlot.EquipEvent>();
				}
				return result;
			}

			// Token: 0x0400982E RID: 38958
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400982F RID: 38959
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0;

			// Token: 0x04009830 RID: 38960
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0;

			// Token: 0x04009831 RID: 38961
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
