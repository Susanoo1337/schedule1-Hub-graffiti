using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000246 RID: 582
	public sealed class ShaderKeyword : ValueType
	{
		// Token: 0x0600286A RID: 10346 RVA: 0x0009E9E8 File Offset: 0x0009CBE8
		// Note: this type is marked as 'beforefieldinit'.
		static ShaderKeyword()
		{
			Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "ShaderKeyword");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr);
			ShaderKeyword.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, "m_Name");
			ShaderKeyword.NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, "m_Index");
			ShaderKeyword.NativeFieldInfoPtr_m_IsLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, "m_IsLocal");
			ShaderKeyword.NativeFieldInfoPtr_m_IsCompute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, "m_IsCompute");
			ShaderKeyword.NativeFieldInfoPtr_m_IsValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, "m_IsValid");
			ShaderKeyword.NativeMethodInfoPtr_GetGlobalKeywordCount_Internal_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, 100667631);
			ShaderKeyword.NativeMethodInfoPtr_GetGlobalKeywordIndex_Internal_Static_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, 100667632);
			ShaderKeyword.NativeMethodInfoPtr_CreateGlobalKeyword_Internal_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, 100667633);
			ShaderKeyword.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, 100667634);
			ShaderKeyword.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, 100667635);
			ShaderKeyword.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, 100667636);
			ShaderKeyword.GetKeywordCountDelegateField = IL2CPP.ResolveICall<ShaderKeyword.GetKeywordCountDelegate>("UnityEngine.Rendering.ShaderKeyword::GetKeywordCount");
			ShaderKeyword.GetKeywordIndexDelegateField = IL2CPP.ResolveICall<ShaderKeyword.GetKeywordIndexDelegate>("UnityEngine.Rendering.ShaderKeyword::GetKeywordIndex");
			ShaderKeyword.GetComputeShaderKeywordCountDelegateField = IL2CPP.ResolveICall<ShaderKeyword.GetComputeShaderKeywordCountDelegate>("UnityEngine.Rendering.ShaderKeyword::GetComputeShaderKeywordCount");
			ShaderKeyword.GetComputeShaderKeywordIndexDelegateField = IL2CPP.ResolveICall<ShaderKeyword.GetComputeShaderKeywordIndexDelegate>("UnityEngine.Rendering.ShaderKeyword::GetComputeShaderKeywordIndex");
			ShaderKeyword.GetGlobalShaderKeywordTypeDelegateField = IL2CPP.ResolveICall<ShaderKeyword.GetGlobalShaderKeywordTypeDelegate>("UnityEngine.Rendering.ShaderKeyword::GetGlobalShaderKeywordType");
		}

		// Token: 0x0600286B RID: 10347 RVA: 0x0009EB40 File Offset: 0x0009CD40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292400, XrefRangeEnd = 1292402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetGlobalKeywordCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderKeyword.NativeMethodInfoPtr_GetGlobalKeywordCount_Internal_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600286C RID: 10348 RVA: 0x0009EB70 File Offset: 0x0009CD70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292402, XrefRangeEnd = 1292404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetGlobalKeywordIndex(string keyword)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderKeyword.NativeMethodInfoPtr_GetGlobalKeywordIndex_Internal_Static_UInt32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600286D RID: 10349 RVA: 0x0009EBB4 File Offset: 0x0009CDB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292404, XrefRangeEnd = 1292406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateGlobalKeyword(string keyword)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderKeyword.NativeMethodInfoPtr_CreateGlobalKeyword_Internal_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x0600286E RID: 10350 RVA: 0x0009EBEC File Offset: 0x0009CDEC
		public unsafe string name
		{
			[CallerCount(163)]
			[CachedScanResults(RefRangeStart = 532930, RefRangeEnd = 533093, XrefRangeStart = 532930, XrefRangeEnd = 533093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderKeyword.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600286F RID: 10351 RVA: 0x0009EC28 File Offset: 0x0009CE28
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1292415, RefRangeEnd = 1292419, XrefRangeStart = 1292406, XrefRangeEnd = 1292415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShaderKeyword(string keywordName) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(keywordName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderKeyword.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002870 RID: 10352 RVA: 0x0009EC78 File Offset: 0x0009CE78
		[CallerCount(163)]
		[CachedScanResults(RefRangeStart = 532930, RefRangeEnd = 533093, XrefRangeStart = 532930, XrefRangeEnd = 533093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderKeyword.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002871 RID: 10353 RVA: 0x00012187 File Offset: 0x00010387
		public ShaderKeyword(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06002872 RID: 10354 RVA: 0x00012190 File Offset: 0x00010390
		public ShaderKeyword() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr))
		{
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x06002873 RID: 10355 RVA: 0x0009ECB4 File Offset: 0x0009CEB4
		// (set) Token: 0x06002874 RID: 10356 RVA: 0x000121A2 File Offset: 0x000103A2
		public unsafe string m_Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderKeyword.NativeFieldInfoPtr_m_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderKeyword.NativeFieldInfoPtr_m_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x06002875 RID: 10357 RVA: 0x0009ECDC File Offset: 0x0009CEDC
		// (set) Token: 0x06002876 RID: 10358 RVA: 0x000121C1 File Offset: 0x000103C1
		public unsafe uint m_Index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderKeyword.NativeFieldInfoPtr_m_Index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderKeyword.NativeFieldInfoPtr_m_Index)) = value;
			}
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x06002877 RID: 10359 RVA: 0x0009ED04 File Offset: 0x0009CF04
		// (set) Token: 0x06002878 RID: 10360 RVA: 0x000121DC File Offset: 0x000103DC
		public unsafe bool m_IsLocal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderKeyword.NativeFieldInfoPtr_m_IsLocal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderKeyword.NativeFieldInfoPtr_m_IsLocal)) = value;
			}
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06002879 RID: 10361 RVA: 0x0009ED2C File Offset: 0x0009CF2C
		// (set) Token: 0x0600287A RID: 10362 RVA: 0x000121F7 File Offset: 0x000103F7
		public unsafe bool m_IsCompute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderKeyword.NativeFieldInfoPtr_m_IsCompute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderKeyword.NativeFieldInfoPtr_m_IsCompute)) = value;
			}
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x0600287B RID: 10363 RVA: 0x0009ED54 File Offset: 0x0009CF54
		// (set) Token: 0x0600287C RID: 10364 RVA: 0x00012212 File Offset: 0x00010412
		public unsafe bool m_IsValid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderKeyword.NativeFieldInfoPtr_m_IsValid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderKeyword.NativeFieldInfoPtr_m_IsValid)) = value;
			}
		}

		// Token: 0x0600287D RID: 10365 RVA: 0x0001222D File Offset: 0x0001042D
		public static uint GetKeywordCount(Shader shader)
		{
			return ShaderKeyword.GetKeywordCountDelegateField(IL2CPP.Il2CppObjectBaseToPtr(shader));
		}

		// Token: 0x0600287E RID: 10366 RVA: 0x0001223F File Offset: 0x0001043F
		public static uint GetKeywordIndex(Shader shader, string keyword)
		{
			return ShaderKeyword.GetKeywordIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtr(shader), IL2CPP.ManagedStringToIl2Cpp(keyword));
		}

		// Token: 0x0600287F RID: 10367 RVA: 0x00012257 File Offset: 0x00010457
		public static uint GetComputeShaderKeywordCount(ComputeShader shader)
		{
			return ShaderKeyword.GetComputeShaderKeywordCountDelegateField(IL2CPP.Il2CppObjectBaseToPtr(shader));
		}

		// Token: 0x06002880 RID: 10368 RVA: 0x00012269 File Offset: 0x00010469
		public static uint GetComputeShaderKeywordIndex(ComputeShader shader, string keyword)
		{
			return ShaderKeyword.GetComputeShaderKeywordIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtr(shader), IL2CPP.ManagedStringToIl2Cpp(keyword));
		}

		// Token: 0x06002881 RID: 10369 RVA: 0x00012281 File Offset: 0x00010481
		public static ShaderKeywordType GetGlobalShaderKeywordType(uint keyword)
		{
			return ShaderKeyword.GetGlobalShaderKeywordTypeDelegateField(keyword);
		}

		// Token: 0x06002882 RID: 10370 RVA: 0x0009ED7C File Offset: 0x0009CF7C
		public static ShaderKeywordType GetGlobalKeywordType(ShaderKeyword index)
		{
			bool flag = index.IsValid();
			ShaderKeywordType result;
			if (flag)
			{
				result = ShaderKeyword.GetGlobalShaderKeywordType(index.m_Index);
			}
			else
			{
				result = ShaderKeywordType.UserDefined;
			}
			return result;
		}

		// Token: 0x06002883 RID: 10371 RVA: 0x0009EDAC File Offset: 0x0009CFAC
		public static bool IsKeywordLocal(ShaderKeyword keyword)
		{
			return keyword.m_IsLocal;
		}

		// Token: 0x06002884 RID: 10372 RVA: 0x0009EDC4 File Offset: 0x0009CFC4
		public bool IsValid()
		{
			return this.m_IsValid;
		}

		// Token: 0x06002885 RID: 10373 RVA: 0x0009EDDC File Offset: 0x0009CFDC
		public bool IsValid(ComputeShader shader)
		{
			return this.m_IsValid;
		}

		// Token: 0x06002886 RID: 10374 RVA: 0x0009EDF4 File Offset: 0x0009CFF4
		public bool IsValid(Shader shader)
		{
			return this.m_IsValid;
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06002887 RID: 10375 RVA: 0x0009EE0C File Offset: 0x0009D00C
		public int index
		{
			get
			{
				return (int)this.m_Index;
			}
		}

		// Token: 0x06002888 RID: 10376 RVA: 0x0009EE24 File Offset: 0x0009D024
		public static ShaderKeywordType GetKeywordType(Shader shader, ShaderKeyword index)
		{
			return ShaderKeywordType.UserDefined;
		}

		// Token: 0x06002889 RID: 10377 RVA: 0x0009EE38 File Offset: 0x0009D038
		public static ShaderKeywordType GetKeywordType(ComputeShader shader, ShaderKeyword index)
		{
			return ShaderKeywordType.UserDefined;
		}

		// Token: 0x0600288A RID: 10378 RVA: 0x0009EE4C File Offset: 0x0009D04C
		public static string GetGlobalKeywordName(ShaderKeyword index)
		{
			return index.m_Name;
		}

		// Token: 0x0600288B RID: 10379 RVA: 0x0009EE64 File Offset: 0x0009D064
		public static string GetKeywordName(Shader shader, ShaderKeyword index)
		{
			return index.m_Name;
		}

		// Token: 0x0600288C RID: 10380 RVA: 0x0009EE7C File Offset: 0x0009D07C
		public static string GetKeywordName(ComputeShader shader, ShaderKeyword index)
		{
			return index.m_Name;
		}

		// Token: 0x0600288D RID: 10381 RVA: 0x0009EE94 File Offset: 0x0009D094
		public unsafe ShaderKeywordType GetKeywordType()
		{
			return ShaderKeyword.GetGlobalKeywordType(*this);
		}

		// Token: 0x0600288E RID: 10382 RVA: 0x0009EEB4 File Offset: 0x0009D0B4
		public unsafe string GetKeywordName()
		{
			return ShaderKeyword.GetGlobalKeywordName(*this);
		}

		// Token: 0x0600288F RID: 10383 RVA: 0x0009EED4 File Offset: 0x0009D0D4
		public string GetName()
		{
			return this.GetKeywordName();
		}

		// Token: 0x0400226F RID: 8815
		private static readonly IntPtr NativeFieldInfoPtr_m_Name;

		// Token: 0x04002270 RID: 8816
		private static readonly IntPtr NativeFieldInfoPtr_m_Index;

		// Token: 0x04002271 RID: 8817
		private static readonly IntPtr NativeFieldInfoPtr_m_IsLocal;

		// Token: 0x04002272 RID: 8818
		private static readonly IntPtr NativeFieldInfoPtr_m_IsCompute;

		// Token: 0x04002273 RID: 8819
		private static readonly IntPtr NativeFieldInfoPtr_m_IsValid;

		// Token: 0x04002274 RID: 8820
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalKeywordCount_Internal_Static_UInt32_0;

		// Token: 0x04002275 RID: 8821
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalKeywordIndex_Internal_Static_UInt32_String_0;

		// Token: 0x04002276 RID: 8822
		private static readonly IntPtr NativeMethodInfoPtr_CreateGlobalKeyword_Internal_Static_Void_String_0;

		// Token: 0x04002277 RID: 8823
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

		// Token: 0x04002278 RID: 8824
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04002279 RID: 8825
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400227A RID: 8826
		private static readonly ShaderKeyword.GetKeywordCountDelegate GetKeywordCountDelegateField;

		// Token: 0x0400227B RID: 8827
		private static readonly ShaderKeyword.GetKeywordIndexDelegate GetKeywordIndexDelegateField;

		// Token: 0x0400227C RID: 8828
		private static readonly ShaderKeyword.GetComputeShaderKeywordCountDelegate GetComputeShaderKeywordCountDelegateField;

		// Token: 0x0400227D RID: 8829
		private static readonly ShaderKeyword.GetComputeShaderKeywordIndexDelegate GetComputeShaderKeywordIndexDelegateField;

		// Token: 0x0400227E RID: 8830
		private static readonly ShaderKeyword.GetGlobalShaderKeywordTypeDelegate GetGlobalShaderKeywordTypeDelegateField;

		// Token: 0x02000B7F RID: 2943
		// (Invoke) Token: 0x06003FE7 RID: 16359
		private delegate uint GetKeywordCountDelegate(IntPtr shader);

		// Token: 0x02000B80 RID: 2944
		// (Invoke) Token: 0x06003FE9 RID: 16361
		private delegate uint GetKeywordIndexDelegate(IntPtr shader, IntPtr keyword);

		// Token: 0x02000B81 RID: 2945
		// (Invoke) Token: 0x06003FEB RID: 16363
		private delegate uint GetComputeShaderKeywordCountDelegate(IntPtr shader);

		// Token: 0x02000B82 RID: 2946
		// (Invoke) Token: 0x06003FED RID: 16365
		private delegate uint GetComputeShaderKeywordIndexDelegate(IntPtr shader, IntPtr keyword);

		// Token: 0x02000B83 RID: 2947
		// (Invoke) Token: 0x06003FEF RID: 16367
		private delegate ShaderKeywordType GetGlobalShaderKeywordTypeDelegate(uint keyword);
	}
}
