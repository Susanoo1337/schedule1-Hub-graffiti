using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine.Experimental.U2D
{
	// Token: 0x02000264 RID: 612
	public class SpriteRendererGroup : Object
	{
		// Token: 0x06002AC1 RID: 10945 RVA: 0x000A6AC8 File Offset: 0x000A4CC8
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteRendererGroup()
		{
			Il2CppClassPointerStore<SpriteRendererGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.U2D", "SpriteRendererGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteRendererGroup>.NativeClassPtr);
			SpriteRendererGroup.AddRenderersDelegateField = IL2CPP.ResolveICall<SpriteRendererGroup.AddRenderersDelegate>("UnityEngine.Experimental.U2D.SpriteRendererGroup::AddRenderers");
			SpriteRendererGroup.ClearDelegateField = IL2CPP.ResolveICall<SpriteRendererGroup.ClearDelegate>("UnityEngine.Experimental.U2D.SpriteRendererGroup::Clear");
		}

		// Token: 0x06002AC2 RID: 10946 RVA: 0x00012DD3 File Offset: 0x00010FD3
		public SpriteRendererGroup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06002AC3 RID: 10947 RVA: 0x00012DDC File Offset: 0x00010FDC
		public static void AddRenderers(Unity.Collections.NativeArray<SpriteIntermediateRendererInfo> renderers)
		{
			SpriteRendererGroup.AddRenderers(renderers.GetUnsafeReadOnlyPtr<SpriteIntermediateRendererInfo>(), renderers.Length);
		}

		// Token: 0x06002AC4 RID: 10948 RVA: 0x00012DF4 File Offset: 0x00010FF4
		public unsafe static void AddRenderers(void* renderers, int count)
		{
			SpriteRendererGroup.AddRenderersDelegateField(renderers, count);
		}

		// Token: 0x06002AC5 RID: 10949 RVA: 0x00012E02 File Offset: 0x00011002
		public static void Clear()
		{
			SpriteRendererGroup.ClearDelegateField();
		}

		// Token: 0x0400243F RID: 9279
		private static readonly SpriteRendererGroup.AddRenderersDelegate AddRenderersDelegateField;

		// Token: 0x04002440 RID: 9280
		private static readonly SpriteRendererGroup.ClearDelegate ClearDelegateField;

		// Token: 0x02000BE6 RID: 3046
		// (Invoke) Token: 0x06004091 RID: 16529
		private delegate void AddRenderersDelegate(IntPtr renderers, int count);

		// Token: 0x02000BE7 RID: 3047
		// (Invoke) Token: 0x06004093 RID: 16531
		private delegate void ClearDelegate();
	}
}
