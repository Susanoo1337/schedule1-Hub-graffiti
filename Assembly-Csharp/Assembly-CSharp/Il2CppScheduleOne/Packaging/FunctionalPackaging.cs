using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.PlayerTasks;
using Il2CppScheduleOne.Product;
using Il2CppScheduleOne.Product.Packaging;
using Il2CppScheduleOne.Tools;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Packaging
{
	// Token: 0x0200050D RID: 1293
	public class FunctionalPackaging : Draggable
	{
		// Token: 0x0600749A RID: 29850 RVA: 0x00209924 File Offset: 0x00207B24
		// Note: this type is marked as 'beforefieldinit'.
		static FunctionalPackaging()
		{
			Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Packaging", "FunctionalPackaging");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr);
			FunctionalPackaging.NativeFieldInfoPtr__IsSealed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "<IsSealed>k__BackingField");
			FunctionalPackaging.NativeFieldInfoPtr__IsFull_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "<IsFull>k__BackingField");
			FunctionalPackaging.NativeFieldInfoPtr__ReachedOutput_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "<ReachedOutput>k__BackingField");
			FunctionalPackaging.NativeFieldInfoPtr_SealInstruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "SealInstruction");
			FunctionalPackaging.NativeFieldInfoPtr_AutoEnableSealing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "AutoEnableSealing");
			FunctionalPackaging.NativeFieldInfoPtr_ProductContactTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "ProductContactTime");
			FunctionalPackaging.NativeFieldInfoPtr_ProductContactMaxVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "ProductContactMaxVelocity");
			FunctionalPackaging.NativeFieldInfoPtr_Definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "Definition");
			FunctionalPackaging.NativeFieldInfoPtr_AlignmentPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "AlignmentPoint");
			FunctionalPackaging.NativeFieldInfoPtr_ProductAlignmentPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "ProductAlignmentPoints");
			FunctionalPackaging.NativeFieldInfoPtr_SealSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "SealSound");
			FunctionalPackaging.NativeFieldInfoPtr_PackedProducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "PackedProducts");
			FunctionalPackaging.NativeFieldInfoPtr_onFullyPacked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "onFullyPacked");
			FunctionalPackaging.NativeFieldInfoPtr_onSealed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "onSealed");
			FunctionalPackaging.NativeFieldInfoPtr_onReachOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "onReachOutput");
			FunctionalPackaging.NativeFieldInfoPtr_station = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "station");
			FunctionalPackaging.NativeFieldInfoPtr_productContactTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "productContactTime");
			FunctionalPackaging.NativeFieldInfoPtr_VelocityCalculator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "VelocityCalculator");
			FunctionalPackaging.NativeMethodInfoPtr_get_IsSealed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678314);
			FunctionalPackaging.NativeMethodInfoPtr_set_IsSealed_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678315);
			FunctionalPackaging.NativeMethodInfoPtr_get_IsFull_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678316);
			FunctionalPackaging.NativeMethodInfoPtr_set_IsFull_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678317);
			FunctionalPackaging.NativeMethodInfoPtr_get_ReachedOutput_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678318);
			FunctionalPackaging.NativeMethodInfoPtr_set_ReachedOutput_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678319);
			FunctionalPackaging.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_PackagingStation_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678320);
			FunctionalPackaging.NativeMethodInfoPtr_AlignTo_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678321);
			FunctionalPackaging.NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678322);
			FunctionalPackaging.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678323);
			FunctionalPackaging.NativeMethodInfoPtr_PackProduct_Protected_Virtual_New_Void_FunctionalProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678324);
			FunctionalPackaging.NativeMethodInfoPtr_FullyPacked_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678325);
			FunctionalPackaging.NativeMethodInfoPtr_OnTriggerStay_Protected_Virtual_New_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678326);
			FunctionalPackaging.NativeMethodInfoPtr_EnableSealing_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678327);
			FunctionalPackaging.NativeMethodInfoPtr_Seal_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678328);
			FunctionalPackaging.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678329);
		}

		// Token: 0x1700240F RID: 9231
		// (get) Token: 0x0600749B RID: 29851 RVA: 0x00209BFC File Offset: 0x00207DFC
		// (set) Token: 0x0600749C RID: 29852 RVA: 0x00209C38 File Offset: 0x00207E38
		public unsafe bool IsSealed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalPackaging.NativeMethodInfoPtr_get_IsSealed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalPackaging.NativeMethodInfoPtr_set_IsSealed_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002410 RID: 9232
		// (get) Token: 0x0600749D RID: 29853 RVA: 0x00209C78 File Offset: 0x00207E78
		// (set) Token: 0x0600749E RID: 29854 RVA: 0x00209CB4 File Offset: 0x00207EB4
		public unsafe bool IsFull
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalPackaging.NativeMethodInfoPtr_get_IsFull_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalPackaging.NativeMethodInfoPtr_set_IsFull_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002411 RID: 9233
		// (get) Token: 0x0600749F RID: 29855 RVA: 0x00209CF4 File Offset: 0x00207EF4
		// (set) Token: 0x060074A0 RID: 29856 RVA: 0x00209D30 File Offset: 0x00207F30
		public unsafe bool ReachedOutput
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalPackaging.NativeMethodInfoPtr_get_ReachedOutput_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalPackaging.NativeMethodInfoPtr_set_ReachedOutput_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060074A1 RID: 29857 RVA: 0x00209D70 File Offset: 0x00207F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228347, XrefRangeEnd = 228359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(PackagingStation _station, Transform alignment, bool align = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_station);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(alignment);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref align;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalPackaging.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_PackagingStation_Transform_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074A2 RID: 29858 RVA: 0x00209DE0 File Offset: 0x00207FE0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 228389, RefRangeEnd = 228392, XrefRangeStart = 228359, XrefRangeEnd = 228389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlignTo(Transform alignment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(alignment);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalPackaging.NativeMethodInfoPtr_AlignTo_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074A3 RID: 29859 RVA: 0x00209E24 File Offset: 0x00208024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228392, XrefRangeEnd = 228397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalPackaging.NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074A4 RID: 29860 RVA: 0x00209E60 File Offset: 0x00208060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228397, XrefRangeEnd = 228428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalPackaging.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074A5 RID: 29861 RVA: 0x00209E9C File Offset: 0x0020809C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228428, XrefRangeEnd = 228447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PackProduct(FunctionalProduct product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalPackaging.NativeMethodInfoPtr_PackProduct_Protected_Virtual_New_Void_FunctionalProduct_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074A6 RID: 29862 RVA: 0x00209EEC File Offset: 0x002080EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 228465, RefRangeEnd = 228467, XrefRangeStart = 228447, XrefRangeEnd = 228465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FullyPacked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalPackaging.NativeMethodInfoPtr_FullyPacked_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074A7 RID: 29863 RVA: 0x00209F28 File Offset: 0x00208128
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 228507, RefRangeEnd = 228508, XrefRangeStart = 228467, XrefRangeEnd = 228507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnTriggerStay(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalPackaging.NativeMethodInfoPtr_OnTriggerStay_Protected_Virtual_New_Void_Collider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074A8 RID: 29864 RVA: 0x00209F78 File Offset: 0x00208178
		[CallerCount(0)]
		public unsafe virtual void EnableSealing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalPackaging.NativeMethodInfoPtr_EnableSealing_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074A9 RID: 29865 RVA: 0x00209FB4 File Offset: 0x002081B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 228531, RefRangeEnd = 228533, XrefRangeStart = 228508, XrefRangeEnd = 228531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Seal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalPackaging.NativeMethodInfoPtr_Seal_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074AA RID: 29866 RVA: 0x00209FF0 File Offset: 0x002081F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 228552, RefRangeEnd = 228554, XrefRangeStart = 228533, XrefRangeEnd = 228552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FunctionalPackaging() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalPackaging.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074AB RID: 29867 RVA: 0x000379F4 File Offset: 0x00035BF4
		public FunctionalPackaging(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023FD RID: 9213
		// (get) Token: 0x060074AC RID: 29868 RVA: 0x0020A02C File Offset: 0x0020822C
		// (set) Token: 0x060074AD RID: 29869 RVA: 0x000379FD File Offset: 0x00035BFD
		public unsafe bool _IsSealed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr__IsSealed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr__IsSealed_k__BackingField)) = value;
			}
		}

		// Token: 0x170023FE RID: 9214
		// (get) Token: 0x060074AE RID: 29870 RVA: 0x0020A054 File Offset: 0x00208254
		// (set) Token: 0x060074AF RID: 29871 RVA: 0x00037A18 File Offset: 0x00035C18
		public unsafe bool _IsFull_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr__IsFull_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr__IsFull_k__BackingField)) = value;
			}
		}

		// Token: 0x170023FF RID: 9215
		// (get) Token: 0x060074B0 RID: 29872 RVA: 0x0020A07C File Offset: 0x0020827C
		// (set) Token: 0x060074B1 RID: 29873 RVA: 0x00037A33 File Offset: 0x00035C33
		public unsafe bool _ReachedOutput_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr__ReachedOutput_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr__ReachedOutput_k__BackingField)) = value;
			}
		}

		// Token: 0x17002400 RID: 9216
		// (get) Token: 0x060074B2 RID: 29874 RVA: 0x0020A0A4 File Offset: 0x002082A4
		// (set) Token: 0x060074B3 RID: 29875 RVA: 0x00037A4E File Offset: 0x00035C4E
		public unsafe string SealInstruction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_SealInstruction);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_SealInstruction), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002401 RID: 9217
		// (get) Token: 0x060074B4 RID: 29876 RVA: 0x0020A0CC File Offset: 0x002082CC
		// (set) Token: 0x060074B5 RID: 29877 RVA: 0x00037A6D File Offset: 0x00035C6D
		public unsafe bool AutoEnableSealing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_AutoEnableSealing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_AutoEnableSealing)) = value;
			}
		}

		// Token: 0x17002402 RID: 9218
		// (get) Token: 0x060074B6 RID: 29878 RVA: 0x0020A0F4 File Offset: 0x002082F4
		// (set) Token: 0x060074B7 RID: 29879 RVA: 0x00037A88 File Offset: 0x00035C88
		public unsafe float ProductContactTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_ProductContactTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_ProductContactTime)) = value;
			}
		}

		// Token: 0x17002403 RID: 9219
		// (get) Token: 0x060074B8 RID: 29880 RVA: 0x0020A11C File Offset: 0x0020831C
		// (set) Token: 0x060074B9 RID: 29881 RVA: 0x00037AA3 File Offset: 0x00035CA3
		public unsafe float ProductContactMaxVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_ProductContactMaxVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_ProductContactMaxVelocity)) = value;
			}
		}

		// Token: 0x17002404 RID: 9220
		// (get) Token: 0x060074BA RID: 29882 RVA: 0x0020A144 File Offset: 0x00208344
		// (set) Token: 0x060074BB RID: 29883 RVA: 0x00037ABE File Offset: 0x00035CBE
		public unsafe PackagingDefinition Definition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_Definition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_Definition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002405 RID: 9221
		// (get) Token: 0x060074BC RID: 29884 RVA: 0x0020A174 File Offset: 0x00208374
		// (set) Token: 0x060074BD RID: 29885 RVA: 0x00037ADD File Offset: 0x00035CDD
		public unsafe Transform AlignmentPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_AlignmentPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_AlignmentPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002406 RID: 9222
		// (get) Token: 0x060074BE RID: 29886 RVA: 0x0020A1A4 File Offset: 0x002083A4
		// (set) Token: 0x060074BF RID: 29887 RVA: 0x00037AFC File Offset: 0x00035CFC
		public unsafe Il2CppReferenceArray<Transform> ProductAlignmentPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_ProductAlignmentPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_ProductAlignmentPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002407 RID: 9223
		// (get) Token: 0x060074C0 RID: 29888 RVA: 0x0020A1D4 File Offset: 0x002083D4
		// (set) Token: 0x060074C1 RID: 29889 RVA: 0x00037B1B File Offset: 0x00035D1B
		public unsafe AudioSourceController SealSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_SealSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_SealSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002408 RID: 9224
		// (get) Token: 0x060074C2 RID: 29890 RVA: 0x0020A204 File Offset: 0x00208404
		// (set) Token: 0x060074C3 RID: 29891 RVA: 0x00037B3A File Offset: 0x00035D3A
		public unsafe List<FunctionalProduct> PackedProducts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_PackedProducts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FunctionalProduct>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_PackedProducts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002409 RID: 9225
		// (get) Token: 0x060074C4 RID: 29892 RVA: 0x0020A234 File Offset: 0x00208434
		// (set) Token: 0x060074C5 RID: 29893 RVA: 0x00037B59 File Offset: 0x00035D59
		public unsafe Action onFullyPacked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_onFullyPacked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_onFullyPacked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700240A RID: 9226
		// (get) Token: 0x060074C6 RID: 29894 RVA: 0x0020A264 File Offset: 0x00208464
		// (set) Token: 0x060074C7 RID: 29895 RVA: 0x00037B78 File Offset: 0x00035D78
		public unsafe Action onSealed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_onSealed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_onSealed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700240B RID: 9227
		// (get) Token: 0x060074C8 RID: 29896 RVA: 0x0020A294 File Offset: 0x00208494
		// (set) Token: 0x060074C9 RID: 29897 RVA: 0x00037B97 File Offset: 0x00035D97
		public unsafe Action onReachOutput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_onReachOutput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_onReachOutput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700240C RID: 9228
		// (get) Token: 0x060074CA RID: 29898 RVA: 0x0020A2C4 File Offset: 0x002084C4
		// (set) Token: 0x060074CB RID: 29899 RVA: 0x00037BB6 File Offset: 0x00035DB6
		public unsafe PackagingStation station
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_station);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_station), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700240D RID: 9229
		// (get) Token: 0x060074CC RID: 29900 RVA: 0x0020A2F4 File Offset: 0x002084F4
		// (set) Token: 0x060074CD RID: 29901 RVA: 0x00037BD5 File Offset: 0x00035DD5
		public unsafe Dictionary<FunctionalProduct, float> productContactTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_productContactTime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<FunctionalProduct, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_productContactTime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700240E RID: 9230
		// (get) Token: 0x060074CE RID: 29902 RVA: 0x0020A324 File Offset: 0x00208524
		// (set) Token: 0x060074CF RID: 29903 RVA: 0x00037BF4 File Offset: 0x00035DF4
		public unsafe SmoothedVelocityCalculator VelocityCalculator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_VelocityCalculator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmoothedVelocityCalculator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_VelocityCalculator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004F70 RID: 20336
		private static readonly IntPtr NativeFieldInfoPtr__IsSealed_k__BackingField;

		// Token: 0x04004F71 RID: 20337
		private static readonly IntPtr NativeFieldInfoPtr__IsFull_k__BackingField;

		// Token: 0x04004F72 RID: 20338
		private static readonly IntPtr NativeFieldInfoPtr__ReachedOutput_k__BackingField;

		// Token: 0x04004F73 RID: 20339
		private static readonly IntPtr NativeFieldInfoPtr_SealInstruction;

		// Token: 0x04004F74 RID: 20340
		private static readonly IntPtr NativeFieldInfoPtr_AutoEnableSealing;

		// Token: 0x04004F75 RID: 20341
		private static readonly IntPtr NativeFieldInfoPtr_ProductContactTime;

		// Token: 0x04004F76 RID: 20342
		private static readonly IntPtr NativeFieldInfoPtr_ProductContactMaxVelocity;

		// Token: 0x04004F77 RID: 20343
		private static readonly IntPtr NativeFieldInfoPtr_Definition;

		// Token: 0x04004F78 RID: 20344
		private static readonly IntPtr NativeFieldInfoPtr_AlignmentPoint;

		// Token: 0x04004F79 RID: 20345
		private static readonly IntPtr NativeFieldInfoPtr_ProductAlignmentPoints;

		// Token: 0x04004F7A RID: 20346
		private static readonly IntPtr NativeFieldInfoPtr_SealSound;

		// Token: 0x04004F7B RID: 20347
		private static readonly IntPtr NativeFieldInfoPtr_PackedProducts;

		// Token: 0x04004F7C RID: 20348
		private static readonly IntPtr NativeFieldInfoPtr_onFullyPacked;

		// Token: 0x04004F7D RID: 20349
		private static readonly IntPtr NativeFieldInfoPtr_onSealed;

		// Token: 0x04004F7E RID: 20350
		private static readonly IntPtr NativeFieldInfoPtr_onReachOutput;

		// Token: 0x04004F7F RID: 20351
		private static readonly IntPtr NativeFieldInfoPtr_station;

		// Token: 0x04004F80 RID: 20352
		private static readonly IntPtr NativeFieldInfoPtr_productContactTime;

		// Token: 0x04004F81 RID: 20353
		private static readonly IntPtr NativeFieldInfoPtr_VelocityCalculator;

		// Token: 0x04004F82 RID: 20354
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSealed_Public_get_Boolean_0;

		// Token: 0x04004F83 RID: 20355
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSealed_Protected_set_Void_Boolean_0;

		// Token: 0x04004F84 RID: 20356
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFull_Public_get_Boolean_0;

		// Token: 0x04004F85 RID: 20357
		private static readonly IntPtr NativeMethodInfoPtr_set_IsFull_Protected_set_Void_Boolean_0;

		// Token: 0x04004F86 RID: 20358
		private static readonly IntPtr NativeMethodInfoPtr_get_ReachedOutput_Public_get_Boolean_0;

		// Token: 0x04004F87 RID: 20359
		private static readonly IntPtr NativeMethodInfoPtr_set_ReachedOutput_Protected_set_Void_Boolean_0;

		// Token: 0x04004F88 RID: 20360
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_PackagingStation_Transform_Boolean_0;

		// Token: 0x04004F89 RID: 20361
		private static readonly IntPtr NativeMethodInfoPtr_AlignTo_Public_Void_Transform_0;

		// Token: 0x04004F8A RID: 20362
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0;

		// Token: 0x04004F8B RID: 20363
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_0;

		// Token: 0x04004F8C RID: 20364
		private static readonly IntPtr NativeMethodInfoPtr_PackProduct_Protected_Virtual_New_Void_FunctionalProduct_0;

		// Token: 0x04004F8D RID: 20365
		private static readonly IntPtr NativeMethodInfoPtr_FullyPacked_Protected_Virtual_New_Void_0;

		// Token: 0x04004F8E RID: 20366
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay_Protected_Virtual_New_Void_Collider_0;

		// Token: 0x04004F8F RID: 20367
		private static readonly IntPtr NativeMethodInfoPtr_EnableSealing_Protected_Virtual_New_Void_0;

		// Token: 0x04004F90 RID: 20368
		private static readonly IntPtr NativeMethodInfoPtr_Seal_Public_Virtual_New_Void_0;

		// Token: 0x04004F91 RID: 20369
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
