using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004CE RID: 1230
	public class RoadCracksRandomizer : MonoBehaviour
	{
		// Token: 0x060070DB RID: 28891 RVA: 0x001FE9D8 File Offset: 0x001FCBD8
		// Note: this type is marked as 'beforefieldinit'.
		static RoadCracksRandomizer()
		{
			Il2CppClassPointerStore<RoadCracksRandomizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "RoadCracksRandomizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoadCracksRandomizer>.NativeClassPtr);
			RoadCracksRandomizer.NativeFieldInfoPtr_Cracks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCracksRandomizer>.NativeClassPtr, "Cracks");
			RoadCracksRandomizer.NativeFieldInfoPtr_MinCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCracksRandomizer>.NativeClassPtr, "MinCount");
			RoadCracksRandomizer.NativeFieldInfoPtr_MaxCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCracksRandomizer>.NativeClassPtr, "MaxCount");
			RoadCracksRandomizer.NativeMethodInfoPtr_Randomize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCracksRandomizer>.NativeClassPtr, 100677890);
			RoadCracksRandomizer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCracksRandomizer>.NativeClassPtr, 100677891);
		}

		// Token: 0x060070DC RID: 28892 RVA: 0x001FEA6C File Offset: 0x001FCC6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225037, XrefRangeEnd = 225062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Randomize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCracksRandomizer.NativeMethodInfoPtr_Randomize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070DD RID: 28893 RVA: 0x001FEAA0 File Offset: 0x001FCCA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225062, XrefRangeEnd = 225063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RoadCracksRandomizer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoadCracksRandomizer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCracksRandomizer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070DE RID: 28894 RVA: 0x00035ACB File Offset: 0x00033CCB
		public RoadCracksRandomizer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170022E4 RID: 8932
		// (get) Token: 0x060070DF RID: 28895 RVA: 0x001FEADC File Offset: 0x001FCCDC
		// (set) Token: 0x060070E0 RID: 28896 RVA: 0x00035AD4 File Offset: 0x00033CD4
		public unsafe Il2CppReferenceArray<Transform> Cracks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCracksRandomizer.NativeFieldInfoPtr_Cracks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCracksRandomizer.NativeFieldInfoPtr_Cracks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022E5 RID: 8933
		// (get) Token: 0x060070E1 RID: 28897 RVA: 0x001FEB0C File Offset: 0x001FCD0C
		// (set) Token: 0x060070E2 RID: 28898 RVA: 0x00035AF3 File Offset: 0x00033CF3
		public unsafe int MinCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCracksRandomizer.NativeFieldInfoPtr_MinCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCracksRandomizer.NativeFieldInfoPtr_MinCount)) = value;
			}
		}

		// Token: 0x170022E6 RID: 8934
		// (get) Token: 0x060070E3 RID: 28899 RVA: 0x001FEB34 File Offset: 0x001FCD34
		// (set) Token: 0x060070E4 RID: 28900 RVA: 0x00035B0E File Offset: 0x00033D0E
		public unsafe int MaxCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCracksRandomizer.NativeFieldInfoPtr_MaxCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCracksRandomizer.NativeFieldInfoPtr_MaxCount)) = value;
			}
		}

		// Token: 0x04004D30 RID: 19760
		private static readonly IntPtr NativeFieldInfoPtr_Cracks;

		// Token: 0x04004D31 RID: 19761
		private static readonly IntPtr NativeFieldInfoPtr_MinCount;

		// Token: 0x04004D32 RID: 19762
		private static readonly IntPtr NativeFieldInfoPtr_MaxCount;

		// Token: 0x04004D33 RID: 19763
		private static readonly IntPtr NativeMethodInfoPtr_Randomize_Private_Void_0;

		// Token: 0x04004D34 RID: 19764
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
