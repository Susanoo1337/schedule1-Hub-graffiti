using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020002F5 RID: 757
	public class TransitRouteMaterial : MonoBehaviour
	{
		// Token: 0x06003BFB RID: 15355 RVA: 0x001457BC File Offset: 0x001439BC
		// Note: this type is marked as 'beforefieldinit'.
		static TransitRouteMaterial()
		{
			Il2CppClassPointerStore<TransitRouteMaterial>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "TransitRouteMaterial");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransitRouteMaterial>.NativeClassPtr);
			TransitRouteMaterial.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRouteMaterial>.NativeClassPtr, 100670987);
			TransitRouteMaterial.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRouteMaterial>.NativeClassPtr, 100670988);
		}

		// Token: 0x06003BFC RID: 15356 RVA: 0x00145814 File Offset: 0x00143A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150794, XrefRangeEnd = 150803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRouteMaterial.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BFD RID: 15357 RVA: 0x00145848 File Offset: 0x00143A48
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransitRouteMaterial() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransitRouteMaterial>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRouteMaterial.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BFE RID: 15358 RVA: 0x0001DEB2 File Offset: 0x0001C0B2
		public TransitRouteMaterial(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400287B RID: 10363
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400287C RID: 10364
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
