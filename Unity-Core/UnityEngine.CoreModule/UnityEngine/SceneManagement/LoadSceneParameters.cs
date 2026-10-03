using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.SceneManagement
{
	// Token: 0x020001B8 RID: 440
	[Serializable]
	[StructLayout(2)]
	public struct LoadSceneParameters
	{
		// Token: 0x06002068 RID: 8296 RVA: 0x00084604 File Offset: 0x00082804
		// Note: this type is marked as 'beforefieldinit'.
		static LoadSceneParameters()
		{
			Il2CppClassPointerStore<LoadSceneParameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.SceneManagement", "LoadSceneParameters");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadSceneParameters>.NativeClassPtr);
			LoadSceneParameters.NativeFieldInfoPtr_m_LoadSceneMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadSceneParameters>.NativeClassPtr, "m_LoadSceneMode");
			LoadSceneParameters.NativeFieldInfoPtr_m_LocalPhysicsMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadSceneParameters>.NativeClassPtr, "m_LocalPhysicsMode");
			LoadSceneParameters.NativeMethodInfoPtr_set_loadSceneMode_Public_set_Void_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadSceneParameters>.NativeClassPtr, 100666833);
			LoadSceneParameters.NativeMethodInfoPtr_set_localPhysicsMode_Public_set_Void_LocalPhysicsMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadSceneParameters>.NativeClassPtr, 100666834);
			LoadSceneParameters.NativeMethodInfoPtr__ctor_Public_Void_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadSceneParameters>.NativeClassPtr, 100666835);
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x0600206D RID: 8301 RVA: 0x00084734 File Offset: 0x00082934
		// (set) Token: 0x06002069 RID: 8297 RVA: 0x00084698 File Offset: 0x00082898
		public unsafe LoadSceneMode loadSceneMode
		{
			get
			{
				return this.m_LoadSceneMode;
			}
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 54922, RefRangeEnd = 54944, XrefRangeStart = 54922, XrefRangeEnd = 54944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadSceneParameters.NativeMethodInfoPtr_set_loadSceneMode_Public_set_Void_LoadSceneMode_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x0600206E RID: 8302 RVA: 0x0008474C File Offset: 0x0008294C
		// (set) Token: 0x0600206A RID: 8298 RVA: 0x000846CC File Offset: 0x000828CC
		public unsafe LocalPhysicsMode localPhysicsMode
		{
			get
			{
				return this.m_LocalPhysicsMode;
			}
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 54944, RefRangeEnd = 54959, XrefRangeStart = 54944, XrefRangeEnd = 54959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadSceneParameters.NativeMethodInfoPtr_set_localPhysicsMode_Public_set_Void_LocalPhysicsMode_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600206B RID: 8299 RVA: 0x00084700 File Offset: 0x00082900
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 54612, RefRangeEnd = 54614, XrefRangeStart = 54612, XrefRangeEnd = 54614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadSceneParameters(LoadSceneMode mode)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadSceneParameters.NativeMethodInfoPtr__ctor_Public_Void_LoadSceneMode_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600206C RID: 8300 RVA: 0x0000EEDA File Offset: 0x0000D0DA
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LoadSceneParameters>.NativeClassPtr, ref this));
		}

		// Token: 0x04001A34 RID: 6708
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadSceneMode;

		// Token: 0x04001A35 RID: 6709
		private static readonly IntPtr NativeFieldInfoPtr_m_LocalPhysicsMode;

		// Token: 0x04001A36 RID: 6710
		private static readonly IntPtr NativeMethodInfoPtr_set_loadSceneMode_Public_set_Void_LoadSceneMode_0;

		// Token: 0x04001A37 RID: 6711
		private static readonly IntPtr NativeMethodInfoPtr_set_localPhysicsMode_Public_set_Void_LocalPhysicsMode_0;

		// Token: 0x04001A38 RID: 6712
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LoadSceneMode_0;

		// Token: 0x04001A39 RID: 6713
		[FieldOffset(0)]
		public LoadSceneMode m_LoadSceneMode;

		// Token: 0x04001A3A RID: 6714
		[FieldOffset(4)]
		public LocalPhysicsMode m_LocalPhysicsMode;
	}
}
