using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004F8 RID: 1272
	public class RemoveChildColliders : MonoBehaviour
	{
		// Token: 0x06007312 RID: 29458 RVA: 0x00205690 File Offset: 0x00203890
		// Note: this type is marked as 'beforefieldinit'.
		static RemoveChildColliders()
		{
			Il2CppClassPointerStore<RemoveChildColliders>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "RemoveChildColliders");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoveChildColliders>.NativeClassPtr);
			RemoveChildColliders.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveChildColliders>.NativeClassPtr, 100678174);
			RemoveChildColliders.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveChildColliders>.NativeClassPtr, 100678175);
		}

		// Token: 0x06007313 RID: 29459 RVA: 0x002056E8 File Offset: 0x002038E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227118, XrefRangeEnd = 227126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoveChildColliders.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007314 RID: 29460 RVA: 0x0020571C File Offset: 0x0020391C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RemoveChildColliders() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoveChildColliders>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoveChildColliders.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007315 RID: 29461 RVA: 0x00036B47 File Offset: 0x00034D47
		public RemoveChildColliders(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004E90 RID: 20112
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004E91 RID: 20113
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
