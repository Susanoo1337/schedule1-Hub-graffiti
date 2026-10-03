using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.SceneManagement
{
	// Token: 0x020001B9 RID: 441
	[Serializable]
	[StructLayout(2)]
	public struct CreateSceneParameters
	{
		// Token: 0x0600206F RID: 8303 RVA: 0x00084764 File Offset: 0x00082964
		// Note: this type is marked as 'beforefieldinit'.
		static CreateSceneParameters()
		{
			Il2CppClassPointerStore<CreateSceneParameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.SceneManagement", "CreateSceneParameters");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateSceneParameters>.NativeClassPtr);
			CreateSceneParameters.NativeFieldInfoPtr_m_LocalPhysicsMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateSceneParameters>.NativeClassPtr, "m_LocalPhysicsMode");
			CreateSceneParameters.NativeMethodInfoPtr__ctor_Public_Void_LocalPhysicsMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateSceneParameters>.NativeClassPtr, 100666836);
		}

		// Token: 0x06002070 RID: 8304 RVA: 0x000847BC File Offset: 0x000829BC
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 54922, RefRangeEnd = 54944, XrefRangeStart = 54922, XrefRangeEnd = 54944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CreateSceneParameters(LocalPhysicsMode physicsMode)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref physicsMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateSceneParameters.NativeMethodInfoPtr__ctor_Public_Void_LocalPhysicsMode_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002071 RID: 8305 RVA: 0x0000EEEC File Offset: 0x0000D0EC
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CreateSceneParameters>.NativeClassPtr, ref this));
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06002072 RID: 8306 RVA: 0x000847F0 File Offset: 0x000829F0
		// (set) Token: 0x06002073 RID: 8307 RVA: 0x0000EEFE File Offset: 0x0000D0FE
		public LocalPhysicsMode localPhysicsMode
		{
			get
			{
				return this.m_LocalPhysicsMode;
			}
			set
			{
				this.m_LocalPhysicsMode = value;
			}
		}

		// Token: 0x04001A3B RID: 6715
		private static readonly IntPtr NativeFieldInfoPtr_m_LocalPhysicsMode;

		// Token: 0x04001A3C RID: 6716
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LocalPhysicsMode_0;

		// Token: 0x04001A3D RID: 6717
		[FieldOffset(0)]
		public LocalPhysicsMode m_LocalPhysicsMode;
	}
}
