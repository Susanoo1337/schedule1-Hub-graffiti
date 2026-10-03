using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.PlayerScripts;
using UnityEngine;

namespace Il2CppScheduleOne.Effects
{
	// Token: 0x020006A8 RID: 1704
	public class Athletic : Effect
	{
		// Token: 0x0600A604 RID: 42500 RVA: 0x002C0B78 File Offset: 0x002BED78
		// Note: this type is marked as 'beforefieldinit'.
		static Athletic()
		{
			Il2CppClassPointerStore<Athletic>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Effects", "Athletic");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Athletic>.NativeClassPtr);
			Athletic.NativeFieldInfoPtr_SPEED_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Athletic>.NativeClassPtr, "SPEED_MULTIPLIER");
			Athletic.NativeFieldInfoPtr_NPC_SPEED_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Athletic>.NativeClassPtr, "NPC_SPEED_MULTIPLIER");
			Athletic.NativeFieldInfoPtr_WorkSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Athletic>.NativeClassPtr, "WorkSpeedMultiplier");
			Athletic.NativeFieldInfoPtr_TintColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Athletic>.NativeClassPtr, "TintColor");
			Athletic.NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Athletic>.NativeClassPtr, 100685327);
			Athletic.NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Athletic>.NativeClassPtr, 100685328);
			Athletic.NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Athletic>.NativeClassPtr, 100685329);
			Athletic.NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Athletic>.NativeClassPtr, 100685330);
			Athletic.NativeMethodInfoPtr_ApplyToEmployee_Protected_Virtual_Void_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Athletic>.NativeClassPtr, 100685331);
			Athletic.NativeMethodInfoPtr_ClearFromEmployee_Protected_Virtual_Void_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Athletic>.NativeClassPtr, 100685332);
			Athletic.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Athletic>.NativeClassPtr, 100685333);
		}

		// Token: 0x0600A605 RID: 42501 RVA: 0x002C0C84 File Offset: 0x002BEE84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289937, XrefRangeEnd = 289941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyToNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Athletic.NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A606 RID: 42502 RVA: 0x002C0CD4 File Offset: 0x002BEED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289941, XrefRangeEnd = 289980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyToPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Athletic.NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A607 RID: 42503 RVA: 0x002C0D24 File Offset: 0x002BEF24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289980, XrefRangeEnd = 289984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearFromNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Athletic.NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A608 RID: 42504 RVA: 0x002C0D74 File Offset: 0x002BEF74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289984, XrefRangeEnd = 290019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearFromPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Athletic.NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A609 RID: 42505 RVA: 0x002C0DC4 File Offset: 0x002BEFC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290019, XrefRangeEnd = 290025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyToEmployee(Employee employee)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(employee);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Athletic.NativeMethodInfoPtr_ApplyToEmployee_Protected_Virtual_Void_Employee_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A60A RID: 42506 RVA: 0x002C0E14 File Offset: 0x002BF014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290025, XrefRangeEnd = 290027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearFromEmployee(Employee employee)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(employee);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Athletic.NativeMethodInfoPtr_ClearFromEmployee_Protected_Virtual_Void_Employee_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A60B RID: 42507 RVA: 0x002C0E64 File Offset: 0x002BF064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290027, XrefRangeEnd = 290028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Athletic() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Athletic>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Athletic.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A60C RID: 42508 RVA: 0x0004BC87 File Offset: 0x00049E87
		public Athletic(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170031CF RID: 12751
		// (get) Token: 0x0600A60D RID: 42509 RVA: 0x002C0EA0 File Offset: 0x002BF0A0
		// (set) Token: 0x0600A60E RID: 42510 RVA: 0x0004BC90 File Offset: 0x00049E90
		public unsafe static float SPEED_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Athletic.NativeFieldInfoPtr_SPEED_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Athletic.NativeFieldInfoPtr_SPEED_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x170031D0 RID: 12752
		// (get) Token: 0x0600A60F RID: 42511 RVA: 0x002C0EBC File Offset: 0x002BF0BC
		// (set) Token: 0x0600A610 RID: 42512 RVA: 0x0004BC9E File Offset: 0x00049E9E
		public unsafe static float NPC_SPEED_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Athletic.NativeFieldInfoPtr_NPC_SPEED_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Athletic.NativeFieldInfoPtr_NPC_SPEED_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x170031D1 RID: 12753
		// (get) Token: 0x0600A611 RID: 42513 RVA: 0x002C0ED8 File Offset: 0x002BF0D8
		// (set) Token: 0x0600A612 RID: 42514 RVA: 0x0004BCAC File Offset: 0x00049EAC
		public unsafe static float WorkSpeedMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Athletic.NativeFieldInfoPtr_WorkSpeedMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Athletic.NativeFieldInfoPtr_WorkSpeedMultiplier, (void*)(&value));
			}
		}

		// Token: 0x170031D2 RID: 12754
		// (get) Token: 0x0600A613 RID: 42515 RVA: 0x002C0EF4 File Offset: 0x002BF0F4
		// (set) Token: 0x0600A614 RID: 42516 RVA: 0x0004BCBA File Offset: 0x00049EBA
		public unsafe Color TintColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Athletic.NativeFieldInfoPtr_TintColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Athletic.NativeFieldInfoPtr_TintColor)) = value;
			}
		}

		// Token: 0x040072D5 RID: 29397
		private static readonly IntPtr NativeFieldInfoPtr_SPEED_MULTIPLIER;

		// Token: 0x040072D6 RID: 29398
		private static readonly IntPtr NativeFieldInfoPtr_NPC_SPEED_MULTIPLIER;

		// Token: 0x040072D7 RID: 29399
		private static readonly IntPtr NativeFieldInfoPtr_WorkSpeedMultiplier;

		// Token: 0x040072D8 RID: 29400
		private static readonly IntPtr NativeFieldInfoPtr_TintColor;

		// Token: 0x040072D9 RID: 29401
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x040072DA RID: 29402
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x040072DB RID: 29403
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x040072DC RID: 29404
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x040072DD RID: 29405
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToEmployee_Protected_Virtual_Void_Employee_0;

		// Token: 0x040072DE RID: 29406
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromEmployee_Protected_Virtual_Void_Employee_0;

		// Token: 0x040072DF RID: 29407
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
