using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020007E6 RID: 2022
	public class ChemistUIElement : WorldspaceUIElement
	{
		// Token: 0x0600C5A6 RID: 50598 RVA: 0x00321DB4 File Offset: 0x0031FFB4
		// Note: this type is marked as 'beforefieldinit'.
		static ChemistUIElement()
		{
			Il2CppClassPointerStore<ChemistUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "ChemistUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistUIElement>.NativeClassPtr);
			ChemistUIElement.NativeFieldInfoPtr_StationsIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistUIElement>.NativeClassPtr, "StationsIcons");
			ChemistUIElement.NativeFieldInfoPtr__AssignedChemist_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistUIElement>.NativeClassPtr, "<AssignedChemist>k__BackingField");
			ChemistUIElement.NativeMethodInfoPtr_get_AssignedChemist_Public_get_Chemist_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistUIElement>.NativeClassPtr, 100688908);
			ChemistUIElement.NativeMethodInfoPtr_set_AssignedChemist_Protected_set_Void_Chemist_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistUIElement>.NativeClassPtr, 100688909);
			ChemistUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Chemist_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistUIElement>.NativeClassPtr, 100688910);
			ChemistUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistUIElement>.NativeClassPtr, 100688911);
			ChemistUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistUIElement>.NativeClassPtr, 100688912);
		}

		// Token: 0x17003C02 RID: 15362
		// (get) Token: 0x0600C5A7 RID: 50599 RVA: 0x00321E70 File Offset: 0x00320070
		// (set) Token: 0x0600C5A8 RID: 50600 RVA: 0x00321EB0 File Offset: 0x003200B0
		public unsafe Chemist AssignedChemist
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistUIElement.NativeMethodInfoPtr_get_AssignedChemist_Public_get_Chemist_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Chemist>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistUIElement.NativeMethodInfoPtr_set_AssignedChemist_Protected_set_Void_Chemist_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600C5A9 RID: 50601 RVA: 0x00321EF4 File Offset: 0x003200F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327201, RefRangeEnd = 327202, XrefRangeStart = 327190, XrefRangeEnd = 327201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Chemist chemist)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(chemist);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Chemist_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C5AA RID: 50602 RVA: 0x00321F38 File Offset: 0x00320138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327202, XrefRangeEnd = 327214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChemistUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C5AB RID: 50603 RVA: 0x00321F74 File Offset: 0x00320174
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistUIElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C5AC RID: 50604 RVA: 0x0005D50C File Offset: 0x0005B70C
		public ChemistUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003C00 RID: 15360
		// (get) Token: 0x0600C5AD RID: 50605 RVA: 0x00321FB0 File Offset: 0x003201B0
		// (set) Token: 0x0600C5AE RID: 50606 RVA: 0x0005D515 File Offset: 0x0005B715
		public unsafe Il2CppReferenceArray<Image> StationsIcons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistUIElement.NativeFieldInfoPtr_StationsIcons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Image>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistUIElement.NativeFieldInfoPtr_StationsIcons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C01 RID: 15361
		// (get) Token: 0x0600C5AF RID: 50607 RVA: 0x00321FE0 File Offset: 0x003201E0
		// (set) Token: 0x0600C5B0 RID: 50608 RVA: 0x0005D534 File Offset: 0x0005B734
		public unsafe Chemist _AssignedChemist_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistUIElement.NativeFieldInfoPtr__AssignedChemist_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Chemist>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistUIElement.NativeFieldInfoPtr__AssignedChemist_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040086DE RID: 34526
		private static readonly IntPtr NativeFieldInfoPtr_StationsIcons;

		// Token: 0x040086DF RID: 34527
		private static readonly IntPtr NativeFieldInfoPtr__AssignedChemist_k__BackingField;

		// Token: 0x040086E0 RID: 34528
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedChemist_Public_get_Chemist_0;

		// Token: 0x040086E1 RID: 34529
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedChemist_Protected_set_Void_Chemist_0;

		// Token: 0x040086E2 RID: 34530
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Chemist_0;

		// Token: 0x040086E3 RID: 34531
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x040086E4 RID: 34532
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
