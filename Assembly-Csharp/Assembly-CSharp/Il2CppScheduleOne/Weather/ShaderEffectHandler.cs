using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Effects;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Weather
{
	// Token: 0x020006DB RID: 1755
	public class ShaderEffectHandler : EffectHandler
	{
		// Token: 0x0600A90F RID: 43279 RVA: 0x002CB448 File Offset: 0x002C9648
		// Note: this type is marked as 'beforefieldinit'.
		static ShaderEffectHandler()
		{
			Il2CppClassPointerStore<ShaderEffectHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Weather", "ShaderEffectHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderEffectHandler>.NativeClassPtr);
			ShaderEffectHandler.NativeFieldInfoPtr__meshRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderEffectHandler>.NativeClassPtr, "_meshRenderers");
			ShaderEffectHandler.NativeFieldInfoPtr__propertyBlocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderEffectHandler>.NativeClassPtr, "_propertyBlocks");
			ShaderEffectHandler.NativeMethodInfoPtr_Initialise_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderEffectHandler>.NativeClassPtr, 100685705);
			ShaderEffectHandler.NativeMethodInfoPtr_Activate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderEffectHandler>.NativeClassPtr, 100685706);
			ShaderEffectHandler.NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderEffectHandler>.NativeClassPtr, 100685707);
			ShaderEffectHandler.NativeMethodInfoPtr_SetVectorParameterForAll_Public_Virtual_Void_String_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderEffectHandler>.NativeClassPtr, 100685708);
			ShaderEffectHandler.NativeMethodInfoPtr_SetVectorParameterForAll_Public_Virtual_Void_String_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderEffectHandler>.NativeClassPtr, 100685709);
			ShaderEffectHandler.NativeMethodInfoPtr_SetNumericParameter_Public_Virtual_Void_String_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderEffectHandler>.NativeClassPtr, 100685710);
			ShaderEffectHandler.NativeMethodInfoPtr_SetNumericParameterForAll_Public_Virtual_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderEffectHandler>.NativeClassPtr, 100685711);
			ShaderEffectHandler.NativeMethodInfoPtr_SetVectorParameter_Public_Virtual_Void_String_String_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderEffectHandler>.NativeClassPtr, 100685712);
			ShaderEffectHandler.NativeMethodInfoPtr_SetVectorParameter_Public_Virtual_Void_String_String_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderEffectHandler>.NativeClassPtr, 100685713);
			ShaderEffectHandler.NativeMethodInfoPtr_SetColorParameterForAll_Public_Virtual_Void_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderEffectHandler>.NativeClassPtr, 100685714);
			ShaderEffectHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderEffectHandler>.NativeClassPtr, 100685715);
		}

		// Token: 0x0600A910 RID: 43280 RVA: 0x002CB57C File Offset: 0x002C977C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292851, XrefRangeEnd = 292867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialise()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShaderEffectHandler.NativeMethodInfoPtr_Initialise_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A911 RID: 43281 RVA: 0x002CB5B8 File Offset: 0x002C97B8
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Activate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShaderEffectHandler.NativeMethodInfoPtr_Activate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A912 RID: 43282 RVA: 0x002CB5F4 File Offset: 0x002C97F4
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Deactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShaderEffectHandler.NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A913 RID: 43283 RVA: 0x002CB630 File Offset: 0x002C9830
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetVectorParameterForAll(string variable, Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(variable);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShaderEffectHandler.NativeMethodInfoPtr_SetVectorParameterForAll_Public_Virtual_Void_String_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A914 RID: 43284 RVA: 0x002CB68C File Offset: 0x002C988C
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetVectorParameterForAll(string variable, Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(variable);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShaderEffectHandler.NativeMethodInfoPtr_SetVectorParameterForAll_Public_Virtual_Void_String_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A915 RID: 43285 RVA: 0x002CB6E8 File Offset: 0x002C98E8
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetNumericParameter(string effectName, string variable, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(effectName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(variable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShaderEffectHandler.NativeMethodInfoPtr_SetNumericParameter_Public_Virtual_Void_String_String_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A916 RID: 43286 RVA: 0x002CB758 File Offset: 0x002C9958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292867, XrefRangeEnd = 292875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetNumericParameterForAll(string variable, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(variable);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShaderEffectHandler.NativeMethodInfoPtr_SetNumericParameterForAll_Public_Virtual_Void_String_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A917 RID: 43287 RVA: 0x002CB7B4 File Offset: 0x002C99B4
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetVectorParameter(string effectName, string variable, Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(effectName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(variable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShaderEffectHandler.NativeMethodInfoPtr_SetVectorParameter_Public_Virtual_Void_String_String_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A918 RID: 43288 RVA: 0x002CB824 File Offset: 0x002C9A24
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetVectorParameter(string effectName, string variable, Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(effectName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(variable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShaderEffectHandler.NativeMethodInfoPtr_SetVectorParameter_Public_Virtual_Void_String_String_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A919 RID: 43289 RVA: 0x002CB894 File Offset: 0x002C9A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292875, XrefRangeEnd = 292883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetColorParameterForAll(string variable, Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(variable);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShaderEffectHandler.NativeMethodInfoPtr_SetColorParameterForAll_Public_Virtual_Void_String_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A91A RID: 43290 RVA: 0x002CB8F0 File Offset: 0x002C9AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShaderEffectHandler() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShaderEffectHandler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderEffectHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A91B RID: 43291 RVA: 0x0004D0AE File Offset: 0x0004B2AE
		public ShaderEffectHandler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003286 RID: 12934
		// (get) Token: 0x0600A91C RID: 43292 RVA: 0x002CB92C File Offset: 0x002C9B2C
		// (set) Token: 0x0600A91D RID: 43293 RVA: 0x0004D0B7 File Offset: 0x0004B2B7
		public unsafe List<MeshRenderer> _meshRenderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderEffectHandler.NativeFieldInfoPtr__meshRenderers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderEffectHandler.NativeFieldInfoPtr__meshRenderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003287 RID: 12935
		// (get) Token: 0x0600A91E RID: 43294 RVA: 0x002CB95C File Offset: 0x002C9B5C
		// (set) Token: 0x0600A91F RID: 43295 RVA: 0x0004D0D6 File Offset: 0x0004B2D6
		public unsafe Il2CppReferenceArray<MaterialPropertyBlock> _propertyBlocks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderEffectHandler.NativeFieldInfoPtr__propertyBlocks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MaterialPropertyBlock>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderEffectHandler.NativeFieldInfoPtr__propertyBlocks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040074D8 RID: 29912
		private static readonly IntPtr NativeFieldInfoPtr__meshRenderers;

		// Token: 0x040074D9 RID: 29913
		private static readonly IntPtr NativeFieldInfoPtr__propertyBlocks;

		// Token: 0x040074DA RID: 29914
		private static readonly IntPtr NativeMethodInfoPtr_Initialise_Public_Virtual_Void_0;

		// Token: 0x040074DB RID: 29915
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Virtual_Void_0;

		// Token: 0x040074DC RID: 29916
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0;

		// Token: 0x040074DD RID: 29917
		private static readonly IntPtr NativeMethodInfoPtr_SetVectorParameterForAll_Public_Virtual_Void_String_Vector3_0;

		// Token: 0x040074DE RID: 29918
		private static readonly IntPtr NativeMethodInfoPtr_SetVectorParameterForAll_Public_Virtual_Void_String_Vector2_0;

		// Token: 0x040074DF RID: 29919
		private static readonly IntPtr NativeMethodInfoPtr_SetNumericParameter_Public_Virtual_Void_String_String_Single_0;

		// Token: 0x040074E0 RID: 29920
		private static readonly IntPtr NativeMethodInfoPtr_SetNumericParameterForAll_Public_Virtual_Void_String_Single_0;

		// Token: 0x040074E1 RID: 29921
		private static readonly IntPtr NativeMethodInfoPtr_SetVectorParameter_Public_Virtual_Void_String_String_Vector3_0;

		// Token: 0x040074E2 RID: 29922
		private static readonly IntPtr NativeMethodInfoPtr_SetVectorParameter_Public_Virtual_Void_String_String_Vector2_0;

		// Token: 0x040074E3 RID: 29923
		private static readonly IntPtr NativeMethodInfoPtr_SetColorParameterForAll_Public_Virtual_Void_String_Color_0;

		// Token: 0x040074E4 RID: 29924
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
