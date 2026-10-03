using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PlayerLoop
{
	// Token: 0x020001C0 RID: 448
	[StructLayout(2)]
	public struct EarlyUpdate
	{
		// Token: 0x0600209D RID: 8349 RVA: 0x0000F0D7 File Offset: 0x0000D2D7
		// Note: this type is marked as 'beforefieldinit'.
		static EarlyUpdate()
		{
			Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.PlayerLoop", "EarlyUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr);
		}

		// Token: 0x0600209E RID: 8350 RVA: 0x0000F0FC File Offset: 0x0000D2FC
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, ref this));
		}

		// Token: 0x02000A39 RID: 2617
		[StructLayout(2)]
		public struct PollPlayerConnection
		{
			// Token: 0x06003D41 RID: 15681 RVA: 0x00016A4A File Offset: 0x00014C4A
			// Note: this type is marked as 'beforefieldinit'.
			static PollPlayerConnection()
			{
				Il2CppClassPointerStore<EarlyUpdate.PollPlayerConnection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "PollPlayerConnection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.PollPlayerConnection>.NativeClassPtr);
			}

			// Token: 0x06003D42 RID: 15682 RVA: 0x00016A6A File Offset: 0x00014C6A
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.PollPlayerConnection>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A3A RID: 2618
		[StructLayout(2)]
		public struct PollHtcsPlayerConnection
		{
			// Token: 0x06003D43 RID: 15683 RVA: 0x00016A7C File Offset: 0x00014C7C
			// Note: this type is marked as 'beforefieldinit'.
			static PollHtcsPlayerConnection()
			{
				Il2CppClassPointerStore<EarlyUpdate.PollHtcsPlayerConnection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "PollHtcsPlayerConnection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.PollHtcsPlayerConnection>.NativeClassPtr);
			}

			// Token: 0x06003D44 RID: 15684 RVA: 0x00016A9C File Offset: 0x00014C9C
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.PollHtcsPlayerConnection>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A3B RID: 2619
		[StructLayout(2)]
		public struct GpuTimestamp
		{
			// Token: 0x06003D45 RID: 15685 RVA: 0x00016AAE File Offset: 0x00014CAE
			// Note: this type is marked as 'beforefieldinit'.
			static GpuTimestamp()
			{
				Il2CppClassPointerStore<EarlyUpdate.GpuTimestamp>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "GpuTimestamp");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.GpuTimestamp>.NativeClassPtr);
			}

			// Token: 0x06003D46 RID: 15686 RVA: 0x00016ACE File Offset: 0x00014CCE
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.GpuTimestamp>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A3C RID: 2620
		[StructLayout(2)]
		public struct AnalyticsCoreStatsUpdate
		{
			// Token: 0x06003D47 RID: 15687 RVA: 0x00016AE0 File Offset: 0x00014CE0
			// Note: this type is marked as 'beforefieldinit'.
			static AnalyticsCoreStatsUpdate()
			{
				Il2CppClassPointerStore<EarlyUpdate.AnalyticsCoreStatsUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "AnalyticsCoreStatsUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.AnalyticsCoreStatsUpdate>.NativeClassPtr);
			}

			// Token: 0x06003D48 RID: 15688 RVA: 0x00016B00 File Offset: 0x00014D00
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.AnalyticsCoreStatsUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A3D RID: 2621
		[StructLayout(2)]
		public struct UnityWebRequestUpdate
		{
			// Token: 0x06003D49 RID: 15689 RVA: 0x00016B12 File Offset: 0x00014D12
			// Note: this type is marked as 'beforefieldinit'.
			static UnityWebRequestUpdate()
			{
				Il2CppClassPointerStore<EarlyUpdate.UnityWebRequestUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UnityWebRequestUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UnityWebRequestUpdate>.NativeClassPtr);
			}

			// Token: 0x06003D4A RID: 15690 RVA: 0x00016B32 File Offset: 0x00014D32
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UnityWebRequestUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A3E RID: 2622
		[StructLayout(2)]
		public struct UpdateStreamingManager
		{
			// Token: 0x06003D4B RID: 15691 RVA: 0x00016B44 File Offset: 0x00014D44
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateStreamingManager()
			{
				Il2CppClassPointerStore<EarlyUpdate.UpdateStreamingManager>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdateStreamingManager");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdateStreamingManager>.NativeClassPtr);
			}

			// Token: 0x06003D4C RID: 15692 RVA: 0x00016B64 File Offset: 0x00014D64
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdateStreamingManager>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A3F RID: 2623
		[StructLayout(2)]
		public struct ExecuteMainThreadJobs
		{
			// Token: 0x06003D4D RID: 15693 RVA: 0x00016B76 File Offset: 0x00014D76
			// Note: this type is marked as 'beforefieldinit'.
			static ExecuteMainThreadJobs()
			{
				Il2CppClassPointerStore<EarlyUpdate.ExecuteMainThreadJobs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "ExecuteMainThreadJobs");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.ExecuteMainThreadJobs>.NativeClassPtr);
			}

			// Token: 0x06003D4E RID: 15694 RVA: 0x00016B96 File Offset: 0x00014D96
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.ExecuteMainThreadJobs>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A40 RID: 2624
		[StructLayout(2)]
		public struct ProcessMouseInWindow
		{
			// Token: 0x06003D4F RID: 15695 RVA: 0x00016BA8 File Offset: 0x00014DA8
			// Note: this type is marked as 'beforefieldinit'.
			static ProcessMouseInWindow()
			{
				Il2CppClassPointerStore<EarlyUpdate.ProcessMouseInWindow>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "ProcessMouseInWindow");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.ProcessMouseInWindow>.NativeClassPtr);
			}

			// Token: 0x06003D50 RID: 15696 RVA: 0x00016BC8 File Offset: 0x00014DC8
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.ProcessMouseInWindow>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A41 RID: 2625
		[StructLayout(2)]
		public struct ClearIntermediateRenderers
		{
			// Token: 0x06003D51 RID: 15697 RVA: 0x00016BDA File Offset: 0x00014DDA
			// Note: this type is marked as 'beforefieldinit'.
			static ClearIntermediateRenderers()
			{
				Il2CppClassPointerStore<EarlyUpdate.ClearIntermediateRenderers>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "ClearIntermediateRenderers");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.ClearIntermediateRenderers>.NativeClassPtr);
			}

			// Token: 0x06003D52 RID: 15698 RVA: 0x00016BFA File Offset: 0x00014DFA
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.ClearIntermediateRenderers>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A42 RID: 2626
		[StructLayout(2)]
		public struct ClearLines
		{
			// Token: 0x06003D53 RID: 15699 RVA: 0x00016C0C File Offset: 0x00014E0C
			// Note: this type is marked as 'beforefieldinit'.
			static ClearLines()
			{
				Il2CppClassPointerStore<EarlyUpdate.ClearLines>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "ClearLines");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.ClearLines>.NativeClassPtr);
			}

			// Token: 0x06003D54 RID: 15700 RVA: 0x00016C2C File Offset: 0x00014E2C
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.ClearLines>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A43 RID: 2627
		[StructLayout(2)]
		public struct PresentBeforeUpdate
		{
			// Token: 0x06003D55 RID: 15701 RVA: 0x00016C3E File Offset: 0x00014E3E
			// Note: this type is marked as 'beforefieldinit'.
			static PresentBeforeUpdate()
			{
				Il2CppClassPointerStore<EarlyUpdate.PresentBeforeUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "PresentBeforeUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.PresentBeforeUpdate>.NativeClassPtr);
			}

			// Token: 0x06003D56 RID: 15702 RVA: 0x00016C5E File Offset: 0x00014E5E
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.PresentBeforeUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A44 RID: 2628
		[StructLayout(2)]
		public struct ResetFrameStatsAfterPresent
		{
			// Token: 0x06003D57 RID: 15703 RVA: 0x00016C70 File Offset: 0x00014E70
			// Note: this type is marked as 'beforefieldinit'.
			static ResetFrameStatsAfterPresent()
			{
				Il2CppClassPointerStore<EarlyUpdate.ResetFrameStatsAfterPresent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "ResetFrameStatsAfterPresent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.ResetFrameStatsAfterPresent>.NativeClassPtr);
			}

			// Token: 0x06003D58 RID: 15704 RVA: 0x00016C90 File Offset: 0x00014E90
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.ResetFrameStatsAfterPresent>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A45 RID: 2629
		[StructLayout(2)]
		public struct UpdateAsyncReadbackManager
		{
			// Token: 0x06003D59 RID: 15705 RVA: 0x00016CA2 File Offset: 0x00014EA2
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateAsyncReadbackManager()
			{
				Il2CppClassPointerStore<EarlyUpdate.UpdateAsyncReadbackManager>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdateAsyncReadbackManager");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdateAsyncReadbackManager>.NativeClassPtr);
			}

			// Token: 0x06003D5A RID: 15706 RVA: 0x00016CC2 File Offset: 0x00014EC2
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdateAsyncReadbackManager>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A46 RID: 2630
		[StructLayout(2)]
		public struct UpdateTextureStreamingManager
		{
			// Token: 0x06003D5B RID: 15707 RVA: 0x00016CD4 File Offset: 0x00014ED4
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateTextureStreamingManager()
			{
				Il2CppClassPointerStore<EarlyUpdate.UpdateTextureStreamingManager>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdateTextureStreamingManager");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdateTextureStreamingManager>.NativeClassPtr);
			}

			// Token: 0x06003D5C RID: 15708 RVA: 0x00016CF4 File Offset: 0x00014EF4
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdateTextureStreamingManager>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A47 RID: 2631
		[StructLayout(2)]
		public struct UpdatePreloading
		{
			// Token: 0x06003D5D RID: 15709 RVA: 0x00016D06 File Offset: 0x00014F06
			// Note: this type is marked as 'beforefieldinit'.
			static UpdatePreloading()
			{
				Il2CppClassPointerStore<EarlyUpdate.UpdatePreloading>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdatePreloading");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdatePreloading>.NativeClassPtr);
			}

			// Token: 0x06003D5E RID: 15710 RVA: 0x00016D26 File Offset: 0x00014F26
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdatePreloading>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A48 RID: 2632
		[StructLayout(2)]
		public struct UpdateContentLoading
		{
			// Token: 0x06003D5F RID: 15711 RVA: 0x00016D38 File Offset: 0x00014F38
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateContentLoading()
			{
				Il2CppClassPointerStore<EarlyUpdate.UpdateContentLoading>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdateContentLoading");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdateContentLoading>.NativeClassPtr);
			}

			// Token: 0x06003D60 RID: 15712 RVA: 0x00016D58 File Offset: 0x00014F58
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdateContentLoading>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A49 RID: 2633
		[StructLayout(2)]
		public struct UpdateAsyncInstantiate
		{
			// Token: 0x06003D61 RID: 15713 RVA: 0x00016D6A File Offset: 0x00014F6A
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateAsyncInstantiate()
			{
				Il2CppClassPointerStore<EarlyUpdate.UpdateAsyncInstantiate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdateAsyncInstantiate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdateAsyncInstantiate>.NativeClassPtr);
			}

			// Token: 0x06003D62 RID: 15714 RVA: 0x00016D8A File Offset: 0x00014F8A
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdateAsyncInstantiate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A4A RID: 2634
		[StructLayout(2)]
		public struct RendererNotifyInvisible
		{
			// Token: 0x06003D63 RID: 15715 RVA: 0x00016D9C File Offset: 0x00014F9C
			// Note: this type is marked as 'beforefieldinit'.
			static RendererNotifyInvisible()
			{
				Il2CppClassPointerStore<EarlyUpdate.RendererNotifyInvisible>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "RendererNotifyInvisible");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.RendererNotifyInvisible>.NativeClassPtr);
			}

			// Token: 0x06003D64 RID: 15716 RVA: 0x00016DBC File Offset: 0x00014FBC
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.RendererNotifyInvisible>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A4B RID: 2635
		[StructLayout(2)]
		public struct PlayerCleanupCachedData
		{
			// Token: 0x06003D65 RID: 15717 RVA: 0x00016DCE File Offset: 0x00014FCE
			// Note: this type is marked as 'beforefieldinit'.
			static PlayerCleanupCachedData()
			{
				Il2CppClassPointerStore<EarlyUpdate.PlayerCleanupCachedData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "PlayerCleanupCachedData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.PlayerCleanupCachedData>.NativeClassPtr);
			}

			// Token: 0x06003D66 RID: 15718 RVA: 0x00016DEE File Offset: 0x00014FEE
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.PlayerCleanupCachedData>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A4C RID: 2636
		[StructLayout(2)]
		public struct UpdateMainGameViewRect
		{
			// Token: 0x06003D67 RID: 15719 RVA: 0x00016E00 File Offset: 0x00015000
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateMainGameViewRect()
			{
				Il2CppClassPointerStore<EarlyUpdate.UpdateMainGameViewRect>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdateMainGameViewRect");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdateMainGameViewRect>.NativeClassPtr);
			}

			// Token: 0x06003D68 RID: 15720 RVA: 0x00016E20 File Offset: 0x00015020
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdateMainGameViewRect>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A4D RID: 2637
		[StructLayout(2)]
		public struct UpdateCanvasRectTransform
		{
			// Token: 0x06003D69 RID: 15721 RVA: 0x00016E32 File Offset: 0x00015032
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateCanvasRectTransform()
			{
				Il2CppClassPointerStore<EarlyUpdate.UpdateCanvasRectTransform>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdateCanvasRectTransform");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdateCanvasRectTransform>.NativeClassPtr);
			}

			// Token: 0x06003D6A RID: 15722 RVA: 0x00016E52 File Offset: 0x00015052
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdateCanvasRectTransform>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A4E RID: 2638
		[StructLayout(2)]
		public struct UpdateInputManager
		{
			// Token: 0x06003D6B RID: 15723 RVA: 0x00016E64 File Offset: 0x00015064
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateInputManager()
			{
				Il2CppClassPointerStore<EarlyUpdate.UpdateInputManager>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdateInputManager");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdateInputManager>.NativeClassPtr);
			}

			// Token: 0x06003D6C RID: 15724 RVA: 0x00016E84 File Offset: 0x00015084
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdateInputManager>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A4F RID: 2639
		[StructLayout(2)]
		public struct ProcessRemoteInput
		{
			// Token: 0x06003D6D RID: 15725 RVA: 0x00016E96 File Offset: 0x00015096
			// Note: this type is marked as 'beforefieldinit'.
			static ProcessRemoteInput()
			{
				Il2CppClassPointerStore<EarlyUpdate.ProcessRemoteInput>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "ProcessRemoteInput");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.ProcessRemoteInput>.NativeClassPtr);
			}

			// Token: 0x06003D6E RID: 15726 RVA: 0x00016EB6 File Offset: 0x000150B6
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.ProcessRemoteInput>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A50 RID: 2640
		[StructLayout(2)]
		public struct XRUpdate
		{
			// Token: 0x06003D6F RID: 15727 RVA: 0x00016EC8 File Offset: 0x000150C8
			// Note: this type is marked as 'beforefieldinit'.
			static XRUpdate()
			{
				Il2CppClassPointerStore<EarlyUpdate.XRUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "XRUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.XRUpdate>.NativeClassPtr);
			}

			// Token: 0x06003D70 RID: 15728 RVA: 0x00016EE8 File Offset: 0x000150E8
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.XRUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A51 RID: 2641
		[StructLayout(2)]
		public struct ScriptRunDelayedStartupFrame
		{
			// Token: 0x06003D71 RID: 15729 RVA: 0x00016EFA File Offset: 0x000150FA
			// Note: this type is marked as 'beforefieldinit'.
			static ScriptRunDelayedStartupFrame()
			{
				Il2CppClassPointerStore<EarlyUpdate.ScriptRunDelayedStartupFrame>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "ScriptRunDelayedStartupFrame");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.ScriptRunDelayedStartupFrame>.NativeClassPtr);
			}

			// Token: 0x06003D72 RID: 15730 RVA: 0x00016F1A File Offset: 0x0001511A
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.ScriptRunDelayedStartupFrame>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A52 RID: 2642
		[StructLayout(2)]
		public struct UpdateKinect
		{
			// Token: 0x06003D73 RID: 15731 RVA: 0x00016F2C File Offset: 0x0001512C
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateKinect()
			{
				Il2CppClassPointerStore<EarlyUpdate.UpdateKinect>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdateKinect");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdateKinect>.NativeClassPtr);
			}

			// Token: 0x06003D74 RID: 15732 RVA: 0x00016F4C File Offset: 0x0001514C
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdateKinect>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A53 RID: 2643
		[StructLayout(2)]
		public struct DeliverIosPlatformEvents
		{
			// Token: 0x06003D75 RID: 15733 RVA: 0x00016F5E File Offset: 0x0001515E
			// Note: this type is marked as 'beforefieldinit'.
			static DeliverIosPlatformEvents()
			{
				Il2CppClassPointerStore<EarlyUpdate.DeliverIosPlatformEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "DeliverIosPlatformEvents");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.DeliverIosPlatformEvents>.NativeClassPtr);
			}

			// Token: 0x06003D76 RID: 15734 RVA: 0x00016F7E File Offset: 0x0001517E
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.DeliverIosPlatformEvents>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A54 RID: 2644
		[StructLayout(2)]
		public struct DispatchEventQueueEvents
		{
			// Token: 0x06003D77 RID: 15735 RVA: 0x00016F90 File Offset: 0x00015190
			// Note: this type is marked as 'beforefieldinit'.
			static DispatchEventQueueEvents()
			{
				Il2CppClassPointerStore<EarlyUpdate.DispatchEventQueueEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "DispatchEventQueueEvents");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.DispatchEventQueueEvents>.NativeClassPtr);
			}

			// Token: 0x06003D78 RID: 15736 RVA: 0x00016FB0 File Offset: 0x000151B0
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.DispatchEventQueueEvents>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A55 RID: 2645
		[StructLayout(2)]
		public struct Physics2DEarlyUpdate
		{
			// Token: 0x06003D79 RID: 15737 RVA: 0x00016FC2 File Offset: 0x000151C2
			// Note: this type is marked as 'beforefieldinit'.
			static Physics2DEarlyUpdate()
			{
				Il2CppClassPointerStore<EarlyUpdate.Physics2DEarlyUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "Physics2DEarlyUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.Physics2DEarlyUpdate>.NativeClassPtr);
			}

			// Token: 0x06003D7A RID: 15738 RVA: 0x00016FE2 File Offset: 0x000151E2
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.Physics2DEarlyUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A56 RID: 2646
		[StructLayout(2)]
		public struct PhysicsResetInterpolatedTransformPosition
		{
			// Token: 0x06003D7B RID: 15739 RVA: 0x00016FF4 File Offset: 0x000151F4
			// Note: this type is marked as 'beforefieldinit'.
			static PhysicsResetInterpolatedTransformPosition()
			{
				Il2CppClassPointerStore<EarlyUpdate.PhysicsResetInterpolatedTransformPosition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "PhysicsResetInterpolatedTransformPosition");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.PhysicsResetInterpolatedTransformPosition>.NativeClassPtr);
			}

			// Token: 0x06003D7C RID: 15740 RVA: 0x00017014 File Offset: 0x00015214
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.PhysicsResetInterpolatedTransformPosition>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A57 RID: 2647
		[StructLayout(2)]
		public struct SpriteAtlasManagerUpdate
		{
			// Token: 0x06003D7D RID: 15741 RVA: 0x00017026 File Offset: 0x00015226
			// Note: this type is marked as 'beforefieldinit'.
			static SpriteAtlasManagerUpdate()
			{
				Il2CppClassPointerStore<EarlyUpdate.SpriteAtlasManagerUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "SpriteAtlasManagerUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.SpriteAtlasManagerUpdate>.NativeClassPtr);
			}

			// Token: 0x06003D7E RID: 15742 RVA: 0x00017046 File Offset: 0x00015246
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.SpriteAtlasManagerUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A58 RID: 2648
		[StructLayout(2)]
		public struct TangoUpdate
		{
			// Token: 0x06003D7F RID: 15743 RVA: 0x00017058 File Offset: 0x00015258
			// Note: this type is marked as 'beforefieldinit'.
			static TangoUpdate()
			{
				Il2CppClassPointerStore<EarlyUpdate.TangoUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "TangoUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.TangoUpdate>.NativeClassPtr);
			}

			// Token: 0x06003D80 RID: 15744 RVA: 0x00017078 File Offset: 0x00015278
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.TangoUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A59 RID: 2649
		[StructLayout(2)]
		public struct ARCoreUpdate
		{
			// Token: 0x06003D81 RID: 15745 RVA: 0x0001708A File Offset: 0x0001528A
			// Note: this type is marked as 'beforefieldinit'.
			static ARCoreUpdate()
			{
				Il2CppClassPointerStore<EarlyUpdate.ARCoreUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "ARCoreUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.ARCoreUpdate>.NativeClassPtr);
			}

			// Token: 0x06003D82 RID: 15746 RVA: 0x000170AA File Offset: 0x000152AA
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.ARCoreUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A5A RID: 2650
		[StructLayout(2)]
		public struct PerformanceAnalyticsUpdate
		{
			// Token: 0x06003D83 RID: 15747 RVA: 0x000170BC File Offset: 0x000152BC
			// Note: this type is marked as 'beforefieldinit'.
			static PerformanceAnalyticsUpdate()
			{
				Il2CppClassPointerStore<EarlyUpdate.PerformanceAnalyticsUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "PerformanceAnalyticsUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.PerformanceAnalyticsUpdate>.NativeClassPtr);
			}

			// Token: 0x06003D84 RID: 15748 RVA: 0x000170DC File Offset: 0x000152DC
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.PerformanceAnalyticsUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A5B RID: 2651
		public struct ProfilerStartFrame
		{
		}
	}
}
