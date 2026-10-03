using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Core.Weather;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Weather
{
	// Token: 0x020006D3 RID: 1747
	public class EnclosureVisualiser : MonoBehaviour
	{
		// Token: 0x0600A7D1 RID: 42961 RVA: 0x002C7874 File Offset: 0x002C5A74
		// Note: this type is marked as 'beforefieldinit'.
		static EnclosureVisualiser()
		{
			Il2CppClassPointerStore<EnclosureVisualiser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Weather", "EnclosureVisualiser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnclosureVisualiser>.NativeClassPtr);
			EnclosureVisualiser.NativeFieldInfoPtr__showEnclosures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnclosureVisualiser>.NativeClassPtr, "_showEnclosures");
			EnclosureVisualiser.NativeFieldInfoPtr_enclosures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnclosureVisualiser>.NativeClassPtr, "enclosures");
			EnclosureVisualiser.NativeMethodInfoPtr_FindEnclosures_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnclosureVisualiser>.NativeClassPtr, 100685574);
			EnclosureVisualiser.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnclosureVisualiser>.NativeClassPtr, 100685575);
			EnclosureVisualiser.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnclosureVisualiser>.NativeClassPtr, 100685576);
		}

		// Token: 0x0600A7D2 RID: 42962 RVA: 0x002C7908 File Offset: 0x002C5B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291298, XrefRangeEnd = 291311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FindEnclosures()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnclosureVisualiser.NativeMethodInfoPtr_FindEnclosures_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7D3 RID: 42963 RVA: 0x002C793C File Offset: 0x002C5B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291311, XrefRangeEnd = 291342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnclosureVisualiser.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7D4 RID: 42964 RVA: 0x002C7970 File Offset: 0x002C5B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291342, XrefRangeEnd = 291350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnclosureVisualiser() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnclosureVisualiser>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnclosureVisualiser.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7D5 RID: 42965 RVA: 0x0004C519 File Offset: 0x0004A719
		public EnclosureVisualiser(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700321C RID: 12828
		// (get) Token: 0x0600A7D6 RID: 42966 RVA: 0x002C79AC File Offset: 0x002C5BAC
		// (set) Token: 0x0600A7D7 RID: 42967 RVA: 0x0004C522 File Offset: 0x0004A722
		public unsafe bool _showEnclosures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnclosureVisualiser.NativeFieldInfoPtr__showEnclosures);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnclosureVisualiser.NativeFieldInfoPtr__showEnclosures)) = value;
			}
		}

		// Token: 0x1700321D RID: 12829
		// (get) Token: 0x0600A7D8 RID: 42968 RVA: 0x002C79D4 File Offset: 0x002C5BD4
		// (set) Token: 0x0600A7D9 RID: 42969 RVA: 0x0004C53D File Offset: 0x0004A73D
		public unsafe List<BasicEnclosure> enclosures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnclosureVisualiser.NativeFieldInfoPtr_enclosures);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BasicEnclosure>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnclosureVisualiser.NativeFieldInfoPtr_enclosures), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400740D RID: 29709
		private static readonly IntPtr NativeFieldInfoPtr__showEnclosures;

		// Token: 0x0400740E RID: 29710
		private static readonly IntPtr NativeFieldInfoPtr_enclosures;

		// Token: 0x0400740F RID: 29711
		private static readonly IntPtr NativeMethodInfoPtr_FindEnclosures_Private_Void_0;

		// Token: 0x04007410 RID: 29712
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04007411 RID: 29713
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
