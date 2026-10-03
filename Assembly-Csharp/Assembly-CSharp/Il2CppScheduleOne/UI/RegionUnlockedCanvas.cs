using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200075B RID: 1883
	public class RegionUnlockedCanvas : Singleton<RegionUnlockedCanvas>
	{
		// Token: 0x0600B7AF RID: 47023 RVA: 0x002F7858 File Offset: 0x002F5A58
		// Note: this type is marked as 'beforefieldinit'.
		static RegionUnlockedCanvas()
		{
			Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "RegionUnlockedCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr);
			RegionUnlockedCanvas.NativeFieldInfoPtr__IsRunning_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, "<IsRunning>k__BackingField");
			RegionUnlockedCanvas.NativeFieldInfoPtr__Order_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, "<Order>k__BackingField");
			RegionUnlockedCanvas.NativeFieldInfoPtr_OpenCloseAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, "OpenCloseAnim");
			RegionUnlockedCanvas.NativeFieldInfoPtr_RegionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, "RegionLabel");
			RegionUnlockedCanvas.NativeFieldInfoPtr_RegionDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, "RegionDescription");
			RegionUnlockedCanvas.NativeFieldInfoPtr_RegionImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, "RegionImage");
			RegionUnlockedCanvas.NativeFieldInfoPtr_UIScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, "UIScreen");
			RegionUnlockedCanvas.NativeFieldInfoPtr_region = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, "region");
			RegionUnlockedCanvas.NativeMethodInfoPtr_get_IsRunning_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, 100687338);
			RegionUnlockedCanvas.NativeMethodInfoPtr_set_IsRunning_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, 100687339);
			RegionUnlockedCanvas.NativeMethodInfoPtr_get_Order_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, 100687340);
			RegionUnlockedCanvas.NativeMethodInfoPtr_set_Order_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, 100687341);
			RegionUnlockedCanvas.NativeMethodInfoPtr_QueueUnlocked_Public_Void_EMapRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, 100687342);
			RegionUnlockedCanvas.NativeMethodInfoPtr_StartEvent_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, 100687343);
			RegionUnlockedCanvas.NativeMethodInfoPtr_EndEvent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, 100687344);
			RegionUnlockedCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, 100687345);
		}

		// Token: 0x17003780 RID: 14208
		// (get) Token: 0x0600B7B0 RID: 47024 RVA: 0x002F79C8 File Offset: 0x002F5BC8
		// (set) Token: 0x0600B7B1 RID: 47025 RVA: 0x002F7A04 File Offset: 0x002F5C04
		public unsafe virtual bool IsRunning
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.NativeMethodInfoPtr_get_IsRunning_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 33070, RefRangeEnd = 33090, XrefRangeStart = 33070, XrefRangeEnd = 33090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.NativeMethodInfoPtr_set_IsRunning_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003781 RID: 14209
		// (get) Token: 0x0600B7B2 RID: 47026 RVA: 0x002F7A44 File Offset: 0x002F5C44
		// (set) Token: 0x0600B7B3 RID: 47027 RVA: 0x002F7A80 File Offset: 0x002F5C80
		public unsafe virtual int Order
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 70643, RefRangeEnd = 70670, XrefRangeStart = 70643, XrefRangeEnd = 70670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.NativeMethodInfoPtr_get_Order_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 165205, RefRangeEnd = 165206, XrefRangeStart = 165205, XrefRangeEnd = 165206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.NativeMethodInfoPtr_set_Order_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B7B4 RID: 47028 RVA: 0x002F7AC0 File Offset: 0x002F5CC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 308504, RefRangeEnd = 308506, XrefRangeStart = 308498, XrefRangeEnd = 308504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueueUnlocked(EMapRegion _region)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _region;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.NativeMethodInfoPtr_QueueUnlocked_Public_Void_EMapRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7B5 RID: 47029 RVA: 0x002F7B00 File Offset: 0x002F5D00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308506, XrefRangeEnd = 308599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.NativeMethodInfoPtr_StartEvent_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7B6 RID: 47030 RVA: 0x002F7B34 File Offset: 0x002F5D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308599, XrefRangeEnd = 308607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.NativeMethodInfoPtr_EndEvent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7B7 RID: 47031 RVA: 0x002F7B68 File Offset: 0x002F5D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308607, XrefRangeEnd = 308610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegionUnlockedCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7B8 RID: 47032 RVA: 0x0005552E File Offset: 0x0005372E
		public RegionUnlockedCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003778 RID: 14200
		// (get) Token: 0x0600B7B9 RID: 47033 RVA: 0x002F7BA4 File Offset: 0x002F5DA4
		// (set) Token: 0x0600B7BA RID: 47034 RVA: 0x00055537 File Offset: 0x00053737
		public unsafe bool _IsRunning_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr__IsRunning_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr__IsRunning_k__BackingField)) = value;
			}
		}

		// Token: 0x17003779 RID: 14201
		// (get) Token: 0x0600B7BB RID: 47035 RVA: 0x002F7BCC File Offset: 0x002F5DCC
		// (set) Token: 0x0600B7BC RID: 47036 RVA: 0x00055552 File Offset: 0x00053752
		public unsafe int _Order_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr__Order_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr__Order_k__BackingField)) = value;
			}
		}

		// Token: 0x1700377A RID: 14202
		// (get) Token: 0x0600B7BD RID: 47037 RVA: 0x002F7BF4 File Offset: 0x002F5DF4
		// (set) Token: 0x0600B7BE RID: 47038 RVA: 0x0005556D File Offset: 0x0005376D
		public unsafe Animation OpenCloseAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr_OpenCloseAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr_OpenCloseAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700377B RID: 14203
		// (get) Token: 0x0600B7BF RID: 47039 RVA: 0x002F7C24 File Offset: 0x002F5E24
		// (set) Token: 0x0600B7C0 RID: 47040 RVA: 0x0005558C File Offset: 0x0005378C
		public unsafe TextMeshProUGUI RegionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr_RegionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr_RegionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700377C RID: 14204
		// (get) Token: 0x0600B7C1 RID: 47041 RVA: 0x002F7C54 File Offset: 0x002F5E54
		// (set) Token: 0x0600B7C2 RID: 47042 RVA: 0x000555AB File Offset: 0x000537AB
		public unsafe TextMeshProUGUI RegionDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr_RegionDescription);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr_RegionDescription), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700377D RID: 14205
		// (get) Token: 0x0600B7C3 RID: 47043 RVA: 0x002F7C84 File Offset: 0x002F5E84
		// (set) Token: 0x0600B7C4 RID: 47044 RVA: 0x000555CA File Offset: 0x000537CA
		public unsafe Image RegionImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr_RegionImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr_RegionImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700377E RID: 14206
		// (get) Token: 0x0600B7C5 RID: 47045 RVA: 0x002F7CB4 File Offset: 0x002F5EB4
		// (set) Token: 0x0600B7C6 RID: 47046 RVA: 0x000555E9 File Offset: 0x000537E9
		public unsafe UIScreen UIScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr_UIScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr_UIScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700377F RID: 14207
		// (get) Token: 0x0600B7C7 RID: 47047 RVA: 0x002F7CE4 File Offset: 0x002F5EE4
		// (set) Token: 0x0600B7C8 RID: 47048 RVA: 0x00055608 File Offset: 0x00053808
		public unsafe EMapRegion region
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr_region);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr_region)) = value;
			}
		}

		// Token: 0x04007E2A RID: 32298
		private static readonly IntPtr NativeFieldInfoPtr__IsRunning_k__BackingField;

		// Token: 0x04007E2B RID: 32299
		private static readonly IntPtr NativeFieldInfoPtr__Order_k__BackingField;

		// Token: 0x04007E2C RID: 32300
		private static readonly IntPtr NativeFieldInfoPtr_OpenCloseAnim;

		// Token: 0x04007E2D RID: 32301
		private static readonly IntPtr NativeFieldInfoPtr_RegionLabel;

		// Token: 0x04007E2E RID: 32302
		private static readonly IntPtr NativeFieldInfoPtr_RegionDescription;

		// Token: 0x04007E2F RID: 32303
		private static readonly IntPtr NativeFieldInfoPtr_RegionImage;

		// Token: 0x04007E30 RID: 32304
		private static readonly IntPtr NativeFieldInfoPtr_UIScreen;

		// Token: 0x04007E31 RID: 32305
		private static readonly IntPtr NativeFieldInfoPtr_region;

		// Token: 0x04007E32 RID: 32306
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRunning_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04007E33 RID: 32307
		private static readonly IntPtr NativeMethodInfoPtr_set_IsRunning_Private_set_Void_Boolean_0;

		// Token: 0x04007E34 RID: 32308
		private static readonly IntPtr NativeMethodInfoPtr_get_Order_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04007E35 RID: 32309
		private static readonly IntPtr NativeMethodInfoPtr_set_Order_Private_set_Void_Int32_0;

		// Token: 0x04007E36 RID: 32310
		private static readonly IntPtr NativeMethodInfoPtr_QueueUnlocked_Public_Void_EMapRegion_0;

		// Token: 0x04007E37 RID: 32311
		private static readonly IntPtr NativeMethodInfoPtr_StartEvent_Public_Virtual_Final_New_Void_0;

		// Token: 0x04007E38 RID: 32312
		private static readonly IntPtr NativeMethodInfoPtr_EndEvent_Public_Void_0;

		// Token: 0x04007E39 RID: 32313
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000CF2 RID: 3314
		[ObfuscatedName("ScheduleOne.UI.RegionUnlockedCanvas+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600F6B9 RID: 63161 RVA: 0x003B2E14 File Offset: 0x003B1014
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RegionUnlockedCanvas.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegionUnlockedCanvas.__c>.NativeClassPtr);
				RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionUnlockedCanvas.__c>.NativeClassPtr, "<>9");
				RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionUnlockedCanvas.__c>.NativeClassPtr, "<>9__15_0");
				RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9__15_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionUnlockedCanvas.__c>.NativeClassPtr, "<>9__15_1");
				RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9__15_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionUnlockedCanvas.__c>.NativeClassPtr, "<>9__15_2");
				RegionUnlockedCanvas.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas.__c>.NativeClassPtr, 100687347);
				RegionUnlockedCanvas.__c.NativeMethodInfoPtr__StartEvent_b__15_0_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas.__c>.NativeClassPtr, 100687348);
				RegionUnlockedCanvas.__c.NativeMethodInfoPtr__StartEvent_b__15_1_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas.__c>.NativeClassPtr, 100687349);
				RegionUnlockedCanvas.__c.NativeMethodInfoPtr__StartEvent_b__15_2_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas.__c>.NativeClassPtr, 100687350);
			}

			// Token: 0x0600F6BA RID: 63162 RVA: 0x003B2EE0 File Offset: 0x003B10E0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegionUnlockedCanvas.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F6BB RID: 63163 RVA: 0x003B2F1C File Offset: 0x003B111C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308485, XrefRangeEnd = 308493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StartEvent_b__15_0(NPC x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.__c.NativeMethodInfoPtr__StartEvent_b__15_0_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F6BC RID: 63164 RVA: 0x003B2F6C File Offset: 0x003B116C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308493, XrefRangeEnd = 308496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StartEvent_b__15_1(NPC x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.__c.NativeMethodInfoPtr__StartEvent_b__15_1_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F6BD RID: 63165 RVA: 0x003B2FBC File Offset: 0x003B11BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308496, XrefRangeEnd = 308498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StartEvent_b__15_2(NPC x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.__c.NativeMethodInfoPtr__StartEvent_b__15_2_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F6BE RID: 63166 RVA: 0x00074A9F File Offset: 0x00072C9F
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B06 RID: 19206
			// (get) Token: 0x0600F6BF RID: 63167 RVA: 0x003B300C File Offset: 0x003B120C
			// (set) Token: 0x0600F6C0 RID: 63168 RVA: 0x00074AA8 File Offset: 0x00072CA8
			public unsafe static RegionUnlockedCanvas.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegionUnlockedCanvas.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B07 RID: 19207
			// (get) Token: 0x0600F6C1 RID: 63169 RVA: 0x003B3034 File Offset: 0x003B1234
			// (set) Token: 0x0600F6C2 RID: 63170 RVA: 0x00074ABA File Offset: 0x00072CBA
			public unsafe static Func<NPC, bool> __9__15_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NPC, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B08 RID: 19208
			// (get) Token: 0x0600F6C3 RID: 63171 RVA: 0x003B305C File Offset: 0x003B125C
			// (set) Token: 0x0600F6C4 RID: 63172 RVA: 0x00074ACC File Offset: 0x00072CCC
			public unsafe static Func<NPC, bool> __9__15_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9__15_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NPC, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9__15_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B09 RID: 19209
			// (get) Token: 0x0600F6C5 RID: 63173 RVA: 0x003B3084 File Offset: 0x003B1284
			// (set) Token: 0x0600F6C6 RID: 63174 RVA: 0x00074ADE File Offset: 0x00072CDE
			public unsafe static Func<NPC, bool> __9__15_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9__15_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NPC, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9__15_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A6E4 RID: 42724
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A6E5 RID: 42725
			private static readonly IntPtr NativeFieldInfoPtr___9__15_0;

			// Token: 0x0400A6E6 RID: 42726
			private static readonly IntPtr NativeFieldInfoPtr___9__15_1;

			// Token: 0x0400A6E7 RID: 42727
			private static readonly IntPtr NativeFieldInfoPtr___9__15_2;

			// Token: 0x0400A6E8 RID: 42728
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A6E9 RID: 42729
			private static readonly IntPtr NativeMethodInfoPtr__StartEvent_b__15_0_Internal_Boolean_NPC_0;

			// Token: 0x0400A6EA RID: 42730
			private static readonly IntPtr NativeMethodInfoPtr__StartEvent_b__15_1_Internal_Boolean_NPC_0;

			// Token: 0x0400A6EB RID: 42731
			private static readonly IntPtr NativeMethodInfoPtr__StartEvent_b__15_2_Internal_Boolean_NPC_0;
		}
	}
}
