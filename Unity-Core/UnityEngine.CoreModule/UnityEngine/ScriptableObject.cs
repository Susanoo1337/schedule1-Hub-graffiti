using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine
{
	// Token: 0x02000147 RID: 327
	public class ScriptableObject : Object
	{
		// Token: 0x06001901 RID: 6401 RVA: 0x0006ADEC File Offset: 0x00068FEC
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptableObject()
		{
			Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ScriptableObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr);
			ScriptableObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr, 100665949);
			ScriptableObject.NativeMethodInfoPtr_CreateInstance_Public_Static_ScriptableObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr, 100665950);
			ScriptableObject.NativeMethodInfoPtr_CreateInstance_Public_Static_ScriptableObject_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr, 100665951);
			ScriptableObject.NativeMethodInfoPtr_CreateInstance_Public_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr, 100665952);
			ScriptableObject.NativeMethodInfoPtr_CreateScriptableObject_Private_Static_Void_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr, 100665953);
			ScriptableObject.NativeMethodInfoPtr_CreateScriptableObjectInstanceFromName_Private_Static_ScriptableObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr, 100665954);
			ScriptableObject.NativeMethodInfoPtr_CreateScriptableObjectInstanceFromType_Internal_Static_ScriptableObject_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr, 100665955);
			ScriptableObject.SetDirtyDelegateField = IL2CPP.ResolveICall<ScriptableObject.SetDirtyDelegate>("UnityEngine.ScriptableObject::SetDirty");
			ScriptableObject.ResetAndApplyDefaultInstancesDelegateField = IL2CPP.ResolveICall<ScriptableObject.ResetAndApplyDefaultInstancesDelegate>("UnityEngine.ScriptableObject::ResetAndApplyDefaultInstances");
		}

		// Token: 0x06001902 RID: 6402 RVA: 0x0006AEC8 File Offset: 0x000690C8
		[CallerCount(124)]
		[CachedScanResults(RefRangeStart = 1260517, RefRangeEnd = 1260641, XrefRangeStart = 1260511, XrefRangeEnd = 1260517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScriptableObject() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001903 RID: 6403 RVA: 0x0006AF04 File Offset: 0x00069104
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1260643, RefRangeEnd = 1260644, XrefRangeStart = 1260641, XrefRangeEnd = 1260643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptableObject CreateInstance(string className)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(className);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableObject.NativeMethodInfoPtr_CreateInstance_Public_Static_ScriptableObject_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr3) : null;
		}

		// Token: 0x06001904 RID: 6404 RVA: 0x0006AF48 File Offset: 0x00069148
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1260646, RefRangeEnd = 1260654, XrefRangeStart = 1260644, XrefRangeEnd = 1260646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptableObject CreateInstance(Type type)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableObject.NativeMethodInfoPtr_CreateInstance_Public_Static_ScriptableObject_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr3) : null;
		}

		// Token: 0x06001905 RID: 6405 RVA: 0x0006AF8C File Offset: 0x0006918C
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 1260661, RefRangeEnd = 1260693, XrefRangeStart = 1260654, XrefRangeEnd = 1260661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T CreateInstance<T>() where T : ScriptableObject
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableObject.MethodInfoStoreGeneric_CreateInstance_Public_Static_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001906 RID: 6406 RVA: 0x0006AFBC File Offset: 0x000691BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260693, XrefRangeEnd = 1260695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateScriptableObject(ScriptableObject self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableObject.NativeMethodInfoPtr_CreateScriptableObject_Private_Static_Void_ScriptableObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001907 RID: 6407 RVA: 0x0006AFF4 File Offset: 0x000691F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1260643, RefRangeEnd = 1260644, XrefRangeStart = 1260643, XrefRangeEnd = 1260644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptableObject CreateScriptableObjectInstanceFromName(string className)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(className);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableObject.NativeMethodInfoPtr_CreateScriptableObjectInstanceFromName_Private_Static_ScriptableObject_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr3) : null;
		}

		// Token: 0x06001908 RID: 6408 RVA: 0x0006B038 File Offset: 0x00069238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260695, XrefRangeEnd = 1260697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptableObject CreateScriptableObjectInstanceFromType(Type type, bool applyDefaultsAndReset)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyDefaultsAndReset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableObject.NativeMethodInfoPtr_CreateScriptableObjectInstanceFromType_Internal_Static_ScriptableObject_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr3) : null;
		}

		// Token: 0x06001909 RID: 6409 RVA: 0x0000C3E6 File Offset: 0x0000A5E6
		public ScriptableObject(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0600190A RID: 6410 RVA: 0x0000C3EF File Offset: 0x0000A5EF
		public void SetDirty()
		{
			ScriptableObject.SetDirtyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600190B RID: 6411 RVA: 0x0006B08C File Offset: 0x0006928C
		public static ScriptableObject CreateInstance(Type type, Action<ScriptableObject> initialize)
		{
			bool flag = !Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<ScriptableObject>()).IsAssignableFrom(type);
			if (flag)
			{
				throw new ArgumentException("Type must inherit ScriptableObject.", "type");
			}
			ScriptableObject scriptableObject = ScriptableObject.CreateScriptableObjectInstanceFromType(type, false);
			try
			{
				initialize.Invoke(scriptableObject);
			}
			finally
			{
				ScriptableObject.ResetAndApplyDefaultInstances(scriptableObject);
			}
			return scriptableObject;
		}

		// Token: 0x0600190C RID: 6412 RVA: 0x0000C401 File Offset: 0x0000A601
		public static void ResetAndApplyDefaultInstances(Object obj)
		{
			ScriptableObject.ResetAndApplyDefaultInstancesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(obj));
		}

		// Token: 0x040014E0 RID: 5344
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040014E1 RID: 5345
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_ScriptableObject_String_0;

		// Token: 0x040014E2 RID: 5346
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_ScriptableObject_Type_0;

		// Token: 0x040014E3 RID: 5347
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_T_0;

		// Token: 0x040014E4 RID: 5348
		private static readonly IntPtr NativeMethodInfoPtr_CreateScriptableObject_Private_Static_Void_ScriptableObject_0;

		// Token: 0x040014E5 RID: 5349
		private static readonly IntPtr NativeMethodInfoPtr_CreateScriptableObjectInstanceFromName_Private_Static_ScriptableObject_String_0;

		// Token: 0x040014E6 RID: 5350
		private static readonly IntPtr NativeMethodInfoPtr_CreateScriptableObjectInstanceFromType_Internal_Static_ScriptableObject_Type_Boolean_0;

		// Token: 0x040014E7 RID: 5351
		private static readonly ScriptableObject.SetDirtyDelegate SetDirtyDelegateField;

		// Token: 0x040014E8 RID: 5352
		private static readonly ScriptableObject.ResetAndApplyDefaultInstancesDelegate ResetAndApplyDefaultInstancesDelegateField;

		// Token: 0x020008E8 RID: 2280
		private sealed class MethodInfoStoreGeneric_CreateInstance_Public_Static_T_0<T>
		{
			// Token: 0x04002B38 RID: 11064
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ScriptableObject.NativeMethodInfoPtr_CreateInstance_Public_Static_T_0, Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020008E9 RID: 2281
		// (Invoke) Token: 0x06003A4A RID: 14922
		private delegate void SetDirtyDelegate(IntPtr @this);

		// Token: 0x020008EA RID: 2282
		// (Invoke) Token: 0x06003A4C RID: 14924
		private delegate void ResetAndApplyDefaultInstancesDelegate(IntPtr obj);
	}
}
