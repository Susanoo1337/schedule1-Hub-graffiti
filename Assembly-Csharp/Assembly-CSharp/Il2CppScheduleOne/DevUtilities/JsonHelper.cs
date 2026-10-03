using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x020003F1 RID: 1009
	public static class JsonHelper : Object
	{
		// Token: 0x060059E4 RID: 23012 RVA: 0x001B1834 File Offset: 0x001AFA34
		// Note: this type is marked as 'beforefieldinit'.
		static JsonHelper()
		{
			Il2CppClassPointerStore<JsonHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "JsonHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonHelper>.NativeClassPtr);
			JsonHelper.NativeMethodInfoPtr_FromJson_Public_Static_Il2CppArrayBase_1_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonHelper>.NativeClassPtr, 100675057);
			JsonHelper.NativeMethodInfoPtr_ToJson_Public_Static_String_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonHelper>.NativeClassPtr, 100675058);
			JsonHelper.NativeMethodInfoPtr_ToJson_Public_Static_String_Il2CppArrayBase_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonHelper>.NativeClassPtr, 100675059);
		}

		// Token: 0x060059E5 RID: 23013 RVA: 0x001B18A0 File Offset: 0x001AFAA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194549, XrefRangeEnd = 194550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> FromJson<T>(string json)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonHelper.MethodInfoStoreGeneric_FromJson_Public_Static_Il2CppArrayBase_1_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x060059E6 RID: 23014 RVA: 0x001B18DC File Offset: 0x001AFADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194550, XrefRangeEnd = 194566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToJson<T>(Il2CppArrayBase<T> array)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonHelper.MethodInfoStoreGeneric_ToJson_Public_Static_String_Il2CppArrayBase_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060059E7 RID: 23015 RVA: 0x001B1918 File Offset: 0x001AFB18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194566, XrefRangeEnd = 194572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToJson<T>(Il2CppArrayBase<T> array, bool prettyPrint)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prettyPrint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonHelper.MethodInfoStoreGeneric_ToJson_Public_Static_String_Il2CppArrayBase_1_T_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060059E8 RID: 23016 RVA: 0x0002AA2B File Offset: 0x00028C2B
		public JsonHelper(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003DB2 RID: 15794
		private static readonly IntPtr NativeMethodInfoPtr_FromJson_Public_Static_Il2CppArrayBase_1_T_String_0;

		// Token: 0x04003DB3 RID: 15795
		private static readonly IntPtr NativeMethodInfoPtr_ToJson_Public_Static_String_Il2CppArrayBase_1_T_0;

		// Token: 0x04003DB4 RID: 15796
		private static readonly IntPtr NativeMethodInfoPtr_ToJson_Public_Static_String_Il2CppArrayBase_1_T_Boolean_0;

		// Token: 0x02000AE6 RID: 2790
		[Serializable]
		public class Wrapper<T> : Object
		{
			// Token: 0x0600E4E9 RID: 58601 RVA: 0x0037F8B8 File Offset: 0x0037DAB8
			// Note: this type is marked as 'beforefieldinit'.
			static Wrapper()
			{
				Il2CppClassPointerStore<JsonHelper.Wrapper<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonHelper>.NativeClassPtr, "Wrapper`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonHelper.Wrapper<T>>.NativeClassPtr);
				JsonHelper.Wrapper<T>.NativeFieldInfoPtr_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonHelper.Wrapper<T>>.NativeClassPtr, "Items");
				JsonHelper.Wrapper<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonHelper.Wrapper<T>>.NativeClassPtr, 100675060);
			}

			// Token: 0x0600E4EA RID: 58602 RVA: 0x0037F948 File Offset: 0x0037DB48
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Wrapper() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonHelper.Wrapper<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonHelper.Wrapper<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E4EB RID: 58603 RVA: 0x0006BECC File Offset: 0x0006A0CC
			public Wrapper(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004596 RID: 17814
			// (get) Token: 0x0600E4EC RID: 58604 RVA: 0x0037F984 File Offset: 0x0037DB84
			// (set) Token: 0x0600E4ED RID: 58605 RVA: 0x0006BED5 File Offset: 0x0006A0D5
			public unsafe Il2CppArrayBase<T> Items
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonHelper.Wrapper<T>.NativeFieldInfoPtr_Items);
					return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonHelper.Wrapper<T>.NativeFieldInfoPtr_Items), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009B69 RID: 39785
			private static readonly IntPtr NativeFieldInfoPtr_Items;

			// Token: 0x04009B6A RID: 39786
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AE7 RID: 2791
		private sealed class MethodInfoStoreGeneric_FromJson_Public_Static_Il2CppArrayBase_1_T_String_0<T>
		{
			// Token: 0x04009B6B RID: 39787
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JsonHelper.NativeMethodInfoPtr_FromJson_Public_Static_Il2CppArrayBase_1_T_String_0, Il2CppClassPointerStore<JsonHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000AE8 RID: 2792
		private sealed class MethodInfoStoreGeneric_ToJson_Public_Static_String_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04009B6C RID: 39788
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JsonHelper.NativeMethodInfoPtr_ToJson_Public_Static_String_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<JsonHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000AE9 RID: 2793
		private sealed class MethodInfoStoreGeneric_ToJson_Public_Static_String_Il2CppArrayBase_1_T_Boolean_0<T>
		{
			// Token: 0x04009B6D RID: 39789
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JsonHelper.NativeMethodInfoPtr_ToJson_Public_Static_String_Il2CppArrayBase_1_T_Boolean_0, Il2CppClassPointerStore<JsonHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
