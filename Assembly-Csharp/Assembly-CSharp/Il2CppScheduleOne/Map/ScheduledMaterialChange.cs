using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020002C5 RID: 709
	public class ScheduledMaterialChange : MonoBehaviour
	{
		// Token: 0x0600370D RID: 14093 RVA: 0x0013220C File Offset: 0x0013040C
		// Note: this type is marked as 'beforefieldinit'.
		static ScheduledMaterialChange()
		{
			Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "ScheduledMaterialChange");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr);
			ScheduledMaterialChange.NativeFieldInfoPtr_Renderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "Renderers");
			ScheduledMaterialChange.NativeFieldInfoPtr_MaterialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "MaterialIndex");
			ScheduledMaterialChange.NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "Enabled");
			ScheduledMaterialChange.NativeFieldInfoPtr_LogState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "LogState");
			ScheduledMaterialChange.NativeFieldInfoPtr_OutsideTimeRangeMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "OutsideTimeRangeMaterial");
			ScheduledMaterialChange.NativeFieldInfoPtr_InsideTimeRangeMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "InsideTimeRangeMaterial");
			ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "TimeRangeMin");
			ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "TimeRangeMax");
			ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "TimeRangeShift");
			ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeRandomization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "TimeRangeRandomization");
			ScheduledMaterialChange.NativeFieldInfoPtr_TurnOnChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "TurnOnChance");
			ScheduledMaterialChange.NativeFieldInfoPtr_TurnOffChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "TurnOffChance");
			ScheduledMaterialChange.NativeFieldInfoPtr_appliedInsideTimeRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "appliedInsideTimeRange");
			ScheduledMaterialChange.NativeFieldInfoPtr_onState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "onState");
			ScheduledMaterialChange.NativeFieldInfoPtr_randomShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "randomShift");
			ScheduledMaterialChange.NativeFieldInfoPtr__shouldTurnOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "_shouldTurnOn");
			ScheduledMaterialChange.NativeFieldInfoPtr__shouldTurnOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "_shouldTurnOff");
			ScheduledMaterialChange.NativeFieldInfoPtr__lastOnState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "_lastOnState");
			ScheduledMaterialChange.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, 100670255);
			ScheduledMaterialChange.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, 100670256);
			ScheduledMaterialChange.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, 100670257);
			ScheduledMaterialChange.NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, 100670258);
			ScheduledMaterialChange.NativeMethodInfoPtr_SetOnOffStatus_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, 100670259);
			ScheduledMaterialChange.NativeMethodInfoPtr_SetMaterial_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, 100670260);
			ScheduledMaterialChange.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, 100670261);
		}

		// Token: 0x0600370E RID: 14094 RVA: 0x00132430 File Offset: 0x00130630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142934, XrefRangeEnd = 142971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScheduledMaterialChange.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600370F RID: 14095 RVA: 0x0013246C File Offset: 0x0013066C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142971, XrefRangeEnd = 143001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScheduledMaterialChange.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003710 RID: 14096 RVA: 0x001324A0 File Offset: 0x001306A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143001, XrefRangeEnd = 143004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScheduledMaterialChange.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003711 RID: 14097 RVA: 0x001324D4 File Offset: 0x001306D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143004, XrefRangeEnd = 143042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnUncappedMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScheduledMaterialChange.NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003712 RID: 14098 RVA: 0x00132510 File Offset: 0x00130710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOnOffStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScheduledMaterialChange.NativeMethodInfoPtr_SetOnOffStatus_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003713 RID: 14099 RVA: 0x00132544 File Offset: 0x00130744
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 143047, RefRangeEnd = 143050, XrefRangeStart = 143042, XrefRangeEnd = 143047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaterial(bool insideTimeRange)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref insideTimeRange;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScheduledMaterialChange.NativeMethodInfoPtr_SetMaterial_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003714 RID: 14100 RVA: 0x00132584 File Offset: 0x00130784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143050, XrefRangeEnd = 143051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScheduledMaterialChange() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScheduledMaterialChange.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003715 RID: 14101 RVA: 0x0001BFB3 File Offset: 0x0001A1B3
		public ScheduledMaterialChange(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001167 RID: 4455
		// (get) Token: 0x06003716 RID: 14102 RVA: 0x001325C0 File Offset: 0x001307C0
		// (set) Token: 0x06003717 RID: 14103 RVA: 0x0001BFBC File Offset: 0x0001A1BC
		public unsafe Il2CppReferenceArray<MeshRenderer> Renderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_Renderers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_Renderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001168 RID: 4456
		// (get) Token: 0x06003718 RID: 14104 RVA: 0x001325F0 File Offset: 0x001307F0
		// (set) Token: 0x06003719 RID: 14105 RVA: 0x0001BFDB File Offset: 0x0001A1DB
		public unsafe int MaterialIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_MaterialIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_MaterialIndex)) = value;
			}
		}

		// Token: 0x17001169 RID: 4457
		// (get) Token: 0x0600371A RID: 14106 RVA: 0x00132618 File Offset: 0x00130818
		// (set) Token: 0x0600371B RID: 14107 RVA: 0x0001BFF6 File Offset: 0x0001A1F6
		public unsafe bool Enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_Enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_Enabled)) = value;
			}
		}

		// Token: 0x1700116A RID: 4458
		// (get) Token: 0x0600371C RID: 14108 RVA: 0x00132640 File Offset: 0x00130840
		// (set) Token: 0x0600371D RID: 14109 RVA: 0x0001C011 File Offset: 0x0001A211
		public unsafe bool LogState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_LogState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_LogState)) = value;
			}
		}

		// Token: 0x1700116B RID: 4459
		// (get) Token: 0x0600371E RID: 14110 RVA: 0x00132668 File Offset: 0x00130868
		// (set) Token: 0x0600371F RID: 14111 RVA: 0x0001C02C File Offset: 0x0001A22C
		public unsafe Material OutsideTimeRangeMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_OutsideTimeRangeMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_OutsideTimeRangeMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700116C RID: 4460
		// (get) Token: 0x06003720 RID: 14112 RVA: 0x00132698 File Offset: 0x00130898
		// (set) Token: 0x06003721 RID: 14113 RVA: 0x0001C04B File Offset: 0x0001A24B
		public unsafe Material InsideTimeRangeMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_InsideTimeRangeMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_InsideTimeRangeMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700116D RID: 4461
		// (get) Token: 0x06003722 RID: 14114 RVA: 0x001326C8 File Offset: 0x001308C8
		// (set) Token: 0x06003723 RID: 14115 RVA: 0x0001C06A File Offset: 0x0001A26A
		public unsafe int TimeRangeMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeMin)) = value;
			}
		}

		// Token: 0x1700116E RID: 4462
		// (get) Token: 0x06003724 RID: 14116 RVA: 0x001326F0 File Offset: 0x001308F0
		// (set) Token: 0x06003725 RID: 14117 RVA: 0x0001C085 File Offset: 0x0001A285
		public unsafe int TimeRangeMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeMax)) = value;
			}
		}

		// Token: 0x1700116F RID: 4463
		// (get) Token: 0x06003726 RID: 14118 RVA: 0x00132718 File Offset: 0x00130918
		// (set) Token: 0x06003727 RID: 14119 RVA: 0x0001C0A0 File Offset: 0x0001A2A0
		public unsafe int TimeRangeShift
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeShift);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeShift)) = value;
			}
		}

		// Token: 0x17001170 RID: 4464
		// (get) Token: 0x06003728 RID: 14120 RVA: 0x00132740 File Offset: 0x00130940
		// (set) Token: 0x06003729 RID: 14121 RVA: 0x0001C0BB File Offset: 0x0001A2BB
		public unsafe int TimeRangeRandomization
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeRandomization);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeRandomization)) = value;
			}
		}

		// Token: 0x17001171 RID: 4465
		// (get) Token: 0x0600372A RID: 14122 RVA: 0x00132768 File Offset: 0x00130968
		// (set) Token: 0x0600372B RID: 14123 RVA: 0x0001C0D6 File Offset: 0x0001A2D6
		public unsafe float TurnOnChance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_TurnOnChance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_TurnOnChance)) = value;
			}
		}

		// Token: 0x17001172 RID: 4466
		// (get) Token: 0x0600372C RID: 14124 RVA: 0x00132790 File Offset: 0x00130990
		// (set) Token: 0x0600372D RID: 14125 RVA: 0x0001C0F1 File Offset: 0x0001A2F1
		public unsafe float TurnOffChance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_TurnOffChance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_TurnOffChance)) = value;
			}
		}

		// Token: 0x17001173 RID: 4467
		// (get) Token: 0x0600372E RID: 14126 RVA: 0x001327B8 File Offset: 0x001309B8
		// (set) Token: 0x0600372F RID: 14127 RVA: 0x0001C10C File Offset: 0x0001A30C
		public unsafe bool appliedInsideTimeRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_appliedInsideTimeRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_appliedInsideTimeRange)) = value;
			}
		}

		// Token: 0x17001174 RID: 4468
		// (get) Token: 0x06003730 RID: 14128 RVA: 0x001327E0 File Offset: 0x001309E0
		// (set) Token: 0x06003731 RID: 14129 RVA: 0x0001C127 File Offset: 0x0001A327
		public unsafe ScheduledMaterialChange.EOnState onState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_onState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_onState)) = value;
			}
		}

		// Token: 0x17001175 RID: 4469
		// (get) Token: 0x06003732 RID: 14130 RVA: 0x00132808 File Offset: 0x00130A08
		// (set) Token: 0x06003733 RID: 14131 RVA: 0x0001C142 File Offset: 0x0001A342
		public unsafe int randomShift
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_randomShift);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_randomShift)) = value;
			}
		}

		// Token: 0x17001176 RID: 4470
		// (get) Token: 0x06003734 RID: 14132 RVA: 0x00132830 File Offset: 0x00130A30
		// (set) Token: 0x06003735 RID: 14133 RVA: 0x0001C15D File Offset: 0x0001A35D
		public unsafe bool _shouldTurnOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr__shouldTurnOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr__shouldTurnOn)) = value;
			}
		}

		// Token: 0x17001177 RID: 4471
		// (get) Token: 0x06003736 RID: 14134 RVA: 0x00132858 File Offset: 0x00130A58
		// (set) Token: 0x06003737 RID: 14135 RVA: 0x0001C178 File Offset: 0x0001A378
		public unsafe bool _shouldTurnOff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr__shouldTurnOff);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr__shouldTurnOff)) = value;
			}
		}

		// Token: 0x17001178 RID: 4472
		// (get) Token: 0x06003738 RID: 14136 RVA: 0x00132880 File Offset: 0x00130A80
		// (set) Token: 0x06003739 RID: 14137 RVA: 0x0001C193 File Offset: 0x0001A393
		public unsafe ScheduledMaterialChange.EOnState _lastOnState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr__lastOnState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr__lastOnState)) = value;
			}
		}

		// Token: 0x040024D6 RID: 9430
		private static readonly IntPtr NativeFieldInfoPtr_Renderers;

		// Token: 0x040024D7 RID: 9431
		private static readonly IntPtr NativeFieldInfoPtr_MaterialIndex;

		// Token: 0x040024D8 RID: 9432
		private static readonly IntPtr NativeFieldInfoPtr_Enabled;

		// Token: 0x040024D9 RID: 9433
		private static readonly IntPtr NativeFieldInfoPtr_LogState;

		// Token: 0x040024DA RID: 9434
		private static readonly IntPtr NativeFieldInfoPtr_OutsideTimeRangeMaterial;

		// Token: 0x040024DB RID: 9435
		private static readonly IntPtr NativeFieldInfoPtr_InsideTimeRangeMaterial;

		// Token: 0x040024DC RID: 9436
		private static readonly IntPtr NativeFieldInfoPtr_TimeRangeMin;

		// Token: 0x040024DD RID: 9437
		private static readonly IntPtr NativeFieldInfoPtr_TimeRangeMax;

		// Token: 0x040024DE RID: 9438
		private static readonly IntPtr NativeFieldInfoPtr_TimeRangeShift;

		// Token: 0x040024DF RID: 9439
		private static readonly IntPtr NativeFieldInfoPtr_TimeRangeRandomization;

		// Token: 0x040024E0 RID: 9440
		private static readonly IntPtr NativeFieldInfoPtr_TurnOnChance;

		// Token: 0x040024E1 RID: 9441
		private static readonly IntPtr NativeFieldInfoPtr_TurnOffChance;

		// Token: 0x040024E2 RID: 9442
		private static readonly IntPtr NativeFieldInfoPtr_appliedInsideTimeRange;

		// Token: 0x040024E3 RID: 9443
		private static readonly IntPtr NativeFieldInfoPtr_onState;

		// Token: 0x040024E4 RID: 9444
		private static readonly IntPtr NativeFieldInfoPtr_randomShift;

		// Token: 0x040024E5 RID: 9445
		private static readonly IntPtr NativeFieldInfoPtr__shouldTurnOn;

		// Token: 0x040024E6 RID: 9446
		private static readonly IntPtr NativeFieldInfoPtr__shouldTurnOff;

		// Token: 0x040024E7 RID: 9447
		private static readonly IntPtr NativeFieldInfoPtr__lastOnState;

		// Token: 0x040024E8 RID: 9448
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x040024E9 RID: 9449
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040024EA RID: 9450
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

		// Token: 0x040024EB RID: 9451
		private static readonly IntPtr NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_New_Void_0;

		// Token: 0x040024EC RID: 9452
		private static readonly IntPtr NativeMethodInfoPtr_SetOnOffStatus_Private_Void_0;

		// Token: 0x040024ED RID: 9453
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterial_Private_Void_Boolean_0;

		// Token: 0x040024EE RID: 9454
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A1B RID: 2587
		[OriginalName("Assembly-CSharp.dll", "", "EOnState")]
		public enum EOnState
		{
			// Token: 0x04009782 RID: 38786
			Undecided,
			// Token: 0x04009783 RID: 38787
			On,
			// Token: 0x04009784 RID: 38788
			Off
		}
	}
}
