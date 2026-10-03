using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

namespace Il2CppScheduleOne.Effects
{
	// Token: 0x020006A6 RID: 1702
	public class VFXEffectHandler : EffectHandler
	{
		// Token: 0x0600A5ED RID: 42477 RVA: 0x002C0488 File Offset: 0x002BE688
		// Note: this type is marked as 'beforefieldinit'.
		static VFXEffectHandler()
		{
			Il2CppClassPointerStore<VFXEffectHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Effects", "VFXEffectHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXEffectHandler>.NativeClassPtr);
			VFXEffectHandler.NativeFieldInfoPtr__visualEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXEffectHandler>.NativeClassPtr, "_visualEffects");
			VFXEffectHandler.NativeMethodInfoPtr_Activate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEffectHandler>.NativeClassPtr, 100685302);
			VFXEffectHandler.NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEffectHandler>.NativeClassPtr, 100685303);
			VFXEffectHandler.NativeMethodInfoPtr_SetColorParameterForAll_Public_Virtual_Void_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEffectHandler>.NativeClassPtr, 100685304);
			VFXEffectHandler.NativeMethodInfoPtr_SetNumericParameter_Public_Virtual_Void_String_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEffectHandler>.NativeClassPtr, 100685305);
			VFXEffectHandler.NativeMethodInfoPtr_SetNumericParameterForAll_Public_Virtual_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEffectHandler>.NativeClassPtr, 100685306);
			VFXEffectHandler.NativeMethodInfoPtr_SetVectorParameter_Public_Virtual_Void_String_String_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEffectHandler>.NativeClassPtr, 100685307);
			VFXEffectHandler.NativeMethodInfoPtr_SetVectorParameter_Public_Virtual_Void_String_String_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEffectHandler>.NativeClassPtr, 100685308);
			VFXEffectHandler.NativeMethodInfoPtr_SetVectorParameterForAll_Public_Virtual_Void_String_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEffectHandler>.NativeClassPtr, 100685309);
			VFXEffectHandler.NativeMethodInfoPtr_SetVectorParameterForAll_Public_Virtual_Void_String_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEffectHandler>.NativeClassPtr, 100685310);
			VFXEffectHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEffectHandler>.NativeClassPtr, 100685311);
		}

		// Token: 0x0600A5EE RID: 42478 RVA: 0x002C0594 File Offset: 0x002BE794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289777, XrefRangeEnd = 289796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Activate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VFXEffectHandler.NativeMethodInfoPtr_Activate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5EF RID: 42479 RVA: 0x002C05D0 File Offset: 0x002BE7D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289796, XrefRangeEnd = 289815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Deactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VFXEffectHandler.NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5F0 RID: 42480 RVA: 0x002C060C File Offset: 0x002BE80C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289815, XrefRangeEnd = 289831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetColorParameterForAll(string variable, Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(variable);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VFXEffectHandler.NativeMethodInfoPtr_SetColorParameterForAll_Public_Virtual_Void_String_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5F1 RID: 42481 RVA: 0x002C0668 File Offset: 0x002BE868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289831, XrefRangeEnd = 289846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetNumericParameter(string effectName, string variable, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(effectName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(variable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VFXEffectHandler.NativeMethodInfoPtr_SetNumericParameter_Public_Virtual_Void_String_String_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5F2 RID: 42482 RVA: 0x002C06D8 File Offset: 0x002BE8D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289846, XrefRangeEnd = 289862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetNumericParameterForAll(string variable, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(variable);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VFXEffectHandler.NativeMethodInfoPtr_SetNumericParameterForAll_Public_Virtual_Void_String_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5F3 RID: 42483 RVA: 0x002C0734 File Offset: 0x002BE934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289862, XrefRangeEnd = 289877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetVectorParameter(string effectName, string variable, Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(effectName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(variable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VFXEffectHandler.NativeMethodInfoPtr_SetVectorParameter_Public_Virtual_Void_String_String_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5F4 RID: 42484 RVA: 0x002C07A4 File Offset: 0x002BE9A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289877, XrefRangeEnd = 289892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetVectorParameter(string effectName, string variable, Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(effectName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(variable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VFXEffectHandler.NativeMethodInfoPtr_SetVectorParameter_Public_Virtual_Void_String_String_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5F5 RID: 42485 RVA: 0x002C0814 File Offset: 0x002BEA14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289892, XrefRangeEnd = 289908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetVectorParameterForAll(string variable, Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(variable);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VFXEffectHandler.NativeMethodInfoPtr_SetVectorParameterForAll_Public_Virtual_Void_String_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5F6 RID: 42486 RVA: 0x002C0870 File Offset: 0x002BEA70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289908, XrefRangeEnd = 289924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetVectorParameterForAll(string variable, Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(variable);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VFXEffectHandler.NativeMethodInfoPtr_SetVectorParameterForAll_Public_Virtual_Void_String_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5F7 RID: 42487 RVA: 0x002C08CC File Offset: 0x002BEACC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 289751, RefRangeEnd = 289753, XrefRangeStart = 289751, XrefRangeEnd = 289753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VFXEffectHandler() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VFXEffectHandler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXEffectHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5F8 RID: 42488 RVA: 0x0004BC48 File Offset: 0x00049E48
		public VFXEffectHandler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170031CD RID: 12749
		// (get) Token: 0x0600A5F9 RID: 42489 RVA: 0x002C0908 File Offset: 0x002BEB08
		// (set) Token: 0x0600A5FA RID: 42490 RVA: 0x0004BC51 File Offset: 0x00049E51
		public unsafe List<VisualEffect> _visualEffects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXEffectHandler.NativeFieldInfoPtr__visualEffects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VisualEffect>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXEffectHandler.NativeFieldInfoPtr__visualEffects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040072C4 RID: 29380
		private static readonly IntPtr NativeFieldInfoPtr__visualEffects;

		// Token: 0x040072C5 RID: 29381
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Virtual_Void_0;

		// Token: 0x040072C6 RID: 29382
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0;

		// Token: 0x040072C7 RID: 29383
		private static readonly IntPtr NativeMethodInfoPtr_SetColorParameterForAll_Public_Virtual_Void_String_Color_0;

		// Token: 0x040072C8 RID: 29384
		private static readonly IntPtr NativeMethodInfoPtr_SetNumericParameter_Public_Virtual_Void_String_String_Single_0;

		// Token: 0x040072C9 RID: 29385
		private static readonly IntPtr NativeMethodInfoPtr_SetNumericParameterForAll_Public_Virtual_Void_String_Single_0;

		// Token: 0x040072CA RID: 29386
		private static readonly IntPtr NativeMethodInfoPtr_SetVectorParameter_Public_Virtual_Void_String_String_Vector3_0;

		// Token: 0x040072CB RID: 29387
		private static readonly IntPtr NativeMethodInfoPtr_SetVectorParameter_Public_Virtual_Void_String_String_Vector2_0;

		// Token: 0x040072CC RID: 29388
		private static readonly IntPtr NativeMethodInfoPtr_SetVectorParameterForAll_Public_Virtual_Void_String_Vector3_0;

		// Token: 0x040072CD RID: 29389
		private static readonly IntPtr NativeMethodInfoPtr_SetVectorParameterForAll_Public_Virtual_Void_String_Vector2_0;

		// Token: 0x040072CE RID: 29390
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C76 RID: 3190
		[ObfuscatedName("ScheduleOne.Effects.VFXEffectHandler+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600F1F8 RID: 61944 RVA: 0x003A56B0 File Offset: 0x003A38B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<VFXEffectHandler.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VFXEffectHandler>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXEffectHandler.__c>.NativeClassPtr);
				VFXEffectHandler.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXEffectHandler.__c>.NativeClassPtr, "<>9");
				VFXEffectHandler.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXEffectHandler.__c>.NativeClassPtr, "<>9__1_0");
				VFXEffectHandler.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXEffectHandler.__c>.NativeClassPtr, "<>9__2_0");
				VFXEffectHandler.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEffectHandler.__c>.NativeClassPtr, 100685313);
				VFXEffectHandler.__c.NativeMethodInfoPtr__Activate_b__1_0_Internal_Void_VisualEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEffectHandler.__c>.NativeClassPtr, 100685314);
				VFXEffectHandler.__c.NativeMethodInfoPtr__Deactivate_b__2_0_Internal_Void_VisualEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEffectHandler.__c>.NativeClassPtr, 100685315);
			}

			// Token: 0x0600F1F9 RID: 61945 RVA: 0x003A5754 File Offset: 0x003A3954
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VFXEffectHandler.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXEffectHandler.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F1FA RID: 61946 RVA: 0x003A5790 File Offset: 0x003A3990
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289753, XrefRangeEnd = 289756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Activate_b__1_0(VisualEffect e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXEffectHandler.__c.NativeMethodInfoPtr__Activate_b__1_0_Internal_Void_VisualEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F1FB RID: 61947 RVA: 0x003A57D4 File Offset: 0x003A39D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289756, XrefRangeEnd = 289759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Deactivate_b__2_0(VisualEffect e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXEffectHandler.__c.NativeMethodInfoPtr__Deactivate_b__2_0_Internal_Void_VisualEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F1FC RID: 61948 RVA: 0x00072348 File Offset: 0x00070548
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004979 RID: 18809
			// (get) Token: 0x0600F1FD RID: 61949 RVA: 0x003A5818 File Offset: 0x003A3A18
			// (set) Token: 0x0600F1FE RID: 61950 RVA: 0x00072351 File Offset: 0x00070551
			public unsafe static VFXEffectHandler.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VFXEffectHandler.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VFXEffectHandler.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VFXEffectHandler.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700497A RID: 18810
			// (get) Token: 0x0600F1FF RID: 61951 RVA: 0x003A5840 File Offset: 0x003A3A40
			// (set) Token: 0x0600F200 RID: 61952 RVA: 0x00072363 File Offset: 0x00070563
			public unsafe static Action<VisualEffect> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VFXEffectHandler.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<VisualEffect>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VFXEffectHandler.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700497B RID: 18811
			// (get) Token: 0x0600F201 RID: 61953 RVA: 0x003A5868 File Offset: 0x003A3A68
			// (set) Token: 0x0600F202 RID: 61954 RVA: 0x00072375 File Offset: 0x00070575
			public unsafe static Action<VisualEffect> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VFXEffectHandler.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<VisualEffect>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VFXEffectHandler.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A3C5 RID: 41925
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A3C6 RID: 41926
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x0400A3C7 RID: 41927
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x0400A3C8 RID: 41928
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A3C9 RID: 41929
			private static readonly IntPtr NativeMethodInfoPtr__Activate_b__1_0_Internal_Void_VisualEffect_0;

			// Token: 0x0400A3CA RID: 41930
			private static readonly IntPtr NativeMethodInfoPtr__Deactivate_b__2_0_Internal_Void_VisualEffect_0;
		}

		// Token: 0x02000C77 RID: 3191
		[ObfuscatedName("ScheduleOne.Effects.VFXEffectHandler+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F203 RID: 61955 RVA: 0x003A5890 File Offset: 0x003A3A90
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<VFXEffectHandler.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VFXEffectHandler>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXEffectHandler.__c__DisplayClass4_0>.NativeClassPtr);
				VFXEffectHandler.__c__DisplayClass4_0.NativeFieldInfoPtr_effectName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXEffectHandler.__c__DisplayClass4_0>.NativeClassPtr, "effectName");
				VFXEffectHandler.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEffectHandler.__c__DisplayClass4_0>.NativeClassPtr, 100685316);
				VFXEffectHandler.__c__DisplayClass4_0.NativeMethodInfoPtr__SetNumericParameter_b__0_Internal_Boolean_VisualEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEffectHandler.__c__DisplayClass4_0>.NativeClassPtr, 100685317);
			}

			// Token: 0x0600F204 RID: 61956 RVA: 0x003A58F8 File Offset: 0x003A3AF8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VFXEffectHandler.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXEffectHandler.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F205 RID: 61957 RVA: 0x003A5934 File Offset: 0x003A3B34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289759, XrefRangeEnd = 289777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SetNumericParameter_b__0(VisualEffect e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXEffectHandler.__c__DisplayClass4_0.NativeMethodInfoPtr__SetNumericParameter_b__0_Internal_Boolean_VisualEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F206 RID: 61958 RVA: 0x00072387 File Offset: 0x00070587
			public __c__DisplayClass4_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700497C RID: 18812
			// (get) Token: 0x0600F207 RID: 61959 RVA: 0x003A5984 File Offset: 0x003A3B84
			// (set) Token: 0x0600F208 RID: 61960 RVA: 0x00072390 File Offset: 0x00070590
			public unsafe string effectName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXEffectHandler.__c__DisplayClass4_0.NativeFieldInfoPtr_effectName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXEffectHandler.__c__DisplayClass4_0.NativeFieldInfoPtr_effectName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400A3CB RID: 41931
			private static readonly IntPtr NativeFieldInfoPtr_effectName;

			// Token: 0x0400A3CC RID: 41932
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A3CD RID: 41933
			private static readonly IntPtr NativeMethodInfoPtr__SetNumericParameter_b__0_Internal_Boolean_VisualEffect_0;
		}

		// Token: 0x02000C78 RID: 3192
		[ObfuscatedName("ScheduleOne.Effects.VFXEffectHandler+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F209 RID: 61961 RVA: 0x003A59AC File Offset: 0x003A3BAC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<VFXEffectHandler.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VFXEffectHandler>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXEffectHandler.__c__DisplayClass6_0>.NativeClassPtr);
				VFXEffectHandler.__c__DisplayClass6_0.NativeFieldInfoPtr_effectName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXEffectHandler.__c__DisplayClass6_0>.NativeClassPtr, "effectName");
				VFXEffectHandler.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEffectHandler.__c__DisplayClass6_0>.NativeClassPtr, 100685318);
				VFXEffectHandler.__c__DisplayClass6_0.NativeMethodInfoPtr__SetVectorParameter_b__0_Internal_Boolean_VisualEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEffectHandler.__c__DisplayClass6_0>.NativeClassPtr, 100685319);
			}

			// Token: 0x0600F20A RID: 61962 RVA: 0x003A5A14 File Offset: 0x003A3C14
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VFXEffectHandler.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXEffectHandler.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F20B RID: 61963 RVA: 0x003A5A50 File Offset: 0x003A3C50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SetVectorParameter_b__0(VisualEffect e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXEffectHandler.__c__DisplayClass6_0.NativeMethodInfoPtr__SetVectorParameter_b__0_Internal_Boolean_VisualEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F20C RID: 61964 RVA: 0x000723AF File Offset: 0x000705AF
			public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700497D RID: 18813
			// (get) Token: 0x0600F20D RID: 61965 RVA: 0x003A5AA0 File Offset: 0x003A3CA0
			// (set) Token: 0x0600F20E RID: 61966 RVA: 0x000723B8 File Offset: 0x000705B8
			public unsafe string effectName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXEffectHandler.__c__DisplayClass6_0.NativeFieldInfoPtr_effectName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXEffectHandler.__c__DisplayClass6_0.NativeFieldInfoPtr_effectName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400A3CE RID: 41934
			private static readonly IntPtr NativeFieldInfoPtr_effectName;

			// Token: 0x0400A3CF RID: 41935
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A3D0 RID: 41936
			private static readonly IntPtr NativeMethodInfoPtr__SetVectorParameter_b__0_Internal_Boolean_VisualEffect_0;
		}

		// Token: 0x02000C79 RID: 3193
		[ObfuscatedName("ScheduleOne.Effects.VFXEffectHandler+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F20F RID: 61967 RVA: 0x003A5AC8 File Offset: 0x003A3CC8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<VFXEffectHandler.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VFXEffectHandler>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXEffectHandler.__c__DisplayClass7_0>.NativeClassPtr);
				VFXEffectHandler.__c__DisplayClass7_0.NativeFieldInfoPtr_effectName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXEffectHandler.__c__DisplayClass7_0>.NativeClassPtr, "effectName");
				VFXEffectHandler.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEffectHandler.__c__DisplayClass7_0>.NativeClassPtr, 100685320);
				VFXEffectHandler.__c__DisplayClass7_0.NativeMethodInfoPtr__SetVectorParameter_b__0_Internal_Boolean_VisualEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEffectHandler.__c__DisplayClass7_0>.NativeClassPtr, 100685321);
			}

			// Token: 0x0600F210 RID: 61968 RVA: 0x003A5B30 File Offset: 0x003A3D30
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VFXEffectHandler.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXEffectHandler.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F211 RID: 61969 RVA: 0x003A5B6C File Offset: 0x003A3D6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SetVectorParameter_b__0(VisualEffect e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXEffectHandler.__c__DisplayClass7_0.NativeMethodInfoPtr__SetVectorParameter_b__0_Internal_Boolean_VisualEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F212 RID: 61970 RVA: 0x000723D7 File Offset: 0x000705D7
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700497E RID: 18814
			// (get) Token: 0x0600F213 RID: 61971 RVA: 0x003A5BBC File Offset: 0x003A3DBC
			// (set) Token: 0x0600F214 RID: 61972 RVA: 0x000723E0 File Offset: 0x000705E0
			public unsafe string effectName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXEffectHandler.__c__DisplayClass7_0.NativeFieldInfoPtr_effectName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXEffectHandler.__c__DisplayClass7_0.NativeFieldInfoPtr_effectName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400A3D1 RID: 41937
			private static readonly IntPtr NativeFieldInfoPtr_effectName;

			// Token: 0x0400A3D2 RID: 41938
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A3D3 RID: 41939
			private static readonly IntPtr NativeMethodInfoPtr__SetVectorParameter_b__0_Internal_Boolean_VisualEffect_0;
		}
	}
}
