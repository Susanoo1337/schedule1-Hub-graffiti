using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.UI.Stations;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020007E5 RID: 2021
	public class ChemistryStationUIElement : WorldspaceUIElement
	{
		// Token: 0x0600C599 RID: 50585 RVA: 0x00321B14 File Offset: 0x0031FD14
		// Note: this type is marked as 'beforefieldinit'.
		static ChemistryStationUIElement()
		{
			Il2CppClassPointerStore<ChemistryStationUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "ChemistryStationUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistryStationUIElement>.NativeClassPtr);
			ChemistryStationUIElement.NativeFieldInfoPtr__AssignedStation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationUIElement>.NativeClassPtr, "<AssignedStation>k__BackingField");
			ChemistryStationUIElement.NativeFieldInfoPtr_RecipeEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationUIElement>.NativeClassPtr, "RecipeEntry");
			ChemistryStationUIElement.NativeFieldInfoPtr_NoRecipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationUIElement>.NativeClassPtr, "NoRecipe");
			ChemistryStationUIElement.NativeMethodInfoPtr_get_AssignedStation_Public_get_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationUIElement>.NativeClassPtr, 100688903);
			ChemistryStationUIElement.NativeMethodInfoPtr_set_AssignedStation_Protected_set_Void_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationUIElement>.NativeClassPtr, 100688904);
			ChemistryStationUIElement.NativeMethodInfoPtr_Initialize_Public_Void_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationUIElement>.NativeClassPtr, 100688905);
			ChemistryStationUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationUIElement>.NativeClassPtr, 100688906);
			ChemistryStationUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationUIElement>.NativeClassPtr, 100688907);
		}

		// Token: 0x17003BFF RID: 15359
		// (get) Token: 0x0600C59A RID: 50586 RVA: 0x00321BE4 File Offset: 0x0031FDE4
		// (set) Token: 0x0600C59B RID: 50587 RVA: 0x00321C24 File Offset: 0x0031FE24
		public unsafe ChemistryStation AssignedStation
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 32794, RefRangeEnd = 32795, XrefRangeStart = 32794, XrefRangeEnd = 32795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationUIElement.NativeMethodInfoPtr_get_AssignedStation_Public_get_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ChemistryStation>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationUIElement.NativeMethodInfoPtr_set_AssignedStation_Protected_set_Void_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600C59C RID: 50588 RVA: 0x00321C68 File Offset: 0x0031FE68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327173, RefRangeEnd = 327174, XrefRangeStart = 327163, XrefRangeEnd = 327173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(ChemistryStation oven)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(oven);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationUIElement.NativeMethodInfoPtr_Initialize_Public_Void_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C59D RID: 50589 RVA: 0x00321CAC File Offset: 0x0031FEAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327174, XrefRangeEnd = 327190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChemistryStationUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C59E RID: 50590 RVA: 0x00321CE8 File Offset: 0x0031FEE8
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistryStationUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistryStationUIElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C59F RID: 50591 RVA: 0x0005D4A6 File Offset: 0x0005B6A6
		public ChemistryStationUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003BFC RID: 15356
		// (get) Token: 0x0600C5A0 RID: 50592 RVA: 0x00321D24 File Offset: 0x0031FF24
		// (set) Token: 0x0600C5A1 RID: 50593 RVA: 0x0005D4AF File Offset: 0x0005B6AF
		public unsafe ChemistryStation _AssignedStation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationUIElement.NativeFieldInfoPtr__AssignedStation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChemistryStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationUIElement.NativeFieldInfoPtr__AssignedStation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BFD RID: 15357
		// (get) Token: 0x0600C5A2 RID: 50594 RVA: 0x00321D54 File Offset: 0x0031FF54
		// (set) Token: 0x0600C5A3 RID: 50595 RVA: 0x0005D4CE File Offset: 0x0005B6CE
		public unsafe StationRecipeEntry RecipeEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationUIElement.NativeFieldInfoPtr_RecipeEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipeEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationUIElement.NativeFieldInfoPtr_RecipeEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BFE RID: 15358
		// (get) Token: 0x0600C5A4 RID: 50596 RVA: 0x00321D84 File Offset: 0x0031FF84
		// (set) Token: 0x0600C5A5 RID: 50597 RVA: 0x0005D4ED File Offset: 0x0005B6ED
		public unsafe GameObject NoRecipe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationUIElement.NativeFieldInfoPtr_NoRecipe);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationUIElement.NativeFieldInfoPtr_NoRecipe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040086D6 RID: 34518
		private static readonly IntPtr NativeFieldInfoPtr__AssignedStation_k__BackingField;

		// Token: 0x040086D7 RID: 34519
		private static readonly IntPtr NativeFieldInfoPtr_RecipeEntry;

		// Token: 0x040086D8 RID: 34520
		private static readonly IntPtr NativeFieldInfoPtr_NoRecipe;

		// Token: 0x040086D9 RID: 34521
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedStation_Public_get_ChemistryStation_0;

		// Token: 0x040086DA RID: 34522
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedStation_Protected_set_Void_ChemistryStation_0;

		// Token: 0x040086DB RID: 34523
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_ChemistryStation_0;

		// Token: 0x040086DC RID: 34524
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x040086DD RID: 34525
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
