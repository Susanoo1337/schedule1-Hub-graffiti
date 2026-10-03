using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x02000528 RID: 1320
	public class StorageEntityVisualizer : StorageVisualizer
	{
		// Token: 0x0600782E RID: 30766 RVA: 0x00216BC8 File Offset: 0x00214DC8
		// Note: this type is marked as 'beforefieldinit'.
		static StorageEntityVisualizer()
		{
			Il2CppClassPointerStore<StorageEntityVisualizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "StorageEntityVisualizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageEntityVisualizer>.NativeClassPtr);
			StorageEntityVisualizer.NativeFieldInfoPtr_storageEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageEntityVisualizer>.NativeClassPtr, "storageEntity");
			StorageEntityVisualizer.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageEntityVisualizer>.NativeClassPtr, 100678770);
			StorageEntityVisualizer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageEntityVisualizer>.NativeClassPtr, 100678771);
		}

		// Token: 0x0600782F RID: 30767 RVA: 0x00216C34 File Offset: 0x00214E34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232476, XrefRangeEnd = 232499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageEntityVisualizer.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007830 RID: 30768 RVA: 0x00216C70 File Offset: 0x00214E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232499, XrefRangeEnd = 232514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorageEntityVisualizer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageEntityVisualizer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageEntityVisualizer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007831 RID: 30769 RVA: 0x00039325 File Offset: 0x00037525
		public StorageEntityVisualizer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002514 RID: 9492
		// (get) Token: 0x06007832 RID: 30770 RVA: 0x00216CAC File Offset: 0x00214EAC
		// (set) Token: 0x06007833 RID: 30771 RVA: 0x0003932E File Offset: 0x0003752E
		public unsafe StorageEntity storageEntity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageEntityVisualizer.NativeFieldInfoPtr_storageEntity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageEntityVisualizer.NativeFieldInfoPtr_storageEntity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040051F2 RID: 20978
		private static readonly IntPtr NativeFieldInfoPtr_storageEntity;

		// Token: 0x040051F3 RID: 20979
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x040051F4 RID: 20980
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
