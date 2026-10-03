using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.Temperature;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x02000461 RID: 1121
	public class BuildUpdate_AirConditioner : BuildUpdate_Grid
	{
		// Token: 0x0600654D RID: 25933 RVA: 0x001DA6EC File Offset: 0x001D88EC
		// Note: this type is marked as 'beforefieldinit'.
		static BuildUpdate_AirConditioner()
		{
			Il2CppClassPointerStore<BuildUpdate_AirConditioner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildUpdate_AirConditioner");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildUpdate_AirConditioner>.NativeClassPtr);
			BuildUpdate_AirConditioner.NativeFieldInfoPtr__ac = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_AirConditioner>.NativeClassPtr, "_ac");
			BuildUpdate_AirConditioner.NativeFieldInfoPtr__currentMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_AirConditioner>.NativeClassPtr, "_currentMode");
			BuildUpdate_AirConditioner.NativeFieldInfoPtr__currentProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_AirConditioner>.NativeClassPtr, "_currentProperty");
			BuildUpdate_AirConditioner.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_GridItem_ItemInstance_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_AirConditioner>.NativeClassPtr, 100676600);
			BuildUpdate_AirConditioner.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_AirConditioner>.NativeClassPtr, 100676601);
			BuildUpdate_AirConditioner.NativeMethodInfoPtr_CycleACMode_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_AirConditioner>.NativeClassPtr, 100676602);
			BuildUpdate_AirConditioner.NativeMethodInfoPtr_SetACMode_Private_Void_EMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_AirConditioner>.NativeClassPtr, 100676603);
			BuildUpdate_AirConditioner.NativeMethodInfoPtr_OnPlacedObjectPreSpawn_Protected_Virtual_Void_GridItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_AirConditioner>.NativeClassPtr, 100676604);
			BuildUpdate_AirConditioner.NativeMethodInfoPtr_OnClosestIntersectionChanged_Protected_Virtual_Void_TileIntersection_TileIntersection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_AirConditioner>.NativeClassPtr, 100676605);
			BuildUpdate_AirConditioner.NativeMethodInfoPtr_AddToProperty_Private_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_AirConditioner>.NativeClassPtr, 100676606);
			BuildUpdate_AirConditioner.NativeMethodInfoPtr_RemoveFromPropery_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_AirConditioner>.NativeClassPtr, 100676607);
			BuildUpdate_AirConditioner.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_AirConditioner>.NativeClassPtr, 100676608);
		}

		// Token: 0x0600654E RID: 25934 RVA: 0x001DA80C File Offset: 0x001D8A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212092, XrefRangeEnd = 212105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(GridItem buildableItemClass, ItemInstance itemInstance, GameObject ghostModel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(buildableItemClass);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(itemInstance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ghostModel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_AirConditioner.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_GridItem_ItemInstance_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600654F RID: 25935 RVA: 0x001DA880 File Offset: 0x001D8A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212105, XrefRangeEnd = 212112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_AirConditioner.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006550 RID: 25936 RVA: 0x001DA8BC File Offset: 0x001D8ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212112, XrefRangeEnd = 212114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CycleACMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_AirConditioner.NativeMethodInfoPtr_CycleACMode_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006551 RID: 25937 RVA: 0x001DA8F0 File Offset: 0x001D8AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212114, XrefRangeEnd = 212115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetACMode(AirConditioner.EMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_AirConditioner.NativeMethodInfoPtr_SetACMode_Private_Void_EMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006552 RID: 25938 RVA: 0x001DA930 File Offset: 0x001D8B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212115, XrefRangeEnd = 212120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPlacedObjectPreSpawn(GridItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_AirConditioner.NativeMethodInfoPtr_OnPlacedObjectPreSpawn_Protected_Virtual_Void_GridItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006553 RID: 25939 RVA: 0x001DA980 File Offset: 0x001D8B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212120, XrefRangeEnd = 212164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnClosestIntersectionChanged(TileIntersection previous, TileIntersection current)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(previous);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(current);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_AirConditioner.NativeMethodInfoPtr_OnClosestIntersectionChanged_Protected_Virtual_Void_TileIntersection_TileIntersection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006554 RID: 25940 RVA: 0x001DA9E0 File Offset: 0x001D8BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212164, XrefRangeEnd = 212182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToProperty(Property property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_AirConditioner.NativeMethodInfoPtr_AddToProperty_Private_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006555 RID: 25941 RVA: 0x001DAA24 File Offset: 0x001D8C24
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 212193, RefRangeEnd = 212197, XrefRangeStart = 212182, XrefRangeEnd = 212193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveFromPropery()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_AirConditioner.NativeMethodInfoPtr_RemoveFromPropery_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006556 RID: 25942 RVA: 0x001DAA58 File Offset: 0x001D8C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212197, XrefRangeEnd = 212198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildUpdate_AirConditioner() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildUpdate_AirConditioner>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_AirConditioner.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006557 RID: 25943 RVA: 0x0002FB1B File Offset: 0x0002DD1B
		public BuildUpdate_AirConditioner(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F01 RID: 7937
		// (get) Token: 0x06006558 RID: 25944 RVA: 0x001DAA94 File Offset: 0x001D8C94
		// (set) Token: 0x06006559 RID: 25945 RVA: 0x0002FB24 File Offset: 0x0002DD24
		public unsafe AirConditioner _ac
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_AirConditioner.NativeFieldInfoPtr__ac);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AirConditioner>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_AirConditioner.NativeFieldInfoPtr__ac), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F02 RID: 7938
		// (get) Token: 0x0600655A RID: 25946 RVA: 0x001DAAC4 File Offset: 0x001D8CC4
		// (set) Token: 0x0600655B RID: 25947 RVA: 0x0002FB43 File Offset: 0x0002DD43
		public unsafe AirConditioner.EMode _currentMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_AirConditioner.NativeFieldInfoPtr__currentMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_AirConditioner.NativeFieldInfoPtr__currentMode)) = value;
			}
		}

		// Token: 0x17001F03 RID: 7939
		// (get) Token: 0x0600655C RID: 25948 RVA: 0x001DAAEC File Offset: 0x001D8CEC
		// (set) Token: 0x0600655D RID: 25949 RVA: 0x0002FB5E File Offset: 0x0002DD5E
		public unsafe Property _currentProperty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_AirConditioner.NativeFieldInfoPtr__currentProperty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_AirConditioner.NativeFieldInfoPtr__currentProperty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040045CF RID: 17871
		private static readonly IntPtr NativeFieldInfoPtr__ac;

		// Token: 0x040045D0 RID: 17872
		private static readonly IntPtr NativeFieldInfoPtr__currentMode;

		// Token: 0x040045D1 RID: 17873
		private static readonly IntPtr NativeFieldInfoPtr__currentProperty;

		// Token: 0x040045D2 RID: 17874
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_GridItem_ItemInstance_GameObject_0;

		// Token: 0x040045D3 RID: 17875
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x040045D4 RID: 17876
		private static readonly IntPtr NativeMethodInfoPtr_CycleACMode_Private_Void_0;

		// Token: 0x040045D5 RID: 17877
		private static readonly IntPtr NativeMethodInfoPtr_SetACMode_Private_Void_EMode_0;

		// Token: 0x040045D6 RID: 17878
		private static readonly IntPtr NativeMethodInfoPtr_OnPlacedObjectPreSpawn_Protected_Virtual_Void_GridItem_0;

		// Token: 0x040045D7 RID: 17879
		private static readonly IntPtr NativeMethodInfoPtr_OnClosestIntersectionChanged_Protected_Virtual_Void_TileIntersection_TileIntersection_0;

		// Token: 0x040045D8 RID: 17880
		private static readonly IntPtr NativeMethodInfoPtr_AddToProperty_Private_Void_Property_0;

		// Token: 0x040045D9 RID: 17881
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFromPropery_Public_Void_0;

		// Token: 0x040045DA RID: 17882
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
