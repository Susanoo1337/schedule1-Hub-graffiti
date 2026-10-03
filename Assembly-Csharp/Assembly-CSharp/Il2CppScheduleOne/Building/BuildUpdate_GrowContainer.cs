using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Property;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x02000465 RID: 1125
	public class BuildUpdate_GrowContainer : BuildUpdate_Grid
	{
		// Token: 0x060065A6 RID: 26022 RVA: 0x001DBAF8 File Offset: 0x001D9CF8
		// Note: this type is marked as 'beforefieldinit'.
		static BuildUpdate_GrowContainer()
		{
			Il2CppClassPointerStore<BuildUpdate_GrowContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildUpdate_GrowContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildUpdate_GrowContainer>.NativeClassPtr);
			BuildUpdate_GrowContainer.NativeFieldInfoPtr__gc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_GrowContainer>.NativeClassPtr, "_gc");
			BuildUpdate_GrowContainer.NativeFieldInfoPtr__showTemps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_GrowContainer>.NativeClassPtr, "_showTemps");
			BuildUpdate_GrowContainer.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_GridItem_ItemInstance_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_GrowContainer>.NativeClassPtr, 100676641);
			BuildUpdate_GrowContainer.NativeMethodInfoPtr_GetTemperature_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_GrowContainer>.NativeClassPtr, 100676642);
			BuildUpdate_GrowContainer.NativeMethodInfoPtr_GetTemperatureVisibility_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_GrowContainer>.NativeClassPtr, 100676643);
			BuildUpdate_GrowContainer.NativeMethodInfoPtr_SetShowTemperatures_Protected_Virtual_Void_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_GrowContainer>.NativeClassPtr, 100676644);
			BuildUpdate_GrowContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_GrowContainer>.NativeClassPtr, 100676645);
		}

		// Token: 0x060065A7 RID: 26023 RVA: 0x001DBBB4 File Offset: 0x001D9DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212770, XrefRangeEnd = 212797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(GridItem buildableItemClass, ItemInstance itemInstance, GameObject ghostModel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(buildableItemClass);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(itemInstance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ghostModel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_GrowContainer.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_GridItem_ItemInstance_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065A8 RID: 26024 RVA: 0x001DBC28 File Offset: 0x001D9E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212797, XrefRangeEnd = 212809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetTemperature()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_GrowContainer.NativeMethodInfoPtr_GetTemperature_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060065A9 RID: 26025 RVA: 0x001DBC64 File Offset: 0x001D9E64
		[CallerCount(0)]
		public unsafe bool GetTemperatureVisibility()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_GrowContainer.NativeMethodInfoPtr_GetTemperatureVisibility_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060065AA RID: 26026 RVA: 0x001DBCA0 File Offset: 0x001D9EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212809, XrefRangeEnd = 212814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetShowTemperatures(bool show, Property property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref show;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(property);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_GrowContainer.NativeMethodInfoPtr_SetShowTemperatures_Protected_Virtual_Void_Boolean_Property_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065AB RID: 26027 RVA: 0x001DBCFC File Offset: 0x001D9EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212814, XrefRangeEnd = 212815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildUpdate_GrowContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildUpdate_GrowContainer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_GrowContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065AC RID: 26028 RVA: 0x0002FD7F File Offset: 0x0002DF7F
		public BuildUpdate_GrowContainer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F1A RID: 7962
		// (get) Token: 0x060065AD RID: 26029 RVA: 0x001DBD38 File Offset: 0x001D9F38
		// (set) Token: 0x060065AE RID: 26030 RVA: 0x0002FD88 File Offset: 0x0002DF88
		public unsafe GrowContainer _gc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_GrowContainer.NativeFieldInfoPtr__gc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GrowContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_GrowContainer.NativeFieldInfoPtr__gc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F1B RID: 7963
		// (get) Token: 0x060065AF RID: 26031 RVA: 0x001DBD68 File Offset: 0x001D9F68
		// (set) Token: 0x060065B0 RID: 26032 RVA: 0x0002FDA7 File Offset: 0x0002DFA7
		public unsafe static bool _showTemps
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(BuildUpdate_GrowContainer.NativeFieldInfoPtr__showTemps, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BuildUpdate_GrowContainer.NativeFieldInfoPtr__showTemps, (void*)(&value));
			}
		}

		// Token: 0x0400460C RID: 17932
		private static readonly IntPtr NativeFieldInfoPtr__gc;

		// Token: 0x0400460D RID: 17933
		private static readonly IntPtr NativeFieldInfoPtr__showTemps;

		// Token: 0x0400460E RID: 17934
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_GridItem_ItemInstance_GameObject_0;

		// Token: 0x0400460F RID: 17935
		private static readonly IntPtr NativeMethodInfoPtr_GetTemperature_Private_Single_0;

		// Token: 0x04004610 RID: 17936
		private static readonly IntPtr NativeMethodInfoPtr_GetTemperatureVisibility_Private_Boolean_0;

		// Token: 0x04004611 RID: 17937
		private static readonly IntPtr NativeMethodInfoPtr_SetShowTemperatures_Protected_Virtual_Void_Boolean_Property_0;

		// Token: 0x04004612 RID: 17938
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
