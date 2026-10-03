using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Development.Experimental.OcclusionCulling
{
	// Token: 0x02000706 RID: 1798
	public class OcclusionData : ScriptableObject
	{
		// Token: 0x0600AD58 RID: 44376 RVA: 0x002D904C File Offset: 0x002D724C
		// Note: this type is marked as 'beforefieldinit'.
		static OcclusionData()
		{
			Il2CppClassPointerStore<OcclusionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Development.Experimental.OcclusionCulling", "OcclusionData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OcclusionData>.NativeClassPtr);
			OcclusionData.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionData>.NativeClassPtr, "Data");
			OcclusionData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionData>.NativeClassPtr, 100686184);
		}

		// Token: 0x0600AD59 RID: 44377 RVA: 0x002D90A4 File Offset: 0x002D72A4
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 79617, RefRangeEnd = 79648, XrefRangeStart = 79617, XrefRangeEnd = 79648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OcclusionData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OcclusionData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD5A RID: 44378 RVA: 0x0004F376 File Offset: 0x0004D576
		public OcclusionData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170033F5 RID: 13301
		// (get) Token: 0x0600AD5B RID: 44379 RVA: 0x002D90E0 File Offset: 0x002D72E0
		// (set) Token: 0x0600AD5C RID: 44380 RVA: 0x0004F37F File Offset: 0x0004D57F
		public unsafe Il2CppStructArray<long> Data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionData.NativeFieldInfoPtr_Data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<long>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionData.NativeFieldInfoPtr_Data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040077BD RID: 30653
		private static readonly IntPtr NativeFieldInfoPtr_Data;

		// Token: 0x040077BE RID: 30654
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
