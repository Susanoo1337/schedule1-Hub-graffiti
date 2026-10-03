using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Map;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Cartel
{
	// Token: 0x02000442 RID: 1090
	public class CartelActivity : MonoBehaviour
	{
		// Token: 0x06006290 RID: 25232 RVA: 0x001D0994 File Offset: 0x001CEB94
		// Note: this type is marked as 'beforefieldinit'.
		static CartelActivity()
		{
			Il2CppClassPointerStore<CartelActivity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Cartel", "CartelActivity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CartelActivity>.NativeClassPtr);
			CartelActivity.NativeFieldInfoPtr__IsActive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelActivity>.NativeClassPtr, "<IsActive>k__BackingField");
			CartelActivity.NativeFieldInfoPtr__MinsSinceActivation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelActivity>.NativeClassPtr, "<MinsSinceActivation>k__BackingField");
			CartelActivity.NativeFieldInfoPtr__Region_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelActivity>.NativeClassPtr, "<Region>k__BackingField");
			CartelActivity.NativeFieldInfoPtr_InfluenceRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelActivity>.NativeClassPtr, "InfluenceRequirement");
			CartelActivity.NativeFieldInfoPtr_onActivated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelActivity>.NativeClassPtr, "onActivated");
			CartelActivity.NativeFieldInfoPtr_onDeactivated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelActivity>.NativeClassPtr, "onDeactivated");
			CartelActivity.NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelActivity>.NativeClassPtr, 100676234);
			CartelActivity.NativeMethodInfoPtr_set_IsActive_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelActivity>.NativeClassPtr, 100676235);
			CartelActivity.NativeMethodInfoPtr_get_MinsSinceActivation_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelActivity>.NativeClassPtr, 100676236);
			CartelActivity.NativeMethodInfoPtr_set_MinsSinceActivation_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelActivity>.NativeClassPtr, 100676237);
			CartelActivity.NativeMethodInfoPtr_get_Region_Public_get_EMapRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelActivity>.NativeClassPtr, 100676238);
			CartelActivity.NativeMethodInfoPtr_set_Region_Protected_set_Void_EMapRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelActivity>.NativeClassPtr, 100676239);
			CartelActivity.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelActivity>.NativeClassPtr, 100676240);
			CartelActivity.NativeMethodInfoPtr_Activate_Public_Virtual_New_Void_EMapRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelActivity>.NativeClassPtr, 100676241);
			CartelActivity.NativeMethodInfoPtr_MinPassed_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelActivity>.NativeClassPtr, 100676242);
			CartelActivity.NativeMethodInfoPtr_HourPassed_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelActivity>.NativeClassPtr, 100676243);
			CartelActivity.NativeMethodInfoPtr_Deactivate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelActivity>.NativeClassPtr, 100676244);
			CartelActivity.NativeMethodInfoPtr_IsRegionValidForActivity_Public_Virtual_New_Boolean_EMapRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelActivity>.NativeClassPtr, 100676245);
			CartelActivity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelActivity>.NativeClassPtr, 100676246);
		}

		// Token: 0x17001E50 RID: 7760
		// (get) Token: 0x06006291 RID: 25233 RVA: 0x001D0B40 File Offset: 0x001CED40
		// (set) Token: 0x06006292 RID: 25234 RVA: 0x001D0B7C File Offset: 0x001CED7C
		public unsafe bool IsActive
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelActivity.NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 30482, RefRangeEnd = 30484, XrefRangeStart = 30482, XrefRangeEnd = 30484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelActivity.NativeMethodInfoPtr_set_IsActive_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E51 RID: 7761
		// (get) Token: 0x06006293 RID: 25235 RVA: 0x001D0BBC File Offset: 0x001CEDBC
		// (set) Token: 0x06006294 RID: 25236 RVA: 0x001D0BF8 File Offset: 0x001CEDF8
		public unsafe int MinsSinceActivation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelActivity.NativeMethodInfoPtr_get_MinsSinceActivation_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29041, RefRangeEnd = 29043, XrefRangeStart = 29041, XrefRangeEnd = 29043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelActivity.NativeMethodInfoPtr_set_MinsSinceActivation_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E52 RID: 7762
		// (get) Token: 0x06006295 RID: 25237 RVA: 0x001D0C38 File Offset: 0x001CEE38
		// (set) Token: 0x06006296 RID: 25238 RVA: 0x001D0C74 File Offset: 0x001CEE74
		public unsafe EMapRegion Region
		{
			[CallerCount(29)]
			[CachedScanResults(RefRangeStart = 29072, RefRangeEnd = 29101, XrefRangeStart = 29072, XrefRangeEnd = 29101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelActivity.NativeMethodInfoPtr_get_Region_Public_get_EMapRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29101, RefRangeEnd = 29102, XrefRangeStart = 29101, XrefRangeEnd = 29102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelActivity.NativeMethodInfoPtr_set_Region_Protected_set_Void_EMapRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006297 RID: 25239 RVA: 0x001D0CB4 File Offset: 0x001CEEB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208120, XrefRangeEnd = 208144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelActivity.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006298 RID: 25240 RVA: 0x001D0CE8 File Offset: 0x001CEEE8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 208155, RefRangeEnd = 208160, XrefRangeStart = 208144, XrefRangeEnd = 208155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Activate(EMapRegion region)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref region;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartelActivity.NativeMethodInfoPtr_Activate_Public_Virtual_New_Void_EMapRegion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006299 RID: 25241 RVA: 0x001D0D34 File Offset: 0x001CEF34
		[CallerCount(0)]
		public unsafe virtual void MinPassed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartelActivity.NativeMethodInfoPtr_MinPassed_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600629A RID: 25242 RVA: 0x001D0D70 File Offset: 0x001CEF70
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HourPassed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartelActivity.NativeMethodInfoPtr_HourPassed_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600629B RID: 25243 RVA: 0x001D0DAC File Offset: 0x001CEFAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 208171, RefRangeEnd = 208173, XrefRangeStart = 208160, XrefRangeEnd = 208171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Deactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartelActivity.NativeMethodInfoPtr_Deactivate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600629C RID: 25244 RVA: 0x001D0DE8 File Offset: 0x001CEFE8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 208179, RefRangeEnd = 208184, XrefRangeStart = 208173, XrefRangeEnd = 208179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsRegionValidForActivity(EMapRegion region)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref region;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartelActivity.NativeMethodInfoPtr_IsRegionValidForActivity_Public_Virtual_New_Boolean_EMapRegion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600629D RID: 25245 RVA: 0x001D0E3C File Offset: 0x001CF03C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CartelActivity() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CartelActivity>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelActivity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600629E RID: 25246 RVA: 0x0002E925 File Offset: 0x0002CB25
		public CartelActivity(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E4A RID: 7754
		// (get) Token: 0x0600629F RID: 25247 RVA: 0x001D0E78 File Offset: 0x001CF078
		// (set) Token: 0x060062A0 RID: 25248 RVA: 0x0002E92E File Offset: 0x0002CB2E
		public unsafe bool _IsActive_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelActivity.NativeFieldInfoPtr__IsActive_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelActivity.NativeFieldInfoPtr__IsActive_k__BackingField)) = value;
			}
		}

		// Token: 0x17001E4B RID: 7755
		// (get) Token: 0x060062A1 RID: 25249 RVA: 0x001D0EA0 File Offset: 0x001CF0A0
		// (set) Token: 0x060062A2 RID: 25250 RVA: 0x0002E949 File Offset: 0x0002CB49
		public unsafe int _MinsSinceActivation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelActivity.NativeFieldInfoPtr__MinsSinceActivation_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelActivity.NativeFieldInfoPtr__MinsSinceActivation_k__BackingField)) = value;
			}
		}

		// Token: 0x17001E4C RID: 7756
		// (get) Token: 0x060062A3 RID: 25251 RVA: 0x001D0EC8 File Offset: 0x001CF0C8
		// (set) Token: 0x060062A4 RID: 25252 RVA: 0x0002E964 File Offset: 0x0002CB64
		public unsafe EMapRegion _Region_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelActivity.NativeFieldInfoPtr__Region_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelActivity.NativeFieldInfoPtr__Region_k__BackingField)) = value;
			}
		}

		// Token: 0x17001E4D RID: 7757
		// (get) Token: 0x060062A5 RID: 25253 RVA: 0x001D0EF0 File Offset: 0x001CF0F0
		// (set) Token: 0x060062A6 RID: 25254 RVA: 0x0002E97F File Offset: 0x0002CB7F
		public unsafe float InfluenceRequirement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelActivity.NativeFieldInfoPtr_InfluenceRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelActivity.NativeFieldInfoPtr_InfluenceRequirement)) = value;
			}
		}

		// Token: 0x17001E4E RID: 7758
		// (get) Token: 0x060062A7 RID: 25255 RVA: 0x001D0F18 File Offset: 0x001CF118
		// (set) Token: 0x060062A8 RID: 25256 RVA: 0x0002E99A File Offset: 0x0002CB9A
		public unsafe Action onActivated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelActivity.NativeFieldInfoPtr_onActivated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelActivity.NativeFieldInfoPtr_onActivated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E4F RID: 7759
		// (get) Token: 0x060062A9 RID: 25257 RVA: 0x001D0F48 File Offset: 0x001CF148
		// (set) Token: 0x060062AA RID: 25258 RVA: 0x0002E9B9 File Offset: 0x0002CBB9
		public unsafe Action onDeactivated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelActivity.NativeFieldInfoPtr_onDeactivated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelActivity.NativeFieldInfoPtr_onDeactivated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040043EC RID: 17388
		private static readonly IntPtr NativeFieldInfoPtr__IsActive_k__BackingField;

		// Token: 0x040043ED RID: 17389
		private static readonly IntPtr NativeFieldInfoPtr__MinsSinceActivation_k__BackingField;

		// Token: 0x040043EE RID: 17390
		private static readonly IntPtr NativeFieldInfoPtr__Region_k__BackingField;

		// Token: 0x040043EF RID: 17391
		private static readonly IntPtr NativeFieldInfoPtr_InfluenceRequirement;

		// Token: 0x040043F0 RID: 17392
		private static readonly IntPtr NativeFieldInfoPtr_onActivated;

		// Token: 0x040043F1 RID: 17393
		private static readonly IntPtr NativeFieldInfoPtr_onDeactivated;

		// Token: 0x040043F2 RID: 17394
		private static readonly IntPtr NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0;

		// Token: 0x040043F3 RID: 17395
		private static readonly IntPtr NativeMethodInfoPtr_set_IsActive_Protected_set_Void_Boolean_0;

		// Token: 0x040043F4 RID: 17396
		private static readonly IntPtr NativeMethodInfoPtr_get_MinsSinceActivation_Public_get_Int32_0;

		// Token: 0x040043F5 RID: 17397
		private static readonly IntPtr NativeMethodInfoPtr_set_MinsSinceActivation_Protected_set_Void_Int32_0;

		// Token: 0x040043F6 RID: 17398
		private static readonly IntPtr NativeMethodInfoPtr_get_Region_Public_get_EMapRegion_0;

		// Token: 0x040043F7 RID: 17399
		private static readonly IntPtr NativeMethodInfoPtr_set_Region_Protected_set_Void_EMapRegion_0;

		// Token: 0x040043F8 RID: 17400
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040043F9 RID: 17401
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Virtual_New_Void_EMapRegion_0;

		// Token: 0x040043FA RID: 17402
		private static readonly IntPtr NativeMethodInfoPtr_MinPassed_Protected_Virtual_New_Void_0;

		// Token: 0x040043FB RID: 17403
		private static readonly IntPtr NativeMethodInfoPtr_HourPassed_Protected_Virtual_New_Void_0;

		// Token: 0x040043FC RID: 17404
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Protected_Virtual_New_Void_0;

		// Token: 0x040043FD RID: 17405
		private static readonly IntPtr NativeMethodInfoPtr_IsRegionValidForActivity_Public_Virtual_New_Boolean_EMapRegion_0;

		// Token: 0x040043FE RID: 17406
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
