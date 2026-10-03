using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Lighting
{
	// Token: 0x020003DC RID: 988
	public class LightExposureNode : MonoBehaviour
	{
		// Token: 0x0600586E RID: 22638 RVA: 0x001AD404 File Offset: 0x001AB604
		// Note: this type is marked as 'beforefieldinit'.
		static LightExposureNode()
		{
			Il2CppClassPointerStore<LightExposureNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Lighting", "LightExposureNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightExposureNode>.NativeClassPtr);
			LightExposureNode.NativeFieldInfoPtr_ambientExposure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExposureNode>.NativeClassPtr, "ambientExposure");
			LightExposureNode.NativeFieldInfoPtr_sources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExposureNode>.NativeClassPtr, "sources");
			LightExposureNode.NativeMethodInfoPtr_GetTotalExposure_Public_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightExposureNode>.NativeClassPtr, 100674909);
			LightExposureNode.NativeMethodInfoPtr_AddSource_Public_Void_UsableLightSource_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightExposureNode>.NativeClassPtr, 100674910);
			LightExposureNode.NativeMethodInfoPtr_RemoveSource_Public_Void_UsableLightSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightExposureNode>.NativeClassPtr, 100674911);
			LightExposureNode.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightExposureNode>.NativeClassPtr, 100674912);
			LightExposureNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightExposureNode>.NativeClassPtr, 100674913);
		}

		// Token: 0x0600586F RID: 22639 RVA: 0x001AD4C0 File Offset: 0x001AB6C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 193158, RefRangeEnd = 193160, XrefRangeStart = 193134, XrefRangeEnd = 193158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetTotalExposure(out float growSpeedMultiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &growSpeedMultiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightExposureNode.NativeMethodInfoPtr_GetTotalExposure_Public_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005870 RID: 22640 RVA: 0x001AD50C File Offset: 0x001AB70C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193170, RefRangeEnd = 193171, XrefRangeStart = 193160, XrefRangeEnd = 193170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSource(UsableLightSource source, float lightAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lightAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightExposureNode.NativeMethodInfoPtr_AddSource_Public_Void_UsableLightSource_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005871 RID: 22641 RVA: 0x001AD55C File Offset: 0x001AB75C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193175, RefRangeEnd = 193176, XrefRangeStart = 193171, XrefRangeEnd = 193175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveSource(UsableLightSource source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightExposureNode.NativeMethodInfoPtr_RemoveSource_Public_Void_UsableLightSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005872 RID: 22642 RVA: 0x001AD5A0 File Offset: 0x001AB7A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193176, XrefRangeEnd = 193181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightExposureNode.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005873 RID: 22643 RVA: 0x001AD5D4 File Offset: 0x001AB7D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193181, XrefRangeEnd = 193189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightExposureNode() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightExposureNode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightExposureNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005874 RID: 22644 RVA: 0x00029CE1 File Offset: 0x00027EE1
		public LightExposureNode(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B42 RID: 6978
		// (get) Token: 0x06005875 RID: 22645 RVA: 0x001AD610 File Offset: 0x001AB810
		// (set) Token: 0x06005876 RID: 22646 RVA: 0x00029CEA File Offset: 0x00027EEA
		public unsafe float ambientExposure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightExposureNode.NativeFieldInfoPtr_ambientExposure);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightExposureNode.NativeFieldInfoPtr_ambientExposure)) = value;
			}
		}

		// Token: 0x17001B43 RID: 6979
		// (get) Token: 0x06005877 RID: 22647 RVA: 0x001AD638 File Offset: 0x001AB838
		// (set) Token: 0x06005878 RID: 22648 RVA: 0x00029D05 File Offset: 0x00027F05
		public unsafe Dictionary<UsableLightSource, float> sources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightExposureNode.NativeFieldInfoPtr_sources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<UsableLightSource, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightExposureNode.NativeFieldInfoPtr_sources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003CD2 RID: 15570
		private static readonly IntPtr NativeFieldInfoPtr_ambientExposure;

		// Token: 0x04003CD3 RID: 15571
		private static readonly IntPtr NativeFieldInfoPtr_sources;

		// Token: 0x04003CD4 RID: 15572
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalExposure_Public_Single_byref_Single_0;

		// Token: 0x04003CD5 RID: 15573
		private static readonly IntPtr NativeMethodInfoPtr_AddSource_Public_Void_UsableLightSource_Single_0;

		// Token: 0x04003CD6 RID: 15574
		private static readonly IntPtr NativeMethodInfoPtr_RemoveSource_Public_Void_UsableLightSource_0;

		// Token: 0x04003CD7 RID: 15575
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04003CD8 RID: 15576
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
