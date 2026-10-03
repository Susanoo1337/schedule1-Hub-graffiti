using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000410 RID: 1040
	[Serializable]
	[StructLayout(2)]
	public struct DisplaySettings
	{
		// Token: 0x06005B83 RID: 23427 RVA: 0x001B6C28 File Offset: 0x001B4E28
		// Note: this type is marked as 'beforefieldinit'.
		static DisplaySettings()
		{
			Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "DisplaySettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr);
			DisplaySettings.NativeFieldInfoPtr_ResolutionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, "ResolutionIndex");
			DisplaySettings.NativeFieldInfoPtr_DisplayMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, "DisplayMode");
			DisplaySettings.NativeFieldInfoPtr_VSync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, "VSync");
			DisplaySettings.NativeFieldInfoPtr_TargetFPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, "TargetFPS");
			DisplaySettings.NativeFieldInfoPtr_UIScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, "UIScale");
			DisplaySettings.NativeFieldInfoPtr_CameraBobbing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, "CameraBobbing");
			DisplaySettings.NativeFieldInfoPtr_ActiveDisplayIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, "ActiveDisplayIndex");
			DisplaySettings.NativeFieldInfoPtr_UnitType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, "UnitType");
			DisplaySettings.NativeFieldInfoPtr_PauseOnFocusLost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, "PauseOnFocusLost");
			DisplaySettings.NativeMethodInfoPtr_GetResolutions_Public_Static_List_1_Resolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, 100675247);
			DisplaySettings.NativeMethodInfoPtr_GetDenominatorSafe_Private_Static_UInt32_RefreshRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, 100675248);
		}

		// Token: 0x06005B84 RID: 23428 RVA: 0x001B6D34 File Offset: 0x001B4F34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 197149, RefRangeEnd = 197151, XrefRangeStart = 197118, XrefRangeEnd = 197149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Resolution> GetResolutions()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplaySettings.NativeMethodInfoPtr_GetResolutions_Public_Static_List_1_Resolution_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Resolution>>(intPtr3) : null;
		}

		// Token: 0x06005B85 RID: 23429 RVA: 0x001B6D68 File Offset: 0x001B4F68
		[CallerCount(0)]
		public unsafe static uint GetDenominatorSafe(RefreshRate refreshRate)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref refreshRate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplaySettings.NativeMethodInfoPtr_GetDenominatorSafe_Private_Static_UInt32_RefreshRate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005B86 RID: 23430 RVA: 0x0002B578 File Offset: 0x00029778
		public Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, ref this));
		}

		// Token: 0x04003EB4 RID: 16052
		private static readonly IntPtr NativeFieldInfoPtr_ResolutionIndex;

		// Token: 0x04003EB5 RID: 16053
		private static readonly IntPtr NativeFieldInfoPtr_DisplayMode;

		// Token: 0x04003EB6 RID: 16054
		private static readonly IntPtr NativeFieldInfoPtr_VSync;

		// Token: 0x04003EB7 RID: 16055
		private static readonly IntPtr NativeFieldInfoPtr_TargetFPS;

		// Token: 0x04003EB8 RID: 16056
		private static readonly IntPtr NativeFieldInfoPtr_UIScale;

		// Token: 0x04003EB9 RID: 16057
		private static readonly IntPtr NativeFieldInfoPtr_CameraBobbing;

		// Token: 0x04003EBA RID: 16058
		private static readonly IntPtr NativeFieldInfoPtr_ActiveDisplayIndex;

		// Token: 0x04003EBB RID: 16059
		private static readonly IntPtr NativeFieldInfoPtr_UnitType;

		// Token: 0x04003EBC RID: 16060
		private static readonly IntPtr NativeFieldInfoPtr_PauseOnFocusLost;

		// Token: 0x04003EBD RID: 16061
		private static readonly IntPtr NativeMethodInfoPtr_GetResolutions_Public_Static_List_1_Resolution_0;

		// Token: 0x04003EBE RID: 16062
		private static readonly IntPtr NativeMethodInfoPtr_GetDenominatorSafe_Private_Static_UInt32_RefreshRate_0;

		// Token: 0x04003EBF RID: 16063
		[FieldOffset(0)]
		public int ResolutionIndex;

		// Token: 0x04003EC0 RID: 16064
		[FieldOffset(4)]
		public DisplaySettings.EDisplayMode DisplayMode;

		// Token: 0x04003EC1 RID: 16065
		[FieldOffset(8)]
		[MarshalAs(4)]
		public bool VSync;

		// Token: 0x04003EC2 RID: 16066
		[FieldOffset(12)]
		public int TargetFPS;

		// Token: 0x04003EC3 RID: 16067
		[FieldOffset(16)]
		public float UIScale;

		// Token: 0x04003EC4 RID: 16068
		[FieldOffset(20)]
		public float CameraBobbing;

		// Token: 0x04003EC5 RID: 16069
		[FieldOffset(24)]
		public int ActiveDisplayIndex;

		// Token: 0x04003EC6 RID: 16070
		[FieldOffset(28)]
		public Settings.EUnitType UnitType;

		// Token: 0x04003EC7 RID: 16071
		[FieldOffset(32)]
		[MarshalAs(4)]
		public bool PauseOnFocusLost;

		// Token: 0x02000AF5 RID: 2805
		[OriginalName("Assembly-CSharp.dll", "", "EDisplayMode")]
		public enum EDisplayMode
		{
			// Token: 0x04009B8F RID: 39823
			Windowed,
			// Token: 0x04009B90 RID: 39824
			FullscreenWindow,
			// Token: 0x04009B91 RID: 39825
			ExclusiveFullscreen
		}

		// Token: 0x02000AF6 RID: 2806
		[ObfuscatedName("ScheduleOne.DevUtilities.DisplaySettings+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E534 RID: 58676 RVA: 0x003805F4 File Offset: 0x0037E7F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<DisplaySettings.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisplaySettings.__c__DisplayClass10_0>.NativeClassPtr);
				DisplaySettings.__c__DisplayClass10_0.NativeFieldInfoPtr_resolutions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings.__c__DisplayClass10_0>.NativeClassPtr, "resolutions");
				DisplaySettings.__c__DisplayClass10_0.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings.__c__DisplayClass10_0>.NativeClassPtr, "i");
				DisplaySettings.__c__DisplayClass10_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings.__c__DisplayClass10_0>.NativeClassPtr, "<>9__0");
				DisplaySettings.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplaySettings.__c__DisplayClass10_0>.NativeClassPtr, 100675249);
				DisplaySettings.__c__DisplayClass10_0.NativeMethodInfoPtr__GetResolutions_b__0_Internal_Boolean_Resolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplaySettings.__c__DisplayClass10_0>.NativeClassPtr, 100675250);
			}

			// Token: 0x0600E535 RID: 58677 RVA: 0x00380684 File Offset: 0x0037E884
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisplaySettings.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplaySettings.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E536 RID: 58678 RVA: 0x003806C0 File Offset: 0x0037E8C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197116, XrefRangeEnd = 197118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetResolutions_b__0(Resolution x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplaySettings.__c__DisplayClass10_0.NativeMethodInfoPtr__GetResolutions_b__0_Internal_Boolean_Resolution_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E537 RID: 58679 RVA: 0x0006C0F5 File Offset: 0x0006A2F5
			public __c__DisplayClass10_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045A6 RID: 17830
			// (get) Token: 0x0600E538 RID: 58680 RVA: 0x0038070C File Offset: 0x0037E90C
			// (set) Token: 0x0600E539 RID: 58681 RVA: 0x0006C0FE File Offset: 0x0006A2FE
			public unsafe Il2CppStructArray<Resolution> resolutions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplaySettings.__c__DisplayClass10_0.NativeFieldInfoPtr_resolutions);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Resolution>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplaySettings.__c__DisplayClass10_0.NativeFieldInfoPtr_resolutions), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045A7 RID: 17831
			// (get) Token: 0x0600E53A RID: 58682 RVA: 0x0038073C File Offset: 0x0037E93C
			// (set) Token: 0x0600E53B RID: 58683 RVA: 0x0006C11D File Offset: 0x0006A31D
			public unsafe int i
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplaySettings.__c__DisplayClass10_0.NativeFieldInfoPtr_i);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplaySettings.__c__DisplayClass10_0.NativeFieldInfoPtr_i)) = value;
				}
			}

			// Token: 0x170045A8 RID: 17832
			// (get) Token: 0x0600E53C RID: 58684 RVA: 0x00380764 File Offset: 0x0037E964
			// (set) Token: 0x0600E53D RID: 58685 RVA: 0x0006C138 File Offset: 0x0006A338
			public unsafe Predicate<Resolution> __9__0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplaySettings.__c__DisplayClass10_0.NativeFieldInfoPtr___9__0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Resolution>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplaySettings.__c__DisplayClass10_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009B92 RID: 39826
			private static readonly IntPtr NativeFieldInfoPtr_resolutions;

			// Token: 0x04009B93 RID: 39827
			private static readonly IntPtr NativeFieldInfoPtr_i;

			// Token: 0x04009B94 RID: 39828
			private static readonly IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x04009B95 RID: 39829
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009B96 RID: 39830
			private static readonly IntPtr NativeMethodInfoPtr__GetResolutions_b__0_Internal_Boolean_Resolution_0;
		}
	}
}
