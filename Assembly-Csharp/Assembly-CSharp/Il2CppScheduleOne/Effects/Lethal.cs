using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.PlayerScripts;

namespace Il2CppScheduleOne.Effects
{
	// Token: 0x020006BA RID: 1722
	public class Lethal : Effect
	{
		// Token: 0x0600A6A4 RID: 42660 RVA: 0x002C3634 File Offset: 0x002C1834
		// Note: this type is marked as 'beforefieldinit'.
		static Lethal()
		{
			Il2CppClassPointerStore<Lethal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Effects", "Lethal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lethal>.NativeClassPtr);
			Lethal.NativeFieldInfoPtr_HEALTH_DRAIN_PLAYER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lethal>.NativeClassPtr, "HEALTH_DRAIN_PLAYER");
			Lethal.NativeFieldInfoPtr_HEALTH_DRAIN_NPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lethal>.NativeClassPtr, "HEALTH_DRAIN_NPC");
			Lethal.NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lethal>.NativeClassPtr, 100685427);
			Lethal.NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lethal>.NativeClassPtr, 100685428);
			Lethal.NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lethal>.NativeClassPtr, 100685429);
			Lethal.NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lethal>.NativeClassPtr, 100685430);
			Lethal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lethal>.NativeClassPtr, 100685431);
		}

		// Token: 0x0600A6A5 RID: 42661 RVA: 0x002C36F0 File Offset: 0x002C18F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290329, XrefRangeEnd = 290337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyToNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Lethal.NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6A6 RID: 42662 RVA: 0x002C3740 File Offset: 0x002C1940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290337, XrefRangeEnd = 290356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyToPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Lethal.NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6A7 RID: 42663 RVA: 0x002C3790 File Offset: 0x002C1990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290356, XrefRangeEnd = 290363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearFromNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Lethal.NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6A8 RID: 42664 RVA: 0x002C37E0 File Offset: 0x002C19E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290363, XrefRangeEnd = 290381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearFromPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Lethal.NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6A9 RID: 42665 RVA: 0x002C3830 File Offset: 0x002C1A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Lethal() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lethal>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lethal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6AA RID: 42666 RVA: 0x0004BE20 File Offset: 0x0004A020
		public Lethal(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170031DC RID: 12764
		// (get) Token: 0x0600A6AB RID: 42667 RVA: 0x002C386C File Offset: 0x002C1A6C
		// (set) Token: 0x0600A6AC RID: 42668 RVA: 0x0004BE29 File Offset: 0x0004A029
		public unsafe static float HEALTH_DRAIN_PLAYER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Lethal.NativeFieldInfoPtr_HEALTH_DRAIN_PLAYER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Lethal.NativeFieldInfoPtr_HEALTH_DRAIN_PLAYER, (void*)(&value));
			}
		}

		// Token: 0x170031DD RID: 12765
		// (get) Token: 0x0600A6AD RID: 42669 RVA: 0x002C3888 File Offset: 0x002C1A88
		// (set) Token: 0x0600A6AE RID: 42670 RVA: 0x0004BE37 File Offset: 0x0004A037
		public unsafe static float HEALTH_DRAIN_NPC
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Lethal.NativeFieldInfoPtr_HEALTH_DRAIN_NPC, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Lethal.NativeFieldInfoPtr_HEALTH_DRAIN_NPC, (void*)(&value));
			}
		}

		// Token: 0x04007344 RID: 29508
		private static readonly IntPtr NativeFieldInfoPtr_HEALTH_DRAIN_PLAYER;

		// Token: 0x04007345 RID: 29509
		private static readonly IntPtr NativeFieldInfoPtr_HEALTH_DRAIN_NPC;

		// Token: 0x04007346 RID: 29510
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x04007347 RID: 29511
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x04007348 RID: 29512
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x04007349 RID: 29513
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x0400734A RID: 29514
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
