using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x020000B0 RID: 176
	public sealed class Skybox : Behaviour
	{
		// Token: 0x06000E85 RID: 3717 RVA: 0x00041C70 File Offset: 0x0003FE70
		// Note: this type is marked as 'beforefieldinit'.
		static Skybox()
		{
			Il2CppClassPointerStore<Skybox>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Skybox");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Skybox>.NativeClassPtr);
			Skybox.NativeMethodInfoPtr_get_material_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skybox>.NativeClassPtr, 100664608);
			Skybox.set_materialDelegateField = IL2CPP.ResolveICall<Skybox.set_materialDelegate>("UnityEngine.Skybox::set_material");
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000E86 RID: 3718 RVA: 0x00041CC4 File Offset: 0x0003FEC4
		// (set) Token: 0x06000E88 RID: 3720 RVA: 0x00008C78 File Offset: 0x00006E78
		public unsafe Material material
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1238117, RefRangeEnd = 1238118, XrefRangeStart = 1238115, XrefRangeEnd = 1238117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skybox.NativeMethodInfoPtr_get_material_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			set
			{
				Skybox.set_materialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x00008C6F File Offset: 0x00006E6F
		public Skybox(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000AB5 RID: 2741
		private static readonly IntPtr NativeMethodInfoPtr_get_material_Public_get_Material_0;

		// Token: 0x04000AB6 RID: 2742
		private static readonly Skybox.set_materialDelegate set_materialDelegateField;

		// Token: 0x02000741 RID: 1857
		// (Invoke) Token: 0x06003736 RID: 14134
		private delegate void set_materialDelegate(IntPtr @this, IntPtr value);
	}
}
