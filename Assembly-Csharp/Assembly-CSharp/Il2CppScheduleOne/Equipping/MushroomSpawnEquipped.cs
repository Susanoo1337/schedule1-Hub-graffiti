using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using UnityEngine;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x02000589 RID: 1417
	public class MushroomSpawnEquipped : Equippable_Viewmodel
	{
		// Token: 0x0600814D RID: 33101 RVA: 0x00236DCC File Offset: 0x00234FCC
		// Note: this type is marked as 'beforefieldinit'.
		static MushroomSpawnEquipped()
		{
			Il2CppClassPointerStore<MushroomSpawnEquipped>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "MushroomSpawnEquipped");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MushroomSpawnEquipped>.NativeClassPtr);
			MushroomSpawnEquipped.NativeFieldInfoPtr_InteractionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MushroomSpawnEquipped>.NativeClassPtr, "InteractionRange");
			MushroomSpawnEquipped.NativeFieldInfoPtr__InteractionLabel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MushroomSpawnEquipped>.NativeClassPtr, "<InteractionLabel>k__BackingField");
			MushroomSpawnEquipped.NativeFieldInfoPtr__taskPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MushroomSpawnEquipped>.NativeClassPtr, "_taskPrefab");
			MushroomSpawnEquipped.NativeMethodInfoPtr_get_InteractionLabel_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomSpawnEquipped>.NativeClassPtr, 100679908);
			MushroomSpawnEquipped.NativeMethodInfoPtr_set_InteractionLabel_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomSpawnEquipped>.NativeClassPtr, 100679909);
			MushroomSpawnEquipped.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomSpawnEquipped>.NativeClassPtr, 100679910);
			MushroomSpawnEquipped.NativeMethodInfoPtr_CanApplyToMushroomBed_Protected_Virtual_New_Boolean_MushroomBed_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomSpawnEquipped>.NativeClassPtr, 100679911);
			MushroomSpawnEquipped.NativeMethodInfoPtr_StartTask_Protected_Void_MushroomBed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomSpawnEquipped>.NativeClassPtr, 100679912);
			MushroomSpawnEquipped.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomSpawnEquipped>.NativeClassPtr, 100679913);
		}

		// Token: 0x17002801 RID: 10241
		// (get) Token: 0x0600814E RID: 33102 RVA: 0x00236EB0 File Offset: 0x002350B0
		// (set) Token: 0x0600814F RID: 33103 RVA: 0x00236EE8 File Offset: 0x002350E8
		public unsafe string InteractionLabel
		{
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 43093, RefRangeEnd = 43137, XrefRangeStart = 43093, XrefRangeEnd = 43137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomSpawnEquipped.NativeMethodInfoPtr_get_InteractionLabel_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomSpawnEquipped.NativeMethodInfoPtr_set_InteractionLabel_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008150 RID: 33104 RVA: 0x00236F2C File Offset: 0x0023512C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244896, XrefRangeEnd = 244926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MushroomSpawnEquipped.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008151 RID: 33105 RVA: 0x00236F68 File Offset: 0x00235168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244926, XrefRangeEnd = 244940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanApplyToMushroomBed(MushroomBed bed, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(bed);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MushroomSpawnEquipped.NativeMethodInfoPtr_CanApplyToMushroomBed_Protected_Virtual_New_Boolean_MushroomBed_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06008152 RID: 33106 RVA: 0x00236FDC File Offset: 0x002351DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244940, XrefRangeEnd = 244948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartTask(MushroomBed growContainer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(growContainer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomSpawnEquipped.NativeMethodInfoPtr_StartTask_Protected_Void_MushroomBed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008153 RID: 33107 RVA: 0x00237020 File Offset: 0x00235220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244948, XrefRangeEnd = 244955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MushroomSpawnEquipped() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MushroomSpawnEquipped>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomSpawnEquipped.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008154 RID: 33108 RVA: 0x0003D86A File Offset: 0x0003BA6A
		public MushroomSpawnEquipped(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027FE RID: 10238
		// (get) Token: 0x06008155 RID: 33109 RVA: 0x0023705C File Offset: 0x0023525C
		// (set) Token: 0x06008156 RID: 33110 RVA: 0x0003D873 File Offset: 0x0003BA73
		public unsafe static float InteractionRange
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(MushroomSpawnEquipped.NativeFieldInfoPtr_InteractionRange, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MushroomSpawnEquipped.NativeFieldInfoPtr_InteractionRange, (void*)(&value));
			}
		}

		// Token: 0x170027FF RID: 10239
		// (get) Token: 0x06008157 RID: 33111 RVA: 0x00237078 File Offset: 0x00235278
		// (set) Token: 0x06008158 RID: 33112 RVA: 0x0003D881 File Offset: 0x0003BA81
		public unsafe string _InteractionLabel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomSpawnEquipped.NativeFieldInfoPtr__InteractionLabel_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomSpawnEquipped.NativeFieldInfoPtr__InteractionLabel_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002800 RID: 10240
		// (get) Token: 0x06008159 RID: 33113 RVA: 0x002370A0 File Offset: 0x002352A0
		// (set) Token: 0x0600815A RID: 33114 RVA: 0x0003D8A0 File Offset: 0x0003BAA0
		public unsafe GameObject _taskPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomSpawnEquipped.NativeFieldInfoPtr__taskPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomSpawnEquipped.NativeFieldInfoPtr__taskPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005825 RID: 22565
		private static readonly IntPtr NativeFieldInfoPtr_InteractionRange;

		// Token: 0x04005826 RID: 22566
		private static readonly IntPtr NativeFieldInfoPtr__InteractionLabel_k__BackingField;

		// Token: 0x04005827 RID: 22567
		private static readonly IntPtr NativeFieldInfoPtr__taskPrefab;

		// Token: 0x04005828 RID: 22568
		private static readonly IntPtr NativeMethodInfoPtr_get_InteractionLabel_Private_get_String_0;

		// Token: 0x04005829 RID: 22569
		private static readonly IntPtr NativeMethodInfoPtr_set_InteractionLabel_Private_set_Void_String_0;

		// Token: 0x0400582A RID: 22570
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x0400582B RID: 22571
		private static readonly IntPtr NativeMethodInfoPtr_CanApplyToMushroomBed_Protected_Virtual_New_Boolean_MushroomBed_byref_String_0;

		// Token: 0x0400582C RID: 22572
		private static readonly IntPtr NativeMethodInfoPtr_StartTask_Protected_Void_MushroomBed_0;

		// Token: 0x0400582D RID: 22573
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
