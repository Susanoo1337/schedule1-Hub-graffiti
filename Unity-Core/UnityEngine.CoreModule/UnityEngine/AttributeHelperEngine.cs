using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine
{
	// Token: 0x0200011F RID: 287
	public class AttributeHelperEngine : Object
	{
		// Token: 0x0600174B RID: 5963 RVA: 0x00064F54 File Offset: 0x00063154
		// Note: this type is marked as 'beforefieldinit'.
		static AttributeHelperEngine()
		{
			Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "AttributeHelperEngine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr);
			AttributeHelperEngine.NativeFieldInfoPtr__disallowMultipleComponentArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr, "_disallowMultipleComponentArray");
			AttributeHelperEngine.NativeFieldInfoPtr__executeInEditModeArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr, "_executeInEditModeArray");
			AttributeHelperEngine.NativeFieldInfoPtr__requireComponentArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr, "_requireComponentArray");
			AttributeHelperEngine.NativeMethodInfoPtr_GetParentTypeDisallowingMultipleInclusion_Private_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr, 100665743);
			AttributeHelperEngine.NativeMethodInfoPtr_GetRequiredComponents_Private_Static_Il2CppReferenceArray_1_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr, 100665744);
			AttributeHelperEngine.NativeMethodInfoPtr_GetExecuteMode_Private_Static_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr, 100665745);
			AttributeHelperEngine.NativeMethodInfoPtr_CheckIsEditorScript_Private_Static_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr, 100665746);
			AttributeHelperEngine.NativeMethodInfoPtr_GetDefaultExecutionOrderFor_Private_Static_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr, 100665747);
			AttributeHelperEngine.NativeMethodInfoPtr_GetCustomAttributeOfType_Private_Static_T_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr, 100665748);
		}

		// Token: 0x0600174C RID: 5964 RVA: 0x00065038 File Offset: 0x00063238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246961, XrefRangeEnd = 1246978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetParentTypeDisallowingMultipleInclusion(Type type)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeHelperEngine.NativeMethodInfoPtr_GetParentTypeDisallowingMultipleInclusion_Private_Static_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x0600174D RID: 5965 RVA: 0x0006507C File Offset: 0x0006327C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246978, XrefRangeEnd = 1247035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Type> GetRequiredComponents(Type klass)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(klass);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeHelperEngine.NativeMethodInfoPtr_GetRequiredComponents_Private_Static_Il2CppReferenceArray_1_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x0600174E RID: 5966 RVA: 0x000650C0 File Offset: 0x000632C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247035, XrefRangeEnd = 1247046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetExecuteMode(Type klass)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(klass);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeHelperEngine.NativeMethodInfoPtr_GetExecuteMode_Private_Static_Int32_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600174F RID: 5967 RVA: 0x00065104 File Offset: 0x00063304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247046, XrefRangeEnd = 1247071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CheckIsEditorScript(Type klass)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(klass);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeHelperEngine.NativeMethodInfoPtr_CheckIsEditorScript_Private_Static_Int32_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001750 RID: 5968 RVA: 0x00065148 File Offset: 0x00063348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247071, XrefRangeEnd = 1247077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetDefaultExecutionOrderFor(Type klass)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(klass);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeHelperEngine.NativeMethodInfoPtr_GetDefaultExecutionOrderFor_Private_Static_Int32_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001751 RID: 5969 RVA: 0x0006518C File Offset: 0x0006338C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1247085, RefRangeEnd = 1247086, XrefRangeStart = 1247077, XrefRangeEnd = 1247085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetCustomAttributeOfType<T>(Type klass) where T : Attribute
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(klass);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeHelperEngine.MethodInfoStoreGeneric_GetCustomAttributeOfType_Private_Static_T_Type_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001752 RID: 5970 RVA: 0x0000B96F File Offset: 0x00009B6F
		public AttributeHelperEngine(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06001753 RID: 5971 RVA: 0x000651CC File Offset: 0x000633CC
		// (set) Token: 0x06001754 RID: 5972 RVA: 0x0000B978 File Offset: 0x00009B78
		public unsafe static Il2CppReferenceArray<DisallowMultipleComponent> _disallowMultipleComponentArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AttributeHelperEngine.NativeFieldInfoPtr__disallowMultipleComponentArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DisallowMultipleComponent>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AttributeHelperEngine.NativeFieldInfoPtr__disallowMultipleComponentArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06001755 RID: 5973 RVA: 0x000651F4 File Offset: 0x000633F4
		// (set) Token: 0x06001756 RID: 5974 RVA: 0x0000B98A File Offset: 0x00009B8A
		public unsafe static Il2CppReferenceArray<ExecuteInEditMode> _executeInEditModeArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AttributeHelperEngine.NativeFieldInfoPtr__executeInEditModeArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ExecuteInEditMode>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AttributeHelperEngine.NativeFieldInfoPtr__executeInEditModeArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06001757 RID: 5975 RVA: 0x0006521C File Offset: 0x0006341C
		// (set) Token: 0x06001758 RID: 5976 RVA: 0x0000B99C File Offset: 0x00009B9C
		public unsafe static Il2CppReferenceArray<RequireComponent> _requireComponentArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AttributeHelperEngine.NativeFieldInfoPtr__requireComponentArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RequireComponent>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AttributeHelperEngine.NativeFieldInfoPtr__requireComponentArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040013CB RID: 5067
		private static readonly IntPtr NativeFieldInfoPtr__disallowMultipleComponentArray;

		// Token: 0x040013CC RID: 5068
		private static readonly IntPtr NativeFieldInfoPtr__executeInEditModeArray;

		// Token: 0x040013CD RID: 5069
		private static readonly IntPtr NativeFieldInfoPtr__requireComponentArray;

		// Token: 0x040013CE RID: 5070
		private static readonly IntPtr NativeMethodInfoPtr_GetParentTypeDisallowingMultipleInclusion_Private_Static_Type_Type_0;

		// Token: 0x040013CF RID: 5071
		private static readonly IntPtr NativeMethodInfoPtr_GetRequiredComponents_Private_Static_Il2CppReferenceArray_1_Type_Type_0;

		// Token: 0x040013D0 RID: 5072
		private static readonly IntPtr NativeMethodInfoPtr_GetExecuteMode_Private_Static_Int32_Type_0;

		// Token: 0x040013D1 RID: 5073
		private static readonly IntPtr NativeMethodInfoPtr_CheckIsEditorScript_Private_Static_Int32_Type_0;

		// Token: 0x040013D2 RID: 5074
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultExecutionOrderFor_Private_Static_Int32_Type_0;

		// Token: 0x040013D3 RID: 5075
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributeOfType_Private_Static_T_Type_0;

		// Token: 0x020008AD RID: 2221
		private sealed class MethodInfoStoreGeneric_GetCustomAttributeOfType_Private_Static_T_Type_0<T>
		{
			// Token: 0x04002AFE RID: 11006
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AttributeHelperEngine.NativeMethodInfoPtr_GetCustomAttributeOfType_Private_Static_T_Type_0, Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
