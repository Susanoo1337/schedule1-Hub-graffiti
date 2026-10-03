using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Gamepad;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x0200051C RID: 1308
	public class PlantHarvestable : MonoBehaviour
	{
		// Token: 0x060076CF RID: 30415 RVA: 0x002111C0 File Offset: 0x0020F3C0
		// Note: this type is marked as 'beforefieldinit'.
		static PlantHarvestable()
		{
			Il2CppClassPointerStore<PlantHarvestable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "PlantHarvestable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlantHarvestable>.NativeClassPtr);
			PlantHarvestable.NativeFieldInfoPtr_Product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlantHarvestable>.NativeClassPtr, "Product");
			PlantHarvestable.NativeFieldInfoPtr_ProductQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlantHarvestable>.NativeClassPtr, "ProductQuantity");
			PlantHarvestable.NativeFieldInfoPtr__gamepadLure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlantHarvestable>.NativeClassPtr, "_gamepadLure");
			PlantHarvestable.NativeFieldInfoPtr__gamepadLureLocationOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlantHarvestable>.NativeClassPtr, "_gamepadLureLocationOverride");
			PlantHarvestable.NativeFieldInfoPtr__isLureActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlantHarvestable>.NativeClassPtr, "_isLureActive");
			PlantHarvestable.NativeFieldInfoPtr__ScheduleOne_Gamepad_IGamepadPointerLure_Offset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlantHarvestable>.NativeClassPtr, "<ScheduleOne.Gamepad.IGamepadPointerLure.Offset>k__BackingField");
			PlantHarvestable.NativeMethodInfoPtr_get_GamepadLure_Public_get_IGamepadPointerLure_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlantHarvestable>.NativeClassPtr, 100678561);
			PlantHarvestable.NativeMethodInfoPtr_get_RegisterDefaultLureWhenEmpty_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlantHarvestable>.NativeClassPtr, 100678562);
			PlantHarvestable.NativeMethodInfoPtr_ScheduleOne_Gamepad_IGamepadPointerLure_get_Data_Private_Virtual_Final_New_get_GamepadPointerLureData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlantHarvestable>.NativeClassPtr, 100678563);
			PlantHarvestable.NativeMethodInfoPtr_ScheduleOne_Gamepad_IGamepadPointerLure_get_IsActive_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlantHarvestable>.NativeClassPtr, 100678564);
			PlantHarvestable.NativeMethodInfoPtr_ScheduleOne_Gamepad_IGamepadPointerLure_get_Position_Private_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlantHarvestable>.NativeClassPtr, 100678565);
			PlantHarvestable.NativeMethodInfoPtr_ScheduleOne_Gamepad_IGamepadPointerLure_get_Offset_Private_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlantHarvestable>.NativeClassPtr, 100678566);
			PlantHarvestable.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlantHarvestable>.NativeClassPtr, 100678567);
			PlantHarvestable.NativeMethodInfoPtr_Start_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlantHarvestable>.NativeClassPtr, 100678568);
			PlantHarvestable.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlantHarvestable>.NativeClassPtr, 100678569);
			PlantHarvestable.NativeMethodInfoPtr_Harvest_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlantHarvestable>.NativeClassPtr, 100678570);
			PlantHarvestable.NativeMethodInfoPtr_ScheduleOne_Gamepad_IGamepadPointerLure_SetActive_Private_Virtual_Final_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlantHarvestable>.NativeClassPtr, 100678571);
			PlantHarvestable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlantHarvestable>.NativeClassPtr, 100678572);
		}

		// Token: 0x170024C4 RID: 9412
		// (get) Token: 0x060076D0 RID: 30416 RVA: 0x00211358 File Offset: 0x0020F558
		public unsafe IGamepadPointerLure GamepadLure
		{
			[CallerCount(1485)]
			[CachedScanResults(RefRangeStart = 115488, RefRangeEnd = 116973, XrefRangeStart = 115488, XrefRangeEnd = 116973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlantHarvestable.NativeMethodInfoPtr_get_GamepadLure_Public_get_IGamepadPointerLure_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IGamepadPointerLure>(intPtr3) : null;
			}
		}

		// Token: 0x170024C5 RID: 9413
		// (get) Token: 0x060076D1 RID: 30417 RVA: 0x00211398 File Offset: 0x0020F598
		public unsafe virtual bool RegisterDefaultLureWhenEmpty
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 29255, RefRangeEnd = 29273, XrefRangeStart = 29255, XrefRangeEnd = 29273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlantHarvestable.NativeMethodInfoPtr_get_RegisterDefaultLureWhenEmpty_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170024C6 RID: 9414
		// (get) Token: 0x060076D2 RID: 30418 RVA: 0x002113E0 File Offset: 0x0020F5E0
		public unsafe virtual GamepadPointerLureData Data
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 2964, RefRangeEnd = 2977, XrefRangeStart = 2964, XrefRangeEnd = 2977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlantHarvestable.NativeMethodInfoPtr_ScheduleOne_Gamepad_IGamepadPointerLure_get_Data_Private_Virtual_Final_New_get_GamepadPointerLureData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GamepadPointerLureData>(intPtr3) : null;
			}
		}

		// Token: 0x170024C7 RID: 9415
		// (get) Token: 0x060076D3 RID: 30419 RVA: 0x00211420 File Offset: 0x0020F620
		public unsafe virtual bool IsActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlantHarvestable.NativeMethodInfoPtr_ScheduleOne_Gamepad_IGamepadPointerLure_get_IsActive_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170024C8 RID: 9416
		// (get) Token: 0x060076D4 RID: 30420 RVA: 0x0021145C File Offset: 0x0020F65C
		public unsafe virtual Vector3 Position
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230239, XrefRangeEnd = 230244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlantHarvestable.NativeMethodInfoPtr_ScheduleOne_Gamepad_IGamepadPointerLure_get_Position_Private_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170024C9 RID: 9417
		// (get) Token: 0x060076D5 RID: 30421 RVA: 0x00211498 File Offset: 0x0020F698
		public unsafe virtual Vector3 Offset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlantHarvestable.NativeMethodInfoPtr_ScheduleOne_Gamepad_IGamepadPointerLure_get_Offset_Private_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060076D6 RID: 30422 RVA: 0x002114D4 File Offset: 0x0020F6D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230244, XrefRangeEnd = 230249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlantHarvestable.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076D7 RID: 30423 RVA: 0x00211508 File Offset: 0x0020F708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230249, XrefRangeEnd = 230267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlantHarvestable.NativeMethodInfoPtr_Start_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076D8 RID: 30424 RVA: 0x00211544 File Offset: 0x0020F744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230267, XrefRangeEnd = 230279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlantHarvestable.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076D9 RID: 30425 RVA: 0x00211578 File Offset: 0x0020F778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230279, XrefRangeEnd = 230367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Harvest(bool giveProduct = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref giveProduct;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlantHarvestable.NativeMethodInfoPtr_Harvest_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076DA RID: 30426 RVA: 0x002115C4 File Offset: 0x0020F7C4
		[CallerCount(0)]
		public unsafe virtual void ScheduleOne_Gamepad_IGamepadPointerLure_SetActive(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlantHarvestable.NativeMethodInfoPtr_ScheduleOne_Gamepad_IGamepadPointerLure_SetActive_Private_Virtual_Final_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076DB RID: 30427 RVA: 0x00211604 File Offset: 0x0020F804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230367, XrefRangeEnd = 230368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlantHarvestable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlantHarvestable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlantHarvestable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076DC RID: 30428 RVA: 0x00038BAC File Offset: 0x00036DAC
		public PlantHarvestable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024BE RID: 9406
		// (get) Token: 0x060076DD RID: 30429 RVA: 0x00211640 File Offset: 0x0020F840
		// (set) Token: 0x060076DE RID: 30430 RVA: 0x00038BB5 File Offset: 0x00036DB5
		public unsafe StorableItemDefinition Product
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantHarvestable.NativeFieldInfoPtr_Product);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantHarvestable.NativeFieldInfoPtr_Product), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024BF RID: 9407
		// (get) Token: 0x060076DF RID: 30431 RVA: 0x00211670 File Offset: 0x0020F870
		// (set) Token: 0x060076E0 RID: 30432 RVA: 0x00038BD4 File Offset: 0x00036DD4
		public unsafe int ProductQuantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantHarvestable.NativeFieldInfoPtr_ProductQuantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantHarvestable.NativeFieldInfoPtr_ProductQuantity)) = value;
			}
		}

		// Token: 0x170024C0 RID: 9408
		// (get) Token: 0x060076E1 RID: 30433 RVA: 0x00211698 File Offset: 0x0020F898
		// (set) Token: 0x060076E2 RID: 30434 RVA: 0x00038BEF File Offset: 0x00036DEF
		public unsafe GamepadPointerLureData _gamepadLure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantHarvestable.NativeFieldInfoPtr__gamepadLure);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GamepadPointerLureData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantHarvestable.NativeFieldInfoPtr__gamepadLure), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024C1 RID: 9409
		// (get) Token: 0x060076E3 RID: 30435 RVA: 0x002116C8 File Offset: 0x0020F8C8
		// (set) Token: 0x060076E4 RID: 30436 RVA: 0x00038C0E File Offset: 0x00036E0E
		public unsafe Transform _gamepadLureLocationOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantHarvestable.NativeFieldInfoPtr__gamepadLureLocationOverride);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantHarvestable.NativeFieldInfoPtr__gamepadLureLocationOverride), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024C2 RID: 9410
		// (get) Token: 0x060076E5 RID: 30437 RVA: 0x002116F8 File Offset: 0x0020F8F8
		// (set) Token: 0x060076E6 RID: 30438 RVA: 0x00038C2D File Offset: 0x00036E2D
		public unsafe bool _isLureActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantHarvestable.NativeFieldInfoPtr__isLureActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantHarvestable.NativeFieldInfoPtr__isLureActive)) = value;
			}
		}

		// Token: 0x170024C3 RID: 9411
		// (get) Token: 0x060076E7 RID: 30439 RVA: 0x00211720 File Offset: 0x0020F920
		// (set) Token: 0x060076E8 RID: 30440 RVA: 0x00038C48 File Offset: 0x00036E48
		public unsafe Vector3 _ScheduleOne_Gamepad_IGamepadPointerLure_Offset_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantHarvestable.NativeFieldInfoPtr__ScheduleOne_Gamepad_IGamepadPointerLure_Offset_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantHarvestable.NativeFieldInfoPtr__ScheduleOne_Gamepad_IGamepadPointerLure_Offset_k__BackingField)) = value;
			}
		}

		// Token: 0x040050EC RID: 20716
		private static readonly IntPtr NativeFieldInfoPtr_Product;

		// Token: 0x040050ED RID: 20717
		private static readonly IntPtr NativeFieldInfoPtr_ProductQuantity;

		// Token: 0x040050EE RID: 20718
		private static readonly IntPtr NativeFieldInfoPtr__gamepadLure;

		// Token: 0x040050EF RID: 20719
		private static readonly IntPtr NativeFieldInfoPtr__gamepadLureLocationOverride;

		// Token: 0x040050F0 RID: 20720
		private static readonly IntPtr NativeFieldInfoPtr__isLureActive;

		// Token: 0x040050F1 RID: 20721
		private static readonly IntPtr NativeFieldInfoPtr__ScheduleOne_Gamepad_IGamepadPointerLure_Offset_k__BackingField;

		// Token: 0x040050F2 RID: 20722
		private static readonly IntPtr NativeMethodInfoPtr_get_GamepadLure_Public_get_IGamepadPointerLure_0;

		// Token: 0x040050F3 RID: 20723
		private static readonly IntPtr NativeMethodInfoPtr_get_RegisterDefaultLureWhenEmpty_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040050F4 RID: 20724
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleOne_Gamepad_IGamepadPointerLure_get_Data_Private_Virtual_Final_New_get_GamepadPointerLureData_0;

		// Token: 0x040050F5 RID: 20725
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleOne_Gamepad_IGamepadPointerLure_get_IsActive_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040050F6 RID: 20726
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleOne_Gamepad_IGamepadPointerLure_get_Position_Private_Virtual_Final_New_get_Vector3_0;

		// Token: 0x040050F7 RID: 20727
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleOne_Gamepad_IGamepadPointerLure_get_Offset_Private_Virtual_Final_New_get_Vector3_0;

		// Token: 0x040050F8 RID: 20728
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040050F9 RID: 20729
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_New_Void_0;

		// Token: 0x040050FA RID: 20730
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040050FB RID: 20731
		private static readonly IntPtr NativeMethodInfoPtr_Harvest_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x040050FC RID: 20732
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleOne_Gamepad_IGamepadPointerLure_SetActive_Private_Virtual_Final_New_Void_Boolean_0;

		// Token: 0x040050FD RID: 20733
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
