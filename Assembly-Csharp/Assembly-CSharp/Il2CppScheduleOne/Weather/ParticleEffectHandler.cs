using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Effects;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Weather
{
	// Token: 0x020006D8 RID: 1752
	public class ParticleEffectHandler : EffectHandler
	{
		// Token: 0x0600A8F2 RID: 43250 RVA: 0x002CACBC File Offset: 0x002C8EBC
		// Note: this type is marked as 'beforefieldinit'.
		static ParticleEffectHandler()
		{
			Il2CppClassPointerStore<ParticleEffectHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Weather", "ParticleEffectHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleEffectHandler>.NativeClassPtr);
			ParticleEffectHandler.NativeFieldInfoPtr__particleSystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleEffectHandler>.NativeClassPtr, "_particleSystems");
			ParticleEffectHandler.NativeMethodInfoPtr_Activate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleEffectHandler>.NativeClassPtr, 100685682);
			ParticleEffectHandler.NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleEffectHandler>.NativeClassPtr, 100685683);
			ParticleEffectHandler.NativeMethodInfoPtr_SetColorParameterForAll_Public_Virtual_Void_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleEffectHandler>.NativeClassPtr, 100685684);
			ParticleEffectHandler.NativeMethodInfoPtr_SetNumericParameter_Public_Virtual_Void_String_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleEffectHandler>.NativeClassPtr, 100685685);
			ParticleEffectHandler.NativeMethodInfoPtr_SetNumericParameterForAll_Public_Virtual_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleEffectHandler>.NativeClassPtr, 100685686);
			ParticleEffectHandler.NativeMethodInfoPtr_SetVectorParameter_Public_Virtual_Void_String_String_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleEffectHandler>.NativeClassPtr, 100685687);
			ParticleEffectHandler.NativeMethodInfoPtr_SetVectorParameter_Public_Virtual_Void_String_String_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleEffectHandler>.NativeClassPtr, 100685688);
			ParticleEffectHandler.NativeMethodInfoPtr_SetVectorParameterForAll_Public_Virtual_Void_String_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleEffectHandler>.NativeClassPtr, 100685689);
			ParticleEffectHandler.NativeMethodInfoPtr_SetVectorParameterForAll_Public_Virtual_Void_String_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleEffectHandler>.NativeClassPtr, 100685690);
			ParticleEffectHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleEffectHandler>.NativeClassPtr, 100685691);
		}

		// Token: 0x0600A8F3 RID: 43251 RVA: 0x002CADC8 File Offset: 0x002C8FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292709, XrefRangeEnd = 292728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Activate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ParticleEffectHandler.NativeMethodInfoPtr_Activate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A8F4 RID: 43252 RVA: 0x002CAE04 File Offset: 0x002C9004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292728, XrefRangeEnd = 292747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Deactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ParticleEffectHandler.NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A8F5 RID: 43253 RVA: 0x002CAE40 File Offset: 0x002C9040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292747, XrefRangeEnd = 292752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetColorParameterForAll(string variable, Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(variable);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ParticleEffectHandler.NativeMethodInfoPtr_SetColorParameterForAll_Public_Virtual_Void_String_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A8F6 RID: 43254 RVA: 0x002CAE9C File Offset: 0x002C909C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292752, XrefRangeEnd = 292781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetNumericParameter(string effectName, string variable, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(effectName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(variable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ParticleEffectHandler.NativeMethodInfoPtr_SetNumericParameter_Public_Virtual_Void_String_String_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A8F7 RID: 43255 RVA: 0x002CAF0C File Offset: 0x002C910C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292781, XrefRangeEnd = 292802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetNumericParameterForAll(string variable, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(variable);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ParticleEffectHandler.NativeMethodInfoPtr_SetNumericParameterForAll_Public_Virtual_Void_String_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A8F8 RID: 43256 RVA: 0x002CAF68 File Offset: 0x002C9168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292802, XrefRangeEnd = 292807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetVectorParameter(string effectName, string variable, Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(effectName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(variable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ParticleEffectHandler.NativeMethodInfoPtr_SetVectorParameter_Public_Virtual_Void_String_String_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A8F9 RID: 43257 RVA: 0x002CAFD8 File Offset: 0x002C91D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292807, XrefRangeEnd = 292812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetVectorParameter(string effectName, string variable, Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(effectName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(variable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ParticleEffectHandler.NativeMethodInfoPtr_SetVectorParameter_Public_Virtual_Void_String_String_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A8FA RID: 43258 RVA: 0x002CB048 File Offset: 0x002C9248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292812, XrefRangeEnd = 292817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetVectorParameterForAll(string variable, Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(variable);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ParticleEffectHandler.NativeMethodInfoPtr_SetVectorParameterForAll_Public_Virtual_Void_String_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A8FB RID: 43259 RVA: 0x002CB0A4 File Offset: 0x002C92A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292817, XrefRangeEnd = 292822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetVectorParameterForAll(string variable, Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(variable);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ParticleEffectHandler.NativeMethodInfoPtr_SetVectorParameterForAll_Public_Virtual_Void_String_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A8FC RID: 43260 RVA: 0x002CB100 File Offset: 0x002C9300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292822, XrefRangeEnd = 292823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParticleEffectHandler() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleEffectHandler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleEffectHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A8FD RID: 43261 RVA: 0x0004D005 File Offset: 0x0004B205
		public ParticleEffectHandler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003283 RID: 12931
		// (get) Token: 0x0600A8FE RID: 43262 RVA: 0x002CB13C File Offset: 0x002C933C
		// (set) Token: 0x0600A8FF RID: 43263 RVA: 0x0004D00E File Offset: 0x0004B20E
		public unsafe List<ParticleSystem> _particleSystems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleEffectHandler.NativeFieldInfoPtr__particleSystems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ParticleSystem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleEffectHandler.NativeFieldInfoPtr__particleSystems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040074C4 RID: 29892
		private static readonly IntPtr NativeFieldInfoPtr__particleSystems;

		// Token: 0x040074C5 RID: 29893
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Virtual_Void_0;

		// Token: 0x040074C6 RID: 29894
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0;

		// Token: 0x040074C7 RID: 29895
		private static readonly IntPtr NativeMethodInfoPtr_SetColorParameterForAll_Public_Virtual_Void_String_Color_0;

		// Token: 0x040074C8 RID: 29896
		private static readonly IntPtr NativeMethodInfoPtr_SetNumericParameter_Public_Virtual_Void_String_String_Single_0;

		// Token: 0x040074C9 RID: 29897
		private static readonly IntPtr NativeMethodInfoPtr_SetNumericParameterForAll_Public_Virtual_Void_String_Single_0;

		// Token: 0x040074CA RID: 29898
		private static readonly IntPtr NativeMethodInfoPtr_SetVectorParameter_Public_Virtual_Void_String_String_Vector3_0;

		// Token: 0x040074CB RID: 29899
		private static readonly IntPtr NativeMethodInfoPtr_SetVectorParameter_Public_Virtual_Void_String_String_Vector2_0;

		// Token: 0x040074CC RID: 29900
		private static readonly IntPtr NativeMethodInfoPtr_SetVectorParameterForAll_Public_Virtual_Void_String_Vector3_0;

		// Token: 0x040074CD RID: 29901
		private static readonly IntPtr NativeMethodInfoPtr_SetVectorParameterForAll_Public_Virtual_Void_String_Vector2_0;

		// Token: 0x040074CE RID: 29902
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C87 RID: 3207
		[ObfuscatedName("ScheduleOne.Weather.ParticleEffectHandler+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600F277 RID: 62071 RVA: 0x003A6CF8 File Offset: 0x003A4EF8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ParticleEffectHandler.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleEffectHandler>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleEffectHandler.__c>.NativeClassPtr);
				ParticleEffectHandler.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleEffectHandler.__c>.NativeClassPtr, "<>9");
				ParticleEffectHandler.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleEffectHandler.__c>.NativeClassPtr, "<>9__1_0");
				ParticleEffectHandler.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleEffectHandler.__c>.NativeClassPtr, "<>9__2_0");
				ParticleEffectHandler.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleEffectHandler.__c>.NativeClassPtr, 100685693);
				ParticleEffectHandler.__c.NativeMethodInfoPtr__Activate_b__1_0_Internal_Void_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleEffectHandler.__c>.NativeClassPtr, 100685694);
				ParticleEffectHandler.__c.NativeMethodInfoPtr__Deactivate_b__2_0_Internal_Void_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleEffectHandler.__c>.NativeClassPtr, 100685695);
			}

			// Token: 0x0600F278 RID: 62072 RVA: 0x003A6D9C File Offset: 0x003A4F9C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleEffectHandler.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleEffectHandler.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F279 RID: 62073 RVA: 0x003A6DD8 File Offset: 0x003A4FD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Activate_b__1_0(ParticleSystem ps)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ps);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleEffectHandler.__c.NativeMethodInfoPtr__Activate_b__1_0_Internal_Void_ParticleSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F27A RID: 62074 RVA: 0x003A6E1C File Offset: 0x003A501C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Deactivate_b__2_0(ParticleSystem ps)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ps);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleEffectHandler.__c.NativeMethodInfoPtr__Deactivate_b__2_0_Internal_Void_ParticleSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F27B RID: 62075 RVA: 0x000726E3 File Offset: 0x000708E3
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004998 RID: 18840
			// (get) Token: 0x0600F27C RID: 62076 RVA: 0x003A6E60 File Offset: 0x003A5060
			// (set) Token: 0x0600F27D RID: 62077 RVA: 0x000726EC File Offset: 0x000708EC
			public unsafe static ParticleEffectHandler.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ParticleEffectHandler.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleEffectHandler.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ParticleEffectHandler.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004999 RID: 18841
			// (get) Token: 0x0600F27E RID: 62078 RVA: 0x003A6E88 File Offset: 0x003A5088
			// (set) Token: 0x0600F27F RID: 62079 RVA: 0x000726FE File Offset: 0x000708FE
			public unsafe static Action<ParticleSystem> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ParticleEffectHandler.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ParticleSystem>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ParticleEffectHandler.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700499A RID: 18842
			// (get) Token: 0x0600F280 RID: 62080 RVA: 0x003A6EB0 File Offset: 0x003A50B0
			// (set) Token: 0x0600F281 RID: 62081 RVA: 0x00072710 File Offset: 0x00070910
			public unsafe static Action<ParticleSystem> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ParticleEffectHandler.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ParticleSystem>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ParticleEffectHandler.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A407 RID: 41991
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A408 RID: 41992
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x0400A409 RID: 41993
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x0400A40A RID: 41994
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A40B RID: 41995
			private static readonly IntPtr NativeMethodInfoPtr__Activate_b__1_0_Internal_Void_ParticleSystem_0;

			// Token: 0x0400A40C RID: 41996
			private static readonly IntPtr NativeMethodInfoPtr__Deactivate_b__2_0_Internal_Void_ParticleSystem_0;
		}

		// Token: 0x02000C88 RID: 3208
		[ObfuscatedName("ScheduleOne.Weather.ParticleEffectHandler+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F282 RID: 62082 RVA: 0x003A6ED8 File Offset: 0x003A50D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<ParticleEffectHandler.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleEffectHandler>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleEffectHandler.__c__DisplayClass4_0>.NativeClassPtr);
				ParticleEffectHandler.__c__DisplayClass4_0.NativeFieldInfoPtr_effectName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleEffectHandler.__c__DisplayClass4_0>.NativeClassPtr, "effectName");
				ParticleEffectHandler.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleEffectHandler.__c__DisplayClass4_0>.NativeClassPtr, 100685696);
				ParticleEffectHandler.__c__DisplayClass4_0.NativeMethodInfoPtr__SetNumericParameter_b__0_Internal_Boolean_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleEffectHandler.__c__DisplayClass4_0>.NativeClassPtr, 100685697);
			}

			// Token: 0x0600F283 RID: 62083 RVA: 0x003A6F40 File Offset: 0x003A5140
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleEffectHandler.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleEffectHandler.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F284 RID: 62084 RVA: 0x003A6F7C File Offset: 0x003A517C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SetNumericParameter_b__0(ParticleSystem p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleEffectHandler.__c__DisplayClass4_0.NativeMethodInfoPtr__SetNumericParameter_b__0_Internal_Boolean_ParticleSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F285 RID: 62085 RVA: 0x00072722 File Offset: 0x00070922
			public __c__DisplayClass4_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700499B RID: 18843
			// (get) Token: 0x0600F286 RID: 62086 RVA: 0x003A6FCC File Offset: 0x003A51CC
			// (set) Token: 0x0600F287 RID: 62087 RVA: 0x0007272B File Offset: 0x0007092B
			public unsafe string effectName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleEffectHandler.__c__DisplayClass4_0.NativeFieldInfoPtr_effectName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleEffectHandler.__c__DisplayClass4_0.NativeFieldInfoPtr_effectName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400A40D RID: 41997
			private static readonly IntPtr NativeFieldInfoPtr_effectName;

			// Token: 0x0400A40E RID: 41998
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A40F RID: 41999
			private static readonly IntPtr NativeMethodInfoPtr__SetNumericParameter_b__0_Internal_Boolean_ParticleSystem_0;
		}
	}
}
