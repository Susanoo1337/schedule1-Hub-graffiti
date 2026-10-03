using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000014 RID: 20
	public class FrameTimingsHUDDisplay : MonoBehaviour
	{
		// Token: 0x06000110 RID: 272 RVA: 0x0007EAC0 File Offset: 0x0007CCC0
		// Note: this type is marked as 'beforefieldinit'.
		static FrameTimingsHUDDisplay()
		{
			Il2CppClassPointerStore<FrameTimingsHUDDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FrameTimingsHUDDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrameTimingsHUDDisplay>.NativeClassPtr);
			FrameTimingsHUDDisplay.NativeFieldInfoPtr_m_Style = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTimingsHUDDisplay>.NativeClassPtr, "m_Style");
			FrameTimingsHUDDisplay.NativeFieldInfoPtr_m_FrameTimings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTimingsHUDDisplay>.NativeClassPtr, "m_FrameTimings");
			FrameTimingsHUDDisplay.NativeFieldInfoPtr_SAMPLE_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTimingsHUDDisplay>.NativeClassPtr, "SAMPLE_SIZE");
			FrameTimingsHUDDisplay.NativeFieldInfoPtr_frameTimingsHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTimingsHUDDisplay>.NativeClassPtr, "frameTimingsHistory");
			FrameTimingsHUDDisplay.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameTimingsHUDDisplay>.NativeClassPtr, 100663397);
			FrameTimingsHUDDisplay.NativeMethodInfoPtr_OnGUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameTimingsHUDDisplay>.NativeClassPtr, 100663398);
			FrameTimingsHUDDisplay.NativeMethodInfoPtr_CaptureTimings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameTimingsHUDDisplay>.NativeClassPtr, 100663399);
			FrameTimingsHUDDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameTimingsHUDDisplay>.NativeClassPtr, 100663400);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0007EB90 File Offset: 0x0007CD90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65754, XrefRangeEnd = 65762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameTimingsHUDDisplay.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0007EBC4 File Offset: 0x0007CDC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65762, XrefRangeEnd = 65820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameTimingsHUDDisplay.NativeMethodInfoPtr_OnGUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0007EBF8 File Offset: 0x0007CDF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65820, XrefRangeEnd = 65823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CaptureTimings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameTimingsHUDDisplay.NativeMethodInfoPtr_CaptureTimings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0007EC2C File Offset: 0x0007CE2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65823, XrefRangeEnd = 65835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FrameTimingsHUDDisplay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FrameTimingsHUDDisplay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameTimingsHUDDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000029E4 File Offset: 0x00000BE4
		public FrameTimingsHUDDisplay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000116 RID: 278 RVA: 0x0007EC68 File Offset: 0x0007CE68
		// (set) Token: 0x06000117 RID: 279 RVA: 0x000029ED File Offset: 0x00000BED
		public unsafe GUIStyle m_Style
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FrameTimingsHUDDisplay.NativeFieldInfoPtr_m_Style);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FrameTimingsHUDDisplay.NativeFieldInfoPtr_m_Style), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000118 RID: 280 RVA: 0x0007EC98 File Offset: 0x0007CE98
		// (set) Token: 0x06000119 RID: 281 RVA: 0x00002A0C File Offset: 0x00000C0C
		public unsafe Il2CppStructArray<FrameTiming> m_FrameTimings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FrameTimingsHUDDisplay.NativeFieldInfoPtr_m_FrameTimings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<FrameTiming>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FrameTimingsHUDDisplay.NativeFieldInfoPtr_m_FrameTimings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600011A RID: 282 RVA: 0x0007ECC8 File Offset: 0x0007CEC8
		// (set) Token: 0x0600011B RID: 283 RVA: 0x00002A2B File Offset: 0x00000C2B
		public unsafe static int SAMPLE_SIZE
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(FrameTimingsHUDDisplay.NativeFieldInfoPtr_SAMPLE_SIZE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FrameTimingsHUDDisplay.NativeFieldInfoPtr_SAMPLE_SIZE, (void*)(&value));
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600011C RID: 284 RVA: 0x0007ECE4 File Offset: 0x0007CEE4
		// (set) Token: 0x0600011D RID: 285 RVA: 0x00002A39 File Offset: 0x00000C39
		public unsafe List<FrameTimingsHUDDisplay.FrameTimingPoint> frameTimingsHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FrameTimingsHUDDisplay.NativeFieldInfoPtr_frameTimingsHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FrameTimingsHUDDisplay.FrameTimingPoint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FrameTimingsHUDDisplay.NativeFieldInfoPtr_frameTimingsHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeFieldInfoPtr_m_Style;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeFieldInfoPtr_m_FrameTimings;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeFieldInfoPtr_SAMPLE_SIZE;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeFieldInfoPtr_frameTimingsHistory;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Private_Void_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_CaptureTimings_Private_Void_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000854 RID: 2132
		[StructLayout(2)]
		public struct FrameTimingPoint
		{
			// Token: 0x0600CFC2 RID: 53186 RVA: 0x00343320 File Offset: 0x00341520
			// Note: this type is marked as 'beforefieldinit'.
			static FrameTimingPoint()
			{
				Il2CppClassPointerStore<FrameTimingsHUDDisplay.FrameTimingPoint>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FrameTimingsHUDDisplay>.NativeClassPtr, "FrameTimingPoint");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrameTimingsHUDDisplay.FrameTimingPoint>.NativeClassPtr);
				FrameTimingsHUDDisplay.FrameTimingPoint.NativeFieldInfoPtr_cpuFrameTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTimingsHUDDisplay.FrameTimingPoint>.NativeClassPtr, "cpuFrameTime");
				FrameTimingsHUDDisplay.FrameTimingPoint.NativeFieldInfoPtr_cpuMainThreadFrameTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTimingsHUDDisplay.FrameTimingPoint>.NativeClassPtr, "cpuMainThreadFrameTime");
				FrameTimingsHUDDisplay.FrameTimingPoint.NativeFieldInfoPtr_cpuRenderThreadFrameTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTimingsHUDDisplay.FrameTimingPoint>.NativeClassPtr, "cpuRenderThreadFrameTime");
				FrameTimingsHUDDisplay.FrameTimingPoint.NativeFieldInfoPtr_gpuFrameTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTimingsHUDDisplay.FrameTimingPoint>.NativeClassPtr, "gpuFrameTime");
			}

			// Token: 0x0600CFC3 RID: 53187 RVA: 0x000625BD File Offset: 0x000607BD
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FrameTimingsHUDDisplay.FrameTimingPoint>.NativeClassPtr, ref this));
			}

			// Token: 0x04008DA2 RID: 36258
			private static readonly IntPtr NativeFieldInfoPtr_cpuFrameTime;

			// Token: 0x04008DA3 RID: 36259
			private static readonly IntPtr NativeFieldInfoPtr_cpuMainThreadFrameTime;

			// Token: 0x04008DA4 RID: 36260
			private static readonly IntPtr NativeFieldInfoPtr_cpuRenderThreadFrameTime;

			// Token: 0x04008DA5 RID: 36261
			private static readonly IntPtr NativeFieldInfoPtr_gpuFrameTime;

			// Token: 0x04008DA6 RID: 36262
			[FieldOffset(0)]
			public double cpuFrameTime;

			// Token: 0x04008DA7 RID: 36263
			[FieldOffset(8)]
			public double cpuMainThreadFrameTime;

			// Token: 0x04008DA8 RID: 36264
			[FieldOffset(16)]
			public double cpuRenderThreadFrameTime;

			// Token: 0x04008DA9 RID: 36265
			[FieldOffset(24)]
			public double gpuFrameTime;
		}
	}
}
