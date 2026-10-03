using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x02000036 RID: 54
	public sealed class ReadOnlyAttribute : Attribute
	{
		// Token: 0x060001EB RID: 491 RVA: 0x0000301A File Offset: 0x0000121A
		// Note: this type is marked as 'beforefieldinit'.
		static ReadOnlyAttribute()
		{
			Il2CppClassPointerStore<ReadOnlyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "ReadOnlyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadOnlyAttribute>.NativeClassPtr);
			ReadOnlyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttribute>.NativeClassPtr, 100663437);
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0001D10C File Offset: 0x0001B30C
		[CallerCount(207)]
		[CachedScanResults(RefRangeStart = 360552, RefRangeEnd = 360759, XrefRangeStart = 360552, XrefRangeEnd = 360759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyAttribute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlyAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00003053 File Offset: 0x00001253
		public ReadOnlyAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
