using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.NPCs.Framework
{
	// Token: 0x02000602 RID: 1538
	public class GenericNPCDataObject<T> : BaseNPCDataObject where T : NPCData
	{
		// Token: 0x060095D4 RID: 38356 RVA: 0x00285F38 File Offset: 0x00284138
		// Note: this type is marked as 'beforefieldinit'.
		static GenericNPCDataObject()
		{
			Il2CppClassPointerStore<GenericNPCDataObject<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Framework", "GenericNPCDataObject`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericNPCDataObject<T>>.NativeClassPtr);
			GenericNPCDataObject<T>.NativeFieldInfoPtr__data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericNPCDataObject<T>>.NativeClassPtr, "_data");
			GenericNPCDataObject<T>.NativeMethodInfoPtr_GetRuntimeData_Public_Virtual_NPCData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericNPCDataObject<T>>.NativeClassPtr, 100682847);
			GenericNPCDataObject<T>.NativeMethodInfoPtr_GetOriginalData_Public_Virtual_NPCData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericNPCDataObject<T>>.NativeClassPtr, 100682848);
			GenericNPCDataObject<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericNPCDataObject<T>>.NativeClassPtr, 100682849);
		}

		// Token: 0x060095D5 RID: 38357 RVA: 0x00285FF4 File Offset: 0x002841F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272361, XrefRangeEnd = 272362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override NPCData GetRuntimeData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericNPCDataObject<T>.NativeMethodInfoPtr_GetRuntimeData_Public_Virtual_NPCData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCData>(intPtr3) : null;
		}

		// Token: 0x060095D6 RID: 38358 RVA: 0x00286040 File Offset: 0x00284240
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override NPCData GetOriginalData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericNPCDataObject<T>.NativeMethodInfoPtr_GetOriginalData_Public_Virtual_NPCData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCData>(intPtr3) : null;
		}

		// Token: 0x060095D7 RID: 38359 RVA: 0x0028608C File Offset: 0x0028428C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 199973, RefRangeEnd = 199979, XrefRangeStart = 199973, XrefRangeEnd = 199979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericNPCDataObject() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericNPCDataObject<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericNPCDataObject<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095D8 RID: 38360 RVA: 0x000461FB File Offset: 0x000443FB
		public GenericNPCDataObject(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E37 RID: 11831
		// (get) Token: 0x060095D9 RID: 38361 RVA: 0x002860C8 File Offset: 0x002842C8
		// (set) Token: 0x060095DA RID: 38362 RVA: 0x002860F0 File Offset: 0x002842F0
		public unsafe T _data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericNPCDataObject<T>.NativeFieldInfoPtr__data);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericNPCDataObject<T>.NativeFieldInfoPtr__data);
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

		// Token: 0x04006715 RID: 26389
		private static readonly IntPtr NativeFieldInfoPtr__data;

		// Token: 0x04006716 RID: 26390
		private static readonly IntPtr NativeMethodInfoPtr_GetRuntimeData_Public_Virtual_NPCData_0;

		// Token: 0x04006717 RID: 26391
		private static readonly IntPtr NativeMethodInfoPtr_GetOriginalData_Public_Virtual_NPCData_0;

		// Token: 0x04006718 RID: 26392
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
