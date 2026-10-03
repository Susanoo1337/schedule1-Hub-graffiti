using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020007F0 RID: 2032
	public class StorageUIElement : WorldspaceUIElement
	{
		// Token: 0x0600C61C RID: 50716 RVA: 0x0032365C File Offset: 0x0032185C
		// Note: this type is marked as 'beforefieldinit'.
		static StorageUIElement()
		{
			Il2CppClassPointerStore<StorageUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "StorageUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageUIElement>.NativeClassPtr);
			StorageUIElement.NativeFieldInfoPtr__AssignedEntity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageUIElement>.NativeClassPtr, "<AssignedEntity>k__BackingField");
			StorageUIElement.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageUIElement>.NativeClassPtr, "Icon");
			StorageUIElement.NativeMethodInfoPtr_get_AssignedEntity_Public_get_PlaceableStorageEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageUIElement>.NativeClassPtr, 100688958);
			StorageUIElement.NativeMethodInfoPtr_set_AssignedEntity_Protected_set_Void_PlaceableStorageEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageUIElement>.NativeClassPtr, 100688959);
			StorageUIElement.NativeMethodInfoPtr_Initialize_Public_Void_PlaceableStorageEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageUIElement>.NativeClassPtr, 100688960);
			StorageUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageUIElement>.NativeClassPtr, 100688961);
			StorageUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageUIElement>.NativeClassPtr, 100688962);
		}

		// Token: 0x17003C24 RID: 15396
		// (get) Token: 0x0600C61D RID: 50717 RVA: 0x00323718 File Offset: 0x00321918
		// (set) Token: 0x0600C61E RID: 50718 RVA: 0x00323758 File Offset: 0x00321958
		public unsafe PlaceableStorageEntity AssignedEntity
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 32794, RefRangeEnd = 32795, XrefRangeStart = 32794, XrefRangeEnd = 32795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageUIElement.NativeMethodInfoPtr_get_AssignedEntity_Public_get_PlaceableStorageEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlaceableStorageEntity>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageUIElement.NativeMethodInfoPtr_set_AssignedEntity_Protected_set_Void_PlaceableStorageEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600C61F RID: 50719 RVA: 0x0032379C File Offset: 0x0032199C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327470, RefRangeEnd = 327471, XrefRangeStart = 327460, XrefRangeEnd = 327470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(PlaceableStorageEntity entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageUIElement.NativeMethodInfoPtr_Initialize_Public_Void_PlaceableStorageEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C620 RID: 50720 RVA: 0x003237E0 File Offset: 0x003219E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327471, XrefRangeEnd = 327472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C621 RID: 50721 RVA: 0x0032381C File Offset: 0x00321A1C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorageUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageUIElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C622 RID: 50722 RVA: 0x0005D84E File Offset: 0x0005BA4E
		public StorageUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003C22 RID: 15394
		// (get) Token: 0x0600C623 RID: 50723 RVA: 0x00323858 File Offset: 0x00321A58
		// (set) Token: 0x0600C624 RID: 50724 RVA: 0x0005D857 File Offset: 0x0005BA57
		public unsafe PlaceableStorageEntity _AssignedEntity_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageUIElement.NativeFieldInfoPtr__AssignedEntity_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlaceableStorageEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageUIElement.NativeFieldInfoPtr__AssignedEntity_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C23 RID: 15395
		// (get) Token: 0x0600C625 RID: 50725 RVA: 0x00323888 File Offset: 0x00321A88
		// (set) Token: 0x0600C626 RID: 50726 RVA: 0x0005D876 File Offset: 0x0005BA76
		public unsafe Image Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageUIElement.NativeFieldInfoPtr_Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageUIElement.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008728 RID: 34600
		private static readonly IntPtr NativeFieldInfoPtr__AssignedEntity_k__BackingField;

		// Token: 0x04008729 RID: 34601
		private static readonly IntPtr NativeFieldInfoPtr_Icon;

		// Token: 0x0400872A RID: 34602
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedEntity_Public_get_PlaceableStorageEntity_0;

		// Token: 0x0400872B RID: 34603
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedEntity_Protected_set_Void_PlaceableStorageEntity_0;

		// Token: 0x0400872C RID: 34604
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_PlaceableStorageEntity_0;

		// Token: 0x0400872D RID: 34605
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x0400872E RID: 34606
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
