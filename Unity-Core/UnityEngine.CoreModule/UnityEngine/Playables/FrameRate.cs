using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Playables
{
	// Token: 0x0200024C RID: 588
	[StructLayout(2)]
	public struct FrameRate
	{
		// Token: 0x060028F7 RID: 10487 RVA: 0x0009FED8 File Offset: 0x0009E0D8
		// Note: this type is marked as 'beforefieldinit'.
		static FrameRate()
		{
			Il2CppClassPointerStore<FrameRate>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "FrameRate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrameRate>.NativeClassPtr);
			FrameRate.NativeFieldInfoPtr_k_24Fps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, "k_24Fps");
			FrameRate.NativeFieldInfoPtr_k_23_976Fps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, "k_23_976Fps");
			FrameRate.NativeFieldInfoPtr_k_25Fps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, "k_25Fps");
			FrameRate.NativeFieldInfoPtr_k_30Fps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, "k_30Fps");
			FrameRate.NativeFieldInfoPtr_k_29_97Fps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, "k_29_97Fps");
			FrameRate.NativeFieldInfoPtr_k_50Fps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, "k_50Fps");
			FrameRate.NativeFieldInfoPtr_k_60Fps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, "k_60Fps");
			FrameRate.NativeFieldInfoPtr_k_59_94Fps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, "k_59_94Fps");
			FrameRate.NativeFieldInfoPtr_m_Rate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, "m_Rate");
			FrameRate.NativeMethodInfoPtr_get_dropFrame_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, 100667662);
			FrameRate.NativeMethodInfoPtr_get_rate_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, 100667663);
			FrameRate.NativeMethodInfoPtr__ctor_Public_Void_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, 100667664);
			FrameRate.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, 100667665);
			FrameRate.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FrameRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, 100667666);
			FrameRate.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, 100667667);
			FrameRate.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FrameRate_FrameRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, 100667668);
			FrameRate.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, 100667669);
			FrameRate.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, 100667670);
			FrameRate.NativeMethodInfoPtr_ToString_Public_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, 100667671);
			FrameRate.NativeMethodInfoPtr_DoubleToFrameRate_Internal_Static_FrameRate_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, 100667672);
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x060028F8 RID: 10488 RVA: 0x000A0098 File Offset: 0x0009E298
		public unsafe bool dropFrame
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 537070, RefRangeEnd = 537071, XrefRangeStart = 537070, XrefRangeEnd = 537071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameRate.NativeMethodInfoPtr_get_dropFrame_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x060028F9 RID: 10489 RVA: 0x000A00C8 File Offset: 0x0009E2C8
		public unsafe double rate
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1292583, RefRangeEnd = 1292585, XrefRangeStart = 1292580, XrefRangeEnd = 1292583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameRate.NativeMethodInfoPtr_get_rate_Public_get_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060028FA RID: 10490 RVA: 0x000A00F8 File Offset: 0x0009E2F8
		[CallerCount(0)]
		public unsafe FrameRate(uint frameRate = 0U, bool drop = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref frameRate;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref drop;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameRate.NativeMethodInfoPtr__ctor_Public_Void_UInt32_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028FB RID: 10491 RVA: 0x000A0138 File Offset: 0x0009E338
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1292585, RefRangeEnd = 1292586, XrefRangeStart = 1292585, XrefRangeEnd = 1292585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValid()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameRate.NativeMethodInfoPtr_IsValid_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028FC RID: 10492 RVA: 0x000A0168 File Offset: 0x0009E368
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1246103, RefRangeEnd = 1246104, XrefRangeStart = 1246103, XrefRangeEnd = 1246104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(FrameRate other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameRate.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FrameRate_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028FD RID: 10493 RVA: 0x000A01A8 File Offset: 0x0009E3A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292586, XrefRangeEnd = 1292591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameRate.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028FE RID: 10494 RVA: 0x000A01EC File Offset: 0x0009E3EC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1292594, RefRangeEnd = 1292602, XrefRangeStart = 1292591, XrefRangeEnd = 1292594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(FrameRate a, FrameRate b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameRate.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FrameRate_FrameRate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028FF RID: 10495 RVA: 0x000A0238 File Offset: 0x0009E438
		[CallerCount(261)]
		[CachedScanResults(RefRangeStart = 1218881, RefRangeEnd = 1219142, XrefRangeStart = 1218881, XrefRangeEnd = 1219142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameRate.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002900 RID: 10496 RVA: 0x000A0268 File Offset: 0x0009E468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292602, XrefRangeEnd = 1292615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameRate.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002901 RID: 10497 RVA: 0x000A0294 File Offset: 0x0009E494
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1292642, RefRangeEnd = 1292643, XrefRangeStart = 1292615, XrefRangeEnd = 1292642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider formatProvider)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameRate.NativeMethodInfoPtr_ToString_Public_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002902 RID: 10498 RVA: 0x000A02E4 File Offset: 0x0009E4E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1292657, RefRangeEnd = 1292658, XrefRangeStart = 1292643, XrefRangeEnd = 1292657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FrameRate DoubleToFrameRate(double framerate)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref framerate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameRate.NativeMethodInfoPtr_DoubleToFrameRate_Internal_Static_FrameRate_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002903 RID: 10499 RVA: 0x0001261D File Offset: 0x0001081D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, ref this));
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x06002904 RID: 10500 RVA: 0x000A0324 File Offset: 0x0009E524
		// (set) Token: 0x06002905 RID: 10501 RVA: 0x0001262F File Offset: 0x0001082F
		public unsafe static FrameRate k_24Fps
		{
			get
			{
				FrameRate result;
				IL2CPP.il2cpp_field_static_get_value(FrameRate.NativeFieldInfoPtr_k_24Fps, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FrameRate.NativeFieldInfoPtr_k_24Fps, (void*)(&value));
			}
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x06002906 RID: 10502 RVA: 0x000A0340 File Offset: 0x0009E540
		// (set) Token: 0x06002907 RID: 10503 RVA: 0x0001263D File Offset: 0x0001083D
		public unsafe static FrameRate k_23_976Fps
		{
			get
			{
				FrameRate result;
				IL2CPP.il2cpp_field_static_get_value(FrameRate.NativeFieldInfoPtr_k_23_976Fps, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FrameRate.NativeFieldInfoPtr_k_23_976Fps, (void*)(&value));
			}
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x06002908 RID: 10504 RVA: 0x000A035C File Offset: 0x0009E55C
		// (set) Token: 0x06002909 RID: 10505 RVA: 0x0001264B File Offset: 0x0001084B
		public unsafe static FrameRate k_25Fps
		{
			get
			{
				FrameRate result;
				IL2CPP.il2cpp_field_static_get_value(FrameRate.NativeFieldInfoPtr_k_25Fps, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FrameRate.NativeFieldInfoPtr_k_25Fps, (void*)(&value));
			}
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x0600290A RID: 10506 RVA: 0x000A0378 File Offset: 0x0009E578
		// (set) Token: 0x0600290B RID: 10507 RVA: 0x00012659 File Offset: 0x00010859
		public unsafe static FrameRate k_30Fps
		{
			get
			{
				FrameRate result;
				IL2CPP.il2cpp_field_static_get_value(FrameRate.NativeFieldInfoPtr_k_30Fps, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FrameRate.NativeFieldInfoPtr_k_30Fps, (void*)(&value));
			}
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x0600290C RID: 10508 RVA: 0x000A0394 File Offset: 0x0009E594
		// (set) Token: 0x0600290D RID: 10509 RVA: 0x00012667 File Offset: 0x00010867
		public unsafe static FrameRate k_29_97Fps
		{
			get
			{
				FrameRate result;
				IL2CPP.il2cpp_field_static_get_value(FrameRate.NativeFieldInfoPtr_k_29_97Fps, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FrameRate.NativeFieldInfoPtr_k_29_97Fps, (void*)(&value));
			}
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x0600290E RID: 10510 RVA: 0x000A03B0 File Offset: 0x0009E5B0
		// (set) Token: 0x0600290F RID: 10511 RVA: 0x00012675 File Offset: 0x00010875
		public unsafe static FrameRate k_50Fps
		{
			get
			{
				FrameRate result;
				IL2CPP.il2cpp_field_static_get_value(FrameRate.NativeFieldInfoPtr_k_50Fps, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FrameRate.NativeFieldInfoPtr_k_50Fps, (void*)(&value));
			}
		}

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x06002910 RID: 10512 RVA: 0x000A03CC File Offset: 0x0009E5CC
		// (set) Token: 0x06002911 RID: 10513 RVA: 0x00012683 File Offset: 0x00010883
		public unsafe static FrameRate k_60Fps
		{
			get
			{
				FrameRate result;
				IL2CPP.il2cpp_field_static_get_value(FrameRate.NativeFieldInfoPtr_k_60Fps, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FrameRate.NativeFieldInfoPtr_k_60Fps, (void*)(&value));
			}
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x06002912 RID: 10514 RVA: 0x000A03E8 File Offset: 0x0009E5E8
		// (set) Token: 0x06002913 RID: 10515 RVA: 0x00012691 File Offset: 0x00010891
		public unsafe static FrameRate k_59_94Fps
		{
			get
			{
				FrameRate result;
				IL2CPP.il2cpp_field_static_get_value(FrameRate.NativeFieldInfoPtr_k_59_94Fps, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FrameRate.NativeFieldInfoPtr_k_59_94Fps, (void*)(&value));
			}
		}

		// Token: 0x06002914 RID: 10516 RVA: 0x0001269F File Offset: 0x0001089F
		public static bool operator !=(FrameRate a, FrameRate b)
		{
			return !a.Equals(b);
		}

		// Token: 0x06002915 RID: 10517 RVA: 0x000126AC File Offset: 0x000108AC
		public static bool operator <(FrameRate a, FrameRate b)
		{
			return a.rate < b.rate;
		}

		// Token: 0x06002916 RID: 10518 RVA: 0x000126BE File Offset: 0x000108BE
		public static bool operator <=(FrameRate a, FrameRate b)
		{
			return a.rate <= b.rate;
		}

		// Token: 0x06002917 RID: 10519 RVA: 0x000126D3 File Offset: 0x000108D3
		public static bool operator >(FrameRate a, FrameRate b)
		{
			return a.rate > b.rate;
		}

		// Token: 0x06002918 RID: 10520 RVA: 0x000126E5 File Offset: 0x000108E5
		public static bool operator >=(FrameRate a, FrameRate b)
		{
			return a.rate <= b.rate;
		}

		// Token: 0x06002919 RID: 10521 RVA: 0x000A0404 File Offset: 0x0009E604
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x0600291A RID: 10522 RVA: 0x000A0420 File Offset: 0x0009E620
		public static int FrameRateToInt(FrameRate framerate)
		{
			return framerate.m_Rate;
		}

		// Token: 0x040022DE RID: 8926
		private static readonly IntPtr NativeFieldInfoPtr_k_24Fps;

		// Token: 0x040022DF RID: 8927
		private static readonly IntPtr NativeFieldInfoPtr_k_23_976Fps;

		// Token: 0x040022E0 RID: 8928
		private static readonly IntPtr NativeFieldInfoPtr_k_25Fps;

		// Token: 0x040022E1 RID: 8929
		private static readonly IntPtr NativeFieldInfoPtr_k_30Fps;

		// Token: 0x040022E2 RID: 8930
		private static readonly IntPtr NativeFieldInfoPtr_k_29_97Fps;

		// Token: 0x040022E3 RID: 8931
		private static readonly IntPtr NativeFieldInfoPtr_k_50Fps;

		// Token: 0x040022E4 RID: 8932
		private static readonly IntPtr NativeFieldInfoPtr_k_60Fps;

		// Token: 0x040022E5 RID: 8933
		private static readonly IntPtr NativeFieldInfoPtr_k_59_94Fps;

		// Token: 0x040022E6 RID: 8934
		private static readonly IntPtr NativeFieldInfoPtr_m_Rate;

		// Token: 0x040022E7 RID: 8935
		private static readonly IntPtr NativeMethodInfoPtr_get_dropFrame_Public_get_Boolean_0;

		// Token: 0x040022E8 RID: 8936
		private static readonly IntPtr NativeMethodInfoPtr_get_rate_Public_get_Double_0;

		// Token: 0x040022E9 RID: 8937
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_Boolean_0;

		// Token: 0x040022EA RID: 8938
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;

		// Token: 0x040022EB RID: 8939
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FrameRate_0;

		// Token: 0x040022EC RID: 8940
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040022ED RID: 8941
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FrameRate_FrameRate_0;

		// Token: 0x040022EE RID: 8942
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040022EF RID: 8943
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040022F0 RID: 8944
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_String_IFormatProvider_0;

		// Token: 0x040022F1 RID: 8945
		private static readonly IntPtr NativeMethodInfoPtr_DoubleToFrameRate_Internal_Static_FrameRate_Double_0;

		// Token: 0x040022F2 RID: 8946
		[FieldOffset(0)]
		public int m_Rate;
	}
}
