using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000DA RID: 218
	[Serializable]
	[StructLayout(2)]
	public struct BoneWeight
	{
		// Token: 0x0600103B RID: 4155 RVA: 0x00048378 File Offset: 0x00046578
		// Note: this type is marked as 'beforefieldinit'.
		static BoneWeight()
		{
			Il2CppClassPointerStore<BoneWeight>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "BoneWeight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr);
			BoneWeight.NativeFieldInfoPtr_m_Weight0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, "m_Weight0");
			BoneWeight.NativeFieldInfoPtr_m_Weight1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, "m_Weight1");
			BoneWeight.NativeFieldInfoPtr_m_Weight2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, "m_Weight2");
			BoneWeight.NativeFieldInfoPtr_m_Weight3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, "m_Weight3");
			BoneWeight.NativeFieldInfoPtr_m_BoneIndex0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, "m_BoneIndex0");
			BoneWeight.NativeFieldInfoPtr_m_BoneIndex1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, "m_BoneIndex1");
			BoneWeight.NativeFieldInfoPtr_m_BoneIndex2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, "m_BoneIndex2");
			BoneWeight.NativeFieldInfoPtr_m_BoneIndex3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, "m_BoneIndex3");
			BoneWeight.NativeMethodInfoPtr_get_weight0_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, 100664796);
			BoneWeight.NativeMethodInfoPtr_get_weight1_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, 100664797);
			BoneWeight.NativeMethodInfoPtr_get_weight2_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, 100664798);
			BoneWeight.NativeMethodInfoPtr_get_weight3_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, 100664799);
			BoneWeight.NativeMethodInfoPtr_get_boneIndex0_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, 100664800);
			BoneWeight.NativeMethodInfoPtr_get_boneIndex1_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, 100664801);
			BoneWeight.NativeMethodInfoPtr_get_boneIndex2_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, 100664802);
			BoneWeight.NativeMethodInfoPtr_get_boneIndex3_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, 100664803);
			BoneWeight.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, 100664804);
			BoneWeight.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, 100664805);
			BoneWeight.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BoneWeight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, 100664806);
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x0600103C RID: 4156 RVA: 0x00048524 File Offset: 0x00046724
		// (set) Token: 0x06001048 RID: 4168 RVA: 0x000098B6 File Offset: 0x00007AB6
		public unsafe float weight0
		{
			[CallerCount(87)]
			[CachedScanResults(RefRangeStart = 1226696, RefRangeEnd = 1226783, XrefRangeStart = 1226696, XrefRangeEnd = 1226783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoneWeight.NativeMethodInfoPtr_get_weight0_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Weight0 = value;
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x0600103D RID: 4157 RVA: 0x00048554 File Offset: 0x00046754
		// (set) Token: 0x06001049 RID: 4169 RVA: 0x000098C0 File Offset: 0x00007AC0
		public unsafe float weight1
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 1219142, RefRangeEnd = 1219216, XrefRangeStart = 1219142, XrefRangeEnd = 1219216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoneWeight.NativeMethodInfoPtr_get_weight1_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Weight1 = value;
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x0600103E RID: 4158 RVA: 0x00048584 File Offset: 0x00046784
		// (set) Token: 0x0600104A RID: 4170 RVA: 0x000098CA File Offset: 0x00007ACA
		public unsafe float weight2
		{
			[CallerCount(41)]
			[CachedScanResults(RefRangeStart = 1226783, RefRangeEnd = 1226824, XrefRangeStart = 1226783, XrefRangeEnd = 1226824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoneWeight.NativeMethodInfoPtr_get_weight2_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Weight2 = value;
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x0600103F RID: 4159 RVA: 0x000485B4 File Offset: 0x000467B4
		// (set) Token: 0x0600104B RID: 4171 RVA: 0x000098D4 File Offset: 0x00007AD4
		public unsafe float weight3
		{
			[CallerCount(37)]
			[CachedScanResults(RefRangeStart = 1222680, RefRangeEnd = 1222717, XrefRangeStart = 1222680, XrefRangeEnd = 1222717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoneWeight.NativeMethodInfoPtr_get_weight3_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Weight3 = value;
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06001040 RID: 4160 RVA: 0x000485E4 File Offset: 0x000467E4
		// (set) Token: 0x0600104C RID: 4172 RVA: 0x000098DE File Offset: 0x00007ADE
		public unsafe int boneIndex0
		{
			[CallerCount(49)]
			[CachedScanResults(RefRangeStart = 669546, RefRangeEnd = 669595, XrefRangeStart = 669546, XrefRangeEnd = 669595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoneWeight.NativeMethodInfoPtr_get_boneIndex0_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_BoneIndex0 = value;
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06001041 RID: 4161 RVA: 0x00048614 File Offset: 0x00046814
		// (set) Token: 0x0600104D RID: 4173 RVA: 0x000098E8 File Offset: 0x00007AE8
		public unsafe int boneIndex1
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 1239503, RefRangeEnd = 1239526, XrefRangeStart = 1239503, XrefRangeEnd = 1239503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoneWeight.NativeMethodInfoPtr_get_boneIndex1_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_BoneIndex1 = value;
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06001042 RID: 4162 RVA: 0x00048644 File Offset: 0x00046844
		// (set) Token: 0x0600104E RID: 4174 RVA: 0x000098F2 File Offset: 0x00007AF2
		public unsafe int boneIndex2
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 1223237, RefRangeEnd = 1223311, XrefRangeStart = 1223237, XrefRangeEnd = 1223311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoneWeight.NativeMethodInfoPtr_get_boneIndex2_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_BoneIndex2 = value;
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06001043 RID: 4163 RVA: 0x00048674 File Offset: 0x00046874
		// (set) Token: 0x0600104F RID: 4175 RVA: 0x000098FC File Offset: 0x00007AFC
		public unsafe int boneIndex3
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1239526, RefRangeEnd = 1239527, XrefRangeStart = 1239526, XrefRangeEnd = 1239526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoneWeight.NativeMethodInfoPtr_get_boneIndex3_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_BoneIndex3 = value;
			}
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x000486A4 File Offset: 0x000468A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239527, XrefRangeEnd = 1239535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoneWeight.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x000486D4 File Offset: 0x000468D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239535, XrefRangeEnd = 1239539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoneWeight.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x00048718 File Offset: 0x00046918
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1239543, RefRangeEnd = 1239544, XrefRangeStart = 1239539, XrefRangeEnd = 1239543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(BoneWeight other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoneWeight.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BoneWeight_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x000098A4 File Offset: 0x00007AA4
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, ref this));
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x00048758 File Offset: 0x00046958
		public static bool operator ==(BoneWeight lhs, BoneWeight rhs)
		{
			return lhs.boneIndex0 == rhs.boneIndex0 && lhs.boneIndex1 == rhs.boneIndex1 && lhs.boneIndex2 == rhs.boneIndex2 && lhs.boneIndex3 == rhs.boneIndex3 && new Vector4(lhs.weight0, lhs.weight1, lhs.weight2, lhs.weight3) == new Vector4(rhs.weight0, rhs.weight1, rhs.weight2, rhs.weight3);
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x000487F4 File Offset: 0x000469F4
		public static bool operator !=(BoneWeight lhs, BoneWeight rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x04000CF2 RID: 3314
		private static readonly IntPtr NativeFieldInfoPtr_m_Weight0;

		// Token: 0x04000CF3 RID: 3315
		private static readonly IntPtr NativeFieldInfoPtr_m_Weight1;

		// Token: 0x04000CF4 RID: 3316
		private static readonly IntPtr NativeFieldInfoPtr_m_Weight2;

		// Token: 0x04000CF5 RID: 3317
		private static readonly IntPtr NativeFieldInfoPtr_m_Weight3;

		// Token: 0x04000CF6 RID: 3318
		private static readonly IntPtr NativeFieldInfoPtr_m_BoneIndex0;

		// Token: 0x04000CF7 RID: 3319
		private static readonly IntPtr NativeFieldInfoPtr_m_BoneIndex1;

		// Token: 0x04000CF8 RID: 3320
		private static readonly IntPtr NativeFieldInfoPtr_m_BoneIndex2;

		// Token: 0x04000CF9 RID: 3321
		private static readonly IntPtr NativeFieldInfoPtr_m_BoneIndex3;

		// Token: 0x04000CFA RID: 3322
		private static readonly IntPtr NativeMethodInfoPtr_get_weight0_Public_get_Single_0;

		// Token: 0x04000CFB RID: 3323
		private static readonly IntPtr NativeMethodInfoPtr_get_weight1_Public_get_Single_0;

		// Token: 0x04000CFC RID: 3324
		private static readonly IntPtr NativeMethodInfoPtr_get_weight2_Public_get_Single_0;

		// Token: 0x04000CFD RID: 3325
		private static readonly IntPtr NativeMethodInfoPtr_get_weight3_Public_get_Single_0;

		// Token: 0x04000CFE RID: 3326
		private static readonly IntPtr NativeMethodInfoPtr_get_boneIndex0_Public_get_Int32_0;

		// Token: 0x04000CFF RID: 3327
		private static readonly IntPtr NativeMethodInfoPtr_get_boneIndex1_Public_get_Int32_0;

		// Token: 0x04000D00 RID: 3328
		private static readonly IntPtr NativeMethodInfoPtr_get_boneIndex2_Public_get_Int32_0;

		// Token: 0x04000D01 RID: 3329
		private static readonly IntPtr NativeMethodInfoPtr_get_boneIndex3_Public_get_Int32_0;

		// Token: 0x04000D02 RID: 3330
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000D03 RID: 3331
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000D04 RID: 3332
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BoneWeight_0;

		// Token: 0x04000D05 RID: 3333
		[FieldOffset(0)]
		public float m_Weight0;

		// Token: 0x04000D06 RID: 3334
		[FieldOffset(4)]
		public float m_Weight1;

		// Token: 0x04000D07 RID: 3335
		[FieldOffset(8)]
		public float m_Weight2;

		// Token: 0x04000D08 RID: 3336
		[FieldOffset(12)]
		public float m_Weight3;

		// Token: 0x04000D09 RID: 3337
		[FieldOffset(16)]
		public int m_BoneIndex0;

		// Token: 0x04000D0A RID: 3338
		[FieldOffset(20)]
		public int m_BoneIndex1;

		// Token: 0x04000D0B RID: 3339
		[FieldOffset(24)]
		public int m_BoneIndex2;

		// Token: 0x04000D0C RID: 3340
		[FieldOffset(28)]
		public int m_BoneIndex3;
	}
}
