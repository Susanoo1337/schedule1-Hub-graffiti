using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Vision;

namespace Il2CppScheduleOne.Effects
{
	// Token: 0x020006C4 RID: 1732
	public class Sneaky : Effect
	{
		// Token: 0x0600A6FC RID: 42748 RVA: 0x002C4D1C File Offset: 0x002C2F1C
		// Note: this type is marked as 'beforefieldinit'.
		static Sneaky()
		{
			Il2CppClassPointerStore<Sneaky>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Effects", "Sneaky");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sneaky>.NativeClassPtr);
			Sneaky.NativeFieldInfoPtr_SPEED_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sneaky>.NativeClassPtr, "SPEED_MULTIPLIER");
			Sneaky.NativeFieldInfoPtr_FOOTSTEP_VOL_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sneaky>.NativeClassPtr, "FOOTSTEP_VOL_MULTIPLIER");
			Sneaky.NativeFieldInfoPtr_visibilityAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sneaky>.NativeClassPtr, "visibilityAttribute");
			Sneaky.NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sneaky>.NativeClassPtr, 100685495);
			Sneaky.NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sneaky>.NativeClassPtr, 100685496);
			Sneaky.NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sneaky>.NativeClassPtr, 100685497);
			Sneaky.NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sneaky>.NativeClassPtr, 100685498);
			Sneaky.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sneaky>.NativeClassPtr, 100685499);
		}

		// Token: 0x0600A6FD RID: 42749 RVA: 0x002C4DEC File Offset: 0x002C2FEC
		[CallerCount(0)]
		public unsafe override void ApplyToNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sneaky.NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6FE RID: 42750 RVA: 0x002C4E3C File Offset: 0x002C303C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290620, XrefRangeEnd = 290644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyToPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sneaky.NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6FF RID: 42751 RVA: 0x002C4E8C File Offset: 0x002C308C
		[CallerCount(0)]
		public unsafe override void ClearFromNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sneaky.NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A700 RID: 42752 RVA: 0x002C4EDC File Offset: 0x002C30DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290644, XrefRangeEnd = 290659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearFromPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sneaky.NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A701 RID: 42753 RVA: 0x002C4F2C File Offset: 0x002C312C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sneaky() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sneaky>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sneaky.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A702 RID: 42754 RVA: 0x0004BEEA File Offset: 0x0004A0EA
		public Sneaky(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170031E4 RID: 12772
		// (get) Token: 0x0600A703 RID: 42755 RVA: 0x002C4F68 File Offset: 0x002C3168
		// (set) Token: 0x0600A704 RID: 42756 RVA: 0x0004BEF3 File Offset: 0x0004A0F3
		public unsafe static float SPEED_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Sneaky.NativeFieldInfoPtr_SPEED_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Sneaky.NativeFieldInfoPtr_SPEED_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x170031E5 RID: 12773
		// (get) Token: 0x0600A705 RID: 42757 RVA: 0x002C4F84 File Offset: 0x002C3184
		// (set) Token: 0x0600A706 RID: 42758 RVA: 0x0004BF01 File Offset: 0x0004A101
		public unsafe static float FOOTSTEP_VOL_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Sneaky.NativeFieldInfoPtr_FOOTSTEP_VOL_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Sneaky.NativeFieldInfoPtr_FOOTSTEP_VOL_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x170031E6 RID: 12774
		// (get) Token: 0x0600A707 RID: 42759 RVA: 0x002C4FA0 File Offset: 0x002C31A0
		// (set) Token: 0x0600A708 RID: 42760 RVA: 0x0004BF0F File Offset: 0x0004A10F
		public unsafe VisibilityAttribute visibilityAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sneaky.NativeFieldInfoPtr_visibilityAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisibilityAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sneaky.NativeFieldInfoPtr_visibilityAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007380 RID: 29568
		private static readonly IntPtr NativeFieldInfoPtr_SPEED_MULTIPLIER;

		// Token: 0x04007381 RID: 29569
		private static readonly IntPtr NativeFieldInfoPtr_FOOTSTEP_VOL_MULTIPLIER;

		// Token: 0x04007382 RID: 29570
		private static readonly IntPtr NativeFieldInfoPtr_visibilityAttribute;

		// Token: 0x04007383 RID: 29571
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x04007384 RID: 29572
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x04007385 RID: 29573
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x04007386 RID: 29574
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x04007387 RID: 29575
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
