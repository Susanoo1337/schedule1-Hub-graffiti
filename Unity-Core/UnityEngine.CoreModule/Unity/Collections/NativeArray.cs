using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.InteropServices;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace Unity.Collections
{
	// Token: 0x0200003F RID: 63
	public sealed class NativeArray<T> : ValueType where T : new()
	{
		// Token: 0x060001FA RID: 506 RVA: 0x0001D1C0 File Offset: 0x0001B3C0
		// Note: this type is marked as 'beforefieldinit'.
		static NativeArray()
		{
			Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "NativeArray`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr);
			NativeArray<T>.NativeFieldInfoPtr_m_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, "m_Buffer");
			NativeArray<T>.NativeFieldInfoPtr_m_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, "m_Length");
			NativeArray<T>.NativeFieldInfoPtr_m_AllocatorLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, "m_AllocatorLabel");
			NativeArray<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_Allocator_NativeArrayOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663440);
			NativeArray<T>.NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663441);
			NativeArray<T>.NativeMethodInfoPtr__ctor_Public_Void_NativeArray_1_T_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663442);
			NativeArray<T>.NativeMethodInfoPtr_Allocate_Private_Static_Void_Int32_Allocator_byref_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663443);
			NativeArray<T>.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663444);
			NativeArray<T>.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663445);
			NativeArray<T>.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663446);
			NativeArray<T>.NativeMethodInfoPtr_get_IsCreated_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663447);
			NativeArray<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663448);
			NativeArray<T>.NativeMethodInfoPtr_Dispose_Public_JobHandle_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663449);
			NativeArray<T>.NativeMethodInfoPtr_CopyFrom_Public_Void_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663450);
			NativeArray<T>.NativeMethodInfoPtr_CopyFrom_Public_Void_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663451);
			NativeArray<T>.NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663452);
			NativeArray<T>.NativeMethodInfoPtr_ToArray_Public_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663453);
			NativeArray<T>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663454);
			NativeArray<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663455);
			NativeArray<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663456);
			NativeArray<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663457);
			NativeArray<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663458);
			NativeArray<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663459);
			NativeArray<T>.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_NativeArray_1_T_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663460);
			NativeArray<T>.NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663461);
			NativeArray<T>.NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppArrayBase_1_T_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663462);
			NativeArray<T>.NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663463);
			NativeArray<T>.NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_NativeArray_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663464);
			NativeArray<T>.NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663465);
			NativeArray<T>.NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_Int32_NativeArray_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663466);
			NativeArray<T>.NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_Int32_Il2CppArrayBase_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663467);
			NativeArray<T>.NativeMethodInfoPtr_CopySafe_Private_Static_Void_NativeArray_1_T_Int32_NativeArray_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663468);
			NativeArray<T>.NativeMethodInfoPtr_CopySafe_Private_Static_Void_Il2CppArrayBase_1_T_Int32_NativeArray_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663469);
			NativeArray<T>.NativeMethodInfoPtr_CopySafe_Private_Static_Void_NativeArray_1_T_Int32_Il2CppArrayBase_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663470);
			NativeArray<T>.NativeMethodInfoPtr_InternalReinterpret_Private_NativeArray_1_U_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663471);
			NativeArray<T>.NativeMethodInfoPtr_Reinterpret_Public_NativeArray_1_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663472);
			NativeArray<T>.NativeMethodInfoPtr_Reinterpret_Public_NativeArray_1_U_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663473);
			NativeArray<T>.NativeMethodInfoPtr_GetSubArray_Public_NativeArray_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663474);
			NativeArray<T>.NativeMethodInfoPtr_AsReadOnly_Public_ReadOnly_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663475);
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0001D538 File Offset: 0x0001B738
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1225530, RefRangeEnd = 1225531, XrefRangeStart = 1225526, XrefRangeEnd = 1225530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeArray(int length, Allocator allocator, NativeArrayOptions options = NativeArrayOptions.ClearMemory) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref length;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allocator;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_Allocator_NativeArrayOptions_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0001D5A0 File Offset: 0x0001B7A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225531, XrefRangeEnd = 1225535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeArray(Il2CppArrayBase<T> array, Allocator allocator) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allocator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_Allocator_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0001D600 File Offset: 0x0001B800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225535, XrefRangeEnd = 1225547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeArray(NativeArray<T> array, Allocator allocator) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(array));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allocator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr__ctor_Public_Void_NativeArray_1_T_Allocator_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0001D664 File Offset: 0x0001B864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225547, XrefRangeEnd = 1225551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Allocate(int length, Allocator allocator, out NativeArray<T> array)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref length;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allocator;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_Allocate_Private_Static_Void_Int32_Allocator_byref_NativeArray_1_T_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			array = ((intPtr4 == 0) ? null : new NativeArray<T>(intPtr4));
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001FF RID: 511 RVA: 0x0001D6C8 File Offset: 0x0001B8C8
		public unsafe int Length
		{
			[CallerCount(29)]
			[CachedScanResults(RefRangeStart = 1222651, RefRangeEnd = 1222680, XrefRangeStart = 1222651, XrefRangeEnd = 1222680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000081 RID: 129
		public unsafe T this[int index]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225551, XrefRangeEnd = 1225552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref index;
				IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
				T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					if (!(t is string))
					{
						ref T ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
						if (ref ptr3 != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref value;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000202 RID: 514 RVA: 0x0001D7F8 File Offset: 0x0001B9F8
		public unsafe bool IsCreated
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 1029970, RefRangeEnd = 1029994, XrefRangeStart = 1029970, XrefRangeEnd = 1029994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_get_IsCreated_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0001D83C File Offset: 0x0001BA3C
		[CallerCount(174)]
		[CachedScanResults(RefRangeStart = 1225554, RefRangeEnd = 1225728, XrefRangeStart = 1225552, XrefRangeEnd = 1225554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0001D874 File Offset: 0x0001BA74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225728, XrefRangeEnd = 1225730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle inputDeps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref inputDeps;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_Dispose_Public_JobHandle_JobHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0001D8C4 File Offset: 0x0001BAC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225730, XrefRangeEnd = 1225732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyFrom(Il2CppArrayBase<T> array)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_CopyFrom_Public_Void_Il2CppArrayBase_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0001D90C File Offset: 0x0001BB0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225732, XrefRangeEnd = 1225740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyFrom(NativeArray<T> array)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(array));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_CopyFrom_Public_Void_NativeArray_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0001D958 File Offset: 0x0001BB58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225740, XrefRangeEnd = 1225750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyTo(Il2CppArrayBase<T> array)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppArrayBase_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0001D9A0 File Offset: 0x0001BBA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225750, XrefRangeEnd = 1225763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> ToArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_ToArray_Public_Il2CppArrayBase_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0001D9DC File Offset: 0x0001BBDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225763, XrefRangeEnd = 1225765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeArray<T>.Enumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativeArray<T>.Enumerator(pointer);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0001DA18 File Offset: 0x0001BC18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225765, XrefRangeEnd = 1225769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0001DA5C File Offset: 0x0001BC5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225769, XrefRangeEnd = 1225773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0001DAA0 File Offset: 0x0001BCA0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1225773, RefRangeEnd = 1225776, XrefRangeStart = 1225773, XrefRangeEnd = 1225773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(NativeArray<T> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_NativeArray_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0001DAF8 File Offset: 0x0001BCF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225776, XrefRangeEnd = 1225782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0001DB4C File Offset: 0x0001BD4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1225782, RefRangeEnd = 1225783, XrefRangeStart = 1225782, XrefRangeEnd = 1225782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0001DB90 File Offset: 0x0001BD90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1225784, RefRangeEnd = 1225786, XrefRangeStart = 1225783, XrefRangeEnd = 1225784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(NativeArray<T> left, NativeArray<T> right)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_NativeArray_1_T_NativeArray_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0001DBF0 File Offset: 0x0001BDF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225786, XrefRangeEnd = 1225793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy(NativeArray<T> src, NativeArray<T> dst)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(src));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dst));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_NativeArray_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0001DC44 File Offset: 0x0001BE44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225793, XrefRangeEnd = 1225802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy(Il2CppArrayBase<T> src, NativeArray<T> dst)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dst));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppArrayBase_1_T_NativeArray_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0001DC94 File Offset: 0x0001BE94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225802, XrefRangeEnd = 1225811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy(NativeArray<T> src, Il2CppArrayBase<T> dst)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(src));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dst);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_Il2CppArrayBase_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0001DCE4 File Offset: 0x0001BEE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225811, XrefRangeEnd = 1225818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy(NativeArray<T> src, NativeArray<T> dst, int length)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(src));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dst));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_NativeArray_1_T_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0001DD44 File Offset: 0x0001BF44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225818, XrefRangeEnd = 1225827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy(NativeArray<T> src, Il2CppArrayBase<T> dst, int length)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(src));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dst);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_Il2CppArrayBase_1_T_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0001DDA0 File Offset: 0x0001BFA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225827, XrefRangeEnd = 1225834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy(NativeArray<T> src, int srcIndex, NativeArray<T> dst, int dstIndex, int length)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(src));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dst));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_Int32_NativeArray_1_T_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0001DE1C File Offset: 0x0001C01C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225834, XrefRangeEnd = 1225836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy(NativeArray<T> src, int srcIndex, Il2CppArrayBase<T> dst, int dstIndex, int length)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(src));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dst);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_Int32_Il2CppArrayBase_1_T_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0001DE94 File Offset: 0x0001C094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225836, XrefRangeEnd = 1225840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopySafe(NativeArray<T> src, int srcIndex, NativeArray<T> dst, int dstIndex, int length)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(src));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dst));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_CopySafe_Private_Static_Void_NativeArray_1_T_Int32_NativeArray_1_T_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0001DF10 File Offset: 0x0001C110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225840, XrefRangeEnd = 1225848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopySafe(Il2CppArrayBase<T> src, int srcIndex, NativeArray<T> dst, int dstIndex, int length)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dst));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_CopySafe_Private_Static_Void_Il2CppArrayBase_1_T_Int32_NativeArray_1_T_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0001DF88 File Offset: 0x0001C188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225848, XrefRangeEnd = 1225856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopySafe(NativeArray<T> src, int srcIndex, Il2CppArrayBase<T> dst, int dstIndex, int length)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(src));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dst);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_CopySafe_Private_Static_Void_NativeArray_1_T_Int32_Il2CppArrayBase_1_T_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0001E000 File Offset: 0x0001C200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225856, XrefRangeEnd = 1225858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeArray<U> InternalReinterpret<U>(int length) where U : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref length;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeArray.MethodInfoStoreGeneric_InternalReinterpret_Private_NativeArray_1_U_Int32_0<U>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativeArray<U>(pointer);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0001E04C File Offset: 0x0001C24C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1225861, RefRangeEnd = 1225867, XrefRangeStart = 1225858, XrefRangeEnd = 1225861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeArray<U> Reinterpret<U>() where U : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeArray.MethodInfoStoreGeneric_Reinterpret_Public_NativeArray_1_U_0<U>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativeArray<U>(pointer);
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0001E088 File Offset: 0x0001C288
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1225871, RefRangeEnd = 1225872, XrefRangeStart = 1225867, XrefRangeEnd = 1225871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeArray<U> Reinterpret<U>(int expectedTypeSize) where U : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref expectedTypeSize;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeArray.MethodInfoStoreGeneric_Reinterpret_Public_NativeArray_1_U_Int32_0<U>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativeArray<U>(pointer);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0001E0D4 File Offset: 0x0001C2D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225872, XrefRangeEnd = 1225875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeArray<T> GetSubArray(int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_GetSubArray_Public_NativeArray_1_T_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativeArray<T>(pointer);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0001E12C File Offset: 0x0001C32C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1225877, RefRangeEnd = 1225879, XrefRangeStart = 1225875, XrefRangeEnd = 1225877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeArray<T>.ReadOnly AsReadOnly()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_AsReadOnly_Public_ReadOnly_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativeArray<T>.ReadOnly(pointer);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0000316A File Offset: 0x0000136A
		public NativeArray(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00003173 File Offset: 0x00001373
		public NativeArray() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr))
		{
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000221 RID: 545 RVA: 0x0001E168 File Offset: 0x0001C368
		// (set) Token: 0x06000222 RID: 546 RVA: 0x00003185 File Offset: 0x00001385
		public unsafe void* m_Buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.NativeFieldInfoPtr_m_Buffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.NativeFieldInfoPtr_m_Buffer)) = value;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000223 RID: 547 RVA: 0x0001E18C File Offset: 0x0001C38C
		// (set) Token: 0x06000224 RID: 548 RVA: 0x000031A0 File Offset: 0x000013A0
		public unsafe int m_Length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.NativeFieldInfoPtr_m_Length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.NativeFieldInfoPtr_m_Length)) = value;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000225 RID: 549 RVA: 0x0001E1B4 File Offset: 0x0001C3B4
		// (set) Token: 0x06000226 RID: 550 RVA: 0x000031BB File Offset: 0x000013BB
		public unsafe Allocator m_AllocatorLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.NativeFieldInfoPtr_m_AllocatorLabel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.NativeFieldInfoPtr_m_AllocatorLabel)) = value;
			}
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0001E1DC File Offset: 0x0001C3DC
		public static void CheckAllocateArguments(int length, Allocator allocator)
		{
			bool flag = allocator <= Allocator.None;
			if (flag)
			{
				throw new ArgumentException("Allocator must be Temp, TempJob or Persistent", "allocator");
			}
			bool flag2 = allocator >= Allocator.FirstUserIndex;
			if (flag2)
			{
				throw new ArgumentException("Use CollectionHelper.CreateNativeArray for custom allocator", "allocator");
			}
			bool flag3 = length < 0;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException("length", "Length must be >= 0");
			}
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0001E23C File Offset: 0x0001C43C
		public static void IsUnmanagedAndThrow()
		{
			bool flag = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsUnmanaged<T>();
			if (flag)
			{
				throw new InvalidOperationException(String.Format("{0} used in NativeArray<{1}> must be unmanaged (contain no managed types).", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
			}
		}

		// Token: 0x06000229 RID: 553 RVA: 0x000031D6 File Offset: 0x000013D6
		public void CheckElementReadAccess(int index)
		{
		}

		// Token: 0x0600022A RID: 554 RVA: 0x000031D9 File Offset: 0x000013D9
		public void CheckElementWriteAccess(int index)
		{
		}

		// Token: 0x0600022B RID: 555 RVA: 0x000031DC File Offset: 0x000013DC
		public unsafe void CopyTo(NativeArray<T> array)
		{
			NativeArray<T>.Copy(*this, array);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0001E27C File Offset: 0x0001C47C
		public static bool operator !=(NativeArray<T> left, NativeArray<T> right)
		{
			return !left.Equals(right);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x000031EC File Offset: 0x000013EC
		public static void Copy(NativeArray<T>.ReadOnly src, NativeArray<T> dst)
		{
			NativeArray<T>.CopySafe(src, 0, dst, 0, src.Length);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00003200 File Offset: 0x00001400
		public static void Copy(NativeArray<T>.ReadOnly src, Il2CppArrayBase<T> dst)
		{
			NativeArray<T>.CopySafe(src, 0, dst, 0, src.Length);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00003214 File Offset: 0x00001414
		public static void Copy(NativeArray<T>.ReadOnly src, NativeArray<T> dst, int length)
		{
			NativeArray<T>.CopySafe(src, 0, dst, 0, length);
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00003222 File Offset: 0x00001422
		public static void Copy(Il2CppArrayBase<T> src, NativeArray<T> dst, int length)
		{
			NativeArray<T>.CopySafe(src, 0, dst, 0, length);
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00003230 File Offset: 0x00001430
		public static void Copy(NativeArray<T>.ReadOnly src, Il2CppArrayBase<T> dst, int length)
		{
			NativeArray<T>.CopySafe(src, 0, dst, 0, length);
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0000323E File Offset: 0x0000143E
		public static void Copy(NativeArray<T>.ReadOnly src, int srcIndex, NativeArray<T> dst, int dstIndex, int length)
		{
			NativeArray<T>.CopySafe(src, srcIndex, dst, dstIndex, length);
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0000324D File Offset: 0x0000144D
		public static void Copy(Il2CppArrayBase<T> src, int srcIndex, NativeArray<T> dst, int dstIndex, int length)
		{
			NativeArray<T>.CopySafe(src, srcIndex, dst, dstIndex, length);
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0000325C File Offset: 0x0000145C
		public static void Copy(NativeArray<T>.ReadOnly src, int srcIndex, Il2CppArrayBase<T> dst, int dstIndex, int length)
		{
			NativeArray<T>.CopySafe(src, srcIndex, dst, dstIndex, length);
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0000326B File Offset: 0x0000146B
		public unsafe static void CopySafe(NativeArray<T>.ReadOnly src, int srcIndex, NativeArray<T> dst, int dstIndex, int length)
		{
			Unity.Collections.LowLevel.Unsafe.UnsafeUtility.MemCpy((void*)((byte*)dst.m_Buffer + dstIndex * Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>()), (void*)((byte*)src.m_Buffer + srcIndex * Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>()), (long)(length * Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>()));
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0001E29C File Offset: 0x0001C49C
		public unsafe static void CopySafe(NativeArray<T>.ReadOnly src, int srcIndex, Il2CppArrayBase<T> dst, int dstIndex, int length)
		{
			GCHandle gchandle = GCHandle.Alloc(dst, GCHandleType.Pinned);
			IntPtr value = gchandle.AddrOfPinnedObject();
			Unity.Collections.LowLevel.Unsafe.UnsafeUtility.MemCpy((void*)((byte*)((void*)value) + dstIndex * Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>()), (void*)((byte*)src.m_Buffer + srcIndex * Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>()), (long)(length * Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>()));
			gchandle.Free();
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0001E2F0 File Offset: 0x0001C4F0
		public static void CheckCopyPtr(Il2CppArrayBase<T> ptr)
		{
			bool flag = ptr == null;
			if (flag)
			{
				throw new ArgumentNullException("ptr");
			}
		}

		// Token: 0x06000238 RID: 568 RVA: 0x0001E314 File Offset: 0x0001C514
		public static void CheckCopyLengths(int srcLength, int dstLength)
		{
			bool flag = srcLength != dstLength;
			if (flag)
			{
				throw new ArgumentException("source and destination length must be the same");
			}
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0001E338 File Offset: 0x0001C538
		public static void CheckCopyArguments(int srcLength, int srcIndex, int dstLength, int dstIndex, int length)
		{
			bool flag = length < 0;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("length", "length must be equal or greater than zero.");
			}
			bool flag2 = srcIndex < 0 || srcIndex > srcLength || (srcIndex == srcLength && srcLength > 0);
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("srcIndex", "srcIndex is outside the range of valid indexes for the source NativeArray.");
			}
			bool flag3 = dstIndex < 0 || dstIndex > dstLength || (dstIndex == dstLength && dstLength > 0);
			if (flag3)
			{
				throw new ArgumentOutOfRangeException("dstIndex", "dstIndex is outside the range of valid indexes for the destination NativeArray.");
			}
			bool flag4 = srcIndex + length > srcLength;
			if (flag4)
			{
				throw new ArgumentException("length is greater than the number of elements from srcIndex to the end of the source NativeArray.", "length");
			}
			bool flag5 = srcIndex + length < 0;
			if (flag5)
			{
				throw new ArgumentException("srcIndex + length causes an integer overflow");
			}
			bool flag6 = dstIndex + length > dstLength;
			if (flag6)
			{
				throw new ArgumentException("length is greater than the number of elements from dstIndex to the end of the destination NativeArray.", "length");
			}
			bool flag7 = dstIndex + length < 0;
			if (flag7)
			{
				throw new ArgumentException("dstIndex + length causes an integer overflow");
			}
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00003299 File Offset: 0x00001499
		public void CheckReinterpretLoadRange<U>(int sourceIndex) where U : struct
		{
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0000329C File Offset: 0x0000149C
		public void CheckReinterpretStoreRange<U>(int destIndex) where U : struct
		{
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0001E41C File Offset: 0x0001C61C
		public unsafe U ReinterpretLoad<U>(int sourceIndex) where U : struct
		{
			byte* source = (byte*)this.m_Buffer + (long)Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>() * (long)sourceIndex;
			return Unity.Collections.LowLevel.Unsafe.UnsafeUtility.ReadArrayElement<U>((void*)source, 0);
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0001E448 File Offset: 0x0001C648
		public unsafe void ReinterpretStore<U>(int destIndex, U data) where U : struct
		{
			byte* destination = (byte*)this.m_Buffer + (long)Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>() * (long)destIndex;
			Unity.Collections.LowLevel.Unsafe.UnsafeUtility.WriteArrayElement<U>((void*)destination, 0, data);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0001E474 File Offset: 0x0001C674
		public static void CheckReinterpretSize<U>() where U : struct
		{
			bool flag = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>() != Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<U>();
			if (flag)
			{
				throw new InvalidOperationException(String.Format("Types {0} and {1} are different sizes - direct reinterpretation is not possible. If this is what you intended, use Reinterpret(<type size>)", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<U>())));
			}
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0001E4BC File Offset: 0x0001C6BC
		public void CheckReinterpretSize<U>(long tSize, long uSize, int expectedTypeSize, long byteLen, long uLen)
		{
			bool flag = tSize != (long)expectedTypeSize;
			if (flag)
			{
				throw new InvalidOperationException(String.Format("Type {0} was expected to be {1} but is {2} bytes", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), expectedTypeSize, tSize));
			}
			bool flag2 = uLen * uSize != byteLen;
			if (flag2)
			{
				throw new InvalidOperationException(String.Format("Types {0} (array length {1}) and {2} cannot be aliased due to size constraints. The size of the types and lengths involved must line up.", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), this.Length, Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<U>())));
			}
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0001E53C File Offset: 0x0001C73C
		public void CheckGetSubArrayArguments(int start, int length)
		{
			bool flag = start < 0;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("start", "start must be >= 0");
			}
			bool flag2 = start + length > this.Length;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("length", String.Format("sub array range {0}-{1} is outside the range of the native array 0-{2}", start, start + length - 1, this.Length - 1));
			}
			bool flag3 = start + length < 0;
			if (flag3)
			{
				throw new ArgumentException(String.Format("sub array range {0}-{1} caused an integer overflow and is outside the range of the native array 0-{2}", start, start + length - 1, this.Length - 1));
			}
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0001E5E0 File Offset: 0x0001C7E0
		public Span<T> AsSpan()
		{
			return new Span<T>(this.m_Buffer, this.m_Length);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0001E604 File Offset: 0x0001C804
		public ReadOnlySpan<T> AsReadOnlySpan()
		{
			return new ReadOnlySpan<T>(this.m_Buffer, this.m_Length);
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0001E628 File Offset: 0x0001C828
		public static implicit operator Span<T>([In] ref NativeArray<T> source)
		{
			return source.AsSpan();
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0001E640 File Offset: 0x0001C840
		public static implicit operator ReadOnlySpan<T>([In] ref NativeArray<T> source)
		{
			return source.AsReadOnlySpan();
		}

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeFieldInfoPtr_m_Buffer;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeFieldInfoPtr_m_Length;

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeFieldInfoPtr_m_AllocatorLabel;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Allocator_NativeArrayOptions_0;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_Allocator_0;

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NativeArray_1_T_Allocator_0;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeMethodInfoPtr_Allocate_Private_Static_Void_Int32_Allocator_byref_NativeArray_1_T_0;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_T_0;

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCreated_Public_get_Boolean_0;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_JobHandle_JobHandle_0;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Void_Il2CppArrayBase_1_T_0;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Void_NativeArray_1_T_0;

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppArrayBase_1_T_0;

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeMethodInfoPtr_ToArray_Public_Il2CppArrayBase_1_T_0;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0;

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_NativeArray_1_T_0;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_NativeArray_1_T_NativeArray_1_T_0;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_NativeArray_1_T_0;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppArrayBase_1_T_NativeArray_1_T_0;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_Il2CppArrayBase_1_T_0;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_NativeArray_1_T_Int32_0;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_Int32_NativeArray_1_T_Int32_Int32_0;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_Int32_Il2CppArrayBase_1_T_Int32_Int32_0;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeMethodInfoPtr_CopySafe_Private_Static_Void_NativeArray_1_T_Int32_NativeArray_1_T_Int32_Int32_0;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeMethodInfoPtr_CopySafe_Private_Static_Void_Il2CppArrayBase_1_T_Int32_NativeArray_1_T_Int32_Int32_0;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeMethodInfoPtr_CopySafe_Private_Static_Void_NativeArray_1_T_Int32_Il2CppArrayBase_1_T_Int32_Int32_0;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeMethodInfoPtr_InternalReinterpret_Private_NativeArray_1_U_Int32_0;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeMethodInfoPtr_Reinterpret_Public_NativeArray_1_U_0;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeMethodInfoPtr_Reinterpret_Public_NativeArray_1_U_Int32_0;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeMethodInfoPtr_GetSubArray_Public_NativeArray_1_T_Int32_Int32_0;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeMethodInfoPtr_AsReadOnly_Public_ReadOnly_T_0;

		// Token: 0x020003BC RID: 956
		public sealed class Enumerator : ValueType
		{
			// Token: 0x06003003 RID: 12291 RVA: 0x000AE4BC File Offset: 0x000AC6BC
			// Note: this type is marked as 'beforefieldinit'.
			static Enumerator()
			{
				Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, "Enumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr);
				NativeArray<T>.Enumerator.NativeFieldInfoPtr_m_Array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr, "m_Array");
				NativeArray<T>.Enumerator.NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr, "m_Index");
				NativeArray<T>.Enumerator.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr, "value");
				NativeArray<T>.Enumerator.NativeMethodInfoPtr__ctor_Public_Void_byref_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr, 100663476);
				NativeArray<T>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr, 100663477);
				NativeArray<T>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr, 100663478);
				NativeArray<T>.Enumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr, 100663479);
				NativeArray<T>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr, 100663480);
				NativeArray<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr, 100663481);
			}

			// Token: 0x06003004 RID: 12292 RVA: 0x000AE5D8 File Offset: 0x000AC7D8
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1225513, RefRangeEnd = 1225516, XrefRangeStart = 1225513, XrefRangeEnd = 1225513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Enumerator(ref NativeArray<T> array) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(array));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.Enumerator.NativeMethodInfoPtr__ctor_Public_Void_byref_NativeArray_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003005 RID: 12293 RVA: 0x000AE630 File Offset: 0x000AC830
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003006 RID: 12294 RVA: 0x000AE668 File Offset: 0x000AC868
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003007 RID: 12295 RVA: 0x000AE6AC File Offset: 0x000AC8AC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 428162, RefRangeEnd = 428164, XrefRangeStart = 428162, XrefRangeEnd = 428164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.Enumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170009F7 RID: 2551
			// (get) Token: 0x06003008 RID: 12296 RVA: 0x000AE6E4 File Offset: 0x000AC8E4
			public unsafe T Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x170009F8 RID: 2552
			// (get) Token: 0x06003009 RID: 12297 RVA: 0x000AE724 File Offset: 0x000AC924
			public unsafe Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225516, XrefRangeEnd = 1225519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600300A RID: 12298 RVA: 0x0001572C File Offset: 0x0001392C
			public Enumerator(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600300B RID: 12299 RVA: 0x00015735 File Offset: 0x00013935
			public Enumerator() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr))
			{
			}

			// Token: 0x170009F4 RID: 2548
			// (get) Token: 0x0600300C RID: 12300 RVA: 0x000AE768 File Offset: 0x000AC968
			// (set) Token: 0x0600300D RID: 12301 RVA: 0x00015747 File Offset: 0x00013947
			public NativeArray<T> m_Array
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.Enumerator.NativeFieldInfoPtr_m_Array);
					return new NativeArray<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.Enumerator.NativeFieldInfoPtr_m_Array), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170009F5 RID: 2549
			// (get) Token: 0x0600300E RID: 12302 RVA: 0x000AE798 File Offset: 0x000AC998
			// (set) Token: 0x0600300F RID: 12303 RVA: 0x00015775 File Offset: 0x00013975
			public unsafe int m_Index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.Enumerator.NativeFieldInfoPtr_m_Index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.Enumerator.NativeFieldInfoPtr_m_Index)) = value;
				}
			}

			// Token: 0x170009F6 RID: 2550
			// (get) Token: 0x06003010 RID: 12304 RVA: 0x000AE7C0 File Offset: 0x000AC9C0
			// (set) Token: 0x06003011 RID: 12305 RVA: 0x000AE7E8 File Offset: 0x000AC9E8
			public unsafe T value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.Enumerator.NativeFieldInfoPtr_value);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.Enumerator.NativeFieldInfoPtr_value);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase);
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x040029DC RID: 10716
			private static readonly IntPtr NativeFieldInfoPtr_m_Array;

			// Token: 0x040029DD RID: 10717
			private static readonly IntPtr NativeFieldInfoPtr_m_Index;

			// Token: 0x040029DE RID: 10718
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x040029DF RID: 10719
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_NativeArray_1_T_0;

			// Token: 0x040029E0 RID: 10720
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x040029E1 RID: 10721
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x040029E2 RID: 10722
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

			// Token: 0x040029E3 RID: 10723
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0;

			// Token: 0x040029E4 RID: 10724
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020003BD RID: 957
		public sealed class ReadOnly : ValueType
		{
			// Token: 0x06003012 RID: 12306 RVA: 0x000AE890 File Offset: 0x000ACA90
			// Note: this type is marked as 'beforefieldinit'.
			static ReadOnly()
			{
				Il2CppClassPointerStore<NativeArray<T>.ReadOnly>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, "ReadOnly"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeArray<T>.ReadOnly>.NativeClassPtr);
				NativeArray<T>.ReadOnly.NativeFieldInfoPtr_m_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArray<T>.ReadOnly>.NativeClassPtr, "m_Buffer");
				NativeArray<T>.ReadOnly.NativeFieldInfoPtr_m_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArray<T>.ReadOnly>.NativeClassPtr, "m_Length");
				NativeArray<T>.ReadOnly.NativeMethodInfoPtr__ctor_Internal_Void_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.ReadOnly>.NativeClassPtr, 100663482);
				NativeArray<T>.ReadOnly.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.ReadOnly>.NativeClassPtr, 100663483);
				NativeArray<T>.ReadOnly.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.ReadOnly>.NativeClassPtr, 100663484);
				NativeArray<T>.ReadOnly.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.ReadOnly>.NativeClassPtr, 100663485);
				NativeArray<T>.ReadOnly.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.ReadOnly>.NativeClassPtr, 100663486);
				NativeArray<T>.ReadOnly.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.ReadOnly>.NativeClassPtr, 100663487);
			}

			// Token: 0x06003013 RID: 12307 RVA: 0x000AE998 File Offset: 0x000ACB98
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 504942, RefRangeEnd = 504946, XrefRangeStart = 504942, XrefRangeEnd = 504946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReadOnly(void* buffer, int length) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeArray<T>.ReadOnly>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = buffer;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.ReadOnly.NativeMethodInfoPtr__ctor_Internal_Void_ptr_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170009FB RID: 2555
			// (get) Token: 0x06003014 RID: 12308 RVA: 0x000AE9F4 File Offset: 0x000ACBF4
			public unsafe int Length
			{
				[CallerCount(29)]
				[CachedScanResults(RefRangeStart = 1222651, RefRangeEnd = 1222680, XrefRangeStart = 1222651, XrefRangeEnd = 1222680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.ReadOnly.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170009FC RID: 2556
			public unsafe T this[int index]
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225519, XrefRangeEnd = 1225520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.ReadOnly.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x06003016 RID: 12310 RVA: 0x000AEA84 File Offset: 0x000ACC84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225520, XrefRangeEnd = 1225522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NativeArray<T>.ReadOnly.Enumerator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.ReadOnly.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new NativeArray<T>.ReadOnly.Enumerator(pointer);
			}

			// Token: 0x06003017 RID: 12311 RVA: 0x000AEAC0 File Offset: 0x000ACCC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225522, XrefRangeEnd = 1225526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.ReadOnly.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
			}

			// Token: 0x06003018 RID: 12312 RVA: 0x000AEB04 File Offset: 0x000ACD04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.ReadOnly.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06003019 RID: 12313 RVA: 0x00015790 File Offset: 0x00013990
			public ReadOnly(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600301A RID: 12314 RVA: 0x00015799 File Offset: 0x00013999
			public ReadOnly() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeArray<T>.ReadOnly>.NativeClassPtr))
			{
			}

			// Token: 0x170009F9 RID: 2553
			// (get) Token: 0x0600301B RID: 12315 RVA: 0x000AEB48 File Offset: 0x000ACD48
			// (set) Token: 0x0600301C RID: 12316 RVA: 0x000157AB File Offset: 0x000139AB
			public unsafe void* m_Buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.ReadOnly.NativeFieldInfoPtr_m_Buffer);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.ReadOnly.NativeFieldInfoPtr_m_Buffer)) = value;
				}
			}

			// Token: 0x170009FA RID: 2554
			// (get) Token: 0x0600301D RID: 12317 RVA: 0x000AEB6C File Offset: 0x000ACD6C
			// (set) Token: 0x0600301E RID: 12318 RVA: 0x000157C6 File Offset: 0x000139C6
			public unsafe int m_Length
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.ReadOnly.NativeFieldInfoPtr_m_Length);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.ReadOnly.NativeFieldInfoPtr_m_Length)) = value;
				}
			}

			// Token: 0x040029E5 RID: 10725
			private static readonly IntPtr NativeFieldInfoPtr_m_Buffer;

			// Token: 0x040029E6 RID: 10726
			private static readonly IntPtr NativeFieldInfoPtr_m_Length;

			// Token: 0x040029E7 RID: 10727
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ptr_Void_Int32_0;

			// Token: 0x040029E8 RID: 10728
			private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

			// Token: 0x040029E9 RID: 10729
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0;

			// Token: 0x040029EA RID: 10730
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0;

			// Token: 0x040029EB RID: 10731
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;

			// Token: 0x040029EC RID: 10732
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x02000D46 RID: 3398
			public sealed class Enumerator : ValueType
			{
				// Token: 0x06004326 RID: 17190 RVA: 0x000B6798 File Offset: 0x000B4998
				// Note: this type is marked as 'beforefieldinit'.
				static Enumerator()
				{
					Il2CppClassPointerStore<NativeArray<T>.ReadOnly.Enumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NativeArray<T>.ReadOnly>.NativeClassPtr, "Enumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
					{
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
					})).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeArray<T>.ReadOnly.Enumerator>.NativeClassPtr);
					NativeArray<T>.ReadOnly.Enumerator.NativeFieldInfoPtr_m_Array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArray<T>.ReadOnly.Enumerator>.NativeClassPtr, "m_Array");
					NativeArray<T>.ReadOnly.Enumerator.NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArray<T>.ReadOnly.Enumerator>.NativeClassPtr, "m_Index");
					NativeArray<T>.ReadOnly.Enumerator.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArray<T>.ReadOnly.Enumerator>.NativeClassPtr, "value");
					NativeArray<T>.ReadOnly.Enumerator.NativeMethodInfoPtr__ctor_Public_Void_byref_ReadOnly_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.ReadOnly.Enumerator>.NativeClassPtr, 100663488);
					NativeArray<T>.ReadOnly.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.ReadOnly.Enumerator>.NativeClassPtr, 100663489);
					NativeArray<T>.ReadOnly.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.ReadOnly.Enumerator>.NativeClassPtr, 100663490);
					NativeArray<T>.ReadOnly.Enumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.ReadOnly.Enumerator>.NativeClassPtr, 100663491);
					NativeArray<T>.ReadOnly.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.ReadOnly.Enumerator>.NativeClassPtr, 100663492);
					NativeArray<T>.ReadOnly.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.ReadOnly.Enumerator>.NativeClassPtr, 100663493);
				}

				// Token: 0x06004327 RID: 17191 RVA: 0x000B68B4 File Offset: 0x000B4AB4
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 1225513, RefRangeEnd = 1225516, XrefRangeStart = 1225513, XrefRangeEnd = 1225516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Enumerator([In] ref NativeArray<T>.ReadOnly array) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeArray<T>.ReadOnly.Enumerator>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(array));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.ReadOnly.Enumerator.NativeMethodInfoPtr__ctor_Public_Void_byref_ReadOnly_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06004328 RID: 17192 RVA: 0x000B690C File Offset: 0x000B4B0C
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.ReadOnly.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06004329 RID: 17193 RVA: 0x000B6944 File Offset: 0x000B4B44
				[CallerCount(0)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.ReadOnly.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600432A RID: 17194 RVA: 0x000B6988 File Offset: 0x000B4B88
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 428162, RefRangeEnd = 428164, XrefRangeStart = 428162, XrefRangeEnd = 428164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.ReadOnly.Enumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17000A3B RID: 2619
				// (get) Token: 0x0600432B RID: 17195 RVA: 0x000B69C0 File Offset: 0x000B4BC0
				public unsafe T Current
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.ReadOnly.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
					}
				}

				// Token: 0x17000A3C RID: 2620
				// (get) Token: 0x0600432C RID: 17196 RVA: 0x000B6A00 File Offset: 0x000B4C00
				public unsafe Object Current
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.ReadOnly.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600432D RID: 17197 RVA: 0x00018852 File Offset: 0x00016A52
				public Enumerator(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x0600432E RID: 17198 RVA: 0x0001885B File Offset: 0x00016A5B
				public Enumerator() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeArray<T>.ReadOnly.Enumerator>.NativeClassPtr))
				{
				}

				// Token: 0x17000A38 RID: 2616
				// (get) Token: 0x0600432F RID: 17199 RVA: 0x000B6A44 File Offset: 0x000B4C44
				// (set) Token: 0x06004330 RID: 17200 RVA: 0x0001886D File Offset: 0x00016A6D
				public NativeArray<T>.ReadOnly m_Array
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.ReadOnly.Enumerator.NativeFieldInfoPtr_m_Array);
						return new NativeArray<T>.ReadOnly(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<T>.ReadOnly>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.ReadOnly.Enumerator.NativeFieldInfoPtr_m_Array), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<T>.ReadOnly>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17000A39 RID: 2617
				// (get) Token: 0x06004331 RID: 17201 RVA: 0x000B6A74 File Offset: 0x000B4C74
				// (set) Token: 0x06004332 RID: 17202 RVA: 0x0001889B File Offset: 0x00016A9B
				public unsafe int m_Index
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.ReadOnly.Enumerator.NativeFieldInfoPtr_m_Index);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.ReadOnly.Enumerator.NativeFieldInfoPtr_m_Index)) = value;
					}
				}

				// Token: 0x17000A3A RID: 2618
				// (get) Token: 0x06004333 RID: 17203 RVA: 0x000B6A9C File Offset: 0x000B4C9C
				// (set) Token: 0x06004334 RID: 17204 RVA: 0x000B6AC4 File Offset: 0x000B4CC4
				public unsafe T value
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.ReadOnly.Enumerator.NativeFieldInfoPtr_value);
						return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.ReadOnly.Enumerator.NativeFieldInfoPtr_value);
						Type typeFromHandle = typeof(T);
						if (!typeFromHandle.IsValueType)
						{
							if (!string.Equals(typeFromHandle.FullName, "System.String"))
							{
								IntPtr intPtr4;
								IntPtr intPtr3 = intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase);
								if (intPtr3 != 0)
								{
									intPtr4 = intPtr3;
									if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
									{
										IntPtr intPtr5 = intPtr3;
										cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
										return;
									}
								}
								IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
							}
							else
							{
								IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
							}
						}
						else
						{
							*intPtr2 = value;
						}
					}
				}

				// Token: 0x04002C99 RID: 11417
				private static readonly IntPtr NativeFieldInfoPtr_m_Array;

				// Token: 0x04002C9A RID: 11418
				private static readonly IntPtr NativeFieldInfoPtr_m_Index;

				// Token: 0x04002C9B RID: 11419
				private static readonly IntPtr NativeFieldInfoPtr_value;

				// Token: 0x04002C9C RID: 11420
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_ReadOnly_T_0;

				// Token: 0x04002C9D RID: 11421
				private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

				// Token: 0x04002C9E RID: 11422
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

				// Token: 0x04002C9F RID: 11423
				private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

				// Token: 0x04002CA0 RID: 11424
				private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0;

				// Token: 0x04002CA1 RID: 11425
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020003BE RID: 958
		private sealed class MethodInfoStoreGeneric_InternalReinterpret_Private_NativeArray_1_U_Int32_0
		{
			// Token: 0x040029ED RID: 10733
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeArray<U>.NativeMethodInfoPtr_InternalReinterpret_Private_NativeArray_1_U_Int32_0, Il2CppClassPointerStore<NativeArray<U>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
			}))));
		}

		// Token: 0x020003BF RID: 959
		private sealed class MethodInfoStoreGeneric_Reinterpret_Public_NativeArray_1_U_0
		{
			// Token: 0x040029EE RID: 10734
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeArray<U>.NativeMethodInfoPtr_Reinterpret_Public_NativeArray_1_U_0, Il2CppClassPointerStore<NativeArray<U>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
			}))));
		}

		// Token: 0x020003C0 RID: 960
		private sealed class MethodInfoStoreGeneric_Reinterpret_Public_NativeArray_1_U_Int32_0
		{
			// Token: 0x040029EF RID: 10735
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeArray<U>.NativeMethodInfoPtr_Reinterpret_Public_NativeArray_1_U_Int32_0, Il2CppClassPointerStore<NativeArray<U>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
			}))));
		}
	}
}
