using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200023E RID: 574
	[StructLayout(2)]
	public struct SortingSettings
	{
		// Token: 0x06002740 RID: 10048 RVA: 0x0009B9D8 File Offset: 0x00099BD8
		// Note: this type is marked as 'beforefieldinit'.
		static SortingSettings()
		{
			Il2CppClassPointerStore<SortingSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "SortingSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr);
			SortingSettings.NativeFieldInfoPtr_m_WorldToCameraMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, "m_WorldToCameraMatrix");
			SortingSettings.NativeFieldInfoPtr_m_CameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, "m_CameraPosition");
			SortingSettings.NativeFieldInfoPtr_m_CustomAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, "m_CustomAxis");
			SortingSettings.NativeFieldInfoPtr_m_Criteria = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, "m_Criteria");
			SortingSettings.NativeFieldInfoPtr_m_DistanceMetric = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, "m_DistanceMetric");
			SortingSettings.NativeMethodInfoPtr__ctor_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, 100667531);
			SortingSettings.NativeMethodInfoPtr_set_customAxis_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, 100667532);
			SortingSettings.NativeMethodInfoPtr_get_criteria_Public_get_SortingCriteria_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, 100667533);
			SortingSettings.NativeMethodInfoPtr_set_criteria_Public_set_Void_SortingCriteria_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, 100667534);
			SortingSettings.NativeMethodInfoPtr_set_distanceMetric_Public_set_Void_DistanceMetric_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, 100667535);
			SortingSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SortingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, 100667536);
			SortingSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, 100667537);
			SortingSettings.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, 100667538);
		}

		// Token: 0x06002741 RID: 10049 RVA: 0x0009BB0C File Offset: 0x00099D0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1291907, RefRangeEnd = 1291910, XrefRangeStart = 1291902, XrefRangeEnd = 1291907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortingSettings(Camera camera)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingSettings.NativeMethodInfoPtr__ctor_Public_Void_Camera_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x0600274E RID: 10062 RVA: 0x0009BCF4 File Offset: 0x00099EF4
		// (set) Token: 0x06002742 RID: 10050 RVA: 0x0009BB44 File Offset: 0x00099D44
		public unsafe Vector3 customAxis
		{
			get
			{
				return this.m_CustomAxis;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 46708, RefRangeEnd = 46711, XrefRangeStart = 46708, XrefRangeEnd = 46711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingSettings.NativeMethodInfoPtr_set_customAxis_Public_set_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06002743 RID: 10051 RVA: 0x0009BB78 File Offset: 0x00099D78
		// (set) Token: 0x06002744 RID: 10052 RVA: 0x0009BBA8 File Offset: 0x00099DA8
		public unsafe SortingCriteria criteria
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingSettings.NativeMethodInfoPtr_get_criteria_Public_get_SortingCriteria_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 44554, RefRangeEnd = 44557, XrefRangeStart = 44554, XrefRangeEnd = 44557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingSettings.NativeMethodInfoPtr_set_criteria_Public_set_Void_SortingCriteria_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x0600274F RID: 10063 RVA: 0x0009BD0C File Offset: 0x00099F0C
		// (set) Token: 0x06002745 RID: 10053 RVA: 0x0009BBDC File Offset: 0x00099DDC
		public unsafe DistanceMetric distanceMetric
		{
			get
			{
				return this.m_DistanceMetric;
			}
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 301601, RefRangeEnd = 301611, XrefRangeStart = 301601, XrefRangeEnd = 301611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingSettings.NativeMethodInfoPtr_set_distanceMetric_Public_set_Void_DistanceMetric_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002746 RID: 10054 RVA: 0x0009BC10 File Offset: 0x00099E10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1291912, RefRangeEnd = 1291913, XrefRangeStart = 1291910, XrefRangeEnd = 1291912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(SortingSettings other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SortingSettings_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002747 RID: 10055 RVA: 0x0009BC50 File Offset: 0x00099E50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291913, XrefRangeEnd = 1291917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002748 RID: 10056 RVA: 0x0009BC94 File Offset: 0x00099E94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1291924, RefRangeEnd = 1291926, XrefRangeStart = 1291917, XrefRangeEnd = 1291924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingSettings.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002749 RID: 10057 RVA: 0x00011AB2 File Offset: 0x0000FCB2
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, ref this));
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x0600274A RID: 10058 RVA: 0x0009BCC4 File Offset: 0x00099EC4
		// (set) Token: 0x0600274B RID: 10059 RVA: 0x00011AC4 File Offset: 0x0000FCC4
		public Matrix4x4 worldToCameraMatrix
		{
			get
			{
				return this.m_WorldToCameraMatrix;
			}
			set
			{
				this.m_WorldToCameraMatrix = value;
			}
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x0600274C RID: 10060 RVA: 0x0009BCDC File Offset: 0x00099EDC
		// (set) Token: 0x0600274D RID: 10061 RVA: 0x00011ACE File Offset: 0x0000FCCE
		public Vector3 cameraPosition
		{
			get
			{
				return this.m_CameraPosition;
			}
			set
			{
				this.m_CameraPosition = value;
			}
		}

		// Token: 0x06002750 RID: 10064 RVA: 0x0009BD24 File Offset: 0x00099F24
		public static bool operator ==(SortingSettings left, SortingSettings right)
		{
			return left.Equals(right);
		}

		// Token: 0x06002751 RID: 10065 RVA: 0x0009BD40 File Offset: 0x00099F40
		public static bool operator !=(SortingSettings left, SortingSettings right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04002197 RID: 8599
		private static readonly IntPtr NativeFieldInfoPtr_m_WorldToCameraMatrix;

		// Token: 0x04002198 RID: 8600
		private static readonly IntPtr NativeFieldInfoPtr_m_CameraPosition;

		// Token: 0x04002199 RID: 8601
		private static readonly IntPtr NativeFieldInfoPtr_m_CustomAxis;

		// Token: 0x0400219A RID: 8602
		private static readonly IntPtr NativeFieldInfoPtr_m_Criteria;

		// Token: 0x0400219B RID: 8603
		private static readonly IntPtr NativeFieldInfoPtr_m_DistanceMetric;

		// Token: 0x0400219C RID: 8604
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Camera_0;

		// Token: 0x0400219D RID: 8605
		private static readonly IntPtr NativeMethodInfoPtr_set_customAxis_Public_set_Void_Vector3_0;

		// Token: 0x0400219E RID: 8606
		private static readonly IntPtr NativeMethodInfoPtr_get_criteria_Public_get_SortingCriteria_0;

		// Token: 0x0400219F RID: 8607
		private static readonly IntPtr NativeMethodInfoPtr_set_criteria_Public_set_Void_SortingCriteria_0;

		// Token: 0x040021A0 RID: 8608
		private static readonly IntPtr NativeMethodInfoPtr_set_distanceMetric_Public_set_Void_DistanceMetric_0;

		// Token: 0x040021A1 RID: 8609
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SortingSettings_0;

		// Token: 0x040021A2 RID: 8610
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040021A3 RID: 8611
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040021A4 RID: 8612
		[FieldOffset(0)]
		public Matrix4x4 m_WorldToCameraMatrix;

		// Token: 0x040021A5 RID: 8613
		[FieldOffset(64)]
		public Vector3 m_CameraPosition;

		// Token: 0x040021A6 RID: 8614
		[FieldOffset(76)]
		public Vector3 m_CustomAxis;

		// Token: 0x040021A7 RID: 8615
		[FieldOffset(88)]
		public SortingCriteria m_Criteria;

		// Token: 0x040021A8 RID: 8616
		[FieldOffset(92)]
		public DistanceMetric m_DistanceMetric;
	}
}
