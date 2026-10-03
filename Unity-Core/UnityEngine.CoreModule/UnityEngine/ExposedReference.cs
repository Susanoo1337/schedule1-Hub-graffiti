using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200007D RID: 125
	[Serializable]
	public sealed class ExposedReference<T> : ValueType where T : Object
	{
		// Token: 0x06000602 RID: 1538 RVA: 0x00029B04 File Offset: 0x00027D04
		// Note: this type is marked as 'beforefieldinit'.
		static ExposedReference()
		{
			Il2CppClassPointerStore<ExposedReference<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ExposedReference`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExposedReference<T>>.NativeClassPtr);
			ExposedReference<T>.NativeFieldInfoPtr_exposedName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExposedReference<T>>.NativeClassPtr, "exposedName");
			ExposedReference<T>.NativeFieldInfoPtr_defaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExposedReference<T>>.NativeClassPtr, "defaultValue");
			ExposedReference<T>.NativeMethodInfoPtr_Resolve_Public_T_IExposedPropertyTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExposedReference<T>>.NativeClassPtr, 100663908);
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00029BAC File Offset: 0x00027DAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1232019, RefRangeEnd = 1232021, XrefRangeStart = 1232003, XrefRangeEnd = 1232019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T Resolve(IExposedPropertyTable resolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(resolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExposedReference<T>.NativeMethodInfoPtr_Resolve_Public_T_IExposedPropertyTable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00004DC3 File Offset: 0x00002FC3
		public ExposedReference(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00004DCC File Offset: 0x00002FCC
		public ExposedReference() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExposedReference<T>>.NativeClassPtr))
		{
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000606 RID: 1542 RVA: 0x00029BFC File Offset: 0x00027DFC
		// (set) Token: 0x06000607 RID: 1543 RVA: 0x00004DDE File Offset: 0x00002FDE
		public unsafe PropertyName exposedName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExposedReference<T>.NativeFieldInfoPtr_exposedName);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExposedReference<T>.NativeFieldInfoPtr_exposedName)) = value;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000608 RID: 1544 RVA: 0x00029C24 File Offset: 0x00027E24
		// (set) Token: 0x06000609 RID: 1545 RVA: 0x00004DF9 File Offset: 0x00002FF9
		public unsafe Object defaultValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExposedReference<T>.NativeFieldInfoPtr_defaultValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExposedReference<T>.NativeFieldInfoPtr_defaultValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000518 RID: 1304
		private static readonly IntPtr NativeFieldInfoPtr_exposedName;

		// Token: 0x04000519 RID: 1305
		private static readonly IntPtr NativeFieldInfoPtr_defaultValue;

		// Token: 0x0400051A RID: 1306
		private static readonly IntPtr NativeMethodInfoPtr_Resolve_Public_T_IExposedPropertyTable_0;
	}
}
