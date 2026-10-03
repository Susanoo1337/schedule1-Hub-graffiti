using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x02000825 RID: 2085
	public class IntegerItemUI : ItemUI
	{
		// Token: 0x0600CAB7 RID: 51895 RVA: 0x003317B0 File Offset: 0x0032F9B0
		// Note: this type is marked as 'beforefieldinit'.
		static IntegerItemUI()
		{
			Il2CppClassPointerStore<IntegerItemUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "IntegerItemUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntegerItemUI>.NativeClassPtr);
			IntegerItemUI.NativeFieldInfoPtr_ValueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegerItemUI>.NativeClassPtr, "ValueLabel");
			IntegerItemUI.NativeFieldInfoPtr_integerItemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegerItemUI>.NativeClassPtr, "integerItemInstance");
			IntegerItemUI.NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemUI>.NativeClassPtr, 100689453);
			IntegerItemUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemUI>.NativeClassPtr, 100689454);
			IntegerItemUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemUI>.NativeClassPtr, 100689455);
		}

		// Token: 0x0600CAB8 RID: 51896 RVA: 0x00331844 File Offset: 0x0032FA44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333034, XrefRangeEnd = 333040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Setup(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntegerItemUI.NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CAB9 RID: 51897 RVA: 0x00331894 File Offset: 0x0032FA94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333040, XrefRangeEnd = 333042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntegerItemUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CABA RID: 51898 RVA: 0x003318D0 File Offset: 0x0032FAD0
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntegerItemUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntegerItemUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntegerItemUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CABB RID: 51899 RVA: 0x0006022D File Offset: 0x0005E42D
		public IntegerItemUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003D91 RID: 15761
		// (get) Token: 0x0600CABC RID: 51900 RVA: 0x0033190C File Offset: 0x0032FB0C
		// (set) Token: 0x0600CABD RID: 51901 RVA: 0x00060236 File Offset: 0x0005E436
		public unsafe Text ValueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegerItemUI.NativeFieldInfoPtr_ValueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegerItemUI.NativeFieldInfoPtr_ValueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D92 RID: 15762
		// (get) Token: 0x0600CABE RID: 51902 RVA: 0x0033193C File Offset: 0x0032FB3C
		// (set) Token: 0x0600CABF RID: 51903 RVA: 0x00060255 File Offset: 0x0005E455
		public unsafe IntegerItemInstance integerItemInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegerItemUI.NativeFieldInfoPtr_integerItemInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IntegerItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegerItemUI.NativeFieldInfoPtr_integerItemInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008A09 RID: 35337
		private static readonly IntPtr NativeFieldInfoPtr_ValueLabel;

		// Token: 0x04008A0A RID: 35338
		private static readonly IntPtr NativeFieldInfoPtr_integerItemInstance;

		// Token: 0x04008A0B RID: 35339
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04008A0C RID: 35340
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0;

		// Token: 0x04008A0D RID: 35341
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
