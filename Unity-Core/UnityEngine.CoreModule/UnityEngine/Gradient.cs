using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000F6 RID: 246
	public class Gradient : Object
	{
		// Token: 0x0600137E RID: 4990 RVA: 0x00056D4C File Offset: 0x00054F4C
		// Note: this type is marked as 'beforefieldinit'.
		static Gradient()
		{
			Il2CppClassPointerStore<Gradient>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Gradient");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Gradient>.NativeClassPtr);
			Gradient.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gradient>.NativeClassPtr, "m_Ptr");
			Gradient.NativeMethodInfoPtr_Init_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100665256);
			Gradient.NativeMethodInfoPtr_Cleanup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100665257);
			Gradient.NativeMethodInfoPtr_Internal_Equals_Private_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100665258);
			Gradient.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100665259);
			Gradient.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100665260);
			Gradient.NativeMethodInfoPtr_Evaluate_Public_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100665261);
			Gradient.NativeMethodInfoPtr_get_colorKeys_Public_get_Il2CppStructArray_1_GradientColorKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100665262);
			Gradient.NativeMethodInfoPtr_set_colorKeys_Public_set_Void_Il2CppStructArray_1_GradientColorKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100665263);
			Gradient.NativeMethodInfoPtr_get_alphaKeys_Public_get_Il2CppStructArray_1_GradientAlphaKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100665264);
			Gradient.NativeMethodInfoPtr_SetKeys_Public_Void_Il2CppStructArray_1_GradientColorKey_Il2CppStructArray_1_GradientAlphaKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100665265);
			Gradient.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100665266);
			Gradient.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Gradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100665267);
			Gradient.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100665268);
			Gradient.NativeMethodInfoPtr_Evaluate_Injected_Private_Void_Single_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100665269);
			Gradient.set_alphaKeysDelegateField = IL2CPP.ResolveICall<Gradient.set_alphaKeysDelegate>("UnityEngine.Gradient::set_alphaKeys");
			Gradient.get_modeDelegateField = IL2CPP.ResolveICall<Gradient.get_modeDelegate>("UnityEngine.Gradient::get_mode");
			Gradient.set_modeDelegateField = IL2CPP.ResolveICall<Gradient.set_modeDelegate>("UnityEngine.Gradient::set_mode");
			Gradient.get_colorSpaceDelegateField = IL2CPP.ResolveICall<Gradient.get_colorSpaceDelegate>("UnityEngine.Gradient::get_colorSpace");
			Gradient.set_colorSpaceDelegateField = IL2CPP.ResolveICall<Gradient.set_colorSpaceDelegate>("UnityEngine.Gradient::set_colorSpace");
		}

		// Token: 0x0600137F RID: 4991 RVA: 0x00056EF4 File Offset: 0x000550F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242454, XrefRangeEnd = 1242456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Init()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_Init_Private_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001380 RID: 4992 RVA: 0x00056F24 File Offset: 0x00055124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242456, XrefRangeEnd = 1242458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_Cleanup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x00056F58 File Offset: 0x00055158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242458, XrefRangeEnd = 1242460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Internal_Equals(IntPtr other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_Internal_Equals_Private_Boolean_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001382 RID: 4994 RVA: 0x00056FA4 File Offset: 0x000551A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1242463, RefRangeEnd = 1242466, XrefRangeStart = 1242460, XrefRangeEnd = 1242463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Gradient() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Gradient>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001383 RID: 4995 RVA: 0x00056FE0 File Offset: 0x000551E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242466, XrefRangeEnd = 1242471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Gradient.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001384 RID: 4996 RVA: 0x0005701C File Offset: 0x0005521C
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 1242473, RefRangeEnd = 1242494, XrefRangeStart = 1242471, XrefRangeEnd = 1242473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color Evaluate(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_Evaluate_Public_Color_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06001385 RID: 4997 RVA: 0x00057068 File Offset: 0x00055268
		// (set) Token: 0x06001386 RID: 4998 RVA: 0x000570A8 File Offset: 0x000552A8
		public unsafe Il2CppStructArray<GradientColorKey> colorKeys
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 1242496, RefRangeEnd = 1242506, XrefRangeStart = 1242494, XrefRangeEnd = 1242496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_get_colorKeys_Public_get_Il2CppStructArray_1_GradientColorKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<GradientColorKey>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1242508, RefRangeEnd = 1242509, XrefRangeStart = 1242506, XrefRangeEnd = 1242508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_set_colorKeys_Public_set_Void_Il2CppStructArray_1_GradientColorKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06001387 RID: 4999 RVA: 0x000570EC File Offset: 0x000552EC
		// (set) Token: 0x06001390 RID: 5008 RVA: 0x0000A7FE File Offset: 0x000089FE
		public unsafe Il2CppStructArray<GradientAlphaKey> alphaKeys
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 1242511, RefRangeEnd = 1242521, XrefRangeStart = 1242509, XrefRangeEnd = 1242511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_get_alphaKeys_Public_get_Il2CppStructArray_1_GradientAlphaKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<GradientAlphaKey>>(intPtr3) : null;
			}
			set
			{
				Gradient.set_alphaKeysDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x0005712C File Offset: 0x0005532C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1242523, RefRangeEnd = 1242526, XrefRangeStart = 1242521, XrefRangeEnd = 1242523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetKeys(Il2CppStructArray<GradientColorKey> colorKeys, Il2CppStructArray<GradientAlphaKey> alphaKeys)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(colorKeys);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(alphaKeys);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_SetKeys_Public_Void_Il2CppStructArray_1_GradientColorKey_Il2CppStructArray_1_GradientAlphaKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x00057180 File Offset: 0x00055380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242526, XrefRangeEnd = 1242540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Gradient.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600138A RID: 5002 RVA: 0x000571D8 File Offset: 0x000553D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242540, XrefRangeEnd = 1242546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Equals(Gradient other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Gradient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600138B RID: 5003 RVA: 0x00057228 File Offset: 0x00055428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242546, XrefRangeEnd = 1242547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Gradient.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600138C RID: 5004 RVA: 0x00057270 File Offset: 0x00055470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242547, XrefRangeEnd = 1242549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Evaluate_Injected(float time, out Color ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_Evaluate_Injected_Private_Void_Single_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600138D RID: 5005 RVA: 0x0000A7DA File Offset: 0x000089DA
		public Gradient(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x0600138E RID: 5006 RVA: 0x000572BC File Offset: 0x000554BC
		// (set) Token: 0x0600138F RID: 5007 RVA: 0x0000A7E3 File Offset: 0x000089E3
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gradient.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gradient.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06001391 RID: 5009 RVA: 0x0000A816 File Offset: 0x00008A16
		// (set) Token: 0x06001392 RID: 5010 RVA: 0x0000A828 File Offset: 0x00008A28
		public GradientMode mode
		{
			get
			{
				return Gradient.get_modeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Gradient.set_modeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06001393 RID: 5011 RVA: 0x0000A83B File Offset: 0x00008A3B
		// (set) Token: 0x06001394 RID: 5012 RVA: 0x0000A84D File Offset: 0x00008A4D
		public ColorSpace colorSpace
		{
			get
			{
				return Gradient.get_colorSpaceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Gradient.set_colorSpaceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x04001116 RID: 4374
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04001117 RID: 4375
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Static_IntPtr_0;

		// Token: 0x04001118 RID: 4376
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Private_Void_0;

		// Token: 0x04001119 RID: 4377
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Equals_Private_Boolean_IntPtr_0;

		// Token: 0x0400111A RID: 4378
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400111B RID: 4379
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x0400111C RID: 4380
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Color_Single_0;

		// Token: 0x0400111D RID: 4381
		private static readonly IntPtr NativeMethodInfoPtr_get_colorKeys_Public_get_Il2CppStructArray_1_GradientColorKey_0;

		// Token: 0x0400111E RID: 4382
		private static readonly IntPtr NativeMethodInfoPtr_set_colorKeys_Public_set_Void_Il2CppStructArray_1_GradientColorKey_0;

		// Token: 0x0400111F RID: 4383
		private static readonly IntPtr NativeMethodInfoPtr_get_alphaKeys_Public_get_Il2CppStructArray_1_GradientAlphaKey_0;

		// Token: 0x04001120 RID: 4384
		private static readonly IntPtr NativeMethodInfoPtr_SetKeys_Public_Void_Il2CppStructArray_1_GradientColorKey_Il2CppStructArray_1_GradientAlphaKey_0;

		// Token: 0x04001121 RID: 4385
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001122 RID: 4386
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Gradient_0;

		// Token: 0x04001123 RID: 4387
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001124 RID: 4388
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Injected_Private_Void_Single_byref_Color_0;

		// Token: 0x04001125 RID: 4389
		private static readonly Gradient.set_alphaKeysDelegate set_alphaKeysDelegateField;

		// Token: 0x04001126 RID: 4390
		private static readonly Gradient.get_modeDelegate get_modeDelegateField;

		// Token: 0x04001127 RID: 4391
		private static readonly Gradient.set_modeDelegate set_modeDelegateField;

		// Token: 0x04001128 RID: 4392
		private static readonly Gradient.get_colorSpaceDelegate get_colorSpaceDelegateField;

		// Token: 0x04001129 RID: 4393
		private static readonly Gradient.set_colorSpaceDelegate set_colorSpaceDelegateField;

		// Token: 0x02000871 RID: 2161
		// (Invoke) Token: 0x06003975 RID: 14709
		private delegate void set_alphaKeysDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000872 RID: 2162
		// (Invoke) Token: 0x06003977 RID: 14711
		private delegate GradientMode get_modeDelegate(IntPtr @this);

		// Token: 0x02000873 RID: 2163
		// (Invoke) Token: 0x06003979 RID: 14713
		private delegate void set_modeDelegate(IntPtr @this, GradientMode value);

		// Token: 0x02000874 RID: 2164
		// (Invoke) Token: 0x0600397B RID: 14715
		private delegate ColorSpace get_colorSpaceDelegate(IntPtr @this);

		// Token: 0x02000875 RID: 2165
		// (Invoke) Token: 0x0600397D RID: 14717
		private delegate void set_colorSpaceDelegate(IntPtr @this, ColorSpace value);
	}
}
