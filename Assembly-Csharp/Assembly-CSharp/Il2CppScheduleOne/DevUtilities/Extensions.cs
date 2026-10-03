using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x020003ED RID: 1005
	public static class Extensions : Object
	{
		// Token: 0x0600597A RID: 22906 RVA: 0x001B0120 File Offset: 0x001AE320
		// Note: this type is marked as 'beforefieldinit'.
		static Extensions()
		{
			Il2CppClassPointerStore<Extensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "Extensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Extensions>.NativeClassPtr);
			Extensions.NativeMethodInfoPtr_ShiftLeft_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions>.NativeClassPtr, 100675007);
			Extensions.NativeMethodInfoPtr_ShiftRight_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions>.NativeClassPtr, 100675008);
			Extensions.NativeMethodInfoPtr_ShiftLeft_Public_Static_List_1_T_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions>.NativeClassPtr, 100675009);
			Extensions.NativeMethodInfoPtr_ShiftRight_Public_Static_List_1_T_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions>.NativeClassPtr, 100675010);
		}

		// Token: 0x0600597B RID: 22907 RVA: 0x001B01A0 File Offset: 0x001AE3A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194051, XrefRangeEnd = 194066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> ShiftLeft<T>(this Il2CppArrayBase<T> array)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions.MethodInfoStoreGeneric_ShiftLeft_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x0600597C RID: 22908 RVA: 0x001B01DC File Offset: 0x001AE3DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194066, XrefRangeEnd = 194080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> ShiftRight<T>(this Il2CppArrayBase<T> array)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions.MethodInfoStoreGeneric_ShiftRight_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x0600597D RID: 22909 RVA: 0x001B0218 File Offset: 0x001AE418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194080, XrefRangeEnd = 194087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<T> ShiftLeft<T>(this List<T> array)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions.MethodInfoStoreGeneric_ShiftLeft_Public_Static_List_1_T_List_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr3) : null;
		}

		// Token: 0x0600597E RID: 22910 RVA: 0x001B025C File Offset: 0x001AE45C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194087, XrefRangeEnd = 194093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<T> ShiftRight<T>(this List<T> array)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions.MethodInfoStoreGeneric_ShiftRight_Public_Static_List_1_T_List_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr3) : null;
		}

		// Token: 0x0600597F RID: 22911 RVA: 0x0002A700 File Offset: 0x00028900
		public Extensions(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003D6B RID: 15723
		private static readonly IntPtr NativeMethodInfoPtr_ShiftLeft_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0;

		// Token: 0x04003D6C RID: 15724
		private static readonly IntPtr NativeMethodInfoPtr_ShiftRight_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0;

		// Token: 0x04003D6D RID: 15725
		private static readonly IntPtr NativeMethodInfoPtr_ShiftLeft_Public_Static_List_1_T_List_1_T_0;

		// Token: 0x04003D6E RID: 15726
		private static readonly IntPtr NativeMethodInfoPtr_ShiftRight_Public_Static_List_1_T_List_1_T_0;

		// Token: 0x02000ADF RID: 2783
		private sealed class MethodInfoStoreGeneric_ShiftLeft_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04009B5A RID: 39770
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Extensions.NativeMethodInfoPtr_ShiftLeft_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<Extensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000AE0 RID: 2784
		private sealed class MethodInfoStoreGeneric_ShiftRight_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04009B5B RID: 39771
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Extensions.NativeMethodInfoPtr_ShiftRight_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<Extensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000AE1 RID: 2785
		private sealed class MethodInfoStoreGeneric_ShiftLeft_Public_Static_List_1_T_List_1_T_0<T>
		{
			// Token: 0x04009B5C RID: 39772
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Extensions.NativeMethodInfoPtr_ShiftLeft_Public_Static_List_1_T_List_1_T_0, Il2CppClassPointerStore<Extensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000AE2 RID: 2786
		private sealed class MethodInfoStoreGeneric_ShiftRight_Public_Static_List_1_T_List_1_T_0<T>
		{
			// Token: 0x04009B5D RID: 39773
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Extensions.NativeMethodInfoPtr_ShiftRight_Public_Static_List_1_T_List_1_T_0, Il2CppClassPointerStore<Extensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
