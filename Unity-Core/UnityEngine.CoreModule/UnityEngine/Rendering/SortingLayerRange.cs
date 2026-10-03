using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200023C RID: 572
	[StructLayout(2)]
	public struct SortingLayerRange
	{
		// Token: 0x06002733 RID: 10035 RVA: 0x0009B734 File Offset: 0x00099934
		// Note: this type is marked as 'beforefieldinit'.
		static SortingLayerRange()
		{
			Il2CppClassPointerStore<SortingLayerRange>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "SortingLayerRange");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortingLayerRange>.NativeClassPtr);
			SortingLayerRange.NativeFieldInfoPtr_m_LowerBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortingLayerRange>.NativeClassPtr, "m_LowerBound");
			SortingLayerRange.NativeFieldInfoPtr_m_UpperBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortingLayerRange>.NativeClassPtr, "m_UpperBound");
			SortingLayerRange.NativeMethodInfoPtr__ctor_Public_Void_Int16_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingLayerRange>.NativeClassPtr, 100667524);
			SortingLayerRange.NativeMethodInfoPtr_get_lowerBound_Public_get_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingLayerRange>.NativeClassPtr, 100667525);
			SortingLayerRange.NativeMethodInfoPtr_get_upperBound_Public_get_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingLayerRange>.NativeClassPtr, 100667526);
			SortingLayerRange.NativeMethodInfoPtr_get_all_Public_Static_get_SortingLayerRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingLayerRange>.NativeClassPtr, 100667527);
			SortingLayerRange.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SortingLayerRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingLayerRange>.NativeClassPtr, 100667528);
			SortingLayerRange.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingLayerRange>.NativeClassPtr, 100667529);
			SortingLayerRange.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingLayerRange>.NativeClassPtr, 100667530);
		}

		// Token: 0x06002734 RID: 10036 RVA: 0x0009B818 File Offset: 0x00099A18
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 171375, RefRangeEnd = 171384, XrefRangeStart = 171375, XrefRangeEnd = 171384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortingLayerRange(short lowerBound, short upperBound)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lowerBound;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref upperBound;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingLayerRange.NativeMethodInfoPtr__ctor_Public_Void_Int16_Int16_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x06002735 RID: 10037 RVA: 0x0009B858 File Offset: 0x00099A58
		// (set) Token: 0x0600273C RID: 10044 RVA: 0x00011A9E File Offset: 0x0000FC9E
		public unsafe short lowerBound
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1291889, RefRangeEnd = 1291892, XrefRangeStart = 1291889, XrefRangeEnd = 1291889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingLayerRange.NativeMethodInfoPtr_get_lowerBound_Public_get_Int16_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_LowerBound = value;
			}
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x06002736 RID: 10038 RVA: 0x0009B888 File Offset: 0x00099A88
		// (set) Token: 0x0600273D RID: 10045 RVA: 0x00011AA8 File Offset: 0x0000FCA8
		public unsafe short upperBound
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1291892, RefRangeEnd = 1291896, XrefRangeStart = 1291892, XrefRangeEnd = 1291892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingLayerRange.NativeMethodInfoPtr_get_upperBound_Public_get_Int16_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_UpperBound = value;
			}
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x06002737 RID: 10039 RVA: 0x0009B8B8 File Offset: 0x00099AB8
		public unsafe static SortingLayerRange all
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1291896, RefRangeEnd = 1291899, XrefRangeStart = 1291896, XrefRangeEnd = 1291896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingLayerRange.NativeMethodInfoPtr_get_all_Public_Static_get_SortingLayerRange_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002738 RID: 10040 RVA: 0x0009B8E8 File Offset: 0x00099AE8
		[CallerCount(0)]
		public unsafe bool Equals(SortingLayerRange other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingLayerRange.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SortingLayerRange_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002739 RID: 10041 RVA: 0x0009B928 File Offset: 0x00099B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291899, XrefRangeEnd = 1291902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingLayerRange.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600273A RID: 10042 RVA: 0x0009B96C File Offset: 0x00099B6C
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingLayerRange.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600273B RID: 10043 RVA: 0x00011A8C File Offset: 0x0000FC8C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SortingLayerRange>.NativeClassPtr, ref this));
		}

		// Token: 0x0600273E RID: 10046 RVA: 0x0009B99C File Offset: 0x00099B9C
		public static bool operator !=(SortingLayerRange lhs, SortingLayerRange rhs)
		{
			return !lhs.Equals(rhs);
		}

		// Token: 0x0600273F RID: 10047 RVA: 0x0009B9BC File Offset: 0x00099BBC
		public static bool operator ==(SortingLayerRange lhs, SortingLayerRange rhs)
		{
			return lhs.Equals(rhs);
		}

		// Token: 0x04002188 RID: 8584
		private static readonly IntPtr NativeFieldInfoPtr_m_LowerBound;

		// Token: 0x04002189 RID: 8585
		private static readonly IntPtr NativeFieldInfoPtr_m_UpperBound;

		// Token: 0x0400218A RID: 8586
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int16_Int16_0;

		// Token: 0x0400218B RID: 8587
		private static readonly IntPtr NativeMethodInfoPtr_get_lowerBound_Public_get_Int16_0;

		// Token: 0x0400218C RID: 8588
		private static readonly IntPtr NativeMethodInfoPtr_get_upperBound_Public_get_Int16_0;

		// Token: 0x0400218D RID: 8589
		private static readonly IntPtr NativeMethodInfoPtr_get_all_Public_Static_get_SortingLayerRange_0;

		// Token: 0x0400218E RID: 8590
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SortingLayerRange_0;

		// Token: 0x0400218F RID: 8591
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002190 RID: 8592
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002191 RID: 8593
		[FieldOffset(0)]
		public short m_LowerBound;

		// Token: 0x04002192 RID: 8594
		[FieldOffset(2)]
		public short m_UpperBound;
	}
}
