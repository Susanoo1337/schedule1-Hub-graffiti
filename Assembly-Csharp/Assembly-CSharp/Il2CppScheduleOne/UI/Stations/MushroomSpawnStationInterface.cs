using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.StationFramework;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Stations
{
	// Token: 0x02000782 RID: 1922
	public class MushroomSpawnStationInterface : StationInterface<MushroomSpawnStationInterface>
	{
		// Token: 0x0600BB51 RID: 47953 RVA: 0x00302478 File Offset: 0x00300678
		// Note: this type is marked as 'beforefieldinit'.
		static MushroomSpawnStationInterface()
		{
			Il2CppClassPointerStore<MushroomSpawnStationInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Stations", "MushroomSpawnStationInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MushroomSpawnStationInterface>.NativeClassPtr);
			MushroomSpawnStationInterface.NativeFieldInfoPtr__beginButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MushroomSpawnStationInterface>.NativeClassPtr, "_beginButton");
			MushroomSpawnStationInterface.NativeFieldInfoPtr__instructionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MushroomSpawnStationInterface>.NativeClassPtr, "_instructionLabel");
			MushroomSpawnStationInterface.NativeFieldInfoPtr__grainBagSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MushroomSpawnStationInterface>.NativeClassPtr, "_grainBagSlotUI");
			MushroomSpawnStationInterface.NativeFieldInfoPtr__syringeSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MushroomSpawnStationInterface>.NativeClassPtr, "_syringeSlotUI");
			MushroomSpawnStationInterface.NativeFieldInfoPtr__outputSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MushroomSpawnStationInterface>.NativeClassPtr, "_outputSlotUI");
			MushroomSpawnStationInterface.NativeFieldInfoPtr__Station_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MushroomSpawnStationInterface>.NativeClassPtr, "<Station>k__BackingField");
			MushroomSpawnStationInterface.NativeMethodInfoPtr_get_Station_Public_get_MushroomSpawnStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomSpawnStationInterface>.NativeClassPtr, 100687737);
			MushroomSpawnStationInterface.NativeMethodInfoPtr_set_Station_Private_set_Void_MushroomSpawnStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomSpawnStationInterface>.NativeClassPtr, 100687738);
			MushroomSpawnStationInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomSpawnStationInterface>.NativeClassPtr, 100687739);
			MushroomSpawnStationInterface.NativeMethodInfoPtr_Open_Public_Void_MushroomSpawnStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomSpawnStationInterface>.NativeClassPtr, 100687740);
			MushroomSpawnStationInterface.NativeMethodInfoPtr_OnBeginButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomSpawnStationInterface>.NativeClassPtr, 100687741);
			MushroomSpawnStationInterface.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomSpawnStationInterface>.NativeClassPtr, 100687742);
			MushroomSpawnStationInterface.NativeMethodInfoPtr_StationContentsChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomSpawnStationInterface>.NativeClassPtr, 100687743);
			MushroomSpawnStationInterface.NativeMethodInfoPtr_UpdateInstruction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomSpawnStationInterface>.NativeClassPtr, 100687744);
			MushroomSpawnStationInterface.NativeMethodInfoPtr_CanBeginTask_Private_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomSpawnStationInterface>.NativeClassPtr, 100687745);
			MushroomSpawnStationInterface.NativeMethodInfoPtr_UpdateBeginButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomSpawnStationInterface>.NativeClassPtr, 100687746);
			MushroomSpawnStationInterface.NativeMethodInfoPtr_BeginTask_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomSpawnStationInterface>.NativeClassPtr, 100687747);
			MushroomSpawnStationInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomSpawnStationInterface>.NativeClassPtr, 100687748);
		}

		// Token: 0x170038AD RID: 14509
		// (get) Token: 0x0600BB52 RID: 47954 RVA: 0x00302610 File Offset: 0x00300810
		// (set) Token: 0x0600BB53 RID: 47955 RVA: 0x00302650 File Offset: 0x00300850
		public unsafe MushroomSpawnStation Station
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22015, RefRangeEnd = 22016, XrefRangeStart = 22015, XrefRangeEnd = 22016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomSpawnStationInterface.NativeMethodInfoPtr_get_Station_Public_get_MushroomSpawnStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MushroomSpawnStation>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomSpawnStationInterface.NativeMethodInfoPtr_set_Station_Private_set_Void_MushroomSpawnStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600BB54 RID: 47956 RVA: 0x00302694 File Offset: 0x00300894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312652, XrefRangeEnd = 312663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MushroomSpawnStationInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BB55 RID: 47957 RVA: 0x003026D0 File Offset: 0x003008D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 312689, RefRangeEnd = 312691, XrefRangeStart = 312663, XrefRangeEnd = 312689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(MushroomSpawnStation station)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(station);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomSpawnStationInterface.NativeMethodInfoPtr_Open_Public_Void_MushroomSpawnStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BB56 RID: 47958 RVA: 0x00302714 File Offset: 0x00300914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312691, XrefRangeEnd = 312714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBeginButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomSpawnStationInterface.NativeMethodInfoPtr_OnBeginButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BB57 RID: 47959 RVA: 0x00302748 File Offset: 0x00300948
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 312737, RefRangeEnd = 312740, XrefRangeStart = 312714, XrefRangeEnd = 312737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomSpawnStationInterface.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BB58 RID: 47960 RVA: 0x0030277C File Offset: 0x0030097C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312740, XrefRangeEnd = 312744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StationContentsChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomSpawnStationInterface.NativeMethodInfoPtr_StationContentsChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BB59 RID: 47961 RVA: 0x003027B0 File Offset: 0x003009B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 312746, RefRangeEnd = 312747, XrefRangeStart = 312744, XrefRangeEnd = 312746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInstruction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomSpawnStationInterface.NativeMethodInfoPtr_UpdateInstruction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BB5A RID: 47962 RVA: 0x003027E4 File Offset: 0x003009E4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 312758, RefRangeEnd = 312764, XrefRangeStart = 312747, XrefRangeEnd = 312758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanBeginTask(out string instruction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MushroomSpawnStationInterface.NativeMethodInfoPtr_CanBeginTask_Private_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			instruction = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600BB5B RID: 47963 RVA: 0x0030283C File Offset: 0x00300A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312764, XrefRangeEnd = 312766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBeginButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomSpawnStationInterface.NativeMethodInfoPtr_UpdateBeginButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BB5C RID: 47964 RVA: 0x00302870 File Offset: 0x00300A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312766, XrefRangeEnd = 312791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomSpawnStationInterface.NativeMethodInfoPtr_BeginTask_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BB5D RID: 47965 RVA: 0x003028A4 File Offset: 0x00300AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312791, XrefRangeEnd = 312794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MushroomSpawnStationInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MushroomSpawnStationInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomSpawnStationInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BB5E RID: 47966 RVA: 0x000576A6 File Offset: 0x000558A6
		public MushroomSpawnStationInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038A7 RID: 14503
		// (get) Token: 0x0600BB5F RID: 47967 RVA: 0x003028E0 File Offset: 0x00300AE0
		// (set) Token: 0x0600BB60 RID: 47968 RVA: 0x000576AF File Offset: 0x000558AF
		public unsafe Button _beginButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomSpawnStationInterface.NativeFieldInfoPtr__beginButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomSpawnStationInterface.NativeFieldInfoPtr__beginButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038A8 RID: 14504
		// (get) Token: 0x0600BB61 RID: 47969 RVA: 0x00302910 File Offset: 0x00300B10
		// (set) Token: 0x0600BB62 RID: 47970 RVA: 0x000576CE File Offset: 0x000558CE
		public unsafe TextMeshProUGUI _instructionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomSpawnStationInterface.NativeFieldInfoPtr__instructionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomSpawnStationInterface.NativeFieldInfoPtr__instructionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038A9 RID: 14505
		// (get) Token: 0x0600BB63 RID: 47971 RVA: 0x00302940 File Offset: 0x00300B40
		// (set) Token: 0x0600BB64 RID: 47972 RVA: 0x000576ED File Offset: 0x000558ED
		public unsafe ItemSlotUI _grainBagSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomSpawnStationInterface.NativeFieldInfoPtr__grainBagSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomSpawnStationInterface.NativeFieldInfoPtr__grainBagSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038AA RID: 14506
		// (get) Token: 0x0600BB65 RID: 47973 RVA: 0x00302970 File Offset: 0x00300B70
		// (set) Token: 0x0600BB66 RID: 47974 RVA: 0x0005770C File Offset: 0x0005590C
		public unsafe ItemSlotUI _syringeSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomSpawnStationInterface.NativeFieldInfoPtr__syringeSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomSpawnStationInterface.NativeFieldInfoPtr__syringeSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038AB RID: 14507
		// (get) Token: 0x0600BB67 RID: 47975 RVA: 0x003029A0 File Offset: 0x00300BA0
		// (set) Token: 0x0600BB68 RID: 47976 RVA: 0x0005772B File Offset: 0x0005592B
		public unsafe ItemSlotUI _outputSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomSpawnStationInterface.NativeFieldInfoPtr__outputSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomSpawnStationInterface.NativeFieldInfoPtr__outputSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038AC RID: 14508
		// (get) Token: 0x0600BB69 RID: 47977 RVA: 0x003029D0 File Offset: 0x00300BD0
		// (set) Token: 0x0600BB6A RID: 47978 RVA: 0x0005774A File Offset: 0x0005594A
		public unsafe MushroomSpawnStation _Station_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomSpawnStationInterface.NativeFieldInfoPtr__Station_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MushroomSpawnStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomSpawnStationInterface.NativeFieldInfoPtr__Station_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008065 RID: 32869
		private static readonly IntPtr NativeFieldInfoPtr__beginButton;

		// Token: 0x04008066 RID: 32870
		private static readonly IntPtr NativeFieldInfoPtr__instructionLabel;

		// Token: 0x04008067 RID: 32871
		private static readonly IntPtr NativeFieldInfoPtr__grainBagSlotUI;

		// Token: 0x04008068 RID: 32872
		private static readonly IntPtr NativeFieldInfoPtr__syringeSlotUI;

		// Token: 0x04008069 RID: 32873
		private static readonly IntPtr NativeFieldInfoPtr__outputSlotUI;

		// Token: 0x0400806A RID: 32874
		private static readonly IntPtr NativeFieldInfoPtr__Station_k__BackingField;

		// Token: 0x0400806B RID: 32875
		private static readonly IntPtr NativeMethodInfoPtr_get_Station_Public_get_MushroomSpawnStation_0;

		// Token: 0x0400806C RID: 32876
		private static readonly IntPtr NativeMethodInfoPtr_set_Station_Private_set_Void_MushroomSpawnStation_0;

		// Token: 0x0400806D RID: 32877
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400806E RID: 32878
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_MushroomSpawnStation_0;

		// Token: 0x0400806F RID: 32879
		private static readonly IntPtr NativeMethodInfoPtr_OnBeginButtonPressed_Public_Void_0;

		// Token: 0x04008070 RID: 32880
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04008071 RID: 32881
		private static readonly IntPtr NativeMethodInfoPtr_StationContentsChanged_Private_Void_0;

		// Token: 0x04008072 RID: 32882
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInstruction_Private_Void_0;

		// Token: 0x04008073 RID: 32883
		private static readonly IntPtr NativeMethodInfoPtr_CanBeginTask_Private_Boolean_byref_String_0;

		// Token: 0x04008074 RID: 32884
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBeginButton_Private_Void_0;

		// Token: 0x04008075 RID: 32885
		private static readonly IntPtr NativeMethodInfoPtr_BeginTask_Private_Void_0;

		// Token: 0x04008076 RID: 32886
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D0E RID: 3342
		[ObfuscatedName("ScheduleOne.UI.Stations.MushroomSpawnStationInterface+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Object
		{
			// Token: 0x0600F7D0 RID: 63440 RVA: 0x003B6088 File Offset: 0x003B4288
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<MushroomSpawnStationInterface.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MushroomSpawnStationInterface>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MushroomSpawnStationInterface.__c__DisplayClass17_0>.NativeClassPtr);
				MushroomSpawnStationInterface.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MushroomSpawnStationInterface.__c__DisplayClass17_0>.NativeClassPtr, "<>4__this");
				MushroomSpawnStationInterface.__c__DisplayClass17_0.NativeFieldInfoPtr__station = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MushroomSpawnStationInterface.__c__DisplayClass17_0>.NativeClassPtr, "_station");
				MushroomSpawnStationInterface.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomSpawnStationInterface.__c__DisplayClass17_0>.NativeClassPtr, 100687749);
				MushroomSpawnStationInterface.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomSpawnStationInterface.__c__DisplayClass17_0>.NativeClassPtr, 100687750);
			}

			// Token: 0x0600F7D1 RID: 63441 RVA: 0x003B6104 File Offset: 0x003B4304
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MushroomSpawnStationInterface.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomSpawnStationInterface.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F7D2 RID: 63442 RVA: 0x003B6140 File Offset: 0x003B4340
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312646, XrefRangeEnd = 312652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomSpawnStationInterface.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F7D3 RID: 63443 RVA: 0x000752F7 File Offset: 0x000734F7
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B58 RID: 19288
			// (get) Token: 0x0600F7D4 RID: 63444 RVA: 0x003B6174 File Offset: 0x003B4374
			// (set) Token: 0x0600F7D5 RID: 63445 RVA: 0x00075300 File Offset: 0x00073500
			public unsafe MushroomSpawnStationInterface __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomSpawnStationInterface.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MushroomSpawnStationInterface>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomSpawnStationInterface.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B59 RID: 19289
			// (get) Token: 0x0600F7D6 RID: 63446 RVA: 0x003B61A4 File Offset: 0x003B43A4
			// (set) Token: 0x0600F7D7 RID: 63447 RVA: 0x0007531F File Offset: 0x0007351F
			public unsafe MushroomSpawnStation _station
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomSpawnStationInterface.__c__DisplayClass17_0.NativeFieldInfoPtr__station);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MushroomSpawnStation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomSpawnStationInterface.__c__DisplayClass17_0.NativeFieldInfoPtr__station), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A789 RID: 42889
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A78A RID: 42890
			private static readonly IntPtr NativeFieldInfoPtr__station;

			// Token: 0x0400A78B RID: 42891
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A78C RID: 42892
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}
	}
}
