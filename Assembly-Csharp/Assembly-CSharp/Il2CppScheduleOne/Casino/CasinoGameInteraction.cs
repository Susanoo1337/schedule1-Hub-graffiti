using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Casino
{
	// Token: 0x02000430 RID: 1072
	public class CasinoGameInteraction : MonoBehaviour
	{
		// Token: 0x06005EF4 RID: 24308 RVA: 0x001C349C File Offset: 0x001C169C
		// Note: this type is marked as 'beforefieldinit'.
		static CasinoGameInteraction()
		{
			Il2CppClassPointerStore<CasinoGameInteraction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino", "CasinoGameInteraction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CasinoGameInteraction>.NativeClassPtr);
			CasinoGameInteraction.NativeFieldInfoPtr_GameName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameInteraction>.NativeClassPtr, "GameName");
			CasinoGameInteraction.NativeFieldInfoPtr_Players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameInteraction>.NativeClassPtr, "Players");
			CasinoGameInteraction.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameInteraction>.NativeClassPtr, "IntObj");
			CasinoGameInteraction.NativeFieldInfoPtr_onLocalPlayerRequestJoin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameInteraction>.NativeClassPtr, "onLocalPlayerRequestJoin");
			CasinoGameInteraction.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameInteraction>.NativeClassPtr, 100675741);
			CasinoGameInteraction.NativeMethodInfoPtr_Hovered_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameInteraction>.NativeClassPtr, 100675742);
			CasinoGameInteraction.NativeMethodInfoPtr_Interacted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameInteraction>.NativeClassPtr, 100675743);
			CasinoGameInteraction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameInteraction>.NativeClassPtr, 100675744);
		}

		// Token: 0x06005EF5 RID: 24309 RVA: 0x001C356C File Offset: 0x001C176C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202448, XrefRangeEnd = 202462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGameInteraction.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EF6 RID: 24310 RVA: 0x001C35A0 File Offset: 0x001C17A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202462, XrefRangeEnd = 202467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGameInteraction.NativeMethodInfoPtr_Hovered_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EF7 RID: 24311 RVA: 0x001C35D4 File Offset: 0x001C17D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202467, XrefRangeEnd = 202472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGameInteraction.NativeMethodInfoPtr_Interacted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EF8 RID: 24312 RVA: 0x001C3608 File Offset: 0x001C1808
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CasinoGameInteraction() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CasinoGameInteraction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGameInteraction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EF9 RID: 24313 RVA: 0x0002CE75 File Offset: 0x0002B075
		public CasinoGameInteraction(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D43 RID: 7491
		// (get) Token: 0x06005EFA RID: 24314 RVA: 0x001C3644 File Offset: 0x001C1844
		// (set) Token: 0x06005EFB RID: 24315 RVA: 0x0002CE7E File Offset: 0x0002B07E
		public unsafe string GameName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameInteraction.NativeFieldInfoPtr_GameName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameInteraction.NativeFieldInfoPtr_GameName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D44 RID: 7492
		// (get) Token: 0x06005EFC RID: 24316 RVA: 0x001C366C File Offset: 0x001C186C
		// (set) Token: 0x06005EFD RID: 24317 RVA: 0x0002CE9D File Offset: 0x0002B09D
		public unsafe CasinoGamePlayers Players
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameInteraction.NativeFieldInfoPtr_Players);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayers>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameInteraction.NativeFieldInfoPtr_Players), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D45 RID: 7493
		// (get) Token: 0x06005EFE RID: 24318 RVA: 0x001C369C File Offset: 0x001C189C
		// (set) Token: 0x06005EFF RID: 24319 RVA: 0x0002CEBC File Offset: 0x0002B0BC
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameInteraction.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameInteraction.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D46 RID: 7494
		// (get) Token: 0x06005F00 RID: 24320 RVA: 0x001C36CC File Offset: 0x001C18CC
		// (set) Token: 0x06005F01 RID: 24321 RVA: 0x0002CEDB File Offset: 0x0002B0DB
		public unsafe Action<Player> onLocalPlayerRequestJoin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameInteraction.NativeFieldInfoPtr_onLocalPlayerRequestJoin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameInteraction.NativeFieldInfoPtr_onLocalPlayerRequestJoin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400415B RID: 16731
		private static readonly IntPtr NativeFieldInfoPtr_GameName;

		// Token: 0x0400415C RID: 16732
		private static readonly IntPtr NativeFieldInfoPtr_Players;

		// Token: 0x0400415D RID: 16733
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x0400415E RID: 16734
		private static readonly IntPtr NativeFieldInfoPtr_onLocalPlayerRequestJoin;

		// Token: 0x0400415F RID: 16735
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004160 RID: 16736
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Private_Void_0;

		// Token: 0x04004161 RID: 16737
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Private_Void_0;

		// Token: 0x04004162 RID: 16738
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
