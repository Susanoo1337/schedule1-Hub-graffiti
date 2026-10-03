using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Doors
{
	// Token: 0x020003B1 RID: 945
	public class StaticDoor : MonoBehaviour
	{
		// Token: 0x060055DD RID: 21981 RVA: 0x001A4644 File Offset: 0x001A2844
		// Note: this type is marked as 'beforefieldinit'.
		static StaticDoor()
		{
			Il2CppClassPointerStore<StaticDoor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Doors", "StaticDoor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr);
			StaticDoor.NativeFieldInfoPtr_KNOCK_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr, "KNOCK_COOLDOWN");
			StaticDoor.NativeFieldInfoPtr_SUMMON_DURATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr, "SUMMON_DURATION");
			StaticDoor.NativeFieldInfoPtr_AccessPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr, "AccessPoint");
			StaticDoor.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr, "IntObj");
			StaticDoor.NativeFieldInfoPtr_KnockSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr, "KnockSound");
			StaticDoor.NativeFieldInfoPtr_EnterSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr, "EnterSound");
			StaticDoor.NativeFieldInfoPtr_ExitSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr, "ExitSound");
			StaticDoor.NativeFieldInfoPtr_Building = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr, "Building");
			StaticDoor.NativeFieldInfoPtr_Usable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr, "Usable");
			StaticDoor.NativeFieldInfoPtr_CanKnock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr, "CanKnock");
			StaticDoor.NativeFieldInfoPtr_timeSinceLastKnock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr, "timeSinceLastKnock");
			StaticDoor.NativeFieldInfoPtr_doorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr, "doorIndex");
			StaticDoor.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr, 100674548);
			StaticDoor.NativeMethodInfoPtr_OnValidate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr, 100674549);
			StaticDoor.NativeMethodInfoPtr_Hovered_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr, 100674550);
			StaticDoor.NativeMethodInfoPtr_CanKnockNow_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr, 100674551);
			StaticDoor.NativeMethodInfoPtr_IsKnockValid_Protected_Virtual_New_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr, 100674552);
			StaticDoor.NativeMethodInfoPtr_Interacted_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr, 100674553);
			StaticDoor.NativeMethodInfoPtr_Knock_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr, 100674554);
			StaticDoor.NativeMethodInfoPtr_NPCSelected_Protected_Virtual_New_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr, 100674555);
			StaticDoor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr, 100674556);
			StaticDoor.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr, 100674557);
		}

		// Token: 0x060055DE RID: 21982 RVA: 0x001A482C File Offset: 0x001A2A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189630, XrefRangeEnd = 189675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StaticDoor.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055DF RID: 21983 RVA: 0x001A4868 File Offset: 0x001A2A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189675, XrefRangeEnd = 189699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StaticDoor.NativeMethodInfoPtr_OnValidate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055E0 RID: 21984 RVA: 0x001A48A4 File Offset: 0x001A2AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189699, XrefRangeEnd = 189700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StaticDoor.NativeMethodInfoPtr_Hovered_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055E1 RID: 21985 RVA: 0x001A48E0 File Offset: 0x001A2AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189700, XrefRangeEnd = 189705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanKnockNow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StaticDoor.NativeMethodInfoPtr_CanKnockNow_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060055E2 RID: 21986 RVA: 0x001A4928 File Offset: 0x001A2B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189705, XrefRangeEnd = 189708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsKnockValid(out string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StaticDoor.NativeMethodInfoPtr_IsKnockValid_Protected_Virtual_New_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			message = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060055E3 RID: 21987 RVA: 0x001A498C File Offset: 0x001A2B8C
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 189708, RefRangeEnd = 189733, XrefRangeStart = 189708, XrefRangeEnd = 189708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StaticDoor.NativeMethodInfoPtr_Interacted_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055E4 RID: 21988 RVA: 0x001A49C8 File Offset: 0x001A2BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189733, XrefRangeEnd = 189745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Knock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StaticDoor.NativeMethodInfoPtr_Knock_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055E5 RID: 21989 RVA: 0x001A4A04 File Offset: 0x001A2C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189745, XrefRangeEnd = 189750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NPCSelected(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StaticDoor.NativeMethodInfoPtr_NPCSelected_Protected_Virtual_New_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055E6 RID: 21990 RVA: 0x001A4A54 File Offset: 0x001A2C54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StaticDoor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaticDoor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055E7 RID: 21991 RVA: 0x001A4A90 File Offset: 0x001A2C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189750, XrefRangeEnd = 189755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaticDoor.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060055E8 RID: 21992 RVA: 0x0002895E File Offset: 0x00026B5E
		public StaticDoor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001A98 RID: 6808
		// (get) Token: 0x060055E9 RID: 21993 RVA: 0x001A4AD0 File Offset: 0x001A2CD0
		// (set) Token: 0x060055EA RID: 21994 RVA: 0x00028967 File Offset: 0x00026B67
		public unsafe static float KNOCK_COOLDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(StaticDoor.NativeFieldInfoPtr_KNOCK_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StaticDoor.NativeFieldInfoPtr_KNOCK_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x17001A99 RID: 6809
		// (get) Token: 0x060055EB RID: 21995 RVA: 0x001A4AEC File Offset: 0x001A2CEC
		// (set) Token: 0x060055EC RID: 21996 RVA: 0x00028975 File Offset: 0x00026B75
		public unsafe static float SUMMON_DURATION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(StaticDoor.NativeFieldInfoPtr_SUMMON_DURATION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StaticDoor.NativeFieldInfoPtr_SUMMON_DURATION, (void*)(&value));
			}
		}

		// Token: 0x17001A9A RID: 6810
		// (get) Token: 0x060055ED RID: 21997 RVA: 0x001A4B08 File Offset: 0x001A2D08
		// (set) Token: 0x060055EE RID: 21998 RVA: 0x00028983 File Offset: 0x00026B83
		public unsafe Transform AccessPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.NativeFieldInfoPtr_AccessPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.NativeFieldInfoPtr_AccessPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A9B RID: 6811
		// (get) Token: 0x060055EF RID: 21999 RVA: 0x001A4B38 File Offset: 0x001A2D38
		// (set) Token: 0x060055F0 RID: 22000 RVA: 0x000289A2 File Offset: 0x00026BA2
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A9C RID: 6812
		// (get) Token: 0x060055F1 RID: 22001 RVA: 0x001A4B68 File Offset: 0x001A2D68
		// (set) Token: 0x060055F2 RID: 22002 RVA: 0x000289C1 File Offset: 0x00026BC1
		public unsafe AudioSourceController KnockSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.NativeFieldInfoPtr_KnockSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.NativeFieldInfoPtr_KnockSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A9D RID: 6813
		// (get) Token: 0x060055F3 RID: 22003 RVA: 0x001A4B98 File Offset: 0x001A2D98
		// (set) Token: 0x060055F4 RID: 22004 RVA: 0x000289E0 File Offset: 0x00026BE0
		public unsafe AudioSourceController EnterSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.NativeFieldInfoPtr_EnterSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.NativeFieldInfoPtr_EnterSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A9E RID: 6814
		// (get) Token: 0x060055F5 RID: 22005 RVA: 0x001A4BC8 File Offset: 0x001A2DC8
		// (set) Token: 0x060055F6 RID: 22006 RVA: 0x000289FF File Offset: 0x00026BFF
		public unsafe AudioSourceController ExitSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.NativeFieldInfoPtr_ExitSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.NativeFieldInfoPtr_ExitSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A9F RID: 6815
		// (get) Token: 0x060055F7 RID: 22007 RVA: 0x001A4BF8 File Offset: 0x001A2DF8
		// (set) Token: 0x060055F8 RID: 22008 RVA: 0x00028A1E File Offset: 0x00026C1E
		public unsafe NPCEnterableBuilding Building
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.NativeFieldInfoPtr_Building);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCEnterableBuilding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.NativeFieldInfoPtr_Building), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AA0 RID: 6816
		// (get) Token: 0x060055F9 RID: 22009 RVA: 0x001A4C28 File Offset: 0x001A2E28
		// (set) Token: 0x060055FA RID: 22010 RVA: 0x00028A3D File Offset: 0x00026C3D
		public unsafe bool Usable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.NativeFieldInfoPtr_Usable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.NativeFieldInfoPtr_Usable)) = value;
			}
		}

		// Token: 0x17001AA1 RID: 6817
		// (get) Token: 0x060055FB RID: 22011 RVA: 0x001A4C50 File Offset: 0x001A2E50
		// (set) Token: 0x060055FC RID: 22012 RVA: 0x00028A58 File Offset: 0x00026C58
		public unsafe bool CanKnock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.NativeFieldInfoPtr_CanKnock);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.NativeFieldInfoPtr_CanKnock)) = value;
			}
		}

		// Token: 0x17001AA2 RID: 6818
		// (get) Token: 0x060055FD RID: 22013 RVA: 0x001A4C78 File Offset: 0x001A2E78
		// (set) Token: 0x060055FE RID: 22014 RVA: 0x00028A73 File Offset: 0x00026C73
		public unsafe float timeSinceLastKnock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.NativeFieldInfoPtr_timeSinceLastKnock);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.NativeFieldInfoPtr_timeSinceLastKnock)) = value;
			}
		}

		// Token: 0x17001AA3 RID: 6819
		// (get) Token: 0x060055FF RID: 22015 RVA: 0x001A4CA0 File Offset: 0x001A2EA0
		// (set) Token: 0x06005600 RID: 22016 RVA: 0x00028A8E File Offset: 0x00026C8E
		public unsafe int doorIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.NativeFieldInfoPtr_doorIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.NativeFieldInfoPtr_doorIndex)) = value;
			}
		}

		// Token: 0x04003B2B RID: 15147
		private static readonly IntPtr NativeFieldInfoPtr_KNOCK_COOLDOWN;

		// Token: 0x04003B2C RID: 15148
		private static readonly IntPtr NativeFieldInfoPtr_SUMMON_DURATION;

		// Token: 0x04003B2D RID: 15149
		private static readonly IntPtr NativeFieldInfoPtr_AccessPoint;

		// Token: 0x04003B2E RID: 15150
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x04003B2F RID: 15151
		private static readonly IntPtr NativeFieldInfoPtr_KnockSound;

		// Token: 0x04003B30 RID: 15152
		private static readonly IntPtr NativeFieldInfoPtr_EnterSound;

		// Token: 0x04003B31 RID: 15153
		private static readonly IntPtr NativeFieldInfoPtr_ExitSound;

		// Token: 0x04003B32 RID: 15154
		private static readonly IntPtr NativeFieldInfoPtr_Building;

		// Token: 0x04003B33 RID: 15155
		private static readonly IntPtr NativeFieldInfoPtr_Usable;

		// Token: 0x04003B34 RID: 15156
		private static readonly IntPtr NativeFieldInfoPtr_CanKnock;

		// Token: 0x04003B35 RID: 15157
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastKnock;

		// Token: 0x04003B36 RID: 15158
		private static readonly IntPtr NativeFieldInfoPtr_doorIndex;

		// Token: 0x04003B37 RID: 15159
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04003B38 RID: 15160
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Protected_Virtual_New_Void_0;

		// Token: 0x04003B39 RID: 15161
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Protected_Virtual_New_Void_0;

		// Token: 0x04003B3A RID: 15162
		private static readonly IntPtr NativeMethodInfoPtr_CanKnockNow_Protected_Virtual_New_Boolean_0;

		// Token: 0x04003B3B RID: 15163
		private static readonly IntPtr NativeMethodInfoPtr_IsKnockValid_Protected_Virtual_New_Boolean_byref_String_0;

		// Token: 0x04003B3C RID: 15164
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Protected_Virtual_New_Void_0;

		// Token: 0x04003B3D RID: 15165
		private static readonly IntPtr NativeMethodInfoPtr_Knock_Protected_Virtual_New_Void_0;

		// Token: 0x04003B3E RID: 15166
		private static readonly IntPtr NativeMethodInfoPtr_NPCSelected_Protected_Virtual_New_Void_NPC_0;

		// Token: 0x04003B3F RID: 15167
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003B40 RID: 15168
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000AB8 RID: 2744
		[ObfuscatedName("ScheduleOne.Doors.StaticDoor+<<Knock>g__knockRoutine|18_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600E376 RID: 58230 RVA: 0x0037B658 File Offset: 0x00379858
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique()
			{
				Il2CppClassPointerStore<StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StaticDoor>.NativeClassPtr, "<<Knock>g__knockRoutine|18_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique>.NativeClassPtr);
				StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique>.NativeClassPtr, "<>1__state");
				StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique>.NativeClassPtr, "<>2__current");
				StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique>.NativeClassPtr, "<>4__this");
				StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique>.NativeClassPtr, 100674558);
				StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique>.NativeClassPtr, 100674559);
				StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique>.NativeClassPtr, 100674560);
				StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique>.NativeClassPtr, 100674561);
				StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique>.NativeClassPtr, 100674562);
				StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique>.NativeClassPtr, 100674563);
			}

			// Token: 0x0600E377 RID: 58231 RVA: 0x0037B738 File Offset: 0x00379938
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E378 RID: 58232 RVA: 0x0037B780 File Offset: 0x00379980
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E379 RID: 58233 RVA: 0x0037B7B4 File Offset: 0x003799B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189614, XrefRangeEnd = 189625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004535 RID: 17717
			// (get) Token: 0x0600E37A RID: 58234 RVA: 0x0037B7F0 File Offset: 0x003799F0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E37B RID: 58235 RVA: 0x0037B830 File Offset: 0x00379A30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189625, XrefRangeEnd = 189630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004536 RID: 17718
			// (get) Token: 0x0600E37C RID: 58236 RVA: 0x0037B864 File Offset: 0x00379A64
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E37D RID: 58237 RVA: 0x0006B3E4 File Offset: 0x000695E4
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004532 RID: 17714
			// (get) Token: 0x0600E37E RID: 58238 RVA: 0x0037B8A4 File Offset: 0x00379AA4
			// (set) Token: 0x0600E37F RID: 58239 RVA: 0x0006B3ED File Offset: 0x000695ED
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004533 RID: 17715
			// (get) Token: 0x0600E380 RID: 58240 RVA: 0x0037B8CC File Offset: 0x00379ACC
			// (set) Token: 0x0600E381 RID: 58241 RVA: 0x0006B408 File Offset: 0x00069608
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004534 RID: 17716
			// (get) Token: 0x0600E382 RID: 58242 RVA: 0x0037B8FC File Offset: 0x00379AFC
			// (set) Token: 0x0600E383 RID: 58243 RVA: 0x0006B427 File Offset: 0x00069627
			public unsafe StaticDoor __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticDoor>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009AA1 RID: 39585
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009AA2 RID: 39586
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009AA3 RID: 39587
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009AA4 RID: 39588
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009AA5 RID: 39589
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009AA6 RID: 39590
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009AA7 RID: 39591
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009AA8 RID: 39592
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009AA9 RID: 39593
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
