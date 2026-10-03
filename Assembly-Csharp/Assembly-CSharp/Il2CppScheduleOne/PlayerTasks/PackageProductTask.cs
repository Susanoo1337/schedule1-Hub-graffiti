using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.Packaging;
using Il2CppScheduleOne.Product;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x02000188 RID: 392
	public class PackageProductTask : Task
	{
		// Token: 0x060027C3 RID: 10179 RVA: 0x000FE700 File Offset: 0x000FC900
		// Note: this type is marked as 'beforefieldinit'.
		static PackageProductTask()
		{
			Il2CppClassPointerStore<PackageProductTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "PackageProductTask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackageProductTask>.NativeClassPtr);
			PackageProductTask.NativeFieldInfoPtr__TaskName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackageProductTask>.NativeClassPtr, "<TaskName>k__BackingField");
			PackageProductTask.NativeFieldInfoPtr_station = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackageProductTask>.NativeClassPtr, "station");
			PackageProductTask.NativeFieldInfoPtr_Packaging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackageProductTask>.NativeClassPtr, "Packaging");
			PackageProductTask.NativeFieldInfoPtr_Products = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackageProductTask>.NativeClassPtr, "Products");
			PackageProductTask.NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackageProductTask>.NativeClassPtr, 100668386);
			PackageProductTask.NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackageProductTask>.NativeClassPtr, 100668387);
			PackageProductTask.NativeMethodInfoPtr__ctor_Public_Void_PackagingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackageProductTask>.NativeClassPtr, 100668388);
			PackageProductTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackageProductTask>.NativeClassPtr, 100668389);
			PackageProductTask.NativeMethodInfoPtr_Success_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackageProductTask>.NativeClassPtr, 100668390);
			PackageProductTask.NativeMethodInfoPtr_FullyPacked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackageProductTask>.NativeClassPtr, 100668391);
			PackageProductTask.NativeMethodInfoPtr_Sealed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackageProductTask>.NativeClassPtr, 100668392);
			PackageProductTask.NativeMethodInfoPtr_ReachedOutput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackageProductTask>.NativeClassPtr, 100668393);
		}

		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x060027C4 RID: 10180 RVA: 0x000FE820 File Offset: 0x000FCA20
		// (set) Token: 0x060027C5 RID: 10181 RVA: 0x000FE864 File Offset: 0x000FCA64
		public unsafe override string TaskName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackageProductTask.NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackageProductTask.NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060027C6 RID: 10182 RVA: 0x000FE8B4 File Offset: 0x000FCAB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 119974, RefRangeEnd = 119975, XrefRangeStart = 119868, XrefRangeEnd = 119974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackageProductTask(PackagingStation _station) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackageProductTask>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_station);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackageProductTask.NativeMethodInfoPtr__ctor_Public_Void_PackagingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027C7 RID: 10183 RVA: 0x000FE900 File Offset: 0x000FCB00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119975, XrefRangeEnd = 120013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackageProductTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027C8 RID: 10184 RVA: 0x000FE93C File Offset: 0x000FCB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120013, XrefRangeEnd = 120016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Success()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackageProductTask.NativeMethodInfoPtr_Success_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027C9 RID: 10185 RVA: 0x000FE978 File Offset: 0x000FCB78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120016, XrefRangeEnd = 120018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FullyPacked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackageProductTask.NativeMethodInfoPtr_FullyPacked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027CA RID: 10186 RVA: 0x000FE9AC File Offset: 0x000FCBAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120018, XrefRangeEnd = 120023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Sealed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackageProductTask.NativeMethodInfoPtr_Sealed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027CB RID: 10187 RVA: 0x000FE9E0 File Offset: 0x000FCBE0
		[CallerCount(0)]
		public unsafe void ReachedOutput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackageProductTask.NativeMethodInfoPtr_ReachedOutput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027CC RID: 10188 RVA: 0x00014EC1 File Offset: 0x000130C1
		public PackageProductTask(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x060027CD RID: 10189 RVA: 0x000FEA14 File Offset: 0x000FCC14
		// (set) Token: 0x060027CE RID: 10190 RVA: 0x00014ECA File Offset: 0x000130CA
		public new unsafe string _TaskName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageProductTask.NativeFieldInfoPtr__TaskName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageProductTask.NativeFieldInfoPtr__TaskName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x060027CF RID: 10191 RVA: 0x000FEA3C File Offset: 0x000FCC3C
		// (set) Token: 0x060027D0 RID: 10192 RVA: 0x00014EE9 File Offset: 0x000130E9
		public unsafe PackagingStation station
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageProductTask.NativeFieldInfoPtr_station);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageProductTask.NativeFieldInfoPtr_station), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x060027D1 RID: 10193 RVA: 0x000FEA6C File Offset: 0x000FCC6C
		// (set) Token: 0x060027D2 RID: 10194 RVA: 0x00014F08 File Offset: 0x00013108
		public unsafe FunctionalPackaging Packaging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageProductTask.NativeFieldInfoPtr_Packaging);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FunctionalPackaging>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageProductTask.NativeFieldInfoPtr_Packaging), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x060027D3 RID: 10195 RVA: 0x000FEA9C File Offset: 0x000FCC9C
		// (set) Token: 0x060027D4 RID: 10196 RVA: 0x00014F27 File Offset: 0x00013127
		public unsafe List<FunctionalProduct> Products
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageProductTask.NativeFieldInfoPtr_Products);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FunctionalProduct>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageProductTask.NativeFieldInfoPtr_Products), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B5F RID: 7007
		private static readonly IntPtr NativeFieldInfoPtr__TaskName_k__BackingField;

		// Token: 0x04001B60 RID: 7008
		private static readonly IntPtr NativeFieldInfoPtr_station;

		// Token: 0x04001B61 RID: 7009
		private static readonly IntPtr NativeFieldInfoPtr_Packaging;

		// Token: 0x04001B62 RID: 7010
		private static readonly IntPtr NativeFieldInfoPtr_Products;

		// Token: 0x04001B63 RID: 7011
		private static readonly IntPtr NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0;

		// Token: 0x04001B64 RID: 7012
		private static readonly IntPtr NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0;

		// Token: 0x04001B65 RID: 7013
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PackagingStation_0;

		// Token: 0x04001B66 RID: 7014
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;

		// Token: 0x04001B67 RID: 7015
		private static readonly IntPtr NativeMethodInfoPtr_Success_Public_Virtual_Void_0;

		// Token: 0x04001B68 RID: 7016
		private static readonly IntPtr NativeMethodInfoPtr_FullyPacked_Private_Void_0;

		// Token: 0x04001B69 RID: 7017
		private static readonly IntPtr NativeMethodInfoPtr_Sealed_Private_Void_0;

		// Token: 0x04001B6A RID: 7018
		private static readonly IntPtr NativeMethodInfoPtr_ReachedOutput_Private_Void_0;
	}
}
