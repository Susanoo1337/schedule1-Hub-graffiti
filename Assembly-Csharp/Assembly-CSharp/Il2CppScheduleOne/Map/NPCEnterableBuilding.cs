using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Doors;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020002BF RID: 703
	public class NPCEnterableBuilding : MonoBehaviour
	{
		// Token: 0x06003679 RID: 13945 RVA: 0x0013045C File Offset: 0x0012E65C
		// Note: this type is marked as 'beforefieldinit'.
		static NPCEnterableBuilding()
		{
			Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "NPCEnterableBuilding");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr);
			NPCEnterableBuilding.NativeFieldInfoPtr_DOOR_SOUND_DISTANCE_LIMIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, "DOOR_SOUND_DISTANCE_LIMIT");
			NPCEnterableBuilding.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, "<GUID>k__BackingField");
			NPCEnterableBuilding.NativeFieldInfoPtr_BuildingName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, "BuildingName");
			NPCEnterableBuilding.NativeFieldInfoPtr_BakedGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, "BakedGUID");
			NPCEnterableBuilding.NativeFieldInfoPtr_Doors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, "Doors");
			NPCEnterableBuilding.NativeFieldInfoPtr_Occupants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, "Occupants");
			NPCEnterableBuilding.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, 100670179);
			NPCEnterableBuilding.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, 100670180);
			NPCEnterableBuilding.NativeMethodInfoPtr_get_OccupantCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, 100670181);
			NPCEnterableBuilding.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, 100670182);
			NPCEnterableBuilding.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, 100670183);
			NPCEnterableBuilding.NativeMethodInfoPtr_NPCEnteredBuilding_Public_Virtual_New_Void_NPC_StaticDoor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, 100670184);
			NPCEnterableBuilding.NativeMethodInfoPtr_NPCExitedBuilding_Public_Virtual_New_Void_NPC_StaticDoor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, 100670185);
			NPCEnterableBuilding.NativeMethodInfoPtr_GetDoors_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, 100670186);
			NPCEnterableBuilding.NativeMethodInfoPtr_GetSummonableNPCs_Public_List_1_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, 100670187);
			NPCEnterableBuilding.NativeMethodInfoPtr_GetClosestDoor_Public_StaticDoor_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, 100670188);
			NPCEnterableBuilding.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, 100670189);
		}

		// Token: 0x1700113C RID: 4412
		// (get) Token: 0x0600367A RID: 13946 RVA: 0x001305E0 File Offset: 0x0012E7E0
		// (set) Token: 0x0600367B RID: 13947 RVA: 0x0013061C File Offset: 0x0012E81C
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700113D RID: 4413
		// (get) Token: 0x0600367C RID: 13948 RVA: 0x0013065C File Offset: 0x0012E85C
		public unsafe int OccupantCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 142248, RefRangeEnd = 142249, XrefRangeStart = 142247, XrefRangeEnd = 142248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.NativeMethodInfoPtr_get_OccupantCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600367D RID: 13949 RVA: 0x00130698 File Offset: 0x0012E898
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 142290, RefRangeEnd = 142291, XrefRangeStart = 142249, XrefRangeEnd = 142290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEnterableBuilding.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600367E RID: 13950 RVA: 0x001306D4 File Offset: 0x0012E8D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142291, XrefRangeEnd = 142295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600367F RID: 13951 RVA: 0x00130714 File Offset: 0x0012E914
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 142322, RefRangeEnd = 142323, XrefRangeStart = 142295, XrefRangeEnd = 142322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NPCEnteredBuilding(NPC npc, StaticDoor door)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(door);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEnterableBuilding.NativeMethodInfoPtr_NPCEnteredBuilding_Public_Virtual_New_Void_NPC_StaticDoor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003680 RID: 13952 RVA: 0x00130774 File Offset: 0x0012E974
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 142352, RefRangeEnd = 142353, XrefRangeStart = 142323, XrefRangeEnd = 142352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NPCExitedBuilding(NPC npc, StaticDoor door)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(door);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEnterableBuilding.NativeMethodInfoPtr_NPCExitedBuilding_Public_Virtual_New_Void_NPC_StaticDoor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003681 RID: 13953 RVA: 0x001307D4 File Offset: 0x0012E9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142353, XrefRangeEnd = 142357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetDoors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.NativeMethodInfoPtr_GetDoors_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003682 RID: 13954 RVA: 0x00130808 File Offset: 0x0012EA08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142357, XrefRangeEnd = 142378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<NPC> GetSummonableNPCs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.NativeMethodInfoPtr_GetSummonableNPCs_Public_List_1_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr3) : null;
		}

		// Token: 0x06003683 RID: 13955 RVA: 0x00130848 File Offset: 0x0012EA48
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 142404, RefRangeEnd = 142408, XrefRangeStart = 142378, XrefRangeEnd = 142404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StaticDoor GetClosestDoor(Vector3 pos, bool useableOnly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useableOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.NativeMethodInfoPtr_GetClosestDoor_Public_StaticDoor_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StaticDoor>(intPtr3) : null;
		}

		// Token: 0x06003684 RID: 13956 RVA: 0x001308A4 File Offset: 0x0012EAA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 142240, RefRangeEnd = 142241, XrefRangeStart = 142240, XrefRangeEnd = 142241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCEnterableBuilding() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003685 RID: 13957 RVA: 0x0001BB0E File Offset: 0x00019D0E
		public NPCEnterableBuilding(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001136 RID: 4406
		// (get) Token: 0x06003686 RID: 13958 RVA: 0x001308E0 File Offset: 0x0012EAE0
		// (set) Token: 0x06003687 RID: 13959 RVA: 0x0001BB17 File Offset: 0x00019D17
		public unsafe static float DOOR_SOUND_DISTANCE_LIMIT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCEnterableBuilding.NativeFieldInfoPtr_DOOR_SOUND_DISTANCE_LIMIT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCEnterableBuilding.NativeFieldInfoPtr_DOOR_SOUND_DISTANCE_LIMIT, (void*)(&value));
			}
		}

		// Token: 0x17001137 RID: 4407
		// (get) Token: 0x06003688 RID: 13960 RVA: 0x001308FC File Offset: 0x0012EAFC
		// (set) Token: 0x06003689 RID: 13961 RVA: 0x0001BB25 File Offset: 0x00019D25
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x17001138 RID: 4408
		// (get) Token: 0x0600368A RID: 13962 RVA: 0x00130924 File Offset: 0x0012EB24
		// (set) Token: 0x0600368B RID: 13963 RVA: 0x0001BB40 File Offset: 0x00019D40
		public unsafe string BuildingName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.NativeFieldInfoPtr_BuildingName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.NativeFieldInfoPtr_BuildingName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001139 RID: 4409
		// (get) Token: 0x0600368C RID: 13964 RVA: 0x0013094C File Offset: 0x0012EB4C
		// (set) Token: 0x0600368D RID: 13965 RVA: 0x0001BB5F File Offset: 0x00019D5F
		public unsafe string BakedGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.NativeFieldInfoPtr_BakedGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.NativeFieldInfoPtr_BakedGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700113A RID: 4410
		// (get) Token: 0x0600368E RID: 13966 RVA: 0x00130974 File Offset: 0x0012EB74
		// (set) Token: 0x0600368F RID: 13967 RVA: 0x0001BB7E File Offset: 0x00019D7E
		public unsafe Il2CppReferenceArray<StaticDoor> Doors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.NativeFieldInfoPtr_Doors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StaticDoor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.NativeFieldInfoPtr_Doors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700113B RID: 4411
		// (get) Token: 0x06003690 RID: 13968 RVA: 0x001309A4 File Offset: 0x0012EBA4
		// (set) Token: 0x06003691 RID: 13969 RVA: 0x0001BB9D File Offset: 0x00019D9D
		public unsafe List<NPC> Occupants
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.NativeFieldInfoPtr_Occupants);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.NativeFieldInfoPtr_Occupants), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002475 RID: 9333
		private static readonly IntPtr NativeFieldInfoPtr_DOOR_SOUND_DISTANCE_LIMIT;

		// Token: 0x04002476 RID: 9334
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04002477 RID: 9335
		private static readonly IntPtr NativeFieldInfoPtr_BuildingName;

		// Token: 0x04002478 RID: 9336
		private static readonly IntPtr NativeFieldInfoPtr_BakedGUID;

		// Token: 0x04002479 RID: 9337
		private static readonly IntPtr NativeFieldInfoPtr_Doors;

		// Token: 0x0400247A RID: 9338
		private static readonly IntPtr NativeFieldInfoPtr_Occupants;

		// Token: 0x0400247B RID: 9339
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x0400247C RID: 9340
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x0400247D RID: 9341
		private static readonly IntPtr NativeMethodInfoPtr_get_OccupantCount_Public_get_Int32_0;

		// Token: 0x0400247E RID: 9342
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x0400247F RID: 9343
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04002480 RID: 9344
		private static readonly IntPtr NativeMethodInfoPtr_NPCEnteredBuilding_Public_Virtual_New_Void_NPC_StaticDoor_0;

		// Token: 0x04002481 RID: 9345
		private static readonly IntPtr NativeMethodInfoPtr_NPCExitedBuilding_Public_Virtual_New_Void_NPC_StaticDoor_0;

		// Token: 0x04002482 RID: 9346
		private static readonly IntPtr NativeMethodInfoPtr_GetDoors_Public_Void_0;

		// Token: 0x04002483 RID: 9347
		private static readonly IntPtr NativeMethodInfoPtr_GetSummonableNPCs_Public_List_1_NPC_0;

		// Token: 0x04002484 RID: 9348
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestDoor_Public_StaticDoor_Vector3_Boolean_0;

		// Token: 0x04002485 RID: 9349
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A15 RID: 2581
		[ObfuscatedName("ScheduleOne.Map.NPCEnterableBuilding+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DE37 RID: 56887 RVA: 0x0036CE74 File Offset: 0x0036B074
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NPCEnterableBuilding.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCEnterableBuilding.__c>.NativeClassPtr);
				NPCEnterableBuilding.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEnterableBuilding.__c>.NativeClassPtr, "<>9");
				NPCEnterableBuilding.__c.NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEnterableBuilding.__c>.NativeClassPtr, "<>9__16_0");
				NPCEnterableBuilding.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding.__c>.NativeClassPtr, 100670191);
				NPCEnterableBuilding.__c.NativeMethodInfoPtr__GetSummonableNPCs_b__16_0_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding.__c>.NativeClassPtr, 100670192);
			}

			// Token: 0x0600DE38 RID: 56888 RVA: 0x0036CEF0 File Offset: 0x0036B0F0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCEnterableBuilding.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE39 RID: 56889 RVA: 0x0036CF2C File Offset: 0x0036B12C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142241, XrefRangeEnd = 142242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetSummonableNPCs_b__16_0(NPC npc)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.__c.NativeMethodInfoPtr__GetSummonableNPCs_b__16_0_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DE3A RID: 56890 RVA: 0x000689EE File Offset: 0x00066BEE
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043A9 RID: 17321
			// (get) Token: 0x0600DE3B RID: 56891 RVA: 0x0036CF7C File Offset: 0x0036B17C
			// (set) Token: 0x0600DE3C RID: 56892 RVA: 0x000689F7 File Offset: 0x00066BF7
			public unsafe static NPCEnterableBuilding.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCEnterableBuilding.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCEnterableBuilding.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCEnterableBuilding.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043AA RID: 17322
			// (get) Token: 0x0600DE3D RID: 56893 RVA: 0x0036CFA4 File Offset: 0x0036B1A4
			// (set) Token: 0x0600DE3E RID: 56894 RVA: 0x00068A09 File Offset: 0x00066C09
			public unsafe static Func<NPC, bool> __9__16_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCEnterableBuilding.__c.NativeFieldInfoPtr___9__16_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NPC, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCEnterableBuilding.__c.NativeFieldInfoPtr___9__16_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009763 RID: 38755
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009764 RID: 38756
			private static readonly IntPtr NativeFieldInfoPtr___9__16_0;

			// Token: 0x04009765 RID: 38757
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009766 RID: 38758
			private static readonly IntPtr NativeMethodInfoPtr__GetSummonableNPCs_b__16_0_Internal_Boolean_NPC_0;
		}

		// Token: 0x02000A16 RID: 2582
		[ObfuscatedName("ScheduleOne.Map.NPCEnterableBuilding+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DE3F RID: 56895 RVA: 0x0036CFCC File Offset: 0x0036B1CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<NPCEnterableBuilding.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCEnterableBuilding.__c__DisplayClass17_0>.NativeClassPtr);
				NPCEnterableBuilding.__c__DisplayClass17_0.NativeFieldInfoPtr_useableOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEnterableBuilding.__c__DisplayClass17_0>.NativeClassPtr, "useableOnly");
				NPCEnterableBuilding.__c__DisplayClass17_0.NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEnterableBuilding.__c__DisplayClass17_0>.NativeClassPtr, "pos");
				NPCEnterableBuilding.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding.__c__DisplayClass17_0>.NativeClassPtr, 100670193);
				NPCEnterableBuilding.__c__DisplayClass17_0.NativeMethodInfoPtr__GetClosestDoor_b__0_Internal_Boolean_StaticDoor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding.__c__DisplayClass17_0>.NativeClassPtr, 100670194);
				NPCEnterableBuilding.__c__DisplayClass17_0.NativeMethodInfoPtr__GetClosestDoor_b__1_Internal_Single_StaticDoor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding.__c__DisplayClass17_0>.NativeClassPtr, 100670195);
			}

			// Token: 0x0600DE40 RID: 56896 RVA: 0x0036D05C File Offset: 0x0036B25C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCEnterableBuilding.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE41 RID: 56897 RVA: 0x0036D098 File Offset: 0x0036B298
			[CallerCount(0)]
			public unsafe bool _GetClosestDoor_b__0(StaticDoor door)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(door);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.__c__DisplayClass17_0.NativeMethodInfoPtr__GetClosestDoor_b__0_Internal_Boolean_StaticDoor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DE42 RID: 56898 RVA: 0x0036D0E8 File Offset: 0x0036B2E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142242, XrefRangeEnd = 142247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _GetClosestDoor_b__1(StaticDoor door)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(door);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.__c__DisplayClass17_0.NativeMethodInfoPtr__GetClosestDoor_b__1_Internal_Single_StaticDoor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DE43 RID: 56899 RVA: 0x00068A1B File Offset: 0x00066C1B
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043AB RID: 17323
			// (get) Token: 0x0600DE44 RID: 56900 RVA: 0x0036D138 File Offset: 0x0036B338
			// (set) Token: 0x0600DE45 RID: 56901 RVA: 0x00068A24 File Offset: 0x00066C24
			public unsafe bool useableOnly
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.__c__DisplayClass17_0.NativeFieldInfoPtr_useableOnly);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.__c__DisplayClass17_0.NativeFieldInfoPtr_useableOnly)) = value;
				}
			}

			// Token: 0x170043AC RID: 17324
			// (get) Token: 0x0600DE46 RID: 56902 RVA: 0x0036D160 File Offset: 0x0036B360
			// (set) Token: 0x0600DE47 RID: 56903 RVA: 0x00068A3F File Offset: 0x00066C3F
			public unsafe Vector3 pos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.__c__DisplayClass17_0.NativeFieldInfoPtr_pos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.__c__DisplayClass17_0.NativeFieldInfoPtr_pos)) = value;
				}
			}

			// Token: 0x04009767 RID: 38759
			private static readonly IntPtr NativeFieldInfoPtr_useableOnly;

			// Token: 0x04009768 RID: 38760
			private static readonly IntPtr NativeFieldInfoPtr_pos;

			// Token: 0x04009769 RID: 38761
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400976A RID: 38762
			private static readonly IntPtr NativeMethodInfoPtr__GetClosestDoor_b__0_Internal_Boolean_StaticDoor_0;

			// Token: 0x0400976B RID: 38763
			private static readonly IntPtr NativeMethodInfoPtr__GetClosestDoor_b__1_Internal_Single_StaticDoor_0;
		}
	}
}
