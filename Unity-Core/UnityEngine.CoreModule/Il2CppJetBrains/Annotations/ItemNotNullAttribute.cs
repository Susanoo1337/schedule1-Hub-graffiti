using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppJetBrains.Annotations
{
	// Token: 0x0200005D RID: 93
	public sealed class ItemNotNullAttribute : Attribute
	{
		// Token: 0x0600030E RID: 782 RVA: 0x000038E6 File Offset: 0x00001AE6
		// Note: this type is marked as 'beforefieldinit'.
		static ItemNotNullAttribute()
		{
			Il2CppClassPointerStore<ItemNotNullAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "JetBrains.Annotations", "ItemNotNullAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemNotNullAttribute>.NativeClassPtr);
			ItemNotNullAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemNotNullAttribute>.NativeClassPtr, 100663600);
		}

		// Token: 0x0600030F RID: 783 RVA: 0x000210D0 File Offset: 0x0001F2D0
		[CallerCount(207)]
		[CachedScanResults(RefRangeStart = 360552, RefRangeEnd = 360759, XrefRangeStart = 360552, XrefRangeEnd = 360759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemNotNullAttribute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemNotNullAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemNotNullAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0000391F File Offset: 0x00001B1F
		public ItemNotNullAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
