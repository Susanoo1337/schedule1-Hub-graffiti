using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Doors;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Property;

namespace Il2CppScheduleOne.Building.Doors
{
	// Token: 0x0200046C RID: 1132
	public class PropertyDoorController : DoorController
	{
		// Token: 0x06006620 RID: 26144 RVA: 0x001DD348 File Offset: 0x001DB548
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyDoorController()
		{
			Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building.Doors", "PropertyDoorController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr);
			PropertyDoorController.NativeFieldInfoPtr_WANTED_PLAYER_CLOSE_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, "WANTED_PLAYER_CLOSE_DISTANCE");
			PropertyDoorController.NativeFieldInfoPtr_Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, "Property");
			PropertyDoorController.NativeFieldInfoPtr_IsUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, "IsUnlocked");
			PropertyDoorController.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Building.Doors.PropertyDoorControllerAssembly-CSharp.dll_Excuted");
			PropertyDoorController.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Building.Doors.PropertyDoorControllerAssembly-CSharp.dll_Excuted");
			PropertyDoorController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, 100676689);
			PropertyDoorController.NativeMethodInfoPtr_Unlock_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, 100676690);
			PropertyDoorController.NativeMethodInfoPtr_CheckClose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, 100676691);
			PropertyDoorController.NativeMethodInfoPtr_CanPlayerAccess_Protected_Virtual_Boolean_EDoorSide_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, 100676692);
			PropertyDoorController.NativeMethodInfoPtr_GetNearestWantedPlayer_Private_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, 100676693);
			PropertyDoorController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, 100676694);
			PropertyDoorController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, 100676695);
			PropertyDoorController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, 100676696);
			PropertyDoorController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, 100676697);
			PropertyDoorController.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, 100676698);
		}

		// Token: 0x06006621 RID: 26145 RVA: 0x001DD4A4 File Offset: 0x001DB6A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213516, XrefRangeEnd = 213532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyDoorController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006622 RID: 26146 RVA: 0x001DD4E0 File Offset: 0x001DB6E0
		[CallerCount(0)]
		public unsafe void Unlock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyDoorController.NativeMethodInfoPtr_Unlock_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006623 RID: 26147 RVA: 0x001DD514 File Offset: 0x001DB714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213532, XrefRangeEnd = 213542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyDoorController.NativeMethodInfoPtr_CheckClose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006624 RID: 26148 RVA: 0x001DD548 File Offset: 0x001DB748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213542, XrefRangeEnd = 213568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanPlayerAccess(EDoorSide side, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref side;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyDoorController.NativeMethodInfoPtr_CanPlayerAccess_Protected_Virtual_Boolean_EDoorSide_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06006625 RID: 26149 RVA: 0x001DD5B8 File Offset: 0x001DB7B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 213602, RefRangeEnd = 213604, XrefRangeStart = 213568, XrefRangeEnd = 213602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Player GetNearestWantedPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyDoorController.NativeMethodInfoPtr_GetNearestWantedPlayer_Private_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
		}

		// Token: 0x06006626 RID: 26150 RVA: 0x001DD5F8 File Offset: 0x001DB7F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213604, XrefRangeEnd = 213605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyDoorController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyDoorController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006627 RID: 26151 RVA: 0x001DD634 File Offset: 0x001DB834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213605, XrefRangeEnd = 213606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyDoorController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006628 RID: 26152 RVA: 0x001DD670 File Offset: 0x001DB870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213606, XrefRangeEnd = 213607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyDoorController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006629 RID: 26153 RVA: 0x001DD6AC File Offset: 0x001DB8AC
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyDoorController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600662A RID: 26154 RVA: 0x001DD6E8 File Offset: 0x001DB8E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213607, XrefRangeEnd = 213622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyDoorController.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600662B RID: 26155 RVA: 0x00030177 File Offset: 0x0002E377
		public PropertyDoorController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F3D RID: 7997
		// (get) Token: 0x0600662C RID: 26156 RVA: 0x001DD724 File Offset: 0x001DB924
		// (set) Token: 0x0600662D RID: 26157 RVA: 0x00030180 File Offset: 0x0002E380
		public unsafe static float WANTED_PLAYER_CLOSE_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PropertyDoorController.NativeFieldInfoPtr_WANTED_PLAYER_CLOSE_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PropertyDoorController.NativeFieldInfoPtr_WANTED_PLAYER_CLOSE_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x17001F3E RID: 7998
		// (get) Token: 0x0600662E RID: 26158 RVA: 0x001DD740 File Offset: 0x001DB940
		// (set) Token: 0x0600662F RID: 26159 RVA: 0x0003018E File Offset: 0x0002E38E
		public unsafe Property Property
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDoorController.NativeFieldInfoPtr_Property);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDoorController.NativeFieldInfoPtr_Property), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F3F RID: 7999
		// (get) Token: 0x06006630 RID: 26160 RVA: 0x001DD770 File Offset: 0x001DB970
		// (set) Token: 0x06006631 RID: 26161 RVA: 0x000301AD File Offset: 0x0002E3AD
		public unsafe bool IsUnlocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDoorController.NativeFieldInfoPtr_IsUnlocked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDoorController.NativeFieldInfoPtr_IsUnlocked)) = value;
			}
		}

		// Token: 0x17001F40 RID: 8000
		// (get) Token: 0x06006632 RID: 26162 RVA: 0x001DD798 File Offset: 0x001DB998
		// (set) Token: 0x06006633 RID: 26163 RVA: 0x000301C8 File Offset: 0x0002E3C8
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDoorController.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDoorController.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001F41 RID: 8001
		// (get) Token: 0x06006634 RID: 26164 RVA: 0x001DD7C0 File Offset: 0x001DB9C0
		// (set) Token: 0x06006635 RID: 26165 RVA: 0x000301E3 File Offset: 0x0002E3E3
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDoorController.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDoorController.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004659 RID: 18009
		private static readonly IntPtr NativeFieldInfoPtr_WANTED_PLAYER_CLOSE_DISTANCE;

		// Token: 0x0400465A RID: 18010
		private static readonly IntPtr NativeFieldInfoPtr_Property;

		// Token: 0x0400465B RID: 18011
		private static readonly IntPtr NativeFieldInfoPtr_IsUnlocked;

		// Token: 0x0400465C RID: 18012
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400465D RID: 18013
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400465E RID: 18014
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0400465F RID: 18015
		private static readonly IntPtr NativeMethodInfoPtr_Unlock_Public_Void_0;

		// Token: 0x04004660 RID: 18016
		private static readonly IntPtr NativeMethodInfoPtr_CheckClose_Private_Void_0;

		// Token: 0x04004661 RID: 18017
		private static readonly IntPtr NativeMethodInfoPtr_CanPlayerAccess_Protected_Virtual_Boolean_EDoorSide_byref_String_0;

		// Token: 0x04004662 RID: 18018
		private static readonly IntPtr NativeMethodInfoPtr_GetNearestWantedPlayer_Private_Player_0;

		// Token: 0x04004663 RID: 18019
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004664 RID: 18020
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004665 RID: 18021
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004666 RID: 18022
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004667 RID: 18023
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;
	}
}
