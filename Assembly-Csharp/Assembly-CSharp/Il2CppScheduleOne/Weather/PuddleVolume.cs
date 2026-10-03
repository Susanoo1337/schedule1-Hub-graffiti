using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Weather
{
	// Token: 0x020006D9 RID: 1753
	public class PuddleVolume : MonoBehaviour
	{
		// Token: 0x0600A900 RID: 43264 RVA: 0x0004D02D File Offset: 0x0004B22D
		// Note: this type is marked as 'beforefieldinit'.
		static PuddleVolume()
		{
			Il2CppClassPointerStore<PuddleVolume>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Weather", "PuddleVolume");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PuddleVolume>.NativeClassPtr);
			PuddleVolume.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PuddleVolume>.NativeClassPtr, 100685698);
		}

		// Token: 0x0600A901 RID: 43265 RVA: 0x002CB16C File Offset: 0x002C936C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PuddleVolume() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PuddleVolume>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PuddleVolume.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A902 RID: 43266 RVA: 0x0004D066 File Offset: 0x0004B266
		public PuddleVolume(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040074CF RID: 29903
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
