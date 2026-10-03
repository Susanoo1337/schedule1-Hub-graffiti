using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004E3 RID: 1251
	public class ForcePlayerCrouch : MonoBehaviour
	{
		// Token: 0x060071E1 RID: 29153 RVA: 0x002019E0 File Offset: 0x001FFBE0
		// Note: this type is marked as 'beforefieldinit'.
		static ForcePlayerCrouch()
		{
			Il2CppClassPointerStore<ForcePlayerCrouch>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "ForcePlayerCrouch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForcePlayerCrouch>.NativeClassPtr);
			ForcePlayerCrouch.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForcePlayerCrouch>.NativeClassPtr, 100678032);
			ForcePlayerCrouch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForcePlayerCrouch>.NativeClassPtr, 100678033);
		}

		// Token: 0x060071E2 RID: 29154 RVA: 0x00201A38 File Offset: 0x001FFC38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225959, XrefRangeEnd = 225979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForcePlayerCrouch.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071E3 RID: 29155 RVA: 0x00201A7C File Offset: 0x001FFC7C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ForcePlayerCrouch() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForcePlayerCrouch>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForcePlayerCrouch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071E4 RID: 29156 RVA: 0x000362C7 File Offset: 0x000344C7
		public ForcePlayerCrouch(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004DD0 RID: 19920
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0;

		// Token: 0x04004DD1 RID: 19921
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
