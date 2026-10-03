using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x020004B1 RID: 1201
	public class ACAvatarLayerReplicator : ACAssetPathReplicator<AvatarLayer>
	{
		// Token: 0x06006D8D RID: 28045 RVA: 0x00033B62 File Offset: 0x00031D62
		// Note: this type is marked as 'beforefieldinit'.
		static ACAvatarLayerReplicator()
		{
			Il2CppClassPointerStore<ACAvatarLayerReplicator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "ACAvatarLayerReplicator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACAvatarLayerReplicator>.NativeClassPtr);
			ACAvatarLayerReplicator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACAvatarLayerReplicator>.NativeClassPtr, 100677606);
		}

		// Token: 0x06006D8E RID: 28046 RVA: 0x001F59A8 File Offset: 0x001F3BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222214, XrefRangeEnd = 222217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACAvatarLayerReplicator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACAvatarLayerReplicator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACAvatarLayerReplicator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D8F RID: 28047 RVA: 0x00033B9B File Offset: 0x00031D9B
		public ACAvatarLayerReplicator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004B3A RID: 19258
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
