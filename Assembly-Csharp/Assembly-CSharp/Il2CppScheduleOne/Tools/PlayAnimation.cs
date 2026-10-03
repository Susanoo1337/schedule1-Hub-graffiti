using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004F3 RID: 1267
	public class PlayAnimation : MonoBehaviour
	{
		// Token: 0x060072C9 RID: 29385 RVA: 0x0020488C File Offset: 0x00202A8C
		// Note: this type is marked as 'beforefieldinit'.
		static PlayAnimation()
		{
			Il2CppClassPointerStore<PlayAnimation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "PlayAnimation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayAnimation>.NativeClassPtr);
			PlayAnimation.NativeMethodInfoPtr_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayAnimation>.NativeClassPtr, 100678147);
			PlayAnimation.NativeMethodInfoPtr_Play_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayAnimation>.NativeClassPtr, 100678148);
			PlayAnimation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayAnimation>.NativeClassPtr, 100678149);
		}

		// Token: 0x060072CA RID: 29386 RVA: 0x002048F8 File Offset: 0x00202AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226817, XrefRangeEnd = 226822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayAnimation.NativeMethodInfoPtr_Play_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072CB RID: 29387 RVA: 0x0020492C File Offset: 0x00202B2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 226827, RefRangeEnd = 226828, XrefRangeStart = 226822, XrefRangeEnd = 226827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play(string animationName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(animationName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayAnimation.NativeMethodInfoPtr_Play_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072CC RID: 29388 RVA: 0x00204970 File Offset: 0x00202B70
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayAnimation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayAnimation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayAnimation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072CD RID: 29389 RVA: 0x0003691D File Offset: 0x00034B1D
		public PlayAnimation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004E63 RID: 20067
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_0;

		// Token: 0x04004E64 RID: 20068
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_String_0;

		// Token: 0x04004E65 RID: 20069
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
