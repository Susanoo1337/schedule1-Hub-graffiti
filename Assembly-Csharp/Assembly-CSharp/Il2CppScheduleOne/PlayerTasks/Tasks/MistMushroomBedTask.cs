using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerTasks.Tasks
{
	// Token: 0x0200018F RID: 399
	public class MistMushroomBedTask : Task
	{
		// Token: 0x06002884 RID: 10372 RVA: 0x00100E00 File Offset: 0x000FF000
		// Note: this type is marked as 'beforefieldinit'.
		static MistMushroomBedTask()
		{
			Il2CppClassPointerStore<MistMushroomBedTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks.Tasks", "MistMushroomBedTask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MistMushroomBedTask>.NativeClassPtr);
			MistMushroomBedTask.NativeFieldInfoPtr__TaskName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MistMushroomBedTask>.NativeClassPtr, "<TaskName>k__BackingField");
			MistMushroomBedTask.NativeFieldInfoPtr_TARGET_SPRAY_RADIUS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MistMushroomBedTask>.NativeClassPtr, "TARGET_SPRAY_RADIUS");
			MistMushroomBedTask.NativeFieldInfoPtr_TARGET_SPRAY_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MistMushroomBedTask>.NativeClassPtr, "TARGET_SPRAY_DISTANCE");
			MistMushroomBedTask.NativeFieldInfoPtr__mushroomBed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MistMushroomBedTask>.NativeClassPtr, "_mushroomBed");
			MistMushroomBedTask.NativeFieldInfoPtr__sprayable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MistMushroomBedTask>.NativeClassPtr, "_sprayable");
			MistMushroomBedTask.NativeFieldInfoPtr__sprayableObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MistMushroomBedTask>.NativeClassPtr, "_sprayableObj");
			MistMushroomBedTask.NativeFieldInfoPtr__waterContainerInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MistMushroomBedTask>.NativeClassPtr, "_waterContainerInstance");
			MistMushroomBedTask.NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MistMushroomBedTask>.NativeClassPtr, 100668481);
			MistMushroomBedTask.NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MistMushroomBedTask>.NativeClassPtr, 100668482);
			MistMushroomBedTask.NativeMethodInfoPtr__ctor_Public_Void_MushroomBed_ItemInstance_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MistMushroomBedTask>.NativeClassPtr, 100668483);
			MistMushroomBedTask.NativeMethodInfoPtr_OnSuccessfulSpray_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MistMushroomBedTask>.NativeClassPtr, 100668484);
			MistMushroomBedTask.NativeMethodInfoPtr_OnSpray_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MistMushroomBedTask>.NativeClassPtr, 100668485);
			MistMushroomBedTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MistMushroomBedTask>.NativeClassPtr, 100668486);
		}

		// Token: 0x17000D59 RID: 3417
		// (get) Token: 0x06002885 RID: 10373 RVA: 0x00100F34 File Offset: 0x000FF134
		// (set) Token: 0x06002886 RID: 10374 RVA: 0x00100F78 File Offset: 0x000FF178
		public unsafe override string TaskName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MistMushroomBedTask.NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MistMushroomBedTask.NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002887 RID: 10375 RVA: 0x00100FC8 File Offset: 0x000FF1C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 121395, RefRangeEnd = 121396, XrefRangeStart = 121294, XrefRangeEnd = 121395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MistMushroomBedTask(MushroomBed mushroomBed, ItemInstance item, GameObject sprayablePrefab) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MistMushroomBedTask>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mushroomBed);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sprayablePrefab);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MistMushroomBedTask.NativeMethodInfoPtr__ctor_Public_Void_MushroomBed_ItemInstance_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002888 RID: 10376 RVA: 0x00101038 File Offset: 0x000FF238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121396, XrefRangeEnd = 121408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSuccessfulSpray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MistMushroomBedTask.NativeMethodInfoPtr_OnSuccessfulSpray_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002889 RID: 10377 RVA: 0x0010106C File Offset: 0x000FF26C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121408, XrefRangeEnd = 121410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSpray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MistMushroomBedTask.NativeMethodInfoPtr_OnSpray_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600288A RID: 10378 RVA: 0x001010A0 File Offset: 0x000FF2A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121410, XrefRangeEnd = 121444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MistMushroomBedTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600288B RID: 10379 RVA: 0x000154BE File Offset: 0x000136BE
		public MistMushroomBedTask(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D52 RID: 3410
		// (get) Token: 0x0600288C RID: 10380 RVA: 0x001010DC File Offset: 0x000FF2DC
		// (set) Token: 0x0600288D RID: 10381 RVA: 0x000154C7 File Offset: 0x000136C7
		public new unsafe string _TaskName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MistMushroomBedTask.NativeFieldInfoPtr__TaskName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MistMushroomBedTask.NativeFieldInfoPtr__TaskName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D53 RID: 3411
		// (get) Token: 0x0600288E RID: 10382 RVA: 0x00101104 File Offset: 0x000FF304
		// (set) Token: 0x0600288F RID: 10383 RVA: 0x000154E6 File Offset: 0x000136E6
		public unsafe static float TARGET_SPRAY_RADIUS
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(MistMushroomBedTask.NativeFieldInfoPtr_TARGET_SPRAY_RADIUS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MistMushroomBedTask.NativeFieldInfoPtr_TARGET_SPRAY_RADIUS, (void*)(&value));
			}
		}

		// Token: 0x17000D54 RID: 3412
		// (get) Token: 0x06002890 RID: 10384 RVA: 0x00101120 File Offset: 0x000FF320
		// (set) Token: 0x06002891 RID: 10385 RVA: 0x000154F4 File Offset: 0x000136F4
		public unsafe static float TARGET_SPRAY_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(MistMushroomBedTask.NativeFieldInfoPtr_TARGET_SPRAY_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MistMushroomBedTask.NativeFieldInfoPtr_TARGET_SPRAY_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x17000D55 RID: 3413
		// (get) Token: 0x06002892 RID: 10386 RVA: 0x0010113C File Offset: 0x000FF33C
		// (set) Token: 0x06002893 RID: 10387 RVA: 0x00015502 File Offset: 0x00013702
		public unsafe MushroomBed _mushroomBed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MistMushroomBedTask.NativeFieldInfoPtr__mushroomBed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MushroomBed>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MistMushroomBedTask.NativeFieldInfoPtr__mushroomBed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D56 RID: 3414
		// (get) Token: 0x06002894 RID: 10388 RVA: 0x0010116C File Offset: 0x000FF36C
		// (set) Token: 0x06002895 RID: 10389 RVA: 0x00015521 File Offset: 0x00013721
		public unsafe Sprayable _sprayable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MistMushroomBedTask.NativeFieldInfoPtr__sprayable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprayable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MistMushroomBedTask.NativeFieldInfoPtr__sprayable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D57 RID: 3415
		// (get) Token: 0x06002896 RID: 10390 RVA: 0x0010119C File Offset: 0x000FF39C
		// (set) Token: 0x06002897 RID: 10391 RVA: 0x00015540 File Offset: 0x00013740
		public unsafe GameObject _sprayableObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MistMushroomBedTask.NativeFieldInfoPtr__sprayableObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MistMushroomBedTask.NativeFieldInfoPtr__sprayableObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D58 RID: 3416
		// (get) Token: 0x06002898 RID: 10392 RVA: 0x001011CC File Offset: 0x000FF3CC
		// (set) Token: 0x06002899 RID: 10393 RVA: 0x0001555F File Offset: 0x0001375F
		public unsafe WaterContainerInstance _waterContainerInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MistMushroomBedTask.NativeFieldInfoPtr__waterContainerInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaterContainerInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MistMushroomBedTask.NativeFieldInfoPtr__waterContainerInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001BDF RID: 7135
		private static readonly IntPtr NativeFieldInfoPtr__TaskName_k__BackingField;

		// Token: 0x04001BE0 RID: 7136
		private static readonly IntPtr NativeFieldInfoPtr_TARGET_SPRAY_RADIUS;

		// Token: 0x04001BE1 RID: 7137
		private static readonly IntPtr NativeFieldInfoPtr_TARGET_SPRAY_DISTANCE;

		// Token: 0x04001BE2 RID: 7138
		private static readonly IntPtr NativeFieldInfoPtr__mushroomBed;

		// Token: 0x04001BE3 RID: 7139
		private static readonly IntPtr NativeFieldInfoPtr__sprayable;

		// Token: 0x04001BE4 RID: 7140
		private static readonly IntPtr NativeFieldInfoPtr__sprayableObj;

		// Token: 0x04001BE5 RID: 7141
		private static readonly IntPtr NativeFieldInfoPtr__waterContainerInstance;

		// Token: 0x04001BE6 RID: 7142
		private static readonly IntPtr NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0;

		// Token: 0x04001BE7 RID: 7143
		private static readonly IntPtr NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0;

		// Token: 0x04001BE8 RID: 7144
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MushroomBed_ItemInstance_GameObject_0;

		// Token: 0x04001BE9 RID: 7145
		private static readonly IntPtr NativeMethodInfoPtr_OnSuccessfulSpray_Private_Void_0;

		// Token: 0x04001BEA RID: 7146
		private static readonly IntPtr NativeMethodInfoPtr_OnSpray_Private_Void_0;

		// Token: 0x04001BEB RID: 7147
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;
	}
}
