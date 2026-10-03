using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.UI.Input;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x0200045C RID: 1116
	public class BuildStart_Grid : BuildStart_Base
	{
		// Token: 0x06006531 RID: 25905 RVA: 0x001DA07C File Offset: 0x001D827C
		// Note: this type is marked as 'beforefieldinit'.
		static BuildStart_Grid()
		{
			Il2CppClassPointerStore<BuildStart_Grid>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildStart_Grid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildStart_Grid>.NativeClassPtr);
			BuildStart_Grid.NativeFieldInfoPtr_GhostModelScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildStart_Grid>.NativeClassPtr, "GhostModelScale");
			BuildStart_Grid.NativeFieldInfoPtr_ghostModelClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildStart_Grid>.NativeClassPtr, "ghostModelClass");
			BuildStart_Grid.NativeMethodInfoPtr_StartBuilding_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStart_Grid>.NativeClassPtr, 100676586);
			BuildStart_Grid.NativeMethodInfoPtr_GetInputPromptsModules_Protected_Virtual_List_1_InputPromptsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStart_Grid>.NativeClassPtr, 100676587);
			BuildStart_Grid.NativeMethodInfoPtr_CreateGhostModel_Protected_Virtual_New_GridItem_BuildableItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStart_Grid>.NativeClassPtr, 100676588);
			BuildStart_Grid.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStart_Grid>.NativeClassPtr, 100676589);
		}

		// Token: 0x06006532 RID: 25906 RVA: 0x001DA124 File Offset: 0x001D8324
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 211825, RefRangeEnd = 211826, XrefRangeStart = 211803, XrefRangeEnd = 211825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartBuilding(ItemInstance itemInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildStart_Grid.NativeMethodInfoPtr_StartBuilding_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006533 RID: 25907 RVA: 0x001DA174 File Offset: 0x001D8374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211826, XrefRangeEnd = 211848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override List<InputPromptsData> GetInputPromptsModules()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildStart_Grid.NativeMethodInfoPtr_GetInputPromptsModules_Protected_Virtual_List_1_InputPromptsData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<InputPromptsData>>(intPtr3) : null;
		}

		// Token: 0x06006534 RID: 25908 RVA: 0x001DA1C0 File Offset: 0x001D83C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211848, XrefRangeEnd = 211913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual GridItem CreateGhostModel(BuildableItemDefinition itemDefinition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemDefinition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildStart_Grid.NativeMethodInfoPtr_CreateGhostModel_Protected_Virtual_New_GridItem_BuildableItemDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GridItem>(intPtr3) : null;
		}

		// Token: 0x06006535 RID: 25909 RVA: 0x001DA21C File Offset: 0x001D841C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildStart_Grid() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildStart_Grid>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildStart_Grid.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006536 RID: 25910 RVA: 0x0002FAC1 File Offset: 0x0002DCC1
		public BuildStart_Grid(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EFF RID: 7935
		// (get) Token: 0x06006537 RID: 25911 RVA: 0x001DA258 File Offset: 0x001D8458
		// (set) Token: 0x06006538 RID: 25912 RVA: 0x0002FACA File Offset: 0x0002DCCA
		public unsafe static float GhostModelScale
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BuildStart_Grid.NativeFieldInfoPtr_GhostModelScale, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BuildStart_Grid.NativeFieldInfoPtr_GhostModelScale, (void*)(&value));
			}
		}

		// Token: 0x17001F00 RID: 7936
		// (get) Token: 0x06006539 RID: 25913 RVA: 0x001DA274 File Offset: 0x001D8474
		// (set) Token: 0x0600653A RID: 25914 RVA: 0x0002FAD8 File Offset: 0x0002DCD8
		public unsafe GridItem ghostModelClass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildStart_Grid.NativeFieldInfoPtr_ghostModelClass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildStart_Grid.NativeFieldInfoPtr_ghostModelClass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040045BF RID: 17855
		private static readonly IntPtr NativeFieldInfoPtr_GhostModelScale;

		// Token: 0x040045C0 RID: 17856
		private static readonly IntPtr NativeFieldInfoPtr_ghostModelClass;

		// Token: 0x040045C1 RID: 17857
		private static readonly IntPtr NativeMethodInfoPtr_StartBuilding_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x040045C2 RID: 17858
		private static readonly IntPtr NativeMethodInfoPtr_GetInputPromptsModules_Protected_Virtual_List_1_InputPromptsData_0;

		// Token: 0x040045C3 RID: 17859
		private static readonly IntPtr NativeMethodInfoPtr_CreateGhostModel_Protected_Virtual_New_GridItem_BuildableItemDefinition_0;

		// Token: 0x040045C4 RID: 17860
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
