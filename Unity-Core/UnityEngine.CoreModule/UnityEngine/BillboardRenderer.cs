using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x0200008D RID: 141
	public sealed class BillboardRenderer : Renderer
	{
		// Token: 0x06000796 RID: 1942 RVA: 0x0002F558 File Offset: 0x0002D758
		// Note: this type is marked as 'beforefieldinit'.
		static BillboardRenderer()
		{
			Il2CppClassPointerStore<BillboardRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "BillboardRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BillboardRenderer>.NativeClassPtr);
			BillboardRenderer.get_billboardDelegateField = IL2CPP.ResolveICall<BillboardRenderer.get_billboardDelegate>("UnityEngine.BillboardRenderer::get_billboard");
			BillboardRenderer.set_billboardDelegateField = IL2CPP.ResolveICall<BillboardRenderer.set_billboardDelegate>("UnityEngine.BillboardRenderer::set_billboard");
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x000055D7 File Offset: 0x000037D7
		public BillboardRenderer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000798 RID: 1944 RVA: 0x0002F5A8 File Offset: 0x0002D7A8
		// (set) Token: 0x06000799 RID: 1945 RVA: 0x000055E0 File Offset: 0x000037E0
		public BillboardAsset billboard
		{
			get
			{
				IntPtr intPtr = BillboardRenderer.get_billboardDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BillboardAsset>(intPtr2) : null;
			}
			set
			{
				BillboardRenderer.set_billboardDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000631 RID: 1585
		private static readonly BillboardRenderer.get_billboardDelegate get_billboardDelegateField;

		// Token: 0x04000632 RID: 1586
		private static readonly BillboardRenderer.set_billboardDelegate set_billboardDelegateField;

		// Token: 0x0200050F RID: 1295
		// (Invoke) Token: 0x060032D3 RID: 13011
		private delegate IntPtr get_billboardDelegate(IntPtr @this);

		// Token: 0x02000510 RID: 1296
		// (Invoke) Token: 0x060032D5 RID: 13013
		private delegate void set_billboardDelegate(IntPtr @this, IntPtr value);
	}
}
