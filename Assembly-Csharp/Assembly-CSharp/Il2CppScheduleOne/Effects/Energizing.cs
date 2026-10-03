using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.PlayerScripts;

namespace Il2CppScheduleOne.Effects
{
	// Token: 0x020006B0 RID: 1712
	public class Energizing : Effect
	{
		// Token: 0x0600A650 RID: 42576 RVA: 0x002C1F08 File Offset: 0x002C0108
		// Note: this type is marked as 'beforefieldinit'.
		static Energizing()
		{
			Il2CppClassPointerStore<Energizing>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Effects", "Energizing");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Energizing>.NativeClassPtr);
			Energizing.NativeFieldInfoPtr_SPEED_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Energizing>.NativeClassPtr, "SPEED_MULTIPLIER");
			Energizing.NativeFieldInfoPtr_WorkSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Energizing>.NativeClassPtr, "WorkSpeedMultiplier");
			Energizing.NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Energizing>.NativeClassPtr, 100685372);
			Energizing.NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Energizing>.NativeClassPtr, 100685373);
			Energizing.NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Energizing>.NativeClassPtr, 100685374);
			Energizing.NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Energizing>.NativeClassPtr, 100685375);
			Energizing.NativeMethodInfoPtr_ApplyToEmployee_Protected_Virtual_Void_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Energizing>.NativeClassPtr, 100685376);
			Energizing.NativeMethodInfoPtr_ClearFromEmployee_Protected_Virtual_Void_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Energizing>.NativeClassPtr, 100685377);
			Energizing.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Energizing>.NativeClassPtr, 100685378);
		}

		// Token: 0x0600A651 RID: 42577 RVA: 0x002C1FEC File Offset: 0x002C01EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290169, XrefRangeEnd = 290173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyToNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Energizing.NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A652 RID: 42578 RVA: 0x002C203C File Offset: 0x002C023C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290173, XrefRangeEnd = 290203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyToPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Energizing.NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A653 RID: 42579 RVA: 0x002C208C File Offset: 0x002C028C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearFromNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Energizing.NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A654 RID: 42580 RVA: 0x002C20DC File Offset: 0x002C02DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290203, XrefRangeEnd = 290229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearFromPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Energizing.NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A655 RID: 42581 RVA: 0x002C212C File Offset: 0x002C032C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290229, XrefRangeEnd = 290235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyToEmployee(Employee employee)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(employee);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Energizing.NativeMethodInfoPtr_ApplyToEmployee_Protected_Virtual_Void_Employee_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A656 RID: 42582 RVA: 0x002C217C File Offset: 0x002C037C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearFromEmployee(Employee employee)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(employee);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Energizing.NativeMethodInfoPtr_ClearFromEmployee_Protected_Virtual_Void_Employee_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A657 RID: 42583 RVA: 0x002C21CC File Offset: 0x002C03CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Energizing() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Energizing>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Energizing.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A658 RID: 42584 RVA: 0x0004BD73 File Offset: 0x00049F73
		public Energizing(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170031D7 RID: 12759
		// (get) Token: 0x0600A659 RID: 42585 RVA: 0x002C2208 File Offset: 0x002C0408
		// (set) Token: 0x0600A65A RID: 42586 RVA: 0x0004BD7C File Offset: 0x00049F7C
		public unsafe static float SPEED_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Energizing.NativeFieldInfoPtr_SPEED_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Energizing.NativeFieldInfoPtr_SPEED_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x170031D8 RID: 12760
		// (get) Token: 0x0600A65B RID: 42587 RVA: 0x002C2224 File Offset: 0x002C0424
		// (set) Token: 0x0600A65C RID: 42588 RVA: 0x0004BD8A File Offset: 0x00049F8A
		public unsafe static float WorkSpeedMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Energizing.NativeFieldInfoPtr_WorkSpeedMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Energizing.NativeFieldInfoPtr_WorkSpeedMultiplier, (void*)(&value));
			}
		}

		// Token: 0x04007309 RID: 29449
		private static readonly IntPtr NativeFieldInfoPtr_SPEED_MULTIPLIER;

		// Token: 0x0400730A RID: 29450
		private static readonly IntPtr NativeFieldInfoPtr_WorkSpeedMultiplier;

		// Token: 0x0400730B RID: 29451
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x0400730C RID: 29452
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x0400730D RID: 29453
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x0400730E RID: 29454
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x0400730F RID: 29455
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToEmployee_Protected_Virtual_Void_Employee_0;

		// Token: 0x04007310 RID: 29456
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromEmployee_Protected_Virtual_Void_Employee_0;

		// Token: 0x04007311 RID: 29457
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
