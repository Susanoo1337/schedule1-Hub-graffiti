using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000117 RID: 279
	public static class Random : Object
	{
		// Token: 0x060016D3 RID: 5843 RVA: 0x00063658 File Offset: 0x00061858
		// Note: this type is marked as 'beforefieldinit'.
		static Random()
		{
			Il2CppClassPointerStore<Random>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Random");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Random>.NativeClassPtr);
			Random.NativeMethodInfoPtr_InitState_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100665693);
			Random.NativeMethodInfoPtr_get_state_Public_Static_get_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100665694);
			Random.NativeMethodInfoPtr_set_state_Public_Static_set_Void_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100665695);
			Random.NativeMethodInfoPtr_Range_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100665696);
			Random.NativeMethodInfoPtr_Range_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100665697);
			Random.NativeMethodInfoPtr_RandomRangeInt_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100665698);
			Random.NativeMethodInfoPtr_get_value_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100665699);
			Random.NativeMethodInfoPtr_get_insideUnitSphere_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100665700);
			Random.NativeMethodInfoPtr_GetRandomUnitCircle_Private_Static_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100665701);
			Random.NativeMethodInfoPtr_get_insideUnitCircle_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100665702);
			Random.NativeMethodInfoPtr_get_onUnitSphere_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100665703);
			Random.NativeMethodInfoPtr_get_rotation_Public_Static_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100665704);
			Random.NativeMethodInfoPtr_get_state_Injected_Private_Static_Void_byref_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100665705);
			Random.NativeMethodInfoPtr_set_state_Injected_Private_Static_Void_byref_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100665706);
			Random.NativeMethodInfoPtr_get_insideUnitSphere_Injected_Private_Static_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100665707);
			Random.NativeMethodInfoPtr_get_onUnitSphere_Injected_Private_Static_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100665708);
			Random.NativeMethodInfoPtr_get_rotation_Injected_Private_Static_Void_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100665709);
			Random.get_seedDelegateField = IL2CPP.ResolveICall<Random.get_seedDelegate>("UnityEngine.Random::get_seed");
			Random.set_seedDelegateField = IL2CPP.ResolveICall<Random.set_seedDelegate>("UnityEngine.Random::set_seed");
			Random.get_rotationUniform_InjectedDelegateField = IL2CPP.ResolveICall<Random.get_rotationUniform_InjectedDelegate>("UnityEngine.Random::get_rotationUniform_Injected");
		}

		// Token: 0x060016D4 RID: 5844 RVA: 0x0006380C File Offset: 0x00061A0C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1246112, RefRangeEnd = 1246125, XrefRangeStart = 1246110, XrefRangeEnd = 1246112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitState(int seed)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref seed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_InitState_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x060016D5 RID: 5845 RVA: 0x00063840 File Offset: 0x00061A40
		// (set) Token: 0x060016D6 RID: 5846 RVA: 0x00063870 File Offset: 0x00061A70
		public unsafe static Random.State state
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1246127, RefRangeEnd = 1246135, XrefRangeStart = 1246125, XrefRangeEnd = 1246127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_get_state_Public_Static_get_State_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 1246137, RefRangeEnd = 1246150, XrefRangeStart = 1246135, XrefRangeEnd = 1246137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_set_state_Public_Static_set_Void_State_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x000638A4 File Offset: 0x00061AA4
		[CallerCount(266)]
		[CachedScanResults(RefRangeStart = 1246152, RefRangeEnd = 1246418, XrefRangeStart = 1246150, XrefRangeEnd = 1246152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Range(float minInclusive, float maxInclusive)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minInclusive;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxInclusive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_Range_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x000638F0 File Offset: 0x00061AF0
		[CallerCount(217)]
		[CachedScanResults(RefRangeStart = 1246420, RefRangeEnd = 1246637, XrefRangeStart = 1246418, XrefRangeEnd = 1246420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Range(int minInclusive, int maxExclusive)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minInclusive;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxExclusive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_Range_Public_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060016D9 RID: 5849 RVA: 0x0006393C File Offset: 0x00061B3C
		[CallerCount(217)]
		[CachedScanResults(RefRangeStart = 1246420, RefRangeEnd = 1246637, XrefRangeStart = 1246420, XrefRangeEnd = 1246637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RandomRangeInt(int minInclusive, int maxExclusive)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minInclusive;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxExclusive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_RandomRangeInt_Private_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x060016DA RID: 5850 RVA: 0x00063988 File Offset: 0x00061B88
		public unsafe static float value
		{
			[CallerCount(46)]
			[CachedScanResults(RefRangeStart = 1246639, RefRangeEnd = 1246685, XrefRangeStart = 1246637, XrefRangeEnd = 1246639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_get_value_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x060016DB RID: 5851 RVA: 0x000639B8 File Offset: 0x00061BB8
		public unsafe static Vector3 insideUnitSphere
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 1246687, RefRangeEnd = 1246704, XrefRangeStart = 1246685, XrefRangeEnd = 1246687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_get_insideUnitSphere_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x000639E8 File Offset: 0x00061BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246704, XrefRangeEnd = 1246706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetRandomUnitCircle(out Vector2 output)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &output;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_GetRandomUnitCircle_Private_Static_Void_byref_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x060016DD RID: 5853 RVA: 0x00063A1C File Offset: 0x00061C1C
		public unsafe static Vector2 insideUnitCircle
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1246708, RefRangeEnd = 1246709, XrefRangeStart = 1246706, XrefRangeEnd = 1246708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_get_insideUnitCircle_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x060016DE RID: 5854 RVA: 0x00063A4C File Offset: 0x00061C4C
		public unsafe static Vector3 onUnitSphere
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1246711, RefRangeEnd = 1246715, XrefRangeStart = 1246709, XrefRangeEnd = 1246711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_get_onUnitSphere_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x060016DF RID: 5855 RVA: 0x00063A7C File Offset: 0x00061C7C
		public unsafe static Quaternion rotation
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 1246717, RefRangeEnd = 1246729, XrefRangeStart = 1246715, XrefRangeEnd = 1246717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_get_rotation_Public_Static_get_Quaternion_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060016E0 RID: 5856 RVA: 0x00063AAC File Offset: 0x00061CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246729, XrefRangeEnd = 1246731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_state_Injected(out Random.State ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_get_state_Injected_Private_Static_Void_byref_State_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016E1 RID: 5857 RVA: 0x00063AE0 File Offset: 0x00061CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246731, XrefRangeEnd = 1246733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void set_state_Injected(ref Random.State value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_set_state_Injected_Private_Static_Void_byref_State_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016E2 RID: 5858 RVA: 0x00063B14 File Offset: 0x00061D14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246733, XrefRangeEnd = 1246735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_insideUnitSphere_Injected(out Vector3 ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_get_insideUnitSphere_Injected_Private_Static_Void_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016E3 RID: 5859 RVA: 0x00063B48 File Offset: 0x00061D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246735, XrefRangeEnd = 1246737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_onUnitSphere_Injected(out Vector3 ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_get_onUnitSphere_Injected_Private_Static_Void_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016E4 RID: 5860 RVA: 0x00063B7C File Offset: 0x00061D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246737, XrefRangeEnd = 1246739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_rotation_Injected(out Quaternion ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_get_rotation_Injected_Private_Static_Void_byref_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016E5 RID: 5861 RVA: 0x0000B712 File Offset: 0x00009912
		public Random(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x060016E6 RID: 5862 RVA: 0x00063BB0 File Offset: 0x00061DB0
		public static Quaternion rotationUniform
		{
			get
			{
				Quaternion result;
				Random.get_rotationUniform_Injected(out result);
				return result;
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x060016E7 RID: 5863 RVA: 0x0000B71B File Offset: 0x0000991B
		// (set) Token: 0x060016E8 RID: 5864 RVA: 0x0000B727 File Offset: 0x00009927
		public static int seed
		{
			get
			{
				return Random.get_seedDelegateField();
			}
			set
			{
				Random.set_seedDelegateField(value);
			}
		}

		// Token: 0x060016E9 RID: 5865 RVA: 0x00063BC8 File Offset: 0x00061DC8
		public static float RandomRange(float min, float max)
		{
			return Random.Range(min, max);
		}

		// Token: 0x060016EA RID: 5866 RVA: 0x00063BE4 File Offset: 0x00061DE4
		public static int RandomRange(int min, int max)
		{
			return Random.Range(min, max);
		}

		// Token: 0x060016EB RID: 5867 RVA: 0x00063C00 File Offset: 0x00061E00
		public static Color ColorHSV()
		{
			return Random.ColorHSV(0f, 1f, 0f, 1f, 0f, 1f, 1f, 1f);
		}

		// Token: 0x060016EC RID: 5868 RVA: 0x00063C40 File Offset: 0x00061E40
		public static Color ColorHSV(float hueMin, float hueMax)
		{
			return Random.ColorHSV(hueMin, hueMax, 0f, 1f, 0f, 1f, 1f, 1f);
		}

		// Token: 0x060016ED RID: 5869 RVA: 0x00063C78 File Offset: 0x00061E78
		public static Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax)
		{
			return Random.ColorHSV(hueMin, hueMax, saturationMin, saturationMax, 0f, 1f, 1f, 1f);
		}

		// Token: 0x060016EE RID: 5870 RVA: 0x00063CA8 File Offset: 0x00061EA8
		public static Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax)
		{
			return Random.ColorHSV(hueMin, hueMax, saturationMin, saturationMax, valueMin, valueMax, 1f, 1f);
		}

		// Token: 0x060016EF RID: 5871 RVA: 0x00063CD4 File Offset: 0x00061ED4
		public static Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax, float alphaMin, float alphaMax)
		{
			float h = Mathf.Lerp(hueMin, hueMax, Random.value);
			float s = Mathf.Lerp(saturationMin, saturationMax, Random.value);
			float v = Mathf.Lerp(valueMin, valueMax, Random.value);
			Color result = Color.HSVToRGB(h, s, v, true);
			result.a = Mathf.Lerp(alphaMin, alphaMax, Random.value);
			return result;
		}

		// Token: 0x060016F0 RID: 5872 RVA: 0x0000B734 File Offset: 0x00009934
		public static void get_rotationUniform_Injected(out Quaternion ret)
		{
			Random.get_rotationUniform_InjectedDelegateField(out ret);
		}

		// Token: 0x04001381 RID: 4993
		private static readonly IntPtr NativeMethodInfoPtr_InitState_Public_Static_Void_Int32_0;

		// Token: 0x04001382 RID: 4994
		private static readonly IntPtr NativeMethodInfoPtr_get_state_Public_Static_get_State_0;

		// Token: 0x04001383 RID: 4995
		private static readonly IntPtr NativeMethodInfoPtr_set_state_Public_Static_set_Void_State_0;

		// Token: 0x04001384 RID: 4996
		private static readonly IntPtr NativeMethodInfoPtr_Range_Public_Static_Single_Single_Single_0;

		// Token: 0x04001385 RID: 4997
		private static readonly IntPtr NativeMethodInfoPtr_Range_Public_Static_Int32_Int32_Int32_0;

		// Token: 0x04001386 RID: 4998
		private static readonly IntPtr NativeMethodInfoPtr_RandomRangeInt_Private_Static_Int32_Int32_Int32_0;

		// Token: 0x04001387 RID: 4999
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Static_get_Single_0;

		// Token: 0x04001388 RID: 5000
		private static readonly IntPtr NativeMethodInfoPtr_get_insideUnitSphere_Public_Static_get_Vector3_0;

		// Token: 0x04001389 RID: 5001
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomUnitCircle_Private_Static_Void_byref_Vector2_0;

		// Token: 0x0400138A RID: 5002
		private static readonly IntPtr NativeMethodInfoPtr_get_insideUnitCircle_Public_Static_get_Vector2_0;

		// Token: 0x0400138B RID: 5003
		private static readonly IntPtr NativeMethodInfoPtr_get_onUnitSphere_Public_Static_get_Vector3_0;

		// Token: 0x0400138C RID: 5004
		private static readonly IntPtr NativeMethodInfoPtr_get_rotation_Public_Static_get_Quaternion_0;

		// Token: 0x0400138D RID: 5005
		private static readonly IntPtr NativeMethodInfoPtr_get_state_Injected_Private_Static_Void_byref_State_0;

		// Token: 0x0400138E RID: 5006
		private static readonly IntPtr NativeMethodInfoPtr_set_state_Injected_Private_Static_Void_byref_State_0;

		// Token: 0x0400138F RID: 5007
		private static readonly IntPtr NativeMethodInfoPtr_get_insideUnitSphere_Injected_Private_Static_Void_byref_Vector3_0;

		// Token: 0x04001390 RID: 5008
		private static readonly IntPtr NativeMethodInfoPtr_get_onUnitSphere_Injected_Private_Static_Void_byref_Vector3_0;

		// Token: 0x04001391 RID: 5009
		private static readonly IntPtr NativeMethodInfoPtr_get_rotation_Injected_Private_Static_Void_byref_Quaternion_0;

		// Token: 0x04001392 RID: 5010
		private static readonly Random.get_seedDelegate get_seedDelegateField;

		// Token: 0x04001393 RID: 5011
		private static readonly Random.set_seedDelegate set_seedDelegateField;

		// Token: 0x04001394 RID: 5012
		private static readonly Random.get_rotationUniform_InjectedDelegate get_rotationUniform_InjectedDelegateField;

		// Token: 0x02000894 RID: 2196
		[Serializable]
		[StructLayout(2)]
		public struct State
		{
			// Token: 0x060039AF RID: 14767 RVA: 0x000B1510 File Offset: 0x000AF710
			// Note: this type is marked as 'beforefieldinit'.
			static State()
			{
				Il2CppClassPointerStore<Random.State>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Random>.NativeClassPtr, "State");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Random.State>.NativeClassPtr);
				Random.State.NativeFieldInfoPtr_s0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Random.State>.NativeClassPtr, "s0");
				Random.State.NativeFieldInfoPtr_s1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Random.State>.NativeClassPtr, "s1");
				Random.State.NativeFieldInfoPtr_s2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Random.State>.NativeClassPtr, "s2");
				Random.State.NativeFieldInfoPtr_s3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Random.State>.NativeClassPtr, "s3");
			}

			// Token: 0x060039B0 RID: 14768 RVA: 0x00015D6C File Offset: 0x00013F6C
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Random.State>.NativeClassPtr, ref this));
			}

			// Token: 0x04002AF1 RID: 10993
			private static readonly IntPtr NativeFieldInfoPtr_s0;

			// Token: 0x04002AF2 RID: 10994
			private static readonly IntPtr NativeFieldInfoPtr_s1;

			// Token: 0x04002AF3 RID: 10995
			private static readonly IntPtr NativeFieldInfoPtr_s2;

			// Token: 0x04002AF4 RID: 10996
			private static readonly IntPtr NativeFieldInfoPtr_s3;

			// Token: 0x04002AF5 RID: 10997
			[FieldOffset(0)]
			public int s0;

			// Token: 0x04002AF6 RID: 10998
			[FieldOffset(4)]
			public int s1;

			// Token: 0x04002AF7 RID: 10999
			[FieldOffset(8)]
			public int s2;

			// Token: 0x04002AF8 RID: 11000
			[FieldOffset(12)]
			public int s3;
		}

		// Token: 0x02000895 RID: 2197
		// (Invoke) Token: 0x060039B2 RID: 14770
		private delegate int get_seedDelegate();

		// Token: 0x02000896 RID: 2198
		// (Invoke) Token: 0x060039B4 RID: 14772
		private delegate void set_seedDelegate(int value);

		// Token: 0x02000897 RID: 2199
		// (Invoke) Token: 0x060039B6 RID: 14774
		private delegate void get_rotationUniform_InjectedDelegate([Out] IntPtr ret);
	}
}
