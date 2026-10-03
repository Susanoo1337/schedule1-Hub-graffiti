using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004D6 RID: 1238
	public class CleanNodeLinks : MonoBehaviour
	{
		// Token: 0x06007138 RID: 28984 RVA: 0x001FF968 File Offset: 0x001FDB68
		// Note: this type is marked as 'beforefieldinit'.
		static CleanNodeLinks()
		{
			Il2CppClassPointerStore<CleanNodeLinks>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "CleanNodeLinks");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CleanNodeLinks>.NativeClassPtr);
			CleanNodeLinks.NativeMethodInfoPtr_Clean_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanNodeLinks>.NativeClassPtr, 100677921);
			CleanNodeLinks.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanNodeLinks>.NativeClassPtr, 100677922);
		}

		// Token: 0x06007139 RID: 28985 RVA: 0x001FF9C0 File Offset: 0x001FDBC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225204, XrefRangeEnd = 225223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clean()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanNodeLinks.NativeMethodInfoPtr_Clean_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600713A RID: 28986 RVA: 0x001FF9F4 File Offset: 0x001FDBF4
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CleanNodeLinks() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CleanNodeLinks>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanNodeLinks.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600713B RID: 28987 RVA: 0x00035DD6 File Offset: 0x00033FD6
		public CleanNodeLinks(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004D69 RID: 19817
		private static readonly IntPtr NativeMethodInfoPtr_Clean_Public_Void_0;

		// Token: 0x04004D6A RID: 19818
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
