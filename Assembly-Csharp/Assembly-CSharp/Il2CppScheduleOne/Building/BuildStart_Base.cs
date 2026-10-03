using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.UI.Input;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x0200045B RID: 1115
	public class BuildStart_Base : MonoBehaviour
	{
		// Token: 0x06006526 RID: 25894 RVA: 0x001D9E20 File Offset: 0x001D8020
		// Note: this type is marked as 'beforefieldinit'.
		static BuildStart_Base()
		{
			Il2CppClassPointerStore<BuildStart_Base>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildStart_Base");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildStart_Base>.NativeClassPtr);
			BuildStart_Base.NativeFieldInfoPtr_inputPromptsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildStart_Base>.NativeClassPtr, "inputPromptsData");
			BuildStart_Base.NativeFieldInfoPtr_loadedInputModules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildStart_Base>.NativeClassPtr, "loadedInputModules");
			BuildStart_Base.NativeMethodInfoPtr_StartBuilding_Public_Virtual_New_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStart_Base>.NativeClassPtr, 100676581);
			BuildStart_Base.NativeMethodInfoPtr_GetInputPromptsModules_Protected_Virtual_New_List_1_InputPromptsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStart_Base>.NativeClassPtr, 100676582);
			BuildStart_Base.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStart_Base>.NativeClassPtr, 100676583);
			BuildStart_Base.NativeMethodInfoPtr_UnloadInputPrompts_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStart_Base>.NativeClassPtr, 100676584);
			BuildStart_Base.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStart_Base>.NativeClassPtr, 100676585);
		}

		// Token: 0x06006527 RID: 25895 RVA: 0x001D9EDC File Offset: 0x001D80DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 211785, RefRangeEnd = 211788, XrefRangeStart = 211764, XrefRangeEnd = 211785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartBuilding(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildStart_Base.NativeMethodInfoPtr_StartBuilding_Public_Virtual_New_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006528 RID: 25896 RVA: 0x001D9F2C File Offset: 0x001D812C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211788, XrefRangeEnd = 211797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<InputPromptsData> GetInputPromptsModules()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildStart_Base.NativeMethodInfoPtr_GetInputPromptsModules_Protected_Virtual_New_List_1_InputPromptsData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<InputPromptsData>>(intPtr3) : null;
		}

		// Token: 0x06006529 RID: 25897 RVA: 0x001D9F78 File Offset: 0x001D8178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211797, XrefRangeEnd = 211803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildStart_Base.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600652A RID: 25898 RVA: 0x001D9FAC File Offset: 0x001D81AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnloadInputPrompts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildStart_Base.NativeMethodInfoPtr_UnloadInputPrompts_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600652B RID: 25899 RVA: 0x001D9FE0 File Offset: 0x001D81E0
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildStart_Base() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildStart_Base>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildStart_Base.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600652C RID: 25900 RVA: 0x0002FA7A File Offset: 0x0002DC7A
		public BuildStart_Base(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EFD RID: 7933
		// (get) Token: 0x0600652D RID: 25901 RVA: 0x001DA01C File Offset: 0x001D821C
		// (set) Token: 0x0600652E RID: 25902 RVA: 0x0002FA83 File Offset: 0x0002DC83
		public unsafe InputPromptsData inputPromptsData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildStart_Base.NativeFieldInfoPtr_inputPromptsData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPromptsData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildStart_Base.NativeFieldInfoPtr_inputPromptsData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EFE RID: 7934
		// (get) Token: 0x0600652F RID: 25903 RVA: 0x001DA04C File Offset: 0x001D824C
		// (set) Token: 0x06006530 RID: 25904 RVA: 0x0002FAA2 File Offset: 0x0002DCA2
		public unsafe Il2CppReferenceArray<InputPromptsData> loadedInputModules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildStart_Base.NativeFieldInfoPtr_loadedInputModules);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InputPromptsData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildStart_Base.NativeFieldInfoPtr_loadedInputModules), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040045B8 RID: 17848
		private static readonly IntPtr NativeFieldInfoPtr_inputPromptsData;

		// Token: 0x040045B9 RID: 17849
		private static readonly IntPtr NativeFieldInfoPtr_loadedInputModules;

		// Token: 0x040045BA RID: 17850
		private static readonly IntPtr NativeMethodInfoPtr_StartBuilding_Public_Virtual_New_Void_ItemInstance_0;

		// Token: 0x040045BB RID: 17851
		private static readonly IntPtr NativeMethodInfoPtr_GetInputPromptsModules_Protected_Virtual_New_List_1_InputPromptsData_0;

		// Token: 0x040045BC RID: 17852
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040045BD RID: 17853
		private static readonly IntPtr NativeMethodInfoPtr_UnloadInputPrompts_Private_Void_0;

		// Token: 0x040045BE RID: 17854
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
