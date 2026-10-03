using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Packaging;
using Il2CppScheduleOne.Product;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x02000189 RID: 393
	public class PackageProductTaskMk2 : Task
	{
		// Token: 0x060027D5 RID: 10197 RVA: 0x000FEACC File Offset: 0x000FCCCC
		// Note: this type is marked as 'beforefieldinit'.
		static PackageProductTaskMk2()
		{
			Il2CppClassPointerStore<PackageProductTaskMk2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "PackageProductTaskMk2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackageProductTaskMk2>.NativeClassPtr);
			PackageProductTaskMk2.NativeFieldInfoPtr__TaskName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackageProductTaskMk2>.NativeClassPtr, "<TaskName>k__BackingField");
			PackageProductTaskMk2.NativeFieldInfoPtr_station = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackageProductTaskMk2>.NativeClassPtr, "station");
			PackageProductTaskMk2.NativeFieldInfoPtr_Packaging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackageProductTaskMk2>.NativeClassPtr, "Packaging");
			PackageProductTaskMk2.NativeFieldInfoPtr_Products = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackageProductTaskMk2>.NativeClassPtr, "Products");
			PackageProductTaskMk2.NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackageProductTaskMk2>.NativeClassPtr, 100668394);
			PackageProductTaskMk2.NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackageProductTaskMk2>.NativeClassPtr, 100668395);
			PackageProductTaskMk2.NativeMethodInfoPtr__ctor_Public_Void_PackagingStationMk2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackageProductTaskMk2>.NativeClassPtr, 100668396);
			PackageProductTaskMk2.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackageProductTaskMk2>.NativeClassPtr, 100668397);
		}

		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x060027D6 RID: 10198 RVA: 0x000FEB9C File Offset: 0x000FCD9C
		// (set) Token: 0x060027D7 RID: 10199 RVA: 0x000FEBE0 File Offset: 0x000FCDE0
		public unsafe override string TaskName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackageProductTaskMk2.NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackageProductTaskMk2.NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060027D8 RID: 10200 RVA: 0x000FEC30 File Offset: 0x000FCE30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 120087, RefRangeEnd = 120088, XrefRangeStart = 120023, XrefRangeEnd = 120087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackageProductTaskMk2(PackagingStationMk2 _station) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackageProductTaskMk2>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_station);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackageProductTaskMk2.NativeMethodInfoPtr__ctor_Public_Void_PackagingStationMk2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027D9 RID: 10201 RVA: 0x000FEC7C File Offset: 0x000FCE7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120088, XrefRangeEnd = 120116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackageProductTaskMk2.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027DA RID: 10202 RVA: 0x00014F46 File Offset: 0x00013146
		public PackageProductTaskMk2(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x060027DB RID: 10203 RVA: 0x000FECB8 File Offset: 0x000FCEB8
		// (set) Token: 0x060027DC RID: 10204 RVA: 0x00014F4F File Offset: 0x0001314F
		public new unsafe string _TaskName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageProductTaskMk2.NativeFieldInfoPtr__TaskName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageProductTaskMk2.NativeFieldInfoPtr__TaskName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D18 RID: 3352
		// (get) Token: 0x060027DD RID: 10205 RVA: 0x000FECE0 File Offset: 0x000FCEE0
		// (set) Token: 0x060027DE RID: 10206 RVA: 0x00014F6E File Offset: 0x0001316E
		public unsafe PackagingStationMk2 station
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageProductTaskMk2.NativeFieldInfoPtr_station);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingStationMk2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageProductTaskMk2.NativeFieldInfoPtr_station), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D19 RID: 3353
		// (get) Token: 0x060027DF RID: 10207 RVA: 0x000FED10 File Offset: 0x000FCF10
		// (set) Token: 0x060027E0 RID: 10208 RVA: 0x00014F8D File Offset: 0x0001318D
		public unsafe FunctionalPackaging Packaging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageProductTaskMk2.NativeFieldInfoPtr_Packaging);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FunctionalPackaging>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageProductTaskMk2.NativeFieldInfoPtr_Packaging), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D1A RID: 3354
		// (get) Token: 0x060027E1 RID: 10209 RVA: 0x000FED40 File Offset: 0x000FCF40
		// (set) Token: 0x060027E2 RID: 10210 RVA: 0x00014FAC File Offset: 0x000131AC
		public unsafe List<FunctionalProduct> Products
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageProductTaskMk2.NativeFieldInfoPtr_Products);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FunctionalProduct>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageProductTaskMk2.NativeFieldInfoPtr_Products), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B6B RID: 7019
		private static readonly IntPtr NativeFieldInfoPtr__TaskName_k__BackingField;

		// Token: 0x04001B6C RID: 7020
		private static readonly IntPtr NativeFieldInfoPtr_station;

		// Token: 0x04001B6D RID: 7021
		private static readonly IntPtr NativeFieldInfoPtr_Packaging;

		// Token: 0x04001B6E RID: 7022
		private static readonly IntPtr NativeFieldInfoPtr_Products;

		// Token: 0x04001B6F RID: 7023
		private static readonly IntPtr NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0;

		// Token: 0x04001B70 RID: 7024
		private static readonly IntPtr NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0;

		// Token: 0x04001B71 RID: 7025
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PackagingStationMk2_0;

		// Token: 0x04001B72 RID: 7026
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;
	}
}
