using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000245 RID: 581
	[StructLayout(2)]
	public struct LocalKeywordSpace
	{
		// Token: 0x06002857 RID: 10327 RVA: 0x0009E704 File Offset: 0x0009C904
		// Note: this type is marked as 'beforefieldinit'.
		static LocalKeywordSpace()
		{
			Il2CppClassPointerStore<LocalKeywordSpace>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "LocalKeywordSpace");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalKeywordSpace>.NativeClassPtr);
			LocalKeywordSpace.NativeFieldInfoPtr_m_KeywordSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalKeywordSpace>.NativeClassPtr, "m_KeywordSpace");
			LocalKeywordSpace.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeywordSpace>.NativeClassPtr, 100667627);
			LocalKeywordSpace.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LocalKeywordSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeywordSpace>.NativeClassPtr, 100667628);
			LocalKeywordSpace.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_LocalKeywordSpace_LocalKeywordSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeywordSpace>.NativeClassPtr, 100667629);
			LocalKeywordSpace.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeywordSpace>.NativeClassPtr, 100667630);
			LocalKeywordSpace.GetKeywords_InjectedDelegateField = IL2CPP.ResolveICall<LocalKeywordSpace.GetKeywords_InjectedDelegate>("UnityEngine.Rendering.LocalKeywordSpace::GetKeywords_Injected");
			LocalKeywordSpace.GetKeywordNames_InjectedDelegateField = IL2CPP.ResolveICall<LocalKeywordSpace.GetKeywordNames_InjectedDelegate>("UnityEngine.Rendering.LocalKeywordSpace::GetKeywordNames_Injected");
			LocalKeywordSpace.GetKeywordCount_InjectedDelegateField = IL2CPP.ResolveICall<LocalKeywordSpace.GetKeywordCount_InjectedDelegate>("UnityEngine.Rendering.LocalKeywordSpace::GetKeywordCount_Injected");
			LocalKeywordSpace.GetKeyword_InjectedDelegateField = IL2CPP.ResolveICall<LocalKeywordSpace.GetKeyword_InjectedDelegate>("UnityEngine.Rendering.LocalKeywordSpace::GetKeyword_Injected");
		}

		// Token: 0x06002858 RID: 10328 RVA: 0x0009E7D4 File Offset: 0x0009C9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292394, XrefRangeEnd = 1292398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalKeywordSpace.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002859 RID: 10329 RVA: 0x0009E818 File Offset: 0x0009CA18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292398, XrefRangeEnd = 1292399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(LocalKeywordSpace rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalKeywordSpace.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LocalKeywordSpace_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600285A RID: 10330 RVA: 0x0009E858 File Offset: 0x0009CA58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292399, XrefRangeEnd = 1292400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(LocalKeywordSpace lhs, LocalKeywordSpace rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalKeywordSpace.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_LocalKeywordSpace_LocalKeywordSpace_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600285B RID: 10331 RVA: 0x0009E8A4 File Offset: 0x0009CAA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalKeywordSpace.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600285C RID: 10332 RVA: 0x00012150 File Offset: 0x00010350
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalKeywordSpace>.NativeClassPtr, ref this));
		}

		// Token: 0x0600285D RID: 10333 RVA: 0x00012162 File Offset: 0x00010362
		public Il2CppReferenceArray<LocalKeyword> GetKeywords()
		{
			return LocalKeywordSpace.GetKeywords_Injected(ref this);
		}

		// Token: 0x0600285E RID: 10334 RVA: 0x0001216A File Offset: 0x0001036A
		public Il2CppStringArray GetKeywordNames()
		{
			return LocalKeywordSpace.GetKeywordNames_Injected(ref this);
		}

		// Token: 0x0600285F RID: 10335 RVA: 0x00012172 File Offset: 0x00010372
		public uint GetKeywordCount()
		{
			return LocalKeywordSpace.GetKeywordCount_Injected(ref this);
		}

		// Token: 0x06002860 RID: 10336 RVA: 0x0009E8D4 File Offset: 0x0009CAD4
		public LocalKeyword GetKeyword(string name)
		{
			LocalKeyword result;
			LocalKeywordSpace.GetKeyword_Injected(ref this, name, out result);
			return result;
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x06002861 RID: 10337 RVA: 0x0009E8EC File Offset: 0x0009CAEC
		public Il2CppReferenceArray<LocalKeyword> keywords
		{
			get
			{
				return this.GetKeywords();
			}
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x06002862 RID: 10338 RVA: 0x0009E904 File Offset: 0x0009CB04
		public Il2CppStringArray keywordNames
		{
			get
			{
				return this.GetKeywordNames();
			}
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x06002863 RID: 10339 RVA: 0x0009E91C File Offset: 0x0009CB1C
		public uint keywordCount
		{
			get
			{
				return this.GetKeywordCount();
			}
		}

		// Token: 0x06002864 RID: 10340 RVA: 0x0009E934 File Offset: 0x0009CB34
		public LocalKeyword FindKeyword(string name)
		{
			return this.GetKeyword(name);
		}

		// Token: 0x06002865 RID: 10341 RVA: 0x0009E950 File Offset: 0x0009CB50
		public static bool operator !=(LocalKeywordSpace lhs, LocalKeywordSpace rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x06002866 RID: 10342 RVA: 0x0009E96C File Offset: 0x0009CB6C
		public static Il2CppReferenceArray<LocalKeyword> GetKeywords_Injected(ref LocalKeywordSpace _unity_self)
		{
			IntPtr intPtr = LocalKeywordSpace.GetKeywords_InjectedDelegateField(ref _unity_self);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LocalKeyword>>(intPtr2) : null;
		}

		// Token: 0x06002867 RID: 10343 RVA: 0x0009E994 File Offset: 0x0009CB94
		public static Il2CppStringArray GetKeywordNames_Injected(ref LocalKeywordSpace _unity_self)
		{
			IntPtr intPtr = LocalKeywordSpace.GetKeywordNames_InjectedDelegateField(ref _unity_self);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x06002868 RID: 10344 RVA: 0x0001217A File Offset: 0x0001037A
		public static uint GetKeywordCount_Injected(ref LocalKeywordSpace _unity_self)
		{
			return LocalKeywordSpace.GetKeywordCount_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002869 RID: 10345 RVA: 0x0009E9BC File Offset: 0x0009CBBC
		public unsafe static void GetKeyword_Injected(ref LocalKeywordSpace _unity_self, string name, out LocalKeyword ret)
		{
			LocalKeywordSpace.GetKeyword_InjectedDelegate getKeyword_InjectedDelegateField = LocalKeywordSpace.GetKeyword_InjectedDelegateField;
			IntPtr name2 = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(ret);
			getKeyword_InjectedDelegateField(ref _unity_self, name2, &intPtr);
		}

		// Token: 0x04002265 RID: 8805
		private static readonly IntPtr NativeFieldInfoPtr_m_KeywordSpace;

		// Token: 0x04002266 RID: 8806
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002267 RID: 8807
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LocalKeywordSpace_0;

		// Token: 0x04002268 RID: 8808
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_LocalKeywordSpace_LocalKeywordSpace_0;

		// Token: 0x04002269 RID: 8809
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400226A RID: 8810
		[FieldOffset(0)]
		public readonly IntPtr m_KeywordSpace;

		// Token: 0x0400226B RID: 8811
		private static readonly LocalKeywordSpace.GetKeywords_InjectedDelegate GetKeywords_InjectedDelegateField;

		// Token: 0x0400226C RID: 8812
		private static readonly LocalKeywordSpace.GetKeywordNames_InjectedDelegate GetKeywordNames_InjectedDelegateField;

		// Token: 0x0400226D RID: 8813
		private static readonly LocalKeywordSpace.GetKeywordCount_InjectedDelegate GetKeywordCount_InjectedDelegateField;

		// Token: 0x0400226E RID: 8814
		private static readonly LocalKeywordSpace.GetKeyword_InjectedDelegate GetKeyword_InjectedDelegateField;

		// Token: 0x02000B7B RID: 2939
		// (Invoke) Token: 0x06003FDF RID: 16351
		private delegate IntPtr GetKeywords_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000B7C RID: 2940
		// (Invoke) Token: 0x06003FE1 RID: 16353
		private delegate IntPtr GetKeywordNames_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000B7D RID: 2941
		// (Invoke) Token: 0x06003FE3 RID: 16355
		private delegate uint GetKeywordCount_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000B7E RID: 2942
		// (Invoke) Token: 0x06003FE5 RID: 16357
		private delegate void GetKeyword_InjectedDelegate(IntPtr _unity_self, IntPtr name, [Out] IntPtr ret);
	}
}
