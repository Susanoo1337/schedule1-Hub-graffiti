using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200001A RID: 26
	public class EntityConfigurationData : MonoBehaviour
	{
		// Token: 0x0600014A RID: 330 RVA: 0x0007F648 File Offset: 0x0007D848
		// Note: this type is marked as 'beforefieldinit'.
		static EntityConfigurationData()
		{
			Il2CppClassPointerStore<EntityConfigurationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "EntityConfigurationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityConfigurationData>.NativeClassPtr);
			EntityConfigurationData.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfigurationData>.NativeClassPtr, 100663431);
			EntityConfigurationData.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfigurationData>.NativeClassPtr, 100663432);
			EntityConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfigurationData>.NativeClassPtr, 100663433);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0007F6B4 File Offset: 0x0007D8B4
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfigurationData.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0007F6E8 File Offset: 0x0007D8E8
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfigurationData.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0007F71C File Offset: 0x0007D91C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityConfigurationData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityConfigurationData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002B5E File Offset: 0x00000D5E
		public EntityConfigurationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
