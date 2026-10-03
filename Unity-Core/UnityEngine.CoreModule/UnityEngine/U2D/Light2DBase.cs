using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.U2D
{
	// Token: 0x02000177 RID: 375
	public class Light2DBase : MonoBehaviour
	{
		// Token: 0x06001CFF RID: 7423 RVA: 0x0000D9D9 File Offset: 0x0000BBD9
		// Note: this type is marked as 'beforefieldinit'.
		static Light2DBase()
		{
			Il2CppClassPointerStore<Light2DBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.U2D", "Light2DBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Light2DBase>.NativeClassPtr);
			Light2DBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2DBase>.NativeClassPtr, 100666433);
		}

		// Token: 0x06001D00 RID: 7424 RVA: 0x000783DC File Offset: 0x000765DC
		[CallerCount(1012)]
		[CachedScanResults(RefRangeStart = 1247777, RefRangeEnd = 1248789, XrefRangeStart = 1247777, XrefRangeEnd = 1248789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Light2DBase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Light2DBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2DBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D01 RID: 7425 RVA: 0x0000DA12 File Offset: 0x0000BC12
		public Light2DBase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040017E5 RID: 6117
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
