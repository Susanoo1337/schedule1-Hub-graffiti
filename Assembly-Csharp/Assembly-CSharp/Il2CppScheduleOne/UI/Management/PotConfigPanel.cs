using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Management.UI;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020007CF RID: 1999
	public class PotConfigPanel : ConfigPanel
	{
		// Token: 0x0600C35F RID: 50015 RVA: 0x0031AA98 File Offset: 0x00318C98
		// Note: this type is marked as 'beforefieldinit'.
		static PotConfigPanel()
		{
			Il2CppClassPointerStore<PotConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "PotConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotConfigPanel>.NativeClassPtr);
			PotConfigPanel.NativeFieldInfoPtr_SeedUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfigPanel>.NativeClassPtr, "SeedUI");
			PotConfigPanel.NativeFieldInfoPtr_Additive1UI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfigPanel>.NativeClassPtr, "Additive1UI");
			PotConfigPanel.NativeFieldInfoPtr_Additive2UI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfigPanel>.NativeClassPtr, "Additive2UI");
			PotConfigPanel.NativeFieldInfoPtr_Additive3UI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfigPanel>.NativeClassPtr, "Additive3UI");
			PotConfigPanel.NativeFieldInfoPtr_DestinationUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfigPanel>.NativeClassPtr, "DestinationUI");
			PotConfigPanel.NativeMethodInfoPtr_BindInternal_Protected_Virtual_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfigPanel>.NativeClassPtr, 100688655);
			PotConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfigPanel>.NativeClassPtr, 100688656);
		}

		// Token: 0x0600C360 RID: 50016 RVA: 0x0031AB54 File Offset: 0x00318D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323357, XrefRangeEnd = 323432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BindInternal(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotConfigPanel.NativeMethodInfoPtr_BindInternal_Protected_Virtual_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C361 RID: 50017 RVA: 0x0031ABA4 File Offset: 0x00318DA4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 34977, RefRangeEnd = 34989, XrefRangeStart = 34977, XrefRangeEnd = 34989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PotConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotConfigPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C362 RID: 50018 RVA: 0x0005C0BF File Offset: 0x0005A2BF
		public PotConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003B48 RID: 15176
		// (get) Token: 0x0600C363 RID: 50019 RVA: 0x0031ABE0 File Offset: 0x00318DE0
		// (set) Token: 0x0600C364 RID: 50020 RVA: 0x0005C0C8 File Offset: 0x0005A2C8
		public unsafe ItemFieldUI SeedUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigPanel.NativeFieldInfoPtr_SeedUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigPanel.NativeFieldInfoPtr_SeedUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B49 RID: 15177
		// (get) Token: 0x0600C365 RID: 50021 RVA: 0x0031AC10 File Offset: 0x00318E10
		// (set) Token: 0x0600C366 RID: 50022 RVA: 0x0005C0E7 File Offset: 0x0005A2E7
		public unsafe ItemFieldUI Additive1UI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigPanel.NativeFieldInfoPtr_Additive1UI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigPanel.NativeFieldInfoPtr_Additive1UI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B4A RID: 15178
		// (get) Token: 0x0600C367 RID: 50023 RVA: 0x0031AC40 File Offset: 0x00318E40
		// (set) Token: 0x0600C368 RID: 50024 RVA: 0x0005C106 File Offset: 0x0005A306
		public unsafe ItemFieldUI Additive2UI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigPanel.NativeFieldInfoPtr_Additive2UI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigPanel.NativeFieldInfoPtr_Additive2UI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B4B RID: 15179
		// (get) Token: 0x0600C369 RID: 50025 RVA: 0x0031AC70 File Offset: 0x00318E70
		// (set) Token: 0x0600C36A RID: 50026 RVA: 0x0005C125 File Offset: 0x0005A325
		public unsafe ItemFieldUI Additive3UI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigPanel.NativeFieldInfoPtr_Additive3UI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigPanel.NativeFieldInfoPtr_Additive3UI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B4C RID: 15180
		// (get) Token: 0x0600C36B RID: 50027 RVA: 0x0031ACA0 File Offset: 0x00318EA0
		// (set) Token: 0x0600C36C RID: 50028 RVA: 0x0005C144 File Offset: 0x0005A344
		public unsafe ObjectFieldUI DestinationUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigPanel.NativeFieldInfoPtr_DestinationUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigPanel.NativeFieldInfoPtr_DestinationUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400856B RID: 34155
		private static readonly IntPtr NativeFieldInfoPtr_SeedUI;

		// Token: 0x0400856C RID: 34156
		private static readonly IntPtr NativeFieldInfoPtr_Additive1UI;

		// Token: 0x0400856D RID: 34157
		private static readonly IntPtr NativeFieldInfoPtr_Additive2UI;

		// Token: 0x0400856E RID: 34158
		private static readonly IntPtr NativeFieldInfoPtr_Additive3UI;

		// Token: 0x0400856F RID: 34159
		private static readonly IntPtr NativeFieldInfoPtr_DestinationUI;

		// Token: 0x04008570 RID: 34160
		private static readonly IntPtr NativeMethodInfoPtr_BindInternal_Protected_Virtual_Void_List_1_EntityConfiguration_0;

		// Token: 0x04008571 RID: 34161
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
