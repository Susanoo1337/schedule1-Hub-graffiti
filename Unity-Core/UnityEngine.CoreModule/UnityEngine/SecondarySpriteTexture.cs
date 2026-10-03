using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000173 RID: 371
	[Serializable]
	public sealed class SecondarySpriteTexture : ValueType
	{
		// Token: 0x06001CB1 RID: 7345 RVA: 0x00076E8C File Offset: 0x0007508C
		// Note: this type is marked as 'beforefieldinit'.
		static SecondarySpriteTexture()
		{
			Il2CppClassPointerStore<SecondarySpriteTexture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "SecondarySpriteTexture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SecondarySpriteTexture>.NativeClassPtr);
			SecondarySpriteTexture.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecondarySpriteTexture>.NativeClassPtr, "name");
			SecondarySpriteTexture.NativeFieldInfoPtr_texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecondarySpriteTexture>.NativeClassPtr, "texture");
		}

		// Token: 0x06001CB2 RID: 7346 RVA: 0x0000D85C File Offset: 0x0000BA5C
		public SecondarySpriteTexture(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x0000D865 File Offset: 0x0000BA65
		public SecondarySpriteTexture() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SecondarySpriteTexture>.NativeClassPtr))
		{
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06001CB4 RID: 7348 RVA: 0x00076EE4 File Offset: 0x000750E4
		// (set) Token: 0x06001CB5 RID: 7349 RVA: 0x0000D877 File Offset: 0x0000BA77
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecondarySpriteTexture.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecondarySpriteTexture.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06001CB6 RID: 7350 RVA: 0x00076F0C File Offset: 0x0007510C
		// (set) Token: 0x06001CB7 RID: 7351 RVA: 0x0000D896 File Offset: 0x0000BA96
		public unsafe Texture2D texture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecondarySpriteTexture.NativeFieldInfoPtr_texture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecondarySpriteTexture.NativeFieldInfoPtr_texture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040017AD RID: 6061
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x040017AE RID: 6062
		private static readonly IntPtr NativeFieldInfoPtr_texture;
	}
}
