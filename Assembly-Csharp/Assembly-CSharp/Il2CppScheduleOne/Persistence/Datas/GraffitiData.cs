using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200020B RID: 523
	public class GraffitiData : SaveData
	{
		// Token: 0x06002E1F RID: 11807 RVA: 0x00114FB8 File Offset: 0x001131B8
		// Note: this type is marked as 'beforefieldinit'.
		static GraffitiData()
		{
			Il2CppClassPointerStore<GraffitiData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "GraffitiData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraffitiData>.NativeClassPtr);
			GraffitiData.NativeFieldInfoPtr_SpraySurfaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiData>.NativeClassPtr, "SpraySurfaces");
			GraffitiData.NativeMethodInfoPtr__ctor_Public_Void_List_1_WorldSpraySurfaceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiData>.NativeClassPtr, 100669359);
		}

		// Token: 0x06002E20 RID: 11808 RVA: 0x00115010 File Offset: 0x00113210
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 134750, RefRangeEnd = 134751, XrefRangeStart = 134741, XrefRangeEnd = 134750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraffitiData(List<WorldSpraySurfaceData> spraySurfaces) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraffitiData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spraySurfaces);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiData.NativeMethodInfoPtr__ctor_Public_Void_List_1_WorldSpraySurfaceData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E21 RID: 11809 RVA: 0x000175A2 File Offset: 0x000157A2
		public GraffitiData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EC6 RID: 3782
		// (get) Token: 0x06002E22 RID: 11810 RVA: 0x0011505C File Offset: 0x0011325C
		// (set) Token: 0x06002E23 RID: 11811 RVA: 0x000175AB File Offset: 0x000157AB
		public unsafe List<WorldSpraySurfaceData> SpraySurfaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiData.NativeFieldInfoPtr_SpraySurfaces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WorldSpraySurfaceData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiData.NativeFieldInfoPtr_SpraySurfaces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F86 RID: 8070
		private static readonly IntPtr NativeFieldInfoPtr_SpraySurfaces;

		// Token: 0x04001F87 RID: 8071
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_WorldSpraySurfaceData_0;
	}
}
