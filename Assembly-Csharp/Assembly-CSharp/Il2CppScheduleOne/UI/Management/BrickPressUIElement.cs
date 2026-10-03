using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020007E3 RID: 2019
	public class BrickPressUIElement : WorldspaceUIElement
	{
		// Token: 0x0600C587 RID: 50567 RVA: 0x003216E4 File Offset: 0x0031F8E4
		// Note: this type is marked as 'beforefieldinit'.
		static BrickPressUIElement()
		{
			Il2CppClassPointerStore<BrickPressUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "BrickPressUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BrickPressUIElement>.NativeClassPtr);
			BrickPressUIElement.NativeFieldInfoPtr__AssignedPress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressUIElement>.NativeClassPtr, "<AssignedPress>k__BackingField");
			BrickPressUIElement.NativeMethodInfoPtr_get_AssignedPress_Public_get_BrickPress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressUIElement>.NativeClassPtr, 100688893);
			BrickPressUIElement.NativeMethodInfoPtr_set_AssignedPress_Protected_set_Void_BrickPress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressUIElement>.NativeClassPtr, 100688894);
			BrickPressUIElement.NativeMethodInfoPtr_Initialize_Public_Void_BrickPress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressUIElement>.NativeClassPtr, 100688895);
			BrickPressUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressUIElement>.NativeClassPtr, 100688896);
			BrickPressUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressUIElement>.NativeClassPtr, 100688897);
		}

		// Token: 0x17003BF9 RID: 15353
		// (get) Token: 0x0600C588 RID: 50568 RVA: 0x0032178C File Offset: 0x0031F98C
		// (set) Token: 0x0600C589 RID: 50569 RVA: 0x003217CC File Offset: 0x0031F9CC
		public unsafe BrickPress AssignedPress
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 32794, RefRangeEnd = 32795, XrefRangeStart = 32794, XrefRangeEnd = 32795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressUIElement.NativeMethodInfoPtr_get_AssignedPress_Public_get_BrickPress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BrickPress>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressUIElement.NativeMethodInfoPtr_set_AssignedPress_Protected_set_Void_BrickPress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600C58A RID: 50570 RVA: 0x00321810 File Offset: 0x0031FA10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327141, RefRangeEnd = 327142, XrefRangeStart = 327131, XrefRangeEnd = 327141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(BrickPress press)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(press);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressUIElement.NativeMethodInfoPtr_Initialize_Public_Void_BrickPress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C58B RID: 50571 RVA: 0x00321854 File Offset: 0x0031FA54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327142, XrefRangeEnd = 327147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrickPressUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C58C RID: 50572 RVA: 0x00321890 File Offset: 0x0031FA90
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BrickPressUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BrickPressUIElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C58D RID: 50573 RVA: 0x0005D456 File Offset: 0x0005B656
		public BrickPressUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003BF8 RID: 15352
		// (get) Token: 0x0600C58E RID: 50574 RVA: 0x003218CC File Offset: 0x0031FACC
		// (set) Token: 0x0600C58F RID: 50575 RVA: 0x0005D45F File Offset: 0x0005B65F
		public unsafe BrickPress _AssignedPress_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressUIElement.NativeFieldInfoPtr__AssignedPress_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BrickPress>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressUIElement.NativeFieldInfoPtr__AssignedPress_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040086CA RID: 34506
		private static readonly IntPtr NativeFieldInfoPtr__AssignedPress_k__BackingField;

		// Token: 0x040086CB RID: 34507
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedPress_Public_get_BrickPress_0;

		// Token: 0x040086CC RID: 34508
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedPress_Protected_set_Void_BrickPress_0;

		// Token: 0x040086CD RID: 34509
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_BrickPress_0;

		// Token: 0x040086CE RID: 34510
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x040086CF RID: 34511
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
