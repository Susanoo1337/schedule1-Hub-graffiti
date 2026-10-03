using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppBeautify.Universal
{
	// Token: 0x0200008F RID: 143
	public class SphereAnimator : MonoBehaviour
	{
		// Token: 0x06000C25 RID: 3109 RVA: 0x000A2D4C File Offset: 0x000A0F4C
		// Note: this type is marked as 'beforefieldinit'.
		static SphereAnimator()
		{
			Il2CppClassPointerStore<SphereAnimator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Beautify.Universal", "SphereAnimator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SphereAnimator>.NativeClassPtr);
			SphereAnimator.NativeFieldInfoPtr_rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphereAnimator>.NativeClassPtr, "rb");
			SphereAnimator.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereAnimator>.NativeClassPtr, 100664819);
			SphereAnimator.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereAnimator>.NativeClassPtr, 100664820);
			SphereAnimator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereAnimator>.NativeClassPtr, 100664821);
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x000A2DCC File Offset: 0x000A0FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78203, XrefRangeEnd = 78207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereAnimator.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x000A2E00 File Offset: 0x000A1000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78207, XrefRangeEnd = 78215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereAnimator.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x000A2E34 File Offset: 0x000A1034
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SphereAnimator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SphereAnimator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereAnimator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x00007A4A File Offset: 0x00005C4A
		public SphereAnimator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06000C2A RID: 3114 RVA: 0x000A2E70 File Offset: 0x000A1070
		// (set) Token: 0x06000C2B RID: 3115 RVA: 0x00007A53 File Offset: 0x00005C53
		public unsafe Rigidbody rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SphereAnimator.NativeFieldInfoPtr_rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SphereAnimator.NativeFieldInfoPtr_rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000885 RID: 2181
		private static readonly IntPtr NativeFieldInfoPtr_rb;

		// Token: 0x04000886 RID: 2182
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000887 RID: 2183
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04000888 RID: 2184
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
