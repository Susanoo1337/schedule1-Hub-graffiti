using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x02000527 RID: 1319
	public class StorageEntityInteractable : InteractableObject
	{
		// Token: 0x06007826 RID: 30758 RVA: 0x00216A1C File Offset: 0x00214C1C
		// Note: this type is marked as 'beforefieldinit'.
		static StorageEntityInteractable()
		{
			Il2CppClassPointerStore<StorageEntityInteractable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "StorageEntityInteractable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageEntityInteractable>.NativeClassPtr);
			StorageEntityInteractable.NativeFieldInfoPtr_StorageEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageEntityInteractable>.NativeClassPtr, "StorageEntity");
			StorageEntityInteractable.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageEntityInteractable>.NativeClassPtr, 100678766);
			StorageEntityInteractable.NativeMethodInfoPtr_Hovered_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageEntityInteractable>.NativeClassPtr, 100678767);
			StorageEntityInteractable.NativeMethodInfoPtr_StartInteract_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageEntityInteractable>.NativeClassPtr, 100678768);
			StorageEntityInteractable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageEntityInteractable>.NativeClassPtr, 100678769);
		}

		// Token: 0x06007827 RID: 30759 RVA: 0x00216AB0 File Offset: 0x00214CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232446, XrefRangeEnd = 232450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageEntityInteractable.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007828 RID: 30760 RVA: 0x00216AE4 File Offset: 0x00214CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232450, XrefRangeEnd = 232452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageEntityInteractable.NativeMethodInfoPtr_Hovered_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007829 RID: 30761 RVA: 0x00216B20 File Offset: 0x00214D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232452, XrefRangeEnd = 232475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageEntityInteractable.NativeMethodInfoPtr_StartInteract_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600782A RID: 30762 RVA: 0x00216B5C File Offset: 0x00214D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232475, XrefRangeEnd = 232476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorageEntityInteractable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageEntityInteractable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageEntityInteractable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600782B RID: 30763 RVA: 0x000392FD File Offset: 0x000374FD
		public StorageEntityInteractable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002513 RID: 9491
		// (get) Token: 0x0600782C RID: 30764 RVA: 0x00216B98 File Offset: 0x00214D98
		// (set) Token: 0x0600782D RID: 30765 RVA: 0x00039306 File Offset: 0x00037506
		public unsafe StorageEntity StorageEntity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageEntityInteractable.NativeFieldInfoPtr_StorageEntity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageEntityInteractable.NativeFieldInfoPtr_StorageEntity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040051ED RID: 20973
		private static readonly IntPtr NativeFieldInfoPtr_StorageEntity;

		// Token: 0x040051EE RID: 20974
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040051EF RID: 20975
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Virtual_Void_0;

		// Token: 0x040051F0 RID: 20976
		private static readonly IntPtr NativeMethodInfoPtr_StartInteract_Public_Virtual_Void_0;

		// Token: 0x040051F1 RID: 20977
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
