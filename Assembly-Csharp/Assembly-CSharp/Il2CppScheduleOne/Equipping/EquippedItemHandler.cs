using System;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Core.Equipping.Framework;
using Il2CppScheduleOne.Core.Items.Framework;
using Il2CppScheduleOne.Equipping.Framework;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x02000588 RID: 1416
	public class EquippedItemHandler : NetworkBehaviour
	{
		// Token: 0x06008121 RID: 33057 RVA: 0x00236298 File Offset: 0x00234498
		// Note: this type is marked as 'beforefieldinit'.
		static EquippedItemHandler()
		{
			Il2CppClassPointerStore<EquippedItemHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "EquippedItemHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EquippedItemHandler>.NativeClassPtr);
			EquippedItemHandler.NativeFieldInfoPtr__IsEquipped_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquippedItemHandler>.NativeClassPtr, "<IsEquipped>k__BackingField");
			EquippedItemHandler.NativeFieldInfoPtr__user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquippedItemHandler>.NativeClassPtr, "_user");
			EquippedItemHandler.NativeFieldInfoPtr__equippableData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquippedItemHandler>.NativeClassPtr, "_equippableData");
			EquippedItemHandler.NativeFieldInfoPtr_OnUnequipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquippedItemHandler>.NativeClassPtr, "OnUnequipped");
			EquippedItemHandler.NativeFieldInfoPtr_syncVar____user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquippedItemHandler>.NativeClassPtr, "syncVar____user");
			EquippedItemHandler.NativeFieldInfoPtr_syncVar____equippableData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquippedItemHandler>.NativeClassPtr, "syncVar____equippableData");
			EquippedItemHandler.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquippedItemHandler>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Equipping.EquippedItemHandlerAssembly-CSharp.dll_Excuted");
			EquippedItemHandler.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquippedItemHandler>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Equipping.EquippedItemHandlerAssembly-CSharp.dll_Excuted");
			EquippedItemHandler.NativeMethodInfoPtr_get_User_Public_Virtual_Final_New_get_IEquippableUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquippedItemHandler>.NativeClassPtr, 100679882);
			EquippedItemHandler.NativeMethodInfoPtr_get_EquippableData_Public_Virtual_Final_New_get_EquippableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquippedItemHandler>.NativeClassPtr, 100679883);
			EquippedItemHandler.NativeMethodInfoPtr_get_IsEquipped_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquippedItemHandler>.NativeClassPtr, 100679884);
			EquippedItemHandler.NativeMethodInfoPtr_set_IsEquipped_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquippedItemHandler>.NativeClassPtr, 100679885);
			EquippedItemHandler.NativeMethodInfoPtr_add_OnUnequipped_Public_Virtual_Final_New_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquippedItemHandler>.NativeClassPtr, 100679886);
			EquippedItemHandler.NativeMethodInfoPtr_remove_OnUnequipped_Public_Virtual_Final_New_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquippedItemHandler>.NativeClassPtr, 100679887);
			EquippedItemHandler.NativeMethodInfoPtr_Equipped_Public_Virtual_New_Void_IEquippableUser_EquippableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquippedItemHandler>.NativeClassPtr, 100679888);
			EquippedItemHandler.NativeMethodInfoPtr_EquippedWithItem_Public_Virtual_New_Void_IEquippableUser_EquippableData_BaseItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquippedItemHandler>.NativeClassPtr, 100679889);
			EquippedItemHandler.NativeMethodInfoPtr_Unequipped_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquippedItemHandler>.NativeClassPtr, 100679890);
			EquippedItemHandler.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquippedItemHandler>.NativeClassPtr, 100679891);
			EquippedItemHandler.NativeMethodInfoPtr_SetupParent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquippedItemHandler>.NativeClassPtr, 100679892);
			EquippedItemHandler.NativeMethodInfoPtr_SetupThirdPerson_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquippedItemHandler>.NativeClassPtr, 100679893);
			EquippedItemHandler.NativeMethodInfoPtr_SetupFirstPerson_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquippedItemHandler>.NativeClassPtr, 100679894);
			EquippedItemHandler.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquippedItemHandler>.NativeClassPtr, 100679895);
			EquippedItemHandler.NativeMethodInfoPtr_UserUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquippedItemHandler>.NativeClassPtr, 100679896);
			EquippedItemHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquippedItemHandler>.NativeClassPtr, 100679897);
			EquippedItemHandler.NativeMethodInfoPtr_ScheduleOne_Core_Equipping_Framework_IEquippedItemHandler_get_gameObject_Private_Virtual_Final_New_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquippedItemHandler>.NativeClassPtr, 100679898);
			EquippedItemHandler.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquippedItemHandler>.NativeClassPtr, 100679899);
			EquippedItemHandler.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquippedItemHandler>.NativeClassPtr, 100679900);
			EquippedItemHandler.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquippedItemHandler>.NativeClassPtr, 100679901);
			EquippedItemHandler.NativeMethodInfoPtr_sync___get_value__user_Public_get_INetworkedEquippableUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquippedItemHandler>.NativeClassPtr, 100679902);
			EquippedItemHandler.NativeMethodInfoPtr_sync___set_value__user_Public_set_Void_INetworkedEquippableUser_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquippedItemHandler>.NativeClassPtr, 100679903);
			EquippedItemHandler.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Equipping_EquippedItemHandler_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquippedItemHandler>.NativeClassPtr, 100679904);
			EquippedItemHandler.NativeMethodInfoPtr_sync___get_value__equippableData_Public_get_EquippableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquippedItemHandler>.NativeClassPtr, 100679905);
			EquippedItemHandler.NativeMethodInfoPtr_sync___set_value__equippableData_Public_set_Void_EquippableData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquippedItemHandler>.NativeClassPtr, 100679906);
			EquippedItemHandler.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquippedItemHandler>.NativeClassPtr, 100679907);
		}

		// Token: 0x170027F8 RID: 10232
		// (get) Token: 0x06008122 RID: 33058 RVA: 0x00236570 File Offset: 0x00234770
		public unsafe virtual IEquippableUser User
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquippedItemHandler.NativeMethodInfoPtr_get_User_Public_Virtual_Final_New_get_IEquippableUser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEquippableUser>(intPtr3) : null;
			}
		}

		// Token: 0x170027F9 RID: 10233
		// (get) Token: 0x06008123 RID: 33059 RVA: 0x002365B0 File Offset: 0x002347B0
		public unsafe virtual EquippableData EquippableData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquippedItemHandler.NativeMethodInfoPtr_get_EquippableData_Public_Virtual_Final_New_get_EquippableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EquippableData>(intPtr3) : null;
			}
		}

		// Token: 0x170027FA RID: 10234
		// (get) Token: 0x06008124 RID: 33060 RVA: 0x002365F0 File Offset: 0x002347F0
		// (set) Token: 0x06008125 RID: 33061 RVA: 0x0023662C File Offset: 0x0023482C
		public unsafe bool IsEquipped
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquippedItemHandler.NativeMethodInfoPtr_get_IsEquipped_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquippedItemHandler.NativeMethodInfoPtr_set_IsEquipped_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008126 RID: 33062 RVA: 0x0023666C File Offset: 0x0023486C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244745, XrefRangeEnd = 244749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_OnUnequipped(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquippedItemHandler.NativeMethodInfoPtr_add_OnUnequipped_Public_Virtual_Final_New_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008127 RID: 33063 RVA: 0x002366B0 File Offset: 0x002348B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244749, XrefRangeEnd = 244753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_OnUnequipped(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquippedItemHandler.NativeMethodInfoPtr_remove_OnUnequipped_Public_Virtual_Final_New_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008128 RID: 33064 RVA: 0x002366F4 File Offset: 0x002348F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244753, XrefRangeEnd = 244782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Equipped(IEquippableUser user, EquippableData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(user);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EquippedItemHandler.NativeMethodInfoPtr_Equipped_Public_Virtual_New_Void_IEquippableUser_EquippableData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008129 RID: 33065 RVA: 0x00236754 File Offset: 0x00234954
		[CallerCount(0)]
		public unsafe virtual void EquippedWithItem(IEquippableUser user, EquippableData data, BaseItemInstance itemInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(user);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(itemInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EquippedItemHandler.NativeMethodInfoPtr_EquippedWithItem_Public_Virtual_New_Void_IEquippableUser_EquippableData_BaseItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600812A RID: 33066 RVA: 0x002367C8 File Offset: 0x002349C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244782, XrefRangeEnd = 244790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Unequipped()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EquippedItemHandler.NativeMethodInfoPtr_Unequipped_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600812B RID: 33067 RVA: 0x00236804 File Offset: 0x00234A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244790, XrefRangeEnd = 244792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EquippedItemHandler.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600812C RID: 33068 RVA: 0x00236840 File Offset: 0x00234A40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 244805, RefRangeEnd = 244807, XrefRangeStart = 244792, XrefRangeEnd = 244805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupParent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquippedItemHandler.NativeMethodInfoPtr_SetupParent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600812D RID: 33069 RVA: 0x00236874 File Offset: 0x00234A74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244807, XrefRangeEnd = 244819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetupThirdPerson()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EquippedItemHandler.NativeMethodInfoPtr_SetupThirdPerson_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600812E RID: 33070 RVA: 0x002368B0 File Offset: 0x00234AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244819, XrefRangeEnd = 244846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetupFirstPerson()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EquippedItemHandler.NativeMethodInfoPtr_SetupFirstPerson_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600812F RID: 33071 RVA: 0x002368EC File Offset: 0x00234AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244846, XrefRangeEnd = 244849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EquippedItemHandler.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008130 RID: 33072 RVA: 0x00236928 File Offset: 0x00234B28
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UserUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EquippedItemHandler.NativeMethodInfoPtr_UserUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008131 RID: 33073 RVA: 0x00236964 File Offset: 0x00234B64
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 65655, RefRangeEnd = 65684, XrefRangeStart = 65655, XrefRangeEnd = 65684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EquippedItemHandler() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EquippedItemHandler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquippedItemHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170027FD RID: 10237
		// (get) Token: 0x06008132 RID: 33074 RVA: 0x002369A0 File Offset: 0x00234BA0
		public unsafe virtual GameObject gameObject
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquippedItemHandler.NativeMethodInfoPtr_ScheduleOne_Core_Equipping_Framework_IEquippedItemHandler_get_gameObject_Private_Virtual_Final_New_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x06008133 RID: 33075 RVA: 0x002369E0 File Offset: 0x00234BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244849, XrefRangeEnd = 244874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EquippedItemHandler.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008134 RID: 33076 RVA: 0x00236A1C File Offset: 0x00234C1C
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EquippedItemHandler.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008135 RID: 33077 RVA: 0x00236A58 File Offset: 0x00234C58
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EquippedItemHandler.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170027FB RID: 10235
		// (get) Token: 0x06008136 RID: 33078 RVA: 0x00236A94 File Offset: 0x00234C94
		// (set) Token: 0x06008137 RID: 33079 RVA: 0x00236AD4 File Offset: 0x00234CD4
		public unsafe INetworkedEquippableUser SyncAccessor__user
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquippedItemHandler.NativeMethodInfoPtr_sync___get_value__user_Public_get_INetworkedEquippableUser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<INetworkedEquippableUser>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 244883, RefRangeEnd = 244884, XrefRangeStart = 244874, XrefRangeEnd = 244883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquippedItemHandler.NativeMethodInfoPtr_sync___set_value__user_Public_set_Void_INetworkedEquippableUser_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008138 RID: 33080 RVA: 0x00236B24 File Offset: 0x00234D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244884, XrefRangeEnd = 244886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Equipping_EquippedItemHandler(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EquippedItemHandler.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Equipping_EquippedItemHandler_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170027FC RID: 10236
		// (get) Token: 0x06008139 RID: 33081 RVA: 0x00236B98 File Offset: 0x00234D98
		// (set) Token: 0x0600813A RID: 33082 RVA: 0x00236BD8 File Offset: 0x00234DD8
		public unsafe EquippableData SyncAccessor__equippableData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquippedItemHandler.NativeMethodInfoPtr_sync___get_value__equippableData_Public_get_EquippableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EquippableData>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 244895, RefRangeEnd = 244896, XrefRangeStart = 244886, XrefRangeEnd = 244895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquippedItemHandler.NativeMethodInfoPtr_sync___set_value__equippableData_Public_set_Void_EquippableData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600813B RID: 33083 RVA: 0x00236C28 File Offset: 0x00234E28
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EquippedItemHandler.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600813C RID: 33084 RVA: 0x0003D775 File Offset: 0x0003B975
		public EquippedItemHandler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027F0 RID: 10224
		// (get) Token: 0x0600813D RID: 33085 RVA: 0x00236C64 File Offset: 0x00234E64
		// (set) Token: 0x0600813E RID: 33086 RVA: 0x0003D77E File Offset: 0x0003B97E
		public unsafe bool _IsEquipped_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EquippedItemHandler.NativeFieldInfoPtr__IsEquipped_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EquippedItemHandler.NativeFieldInfoPtr__IsEquipped_k__BackingField)) = value;
			}
		}

		// Token: 0x170027F1 RID: 10225
		// (get) Token: 0x0600813F RID: 33087 RVA: 0x00236C8C File Offset: 0x00234E8C
		// (set) Token: 0x06008140 RID: 33088 RVA: 0x0003D799 File Offset: 0x0003B999
		public unsafe INetworkedEquippableUser _user
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EquippedItemHandler.NativeFieldInfoPtr__user);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<INetworkedEquippableUser>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EquippedItemHandler.NativeFieldInfoPtr__user), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027F2 RID: 10226
		// (get) Token: 0x06008141 RID: 33089 RVA: 0x00236CBC File Offset: 0x00234EBC
		// (set) Token: 0x06008142 RID: 33090 RVA: 0x0003D7B8 File Offset: 0x0003B9B8
		public unsafe EquippableData _equippableData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EquippedItemHandler.NativeFieldInfoPtr__equippableData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EquippableData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EquippedItemHandler.NativeFieldInfoPtr__equippableData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027F3 RID: 10227
		// (get) Token: 0x06008143 RID: 33091 RVA: 0x00236CEC File Offset: 0x00234EEC
		// (set) Token: 0x06008144 RID: 33092 RVA: 0x0003D7D7 File Offset: 0x0003B9D7
		public unsafe Action OnUnequipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EquippedItemHandler.NativeFieldInfoPtr_OnUnequipped);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EquippedItemHandler.NativeFieldInfoPtr_OnUnequipped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027F4 RID: 10228
		// (get) Token: 0x06008145 RID: 33093 RVA: 0x00236D1C File Offset: 0x00234F1C
		// (set) Token: 0x06008146 RID: 33094 RVA: 0x0003D7F6 File Offset: 0x0003B9F6
		public unsafe SyncVar<INetworkedEquippableUser> syncVar____user
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EquippedItemHandler.NativeFieldInfoPtr_syncVar____user);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<INetworkedEquippableUser>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EquippedItemHandler.NativeFieldInfoPtr_syncVar____user), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027F5 RID: 10229
		// (get) Token: 0x06008147 RID: 33095 RVA: 0x00236D4C File Offset: 0x00234F4C
		// (set) Token: 0x06008148 RID: 33096 RVA: 0x0003D815 File Offset: 0x0003BA15
		public unsafe SyncVar<EquippableData> syncVar____equippableData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EquippedItemHandler.NativeFieldInfoPtr_syncVar____equippableData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<EquippableData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EquippedItemHandler.NativeFieldInfoPtr_syncVar____equippableData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027F6 RID: 10230
		// (get) Token: 0x06008149 RID: 33097 RVA: 0x00236D7C File Offset: 0x00234F7C
		// (set) Token: 0x0600814A RID: 33098 RVA: 0x0003D834 File Offset: 0x0003BA34
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EquippedItemHandler.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EquippedItemHandler.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170027F7 RID: 10231
		// (get) Token: 0x0600814B RID: 33099 RVA: 0x00236DA4 File Offset: 0x00234FA4
		// (set) Token: 0x0600814C RID: 33100 RVA: 0x0003D84F File Offset: 0x0003BA4F
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EquippedItemHandler.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EquippedItemHandler.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04005803 RID: 22531
		private static readonly IntPtr NativeFieldInfoPtr__IsEquipped_k__BackingField;

		// Token: 0x04005804 RID: 22532
		private static readonly IntPtr NativeFieldInfoPtr__user;

		// Token: 0x04005805 RID: 22533
		private static readonly IntPtr NativeFieldInfoPtr__equippableData;

		// Token: 0x04005806 RID: 22534
		private static readonly IntPtr NativeFieldInfoPtr_OnUnequipped;

		// Token: 0x04005807 RID: 22535
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____user;

		// Token: 0x04005808 RID: 22536
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____equippableData;

		// Token: 0x04005809 RID: 22537
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400580A RID: 22538
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400580B RID: 22539
		private static readonly IntPtr NativeMethodInfoPtr_get_User_Public_Virtual_Final_New_get_IEquippableUser_0;

		// Token: 0x0400580C RID: 22540
		private static readonly IntPtr NativeMethodInfoPtr_get_EquippableData_Public_Virtual_Final_New_get_EquippableData_0;

		// Token: 0x0400580D RID: 22541
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEquipped_Public_get_Boolean_0;

		// Token: 0x0400580E RID: 22542
		private static readonly IntPtr NativeMethodInfoPtr_set_IsEquipped_Private_set_Void_Boolean_0;

		// Token: 0x0400580F RID: 22543
		private static readonly IntPtr NativeMethodInfoPtr_add_OnUnequipped_Public_Virtual_Final_New_add_Void_Action_0;

		// Token: 0x04005810 RID: 22544
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnUnequipped_Public_Virtual_Final_New_rem_Void_Action_0;

		// Token: 0x04005811 RID: 22545
		private static readonly IntPtr NativeMethodInfoPtr_Equipped_Public_Virtual_New_Void_IEquippableUser_EquippableData_0;

		// Token: 0x04005812 RID: 22546
		private static readonly IntPtr NativeMethodInfoPtr_EquippedWithItem_Public_Virtual_New_Void_IEquippableUser_EquippableData_BaseItemInstance_0;

		// Token: 0x04005813 RID: 22547
		private static readonly IntPtr NativeMethodInfoPtr_Unequipped_Public_Virtual_New_Void_0;

		// Token: 0x04005814 RID: 22548
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x04005815 RID: 22549
		private static readonly IntPtr NativeMethodInfoPtr_SetupParent_Private_Void_0;

		// Token: 0x04005816 RID: 22550
		private static readonly IntPtr NativeMethodInfoPtr_SetupThirdPerson_Protected_Virtual_New_Void_0;

		// Token: 0x04005817 RID: 22551
		private static readonly IntPtr NativeMethodInfoPtr_SetupFirstPerson_Protected_Virtual_New_Void_0;

		// Token: 0x04005818 RID: 22552
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04005819 RID: 22553
		private static readonly IntPtr NativeMethodInfoPtr_UserUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x0400581A RID: 22554
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400581B RID: 22555
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleOne_Core_Equipping_Framework_IEquippedItemHandler_get_gameObject_Private_Virtual_Final_New_get_GameObject_0;

		// Token: 0x0400581C RID: 22556
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400581D RID: 22557
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400581E RID: 22558
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400581F RID: 22559
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__user_Public_get_INetworkedEquippableUser_0;

		// Token: 0x04005820 RID: 22560
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__user_Public_set_Void_INetworkedEquippableUser_Boolean_0;

		// Token: 0x04005821 RID: 22561
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Equipping_EquippedItemHandler_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04005822 RID: 22562
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__equippableData_Public_get_EquippableData_0;

		// Token: 0x04005823 RID: 22563
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__equippableData_Public_set_Void_EquippableData_Boolean_0;

		// Token: 0x04005824 RID: 22564
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
