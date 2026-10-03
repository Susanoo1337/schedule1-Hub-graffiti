using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020002C1 RID: 705
	public class NPCPresenceAccessZone : AccessZone
	{
		// Token: 0x0600369B RID: 13979 RVA: 0x00130BEC File Offset: 0x0012EDEC
		// Note: this type is marked as 'beforefieldinit'.
		static NPCPresenceAccessZone()
		{
			Il2CppClassPointerStore<NPCPresenceAccessZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "NPCPresenceAccessZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCPresenceAccessZone>.NativeClassPtr);
			NPCPresenceAccessZone.NativeFieldInfoPtr_CooldownTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCPresenceAccessZone>.NativeClassPtr, "CooldownTime");
			NPCPresenceAccessZone.NativeFieldInfoPtr_DetectionZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCPresenceAccessZone>.NativeClassPtr, "DetectionZone");
			NPCPresenceAccessZone.NativeFieldInfoPtr_TargetNPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCPresenceAccessZone>.NativeClassPtr, "TargetNPC");
			NPCPresenceAccessZone.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPresenceAccessZone>.NativeClassPtr, 100670201);
			NPCPresenceAccessZone.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPresenceAccessZone>.NativeClassPtr, 100670202);
			NPCPresenceAccessZone.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPresenceAccessZone>.NativeClassPtr, 100670203);
			NPCPresenceAccessZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPresenceAccessZone>.NativeClassPtr, 100670204);
		}

		// Token: 0x0600369C RID: 13980 RVA: 0x00130CA8 File Offset: 0x0012EEA8
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCPresenceAccessZone.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600369D RID: 13981 RVA: 0x00130CE4 File Offset: 0x0012EEE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142453, XrefRangeEnd = 142464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCPresenceAccessZone.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600369E RID: 13982 RVA: 0x00130D20 File Offset: 0x0012EF20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142464, XrefRangeEnd = 142471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCPresenceAccessZone.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600369F RID: 13983 RVA: 0x00130D5C File Offset: 0x0012EF5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 141220, RefRangeEnd = 141221, XrefRangeStart = 141220, XrefRangeEnd = 141221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCPresenceAccessZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCPresenceAccessZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCPresenceAccessZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036A0 RID: 13984 RVA: 0x0001BBE4 File Offset: 0x00019DE4
		public NPCPresenceAccessZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001140 RID: 4416
		// (get) Token: 0x060036A1 RID: 13985 RVA: 0x00130D98 File Offset: 0x0012EF98
		// (set) Token: 0x060036A2 RID: 13986 RVA: 0x0001BBED File Offset: 0x00019DED
		public unsafe static float CooldownTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCPresenceAccessZone.NativeFieldInfoPtr_CooldownTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCPresenceAccessZone.NativeFieldInfoPtr_CooldownTime, (void*)(&value));
			}
		}

		// Token: 0x17001141 RID: 4417
		// (get) Token: 0x060036A3 RID: 13987 RVA: 0x00130DB4 File Offset: 0x0012EFB4
		// (set) Token: 0x060036A4 RID: 13988 RVA: 0x0001BBFB File Offset: 0x00019DFB
		public unsafe Collider DetectionZone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPresenceAccessZone.NativeFieldInfoPtr_DetectionZone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPresenceAccessZone.NativeFieldInfoPtr_DetectionZone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001142 RID: 4418
		// (get) Token: 0x060036A5 RID: 13989 RVA: 0x00130DE4 File Offset: 0x0012EFE4
		// (set) Token: 0x060036A6 RID: 13990 RVA: 0x0001BC1A File Offset: 0x00019E1A
		public unsafe NPC TargetNPC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPresenceAccessZone.NativeFieldInfoPtr_TargetNPC);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPresenceAccessZone.NativeFieldInfoPtr_TargetNPC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400248C RID: 9356
		private static readonly IntPtr NativeFieldInfoPtr_CooldownTime;

		// Token: 0x0400248D RID: 9357
		private static readonly IntPtr NativeFieldInfoPtr_DetectionZone;

		// Token: 0x0400248E RID: 9358
		private static readonly IntPtr NativeFieldInfoPtr_TargetNPC;

		// Token: 0x0400248F RID: 9359
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04002490 RID: 9360
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04002491 RID: 9361
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0;

		// Token: 0x04002492 RID: 9362
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
