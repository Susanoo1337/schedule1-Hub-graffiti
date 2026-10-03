using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x020001BE RID: 446
	public class DynamicLoader : Object
	{
		// Token: 0x06002C22 RID: 11298 RVA: 0x0010D59C File Offset: 0x0010B79C
		// Note: this type is marked as 'beforefieldinit'.
		static DynamicLoader()
		{
			Il2CppClassPointerStore<DynamicLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "DynamicLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicLoader>.NativeClassPtr);
			DynamicLoader.NativeMethodInfoPtr_Load_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicLoader>.NativeClassPtr, 100669001);
			DynamicLoader.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_DynamicSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicLoader>.NativeClassPtr, 100669002);
			DynamicLoader.NativeMethodInfoPtr_ExtractBaseData_Public_Static_T_DynamicSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicLoader>.NativeClassPtr, 100669003);
			DynamicLoader.NativeMethodInfoPtr_TryExtractBaseData_Public_Static_Boolean_DynamicSaveData_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicLoader>.NativeClassPtr, 100669004);
			DynamicLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicLoader>.NativeClassPtr, 100669005);
		}

		// Token: 0x06002C23 RID: 11299 RVA: 0x0010D630 File Offset: 0x0010B830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128511, XrefRangeEnd = 128529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(string serializedDynamicSaveData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(serializedDynamicSaveData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicLoader.NativeMethodInfoPtr_Load_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C24 RID: 11300 RVA: 0x0010D674 File Offset: 0x0010B874
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Load(DynamicSaveData saveData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicLoader.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_DynamicSaveData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C25 RID: 11301 RVA: 0x0010D6C4 File Offset: 0x0010B8C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 128541, RefRangeEnd = 128543, XrefRangeStart = 128529, XrefRangeEnd = 128541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T ExtractBaseData<T>(DynamicSaveData saveData) where T : SaveData
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicLoader.MethodInfoStoreGeneric_ExtractBaseData_Public_Static_T_DynamicSaveData_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06002C26 RID: 11302 RVA: 0x0010D704 File Offset: 0x0010B904
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 128548, RefRangeEnd = 128552, XrefRangeStart = 128543, XrefRangeEnd = 128548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryExtractBaseData<T>(DynamicSaveData saveData, out T baseData) where T : SaveData
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveData);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref baseData;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DynamicLoader.MethodInfoStoreGeneric_TryExtractBaseData_Public_Static_Boolean_DynamicSaveData_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				baseData = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06002C27 RID: 11303 RVA: 0x0010D794 File Offset: 0x0010B994
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C28 RID: 11304 RVA: 0x00016D24 File Offset: 0x00014F24
		public DynamicLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001E56 RID: 7766
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_String_0;

		// Token: 0x04001E57 RID: 7767
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_New_Void_DynamicSaveData_0;

		// Token: 0x04001E58 RID: 7768
		private static readonly IntPtr NativeMethodInfoPtr_ExtractBaseData_Public_Static_T_DynamicSaveData_0;

		// Token: 0x04001E59 RID: 7769
		private static readonly IntPtr NativeMethodInfoPtr_TryExtractBaseData_Public_Static_Boolean_DynamicSaveData_byref_T_0;

		// Token: 0x04001E5A RID: 7770
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009B7 RID: 2487
		private sealed class MethodInfoStoreGeneric_ExtractBaseData_Public_Static_T_DynamicSaveData_0<T>
		{
			// Token: 0x040095EE RID: 38382
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DynamicLoader.NativeMethodInfoPtr_ExtractBaseData_Public_Static_T_DynamicSaveData_0, Il2CppClassPointerStore<DynamicLoader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020009B8 RID: 2488
		private sealed class MethodInfoStoreGeneric_TryExtractBaseData_Public_Static_Boolean_DynamicSaveData_byref_T_0<T>
		{
			// Token: 0x040095EF RID: 38383
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DynamicLoader.NativeMethodInfoPtr_TryExtractBaseData_Public_Static_Boolean_DynamicSaveData_byref_T_0, Il2CppClassPointerStore<DynamicLoader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
