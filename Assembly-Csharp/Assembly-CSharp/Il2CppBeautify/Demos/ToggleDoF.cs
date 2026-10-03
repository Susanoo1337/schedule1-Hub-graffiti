using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppBeautify.Demos
{
	// Token: 0x0200008C RID: 140
	public class ToggleDoF : MonoBehaviour
	{
		// Token: 0x06000C03 RID: 3075 RVA: 0x000A2790 File Offset: 0x000A0990
		// Note: this type is marked as 'beforefieldinit'.
		static ToggleDoF()
		{
			Il2CppClassPointerStore<ToggleDoF>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Beautify.Demos", "ToggleDoF");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleDoF>.NativeClassPtr);
			ToggleDoF.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleDoF>.NativeClassPtr, 100664808);
			ToggleDoF.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleDoF>.NativeClassPtr, 100664809);
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x000A27E8 File Offset: 0x000A09E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78132, XrefRangeEnd = 78138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleDoF.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x000A281C File Offset: 0x000A0A1C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ToggleDoF() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleDoF>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleDoF.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x00007928 File Offset: 0x00005B28
		public ToggleDoF(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000872 RID: 2162
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000873 RID: 2163
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
