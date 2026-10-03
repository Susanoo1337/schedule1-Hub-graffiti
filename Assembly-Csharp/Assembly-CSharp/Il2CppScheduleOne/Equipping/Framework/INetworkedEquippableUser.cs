using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Core.Equipping.Framework;
using Il2CppScheduleOne.Core.Items.Framework;
using UnityEngine;

namespace Il2CppScheduleOne.Equipping.Framework
{
	// Token: 0x02000592 RID: 1426
	public class INetworkedEquippableUser : Il2CppObjectBase
	{
		// Token: 0x06008197 RID: 33175 RVA: 0x00237D80 File Offset: 0x00235F80
		// Note: this type is marked as 'beforefieldinit'.
		static INetworkedEquippableUser()
		{
			Il2CppClassPointerStore<INetworkedEquippableUser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping.Framework", "INetworkedEquippableUser");
			INetworkedEquippableUser.NativeMethodInfoPtr_get_NetworkBehaviour_Public_Abstract_Virtual_New_get_NetworkBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INetworkedEquippableUser>.NativeClassPtr, 100679940);
			INetworkedEquippableUser.NativeMethodInfoPtr_EquipLocal_Public_Abstract_Virtual_New_IEquippedItemHandler_EquippableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INetworkedEquippableUser>.NativeClassPtr, 100679941);
			INetworkedEquippableUser.NativeMethodInfoPtr_EquipLocal_Public_Abstract_Virtual_New_IEquippedItemHandler_BaseItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INetworkedEquippableUser>.NativeClassPtr, 100679942);
			INetworkedEquippableUser.NativeMethodInfoPtr_get_ItemHandlerContainer_Public_Virtual_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INetworkedEquippableUser>.NativeClassPtr, 100679943);
		}

		// Token: 0x1700280E RID: 10254
		// (get) Token: 0x06008198 RID: 33176 RVA: 0x00237DF8 File Offset: 0x00235FF8
		public unsafe virtual NetworkBehaviour NetworkBehaviour
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), INetworkedEquippableUser.NativeMethodInfoPtr_get_NetworkBehaviour_Public_Abstract_Virtual_New_get_NetworkBehaviour_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkBehaviour>(intPtr3) : null;
			}
		}

		// Token: 0x06008199 RID: 33177 RVA: 0x00237E44 File Offset: 0x00236044
		[CallerCount(0)]
		public unsafe virtual IEquippedItemHandler EquipLocal(EquippableData equippable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(equippable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), INetworkedEquippableUser.NativeMethodInfoPtr_EquipLocal_Public_Abstract_Virtual_New_IEquippedItemHandler_EquippableData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEquippedItemHandler>(intPtr3) : null;
		}

		// Token: 0x0600819A RID: 33178 RVA: 0x00237EA0 File Offset: 0x002360A0
		[CallerCount(0)]
		public unsafe virtual IEquippedItemHandler EquipLocal(BaseItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), INetworkedEquippableUser.NativeMethodInfoPtr_EquipLocal_Public_Abstract_Virtual_New_IEquippedItemHandler_BaseItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEquippedItemHandler>(intPtr3) : null;
		}

		// Token: 0x1700280F RID: 10255
		// (get) Token: 0x0600819B RID: 33179 RVA: 0x00237EFC File Offset: 0x002360FC
		public unsafe virtual Transform ItemHandlerContainer
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245313, XrefRangeEnd = 245318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), INetworkedEquippableUser.NativeMethodInfoPtr_get_ItemHandlerContainer_Public_Virtual_New_get_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x0600819C RID: 33180 RVA: 0x0003DA5C File Offset: 0x0003BC5C
		public INetworkedEquippableUser(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400584F RID: 22607
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkBehaviour_Public_Abstract_Virtual_New_get_NetworkBehaviour_0;

		// Token: 0x04005850 RID: 22608
		private static readonly IntPtr NativeMethodInfoPtr_EquipLocal_Public_Abstract_Virtual_New_IEquippedItemHandler_EquippableData_0;

		// Token: 0x04005851 RID: 22609
		private static readonly IntPtr NativeMethodInfoPtr_EquipLocal_Public_Abstract_Virtual_New_IEquippedItemHandler_BaseItemInstance_0;

		// Token: 0x04005852 RID: 22610
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemHandlerContainer_Public_Virtual_New_get_Transform_0;
	}
}
