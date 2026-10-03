using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Combat;
using Il2CppScheduleOne.Dragging;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.Property;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Trash
{
	// Token: 0x0200048F RID: 1167
	public class TrashItem : MonoBehaviour
	{
		// Token: 0x0600692D RID: 26925 RVA: 0x001E6F28 File Offset: 0x001E5128
		// Note: this type is marked as 'beforefieldinit'.
		static TrashItem()
		{
			Il2CppClassPointerStore<TrashItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Trash", "TrashItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashItem>.NativeClassPtr);
			TrashItem.NativeFieldInfoPtr_ColliderRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "ColliderRange");
			TrashItem.NativeFieldInfoPtr_ColliderRangeSqr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "ColliderRangeSqr");
			TrashItem.NativeFieldInfoPtr_POSITION_CHANGE_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "POSITION_CHANGE_THRESHOLD");
			TrashItem.NativeFieldInfoPtr_LINEAR_DRAG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "LINEAR_DRAG");
			TrashItem.NativeFieldInfoPtr_ANGULAR_DRAG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "ANGULAR_DRAG");
			TrashItem.NativeFieldInfoPtr_MIN_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "MIN_Y");
			TrashItem.NativeFieldInfoPtr_INTERACTION_PRIORITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "INTERACTION_PRIORITY");
			TrashItem.NativeFieldInfoPtr_Rigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "Rigidbody");
			TrashItem.NativeFieldInfoPtr_Draggable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "Draggable");
			TrashItem.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "ID");
			TrashItem.NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "Size");
			TrashItem.NativeFieldInfoPtr_SellValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "SellValue");
			TrashItem.NativeFieldInfoPtr_CanGoInContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "CanGoInContainer");
			TrashItem.NativeFieldInfoPtr_colliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "colliders");
			TrashItem.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "<GUID>k__BackingField");
			TrashItem.NativeFieldInfoPtr__CurrentProperty_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "<CurrentProperty>k__BackingField");
			TrashItem.NativeFieldInfoPtr_lastPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "lastPosition");
			TrashItem.NativeFieldInfoPtr_onDestroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "onDestroyed");
			TrashItem.NativeFieldInfoPtr_collidersEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "collidersEnabled");
			TrashItem.NativeFieldInfoPtr_timeOnPhysicsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "timeOnPhysicsEnabled");
			TrashItem.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			TrashItem.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			TrashItem.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "<HasChanged>k__BackingField");
			TrashItem.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100677071);
			TrashItem.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100677072);
			TrashItem.NativeMethodInfoPtr_get_CurrentProperty_Public_get_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100677073);
			TrashItem.NativeMethodInfoPtr_set_CurrentProperty_Protected_set_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100677074);
			TrashItem.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100677075);
			TrashItem.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100677076);
			TrashItem.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100677077);
			TrashItem.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100677078);
			TrashItem.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100677079);
			TrashItem.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100677080);
			TrashItem.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100677081);
			TrashItem.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100677082);
			TrashItem.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100677083);
			TrashItem.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100677084);
			TrashItem.NativeMethodInfoPtr_Awake_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100677085);
			TrashItem.NativeMethodInfoPtr_Start_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100677086);
			TrashItem.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100677087);
			TrashItem.NativeMethodInfoPtr_OnValidate_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100677088);
			TrashItem.NativeMethodInfoPtr_OnTick_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100677089);
			TrashItem.NativeMethodInfoPtr_Hovered_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100677090);
			TrashItem.NativeMethodInfoPtr_Interacted_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100677091);
			TrashItem.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100677092);
			TrashItem.NativeMethodInfoPtr_SetVelocity_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100677093);
			TrashItem.NativeMethodInfoPtr_DestroyTrash_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100677094);
			TrashItem.NativeMethodInfoPtr_Deinitialize_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100677095);
			TrashItem.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100677096);
			TrashItem.NativeMethodInfoPtr_RecheckPosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100677097);
			TrashItem.NativeMethodInfoPtr_GetData_Public_Virtual_New_TrashItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100677098);
			TrashItem.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100677099);
			TrashItem.NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100677100);
			TrashItem.NativeMethodInfoPtr_RecheckProperty_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100677101);
			TrashItem.NativeMethodInfoPtr_SetContinuousCollisionDetection_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100677102);
			TrashItem.NativeMethodInfoPtr_SetDiscreteCollisionDetection_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100677103);
			TrashItem.NativeMethodInfoPtr_SetPhysicsActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100677104);
			TrashItem.NativeMethodInfoPtr_SetCollidersEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100677105);
			TrashItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100677106);
			TrashItem.NativeMethodInfoPtr__Awake_b__46_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100677107);
			TrashItem.NativeMethodInfoPtr__Awake_b__46_1_Private_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100677108);
		}

		// Token: 0x1700203C RID: 8252
		// (get) Token: 0x0600692E RID: 26926 RVA: 0x001E741C File Offset: 0x001E561C
		// (set) Token: 0x0600692F RID: 26927 RVA: 0x001E7458 File Offset: 0x001E5658
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700203D RID: 8253
		// (get) Token: 0x06006930 RID: 26928 RVA: 0x001E7498 File Offset: 0x001E5698
		// (set) Token: 0x06006931 RID: 26929 RVA: 0x001E74D8 File Offset: 0x001E56D8
		public unsafe Property CurrentProperty
		{
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 43093, RefRangeEnd = 43137, XrefRangeStart = 43093, XrefRangeEnd = 43137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_get_CurrentProperty_Public_get_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Property>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_set_CurrentProperty_Protected_set_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700203E RID: 8254
		// (get) Token: 0x06006932 RID: 26930 RVA: 0x001E751C File Offset: 0x001E571C
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217334, XrefRangeEnd = 217339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700203F RID: 8255
		// (get) Token: 0x06006933 RID: 26931 RVA: 0x001E7554 File Offset: 0x001E5754
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217339, XrefRangeEnd = 217344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17002040 RID: 8256
		// (get) Token: 0x06006934 RID: 26932 RVA: 0x001E758C File Offset: 0x001E578C
		public unsafe virtual Loader Loader
		{
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 31078, RefRangeEnd = 31151, XrefRangeStart = 31078, XrefRangeEnd = 31151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x17002041 RID: 8257
		// (get) Token: 0x06006935 RID: 26933 RVA: 0x001E75CC File Offset: 0x001E57CC
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(170)]
			[CachedScanResults(RefRangeStart = 31151, RefRangeEnd = 31321, XrefRangeStart = 31151, XrefRangeEnd = 31321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002042 RID: 8258
		// (get) Token: 0x06006936 RID: 26934 RVA: 0x001E7608 File Offset: 0x001E5808
		// (set) Token: 0x06006937 RID: 26935 RVA: 0x001E7648 File Offset: 0x001E5848
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 41637, RefRangeEnd = 41647, XrefRangeStart = 41637, XrefRangeEnd = 41647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 142409, RefRangeEnd = 142410, XrefRangeStart = 142409, XrefRangeEnd = 142410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002043 RID: 8259
		// (get) Token: 0x06006938 RID: 26936 RVA: 0x001E768C File Offset: 0x001E588C
		// (set) Token: 0x06006939 RID: 26937 RVA: 0x001E76CC File Offset: 0x001E58CC
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 70274, RefRangeEnd = 70285, XrefRangeStart = 70274, XrefRangeEnd = 70285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002044 RID: 8260
		// (get) Token: 0x0600693A RID: 26938 RVA: 0x001E7710 File Offset: 0x001E5910
		// (set) Token: 0x0600693B RID: 26939 RVA: 0x001E774C File Offset: 0x001E594C
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600693C RID: 26940 RVA: 0x001E778C File Offset: 0x001E598C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217344, XrefRangeEnd = 217408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_Awake_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600693D RID: 26941 RVA: 0x001E77C0 File Offset: 0x001E59C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217408, XrefRangeEnd = 217434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_Start_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600693E RID: 26942 RVA: 0x001E77F4 File Offset: 0x001E59F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217434, XrefRangeEnd = 217440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashItem.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600693F RID: 26943 RVA: 0x001E7830 File Offset: 0x001E5A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217440, XrefRangeEnd = 217469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_OnValidate_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006940 RID: 26944 RVA: 0x001E7864 File Offset: 0x001E5A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217469, XrefRangeEnd = 217493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_OnTick_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006941 RID: 26945 RVA: 0x001E7898 File Offset: 0x001E5A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217493, XrefRangeEnd = 217514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_Hovered_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006942 RID: 26946 RVA: 0x001E78CC File Offset: 0x001E5ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217514, XrefRangeEnd = 217521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_Interacted_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006943 RID: 26947 RVA: 0x001E7900 File Offset: 0x001E5B00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 217537, RefRangeEnd = 217539, XrefRangeStart = 217521, XrefRangeEnd = 217537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006944 RID: 26948 RVA: 0x001E7940 File Offset: 0x001E5B40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 217540, RefRangeEnd = 217542, XrefRangeStart = 217539, XrefRangeEnd = 217540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVelocity(Vector3 velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref velocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_SetVelocity_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006945 RID: 26949 RVA: 0x001E7980 File Offset: 0x001E5B80
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 217548, RefRangeEnd = 217559, XrefRangeStart = 217542, XrefRangeEnd = 217548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyTrash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_DestroyTrash_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006946 RID: 26950 RVA: 0x001E79B4 File Offset: 0x001E5BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217559, XrefRangeEnd = 217572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Deinitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashItem.NativeMethodInfoPtr_Deinitialize_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006947 RID: 26951 RVA: 0x001E79F0 File Offset: 0x001E5BF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217572, XrefRangeEnd = 217587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006948 RID: 26952 RVA: 0x001E7A24 File Offset: 0x001E5C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217587, XrefRangeEnd = 217597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecheckPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_RecheckPosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006949 RID: 26953 RVA: 0x001E7A58 File Offset: 0x001E5C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217597, XrefRangeEnd = 217606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TrashItemData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashItem.NativeMethodInfoPtr_GetData_Public_Virtual_New_TrashItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrashItemData>(intPtr3) : null;
		}

		// Token: 0x0600694A RID: 26954 RVA: 0x001E7AA4 File Offset: 0x001E5CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217606, XrefRangeEnd = 217608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashItem.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600694B RID: 26955 RVA: 0x001E7AE8 File Offset: 0x001E5CE8
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 29255, RefRangeEnd = 29273, XrefRangeStart = 29255, XrefRangeEnd = 29273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashItem.NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600694C RID: 26956 RVA: 0x001E7B30 File Offset: 0x001E5D30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 217651, RefRangeEnd = 217653, XrefRangeStart = 217608, XrefRangeEnd = 217651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecheckProperty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_RecheckProperty_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600694D RID: 26957 RVA: 0x001E7B64 File Offset: 0x001E5D64
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 217664, RefRangeEnd = 217670, XrefRangeStart = 217653, XrefRangeEnd = 217664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetContinuousCollisionDetection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_SetContinuousCollisionDetection_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600694E RID: 26958 RVA: 0x001E7B98 File Offset: 0x001E5D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217670, XrefRangeEnd = 217678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDiscreteCollisionDetection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_SetDiscreteCollisionDetection_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600694F RID: 26959 RVA: 0x001E7BCC File Offset: 0x001E5DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217678, XrefRangeEnd = 217682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPhysicsActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_SetPhysicsActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006950 RID: 26960 RVA: 0x001E7C0C File Offset: 0x001E5E0C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 217684, RefRangeEnd = 217689, XrefRangeStart = 217682, XrefRangeEnd = 217684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCollidersEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_SetCollidersEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006951 RID: 26961 RVA: 0x001E7C4C File Offset: 0x001E5E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217689, XrefRangeEnd = 217708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006952 RID: 26962 RVA: 0x001E7C88 File Offset: 0x001E5E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217708, XrefRangeEnd = 217709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__46_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr__Awake_b__46_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006953 RID: 26963 RVA: 0x001E7CBC File Offset: 0x001E5EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217709, XrefRangeEnd = 217710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__46_1(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr__Awake_b__46_1_Private_Void_Impact_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006954 RID: 26964 RVA: 0x00031791 File Offset: 0x0002F991
		public TrashItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002025 RID: 8229
		// (get) Token: 0x06006955 RID: 26965 RVA: 0x001E7D00 File Offset: 0x001E5F00
		// (set) Token: 0x06006956 RID: 26966 RVA: 0x0003179A File Offset: 0x0002F99A
		public unsafe static float ColliderRange
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrashItem.NativeFieldInfoPtr_ColliderRange, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashItem.NativeFieldInfoPtr_ColliderRange, (void*)(&value));
			}
		}

		// Token: 0x17002026 RID: 8230
		// (get) Token: 0x06006957 RID: 26967 RVA: 0x001E7D1C File Offset: 0x001E5F1C
		// (set) Token: 0x06006958 RID: 26968 RVA: 0x000317A8 File Offset: 0x0002F9A8
		public unsafe static float ColliderRangeSqr
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrashItem.NativeFieldInfoPtr_ColliderRangeSqr, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashItem.NativeFieldInfoPtr_ColliderRangeSqr, (void*)(&value));
			}
		}

		// Token: 0x17002027 RID: 8231
		// (get) Token: 0x06006959 RID: 26969 RVA: 0x001E7D38 File Offset: 0x001E5F38
		// (set) Token: 0x0600695A RID: 26970 RVA: 0x000317B6 File Offset: 0x0002F9B6
		public unsafe static float POSITION_CHANGE_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrashItem.NativeFieldInfoPtr_POSITION_CHANGE_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashItem.NativeFieldInfoPtr_POSITION_CHANGE_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17002028 RID: 8232
		// (get) Token: 0x0600695B RID: 26971 RVA: 0x001E7D54 File Offset: 0x001E5F54
		// (set) Token: 0x0600695C RID: 26972 RVA: 0x000317C4 File Offset: 0x0002F9C4
		public unsafe static float LINEAR_DRAG
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrashItem.NativeFieldInfoPtr_LINEAR_DRAG, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashItem.NativeFieldInfoPtr_LINEAR_DRAG, (void*)(&value));
			}
		}

		// Token: 0x17002029 RID: 8233
		// (get) Token: 0x0600695D RID: 26973 RVA: 0x001E7D70 File Offset: 0x001E5F70
		// (set) Token: 0x0600695E RID: 26974 RVA: 0x000317D2 File Offset: 0x0002F9D2
		public unsafe static float ANGULAR_DRAG
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrashItem.NativeFieldInfoPtr_ANGULAR_DRAG, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashItem.NativeFieldInfoPtr_ANGULAR_DRAG, (void*)(&value));
			}
		}

		// Token: 0x1700202A RID: 8234
		// (get) Token: 0x0600695F RID: 26975 RVA: 0x001E7D8C File Offset: 0x001E5F8C
		// (set) Token: 0x06006960 RID: 26976 RVA: 0x000317E0 File Offset: 0x0002F9E0
		public unsafe static float MIN_Y
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrashItem.NativeFieldInfoPtr_MIN_Y, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashItem.NativeFieldInfoPtr_MIN_Y, (void*)(&value));
			}
		}

		// Token: 0x1700202B RID: 8235
		// (get) Token: 0x06006961 RID: 26977 RVA: 0x001E7DA8 File Offset: 0x001E5FA8
		// (set) Token: 0x06006962 RID: 26978 RVA: 0x000317EE File Offset: 0x0002F9EE
		public unsafe static int INTERACTION_PRIORITY
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(TrashItem.NativeFieldInfoPtr_INTERACTION_PRIORITY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashItem.NativeFieldInfoPtr_INTERACTION_PRIORITY, (void*)(&value));
			}
		}

		// Token: 0x1700202C RID: 8236
		// (get) Token: 0x06006963 RID: 26979 RVA: 0x001E7DC4 File Offset: 0x001E5FC4
		// (set) Token: 0x06006964 RID: 26980 RVA: 0x000317FC File Offset: 0x0002F9FC
		public unsafe Rigidbody Rigidbody
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_Rigidbody);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_Rigidbody), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700202D RID: 8237
		// (get) Token: 0x06006965 RID: 26981 RVA: 0x001E7DF4 File Offset: 0x001E5FF4
		// (set) Token: 0x06006966 RID: 26982 RVA: 0x0003181B File Offset: 0x0002FA1B
		public unsafe Draggable Draggable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_Draggable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_Draggable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700202E RID: 8238
		// (get) Token: 0x06006967 RID: 26983 RVA: 0x001E7E24 File Offset: 0x001E6024
		// (set) Token: 0x06006968 RID: 26984 RVA: 0x0003183A File Offset: 0x0002FA3A
		public unsafe string ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_ID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700202F RID: 8239
		// (get) Token: 0x06006969 RID: 26985 RVA: 0x001E7E4C File Offset: 0x001E604C
		// (set) Token: 0x0600696A RID: 26986 RVA: 0x00031859 File Offset: 0x0002FA59
		public unsafe int Size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_Size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_Size)) = value;
			}
		}

		// Token: 0x17002030 RID: 8240
		// (get) Token: 0x0600696B RID: 26987 RVA: 0x001E7E74 File Offset: 0x001E6074
		// (set) Token: 0x0600696C RID: 26988 RVA: 0x00031874 File Offset: 0x0002FA74
		public unsafe int SellValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_SellValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_SellValue)) = value;
			}
		}

		// Token: 0x17002031 RID: 8241
		// (get) Token: 0x0600696D RID: 26989 RVA: 0x001E7E9C File Offset: 0x001E609C
		// (set) Token: 0x0600696E RID: 26990 RVA: 0x0003188F File Offset: 0x0002FA8F
		public unsafe bool CanGoInContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_CanGoInContainer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_CanGoInContainer)) = value;
			}
		}

		// Token: 0x17002032 RID: 8242
		// (get) Token: 0x0600696F RID: 26991 RVA: 0x001E7EC4 File Offset: 0x001E60C4
		// (set) Token: 0x06006970 RID: 26992 RVA: 0x000318AA File Offset: 0x0002FAAA
		public unsafe Il2CppReferenceArray<Collider> colliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_colliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_colliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002033 RID: 8243
		// (get) Token: 0x06006971 RID: 26993 RVA: 0x001E7EF4 File Offset: 0x001E60F4
		// (set) Token: 0x06006972 RID: 26994 RVA: 0x000318C9 File Offset: 0x0002FAC9
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x17002034 RID: 8244
		// (get) Token: 0x06006973 RID: 26995 RVA: 0x001E7F1C File Offset: 0x001E611C
		// (set) Token: 0x06006974 RID: 26996 RVA: 0x000318E4 File Offset: 0x0002FAE4
		public unsafe Property _CurrentProperty_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr__CurrentProperty_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr__CurrentProperty_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002035 RID: 8245
		// (get) Token: 0x06006975 RID: 26997 RVA: 0x001E7F4C File Offset: 0x001E614C
		// (set) Token: 0x06006976 RID: 26998 RVA: 0x00031903 File Offset: 0x0002FB03
		public unsafe Vector3 lastPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_lastPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_lastPosition)) = value;
			}
		}

		// Token: 0x17002036 RID: 8246
		// (get) Token: 0x06006977 RID: 26999 RVA: 0x001E7F74 File Offset: 0x001E6174
		// (set) Token: 0x06006978 RID: 27000 RVA: 0x0003191E File Offset: 0x0002FB1E
		public unsafe Action<TrashItem> onDestroyed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_onDestroyed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TrashItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_onDestroyed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002037 RID: 8247
		// (get) Token: 0x06006979 RID: 27001 RVA: 0x001E7FA4 File Offset: 0x001E61A4
		// (set) Token: 0x0600697A RID: 27002 RVA: 0x0003193D File Offset: 0x0002FB3D
		public unsafe bool collidersEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_collidersEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_collidersEnabled)) = value;
			}
		}

		// Token: 0x17002038 RID: 8248
		// (get) Token: 0x0600697B RID: 27003 RVA: 0x001E7FCC File Offset: 0x001E61CC
		// (set) Token: 0x0600697C RID: 27004 RVA: 0x00031958 File Offset: 0x0002FB58
		public unsafe float timeOnPhysicsEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_timeOnPhysicsEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_timeOnPhysicsEnabled)) = value;
			}
		}

		// Token: 0x17002039 RID: 8249
		// (get) Token: 0x0600697D RID: 27005 RVA: 0x001E7FF4 File Offset: 0x001E61F4
		// (set) Token: 0x0600697E RID: 27006 RVA: 0x00031973 File Offset: 0x0002FB73
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700203A RID: 8250
		// (get) Token: 0x0600697F RID: 27007 RVA: 0x001E8024 File Offset: 0x001E6224
		// (set) Token: 0x06006980 RID: 27008 RVA: 0x00031992 File Offset: 0x0002FB92
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700203B RID: 8251
		// (get) Token: 0x06006981 RID: 27009 RVA: 0x001E8054 File Offset: 0x001E6254
		// (set) Token: 0x06006982 RID: 27010 RVA: 0x000319B1 File Offset: 0x0002FBB1
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x04004858 RID: 18520
		private static readonly IntPtr NativeFieldInfoPtr_ColliderRange;

		// Token: 0x04004859 RID: 18521
		private static readonly IntPtr NativeFieldInfoPtr_ColliderRangeSqr;

		// Token: 0x0400485A RID: 18522
		private static readonly IntPtr NativeFieldInfoPtr_POSITION_CHANGE_THRESHOLD;

		// Token: 0x0400485B RID: 18523
		private static readonly IntPtr NativeFieldInfoPtr_LINEAR_DRAG;

		// Token: 0x0400485C RID: 18524
		private static readonly IntPtr NativeFieldInfoPtr_ANGULAR_DRAG;

		// Token: 0x0400485D RID: 18525
		private static readonly IntPtr NativeFieldInfoPtr_MIN_Y;

		// Token: 0x0400485E RID: 18526
		private static readonly IntPtr NativeFieldInfoPtr_INTERACTION_PRIORITY;

		// Token: 0x0400485F RID: 18527
		private static readonly IntPtr NativeFieldInfoPtr_Rigidbody;

		// Token: 0x04004860 RID: 18528
		private static readonly IntPtr NativeFieldInfoPtr_Draggable;

		// Token: 0x04004861 RID: 18529
		private static readonly IntPtr NativeFieldInfoPtr_ID;

		// Token: 0x04004862 RID: 18530
		private static readonly IntPtr NativeFieldInfoPtr_Size;

		// Token: 0x04004863 RID: 18531
		private static readonly IntPtr NativeFieldInfoPtr_SellValue;

		// Token: 0x04004864 RID: 18532
		private static readonly IntPtr NativeFieldInfoPtr_CanGoInContainer;

		// Token: 0x04004865 RID: 18533
		private static readonly IntPtr NativeFieldInfoPtr_colliders;

		// Token: 0x04004866 RID: 18534
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04004867 RID: 18535
		private static readonly IntPtr NativeFieldInfoPtr__CurrentProperty_k__BackingField;

		// Token: 0x04004868 RID: 18536
		private static readonly IntPtr NativeFieldInfoPtr_lastPosition;

		// Token: 0x04004869 RID: 18537
		private static readonly IntPtr NativeFieldInfoPtr_onDestroyed;

		// Token: 0x0400486A RID: 18538
		private static readonly IntPtr NativeFieldInfoPtr_collidersEnabled;

		// Token: 0x0400486B RID: 18539
		private static readonly IntPtr NativeFieldInfoPtr_timeOnPhysicsEnabled;

		// Token: 0x0400486C RID: 18540
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x0400486D RID: 18541
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x0400486E RID: 18542
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x0400486F RID: 18543
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x04004870 RID: 18544
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x04004871 RID: 18545
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentProperty_Public_get_Property_0;

		// Token: 0x04004872 RID: 18546
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentProperty_Protected_set_Void_Property_0;

		// Token: 0x04004873 RID: 18547
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04004874 RID: 18548
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04004875 RID: 18549
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04004876 RID: 18550
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04004877 RID: 18551
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04004878 RID: 18552
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04004879 RID: 18553
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x0400487A RID: 18554
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x0400487B RID: 18555
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400487C RID: 18556
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0400487D RID: 18557
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Void_0;

		// Token: 0x0400487E RID: 18558
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Void_0;

		// Token: 0x0400487F RID: 18559
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04004880 RID: 18560
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Protected_Void_0;

		// Token: 0x04004881 RID: 18561
		private static readonly IntPtr NativeMethodInfoPtr_OnTick_Protected_Void_0;

		// Token: 0x04004882 RID: 18562
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Protected_Void_0;

		// Token: 0x04004883 RID: 18563
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Protected_Void_0;

		// Token: 0x04004884 RID: 18564
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04004885 RID: 18565
		private static readonly IntPtr NativeMethodInfoPtr_SetVelocity_Public_Void_Vector3_0;

		// Token: 0x04004886 RID: 18566
		private static readonly IntPtr NativeMethodInfoPtr_DestroyTrash_Public_Void_0;

		// Token: 0x04004887 RID: 18567
		private static readonly IntPtr NativeMethodInfoPtr_Deinitialize_Public_Virtual_New_Void_0;

		// Token: 0x04004888 RID: 18568
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04004889 RID: 18569
		private static readonly IntPtr NativeMethodInfoPtr_RecheckPosition_Private_Void_0;

		// Token: 0x0400488A RID: 18570
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_Virtual_New_TrashItemData_0;

		// Token: 0x0400488B RID: 18571
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x0400488C RID: 18572
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0;

		// Token: 0x0400488D RID: 18573
		private static readonly IntPtr NativeMethodInfoPtr_RecheckProperty_Private_Void_0;

		// Token: 0x0400488E RID: 18574
		private static readonly IntPtr NativeMethodInfoPtr_SetContinuousCollisionDetection_Public_Void_0;

		// Token: 0x0400488F RID: 18575
		private static readonly IntPtr NativeMethodInfoPtr_SetDiscreteCollisionDetection_Public_Void_0;

		// Token: 0x04004890 RID: 18576
		private static readonly IntPtr NativeMethodInfoPtr_SetPhysicsActive_Public_Void_Boolean_0;

		// Token: 0x04004891 RID: 18577
		private static readonly IntPtr NativeMethodInfoPtr_SetCollidersEnabled_Public_Void_Boolean_0;

		// Token: 0x04004892 RID: 18578
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004893 RID: 18579
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__46_0_Private_Void_0;

		// Token: 0x04004894 RID: 18580
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__46_1_Private_Void_Impact_0;
	}
}
