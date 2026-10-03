using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x020004AF RID: 1199
	public class ACAccessoryReplicator : ACAssetPathReplicator<Accessory>
	{
		// Token: 0x06006D83 RID: 28035 RVA: 0x00033AF8 File Offset: 0x00031CF8
		// Note: this type is marked as 'beforefieldinit'.
		static ACAccessoryReplicator()
		{
			Il2CppClassPointerStore<ACAccessoryReplicator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "ACAccessoryReplicator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACAccessoryReplicator>.NativeClassPtr);
			ACAccessoryReplicator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACAccessoryReplicator>.NativeClassPtr, 100677602);
		}

		// Token: 0x06006D84 RID: 28036 RVA: 0x001F57B8 File Offset: 0x001F39B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222199, XrefRangeEnd = 222202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACAccessoryReplicator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACAccessoryReplicator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACAccessoryReplicator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D85 RID: 28037 RVA: 0x00033B31 File Offset: 0x00031D31
		public ACAccessoryReplicator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004B35 RID: 19253
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
