using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.AvatarFramework;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.PlayerScripts;
using UnityEngine;

namespace Il2CppScheduleOne.Effects
{
	// Token: 0x020006AF RID: 1711
	public class Electrifying : Effect
	{
		// Token: 0x0600A645 RID: 42565 RVA: 0x002C1C30 File Offset: 0x002BFE30
		// Note: this type is marked as 'beforefieldinit'.
		static Electrifying()
		{
			Il2CppClassPointerStore<Electrifying>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Effects", "Electrifying");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Electrifying>.NativeClassPtr);
			Electrifying.NativeFieldInfoPtr_EyeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Electrifying>.NativeClassPtr, "EyeColor");
			Electrifying.NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Electrifying>.NativeClassPtr, 100685364);
			Electrifying.NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Electrifying>.NativeClassPtr, 100685365);
			Electrifying.NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Electrifying>.NativeClassPtr, 100685366);
			Electrifying.NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Electrifying>.NativeClassPtr, 100685367);
			Electrifying.NativeMethodInfoPtr_ApplyToAvatar_Public_Static_Void_Avatar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Electrifying>.NativeClassPtr, 100685368);
			Electrifying.NativeMethodInfoPtr_ClearFromAvatar_Public_Static_Void_Avatar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Electrifying>.NativeClassPtr, 100685369);
			Electrifying.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Electrifying>.NativeClassPtr, 100685370);
		}

		// Token: 0x0600A646 RID: 42566 RVA: 0x002C1D00 File Offset: 0x002BFF00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290131, XrefRangeEnd = 290136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyToNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Electrifying.NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A647 RID: 42567 RVA: 0x002C1D50 File Offset: 0x002BFF50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290136, XrefRangeEnd = 290141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyToPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Electrifying.NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A648 RID: 42568 RVA: 0x002C1DA0 File Offset: 0x002BFFA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290141, XrefRangeEnd = 290147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearFromNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Electrifying.NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A649 RID: 42569 RVA: 0x002C1DF0 File Offset: 0x002BFFF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290147, XrefRangeEnd = 290156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearFromPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Electrifying.NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A64A RID: 42570 RVA: 0x002C1E40 File Offset: 0x002C0040
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 290162, RefRangeEnd = 290166, XrefRangeStart = 290156, XrefRangeEnd = 290162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ApplyToAvatar(Il2CppScheduleOne.AvatarFramework.Avatar avatar)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(avatar);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Electrifying.NativeMethodInfoPtr_ApplyToAvatar_Public_Static_Void_Avatar_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A64B RID: 42571 RVA: 0x002C1E78 File Offset: 0x002C0078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290166, XrefRangeEnd = 290169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearFromAvatar(Il2CppScheduleOne.AvatarFramework.Avatar avatar)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(avatar);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Electrifying.NativeMethodInfoPtr_ClearFromAvatar_Public_Static_Void_Avatar_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A64C RID: 42572 RVA: 0x002C1EB0 File Offset: 0x002C00B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Electrifying() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Electrifying>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Electrifying.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A64D RID: 42573 RVA: 0x0004BD5C File Offset: 0x00049F5C
		public Electrifying(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170031D6 RID: 12758
		// (get) Token: 0x0600A64E RID: 42574 RVA: 0x002C1EEC File Offset: 0x002C00EC
		// (set) Token: 0x0600A64F RID: 42575 RVA: 0x0004BD65 File Offset: 0x00049F65
		public unsafe static Color32 EyeColor
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(Electrifying.NativeFieldInfoPtr_EyeColor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Electrifying.NativeFieldInfoPtr_EyeColor, (void*)(&value));
			}
		}

		// Token: 0x04007301 RID: 29441
		private static readonly IntPtr NativeFieldInfoPtr_EyeColor;

		// Token: 0x04007302 RID: 29442
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x04007303 RID: 29443
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x04007304 RID: 29444
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x04007305 RID: 29445
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x04007306 RID: 29446
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToAvatar_Public_Static_Void_Avatar_0;

		// Token: 0x04007307 RID: 29447
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromAvatar_Public_Static_Void_Avatar_0;

		// Token: 0x04007308 RID: 29448
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
