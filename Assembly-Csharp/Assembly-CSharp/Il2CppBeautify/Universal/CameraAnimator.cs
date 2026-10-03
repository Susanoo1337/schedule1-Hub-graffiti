using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppBeautify.Universal
{
	// Token: 0x0200008D RID: 141
	public class CameraAnimator : MonoBehaviour
	{
		// Token: 0x06000C07 RID: 3079 RVA: 0x000A2858 File Offset: 0x000A0A58
		// Note: this type is marked as 'beforefieldinit'.
		static CameraAnimator()
		{
			Il2CppClassPointerStore<CameraAnimator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Beautify.Universal", "CameraAnimator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraAnimator>.NativeClassPtr);
			CameraAnimator.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraAnimator>.NativeClassPtr, 100664810);
			CameraAnimator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraAnimator>.NativeClassPtr, 100664811);
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x000A28B0 File Offset: 0x000A0AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78138, XrefRangeEnd = 78141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraAnimator.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x000A28E4 File Offset: 0x000A0AE4
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraAnimator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraAnimator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraAnimator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x00007931 File Offset: 0x00005B31
		public CameraAnimator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000874 RID: 2164
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000875 RID: 2165
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
