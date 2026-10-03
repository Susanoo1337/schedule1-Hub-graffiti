using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x0200049E RID: 1182
	[Serializable]
	public class FaceLayer : AvatarLayer
	{
		// Token: 0x06006C5E RID: 27742 RVA: 0x00033181 File Offset: 0x00031381
		// Note: this type is marked as 'beforefieldinit'.
		static FaceLayer()
		{
			Il2CppClassPointerStore<FaceLayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "FaceLayer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FaceLayer>.NativeClassPtr);
			FaceLayer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceLayer>.NativeClassPtr, 100677456);
		}

		// Token: 0x06006C5F RID: 27743 RVA: 0x001F1F20 File Offset: 0x001F0120
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 79617, RefRangeEnd = 79648, XrefRangeStart = 79617, XrefRangeEnd = 79648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FaceLayer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FaceLayer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceLayer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C60 RID: 27744 RVA: 0x000331BA File Offset: 0x000313BA
		public FaceLayer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004A82 RID: 19074
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
