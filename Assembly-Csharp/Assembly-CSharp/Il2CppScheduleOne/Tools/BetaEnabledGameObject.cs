using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004D2 RID: 1234
	public class BetaEnabledGameObject : MonoBehaviour
	{
		// Token: 0x06007106 RID: 28934 RVA: 0x001FF0C0 File Offset: 0x001FD2C0
		// Note: this type is marked as 'beforefieldinit'.
		static BetaEnabledGameObject()
		{
			Il2CppClassPointerStore<BetaEnabledGameObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "BetaEnabledGameObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BetaEnabledGameObject>.NativeClassPtr);
			BetaEnabledGameObject.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetaEnabledGameObject>.NativeClassPtr, 100677899);
			BetaEnabledGameObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetaEnabledGameObject>.NativeClassPtr, 100677900);
		}

		// Token: 0x06007107 RID: 28935 RVA: 0x001FF118 File Offset: 0x001FD318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225097, XrefRangeEnd = 225101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BetaEnabledGameObject.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007108 RID: 28936 RVA: 0x001FF14C File Offset: 0x001FD34C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BetaEnabledGameObject() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BetaEnabledGameObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BetaEnabledGameObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007109 RID: 28937 RVA: 0x00035C6B File Offset: 0x00033E6B
		public BetaEnabledGameObject(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004D4C RID: 19788
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004D4D RID: 19789
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
