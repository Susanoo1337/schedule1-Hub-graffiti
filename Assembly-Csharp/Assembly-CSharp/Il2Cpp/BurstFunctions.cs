using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200001C RID: 28
	public static class BurstFunctions : Il2CppSystem.Object
	{
		// Token: 0x06000164 RID: 356 RVA: 0x0007FB60 File Offset: 0x0007DD60
		// Note: this type is marked as 'beforefieldinit'.
		static BurstFunctions()
		{
			Il2CppClassPointerStore<BurstFunctions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BurstFunctions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstFunctions>.NativeClassPtr);
			BurstFunctions.NativeMethodInfoPtr_Average_Public_Static_Void_byref_NativeArray_1_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstFunctions>.NativeClassPtr, 100663443);
			BurstFunctions.NativeMethodInfoPtr_Average_Public_Static_Void_byref_NativeArray_1_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstFunctions>.NativeClassPtr, 100663444);
			BurstFunctions.NativeMethodInfoPtr_Method_Public_Static_Void_byref_NativeArray_1_Single_byref_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstFunctions>.NativeClassPtr, 100663445);
			BurstFunctions.NativeMethodInfoPtr_Method_Public_Static_Void_byref_NativeArray_1_Vector3_byref_Vector3_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstFunctions>.NativeClassPtr, 100663446);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0007FBE0 File Offset: 0x0007DDE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66630, XrefRangeEnd = 66634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Average(ref NativeArray<float> arr, out float result)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(arr));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstFunctions.NativeMethodInfoPtr_Average_Public_Static_Void_byref_NativeArray_1_Single_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0007FC2C File Offset: 0x0007DE2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 66638, RefRangeEnd = 66640, XrefRangeStart = 66634, XrefRangeEnd = 66638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Average(ref NativeArray<Vector3> arr, out Vector3 result)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(arr));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstFunctions.NativeMethodInfoPtr_Average_Public_Static_Void_byref_NativeArray_1_Vector3_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0007FC78 File Offset: 0x0007DE78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66640, XrefRangeEnd = 66641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_byref_NativeArray_1_Single_byref_Single_PDM_0(ref NativeArray<float> arr, out float result)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(arr));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstFunctions.NativeMethodInfoPtr_Method_Public_Static_Void_byref_NativeArray_1_Single_byref_Single_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0007FCC4 File Offset: 0x0007DEC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66641, XrefRangeEnd = 66643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_byref_NativeArray_1_Vector3_byref_Vector3_PDM_0(ref NativeArray<Vector3> arr, out Vector3 result)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(arr));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstFunctions.NativeMethodInfoPtr_Method_Public_Static_Void_byref_NativeArray_1_Vector3_byref_Vector3_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00002BDC File Offset: 0x00000DDC
		public BurstFunctions(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr_Average_Public_Static_Void_byref_NativeArray_1_Single_byref_Single_0;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr_Average_Public_Static_Void_byref_NativeArray_1_Vector3_byref_Vector3_0;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_byref_NativeArray_1_Single_byref_Single_PDM_0;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_byref_NativeArray_1_Vector3_byref_Vector3_PDM_0;

		// Token: 0x02000859 RID: 2137
		[ObfuscatedName("BurstFunctions+Average_00000093$PostfixBurstDelegate")]
		public sealed class MulticastDelegateNPublicSealedVoObA_ObVoInA_arInre0 : MulticastDelegate
		{
			// Token: 0x0600CFE6 RID: 53222 RVA: 0x003439B8 File Offset: 0x00341BB8
			// Note: this type is marked as 'beforefieldinit'.
			static MulticastDelegateNPublicSealedVoObA_ObVoInA_arInre0()
			{
				Il2CppClassPointerStore<BurstFunctions.MulticastDelegateNPublicSealedVoObA_ObVoInA_arInre0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstFunctions>.NativeClassPtr, "Average_00000093$PostfixBurstDelegate");
				BurstFunctions.MulticastDelegateNPublicSealedVoObA_ObVoInA_arInre0.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstFunctions.MulticastDelegateNPublicSealedVoObA_ObVoInA_arInre0>.NativeClassPtr, 100663447);
				BurstFunctions.MulticastDelegateNPublicSealedVoObA_ObVoInA_arInre0.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_NativeArray_1_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstFunctions.MulticastDelegateNPublicSealedVoObA_ObVoInA_arInre0>.NativeClassPtr, 100663448);
				BurstFunctions.MulticastDelegateNPublicSealedVoObA_ObVoInA_arInre0.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_NativeArray_1_Single_byref_Single_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstFunctions.MulticastDelegateNPublicSealedVoObA_ObVoInA_arInre0>.NativeClassPtr, 100663449);
				BurstFunctions.MulticastDelegateNPublicSealedVoObA_ObVoInA_arInre0.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstFunctions.MulticastDelegateNPublicSealedVoObA_ObVoInA_arInre0>.NativeClassPtr, 100663450);
			}

			// Token: 0x0600CFE7 RID: 53223 RVA: 0x00343A2C File Offset: 0x00341C2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66451, XrefRangeEnd = 66455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MulticastDelegateNPublicSealedVoObA_ObVoInA_arInre0(Il2CppSystem.Object A_1, IntPtr A_2) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurstFunctions.MulticastDelegateNPublicSealedVoObA_ObVoInA_arInre0>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstFunctions.MulticastDelegateNPublicSealedVoObA_ObVoInA_arInre0.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFE8 RID: 53224 RVA: 0x00343A88 File Offset: 0x00341C88
			[CallerCount(0)]
			public unsafe void Invoke(ref NativeArray<float> arr, out float result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(arr));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstFunctions.MulticastDelegateNPublicSealedVoObA_ObVoInA_arInre0.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_NativeArray_1_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFE9 RID: 53225 RVA: 0x00343AE0 File Offset: 0x00341CE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66455, XrefRangeEnd = 66462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(ref NativeArray<float> arr, out float result, AsyncCallback A_3, Il2CppSystem.Object A_4)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(arr));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_3);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_4);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstFunctions.MulticastDelegateNPublicSealedVoObA_ObVoInA_arInre0.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_NativeArray_1_Single_byref_Single_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600CFEA RID: 53226 RVA: 0x00343B6C File Offset: 0x00341D6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstFunctions.MulticastDelegateNPublicSealedVoObA_ObVoInA_arInre0.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFEB RID: 53227 RVA: 0x00062710 File Offset: 0x00060910
			public MulticastDelegateNPublicSealedVoObA_ObVoInA_arInre0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008DBC RID: 36284
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04008DBD RID: 36285
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_NativeArray_1_Single_byref_Single_0;

			// Token: 0x04008DBE RID: 36286
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_NativeArray_1_Single_byref_Single_AsyncCallback_Object_0;

			// Token: 0x04008DBF RID: 36287
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200085A RID: 2138
		[ObfuscatedName("BurstFunctions+Average_00000093$BurstDirectCall")]
		public static class ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe0 : Il2CppSystem.Object
		{
			// Token: 0x0600CFEC RID: 53228 RVA: 0x00343BB0 File Offset: 0x00341DB0
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe0()
			{
				Il2CppClassPointerStore<BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstFunctions>.NativeClassPtr, "Average_00000093$BurstDirectCall");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe0>.NativeClassPtr);
				BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe0.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe0>.NativeClassPtr, "Pointer");
				BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe0.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe0>.NativeClassPtr, "DeferredCompilation");
				BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe0.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe0>.NativeClassPtr, 100663451);
				BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe0.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe0>.NativeClassPtr, 100663452);
				BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe0.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe0>.NativeClassPtr, 100663453);
				BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe0.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe0>.NativeClassPtr, 100663454);
				BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe0.NativeMethodInfoPtr_Invoke_Public_Static_Void_byref_NativeArray_1_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe0>.NativeClassPtr, 100663456);
			}

			// Token: 0x0600CFED RID: 53229 RVA: 0x00343C68 File Offset: 0x00341E68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66462, XrefRangeEnd = 66480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = &A_0;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe0.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFEE RID: 53230 RVA: 0x00343C9C File Offset: 0x00341E9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66480, XrefRangeEnd = 66502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static IntPtr GetFunctionPointer()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe0.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CFEF RID: 53231 RVA: 0x00343CCC File Offset: 0x00341ECC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66502, XrefRangeEnd = 66512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Constructor()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe0.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFF0 RID: 53232 RVA: 0x00343CF4 File Offset: 0x00341EF4
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Initialize()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe0.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFF1 RID: 53233 RVA: 0x00343D1C File Offset: 0x00341F1C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 66541, RefRangeEnd = 66542, XrefRangeStart = 66512, XrefRangeEnd = 66541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Invoke(ref NativeArray<float> arr, out float result)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(arr));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe0.NativeMethodInfoPtr_Invoke_Public_Static_Void_byref_NativeArray_1_Single_byref_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFF2 RID: 53234 RVA: 0x00062719 File Offset: 0x00060919
			public ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EF7 RID: 16119
			// (get) Token: 0x0600CFF3 RID: 53235 RVA: 0x00343D68 File Offset: 0x00341F68
			// (set) Token: 0x0600CFF4 RID: 53236 RVA: 0x00062722 File Offset: 0x00060922
			public unsafe static IntPtr Pointer
			{
				get
				{
					IntPtr result;
					IL2CPP.il2cpp_field_static_get_value(BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe0.NativeFieldInfoPtr_Pointer, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe0.NativeFieldInfoPtr_Pointer, (void*)(&value));
				}
			}

			// Token: 0x17003EF8 RID: 16120
			// (get) Token: 0x0600CFF5 RID: 53237 RVA: 0x00343D84 File Offset: 0x00341F84
			// (set) Token: 0x0600CFF6 RID: 53238 RVA: 0x00062730 File Offset: 0x00060930
			public unsafe static IntPtr DeferredCompilation
			{
				get
				{
					IntPtr result;
					IL2CPP.il2cpp_field_static_get_value(BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe0.NativeFieldInfoPtr_DeferredCompilation, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe0.NativeFieldInfoPtr_DeferredCompilation, (void*)(&value));
				}
			}

			// Token: 0x04008DC0 RID: 36288
			private static readonly IntPtr NativeFieldInfoPtr_Pointer;

			// Token: 0x04008DC1 RID: 36289
			private static readonly IntPtr NativeFieldInfoPtr_DeferredCompilation;

			// Token: 0x04008DC2 RID: 36290
			private static readonly IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;

			// Token: 0x04008DC3 RID: 36291
			private static readonly IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;

			// Token: 0x04008DC4 RID: 36292
			private static readonly IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;

			// Token: 0x04008DC5 RID: 36293
			private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;

			// Token: 0x04008DC6 RID: 36294
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_byref_NativeArray_1_Single_byref_Single_0;
		}

		// Token: 0x0200085B RID: 2139
		[ObfuscatedName("BurstFunctions+Average_00000094$PostfixBurstDelegate")]
		public sealed class MulticastDelegateNPublicSealedVoObA_ObVoInA_arInre1 : MulticastDelegate
		{
			// Token: 0x0600CFF7 RID: 53239 RVA: 0x00343DA0 File Offset: 0x00341FA0
			// Note: this type is marked as 'beforefieldinit'.
			static MulticastDelegateNPublicSealedVoObA_ObVoInA_arInre1()
			{
				Il2CppClassPointerStore<BurstFunctions.MulticastDelegateNPublicSealedVoObA_ObVoInA_arInre1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstFunctions>.NativeClassPtr, "Average_00000094$PostfixBurstDelegate");
				BurstFunctions.MulticastDelegateNPublicSealedVoObA_ObVoInA_arInre1.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstFunctions.MulticastDelegateNPublicSealedVoObA_ObVoInA_arInre1>.NativeClassPtr, 100663457);
				BurstFunctions.MulticastDelegateNPublicSealedVoObA_ObVoInA_arInre1.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_NativeArray_1_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstFunctions.MulticastDelegateNPublicSealedVoObA_ObVoInA_arInre1>.NativeClassPtr, 100663458);
				BurstFunctions.MulticastDelegateNPublicSealedVoObA_ObVoInA_arInre1.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_NativeArray_1_Vector3_byref_Vector3_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstFunctions.MulticastDelegateNPublicSealedVoObA_ObVoInA_arInre1>.NativeClassPtr, 100663459);
				BurstFunctions.MulticastDelegateNPublicSealedVoObA_ObVoInA_arInre1.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstFunctions.MulticastDelegateNPublicSealedVoObA_ObVoInA_arInre1>.NativeClassPtr, 100663460);
			}

			// Token: 0x0600CFF8 RID: 53240 RVA: 0x00343E14 File Offset: 0x00342014
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MulticastDelegateNPublicSealedVoObA_ObVoInA_arInre1(Il2CppSystem.Object A_1, IntPtr A_2) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurstFunctions.MulticastDelegateNPublicSealedVoObA_ObVoInA_arInre1>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstFunctions.MulticastDelegateNPublicSealedVoObA_ObVoInA_arInre1.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFF9 RID: 53241 RVA: 0x00343E70 File Offset: 0x00342070
			[CallerCount(0)]
			public unsafe void Invoke(ref NativeArray<Vector3> arr, out Vector3 result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(arr));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstFunctions.MulticastDelegateNPublicSealedVoObA_ObVoInA_arInre1.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_NativeArray_1_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFFA RID: 53242 RVA: 0x00343EC8 File Offset: 0x003420C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66542, XrefRangeEnd = 66549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(ref NativeArray<Vector3> arr, out Vector3 result, AsyncCallback A_3, Il2CppSystem.Object A_4)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(arr));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_3);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_4);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstFunctions.MulticastDelegateNPublicSealedVoObA_ObVoInA_arInre1.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_NativeArray_1_Vector3_byref_Vector3_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600CFFB RID: 53243 RVA: 0x00343F54 File Offset: 0x00342154
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstFunctions.MulticastDelegateNPublicSealedVoObA_ObVoInA_arInre1.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFFC RID: 53244 RVA: 0x0006273E File Offset: 0x0006093E
			public MulticastDelegateNPublicSealedVoObA_ObVoInA_arInre1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008DC7 RID: 36295
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04008DC8 RID: 36296
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_NativeArray_1_Vector3_byref_Vector3_0;

			// Token: 0x04008DC9 RID: 36297
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_NativeArray_1_Vector3_byref_Vector3_AsyncCallback_Object_0;

			// Token: 0x04008DCA RID: 36298
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200085C RID: 2140
		[ObfuscatedName("BurstFunctions+Average_00000094$BurstDirectCall")]
		public static class ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe1 : Il2CppSystem.Object
		{
			// Token: 0x0600CFFD RID: 53245 RVA: 0x00343F98 File Offset: 0x00342198
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe1()
			{
				Il2CppClassPointerStore<BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstFunctions>.NativeClassPtr, "Average_00000094$BurstDirectCall");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe1>.NativeClassPtr);
				BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe1.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe1>.NativeClassPtr, "Pointer");
				BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe1.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe1>.NativeClassPtr, "DeferredCompilation");
				BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe1.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe1>.NativeClassPtr, 100663461);
				BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe1.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe1>.NativeClassPtr, 100663462);
				BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe1.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe1>.NativeClassPtr, 100663463);
				BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe1.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe1>.NativeClassPtr, 100663464);
				BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe1.NativeMethodInfoPtr_Invoke_Public_Static_Void_byref_NativeArray_1_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe1>.NativeClassPtr, 100663466);
			}

			// Token: 0x0600CFFE RID: 53246 RVA: 0x00344050 File Offset: 0x00342250
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66549, XrefRangeEnd = 66567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = &A_0;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe1.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFFF RID: 53247 RVA: 0x00344084 File Offset: 0x00342284
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66567, XrefRangeEnd = 66589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static IntPtr GetFunctionPointer()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe1.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D000 RID: 53248 RVA: 0x003440B4 File Offset: 0x003422B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66589, XrefRangeEnd = 66599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Constructor()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe1.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D001 RID: 53249 RVA: 0x003440DC File Offset: 0x003422DC
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Initialize()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe1.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D002 RID: 53250 RVA: 0x00344104 File Offset: 0x00342304
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 66629, RefRangeEnd = 66630, XrefRangeStart = 66599, XrefRangeEnd = 66629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Invoke(ref NativeArray<Vector3> arr, out Vector3 result)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(arr));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe1.NativeMethodInfoPtr_Invoke_Public_Static_Void_byref_NativeArray_1_Vector3_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D003 RID: 53251 RVA: 0x00062747 File Offset: 0x00060947
			public ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EF9 RID: 16121
			// (get) Token: 0x0600D004 RID: 53252 RVA: 0x00344150 File Offset: 0x00342350
			// (set) Token: 0x0600D005 RID: 53253 RVA: 0x00062750 File Offset: 0x00060950
			public unsafe static IntPtr Pointer
			{
				get
				{
					IntPtr result;
					IL2CPP.il2cpp_field_static_get_value(BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe1.NativeFieldInfoPtr_Pointer, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe1.NativeFieldInfoPtr_Pointer, (void*)(&value));
				}
			}

			// Token: 0x17003EFA RID: 16122
			// (get) Token: 0x0600D006 RID: 53254 RVA: 0x0034416C File Offset: 0x0034236C
			// (set) Token: 0x0600D007 RID: 53255 RVA: 0x0006275E File Offset: 0x0006095E
			public unsafe static IntPtr DeferredCompilation
			{
				get
				{
					IntPtr result;
					IL2CPP.il2cpp_field_static_get_value(BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe1.NativeFieldInfoPtr_DeferredCompilation, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BurstFunctions.ObjectNInternalAbstractSealedInPoDeInGeVoA_ObCoGe1.NativeFieldInfoPtr_DeferredCompilation, (void*)(&value));
				}
			}

			// Token: 0x04008DCB RID: 36299
			private static readonly IntPtr NativeFieldInfoPtr_Pointer;

			// Token: 0x04008DCC RID: 36300
			private static readonly IntPtr NativeFieldInfoPtr_DeferredCompilation;

			// Token: 0x04008DCD RID: 36301
			private static readonly IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;

			// Token: 0x04008DCE RID: 36302
			private static readonly IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;

			// Token: 0x04008DCF RID: 36303
			private static readonly IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;

			// Token: 0x04008DD0 RID: 36304
			private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;

			// Token: 0x04008DD1 RID: 36305
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_byref_NativeArray_1_Vector3_byref_Vector3_0;
		}
	}
}
