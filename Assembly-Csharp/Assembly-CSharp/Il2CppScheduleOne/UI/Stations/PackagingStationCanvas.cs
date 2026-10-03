using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Stations
{
	// Token: 0x02000783 RID: 1923
	public class PackagingStationCanvas : StationInterface<PackagingStationCanvas>
	{
		// Token: 0x0600BB6B RID: 47979 RVA: 0x00302A00 File Offset: 0x00300C00
		// Note: this type is marked as 'beforefieldinit'.
		static PackagingStationCanvas()
		{
			Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Stations", "PackagingStationCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr);
			PackagingStationCanvas.NativeFieldInfoPtr__Station_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "<Station>k__BackingField");
			PackagingStationCanvas.NativeFieldInfoPtr_ShowHintOnOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "ShowHintOnOpen");
			PackagingStationCanvas.NativeFieldInfoPtr_ShowShiftClickHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "ShowShiftClickHint");
			PackagingStationCanvas.NativeFieldInfoPtr_CurrentMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "CurrentMode");
			PackagingStationCanvas.NativeFieldInfoPtr_InstructionWarningColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "InstructionWarningColor");
			PackagingStationCanvas.NativeFieldInfoPtr_PackagingSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "PackagingSlotUI");
			PackagingStationCanvas.NativeFieldInfoPtr_ProductSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "ProductSlotUI");
			PackagingStationCanvas.NativeFieldInfoPtr_OutputSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "OutputSlotUI");
			PackagingStationCanvas.NativeFieldInfoPtr_InstructionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "InstructionLabel");
			PackagingStationCanvas.NativeFieldInfoPtr_BeginButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "BeginButton");
			PackagingStationCanvas.NativeFieldInfoPtr_ModeAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "ModeAnimation");
			PackagingStationCanvas.NativeFieldInfoPtr_ButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "ButtonLabel");
			PackagingStationCanvas.NativeMethodInfoPtr_get_Station_Public_get_PackagingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100687751);
			PackagingStationCanvas.NativeMethodInfoPtr_set_Station_Protected_set_Void_PackagingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100687752);
			PackagingStationCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100687753);
			PackagingStationCanvas.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100687754);
			PackagingStationCanvas.NativeMethodInfoPtr_UpdateUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100687755);
			PackagingStationCanvas.NativeMethodInfoPtr_Open_Public_Void_PackagingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100687756);
			PackagingStationCanvas.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100687757);
			PackagingStationCanvas.NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100687758);
			PackagingStationCanvas.NativeMethodInfoPtr_BeginPackagingTask_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100687759);
			PackagingStationCanvas.NativeMethodInfoPtr_RepeatPackagingTask_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100687760);
			PackagingStationCanvas.NativeMethodInfoPtr_ToggleMode_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100687761);
			PackagingStationCanvas.NativeMethodInfoPtr_SetMode_Public_Void_EMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100687762);
			PackagingStationCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100687763);
		}

		// Token: 0x170038BA RID: 14522
		// (get) Token: 0x0600BB6C RID: 47980 RVA: 0x00302C24 File Offset: 0x00300E24
		// (set) Token: 0x0600BB6D RID: 47981 RVA: 0x00302C64 File Offset: 0x00300E64
		public unsafe PackagingStation Station
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationCanvas.NativeMethodInfoPtr_get_Station_Public_get_PackagingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PackagingStation>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationCanvas.NativeMethodInfoPtr_set_Station_Protected_set_Void_PackagingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600BB6E RID: 47982 RVA: 0x00302CA8 File Offset: 0x00300EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312811, XrefRangeEnd = 312822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagingStationCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BB6F RID: 47983 RVA: 0x00302CE4 File Offset: 0x00300EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312822, XrefRangeEnd = 312824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagingStationCanvas.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BB70 RID: 47984 RVA: 0x00302D20 File Offset: 0x00300F20
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 312872, RefRangeEnd = 312875, XrefRangeStart = 312824, XrefRangeEnd = 312872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationCanvas.NativeMethodInfoPtr_UpdateUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BB71 RID: 47985 RVA: 0x00302D54 File Offset: 0x00300F54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 312887, RefRangeEnd = 312888, XrefRangeStart = 312875, XrefRangeEnd = 312887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(PackagingStation station)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(station);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationCanvas.NativeMethodInfoPtr_Open_Public_Void_PackagingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BB72 RID: 47986 RVA: 0x00302D98 File Offset: 0x00300F98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 312893, RefRangeEnd = 312894, XrefRangeStart = 312888, XrefRangeEnd = 312893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationCanvas.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BB73 RID: 47987 RVA: 0x00302DCC File Offset: 0x00300FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312894, XrefRangeEnd = 312902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationCanvas.NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BB74 RID: 47988 RVA: 0x00302E00 File Offset: 0x00301000
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 312926, RefRangeEnd = 312928, XrefRangeStart = 312902, XrefRangeEnd = 312926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginPackagingTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationCanvas.NativeMethodInfoPtr_BeginPackagingTask_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BB75 RID: 47989 RVA: 0x00302E34 File Offset: 0x00301034
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 312929, RefRangeEnd = 312931, XrefRangeStart = 312928, XrefRangeEnd = 312929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RepeatPackagingTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationCanvas.NativeMethodInfoPtr_RepeatPackagingTask_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BB76 RID: 47990 RVA: 0x00302E68 File Offset: 0x00301068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312931, XrefRangeEnd = 312932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationCanvas.NativeMethodInfoPtr_ToggleMode_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BB77 RID: 47991 RVA: 0x00302E9C File Offset: 0x0030109C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 312977, RefRangeEnd = 312978, XrefRangeStart = 312932, XrefRangeEnd = 312977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMode(PackagingStation.EMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationCanvas.NativeMethodInfoPtr_SetMode_Public_Void_EMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BB78 RID: 47992 RVA: 0x00302EDC File Offset: 0x003010DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312978, XrefRangeEnd = 312981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackagingStationCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BB79 RID: 47993 RVA: 0x00057769 File Offset: 0x00055969
		public PackagingStationCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038AE RID: 14510
		// (get) Token: 0x0600BB7A RID: 47994 RVA: 0x00302F18 File Offset: 0x00301118
		// (set) Token: 0x0600BB7B RID: 47995 RVA: 0x00057772 File Offset: 0x00055972
		public unsafe PackagingStation _Station_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr__Station_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr__Station_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038AF RID: 14511
		// (get) Token: 0x0600BB7C RID: 47996 RVA: 0x00302F48 File Offset: 0x00301148
		// (set) Token: 0x0600BB7D RID: 47997 RVA: 0x00057791 File Offset: 0x00055991
		public unsafe bool ShowHintOnOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_ShowHintOnOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_ShowHintOnOpen)) = value;
			}
		}

		// Token: 0x170038B0 RID: 14512
		// (get) Token: 0x0600BB7E RID: 47998 RVA: 0x00302F70 File Offset: 0x00301170
		// (set) Token: 0x0600BB7F RID: 47999 RVA: 0x000577AC File Offset: 0x000559AC
		public unsafe bool ShowShiftClickHint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_ShowShiftClickHint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_ShowShiftClickHint)) = value;
			}
		}

		// Token: 0x170038B1 RID: 14513
		// (get) Token: 0x0600BB80 RID: 48000 RVA: 0x00302F98 File Offset: 0x00301198
		// (set) Token: 0x0600BB81 RID: 48001 RVA: 0x000577C7 File Offset: 0x000559C7
		public unsafe PackagingStation.EMode CurrentMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_CurrentMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_CurrentMode)) = value;
			}
		}

		// Token: 0x170038B2 RID: 14514
		// (get) Token: 0x0600BB82 RID: 48002 RVA: 0x00302FC0 File Offset: 0x003011C0
		// (set) Token: 0x0600BB83 RID: 48003 RVA: 0x000577E2 File Offset: 0x000559E2
		public unsafe Color InstructionWarningColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_InstructionWarningColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_InstructionWarningColor)) = value;
			}
		}

		// Token: 0x170038B3 RID: 14515
		// (get) Token: 0x0600BB84 RID: 48004 RVA: 0x00302FE8 File Offset: 0x003011E8
		// (set) Token: 0x0600BB85 RID: 48005 RVA: 0x000577FD File Offset: 0x000559FD
		public unsafe ItemSlotUI PackagingSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_PackagingSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_PackagingSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038B4 RID: 14516
		// (get) Token: 0x0600BB86 RID: 48006 RVA: 0x00303018 File Offset: 0x00301218
		// (set) Token: 0x0600BB87 RID: 48007 RVA: 0x0005781C File Offset: 0x00055A1C
		public unsafe ItemSlotUI ProductSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_ProductSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_ProductSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038B5 RID: 14517
		// (get) Token: 0x0600BB88 RID: 48008 RVA: 0x00303048 File Offset: 0x00301248
		// (set) Token: 0x0600BB89 RID: 48009 RVA: 0x0005783B File Offset: 0x00055A3B
		public unsafe ItemSlotUI OutputSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_OutputSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_OutputSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038B6 RID: 14518
		// (get) Token: 0x0600BB8A RID: 48010 RVA: 0x00303078 File Offset: 0x00301278
		// (set) Token: 0x0600BB8B RID: 48011 RVA: 0x0005785A File Offset: 0x00055A5A
		public unsafe TextMeshProUGUI InstructionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_InstructionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_InstructionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038B7 RID: 14519
		// (get) Token: 0x0600BB8C RID: 48012 RVA: 0x003030A8 File Offset: 0x003012A8
		// (set) Token: 0x0600BB8D RID: 48013 RVA: 0x00057879 File Offset: 0x00055A79
		public unsafe Button BeginButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_BeginButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_BeginButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038B8 RID: 14520
		// (get) Token: 0x0600BB8E RID: 48014 RVA: 0x003030D8 File Offset: 0x003012D8
		// (set) Token: 0x0600BB8F RID: 48015 RVA: 0x00057898 File Offset: 0x00055A98
		public unsafe Animation ModeAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_ModeAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_ModeAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038B9 RID: 14521
		// (get) Token: 0x0600BB90 RID: 48016 RVA: 0x00303108 File Offset: 0x00301308
		// (set) Token: 0x0600BB91 RID: 48017 RVA: 0x000578B7 File Offset: 0x00055AB7
		public unsafe TextMeshProUGUI ButtonLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_ButtonLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_ButtonLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008077 RID: 32887
		private static readonly IntPtr NativeFieldInfoPtr__Station_k__BackingField;

		// Token: 0x04008078 RID: 32888
		private static readonly IntPtr NativeFieldInfoPtr_ShowHintOnOpen;

		// Token: 0x04008079 RID: 32889
		private static readonly IntPtr NativeFieldInfoPtr_ShowShiftClickHint;

		// Token: 0x0400807A RID: 32890
		private static readonly IntPtr NativeFieldInfoPtr_CurrentMode;

		// Token: 0x0400807B RID: 32891
		private static readonly IntPtr NativeFieldInfoPtr_InstructionWarningColor;

		// Token: 0x0400807C RID: 32892
		private static readonly IntPtr NativeFieldInfoPtr_PackagingSlotUI;

		// Token: 0x0400807D RID: 32893
		private static readonly IntPtr NativeFieldInfoPtr_ProductSlotUI;

		// Token: 0x0400807E RID: 32894
		private static readonly IntPtr NativeFieldInfoPtr_OutputSlotUI;

		// Token: 0x0400807F RID: 32895
		private static readonly IntPtr NativeFieldInfoPtr_InstructionLabel;

		// Token: 0x04008080 RID: 32896
		private static readonly IntPtr NativeFieldInfoPtr_BeginButton;

		// Token: 0x04008081 RID: 32897
		private static readonly IntPtr NativeFieldInfoPtr_ModeAnimation;

		// Token: 0x04008082 RID: 32898
		private static readonly IntPtr NativeFieldInfoPtr_ButtonLabel;

		// Token: 0x04008083 RID: 32899
		private static readonly IntPtr NativeMethodInfoPtr_get_Station_Public_get_PackagingStation_0;

		// Token: 0x04008084 RID: 32900
		private static readonly IntPtr NativeMethodInfoPtr_set_Station_Protected_set_Void_PackagingStation_0;

		// Token: 0x04008085 RID: 32901
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04008086 RID: 32902
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04008087 RID: 32903
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Private_Void_0;

		// Token: 0x04008088 RID: 32904
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_PackagingStation_0;

		// Token: 0x04008089 RID: 32905
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x0400808A RID: 32906
		private static readonly IntPtr NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0;

		// Token: 0x0400808B RID: 32907
		private static readonly IntPtr NativeMethodInfoPtr_BeginPackagingTask_Private_Void_0;

		// Token: 0x0400808C RID: 32908
		private static readonly IntPtr NativeMethodInfoPtr_RepeatPackagingTask_Public_Void_0;

		// Token: 0x0400808D RID: 32909
		private static readonly IntPtr NativeMethodInfoPtr_ToggleMode_Public_Void_0;

		// Token: 0x0400808E RID: 32910
		private static readonly IntPtr NativeMethodInfoPtr_SetMode_Public_Void_EMode_0;

		// Token: 0x0400808F RID: 32911
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D0F RID: 3343
		[ObfuscatedName("ScheduleOne.UI.Stations.PackagingStationCanvas+<>c__DisplayClass21_0")]
		public sealed class __c__DisplayClass21_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F7D8 RID: 63448 RVA: 0x003B61D4 File Offset: 0x003B43D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<PackagingStationCanvas.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "<>c__DisplayClass21_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingStationCanvas.__c__DisplayClass21_0>.NativeClassPtr);
				PackagingStationCanvas.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas.__c__DisplayClass21_0>.NativeClassPtr, "<>4__this");
				PackagingStationCanvas.__c__DisplayClass21_0.NativeFieldInfoPtr_station = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas.__c__DisplayClass21_0>.NativeClassPtr, "station");
				PackagingStationCanvas.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas.__c__DisplayClass21_0>.NativeClassPtr, 100687764);
				PackagingStationCanvas.__c__DisplayClass21_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas.__c__DisplayClass21_0>.NativeClassPtr, 100687765);
			}

			// Token: 0x0600F7D9 RID: 63449 RVA: 0x003B6250 File Offset: 0x003B4450
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingStationCanvas.__c__DisplayClass21_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationCanvas.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F7DA RID: 63450 RVA: 0x003B628C File Offset: 0x003B448C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312794, XrefRangeEnd = 312811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationCanvas.__c__DisplayClass21_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F7DB RID: 63451 RVA: 0x0007533E File Offset: 0x0007353E
			public __c__DisplayClass21_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B5A RID: 19290
			// (get) Token: 0x0600F7DC RID: 63452 RVA: 0x003B62C0 File Offset: 0x003B44C0
			// (set) Token: 0x0600F7DD RID: 63453 RVA: 0x00075347 File Offset: 0x00073547
			public unsafe PackagingStationCanvas __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingStationCanvas>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B5B RID: 19291
			// (get) Token: 0x0600F7DE RID: 63454 RVA: 0x003B62F0 File Offset: 0x003B44F0
			// (set) Token: 0x0600F7DF RID: 63455 RVA: 0x00075366 File Offset: 0x00073566
			public unsafe PackagingStation station
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.__c__DisplayClass21_0.NativeFieldInfoPtr_station);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingStation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.__c__DisplayClass21_0.NativeFieldInfoPtr_station), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A78D RID: 42893
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A78E RID: 42894
			private static readonly IntPtr NativeFieldInfoPtr_station;

			// Token: 0x0400A78F RID: 42895
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A790 RID: 42896
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}
	}
}
