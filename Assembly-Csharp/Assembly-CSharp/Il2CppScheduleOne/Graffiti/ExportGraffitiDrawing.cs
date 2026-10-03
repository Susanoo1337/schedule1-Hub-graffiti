using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Graffiti
{
	// Token: 0x02000368 RID: 872
	public class ExportGraffitiDrawing : MonoBehaviour
	{
		// Token: 0x0600499E RID: 18846 RVA: 0x00175ABC File Offset: 0x00173CBC
		// Note: this type is marked as 'beforefieldinit'.
		static ExportGraffitiDrawing()
		{
			Il2CppClassPointerStore<ExportGraffitiDrawing>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Graffiti", "ExportGraffitiDrawing");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExportGraffitiDrawing>.NativeClassPtr);
			ExportGraffitiDrawing.NativeFieldInfoPtr_ContainerPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExportGraffitiDrawing>.NativeClassPtr, "ContainerPath");
			ExportGraffitiDrawing.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExportGraffitiDrawing>.NativeClassPtr, 100672734);
		}

		// Token: 0x0600499F RID: 18847 RVA: 0x00175B14 File Offset: 0x00173D14
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExportGraffitiDrawing() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExportGraffitiDrawing>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExportGraffitiDrawing.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049A0 RID: 18848 RVA: 0x00023B9E File Offset: 0x00021D9E
		public ExportGraffitiDrawing(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700170E RID: 5902
		// (get) Token: 0x060049A1 RID: 18849 RVA: 0x00175B50 File Offset: 0x00173D50
		// (set) Token: 0x060049A2 RID: 18850 RVA: 0x00023BA7 File Offset: 0x00021DA7
		public unsafe static string ContainerPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExportGraffitiDrawing.NativeFieldInfoPtr_ContainerPath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExportGraffitiDrawing.NativeFieldInfoPtr_ContainerPath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003214 RID: 12820
		private static readonly IntPtr NativeFieldInfoPtr_ContainerPath;

		// Token: 0x04003215 RID: 12821
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
