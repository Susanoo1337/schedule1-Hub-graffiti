using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x02000270 RID: 624
	[StructLayout(2)]
	public struct LightDataGI
	{
		// Token: 0x06002ADF RID: 10975 RVA: 0x000A73FC File Offset: 0x000A55FC
		// Note: this type is marked as 'beforefieldinit'.
		static LightDataGI()
		{
			Il2CppClassPointerStore<LightDataGI>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "LightDataGI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr);
			LightDataGI.NativeFieldInfoPtr_instanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "instanceID");
			LightDataGI.NativeFieldInfoPtr_cookieID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "cookieID");
			LightDataGI.NativeFieldInfoPtr_cookieScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "cookieScale");
			LightDataGI.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "color");
			LightDataGI.NativeFieldInfoPtr_indirectColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "indirectColor");
			LightDataGI.NativeFieldInfoPtr_orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "orientation");
			LightDataGI.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "position");
			LightDataGI.NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "range");
			LightDataGI.NativeFieldInfoPtr_coneAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "coneAngle");
			LightDataGI.NativeFieldInfoPtr_innerConeAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "innerConeAngle");
			LightDataGI.NativeFieldInfoPtr_shape0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "shape0");
			LightDataGI.NativeFieldInfoPtr_shape1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "shape1");
			LightDataGI.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "type");
			LightDataGI.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "mode");
			LightDataGI.NativeFieldInfoPtr_shadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "shadow");
			LightDataGI.NativeFieldInfoPtr_falloff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "falloff");
			LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_DirectionalLight_byref_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, 100667912);
			LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_PointLight_byref_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, 100667913);
			LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_SpotLight_byref_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, 100667914);
			LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_RectangleLight_byref_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, 100667915);
			LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_DiscLight_byref_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, 100667916);
			LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_DirectionalLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, 100667917);
			LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_PointLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, 100667918);
			LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_SpotLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, 100667919);
			LightDataGI.NativeMethodInfoPtr_InitNoBake_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, 100667920);
		}

		// Token: 0x06002AE0 RID: 10976 RVA: 0x000A7620 File Offset: 0x000A5820
		[CallerCount(0)]
		public unsafe void Init(ref DirectionalLight light, ref Cookie cookie)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &light;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cookie;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_DirectionalLight_byref_Cookie_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AE1 RID: 10977 RVA: 0x000A7660 File Offset: 0x000A5860
		[CallerCount(0)]
		public unsafe void Init(ref PointLight light, ref Cookie cookie)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &light;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cookie;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_PointLight_byref_Cookie_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AE2 RID: 10978 RVA: 0x000A76A0 File Offset: 0x000A58A0
		[CallerCount(0)]
		public unsafe void Init(ref SpotLight light, ref Cookie cookie)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &light;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cookie;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_SpotLight_byref_Cookie_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AE3 RID: 10979 RVA: 0x000A76E0 File Offset: 0x000A58E0
		[CallerCount(0)]
		public unsafe void Init(ref RectangleLight light, ref Cookie cookie)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &light;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cookie;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_RectangleLight_byref_Cookie_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AE4 RID: 10980 RVA: 0x000A7720 File Offset: 0x000A5920
		[CallerCount(0)]
		public unsafe void Init(ref DiscLight light, ref Cookie cookie)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &light;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cookie;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_DiscLight_byref_Cookie_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AE5 RID: 10981 RVA: 0x000A7760 File Offset: 0x000A5960
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1294107, RefRangeEnd = 1294108, XrefRangeStart = 1294107, XrefRangeEnd = 1294107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(ref DirectionalLight light)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &light;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_DirectionalLight_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AE6 RID: 10982 RVA: 0x000A7794 File Offset: 0x000A5994
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1294108, RefRangeEnd = 1294109, XrefRangeStart = 1294108, XrefRangeEnd = 1294108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(ref PointLight light)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &light;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_PointLight_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AE7 RID: 10983 RVA: 0x000A77C8 File Offset: 0x000A59C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1294109, RefRangeEnd = 1294110, XrefRangeStart = 1294109, XrefRangeEnd = 1294109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(ref SpotLight light)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &light;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_SpotLight_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AE8 RID: 10984 RVA: 0x000A77FC File Offset: 0x000A59FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1294110, RefRangeEnd = 1294112, XrefRangeStart = 1294110, XrefRangeEnd = 1294110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitNoBake(int lightInstanceID)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lightInstanceID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightDataGI.NativeMethodInfoPtr_InitNoBake_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AE9 RID: 10985 RVA: 0x00012E8C File Offset: 0x0001108C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, ref this));
		}

		// Token: 0x06002AEA RID: 10986 RVA: 0x000A7830 File Offset: 0x000A5A30
		public void Init(ref RectangleLight light)
		{
			Cookie cookie = Cookie.Defaults();
			this.Init(ref light, ref cookie);
		}

		// Token: 0x06002AEB RID: 10987 RVA: 0x000A7850 File Offset: 0x000A5A50
		public void Init(ref DiscLight light)
		{
			Cookie cookie = Cookie.Defaults();
			this.Init(ref light, ref cookie);
		}

		// Token: 0x040024D8 RID: 9432
		private static readonly IntPtr NativeFieldInfoPtr_instanceID;

		// Token: 0x040024D9 RID: 9433
		private static readonly IntPtr NativeFieldInfoPtr_cookieID;

		// Token: 0x040024DA RID: 9434
		private static readonly IntPtr NativeFieldInfoPtr_cookieScale;

		// Token: 0x040024DB RID: 9435
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x040024DC RID: 9436
		private static readonly IntPtr NativeFieldInfoPtr_indirectColor;

		// Token: 0x040024DD RID: 9437
		private static readonly IntPtr NativeFieldInfoPtr_orientation;

		// Token: 0x040024DE RID: 9438
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x040024DF RID: 9439
		private static readonly IntPtr NativeFieldInfoPtr_range;

		// Token: 0x040024E0 RID: 9440
		private static readonly IntPtr NativeFieldInfoPtr_coneAngle;

		// Token: 0x040024E1 RID: 9441
		private static readonly IntPtr NativeFieldInfoPtr_innerConeAngle;

		// Token: 0x040024E2 RID: 9442
		private static readonly IntPtr NativeFieldInfoPtr_shape0;

		// Token: 0x040024E3 RID: 9443
		private static readonly IntPtr NativeFieldInfoPtr_shape1;

		// Token: 0x040024E4 RID: 9444
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x040024E5 RID: 9445
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x040024E6 RID: 9446
		private static readonly IntPtr NativeFieldInfoPtr_shadow;

		// Token: 0x040024E7 RID: 9447
		private static readonly IntPtr NativeFieldInfoPtr_falloff;

		// Token: 0x040024E8 RID: 9448
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_byref_DirectionalLight_byref_Cookie_0;

		// Token: 0x040024E9 RID: 9449
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_byref_PointLight_byref_Cookie_0;

		// Token: 0x040024EA RID: 9450
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_byref_SpotLight_byref_Cookie_0;

		// Token: 0x040024EB RID: 9451
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_byref_RectangleLight_byref_Cookie_0;

		// Token: 0x040024EC RID: 9452
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_byref_DiscLight_byref_Cookie_0;

		// Token: 0x040024ED RID: 9453
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_byref_DirectionalLight_0;

		// Token: 0x040024EE RID: 9454
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_byref_PointLight_0;

		// Token: 0x040024EF RID: 9455
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_byref_SpotLight_0;

		// Token: 0x040024F0 RID: 9456
		private static readonly IntPtr NativeMethodInfoPtr_InitNoBake_Public_Void_Int32_0;

		// Token: 0x040024F1 RID: 9457
		[FieldOffset(0)]
		public int instanceID;

		// Token: 0x040024F2 RID: 9458
		[FieldOffset(4)]
		public int cookieID;

		// Token: 0x040024F3 RID: 9459
		[FieldOffset(8)]
		public float cookieScale;

		// Token: 0x040024F4 RID: 9460
		[FieldOffset(12)]
		public LinearColor color;

		// Token: 0x040024F5 RID: 9461
		[FieldOffset(28)]
		public LinearColor indirectColor;

		// Token: 0x040024F6 RID: 9462
		[FieldOffset(44)]
		public Quaternion orientation;

		// Token: 0x040024F7 RID: 9463
		[FieldOffset(60)]
		public Vector3 position;

		// Token: 0x040024F8 RID: 9464
		[FieldOffset(72)]
		public float range;

		// Token: 0x040024F9 RID: 9465
		[FieldOffset(76)]
		public float coneAngle;

		// Token: 0x040024FA RID: 9466
		[FieldOffset(80)]
		public float innerConeAngle;

		// Token: 0x040024FB RID: 9467
		[FieldOffset(84)]
		public float shape0;

		// Token: 0x040024FC RID: 9468
		[FieldOffset(88)]
		public float shape1;

		// Token: 0x040024FD RID: 9469
		[FieldOffset(92)]
		public LightType type;

		// Token: 0x040024FE RID: 9470
		[FieldOffset(93)]
		public LightMode mode;

		// Token: 0x040024FF RID: 9471
		[FieldOffset(94)]
		public byte shadow;

		// Token: 0x04002500 RID: 9472
		[FieldOffset(95)]
		public FalloffType falloff;
	}
}
