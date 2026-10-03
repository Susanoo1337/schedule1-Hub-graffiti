using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.Tools;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x02000181 RID: 385
	public class FillWaterContainer : Task
	{
		// Token: 0x06002729 RID: 10025 RVA: 0x000FC920 File Offset: 0x000FAB20
		// Note: this type is marked as 'beforefieldinit'.
		static FillWaterContainer()
		{
			Il2CppClassPointerStore<FillWaterContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "FillWaterContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FillWaterContainer>.NativeClassPtr);
			FillWaterContainer.NativeFieldInfoPtr__TaskName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FillWaterContainer>.NativeClassPtr, "<TaskName>k__BackingField");
			FillWaterContainer.NativeFieldInfoPtr__tap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FillWaterContainer>.NativeClassPtr, "_tap");
			FillWaterContainer.NativeFieldInfoPtr__waterContainerItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FillWaterContainer>.NativeClassPtr, "_waterContainerItem");
			FillWaterContainer.NativeFieldInfoPtr__fillable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FillWaterContainer>.NativeClassPtr, "_fillable");
			FillWaterContainer.NativeMethodInfoPtr_get_TaskName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FillWaterContainer>.NativeClassPtr, 100668316);
			FillWaterContainer.NativeMethodInfoPtr_set_TaskName_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FillWaterContainer>.NativeClassPtr, 100668317);
			FillWaterContainer.NativeMethodInfoPtr__ctor_Public_Void_Tap_WaterContainerInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FillWaterContainer>.NativeClassPtr, 100668318);
			FillWaterContainer.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FillWaterContainer>.NativeClassPtr, 100668319);
			FillWaterContainer.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FillWaterContainer>.NativeClassPtr, 100668320);
			FillWaterContainer.NativeMethodInfoPtr_UpdateInstruction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FillWaterContainer>.NativeClassPtr, 100668321);
			FillWaterContainer.NativeMethodInfoPtr_UpdateFillSound_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FillWaterContainer>.NativeClassPtr, 100668322);
		}

		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x0600272A RID: 10026 RVA: 0x000FCA2C File Offset: 0x000FAC2C
		// (set) Token: 0x0600272B RID: 10027 RVA: 0x000FCA64 File Offset: 0x000FAC64
		public new unsafe string TaskName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FillWaterContainer.NativeMethodInfoPtr_get_TaskName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FillWaterContainer.NativeMethodInfoPtr_set_TaskName_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600272C RID: 10028 RVA: 0x000FCAA8 File Offset: 0x000FACA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 118854, RefRangeEnd = 118855, XrefRangeStart = 118817, XrefRangeEnd = 118854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FillWaterContainer(Tap tap, WaterContainerInstance waterContainerItem) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FillWaterContainer>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tap);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(waterContainerItem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FillWaterContainer.NativeMethodInfoPtr__ctor_Public_Void_Tap_WaterContainerInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600272D RID: 10029 RVA: 0x000FCB08 File Offset: 0x000FAD08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118855, XrefRangeEnd = 118877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FillWaterContainer.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600272E RID: 10030 RVA: 0x000FCB44 File Offset: 0x000FAD44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118877, XrefRangeEnd = 118886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FillWaterContainer.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600272F RID: 10031 RVA: 0x000FCB80 File Offset: 0x000FAD80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 118898, RefRangeEnd = 118900, XrefRangeStart = 118886, XrefRangeEnd = 118898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInstruction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FillWaterContainer.NativeMethodInfoPtr_UpdateInstruction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002730 RID: 10032 RVA: 0x000FCBB4 File Offset: 0x000FADB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 118911, RefRangeEnd = 118912, XrefRangeStart = 118900, XrefRangeEnd = 118911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFillSound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FillWaterContainer.NativeMethodInfoPtr_UpdateFillSound_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002731 RID: 10033 RVA: 0x000149DB File Offset: 0x00012BDB
		public FillWaterContainer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x06002732 RID: 10034 RVA: 0x000FCBE8 File Offset: 0x000FADE8
		// (set) Token: 0x06002733 RID: 10035 RVA: 0x000149E4 File Offset: 0x00012BE4
		public new unsafe string _TaskName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FillWaterContainer.NativeFieldInfoPtr__TaskName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FillWaterContainer.NativeFieldInfoPtr__TaskName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x06002734 RID: 10036 RVA: 0x000FCC10 File Offset: 0x000FAE10
		// (set) Token: 0x06002735 RID: 10037 RVA: 0x00014A03 File Offset: 0x00012C03
		public unsafe Tap _tap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FillWaterContainer.NativeFieldInfoPtr__tap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FillWaterContainer.NativeFieldInfoPtr__tap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE5 RID: 3301
		// (get) Token: 0x06002736 RID: 10038 RVA: 0x000FCC40 File Offset: 0x000FAE40
		// (set) Token: 0x06002737 RID: 10039 RVA: 0x00014A22 File Offset: 0x00012C22
		public unsafe WaterContainerInstance _waterContainerItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FillWaterContainer.NativeFieldInfoPtr__waterContainerItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaterContainerInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FillWaterContainer.NativeFieldInfoPtr__waterContainerItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE6 RID: 3302
		// (get) Token: 0x06002738 RID: 10040 RVA: 0x000FCC70 File Offset: 0x000FAE70
		// (set) Token: 0x06002739 RID: 10041 RVA: 0x00014A41 File Offset: 0x00012C41
		public unsafe FillableWaterContainer _fillable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FillWaterContainer.NativeFieldInfoPtr__fillable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FillableWaterContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FillWaterContainer.NativeFieldInfoPtr__fillable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001AFC RID: 6908
		private static readonly IntPtr NativeFieldInfoPtr__TaskName_k__BackingField;

		// Token: 0x04001AFD RID: 6909
		private static readonly IntPtr NativeFieldInfoPtr__tap;

		// Token: 0x04001AFE RID: 6910
		private static readonly IntPtr NativeFieldInfoPtr__waterContainerItem;

		// Token: 0x04001AFF RID: 6911
		private static readonly IntPtr NativeFieldInfoPtr__fillable;

		// Token: 0x04001B00 RID: 6912
		private static readonly IntPtr NativeMethodInfoPtr_get_TaskName_Public_get_String_0;

		// Token: 0x04001B01 RID: 6913
		private static readonly IntPtr NativeMethodInfoPtr_set_TaskName_Protected_set_Void_String_0;

		// Token: 0x04001B02 RID: 6914
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Tap_WaterContainerInstance_0;

		// Token: 0x04001B03 RID: 6915
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;

		// Token: 0x04001B04 RID: 6916
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001B05 RID: 6917
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInstruction_Private_Void_0;

		// Token: 0x04001B06 RID: 6918
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFillSound_Private_Void_0;
	}
}
