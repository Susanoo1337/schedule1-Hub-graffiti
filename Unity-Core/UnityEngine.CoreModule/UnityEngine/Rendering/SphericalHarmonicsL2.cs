using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000209 RID: 521
	[StructLayout(2)]
	public struct SphericalHarmonicsL2
	{
		// Token: 0x060023F5 RID: 9205 RVA: 0x000907A8 File Offset: 0x0008E9A8
		// Note: this type is marked as 'beforefieldinit'.
		static SphericalHarmonicsL2()
		{
			Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "SphericalHarmonicsL2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr);
			SphericalHarmonicsL2.NativeFieldInfoPtr_shr0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shr0");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shr1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shr1");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shr2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shr2");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shr3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shr3");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shr4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shr4");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shr5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shr5");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shr6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shr6");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shr7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shr7");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shr8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shr8");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shg0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shg0");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shg1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shg1");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shg2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shg2");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shg3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shg3");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shg4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shg4");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shg5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shg5");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shg6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shg6");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shg7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shg7");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shg8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shg8");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shb0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shb0");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shb1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shb1");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shb2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shb2");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shb3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shb3");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shb4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shb4");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shb5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shb5");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shb6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shb6");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shb7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shb7");
			SphericalHarmonicsL2.NativeFieldInfoPtr_shb8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shb8");
			SphericalHarmonicsL2.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, 100667188);
			SphericalHarmonicsL2.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, 100667189);
			SphericalHarmonicsL2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, 100667190);
			SphericalHarmonicsL2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, 100667191);
			SphericalHarmonicsL2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SphericalHarmonicsL2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, 100667192);
			SphericalHarmonicsL2.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SphericalHarmonicsL2_SphericalHarmonicsL2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, 100667193);
			SphericalHarmonicsL2.EvaluateInternalDelegateField = IL2CPP.ResolveICall<SphericalHarmonicsL2.EvaluateInternalDelegate>("UnityEngine.Rendering.SphericalHarmonicsL2::EvaluateInternal");
			SphericalHarmonicsL2.SetZero_InjectedDelegateField = IL2CPP.ResolveICall<SphericalHarmonicsL2.SetZero_InjectedDelegate>("UnityEngine.Rendering.SphericalHarmonicsL2::SetZero_Injected");
			SphericalHarmonicsL2.AddAmbientLight_InjectedDelegateField = IL2CPP.ResolveICall<SphericalHarmonicsL2.AddAmbientLight_InjectedDelegate>("UnityEngine.Rendering.SphericalHarmonicsL2::AddAmbientLight_Injected");
			SphericalHarmonicsL2.AddDirectionalLightInternal_InjectedDelegateField = IL2CPP.ResolveICall<SphericalHarmonicsL2.AddDirectionalLightInternal_InjectedDelegate>("UnityEngine.Rendering.SphericalHarmonicsL2::AddDirectionalLightInternal_Injected");
		}

		// Token: 0x17000721 RID: 1825
		public unsafe float this[int rgb, int coefficient]
		{
			[CallerCount(72)]
			[CachedScanResults(RefRangeStart = 1289890, RefRangeEnd = 1289962, XrefRangeStart = 1289890, XrefRangeEnd = 1289890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref rgb;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref coefficient;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphericalHarmonicsL2.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 1289962, RefRangeEnd = 1289986, XrefRangeStart = 1289962, XrefRangeEnd = 1289962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref rgb;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref coefficient;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphericalHarmonicsL2.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int32_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060023F8 RID: 9208 RVA: 0x00090B44 File Offset: 0x0008ED44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1289986, XrefRangeEnd = 1290013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphericalHarmonicsL2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023F9 RID: 9209 RVA: 0x00090B74 File Offset: 0x0008ED74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290013, XrefRangeEnd = 1290017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphericalHarmonicsL2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023FA RID: 9210 RVA: 0x00090BB8 File Offset: 0x0008EDB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290017, XrefRangeEnd = 1290018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(SphericalHarmonicsL2 other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphericalHarmonicsL2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SphericalHarmonicsL2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023FB RID: 9211 RVA: 0x00090BF8 File Offset: 0x0008EDF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1290018, RefRangeEnd = 1290020, XrefRangeStart = 1290018, XrefRangeEnd = 1290018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(SphericalHarmonicsL2 lhs, SphericalHarmonicsL2 rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphericalHarmonicsL2.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SphericalHarmonicsL2_SphericalHarmonicsL2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023FC RID: 9212 RVA: 0x000109E0 File Offset: 0x0000EBE0
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, ref this));
		}

		// Token: 0x060023FD RID: 9213 RVA: 0x000109F2 File Offset: 0x0000EBF2
		public void Clear()
		{
			this.SetZero();
		}

		// Token: 0x060023FE RID: 9214 RVA: 0x000109FC File Offset: 0x0000EBFC
		public void SetZero()
		{
			SphericalHarmonicsL2.SetZero_Injected(ref this);
		}

		// Token: 0x060023FF RID: 9215 RVA: 0x00010A04 File Offset: 0x0000EC04
		public void AddAmbientLight(Color color)
		{
			SphericalHarmonicsL2.AddAmbientLight_Injected(ref this, ref color);
		}

		// Token: 0x06002400 RID: 9216 RVA: 0x00090C44 File Offset: 0x0008EE44
		public void AddDirectionalLight(Vector3 direction, Color color, float intensity)
		{
			Color color2 = color * (2f * intensity);
			SphericalHarmonicsL2.AddDirectionalLightInternal(ref this, direction, color2);
		}

		// Token: 0x06002401 RID: 9217 RVA: 0x00010A0E File Offset: 0x0000EC0E
		public static void AddDirectionalLightInternal(ref SphericalHarmonicsL2 sh, Vector3 direction, Color color)
		{
			SphericalHarmonicsL2.AddDirectionalLightInternal_Injected(ref sh, ref direction, ref color);
		}

		// Token: 0x06002402 RID: 9218 RVA: 0x00090C6C File Offset: 0x0008EE6C
		public void Evaluate(Il2CppStructArray<Vector3> directions, Il2CppStructArray<Color> results)
		{
			bool flag = directions == null;
			if (flag)
			{
				throw new ArgumentNullException("directions");
			}
			bool flag2 = results == null;
			if (flag2)
			{
				throw new ArgumentNullException("results");
			}
			bool flag3 = directions.Length == 0;
			if (!flag3)
			{
				bool flag4 = directions.Length != results.Length;
				if (flag4)
				{
					throw new ArgumentException("Length of the directions array and the results array must match.");
				}
				SphericalHarmonicsL2.EvaluateInternal(ref this, directions, results);
			}
		}

		// Token: 0x06002403 RID: 9219 RVA: 0x00010A1A File Offset: 0x0000EC1A
		public static void EvaluateInternal(ref SphericalHarmonicsL2 sh, Il2CppStructArray<Vector3> directions, [Out] Il2CppStructArray<Color> results)
		{
			SphericalHarmonicsL2.EvaluateInternalDelegateField(ref sh, IL2CPP.Il2CppObjectBaseToPtr(directions), IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x06002404 RID: 9220 RVA: 0x00090CDC File Offset: 0x0008EEDC
		public static SphericalHarmonicsL2 operator *(SphericalHarmonicsL2 lhs, float rhs)
		{
			return new SphericalHarmonicsL2
			{
				shr0 = lhs.shr0 * rhs,
				shr1 = lhs.shr1 * rhs,
				shr2 = lhs.shr2 * rhs,
				shr3 = lhs.shr3 * rhs,
				shr4 = lhs.shr4 * rhs,
				shr5 = lhs.shr5 * rhs,
				shr6 = lhs.shr6 * rhs,
				shr7 = lhs.shr7 * rhs,
				shr8 = lhs.shr8 * rhs,
				shg0 = lhs.shg0 * rhs,
				shg1 = lhs.shg1 * rhs,
				shg2 = lhs.shg2 * rhs,
				shg3 = lhs.shg3 * rhs,
				shg4 = lhs.shg4 * rhs,
				shg5 = lhs.shg5 * rhs,
				shg6 = lhs.shg6 * rhs,
				shg7 = lhs.shg7 * rhs,
				shg8 = lhs.shg8 * rhs,
				shb0 = lhs.shb0 * rhs,
				shb1 = lhs.shb1 * rhs,
				shb2 = lhs.shb2 * rhs,
				shb3 = lhs.shb3 * rhs,
				shb4 = lhs.shb4 * rhs,
				shb5 = lhs.shb5 * rhs,
				shb6 = lhs.shb6 * rhs,
				shb7 = lhs.shb7 * rhs,
				shb8 = lhs.shb8 * rhs
			};
		}

		// Token: 0x06002405 RID: 9221 RVA: 0x00090E8C File Offset: 0x0008F08C
		public static SphericalHarmonicsL2 operator *(float lhs, SphericalHarmonicsL2 rhs)
		{
			return new SphericalHarmonicsL2
			{
				shr0 = rhs.shr0 * lhs,
				shr1 = rhs.shr1 * lhs,
				shr2 = rhs.shr2 * lhs,
				shr3 = rhs.shr3 * lhs,
				shr4 = rhs.shr4 * lhs,
				shr5 = rhs.shr5 * lhs,
				shr6 = rhs.shr6 * lhs,
				shr7 = rhs.shr7 * lhs,
				shr8 = rhs.shr8 * lhs,
				shg0 = rhs.shg0 * lhs,
				shg1 = rhs.shg1 * lhs,
				shg2 = rhs.shg2 * lhs,
				shg3 = rhs.shg3 * lhs,
				shg4 = rhs.shg4 * lhs,
				shg5 = rhs.shg5 * lhs,
				shg6 = rhs.shg6 * lhs,
				shg7 = rhs.shg7 * lhs,
				shg8 = rhs.shg8 * lhs,
				shb0 = rhs.shb0 * lhs,
				shb1 = rhs.shb1 * lhs,
				shb2 = rhs.shb2 * lhs,
				shb3 = rhs.shb3 * lhs,
				shb4 = rhs.shb4 * lhs,
				shb5 = rhs.shb5 * lhs,
				shb6 = rhs.shb6 * lhs,
				shb7 = rhs.shb7 * lhs,
				shb8 = rhs.shb8 * lhs
			};
		}

		// Token: 0x06002406 RID: 9222 RVA: 0x0009103C File Offset: 0x0008F23C
		public static SphericalHarmonicsL2 operator +(SphericalHarmonicsL2 lhs, SphericalHarmonicsL2 rhs)
		{
			return new SphericalHarmonicsL2
			{
				shr0 = lhs.shr0 + rhs.shr0,
				shr1 = lhs.shr1 + rhs.shr1,
				shr2 = lhs.shr2 + rhs.shr2,
				shr3 = lhs.shr3 + rhs.shr3,
				shr4 = lhs.shr4 + rhs.shr4,
				shr5 = lhs.shr5 + rhs.shr5,
				shr6 = lhs.shr6 + rhs.shr6,
				shr7 = lhs.shr7 + rhs.shr7,
				shr8 = lhs.shr8 + rhs.shr8,
				shg0 = lhs.shg0 + rhs.shg0,
				shg1 = lhs.shg1 + rhs.shg1,
				shg2 = lhs.shg2 + rhs.shg2,
				shg3 = lhs.shg3 + rhs.shg3,
				shg4 = lhs.shg4 + rhs.shg4,
				shg5 = lhs.shg5 + rhs.shg5,
				shg6 = lhs.shg6 + rhs.shg6,
				shg7 = lhs.shg7 + rhs.shg7,
				shg8 = lhs.shg8 + rhs.shg8,
				shb0 = lhs.shb0 + rhs.shb0,
				shb1 = lhs.shb1 + rhs.shb1,
				shb2 = lhs.shb2 + rhs.shb2,
				shb3 = lhs.shb3 + rhs.shb3,
				shb4 = lhs.shb4 + rhs.shb4,
				shb5 = lhs.shb5 + rhs.shb5,
				shb6 = lhs.shb6 + rhs.shb6,
				shb7 = lhs.shb7 + rhs.shb7,
				shb8 = lhs.shb8 + rhs.shb8
			};
		}

		// Token: 0x06002407 RID: 9223 RVA: 0x00091274 File Offset: 0x0008F474
		public static bool operator !=(SphericalHarmonicsL2 lhs, SphericalHarmonicsL2 rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x06002408 RID: 9224 RVA: 0x00010A33 File Offset: 0x0000EC33
		public static void SetZero_Injected(ref SphericalHarmonicsL2 _unity_self)
		{
			SphericalHarmonicsL2.SetZero_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002409 RID: 9225 RVA: 0x00010A40 File Offset: 0x0000EC40
		public static void AddAmbientLight_Injected(ref SphericalHarmonicsL2 _unity_self, ref Color color)
		{
			SphericalHarmonicsL2.AddAmbientLight_InjectedDelegateField(ref _unity_self, ref color);
		}

		// Token: 0x0600240A RID: 9226 RVA: 0x00010A4E File Offset: 0x0000EC4E
		public static void AddDirectionalLightInternal_Injected(ref SphericalHarmonicsL2 sh, ref Vector3 direction, ref Color color)
		{
			SphericalHarmonicsL2.AddDirectionalLightInternal_InjectedDelegateField(ref sh, ref direction, ref color);
		}

		// Token: 0x04001DCC RID: 7628
		private static readonly IntPtr NativeFieldInfoPtr_shr0;

		// Token: 0x04001DCD RID: 7629
		private static readonly IntPtr NativeFieldInfoPtr_shr1;

		// Token: 0x04001DCE RID: 7630
		private static readonly IntPtr NativeFieldInfoPtr_shr2;

		// Token: 0x04001DCF RID: 7631
		private static readonly IntPtr NativeFieldInfoPtr_shr3;

		// Token: 0x04001DD0 RID: 7632
		private static readonly IntPtr NativeFieldInfoPtr_shr4;

		// Token: 0x04001DD1 RID: 7633
		private static readonly IntPtr NativeFieldInfoPtr_shr5;

		// Token: 0x04001DD2 RID: 7634
		private static readonly IntPtr NativeFieldInfoPtr_shr6;

		// Token: 0x04001DD3 RID: 7635
		private static readonly IntPtr NativeFieldInfoPtr_shr7;

		// Token: 0x04001DD4 RID: 7636
		private static readonly IntPtr NativeFieldInfoPtr_shr8;

		// Token: 0x04001DD5 RID: 7637
		private static readonly IntPtr NativeFieldInfoPtr_shg0;

		// Token: 0x04001DD6 RID: 7638
		private static readonly IntPtr NativeFieldInfoPtr_shg1;

		// Token: 0x04001DD7 RID: 7639
		private static readonly IntPtr NativeFieldInfoPtr_shg2;

		// Token: 0x04001DD8 RID: 7640
		private static readonly IntPtr NativeFieldInfoPtr_shg3;

		// Token: 0x04001DD9 RID: 7641
		private static readonly IntPtr NativeFieldInfoPtr_shg4;

		// Token: 0x04001DDA RID: 7642
		private static readonly IntPtr NativeFieldInfoPtr_shg5;

		// Token: 0x04001DDB RID: 7643
		private static readonly IntPtr NativeFieldInfoPtr_shg6;

		// Token: 0x04001DDC RID: 7644
		private static readonly IntPtr NativeFieldInfoPtr_shg7;

		// Token: 0x04001DDD RID: 7645
		private static readonly IntPtr NativeFieldInfoPtr_shg8;

		// Token: 0x04001DDE RID: 7646
		private static readonly IntPtr NativeFieldInfoPtr_shb0;

		// Token: 0x04001DDF RID: 7647
		private static readonly IntPtr NativeFieldInfoPtr_shb1;

		// Token: 0x04001DE0 RID: 7648
		private static readonly IntPtr NativeFieldInfoPtr_shb2;

		// Token: 0x04001DE1 RID: 7649
		private static readonly IntPtr NativeFieldInfoPtr_shb3;

		// Token: 0x04001DE2 RID: 7650
		private static readonly IntPtr NativeFieldInfoPtr_shb4;

		// Token: 0x04001DE3 RID: 7651
		private static readonly IntPtr NativeFieldInfoPtr_shb5;

		// Token: 0x04001DE4 RID: 7652
		private static readonly IntPtr NativeFieldInfoPtr_shb6;

		// Token: 0x04001DE5 RID: 7653
		private static readonly IntPtr NativeFieldInfoPtr_shb7;

		// Token: 0x04001DE6 RID: 7654
		private static readonly IntPtr NativeFieldInfoPtr_shb8;

		// Token: 0x04001DE7 RID: 7655
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_Int32_0;

		// Token: 0x04001DE8 RID: 7656
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int32_Single_0;

		// Token: 0x04001DE9 RID: 7657
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001DEA RID: 7658
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001DEB RID: 7659
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SphericalHarmonicsL2_0;

		// Token: 0x04001DEC RID: 7660
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SphericalHarmonicsL2_SphericalHarmonicsL2_0;

		// Token: 0x04001DED RID: 7661
		[FieldOffset(0)]
		public float shr0;

		// Token: 0x04001DEE RID: 7662
		[FieldOffset(4)]
		public float shr1;

		// Token: 0x04001DEF RID: 7663
		[FieldOffset(8)]
		public float shr2;

		// Token: 0x04001DF0 RID: 7664
		[FieldOffset(12)]
		public float shr3;

		// Token: 0x04001DF1 RID: 7665
		[FieldOffset(16)]
		public float shr4;

		// Token: 0x04001DF2 RID: 7666
		[FieldOffset(20)]
		public float shr5;

		// Token: 0x04001DF3 RID: 7667
		[FieldOffset(24)]
		public float shr6;

		// Token: 0x04001DF4 RID: 7668
		[FieldOffset(28)]
		public float shr7;

		// Token: 0x04001DF5 RID: 7669
		[FieldOffset(32)]
		public float shr8;

		// Token: 0x04001DF6 RID: 7670
		[FieldOffset(36)]
		public float shg0;

		// Token: 0x04001DF7 RID: 7671
		[FieldOffset(40)]
		public float shg1;

		// Token: 0x04001DF8 RID: 7672
		[FieldOffset(44)]
		public float shg2;

		// Token: 0x04001DF9 RID: 7673
		[FieldOffset(48)]
		public float shg3;

		// Token: 0x04001DFA RID: 7674
		[FieldOffset(52)]
		public float shg4;

		// Token: 0x04001DFB RID: 7675
		[FieldOffset(56)]
		public float shg5;

		// Token: 0x04001DFC RID: 7676
		[FieldOffset(60)]
		public float shg6;

		// Token: 0x04001DFD RID: 7677
		[FieldOffset(64)]
		public float shg7;

		// Token: 0x04001DFE RID: 7678
		[FieldOffset(68)]
		public float shg8;

		// Token: 0x04001DFF RID: 7679
		[FieldOffset(72)]
		public float shb0;

		// Token: 0x04001E00 RID: 7680
		[FieldOffset(76)]
		public float shb1;

		// Token: 0x04001E01 RID: 7681
		[FieldOffset(80)]
		public float shb2;

		// Token: 0x04001E02 RID: 7682
		[FieldOffset(84)]
		public float shb3;

		// Token: 0x04001E03 RID: 7683
		[FieldOffset(88)]
		public float shb4;

		// Token: 0x04001E04 RID: 7684
		[FieldOffset(92)]
		public float shb5;

		// Token: 0x04001E05 RID: 7685
		[FieldOffset(96)]
		public float shb6;

		// Token: 0x04001E06 RID: 7686
		[FieldOffset(100)]
		public float shb7;

		// Token: 0x04001E07 RID: 7687
		[FieldOffset(104)]
		public float shb8;

		// Token: 0x04001E08 RID: 7688
		private static readonly SphericalHarmonicsL2.EvaluateInternalDelegate EvaluateInternalDelegateField;

		// Token: 0x04001E09 RID: 7689
		private static readonly SphericalHarmonicsL2.SetZero_InjectedDelegate SetZero_InjectedDelegateField;

		// Token: 0x04001E0A RID: 7690
		private static readonly SphericalHarmonicsL2.AddAmbientLight_InjectedDelegate AddAmbientLight_InjectedDelegateField;

		// Token: 0x04001E0B RID: 7691
		private static readonly SphericalHarmonicsL2.AddDirectionalLightInternal_InjectedDelegate AddDirectionalLightInternal_InjectedDelegateField;

		// Token: 0x02000B44 RID: 2884
		// (Invoke) Token: 0x06003F6E RID: 16238
		private delegate void EvaluateInternalDelegate(IntPtr sh, IntPtr directions, [Out] IntPtr results);

		// Token: 0x02000B45 RID: 2885
		// (Invoke) Token: 0x06003F70 RID: 16240
		private delegate void SetZero_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000B46 RID: 2886
		// (Invoke) Token: 0x06003F72 RID: 16242
		private delegate void AddAmbientLight_InjectedDelegate(IntPtr _unity_self, IntPtr color);

		// Token: 0x02000B47 RID: 2887
		// (Invoke) Token: 0x06003F74 RID: 16244
		private delegate void AddDirectionalLightInternal_InjectedDelegate(IntPtr sh, IntPtr direction, IntPtr color);
	}
}
