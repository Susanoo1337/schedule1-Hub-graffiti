using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Rendering;

namespace Il2CppScheduleOne.Weather
{
	// Token: 0x020006D6 RID: 1750
	public class LensFlareSettings : ScriptableObject
	{
		// Token: 0x0600A8B5 RID: 43189 RVA: 0x002CA254 File Offset: 0x002C8454
		// Note: this type is marked as 'beforefieldinit'.
		static LensFlareSettings()
		{
			Il2CppClassPointerStore<LensFlareSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Weather", "LensFlareSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LensFlareSettings>.NativeClassPtr);
			LensFlareSettings.NativeFieldInfoPtr_lensFlareGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareSettings>.NativeClassPtr, "lensFlareGroups");
			LensFlareSettings.NativeMethodInfoPtr_TryGetLensFlareSettings_Public_Boolean_LensFlareDataSRP_byref_LensFlareSettingsGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareSettings>.NativeClassPtr, 100685660);
			LensFlareSettings.NativeMethodInfoPtr_GetLensFlareGroups_Public_Il2CppReferenceArray_1_LensFlareSettingsGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareSettings>.NativeClassPtr, 100685661);
			LensFlareSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareSettings>.NativeClassPtr, 100685662);
		}

		// Token: 0x0600A8B6 RID: 43190 RVA: 0x002CA2D4 File Offset: 0x002C84D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292522, XrefRangeEnd = 292528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetLensFlareSettings(LensFlareDataSRP lensFlare, out LensFlareSettings.LensFlareSettingsGroup group)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(lensFlare);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LensFlareSettings.NativeMethodInfoPtr_TryGetLensFlareSettings_Public_Boolean_LensFlareDataSRP_byref_LensFlareSettingsGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			group = ((intPtr4 == 0) ? null : new LensFlareSettings.LensFlareSettingsGroup(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600A8B7 RID: 43191 RVA: 0x002CA344 File Offset: 0x002C8544
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<LensFlareSettings.LensFlareSettingsGroup> GetLensFlareGroups()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareSettings.NativeMethodInfoPtr_GetLensFlareGroups_Public_Il2CppReferenceArray_1_LensFlareSettingsGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LensFlareSettings.LensFlareSettingsGroup>>(intPtr3) : null;
		}

		// Token: 0x0600A8B8 RID: 43192 RVA: 0x002CA384 File Offset: 0x002C8584
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 79617, RefRangeEnd = 79648, XrefRangeStart = 79617, XrefRangeEnd = 79648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LensFlareSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LensFlareSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A8B9 RID: 43193 RVA: 0x0004CD65 File Offset: 0x0004AF65
		public LensFlareSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003269 RID: 12905
		// (get) Token: 0x0600A8BA RID: 43194 RVA: 0x002CA3C0 File Offset: 0x002C85C0
		// (set) Token: 0x0600A8BB RID: 43195 RVA: 0x0004CD6E File Offset: 0x0004AF6E
		public unsafe Il2CppReferenceArray<LensFlareSettings.LensFlareSettingsGroup> lensFlareGroups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareSettings.NativeFieldInfoPtr_lensFlareGroups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LensFlareSettings.LensFlareSettingsGroup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareSettings.NativeFieldInfoPtr_lensFlareGroups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040074A1 RID: 29857
		private static readonly IntPtr NativeFieldInfoPtr_lensFlareGroups;

		// Token: 0x040074A2 RID: 29858
		private static readonly IntPtr NativeMethodInfoPtr_TryGetLensFlareSettings_Public_Boolean_LensFlareDataSRP_byref_LensFlareSettingsGroup_0;

		// Token: 0x040074A3 RID: 29859
		private static readonly IntPtr NativeMethodInfoPtr_GetLensFlareGroups_Public_Il2CppReferenceArray_1_LensFlareSettingsGroup_0;

		// Token: 0x040074A4 RID: 29860
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C84 RID: 3204
		[Serializable]
		public class LensFlareSettingsGroup : Il2CppSystem.Object
		{
			// Token: 0x0600F258 RID: 62040 RVA: 0x003A6798 File Offset: 0x003A4998
			// Note: this type is marked as 'beforefieldinit'.
			static LensFlareSettingsGroup()
			{
				Il2CppClassPointerStore<LensFlareSettings.LensFlareSettingsGroup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LensFlareSettings>.NativeClassPtr, "LensFlareSettingsGroup");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LensFlareSettings.LensFlareSettingsGroup>.NativeClassPtr);
				LensFlareSettings.LensFlareSettingsGroup.NativeFieldInfoPtr_LensFlare = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareSettings.LensFlareSettingsGroup>.NativeClassPtr, "LensFlare");
				LensFlareSettings.LensFlareSettingsGroup.NativeFieldInfoPtr_Intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareSettings.LensFlareSettingsGroup>.NativeClassPtr, "Intensity");
				LensFlareSettings.LensFlareSettingsGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareSettings.LensFlareSettingsGroup>.NativeClassPtr, 100685663);
			}

			// Token: 0x0600F259 RID: 62041 RVA: 0x003A6800 File Offset: 0x003A4A00
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LensFlareSettingsGroup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LensFlareSettings.LensFlareSettingsGroup>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareSettings.LensFlareSettingsGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F25A RID: 62042 RVA: 0x000725DC File Offset: 0x000707DC
			public LensFlareSettingsGroup(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700498E RID: 18830
			// (get) Token: 0x0600F25B RID: 62043 RVA: 0x003A683C File Offset: 0x003A4A3C
			// (set) Token: 0x0600F25C RID: 62044 RVA: 0x000725E5 File Offset: 0x000707E5
			public unsafe LensFlareDataSRP LensFlare
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareSettings.LensFlareSettingsGroup.NativeFieldInfoPtr_LensFlare);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LensFlareDataSRP>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareSettings.LensFlareSettingsGroup.NativeFieldInfoPtr_LensFlare), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700498F RID: 18831
			// (get) Token: 0x0600F25D RID: 62045 RVA: 0x003A686C File Offset: 0x003A4A6C
			// (set) Token: 0x0600F25E RID: 62046 RVA: 0x00072604 File Offset: 0x00070804
			public unsafe float Intensity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareSettings.LensFlareSettingsGroup.NativeFieldInfoPtr_Intensity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareSettings.LensFlareSettingsGroup.NativeFieldInfoPtr_Intensity)) = value;
				}
			}

			// Token: 0x0400A3F6 RID: 41974
			private static readonly IntPtr NativeFieldInfoPtr_LensFlare;

			// Token: 0x0400A3F7 RID: 41975
			private static readonly IntPtr NativeFieldInfoPtr_Intensity;

			// Token: 0x0400A3F8 RID: 41976
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
