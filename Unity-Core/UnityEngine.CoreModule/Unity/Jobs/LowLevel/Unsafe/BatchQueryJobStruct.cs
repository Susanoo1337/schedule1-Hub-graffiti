using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Unity.Jobs.LowLevel.Unsafe
{
	// Token: 0x02000012 RID: 18
	public sealed class BatchQueryJobStruct<T> : ValueType where T : new()
	{
		// Token: 0x0600005F RID: 95 RVA: 0x00019AFC File Offset: 0x00017CFC
		// Note: this type is marked as 'beforefieldinit'.
		static BatchQueryJobStruct()
		{
			Il2CppClassPointerStore<BatchQueryJobStruct<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Jobs.LowLevel.Unsafe", "BatchQueryJobStruct`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchQueryJobStruct<T>>.NativeClassPtr);
			BatchQueryJobStruct<T>.NativeFieldInfoPtr_jobReflectionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchQueryJobStruct<T>>.NativeClassPtr, "jobReflectionData");
			BatchQueryJobStruct<T>.NativeMethodInfoPtr_Initialize_Public_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchQueryJobStruct<T>>.NativeClassPtr, 100663346);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00019B90 File Offset: 0x00017D90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1225085, RefRangeEnd = 1225086, XrefRangeStart = 1225073, XrefRangeEnd = 1225085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Initialize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchQueryJobStruct<T>.NativeMethodInfoPtr_Initialize_Public_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002355 File Offset: 0x00000555
		public BatchQueryJobStruct(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000235E File Offset: 0x0000055E
		public BatchQueryJobStruct() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchQueryJobStruct<T>>.NativeClassPtr))
		{
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00019BC0 File Offset: 0x00017DC0
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00002370 File Offset: 0x00000570
		public unsafe static IntPtr jobReflectionData
		{
			get
			{
				IntPtr result;
				IL2CPP.il2cpp_field_static_get_value(BatchQueryJobStruct<T>.NativeFieldInfoPtr_jobReflectionData, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BatchQueryJobStruct<T>.NativeFieldInfoPtr_jobReflectionData, (void*)(&value));
			}
		}

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeFieldInfoPtr_jobReflectionData;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Static_IntPtr_0;
	}
}
