using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Experimental.Playables
{
	// Token: 0x02000276 RID: 630
	[StructLayout(2)]
	public struct TexturePlayableOutput
	{
		// Token: 0x06002B2C RID: 11052 RVA: 0x000A83EC File Offset: 0x000A65EC
		// Note: this type is marked as 'beforefieldinit'.
		static TexturePlayableOutput()
		{
			Il2CppClassPointerStore<TexturePlayableOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Playables", "TexturePlayableOutput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TexturePlayableOutput>.NativeClassPtr);
			TexturePlayableOutput.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePlayableOutput>.NativeClassPtr, "m_Handle");
			TexturePlayableOutput.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TexturePlayableOutput>.NativeClassPtr, 100667948);
			TexturePlayableOutput.InternalGetTargetDelegateField = IL2CPP.ResolveICall<TexturePlayableOutput.InternalGetTargetDelegate>("UnityEngine.Experimental.Playables.TexturePlayableOutput::InternalGetTarget");
			TexturePlayableOutput.InternalSetTargetDelegateField = IL2CPP.ResolveICall<TexturePlayableOutput.InternalSetTargetDelegate>("UnityEngine.Experimental.Playables.TexturePlayableOutput::InternalSetTarget");
		}

		// Token: 0x06002B2D RID: 11053 RVA: 0x000A8464 File Offset: 0x000A6664
		[CallerCount(47)]
		[CachedScanResults(RefRangeStart = 1223500, RefRangeEnd = 1223547, XrefRangeStart = 1223500, XrefRangeEnd = 1223547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEngine.Playables.PlayableOutputHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TexturePlayableOutput.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B2E RID: 11054 RVA: 0x00012FCC File Offset: 0x000111CC
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TexturePlayableOutput>.NativeClassPtr, ref this));
		}

		// Token: 0x06002B2F RID: 11055 RVA: 0x000A8494 File Offset: 0x000A6694
		public static TexturePlayableOutput Create(UnityEngine.Playables.PlayableGraph graph, string name, RenderTexture target)
		{
			UnityEngine.Playables.PlayableOutputHandle playableOutputHandle;
			bool flag = !TexturePlayableGraphExtensions.InternalCreateTextureOutput(ref graph, name, out playableOutputHandle);
			TexturePlayableOutput result;
			if (flag)
			{
				result = TexturePlayableOutput.Null;
			}
			else
			{
				TexturePlayableOutput texturePlayableOutput = new TexturePlayableOutput(playableOutputHandle);
				texturePlayableOutput.SetTarget(target);
				result = texturePlayableOutput;
			}
			return result;
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06002B30 RID: 11056 RVA: 0x000A84D4 File Offset: 0x000A66D4
		public static TexturePlayableOutput Null
		{
			get
			{
				return new TexturePlayableOutput(UnityEngine.Playables.PlayableOutputHandle.Null);
			}
		}

		// Token: 0x06002B31 RID: 11057 RVA: 0x000A84F0 File Offset: 0x000A66F0
		public static implicit operator UnityEngine.Playables.PlayableOutput(TexturePlayableOutput output)
		{
			return new UnityEngine.Playables.PlayableOutput(output.GetHandle());
		}

		// Token: 0x06002B32 RID: 11058 RVA: 0x000A8510 File Offset: 0x000A6710
		public static explicit operator TexturePlayableOutput(UnityEngine.Playables.PlayableOutput output)
		{
			return new TexturePlayableOutput(output.GetHandle());
		}

		// Token: 0x06002B33 RID: 11059 RVA: 0x000A8530 File Offset: 0x000A6730
		public RenderTexture GetTarget()
		{
			return TexturePlayableOutput.InternalGetTarget(ref this.m_Handle);
		}

		// Token: 0x06002B34 RID: 11060 RVA: 0x00012FDE File Offset: 0x000111DE
		public void SetTarget(RenderTexture value)
		{
			TexturePlayableOutput.InternalSetTarget(ref this.m_Handle, value);
		}

		// Token: 0x06002B35 RID: 11061 RVA: 0x000A8550 File Offset: 0x000A6750
		public static RenderTexture InternalGetTarget(ref UnityEngine.Playables.PlayableOutputHandle output)
		{
			IntPtr intPtr = TexturePlayableOutput.InternalGetTargetDelegateField(ref output);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
		}

		// Token: 0x06002B36 RID: 11062 RVA: 0x00012FEE File Offset: 0x000111EE
		public static void InternalSetTarget(ref UnityEngine.Playables.PlayableOutputHandle output, RenderTexture target)
		{
			TexturePlayableOutput.InternalSetTargetDelegateField(ref output, IL2CPP.Il2CppObjectBaseToPtr(target));
		}

		// Token: 0x04002529 RID: 9513
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x0400252A RID: 9514
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0;

		// Token: 0x0400252B RID: 9515
		[FieldOffset(0)]
		public UnityEngine.Playables.PlayableOutputHandle m_Handle;

		// Token: 0x0400252C RID: 9516
		private static readonly TexturePlayableOutput.InternalGetTargetDelegate InternalGetTargetDelegateField;

		// Token: 0x0400252D RID: 9517
		private static readonly TexturePlayableOutput.InternalSetTargetDelegate InternalSetTargetDelegateField;

		// Token: 0x02000BF6 RID: 3062
		// (Invoke) Token: 0x060040B8 RID: 16568
		private delegate IntPtr InternalGetTargetDelegate(IntPtr output);

		// Token: 0x02000BF7 RID: 3063
		// (Invoke) Token: 0x060040BA RID: 16570
		private delegate void InternalSetTargetDelegate(IntPtr output, IntPtr target);
	}
}
