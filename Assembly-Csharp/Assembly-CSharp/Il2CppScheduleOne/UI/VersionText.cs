using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000772 RID: 1906
	public class VersionText : MonoBehaviour
	{
		// Token: 0x0600B97B RID: 47483 RVA: 0x002FCC74 File Offset: 0x002FAE74
		// Note: this type is marked as 'beforefieldinit'.
		static VersionText()
		{
			Il2CppClassPointerStore<VersionText>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "VersionText");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VersionText>.NativeClassPtr);
			VersionText.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionText>.NativeClassPtr, 100687538);
			VersionText.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionText>.NativeClassPtr, 100687539);
		}

		// Token: 0x0600B97C RID: 47484 RVA: 0x002FCCCC File Offset: 0x002FAECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309914, XrefRangeEnd = 309925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionText.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B97D RID: 47485 RVA: 0x002FCD00 File Offset: 0x002FAF00
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VersionText() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VersionText>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionText.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B97E RID: 47486 RVA: 0x000565A3 File Offset: 0x000547A3
		public VersionText(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04007F3D RID: 32573
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04007F3E RID: 32574
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
