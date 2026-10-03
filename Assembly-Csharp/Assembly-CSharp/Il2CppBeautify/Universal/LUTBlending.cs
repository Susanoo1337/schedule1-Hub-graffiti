using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppBeautify.Universal
{
	// Token: 0x0200008E RID: 142
	public class LUTBlending : MonoBehaviour
	{
		// Token: 0x06000C0B RID: 3083 RVA: 0x000A2920 File Offset: 0x000A0B20
		// Note: this type is marked as 'beforefieldinit'.
		static LUTBlending()
		{
			Il2CppClassPointerStore<LUTBlending>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Beautify.Universal", "LUTBlending");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr);
			LUTBlending.NativeFieldInfoPtr_LUT1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, "LUT1");
			LUTBlending.NativeFieldInfoPtr_LUT2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, "LUT2");
			LUTBlending.NativeFieldInfoPtr_LUT1Intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, "LUT1Intensity");
			LUTBlending.NativeFieldInfoPtr_LUT2Intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, "LUT2Intensity");
			LUTBlending.NativeFieldInfoPtr_phase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, "phase");
			LUTBlending.NativeFieldInfoPtr_lerpShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, "lerpShader");
			LUTBlending.NativeFieldInfoPtr_oldPhase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, "oldPhase");
			LUTBlending.NativeFieldInfoPtr_rt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, "rt");
			LUTBlending.NativeFieldInfoPtr_lerpMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, "lerpMat");
			LUTBlending.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, 100664812);
			LUTBlending.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, 100664813);
			LUTBlending.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, 100664814);
			LUTBlending.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, 100664815);
			LUTBlending.NativeMethodInfoPtr_UpdateBeautifyLUT_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, 100664816);
			LUTBlending.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, 100664817);
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x000A2A7C File Offset: 0x000A0C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78141, XrefRangeEnd = 78142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LUTBlending.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x000A2AB0 File Offset: 0x000A0CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78142, XrefRangeEnd = 78143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LUTBlending.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x000A2AE4 File Offset: 0x000A0CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78143, XrefRangeEnd = 78148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LUTBlending.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x000A2B18 File Offset: 0x000A0D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LUTBlending.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x000A2B4C File Offset: 0x000A0D4C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 78199, RefRangeEnd = 78202, XrefRangeStart = 78148, XrefRangeEnd = 78199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBeautifyLUT()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LUTBlending.NativeMethodInfoPtr_UpdateBeautifyLUT_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x000A2B80 File Offset: 0x000A0D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78202, XrefRangeEnd = 78203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LUTBlending() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LUTBlending.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x0000793A File Offset: 0x00005B3A
		public LUTBlending(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000C13 RID: 3091 RVA: 0x000A2BBC File Offset: 0x000A0DBC
		// (set) Token: 0x06000C14 RID: 3092 RVA: 0x00007943 File Offset: 0x00005B43
		public unsafe Texture2D LUT1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_LUT1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_LUT1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000C15 RID: 3093 RVA: 0x000A2BEC File Offset: 0x000A0DEC
		// (set) Token: 0x06000C16 RID: 3094 RVA: 0x00007962 File Offset: 0x00005B62
		public unsafe Texture2D LUT2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_LUT2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_LUT2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000C17 RID: 3095 RVA: 0x000A2C1C File Offset: 0x000A0E1C
		// (set) Token: 0x06000C18 RID: 3096 RVA: 0x00007981 File Offset: 0x00005B81
		public unsafe float LUT1Intensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_LUT1Intensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_LUT1Intensity)) = value;
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000C19 RID: 3097 RVA: 0x000A2C44 File Offset: 0x000A0E44
		// (set) Token: 0x06000C1A RID: 3098 RVA: 0x0000799C File Offset: 0x00005B9C
		public unsafe float LUT2Intensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_LUT2Intensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_LUT2Intensity)) = value;
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000C1B RID: 3099 RVA: 0x000A2C6C File Offset: 0x000A0E6C
		// (set) Token: 0x06000C1C RID: 3100 RVA: 0x000079B7 File Offset: 0x00005BB7
		public unsafe float phase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_phase);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_phase)) = value;
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000C1D RID: 3101 RVA: 0x000A2C94 File Offset: 0x000A0E94
		// (set) Token: 0x06000C1E RID: 3102 RVA: 0x000079D2 File Offset: 0x00005BD2
		public unsafe Shader lerpShader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_lerpShader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_lerpShader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000C1F RID: 3103 RVA: 0x000A2CC4 File Offset: 0x000A0EC4
		// (set) Token: 0x06000C20 RID: 3104 RVA: 0x000079F1 File Offset: 0x00005BF1
		public unsafe float oldPhase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_oldPhase);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_oldPhase)) = value;
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000C21 RID: 3105 RVA: 0x000A2CEC File Offset: 0x000A0EEC
		// (set) Token: 0x06000C22 RID: 3106 RVA: 0x00007A0C File Offset: 0x00005C0C
		public unsafe RenderTexture rt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_rt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_rt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06000C23 RID: 3107 RVA: 0x000A2D1C File Offset: 0x000A0F1C
		// (set) Token: 0x06000C24 RID: 3108 RVA: 0x00007A2B File Offset: 0x00005C2B
		public unsafe Material lerpMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_lerpMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_lerpMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000876 RID: 2166
		private static readonly IntPtr NativeFieldInfoPtr_LUT1;

		// Token: 0x04000877 RID: 2167
		private static readonly IntPtr NativeFieldInfoPtr_LUT2;

		// Token: 0x04000878 RID: 2168
		private static readonly IntPtr NativeFieldInfoPtr_LUT1Intensity;

		// Token: 0x04000879 RID: 2169
		private static readonly IntPtr NativeFieldInfoPtr_LUT2Intensity;

		// Token: 0x0400087A RID: 2170
		private static readonly IntPtr NativeFieldInfoPtr_phase;

		// Token: 0x0400087B RID: 2171
		private static readonly IntPtr NativeFieldInfoPtr_lerpShader;

		// Token: 0x0400087C RID: 2172
		private static readonly IntPtr NativeFieldInfoPtr_oldPhase;

		// Token: 0x0400087D RID: 2173
		private static readonly IntPtr NativeFieldInfoPtr_rt;

		// Token: 0x0400087E RID: 2174
		private static readonly IntPtr NativeFieldInfoPtr_lerpMat;

		// Token: 0x0400087F RID: 2175
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000880 RID: 2176
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04000881 RID: 2177
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000882 RID: 2178
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04000883 RID: 2179
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBeautifyLUT_Private_Void_0;

		// Token: 0x04000884 RID: 2180
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008AA RID: 2218
		public static class ShaderParams : Il2CppSystem.Object
		{
			// Token: 0x0600D3F0 RID: 54256 RVA: 0x0034D270 File Offset: 0x0034B470
			// Note: this type is marked as 'beforefieldinit'.
			static ShaderParams()
			{
				Il2CppClassPointerStore<LUTBlending.ShaderParams>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, "ShaderParams");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LUTBlending.ShaderParams>.NativeClassPtr);
				LUTBlending.ShaderParams.NativeFieldInfoPtr_LUT2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LUTBlending.ShaderParams>.NativeClassPtr, "LUT2");
				LUTBlending.ShaderParams.NativeFieldInfoPtr_Phase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LUTBlending.ShaderParams>.NativeClassPtr, "Phase");
			}

			// Token: 0x0600D3F1 RID: 54257 RVA: 0x000643BF File Offset: 0x000625BF
			public ShaderParams(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004084 RID: 16516
			// (get) Token: 0x0600D3F2 RID: 54258 RVA: 0x0034D2C4 File Offset: 0x0034B4C4
			// (set) Token: 0x0600D3F3 RID: 54259 RVA: 0x000643C8 File Offset: 0x000625C8
			public unsafe static int LUT2
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LUTBlending.ShaderParams.NativeFieldInfoPtr_LUT2, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LUTBlending.ShaderParams.NativeFieldInfoPtr_LUT2, (void*)(&value));
				}
			}

			// Token: 0x17004085 RID: 16517
			// (get) Token: 0x0600D3F4 RID: 54260 RVA: 0x0034D2E0 File Offset: 0x0034B4E0
			// (set) Token: 0x0600D3F5 RID: 54261 RVA: 0x000643D6 File Offset: 0x000625D6
			public unsafe static int Phase
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LUTBlending.ShaderParams.NativeFieldInfoPtr_Phase, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LUTBlending.ShaderParams.NativeFieldInfoPtr_Phase, (void*)(&value));
				}
			}

			// Token: 0x04009053 RID: 36947
			private static readonly IntPtr NativeFieldInfoPtr_LUT2;

			// Token: 0x04009054 RID: 36948
			private static readonly IntPtr NativeFieldInfoPtr_Phase;
		}
	}
}
