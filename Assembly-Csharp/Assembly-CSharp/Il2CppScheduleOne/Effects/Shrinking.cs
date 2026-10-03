using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.PlayerScripts;

namespace Il2CppScheduleOne.Effects
{
	// Token: 0x020006C1 RID: 1729
	public class Shrinking : Effect
	{
		// Token: 0x0600A6E3 RID: 42723 RVA: 0x002C468C File Offset: 0x002C288C
		// Note: this type is marked as 'beforefieldinit'.
		static Shrinking()
		{
			Il2CppClassPointerStore<Shrinking>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Effects", "Shrinking");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Shrinking>.NativeClassPtr);
			Shrinking.NativeFieldInfoPtr_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shrinking>.NativeClassPtr, "Scale");
			Shrinking.NativeFieldInfoPtr_LerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shrinking>.NativeClassPtr, "LerpTime");
			Shrinking.NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shrinking>.NativeClassPtr, 100685480);
			Shrinking.NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shrinking>.NativeClassPtr, 100685481);
			Shrinking.NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shrinking>.NativeClassPtr, 100685482);
			Shrinking.NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shrinking>.NativeClassPtr, 100685483);
			Shrinking.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shrinking>.NativeClassPtr, 100685484);
		}

		// Token: 0x0600A6E4 RID: 42724 RVA: 0x002C4748 File Offset: 0x002C2948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290594, XrefRangeEnd = 290595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyToNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Shrinking.NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6E5 RID: 42725 RVA: 0x002C4798 File Offset: 0x002C2998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290595, XrefRangeEnd = 290597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyToPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Shrinking.NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6E6 RID: 42726 RVA: 0x002C47E8 File Offset: 0x002C29E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290597, XrefRangeEnd = 290598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearFromNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Shrinking.NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6E7 RID: 42727 RVA: 0x002C4838 File Offset: 0x002C2A38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290598, XrefRangeEnd = 290600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearFromPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Shrinking.NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6E8 RID: 42728 RVA: 0x002C4888 File Offset: 0x002C2A88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Shrinking() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Shrinking>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shrinking.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6E9 RID: 42729 RVA: 0x0004BEB3 File Offset: 0x0004A0B3
		public Shrinking(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170031E2 RID: 12770
		// (get) Token: 0x0600A6EA RID: 42730 RVA: 0x002C48C4 File Offset: 0x002C2AC4
		// (set) Token: 0x0600A6EB RID: 42731 RVA: 0x0004BEBC File Offset: 0x0004A0BC
		public unsafe static float Scale
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Shrinking.NativeFieldInfoPtr_Scale, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Shrinking.NativeFieldInfoPtr_Scale, (void*)(&value));
			}
		}

		// Token: 0x170031E3 RID: 12771
		// (get) Token: 0x0600A6EC RID: 42732 RVA: 0x002C48E0 File Offset: 0x002C2AE0
		// (set) Token: 0x0600A6ED RID: 42733 RVA: 0x0004BECA File Offset: 0x0004A0CA
		public unsafe static float LerpTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Shrinking.NativeFieldInfoPtr_LerpTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Shrinking.NativeFieldInfoPtr_LerpTime, (void*)(&value));
			}
		}

		// Token: 0x0400736F RID: 29551
		private static readonly IntPtr NativeFieldInfoPtr_Scale;

		// Token: 0x04007370 RID: 29552
		private static readonly IntPtr NativeFieldInfoPtr_LerpTime;

		// Token: 0x04007371 RID: 29553
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x04007372 RID: 29554
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x04007373 RID: 29555
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x04007374 RID: 29556
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x04007375 RID: 29557
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
