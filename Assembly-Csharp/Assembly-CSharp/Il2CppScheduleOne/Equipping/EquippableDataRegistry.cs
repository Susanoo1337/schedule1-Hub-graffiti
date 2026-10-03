using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Core.Equipping.Framework;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x02000587 RID: 1415
	public class EquippableDataRegistry : PersistentSingleton<EquippableDataRegistry>
	{
		// Token: 0x0600811A RID: 33050 RVA: 0x0023611C File Offset: 0x0023431C
		// Note: this type is marked as 'beforefieldinit'.
		static EquippableDataRegistry()
		{
			Il2CppClassPointerStore<EquippableDataRegistry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "EquippableDataRegistry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EquippableDataRegistry>.NativeClassPtr);
			EquippableDataRegistry.NativeFieldInfoPtr__equippableDataList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquippableDataRegistry>.NativeClassPtr, "_equippableDataList");
			EquippableDataRegistry.NativeMethodInfoPtr_GetEquippableData_Public_EquippableData_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquippableDataRegistry>.NativeClassPtr, 100679879);
			EquippableDataRegistry.NativeMethodInfoPtr_RegisterEquippableData_Private_Void_EquippableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquippableDataRegistry>.NativeClassPtr, 100679880);
			EquippableDataRegistry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquippableDataRegistry>.NativeClassPtr, 100679881);
		}

		// Token: 0x0600811B RID: 33051 RVA: 0x0023619C File Offset: 0x0023439C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 244722, RefRangeEnd = 244723, XrefRangeStart = 244708, XrefRangeEnd = 244722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EquippableData GetEquippableData(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquippableDataRegistry.NativeMethodInfoPtr_GetEquippableData_Public_EquippableData_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EquippableData>(intPtr3) : null;
		}

		// Token: 0x0600811C RID: 33052 RVA: 0x002361E8 File Offset: 0x002343E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244723, XrefRangeEnd = 244735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterEquippableData(EquippableData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquippableDataRegistry.NativeMethodInfoPtr_RegisterEquippableData_Private_Void_EquippableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600811D RID: 33053 RVA: 0x0023622C File Offset: 0x0023442C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244735, XrefRangeEnd = 244745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EquippableDataRegistry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EquippableDataRegistry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquippableDataRegistry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600811E RID: 33054 RVA: 0x0003D74D File Offset: 0x0003B94D
		public EquippableDataRegistry(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027EF RID: 10223
		// (get) Token: 0x0600811F RID: 33055 RVA: 0x00236268 File Offset: 0x00234468
		// (set) Token: 0x06008120 RID: 33056 RVA: 0x0003D756 File Offset: 0x0003B956
		public unsafe List<EquippableData> _equippableDataList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EquippableDataRegistry.NativeFieldInfoPtr__equippableDataList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EquippableData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EquippableDataRegistry.NativeFieldInfoPtr__equippableDataList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040057FF RID: 22527
		private static readonly IntPtr NativeFieldInfoPtr__equippableDataList;

		// Token: 0x04005800 RID: 22528
		private static readonly IntPtr NativeMethodInfoPtr_GetEquippableData_Public_EquippableData_Guid_0;

		// Token: 0x04005801 RID: 22529
		private static readonly IntPtr NativeMethodInfoPtr_RegisterEquippableData_Private_Void_EquippableData_0;

		// Token: 0x04005802 RID: 22530
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
