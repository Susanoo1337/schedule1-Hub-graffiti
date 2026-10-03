using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000239 RID: 569
	[StructLayout(2)]
	public struct ShadowDrawingSettings
	{
		// Token: 0x06002708 RID: 9992 RVA: 0x0009AFF0 File Offset: 0x000991F0
		// Note: this type is marked as 'beforefieldinit'.
		static ShadowDrawingSettings()
		{
			Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "ShadowDrawingSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr);
			ShadowDrawingSettings.NativeFieldInfoPtr_m_CullingResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, "m_CullingResults");
			ShadowDrawingSettings.NativeFieldInfoPtr_m_LightIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, "m_LightIndex");
			ShadowDrawingSettings.NativeFieldInfoPtr_m_UseRenderingLayerMaskTest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, "m_UseRenderingLayerMaskTest");
			ShadowDrawingSettings.NativeFieldInfoPtr_m_SplitData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, "m_SplitData");
			ShadowDrawingSettings.NativeFieldInfoPtr_m_ObjectsFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, "m_ObjectsFilter");
			ShadowDrawingSettings.NativeFieldInfoPtr_m_ProjectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, "m_ProjectionType");
			ShadowDrawingSettings.NativeMethodInfoPtr_set_useRenderingLayerMaskTest_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, 100667510);
			ShadowDrawingSettings.NativeMethodInfoPtr_set_splitData_Public_set_Void_ShadowSplitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, 100667511);
			ShadowDrawingSettings.NativeMethodInfoPtr__ctor_Public_Void_CullingResults_Int32_BatchCullingProjectionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, 100667512);
			ShadowDrawingSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ShadowDrawingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, 100667513);
			ShadowDrawingSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, 100667514);
			ShadowDrawingSettings.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, 100667515);
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x06002714 RID: 10004 RVA: 0x0009B2AC File Offset: 0x000994AC
		// (set) Token: 0x06002709 RID: 9993 RVA: 0x0009B110 File Offset: 0x00099310
		public unsafe bool useRenderingLayerMaskTest
		{
			get
			{
				return this.m_UseRenderingLayerMaskTest != 0;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1218871, RefRangeEnd = 1218874, XrefRangeStart = 1218871, XrefRangeEnd = 1218874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowDrawingSettings.NativeMethodInfoPtr_set_useRenderingLayerMaskTest_Public_set_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x06002715 RID: 10005 RVA: 0x0009B2C8 File Offset: 0x000994C8
		// (set) Token: 0x0600270A RID: 9994 RVA: 0x0009B144 File Offset: 0x00099344
		public unsafe ShadowSplitData splitData
		{
			get
			{
				return this.m_SplitData;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1291823, RefRangeEnd = 1291825, XrefRangeStart = 1291823, XrefRangeEnd = 1291823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowDrawingSettings.NativeMethodInfoPtr_set_splitData_Public_set_Void_ShadowSplitData_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600270B RID: 9995 RVA: 0x0009B178 File Offset: 0x00099378
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1291830, RefRangeEnd = 1291832, XrefRangeStart = 1291825, XrefRangeEnd = 1291830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShadowDrawingSettings(CullingResults cullingResults, int lightIndex, BatchCullingProjectionType projectionType)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cullingResults;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lightIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref projectionType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowDrawingSettings.NativeMethodInfoPtr__ctor_Public_Void_CullingResults_Int32_BatchCullingProjectionType_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600270C RID: 9996 RVA: 0x0009B1C8 File Offset: 0x000993C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1291843, RefRangeEnd = 1291844, XrefRangeStart = 1291832, XrefRangeEnd = 1291843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(ShadowDrawingSettings other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowDrawingSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ShadowDrawingSettings_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600270D RID: 9997 RVA: 0x0009B208 File Offset: 0x00099408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291844, XrefRangeEnd = 1291848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowDrawingSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600270E RID: 9998 RVA: 0x0009B24C File Offset: 0x0009944C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291848, XrefRangeEnd = 1291856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowDrawingSettings.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600270F RID: 9999 RVA: 0x000119F9 File Offset: 0x0000FBF9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, ref this));
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x06002710 RID: 10000 RVA: 0x0009B27C File Offset: 0x0009947C
		// (set) Token: 0x06002711 RID: 10001 RVA: 0x00011A0B File Offset: 0x0000FC0B
		public CullingResults cullingResults
		{
			get
			{
				return this.m_CullingResults;
			}
			set
			{
				this.m_CullingResults = value;
			}
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x06002712 RID: 10002 RVA: 0x0009B294 File Offset: 0x00099494
		// (set) Token: 0x06002713 RID: 10003 RVA: 0x00011A15 File Offset: 0x0000FC15
		public int lightIndex
		{
			get
			{
				return this.m_LightIndex;
			}
			set
			{
				this.m_LightIndex = value;
			}
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x06002716 RID: 10006 RVA: 0x0009B2E0 File Offset: 0x000994E0
		// (set) Token: 0x06002717 RID: 10007 RVA: 0x00011A1F File Offset: 0x0000FC1F
		public ShadowObjectsFilter objectsFilter
		{
			get
			{
				return this.m_ObjectsFilter;
			}
			set
			{
				this.m_ObjectsFilter = value;
			}
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x06002718 RID: 10008 RVA: 0x0009B2F8 File Offset: 0x000994F8
		// (set) Token: 0x06002719 RID: 10009 RVA: 0x00011A29 File Offset: 0x0000FC29
		public BatchCullingProjectionType projectionType
		{
			get
			{
				return this.m_ProjectionType;
			}
			set
			{
				this.m_ProjectionType = value;
			}
		}

		// Token: 0x0600271A RID: 10010 RVA: 0x0009B310 File Offset: 0x00099510
		public static bool operator ==(ShadowDrawingSettings left, ShadowDrawingSettings right)
		{
			return left.Equals(right);
		}

		// Token: 0x0600271B RID: 10011 RVA: 0x0009B32C File Offset: 0x0009952C
		public static bool operator !=(ShadowDrawingSettings left, ShadowDrawingSettings right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04002156 RID: 8534
		private static readonly IntPtr NativeFieldInfoPtr_m_CullingResults;

		// Token: 0x04002157 RID: 8535
		private static readonly IntPtr NativeFieldInfoPtr_m_LightIndex;

		// Token: 0x04002158 RID: 8536
		private static readonly IntPtr NativeFieldInfoPtr_m_UseRenderingLayerMaskTest;

		// Token: 0x04002159 RID: 8537
		private static readonly IntPtr NativeFieldInfoPtr_m_SplitData;

		// Token: 0x0400215A RID: 8538
		private static readonly IntPtr NativeFieldInfoPtr_m_ObjectsFilter;

		// Token: 0x0400215B RID: 8539
		private static readonly IntPtr NativeFieldInfoPtr_m_ProjectionType;

		// Token: 0x0400215C RID: 8540
		private static readonly IntPtr NativeMethodInfoPtr_set_useRenderingLayerMaskTest_Public_set_Void_Boolean_0;

		// Token: 0x0400215D RID: 8541
		private static readonly IntPtr NativeMethodInfoPtr_set_splitData_Public_set_Void_ShadowSplitData_0;

		// Token: 0x0400215E RID: 8542
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CullingResults_Int32_BatchCullingProjectionType_0;

		// Token: 0x0400215F RID: 8543
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ShadowDrawingSettings_0;

		// Token: 0x04002160 RID: 8544
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002161 RID: 8545
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002162 RID: 8546
		[FieldOffset(0)]
		public CullingResults m_CullingResults;

		// Token: 0x04002163 RID: 8547
		[FieldOffset(16)]
		public int m_LightIndex;

		// Token: 0x04002164 RID: 8548
		[FieldOffset(20)]
		public int m_UseRenderingLayerMaskTest;

		// Token: 0x04002165 RID: 8549
		[FieldOffset(24)]
		public ShadowSplitData m_SplitData;

		// Token: 0x04002166 RID: 8550
		[FieldOffset(276)]
		public ShadowObjectsFilter m_ObjectsFilter;

		// Token: 0x04002167 RID: 8551
		[FieldOffset(280)]
		public BatchCullingProjectionType m_ProjectionType;
	}
}
