using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020007E4 RID: 2020
	public class CauldronUIElement : WorldspaceUIElement
	{
		// Token: 0x0600C590 RID: 50576 RVA: 0x003218FC File Offset: 0x0031FAFC
		// Note: this type is marked as 'beforefieldinit'.
		static CauldronUIElement()
		{
			Il2CppClassPointerStore<CauldronUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "CauldronUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CauldronUIElement>.NativeClassPtr);
			CauldronUIElement.NativeFieldInfoPtr__AssignedCauldron_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronUIElement>.NativeClassPtr, "<AssignedCauldron>k__BackingField");
			CauldronUIElement.NativeMethodInfoPtr_get_AssignedCauldron_Public_get_Cauldron_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronUIElement>.NativeClassPtr, 100688898);
			CauldronUIElement.NativeMethodInfoPtr_set_AssignedCauldron_Protected_set_Void_Cauldron_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronUIElement>.NativeClassPtr, 100688899);
			CauldronUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Cauldron_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronUIElement>.NativeClassPtr, 100688900);
			CauldronUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronUIElement>.NativeClassPtr, 100688901);
			CauldronUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronUIElement>.NativeClassPtr, 100688902);
		}

		// Token: 0x17003BFB RID: 15355
		// (get) Token: 0x0600C591 RID: 50577 RVA: 0x003219A4 File Offset: 0x0031FBA4
		// (set) Token: 0x0600C592 RID: 50578 RVA: 0x003219E4 File Offset: 0x0031FBE4
		public unsafe Cauldron AssignedCauldron
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 32794, RefRangeEnd = 32795, XrefRangeStart = 32794, XrefRangeEnd = 32795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronUIElement.NativeMethodInfoPtr_get_AssignedCauldron_Public_get_Cauldron_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Cauldron>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronUIElement.NativeMethodInfoPtr_set_AssignedCauldron_Protected_set_Void_Cauldron_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600C593 RID: 50579 RVA: 0x00321A28 File Offset: 0x0031FC28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327157, RefRangeEnd = 327158, XrefRangeStart = 327147, XrefRangeEnd = 327157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Cauldron cauldron)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cauldron);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Cauldron_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C594 RID: 50580 RVA: 0x00321A6C File Offset: 0x0031FC6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327158, XrefRangeEnd = 327163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CauldronUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C595 RID: 50581 RVA: 0x00321AA8 File Offset: 0x0031FCA8
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CauldronUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CauldronUIElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C596 RID: 50582 RVA: 0x0005D47E File Offset: 0x0005B67E
		public CauldronUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003BFA RID: 15354
		// (get) Token: 0x0600C597 RID: 50583 RVA: 0x00321AE4 File Offset: 0x0031FCE4
		// (set) Token: 0x0600C598 RID: 50584 RVA: 0x0005D487 File Offset: 0x0005B687
		public unsafe Cauldron _AssignedCauldron_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronUIElement.NativeFieldInfoPtr__AssignedCauldron_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cauldron>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronUIElement.NativeFieldInfoPtr__AssignedCauldron_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040086D0 RID: 34512
		private static readonly IntPtr NativeFieldInfoPtr__AssignedCauldron_k__BackingField;

		// Token: 0x040086D1 RID: 34513
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedCauldron_Public_get_Cauldron_0;

		// Token: 0x040086D2 RID: 34514
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedCauldron_Protected_set_Void_Cauldron_0;

		// Token: 0x040086D3 RID: 34515
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Cauldron_0;

		// Token: 0x040086D4 RID: 34516
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x040086D5 RID: 34517
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
