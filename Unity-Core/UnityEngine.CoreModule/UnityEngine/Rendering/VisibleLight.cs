using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000241 RID: 577
	[StructLayout(2)]
	public struct VisibleLight
	{
		// Token: 0x06002807 RID: 10247 RVA: 0x0009D948 File Offset: 0x0009BB48
		// Note: this type is marked as 'beforefieldinit'.
		static VisibleLight()
		{
			Il2CppClassPointerStore<VisibleLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "VisibleLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr);
			VisibleLight.NativeFieldInfoPtr_m_LightType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, "m_LightType");
			VisibleLight.NativeFieldInfoPtr_m_FinalColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, "m_FinalColor");
			VisibleLight.NativeFieldInfoPtr_m_ScreenRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, "m_ScreenRect");
			VisibleLight.NativeFieldInfoPtr_m_LocalToWorldMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, "m_LocalToWorldMatrix");
			VisibleLight.NativeFieldInfoPtr_m_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, "m_Range");
			VisibleLight.NativeFieldInfoPtr_m_SpotAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, "m_SpotAngle");
			VisibleLight.NativeFieldInfoPtr_m_InstanceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, "m_InstanceId");
			VisibleLight.NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, "m_Flags");
			VisibleLight.NativeMethodInfoPtr_get_light_Public_get_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, 100667600);
			VisibleLight.NativeMethodInfoPtr_get_lightType_Public_get_LightType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, 100667601);
			VisibleLight.NativeMethodInfoPtr_get_finalColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, 100667602);
			VisibleLight.NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, 100667603);
			VisibleLight.NativeMethodInfoPtr_get_range_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, 100667604);
			VisibleLight.NativeMethodInfoPtr_get_spotAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, 100667605);
			VisibleLight.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VisibleLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, 100667606);
			VisibleLight.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, 100667607);
			VisibleLight.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, 100667608);
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x06002808 RID: 10248 RVA: 0x0009DACC File Offset: 0x0009BCCC
		public unsafe Light light
		{
			[CallerCount(40)]
			[CachedScanResults(RefRangeStart = 1292178, RefRangeEnd = 1292218, XrefRangeStart = 1292173, XrefRangeEnd = 1292178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibleLight.NativeMethodInfoPtr_get_light_Public_get_Light_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Light>(intPtr3) : null;
			}
		}

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06002809 RID: 10249 RVA: 0x0009DB00 File Offset: 0x0009BD00
		// (set) Token: 0x06002812 RID: 10258 RVA: 0x00011FDB File Offset: 0x000101DB
		public unsafe LightType lightType
		{
			[CallerCount(261)]
			[CachedScanResults(RefRangeStart = 1218881, RefRangeEnd = 1219142, XrefRangeStart = 1218881, XrefRangeEnd = 1219142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibleLight.NativeMethodInfoPtr_get_lightType_Public_get_LightType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_LightType = value;
			}
		}

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x0600280A RID: 10250 RVA: 0x0009DB30 File Offset: 0x0009BD30
		// (set) Token: 0x06002813 RID: 10259 RVA: 0x00011FE5 File Offset: 0x000101E5
		public unsafe Color finalColor
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 1292218, RefRangeEnd = 1292233, XrefRangeStart = 1292218, XrefRangeEnd = 1292218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibleLight.NativeMethodInfoPtr_get_finalColor_Public_get_Color_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_FinalColor = value;
			}
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x0600280B RID: 10251 RVA: 0x0009DB60 File Offset: 0x0009BD60
		// (set) Token: 0x06002816 RID: 10262 RVA: 0x00011FF9 File Offset: 0x000101F9
		public unsafe Matrix4x4 localToWorldMatrix
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 1292233, RefRangeEnd = 1292244, XrefRangeStart = 1292233, XrefRangeEnd = 1292233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibleLight.NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_LocalToWorldMatrix = value;
			}
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x0600280C RID: 10252 RVA: 0x0009DB90 File Offset: 0x0009BD90
		// (set) Token: 0x06002817 RID: 10263 RVA: 0x00012003 File Offset: 0x00010203
		public unsafe float range
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 1292244, RefRangeEnd = 1292259, XrefRangeStart = 1292244, XrefRangeEnd = 1292244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibleLight.NativeMethodInfoPtr_get_range_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Range = value;
			}
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x0600280D RID: 10253 RVA: 0x0009DBC0 File Offset: 0x0009BDC0
		// (set) Token: 0x06002818 RID: 10264 RVA: 0x0001200D File Offset: 0x0001020D
		public unsafe float spotAngle
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1292259, RefRangeEnd = 1292266, XrefRangeStart = 1292259, XrefRangeEnd = 1292259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibleLight.NativeMethodInfoPtr_get_spotAngle_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_SpotAngle = value;
			}
		}

		// Token: 0x0600280E RID: 10254 RVA: 0x0009DBF0 File Offset: 0x0009BDF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1292278, RefRangeEnd = 1292279, XrefRangeStart = 1292266, XrefRangeEnd = 1292278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(VisibleLight other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibleLight.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VisibleLight_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600280F RID: 10255 RVA: 0x0009DC30 File Offset: 0x0009BE30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292279, XrefRangeEnd = 1292283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibleLight.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002810 RID: 10256 RVA: 0x0009DC74 File Offset: 0x0009BE74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292283, XrefRangeEnd = 1292291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibleLight.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002811 RID: 10257 RVA: 0x00011FC9 File Offset: 0x000101C9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, ref this));
		}

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x06002814 RID: 10260 RVA: 0x0009DCA4 File Offset: 0x0009BEA4
		// (set) Token: 0x06002815 RID: 10261 RVA: 0x00011FEF File Offset: 0x000101EF
		public Rect screenRect
		{
			get
			{
				return this.m_ScreenRect;
			}
			set
			{
				this.m_ScreenRect = value;
			}
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x06002819 RID: 10265 RVA: 0x0009DCBC File Offset: 0x0009BEBC
		// (set) Token: 0x0600281A RID: 10266 RVA: 0x0009DCDC File Offset: 0x0009BEDC
		public bool intersectsNearPlane
		{
			get
			{
				return (this.m_Flags & VisibleLightFlags.IntersectsNearPlane) > (VisibleLightFlags)0;
			}
			set
			{
				if (value)
				{
					this.m_Flags |= VisibleLightFlags.IntersectsNearPlane;
				}
				else
				{
					this.m_Flags &= ~VisibleLightFlags.IntersectsNearPlane;
				}
			}
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x0600281B RID: 10267 RVA: 0x0009DD10 File Offset: 0x0009BF10
		// (set) Token: 0x0600281C RID: 10268 RVA: 0x0009DD30 File Offset: 0x0009BF30
		public bool intersectsFarPlane
		{
			get
			{
				return (this.m_Flags & VisibleLightFlags.IntersectsFarPlane) > (VisibleLightFlags)0;
			}
			set
			{
				if (value)
				{
					this.m_Flags |= VisibleLightFlags.IntersectsFarPlane;
				}
				else
				{
					this.m_Flags &= ~VisibleLightFlags.IntersectsFarPlane;
				}
			}
		}

		// Token: 0x0600281D RID: 10269 RVA: 0x0009DD64 File Offset: 0x0009BF64
		public static bool operator ==(VisibleLight left, VisibleLight right)
		{
			return left.Equals(right);
		}

		// Token: 0x0600281E RID: 10270 RVA: 0x0009DD80 File Offset: 0x0009BF80
		public static bool operator !=(VisibleLight left, VisibleLight right)
		{
			return !left.Equals(right);
		}

		// Token: 0x0400221C RID: 8732
		private static readonly IntPtr NativeFieldInfoPtr_m_LightType;

		// Token: 0x0400221D RID: 8733
		private static readonly IntPtr NativeFieldInfoPtr_m_FinalColor;

		// Token: 0x0400221E RID: 8734
		private static readonly IntPtr NativeFieldInfoPtr_m_ScreenRect;

		// Token: 0x0400221F RID: 8735
		private static readonly IntPtr NativeFieldInfoPtr_m_LocalToWorldMatrix;

		// Token: 0x04002220 RID: 8736
		private static readonly IntPtr NativeFieldInfoPtr_m_Range;

		// Token: 0x04002221 RID: 8737
		private static readonly IntPtr NativeFieldInfoPtr_m_SpotAngle;

		// Token: 0x04002222 RID: 8738
		private static readonly IntPtr NativeFieldInfoPtr_m_InstanceId;

		// Token: 0x04002223 RID: 8739
		private static readonly IntPtr NativeFieldInfoPtr_m_Flags;

		// Token: 0x04002224 RID: 8740
		private static readonly IntPtr NativeMethodInfoPtr_get_light_Public_get_Light_0;

		// Token: 0x04002225 RID: 8741
		private static readonly IntPtr NativeMethodInfoPtr_get_lightType_Public_get_LightType_0;

		// Token: 0x04002226 RID: 8742
		private static readonly IntPtr NativeMethodInfoPtr_get_finalColor_Public_get_Color_0;

		// Token: 0x04002227 RID: 8743
		private static readonly IntPtr NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0;

		// Token: 0x04002228 RID: 8744
		private static readonly IntPtr NativeMethodInfoPtr_get_range_Public_get_Single_0;

		// Token: 0x04002229 RID: 8745
		private static readonly IntPtr NativeMethodInfoPtr_get_spotAngle_Public_get_Single_0;

		// Token: 0x0400222A RID: 8746
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VisibleLight_0;

		// Token: 0x0400222B RID: 8747
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400222C RID: 8748
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400222D RID: 8749
		[FieldOffset(0)]
		public LightType m_LightType;

		// Token: 0x0400222E RID: 8750
		[FieldOffset(4)]
		public Color m_FinalColor;

		// Token: 0x0400222F RID: 8751
		[FieldOffset(20)]
		public Rect m_ScreenRect;

		// Token: 0x04002230 RID: 8752
		[FieldOffset(36)]
		public Matrix4x4 m_LocalToWorldMatrix;

		// Token: 0x04002231 RID: 8753
		[FieldOffset(100)]
		public float m_Range;

		// Token: 0x04002232 RID: 8754
		[FieldOffset(104)]
		public float m_SpotAngle;

		// Token: 0x04002233 RID: 8755
		[FieldOffset(108)]
		public int m_InstanceId;

		// Token: 0x04002234 RID: 8756
		[FieldOffset(112)]
		public VisibleLightFlags m_Flags;
	}
}
