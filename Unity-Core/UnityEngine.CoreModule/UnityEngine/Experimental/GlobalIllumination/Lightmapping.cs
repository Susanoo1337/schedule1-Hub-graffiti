using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x02000272 RID: 626
	public static class Lightmapping : Object
	{
		// Token: 0x06002AF9 RID: 11001 RVA: 0x000A7C60 File Offset: 0x000A5E60
		// Note: this type is marked as 'beforefieldinit'.
		static Lightmapping()
		{
			Il2CppClassPointerStore<Lightmapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "Lightmapping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lightmapping>.NativeClassPtr);
			Lightmapping.NativeFieldInfoPtr_s_DefaultDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lightmapping>.NativeClassPtr, "s_DefaultDelegate");
			Lightmapping.NativeFieldInfoPtr_s_RequestLightsDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lightmapping>.NativeClassPtr, "s_RequestLightsDelegate");
			Lightmapping.NativeMethodInfoPtr_SetDelegate_Public_Static_Void_RequestLightsDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lightmapping>.NativeClassPtr, 100667932);
			Lightmapping.NativeMethodInfoPtr_GetDelegate_Public_Static_RequestLightsDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lightmapping>.NativeClassPtr, 100667933);
			Lightmapping.NativeMethodInfoPtr_ResetDelegate_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lightmapping>.NativeClassPtr, 100667934);
			Lightmapping.NativeMethodInfoPtr_RequestLights_Internal_Static_Void_Il2CppReferenceArray_1_Light_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lightmapping>.NativeClassPtr, 100667935);
		}

		// Token: 0x06002AFA RID: 11002 RVA: 0x000A7D08 File Offset: 0x000A5F08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1294310, RefRangeEnd = 1294311, XrefRangeStart = 1294280, XrefRangeEnd = 1294310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetDelegate(Lightmapping.RequestLightsDelegate del)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(del);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lightmapping.NativeMethodInfoPtr_SetDelegate_Public_Static_Void_RequestLightsDelegate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AFB RID: 11003 RVA: 0x000A7D40 File Offset: 0x000A5F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294311, XrefRangeEnd = 1294315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Lightmapping.RequestLightsDelegate GetDelegate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lightmapping.NativeMethodInfoPtr_GetDelegate_Public_Static_RequestLightsDelegate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Lightmapping.RequestLightsDelegate>(intPtr3) : null;
		}

		// Token: 0x06002AFC RID: 11004 RVA: 0x000A7D74 File Offset: 0x000A5F74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1294321, RefRangeEnd = 1294322, XrefRangeStart = 1294315, XrefRangeEnd = 1294321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ResetDelegate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lightmapping.NativeMethodInfoPtr_ResetDelegate_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AFD RID: 11005 RVA: 0x000A7D9C File Offset: 0x000A5F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294322, XrefRangeEnd = 1294330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RequestLights(Il2CppReferenceArray<Light> lights, IntPtr outLightsPtr, int outLightsCount)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(lights);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref outLightsPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref outLightsCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lightmapping.NativeMethodInfoPtr_RequestLights_Internal_Static_Void_Il2CppReferenceArray_1_Light_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AFE RID: 11006 RVA: 0x00012EA7 File Offset: 0x000110A7
		public Lightmapping(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x06002AFF RID: 11007 RVA: 0x000A7DF0 File Offset: 0x000A5FF0
		// (set) Token: 0x06002B00 RID: 11008 RVA: 0x00012EB0 File Offset: 0x000110B0
		public unsafe static Lightmapping.RequestLightsDelegate s_DefaultDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Lightmapping.NativeFieldInfoPtr_s_DefaultDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lightmapping.RequestLightsDelegate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Lightmapping.NativeFieldInfoPtr_s_DefaultDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x06002B01 RID: 11009 RVA: 0x000A7E18 File Offset: 0x000A6018
		// (set) Token: 0x06002B02 RID: 11010 RVA: 0x00012EC2 File Offset: 0x000110C2
		public unsafe static Lightmapping.RequestLightsDelegate s_RequestLightsDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Lightmapping.NativeFieldInfoPtr_s_RequestLightsDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lightmapping.RequestLightsDelegate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Lightmapping.NativeFieldInfoPtr_s_RequestLightsDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400250C RID: 9484
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultDelegate;

		// Token: 0x0400250D RID: 9485
		private static readonly IntPtr NativeFieldInfoPtr_s_RequestLightsDelegate;

		// Token: 0x0400250E RID: 9486
		private static readonly IntPtr NativeMethodInfoPtr_SetDelegate_Public_Static_Void_RequestLightsDelegate_0;

		// Token: 0x0400250F RID: 9487
		private static readonly IntPtr NativeMethodInfoPtr_GetDelegate_Public_Static_RequestLightsDelegate_0;

		// Token: 0x04002510 RID: 9488
		private static readonly IntPtr NativeMethodInfoPtr_ResetDelegate_Public_Static_Void_0;

		// Token: 0x04002511 RID: 9489
		private static readonly IntPtr NativeMethodInfoPtr_RequestLights_Internal_Static_Void_Il2CppReferenceArray_1_Light_IntPtr_Int32_0;

		// Token: 0x02000BE8 RID: 3048
		public sealed class RequestLightsDelegate : MulticastDelegate
		{
			// Token: 0x06004094 RID: 16532 RVA: 0x0001875E File Offset: 0x0001695E
			// Note: this type is marked as 'beforefieldinit'.
			static RequestLightsDelegate()
			{
				Il2CppClassPointerStore<Lightmapping.RequestLightsDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Lightmapping>.NativeClassPtr, "RequestLightsDelegate");
				Lightmapping.RequestLightsDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lightmapping.RequestLightsDelegate>.NativeClassPtr, 100667937);
				Lightmapping.RequestLightsDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Il2CppReferenceArray_1_Light_NativeArray_1_LightDataGI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lightmapping.RequestLightsDelegate>.NativeClassPtr, 100667938);
			}

			// Token: 0x06004095 RID: 16533 RVA: 0x000B5F10 File Offset: 0x000B4110
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294258, XrefRangeEnd = 1294262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RequestLightsDelegate(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lightmapping.RequestLightsDelegate>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lightmapping.RequestLightsDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004096 RID: 16534 RVA: 0x000B5F6C File Offset: 0x000B416C
			[CallerCount(0)]
			public unsafe void Invoke(Il2CppReferenceArray<Light> requests, Unity.Collections.NativeArray<LightDataGI> lightsOutput)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requests);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lightsOutput));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lightmapping.RequestLightsDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Il2CppReferenceArray_1_Light_NativeArray_1_LightDataGI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004097 RID: 16535 RVA: 0x0001879C File Offset: 0x0001699C
			public RequestLightsDelegate(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06004098 RID: 16536 RVA: 0x000187A5 File Offset: 0x000169A5
			public static implicit operator Lightmapping.RequestLightsDelegate(Action<Il2CppReferenceArray<Light>, Unity.Collections.NativeArray<LightDataGI>> A_0)
			{
				return DelegateSupport.ConvertDelegate<Lightmapping.RequestLightsDelegate>(A_0);
			}

			// Token: 0x06004099 RID: 16537 RVA: 0x000187AD File Offset: 0x000169AD
			public static Lightmapping.RequestLightsDelegate operator +(Lightmapping.RequestLightsDelegate A_0, Lightmapping.RequestLightsDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Lightmapping.RequestLightsDelegate>();
			}

			// Token: 0x0600409A RID: 16538 RVA: 0x000187BB File Offset: 0x000169BB
			public static Lightmapping.RequestLightsDelegate operator -(Lightmapping.RequestLightsDelegate A_0, Lightmapping.RequestLightsDelegate A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<Lightmapping.RequestLightsDelegate>();
				}
				return result;
			}

			// Token: 0x04002C20 RID: 11296
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002C21 RID: 11297
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Il2CppReferenceArray_1_Light_NativeArray_1_LightDataGI_0;
		}

		// Token: 0x02000BE9 RID: 3049
		[ObfuscatedName("UnityEngine.Experimental.GlobalIllumination.Lightmapping+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600409B RID: 16539 RVA: 0x000B5FC8 File Offset: 0x000B41C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Lightmapping.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Lightmapping>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lightmapping.__c>.NativeClassPtr);
				Lightmapping.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lightmapping.__c>.NativeClassPtr, "<>9");
				Lightmapping.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lightmapping.__c>.NativeClassPtr, 100667940);
				Lightmapping.__c.NativeMethodInfoPtr___cctor_b__7_0_Internal_Void_Il2CppReferenceArray_1_Light_NativeArray_1_LightDataGI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lightmapping.__c>.NativeClassPtr, 100667941);
			}

			// Token: 0x0600409C RID: 16540 RVA: 0x000B6030 File Offset: 0x000B4230
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lightmapping.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lightmapping.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600409D RID: 16541 RVA: 0x000B606C File Offset: 0x000B426C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294262, XrefRangeEnd = 1294280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__7_0(Il2CppReferenceArray<Light> requests, Unity.Collections.NativeArray<LightDataGI> lightsOutput)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requests);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lightsOutput));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lightmapping.__c.NativeMethodInfoPtr___cctor_b__7_0_Internal_Void_Il2CppReferenceArray_1_Light_NativeArray_1_LightDataGI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600409E RID: 16542 RVA: 0x000187CC File Offset: 0x000169CC
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17000A37 RID: 2615
			// (get) Token: 0x0600409F RID: 16543 RVA: 0x000B60C8 File Offset: 0x000B42C8
			// (set) Token: 0x060040A0 RID: 16544 RVA: 0x000187D5 File Offset: 0x000169D5
			public unsafe static Lightmapping.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Lightmapping.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lightmapping.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Lightmapping.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002C22 RID: 11298
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002C23 RID: 11299
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002C24 RID: 11300
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__7_0_Internal_Void_Il2CppReferenceArray_1_Light_NativeArray_1_LightDataGI_0;
		}

		// Token: 0x02000BEA RID: 3050
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
