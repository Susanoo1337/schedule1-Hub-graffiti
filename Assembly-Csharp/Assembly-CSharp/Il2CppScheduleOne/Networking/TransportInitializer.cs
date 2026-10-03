using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Networking
{
	// Token: 0x020002A0 RID: 672
	public class TransportInitializer : MonoBehaviour
	{
		// Token: 0x06003332 RID: 13106 RVA: 0x00124AAC File Offset: 0x00122CAC
		// Note: this type is marked as 'beforefieldinit'.
		static TransportInitializer()
		{
			Il2CppClassPointerStore<TransportInitializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Networking", "TransportInitializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransportInitializer>.NativeClassPtr);
			TransportInitializer.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransportInitializer>.NativeClassPtr, 100669717);
			TransportInitializer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransportInitializer>.NativeClassPtr, 100669718);
		}

		// Token: 0x06003333 RID: 13107 RVA: 0x00124B04 File Offset: 0x00122D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137615, XrefRangeEnd = 137625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransportInitializer.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003334 RID: 13108 RVA: 0x00124B38 File Offset: 0x00122D38
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransportInitializer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransportInitializer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransportInitializer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003335 RID: 13109 RVA: 0x0001A3B7 File Offset: 0x000185B7
		public TransportInitializer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400222B RID: 8747
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x0400222C RID: 8748
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
