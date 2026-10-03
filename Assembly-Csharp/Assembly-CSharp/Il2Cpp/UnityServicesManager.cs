using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000018 RID: 24
	public class UnityServicesManager : MonoBehaviour
	{
		// Token: 0x06000139 RID: 313 RVA: 0x0007F2C0 File Offset: 0x0007D4C0
		// Note: this type is marked as 'beforefieldinit'.
		static UnityServicesManager()
		{
			Il2CppClassPointerStore<UnityServicesManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UnityServicesManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityServicesManager>.NativeClassPtr);
			UnityServicesManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityServicesManager>.NativeClassPtr, 100663417);
			UnityServicesManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityServicesManager>.NativeClassPtr, 100663418);
			UnityServicesManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityServicesManager>.NativeClassPtr, 100663419);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0007F32C File Offset: 0x0007D52C
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityServicesManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0007F360 File Offset: 0x0007D560
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityServicesManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x0007F394 File Offset: 0x0007D594
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityServicesManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityServicesManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityServicesManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002AEF File Offset: 0x00000CEF
		public UnityServicesManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
