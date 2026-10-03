using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x020003F4 RID: 1012
	public static class ListExtensions : Object
	{
		// Token: 0x06005A00 RID: 23040 RVA: 0x0002AB12 File Offset: 0x00028D12
		// Note: this type is marked as 'beforefieldinit'.
		static ListExtensions()
		{
			Il2CppClassPointerStore<ListExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "ListExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListExtensions>.NativeClassPtr);
			ListExtensions.NativeMethodInfoPtr_Shuffle_Public_Static_Void_IList_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListExtensions>.NativeClassPtr, 100675070);
		}

		// Token: 0x06005A01 RID: 23041 RVA: 0x001B1D94 File Offset: 0x001AFF94
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 194696, RefRangeEnd = 194699, XrefRangeStart = 194679, XrefRangeEnd = 194696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Shuffle<T>(this IList<T> list, int seed = -1)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListExtensions.MethodInfoStoreGeneric_Shuffle_Public_Static_Void_IList_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A02 RID: 23042 RVA: 0x0002AB4B File Offset: 0x00028D4B
		public ListExtensions(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003DC3 RID: 15811
		private static readonly IntPtr NativeMethodInfoPtr_Shuffle_Public_Static_Void_IList_1_T_Int32_0;

		// Token: 0x02000AEA RID: 2794
		private sealed class MethodInfoStoreGeneric_Shuffle_Public_Static_Void_IList_1_T_Int32_0<T>
		{
			// Token: 0x04009B6E RID: 39790
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListExtensions.NativeMethodInfoPtr_Shuffle_Public_Static_Void_IList_1_T_Int32_0, Il2CppClassPointerStore<ListExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
