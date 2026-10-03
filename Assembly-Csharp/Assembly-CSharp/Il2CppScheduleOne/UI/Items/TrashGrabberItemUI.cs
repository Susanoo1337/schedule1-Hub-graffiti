using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts.WateringCan;
using Il2CppTMPro;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x02000830 RID: 2096
	public class TrashGrabberItemUI : ItemUI
	{
		// Token: 0x0600CBAF RID: 52143 RVA: 0x00334914 File Offset: 0x00332B14
		// Note: this type is marked as 'beforefieldinit'.
		static TrashGrabberItemUI()
		{
			Il2CppClassPointerStore<TrashGrabberItemUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "TrashGrabberItemUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashGrabberItemUI>.NativeClassPtr);
			TrashGrabberItemUI.NativeFieldInfoPtr_ValueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGrabberItemUI>.NativeClassPtr, "ValueLabel");
			TrashGrabberItemUI.NativeFieldInfoPtr_trashGrabberInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGrabberItemUI>.NativeClassPtr, "trashGrabberInstance");
			TrashGrabberItemUI.NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberItemUI>.NativeClassPtr, 100689552);
			TrashGrabberItemUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberItemUI>.NativeClassPtr, 100689553);
			TrashGrabberItemUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberItemUI>.NativeClassPtr, 100689554);
		}

		// Token: 0x0600CBB0 RID: 52144 RVA: 0x003349A8 File Offset: 0x00332BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334266, XrefRangeEnd = 334272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Setup(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashGrabberItemUI.NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CBB1 RID: 52145 RVA: 0x003349F8 File Offset: 0x00332BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334272, XrefRangeEnd = 334283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashGrabberItemUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CBB2 RID: 52146 RVA: 0x00334A34 File Offset: 0x00332C34
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashGrabberItemUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashGrabberItemUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberItemUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CBB3 RID: 52147 RVA: 0x00060A65 File Offset: 0x0005EC65
		public TrashGrabberItemUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003DDE RID: 15838
		// (get) Token: 0x0600CBB4 RID: 52148 RVA: 0x00334A70 File Offset: 0x00332C70
		// (set) Token: 0x0600CBB5 RID: 52149 RVA: 0x00060A6E File Offset: 0x0005EC6E
		public unsafe TextMeshProUGUI ValueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGrabberItemUI.NativeFieldInfoPtr_ValueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGrabberItemUI.NativeFieldInfoPtr_ValueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DDF RID: 15839
		// (get) Token: 0x0600CBB6 RID: 52150 RVA: 0x00334AA0 File Offset: 0x00332CA0
		// (set) Token: 0x0600CBB7 RID: 52151 RVA: 0x00060A8D File Offset: 0x0005EC8D
		public unsafe TrashGrabberInstance trashGrabberInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGrabberItemUI.NativeFieldInfoPtr_trashGrabberInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashGrabberInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGrabberItemUI.NativeFieldInfoPtr_trashGrabberInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008AA7 RID: 35495
		private static readonly IntPtr NativeFieldInfoPtr_ValueLabel;

		// Token: 0x04008AA8 RID: 35496
		private static readonly IntPtr NativeFieldInfoPtr_trashGrabberInstance;

		// Token: 0x04008AA9 RID: 35497
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04008AAA RID: 35498
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0;

		// Token: 0x04008AAB RID: 35499
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
