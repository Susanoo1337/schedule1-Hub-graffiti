using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000092 RID: 146
	public sealed class DisplayInfo : ValueType
	{
		// Token: 0x060007E2 RID: 2018 RVA: 0x0002FFFC File Offset: 0x0002E1FC
		// Note: this type is marked as 'beforefieldinit'.
		static DisplayInfo()
		{
			Il2CppClassPointerStore<DisplayInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "DisplayInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisplayInfo>.NativeClassPtr);
			DisplayInfo.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayInfo>.NativeClassPtr, "handle");
			DisplayInfo.NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayInfo>.NativeClassPtr, "width");
			DisplayInfo.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayInfo>.NativeClassPtr, "height");
			DisplayInfo.NativeFieldInfoPtr_refreshRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayInfo>.NativeClassPtr, "refreshRate");
			DisplayInfo.NativeFieldInfoPtr_workArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayInfo>.NativeClassPtr, "workArea");
			DisplayInfo.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayInfo>.NativeClassPtr, "name");
			DisplayInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DisplayInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayInfo>.NativeClassPtr, 100664141);
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x000300B8 File Offset: 0x0002E2B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233660, XrefRangeEnd = 1233662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(DisplayInfo other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DisplayInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x00005800 File Offset: 0x00003A00
		public DisplayInfo(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x00005809 File Offset: 0x00003A09
		public DisplayInfo() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisplayInfo>.NativeClassPtr))
		{
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060007E6 RID: 2022 RVA: 0x00030110 File Offset: 0x0002E310
		// (set) Token: 0x060007E7 RID: 2023 RVA: 0x0000581B File Offset: 0x00003A1B
		public unsafe ulong handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayInfo.NativeFieldInfoPtr_handle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayInfo.NativeFieldInfoPtr_handle)) = value;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060007E8 RID: 2024 RVA: 0x00030138 File Offset: 0x0002E338
		// (set) Token: 0x060007E9 RID: 2025 RVA: 0x00005836 File Offset: 0x00003A36
		public unsafe int width
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayInfo.NativeFieldInfoPtr_width);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayInfo.NativeFieldInfoPtr_width)) = value;
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060007EA RID: 2026 RVA: 0x00030160 File Offset: 0x0002E360
		// (set) Token: 0x060007EB RID: 2027 RVA: 0x00005851 File Offset: 0x00003A51
		public unsafe int height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayInfo.NativeFieldInfoPtr_height);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayInfo.NativeFieldInfoPtr_height)) = value;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060007EC RID: 2028 RVA: 0x00030188 File Offset: 0x0002E388
		// (set) Token: 0x060007ED RID: 2029 RVA: 0x0000586C File Offset: 0x00003A6C
		public unsafe RefreshRate refreshRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayInfo.NativeFieldInfoPtr_refreshRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayInfo.NativeFieldInfoPtr_refreshRate)) = value;
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060007EE RID: 2030 RVA: 0x000301B0 File Offset: 0x0002E3B0
		// (set) Token: 0x060007EF RID: 2031 RVA: 0x00005887 File Offset: 0x00003A87
		public unsafe RectInt workArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayInfo.NativeFieldInfoPtr_workArea);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayInfo.NativeFieldInfoPtr_workArea)) = value;
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060007F0 RID: 2032 RVA: 0x000301D8 File Offset: 0x0002E3D8
		// (set) Token: 0x060007F1 RID: 2033 RVA: 0x000058A2 File Offset: 0x00003AA2
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayInfo.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayInfo.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400065E RID: 1630
		private static readonly IntPtr NativeFieldInfoPtr_handle;

		// Token: 0x0400065F RID: 1631
		private static readonly IntPtr NativeFieldInfoPtr_width;

		// Token: 0x04000660 RID: 1632
		private static readonly IntPtr NativeFieldInfoPtr_height;

		// Token: 0x04000661 RID: 1633
		private static readonly IntPtr NativeFieldInfoPtr_refreshRate;

		// Token: 0x04000662 RID: 1634
		private static readonly IntPtr NativeFieldInfoPtr_workArea;

		// Token: 0x04000663 RID: 1635
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04000664 RID: 1636
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DisplayInfo_0;
	}
}
