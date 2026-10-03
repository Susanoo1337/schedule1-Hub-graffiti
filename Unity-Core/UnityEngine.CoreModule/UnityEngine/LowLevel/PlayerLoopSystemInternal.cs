using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.LowLevel
{
	// Token: 0x020001BB RID: 443
	public sealed class PlayerLoopSystemInternal : ValueType
	{
		// Token: 0x06002074 RID: 8308 RVA: 0x00084808 File Offset: 0x00082A08
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerLoopSystemInternal()
		{
			Il2CppClassPointerStore<PlayerLoopSystemInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.LowLevel", "PlayerLoopSystemInternal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerLoopSystemInternal>.NativeClassPtr);
			PlayerLoopSystemInternal.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLoopSystemInternal>.NativeClassPtr, "type");
			PlayerLoopSystemInternal.NativeFieldInfoPtr_updateDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLoopSystemInternal>.NativeClassPtr, "updateDelegate");
			PlayerLoopSystemInternal.NativeFieldInfoPtr_updateFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLoopSystemInternal>.NativeClassPtr, "updateFunction");
			PlayerLoopSystemInternal.NativeFieldInfoPtr_loopConditionFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLoopSystemInternal>.NativeClassPtr, "loopConditionFunction");
			PlayerLoopSystemInternal.NativeFieldInfoPtr_numSubSystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLoopSystemInternal>.NativeClassPtr, "numSubSystems");
		}

		// Token: 0x06002075 RID: 8309 RVA: 0x0000EF08 File Offset: 0x0000D108
		public PlayerLoopSystemInternal(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06002076 RID: 8310 RVA: 0x0000EF11 File Offset: 0x0000D111
		public PlayerLoopSystemInternal() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerLoopSystemInternal>.NativeClassPtr))
		{
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x06002077 RID: 8311 RVA: 0x0008489C File Offset: 0x00082A9C
		// (set) Token: 0x06002078 RID: 8312 RVA: 0x0000EF23 File Offset: 0x0000D123
		public unsafe Type type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x06002079 RID: 8313 RVA: 0x000848CC File Offset: 0x00082ACC
		// (set) Token: 0x0600207A RID: 8314 RVA: 0x0000EF42 File Offset: 0x0000D142
		public unsafe PlayerLoopSystem.UpdateFunction updateDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_updateDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerLoopSystem.UpdateFunction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_updateDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x0600207B RID: 8315 RVA: 0x000848FC File Offset: 0x00082AFC
		// (set) Token: 0x0600207C RID: 8316 RVA: 0x0000EF61 File Offset: 0x0000D161
		public unsafe IntPtr updateFunction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_updateFunction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_updateFunction)) = value;
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x0600207D RID: 8317 RVA: 0x00084924 File Offset: 0x00082B24
		// (set) Token: 0x0600207E RID: 8318 RVA: 0x0000EF7C File Offset: 0x0000D17C
		public unsafe IntPtr loopConditionFunction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_loopConditionFunction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_loopConditionFunction)) = value;
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x0600207F RID: 8319 RVA: 0x0008494C File Offset: 0x00082B4C
		// (set) Token: 0x06002080 RID: 8320 RVA: 0x0000EF97 File Offset: 0x0000D197
		public unsafe int numSubSystems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_numSubSystems);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_numSubSystems)) = value;
			}
		}

		// Token: 0x04001A41 RID: 6721
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04001A42 RID: 6722
		private static readonly IntPtr NativeFieldInfoPtr_updateDelegate;

		// Token: 0x04001A43 RID: 6723
		private static readonly IntPtr NativeFieldInfoPtr_updateFunction;

		// Token: 0x04001A44 RID: 6724
		private static readonly IntPtr NativeFieldInfoPtr_loopConditionFunction;

		// Token: 0x04001A45 RID: 6725
		private static readonly IntPtr NativeFieldInfoPtr_numSubSystems;
	}
}
