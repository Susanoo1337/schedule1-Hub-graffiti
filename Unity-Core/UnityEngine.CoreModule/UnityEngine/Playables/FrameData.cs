using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Playables
{
	// Token: 0x0200024B RID: 587
	[StructLayout(2)]
	public struct FrameData
	{
		// Token: 0x060028E7 RID: 10471 RVA: 0x0009FB08 File Offset: 0x0009DD08
		// Note: this type is marked as 'beforefieldinit'.
		static FrameData()
		{
			Il2CppClassPointerStore<FrameData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "FrameData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrameData>.NativeClassPtr);
			FrameData.NativeFieldInfoPtr_m_FrameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, "m_FrameID");
			FrameData.NativeFieldInfoPtr_m_DeltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, "m_DeltaTime");
			FrameData.NativeFieldInfoPtr_m_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, "m_Weight");
			FrameData.NativeFieldInfoPtr_m_EffectiveWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, "m_EffectiveWeight");
			FrameData.NativeFieldInfoPtr_m_EffectiveParentDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, "m_EffectiveParentDelay");
			FrameData.NativeFieldInfoPtr_m_EffectiveParentSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, "m_EffectiveParentSpeed");
			FrameData.NativeFieldInfoPtr_m_EffectiveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, "m_EffectiveSpeed");
			FrameData.NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, "m_Flags");
			FrameData.NativeFieldInfoPtr_m_Output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, "m_Output");
			FrameData.NativeMethodInfoPtr_HasFlags_Private_Boolean_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameData>.NativeClassPtr, 100667653);
			FrameData.NativeMethodInfoPtr_get_deltaTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameData>.NativeClassPtr, 100667654);
			FrameData.NativeMethodInfoPtr_get_effectiveSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameData>.NativeClassPtr, 100667655);
			FrameData.NativeMethodInfoPtr_get_evaluationType_Public_get_EvaluationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameData>.NativeClassPtr, 100667656);
			FrameData.NativeMethodInfoPtr_get_seekOccurred_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameData>.NativeClassPtr, 100667657);
			FrameData.NativeMethodInfoPtr_get_timeLooped_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameData>.NativeClassPtr, 100667658);
			FrameData.NativeMethodInfoPtr_get_timeHeld_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameData>.NativeClassPtr, 100667659);
			FrameData.NativeMethodInfoPtr_get_output_Public_get_PlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameData>.NativeClassPtr, 100667660);
			FrameData.NativeMethodInfoPtr_get_effectivePlayState_Public_get_PlayState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameData>.NativeClassPtr, 100667661);
		}

		// Token: 0x060028E8 RID: 10472 RVA: 0x0009FCA0 File Offset: 0x0009DEA0
		[CallerCount(0)]
		public unsafe bool HasFlags(FrameData.Flags flag)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref flag;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameData.NativeMethodInfoPtr_HasFlags_Private_Boolean_Flags_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x060028E9 RID: 10473 RVA: 0x0009FCE0 File Offset: 0x0009DEE0
		public unsafe float deltaTime
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1292560, RefRangeEnd = 1292562, XrefRangeStart = 1292560, XrefRangeEnd = 1292560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameData.NativeMethodInfoPtr_get_deltaTime_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x060028EA RID: 10474 RVA: 0x0009FD10 File Offset: 0x0009DF10
		public unsafe float effectiveSpeed
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1282757, RefRangeEnd = 1282765, XrefRangeStart = 1282757, XrefRangeEnd = 1282765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameData.NativeMethodInfoPtr_get_effectiveSpeed_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x060028EB RID: 10475 RVA: 0x0009FD40 File Offset: 0x0009DF40
		public unsafe FrameData.EvaluationType evaluationType
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1292562, RefRangeEnd = 1292565, XrefRangeStart = 1292562, XrefRangeEnd = 1292562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameData.NativeMethodInfoPtr_get_evaluationType_Public_get_EvaluationType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x060028EC RID: 10476 RVA: 0x0009FD70 File Offset: 0x0009DF70
		public unsafe bool seekOccurred
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1292565, RefRangeEnd = 1292566, XrefRangeStart = 1292565, XrefRangeEnd = 1292565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameData.NativeMethodInfoPtr_get_seekOccurred_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x060028ED RID: 10477 RVA: 0x0009FDA0 File Offset: 0x0009DFA0
		public unsafe bool timeLooped
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1292566, RefRangeEnd = 1292572, XrefRangeStart = 1292566, XrefRangeEnd = 1292566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameData.NativeMethodInfoPtr_get_timeLooped_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x060028EE RID: 10478 RVA: 0x0009FDD0 File Offset: 0x0009DFD0
		public unsafe bool timeHeld
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1292572, RefRangeEnd = 1292573, XrefRangeStart = 1292572, XrefRangeEnd = 1292572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameData.NativeMethodInfoPtr_get_timeHeld_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x060028EF RID: 10479 RVA: 0x0009FE00 File Offset: 0x0009E000
		public unsafe PlayableOutput output
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1292573, RefRangeEnd = 1292577, XrefRangeStart = 1292573, XrefRangeEnd = 1292573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameData.NativeMethodInfoPtr_get_output_Public_get_PlayableOutput_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x060028F0 RID: 10480 RVA: 0x0009FE30 File Offset: 0x0009E030
		public unsafe PlayState effectivePlayState
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1292577, RefRangeEnd = 1292580, XrefRangeStart = 1292577, XrefRangeEnd = 1292577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameData.NativeMethodInfoPtr_get_effectivePlayState_Public_get_PlayState_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060028F1 RID: 10481 RVA: 0x0001260B File Offset: 0x0001080B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FrameData>.NativeClassPtr, ref this));
		}

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x060028F2 RID: 10482 RVA: 0x0009FE60 File Offset: 0x0009E060
		public ulong frameId
		{
			get
			{
				return this.m_FrameID;
			}
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x060028F3 RID: 10483 RVA: 0x0009FE78 File Offset: 0x0009E078
		public float weight
		{
			get
			{
				return this.m_Weight;
			}
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x060028F4 RID: 10484 RVA: 0x0009FE90 File Offset: 0x0009E090
		public float effectiveWeight
		{
			get
			{
				return this.m_EffectiveWeight;
			}
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x060028F5 RID: 10485 RVA: 0x0009FEA8 File Offset: 0x0009E0A8
		public double effectiveParentDelay
		{
			get
			{
				return this.m_EffectiveParentDelay;
			}
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x060028F6 RID: 10486 RVA: 0x0009FEC0 File Offset: 0x0009E0C0
		public float effectiveParentSpeed
		{
			get
			{
				return this.m_EffectiveParentSpeed;
			}
		}

		// Token: 0x040022C3 RID: 8899
		private static readonly IntPtr NativeFieldInfoPtr_m_FrameID;

		// Token: 0x040022C4 RID: 8900
		private static readonly IntPtr NativeFieldInfoPtr_m_DeltaTime;

		// Token: 0x040022C5 RID: 8901
		private static readonly IntPtr NativeFieldInfoPtr_m_Weight;

		// Token: 0x040022C6 RID: 8902
		private static readonly IntPtr NativeFieldInfoPtr_m_EffectiveWeight;

		// Token: 0x040022C7 RID: 8903
		private static readonly IntPtr NativeFieldInfoPtr_m_EffectiveParentDelay;

		// Token: 0x040022C8 RID: 8904
		private static readonly IntPtr NativeFieldInfoPtr_m_EffectiveParentSpeed;

		// Token: 0x040022C9 RID: 8905
		private static readonly IntPtr NativeFieldInfoPtr_m_EffectiveSpeed;

		// Token: 0x040022CA RID: 8906
		private static readonly IntPtr NativeFieldInfoPtr_m_Flags;

		// Token: 0x040022CB RID: 8907
		private static readonly IntPtr NativeFieldInfoPtr_m_Output;

		// Token: 0x040022CC RID: 8908
		private static readonly IntPtr NativeMethodInfoPtr_HasFlags_Private_Boolean_Flags_0;

		// Token: 0x040022CD RID: 8909
		private static readonly IntPtr NativeMethodInfoPtr_get_deltaTime_Public_get_Single_0;

		// Token: 0x040022CE RID: 8910
		private static readonly IntPtr NativeMethodInfoPtr_get_effectiveSpeed_Public_get_Single_0;

		// Token: 0x040022CF RID: 8911
		private static readonly IntPtr NativeMethodInfoPtr_get_evaluationType_Public_get_EvaluationType_0;

		// Token: 0x040022D0 RID: 8912
		private static readonly IntPtr NativeMethodInfoPtr_get_seekOccurred_Public_get_Boolean_0;

		// Token: 0x040022D1 RID: 8913
		private static readonly IntPtr NativeMethodInfoPtr_get_timeLooped_Public_get_Boolean_0;

		// Token: 0x040022D2 RID: 8914
		private static readonly IntPtr NativeMethodInfoPtr_get_timeHeld_Public_get_Boolean_0;

		// Token: 0x040022D3 RID: 8915
		private static readonly IntPtr NativeMethodInfoPtr_get_output_Public_get_PlayableOutput_0;

		// Token: 0x040022D4 RID: 8916
		private static readonly IntPtr NativeMethodInfoPtr_get_effectivePlayState_Public_get_PlayState_0;

		// Token: 0x040022D5 RID: 8917
		[FieldOffset(0)]
		public ulong m_FrameID;

		// Token: 0x040022D6 RID: 8918
		[FieldOffset(8)]
		public double m_DeltaTime;

		// Token: 0x040022D7 RID: 8919
		[FieldOffset(16)]
		public float m_Weight;

		// Token: 0x040022D8 RID: 8920
		[FieldOffset(20)]
		public float m_EffectiveWeight;

		// Token: 0x040022D9 RID: 8921
		[FieldOffset(24)]
		public double m_EffectiveParentDelay;

		// Token: 0x040022DA RID: 8922
		[FieldOffset(32)]
		public float m_EffectiveParentSpeed;

		// Token: 0x040022DB RID: 8923
		[FieldOffset(36)]
		public float m_EffectiveSpeed;

		// Token: 0x040022DC RID: 8924
		[FieldOffset(40)]
		public FrameData.Flags m_Flags;

		// Token: 0x040022DD RID: 8925
		[FieldOffset(48)]
		public PlayableOutput m_Output;

		// Token: 0x02000B96 RID: 2966
		[OriginalName("UnityEngine.CoreModule.dll", "", "Flags")]
		[Flags]
		public enum Flags
		{
			// Token: 0x04002BF0 RID: 11248
			Evaluate = 1,
			// Token: 0x04002BF1 RID: 11249
			SeekOccured = 2,
			// Token: 0x04002BF2 RID: 11250
			Loop = 4,
			// Token: 0x04002BF3 RID: 11251
			Hold = 8,
			// Token: 0x04002BF4 RID: 11252
			EffectivePlayStateDelayed = 16,
			// Token: 0x04002BF5 RID: 11253
			EffectivePlayStatePlaying = 32
		}

		// Token: 0x02000B97 RID: 2967
		[OriginalName("UnityEngine.CoreModule.dll", "", "EvaluationType")]
		public enum EvaluationType
		{
			// Token: 0x04002BF7 RID: 11255
			Evaluate,
			// Token: 0x04002BF8 RID: 11256
			Playback
		}
	}
}
