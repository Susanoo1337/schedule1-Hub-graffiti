using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000067 RID: 103
	[StructLayout(2)]
	public struct Keyframe
	{
		// Token: 0x06000334 RID: 820 RVA: 0x00021688 File Offset: 0x0001F888
		// Note: this type is marked as 'beforefieldinit'.
		static Keyframe()
		{
			Il2CppClassPointerStore<Keyframe>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Keyframe");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Keyframe>.NativeClassPtr);
			Keyframe.NativeFieldInfoPtr_m_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, "m_Time");
			Keyframe.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, "m_Value");
			Keyframe.NativeFieldInfoPtr_m_InTangent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, "m_InTangent");
			Keyframe.NativeFieldInfoPtr_m_OutTangent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, "m_OutTangent");
			Keyframe.NativeFieldInfoPtr_m_WeightedMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, "m_WeightedMode");
			Keyframe.NativeFieldInfoPtr_m_InWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, "m_InWeight");
			Keyframe.NativeFieldInfoPtr_m_OutWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, "m_OutWeight");
			Keyframe.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663614);
			Keyframe.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663615);
			Keyframe.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663616);
			Keyframe.NativeMethodInfoPtr_get_time_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663617);
			Keyframe.NativeMethodInfoPtr_set_time_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663618);
			Keyframe.NativeMethodInfoPtr_get_value_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663619);
			Keyframe.NativeMethodInfoPtr_set_value_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663620);
			Keyframe.NativeMethodInfoPtr_get_inTangent_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663621);
			Keyframe.NativeMethodInfoPtr_set_inTangent_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663622);
			Keyframe.NativeMethodInfoPtr_get_outTangent_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663623);
			Keyframe.NativeMethodInfoPtr_set_outTangent_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663624);
			Keyframe.NativeMethodInfoPtr_get_inWeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663625);
			Keyframe.NativeMethodInfoPtr_set_inWeight_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663626);
			Keyframe.NativeMethodInfoPtr_get_outWeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663627);
			Keyframe.NativeMethodInfoPtr_set_outWeight_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663628);
			Keyframe.NativeMethodInfoPtr_get_weightedMode_Public_get_WeightedMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663629);
			Keyframe.NativeMethodInfoPtr_set_weightedMode_Public_set_Void_WeightedMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663630);
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00021898 File Offset: 0x0001FA98
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 1226660, RefRangeEnd = 1226679, XrefRangeStart = 1226660, XrefRangeEnd = 1226660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Keyframe(float time, float value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000336 RID: 822 RVA: 0x000218D8 File Offset: 0x0001FAD8
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1226679, RefRangeEnd = 1226694, XrefRangeStart = 1226679, XrefRangeEnd = 1226679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Keyframe(float time, float value, float inTangent, float outTangent)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inTangent;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref outTangent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00021934 File Offset: 0x0001FB34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1226694, RefRangeEnd = 1226696, XrefRangeStart = 1226694, XrefRangeEnd = 1226694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Keyframe(float time, float value, float inTangent, float outTangent, float inWeight, float outWeight)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inTangent;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref outTangent;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inWeight;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref outWeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000338 RID: 824 RVA: 0x000219AC File Offset: 0x0001FBAC
		// (set) Token: 0x06000339 RID: 825 RVA: 0x000219DC File Offset: 0x0001FBDC
		public unsafe float time
		{
			[CallerCount(87)]
			[CachedScanResults(RefRangeStart = 1226696, RefRangeEnd = 1226783, XrefRangeStart = 1226696, XrefRangeEnd = 1226696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_get_time_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(39)]
			[CachedScanResults(RefRangeStart = 42756, RefRangeEnd = 42795, XrefRangeStart = 42756, XrefRangeEnd = 42795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_set_time_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600033A RID: 826 RVA: 0x00021A10 File Offset: 0x0001FC10
		// (set) Token: 0x0600033B RID: 827 RVA: 0x00021A40 File Offset: 0x0001FC40
		public unsafe float value
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 1219142, RefRangeEnd = 1219216, XrefRangeStart = 1219142, XrefRangeEnd = 1219216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_get_value_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 42795, RefRangeEnd = 42811, XrefRangeStart = 42795, XrefRangeEnd = 42811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_set_value_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600033C RID: 828 RVA: 0x00021A74 File Offset: 0x0001FC74
		// (set) Token: 0x0600033D RID: 829 RVA: 0x00021AA4 File Offset: 0x0001FCA4
		public unsafe float inTangent
		{
			[CallerCount(41)]
			[CachedScanResults(RefRangeStart = 1226783, RefRangeEnd = 1226824, XrefRangeStart = 1226783, XrefRangeEnd = 1226783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_get_inTangent_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 42811, RefRangeEnd = 42819, XrefRangeStart = 42811, XrefRangeEnd = 42819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_set_inTangent_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600033E RID: 830 RVA: 0x00021AD8 File Offset: 0x0001FCD8
		// (set) Token: 0x0600033F RID: 831 RVA: 0x00021B08 File Offset: 0x0001FD08
		public unsafe float outTangent
		{
			[CallerCount(37)]
			[CachedScanResults(RefRangeStart = 1222680, RefRangeEnd = 1222717, XrefRangeStart = 1222680, XrefRangeEnd = 1222717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_get_outTangent_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 42819, RefRangeEnd = 42826, XrefRangeStart = 42819, XrefRangeEnd = 42826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_set_outTangent_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000340 RID: 832 RVA: 0x00021B3C File Offset: 0x0001FD3C
		// (set) Token: 0x06000341 RID: 833 RVA: 0x00021B6C File Offset: 0x0001FD6C
		public unsafe float inWeight
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1226824, RefRangeEnd = 1226826, XrefRangeStart = 1226824, XrefRangeEnd = 1226824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_get_inWeight_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 26895, RefRangeEnd = 26896, XrefRangeStart = 26895, XrefRangeEnd = 26896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_set_inWeight_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000342 RID: 834 RVA: 0x00021BA0 File Offset: 0x0001FDA0
		// (set) Token: 0x06000343 RID: 835 RVA: 0x00021BD0 File Offset: 0x0001FDD0
		public unsafe float outWeight
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 1226826, RefRangeEnd = 1226837, XrefRangeStart = 1226826, XrefRangeEnd = 1226826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_get_outWeight_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 149236, RefRangeEnd = 149240, XrefRangeStart = 149236, XrefRangeEnd = 149240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_set_outWeight_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000344 RID: 836 RVA: 0x00021C04 File Offset: 0x0001FE04
		// (set) Token: 0x06000345 RID: 837 RVA: 0x00021C34 File Offset: 0x0001FE34
		public unsafe WeightedMode weightedMode
		{
			[CallerCount(49)]
			[CachedScanResults(RefRangeStart = 669546, RefRangeEnd = 669595, XrefRangeStart = 669546, XrefRangeEnd = 669595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_get_weightedMode_Public_get_WeightedMode_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 29051, RefRangeEnd = 29056, XrefRangeStart = 29051, XrefRangeEnd = 29056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_set_weightedMode_Public_set_Void_WeightedMode_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00003A58 File Offset: 0x00001C58
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, ref this));
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000347 RID: 839 RVA: 0x00021C68 File Offset: 0x0001FE68
		// (set) Token: 0x06000348 RID: 840 RVA: 0x00003A6A File Offset: 0x00001C6A
		public int tangentMode
		{
			get
			{
				return this.tangentModeInternal;
			}
			set
			{
				this.tangentModeInternal = value;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000349 RID: 841 RVA: 0x00021C80 File Offset: 0x0001FE80
		// (set) Token: 0x0600034A RID: 842 RVA: 0x00003A75 File Offset: 0x00001C75
		public int tangentModeInternal
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeFieldInfoPtr_m_Time;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeFieldInfoPtr_m_InTangent;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeFieldInfoPtr_m_OutTangent;

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeFieldInfoPtr_m_WeightedMode;

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeFieldInfoPtr_m_InWeight;

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeFieldInfoPtr_m_OutWeight;

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_0;

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeMethodInfoPtr_get_time_Public_get_Single_0;

		// Token: 0x0400027D RID: 637
		private static readonly IntPtr NativeMethodInfoPtr_set_time_Public_set_Void_Single_0;

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_get_Single_0;

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeMethodInfoPtr_set_value_Public_set_Void_Single_0;

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeMethodInfoPtr_get_inTangent_Public_get_Single_0;

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeMethodInfoPtr_set_inTangent_Public_set_Void_Single_0;

		// Token: 0x04000282 RID: 642
		private static readonly IntPtr NativeMethodInfoPtr_get_outTangent_Public_get_Single_0;

		// Token: 0x04000283 RID: 643
		private static readonly IntPtr NativeMethodInfoPtr_set_outTangent_Public_set_Void_Single_0;

		// Token: 0x04000284 RID: 644
		private static readonly IntPtr NativeMethodInfoPtr_get_inWeight_Public_get_Single_0;

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeMethodInfoPtr_set_inWeight_Public_set_Void_Single_0;

		// Token: 0x04000286 RID: 646
		private static readonly IntPtr NativeMethodInfoPtr_get_outWeight_Public_get_Single_0;

		// Token: 0x04000287 RID: 647
		private static readonly IntPtr NativeMethodInfoPtr_set_outWeight_Public_set_Void_Single_0;

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeMethodInfoPtr_get_weightedMode_Public_get_WeightedMode_0;

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeMethodInfoPtr_set_weightedMode_Public_set_Void_WeightedMode_0;

		// Token: 0x0400028A RID: 650
		[FieldOffset(0)]
		public float m_Time;

		// Token: 0x0400028B RID: 651
		[FieldOffset(4)]
		public float m_Value;

		// Token: 0x0400028C RID: 652
		[FieldOffset(8)]
		public float m_InTangent;

		// Token: 0x0400028D RID: 653
		[FieldOffset(12)]
		public float m_OutTangent;

		// Token: 0x0400028E RID: 654
		[FieldOffset(16)]
		public int m_WeightedMode;

		// Token: 0x0400028F RID: 655
		[FieldOffset(20)]
		public float m_InWeight;

		// Token: 0x04000290 RID: 656
		[FieldOffset(24)]
		public float m_OutWeight;
	}
}
