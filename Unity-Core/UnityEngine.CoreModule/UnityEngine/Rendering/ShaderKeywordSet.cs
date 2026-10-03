using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000247 RID: 583
	[StructLayout(2)]
	public struct ShaderKeywordSet
	{
		// Token: 0x06002890 RID: 10384 RVA: 0x0009EEEC File Offset: 0x0009D0EC
		// Note: this type is marked as 'beforefieldinit'.
		static ShaderKeywordSet()
		{
			Il2CppClassPointerStore<ShaderKeywordSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "ShaderKeywordSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderKeywordSet>.NativeClassPtr);
			ShaderKeywordSet.NativeFieldInfoPtr_m_KeywordState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordSet>.NativeClassPtr, "m_KeywordState");
			ShaderKeywordSet.NativeFieldInfoPtr_m_Shader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordSet>.NativeClassPtr, "m_Shader");
			ShaderKeywordSet.NativeFieldInfoPtr_m_ComputeShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordSet>.NativeClassPtr, "m_ComputeShader");
			ShaderKeywordSet.NativeFieldInfoPtr_m_StateIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordSet>.NativeClassPtr, "m_StateIndex");
			ShaderKeywordSet.NativeMethodInfoPtr_IsKeywordNameEnabled_Private_Static_Boolean_ShaderKeywordSet_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeywordSet>.NativeClassPtr, 100667637);
			ShaderKeywordSet.NativeMethodInfoPtr_CheckKeywordCompatible_Private_Void_ShaderKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeywordSet>.NativeClassPtr, 100667638);
			ShaderKeywordSet.NativeMethodInfoPtr_IsEnabled_Public_Boolean_ShaderKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeywordSet>.NativeClassPtr, 100667639);
			ShaderKeywordSet.NativeMethodInfoPtr_IsKeywordNameEnabled_Injected_Private_Static_Boolean_byref_ShaderKeywordSet_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeywordSet>.NativeClassPtr, 100667640);
			ShaderKeywordSet.IsGlobalKeywordEnabled_InjectedDelegateField = IL2CPP.ResolveICall<ShaderKeywordSet.IsGlobalKeywordEnabled_InjectedDelegate>("UnityEngine.Rendering.ShaderKeywordSet::IsGlobalKeywordEnabled_Injected");
			ShaderKeywordSet.IsKeywordEnabled_InjectedDelegateField = IL2CPP.ResolveICall<ShaderKeywordSet.IsKeywordEnabled_InjectedDelegate>("UnityEngine.Rendering.ShaderKeywordSet::IsKeywordEnabled_Injected");
			ShaderKeywordSet.EnableGlobalKeyword_InjectedDelegateField = IL2CPP.ResolveICall<ShaderKeywordSet.EnableGlobalKeyword_InjectedDelegate>("UnityEngine.Rendering.ShaderKeywordSet::EnableGlobalKeyword_Injected");
			ShaderKeywordSet.EnableKeywordName_InjectedDelegateField = IL2CPP.ResolveICall<ShaderKeywordSet.EnableKeywordName_InjectedDelegate>("UnityEngine.Rendering.ShaderKeywordSet::EnableKeywordName_Injected");
			ShaderKeywordSet.DisableGlobalKeyword_InjectedDelegateField = IL2CPP.ResolveICall<ShaderKeywordSet.DisableGlobalKeyword_InjectedDelegate>("UnityEngine.Rendering.ShaderKeywordSet::DisableGlobalKeyword_Injected");
			ShaderKeywordSet.DisableKeywordName_InjectedDelegateField = IL2CPP.ResolveICall<ShaderKeywordSet.DisableKeywordName_InjectedDelegate>("UnityEngine.Rendering.ShaderKeywordSet::DisableKeywordName_Injected");
			ShaderKeywordSet.GetEnabledKeywords_InjectedDelegateField = IL2CPP.ResolveICall<ShaderKeywordSet.GetEnabledKeywords_InjectedDelegate>("UnityEngine.Rendering.ShaderKeywordSet::GetEnabledKeywords_Injected");
		}

		// Token: 0x06002891 RID: 10385 RVA: 0x0009F028 File Offset: 0x0009D228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292419, XrefRangeEnd = 1292421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsKeywordNameEnabled(ShaderKeywordSet state, string name)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderKeywordSet.NativeMethodInfoPtr_IsKeywordNameEnabled_Private_Static_Boolean_ShaderKeywordSet_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002892 RID: 10386 RVA: 0x0009F078 File Offset: 0x0009D278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292421, XrefRangeEnd = 1292430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckKeywordCompatible(ShaderKeyword keyword)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(keyword));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderKeywordSet.NativeMethodInfoPtr_CheckKeywordCompatible_Private_Void_ShaderKeyword_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002893 RID: 10387 RVA: 0x0009F0B4 File Offset: 0x0009D2B4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1292441, RefRangeEnd = 1292445, XrefRangeStart = 1292430, XrefRangeEnd = 1292441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsEnabled(ShaderKeyword keyword)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(keyword));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderKeywordSet.NativeMethodInfoPtr_IsEnabled_Public_Boolean_ShaderKeyword_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002894 RID: 10388 RVA: 0x0009F0FC File Offset: 0x0009D2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292445, XrefRangeEnd = 1292447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsKeywordNameEnabled_Injected(ref ShaderKeywordSet state, string name)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &state;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderKeywordSet.NativeMethodInfoPtr_IsKeywordNameEnabled_Injected_Private_Static_Boolean_byref_ShaderKeywordSet_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002895 RID: 10389 RVA: 0x0001228E File Offset: 0x0001048E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShaderKeywordSet>.NativeClassPtr, ref this));
		}

		// Token: 0x06002896 RID: 10390 RVA: 0x000122A0 File Offset: 0x000104A0
		public static bool IsGlobalKeywordEnabled(ShaderKeywordSet state, uint index)
		{
			return ShaderKeywordSet.IsGlobalKeywordEnabled_Injected(ref state, index);
		}

		// Token: 0x06002897 RID: 10391 RVA: 0x000122AA File Offset: 0x000104AA
		public static bool IsKeywordEnabled(ShaderKeywordSet state, LocalKeywordSpace keywordSpace, uint index)
		{
			return ShaderKeywordSet.IsKeywordEnabled_Injected(ref state, ref keywordSpace, index);
		}

		// Token: 0x06002898 RID: 10392 RVA: 0x000122B6 File Offset: 0x000104B6
		public static void EnableGlobalKeyword(ShaderKeywordSet state, uint index)
		{
			ShaderKeywordSet.EnableGlobalKeyword_Injected(ref state, index);
		}

		// Token: 0x06002899 RID: 10393 RVA: 0x000122C0 File Offset: 0x000104C0
		public static void EnableKeywordName(ShaderKeywordSet state, string name)
		{
			ShaderKeywordSet.EnableKeywordName_Injected(ref state, name);
		}

		// Token: 0x0600289A RID: 10394 RVA: 0x000122CA File Offset: 0x000104CA
		public static void DisableGlobalKeyword(ShaderKeywordSet state, uint index)
		{
			ShaderKeywordSet.DisableGlobalKeyword_Injected(ref state, index);
		}

		// Token: 0x0600289B RID: 10395 RVA: 0x000122D4 File Offset: 0x000104D4
		public static void DisableKeywordName(ShaderKeywordSet state, string name)
		{
			ShaderKeywordSet.DisableKeywordName_Injected(ref state, name);
		}

		// Token: 0x0600289C RID: 10396 RVA: 0x000122DE File Offset: 0x000104DE
		public static Il2CppReferenceArray<ShaderKeyword> GetEnabledKeywords(ShaderKeywordSet state)
		{
			return ShaderKeywordSet.GetEnabledKeywords_Injected(ref state);
		}

		// Token: 0x0600289D RID: 10397 RVA: 0x0009F14C File Offset: 0x0009D34C
		public bool IsEnabled(LocalKeyword keyword)
		{
			return ShaderKeywordSet.IsKeywordEnabled(this, keyword.m_SpaceInfo, keyword.m_Index);
		}

		// Token: 0x0600289E RID: 10398 RVA: 0x0009F178 File Offset: 0x0009D378
		public void Enable(ShaderKeyword keyword)
		{
			this.CheckKeywordCompatible(keyword);
			bool flag = keyword.m_IsLocal || !keyword.IsValid();
			if (flag)
			{
				ShaderKeywordSet.EnableKeywordName(this, keyword.m_Name);
			}
			else
			{
				ShaderKeywordSet.EnableGlobalKeyword(this, keyword.m_Index);
			}
		}

		// Token: 0x0600289F RID: 10399 RVA: 0x0009F1D0 File Offset: 0x0009D3D0
		public void Disable(ShaderKeyword keyword)
		{
			bool flag = keyword.m_IsLocal || !keyword.IsValid();
			if (flag)
			{
				ShaderKeywordSet.DisableKeywordName(this, keyword.m_Name);
			}
			else
			{
				ShaderKeywordSet.DisableGlobalKeyword(this, keyword.m_Index);
			}
		}

		// Token: 0x060028A0 RID: 10400 RVA: 0x0009F220 File Offset: 0x0009D420
		public Il2CppReferenceArray<ShaderKeyword> GetShaderKeywords()
		{
			return ShaderKeywordSet.GetEnabledKeywords(this);
		}

		// Token: 0x060028A1 RID: 10401 RVA: 0x000122E7 File Offset: 0x000104E7
		public static bool IsGlobalKeywordEnabled_Injected(ref ShaderKeywordSet state, uint index)
		{
			return ShaderKeywordSet.IsGlobalKeywordEnabled_InjectedDelegateField(ref state, index);
		}

		// Token: 0x060028A2 RID: 10402 RVA: 0x000122F5 File Offset: 0x000104F5
		public static bool IsKeywordEnabled_Injected(ref ShaderKeywordSet state, ref LocalKeywordSpace keywordSpace, uint index)
		{
			return ShaderKeywordSet.IsKeywordEnabled_InjectedDelegateField(ref state, ref keywordSpace, index);
		}

		// Token: 0x060028A3 RID: 10403 RVA: 0x00012304 File Offset: 0x00010504
		public static void EnableGlobalKeyword_Injected(ref ShaderKeywordSet state, uint index)
		{
			ShaderKeywordSet.EnableGlobalKeyword_InjectedDelegateField(ref state, index);
		}

		// Token: 0x060028A4 RID: 10404 RVA: 0x00012312 File Offset: 0x00010512
		public static void EnableKeywordName_Injected(ref ShaderKeywordSet state, string name)
		{
			ShaderKeywordSet.EnableKeywordName_InjectedDelegateField(ref state, IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x060028A5 RID: 10405 RVA: 0x00012325 File Offset: 0x00010525
		public static void DisableGlobalKeyword_Injected(ref ShaderKeywordSet state, uint index)
		{
			ShaderKeywordSet.DisableGlobalKeyword_InjectedDelegateField(ref state, index);
		}

		// Token: 0x060028A6 RID: 10406 RVA: 0x00012333 File Offset: 0x00010533
		public static void DisableKeywordName_Injected(ref ShaderKeywordSet state, string name)
		{
			ShaderKeywordSet.DisableKeywordName_InjectedDelegateField(ref state, IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x060028A7 RID: 10407 RVA: 0x0009F240 File Offset: 0x0009D440
		public static Il2CppReferenceArray<ShaderKeyword> GetEnabledKeywords_Injected(ref ShaderKeywordSet state)
		{
			IntPtr intPtr = ShaderKeywordSet.GetEnabledKeywords_InjectedDelegateField(ref state);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ShaderKeyword>>(intPtr2) : null;
		}

		// Token: 0x0400227F RID: 8831
		private static readonly IntPtr NativeFieldInfoPtr_m_KeywordState;

		// Token: 0x04002280 RID: 8832
		private static readonly IntPtr NativeFieldInfoPtr_m_Shader;

		// Token: 0x04002281 RID: 8833
		private static readonly IntPtr NativeFieldInfoPtr_m_ComputeShader;

		// Token: 0x04002282 RID: 8834
		private static readonly IntPtr NativeFieldInfoPtr_m_StateIndex;

		// Token: 0x04002283 RID: 8835
		private static readonly IntPtr NativeMethodInfoPtr_IsKeywordNameEnabled_Private_Static_Boolean_ShaderKeywordSet_String_0;

		// Token: 0x04002284 RID: 8836
		private static readonly IntPtr NativeMethodInfoPtr_CheckKeywordCompatible_Private_Void_ShaderKeyword_0;

		// Token: 0x04002285 RID: 8837
		private static readonly IntPtr NativeMethodInfoPtr_IsEnabled_Public_Boolean_ShaderKeyword_0;

		// Token: 0x04002286 RID: 8838
		private static readonly IntPtr NativeMethodInfoPtr_IsKeywordNameEnabled_Injected_Private_Static_Boolean_byref_ShaderKeywordSet_String_0;

		// Token: 0x04002287 RID: 8839
		[FieldOffset(0)]
		public IntPtr m_KeywordState;

		// Token: 0x04002288 RID: 8840
		[FieldOffset(8)]
		public IntPtr m_Shader;

		// Token: 0x04002289 RID: 8841
		[FieldOffset(16)]
		public IntPtr m_ComputeShader;

		// Token: 0x0400228A RID: 8842
		[FieldOffset(24)]
		public ulong m_StateIndex;

		// Token: 0x0400228B RID: 8843
		private static readonly ShaderKeywordSet.IsGlobalKeywordEnabled_InjectedDelegate IsGlobalKeywordEnabled_InjectedDelegateField;

		// Token: 0x0400228C RID: 8844
		private static readonly ShaderKeywordSet.IsKeywordEnabled_InjectedDelegate IsKeywordEnabled_InjectedDelegateField;

		// Token: 0x0400228D RID: 8845
		private static readonly ShaderKeywordSet.EnableGlobalKeyword_InjectedDelegate EnableGlobalKeyword_InjectedDelegateField;

		// Token: 0x0400228E RID: 8846
		private static readonly ShaderKeywordSet.EnableKeywordName_InjectedDelegate EnableKeywordName_InjectedDelegateField;

		// Token: 0x0400228F RID: 8847
		private static readonly ShaderKeywordSet.DisableGlobalKeyword_InjectedDelegate DisableGlobalKeyword_InjectedDelegateField;

		// Token: 0x04002290 RID: 8848
		private static readonly ShaderKeywordSet.DisableKeywordName_InjectedDelegate DisableKeywordName_InjectedDelegateField;

		// Token: 0x04002291 RID: 8849
		private static readonly ShaderKeywordSet.GetEnabledKeywords_InjectedDelegate GetEnabledKeywords_InjectedDelegateField;

		// Token: 0x02000B84 RID: 2948
		// (Invoke) Token: 0x06003FF1 RID: 16369
		private delegate bool IsGlobalKeywordEnabled_InjectedDelegate(IntPtr state, uint index);

		// Token: 0x02000B85 RID: 2949
		// (Invoke) Token: 0x06003FF3 RID: 16371
		private delegate bool IsKeywordEnabled_InjectedDelegate(IntPtr state, IntPtr keywordSpace, uint index);

		// Token: 0x02000B86 RID: 2950
		// (Invoke) Token: 0x06003FF5 RID: 16373
		private delegate void EnableGlobalKeyword_InjectedDelegate(IntPtr state, uint index);

		// Token: 0x02000B87 RID: 2951
		// (Invoke) Token: 0x06003FF7 RID: 16375
		private delegate void EnableKeywordName_InjectedDelegate(IntPtr state, IntPtr name);

		// Token: 0x02000B88 RID: 2952
		// (Invoke) Token: 0x06003FF9 RID: 16377
		private delegate void DisableGlobalKeyword_InjectedDelegate(IntPtr state, uint index);

		// Token: 0x02000B89 RID: 2953
		// (Invoke) Token: 0x06003FFB RID: 16379
		private delegate void DisableKeywordName_InjectedDelegate(IntPtr state, IntPtr name);

		// Token: 0x02000B8A RID: 2954
		// (Invoke) Token: 0x06003FFD RID: 16381
		private delegate IntPtr GetEnabledKeywords_InjectedDelegate(IntPtr state);
	}
}
