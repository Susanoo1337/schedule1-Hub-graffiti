using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.ItemFramework;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x0200045D RID: 1117
	public class BuildStart_ProceduralGrid : BuildStart_Base
	{
		// Token: 0x0600653B RID: 25915 RVA: 0x001DA2A4 File Offset: 0x001D84A4
		// Note: this type is marked as 'beforefieldinit'.
		static BuildStart_ProceduralGrid()
		{
			Il2CppClassPointerStore<BuildStart_ProceduralGrid>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildStart_ProceduralGrid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildStart_ProceduralGrid>.NativeClassPtr);
			BuildStart_ProceduralGrid.NativeMethodInfoPtr_StartBuilding_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStart_ProceduralGrid>.NativeClassPtr, 100676590);
			BuildStart_ProceduralGrid.NativeMethodInfoPtr_CreateGhostModel_Protected_Virtual_New_ProceduralGridItem_BuildableItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStart_ProceduralGrid>.NativeClassPtr, 100676591);
			BuildStart_ProceduralGrid.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStart_ProceduralGrid>.NativeClassPtr, 100676592);
		}

		// Token: 0x0600653C RID: 25916 RVA: 0x001DA310 File Offset: 0x001D8510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211913, XrefRangeEnd = 211949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartBuilding(ItemInstance itemInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildStart_ProceduralGrid.NativeMethodInfoPtr_StartBuilding_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600653D RID: 25917 RVA: 0x001DA360 File Offset: 0x001D8560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211949, XrefRangeEnd = 211982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ProceduralGridItem CreateGhostModel(BuildableItemDefinition itemDefinition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemDefinition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildStart_ProceduralGrid.NativeMethodInfoPtr_CreateGhostModel_Protected_Virtual_New_ProceduralGridItem_BuildableItemDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProceduralGridItem>(intPtr3) : null;
		}

		// Token: 0x0600653E RID: 25918 RVA: 0x001DA3BC File Offset: 0x001D85BC
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildStart_ProceduralGrid() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildStart_ProceduralGrid>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildStart_ProceduralGrid.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600653F RID: 25919 RVA: 0x0002FAF7 File Offset: 0x0002DCF7
		public BuildStart_ProceduralGrid(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040045C5 RID: 17861
		private static readonly IntPtr NativeMethodInfoPtr_StartBuilding_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x040045C6 RID: 17862
		private static readonly IntPtr NativeMethodInfoPtr_CreateGhostModel_Protected_Virtual_New_ProceduralGridItem_BuildableItemDefinition_0;

		// Token: 0x040045C7 RID: 17863
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
