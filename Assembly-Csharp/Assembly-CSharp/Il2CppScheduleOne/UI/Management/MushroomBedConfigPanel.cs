using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Management.UI;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020007CC RID: 1996
	public class MushroomBedConfigPanel : ConfigPanel
	{
		// Token: 0x0600C341 RID: 49985 RVA: 0x0031A588 File Offset: 0x00318788
		// Note: this type is marked as 'beforefieldinit'.
		static MushroomBedConfigPanel()
		{
			Il2CppClassPointerStore<MushroomBedConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "MushroomBedConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MushroomBedConfigPanel>.NativeClassPtr);
			MushroomBedConfigPanel.NativeFieldInfoPtr_SpawnUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MushroomBedConfigPanel>.NativeClassPtr, "SpawnUI");
			MushroomBedConfigPanel.NativeFieldInfoPtr_Additive1UI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MushroomBedConfigPanel>.NativeClassPtr, "Additive1UI");
			MushroomBedConfigPanel.NativeFieldInfoPtr_Additive2UI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MushroomBedConfigPanel>.NativeClassPtr, "Additive2UI");
			MushroomBedConfigPanel.NativeFieldInfoPtr_Additive3UI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MushroomBedConfigPanel>.NativeClassPtr, "Additive3UI");
			MushroomBedConfigPanel.NativeFieldInfoPtr_DestinationUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MushroomBedConfigPanel>.NativeClassPtr, "DestinationUI");
			MushroomBedConfigPanel.NativeMethodInfoPtr_BindInternal_Protected_Virtual_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomBedConfigPanel>.NativeClassPtr, 100688649);
			MushroomBedConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomBedConfigPanel>.NativeClassPtr, 100688650);
		}

		// Token: 0x0600C342 RID: 49986 RVA: 0x0031A644 File Offset: 0x00318844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323191, XrefRangeEnd = 323267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BindInternal(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MushroomBedConfigPanel.NativeMethodInfoPtr_BindInternal_Protected_Virtual_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C343 RID: 49987 RVA: 0x0031A694 File Offset: 0x00318894
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 34977, RefRangeEnd = 34989, XrefRangeStart = 34977, XrefRangeEnd = 34989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MushroomBedConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MushroomBedConfigPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomBedConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C344 RID: 49988 RVA: 0x0005BF8D File Offset: 0x0005A18D
		public MushroomBedConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003B3F RID: 15167
		// (get) Token: 0x0600C345 RID: 49989 RVA: 0x0031A6D0 File Offset: 0x003188D0
		// (set) Token: 0x0600C346 RID: 49990 RVA: 0x0005BF96 File Offset: 0x0005A196
		public unsafe ItemFieldUI SpawnUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedConfigPanel.NativeFieldInfoPtr_SpawnUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedConfigPanel.NativeFieldInfoPtr_SpawnUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B40 RID: 15168
		// (get) Token: 0x0600C347 RID: 49991 RVA: 0x0031A700 File Offset: 0x00318900
		// (set) Token: 0x0600C348 RID: 49992 RVA: 0x0005BFB5 File Offset: 0x0005A1B5
		public unsafe ItemFieldUI Additive1UI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedConfigPanel.NativeFieldInfoPtr_Additive1UI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedConfigPanel.NativeFieldInfoPtr_Additive1UI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B41 RID: 15169
		// (get) Token: 0x0600C349 RID: 49993 RVA: 0x0031A730 File Offset: 0x00318930
		// (set) Token: 0x0600C34A RID: 49994 RVA: 0x0005BFD4 File Offset: 0x0005A1D4
		public unsafe ItemFieldUI Additive2UI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedConfigPanel.NativeFieldInfoPtr_Additive2UI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedConfigPanel.NativeFieldInfoPtr_Additive2UI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B42 RID: 15170
		// (get) Token: 0x0600C34B RID: 49995 RVA: 0x0031A760 File Offset: 0x00318960
		// (set) Token: 0x0600C34C RID: 49996 RVA: 0x0005BFF3 File Offset: 0x0005A1F3
		public unsafe ItemFieldUI Additive3UI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedConfigPanel.NativeFieldInfoPtr_Additive3UI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedConfigPanel.NativeFieldInfoPtr_Additive3UI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B43 RID: 15171
		// (get) Token: 0x0600C34D RID: 49997 RVA: 0x0031A790 File Offset: 0x00318990
		// (set) Token: 0x0600C34E RID: 49998 RVA: 0x0005C012 File Offset: 0x0005A212
		public unsafe ObjectFieldUI DestinationUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedConfigPanel.NativeFieldInfoPtr_DestinationUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedConfigPanel.NativeFieldInfoPtr_DestinationUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400855C RID: 34140
		private static readonly IntPtr NativeFieldInfoPtr_SpawnUI;

		// Token: 0x0400855D RID: 34141
		private static readonly IntPtr NativeFieldInfoPtr_Additive1UI;

		// Token: 0x0400855E RID: 34142
		private static readonly IntPtr NativeFieldInfoPtr_Additive2UI;

		// Token: 0x0400855F RID: 34143
		private static readonly IntPtr NativeFieldInfoPtr_Additive3UI;

		// Token: 0x04008560 RID: 34144
		private static readonly IntPtr NativeFieldInfoPtr_DestinationUI;

		// Token: 0x04008561 RID: 34145
		private static readonly IntPtr NativeMethodInfoPtr_BindInternal_Protected_Virtual_Void_List_1_EntityConfiguration_0;

		// Token: 0x04008562 RID: 34146
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
