using System;
using Il2CppFishNet.Connection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Levelling;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Graffiti
{
	// Token: 0x02000369 RID: 873
	public class GraffitiManager : NetworkSingleton<GraffitiManager>
	{
		// Token: 0x060049A3 RID: 18851 RVA: 0x00175B70 File Offset: 0x00173D70
		// Note: this type is marked as 'beforefieldinit'.
		static GraffitiManager()
		{
			Il2CppClassPointerStore<GraffitiManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Graffiti", "GraffitiManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraffitiManager>.NativeClassPtr);
			GraffitiManager.NativeFieldInfoPtr_SPRAY_PAINT_STOCK_VARIABLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiManager>.NativeClassPtr, "SPRAY_PAINT_STOCK_VARIABLE");
			GraffitiManager.NativeFieldInfoPtr_SPRAY_PAINTS_PURCHASED_VARIABLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiManager>.NativeClassPtr, "SPRAY_PAINTS_PURCHASED_VARIABLE");
			GraffitiManager.NativeFieldInfoPtr__WorldSpraySurfaces_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiManager>.NativeClassPtr, "<WorldSpraySurfaces>k__BackingField");
			GraffitiManager.NativeFieldInfoPtr__falloffCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiManager>.NativeClassPtr, "_falloffCurve");
			GraffitiManager.NativeFieldInfoPtr__falloffTableCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiManager>.NativeClassPtr, "_falloffTableCache");
			GraffitiManager.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiManager>.NativeClassPtr, "loader");
			GraffitiManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiManager>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			GraffitiManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiManager>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			GraffitiManager.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiManager>.NativeClassPtr, "<HasChanged>k__BackingField");
			GraffitiManager.NativeFieldInfoPtr__LoadOrder_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiManager>.NativeClassPtr, "<LoadOrder>k__BackingField");
			GraffitiManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Graffiti.GraffitiManagerAssembly-CSharp.dll_Excuted");
			GraffitiManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Graffiti.GraffitiManagerAssembly-CSharp.dll_Excuted");
			GraffitiManager.NativeMethodInfoPtr_get_WorldSpraySurfaces_Public_get_List_1_WorldSpraySurface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiManager>.NativeClassPtr, 100672735);
			GraffitiManager.NativeMethodInfoPtr_set_WorldSpraySurfaces_Private_set_Void_List_1_WorldSpraySurface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiManager>.NativeClassPtr, 100672736);
			GraffitiManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiManager>.NativeClassPtr, 100672737);
			GraffitiManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiManager>.NativeClassPtr, 100672738);
			GraffitiManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiManager>.NativeClassPtr, 100672739);
			GraffitiManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiManager>.NativeClassPtr, 100672740);
			GraffitiManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiManager>.NativeClassPtr, 100672741);
			GraffitiManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiManager>.NativeClassPtr, 100672742);
			GraffitiManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiManager>.NativeClassPtr, 100672743);
			GraffitiManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiManager>.NativeClassPtr, 100672744);
			GraffitiManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiManager>.NativeClassPtr, 100672745);
			GraffitiManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiManager>.NativeClassPtr, 100672746);
			GraffitiManager.NativeMethodInfoPtr_get_LoadOrder_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiManager>.NativeClassPtr, 100672747);
			GraffitiManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiManager>.NativeClassPtr, 100672748);
			GraffitiManager.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiManager>.NativeClassPtr, 100672749);
			GraffitiManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiManager>.NativeClassPtr, 100672750);
			GraffitiManager.NativeMethodInfoPtr_SprayPaintPurchaseCountChanged_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiManager>.NativeClassPtr, 100672751);
			GraffitiManager.NativeMethodInfoPtr_RankChange_Private_Void_FullRank_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiManager>.NativeClassPtr, 100672752);
			GraffitiManager.NativeMethodInfoPtr_UpdateSprayPaintStockVariable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiManager>.NativeClassPtr, 100672753);
			GraffitiManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiManager>.NativeClassPtr, 100672754);
			GraffitiManager.NativeMethodInfoPtr_QueueSurfaceToReplicate_Public_Void_SpraySurface_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiManager>.NativeClassPtr, 100672755);
			GraffitiManager.NativeMethodInfoPtr_GetPixelStrength_Public_Single_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiManager>.NativeClassPtr, 100672756);
			GraffitiManager.NativeMethodInfoPtr_GetFalloffTable_Private_Il2CppStructArray_1_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiManager>.NativeClassPtr, 100672757);
			GraffitiManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiManager>.NativeClassPtr, 100672758);
			GraffitiManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiManager>.NativeClassPtr, 100672759);
			GraffitiManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiManager>.NativeClassPtr, 100672760);
			GraffitiManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiManager>.NativeClassPtr, 100672761);
			GraffitiManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiManager>.NativeClassPtr, 100672762);
		}

		// Token: 0x1700171B RID: 5915
		// (get) Token: 0x060049A4 RID: 18852 RVA: 0x00175EC0 File Offset: 0x001740C0
		// (set) Token: 0x060049A5 RID: 18853 RVA: 0x00175F00 File Offset: 0x00174100
		public unsafe List<WorldSpraySurface> WorldSpraySurfaces
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiManager.NativeMethodInfoPtr_get_WorldSpraySurfaces_Public_get_List_1_WorldSpraySurface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<WorldSpraySurface>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiManager.NativeMethodInfoPtr_set_WorldSpraySurfaces_Private_set_Void_List_1_WorldSpraySurface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700171C RID: 5916
		// (get) Token: 0x060049A6 RID: 18854 RVA: 0x00175F44 File Offset: 0x00174144
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169166, XrefRangeEnd = 169168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700171D RID: 5917
		// (get) Token: 0x060049A7 RID: 18855 RVA: 0x00175F7C File Offset: 0x0017417C
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169168, XrefRangeEnd = 169170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700171E RID: 5918
		// (get) Token: 0x060049A8 RID: 18856 RVA: 0x00175FB4 File Offset: 0x001741B4
		public unsafe virtual Loader Loader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x1700171F RID: 5919
		// (get) Token: 0x060049A9 RID: 18857 RVA: 0x00175FF4 File Offset: 0x001741F4
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(170)]
			[CachedScanResults(RefRangeStart = 31151, RefRangeEnd = 31321, XrefRangeStart = 31151, XrefRangeEnd = 31321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001720 RID: 5920
		// (get) Token: 0x060049AA RID: 18858 RVA: 0x00176030 File Offset: 0x00174230
		// (set) Token: 0x060049AB RID: 18859 RVA: 0x00176070 File Offset: 0x00174270
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001721 RID: 5921
		// (get) Token: 0x060049AC RID: 18860 RVA: 0x001760B4 File Offset: 0x001742B4
		// (set) Token: 0x060049AD RID: 18861 RVA: 0x001760F4 File Offset: 0x001742F4
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 94584, RefRangeEnd = 94585, XrefRangeStart = 94584, XrefRangeEnd = 94585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001722 RID: 5922
		// (get) Token: 0x060049AE RID: 18862 RVA: 0x00176138 File Offset: 0x00174338
		// (set) Token: 0x060049AF RID: 18863 RVA: 0x00176174 File Offset: 0x00174374
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001723 RID: 5923
		// (get) Token: 0x060049B0 RID: 18864 RVA: 0x001761B4 File Offset: 0x001743B4
		public unsafe virtual int LoadOrder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiManager.NativeMethodInfoPtr_get_LoadOrder_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060049B1 RID: 18865 RVA: 0x001761F0 File Offset: 0x001743F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169170, XrefRangeEnd = 169181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GraffitiManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049B2 RID: 18866 RVA: 0x0017622C File Offset: 0x0017442C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169181, XrefRangeEnd = 169237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GraffitiManager.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049B3 RID: 18867 RVA: 0x00176268 File Offset: 0x00174468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169237, XrefRangeEnd = 169243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GraffitiManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049B4 RID: 18868 RVA: 0x001762A4 File Offset: 0x001744A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169243, XrefRangeEnd = 169244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SprayPaintPurchaseCountChanged(float newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiManager.NativeMethodInfoPtr_SprayPaintPurchaseCountChanged_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049B5 RID: 18869 RVA: 0x001762E4 File Offset: 0x001744E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RankChange(FullRank oldRank, FullRank newRank)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref oldRank;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newRank;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiManager.NativeMethodInfoPtr_RankChange_Private_Void_FullRank_FullRank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049B6 RID: 18870 RVA: 0x00176330 File Offset: 0x00174530
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 169268, RefRangeEnd = 169271, XrefRangeStart = 169244, XrefRangeEnd = 169268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSprayPaintStockVariable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiManager.NativeMethodInfoPtr_UpdateSprayPaintStockVariable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049B7 RID: 18871 RVA: 0x00176364 File Offset: 0x00174564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169271, XrefRangeEnd = 169311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GraffitiManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060049B8 RID: 18872 RVA: 0x001763A8 File Offset: 0x001745A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169325, RefRangeEnd = 169326, XrefRangeStart = 169311, XrefRangeEnd = 169325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueueSurfaceToReplicate(SpraySurface surface, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(surface);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiManager.NativeMethodInfoPtr_QueueSurfaceToReplicate_Public_Void_SpraySurface_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049B9 RID: 18873 RVA: 0x001763FC File Offset: 0x001745FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169336, RefRangeEnd = 169337, XrefRangeStart = 169326, XrefRangeEnd = 169336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetPixelStrength(byte strokeSize, int pixelIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref strokeSize;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pixelIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiManager.NativeMethodInfoPtr_GetPixelStrength_Public_Single_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060049BA RID: 18874 RVA: 0x00176454 File Offset: 0x00174654
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 169353, RefRangeEnd = 169356, XrefRangeStart = 169337, XrefRangeEnd = 169353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<float> GetFalloffTable(int strokeSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref strokeSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiManager.NativeMethodInfoPtr_GetFalloffTable_Private_Il2CppStructArray_1_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr3) : null;
		}

		// Token: 0x060049BB RID: 18875 RVA: 0x001764A0 File Offset: 0x001746A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169356, XrefRangeEnd = 169390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraffitiManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraffitiManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049BC RID: 18876 RVA: 0x001764DC File Offset: 0x001746DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169390, XrefRangeEnd = 169393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GraffitiManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049BD RID: 18877 RVA: 0x00176518 File Offset: 0x00174718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169393, XrefRangeEnd = 169396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GraffitiManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049BE RID: 18878 RVA: 0x00176554 File Offset: 0x00174754
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GraffitiManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049BF RID: 18879 RVA: 0x00176590 File Offset: 0x00174790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169396, XrefRangeEnd = 169405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GraffitiManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049C0 RID: 18880 RVA: 0x00023BB9 File Offset: 0x00021DB9
		public GraffitiManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700170F RID: 5903
		// (get) Token: 0x060049C1 RID: 18881 RVA: 0x001765CC File Offset: 0x001747CC
		// (set) Token: 0x060049C2 RID: 18882 RVA: 0x00023BC2 File Offset: 0x00021DC2
		public unsafe static string SPRAY_PAINT_STOCK_VARIABLE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GraffitiManager.NativeFieldInfoPtr_SPRAY_PAINT_STOCK_VARIABLE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GraffitiManager.NativeFieldInfoPtr_SPRAY_PAINT_STOCK_VARIABLE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001710 RID: 5904
		// (get) Token: 0x060049C3 RID: 18883 RVA: 0x001765EC File Offset: 0x001747EC
		// (set) Token: 0x060049C4 RID: 18884 RVA: 0x00023BD4 File Offset: 0x00021DD4
		public unsafe static string SPRAY_PAINTS_PURCHASED_VARIABLE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GraffitiManager.NativeFieldInfoPtr_SPRAY_PAINTS_PURCHASED_VARIABLE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GraffitiManager.NativeFieldInfoPtr_SPRAY_PAINTS_PURCHASED_VARIABLE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001711 RID: 5905
		// (get) Token: 0x060049C5 RID: 18885 RVA: 0x0017660C File Offset: 0x0017480C
		// (set) Token: 0x060049C6 RID: 18886 RVA: 0x00023BE6 File Offset: 0x00021DE6
		public unsafe List<WorldSpraySurface> _WorldSpraySurfaces_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiManager.NativeFieldInfoPtr__WorldSpraySurfaces_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WorldSpraySurface>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiManager.NativeFieldInfoPtr__WorldSpraySurfaces_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001712 RID: 5906
		// (get) Token: 0x060049C7 RID: 18887 RVA: 0x0017663C File Offset: 0x0017483C
		// (set) Token: 0x060049C8 RID: 18888 RVA: 0x00023C05 File Offset: 0x00021E05
		public unsafe AnimationCurve _falloffCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiManager.NativeFieldInfoPtr__falloffCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiManager.NativeFieldInfoPtr__falloffCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001713 RID: 5907
		// (get) Token: 0x060049C9 RID: 18889 RVA: 0x0017666C File Offset: 0x0017486C
		// (set) Token: 0x060049CA RID: 18890 RVA: 0x00023C24 File Offset: 0x00021E24
		public unsafe Dictionary<byte, Il2CppStructArray<float>> _falloffTableCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiManager.NativeFieldInfoPtr__falloffTableCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<byte, Il2CppStructArray<float>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiManager.NativeFieldInfoPtr__falloffTableCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001714 RID: 5908
		// (get) Token: 0x060049CB RID: 18891 RVA: 0x0017669C File Offset: 0x0017489C
		// (set) Token: 0x060049CC RID: 18892 RVA: 0x00023C43 File Offset: 0x00021E43
		public unsafe GraffitiLoader loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiManager.NativeFieldInfoPtr_loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GraffitiLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiManager.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001715 RID: 5909
		// (get) Token: 0x060049CD RID: 18893 RVA: 0x001766CC File Offset: 0x001748CC
		// (set) Token: 0x060049CE RID: 18894 RVA: 0x00023C62 File Offset: 0x00021E62
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001716 RID: 5910
		// (get) Token: 0x060049CF RID: 18895 RVA: 0x001766FC File Offset: 0x001748FC
		// (set) Token: 0x060049D0 RID: 18896 RVA: 0x00023C81 File Offset: 0x00021E81
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001717 RID: 5911
		// (get) Token: 0x060049D1 RID: 18897 RVA: 0x0017672C File Offset: 0x0017492C
		// (set) Token: 0x060049D2 RID: 18898 RVA: 0x00023CA0 File Offset: 0x00021EA0
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiManager.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiManager.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x17001718 RID: 5912
		// (get) Token: 0x060049D3 RID: 18899 RVA: 0x00176754 File Offset: 0x00174954
		// (set) Token: 0x060049D4 RID: 18900 RVA: 0x00023CBB File Offset: 0x00021EBB
		public unsafe int _LoadOrder_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiManager.NativeFieldInfoPtr__LoadOrder_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiManager.NativeFieldInfoPtr__LoadOrder_k__BackingField)) = value;
			}
		}

		// Token: 0x17001719 RID: 5913
		// (get) Token: 0x060049D5 RID: 18901 RVA: 0x0017677C File Offset: 0x0017497C
		// (set) Token: 0x060049D6 RID: 18902 RVA: 0x00023CD6 File Offset: 0x00021ED6
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700171A RID: 5914
		// (get) Token: 0x060049D7 RID: 18903 RVA: 0x001767A4 File Offset: 0x001749A4
		// (set) Token: 0x060049D8 RID: 18904 RVA: 0x00023CF1 File Offset: 0x00021EF1
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003216 RID: 12822
		private static readonly IntPtr NativeFieldInfoPtr_SPRAY_PAINT_STOCK_VARIABLE;

		// Token: 0x04003217 RID: 12823
		private static readonly IntPtr NativeFieldInfoPtr_SPRAY_PAINTS_PURCHASED_VARIABLE;

		// Token: 0x04003218 RID: 12824
		private static readonly IntPtr NativeFieldInfoPtr__WorldSpraySurfaces_k__BackingField;

		// Token: 0x04003219 RID: 12825
		private static readonly IntPtr NativeFieldInfoPtr__falloffCurve;

		// Token: 0x0400321A RID: 12826
		private static readonly IntPtr NativeFieldInfoPtr__falloffTableCache;

		// Token: 0x0400321B RID: 12827
		private static readonly IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x0400321C RID: 12828
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x0400321D RID: 12829
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x0400321E RID: 12830
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x0400321F RID: 12831
		private static readonly IntPtr NativeFieldInfoPtr__LoadOrder_k__BackingField;

		// Token: 0x04003220 RID: 12832
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003221 RID: 12833
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003222 RID: 12834
		private static readonly IntPtr NativeMethodInfoPtr_get_WorldSpraySurfaces_Public_get_List_1_WorldSpraySurface_0;

		// Token: 0x04003223 RID: 12835
		private static readonly IntPtr NativeMethodInfoPtr_set_WorldSpraySurfaces_Private_set_Void_List_1_WorldSpraySurface_0;

		// Token: 0x04003224 RID: 12836
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04003225 RID: 12837
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04003226 RID: 12838
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04003227 RID: 12839
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003228 RID: 12840
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04003229 RID: 12841
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x0400322A RID: 12842
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x0400322B RID: 12843
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x0400322C RID: 12844
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400322D RID: 12845
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0400322E RID: 12846
		private static readonly IntPtr NativeMethodInfoPtr_get_LoadOrder_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400322F RID: 12847
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04003230 RID: 12848
		private static readonly IntPtr NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0;

		// Token: 0x04003231 RID: 12849
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04003232 RID: 12850
		private static readonly IntPtr NativeMethodInfoPtr_SprayPaintPurchaseCountChanged_Private_Void_Single_0;

		// Token: 0x04003233 RID: 12851
		private static readonly IntPtr NativeMethodInfoPtr_RankChange_Private_Void_FullRank_FullRank_0;

		// Token: 0x04003234 RID: 12852
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSprayPaintStockVariable_Private_Void_0;

		// Token: 0x04003235 RID: 12853
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x04003236 RID: 12854
		private static readonly IntPtr NativeMethodInfoPtr_QueueSurfaceToReplicate_Public_Void_SpraySurface_NetworkConnection_0;

		// Token: 0x04003237 RID: 12855
		private static readonly IntPtr NativeMethodInfoPtr_GetPixelStrength_Public_Single_Byte_Int32_0;

		// Token: 0x04003238 RID: 12856
		private static readonly IntPtr NativeMethodInfoPtr_GetFalloffTable_Private_Il2CppStructArray_1_Single_Int32_0;

		// Token: 0x04003239 RID: 12857
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400323A RID: 12858
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400323B RID: 12859
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400323C RID: 12860
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400323D RID: 12861
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000A74 RID: 2676
		[ObfuscatedName("ScheduleOne.Graffiti.GraffitiManager+<>c__DisplayClass39_0")]
		public sealed class __c__DisplayClass39_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E12D RID: 57645 RVA: 0x00374F04 File Offset: 0x00373104
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass39_0()
			{
				Il2CppClassPointerStore<GraffitiManager.__c__DisplayClass39_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GraffitiManager>.NativeClassPtr, "<>c__DisplayClass39_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraffitiManager.__c__DisplayClass39_0>.NativeClassPtr);
				GraffitiManager.__c__DisplayClass39_0.NativeFieldInfoPtr_surface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiManager.__c__DisplayClass39_0>.NativeClassPtr, "surface");
				GraffitiManager.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiManager.__c__DisplayClass39_0>.NativeClassPtr, 100672763);
				GraffitiManager.__c__DisplayClass39_0.NativeMethodInfoPtr_Method_Internal_Void_NetworkConnection_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiManager.__c__DisplayClass39_0>.NativeClassPtr, 100672764);
			}

			// Token: 0x0600E12E RID: 57646 RVA: 0x00374F6C File Offset: 0x0037316C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass39_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraffitiManager.__c__DisplayClass39_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiManager.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E12F RID: 57647 RVA: 0x00374FA8 File Offset: 0x003731A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169165, XrefRangeEnd = 169166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_NetworkConnection_PDM_0(NetworkConnection conn)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiManager.__c__DisplayClass39_0.NativeMethodInfoPtr_Method_Internal_Void_NetworkConnection_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E130 RID: 57648 RVA: 0x0006A23D File Offset: 0x0006843D
			public __c__DisplayClass39_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700448B RID: 17547
			// (get) Token: 0x0600E131 RID: 57649 RVA: 0x00374FEC File Offset: 0x003731EC
			// (set) Token: 0x0600E132 RID: 57650 RVA: 0x0006A246 File Offset: 0x00068446
			public unsafe SpraySurface surface
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiManager.__c__DisplayClass39_0.NativeFieldInfoPtr_surface);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpraySurface>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiManager.__c__DisplayClass39_0.NativeFieldInfoPtr_surface), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009942 RID: 39234
			private static readonly IntPtr NativeFieldInfoPtr_surface;

			// Token: 0x04009943 RID: 39235
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009944 RID: 39236
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_NetworkConnection_PDM_0;
		}
	}
}
