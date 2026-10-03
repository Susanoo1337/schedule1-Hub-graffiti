using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Tiles
{
	// Token: 0x02000117 RID: 279
	public class IndoorTile : Tile
	{
		// Token: 0x06001B25 RID: 6949 RVA: 0x0000EC0E File Offset: 0x0000CE0E
		// Note: this type is marked as 'beforefieldinit'.
		static IndoorTile()
		{
			Il2CppClassPointerStore<IndoorTile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tiles", "IndoorTile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IndoorTile>.NativeClassPtr);
			IndoorTile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndoorTile>.NativeClassPtr, 100666910);
		}

		// Token: 0x06001B26 RID: 6950 RVA: 0x000D4B60 File Offset: 0x000D2D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101415, XrefRangeEnd = 101430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IndoorTile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IndoorTile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndoorTile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B27 RID: 6951 RVA: 0x0000EC47 File Offset: 0x0000CE47
		public IndoorTile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040012CF RID: 4815
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
