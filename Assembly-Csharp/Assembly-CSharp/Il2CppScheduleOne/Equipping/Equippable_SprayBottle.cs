using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using UnityEngine;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x02000583 RID: 1411
	public class Equippable_SprayBottle : Equippable_Viewmodel
	{
		// Token: 0x060080E9 RID: 33001 RVA: 0x00235784 File Offset: 0x00233984
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_SprayBottle()
		{
			Il2CppClassPointerStore<Equippable_SprayBottle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_SprayBottle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_SprayBottle>.NativeClassPtr);
			Equippable_SprayBottle.NativeFieldInfoPtr_InteractionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_SprayBottle>.NativeClassPtr, "InteractionRange");
			Equippable_SprayBottle.NativeFieldInfoPtr__InteractionLabel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_SprayBottle>.NativeClassPtr, "<InteractionLabel>k__BackingField");
			Equippable_SprayBottle.NativeFieldInfoPtr__sprayablePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_SprayBottle>.NativeClassPtr, "_sprayablePrefab");
			Equippable_SprayBottle.NativeFieldInfoPtr__waterContainerInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_SprayBottle>.NativeClassPtr, "_waterContainerInstance");
			Equippable_SprayBottle.NativeMethodInfoPtr_get_InteractionLabel_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_SprayBottle>.NativeClassPtr, 100679860);
			Equippable_SprayBottle.NativeMethodInfoPtr_set_InteractionLabel_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_SprayBottle>.NativeClassPtr, 100679861);
			Equippable_SprayBottle.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_SprayBottle>.NativeClassPtr, 100679862);
			Equippable_SprayBottle.NativeMethodInfoPtr_CanSpray_Protected_Virtual_New_Boolean_GrowContainer_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_SprayBottle>.NativeClassPtr, 100679863);
			Equippable_SprayBottle.NativeMethodInfoPtr_StartSprayTask_Protected_Void_MushroomBed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_SprayBottle>.NativeClassPtr, 100679864);
			Equippable_SprayBottle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_SprayBottle>.NativeClassPtr, 100679865);
		}

		// Token: 0x170027E7 RID: 10215
		// (get) Token: 0x060080EA RID: 33002 RVA: 0x0023587C File Offset: 0x00233A7C
		// (set) Token: 0x060080EB RID: 33003 RVA: 0x002358B4 File Offset: 0x00233AB4
		public unsafe string InteractionLabel
		{
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 43093, RefRangeEnd = 43137, XrefRangeStart = 43093, XrefRangeEnd = 43137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_SprayBottle.NativeMethodInfoPtr_get_InteractionLabel_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_SprayBottle.NativeMethodInfoPtr_set_InteractionLabel_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060080EC RID: 33004 RVA: 0x002358F8 File Offset: 0x00233AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244536, XrefRangeEnd = 244568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_SprayBottle.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080ED RID: 33005 RVA: 0x00235934 File Offset: 0x00233B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244568, XrefRangeEnd = 244577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanSpray(GrowContainer growContainer, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(growContainer);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_SprayBottle.NativeMethodInfoPtr_CanSpray_Protected_Virtual_New_Boolean_GrowContainer_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060080EE RID: 33006 RVA: 0x002359A8 File Offset: 0x00233BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244577, XrefRangeEnd = 244581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartSprayTask(MushroomBed growContainer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(growContainer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_SprayBottle.NativeMethodInfoPtr_StartSprayTask_Protected_Void_MushroomBed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080EF RID: 33007 RVA: 0x002359EC File Offset: 0x00233BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244581, XrefRangeEnd = 244588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_SprayBottle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_SprayBottle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_SprayBottle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080F0 RID: 33008 RVA: 0x0003D5F5 File Offset: 0x0003B7F5
		public Equippable_SprayBottle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027E3 RID: 10211
		// (get) Token: 0x060080F1 RID: 33009 RVA: 0x00235A28 File Offset: 0x00233C28
		// (set) Token: 0x060080F2 RID: 33010 RVA: 0x0003D5FE File Offset: 0x0003B7FE
		public unsafe static float InteractionRange
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Equippable_SprayBottle.NativeFieldInfoPtr_InteractionRange, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Equippable_SprayBottle.NativeFieldInfoPtr_InteractionRange, (void*)(&value));
			}
		}

		// Token: 0x170027E4 RID: 10212
		// (get) Token: 0x060080F3 RID: 33011 RVA: 0x00235A44 File Offset: 0x00233C44
		// (set) Token: 0x060080F4 RID: 33012 RVA: 0x0003D60C File Offset: 0x0003B80C
		public unsafe string _InteractionLabel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_SprayBottle.NativeFieldInfoPtr__InteractionLabel_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_SprayBottle.NativeFieldInfoPtr__InteractionLabel_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170027E5 RID: 10213
		// (get) Token: 0x060080F5 RID: 33013 RVA: 0x00235A6C File Offset: 0x00233C6C
		// (set) Token: 0x060080F6 RID: 33014 RVA: 0x0003D62B File Offset: 0x0003B82B
		public unsafe GameObject _sprayablePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_SprayBottle.NativeFieldInfoPtr__sprayablePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_SprayBottle.NativeFieldInfoPtr__sprayablePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027E6 RID: 10214
		// (get) Token: 0x060080F7 RID: 33015 RVA: 0x00235A9C File Offset: 0x00233C9C
		// (set) Token: 0x060080F8 RID: 33016 RVA: 0x0003D64A File Offset: 0x0003B84A
		public unsafe WaterContainerInstance _waterContainerInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_SprayBottle.NativeFieldInfoPtr__waterContainerInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaterContainerInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_SprayBottle.NativeFieldInfoPtr__waterContainerInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040057E1 RID: 22497
		private static readonly IntPtr NativeFieldInfoPtr_InteractionRange;

		// Token: 0x040057E2 RID: 22498
		private static readonly IntPtr NativeFieldInfoPtr__InteractionLabel_k__BackingField;

		// Token: 0x040057E3 RID: 22499
		private static readonly IntPtr NativeFieldInfoPtr__sprayablePrefab;

		// Token: 0x040057E4 RID: 22500
		private static readonly IntPtr NativeFieldInfoPtr__waterContainerInstance;

		// Token: 0x040057E5 RID: 22501
		private static readonly IntPtr NativeMethodInfoPtr_get_InteractionLabel_Private_get_String_0;

		// Token: 0x040057E6 RID: 22502
		private static readonly IntPtr NativeMethodInfoPtr_set_InteractionLabel_Private_set_Void_String_0;

		// Token: 0x040057E7 RID: 22503
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x040057E8 RID: 22504
		private static readonly IntPtr NativeMethodInfoPtr_CanSpray_Protected_Virtual_New_Boolean_GrowContainer_byref_String_0;

		// Token: 0x040057E9 RID: 22505
		private static readonly IntPtr NativeMethodInfoPtr_StartSprayTask_Protected_Void_MushroomBed_0;

		// Token: 0x040057EA RID: 22506
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
