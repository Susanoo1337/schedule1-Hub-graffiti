using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppScheduleOne.Core.Equipping.Framework;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;

namespace Il2CppScheduleOne.Equipping.Framework
{
	// Token: 0x02000591 RID: 1425
	public class GenericEquippableItemDefinition<T> : StorableItemDefinition where T : EquippableData
	{
		// Token: 0x0600818F RID: 33167 RVA: 0x00237A9C File Offset: 0x00235C9C
		// Note: this type is marked as 'beforefieldinit'.
		static GenericEquippableItemDefinition()
		{
			Il2CppClassPointerStore<GenericEquippableItemDefinition<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping.Framework", "GenericEquippableItemDefinition`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericEquippableItemDefinition<T>>.NativeClassPtr);
			GenericEquippableItemDefinition<T>.NativeFieldInfoPtr__EquippableData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericEquippableItemDefinition<T>>.NativeClassPtr, "<EquippableData>k__BackingField");
			GenericEquippableItemDefinition<T>.NativeMethodInfoPtr_get_EquippableData_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericEquippableItemDefinition<T>>.NativeClassPtr, 100679936);
			GenericEquippableItemDefinition<T>.NativeMethodInfoPtr_set_EquippableData_Private_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericEquippableItemDefinition<T>>.NativeClassPtr, 100679937);
			GenericEquippableItemDefinition<T>.NativeMethodInfoPtr_ValidateDefinition_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericEquippableItemDefinition<T>>.NativeClassPtr, 100679938);
			GenericEquippableItemDefinition<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericEquippableItemDefinition<T>>.NativeClassPtr, 100679939);
		}

		// Token: 0x1700280D RID: 10253
		// (get) Token: 0x06008190 RID: 33168 RVA: 0x00237B6C File Offset: 0x00235D6C
		// (set) Token: 0x06008191 RID: 33169 RVA: 0x00237BA8 File Offset: 0x00235DA8
		public new unsafe T EquippableData
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 38421, RefRangeEnd = 38424, XrefRangeStart = 38421, XrefRangeEnd = 38424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericEquippableItemDefinition<T>.NativeMethodInfoPtr_get_EquippableData_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				IntPtr* ptr2 = ptr;
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericEquippableItemDefinition<T>.NativeMethodInfoPtr_set_EquippableData_Private_set_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008192 RID: 33170 RVA: 0x00237C38 File Offset: 0x00235E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245300, XrefRangeEnd = 245313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ValidateDefinition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericEquippableItemDefinition<T>.NativeMethodInfoPtr_ValidateDefinition_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008193 RID: 33171 RVA: 0x00237C74 File Offset: 0x00235E74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166837, RefRangeEnd = 166838, XrefRangeStart = 166837, XrefRangeEnd = 166838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericEquippableItemDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericEquippableItemDefinition<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericEquippableItemDefinition<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008194 RID: 33172 RVA: 0x0003DA53 File Offset: 0x0003BC53
		public GenericEquippableItemDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700280C RID: 10252
		// (get) Token: 0x06008195 RID: 33173 RVA: 0x00237CB0 File Offset: 0x00235EB0
		// (set) Token: 0x06008196 RID: 33174 RVA: 0x00237CD8 File Offset: 0x00235ED8
		public unsafe T _EquippableData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericEquippableItemDefinition<T>.NativeFieldInfoPtr__EquippableData_k__BackingField);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericEquippableItemDefinition<T>.NativeFieldInfoPtr__EquippableData_k__BackingField);
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

		// Token: 0x0400584A RID: 22602
		private static readonly IntPtr NativeFieldInfoPtr__EquippableData_k__BackingField;

		// Token: 0x0400584B RID: 22603
		private static readonly IntPtr NativeMethodInfoPtr_get_EquippableData_Public_get_T_0;

		// Token: 0x0400584C RID: 22604
		private static readonly IntPtr NativeMethodInfoPtr_set_EquippableData_Private_set_Void_T_0;

		// Token: 0x0400584D RID: 22605
		private static readonly IntPtr NativeMethodInfoPtr_ValidateDefinition_Public_Virtual_Void_0;

		// Token: 0x0400584E RID: 22606
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
