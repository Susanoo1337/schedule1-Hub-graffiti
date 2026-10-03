using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x020004B3 RID: 1203
	public class ACFaceLayerReplicator : ACAssetPathReplicator<FaceLayer>
	{
		// Token: 0x06006D96 RID: 28054 RVA: 0x00033BCC File Offset: 0x00031DCC
		// Note: this type is marked as 'beforefieldinit'.
		static ACFaceLayerReplicator()
		{
			Il2CppClassPointerStore<ACFaceLayerReplicator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "ACFaceLayerReplicator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACFaceLayerReplicator>.NativeClassPtr);
			ACFaceLayerReplicator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACFaceLayerReplicator>.NativeClassPtr, 100677609);
		}

		// Token: 0x06006D97 RID: 28055 RVA: 0x001F5B0C File Offset: 0x001F3D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222227, XrefRangeEnd = 222230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACFaceLayerReplicator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACFaceLayerReplicator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACFaceLayerReplicator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D98 RID: 28056 RVA: 0x00033C05 File Offset: 0x00031E05
		public ACFaceLayerReplicator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004B3E RID: 19262
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
