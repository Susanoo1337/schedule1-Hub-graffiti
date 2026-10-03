using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000015 RID: 21
	public static class GUIDManager : Il2CppSystem.Object
	{
		// Token: 0x0600011E RID: 286 RVA: 0x0007ED14 File Offset: 0x0007CF14
		// Note: this type is marked as 'beforefieldinit'.
		static GUIDManager()
		{
			Il2CppClassPointerStore<GUIDManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GUIDManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUIDManager>.NativeClassPtr);
			GUIDManager.NativeFieldInfoPtr_registeredGUIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIDManager>.NativeClassPtr, "registeredGUIDs");
			GUIDManager.NativeFieldInfoPtr_guidToObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIDManager>.NativeClassPtr, "guidToObject");
			GUIDManager.NativeMethodInfoPtr_RegisterObject_Public_Static_Void_IGUIDRegisterable_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIDManager>.NativeClassPtr, 100663401);
			GUIDManager.NativeMethodInfoPtr_DeregisterObject_Public_Static_Void_IGUIDRegisterable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIDManager>.NativeClassPtr, 100663402);
			GUIDManager.NativeMethodInfoPtr_GetObject_Public_Static_T_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIDManager>.NativeClassPtr, 100663403);
			GUIDManager.NativeMethodInfoPtr_GetObjectType_Public_Static_Type_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIDManager>.NativeClassPtr, 100663404);
			GUIDManager.NativeMethodInfoPtr_GenerateUniqueGUID_Public_Static_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIDManager>.NativeClassPtr, 100663405);
			GUIDManager.NativeMethodInfoPtr_IsGUIDAlreadyRegistered_Public_Static_Boolean_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIDManager>.NativeClassPtr, 100663406);
			GUIDManager.NativeMethodInfoPtr_IsGUIDValid_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIDManager>.NativeClassPtr, 100663407);
			GUIDManager.NativeMethodInfoPtr_Clear_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIDManager>.NativeClassPtr, 100663408);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0007EE0C File Offset: 0x0007D00C
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 65884, RefRangeEnd = 65921, XrefRangeStart = 65835, XrefRangeEnd = 65884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterObject(IGUIDRegisterable obj, GameObject go = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(go);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIDManager.NativeMethodInfoPtr_RegisterObject_Public_Static_Void_IGUIDRegisterable_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0007EE54 File Offset: 0x0007D054
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 65937, RefRangeEnd = 65938, XrefRangeStart = 65921, XrefRangeEnd = 65937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeregisterObject(IGUIDRegisterable obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIDManager.NativeMethodInfoPtr_DeregisterObject_Public_Static_Void_IGUIDRegisterable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0007EE8C File Offset: 0x0007D08C
		[CallerCount(69)]
		[CachedScanResults(RefRangeStart = 65963, RefRangeEnd = 66032, XrefRangeStart = 65938, XrefRangeEnd = 65963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetObject<T>(Guid guid)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIDManager.MethodInfoStoreGeneric_GetObject_Public_Static_T_Guid_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0007EEC8 File Offset: 0x0007D0C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66032, XrefRangeEnd = 66039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetObjectType(Guid guid)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIDManager.NativeMethodInfoPtr_GetObjectType_Public_Static_Type_Guid_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0007EF08 File Offset: 0x0007D108
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 66047, RefRangeEnd = 66060, XrefRangeStart = 66039, XrefRangeEnd = 66047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Guid GenerateUniqueGUID()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIDManager.NativeMethodInfoPtr_GenerateUniqueGUID_Public_Static_Guid_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0007EF38 File Offset: 0x0007D138
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 66067, RefRangeEnd = 66092, XrefRangeStart = 66060, XrefRangeEnd = 66067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsGUIDAlreadyRegistered(Guid guid)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIDManager.NativeMethodInfoPtr_IsGUIDAlreadyRegistered_Public_Static_Boolean_Guid_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0007EF78 File Offset: 0x0007D178
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 66099, RefRangeEnd = 66113, XrefRangeStart = 66092, XrefRangeEnd = 66099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsGUIDValid(string guid)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIDManager.NativeMethodInfoPtr_IsGUIDValid_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0007EFBC File Offset: 0x0007D1BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 66129, RefRangeEnd = 66130, XrefRangeStart = 66113, XrefRangeEnd = 66129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Clear()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIDManager.NativeMethodInfoPtr_Clear_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00002A58 File Offset: 0x00000C58
		public GUIDManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000128 RID: 296 RVA: 0x0007EFE4 File Offset: 0x0007D1E4
		// (set) Token: 0x06000129 RID: 297 RVA: 0x00002A61 File Offset: 0x00000C61
		public unsafe static List<Guid> registeredGUIDs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUIDManager.NativeFieldInfoPtr_registeredGUIDs, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Guid>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIDManager.NativeFieldInfoPtr_registeredGUIDs, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600012A RID: 298 RVA: 0x0007F00C File Offset: 0x0007D20C
		// (set) Token: 0x0600012B RID: 299 RVA: 0x00002A73 File Offset: 0x00000C73
		public unsafe static Dictionary<Guid, Il2CppSystem.Object> guidToObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUIDManager.NativeFieldInfoPtr_guidToObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Guid, Il2CppSystem.Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIDManager.NativeFieldInfoPtr_guidToObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeFieldInfoPtr_registeredGUIDs;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeFieldInfoPtr_guidToObject;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_RegisterObject_Public_Static_Void_IGUIDRegisterable_GameObject_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_DeregisterObject_Public_Static_Void_IGUIDRegisterable_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_GetObject_Public_Static_T_Guid_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectType_Public_Static_Type_Guid_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_GenerateUniqueGUID_Public_Static_Guid_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr_IsGUIDAlreadyRegistered_Public_Static_Boolean_Guid_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_IsGUIDValid_Public_Static_Boolean_String_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Static_Void_0;

		// Token: 0x02000855 RID: 2133
		private sealed class MethodInfoStoreGeneric_GetObject_Public_Static_T_Guid_0<T>
		{
			// Token: 0x04008DAA RID: 36266
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GUIDManager.NativeMethodInfoPtr_GetObject_Public_Static_T_Guid_0, Il2CppClassPointerStore<GUIDManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
