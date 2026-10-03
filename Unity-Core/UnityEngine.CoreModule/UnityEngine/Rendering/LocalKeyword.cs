using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000244 RID: 580
	public sealed class LocalKeyword : ValueType
	{
		// Token: 0x06002836 RID: 10294 RVA: 0x0009E1F0 File Offset: 0x0009C3F0
		// Note: this type is marked as 'beforefieldinit'.
		static LocalKeyword()
		{
			Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "LocalKeyword");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr);
			LocalKeyword.NativeFieldInfoPtr_m_SpaceInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, "m_SpaceInfo");
			LocalKeyword.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, "m_Name");
			LocalKeyword.NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, "m_Index");
			LocalKeyword.NativeMethodInfoPtr_GetShaderKeywordCount_Private_Static_UInt32_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, 100667620);
			LocalKeyword.NativeMethodInfoPtr_GetShaderKeywordIndex_Private_Static_UInt32_Shader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, 100667621);
			LocalKeyword.NativeMethodInfoPtr__ctor_Public_Void_Shader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, 100667622);
			LocalKeyword.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, 100667623);
			LocalKeyword.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, 100667624);
			LocalKeyword.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LocalKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, 100667625);
			LocalKeyword.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, 100667626);
			LocalKeyword.GetComputeShaderKeywordCountDelegateField = IL2CPP.ResolveICall<LocalKeyword.GetComputeShaderKeywordCountDelegate>("UnityEngine.Rendering.LocalKeyword::GetComputeShaderKeywordCount");
			LocalKeyword.GetComputeShaderKeywordIndexDelegateField = IL2CPP.ResolveICall<LocalKeyword.GetComputeShaderKeywordIndexDelegate>("UnityEngine.Rendering.LocalKeyword::GetComputeShaderKeywordIndex");
			LocalKeyword.IsDynamic_InjectedDelegateField = IL2CPP.ResolveICall<LocalKeyword.IsDynamic_InjectedDelegate>("UnityEngine.Rendering.LocalKeyword::IsDynamic_Injected");
			LocalKeyword.IsOverridable_InjectedDelegateField = IL2CPP.ResolveICall<LocalKeyword.IsOverridable_InjectedDelegate>("UnityEngine.Rendering.LocalKeyword::IsOverridable_Injected");
			LocalKeyword.GetKeywordType_InjectedDelegateField = IL2CPP.ResolveICall<LocalKeyword.GetKeywordType_InjectedDelegate>("UnityEngine.Rendering.LocalKeyword::GetKeywordType_Injected");
			LocalKeyword.IsValid_InjectedDelegateField = IL2CPP.ResolveICall<LocalKeyword.IsValid_InjectedDelegate>("UnityEngine.Rendering.LocalKeyword::IsValid_Injected");
		}

		// Token: 0x06002837 RID: 10295 RVA: 0x0009E344 File Offset: 0x0009C544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292356, XrefRangeEnd = 1292358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetShaderKeywordCount(Shader shader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(shader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalKeyword.NativeMethodInfoPtr_GetShaderKeywordCount_Private_Static_UInt32_Shader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002838 RID: 10296 RVA: 0x0009E388 File Offset: 0x0009C588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292358, XrefRangeEnd = 1292360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetShaderKeywordIndex(Shader shader, string keyword)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(shader);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(keyword);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalKeyword.NativeMethodInfoPtr_GetShaderKeywordIndex_Private_Static_UInt32_Shader_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002839 RID: 10297 RVA: 0x0009E3DC File Offset: 0x0009C5DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1292386, RefRangeEnd = 1292387, XrefRangeStart = 1292360, XrefRangeEnd = 1292386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalKeyword(Shader shader, string name) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(shader);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalKeyword.NativeMethodInfoPtr__ctor_Public_Void_Shader_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600283A RID: 10298 RVA: 0x0009E440 File Offset: 0x0009C640
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 537050, RefRangeEnd = 537070, XrefRangeStart = 537050, XrefRangeEnd = 537070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalKeyword.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600283B RID: 10299 RVA: 0x0009E47C File Offset: 0x0009C67C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292387, XrefRangeEnd = 1292391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalKeyword.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600283C RID: 10300 RVA: 0x0009E4D0 File Offset: 0x0009C6D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292391, XrefRangeEnd = 1292392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(LocalKeyword rhs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rhs));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalKeyword.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LocalKeyword_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600283D RID: 10301 RVA: 0x0009E528 File Offset: 0x0009C728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292392, XrefRangeEnd = 1292394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalKeyword.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600283E RID: 10302 RVA: 0x00012074 File Offset: 0x00010274
		public LocalKeyword(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0600283F RID: 10303 RVA: 0x0001207D File Offset: 0x0001027D
		public LocalKeyword() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr))
		{
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x06002840 RID: 10304 RVA: 0x0009E56C File Offset: 0x0009C76C
		// (set) Token: 0x06002841 RID: 10305 RVA: 0x0001208F File Offset: 0x0001028F
		public unsafe LocalKeywordSpace m_SpaceInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalKeyword.NativeFieldInfoPtr_m_SpaceInfo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalKeyword.NativeFieldInfoPtr_m_SpaceInfo)) = value;
			}
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06002842 RID: 10306 RVA: 0x0009E594 File Offset: 0x0009C794
		// (set) Token: 0x06002843 RID: 10307 RVA: 0x000120AA File Offset: 0x000102AA
		public unsafe string m_Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalKeyword.NativeFieldInfoPtr_m_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalKeyword.NativeFieldInfoPtr_m_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06002844 RID: 10308 RVA: 0x0009E5BC File Offset: 0x0009C7BC
		// (set) Token: 0x06002845 RID: 10309 RVA: 0x000120C9 File Offset: 0x000102C9
		public unsafe uint m_Index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalKeyword.NativeFieldInfoPtr_m_Index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalKeyword.NativeFieldInfoPtr_m_Index)) = value;
			}
		}

		// Token: 0x06002846 RID: 10310 RVA: 0x000120E4 File Offset: 0x000102E4
		public static bool IsDynamic(LocalKeyword kw)
		{
			return LocalKeyword.IsDynamic_Injected(ref kw);
		}

		// Token: 0x06002847 RID: 10311 RVA: 0x000120ED File Offset: 0x000102ED
		public static bool IsOverridable(LocalKeyword kw)
		{
			return LocalKeyword.IsOverridable_Injected(ref kw);
		}

		// Token: 0x06002848 RID: 10312 RVA: 0x000120F6 File Offset: 0x000102F6
		public static uint GetComputeShaderKeywordCount(ComputeShader shader)
		{
			return LocalKeyword.GetComputeShaderKeywordCountDelegateField(IL2CPP.Il2CppObjectBaseToPtr(shader));
		}

		// Token: 0x06002849 RID: 10313 RVA: 0x00012108 File Offset: 0x00010308
		public static uint GetComputeShaderKeywordIndex(ComputeShader shader, string keyword)
		{
			return LocalKeyword.GetComputeShaderKeywordIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtr(shader), IL2CPP.ManagedStringToIl2Cpp(keyword));
		}

		// Token: 0x0600284A RID: 10314 RVA: 0x00012120 File Offset: 0x00010320
		public static ShaderKeywordType GetKeywordType(LocalKeywordSpace spaceInfo, uint keyword)
		{
			return LocalKeyword.GetKeywordType_Injected(ref spaceInfo, keyword);
		}

		// Token: 0x0600284B RID: 10315 RVA: 0x0001212A File Offset: 0x0001032A
		public static bool IsValid(LocalKeywordSpace spaceInfo, uint keyword)
		{
			return LocalKeyword.IsValid_Injected(ref spaceInfo, keyword);
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x0600284C RID: 10316 RVA: 0x0009E5E4 File Offset: 0x0009C7E4
		public string name
		{
			get
			{
				return this.m_Name;
			}
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x0600284D RID: 10317 RVA: 0x0009E5FC File Offset: 0x0009C7FC
		public unsafe bool isDynamic
		{
			get
			{
				return LocalKeyword.IsDynamic(*this);
			}
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x0600284E RID: 10318 RVA: 0x0009E61C File Offset: 0x0009C81C
		public unsafe bool isOverridable
		{
			get
			{
				return LocalKeyword.IsOverridable(*this);
			}
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x0600284F RID: 10319 RVA: 0x0009E63C File Offset: 0x0009C83C
		public bool isValid
		{
			get
			{
				return LocalKeyword.IsValid(this.m_SpaceInfo, this.m_Index);
			}
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x06002850 RID: 10320 RVA: 0x0009E660 File Offset: 0x0009C860
		public ShaderKeywordType type
		{
			get
			{
				return LocalKeyword.GetKeywordType(this.m_SpaceInfo, this.m_Index);
			}
		}

		// Token: 0x06002851 RID: 10321 RVA: 0x0009E684 File Offset: 0x0009C884
		public static bool operator ==(LocalKeyword lhs, LocalKeyword rhs)
		{
			return lhs.Equals(rhs);
		}

		// Token: 0x06002852 RID: 10322 RVA: 0x0009E6A0 File Offset: 0x0009C8A0
		public static bool operator !=(LocalKeyword lhs, LocalKeyword rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x06002853 RID: 10323 RVA: 0x0009E6BC File Offset: 0x0009C8BC
		public unsafe static bool IsDynamic_Injected(ref LocalKeyword kw)
		{
			LocalKeyword.IsDynamic_InjectedDelegate isDynamic_InjectedDelegateField = LocalKeyword.IsDynamic_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(kw);
			return isDynamic_InjectedDelegateField(&intPtr);
		}

		// Token: 0x06002854 RID: 10324 RVA: 0x0009E6E0 File Offset: 0x0009C8E0
		public unsafe static bool IsOverridable_Injected(ref LocalKeyword kw)
		{
			LocalKeyword.IsOverridable_InjectedDelegate isOverridable_InjectedDelegateField = LocalKeyword.IsOverridable_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(kw);
			return isOverridable_InjectedDelegateField(&intPtr);
		}

		// Token: 0x06002855 RID: 10325 RVA: 0x00012134 File Offset: 0x00010334
		public static ShaderKeywordType GetKeywordType_Injected(ref LocalKeywordSpace spaceInfo, uint keyword)
		{
			return LocalKeyword.GetKeywordType_InjectedDelegateField(ref spaceInfo, keyword);
		}

		// Token: 0x06002856 RID: 10326 RVA: 0x00012142 File Offset: 0x00010342
		public static bool IsValid_Injected(ref LocalKeywordSpace spaceInfo, uint keyword)
		{
			return LocalKeyword.IsValid_InjectedDelegateField(ref spaceInfo, keyword);
		}

		// Token: 0x04002255 RID: 8789
		private static readonly IntPtr NativeFieldInfoPtr_m_SpaceInfo;

		// Token: 0x04002256 RID: 8790
		private static readonly IntPtr NativeFieldInfoPtr_m_Name;

		// Token: 0x04002257 RID: 8791
		private static readonly IntPtr NativeFieldInfoPtr_m_Index;

		// Token: 0x04002258 RID: 8792
		private static readonly IntPtr NativeMethodInfoPtr_GetShaderKeywordCount_Private_Static_UInt32_Shader_0;

		// Token: 0x04002259 RID: 8793
		private static readonly IntPtr NativeMethodInfoPtr_GetShaderKeywordIndex_Private_Static_UInt32_Shader_String_0;

		// Token: 0x0400225A RID: 8794
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Shader_String_0;

		// Token: 0x0400225B RID: 8795
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400225C RID: 8796
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400225D RID: 8797
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LocalKeyword_0;

		// Token: 0x0400225E RID: 8798
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400225F RID: 8799
		private static readonly LocalKeyword.GetComputeShaderKeywordCountDelegate GetComputeShaderKeywordCountDelegateField;

		// Token: 0x04002260 RID: 8800
		private static readonly LocalKeyword.GetComputeShaderKeywordIndexDelegate GetComputeShaderKeywordIndexDelegateField;

		// Token: 0x04002261 RID: 8801
		private static readonly LocalKeyword.IsDynamic_InjectedDelegate IsDynamic_InjectedDelegateField;

		// Token: 0x04002262 RID: 8802
		private static readonly LocalKeyword.IsOverridable_InjectedDelegate IsOverridable_InjectedDelegateField;

		// Token: 0x04002263 RID: 8803
		private static readonly LocalKeyword.GetKeywordType_InjectedDelegate GetKeywordType_InjectedDelegateField;

		// Token: 0x04002264 RID: 8804
		private static readonly LocalKeyword.IsValid_InjectedDelegate IsValid_InjectedDelegateField;

		// Token: 0x02000B75 RID: 2933
		// (Invoke) Token: 0x06003FD3 RID: 16339
		private delegate uint GetComputeShaderKeywordCountDelegate(IntPtr shader);

		// Token: 0x02000B76 RID: 2934
		// (Invoke) Token: 0x06003FD5 RID: 16341
		private delegate uint GetComputeShaderKeywordIndexDelegate(IntPtr shader, IntPtr keyword);

		// Token: 0x02000B77 RID: 2935
		// (Invoke) Token: 0x06003FD7 RID: 16343
		private delegate bool IsDynamic_InjectedDelegate(IntPtr kw);

		// Token: 0x02000B78 RID: 2936
		// (Invoke) Token: 0x06003FD9 RID: 16345
		private delegate bool IsOverridable_InjectedDelegate(IntPtr kw);

		// Token: 0x02000B79 RID: 2937
		// (Invoke) Token: 0x06003FDB RID: 16347
		private delegate ShaderKeywordType GetKeywordType_InjectedDelegate(IntPtr spaceInfo, uint keyword);

		// Token: 0x02000B7A RID: 2938
		// (Invoke) Token: 0x06003FDD RID: 16349
		private delegate bool IsValid_InjectedDelegate(IntPtr spaceInfo, uint keyword);
	}
}
