using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.PlayerScripts;
using UnityEngine;

namespace Il2CppScheduleOne.Effects
{
	// Token: 0x020006AA RID: 1706
	public class BrightEyed : Effect
	{
		// Token: 0x0600A61C RID: 42524 RVA: 0x002C112C File Offset: 0x002BF32C
		// Note: this type is marked as 'beforefieldinit'.
		static BrightEyed()
		{
			Il2CppClassPointerStore<BrightEyed>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Effects", "BrightEyed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BrightEyed>.NativeClassPtr);
			BrightEyed.NativeFieldInfoPtr_EyeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrightEyed>.NativeClassPtr, "EyeColor");
			BrightEyed.NativeFieldInfoPtr_Emission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrightEyed>.NativeClassPtr, "Emission");
			BrightEyed.NativeFieldInfoPtr_LightIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrightEyed>.NativeClassPtr, "LightIntensity");
			BrightEyed.NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrightEyed>.NativeClassPtr, 100685339);
			BrightEyed.NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrightEyed>.NativeClassPtr, 100685340);
			BrightEyed.NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrightEyed>.NativeClassPtr, 100685341);
			BrightEyed.NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrightEyed>.NativeClassPtr, 100685342);
			BrightEyed.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrightEyed>.NativeClassPtr, 100685343);
		}

		// Token: 0x0600A61D RID: 42525 RVA: 0x002C11FC File Offset: 0x002BF3FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290036, XrefRangeEnd = 290038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyToNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrightEyed.NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A61E RID: 42526 RVA: 0x002C124C File Offset: 0x002BF44C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290038, XrefRangeEnd = 290040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyToPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrightEyed.NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A61F RID: 42527 RVA: 0x002C129C File Offset: 0x002BF49C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290040, XrefRangeEnd = 290042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearFromNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrightEyed.NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A620 RID: 42528 RVA: 0x002C12EC File Offset: 0x002BF4EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290042, XrefRangeEnd = 290044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearFromPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrightEyed.NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A621 RID: 42529 RVA: 0x002C133C File Offset: 0x002BF53C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290044, XrefRangeEnd = 290045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BrightEyed() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BrightEyed>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrightEyed.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A622 RID: 42530 RVA: 0x0004BCDE File Offset: 0x00049EDE
		public BrightEyed(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170031D3 RID: 12755
		// (get) Token: 0x0600A623 RID: 42531 RVA: 0x002C1378 File Offset: 0x002BF578
		// (set) Token: 0x0600A624 RID: 42532 RVA: 0x0004BCE7 File Offset: 0x00049EE7
		public unsafe Color EyeColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrightEyed.NativeFieldInfoPtr_EyeColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrightEyed.NativeFieldInfoPtr_EyeColor)) = value;
			}
		}

		// Token: 0x170031D4 RID: 12756
		// (get) Token: 0x0600A625 RID: 42533 RVA: 0x002C13A0 File Offset: 0x002BF5A0
		// (set) Token: 0x0600A626 RID: 42534 RVA: 0x0004BD02 File Offset: 0x00049F02
		public unsafe float Emission
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrightEyed.NativeFieldInfoPtr_Emission);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrightEyed.NativeFieldInfoPtr_Emission)) = value;
			}
		}

		// Token: 0x170031D5 RID: 12757
		// (get) Token: 0x0600A627 RID: 42535 RVA: 0x002C13C8 File Offset: 0x002BF5C8
		// (set) Token: 0x0600A628 RID: 42536 RVA: 0x0004BD1D File Offset: 0x00049F1D
		public unsafe float LightIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrightEyed.NativeFieldInfoPtr_LightIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrightEyed.NativeFieldInfoPtr_LightIntensity)) = value;
			}
		}

		// Token: 0x040072E5 RID: 29413
		private static readonly IntPtr NativeFieldInfoPtr_EyeColor;

		// Token: 0x040072E6 RID: 29414
		private static readonly IntPtr NativeFieldInfoPtr_Emission;

		// Token: 0x040072E7 RID: 29415
		private static readonly IntPtr NativeFieldInfoPtr_LightIntensity;

		// Token: 0x040072E8 RID: 29416
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x040072E9 RID: 29417
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x040072EA RID: 29418
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x040072EB RID: 29419
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x040072EC RID: 29420
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
