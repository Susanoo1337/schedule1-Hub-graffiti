using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000228 RID: 552
	[StructLayout(2)]
	public struct LODParameters
	{
		// Token: 0x0600258D RID: 9613 RVA: 0x00095D2C File Offset: 0x00093F2C
		// Note: this type is marked as 'beforefieldinit'.
		static LODParameters()
		{
			Il2CppClassPointerStore<LODParameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "LODParameters");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LODParameters>.NativeClassPtr);
			LODParameters.NativeFieldInfoPtr_m_IsOrthographic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, "m_IsOrthographic");
			LODParameters.NativeFieldInfoPtr_m_CameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, "m_CameraPosition");
			LODParameters.NativeFieldInfoPtr_m_FieldOfView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, "m_FieldOfView");
			LODParameters.NativeFieldInfoPtr_m_OrthoSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, "m_OrthoSize");
			LODParameters.NativeFieldInfoPtr_m_CameraPixelHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, "m_CameraPixelHeight");
			LODParameters.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LODParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, 100667322);
			LODParameters.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, 100667323);
			LODParameters.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, 100667324);
		}

		// Token: 0x0600258E RID: 9614 RVA: 0x00095DFC File Offset: 0x00093FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290562, XrefRangeEnd = 1290564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(LODParameters other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LODParameters.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LODParameters_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600258F RID: 9615 RVA: 0x00095E3C File Offset: 0x0009403C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290564, XrefRangeEnd = 1290566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LODParameters.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002590 RID: 9616 RVA: 0x00095E80 File Offset: 0x00094080
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1290571, RefRangeEnd = 1290572, XrefRangeStart = 1290566, XrefRangeEnd = 1290571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LODParameters.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002591 RID: 9617 RVA: 0x00011300 File Offset: 0x0000F500
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, ref this));
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x06002592 RID: 9618 RVA: 0x00095EB0 File Offset: 0x000940B0
		// (set) Token: 0x06002593 RID: 9619 RVA: 0x00011312 File Offset: 0x0000F512
		public bool isOrthographic
		{
			get
			{
				return Convert.ToBoolean(this.m_IsOrthographic);
			}
			set
			{
				this.m_IsOrthographic = Convert.ToInt32(value);
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x06002594 RID: 9620 RVA: 0x00095ED0 File Offset: 0x000940D0
		// (set) Token: 0x06002595 RID: 9621 RVA: 0x00011321 File Offset: 0x0000F521
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

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06002596 RID: 9622 RVA: 0x00095EE8 File Offset: 0x000940E8
		// (set) Token: 0x06002597 RID: 9623 RVA: 0x0001132B File Offset: 0x0000F52B
		public float fieldOfView
		{
			get
			{
				return this.m_FieldOfView;
			}
			set
			{
				this.m_FieldOfView = value;
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06002598 RID: 9624 RVA: 0x00095F00 File Offset: 0x00094100
		// (set) Token: 0x06002599 RID: 9625 RVA: 0x00011335 File Offset: 0x0000F535
		public float orthoSize
		{
			get
			{
				return this.m_OrthoSize;
			}
			set
			{
				this.m_OrthoSize = value;
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x0600259A RID: 9626 RVA: 0x00095F18 File Offset: 0x00094118
		// (set) Token: 0x0600259B RID: 9627 RVA: 0x0001133F File Offset: 0x0000F53F
		public int cameraPixelHeight
		{
			get
			{
				return this.m_CameraPixelHeight;
			}
			set
			{
				this.m_CameraPixelHeight = value;
			}
		}

		// Token: 0x0600259C RID: 9628 RVA: 0x00095F30 File Offset: 0x00094130
		public static bool operator ==(LODParameters left, LODParameters right)
		{
			return left.Equals(right);
		}

		// Token: 0x0600259D RID: 9629 RVA: 0x00095F4C File Offset: 0x0009414C
		public static bool operator !=(LODParameters left, LODParameters right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04002019 RID: 8217
		private static readonly IntPtr NativeFieldInfoPtr_m_IsOrthographic;

		// Token: 0x0400201A RID: 8218
		private static readonly IntPtr NativeFieldInfoPtr_m_CameraPosition;

		// Token: 0x0400201B RID: 8219
		private static readonly IntPtr NativeFieldInfoPtr_m_FieldOfView;

		// Token: 0x0400201C RID: 8220
		private static readonly IntPtr NativeFieldInfoPtr_m_OrthoSize;

		// Token: 0x0400201D RID: 8221
		private static readonly IntPtr NativeFieldInfoPtr_m_CameraPixelHeight;

		// Token: 0x0400201E RID: 8222
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LODParameters_0;

		// Token: 0x0400201F RID: 8223
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002020 RID: 8224
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002021 RID: 8225
		[FieldOffset(0)]
		public int m_IsOrthographic;

		// Token: 0x04002022 RID: 8226
		[FieldOffset(4)]
		public Vector3 m_CameraPosition;

		// Token: 0x04002023 RID: 8227
		[FieldOffset(16)]
		public float m_FieldOfView;

		// Token: 0x04002024 RID: 8228
		[FieldOffset(20)]
		public float m_OrthoSize;

		// Token: 0x04002025 RID: 8229
		[FieldOffset(24)]
		public int m_CameraPixelHeight;
	}
}
