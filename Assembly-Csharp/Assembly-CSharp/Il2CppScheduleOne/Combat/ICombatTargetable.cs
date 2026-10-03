using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using UnityEngine;

namespace Il2CppScheduleOne.Combat
{
	// Token: 0x020006FE RID: 1790
	public class ICombatTargetable : Il2CppObjectBase
	{
		// Token: 0x0600AC22 RID: 44066 RVA: 0x002D4DEC File Offset: 0x002D2FEC
		// Note: this type is marked as 'beforefieldinit'.
		static ICombatTargetable()
		{
			Il2CppClassPointerStore<ICombatTargetable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Combat", "ICombatTargetable");
			ICombatTargetable.NativeMethodInfoPtr_get_NetworkObject_Public_Abstract_Virtual_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICombatTargetable>.NativeClassPtr, 100686019);
			ICombatTargetable.NativeMethodInfoPtr_get_CenterPoint_Public_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICombatTargetable>.NativeClassPtr, 100686020);
			ICombatTargetable.NativeMethodInfoPtr_get_CenterPointTransform_Public_Abstract_Virtual_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICombatTargetable>.NativeClassPtr, 100686021);
			ICombatTargetable.NativeMethodInfoPtr_get_LookAtPoint_Public_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICombatTargetable>.NativeClassPtr, 100686022);
			ICombatTargetable.NativeMethodInfoPtr_get_IsCurrentlyTargetable_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICombatTargetable>.NativeClassPtr, 100686023);
			ICombatTargetable.NativeMethodInfoPtr_get_RangedHitChanceMultiplier_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICombatTargetable>.NativeClassPtr, 100686024);
			ICombatTargetable.NativeMethodInfoPtr_get_Velocity_Public_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICombatTargetable>.NativeClassPtr, 100686025);
			ICombatTargetable.NativeMethodInfoPtr_RecordLastKnownPosition_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICombatTargetable>.NativeClassPtr, 100686026);
			ICombatTargetable.NativeMethodInfoPtr_GetSearchTime_Public_Abstract_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICombatTargetable>.NativeClassPtr, 100686027);
			ICombatTargetable.NativeMethodInfoPtr_get_IsPlayer_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICombatTargetable>.NativeClassPtr, 100686028);
			ICombatTargetable.NativeMethodInfoPtr_get_AsPlayer_Public_Virtual_New_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICombatTargetable>.NativeClassPtr, 100686029);
			ICombatTargetable.NativeMethodInfoPtr_IsNull_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICombatTargetable>.NativeClassPtr, 100686030);
		}

		// Token: 0x17003391 RID: 13201
		// (get) Token: 0x0600AC23 RID: 44067 RVA: 0x002D4F04 File Offset: 0x002D3104
		public unsafe virtual NetworkObject NetworkObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICombatTargetable.NativeMethodInfoPtr_get_NetworkObject_Public_Abstract_Virtual_New_get_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
		}

		// Token: 0x17003392 RID: 13202
		// (get) Token: 0x0600AC24 RID: 44068 RVA: 0x002D4F50 File Offset: 0x002D3150
		public unsafe virtual Vector3 CenterPoint
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295474, XrefRangeEnd = 295478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICombatTargetable.NativeMethodInfoPtr_get_CenterPoint_Public_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003393 RID: 13203
		// (get) Token: 0x0600AC25 RID: 44069 RVA: 0x002D4F98 File Offset: 0x002D3198
		public unsafe virtual Transform CenterPointTransform
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICombatTargetable.NativeMethodInfoPtr_get_CenterPointTransform_Public_Abstract_Virtual_New_get_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17003394 RID: 13204
		// (get) Token: 0x0600AC26 RID: 44070 RVA: 0x002D4FE4 File Offset: 0x002D31E4
		public unsafe virtual Vector3 LookAtPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICombatTargetable.NativeMethodInfoPtr_get_LookAtPoint_Public_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003395 RID: 13205
		// (get) Token: 0x0600AC27 RID: 44071 RVA: 0x002D502C File Offset: 0x002D322C
		public unsafe virtual bool IsCurrentlyTargetable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICombatTargetable.NativeMethodInfoPtr_get_IsCurrentlyTargetable_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003396 RID: 13206
		// (get) Token: 0x0600AC28 RID: 44072 RVA: 0x002D5074 File Offset: 0x002D3274
		public unsafe virtual float RangedHitChanceMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICombatTargetable.NativeMethodInfoPtr_get_RangedHitChanceMultiplier_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003397 RID: 13207
		// (get) Token: 0x0600AC29 RID: 44073 RVA: 0x002D50BC File Offset: 0x002D32BC
		public unsafe virtual Vector3 Velocity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICombatTargetable.NativeMethodInfoPtr_get_Velocity_Public_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600AC2A RID: 44074 RVA: 0x002D5104 File Offset: 0x002D3304
		[CallerCount(0)]
		public unsafe virtual void RecordLastKnownPosition(bool resetTimeSinceLastSeen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref resetTimeSinceLastSeen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICombatTargetable.NativeMethodInfoPtr_RecordLastKnownPosition_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC2B RID: 44075 RVA: 0x002D5150 File Offset: 0x002D3350
		[CallerCount(0)]
		public unsafe virtual float GetSearchTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICombatTargetable.NativeMethodInfoPtr_GetSearchTime_Public_Abstract_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17003398 RID: 13208
		// (get) Token: 0x0600AC2C RID: 44076 RVA: 0x002D5198 File Offset: 0x002D3398
		public unsafe virtual bool IsPlayer
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295478, XrefRangeEnd = 295480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICombatTargetable.NativeMethodInfoPtr_get_IsPlayer_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003399 RID: 13209
		// (get) Token: 0x0600AC2D RID: 44077 RVA: 0x002D51E0 File Offset: 0x002D33E0
		public unsafe virtual Player AsPlayer
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295480, XrefRangeEnd = 295482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICombatTargetable.NativeMethodInfoPtr_get_AsPlayer_Public_Virtual_New_get_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
		}

		// Token: 0x0600AC2E RID: 44078 RVA: 0x002D522C File Offset: 0x002D342C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295482, XrefRangeEnd = 295494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsNull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICombatTargetable.NativeMethodInfoPtr_IsNull_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600AC2F RID: 44079 RVA: 0x0004EB2D File Offset: 0x0004CD2D
		public ICombatTargetable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040076DE RID: 30430
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkObject_Public_Abstract_Virtual_New_get_NetworkObject_0;

		// Token: 0x040076DF RID: 30431
		private static readonly IntPtr NativeMethodInfoPtr_get_CenterPoint_Public_Virtual_New_get_Vector3_0;

		// Token: 0x040076E0 RID: 30432
		private static readonly IntPtr NativeMethodInfoPtr_get_CenterPointTransform_Public_Abstract_Virtual_New_get_Transform_0;

		// Token: 0x040076E1 RID: 30433
		private static readonly IntPtr NativeMethodInfoPtr_get_LookAtPoint_Public_Abstract_Virtual_New_get_Vector3_0;

		// Token: 0x040076E2 RID: 30434
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCurrentlyTargetable_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040076E3 RID: 30435
		private static readonly IntPtr NativeMethodInfoPtr_get_RangedHitChanceMultiplier_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x040076E4 RID: 30436
		private static readonly IntPtr NativeMethodInfoPtr_get_Velocity_Public_Abstract_Virtual_New_get_Vector3_0;

		// Token: 0x040076E5 RID: 30437
		private static readonly IntPtr NativeMethodInfoPtr_RecordLastKnownPosition_Public_Abstract_Virtual_New_Void_Boolean_0;

		// Token: 0x040076E6 RID: 30438
		private static readonly IntPtr NativeMethodInfoPtr_GetSearchTime_Public_Abstract_Virtual_New_Single_0;

		// Token: 0x040076E7 RID: 30439
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPlayer_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040076E8 RID: 30440
		private static readonly IntPtr NativeMethodInfoPtr_get_AsPlayer_Public_Virtual_New_get_Player_0;

		// Token: 0x040076E9 RID: 30441
		private static readonly IntPtr NativeMethodInfoPtr_IsNull_Public_Virtual_New_Boolean_0;
	}
}
