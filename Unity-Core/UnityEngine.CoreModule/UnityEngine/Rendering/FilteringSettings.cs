using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000226 RID: 550
	[StructLayout(2)]
	public struct FilteringSettings
	{
		// Token: 0x0600257A RID: 9594 RVA: 0x00095870 File Offset: 0x00093A70
		// Note: this type is marked as 'beforefieldinit'.
		static FilteringSettings()
		{
			Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "FilteringSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr);
			FilteringSettings.NativeFieldInfoPtr_m_RenderQueueRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, "m_RenderQueueRange");
			FilteringSettings.NativeFieldInfoPtr_m_LayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, "m_LayerMask");
			FilteringSettings.NativeFieldInfoPtr_m_RenderingLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, "m_RenderingLayerMask");
			FilteringSettings.NativeFieldInfoPtr_m_ExcludeMotionVectorObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, "m_ExcludeMotionVectorObjects");
			FilteringSettings.NativeFieldInfoPtr_m_SortingLayerRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, "m_SortingLayerRange");
			FilteringSettings.NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_RenderQueueRange_Int32_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, 100667310);
			FilteringSettings.NativeMethodInfoPtr_get_renderQueueRange_Public_get_RenderQueueRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, 100667311);
			FilteringSettings.NativeMethodInfoPtr_set_renderQueueRange_Public_set_Void_RenderQueueRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, 100667312);
			FilteringSettings.NativeMethodInfoPtr_get_layerMask_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, 100667313);
			FilteringSettings.NativeMethodInfoPtr_set_layerMask_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, 100667314);
			FilteringSettings.NativeMethodInfoPtr_set_renderingLayerMask_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, 100667315);
			FilteringSettings.NativeMethodInfoPtr_set_excludeMotionVectorObjects_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, 100667316);
			FilteringSettings.NativeMethodInfoPtr_set_sortingLayerRange_Public_set_Void_SortingLayerRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, 100667317);
			FilteringSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FilteringSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, 100667318);
			FilteringSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, 100667319);
			FilteringSettings.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, 100667320);
			FilteringSettings.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FilteringSettings_FilteringSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, 100667321);
		}

		// Token: 0x0600257B RID: 9595 RVA: 0x000959F4 File Offset: 0x00093BF4
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 1290527, RefRangeEnd = 1290548, XrefRangeStart = 1290519, XrefRangeEnd = 1290527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FilteringSettings(Nullable<RenderQueueRange> renderQueueRange = null, int layerMask = -1, uint renderingLayerMask = 4294967295U, int excludeMotionVectorObjects = 0)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(renderQueueRange));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderingLayerMask;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref excludeMotionVectorObjects;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilteringSettings.NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_RenderQueueRange_Int32_UInt32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x0600257C RID: 9596 RVA: 0x00095A5C File Offset: 0x00093C5C
		// (set) Token: 0x0600257D RID: 9597 RVA: 0x00095A8C File Offset: 0x00093C8C
		public unsafe RenderQueueRange renderQueueRange
		{
			[CallerCount(163)]
			[CachedScanResults(RefRangeStart = 532930, RefRangeEnd = 533093, XrefRangeStart = 532930, XrefRangeEnd = 533093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilteringSettings.NativeMethodInfoPtr_get_renderQueueRange_Public_get_RenderQueueRange_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(35)]
			[CachedScanResults(RefRangeStart = 389084, RefRangeEnd = 389119, XrefRangeStart = 389084, XrefRangeEnd = 389119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilteringSettings.NativeMethodInfoPtr_set_renderQueueRange_Public_set_Void_RenderQueueRange_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x0600257E RID: 9598 RVA: 0x00095AC0 File Offset: 0x00093CC0
		// (set) Token: 0x0600257F RID: 9599 RVA: 0x00095AF0 File Offset: 0x00093CF0
		public unsafe int layerMask
		{
			[CallerCount(29)]
			[CachedScanResults(RefRangeStart = 1222651, RefRangeEnd = 1222680, XrefRangeStart = 1222651, XrefRangeEnd = 1222680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilteringSettings.NativeMethodInfoPtr_get_layerMask_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 29176, RefRangeEnd = 29187, XrefRangeStart = 29176, XrefRangeEnd = 29187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilteringSettings.NativeMethodInfoPtr_set_layerMask_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x06002589 RID: 9609 RVA: 0x00095CC0 File Offset: 0x00093EC0
		// (set) Token: 0x06002580 RID: 9600 RVA: 0x00095B24 File Offset: 0x00093D24
		public unsafe uint renderingLayerMask
		{
			get
			{
				return this.m_RenderingLayerMask;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 29190, RefRangeEnd = 29194, XrefRangeStart = 29190, XrefRangeEnd = 29194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilteringSettings.NativeMethodInfoPtr_set_renderingLayerMask_Public_set_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x0600258A RID: 9610 RVA: 0x00095CD8 File Offset: 0x00093ED8
		// (set) Token: 0x06002581 RID: 9601 RVA: 0x00095B58 File Offset: 0x00093D58
		public unsafe bool excludeMotionVectorObjects
		{
			get
			{
				return this.m_ExcludeMotionVectorObjects != 0;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1218869, RefRangeEnd = 1218871, XrefRangeStart = 1218869, XrefRangeEnd = 1218871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilteringSettings.NativeMethodInfoPtr_set_excludeMotionVectorObjects_Public_set_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x0600258B RID: 9611 RVA: 0x00095CF4 File Offset: 0x00093EF4
		// (set) Token: 0x06002582 RID: 9602 RVA: 0x00095B8C File Offset: 0x00093D8C
		public unsafe SortingLayerRange sortingLayerRange
		{
			get
			{
				return this.m_SortingLayerRange;
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 168968, RefRangeEnd = 168976, XrefRangeStart = 168968, XrefRangeEnd = 168976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilteringSettings.NativeMethodInfoPtr_set_sortingLayerRange_Public_set_Void_SortingLayerRange_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002583 RID: 9603 RVA: 0x00095BC0 File Offset: 0x00093DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290548, XrefRangeEnd = 1290552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(FilteringSettings other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilteringSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FilteringSettings_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002584 RID: 9604 RVA: 0x00095C00 File Offset: 0x00093E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290552, XrefRangeEnd = 1290554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilteringSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002585 RID: 9605 RVA: 0x00095C44 File Offset: 0x00093E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290554, XrefRangeEnd = 1290558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilteringSettings.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002586 RID: 9606 RVA: 0x00095C74 File Offset: 0x00093E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290558, XrefRangeEnd = 1290562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(FilteringSettings left, FilteringSettings right)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref left;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilteringSettings.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FilteringSettings_FilteringSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002587 RID: 9607 RVA: 0x000112DA File Offset: 0x0000F4DA
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, ref this));
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06002588 RID: 9608 RVA: 0x000112EC File Offset: 0x0000F4EC
		public static FilteringSettings defaultValue
		{
			get
			{
				return new FilteringSettings(new Nullable<RenderQueueRange>(RenderQueueRange.all), -1, uint.MaxValue, 0);
			}
		}

		// Token: 0x0600258C RID: 9612 RVA: 0x00095D0C File Offset: 0x00093F0C
		public static bool operator !=(FilteringSettings left, FilteringSettings right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04002000 RID: 8192
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderQueueRange;

		// Token: 0x04002001 RID: 8193
		private static readonly IntPtr NativeFieldInfoPtr_m_LayerMask;

		// Token: 0x04002002 RID: 8194
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderingLayerMask;

		// Token: 0x04002003 RID: 8195
		private static readonly IntPtr NativeFieldInfoPtr_m_ExcludeMotionVectorObjects;

		// Token: 0x04002004 RID: 8196
		private static readonly IntPtr NativeFieldInfoPtr_m_SortingLayerRange;

		// Token: 0x04002005 RID: 8197
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_RenderQueueRange_Int32_UInt32_Int32_0;

		// Token: 0x04002006 RID: 8198
		private static readonly IntPtr NativeMethodInfoPtr_get_renderQueueRange_Public_get_RenderQueueRange_0;

		// Token: 0x04002007 RID: 8199
		private static readonly IntPtr NativeMethodInfoPtr_set_renderQueueRange_Public_set_Void_RenderQueueRange_0;

		// Token: 0x04002008 RID: 8200
		private static readonly IntPtr NativeMethodInfoPtr_get_layerMask_Public_get_Int32_0;

		// Token: 0x04002009 RID: 8201
		private static readonly IntPtr NativeMethodInfoPtr_set_layerMask_Public_set_Void_Int32_0;

		// Token: 0x0400200A RID: 8202
		private static readonly IntPtr NativeMethodInfoPtr_set_renderingLayerMask_Public_set_Void_UInt32_0;

		// Token: 0x0400200B RID: 8203
		private static readonly IntPtr NativeMethodInfoPtr_set_excludeMotionVectorObjects_Public_set_Void_Boolean_0;

		// Token: 0x0400200C RID: 8204
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingLayerRange_Public_set_Void_SortingLayerRange_0;

		// Token: 0x0400200D RID: 8205
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FilteringSettings_0;

		// Token: 0x0400200E RID: 8206
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400200F RID: 8207
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002010 RID: 8208
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FilteringSettings_FilteringSettings_0;

		// Token: 0x04002011 RID: 8209
		[FieldOffset(0)]
		public RenderQueueRange m_RenderQueueRange;

		// Token: 0x04002012 RID: 8210
		[FieldOffset(8)]
		public int m_LayerMask;

		// Token: 0x04002013 RID: 8211
		[FieldOffset(12)]
		public uint m_RenderingLayerMask;

		// Token: 0x04002014 RID: 8212
		[FieldOffset(16)]
		public int m_ExcludeMotionVectorObjects;

		// Token: 0x04002015 RID: 8213
		[FieldOffset(20)]
		public SortingLayerRange m_SortingLayerRange;
	}
}
